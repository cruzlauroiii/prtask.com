namespace WillowMaze.Wasm.Decompiled;


public readonly class GmsVersion {
    public static readonly int VERSION_HALLOUMI = 4100000;
    public static readonly int VERSION_JARLSBERG = 4300000;
    public static readonly int VERSION_KENAFA = 4400000;
    public static readonly int VERSION_LONGHORN = 5000000;
    public static readonly int VERSION_MANCHEGO = 6000000;
    public static readonly int VERSION_ORLA = 7000000;
    public static readonly int VERSION_PARMESAN = 7200000;
    public static readonly int VERSION_QUESO = 7500000;
    public static readonly int VERSION_REBLOCHON = 7800000;
    public static readonly int VERSION_SAGA = 8000000;

    private GmsVersion() {
    }

    public static bool IsAtLeastFenacho(int i) {
        return i >= 3200000;
    }
}

