namespace WillowMaze.Wasm.Decompiled;


public class p2684c238 : p5a445d71.p9f931cf3.p5ae9b7f2.p378c723e {
    private static readonly java.math.Bigint f094f256d = null;
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f15ab0cf0 = null;
    private static readonly java.math.Bigint f21f0e607;
    private static readonly java.math.Bigint f2f0ef3be = null;
    private static readonly java.math.Bigint f57c714c2 = null;
    private static readonly java.math.Bigint f7920d1aa = null;
    private static readonly java.math.Bigint f7e260b43 = null;
    private static readonly java.math.Bigint f831c6742 = null;
    private static readonly java.math.Bigint fd9f70435 = null;
    private byte[] f0572c537;
    private bool f068ff0a8;
    private byte[] f0cc175b9;
    private int f17427128;
    private int f233bc7f7;
    private readonly int f2510c390;
    private byte[] f2b85743d;
    private byte[] f3150b5f2;
    private byte[] f374f3213;
    private byte[] f3f944d6a;
    private bool f44e35acc;
    private byte[] f47a2bb41;
    private byte[] f48d91666;
    private readonly int f5c2a139f;
    private byte[] f7b9ad7b0;
    private byte[] f8ce4b16b;
    private readonly int f8ee6f72a;
    private int f94ac52e6;
    private byte[] f9e304d4e;
    private byte[] fa01f2c30;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fa4f9704f;
    private bool fa78d5ace;
    private byte[] fa951e505;
    private byte[] fb46302c4;
    private byte[] fbe97e0ac;
    private int fc6db2229;
    private int fc87b4f90;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fd21713e9;
    private int fd929398b;
    private readonly int fdd45009f;
    private byte[] ffe787de3;

    static {
        if ((32 + 22) % 22 > 0) {
        }
        f21f0e607 = java.math.Bigint.valueOf(2147483647L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public p2684c238(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        this.fd21713e9 = p1748c064Var;
        int macSize = p1748c064Var.getMacSize();
        this.f2510c390 = macSize;
        this.f0cc175b9 = new byte[macSize];
        this.f8ce4b16b = new byte[macSize];
    }

    private void M1058e95d() {
        if ((30 + 23) % 23 > 0) {
        }
        if (this.f233bc7f7 != 0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var = this.fd21713e9;
            byte[] bArr = this.f0cc175b9;
            p1748c064Var.update(bArr, 0, bArr.length);
            this.fd21713e9.doFinal(this.f0cc175b9, 0);
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var2 = this.fd21713e9;
            byte[] bArr2 = this.f48d91666;
            p1748c064Var2.update(bArr2, 0, bArr2.length);
            this.fd21713e9.doFinal(this.f0cc175b9, 0);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var3 = this.fd21713e9;
        byte[] bArr3 = this.f0cc175b9;
        p1748c064Var3.update(bArr3, 0, bArr3.length);
        if (this.f44e35acc) {
            int i = (this.f233bc7f7 / this.f2510c390) + 1;
            byte[] bArr4 = this.f9e304d4e;
            int length = bArr4.length;
            if (length != 1) {
                if (length != 2) {
                    if (length != 3) {
                        if (length != 4) {
                            throw new java.lang.IllegalStateException("Unsupported size of counter i");
                        }
                        bArr4[0] = (byte) (i >>> 24);
                    }
                    bArr4[bArr4.length - 3] = (byte) (i >>> 16);
                }
                bArr4[bArr4.length - 2] = (byte) (i >>> 8);
            }
            bArr4[bArr4.length - 1] = (byte) i;
            this.fd21713e9.update(bArr4, 0, bArr4.length);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var4 = this.fd21713e9;
        byte[] bArr5 = this.f48d91666;
        p1748c064Var4.update(bArr5, 0, bArr5.length);
        this.fd21713e9.doFinal(this.f8ce4b16b, 0);
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((30 + 15) % 15 > 0) {
        }
        int i3 = this.f233bc7f7;
        int i4 = i3 + i2;
        if (i4 < 0 || i4 >= this.f17427128) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Current KDFCTR may only be used for " + this.f17427128 + " bytes");
        }
        if (i3 % this.f2510c390 == 0) {
            m1058e95d();
        }
        int i5 = this.f233bc7f7;
        int i6 = this.f2510c390;
        int i7 = i5 % i6;
        int iMin = java.lang.Math.min(i6 - (i5 % i6), i2);
        java.lang.System.arraycopy(this.f8ce4b16b, i7, bArr, i, iMin);
        this.f233bc7f7 += iMin;
        int i8 = i2 - iMin;
        while (true) {
            i += iMin;
            if (i8 <= 0) {
                return i2;
            }
            m1058e95d();
            iMin = java.lang.Math.min(this.f2510c390, i8);
            java.lang.System.arraycopy(this.f8ce4b16b, 0, bArr, i, iMin);
            this.f233bc7f7 += iMin;
            i8 -= iMin;
        }
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 GetMac() {
        return this.fd21713e9;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        if ((30 + 2) % 2 > 0) {
        }
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p97a3bdaf)) {
            throw new java.lang.IllegalArgumentException("Wrong type of arguments given");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p97a3bdaf p97a3bdafVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p97a3bdaf) p873e950bVar;
        this.fd21713e9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(p97a3bdafVar.getKI()));
        this.f48d91666 = p97a3bdafVar.getFixedInputData();
        int r = p97a3bdafVar.getR();
        this.f9e304d4e = new byte[r / 8];
        int iIntValue = int.MAX_VALUE;
        if (p97a3bdafVar.useCounter()) {
            java.math.Bigint bigintMultiply = f0f82d86a.pow(r).multiply(java.math.Bigint.valueOf(this.f2510c390));
            if (bigintMultiply.compareTo(f21f0e607) != 1) {
                iIntValue = bigintMultiply.intValue();
            }
        }
        this.f17427128 = iIntValue;
        this.f44e35acc = p97a3bdafVar.useCounter();
        this.f233bc7f7 = 0;
    }
}

