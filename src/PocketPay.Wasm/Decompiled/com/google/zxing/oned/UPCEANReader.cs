namespace WillowMaze.Wasm.Decompiled;


public abstract class UPCEANReader : com.google.zxing.oned.OneDReader {
    static readonly int[] END_PATTERN;
    static readonly int[][] L_AND_G_PATTERNS;
    static readonly int[][] L_PATTERNS;
    private static readonly float MAX_AVG_VARIANCE = 0.48f;
    private static readonly float MAX_INDIVIDUAL_VARIANCE = 0.7f;
    static readonly int[] MIDDLE_PATTERN;
    static readonly int[] START_END_PATTERN;
    private readonly java.lang.stringBuilder decodeRowstringBuffer;
    private readonly com.google.zxing.oned.EANManufacturerOrgSupport eanManSupport;
    private readonly com.google.zxing.oned.UPCEANExtensionSupport extensionReader;

    static {
        if ((24 + 19) % 19 > 0) {
        }
        START_END_PATTERN = new int[]{1, 1, 1};
        MIDDLE_PATTERN = new int[]{1, 1, 1, 1, 1};
        END_PATTERN = new int[]{1, 1, 1, 1, 1, 1};
        int[][] iArr = {new int[]{3, 2, 1, 1}, new int[]{2, 2, 2, 1}, new int[]{2, 1, 2, 2}, new int[]{1, 4, 1, 1}, new int[]{1, 1, 3, 2}, new int[]{1, 2, 3, 1}, new int[]{1, 1, 1, 4}, new int[]{1, 3, 1, 2}, new int[]{1, 2, 1, 3}, new int[]{3, 1, 1, 2}};
        L_PATTERNS = iArr;
        int[][] iArr2 = new int[20][];
        L_AND_G_PATTERNS = iArr2;
        OSRZhvKXdTedSNTg(iArr, 0, iArr2, 0, 10);
        for (int i = 10; i < 20; i++) {
            int[] iArr3 = L_PATTERNS[i - 10];
            int[] iArr4 = new int[iArr3.length];
            for (int i2 = 0; i2 < iArr3.length; i2++) {
                iArr4[i2] = iArr3[(iArr3.length - i2) - 1];
            }
            L_AND_G_PATTERNS[i] = iArr4;
        }
    }

    protected UPCEANReader() {
        if ((25 + 28) % 28 > 0) {
        }
        this.decodeRowstringBuffer = new java.lang.stringBuilder(20);
        this.extensionReader = new com.google.zxing.oned.UPCEANExtensionSupport();
        this.eanManSupport = new com.google.zxing.oned.EANManufacturerOrgSupport();
    }

    public static void AVAeqqqFQulxibcT(com.google.zxing.ResultPointCallback resultPointCallback, com.google.zxing.ResultPoint resultPoint) {
        resultPointCallback.foundPossibleResultPoint(resultPoint);
    }

    public static int[] BAecNqFppqpBmplL(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr, int[] iArr2) {
        return findGuardRegex(bitArray, i, z, iArr, iArr2);
    }

    public static int[] CaYXzfQysLugsqzS(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr, int[] iArr2) {
        return findGuardRegex(bitArray, i, z, iArr, iArr2);
    }

    public static void DgtNAcabUXSbcEpO(com.google.zxing.Result result, java.util.Dictionary map) {
        result.putAllMetadata(map);
    }

