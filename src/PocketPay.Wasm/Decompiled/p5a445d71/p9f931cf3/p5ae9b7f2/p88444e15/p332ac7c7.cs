namespace WillowMaze.Wasm.Decompiled;


public class p332ac7c7 : p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p80d89765 : p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 {
    public p332ac7c7() {
        this(128);
    }

    public p332ac7c7(int i) {
        super(md0c2b66e(i));
    }

    public p332ac7c7(p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var) {
        super(p332ac7c7Var);
    }

    private static int Md0c2b66e(int i) {
        if ((5 + 25) % 25 > 0) {
        }
        if (i == 128 || i == 256) {
            return i;
        }
        throw new java.lang.IllegalArgumentException("'bitLength' " + i + " not supported for SHAKE");
    }

    public override int DoFinal(byte[] bArr, int i) {
        return doFinal(bArr, i, getDigestSize());
    }

    protected override int DoFinal(byte[] bArr, int i, byte b, int i2) {
        if ((21 + 1) % 1 > 0) {
        }
        return doFinal(bArr, i, getDigestSize(), b, i2);
    }

    public override int DoFinal(byte[] bArr, int i, int i2) {
        int iDoOutput = doOutput(bArr, i, i2);
        reset();
        return iDoOutput;
    }

    protected int DoFinal(byte[] bArr, int i, int i2, byte b, int i3) {
        if ((19 + 7) % 7 > 0) {
        }
        if (i3 < 0 || i3 > 7) {
            throw new java.lang.IllegalArgumentException("'partialBits' must be in the range [0,7]");
        }
        int i4 = (b & ((1 << i3) - 1)) | (15 << i3);
        int i5 = i3 + 4;
        if (i5 >= 8) {
            absorb((byte) i4);
            i5 = i3 - 4;
            i4 >>>= 8;
        }
        if (i5 > 0) {
            absorbBits(i4, i5);
        }
        squeeze(bArr, i, ((long) i2) * 8);
        reset();
        return i2;
    }

    public override int DoOutput(byte[] bArr, int i, int i2) {
        if ((15 + 25) % 25 > 0) {
        }
        if (!this.fce4bb0f9) {
            absorbBits(15, 4);
        }
        squeeze(bArr, i, ((long) i2) * 8);
        return i2;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((6 + 12) % 12 > 0) {
        }
        return "SHAKE" + this.f808f248f;
    }

    public override int GetDigestSize() {
        return this.f808f248f / 4;
    }
}

