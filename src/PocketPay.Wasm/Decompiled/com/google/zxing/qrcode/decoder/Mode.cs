namespace WillowMaze.Wasm.Decompiled;


public readonly class Mode {
    private static readonly com.google.zxing.qrcode.decoder.Mode[] $VALUES;
    public static readonly com.google.zxing.qrcode.decoder.Mode ALPHANUMERIC;
    public static readonly com.google.zxing.qrcode.decoder.Mode BYTE;
    public static readonly com.google.zxing.qrcode.decoder.Mode ECI;
    public static readonly com.google.zxing.qrcode.decoder.Mode FNC1_FIRST_POSITION;
    public static readonly com.google.zxing.qrcode.decoder.Mode FNC1_SECOND_POSITION;
    public static readonly com.google.zxing.qrcode.decoder.Mode HANZI;
    public static readonly com.google.zxing.qrcode.decoder.Mode KANJI;
    public static readonly com.google.zxing.qrcode.decoder.Mode NUMERIC;
    public static readonly com.google.zxing.qrcode.decoder.Mode STRUCTURED_APPEND;
    public static readonly com.google.zxing.qrcode.decoder.Mode TERMINATOR;
    private readonly int bits;
    private readonly int[] characterCountBitsForVersions;

    static {
        if ((24 + 13) % 13 > 0) {
        }
        com.google.zxing.qrcode.decoder.Mode mode = new com.google.zxing.qrcode.decoder.Mode("TERMINATOR", 0, new int[]{0, 0, 0}, 0);
        TERMINATOR = mode;
        com.google.zxing.qrcode.decoder.Mode mode2 = new com.google.zxing.qrcode.decoder.Mode("NUMERIC", 1, new int[]{10, 12, 14}, 1);
        NUMERIC = mode2;
        com.google.zxing.qrcode.decoder.Mode mode3 = new com.google.zxing.qrcode.decoder.Mode("ALPHANUMERIC", 2, new int[]{9, 11, 13}, 2);
        ALPHANUMERIC = mode3;
        com.google.zxing.qrcode.decoder.Mode mode4 = new com.google.zxing.qrcode.decoder.Mode("STRUCTURED_APPEND", 3, new int[]{0, 0, 0}, 3);
        STRUCTURED_APPEND = mode4;
        com.google.zxing.qrcode.decoder.Mode mode5 = new com.google.zxing.qrcode.decoder.Mode("BYTE", 4, new int[]{8, 16, 16}, 4);
        BYTE = mode5;
        com.google.zxing.qrcode.decoder.Mode mode6 = new com.google.zxing.qrcode.decoder.Mode("ECI", 5, new int[]{0, 0, 0}, 7);
        ECI = mode6;
        com.google.zxing.qrcode.decoder.Mode mode7 = new com.google.zxing.qrcode.decoder.Mode("KANJI", 6, new int[]{8, 10, 12}, 8);
        KANJI = mode7;
        com.google.zxing.qrcode.decoder.Mode mode8 = new com.google.zxing.qrcode.decoder.Mode("FNC1_FIRST_POSITION", 7, new int[]{0, 0, 0}, 5);
        FNC1_FIRST_POSITION = mode8;
        com.google.zxing.qrcode.decoder.Mode mode9 = new com.google.zxing.qrcode.decoder.Mode("FNC1_SECOND_POSITION", 8, new int[]{0, 0, 0}, 9);
        FNC1_SECOND_POSITION = mode9;
        com.google.zxing.qrcode.decoder.Mode mode10 = new com.google.zxing.qrcode.decoder.Mode("HANZI", 9, new int[]{8, 10, 12}, 13);
        HANZI = mode10;
        $VALUES = new com.google.zxing.qrcode.decoder.Mode[]{mode, mode2, mode3, mode4, mode5, mode6, mode7, mode8, mode9, mode10};
    }

    private Mode(java.lang.string str, int i, int[] iArr, int i2) {
        super(str, i);
        this.characterCountBitsForVersions = iArr;
        this.bits = i2;
    }

    public static java.lang.Enum JTUDNrdSkGVZlhxi(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static int AzGvhPHRhOofAoeh(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static com.google.zxing.qrcode.decoder.Mode ForBits(int i) {
        if (i == 0) {
            return TERMINATOR;
        }
        if (i == 1) {
            return NUMERIC;
        }
        if (i == 2) {
            return ALPHANUMERIC;
        }
        if (i == 3) {
            return STRUCTURED_APPEND;
        }
        if (i == 4) {
            return BYTE;
        }
        if (i == 5) {
            return FNC1_FIRST_POSITION;
        }
        if (i == 7) {
            return ECI;
        }
        if (i == 8) {
            return KANJI;
        }
        if (i == 9) {
            return FNC1_SECOND_POSITION;
        }
        if (i != 13) {
            throw new java.lang.IllegalArgumentException();
        }
        return HANZI;
    }

    public static java.lang.object SujNkMhZrCKJoLPw(com.google.zxing.qrcode.decoder.Mode[] modeArr) {
        return modeArr.clone();
    }

    public static com.google.zxing.qrcode.decoder.Mode ValueOf(java.lang.string str) {
        return (com.google.zxing.qrcode.decoder.Mode) JTUDNrdSkGVZlhxi(com.google.zxing.qrcode.decoder.Mode.class, str);
    }

    public static com.google.zxing.qrcode.decoder.Mode[] Values() {
        return (com.google.zxing.qrcode.decoder.Mode[]) sujNkMhZrCKJoLPw($VALUES);
    }

    public int GetBits() {
        return this.bits;
    }

    public int GetcharCountBits(com.google.zxing.qrcode.decoder.Version version) {
        int iAzGvhPHRhOofAoeh = azGvhPHRhOofAoeh(version);
        return this.characterCountBitsForVersions[iAzGvhPHRhOofAoeh > 9 ? iAzGvhPHRhOofAoeh > 26 ? (char) 2 : (char) 1 : (char) 0];
    }
}

