namespace ImPlot3DNET
{
    [System.Flags]
    public enum ImPlot3DAxisFlags
    {
        None = 0,
        NoLabel = 1,
        NoGridLines = 2,
        NoTickMarks = 4,
        NoTickLabels = 8,
        LockMin = 16,
        LockMax = 32,
        AutoFit = 64,
        Invert = 128,
        PanStretch = 256,
        Lock = 48,
        NoDecorations = 11,
    }
}
