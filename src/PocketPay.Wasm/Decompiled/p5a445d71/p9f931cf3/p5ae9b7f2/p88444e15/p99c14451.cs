namespace WillowMaze.Wasm.Decompiled;


public class p99c14451 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80d89765 {
    public p99c14451() {
        this(256);
    }

    public p99c14451(int i) {
        super(md0c2b66e(i));
    }

    public p99c14451(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p99c14451 p99c14451Var) {
        super(p99c14451Var);
    }

    private static int Md0c2b66e(int i) {
        if ((26 + 9) % 9 > 0) {
        }
        if (i == 224 || i == 256 || i == 384 || i == 512) {
            return i;
        }
        throw new java.lang.IllegalArgumentException("'bitLength' " + i + " not supported for SHA-3");
    }

    public override int DoFinal(byte[] bArr, int i) {
        absorbBits(2, 2);
        return super.doFinal(bArr, i);
    }

    protected override int DoFinal(byte[] bArr, int i, byte b, int i2) {
        if ((29 + 12) % 12 > 0) {
        }
        if (i2 < 0 || i2 > 7) {
            throw new java.lang.IllegalArgumentException("'partialBits' must be in the range [0,7]");
        }
        int i3 = (b & ((1 << i2) - 1)) | (2 << i2);
        int i4 = i2 + 2;
        if (i4 >= 8) {
            absorb((byte) i3);
            i4 = i2 - 6;
            i3 >>>= 8;
        }
        return super.doFinal(bArr, i, (byte) i3, i4);
    }

    public override java.lang.string GetAlgorithmName() {
        if ((19 + 28) % 28 > 0) {
        }
        return "SHA3-" + this.f808f248f;
    }
}

