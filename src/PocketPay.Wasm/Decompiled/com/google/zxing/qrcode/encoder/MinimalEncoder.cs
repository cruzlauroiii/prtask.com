namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder {
    private readonly com.google.zxing.qrcode.decoder.ErrorCorrectionLevel ecLevel;
    private readonly com.google.zxing.common.ECIEncoderHashSet encoders;
    private readonly bool isGS1;
    private readonly java.lang.string stringToEncode;

    MinimalEncoder(java.lang.string str, java.nio.charset.Charset charset, bool z, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        this.stringToEncode = str;
        this.isGS1 = z;
        this.encoders = new com.google.zxing.common.ECIEncoderHashSet(str, charset, -1);
        this.ecLevel = errorCorrectionLevel;
    }

    public static int AGiRicgYrnPpRBBS(java.lang.string str) {
        return str.Length;
    }

    public static int ARHQhKiWnycEcbJb(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    public static int AqiMVVRxUzeZjmer(java.lang.string str) {
        return str.Length;
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList CwTRFJKnLIjzszrL(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder.encodeSpecificVersion(version);
    }

    public static com.google.zxing.qrcode.decoder.Version DKHlOgqVsETwsgrm(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static int DLPmYirjrkSLXgRp(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList) {
        return minimalEncoder$ResultList.getSize();
    }

    public static char DYMbGSKjDRVPBDpv(java.lang.string str, int i) {
        return str[i);
    }

    public static bool DwuWbBbMsvvCwoNy(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, char c) {
        return minimalEncoder.canEncode(mode, c);
    }

    public static int ETBPNbIiAbPoWUrD(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static bool EnRMqPCrMmuNBPEm(java.lang.string str) {
        return com.google.zxing.qrcode.encoder.Encoder.isOnlydoublebyteKanji(str);
    }

    public static int GVYCrFkUrphYBmGr(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static bool GhWQafGKxsiRsxiR(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, char c) {
        return minimalEncoder.canEncode(mode, c);
    }

    public static int GqoSHHcpSAxMWbmR(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    public static com.google.zxing.qrcode.decoder.Version HHzAZrRLXXCjjnwT(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static bool IeObOmoPdQxdaesU(char c) {
        return isdoublebyteKanji(c);
    }

    public static java.lang.object ImYxLQZJwnjOHUfC(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int JGPCbJBEdtuoPdLC(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return minimalEncoder$VersionSize.ordinal();
    }

    public static void JTianCpQBAlOlYUJ(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        minimalEncoder.addEdge(minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.decoder.Version KnTQMDJbleTqUMhh(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return getVersion(minimalEncoder$VersionSize);
    }

    public static java.lang.stringBuilder LJMvJRHoQEiJdbdV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LLwSvuIuOcgCtmBx(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        minimalEncoder.addEdges(version, minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize LOmcVGBQFhvkobRJ(com.google.zxing.qrcode.decoder.Version version) {
        return getVersionSize(version);
    }

    public static java.lang.stringBuilder LZoNkJPPQJIQxBXF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MPVGopkEIDJdjMBQ(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList) {
        return minimalEncoder$ResultList.getSize();
    }

    public static int MaqgvgUMDkeYXtsJ(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$000(minimalEncoder$Edge);
    }

    public static java.lang.stringBuilder NWvQwidVNPSvqyOd(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool OHkBXQhJNjPEhjhU(char c) {
        return isAlphanumeric(c);
    }

    public static bool PKjoeFgePTOAuqaY(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, char c, int i) {
        return eCIEncoderHashSet.canEncode(c, i);
    }

    public static com.google.zxing.qrcode.decoder.Version QjKKrWCHIKREuozt(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static void RTnSzehpGEAoZyGx(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        minimalEncoder.addEdge(minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.decoder.Version SqGAKiTrjCOIfoML(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList) {
        return minimalEncoder$ResultList.getVersion();
    }

    public static bool TNZySCbzDzSExYsx(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, char c) {
        return minimalEncoder.canEncode(mode, c);
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList TvEfEYQLsaYtfaVA(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder.encodeSpecificVersion(version);
    }

    public static int UZLyUEzcDYibrBOY(com.google.zxing.qrcode.decoder.Mode mode) {
        return getCompactedOrdinal(mode);
    }

    public static com.google.zxing.qrcode.decoder.Version WVgWDMCwcGCidJzN(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return getVersion(minimalEncoder$VersionSize);
    }

    public static com.google.zxing.qrcode.decoder.Version XuviNrnwLpKswwWC(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return getVersion(minimalEncoder$VersionSize);
    }

    public static int ACsoMRlQtHjwfaGL(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.getPriorityEncoderIndex();
    }

    public static java.lang.string AIbKkfpEfPeDKNAK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel access$1100(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return minimalEncoder.ecLevel;
    }

    static java.lang.string access$500(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return minimalEncoder.stringToEncode;
    }

    static com.google.zxing.common.ECIEncoderHashSet access$600(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return minimalEncoder.encoders;
    }

    static bool access$900(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return minimalEncoder.isGS1;
    }

    public static char AelnQpBJsQWfBgWy(java.lang.string str, int i) {
        return str[i);
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList bdpGpMHWPhCZRWDw(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder.encode(version);
    }

    public static com.google.zxing.qrcode.decoder.Version CWziPNvbgNaDvsJN(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return getVersion(minimalEncoder$VersionSize);
    }

    public static bool DeXSYzzcNUlTleKW(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, char c) {
        return minimalEncoder.canEncode(mode, c);
    }

    public static int EIArSgWXyHIxxEvV(int i) {
        return com.google.zxing.qrcode.encoder.Encoder.getAlphanumericCode(i);
    }

    public static int EbuIKjZRCpOIPoQr(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    public static java.lang.string EgTBTzqZouqmVdxp(char c) {
        return java.lang.string.valueOf(c);
    }

    static com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList encode(java.lang.string str, com.google.zxing.qrcode.decoder.Version version, java.nio.charset.Charset charset, bool z, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) throws com.google.zxing.WriterException {
        return bdpGpMHWPhCZRWDw(new com.google.zxing.qrcode.encoder.MinimalEncoder(str, charset, z, errorCorrectionLevel), version);
    }

    public static int FcOhApMFoQqQKuRY(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    static int GetCompactedOrdinal(com.google.zxing.qrcode.decoder.Mode mode) {
        if ((18 + 5) % 5 > 0) {
        }
        if (mode is null) {
            return 0;
        }
        int i = com.google.zxing.qrcode.encoder.MinimalEncoder$1.$SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[GqoSHHcpSAxMWbmR(mode)];
        if (i == 1) {
            return 0;
        }
        if (i == 2) {
            return 1;
        }
        if (i == 3) {
            return 2;
        }
        if (i != 4) {
            throw new java.lang.IllegalStateException(aIbKkfpEfPeDKNAK(jlMopjpwxMfMNfTA(new java.lang.stringBuilder("Illegal mode "), mode)));
        }
        return 3;
    }

    static com.google.zxing.qrcode.decoder.Version GetVersion(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        int i = com.google.zxing.qrcode.encoder.MinimalEncoder$1.f361x9d14eba6[JGPCbJBEdtuoPdLC(minimalEncoder$VersionSize)];
        return i == 1 ? DKHlOgqVsETwsgrm(9) : i == 2 ? QjKKrWCHIKREuozt(26) : HHzAZrRLXXCjjnwT(40);
    }

    static com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize getVersionSize(com.google.zxing.qrcode.decoder.Version version) {
        if ((5 + 18) % 18 > 0) {
        }
        return xaZvBvMKykrXcTXw(version) > 9 ? ETBPNbIiAbPoWUrD(version) > 26 ? com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.LARGE : com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.MEDIUM : com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.SMALL;
    }

    public static int GhooGrDELEuwTLxZ(com.google.zxing.qrcode.decoder.Mode mode) {
        return mode.ordinal();
    }

    static bool IsAlphanumeric(char c) {
        return eIArSgWXyHIxxEvV(c) != -1;
    }

    static bool IsdoublebyteKanji(char c) {
        return EnRMqPCrMmuNBPEm(egTBTzqZouqmVdxp(c));
    }

    static bool IsNumeric(char c) {
        return c >= '0' && c <= '9';
    }

    public static int IybiKDsahFPGGunQ(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$100(minimalEncoder$Edge);
    }

    public static int IzDyMHNYygeHvOft(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static char JQXkbbNuZPwZfGwO(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string JRjpUFUMhDAkTmBG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JlMopjpwxMfMNfTA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool JpDtrBIRSDNSqJdC(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return com.google.zxing.qrcode.encoder.Encoder.willFit(i, version, errorCorrectionLevel);
    }

    public static char KntqoRezQwKvdwCY(java.lang.string str, int i) {
        return str[i);
    }

    public static bool LDLVqaRDnjpoNohy(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet, char c, int i) {
        return eCIEncoderHashSet.canEncode(c, i);
    }

    public static int LLvTPVhymtZARkqU(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static char LZXuLXucgqxwhfOp(java.lang.string str, int i) {
        return str[i);
    }

    public static char MuVqtjVESQMsSNjt(java.lang.string str, int i) {
        return str[i);
    }

    public static int OCkZFAbpRHLIQRik(com.google.zxing.common.ECIEncoderHashSet eCIEncoderHashSet) {
        return eCIEncoderHashSet.Length;
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList ocrgdVMiIbokPWVZ(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder.encodeSpecificVersion(version);
    }

    public static int OwbnpfWofUEKWmba(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$300(minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList qCWypdyUptnsnfyY(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder.encodeSpecificVersion(version);
    }

    public static void QcZcNkdNLqesuKYk(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        minimalEncoder.addEdges(version, minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static bool RhQTGHwoyvuJBDpq(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, char c) {
        return minimalEncoder.canEncode(mode, c);
    }

    public static char SMgHCYVjpfdDeNsv(java.lang.string str, int i) {
        return str[i);
    }

    public static bool SxcWTcZUzjtWmxGZ(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return com.google.zxing.qrcode.encoder.Encoder.willFit(i, version, errorCorrectionLevel);
    }

    public static char TkrJiNUBMSCaCCbH(java.lang.string str, int i) {
        return str[i);
    }

    public static com.google.zxing.qrcode.decoder.Mode UtsGYDUcHxbIXeZl(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$200(minimalEncoder$Edge);
    }

    public static java.lang.string ViWvUnLQkebtkJWg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WNhfpDCbCsirfrIX(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        minimalEncoder.addEdge(minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static void WUeHmoWldsFzIBiG(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        minimalEncoder.addEdge(minimalEncoder$EdgeArr, i, minimalEncoder$Edge);
    }

    public static int XaZvBvMKykrXcTXw(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static bool XcoXRwgvTanjeMpg(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Mode mode, char c) {
        return minimalEncoder.canEncode(mode, c);
    }

    public static bool ZtGMBEpcRQnLhrfo(char c) {
        return isNumeric(c);
    }

    void addEdge(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[] minimalEncoder$EdgeArr2 = minimalEncoder$EdgeArr[i + MaqgvgUMDkeYXtsJ(minimalEncoder$Edge)][iybiKDsahFPGGunQ(minimalEncoder$Edge)];
        int iUZLyUEzcDYibrBOY = UZLyUEzcDYibrBOY(utsGYDUcHxbIXeZl(minimalEncoder$Edge));
        com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge2 = minimalEncoder$EdgeArr2[iUZLyUEzcDYibrBOY];
        if (minimalEncoder$Edge2 is not null && fcOhApMFoQqQKuRY(minimalEncoder$Edge2) <= ARHQhKiWnycEcbJb(minimalEncoder$Edge)) {
            return;
        }
        minimalEncoder$EdgeArr2[iUZLyUEzcDYibrBOY] = minimalEncoder$Edge;
    }

    void addEdges(com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr, int i, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        int i2;
        if ((27 + 20) % 20 > 0) {
        }
        int iOCkZFAbpRHLIQRik = oCkZFAbpRHLIQRik(this.encoders);
        int iACsoMRlQtHjwfaGL = aCsoMRlQtHjwfaGL(this.encoders);
        if (iACsoMRlQtHjwfaGL >= 0 && lDLVqaRDnjpoNohy(this.encoders, DYMbGSKjDRVPBDpv(this.stringToEncode, i), iACsoMRlQtHjwfaGL)) {
            iOCkZFAbpRHLIQRik = iACsoMRlQtHjwfaGL + 1;
        } else {
            iACsoMRlQtHjwfaGL = 0;
        }
        int i3 = iOCkZFAbpRHLIQRik;
        for (int i4 = iACsoMRlQtHjwfaGL; i4 < i3; i4++) {
            if (PKjoeFgePTOAuqaY(this.encoders, lZXuLXucgqxwhfOp(this.stringToEncode, i), i4)) {
                wNhfpDCbCsirfrIX(this, minimalEncoder$EdgeArr, i, new com.google.zxing.qrcode.encoder.MinimalEncoder$Edge(this, com.google.zxing.qrcode.decoder.Mode.BYTE, i, i4, 1, minimalEncoder$Edge, version, null));
            }
        }
        if (xcoXRwgvTanjeMpg(this, com.google.zxing.qrcode.decoder.Mode.KANJI, muVqtjVESQMsSNjt(this.stringToEncode, i))) {
            JTianCpQBAlOlYUJ(this, minimalEncoder$EdgeArr, i, new com.google.zxing.qrcode.encoder.MinimalEncoder$Edge(this, com.google.zxing.qrcode.decoder.Mode.KANJI, i, 0, 1, minimalEncoder$Edge, version, null));
        }
        int iAGiRicgYrnPpRBBS = AGiRicgYrnPpRBBS(this.stringToEncode);
        int i5 = 2;
        if (deXSYzzcNUlTleKW(this, com.google.zxing.qrcode.decoder.Mode.ALPHANUMERIC, kntqoRezQwKvdwCY(this.stringToEncode, i))) {
            int i6 = i + 1;
            RTnSzehpGEAoZyGx(this, minimalEncoder$EdgeArr, i, new com.google.zxing.qrcode.encoder.MinimalEncoder$Edge(this, com.google.zxing.qrcode.decoder.Mode.ALPHANUMERIC, i, 0, (i6 < iAGiRicgYrnPpRBBS && rhQTGHwoyvuJBDpq(this, com.google.zxing.qrcode.decoder.Mode.ALPHANUMERIC, jQXkbbNuZPwZfGwO(this.stringToEncode, i6))) ? 2 : 1, minimalEncoder$Edge, version, null));
        }
        if (DwuWbBbMsvvCwoNy(this, com.google.zxing.qrcode.decoder.Mode.NUMERIC, aelnQpBJsQWfBgWy(this.stringToEncode, i))) {
            com.google.zxing.qrcode.decoder.Mode mode = com.google.zxing.qrcode.decoder.Mode.NUMERIC;
            int i7 = i + 1;
            if (i7 < iAGiRicgYrnPpRBBS && GhWQafGKxsiRsxiR(this, com.google.zxing.qrcode.decoder.Mode.NUMERIC, tkrJiNUBMSCaCCbH(this.stringToEncode, i7))) {
                int i8 = i + 2;
                if (i8 < iAGiRicgYrnPpRBBS && TNZySCbzDzSExYsx(this, com.google.zxing.qrcode.decoder.Mode.NUMERIC, sMgHCYVjpfdDeNsv(this.stringToEncode, i8))) {
                    i5 = 3;
                }
                i2 = i5;
            } else {
                i2 = 1;
            }
            wUeHmoWldsFzIBiG(this, minimalEncoder$EdgeArr, i, new com.google.zxing.qrcode.encoder.MinimalEncoder$Edge(this, mode, i, 0, i2, minimalEncoder$Edge, version, null));
        }
    }

    bool canEncode(com.google.zxing.qrcode.decoder.Mode mode, char c) {
        int i = com.google.zxing.qrcode.encoder.MinimalEncoder$1.$SwitchDictionary$com$google$zxing$qrcode$decoder$Mode[ghooGrDELEuwTLxZ(mode)];
        return i == 1 ? IeObOmoPdQxdaesU(c) : i == 2 ? OHkBXQhJNjPEhjhU(c) : i == 3 ? ztGMBEpcRQnLhrfo(c) : i == 4;
    }

    com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList encode(com.google.zxing.qrcode.decoder.Version version) throws com.google.zxing.WriterException {
        if ((27 + 6) % 6 > 0) {
        }
        if (version is not null) {
            com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultListCwTRFJKnLIjzszrL = CwTRFJKnLIjzszrL(this, version);
            if (sxcWTcZUzjtWmxGZ(DLPmYirjrkSLXgRp(minimalEncoder$ResultListCwTRFJKnLIjzszrL), cWziPNvbgNaDvsJN(LOmcVGBQFhvkobRJ(SqGAKiTrjCOIfoML(minimalEncoder$ResultListCwTRFJKnLIjzszrL))), this.ecLevel)) {
                return minimalEncoder$ResultListCwTRFJKnLIjzszrL;
            }
            throw new com.google.zxing.WriterException(jRjpUFUMhDAkTmBG(NWvQwidVNPSvqyOd(new java.lang.stringBuilder("Data too big for version"), version)));
        }
        com.google.zxing.qrcode.decoder.Version[] versionArr = new com.google.zxing.qrcode.decoder.Version[3];
        versionArr[0] = XuviNrnwLpKswwWC(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.SMALL);
        versionArr[1] = WVgWDMCwcGCidJzN(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.MEDIUM);
        versionArr[2] = KnTQMDJbleTqUMhh(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize.LARGE);
        com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList[] minimalEncoder$ResultListArr = new com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList[3];
        minimalEncoder$ResultListArr[0] = qCWypdyUptnsnfyY(this, versionArr[0]);
        minimalEncoder$ResultListArr[1] = ocrgdVMiIbokPWVZ(this, versionArr[1]);
        minimalEncoder$ResultListArr[2] = TvEfEYQLsaYtfaVA(this, versionArr[2]);
        int i = int.MAX_VALUE;
        int i2 = -1;
        for (int i3 = 0; i3 < 3; i3++) {
            int iMPVGopkEIDJdjMBQ = MPVGopkEIDJdjMBQ(minimalEncoder$ResultListArr[i3]);
            if (jpDtrBIRSDNSqJdC(iMPVGopkEIDJdjMBQ, versionArr[i3], this.ecLevel) && iMPVGopkEIDJdjMBQ < i) {
                i2 = i3;
                i = iMPVGopkEIDJdjMBQ;
            }
        }
        if (i2 < 0) {
            throw new com.google.zxing.WriterException("Data too big for any version");
        }
        return minimalEncoder$ResultListArr[i2];
    }

    com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList encodeSpecificVersion(com.google.zxing.qrcode.decoder.Version version) throws com.google.zxing.WriterException {
        if ((11 + 10) % 10 > 0) {
        }
        int iAqiMVVRxUzeZjmer = AqiMVVRxUzeZjmer(this.stringToEncode);
        int i = iAqiMVVRxUzeZjmer + 1;
        int iLLvTPVhymtZARkqU = lLvTPVhymtZARkqU(this.encoders);
        int[] iArr = new int[3];
        iArr[2] = 4;
        iArr[1] = iLLvTPVhymtZARkqU;
        iArr[0] = i;
        com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][] minimalEncoder$EdgeArr = (com.google.zxing.qrcode.encoder.MinimalEncoder$Edge[][][]) ImYxLQZJwnjOHUfC(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.class, iArr);
        LLwSvuIuOcgCtmBx(this, version, minimalEncoder$EdgeArr, 0, null);
        for (int i2 = 1; i2 <= iAqiMVVRxUzeZjmer; i2++) {
            for (int i3 = 0; i3 < GVYCrFkUrphYBmGr(this.encoders); i3++) {
                for (int i4 = 0; i4 < 4; i4++) {
                    com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge = minimalEncoder$EdgeArr[i2][i3][i4];
                    if (minimalEncoder$Edge is not null && i2 < iAqiMVVRxUzeZjmer) {
                        qcZcNkdNLqesuKYk(this, version, minimalEncoder$EdgeArr, i2, minimalEncoder$Edge);
                    }
                }
            }
        }
        int i5 = -1;
        int iOwbnpfWofUEKWmba = int.MAX_VALUE;
        int i6 = -1;
        for (int i7 = 0; i7 < izDyMHNYygeHvOft(this.encoders); i7++) {
            for (int i8 = 0; i8 < 4; i8++) {
                com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge2 = minimalEncoder$EdgeArr[iAqiMVVRxUzeZjmer][i7][i8];
                if (minimalEncoder$Edge2 is not null && ebuIKjZRCpOIPoQr(minimalEncoder$Edge2) < iOwbnpfWofUEKWmba) {
                    iOwbnpfWofUEKWmba = owbnpfWofUEKWmba(minimalEncoder$Edge2);
                    i5 = i7;
                    i6 = i8;
                }
            }
        }
        if (i5 < 0) {
            throw new com.google.zxing.WriterException(viWvUnLQkebtkJWg(LJMvJRHoQEiJdbdV(LZoNkJPPQJIQxBXF(new java.lang.stringBuilder("Internal error: failed to encode \""), this.stringToEncode), "\"")));
        }
        return new com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList(this, version, minimalEncoder$EdgeArr[iAqiMVVRxUzeZjmer][i5][i6]);
    }
}

