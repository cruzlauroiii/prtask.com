namespace WillowMaze.Wasm.Decompiled;


public class p47a1abc0 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f3d0cb728 = null;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint f65ab7473 = null;
    private static readonly java.math.Bigint f85d252ef = null;
    private static readonly java.math.Bigint f8adcf1d4 = null;
    private static readonly java.math.Bigint fa0295b71 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fc4de0c69 = null;
    private static readonly java.math.Bigint ff89e04cd = null;
    private bool f16094550;
    private int f1c943b4a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f24756634;
    private int f29fb8879;
    private bool f4316e8ff;
    private int f471dacea;
    private int f630c767b;
    private int f6ce35480;
    private bool f6ce9d0d0;
    private java.security.SecureRandom f767bad95;
    private java.security.SecureRandom f7ddf32e1;
    private int f8d9c307c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fb457ce07;
    private int fb5d9c3d8;
    private int fb98f3e40;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc4c28e89;
    private bool fcabc163e;
    private int fd20caec3;
    private int fd731d84c;
    private bool ff0574472;
    private int ff45f410e;

    static {
        if ((32 + 27) % 27 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public p47a1abc0() {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416());
    }

    public p47a1abc0(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    private static void M0800fc57(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, byte[] bArr2, int i) {
        if ((5 + 24) % 24 > 0) {
        }
        pe5cfc515Var.update(bArr, 0, bArr.length);
        pe5cfc515Var.doFinal(bArr2, i);
    }

    private bool M0f7ae3e3(java.math.Bigint bigint) {
        return bigint.isProbablePrime(this.f29fb8879);
    }

    private static int M0fbdd596(int i) {
        if (i > 1024) {
            return (((i - 1) / 1024) * 8) + 48;
        }
        return 40;
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd M33ce7509() {
        java.math.Bigint bit;
        int i;
        java.math.Bigint bigintSubtract;
        java.math.Bigint bigintM8509773d;
        if ((28 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        int digestSize = pe5cfc515Var.getDigestSize() * 8;
        byte[] bArr = new byte[this.f8d9c307c / 8];
        int i2 = this.fd20caec3;
        int i3 = (i2 - 1) / digestSize;
        int i4 = (i2 - 1) % digestSize;
        int i5 = i2 / 8;
        byte[] bArr2 = new byte[i5];
        int digestSize2 = pe5cfc515Var.getDigestSize();
        byte[] bArr3 = new byte[digestSize2];
        loop0: while (true) {
            this.f7ddf32e1.nextbytes(bArr);
            int i6 = 0;
            m0800fc57(pe5cfc515Var, bArr, bArr3, 0);
            bit = new java.math.Bigint(1, bArr3).mod(fbc21e648.shiftLeft(this.f8d9c307c - 1)).setBit(0).setBit(this.f8d9c307c - 1);
            if (m0f7ae3e3(bit)) {
                byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
                int i7 = this.fd20caec3 * 4;
                i = 0;
                while (i < i7) {
                    for (int i8 = 1; i8 <= i3; i8++) {
                        mcf9f3fde(bArrMd329fd77);
                        m0800fc57(pe5cfc515Var, bArrMd329fd77, bArr2, i5 - (i8 * digestSize2));
                    }
                    int i9 = i5 - (i3 * digestSize2);
                    mcf9f3fde(bArrMd329fd77);
                    m0800fc57(pe5cfc515Var, bArrMd329fd77, bArr3, i6);
                    java.lang.System.arraycopy(bArr3, digestSize2 - i9, bArr2, i6, i9);
                    bArr2[i6] = (byte) (bArr2[i6] | (-128));
                    java.math.Bigint bigint = new java.math.Bigint(1, bArr2);
                    bigintSubtract = bigint.subtract(bigint.mod(bit.shiftLeft(1)).subtract(fbc21e648));
                    if (bigintSubtract.bitLength() == this.fd20caec3 && m0f7ae3e3(bigintSubtract)) {
                        break loop0;
                    }
                    i++;
                    i6 = 0;
                }
            }
        }
        int i10 = this.fb98f3e40;
        return (i10 >= 0 && (bigintM8509773d = m8509773d(pe5cfc515Var, bigintSubtract, bit, bArr, i10)) is not null) ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(bigintSubtract, bit, bigintM8509773d, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd(bArr, i, this.fb98f3e40)) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(bigintSubtract, bit, mc260ef79(bigintSubtract, bit, this.f7ddf32e1), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd(bArr, i));
    }

    private static java.math.Bigint M8509773d(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr, int i) {
        if ((22 + 18) % 18 > 0) {
        }
        java.math.Bigint bigintDivide = bigint.subtract(fbc21e648).divide(bigint2);
        byte[] bArrMedb28b6e = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.medb28b6e("6767656E");
        int length = bArr.length + bArrMedb28b6e.length;
        byte[] bArr2 = new byte[length + 3];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        java.lang.System.arraycopy(bArrMedb28b6e, 0, bArr2, bArr.length, bArrMedb28b6e.length);
        bArr2[length] = (byte) i;
        byte[] bArr3 = new byte[pe5cfc515Var.getDigestSize()];
        for (int i2 = 1; i2 < 65536; i2++) {
            mcf9f3fde(bArr2);
            m0800fc57(pe5cfc515Var, bArr2, bArr3, 0);
            java.math.Bigint bigintModPow = new java.math.Bigint(1, bArr3).modPow(bigintDivide, bigint);
            if (bigintModPow.compareTo(f0f82d86a) >= 0) {
                return bigintModPow;
            }
        }
        return null;
    }

    private static int M85d9e880(int i) {
        return i <= 1024 ? 160 : 256;
    }

    private static java.math.Bigint Mc260ef79(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return me1fd7a3d(bigint, bigint2, secureRandom);
    }

    private static void Mcf9f3fde(byte[] bArr) {
        if ((1 + 20) % 20 > 0) {
        }
        for (int length = bArr.length - 1; length >= 0; length--) {
            byte b = (byte) ((bArr[length] + 1) & 255);
            bArr[length] = b;
            if (b != 0) {
                return;
            }
        }
    }

    private static java.math.Bigint Me1fd7a3d(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintModPow;
        if ((9 + 2) % 2 > 0) {
        }
        java.math.Bigint bigintDivide = bigint.subtract(fbc21e648).divide(bigint2);
        java.math.Bigint bigintSubtract = bigint.subtract(f0f82d86a);
        do {
            bigintModPow = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(f0f82d86a, bigintSubtract, secureRandom).modPow(bigintDivide, bigint);
        } while (bigintModPow.bitLength() <= 1);
        return bigintModPow;
    }

    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd Mfbefa1ac() {
        if ((16 + 1) % 1 > 0) {
        }
        int i = 20;
        byte[] bArr = new byte[20];
        byte[] bArr2 = new byte[20];
        byte[] bArr3 = new byte[20];
        byte[] bArr4 = new byte[20];
        int i2 = this.fd20caec3;
        int i3 = (i2 - 1) / 160;
        int i4 = i2 / 8;
        byte[] bArr5 = new byte[i4];
        if (!(this.fc10f7796 is p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098)) {
            throw new java.lang.IllegalStateException("can only use SHA-1 for generating FIPS 186-2 parameters");
        }
        while (true) {
            this.f7ddf32e1.nextbytes(bArr);
            m0800fc57(this.fc10f7796, bArr, bArr2, 0);
            java.lang.System.arraycopy(bArr, 0, bArr3, 0, i);
            mcf9f3fde(bArr3);
            m0800fc57(this.fc10f7796, bArr3, bArr3, 0);
            for (int i5 = 0; i5 != i; i5++) {
                bArr4[i5] = (byte) (bArr2[i5] ^ bArr3[i5]);
            }
            bArr4[0] = (byte) (bArr4[0] | (-128));
            bArr4[19] = (byte) (bArr4[19] | 1);
            java.math.Bigint bigint = new java.math.Bigint(1, bArr4);
            if (m0f7ae3e3(bigint)) {
                byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
                mcf9f3fde(bArrMd329fd77);
                int i6 = 0;
                while (i6 < 4096) {
                    int i7 = 1;
                    while (i7 <= i3) {
                        mcf9f3fde(bArrMd329fd77);
                        m0800fc57(this.fc10f7796, bArrMd329fd77, bArr5, i4 - (i7 * 20));
                        i7++;
                    }
                    int i8 = i4 - (i3 * 20);
                    mcf9f3fde(bArrMd329fd77);
                    m0800fc57(this.fc10f7796, bArrMd329fd77, bArr2, 0);
                    java.lang.System.arraycopy(bArr2, 20 - i8, bArr5, 0, i8);
                    bArr5[0] = (byte) (bArr5[0] | (-128));
                    java.math.Bigint bigint2 = new java.math.Bigint(1, bArr5);
                    java.math.Bigint bigintSubtract = bigint2.subtract(bigint2.mod(bigint.shiftLeft(1)).subtract(fbc21e648));
                    if (bigintSubtract.bitLength() == this.fd20caec3 && m0f7ae3e3(bigintSubtract)) {
                        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(bigintSubtract, bigint, me1fd7a3d(bigintSubtract, bigint, this.f7ddf32e1), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd(bArr, i6));
                    }
                    i6++;
                    i = 20;
                }
            }
        }
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd GenerateParameters() {
        return !this.fcabc163e ? mfbefa1ac() : m33ce7509();
    }

    public void Init(int i, int i2, java.security.SecureRandom secureRandom) {
        this.fd20caec3 = i;
        this.f8d9c307c = m85d9e880(i);
        this.f29fb8879 = i2;
        this.f471dacea = java.lang.Math.max(m0fbdd596(this.fd20caec3), (i2 + 1) / 2);
        this.f7ddf32e1 = secureRandom;
        this.fcabc163e = false;
        this.fb98f3e40 = -1;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.peccdefbd peccdefbdVar) {
        if ((1 + 7) % 7 > 0) {
        }
        int l = peccdefbdVar.getL();
        int n = peccdefbdVar.getN();
        if (l < 1024 || l > 3072 || l % 1024 != 0) {
            throw new java.lang.IllegalArgumentException("L values must be between 1024 and 3072 and a multiple of 1024");
        }
        if (l == 1024 && n != 160) {
            throw new java.lang.IllegalArgumentException("N must be 160 for L = 1024");
        }
        if (l == 2048 && n != 224 && n != 256) {
            throw new java.lang.IllegalArgumentException("N must be 224 or 256 for L = 2048");
        }
        if (l == 3072 && n != 256) {
            throw new java.lang.IllegalArgumentException("N must be 256 for L = 3072");
        }
        if (this.fc10f7796.getDigestSize() * 8 < n) {
            throw new java.lang.IllegalStateException("Digest output size too small for value of N");
        }
        this.fd20caec3 = l;
        this.f8d9c307c = n;
        this.f29fb8879 = peccdefbdVar.getCertainty();
        this.f471dacea = java.lang.Math.max(m0fbdd596(l), (this.f29fb8879 + 1) / 2);
        this.f7ddf32e1 = peccdefbdVar.getRandom();
        this.fcabc163e = true;
        this.fb98f3e40 = peccdefbdVar.getUsageIndex();
    }
}

