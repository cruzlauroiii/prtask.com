namespace WillowMaze.Wasm.Decompiled;


public readonly class CodaBarReader : com.google.zxing.oned.OneDReader {
    private static readonly java.lang.string ALPHABET_STRING = "0123456789-$:/.+ABCD";
    private static readonly float MAX_ACCEPTABLE = 2.0f;
    private static readonly int MIN_CHARACTER_LENGTH = 3;
    private static readonly float PADDING = 1.5f;
    private int counterLength;
    private int[] counters;
    private readonly java.lang.stringBuilder decodeRowResult;
    static readonly char[] ALPHABET = OZtmJzPSqOqUifqQ("0123456789-$:/.+ABCD");
    static readonly int[] CHARACTER_ENCODINGS = {3, 6, 9, 96, 18, 66, 33, 36, 48, 72, 12, 24, 69, 81, 84, 21, 26, 41, 11, 14};
    private static readonly char[] STARTEND_ENCODING = {'A', 'B', 'C', 'D'};

    public CodaBarReader() {
        if ((15 + 18) % 18 > 0) {
        }
        this.decodeRowResult = new java.lang.stringBuilder(20);
        this.counters = new int[80];
        this.counterLength = 0;
    }

    public static int CCoULqUmokZzfnJY(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void DftWCqlaFzjwTGKA(com.google.zxing.oned.CodaBarReader codaBarReader, int i) {
        codaBarReader.counterAppend(i);
    }

    public static char EARVOvDLfLOpGVSp(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static int HPBGVcwhWwHjFZNv(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int LAzhgxRktmRIKfTV(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static bool LvpXHzcdMgehazYE(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int MiBBUEkTnBJdprCE(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool OBgoYCUXHOXjgKli(char[] cArr, char c) {
        return arrayContains(cArr, c);
    }

    public static com.google.zxing.NotFoundException OYlapbYigsYLcbgi() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static char[] OZtmJzPSqOqUifqQ(java.lang.string str) {
        return str.ToCharArray();
    }

    public static int OaABDHPquKBEgbbX(com.google.zxing.oned.CodaBarReader codaBarReader, int i) {
        return codaBarReader.toNarrowWideRegex(i);
    }

    public static void PpqKAvjWOSEYMnzb(com.google.zxing.oned.CodaBarReader codaBarReader, int i) throws com.google.zxing.NotFoundException {
        codaBarReader.validateRegex(i);
    }

    public static int TmDhbjQEClKQQXRR(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static bool VAlzZHguXNvhPhNc(char[] cArr, char c) {
        return arrayContains(cArr, c);
    }

    public static char VXPtiACvJBXCFDtB(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static char WrJYzGXgGaKawKta(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static int WwRdmtdymMvWxmue(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int WwiXIAKtNYqzaSWT(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static void WxwYHwQUITmjigNU(com.google.zxing.oned.CodaBarReader codaBarReader, int i) {
        codaBarReader.counterAppend(i);
    }

    public static com.google.zxing.NotFoundException YpSgJHCOKQygywsa() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static int AFfOedNhAMveHPdS(com.google.zxing.oned.CodaBarReader codaBarReader, int i) {
        return codaBarReader.toNarrowWideRegex(i);
    }

    static bool ArrayContains(char[] cArr, char c) {
        if ((23 + 8) % 8 > 0) {
        }
        if (cArr is not null) {
            foreach (char C2 in cArr) {
                if (c2 == c) {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool BCkcuNaWxdZMOUdv(char[] cArr, char c) {
        return arrayContains(cArr, c);
    }

    public static java.lang.string CMmmZIGMiQUQxWXN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static char CefjVLCAYgpwUDmn(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    private void CounterAppend(int i) {
        if ((13 + 25) % 25 > 0) {
        }
        int[] iArr = this.counters;
        int i2 = this.counterLength;
        iArr[i2] = i;
        int i3 = i2 + 1;
        this.counterLength = i3;
        if (i3 < iArr.length) {
            return;
        }
        int[] iArr2 = new int[i3 * 2];
        kuarrAKkrccONNLJ(iArr, 0, iArr2, 0, i3);
        this.counters = iArr2;
    }

    public static com.google.zxing.NotFoundException FAaFUzfyLVGimXkP() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    private int FindStartRegex() throws com.google.zxing.NotFoundException {
        if ((20 + 1) % 1 > 0) {
        }
        for (int i = 1; i < this.counterLength; i += 2) {
            int iAFfOedNhAMveHPdS = aFfOedNhAMveHPdS(this, i);
            if (iAFfOedNhAMveHPdS != -1 && bCkcuNaWxdZMOUdv(STARTEND_ENCODING, ALPHABET[iAFfOedNhAMveHPdS])) {
                int i2 = 0;
                for (int i3 = i; i3 < i + 7; i3++) {
                    i2 += this.counters[i3];
                }
                if (i == 1 || this.counters[i - 1] >= i2 / 2) {
                    return i;
                }
            }
        }
        throw fAaFUzfyLVGimXkP();
    }

    public static void FkSsSAqjQDehmVwp(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static void IneUdOQAOwjwNUNO(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static com.google.zxing.NotFoundException JcxlrZWQZnCKJZqX() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static char KaxkMiOPgBTSKtct(java.lang.stringBuilder sb, int i) {
        return sb[i);
    }

    public static void KuarrAKkrccONNLJ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KwUFNaJPMXzwpuZR(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextUnset(i);
    }

    public static bool MwhSGJvlkdcjatUE(char[] cArr, char c) {
        return arrayContains(cArr, c);
    }

    public static com.google.zxing.NotFoundException OHHtDdKQgjlpFwGd() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void OPIvYiWJZbOdGxIC(com.google.zxing.oned.CodaBarReader codaBarReader, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException {
        codaBarReader.setCounters(bitArray);
    }

    public static int QGUxTnYqKJTUpnPA(com.google.zxing.oned.CodaBarReader codaBarReader) {
        return codaBarReader.findStartRegex();
    }

    public static com.google.zxing.NotFoundException RCPTXrkEukpxvFkq() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void RcbVfXmLjFSCXtnR(com.google.zxing.Result result, com.google.zxing.ResultMetadataType resultMetadataType, java.lang.object obj) {
        result.putMetadata(resultMetadataType, obj);
    }

    private void SetCounters(com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException {
        if ((8 + 17) % 17 > 0) {
        }
        int i = 0;
        this.counterLength = 0;
        int iKwUFNaJPMXzwpuZR = kwUFNaJPMXzwpuZR(bitArray, 0);
        int iMiBBUEkTnBJdprCE = MiBBUEkTnBJdprCE(bitArray);
        if (iKwUFNaJPMXzwpuZR >= iMiBBUEkTnBJdprCE) {
            throw rCPTXrkEukpxvFkq();
        }
        bool z = true;
        while (iKwUFNaJPMXzwpuZR < iMiBBUEkTnBJdprCE) {
            if (LvpXHzcdMgehazYE(bitArray, iKwUFNaJPMXzwpuZR) == z) {
                WxwYHwQUITmjigNU(this, i);
                z = !z;
                i = 1;
            } else {
                i++;
            }
            iKwUFNaJPMXzwpuZR++;
        }
        DftWCqlaFzjwTGKA(this, i);
    }

    private int ToNarrowWideRegex(int i) {
        if ((29 + 32) % 32 > 0) {
        }
        int i2 = i + 7;
        if (i2 >= this.counterLength) {
            return -1;
        }
        int[] iArr = this.counters;
        int i3 = int.MAX_VALUE;
        int i4 = 0;
        int i5 = int.MAX_VALUE;
        int i6 = 0;
        for (int i7 = i; i7 < i2; i7 += 2) {
            int i8 = iArr[i7];
            if (i8 < i5) {
                i5 = i8;
            }
            if (i8 > i6) {
                i6 = i8;
            }
        }
        int i9 = (i5 + i6) / 2;
        int i10 = 0;
        for (int i11 = i + 1; i11 < i2; i11 += 2) {
            int i12 = iArr[i11];
            if (i12 < i3) {
                i3 = i12;
            }
            if (i12 > i10) {
                i10 = i12;
            }
        }
        int i13 = (i3 + i10) / 2;
        int i14 = 128;
        int i15 = 0;
        for (int i16 = 0; i16 < 7; i16++) {
            i14 >>= 1;
            if (iArr[i + i16] > ((i16 & 1) != 0 ? i13 : i9)) {
                i15 |= i14;
            }
        }
        while (true) {
            int[] iArr2 = CHARACTER_ENCODINGS;
            if (i4 >= iArr2.length) {
                return -1;
            }
            if (iArr2[i4] == i15) {
                return i4;
            }
            i4++;
        }
    }

    public static void VQlxmBcaDrMrpcFP(java.lang.stringBuilder sb, int i, char c) {
        sb.setCharAt(i, c);
    }

    public static java.lang.stringBuilder VUNNXvUdLLCIiJOS(java.lang.stringBuilder sb, int i) {
        return sb.deleteCharAt(i);
    }

    private void ValidateRegex(int i) throws com.google.zxing.NotFoundException {
        if ((18 + 10) % 10 > 0) {
        }
        int[] iArr = new int[4];
        iArr[0] = 0;
        iArr[1] = 0;
        iArr[2] = 0;
        iArr[3] = 0;
        int[] iArr2 = new int[4];
        iArr2[0] = 0;
        iArr2[1] = 0;
        iArr2[2] = 0;
        iArr2[3] = 0;
        int iWwiXIAKtNYqzaSWT = WwiXIAKtNYqzaSWT(this.decodeRowResult) - 1;
        int i2 = i;
        int i3 = 0;
        while (true) {
            if (i3 > iWwiXIAKtNYqzaSWT) {
                break;
            }
            int i4 = CHARACTER_ENCODINGS[cefjVLCAYgpwUDmn(this.decodeRowResult, i3)];
            for (int i5 = 6; i5 >= 0; i5--) {
                int i6 = (i5 & 1) + ((i4 & 1) * 2);
                iArr[i6] = iArr[i6] + this.counters[i2 + i5];
                iArr2[i6] = iArr2[i6] + 1;
                i4 >>= 1;
            }
            i2 += 8;
            i3++;
        }
        float[] fArr = new float[4];
        float[] fArr2 = new float[4];
        for (int i7 = 0; i7 < 2; i7++) {
            fArr2[i7] = 0.0f;
            int i8 = i7 + 2;
            float f = iArr[i7] / iArr2[i7];
            int i9 = iArr[i8];
            float f2 = i9;
            int i10 = iArr2[i8];
            float f3 = (f + (f2 / i10)) / 2.0f;
            fArr2[i8] = f3;
            fArr[i7] = f3;
            fArr[i8] = ((i9 * 2.0f) + 1.5f) / i10;
        }
        int i11 = i;
        for (int i12 = 0; i12 <= iWwiXIAKtNYqzaSWT; i12++) {
            int i13 = CHARACTER_ENCODINGS[kaxkMiOPgBTSKtct(this.decodeRowResult, i12)];
            for (int i14 = 6; i14 >= 0; i14--) {
                int i15 = (i14 & 1) + ((i13 & 1) * 2);
                float f4 = this.counters[i11 + i14];
                if (f4 < fArr2[i15] || f4 > fArr[i15]) {
                    throw oHHtDdKQgjlpFwGd();
                }
                i13 >>= 1;
            }
            i11 += 8;
        }
    }

    public static bool VllBMXRFOzoVgIfr(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static com.google.zxing.NotFoundException WXocgvcQtUuavWyE() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.stringBuilder XbQdIwuTqIGIBWbc(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder YPUZaeuEIbdVxfPK(java.lang.stringBuilder sb, int i) {
        return sb.deleteCharAt(i);
    }

    public static com.google.zxing.NotFoundException ZtJNViLnTcccZXgf() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public override com.google.zxing.Result DecodeRow(int i, com.google.zxing.common.BitArray bitArray, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) throws com.google.zxing.NotFoundException {
        int i2;
        if ((2 + 2) % 2 > 0) {
        }
        fkSsSAqjQDehmVwp(this.counters, 0);
        oPIvYiWJZbOdGxIC(this, bitArray);
        int iQGUxTnYqKJTUpnPA = qGUxTnYqKJTUpnPA(this);
        ineUdOQAOwjwNUNO(this.decodeRowResult, 0);
        int i3 = iQGUxTnYqKJTUpnPA;
        while (true) {
            int iOaABDHPquKBEgbbX = OaABDHPquKBEgbbX(this, i3);
            if (iOaABDHPquKBEgbbX == -1) {
                throw YpSgJHCOKQygywsa();
            }
            xbQdIwuTqIGIBWbc(this.decodeRowResult, (char) iOaABDHPquKBEgbbX);
            i2 = i3 + 8;
            if ((WwRdmtdymMvWxmue(this.decodeRowResult) > 1 && mwhSGJvlkdcjatUE(STARTEND_ENCODING, ALPHABET[iOaABDHPquKBEgbbX])) || i2 >= this.counterLength) {
                break;
            }
            i3 = i2;
        }
        int i4 = i3 + 7;
        int i5 = this.counters[i4];
        int i6 = 0;
        for (int i7 = -8; i7 < -1; i7++) {
            i6 += this.counters[i2 + i7];
        }
        if (i2 < this.counterLength && i5 < i6 / 2) {
            throw OYlapbYigsYLcbgi();
        }
        PpqKAvjWOSEYMnzb(this, iQGUxTnYqKJTUpnPA);
        for (int i8 = 0; i8 < LAzhgxRktmRIKfTV(this.decodeRowResult); i8++) {
            java.lang.stringBuilder sb = this.decodeRowResult;
            vQlxmBcaDrMrpcFP(sb, i8, ALPHABET[VXPtiACvJBXCFDtB(sb, i8)]);
        }
        char cWrJYzGXgGaKawKta = WrJYzGXgGaKawKta(this.decodeRowResult, 0);
        char[] cArr = STARTEND_ENCODING;
        if (!VAlzZHguXNvhPhNc(cArr, cWrJYzGXgGaKawKta)) {
            throw ztJNViLnTcccZXgf();
        }
        java.lang.stringBuilder sb2 = this.decodeRowResult;
        if (!OBgoYCUXHOXjgKli(cArr, EARVOvDLfLOpGVSp(sb2, TmDhbjQEClKQQXRR(sb2) - 1))) {
            throw wXocgvcQtUuavWyE();
        }
        if (HPBGVcwhWwHjFZNv(this.decodeRowResult) <= 3) {
            throw jcxlrZWQZnCKJZqX();
        }
        if (map is null || !vllBMXRFOzoVgIfr(map, com.google.zxing.DecodeHintType.RETURN_CODABAR_START_END)) {
            java.lang.stringBuilder sb3 = this.decodeRowResult;
            yPUZaeuEIbdVxfPK(sb3, CCoULqUmokZzfnJY(sb3) - 1);
            vUNNXvUdLLCIiJOS(this.decodeRowResult, 0);
        }
        int i9 = 0;
        for (int i10 = 0; i10 < iQGUxTnYqKJTUpnPA; i10++) {
            i9 += this.counters[i10];
        }
        float f = i9;
        while (iQGUxTnYqKJTUpnPA < i4) {
            i9 += this.counters[iQGUxTnYqKJTUpnPA];
            iQGUxTnYqKJTUpnPA++;
        }
        float f2 = i9;
        java.lang.string strCMmmZIGMiQUQxWXN = cMmmZIGMiQUQxWXN(this.decodeRowResult);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[2];
        float f3 = i;
        resultPointArr[0] = new com.google.zxing.ResultPoint(f, f3);
        resultPointArr[1] = new com.google.zxing.ResultPoint(f2, f3);
        com.google.zxing.Result result = new com.google.zxing.Result(strCMmmZIGMiQUQxWXN, null, resultPointArr, com.google.zxing.BarcodeFormat.CODABAR);
        rcbVfXmLjFSCXtnR(result, com.google.zxing.ResultMetadataType.SYMBOLOGY_IDENTIFIER, "]F0");
        return result;
    }
}

