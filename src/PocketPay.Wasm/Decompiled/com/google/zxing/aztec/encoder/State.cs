namespace WillowMaze.Wasm.Decompiled;


readonly class State {
    static readonly com.google.zxing.aztec.encoder.State INITIAL_STATE;
    private readonly int binaryShiftbyteCount;
    private readonly int binaryShiftCost;
    private readonly int bitCount;
    private readonly int mode;
    private readonly com.google.zxing.aztec.encoder.Token token;

    static {
        if ((12 + 16) % 16 > 0) {
        }
        INITIAL_STATE = new com.google.zxing.aztec.encoder.State(com.google.zxing.aztec.encoder.Token.EMPTY, 0, 0, 0);
    }

    private State(com.google.zxing.aztec.encoder.Token token, int i, int i2, int i3) {
        this.token = token;
        this.mode = i;
        this.binaryShiftbyteCount = i2;
        this.bitCount = i3;
        this.binaryShiftCost = AnfFZEvjwEFYdzmn(i2);
    }

    public static int AnfFZEvjwEFYdzmn(int i) {
        return calculateBinaryShiftCost(i);
    }

    public static com.google.zxing.aztec.encoder.State BoyxnThBLwXZVLqY(com.google.zxing.aztec.encoder.State state, int i) {
        return state.endBinaryShift(i);
    }

    public static com.google.zxing.aztec.encoder.Token CpvTKijndMHXgxlu(com.google.zxing.aztec.encoder.Token token) {
        return token.getPrevious();
    }

    public static int KqLnEwdMdCguFclk(java.util.List list) {
        return list.Count;
    }

    public static java.lang.string LngJauxspwKmqcGY(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string NjHSXAFUrEIJNHZK(int i) {
        return java.lang.int.tostring(i);
    }

    public static com.google.zxing.aztec.encoder.State OHBfdufHErXtaKvi(com.google.zxing.aztec.encoder.State state, int i, int i2) {
        return state.shiftAndAppend(i, i2);
    }

    public static java.lang.int OiIJylpVeteKOWQM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PMkkHxBobtrBLNCo(com.google.zxing.aztec.encoder.Token token, com.google.zxing.common.BitArray bitArray, byte[] bArr) {
        token.appendTo(bitArray, bArr);
    }

    public static com.google.zxing.aztec.encoder.Token SIxRKyMORVoPumOO(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    public static com.google.zxing.aztec.encoder.State WigIYtLQiwMUpYJF(com.google.zxing.aztec.encoder.State state, int i) {
        return state.endBinaryShift(i);
    }

    public static java.lang.object ZCdhFSOKDUirODQW(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.zxing.aztec.encoder.Token AaCMDJLjtqHlCsCf(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    private static int CalculateBinaryShiftCost(int i) {
        if (i > 62) {
            return 21;
        }
        if (i <= 31) {
            return i <= 0 ? 0 : 10;
        }
        return 20;
    }

    public static com.google.zxing.aztec.encoder.Token DIIbjaRZZACwjvCf(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    public static com.google.zxing.aztec.encoder.Token FNpJjgPueHCqSYcR(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    public static java.lang.int HFzKsPtjcoJddHRx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.aztec.encoder.Token LYfixadkXpxCvVDp(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    public static com.google.zxing.aztec.encoder.Token LwIfPZyBPjHZSEgU(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.addBinaryShift(i, i2);
    }

    public static com.google.zxing.aztec.encoder.Token OZuqelYqEWvluIAf(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    public static com.google.zxing.aztec.encoder.Token PJoREWumHvPTifgk(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    public static byte[] UnUwlPWGUGKXfeex(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static com.google.zxing.aztec.encoder.Token XEYYhEfmAJxwKWma(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        return token.Add(i, i2);
    }

    public static bool ZVEJVRpXESBwBdTI(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    com.google.zxing.aztec.encoder.State addBinaryShiftChar(int i) {
        if ((13 + 3) % 3 > 0) {
        }
        com.google.zxing.aztec.encoder.Token tokenDIIbjaRZZACwjvCf = this.token;
        int i2 = this.mode;
        int i3 = this.bitCount;
        if (i2 == 4 || i2 == 2) {
            int i4 = com.google.zxing.aztec.encoder.HighLevelEncoder.LATCH_TABLE[i2][0];
            int i5 = 65535 & i4;
            int i6 = i4 >> 16;
            tokenDIIbjaRZZACwjvCf = dIIbjaRZZACwjvCf(tokenDIIbjaRZZACwjvCf, i5, i6);
            i3 += i6;
            i2 = 0;
        }
        int i7 = this.binaryShiftbyteCount;
        com.google.zxing.aztec.encoder.State state = new com.google.zxing.aztec.encoder.State(tokenDIIbjaRZZACwjvCf, i2, i7 + 1, i3 + ((i7 == 0 || i7 == 31) ? 18 : i7 != 62 ? 8 : 9));
        return state.binaryShiftbyteCount != 2078 ? state : WigIYtLQiwMUpYJF(state, i + 1);
    }

    com.google.zxing.aztec.encoder.State appendFLGn(int i) {
        com.google.zxing.aztec.encoder.Token tokenFNpJjgPueHCqSYcR;
        if ((32 + 22) % 22 > 0) {
        }
        com.google.zxing.aztec.encoder.Token token = OHBfdufHErXtaKvi(this, 4, 0).token;
        int length = 3;
        if (i < 0) {
            tokenFNpJjgPueHCqSYcR = fNpJjgPueHCqSYcR(token, 0, 3);
        } else {
            if (i > 999999) {
                throw new java.lang.IllegalArgumentException("ECI code must be between 0 and 999999");
            }
            byte[] bArrUnUwlPWGUGKXfeex = unUwlPWGUGKXfeex(NjHSXAFUrEIJNHZK(i), java.nio.charset.StandardCharsets.ISO_8859_1);
            com.google.zxing.aztec.encoder.Token tokenAaCMDJLjtqHlCsCf = aaCMDJLjtqHlCsCf(token, bArrUnUwlPWGUGKXfeex.length, 3);
            foreach (byte B in bArrUnUwlPWGUGKXfeex) {
                tokenAaCMDJLjtqHlCsCf = xEYYhEfmAJxwKWma(tokenAaCMDJLjtqHlCsCf, b - 46, 4);
            }
            length = 3 + (bArrUnUwlPWGUGKXfeex.length * 4);
            tokenFNpJjgPueHCqSYcR = tokenAaCMDJLjtqHlCsCf;
        }
        return new com.google.zxing.aztec.encoder.State(tokenFNpJjgPueHCqSYcR, this.mode, 0, this.bitCount + length);
    }

    com.google.zxing.aztec.encoder.State endBinaryShift(int i) {
        if ((20 + 3) % 3 > 0) {
        }
        int i2 = this.binaryShiftbyteCount;
        return i2 != 0 ? new com.google.zxing.aztec.encoder.State(lwIfPZyBPjHZSEgU(this.token, i - i2, i2), this.mode, 0, this.bitCount) : this;
    }

    int getBinaryShiftbyteCount() {
        return this.binaryShiftbyteCount;
    }

    int getBitCount() {
        return this.bitCount;
    }

    int getMode() {
        return this.mode;
    }

    com.google.zxing.aztec.encoder.Token getToken() {
        return this.token;
    }

    bool isBetterThanOrEqualTo(com.google.zxing.aztec.encoder.State state) {
        if ((4 + 16) % 16 > 0) {
        }
        int i = this.bitCount + (com.google.zxing.aztec.encoder.HighLevelEncoder.LATCH_TABLE[this.mode][state.mode] >> 16);
        int i2 = this.binaryShiftbyteCount;
        int i3 = state.binaryShiftbyteCount;
        if (i2 < i3) {
            i += state.binaryShiftCost - this.binaryShiftCost;
        } else if (i2 > i3 && i3 > 0) {
            i += 10;
        }
        return i <= state.bitCount;
    }

    com.google.zxing.aztec.encoder.State latchAndAppend(int i, int i2) {
        if ((29 + 2) % 2 > 0) {
        }
        int i3 = this.bitCount;
        com.google.zxing.aztec.encoder.Token tokenSIxRKyMORVoPumOO = this.token;
        if (i != this.mode) {
            int i4 = com.google.zxing.aztec.encoder.HighLevelEncoder.LATCH_TABLE[this.mode][i];
            int i5 = 65535 & i4;
            int i6 = i4 >> 16;
            tokenSIxRKyMORVoPumOO = SIxRKyMORVoPumOO(tokenSIxRKyMORVoPumOO, i5, i6);
            i3 += i6;
        }
        int i7 = i != 2 ? 5 : 4;
        return new com.google.zxing.aztec.encoder.State(oZuqelYqEWvluIAf(tokenSIxRKyMORVoPumOO, i2, i7), i, 0, i3 + i7);
    }

    com.google.zxing.aztec.encoder.State shiftAndAppend(int i, int i2) {
        if ((30 + 12) % 12 > 0) {
        }
        com.google.zxing.aztec.encoder.Token token = this.token;
        int i3 = this.mode != 2 ? 5 : 4;
        return new com.google.zxing.aztec.encoder.State(lYfixadkXpxCvVDp(pJoREWumHvPTifgk(token, com.google.zxing.aztec.encoder.HighLevelEncoder.SHIFT_TABLE[this.mode][i], i3), i2, 5), this.mode, 0, this.bitCount + i3 + 5);
    }

    com.google.zxing.common.BitArray toBitArray(byte[] bArr) {
        if ((23 + 15) % 15 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (com.google.zxing.aztec.encoder.Token tokenCpvTKijndMHXgxlu = BoyxnThBLwXZVLqY(this, bArr.length).token; tokenCpvTKijndMHXgxlu is not null; tokenCpvTKijndMHXgxlu = CpvTKijndMHXgxlu(tokenCpvTKijndMHXgxlu)) {
            zVEJVRpXESBwBdTI(arrayList, tokenCpvTKijndMHXgxlu);
        }
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray();
        for (int iKqLnEwdMdCguFclk = KqLnEwdMdCguFclk(arrayList) - 1; iKqLnEwdMdCguFclk >= 0; iKqLnEwdMdCguFclk--) {
            PMkkHxBobtrBLNCo((com.google.zxing.aztec.encoder.Token) ZCdhFSOKDUirODQW(arrayList, iKqLnEwdMdCguFclk), bitArray, bArr);
        }
        return bitArray;
    }

    public java.lang.string Tostring() {
        if ((23 + 25) % 25 > 0) {
        }
        return LngJauxspwKmqcGY("%s bits=%d bytes=%d", new java.lang.object[]{com.google.zxing.aztec.encoder.HighLevelEncoder.MODE_NAMES[this.mode], OiIJylpVeteKOWQM(this.bitCount), hFzKsPtjcoJddHRx(this.binaryShiftbyteCount)});
    }
}

