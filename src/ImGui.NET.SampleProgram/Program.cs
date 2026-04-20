using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using ImGuizmoNET;
using imnodesNET;
using ImPlotNET;
using System.Runtime.CompilerServices;
using TestDotNetStandardLib;
using Veldrid;
using Veldrid.Sdl2;
using Veldrid.StartupUtilities;

using static ImGuiNET.ImGuiNative;

namespace ImGuiNET
{
    class Program
    {
        private static Sdl2Window _window;
        private static GraphicsDevice _gd;
        private static CommandList _cl;
        private static ImGuiController _controller;
        // private static MemoryEditor _memoryEditor;

        // UI state
        private static float _f = 0.0f;
        private static int _counter = 0;
        private static int _dragInt = 0;
        private static Vector3 _clearColor = new Vector3(0.45f, 0.55f, 0.6f);
        private static bool _showImGuiDemoWindow = true;
        private static bool _showAnotherWindow = false;
        private static bool _showMemoryEditor = false;
        private static bool _showImPlotWindow = true;
        private static bool _showImGuizmoWindow = true;
        private static bool _showImNodesWindow = true;

        // ImPlot state
        private static readonly float[] _sinData = Enumerable.Range(0, 100).Select(i => (float)Math.Sin(i * 0.1)).ToArray();

        // ImGuizmo state
        private static float[] _gizmoView = new float[16];
        private static float[] _gizmoProjection = new float[16];
        private static float[] _gizmoMatrix = new float[16];

        // ImNodes state
        private static int _imNodesLink0Start = 1;
        private static int _imNodesLink0End = 2;
        private static byte[] _memoryEditorData;
        private static uint s_tab_bar_flags = (uint)ImGuiTabBarFlags.Reorderable;
        static bool[] s_opened = { true, true, true, true }; // Persistent user state

        static void SetThing(out float i, float val) { i = val; }

        private static void InitGizmoMatrices()
        {
            // Identity model matrix
            _gizmoMatrix[0] = 1; _gizmoMatrix[5] = 1; _gizmoMatrix[10] = 1; _gizmoMatrix[15] = 1;

            // Simple lookat view matrix (camera at (2,2,5) looking at origin)
            var eye = new Vector3(2f, 2f, 5f);
            var center = Vector3.Zero;
            var up = Vector3.UnitY;
            var z = Vector3.Normalize(eye - center);
            var x = Vector3.Normalize(Vector3.Cross(up, z));
            var y = Vector3.Cross(z, x);
            _gizmoView[0]  = x.X; _gizmoView[1]  = y.X; _gizmoView[2]  = z.X; _gizmoView[3]  = 0;
            _gizmoView[4]  = x.Y; _gizmoView[5]  = y.Y; _gizmoView[6]  = z.Y; _gizmoView[7]  = 0;
            _gizmoView[8]  = x.Z; _gizmoView[9]  = y.Z; _gizmoView[10] = z.Z; _gizmoView[11] = 0;
            _gizmoView[12] = -Vector3.Dot(x, eye); _gizmoView[13] = -Vector3.Dot(y, eye); _gizmoView[14] = -Vector3.Dot(z, eye); _gizmoView[15] = 1;

            // Simple perspective projection
            float fovY = (float)(Math.PI / 4.0);
            float aspect = 1280f / 720f;
            float near = 0.1f; float far = 100f;
            float f = 1f / (float)Math.Tan(fovY / 2f);
            _gizmoProjection[0]  = f / aspect;
            _gizmoProjection[5]  = f;
            _gizmoProjection[10] = (far + near) / (near - far);
            _gizmoProjection[11] = -1f;
            _gizmoProjection[14] = (2f * far * near) / (near - far);
        }

