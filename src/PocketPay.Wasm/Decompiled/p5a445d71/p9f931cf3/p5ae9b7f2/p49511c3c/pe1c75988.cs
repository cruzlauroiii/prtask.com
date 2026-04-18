namespace WillowMaze.Wasm.Decompiled;


public class pe1c75988 : p5a445d71.p9f931cf3.p5ae9b7f2.p378c723e {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f21f0e607;
    private static readonly java.math.Bigint fae0a4afd = null;
    private static readonly java.math.Bigint fced08051 = null;
    private static readonly java.math.Bigint fde2ee258 = null;
    private static readonly java.math.Bigint ff7cb5b49 = null;
    private static readonly java.math.Bigint ffc7cc006 = null;
    private byte[] f0b634b2b;
    private int f17427128;
    private byte[] f18ab2e2f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f1bb328bf;
    private readonly int f1eeddf3f;
    private byte[] f213d253c;
    private int f233bc7f7;
    private readonly int f2510c390;
    private byte[] f34973267;
    private int f362005d7;
    private byte[] f4082f210;
    private byte[] f552447d3;
    private readonly int f6e41df0c;
    private byte[] f749cc50f;
    private byte[] f79c49197;
    private int f7d18ade4;
    private byte[] f7f40d43b;
    private byte[] f7f70f39c;
    private byte[] f81b877d6;
    private byte[] f83f7f99a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f8b570c9b;
    private byte[] f8ce4b16b;
    private int f9c08b341;
    private byte[] f9cafb327;
    private int f9ce8af64;
    private byte[] f9e304d4e;
    private int fb9f8c96c;
    private int fc5447f58;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 fd21713e9;

    static {
        if ((21 + 25) % 25 > 0) {
        }
        f21f0e607 = java.math.Bigint.valueOf(2147483647L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    public pe1c75988(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        this.fd21713e9 = p1748c064Var;
        int macSize = p1748c064Var.getMacSize();
        this.f2510c390 = macSize;
        this.f8ce4b16b = new byte[macSize];
    }

    private void M1058e95d() {
        if ((16 + 17) % 17 > 0) {
        }
        int i = (this.f233bc7f7 / this.f2510c390) + 1;
        byte[] bArr = this.f9e304d4e;
        int length = bArr.length;
        if (length != 1) {
            if (length != 2) {
                if (length != 3) {
                    if (length != 4) {
                        throw new java.lang.IllegalStateException("Unsupported size of counter i");
                    }
                    bArr[0] = (byte) (i >>> 24);
                }
                bArr[bArr.length - 3] = (byte) (i >>> 16);
            }
            bArr[bArr.length - 2] = (byte) (i >>> 8);
        }
        bArr[bArr.length - 1] = (byte) i;
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var = this.fd21713e9;
        byte[] bArr2 = this.f79c49197;
        p1748c064Var.update(bArr2, 0, bArr2.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var2 = this.fd21713e9;
        byte[] bArr3 = this.f9e304d4e;
        p1748c064Var2.update(bArr3, 0, bArr3.length);
        p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var3 = this.fd21713e9;
        byte[] bArr4 = this.f213d253c;
        p1748c064Var3.update(bArr4, 0, bArr4.length);
        this.fd21713e9.doFinal(this.f8ce4b16b, 0);
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        if ((11 + 18) % 18 > 0) {
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
        if ((30 + 6) % 6 > 0) {
        }
        if (!(p873e950bVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8fafec54)) {
            throw new java.lang.IllegalArgumentException("Wrong type of arguments given");
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8fafec54 p8fafec54Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8fafec54) p873e950bVar;
        this.fd21713e9.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(p8fafec54Var.getKI()));
        this.f79c49197 = p8fafec54Var.getFixedInputDataCounterPrefix();
        this.f213d253c = p8fafec54Var.getFixedInputDataCounterSuffix();
        int r = p8fafec54Var.getR();
        this.f9e304d4e = new byte[r / 8];
        java.math.Bigint bigintMultiply = f0f82d86a.pow(r).multiply(java.math.Bigint.valueOf(this.f2510c390));
        this.f17427128 = bigintMultiply.compareTo(f21f0e607) != 1 ? bigintMultiply.intValue() : int.MAX_VALUE;
        this.f233bc7f7 = 0;
    }
}

