namespace ImPlot3DNET
{
    [System.Flags]
    public enum ImPlot3DFlags
    {
        None = 0,
        NoTitle = 1,
        NoLegend = 2,
        NoMouseText = 4,
        NoClip = 8,
        NoMenus = 16,
        Equal = 32,
        NoRotate = 64,
        NoPan = 128,
        NoZoom = 256,
        NoInputs = 512,
        CanvasOnly = 7,
    }
}
