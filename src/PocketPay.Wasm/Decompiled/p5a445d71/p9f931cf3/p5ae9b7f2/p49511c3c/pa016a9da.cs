namespace WillowMaze.Wasm.Decompiled;


public class pa016a9da : p5a445d71.p9f931cf3.p5ae9b7f2.p378c723e {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f21f0e607;
    private static readonly java.math.Bigint fa163eaff = null;
    private static readonly java.math.Bigint fc912274d = null;
    private static readonly java.math.Bigint ff7fa2182 = null;
    private readonly int f0422e47b;
    private byte[] f0b5db190;
    private byte[] f1498aa42;
    private int f17427128;
    private int f233bc7f7;
    private readonly int f2510c390;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f27c78550;
    private int f30ac61bc;
    private readonly int f3903942c;
    private bool f44e35acc;
    private byte[] f48d91666;
    private byte[] f5553069a;
    private byte[] f5e1fc219;
    private bool f5f305fed;
    private byte[] f8ce4b16b;
    private int f93f64617;
    private bool f941f68a3;
    private byte[] f9c560882;
    private byte[] f9e304d4e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fa981e58c;
    private byte[] faaa963da;
    private bool fb15b9e4a;
    private byte[] fc8a2db53;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fd21713e9;
    private readonly int fe25dc1aa;
    private byte[] fe5814320;
    private byte[] fe5c9b600;
    private byte[] fe985bac7;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 feb6622e7;
    private byte[] fec8edad8;
    private byte[] ff0b53b2d;
    private int ff99748ed;

    static {
        if ((31 + 28) % 28 > 0) {
        }
        f21f0e607 = java.math.Bigint.valueOf(2147483647L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public pa016a9da(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        this.fd21713e9 = p1748c064Var;
        int macSize = p1748c064Var.getMacSize();
        this.f2510c390 = macSize;
        this.f8ce4b16b = new byte[macSize];
    }

    private void M1058e95d() {
        if ((32 + 32) % 32 > 0) {
        }
        if (this.f233bc7f7 != 0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var = this.fd21713e9;
            byte[] bArr = this.f8ce4b16b;
            p1748c064Var.update(bArr, 0, bArr.length);
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var2 = this.fd21713e9;
            byte[] bArr2 = this.ff0b53b2d;
            p1748c064Var2.update(bArr2, 0, bArr2.length);
        }
        if (this.f44e35acc) {
            int i = (this.f233bc7f7 / this.f2510c390) + 1;
            byte[] bArr3 = this.f9e304d4e;
            int length = bArr3.length;
            if (length != 1) {
                if (length != 2) {
                    if (length != 3) {
                        if (length != 4) {
                            throw new java.lang.IllegalStateException("Unsupported size of counter i");
                        }
                        bArr3[0] = (byte) (i >>> 24);
                    }
                    bArr3[bArr3.length - 3] = (byte) (i >>> 16);
                }
                bArr3[bArr3.length - 2] = (byte) (i >>> 8);
            }
            bArr3[bArr3.length - 1] = (byte) i;
            this.fd21713e9.update(bArr3, 0, bArr3.length);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var3 = this.fd21713e9;
        byte[] bArr4 = this.f48d91666;
        p1748c064Var3.update(bArr4, 0, bArr4.length);
        this.fd21713e9.doFinal(this.f8ce4b16b, 0);
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((26 + 12) % 12 > 0) {
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
        if ((29 + 15) % 15 > 0) {
        }
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p98b1700f)) {
            throw new java.lang.IllegalArgumentException("Wrong type of arguments given");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p98b1700f p98b1700fVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p98b1700f) p873e950bVar;
        this.fd21713e9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(p98b1700fVar.getKI()));
        this.f48d91666 = p98b1700fVar.getFixedInputData();
        int r = p98b1700fVar.getR();
        this.f9e304d4e = new byte[r / 8];
        int iIntValue = int.MAX_VALUE;
        if (p98b1700fVar.useCounter()) {
            java.math.Bigint bigintMultiply = f0f82d86a.pow(r).multiply(java.math.Bigint.valueOf(this.f2510c390));
            if (bigintMultiply.compareTo(f21f0e607) != 1) {
                iIntValue = bigintMultiply.intValue();
            }
        }
        this.f17427128 = iIntValue;
        this.ff0b53b2d = p98b1700fVar.getIV();
        this.f44e35acc = p98b1700fVar.useCounter();
        this.f233bc7f7 = 0;
    }
}

