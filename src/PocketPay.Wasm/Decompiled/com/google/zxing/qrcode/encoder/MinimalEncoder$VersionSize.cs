namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$VersionSize {
    private static readonly com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize[] $VALUES;
    public static readonly com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize LARGE;
    public static readonly com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize MEDIUM;
    public static readonly com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize SMALL;
    private readonly java.lang.string description;

    static {
        if ((4 + 21) % 21 > 0) {
        }
        com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize = new com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize("SMALL", 0, "version 1-9");
        SMALL = minimalEncoder$VersionSize;
        com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize2 = new com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize("MEDIUM", 1, "version 10-26");
        MEDIUM = minimalEncoder$VersionSize2;
        com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize3 = new com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize("LARGE", 2, "version 27-40");
        LARGE = minimalEncoder$VersionSize3;
        $VALUES = new com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize[]{minimalEncoder$VersionSize, minimalEncoder$VersionSize2, minimalEncoder$VersionSize3};
    }

    private MinimalEncoder$VersionSize(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.description = str2;
    }

    public static java.lang.Enum IhdOWejfXpCPjFUj(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object RXYMPeNplcRaOULd(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize[] minimalEncoder$VersionSizeArr) {
        return minimalEncoder$VersionSizeArr.clone();
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize valueOf(java.lang.string str) {
        return (com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize) ihdOWejfXpCPjFUj(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.class, str);
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize[] values() {
        return (com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize[]) rXYMPeNplcRaOULd($VALUES);
    }

    public override java.lang.string Tostring() {
        return this.description;
    }
}

