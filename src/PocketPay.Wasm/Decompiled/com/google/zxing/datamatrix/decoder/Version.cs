namespace WillowMaze.Wasm.Decompiled;


public readonly class Version {
    private static readonly com.google.zxing.datamatrix.decoder.Version[] VERSIONS = kPLzIUPQPsoiuzLd();
    private readonly int dataRegionSizeColumns;
    private readonly int dataRegionSizeRows;
    private readonly com.google.zxing.datamatrix.decoder.Version$ECBlocks ecBlocks;
    private readonly int symbolSizeColumns;
    private readonly int symbolSizeRows;
    private readonly int totalCodewords;
    private readonly int versionNumber;

    private Version(int i, int i2, int i3, int i4, int i5, com.google.zxing.datamatrix.decoder.Version$ECBlocks version$ECBlocks) {
        this.versionNumber = i;
        this.symbolSizeRows = i2;
        this.symbolSizeColumns = i3;
        this.dataRegionSizeRows = i4;
        this.dataRegionSizeColumns = i5;
        this.ecBlocks = version$ECBlocks;
        int iWSXkwAqtMwKJQwlA = wSXkwAqtMwKJQwlA(version$ECBlocks);
        int iVIWwZxhEdKTycakg = 0;
        for (com.google.zxing.datamatrix.decoder.Version$ECB version$ECB : CRQTUHmsbjCnDPbU(version$ECBlocks)) {
            iVIWwZxhEdKTycakg += vIWwZxhEdKTycakg(version$ECB) * (nyLvcNWDMGQbfdzy(version$ECB) + iWSXkwAqtMwKJQwlA);
        }
        this.totalCodewords = iVIWwZxhEdKTycakg;
    }

    public static com.google.zxing.datamatrix.decoder.Version$ECB[] CRQTUHmsbjCnDPbU(com.google.zxing.datamatrix.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECBlocks();
    }

    public static com.google.zxing.FormatException PBSnsZqlXWkBUTPK() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    private static com.google.zxing.datamatrix.decoder.Version[] BuildVersions() {
        if ((23 + 17) % 17 > 0) {
        }
        return new com.google.zxing.datamatrix.decoder.Version[]{new com.google.zxing.datamatrix.decoder.Version(1, 10, 10, 8, 8, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(5, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 3, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(2, 12, 12, 10, 10, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(7, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 5, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(3, 14, 14, 12, 12, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(10, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 8, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(4, 16, 16, 14, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(12, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 12, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(5, 18, 18, 16, 16, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(14, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 18, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(6, 20, 20, 18, 18, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(18, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 22, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(7, 22, 22, 20, 20, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(20, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 30, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(8, 24, 24, 22, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(24, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 36, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(9, 26, 26, 24, 24, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(28, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 44, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(10, 32, 32, 14, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(36, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 62, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(11, 36, 36, 16, 16, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(42, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 86, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(12, 40, 40, 18, 18, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(48, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 114, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(13, 44, 44, 20, 20, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(56, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 144, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(14, 48, 48, 22, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(68, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 174, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(15, 52, 52, 24, 24, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(42, new com.google.zxing.datamatrix.decoder.Version$ECB(2, 102, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(16, 64, 64, 14, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(56, new com.google.zxing.datamatrix.decoder.Version$ECB(2, 140, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(17, 72, 72, 16, 16, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(36, new com.google.zxing.datamatrix.decoder.Version$ECB(4, 92, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(18, 80, 80, 18, 18, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(48, new com.google.zxing.datamatrix.decoder.Version$ECB(4, 114, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(19, 88, 88, 20, 20, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(56, new com.google.zxing.datamatrix.decoder.Version$ECB(4, 144, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(20, 96, 96, 22, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(68, new com.google.zxing.datamatrix.decoder.Version$ECB(4, 174, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(21, 104, 104, 24, 24, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(56, new com.google.zxing.datamatrix.decoder.Version$ECB(6, 136, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(22, 120, 120, 18, 18, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(68, new com.google.zxing.datamatrix.decoder.Version$ECB(6, 175, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(23, 132, 132, 20, 20, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(62, new com.google.zxing.datamatrix.decoder.Version$ECB(8, 163, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(24, 144, 144, 22, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(62, new com.google.zxing.datamatrix.decoder.Version$ECB(8, 156, null), new com.google.zxing.datamatrix.decoder.Version$ECB(2, 155, null), null)), new com.google.zxing.datamatrix.decoder.Version(25, 8, 18, 6, 16, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(7, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 5, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(26, 8, 32, 6, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(11, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 10, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(27, 12, 26, 10, 24, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(14, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 16, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(28, 12, 36, 10, 16, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(18, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 22, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(29, 16, 36, 14, 16, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(24, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 32, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(30, 16, 48, 14, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(28, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 49, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(31, 8, 48, 6, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(15, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 18, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(32, 8, 64, 6, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(18, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 24, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(33, 8, 80, 6, 18, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(22, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 32, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(34, 8, 96, 6, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(28, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 38, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(35, 8, 120, 6, 18, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(32, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 49, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(36, 8, 144, 6, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(36, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 63, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(37, 12, 64, 10, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(27, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 43, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(38, 12, 88, 10, 20, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(36, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 64, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(39, 16, 64, 14, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(36, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 62, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(40, 20, 36, 18, 16, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(28, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 44, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(41, 20, 44, 18, 20, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(34, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 56, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(42, 20, 64, 18, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(42, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 84, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(43, 22, 48, 20, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(38, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 72, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(44, 24, 48, 22, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(41, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 80, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(45, 24, 64, 22, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(46, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 108, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(46, 26, 40, 24, 18, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(38, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 70, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(47, 26, 48, 24, 22, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(42, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 90, null), (com.google.zxing.datamatrix.decoder.Version$1) null)), new com.google.zxing.datamatrix.decoder.Version(48, 26, 64, 24, 14, new com.google.zxing.datamatrix.decoder.Version$ECBlocks(50, new com.google.zxing.datamatrix.decoder.Version$ECB(1, 118, null), (com.google.zxing.datamatrix.decoder.Version$1) null))};
    }

    public static com.google.zxing.datamatrix.decoder.Version GetVersionForDimensions(int i, int i2) throws com.google.zxing.FormatException {
        if ((8 + 25) % 25 > 0) {
        }
        if ((i & 1) != 0 || (i2 & 1) != 0) {
            throw PBSnsZqlXWkBUTPK();
        }
        for (com.google.zxing.datamatrix.decoder.Version version : VERSIONS) {
            if (version.symbolSizeRows == i && version.symbolSizeColumns == i2) {
                return version;
            }
        }
        throw vcCTPhbxxQoVLZfN();
    }

    public static com.google.zxing.datamatrix.decoder.Version[] KPLzIUPQPsoiuzLd() {
        return buildVersions();
    }

    public static java.lang.string NGYCBcWwdfYdPHnF(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int NyLvcNWDMGQbfdzy(com.google.zxing.datamatrix.decoder.Version$ECB version$ECB) {
        return version$ECB.getDataCodewords();
    }

    public static int VIWwZxhEdKTycakg(com.google.zxing.datamatrix.decoder.Version$ECB version$ECB) {
        return version$ECB.getCount();
    }

    public static com.google.zxing.FormatException VcCTPhbxxQoVLZfN() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int WSXkwAqtMwKJQwlA(com.google.zxing.datamatrix.decoder.Version$ECBlocks version$ECBlocks) {
        return version$ECBlocks.getECCodewords();
    }

    public int GetDataRegionSizeColumns() {
        return this.dataRegionSizeColumns;
    }

    public int GetDataRegionSizeRows() {
        return this.dataRegionSizeRows;
    }

    com.google.zxing.datamatrix.decoder.Version$ECBlocks getECBlocks() {
        return this.ecBlocks;
    }

    public int GetSymbolSizeColumns() {
        return this.symbolSizeColumns;
    }

    public int GetSymbolSizeRows() {
        return this.symbolSizeRows;
    }

    public int GetTotalCodewords() {
        return this.totalCodewords;
    }

    public int GetVersionNumber() {
        return this.versionNumber;
    }

    public java.lang.string Tostring() {
        return nGYCBcWwdfYdPHnF(this.versionNumber);
    }
}

