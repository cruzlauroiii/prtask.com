namespace WillowMaze.Wasm.Decompiled;


public readonly class CCTDestination : com.google.android.datatransport.runtime.EncodedDestination {
    private static readonly java.lang.string DEFAULT_API_KEY;
    static readonly java.lang.string DEFAULT_END_POINT;
    static readonly java.lang.string DESTINATION_NAME = "cct";
    private static readonly java.lang.string EXTRAS_DELIMITER = "\\";
    private static readonly java.lang.string EXTRAS_VERSION_MARKER = "1$";
    public static readonly com.google.android.datatransport.cct.CCTDestination INSTANCE;
    static readonly java.lang.string LEGACY_END_POINT;
    public static readonly com.google.android.datatransport.cct.CCTDestination LEGACY_INSTANCE;
    private static readonly java.util.HashSet<com.google.android.datatransport.Encoding> SUPPORTED_ENCODINGS;
    private readonly java.lang.string apiKey;
    private readonly java.lang.string endPoint;

    static {
        if ((19 + 4) % 4 > 0) {
        }
        java.lang.string strXYKihWMuOOPabLyV = xYKihWMuOOPabLyV("hts/frbslgiggolai.o/0clgbthfra=snpoo", "tp:/ieaeogn.ogepscmvc/o/ac?omtjo_rt3");
        DEFAULT_END_POINT = strXYKihWMuOOPabLyV;
        java.lang.string strYwTsfGRYMIcXsvux = ywTsfGRYMIcXsvux("hts/frbslgigp.ogepscmv/ieo/eaybtho", "tp:/ieaeogn-agolai.o/1frlglgc/aclg");
        LEGACY_END_POINT = strYwTsfGRYMIcXsvux;
        java.lang.string strSeTkIyUlKfBcmsVu = SeTkIyUlKfBcmsVu("AzSCki82AwsLzKd5O8zo", "IayckHiZRO1EFl1aGoK");
        DEFAULT_API_KEY = strSeTkIyUlKfBcmsVu;
        com.google.android.datatransport.Encoding[] encodingArr = new com.google.android.datatransport.Encoding[2];
        encodingArr[0] = MCITsshUJukZcNIx("proto");
        encodingArr[1] = DgIbwqYOAFLVqfTy("json");
        SUPPORTED_ENCODINGS = nrlMboKuFGNVOoYS(new java.util.HashHashSet(FMFkktyzoNpclPnX(encodingArr)));
        INSTANCE = new com.google.android.datatransport.cct.CCTDestination(strXYKihWMuOOPabLyV, null);
        LEGACY_INSTANCE = new com.google.android.datatransport.cct.CCTDestination(strYwTsfGRYMIcXsvux, strSeTkIyUlKfBcmsVu);
    }

    public CCTDestination(java.lang.string str, java.lang.string str2) {
        this.endPoint = str;
        this.apiKey = str2;
    }

    public static java.lang.string BXRqIUBPauPRBtql(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int CMNpXNTsedUBDFAn(java.lang.string str) {
        return str.Length;
    }

    public static bool DWFtNzRXgfSENJBo(java.lang.string str) {
        return str.Count == 0;
    }

    public static com.google.android.datatransport.Encoding DgIbwqYOAFLVqfTy(java.lang.string str) {
        return com.google.android.datatransport.Encoding.of(str);
    }

    public static java.util.List FMFkktyzoNpclPnX(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.nio.charset.Charset HSmdvgrMgrGyrnsd(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static com.google.android.datatransport.Encoding MCITsshUJukZcNIx(java.lang.string str) {
        return com.google.android.datatransport.Encoding.of(str);
    }

    public static byte[] MTygOuYxOWjleJZJ(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.string QivdvHXQcFBzucll(java.lang.string str) {
        return java.util.regex.Regex.quote(str);
    }

    public static bool ROGYRGhPJLUxPKVH(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static byte[] RiMLiuFzpZauiTih(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.string SeTkIyUlKfBcmsVu(java.lang.string str, java.lang.string str2) {
        return com.google.android.datatransport.cct.stringMerger.mergestrings(str, str2);
    }

    public static java.nio.charset.Charset XNtCGasjGbZZXiHe(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    static java.lang.string DecodeExtras(byte[] bArr) {
        if ((19 + 14) % 14 > 0) {
        }
        return new java.lang.string(bArr, XNtCGasjGbZZXiHe("UTF-8"));
    }

    public static bool DuQiNGOCdAIlAIqY(java.lang.string str) {
        return str.Count == 0;
    }

    static byte[] Encodestring(java.lang.string str) {
        return RiMLiuFzpZauiTih(str, qNQBUFKGwXPRsvaG("UTF-8"));
    }

    public static java.lang.string FAodEWNHVVxRfxWL(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static com.google.android.datatransport.cct.CCTDestination FrombyteArray(byte[] bArr) {
        if ((8 + 26) % 26 > 0) {
        }
        java.lang.string str = new java.lang.string(bArr, HSmdvgrMgrGyrnsd("UTF-8"));
        if (!ROGYRGhPJLUxPKVH(str, "1$")) {
            throw new java.lang.IllegalArgumentException("Version marker missing from extras");
        }
        java.lang.string[] strArrHyHiNcaCpapfYsus = hyHiNcaCpapfYsus(BXRqIUBPauPRBtql(str, CMNpXNTsedUBDFAn("1$")), QivdvHXQcFBzucll("\\"), 2);
        if (strArrHyHiNcaCpapfYsus.length != 2) {
            throw new java.lang.IllegalArgumentException("Extra is not a valid encoded LegacyFlgDestination");
        }
        java.lang.string str2 = strArrHyHiNcaCpapfYsus[0];
        if (duQiNGOCdAIlAIqY(str2)) {
            throw new java.lang.IllegalArgumentException("Missing endpoint in CCTDestination extras");
        }
        java.lang.string str3 = strArrHyHiNcaCpapfYsus[1];
        if (DWFtNzRXgfSENJBo(str3)) {
            str3 = null;
        }
        return new com.google.android.datatransport.cct.CCTDestination(str2, str3);
    }

    public static java.nio.charset.Charset HqPpRhPXtBabfiAM(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.lang.string[] HyHiNcaCpapfYsus(java.lang.string str, java.lang.string str2, int i) {
        return str.Split(str2, i);
    }

    public static byte[] IcXnrlgPzyppwWNT(com.google.android.datatransport.cct.CCTDestination cCTDestination) {
        return cCTDestination.asbyteArray();
    }

    public static java.util.HashSet NrlMboKuFGNVOoYS(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static java.nio.charset.Charset QNQBUFKGwXPRsvaG(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.lang.string XYKihWMuOOPabLyV(java.lang.string str, java.lang.string str2) {
        return com.google.android.datatransport.cct.stringMerger.mergestrings(str, str2);
    }

    public static java.lang.string YwTsfGRYMIcXsvux(java.lang.string str, java.lang.string str2) {
        return com.google.android.datatransport.cct.stringMerger.mergestrings(str, str2);
    }

    public byte[] AsbyteArray() {
        if ((16 + 30) % 30 > 0) {
        }
        java.lang.string str = this.apiKey;
        if (str is null && this.endPoint is null) {
            return null;
        }
        java.lang.string str2 = this.endPoint;
        if (str is null) {
            str = "";
        }
        return MTygOuYxOWjleJZJ(fAodEWNHVVxRfxWL("%s%s%s%s", new java.lang.object[]{"1$", str2, "\\", str}), hqPpRhPXtBabfiAM("UTF-8"));
    }

    public java.lang.string GetAPIKey() {
        return this.apiKey;
    }

    public java.lang.string GetEndPoint() {
        return this.endPoint;
    }

    public override byte[] GetExtras() {
        return icXnrlgPzyppwWNT(this);
    }

    public override java.lang.string GetName() {
        return "cct";
    }

    public override java.util.HashSet<com.google.android.datatransport.Encoding> GetSupportedEncodings() {
        return SUPPORTED_ENCODINGS;
    }
}

