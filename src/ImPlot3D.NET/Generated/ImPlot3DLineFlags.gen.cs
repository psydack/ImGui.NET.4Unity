namespace ImPlot3DNET
{
    [System.Flags]
    public enum ImPlot3DLineFlags
    {
        None = 0,
        NoLegend = 1,
        NoFit = 2,
        Segments = 1024,
        Loop = 2048,
        SkipNaN = 4096,
    }
}
