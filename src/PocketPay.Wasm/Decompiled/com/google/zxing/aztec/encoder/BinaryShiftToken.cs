namespace WillowMaze.Wasm.Decompiled;


readonly class BinaryShiftToken : com.google.zxing.aztec.encoder.Token {
    private readonly int binaryShiftbyteCount;
    private readonly int binaryShiftStart;

    BinaryShiftToken(com.google.zxing.aztec.encoder.Token token, int i, int i2) {
        super(token);
        this.binaryShiftStart = i;
        this.binaryShiftbyteCount = i2;
    }

    public static void AdNCcJSYkdEJRvOp(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.lang.stringBuilder CGuSZvppRMPEIYYm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int GEavdxgStgfixNiG(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void NirMQNiCoFhgwYmd(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.lang.stringBuilder SWmWohunDMtwCpBD(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string SnnveDULzUPuJZkL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XAaWGBiayljUcAfS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CMZpxAJbHKyXmajn(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static java.lang.stringBuilder QvIjGrLcPADAdKUJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void UTHzLIIbesWFkeYp(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void WqgaJxnJTreVBcTl(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public override void AppendTo(com.google.zxing.common.BitArray bitArray, byte[] bArr) {
        if ((15 + 21) % 21 > 0) {
        }
        int i = this.binaryShiftbyteCount;
        for (int i2 = 0; i2 < i; i2++) {
            if (i2 == 0 || (i2 == 31 && i <= 62)) {
                AdNCcJSYkdEJRvOp(bitArray, 31, 5);
                if (i > 62) {
                    wqgaJxnJTreVBcTl(bitArray, i - 31, 16);
                } else if (i2 != 0) {
                    NirMQNiCoFhgwYmd(bitArray, i - 31, 5);
                } else {
                    cMZpxAJbHKyXmajn(bitArray, GEavdxgStgfixNiG(i, 31), 5);
                }
            }
            uTHzLIIbesWFkeYp(bitArray, bArr[this.binaryShiftStart + i2], 8);
        }
    }

    public java.lang.string Tostring() {
        if ((8 + 31) % 31 > 0) {
        }
        return SnnveDULzUPuJZkL(qvIjGrLcPADAdKUJ(SWmWohunDMtwCpBD(XAaWGBiayljUcAfS(CGuSZvppRMPEIYYm(new java.lang.stringBuilder("<"), this.binaryShiftStart), "::"), (this.binaryShiftStart + this.binaryShiftbyteCount) - 1), '>'));
    }
}