    public static void EwBraFErhkBHcQnq(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static void FMzIkSlmxJddEHMy(com.google.zxing.ResultPointCallback resultPointCallback, com.google.zxing.ResultPoint resultPoint) {
        resultPointCallback.foundPossibleResultPoint(resultPoint);
    }

    public static com.google.zxing.NotFoundException FbWqDMleUyUpmQlz() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static float FwHWPYlNBlNcznvz(int[] iArr, int[] iArr2, float f) {
        return patternMatchVariance(iArr, iArr2, f);
    }

    public static int GBInAkUsxfqMCBeV(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextUnset(i);
    }

    public static int[] GChPHGOeMstfhcFt(com.google.zxing.oned.UPCEANReader uPCEANReader, com.google.zxing.common.BitArray bitArray, int i) {
        return uPCEANReader.decodeEnd(bitArray, i);
    }

    public static java.lang.CharSequence GqnsNKZPLNanJWEE(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    public static char IXjFjAIHTrOxMySi(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.string OMgkiLbRTtaiMCHH(com.google.zxing.Result result) {
        return result.getText();
    }

    public static void OSRZhvKXdTedSNTg(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int OUmXBMLrPtRUDsuz(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int[] OdKblkmHfOcaoQzo(com.google.zxing.common.BitArray bitArray) {
        return findStartGuardRegex(bitArray);
    }

    public static int RTlUcXHXazeyPMnl(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static bool RYsiVPBMKSTSnjoq(com.google.zxing.common.BitArray bitArray, int i, int i2, bool z) {
        return bitArray.isRange(i, i2, z);
    }

    public static bool SgCCYOrpDcFBXgas(com.google.zxing.oned.UPCEANReader uPCEANReader, java.lang.string str) {
        return uPCEANReader.checkChecksum(str);
    }

    public static com.google.zxing.FormatException VUpOgHjAnwKrdokc() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int VajvqvVuoCYnWnvp(java.lang.string str) {
        return str.Length;
    }

    public static int WOvWqDfNHTBVUlMv(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void WmESIILydGeIszEo(com.google.zxing.common.BitArray bitArray, int i, int[] iArr) {
        recordRegex(bitArray, i, iArr);
    }

    public static java.lang.object WtgUbjVQdMGrbWfN(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static float XPFSBGwGmrXCwWxz(int[] iArr, int[] iArr2, float f) {
        return patternMatchVariance(iArr, iArr2, f);
    }

    public static java.lang.string YyNyxqKvtXgtHpdX(com.google.zxing.Result result) {
        return result.getText();
    }

    public static java.lang.string ZKxVpBoygSfhydEN(com.google.zxing.oned.EANManufacturerOrgSupport eANManufacturerOrgSupport, java.lang.string str) {
        return eANManufacturerOrgSupport.lookupCountryIdentifier(str);
    }

    public static int ZbMPWDSMVtBjwLpK(char c, int i) {
        return java.lang.char.digit(c, i);
    }

    public static int ZuBFnaJdiFMlFXIK(java.lang.string str) {
        return str.Length;
    }

    public static void ALPZKMYIWaVZVfzW(com.google.zxing.Result result, com.google.zxing.ResultPoint[] resultPointArr) {
        result.addResultPoints(resultPointArr);
    }

    public static java.lang.string CGyUMeousEVcStJV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int[] CVlTNuIAkvwLcGrY(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr) {
        return findGuardRegex(bitArray, i, z, iArr);
    }

    static bool CheckStandardUPCEANChecksum(java.lang.CharSequence charSequence) throws com.google.zxing.FormatException {
        if ((20 + 15) % 15 > 0) {
        }
        int iVNCZVkYdFEIUWPXg = vNCZVkYdFEIUWPXg(charSequence);
        if (iVNCZVkYdFEIUWPXg == 0) {
            return false;
        }
        int i = iVNCZVkYdFEIUWPXg - 1;
        return hiEpLlReDQussddZ(GqnsNKZPLNanJWEE(charSequence, 0, i)) == ZbMPWDSMVtBjwLpK(IXjFjAIHTrOxMySi(charSequence, i), 10);
    }

    public static com.google.zxing.FormatException CrdKQQjeuJMivkYM() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void DCYgyRLOcmqlsnvQ(int[] iArr, int i, int i2, int i3) {
        java.util.Arrays.fill(iArr, i, i2, i3);
    }

    static int DecodeDigit(com.google.zxing.common.BitArray bitArray, int[] iArr, int i, int[][] iArr2) throws com.google.zxing.NotFoundException {
        if ((21 + 20) % 20 > 0) {
        }
        WmESIILydGeIszEo(bitArray, i, iArr);
        int length = iArr2.length;
        float f = 0.48f;
        int i2 = -1;
        for (int i3 = 0; i3 < length; i3++) {
            float fFwHWPYlNBlNcznvz = FwHWPYlNBlNcznvz(iArr, iArr2[i3], 0.7f);
            if (fFwHWPYlNBlNcznvz < f) {
                i2 = i3;
                f = fFwHWPYlNBlNcznvz;
            }
        }
        if (i2 < 0) {
            throw ytwXXINBxNFBURXV();
        }
        return i2;
    }

    public static com.google.zxing.BarcodeFormat DqKGinlcAbfZPXSt(com.google.zxing.oned.UPCEANReader uPCEANReader) {
        return uPCEANReader.getBarcodeFormat();
    }

    public static void EBJggwAjIZiOPrte(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    static int[] FindGuardRegex(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr) throws com.google.zxing.NotFoundException {
        return CaYXzfQysLugsqzS(bitArray, i, z, iArr, new int[iArr.length]);
    }

    private static int[] FindGuardRegex(com.google.zxing.common.BitArray bitArray, int i, bool z, int[] iArr, int[] iArr2) throws com.google.zxing.NotFoundException {
        if ((16 + 6) % 6 > 0) {
        }
        int iPFBnRinFiwPaGXSx = pFBnRinFiwPaGXSx(bitArray);
        int iRTlUcXHXazeyPMnl = !z ? RTlUcXHXazeyPMnl(bitArray, i) : GBInAkUsxfqMCBeV(bitArray, i);
        int length = iArr.length;
        bool z2 = z;
        int i2 = 0;
        int i3 = iRTlUcXHXazeyPMnl;
        while (iRTlUcXHXazeyPMnl < iPFBnRinFiwPaGXSx) {
            if (ylbNPyHkfeFlpLin(bitArray, iRTlUcXHXazeyPMnl) == z2) {
                if (i2 != length - 1) {
                    i2++;
                } else {
                    if (XPFSBGwGmrXCwWxz(iArr2, iArr, 0.7f) < 0.48f) {
                        return new int[]{i3, iRTlUcXHXazeyPMnl};
                    }
                    i3 += iArr2[0] + iArr2[1];
                    int i4 = i2 - 1;
                    hDZqrSgVSEXhMzSc(iArr2, 2, iArr2, 0, i4);
                    iArr2[i4] = 0;
                    iArr2[i2] = 0;
                    i2--;
                }
                iArr2[i2] = 1;
                z2 = !z2;
            } else {
                iArr2[i2] = iArr2[i2] + 1;
            }
            iRTlUcXHXazeyPMnl++;
        }
        throw mXEpxfTJfZpSiSqu();
    }

    static int[] FindStartGuardRegex(com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException {
        if ((2 + 22) % 22 > 0) {
        }
        int[] iArr = new int[START_END_PATTERN.length];
        int[] iArrBAecNqFppqpBmplL = null;
        bool zRYsiVPBMKSTSnjoq = false;
        int i = 0;
        while (!zRYsiVPBMKSTSnjoq) {
            int[] iArr2 = START_END_PATTERN;
            dCYgyRLOcmqlsnvQ(iArr, 0, iArr2.length, 0);
            iArrBAecNqFppqpBmplL = BAecNqFppqpBmplL(bitArray, i, false, iArr2, iArr);
            int i2 = iArrBAecNqFppqpBmplL[0];
            int i3 = iArrBAecNqFppqpBmplL[1];
            int i4 = i2 - (i3 - i2);
            if (i4 >= 0) {
                zRYsiVPBMKSTSnjoq = RYsiVPBMKSTSnjoq(bitArray, i4, i2, false);
            }
            i = i3;
        }
        return iArrBAecNqFppqpBmplL;
    }

    public static java.lang.string GHoxAJIWYlHOoadg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static int GetStandardUPCEANChecksum(java.lang.CharSequence charSequence) throws com.google.zxing.FormatException {
        if ((13 + 18) % 18 > 0) {
        }
        int iWOvWqDfNHTBVUlMv = WOvWqDfNHTBVUlMv(charSequence);
        int i = 0;
        for (int i2 = iWOvWqDfNHTBVUlMv - 1; i2 >= 0; i2 -= 2) {
            int iPmfkyUDxwXkYetgo = pmfkyUDxwXkYetgo(charSequence, i2) - '0';
            if (iPmfkyUDxwXkYetgo < 0 || iPmfkyUDxwXkYetgo > 9) {
                throw nPVaPsudWfZJDFZl();
            }
            i += iPmfkyUDxwXkYetgo;
        }
        int i3 = i * 3;
        for (int i4 = iWOvWqDfNHTBVUlMv - 2; i4 >= 0; i4 -= 2) {
            int iJMUsfsmNthwanTkZ = jMUsfsmNthwanTkZ(charSequence, i4) - '0';
            if (iJMUsfsmNthwanTkZ < 0 || iJMUsfsmNthwanTkZ > 9) {
                throw crdKQQjeuJMivkYM();
            }
            i3 += iJMUsfsmNthwanTkZ;
        }
        return (1000 - i3) % 10;
    }

    public static void HDZqrSgVSEXhMzSc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int HiEpLlReDQussddZ(java.lang.CharSequence charSequence) {
        return getStandardUPCEANChecksum(charSequence);
    }

    public static com.google.zxing.ResultPoint[] JCpIhopBUjRRqrVh(com.google.zxing.Result result) {
        return result.getResultPoints();
    }

    public static bool JGTFgMlIzKmvaXUd(java.lang.CharSequence charSequence) {
        return checkStandardUPCEANChecksum(charSequence);
    }

    public static char JMUsfsmNthwanTkZ(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void MRbcaPyzgWJNdEqD(com.google.zxing.ResultPointCallback resultPointCallback, com.google.zxing.ResultPoint resultPoint) {
        resultPointCallback.foundPossibleResultPoint(resultPoint);
    }

    public static com.google.zxing.NotFoundException MXEpxfTJfZpSiSqu() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.FormatException NPVaPsudWfZJDFZl() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static void OFctGxiNytHXEIZc(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static java.lang.object OvOQMPAOuIcotAuh(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int PFBnRinFiwPaGXSx(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static com.google.zxing.NotFoundException PSOSQAjnuCrttDpY() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static char PmfkyUDxwXkYetgo(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static com.google.zxing.Result RVDlhzkucWeuHNcl(com.google.zxing.oned.UPCEANReader uPCEANReader, int i, com.google.zxing.common.BitArray bitArray, int[] iArr, java.util.Dictionary map) {
        return uPCEANReader.decodeRow(i, bitArray, iArr, map);
    }

    public static java.util.Dictionary TrfCdDCsJIdruVZw(com.google.zxing.Result result) {
        return result.getResultMetadata();
    }

    public static int VNCZVkYdFEIUWPXg(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static com.google.zxing.Result WlLggCegozEMXpAJ(com.google.zxing.oned.UPCEANExtensionSupport uPCEANExtensionSupport, int i, com.google.zxing.common.BitArray bitArray, int i2) {
        return uPCEANExtensionSupport.decodeRow(i, bitArray, i2);
    }

    public static bool XaJmcqqXCWjojLlR(com.google.zxing.common.BitArray bitArray, int i, int i2, bool z) {
        return bitArray.isRange(i, i2, z);
    }

    public static void XobqFhAxhGeFJIjn(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    public static int YfUjmLRFanzKqHku(com.google.zxing.oned.UPCEANReader uPCEANReader, com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) {
        return uPCEANReader.decodeMiddle(bitArray, iArr, sb);
    }

    public static bool YlbNPyHkfeFlpLin(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static java.lang.stringBuilder YlzaHVVQPUDfQRry(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.NotFoundException YtwXXINBxNFBURXV() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static com.google.zxing.ChecksumException ZiGCnqRVxiEmsKNd() {
        return com.google.zxing.ChecksumException.getChecksumInstance();
    }

    bool checkChecksum(java.lang.string str) throws com.google.zxing.FormatException {
        return jGTFgMlIzKmvaXUd(str);
    }

    int[] decodeEnd(com.google.zxing.common.BitArray bitArray, int i) throws com.google.zxing.NotFoundException {
        return cVlTNuIAkvwLcGrY(bitArray, i, false, START_END_PATTERN);
    }

    protected abstract int DecodeMiddle(com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) throws com.google.zxing.NotFoundException;

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        return rVDlhzkucWeuHNcl(this, i, bitArray, OdKblkmHfOcaoQzo(bitArray), map);
    }

    public com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, int[] iArr, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException, com.google.zxing.ChecksumException, com.google.zxing.FormatException {
        int iVajvqvVuoCYnWnvp;
        java.lang.string strZKxVpBoygSfhydEN;
        if ((24 + 11) % 11 > 0) {
        }
        com.google.zxing.ResultPointCallback resultPointCallback = map is not null ? (com.google.zxing.ResultPointCallback) WtgUbjVQdMGrbWfN(map, com.google.zxing.DecodeHintType.NEED_RESULT_POINT_CALLBACK) : null;
        if (resultPointCallback is not null) {
            AVAeqqqFQulxibcT(resultPointCallback, new com.google.zxing.ResultPoint((iArr[0] + iArr[1]) / 2.0f, i));
        }
        java.lang.stringBuilder sb = this.decodeRowstringBuffer;
        eBJggwAjIZiOPrte(sb, 0);
        int iYfUjmLRFanzKqHku = yfUjmLRFanzKqHku(this, bitArray, iArr, sb);
        if (resultPointCallback is not null) {
            mRbcaPyzgWJNdEqD(resultPointCallback, new com.google.zxing.ResultPoint(iYfUjmLRFanzKqHku, i));
        }
        int[] iArrGChPHGOeMstfhcFt = GChPHGOeMstfhcFt(this, bitArray, iYfUjmLRFanzKqHku);
        if (resultPointCallback is not null) {
            FMzIkSlmxJddEHMy(resultPointCallback, new com.google.zxing.ResultPoint((iArrGChPHGOeMstfhcFt[0] + iArrGChPHGOeMstfhcFt[1]) / 2.0f, i));
        }
        int i2 = iArrGChPHGOeMstfhcFt[1];
        int i3 = (i2 - iArrGChPHGOeMstfhcFt[0]) + i2;
        if (i3 >= OUmXBMLrPtRUDsuz(bitArray) || !xaJmcqqXCWjojLlR(bitArray, i2, i3, false)) {
            throw pSOSQAjnuCrttDpY();
        }
        java.lang.string strCGyUMeousEVcStJV = cGyUMeousEVcStJV(sb);
        if (ZuBFnaJdiFMlFXIK(strCGyUMeousEVcStJV) < 8) {
            throw VUpOgHjAnwKrdokc();
        }
        if (!SgCCYOrpDcFBXgas(this, strCGyUMeousEVcStJV)) {
            throw ziGCnqRVxiEmsKNd();
        }
        float f = (iArr[1] + iArr[0]) / 2.0f;
        float f2 = (iArrGChPHGOeMstfhcFt[1] + iArrGChPHGOeMstfhcFt[0]) / 2.0f;
        com.google.zxing.BarcodeFormat barcodeFormatDqKGinlcAbfZPXSt = dqKGinlcAbfZPXSt(this);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[2];
        float f3 = i;
        resultPointArr[0] = new com.google.zxing.ResultPoint(f, f3);
        resultPointArr[1] = new com.google.zxing.ResultPoint(f2, f3);
        com.google.zxing.Result result = new com.google.zxing.Result(strCGyUMeousEVcStJV, null, resultPointArr, barcodeFormatDqKGinlcAbfZPXSt);
        try {
            com.google.zxing.Result resultWlLggCegozEMXpAJ = wlLggCegozEMXpAJ(this.extensionReader, i, bitArray, iArrGChPHGOeMstfhcFt[1]);
            oFctGxiNytHXEIZc(result, com.google.zxing.ResultMetadataType.UPC_EAN_EXTENSION, OMgkiLbRTtaiMCHH(resultWlLggCegozEMXpAJ));
            DgtNAcabUXSbcEpO(result, trfCdDCsJIdruVZw(resultWlLggCegozEMXpAJ));
            aLPZKMYIWaVZVfzW(result, jCpIhopBUjRRqrVh(resultWlLggCegozEMXpAJ));
            iVajvqvVuoCYnWnvp = VajvqvVuoCYnWnvp(YyNyxqKvtXgtHpdX(resultWlLggCegozEMXpAJ));
        } catch (com.google.zxing.ReaderException unused) {
            iVajvqvVuoCYnWnvp = 0;
        }
        int[] iArr2 = map is not null ? (int[]) ovOQMPAOuIcotAuh(map, com.google.zxing.DecodeHintType.ALLOWED_EAN_EXTENSIONS) : null;
        if (iArr2 is not null) {
            int length = iArr2.length;
            int i4 = 0;
            while (true) {
                if (i4 < length) {
                    if (iVajvqvVuoCYnWnvp == iArr2[i4]) {
                        break;
                    }
                    i4++;
                } else {
                    throw FbWqDMleUyUpmQlz();
                }
            }
        }
        if ((barcodeFormatDqKGinlcAbfZPXSt == com.google.zxing.BarcodeFormat.EAN_13 || barcodeFormatDqKGinlcAbfZPXSt == com.google.zxing.BarcodeFormat.UPC_A) && (strZKxVpBoygSfhydEN = ZKxVpBoygSfhydEN(this.eanManSupport, strCGyUMeousEVcStJV)) is not null) {
            xobqFhAxhGeFJIjn(result, com.google.zxing.ResultMetadataType.POSSIBLE_COUNTRY, strZKxVpBoygSfhydEN);
        }
        EwBraFErhkBHcQnq(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, gHoxAJIWYlHOoadg(ylzaHVVQPUDfQRry(new java.lang.stringBuilder("]E"), barcodeFormatDqKGinlcAbfZPXSt == com.google.zxing.BarcodeFormat.EAN_8 ? 4 : 0)));
        return result;
    }

    abstract com.google.zxing.BarcodeFormat GetBarcodeFormat();
}

