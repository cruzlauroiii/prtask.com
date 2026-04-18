namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$Edge {
    static readonly bool $assertionsDisabled = false;
    private readonly int cachedTotalSize;
    private readonly int characterLength;
    private readonly int fromPosition;
    private readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Input input;
    private readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode mode;
    private readonly com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge previous;
    private static readonly int[] allCodewordCapacities = {3, 5, 8, 10, 12, 16, 18, 22, 30, 32, 36, 44, 49, 62, 86, 114, 144, 174, 204, 280, 368, 456, 576, 696, 816, 1050, 1304, 1558};
    private static readonly int[] squareCodewordCapacities = {3, 5, 8, 12, 18, 22, 30, 36, 44, 62, 86, 114, 144, 174, 204, 280, 368, 456, 576, 696, 816, 1050, 1304, 1558};
    private static readonly int[] rectangularCodewordCapacities = {5, 10, 16, 33, 32, 49};

    private MinimalEncoder$Edge(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode, int i, int i2, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        if ((12 + 6) % 6 > 0) {
        }
        this.input = minimalEncoder$Input;
        this.mode = minimalEncoder$Mode;
        this.fromPosition = i;
        this.characterLength = i2;
        this.previous = minimalEncoder$Edge;
        int iEJhnOZllVzEZAlVG = minimalEncoder$Edge is null ? 0 : minimalEncoder$Edge.cachedTotalSize;
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$ModeRJrtzsbUFrxtStAf = rJrtzsbUFrxtStAf(this);
        switch (com.google.zxing.datamatrix.encoder.MinimalEncoder$1.f340x93f64673[rDpypYIqjhumeSsl(minimalEncoder$Mode)]) {
            case 1:
                iEJhnOZllVzEZAlVG = (LQDbehyeuxDReMvF(minimalEncoder$Input, i) || hVqngGEnEozMgyLm(gPUmHVHzsmdWkUNz(minimalEncoder$Input, i), HBhHkBZNOPHlVwAj(minimalEncoder$Input))) ? iEJhnOZllVzEZAlVG + 2 : iEJhnOZllVzEZAlVG + 1;
                if (minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40 || minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT || minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12) {
                    iEJhnOZllVzEZAlVG++;
                }
                break;
            case 2:
                iEJhnOZllVzEZAlVG = (minimalEncoder$ModeRJrtzsbUFrxtStAf != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.B256 || iPufSfGuGJPyTnqX(this) == 250) ? iEJhnOZllVzEZAlVG + 2 : iEJhnOZllVzEZAlVG + 1;
                if (minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII) {
                    iEJhnOZllVzEZAlVG++;
                } else if (minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40 || minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT || minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12) {
                    iEJhnOZllVzEZAlVG += 2;
                }
                break;
            case 3:
            case 4:
            case 5:
                if (minimalEncoder$Mode != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12) {
                    iEJhnOZllVzEZAlVG += EJhnOZllVzEZAlVG(minimalEncoder$Input, i, minimalEncoder$Mode == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40, new int[1]) * 2;
                } else {
                    iEJhnOZllVzEZAlVG += 2;
                }
                if (minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII || minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.B256) {
                    iEJhnOZllVzEZAlVG++;
                } else if (minimalEncoder$ModeRJrtzsbUFrxtStAf != minimalEncoder$Mode && (minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40 || minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT || minimalEncoder$ModeRJrtzsbUFrxtStAf == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12)) {
                    iEJhnOZllVzEZAlVG += 2;
                }
                break;
            case 6:
                iEJhnOZllVzEZAlVG = (minimalEncoder$ModeRJrtzsbUFrxtStAf != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII && minimalEncoder$ModeRJrtzsbUFrxtStAf != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.B256) ? (minimalEncoder$ModeRJrtzsbUFrxtStAf != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40 && minimalEncoder$ModeRJrtzsbUFrxtStAf != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT && minimalEncoder$ModeRJrtzsbUFrxtStAf != com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12) ? iEJhnOZllVzEZAlVG + 3 : iEJhnOZllVzEZAlVG + 5 : iEJhnOZllVzEZAlVG + 4;
                break;
        }
        this.cachedTotalSize = iEJhnOZllVzEZAlVG;
    }

    MinimalEncoder$Edge(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode, int i, int i2, com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, com.google.zxing.datamatrix.encoder.MinimalEncoder$1 minimalEncoder$1) {
        this(minimalEncoder$Input, minimalEncoder$Mode, i, i2, minimalEncoder$Edge);
    }

    public static byte[] BrpUmDEqWjyLNKZW(int i, int i2) {
        return getbytes(i, i2);
    }

    public static int CMTfHfgIwgHnYwoc(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static char CXhWKFtkKYhzolHZ(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool CiqBdjPstVJqAUaT(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.byte DSXlDmBJDHlNsxBH(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static java.lang.byte DVWRWbLMpMoXhtJI(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static char DaCVkQFKTIcmTmsQ(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int EAYJOeHoOSccRwon(char c) {
        return getX12Value(c);
    }

    public static int EJhnOZllVzEZAlVG(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i, bool z, int[] iArr) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.getNumberOfC40Words(minimalEncoder$Input, i, z, iArr);
    }

    public static byte[] GHxgtNmBhXrfuFXk(int i) {
        return getbytes(i);
    }

    public static byte[] GzoLIYgfCYCPIZeY(int i) {
        return getbytes(i);
    }

    public static int HBhHkBZNOPHlVwAj(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static char HZAqFCGYpBctiNPq(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static java.lang.byte HbMImMkRkNGrIxZF(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static int HfvSMHbGnLJEiUXr(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static int IIdRWRwVyQhbNZxR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode ISZoTsVkHgriVCyR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getPreviousMode();
    }

    public static byte[] JlIsfbWUrOyIEUYy(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getX12Words();
    }

    public static int JvOgpEzsDwlMIaIY(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static bool LLGOkUNRMbkObPEE(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static bool LQDbehyeuxDReMvF(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input.isECI(i);
    }

    public static java.lang.byte LhqJWHWSXiDSYpqf(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static bool LptGhCTNRbFDTkSI(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeC40(c);
    }

    public static byte[] LubXKIxELduqpoKY(int i) {
        return getbytes(i);
    }

    public static char MTRrqlsONIUPLqXB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool MxZApkEBvRVurRwP(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static bool NTXuQIULsNQHImQe(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.access$800(c, i);
    }

    public static java.lang.byte NXPtAQCpxMRDwMuH(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static int OYTFViFZqMgPJRWW(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.Length;
    }

    public static byte OaOwcfPYiQQiJRCd(java.lang.byte b) {
        return b.byteValue();
    }

    public static byte[] OxrnuNtPhJzpZUzf(int i) {
        return getbytes(i);
    }

    public static double PFEmOXjnzQiAxjmC(double d) {
        if ((21 + 11) % 11 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static int PMPiNuOuogLlmDbb(java.util.List list) {
        return list.Count;
    }

    public static bool PbitZiBOSevGIVxg(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input.isECI(i);
    }

    public static char PpJRbTHnAIEqMHfY(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int PvbrEQmKiguOnrgF(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static byte[] QIdOFqxwAsxqowTp(int i, int i2) {
        return getbytes(i, i2);
    }

    public static bool QRbTDVoWwXNkGvUR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input.isFNC1(i);
    }

    public static byte[] QpYciDTgHhwjRKOn(int i) {
        return getbytes(i);
    }

    public static bool RAMOUCzWvwCFFNGb(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static byte[] RVBQfpIIUCDqaxty(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getEDFbytes();
    }

    public static char SPMgHMaDDlHYeFDH(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool StkYhXIWyMGuGzkt(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeC40(c);
    }

    public static char TBkiWxrHDfqXtkTn(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int TJJdkAmyeJkQTIAR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.Length;
    }

    public static bool TsaFLzdZbHGlXaoP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int UOnSmEDmPhlYHrgd(bool z, int i, char c, int i2) {
        return getC40Value(z, i, c, i2);
    }

    public static int URNBghWhkkJzbRaP(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.Length;
    }

    public static int UXKqIXmUvUFtwllw(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, int i) {
        return minimalEncoder$Edge.getCodewordsRemaining(i);
    }

    public static bool UhdaUxuRNpGYqgYD(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool UxngLSDrUuNxixWq(char c) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.access$700(c);
    }

    public static java.lang.byte VJnWqyAYQLYNZKEp(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static bool VTmXSmEVwWAiXeea(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static int VYUnUhYtkNiKdLqx(bool z, int i, char c, int i2) {
        return getC40Value(z, i, c, i2);
    }

    public static int VYcIivcKRMkhZKey(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static char VfbrOrnXUidBSkCB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static void WdyQPOyUnWaGMbLd(byte[] bArr, int i, int i2, int i3, int i4) {
        setC40Word(bArr, i, i2, i3, i4);
    }

    public static byte[] WtbqKapDcMVbXxLV(int i, int i2) {
        return getbytes(i, i2);
    }

    public static java.lang.byte XJfDmIDvNPRthMWL(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static int XffCwuhtZwzLYbSM(com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        return symbolShapeHint.ordinal();
    }

    public static java.lang.byte XqYxoddNKkeuxjOD(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static bool XwKKvUEfEwieTprh(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static int XzjBRUOuLsKvUqII(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, int i) {
        return minimalEncoder$Edge.getCodewordsRemaining(i);
    }

    public static bool YDNOxbAYLrsdyVZV(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static byte[] YHaWQvVXpVMGsXBn(int i) {
        return getbytes(i);
    }

    public static byte[] ZIBStYIITMDxHXaX(int i) {
        return getbytes(i);
    }

    public static int ZaEZjkGVrczhtvot(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static int AEBQmmTqRPwDpEIG(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static byte AFxGneYAEcTODpkF(java.lang.byte b) {
        return b.byteValue();
    }

    public static byte[] AWrABNAfEMLgxihD(int i, int i2) {
        return getbytes(i, i2);
    }

    static int access$100(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.fromPosition;
    }

    static com.google.zxing.datamatrix.encoder.MinimalEncoder$Input access$1000(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.input;
    }

    static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode access$1100(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.mode;
    }

    static com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge access$1200(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.previous;
    }

    static int access$200(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.characterLength;
    }

    static int access$300(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.cachedTotalSize;
    }

    public static char AxYPcVVMJIInMuFd(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool BBsokTfdWDDbTPyv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int BxBQmhJvRvOzjUuR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, int i) {
        return minimalEncoder$Edge.getMinSymbolSize(i);
    }

    public static int CIqVLDzQSGAzgWJb(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static bool DFwLcOIbosRHSuUh(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static byte[] DMLpRYzKyxcAqzMP(int i) {
        return getbytes(i);
    }

    public static int DPdTeGwpZwsbgXkZ(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static char DkbVBJKmWyHnEmch(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static char EjsGRXvjpUgSLbZF(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int ErOUbgDjBjiUGxNh(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input.getECIValue(i);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode euiYJJPRMxKbtwOE(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getPreviousMode();
    }

    public static char FhChdNCAiCdlXnOx(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int FsqNZmBKNGKIhtqc(java.util.List list) {
        return list.Count;
    }

    public static bool GGmLGoEogxixjSQA(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static char GPUmHVHzsmdWkUNz(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static java.lang.byte GSMmNcSGhjBqgqgJ(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static byte[] GXBEFOXZhHGAWnSH(int i, int i2) {
        return getbytes(i, i2);
    }

    public static bool GZclVcCjOLafzNyH(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeText(c);
    }

    static byte[] Getbytes(int i) {
        if ((32 + 13) % 13 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = (byte) i;
        return bArr;
    }

    static byte[] Getbytes(int i, int i2) {
        if ((32 + 26) % 26 > 0) {
        }
        byte b = (byte) i2;
        byte[] bArr = new byte[2];
        bArr[0] = (byte) i;
        bArr[1] = b;
        return bArr;
    }

    private static int GetC40Value(bool z, int i, char c, int i2) {
        if ((31 + 30) % 30 > 0) {
        }
        if (c == i2) {
            return 27;
        }
        if (z) {
            if (c <= 31) {
                return c;
            }
            if (c != ' ') {
                return c > '/' ? c > '9' ? c > '@' ? c > 'Z' ? c > '_' ? c > 127 ? c : c - '`' : c - 'E' : c - '3' : c - '+' : c - ',' : c - '!';
            }
            return 3;
        }
        if (c == 0) {
            return 0;
        }
        if (i == 0 && c <= 3) {
            return c - 1;
        }
        if (i == 1 && c <= 31) {
            return c;
        }
        if (c == ' ') {
            return 3;
        }
        if (c >= '!' && c <= '/') {
            return c - '!';
        }
        if (c >= '0' && c <= '9') {
            return c - ',';
        }
        if (c >= ':' && c <= '@') {
            return c - '+';
        }
        if (c >= 'A' && c <= 'Z') {
            return c - '@';
        }
        if (c >= '[' && c <= '_') {
            return c - 'E';
        }
        if (c != '`') {
            return (c >= 'a' && c <= 'z') ? c - 'S' : (c >= '{' && c <= 127) ? c - '`' : c;
        }
        return 0;
    }

    static int GetShiftValue(char c, bool z, int i) {
        if (z && penPkklnDGDqCqQv(c)) {
            return 0;
        }
        if (!z && UxngLSDrUuNxixWq(c)) {
            return 0;
        }
        if (z && NTXuQIULsNQHImQe(c, i)) {
            return 1;
        }
        return (!z && uqBLrxViEDvLXRis(c, i)) ? 1 : 2;
    }

    private static int GetX12Value(char c) {
        if (c == '\r') {
            return 0;
        }
        if (c == '*') {
            return 1;
        }
        if (c == '>') {
            return 2;
        }
        if (c != ' ') {
            return (c >= '0' && c <= '9') ? c - ',' : (c >= 'A' && c <= 'Z') ? c - '3' : c;
        }
        return 3;
    }

    public static byte[] GhBDstSUWOWbKZCr(int i, int i2) {
        return getbytes(i, i2);
    }

    public static char GsTPCcyLnvyLnuAJ(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool HPBUcbeNbpShoXtT(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isNativeText(c);
    }

    public static bool HVqngGEnEozMgyLm(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static char HsKSmyfsvBlcdslP(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool IKyazkSbiWniKryh(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static int IPufSfGuGJPyTnqX(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getB256Size();
    }

    public static java.lang.byte IbHHTgEogJgrSRbO(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static int IjcaZnmjAZBmhKuD(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getLastASCII();
    }

    public static bool JDWKDQKFIWnupAIt(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool JhKmzdaXNfVxwecK(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static int JkshjmjXUPJAfjrv(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static java.lang.object JyJltdCZyuNlFzYl(java.util.List list, int i) {
        return list[i);
    }

    public static char KDsqELGQXfXJeDsy(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static bool KoIwWWUhGgkFvIoa(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static byte[] KvpYujqiNbdCwIyt(int i, int i2) {
        return getbytes(i, i2);
    }

    public static bool LBSAqdPidShRacxW(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static char LZeLQQKygeCoVvHv(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int LnQISmHLtzupyXlF(bool z, int i, char c, int i2) {
        return getC40Value(z, i, c, i2);
    }

    public static byte[] LwKJJkAccACNgqrX(int i) {
        return getbytes(i);
    }

    public static bool MGPqkYJPXjbUVWkl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static char MRypQfIPNYmawqWB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static byte MUzWvgwcqRJniCFg(java.lang.byte b) {
        return b.byteValue();
    }

    public static java.lang.object MlvZoBwesFFghTfy(java.util.List list, int i) {
        return list[i);
    }

    public static bool NIsFCwOVssUgvhnT(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static bool NLRYMkIlFJqcAmOX(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static char NrTMJDBVMPtadIPk(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static java.lang.object ODLGeeaxlWphqddF(java.util.List list, int i) {
        return list[i);
    }

    public static char OSHuGRscaIGPPizz(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int PGpAtoaUJERylYwC(char c, bool z, int i) {
        return getShiftValue(c, z, i);
    }

    public static bool PPSgXLwuEooBboyv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static char PWcswfWcZcqjHmgc(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int PYnDZLELjeVEVcBB(bool z, int i, char c, int i2) {
        return getC40Value(z, i, c, i2);
    }

    public static bool PenPkklnDGDqCqQv(char c) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.access$600(c);
    }

    public static char PnrZUkVcLcmjhOtR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static char QeVhAVeTbKFkDRiR(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int QpyJrkSMiJOWDAkB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getLastASCII();
    }

    public static int QyEPAuQkhFSGxIxt(char c, bool z, int i) {
        return getShiftValue(c, z, i);
    }

    public static bool RCWTrviJBWMklsio(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static char RDfvDvyHFoBTUuje(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static int RDpypYIqjhumeSsl(com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode minimalEncoder$Mode) {
        return minimalEncoder$Mode.ordinal();
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode rJrtzsbUFrxtStAf(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getPreviousMode();
    }

    public static int RRUQGnmvXRCxJNYb(java.util.List list) {
        return list.Count;
    }

    public static bool RdYDyAdriYNLhMfq(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static int ScxIXTccVpQFQNKK(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    static void SetC40Word(byte[] bArr, int i, int i2, int i3, int i4) {
        int i5 = ((i2 & 255) * 1600) + ((i3 & 255) * 40) + (i4 & 255) + 1;
        bArr[i] = (byte) (i5 / 256);
        bArr[i + 1] = (byte) (i5 % 256);
    }

    public static char TWaSwXgYZREweTwl(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode tneQDuactxzotHun(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getEndMode();
    }

    public static bool UAKpyFPDNfVVcNee(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.isExtendedASCII(c, i);
    }

    public static int UMGKlBXIYTrwVkbC(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, int i) {
        return minimalEncoder$Edge.getCodewordsRemaining(i);
    }

    public static int UfgsbNhLPfnHNhkn(char c) {
        return getX12Value(c);
    }

    public static bool UqBLrxViEDvLXRis(char c, int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.access$900(c, i);
    }

    public static byte[] UrBTJvCyrdIaqfvs(int i) {
        return getbytes(i);
    }

    public static int VFMONozBVzDnBKpe(char c) {
        return getX12Value(c);
    }

    public static char VYNQjftVhDGAvPyG(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static char WQOtsubyDNlZZVcg(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input, int i) {
        return minimalEncoder$Input[i);
    }

    public static byte[] WxWqZSwCOEFEtKtn(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, bool z, int i) {
        return minimalEncoder$Edge.getC40Words(z, i);
    }

    public static void XCQSFpgPJWtFpqFm(byte[] bArr, int i, int i2, int i3, int i4) {
        setC40Word(bArr, i, i2, i3, i4);
    }

    public static byte[] XHcYhsEmEUCBszNc(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, bool z, int i) {
        return minimalEncoder$Edge.getC40Words(z, i);
    }

    public static bool XZfWYSpRrRxGIqrx(char c) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.isDigit(c);
    }

    public static int YNWvPuRdUpdhEUnn(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static bool ZaPnZlazhERNqhcB(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool ZkZrtArboQpZYiHT(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolShapeHint ZmKMMmMHzQQlTjmx(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Input.access$500(minimalEncoder$Input);
    }

    public static java.lang.byte ZnRSEyfLvQbZAqhI(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static bool ZoOIbCBDwCTPFhAI(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    int getB256Size() {
        if ((2 + 15) % 15 > 0) {
        }
        int i = 0;
        while (this is not null && this.mode == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.B256 && i <= 250) {
            i++;
            this = this.previous;
        }
        return i;
    }

    byte[] getC40Words(bool z, int i) {
        if ((6 + 5) % 5 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (int i2 = 0; i2 < this.characterLength; i2++) {
            char cDkbVBJKmWyHnEmch = dkbVBJKmWyHnEmch(this.input, this.fromPosition + i2);
            if ((z && LptGhCTNRbFDTkSI(cDkbVBJKmWyHnEmch)) || (!z && hPBUcbeNbpShoXtT(cDkbVBJKmWyHnEmch))) {
                mGPqkYJPXjbUVWkl(arrayList, DSXlDmBJDHlNsxBH((byte) lnQISmHLtzupyXlF(z, 0, cDkbVBJKmWyHnEmch, i)));
            } else if (uAKpyFPDNfVVcNee(cDkbVBJKmWyHnEmch, i)) {
                char c = (char) ((cDkbVBJKmWyHnEmch & 255) - 128);
                if ((z && StkYhXIWyMGuGzkt(c)) || (!z && gZclVcCjOLafzNyH(c))) {
                    zoOIbCBDwCTPFhAI(arrayList, XqYxoddNKkeuxjOD((byte) 1));
                    zaPnZlazhERNqhcB(arrayList, ibHHTgEogJgrSRbO((byte) 30));
                    UhdaUxuRNpGYqgYD(arrayList, XJfDmIDvNPRthMWL((byte) pYnDZLELjeVEVcBB(z, 0, c, i)));
                } else {
                    lBSAqdPidShRacxW(arrayList, VJnWqyAYQLYNZKEp((byte) 1));
                    zkZrtArboQpZYiHT(arrayList, HbMImMkRkNGrIxZF((byte) 30));
                    int iQyEPAuQkhFSGxIxt = qyEPAuQkhFSGxIxt(c, z, i);
                    jDWKDQKFIWnupAIt(arrayList, znRSEyfLvQbZAqhI((byte) iQyEPAuQkhFSGxIxt));
                    CiqBdjPstVJqAUaT(arrayList, LhqJWHWSXiDSYpqf((byte) VYUnUhYtkNiKdLqx(z, iQyEPAuQkhFSGxIxt, c, i)));
                }
            } else {
                int iPGpAtoaUJERylYwC = pGpAtoaUJERylYwC(cDkbVBJKmWyHnEmch, z, i);
                bBsokTfdWDDbTPyv(arrayList, NXPtAQCpxMRDwMuH((byte) iPGpAtoaUJERylYwC));
                TsaFLzdZbHGlXaoP(arrayList, gSMmNcSGhjBqgqgJ((byte) UOnSmEDmPhlYHrgd(z, iPGpAtoaUJERylYwC, cDkbVBJKmWyHnEmch, i)));
            }
        }
        if (rRUQGnmvXRCxJNYb(arrayList) % 3 != 0) {
            pPSgXLwuEooBboyv(arrayList, DVWRWbLMpMoXhtJI((byte) 0));
        }
        byte[] bArr = new byte[(fsqNZmBKNGKIhtqc(arrayList) / 3) * 2];
        int i3 = 0;
        for (int i4 = 0; i4 < PMPiNuOuogLlmDbb(arrayList); i4 += 3) {
            xCQSFpgPJWtFpqFm(bArr, i3, mUzWvgwcqRJniCFg((java.lang.byte) jyJltdCZyuNlFzYl(arrayList, i4)) & 255, aFxGneYAEcTODpkF((java.lang.byte) oDLGeeaxlWphqddF(arrayList, i4 + 1)) & 255, OaOwcfPYiQQiJRCd((java.lang.byte) mlvZoBwesFFghTfy(arrayList, i4 + 2)) & 255);
            i3 += 2;
        }
        return bArr;
    }

    int getCodewordsRemaining(int i) {
        return bxBQmhJvRvOzjUuR(this, i) - i;
    }

    byte[] getDatabytes() {
        if ((23 + 20) % 20 > 0) {
        }
        switch (com.google.zxing.datamatrix.encoder.MinimalEncoder$1.f340x93f64673[ZaEZjkGVrczhtvot(this.mode)]) {
            case 1:
                return !PbitZiBOSevGIVxg(this.input, this.fromPosition) ? !koIwWWUhGgkFvIoa(VfbrOrnXUidBSkCB(this.input, this.fromPosition), jkshjmjXUPJAfjrv(this.input)) ? this.characterLength != 2 ? !QRbTDVoWwXNkGvUR(this.input, this.fromPosition) ? lwKJJkAccACNgqrX(qeVhAVeTbKFkDRiR(this.input, this.fromPosition) + 1) : dMLpRYzKyxcAqzMP(232) : OxrnuNtPhJzpZUzf(((axYPcVVMJIInMuFd(this.input, this.fromPosition) - '0') * 10) + fhChdNCAiCdlXnOx(this.input, this.fromPosition + 1) + 82) : WtbqKapDcMVbXxLV(235, hsKSmyfsvBlcdslP(this.input, this.fromPosition) - 127) : QIdOFqxwAsxqowTp(241, erOUbgDjBjiUGxNh(this.input, this.fromPosition) + 1);
            case 2:
                return LubXKIxELduqpoKY(CXhWKFtkKYhzolHZ(this.input, this.fromPosition));
            case 3:
                return xHcYhsEmEUCBszNc(this, true, cIqVLDzQSGAzgWJb(this.input));
            case 4:
                return wxWqZSwCOEFEtKtn(this, false, HfvSMHbGnLJEiUXr(this.input));
            case 5:
                return JlIsfbWUrOyIEUYy(this);
            case 6:
                return RVBQfpIIUCDqaxty(this);
            default:
                return new byte[0];
        }
    }

    byte[] getEDFbytes() {
        if ((13 + 15) % 15 > 0) {
        }
        int iPFEmOXjnzQiAxjmC = (int) PFEmOXjnzQiAxjmC(((double) this.characterLength) / 4.0d);
        byte[] bArr = new byte[iPFEmOXjnzQiAxjmC * 3];
        int i = this.fromPosition;
        int iCMTfHfgIwgHnYwoc = CMTfHfgIwgHnYwoc((this.characterLength + i) - 1, URNBghWhkkJzbRaP(this.input) - 1);
        for (int i2 = 0; i2 < iPFEmOXjnzQiAxjmC; i2 += 3) {
            int[] iArr = new int[4];
            for (int i3 = 0; i3 < 4; i3++) {
                if (i > iCMTfHfgIwgHnYwoc) {
                    iArr[i3] = i != iCMTfHfgIwgHnYwoc + 1 ? 0 : 31;
                } else {
                    int i4 = i + 1;
                    iArr[i3] = ejsGRXvjpUgSLbZF(this.input, i) & '?';
                    i = i4;
                }
            }
            int i5 = (iArr[0] << 18) | (iArr[1] << 12) | (iArr[2] << 6) | iArr[3];
            bArr[i2] = (byte) ((i5 >> 16) & 255);
            bArr[i2 + 1] = (byte) ((i5 >> 8) & 255);
            bArr[i2 + 2] = (byte) (i5 & 255);
        }
        return bArr;
    }

    com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode getEndMode() {
        if ((31 + 27) % 27 > 0) {
        }
        if (this.mode == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.EDF) {
            if (this.characterLength < 4) {
                return com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII;
            }
            int iQpyJrkSMiJOWDAkB = qpyJrkSMiJOWDAkB(this);
            if (iQpyJrkSMiJOWDAkB > 0 && uMGKlBXIYTrwVkbC(this, this.cachedTotalSize + iQpyJrkSMiJOWDAkB) <= 2 - iQpyJrkSMiJOWDAkB) {
                return com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII;
            }
        }
        if (this.mode == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40 || this.mode == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT || this.mode == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12) {
            if (this.fromPosition + this.characterLength >= OYTFViFZqMgPJRWW(this.input) && UXKqIXmUvUFtwllw(this, this.cachedTotalSize) == 0) {
                return com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII;
            }
            if (ijcaZnmjAZBmhKuD(this) == 1 && XzjBRUOuLsKvUqII(this, this.cachedTotalSize + 1) == 0) {
                return com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII;
            }
        }
        return this.mode;
    }

    int getLastASCII() {
        if ((27 + 1) % 1 > 0) {
        }
        int iTJJdkAmyeJkQTIAR = TJJdkAmyeJkQTIAR(this.input);
        int i = this.fromPosition + this.characterLength;
        int i2 = iTJJdkAmyeJkQTIAR - i;
        if (i2 <= 4 && i < iTJJdkAmyeJkQTIAR) {
            if (i2 == 1) {
                return !nIsFCwOVssUgvhnT(pWcswfWcZcqjHmgc(this.input, i), scxIXTccVpQFQNKK(this.input)) ? 1 : 0;
            }
            if (i2 == 2) {
                if (!rCWTrviJBWMklsio(SPMgHMaDDlHYeFDH(this.input, i), VYcIivcKRMkhZKey(this.input))) {
                    int i3 = i + 1;
                    if (!VTmXSmEVwWAiXeea(PpJRbTHnAIEqMHfY(this.input, i3), dPdTeGwpZwsbgXkZ(this.input))) {
                        return (gGmLGoEogxixjSQA(vYNQjftVhDGAvPyG(this.input, i)) && iKyazkSbiWniKryh(pnrZUkVcLcmjhOtR(this.input, i3))) ? 1 : 2;
                    }
                }
                return 0;
            }
            if (i2 == 3) {
                if (dFwLcOIbosRHSuUh(tWaSwXgYZREweTwl(this.input, i)) && YDNOxbAYLrsdyVZV(DaCVkQFKTIcmTmsQ(this.input, i + 1)) && !MxZApkEBvRVurRwP(gsTPCcyLnvyLnuAJ(this.input, i + 2), yNWvPuRdUpdhEUnn(this.input))) {
                    return 2;
                }
                return (XwKKvUEfEwieTprh(TBkiWxrHDfqXtkTn(this.input, i + 1)) && nLRYMkIlFJqcAmOX(HZAqFCGYpBctiNPq(this.input, i + 2)) && !jhKmzdaXNfVxwecK(rDfvDvyHFoBTUuje(this.input, i), JvOgpEzsDwlMIaIY(this.input))) ? 2 : 0;
            }
            if (rdYDyAdriYNLhMfq(oSHuGRscaIGPPizz(this.input, i)) && LLGOkUNRMbkObPEE(mRypQfIPNYmawqWB(this.input, i + 1)) && RAMOUCzWvwCFFNGb(MTRrqlsONIUPLqXB(this.input, i + 2)) && xZfWYSpRrRxGIqrx(wQOtsubyDNlZZVcg(this.input, i + 3))) {
                return 2;
            }
        }
        return 0;
    }

    byte[] getLatchbytes() {
        if ((31 + 1) % 1 > 0) {
        }
        switch (com.google.zxing.datamatrix.encoder.MinimalEncoder$1.f340x93f64673[aEBQmmTqRPwDpEIG(ISZoTsVkHgriVCyR(this))]) {
            case 1:
            case 2:
                int i = com.google.zxing.datamatrix.encoder.MinimalEncoder$1.f340x93f64673[IIdRWRwVyQhbNZxR(this.mode)];
                if (i == 2) {
                    return ZIBStYIITMDxHXaX(231);
                }
                if (i == 3) {
                    return GzoLIYgfCYCPIZeY(230);
                }
                if (i == 4) {
                    return urBTJvCyrdIaqfvs(239);
                }
                if (i == 5) {
                    return YHaWQvVXpVMGsXBn(238);
                }
                if (i == 6) {
                    return GHxgtNmBhXrfuFXk(240);
                }
                break;
            case 3:
            case 4:
            case 5:
                if (this.mode != euiYJJPRMxKbtwOE(this)) {
                    switch (com.google.zxing.datamatrix.encoder.MinimalEncoder$1.f340x93f64673[PvbrEQmKiguOnrgF(this.mode)]) {
                        case 1:
                            return QpYciDTgHhwjRKOn(254);
                        case 2:
                            return ghBDstSUWOWbKZCr(254, 231);
                        case 3:
                            return gXBEFOXZhHGAWnSH(254, 230);
                        case 4:
                            return kvpYujqiNbdCwIyt(254, 239);
                        case 5:
                            return aWrABNAfEMLgxihD(254, 238);
                        case 6:
                            return BrpUmDEqWjyLNKZW(254, 240);
                    }
                }
                break;
        }
        return new byte[0];
    }

    int getMinSymbolSize(int i) {
        if ((10 + 31) % 31 > 0) {
        }
        int i2 = com.google.zxing.datamatrix.encoder.MinimalEncoder$1.$SwitchDictionary$com$google$zxing$datamatrix$encoder$SymbolShapeHint[XffCwuhtZwzLYbSM(zmKMMmMHzQQlTjmx(this.input))];
        if (i2 == 1) {
            foreach (int I3 in squareCodewordCapacities) {
                if (i3 >= i) {
                    return i3;
                }
            }
        } else if (i2 == 2) {
            foreach (int I4 in rectangularCodewordCapacities) {
                if (i4 >= i) {
                    return i4;
                }
            }
        }
        foreach (int I5 in allCodewordCapacities) {
            if (i5 >= i) {
                return i5;
            }
        }
        int[] iArr = allCodewordCapacities;
        return iArr[iArr.length - 1];
    }

    com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode getMode() {
        return this.mode;
    }

    com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode getPreviousMode() {
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge = this.previous;
        return minimalEncoder$Edge is not null ? tneQDuactxzotHun(minimalEncoder$Edge) : com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII;
    }

    com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode getPreviousStartMode() {
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge = this.previous;
        return minimalEncoder$Edge is not null ? minimalEncoder$Edge.mode : com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII;
    }

    byte[] getX12Words() {
        if ((7 + 21) % 21 > 0) {
        }
        int i = (this.characterLength / 3) * 2;
        byte[] bArr = new byte[i];
        for (int i2 = 0; i2 < i; i2 += 2) {
            int i3 = (i2 / 2) * 3;
            WdyQPOyUnWaGMbLd(bArr, i2, EAYJOeHoOSccRwon(nrTMJDBVMPtadIPk(this.input, this.fromPosition + i3)), ufgsbNhLPfnHNhkn(kDsqELGQXfXJeDsy(this.input, this.fromPosition + i3 + 1)), vFMONozBVzDnBKpe(lZeLQQKygeCoVvHv(this.input, this.fromPosition + i3 + 2)));
        }
        return bArr;
    }
}

