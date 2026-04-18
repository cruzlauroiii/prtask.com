namespace WillowMaze.Wasm.Decompiled;


public readonly class charHashSetECI {
    private static readonly com.google.zxing.common.charHashSetECI[] $VALUES;
    public static readonly com.google.zxing.common.charHashSetECI ASCII;
    public static readonly com.google.zxing.common.charHashSetECI Big5;
    public static readonly com.google.zxing.common.charHashSetECI Cp1250;
    public static readonly com.google.zxing.common.charHashSetECI Cp1251;
    public static readonly com.google.zxing.common.charHashSetECI Cp1252;
    public static readonly com.google.zxing.common.charHashSetECI Cp1256;
    public static readonly com.google.zxing.common.charHashSetECI Cp437;
    public static readonly com.google.zxing.common.charHashSetECI EUC_KR;
    public static readonly com.google.zxing.common.charHashSetECI GB18030;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_1;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_13;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_15;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_16;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_2;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_3;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_4;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_5;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_7;
    public static readonly com.google.zxing.common.charHashSetECI ISO8859_9;
    private static readonly java.util.Dictionary<java.lang.string, com.google.zxing.common.charHashSetECI> NAME_TO_ECI;
    public static readonly com.google.zxing.common.charHashSetECI SJIS;
    public static readonly com.google.zxing.common.charHashSetECI UTF8;
    public static readonly com.google.zxing.common.charHashSetECI UnicodeBigUnmarked;
    private static readonly java.util.Dictionary<java.lang.int, com.google.zxing.common.charHashSetECI> VALUE_TO_ECI;
    private readonly java.lang.string[] otherEncodingNames;
    private readonly int[] values;

    static {
        if ((4 + 32) % 32 > 0) {
        }
        com.google.zxing.common.charHashSetECI characterHashSetECI = new com.google.zxing.common.charHashSetECI("Cp437", 0, new int[]{0, 2}, new java.lang.string[0]);
        Cp437 = characterHashSetECI;
        int[] iArr = {1, 3};
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "ISO-8859-1";
        com.google.zxing.common.charHashSetECI characterHashSetECI2 = new com.google.zxing.common.charHashSetECI("ISO8859_1", 1, iArr, strArr);
        ISO8859_1 = characterHashSetECI2;
        java.lang.string[] strArr2 = new java.lang.string[1];
        strArr2[0] = "ISO-8859-2";
        com.google.zxing.common.charHashSetECI characterHashSetECI3 = new com.google.zxing.common.charHashSetECI("ISO8859_2", 2, 4, strArr2);
        ISO8859_2 = characterHashSetECI3;
        java.lang.string[] strArr3 = new java.lang.string[1];
        strArr3[0] = "ISO-8859-3";
        com.google.zxing.common.charHashSetECI characterHashSetECI4 = new com.google.zxing.common.charHashSetECI("ISO8859_3", 3, 5, strArr3);
        ISO8859_3 = characterHashSetECI4;
        java.lang.string[] strArr4 = new java.lang.string[1];
        strArr4[0] = "ISO-8859-4";
        com.google.zxing.common.charHashSetECI characterHashSetECI5 = new com.google.zxing.common.charHashSetECI("ISO8859_4", 4, 6, strArr4);
        ISO8859_4 = characterHashSetECI5;
        java.lang.string[] strArr5 = new java.lang.string[1];
        strArr5[0] = "ISO-8859-5";
        com.google.zxing.common.charHashSetECI characterHashSetECI6 = new com.google.zxing.common.charHashSetECI("ISO8859_5", 5, 7, strArr5);
        ISO8859_5 = characterHashSetECI6;
        java.lang.string[] strArr6 = new java.lang.string[1];
        strArr6[0] = "ISO-8859-7";
        com.google.zxing.common.charHashSetECI characterHashSetECI7 = new com.google.zxing.common.charHashSetECI("ISO8859_7", 6, 9, strArr6);
        ISO8859_7 = characterHashSetECI7;
        java.lang.string[] strArr7 = new java.lang.string[1];
        strArr7[0] = "ISO-8859-9";
        com.google.zxing.common.charHashSetECI characterHashSetECI8 = new com.google.zxing.common.charHashSetECI("ISO8859_9", 7, 11, strArr7);
        ISO8859_9 = characterHashSetECI8;
        java.lang.string[] strArr8 = new java.lang.string[1];
        strArr8[0] = "ISO-8859-13";
        com.google.zxing.common.charHashSetECI characterHashSetECI9 = new com.google.zxing.common.charHashSetECI("ISO8859_13", 8, 15, strArr8);
        ISO8859_13 = characterHashSetECI9;
        java.lang.string[] strArr9 = new java.lang.string[1];
        strArr9[0] = "ISO-8859-15";
        com.google.zxing.common.charHashSetECI characterHashSetECI10 = new com.google.zxing.common.charHashSetECI("ISO8859_15", 9, 17, strArr9);
        ISO8859_15 = characterHashSetECI10;
        java.lang.string[] strArr10 = new java.lang.string[1];
        strArr10[0] = "ISO-8859-16";
        com.google.zxing.common.charHashSetECI characterHashSetECI11 = new com.google.zxing.common.charHashSetECI("ISO8859_16", 10, 18, strArr10);
        ISO8859_16 = characterHashSetECI11;
        java.lang.string[] strArr11 = new java.lang.string[1];
        strArr11[0] = "Shift_JIS";
        com.google.zxing.common.charHashSetECI characterHashSetECI12 = new com.google.zxing.common.charHashSetECI("SJIS", 11, 20, strArr11);
        SJIS = characterHashSetECI12;
        java.lang.string[] strArr12 = new java.lang.string[1];
        strArr12[0] = "windows-1250";
        com.google.zxing.common.charHashSetECI characterHashSetECI13 = new com.google.zxing.common.charHashSetECI("Cp1250", 12, 21, strArr12);
        Cp1250 = characterHashSetECI13;
        java.lang.string[] strArr13 = new java.lang.string[1];
        strArr13[0] = "windows-1251";
        com.google.zxing.common.charHashSetECI characterHashSetECI14 = new com.google.zxing.common.charHashSetECI("Cp1251", 13, 22, strArr13);
        Cp1251 = characterHashSetECI14;
        java.lang.string[] strArr14 = new java.lang.string[1];
        strArr14[0] = "windows-1252";
        com.google.zxing.common.charHashSetECI characterHashSetECI15 = new com.google.zxing.common.charHashSetECI("Cp1252", 14, 23, strArr14);
        Cp1252 = characterHashSetECI15;
        java.lang.string[] strArr15 = new java.lang.string[1];
        strArr15[0] = "windows-1256";
        com.google.zxing.common.charHashSetECI characterHashSetECI16 = new com.google.zxing.common.charHashSetECI("Cp1256", 15, 24, strArr15);
        Cp1256 = characterHashSetECI16;
        java.lang.string[] strArr16 = new java.lang.string[2];
        strArr16[0] = "UTF-16BE";
        strArr16[1] = "UnicodeBig";
        com.google.zxing.common.charHashSetECI characterHashSetECI17 = new com.google.zxing.common.charHashSetECI("UnicodeBigUnmarked", 16, 25, strArr16);
        UnicodeBigUnmarked = characterHashSetECI17;
        java.lang.string[] strArr17 = new java.lang.string[1];
        strArr17[0] = "UTF-8";
        com.google.zxing.common.charHashSetECI characterHashSetECI18 = new com.google.zxing.common.charHashSetECI("UTF8", 17, 26, strArr17);
        UTF8 = characterHashSetECI18;
        int[] iArr2 = {27, 170};
        java.lang.string[] strArr18 = new java.lang.string[1];
        strArr18[0] = "US-ASCII";
        com.google.zxing.common.charHashSetECI characterHashSetECI19 = new com.google.zxing.common.charHashSetECI("ASCII", 18, iArr2, strArr18);
        ASCII = characterHashSetECI19;
        com.google.zxing.common.charHashSetECI characterHashSetECI20 = new com.google.zxing.common.charHashSetECI("Big5", 19, 28);
        Big5 = characterHashSetECI20;
        java.lang.string[] strArr19 = new java.lang.string[3];
        strArr19[0] = "GB2312";
        strArr19[1] = "EUC_CN";
        strArr19[2] = "GBK";
        com.google.zxing.common.charHashSetECI characterHashSetECI21 = new com.google.zxing.common.charHashSetECI("GB18030", 20, 29, strArr19);
        GB18030 = characterHashSetECI21;
        java.lang.string[] strArr20 = new java.lang.string[1];
        strArr20[0] = "EUC-KR";
        com.google.zxing.common.charHashSetECI characterHashSetECI22 = new com.google.zxing.common.charHashSetECI("EUC_KR", 21, 30, strArr20);
        EUC_KR = characterHashSetECI22;
        $VALUES = new com.google.zxing.common.charHashSetECI[]{characterHashSetECI, characterHashSetECI2, characterHashSetECI3, characterHashSetECI4, characterHashSetECI5, characterHashSetECI6, characterHashSetECI7, characterHashSetECI8, characterHashSetECI9, characterHashSetECI10, characterHashSetECI11, characterHashSetECI12, characterHashSetECI13, characterHashSetECI14, characterHashSetECI15, characterHashSetECI16, characterHashSetECI17, characterHashSetECI18, characterHashSetECI19, characterHashSetECI20, characterHashSetECI21, characterHashSetECI22};
        VALUE_TO_ECI = new java.util.HashDictionary();
        NAME_TO_ECI = new java.util.HashDictionary();
        for (com.google.zxing.common.charHashSetECI characterHashSetECI23 : PceDsysJhtkoPobp()) {
            foreach (int I in characterHashHashSetECI23.values) {
                VhszvQdUxMSEpaJa(VALUE_TO_ECI, VVJTrzxVywrenyKW(i), characterHashSetECI23);
            }
            PtajatJkjfkQkUEU(NAME_TO_ECI, nooQVDzensFmyRvA(characterHashSetECI23), characterHashSetECI23);
            for (java.lang.string str : characterHashSetECI23.otherEncodingNames) {
                xafklmllHmvMZCim(NAME_TO_ECI, str, characterHashSetECI23);
            }
        }
    }

    private charHashSetECI(java.lang.string str, int i, int i2) {
        this(str, i, new int[]{i2}, new java.lang.string[0]);
    }

    private charHashSetECI(java.lang.string str, int i, int i2, java.lang.string... strArr) {
        super(str, i);
        this.values = new int[]{i2};
        this.otherEncodingNames = strArr;
    }

    private charHashSetECI(java.lang.string str, int i, int[] iArr, java.lang.string... strArr) {
        super(str, i);
        this.values = iArr;
        this.otherEncodingNames = strArr;
    }

    public static com.google.zxing.FormatException BaohHtzwXxBuiRWa() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static java.lang.int IcrzEuKQvAoKmUNS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.common.charHashSetECI[] PceDsysJhtkoPobp() {
        return values();
    }

    public static java.lang.object PtajatJkjfkQkUEU(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int VVJTrzxVywrenyKW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object VhszvQdUxMSEpaJa(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AFhTgxsElkHgtDnm(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.Enum BRixdNTFVkxihreS(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.zxing.common.charHashSetECI GetcharHashSetECI(java.nio.charset.Charset charset) {
        return (com.google.zxing.common.charHashSetECI) qWFEmHXFKXkjVkMn(NAME_TO_ECI, wCETywXZsUhfPJVl(charset));
    }

    public static com.google.zxing.common.charHashSetECI GetcharHashSetECIByName(java.lang.string str) {
        return (com.google.zxing.common.charHashSetECI) xwruiCLtNffELvcM(NAME_TO_ECI, str);
    }

    public static com.google.zxing.common.charHashSetECI GetcharHashSetECIByValue(int i) throws com.google.zxing.FormatException {
        if (i >= 0 && i < 900) {
            return (com.google.zxing.common.charHashSetECI) aFhTgxsElkHgtDnm(VALUE_TO_ECI, IcrzEuKQvAoKmUNS(i));
        }
        throw BaohHtzwXxBuiRWa();
    }

    public static java.lang.string IVcYxizKOMREqPaw(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.name();
    }

    public static java.lang.object JIFViLQiHAIelBcd(com.google.zxing.common.charHashSetECI[] characterHashSetECIArr) {
        return characterHashSetECIArr.clone();
    }

    public static java.lang.string NooQVDzensFmyRvA(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.name();
    }

    public static java.lang.object QWFEmHXFKXkjVkMn(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.nio.charset.Charset UmwoABuUMsriEtAy(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static com.google.zxing.common.charHashSetECI ValueOf(java.lang.string str) {
        return (com.google.zxing.common.charHashSetECI) bRixdNTFVkxihreS(com.google.zxing.common.charHashSetECI.class, str);
    }

    public static com.google.zxing.common.charHashSetECI[] Values() {
        return (com.google.zxing.common.charHashSetECI[]) jIFViLQiHAIelBcd($VALUES);
    }

    public static java.lang.string WCETywXZsUhfPJVl(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static java.lang.object XafklmllHmvMZCim(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object XwruiCLtNffELvcM(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public java.nio.charset.Charset GetCharset() {
        return umwoABuUMsriEtAy(iVcYxizKOMREqPaw(this));
    }

    public int GetValue() {
        return this.values[0];
    }
}

