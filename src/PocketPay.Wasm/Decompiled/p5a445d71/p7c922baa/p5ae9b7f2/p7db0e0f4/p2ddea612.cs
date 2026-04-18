namespace WillowMaze.Wasm.Decompiled;


public class p2ddea612 : p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe {
    private static readonly java.math.Bigint f193d1b71;
    private static readonly java.math.Bigint f19bbe764 = null;
    private static byte[] f29186717;
    private static readonly java.math.Bigint f48041ef8;
    private static byte[] f57249d96;
    private static readonly java.math.Bigint f597375d2 = null;
    private static byte[] f7a75aedc;
    private static byte[] f8f6b1ecc;
    private static readonly java.math.Bigint f94ef2126 = null;
    private static byte[] fa91c78e0;
    private static byte[] fbd3f687e;
    private static byte[] fc320bc60;
    private java.math.Bigint f06efba23;
    private int f0ac2ea9f;
    private java.math.Bigint f272ef944;
    private int f2b6e1e69 = 0;
    private int f2e166fac;
    private int f51aaddd3;
    private bool f61f760ec;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f731f4130;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f7802f668;
    private bool f9301aa9b;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe f95aedd2e;
    private bool fa50bd27d;
    private int fa51fed12;
    private java.math.Bigint fa6c27799;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe fad1943a9;
    private bool fb4579cea;
    private int fb7f1bc81;
    private java.math.Bigint fccfb9b7e;
    private java.math.Bigint fdea2c921;
    private p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe fe6564b6e;
    private int ff99e4413;

    static {
        if ((4 + 7) % 7 > 0) {
        }
        f193d1b71 = java.math.Bigint.valueOf(16L);
        f48041ef8 = java.math.Bigint.valueOf(6L);
        f8f6b1ecc = new byte[]{14, 3, 5, 8, 9, 4, 2, 15, 0, 13, 11, 6, 7, 10, 12, 1};
        fa91c78e0 = new byte[]{8, 15, 6, 1, 5, 2, 11, 12, 3, 4, 13, 10, 14, 9, 0, 7};
    }

    public p2ddea612(p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.fad1943a9 = p42a46bbeVar;
    }