        static void Main(string[] args)
        {
            // Create window, GraphicsDevice, and all resources necessary for the demo.
            VeldridStartup.CreateWindowAndGraphicsDevice(
                new WindowCreateInfo(50, 50, 1280, 720, WindowState.Normal, "ImGui.NET Sample Program"),
                new GraphicsDeviceOptions(true, null, true, ResourceBindingModel.Improved, true, true),
                out _window,
                out _gd);
            _window.Resized += () =>
            {
                _gd.MainSwapchain.Resize((uint)_window.Width, (uint)_window.Height);
                _controller.WindowResized(_window.Width, _window.Height);
            };
            _cl = _gd.ResourceFactory.CreateCommandList();
            _controller = new ImGuiController(_gd, _gd.MainSwapchain.Framebuffer.OutputDescription, _window.Width, _window.Height);
            // _memoryEditor = new MemoryEditor();

            IntPtr imGuiContext = ImGui.GetCurrentContext();
            ImPlot.CreateContext();
            ImPlot.SetImGuiContext(imGuiContext);
            imnodes.CreateContext();
            imnodes.SetImGuiContext(imGuiContext);
            ImGuizmo.SetImGuiContext(imGuiContext);
            InitGizmoMatrices();

            Random random = new Random();
            _memoryEditorData = Enumerable.Range(0, 1024).Select(i => (byte)random.Next(255)).ToArray();

            var stopwatch = Stopwatch.StartNew();
            float deltaTime = 0f;
            // Main application loop
            while (_window.Exists)
            {
                deltaTime = stopwatch.ElapsedTicks / (float)Stopwatch.Frequency;
                stopwatch.Restart();
                InputSnapshot snapshot = _window.PumpEvents();
                if (!_window.Exists) { break; }
                _controller.Update(deltaTime, snapshot); // Feed the input events to our ImGui controller, which passes them through to ImGui.

                SubmitUI();

                _cl.Begin();
                _cl.SetFramebuffer(_gd.MainSwapchain.Framebuffer);
                _cl.ClearColorTarget(0, new RgbaFloat(_clearColor.X, _clearColor.Y, _clearColor.Z, 1f));
                _controller.Render(_gd, _cl);
                _cl.End();
                _gd.SubmitCommands(_cl);
                _gd.SwapBuffers(_gd.MainSwapchain);
            }

            // Clean up Veldrid resources
            _gd.WaitForIdle();
            _controller.Dispose();
            _cl.Dispose();
            _gd.Dispose();

            imnodes.DestroyContext();
            ImPlot.DestroyContext();
        }

