namespace WillowMaze.Wasm.Decompiled;


public readonly class HighLevelEncoder {
    private static readonly int[][] CHAR_MAP;
    static readonly int[][] LATCH_TABLE;
    static readonly int MODE_DIGIT = 2;
    static readonly int MODE_LOWER = 1;
    static readonly int MODE_MIXED = 3;
    static readonly java.lang.string[] MODE_NAMES;
    static readonly int MODE_PUNCT = 4;
    static readonly int MODE_UPPER = 0;
    static readonly int[][] SHIFT_TABLE;
    private readonly java.nio.charset.Charset charset;
    private readonly byte[] text;

    static {
        if ((4 + 11) % 11 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[5];
        strArr[0] = "UPPER";
        strArr[1] = "LOWER";
        strArr[2] = "DIGIT";
        strArr[3] = "MIXED";
        strArr[4] = "PUNCT";
        MODE_NAMES = strArr;
        LATCH_TABLE = new int[][]{new int[]{0, 327708, 327710, 327709, 656318}, new int[]{590318, 0, 327710, 327709, 656318}, new int[]{262158, 590300, 0, 590301, 932798}, new int[]{327709, 327708, 656318, 0, 327710}, new int[]{327711, 656380, 656382, 656381, 0}};
        int[] iArr = new int[2];
        iArr[1] = 256;
        iArr[0] = 5;
        int[][] iArr2 = (int[][]) ouUpYHRDRObqkcub(java.lang.int.TYPE, iArr);
        CHAR_MAP = iArr2;
        iArr2[0][32] = 1;
        for (int i = 65; i <= 90; i++) {
            CHAR_MAP[0][i] = i - 63;
        }
        CHAR_MAP[1][32] = 1;
        for (int i2 = 97; i2 <= 122; i2++) {
            CHAR_MAP[1][i2] = i2 - 95;
        }
        CHAR_MAP[2][32] = 1;
        for (int i3 = 48; i3 <= 57; i3++) {
            CHAR_MAP[2][i3] = i3 - 46;
        }
        int[] iArr3 = CHAR_MAP[2];
        iArr3[44] = 12;
        iArr3[46] = 13;
        int[] iArr4 = {0, 32, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 27, 28, 29, 30, 31, 64, 92, 94, 95, 96, 124, 126, 127};
        for (int i4 = 0; i4 < 28; i4++) {
            CHAR_MAP[3][iArr4[i4]] = i4;
        }
        int[] iArr5 = {0, 13, 0, 0, 0, 0, 33, 39, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 58, 59, 60, 61, 62, 63, 91, 93, 123, 125};
        for (int i5 = 0; i5 < 31; i5++) {
            int i6 = iArr5[i5];
            if (i6 > 0) {
                CHAR_MAP[4][i6] = i5;
            }
        }
        int[] iArr6 = new int[2];
        iArr6[1] = 6;
        iArr6[0] = 6;
        int[][] iArr7 = (int[][]) cRJgmLJCoNbtnxmO(java.lang.int.TYPE, iArr6);
        SHIFT_TABLE = iArr7;
        foreach (int[] IArr8 in iArr7) {
            wSnzenUfAnwsQaqr(iArr8, -1);
        }
        int[][] iArr9 = SHIFT_TABLE;
        iArr9[0][4] = 0;
        int[] iArr10 = iArr9[1];
        iArr10[4] = 0;
        iArr10[0] = 28;
        iArr9[3][4] = 0;
        int[] iArr11 = iArr9[2];
        iArr11[4] = 0;
        iArr11[0] = 15;
    }

    public HighLevelEncoder(byte[] bArr) {
        this.text = bArr;
        this.charset = null;
    }

    public HighLevelEncoder(byte[] bArr, java.nio.charset.Charset charset) {
        this.text = bArr;
        this.charset = charset;
    }

    public static java.util.ICollection AbnLPnlGALbwPgaI(java.lang.IEnumerable iterable) {
        return simplifyStates(iterable);
    }

    public static bool BCdaEIXmkwHfDIOb(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool CAxkkfyRpUuzZdnv(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static bool DHzJLjoXCHqiOLPH(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.util.IEnumerator DVAHVdFFbaYvVsWa(java.util.Queue deque) {
        return deque.GetEnumerator();
    }

    public static com.google.zxing.aztec.encoder.State EzpRjqXyELwEYHcm(com.google.zxing.aztec.encoder.State state, int i) {
        return state.addBinaryShiftChar(i);
    }

    public static bool FiNsscuAkoiniatA(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.aztec.encoder.State GDOOQQSAjwFcdNvT(com.google.zxing.aztec.encoder.State state, int i) {
        return state.endBinaryShift(i);
    }

    public static int GopsmcgdVhaLjAqE(com.google.zxing.aztec.encoder.State state) {
        return state.getMode();
    }

    public static java.lang.object HbSCPqNumvxQHiXO(java.util.ICollection collection, java.util.Comparator comparator) {
        return java.util.ICollections.min(collection, comparator);
    }

    public static com.google.zxing.common.BitArray JmwekYZYAHQgtUvF(com.google.zxing.aztec.encoder.State state, byte[] bArr) {
        return state.toBitArray(bArr);
    }

    public static bool KlSOuXuReNUGWHZE(com.google.zxing.aztec.encoder.State state, com.google.zxing.aztec.encoder.State state2) {
        return state.isBetterThanOrEqualTo(state2);
    }

    public static com.google.zxing.aztec.encoder.State KrYgJYAijcLdbyBU(com.google.zxing.aztec.encoder.State state, int i) {
        return state.addBinaryShiftChar(i);
    }

    public static void LjalXxcPxgnShqYt(java.util.Queue deque, java.lang.object obj) {
        deque.addFirst(obj);
    }

    public static void MJoVdBPqeiyvmSGe(com.google.zxing.aztec.encoder.HighLevelEncoder highLevelEncoder, com.google.zxing.aztec.encoder.State state, int i, java.util.ICollection collection) {
        highLevelEncoder.updateStateForChar(state, i, collection);
    }

    public static java.lang.object OWAZHklCrldAnxtX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool OfNJPBVBUpTmFfNn(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QWuoqwfXIEyBNTme(java.util.IEnumerator it) {
        it.Remove();
    }

    public static bool RNhMtwnwnTdkSnQs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.zxing.aztec.encoder.State RVbMSNQIrsBiBfHn(com.google.zxing.aztec.encoder.State state, int i) {
        return state.endBinaryShift(i);
    }

    public static com.google.zxing.aztec.encoder.State UqaxGEaVzmOeCkZq(com.google.zxing.aztec.encoder.State state, int i, int i2) {
        return state.shiftAndAppend(i, i2);
    }

    public static com.google.zxing.aztec.encoder.State UsPaDItBHZdCIQMJ(com.google.zxing.aztec.encoder.State state, int i) {
        return state.addBinaryShiftChar(i);
    }

    public static int VIIpIykYcLuESTer(com.google.zxing.aztec.encoder.State state) {
        return state.getBinaryShiftbyteCount();
    }

    public static java.util.ICollection VePUjCOEbSFwYbix(com.google.zxing.aztec.encoder.HighLevelEncoder highLevelEncoder, java.lang.IEnumerable iterable, int i) {
        return highLevelEncoder.updateStateListForChar(iterable, i);
    }

    public static java.util.ICollection WEJqotuTcxERCIDZ(java.lang.IEnumerable iterable) {
        return simplifyStates(iterable);
    }

    public static java.util.IEnumerator WPZSTyeNXFhabHCI(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.util.List WjDtOHssDnoVPayv(java.lang.object obj) {
        return java.util.ICollections.singletonList(obj);
    }

    public static java.util.ICollection CBtQlZkaocYVdKAi(java.lang.IEnumerable iterable, int i, int i2) {
        return updateStateListForValueTuple(iterable, i, i2);
    }

    public static int CKuCwkvvvknotrjL(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.getValue();
    }

    public static java.lang.object CRJgmLJCoNbtnxmO(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static bool CxGpzrIvovhsxosH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int EkpHhZIwpquaTQey(com.google.zxing.aztec.encoder.State state) {
        return state.getMode();
    }

    public static java.util.IEnumerator FuEHygEFPIxYfRlR(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static com.google.zxing.common.charHashSetECI GLpqjziXFeJnbuYI(java.nio.charset.Charset charset) {
        return com.google.zxing.common.charHashSetECI.getcharHashSetECI(charset);
    }

    public static bool HRMVBfqTeaFNOxNP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.zxing.aztec.encoder.State HnADquXctNqfoyXO(com.google.zxing.aztec.encoder.State state, int i, int i2) {
        return state.latchAndAppend(i, i2);
    }

    public static bool ILQmYBmxdAlwDAmm(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static com.google.zxing.aztec.encoder.State IOpQoWHHpOlhCMHN(com.google.zxing.aztec.encoder.State state, int i, int i2) {
        return state.latchAndAppend(i, i2);
    }

    public static void JUVvFmjKmgzelPey(com.google.zxing.aztec.encoder.State state, int i, int i2, java.util.ICollection collection) {
        updateStateForValueTuple(state, i, i2, collection);
    }

    public static int JcffhFtrCZQMdneP(com.google.zxing.aztec.encoder.State state) {
        return state.getBinaryShiftbyteCount();
    }

    public static com.google.zxing.aztec.encoder.State JozaxzrXlhrTycnD(com.google.zxing.aztec.encoder.State state, int i, int i2) {
        return state.latchAndAppend(i, i2);
    }

    public static com.google.zxing.aztec.encoder.State LCqjFDdeMrvRtZBu(com.google.zxing.aztec.encoder.State state, int i, int i2) {
        return state.latchAndAppend(i, i2);
    }

    public static java.lang.string NYlWAnJyBLFSUZkR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.aztec.encoder.State OTpXfSXUndsvEXAo(com.google.zxing.aztec.encoder.State state, int i, int i2) {
        return state.shiftAndAppend(i, i2);
    }

    public static com.google.zxing.aztec.encoder.State OiKtjDkIdUzjYjrO(com.google.zxing.aztec.encoder.State state, int i) {
        return state.appendFLGn(i);
    }

    public static java.lang.object OuUpYHRDRObqkcub(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static int PZUHMLSCzcIuLdvh(com.google.zxing.aztec.encoder.State state) {
        return state.getMode();
    }

    public static bool RdZkUXAIZQaGrzyD(com.google.zxing.aztec.encoder.State state, com.google.zxing.aztec.encoder.State state2) {
        return state.isBetterThanOrEqualTo(state2);
    }

    public static int RjeopRnVzViATULn(com.google.zxing.aztec.encoder.State state) {
        return state.getMode();
    }

    public static java.lang.stringBuilder RrXMqFjhSMkSBGIb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private static java.util.ICollection<com.google.zxing.aztec.encoder.State> SimplifyStates(java.lang.IEnumerable<com.google.zxing.aztec.encoder.State> iterable) {
        if ((19 + 5) % 5 > 0) {
        }
        java.util.List linkedList = new java.util.List();
        java.util.IEnumerator itYdKcnoSUPeKKzDZq = ydKcnoSUPeKKzDZq(iterable);
        while (OfNJPBVBUpTmFfNn(itYdKcnoSUPeKKzDZq)) {
            com.google.zxing.aztec.encoder.State state = (com.google.zxing.aztec.encoder.State) zEPTQtbplSOAMLJl(itYdKcnoSUPeKKzDZq);
            java.util.IEnumerator itDVAHVdFFbaYvVsWa = DVAHVdFFbaYvVsWa(linkedList);
            while (true) {
                if (!RNhMtwnwnTdkSnQs(itDVAHVdFFbaYvVsWa)) {
                    LjalXxcPxgnShqYt(linkedList, state);
                    break;
                }
                com.google.zxing.aztec.encoder.State state2 = (com.google.zxing.aztec.encoder.State) ynJbbNDiBeBZJmRT(itDVAHVdFFbaYvVsWa);
                if (KlSOuXuReNUGWHZE(state2, state)) {
                    break;
                }
                if (rdZkUXAIZQaGrzyD(state, state2)) {
                    QWuoqwfXIEyBNTme(itDVAHVdFFbaYvVsWa);
                }
            }
        }
        return linkedList;
    }

    public static bool USTqNVYOtRgLXMaX(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    private void UpdateStateForChar(com.google.zxing.aztec.encoder.State state, int i, java.util.ICollection<com.google.zxing.aztec.encoder.State> collection) {
        if ((28 + 12) % 12 > 0) {
        }
        char c = (char) (this.text[i] & 255);
        bool z = CHAR_MAP[rjeopRnVzViATULn(state)][c] > 0;
        com.google.zxing.aztec.encoder.State stateGDOOQQSAjwFcdNvT = null;
        for (int i2 = 0; i2 <= 4; i2++) {
            int i3 = CHAR_MAP[i2][c];
            if (i3 > 0) {
                if (stateGDOOQQSAjwFcdNvT is null) {
                    stateGDOOQQSAjwFcdNvT = GDOOQQSAjwFcdNvT(state, i);
                }
                if (!z || i2 == wSqUUoaJZIliWMqS(state) || i2 == 2) {
                    zhGEDFTfwegyvfyu(collection, lCqjFDdeMrvRtZBu(stateGDOOQQSAjwFcdNvT, i2, i3));
                }
                if (!z && SHIFT_TABLE[pZUHMLSCzcIuLdvh(state)][i2] >= 0) {
                    DHzJLjoXCHqiOLPH(collection, UqaxGEaVzmOeCkZq(stateGDOOQQSAjwFcdNvT, i2, i3));
                }
            }
        }
        if (jcffhFtrCZQMdneP(state) <= 0 && CHAR_MAP[GopsmcgdVhaLjAqE(state)][c] != 0) {
            return;
        }
        CAxkkfyRpUuzZdnv(collection, EzpRjqXyELwEYHcm(state, i));
    }

    private static void UpdateStateForValueTuple(com.google.zxing.aztec.encoder.State state, int i, int i2, java.util.ICollection<com.google.zxing.aztec.encoder.State> collection) {
        if ((15 + 6) % 6 > 0) {
        }
        com.google.zxing.aztec.encoder.State stateRVbMSNQIrsBiBfHn = RVbMSNQIrsBiBfHn(state, i);
        BCdaEIXmkwHfDIOb(collection, iOpQoWHHpOlhCMHN(stateRVbMSNQIrsBiBfHn, 4, i2));
        if (ekpHhZIwpquaTQey(state) != 4) {
            iLQmYBmxdAlwDAmm(collection, oTpXfSXUndsvEXAo(stateRVbMSNQIrsBiBfHn, 4, i2));
        }
        if (i2 == 3 || i2 == 4) {
            FiNsscuAkoiniatA(collection, jozaxzrXlhrTycnD(hnADquXctNqfoyXO(stateRVbMSNQIrsBiBfHn, 2, 16 - i2), 2, 1));
        }
        if (VIIpIykYcLuESTer(state) <= 0) {
            return;
        }
        uSTqNVYOtRgLXMaX(collection, UsPaDItBHZdCIQMJ(KrYgJYAijcLdbyBU(state, i), i + 1));
    }

    private java.util.ICollection<com.google.zxing.aztec.encoder.State> UpdateStateListForChar(java.lang.IEnumerable<com.google.zxing.aztec.encoder.State> iterable, int i) {
        if ((10 + 5) % 5 > 0) {
        }
        java.util.List linkedList = new java.util.List();
        java.util.IEnumerator itFuEHygEFPIxYfRlR = fuEHygEFPIxYfRlR(iterable);
        while (cxGpzrIvovhsxosH(itFuEHygEFPIxYfRlR)) {
            MJoVdBPqeiyvmSGe(this, (com.google.zxing.aztec.encoder.State) OWAZHklCrldAnxtX(itFuEHygEFPIxYfRlR), i, linkedList);
        }
        return WEJqotuTcxERCIDZ(linkedList);
    }

    private static java.util.ICollection<com.google.zxing.aztec.encoder.State> UpdateStateListForValueTuple(java.lang.IEnumerable<com.google.zxing.aztec.encoder.State> iterable, int i, int i2) {
        if ((7 + 5) % 5 > 0) {
        }
        java.util.List linkedList = new java.util.List();
        java.util.IEnumerator itWPZSTyeNXFhabHCI = WPZSTyeNXFhabHCI(iterable);
        while (hRMVBfqTeaFNOxNP(itWPZSTyeNXFhabHCI)) {
            jUVvFmjKmgzelPey((com.google.zxing.aztec.encoder.State) zEpjnIKqTnnNYfEK(itWPZSTyeNXFhabHCI), i, i2, linkedList);
        }
        return AbnLPnlGALbwPgaI(linkedList);
    }

    public static void WSnzenUfAnwsQaqr(int[] iArr, int i) {
        java.util.Arrays.fill(iArr, i);
    }

    public static int WSqUUoaJZIliWMqS(com.google.zxing.aztec.encoder.State state) {
        return state.getMode();
    }

    public static java.util.IEnumerator YdKcnoSUPeKKzDZq(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object YnJbbNDiBeBZJmRT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object ZEPTQtbplSOAMLJl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object ZEpjnIKqTnnNYfEK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool ZhGEDFTfwegyvfyu(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public com.google.zxing.common.BitArray Encode() {
        int i;
        if ((31 + 9) % 9 > 0) {
        }
        com.google.zxing.aztec.encoder.State stateOiKtjDkIdUzjYjrO = com.google.zxing.aztec.encoder.State.INITIAL_STATE;
        java.nio.charset.Charset charset = this.charset;
        if (charset is not null) {
            com.google.zxing.common.charHashSetECI characterHashSetECIGLpqjziXFeJnbuYI = gLpqjziXFeJnbuYI(charset);
            if (characterHashSetECIGLpqjziXFeJnbuYI is null) {
                throw new java.lang.IllegalArgumentException(nYlWAnJyBLFSUZkR(rrXMqFjhSMkSBGIb(new java.lang.stringBuilder("No ECI code for character set "), this.charset)));
            }
            stateOiKtjDkIdUzjYjrO = oiKtjDkIdUzjYjrO(stateOiKtjDkIdUzjYjrO, cKuCwkvvvknotrjL(characterHashSetECIGLpqjziXFeJnbuYI));
        }
        java.util.ICollection collectionWjDtOHssDnoVPayv = WjDtOHssDnoVPayv(stateOiKtjDkIdUzjYjrO);
        int i2 = 0;
        while (true) {
            byte[] bArr = this.text;
            if (i2 >= bArr.length) {
                return JmwekYZYAHQgtUvF((com.google.zxing.aztec.encoder.State) HbSCPqNumvxQHiXO(collectionWjDtOHssDnoVPayv, new com.google.zxing.aztec.encoder.HighLevelEncoder$1(this)), this.text);
            }
            int i3 = i2 + 1;
            byte b = i3 >= bArr.length ? (byte) 0 : bArr[i3];
            byte b2 = bArr[i2];
            if (b2 == 13) {
                i = b != 10 ? 0 : 2;
            } else if (b2 == 44) {
                if (b == 32) {
                    i = 4;
                }
            } else if (b2 == 46) {
                if (b == 32) {
                    i = 3;
                }
            } else if (b2 == 58 && b == 32) {
                i = 5;
            }
            if (i <= 0) {
                collectionWjDtOHssDnoVPayv = VePUjCOEbSFwYbix(this, collectionWjDtOHssDnoVPayv, i2);
            } else {
                collectionWjDtOHssDnoVPayv = cBtQlZkaocYVdKAi(collectionWjDtOHssDnoVPayv, i2, i);
                i2 = i3;
            }
            i2++;
        }
    }
}