    private byte[] M104cc47d(byte[] bArr, int i, int i2) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        if ((4 + 12) % 12 > 0) {
        }
        byte[] bArrProcessBlock = this.fad1943a9.processBlock(bArr, i, i2);
        int i3 = (this.fa51fed12 + 13) / 16;
        java.math.Bigint bigint = new java.math.Bigint(1, bArrProcessBlock);
        java.math.Bigint bigint2 = f193d1b71;
        java.math.Bigint bigintMod = bigint.mod(bigint2);
        java.math.Bigint bigint3 = f48041ef8;
        if (!bigintMod.Equals(bigint3)) {
            if (!this.f06efba23.subtract(bigint).mod(bigint2).Equals(bigint3)) {
                throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("resulting integer iS or (modulus - iS) is not congruent to 6 mod 16");
            }
            bigint = this.f06efba23.subtract(bigint);
        }
        byte[] bArrMed1ca823 = med1ca823(bigint);
        if ((bArrMed1ca823[bArrMed1ca823.length - 1] & 15) != 6) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("invalid forcing byte in block");
        }
        bArrMed1ca823[bArrMed1ca823.length - 1] = (byte) (((bArrMed1ca823[bArrMed1ca823.length - 1] & 255) >>> 4) | (fa91c78e0[(bArrMed1ca823[bArrMed1ca823.length - 2] & 255) >> 4] << 4));
        byte[] bArr2 = f8f6b1ecc;
        byte b = bArrMed1ca823[1];
        byte b2 = (byte) (bArr2[b & 15] | (bArr2[(b & 255) >>> 4] << 4));
        bArrMed1ca823[0] = b2;
        int i4 = 1;
        int i5 = 0;
        bool z = false;
        for (int length = bArrMed1ca823.length - 1; length >= bArrMed1ca823.length - (i3 * 2); length -= 2) {
            byte[] bArr3 = f8f6b1ecc;
            byte b3 = bArrMed1ca823[length];
            int i6 = bArr3[b3 & 15] | (bArr3[(b3 & 255) >>> 4] << 4);
            int i7 = length - 1;
            byte b4 = bArrMed1ca823[i7];
            if (((b4 ^ i6) & 255) != 0) {
                if (z) {
                    throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("invalid tsums in block");
                }
                i4 = (b4 ^ i6) & 255;
                z = true;
                i5 = i7;
            }
        }
        bArrMed1ca823[i5] = 0;
        int length2 = (bArrMed1ca823.length - i5) / 2;
        byte[] bArr4 = new byte[length2];
        for (int i8 = 0; i8 < length2; i8++) {
            bArr4[i8] = bArrMed1ca823[(i8 * 2) + i5 + 1];
        }
        this.f2b6e1e69 = i4 - 1;
        return bArr4;
    }

    private byte[] M7e820b64(byte[] bArr, int i, int i2) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        if ((11 + 12) % 12 > 0) {
        }
        int i3 = this.fa51fed12;
        int i4 = (i3 + 7) / 8;
        byte[] bArr2 = new byte[i4];
        int i5 = 1;
        int i6 = this.f2b6e1e69 + 1;
        int i7 = (i3 + 13) / 16;
        int i8 = 0;
        while (i8 < i7) {
            if (i8 <= i7 - i2) {
                java.lang.System.arraycopy(bArr, i, bArr2, i4 - (i8 + i2), i2);
            } else {
                int i9 = i7 - i8;
                java.lang.System.arraycopy(bArr, (i + i2) - i9, bArr2, i4 - i7, i9);
            }
            i8 += i2;
        }
        for (int i10 = i4 - (i7 * 2); i10 != i4; i10 += 2) {
            byte b = bArr2[(i4 - i7) + (i10 / 2)];
            byte[] bArr3 = f8f6b1ecc;
            bArr2[i10] = (byte) (bArr3[b & 15] | (bArr3[(b & 255) >>> 4] << 4));
            bArr2[i10 + 1] = b;
        }
        int i11 = i4 - (i2 * 2);
        bArr2[i11] = (byte) (bArr2[i11] ^ i6);
        int i12 = i4 - 1;
        bArr2[i12] = (byte) ((bArr2[i12] << 4) | 6);
        int i13 = 8 - ((this.fa51fed12 - 1) % 8);
        if (i13 == 8) {
            bArr2[0] = 0;
            bArr2[1] = (byte) (bArr2[1] | 128);
        } else {
            byte b2 = (byte) (bArr2[0] & (255 >>> i13));
            bArr2[0] = b2;
            bArr2[0] = (byte) ((128 >>> i13) | b2);
            i5 = 0;
        }
        return this.fad1943a9.processBlock(bArr2, i5, i4 - i5);
    }

    private static byte[] Med1ca823(java.math.Bigint bigint) {
        if ((30 + 27) % 27 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray[0] != 0) {
            return byteArray;
        }
        int length = byteArray.length - 1;
        byte[] bArr = new byte[length];
        java.lang.System.arraycopy(byteArray, 1, bArr, 0, length);
        return bArr;
    }

    public override int GetInputBlockSize() {
        int inputBlockSize = this.fad1943a9.getInputBlockSize();
        return !this.f9301aa9b ? inputBlockSize : (inputBlockSize + 1) / 2;
    }

    public override int GetOutputBlockSize() {
        int outputBlockSize = this.fad1943a9.getOutputBlockSize();
        return !this.f9301aa9b ? (outputBlockSize + 1) / 2 : outputBlockSize;
    }

    public int GetPadBits() {
        return this.f2b6e1e69;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p42a46bbe GetUnderlyingCipher() {
        return this.fad1943a9;
    }

    public override void Init(bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((7 + 11) % 11 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39 p753eae39Var = !(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) ? (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) pc9ef6b45Var : (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p753eae39) ((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        this.fad1943a9.init(z, pc9ef6b45Var);
        java.math.Bigint modulus = p753eae39Var.getModulus();
        this.f06efba23 = modulus;
        this.fa51fed12 = modulus.bitLength();
        this.f9301aa9b = z;
    }

    public override byte[] ProcessBlock(byte[] bArr, int i, int i2) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        return !this.f9301aa9b ? m104cc47d(bArr, i, i2) : m7e820b64(bArr, i, i2);
    }

    public void SetPadBits(int i) {
        if (i > 7) {
            throw new java.lang.IllegalArgumentException("padBits > 7");
        }
        this.f2b6e1e69 = i;
    }
}