        private static unsafe void SubmitUI()
        {
            // Demo code adapted from the official Dear ImGui demo program:
            // https://github.com/ocornut/imgui/blob/master/examples/example_win32_directx11/main.cpp#L172

            // 1. Show a simple window.
            // Tip: if we don't call ImGui.Begin(string) / ImGui.End() the widgets automatically appears in a window called "Debug".
            {
                ImGui.Text("");
                ImGui.Text(string.Empty);
                ImGui.Text("Hello, world!");                                        // Display some text (you can use a format string too)
                ImGui.SliderFloat("float", ref _f, 0, 1, _f.ToString("0.000"));  // Edit 1 float using a slider from 0.0f to 1.0f    
                //ImGui.ColorEdit3("clear color", ref _clearColor);                   // Edit 3 floats representing a color

                ImGui.Text($"Mouse position: {ImGui.GetMousePos()}");

                ImGui.Checkbox("ImGui Demo Window", ref _showImGuiDemoWindow);
                ImGui.Checkbox("Another Window", ref _showAnotherWindow);
                ImGui.Checkbox("Memory Editor", ref _showMemoryEditor);
                ImGui.Checkbox("ImPlot Demo", ref _showImPlotWindow);
                ImGui.Checkbox("ImGuizmo Demo", ref _showImGuizmoWindow);
                ImGui.Checkbox("ImNodes Demo", ref _showImNodesWindow);
                if (ImGui.Button("Button"))                                         // Buttons return true when clicked (NB: most widgets return true when edited/activated)
                    _counter++;
                ImGui.SameLine(0, -1);
                ImGui.Text($"counter = {_counter}");

                ImGui.DragInt("Draggable Int", ref _dragInt);

                float framerate = ImGui.GetIO().Framerate;
                ImGui.Text($"Application average {1000.0f / framerate:0.##} ms/frame ({framerate:0.#} FPS)");
            }

            // 2. Show another simple window. In most cases you will use an explicit Begin/End pair to name your windows.
            if (_showAnotherWindow)
            {
                ImGui.Begin("Another Window", ref _showAnotherWindow);
                ImGui.Text("Hello from another window!");
                if (ImGui.Button("Close Me"))
                    _showAnotherWindow = false;
                ImGui.End();
            }

            // 3. Show the ImGui demo window. Most of the sample code is in ImGui.ShowDemoWindow(). Read its code to learn more about Dear ImGui!
            if (_showImGuiDemoWindow)
            {
                // Normally user code doesn't need/want to call this because positions are saved in .ini file anyway.
                // Here we just want to make the demo initial state a bit more friendly!
                ImGui.SetNextWindowPos(new Vector2(650, 20), ImGuiCond.FirstUseEver);
                ImGui.ShowDemoWindow(ref _showImGuiDemoWindow);
            }
            
            if (ImGui.TreeNode("Tabs"))
            {
                if (ImGui.TreeNode("Basic"))
                {
                    ImGuiTabBarFlags tab_bar_flags = ImGuiTabBarFlags.None;
                    if (ImGui.BeginTabBar("MyTabBar", tab_bar_flags))
                    {
                        if (ImGui.BeginTabItem("Avocado"))
                        {
                            ImGui.Text("This is the Avocado tab!\nblah blah blah blah blah");
                            ImGui.EndTabItem();
                        }
                        if (ImGui.BeginTabItem("Broccoli"))
                        {
                            ImGui.Text("This is the Broccoli tab!\nblah blah blah blah blah");
                            ImGui.EndTabItem();
                        }
                        if (ImGui.BeginTabItem("Cucumber"))
                        {
                            ImGui.Text("This is the Cucumber tab!\nblah blah blah blah blah");
                            ImGui.EndTabItem();
                        }
                        ImGui.EndTabBar();
                    }
                    ImGui.Separator();
                    ImGui.TreePop();
                }

                if (ImGui.TreeNode("Advanced & Close Button"))
                {
                    // Expose a couple of the available flags. In most cases you may just call BeginTabBar() with no flags (0).
                    ImGui.CheckboxFlags("ImGuiTabBarFlags_Reorderable", ref s_tab_bar_flags, (uint)ImGuiTabBarFlags.Reorderable);
                    ImGui.CheckboxFlags("ImGuiTabBarFlags_AutoSelectNewTabs", ref s_tab_bar_flags, (uint)ImGuiTabBarFlags.AutoSelectNewTabs);
                    ImGui.CheckboxFlags("ImGuiTabBarFlags_NoCloseWithMiddleMouseButton", ref s_tab_bar_flags, (uint)ImGuiTabBarFlags.NoCloseWithMiddleMouseButton);
                    if ((s_tab_bar_flags & (uint)ImGuiTabBarFlags.FittingPolicyMask) == 0)
                        s_tab_bar_flags |= (uint)ImGuiTabBarFlags.FittingPolicyDefault;
                    if (ImGui.CheckboxFlags("ImGuiTabBarFlags_FittingPolicyShrink", ref s_tab_bar_flags, (uint)ImGuiTabBarFlags.FittingPolicyShrink))
                        s_tab_bar_flags &= ~((uint)ImGuiTabBarFlags.FittingPolicyMask ^ (uint)ImGuiTabBarFlags.FittingPolicyShrink);
                    if (ImGui.CheckboxFlags("ImGuiTabBarFlags_FittingPolicyScroll", ref s_tab_bar_flags, (uint)ImGuiTabBarFlags.FittingPolicyScroll))
                        s_tab_bar_flags &= ~((uint)ImGuiTabBarFlags.FittingPolicyMask ^ (uint)ImGuiTabBarFlags.FittingPolicyScroll);

                    // Tab Bar
                    string[] names = { "Artichoke", "Beetroot", "Celery", "Daikon" };

                    for (int n = 0; n < s_opened.Length; n++)
                    {
                        if (n > 0) { ImGui.SameLine(); }
                        ImGui.Checkbox(names[n], ref s_opened[n]);
                    }

                    // Passing a bool* to BeginTabItem() is similar to passing one to Begin(): the underlying bool will be set to false when the tab is closed.
                    if (ImGui.BeginTabBar("MyTabBar", (ImGuiTabBarFlags)s_tab_bar_flags))
                    {
                        for (int n = 0; n < s_opened.Length; n++)
                            if (s_opened[n] && ImGui.BeginTabItem(names[n], ref s_opened[n]))
                            {
                                ImGui.Text($"This is the {names[n]} tab!");
                                if ((n & 1) != 0)
                                    ImGui.Text("I am an odd tab.");
                                ImGui.EndTabItem();
                            }
                        ImGui.EndTabBar();
                    }
                    ImGui.Separator();
                    ImGui.TreePop();
                }
                ImGui.TreePop();
            }

            if (_showImPlotWindow)
            {
                ImGui.Begin("ImPlot Demo", ref _showImPlotWindow);
                if (ImPlot.BeginPlot("Sin Wave"))
                {
                    ImPlot.SetupAxes("x", "y");
                    float[] data = _sinData;
                    ImPlot.PlotLine("sin(x)", ref data[0], data.Length);
                    ImPlot.EndPlot();
                }
                ImGui.End();
            }

            if (_showImGuizmoWindow)
            {
                ImGui.Begin("ImGuizmo Demo", ref _showImGuizmoWindow);
                ImGuizmo.BeginFrame();
                var pos = ImGui.GetWindowPos();
                var size = ImGui.GetWindowSize();
                ImGuizmo.SetRect(pos.X, pos.Y, size.X, size.Y);
                ImGuizmo.Manipulate(ref _gizmoView[0], ref _gizmoProjection[0], OPERATION.TRANSLATE, MODE.LOCAL, ref _gizmoMatrix[0]);
                ImGuizmo.DrawGrid(ref _gizmoView[0], ref _gizmoProjection[0], ref _gizmoMatrix[0], 10f);
                ImGui.End();
            }

            if (_showImNodesWindow)
            {
                ImGui.Begin("ImNodes Demo", ref _showImNodesWindow);
                imnodes.BeginNodeEditor();

                imnodes.BeginNode(1);
                imnodes.BeginNodeTitleBar();
                ImGui.TextUnformatted("Node A");
                imnodes.EndNodeTitleBar();
                imnodes.BeginOutputAttribute(_imNodesLink0Start);
                ImGui.Text("Output");
                imnodes.EndOutputAttribute();
                imnodes.EndNode();

                imnodes.BeginNode(2);
                imnodes.BeginNodeTitleBar();
                ImGui.TextUnformatted("Node B");
                imnodes.EndNodeTitleBar();
                imnodes.BeginInputAttribute(_imNodesLink0End);
                ImGui.Text("Input");
                imnodes.EndInputAttribute();
                imnodes.EndNode();

                imnodes.Link(0, _imNodesLink0Start, _imNodesLink0End);
                imnodes.EndNodeEditor();
                ImGui.End();
            }

            ImGuiIOPtr io = ImGui.GetIO();
            SetThing(out io.DeltaTime, 2f);

            if (_showMemoryEditor)
            {
                ImGui.Text("Memory editor currently supported.");
                // _memoryEditor.Draw("Memory Editor", _memoryEditorData, _memoryEditorData.Length);
            }
            
            // ReadOnlySpan<char> and .NET Standard 2.0 tests
            TestStringParameterOnDotNetStandard.Text(); // String overloads should always be available.
            
            // On .NET Standard 2.1 or greater, you can use ReadOnlySpan<char> instead of string to prevent allocations.
            long allocBytesStringStart = GC.GetAllocatedBytesForCurrentThread();
            ImGui.Text($"Hello, world {Random.Shared.Next(100)}!");
            long allocBytesStringEnd = GC.GetAllocatedBytesForCurrentThread() - allocBytesStringStart;
            Console.WriteLine("GC (string): " + allocBytesStringEnd);
                
            long allocBytesSpanStart = GC.GetAllocatedBytesForCurrentThread();
            ImGui.Text($"Hello, world {Random.Shared.Next(100)}!".AsSpan()); // Note that this call will STILL allocate memory due to string interpolation, but you can prevent that from happening by using an InterpolatedStringHandler.
            long allocBytesSpanEnd = GC.GetAllocatedBytesForCurrentThread() - allocBytesSpanStart;
            Console.WriteLine("GC (span): " + allocBytesSpanEnd);
            
            ImGui.Text("Empty span:");
            ImGui.SameLine();
            ImGui.GetWindowDrawList().AddText(ImGui.GetCursorScreenPos(), uint.MaxValue, ReadOnlySpan<char>.Empty);
            ImGui.NewLine();
            ImGui.GetWindowDrawList().AddText(ImGui.GetCursorScreenPos(), uint.MaxValue, $"{ImGui.CalcTextSize("h")}");
            ImGui.NewLine();
            ImGui.TextUnformatted("TextUnformatted now passes end ptr but isn't cut off");
        }
    }
}
