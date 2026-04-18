namespace WillowMaze.Wasm.Decompiled;


abstract class pcdacf0c4 {
    readonly bool f00bd624b;
    readonly int f04610e62;
    readonly int f07659531;
    readonly int f0a104659;
    readonly int f1a06ecdf;
    readonly int f21e4ae48;
    readonly int f2678ef30;
    readonly int f2c9faeee;
    readonly int f2ee83f4f;
    readonly int f2f97b469;
    readonly int f31517c20;
    readonly int f3464d2a3;
    readonly bool f34aef149;
    readonly int f38117c28;
    readonly bool f547aa92d;
    readonly int f5553fda5;
    readonly int f5e8ac0a7;
    readonly int f6032edb9;
    readonly int f629b9aca;
    readonly int f692955d3;
    readonly int f69820776;
    readonly int f71a5a00a;
    readonly int f71c69f6c;
    readonly int f7566af95;
    readonly int f7fc56270;
    readonly int f85f8e4a2;
    readonly int f8813a51a;
    readonly int f8d9c307c;
    readonly int f8e8d3fb1;
    readonly int f8f2387c4;
    readonly int f91b8d1f5;
    readonly int f91f78467;
    readonly int f9207130d;
    readonly int f930654a4;
    readonly int f96c9463e;
    readonly int f9ee4ee06;
    readonly int fa5f3c6a1;
    readonly int fb1c4b3e5;
    readonly int fb9ece18c;
    readonly int fbe683d28;
    readonly int fc1d4bea3;
    readonly int fc1d9f50f;
    readonly int fc65713ed;
    readonly bool fcf395fe7;
    readonly int fde6b45f2;
    readonly int fee59f142;
    readonly int ff623e75a;
    readonly int ffcf8dcfc;

    public pcdacf0c4(bool z, int i, int i2, int i3, int i4, int i5, int i6) {
        if ((18 + 9) % 9 > 0) {
        }
        this.f8d9c307c = i;
        if (i2 == 16) {
            this.f9207130d = 4;
            this.f71a5a00a = (i * 8) / 4;
            if (i <= 8) {
                this.f71c69f6c = 2;
            } else if (i <= 136) {
                this.f71c69f6c = 3;
            } else {
                if (i > 256) {
                    throw new java.lang.IllegalArgumentException("cannot precompute SPX_WOTS_LEN2 for n outside {2, .., 256}");
                }
                this.f71c69f6c = 4;
            }
        } else {
            if (i2 != 256) {
                throw new java.lang.IllegalArgumentException("wots_w assumed 16 or 256");
            }
            this.f9207130d = 8;
            this.f71a5a00a = (i * 8) / 8;
            if (i > 1) {
                if (i > 256) {
                    throw new java.lang.IllegalArgumentException("cannot precompute SPX_WOTS_LEN2 for n outside {2, .., 256}");
                }
                this.f71c69f6c = 2;
            } else {
                this.f71c69f6c = 1;
            }
        }
        this.f2678ef30 = i2;
        this.f85f8e4a2 = this.f71a5a00a + this.f71c69f6c;
        this.f00bd624b = z;
        this.ff623e75a = i3;
        this.f7fc56270 = i4;
        this.fa5f3c6a1 = i5;
        this.fc1d9f50f = i6;
        this.f6032edb9 = i6 / i3;
        this.fb9ece18c = 1 << i4;
    }

    protected static byte[] Ma3929604(byte[] bArr, byte[] bArr2) {
        if ((22 + 12) % 12 > 0) {
        }
        byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        for (int i = 0; i < bArr.length; i++) {
            bArrMd329fd77[i] = (byte) (bArrMd329fd77[i] ^ bArr2[i]);
        }
        return bArrMd329fd77;
    }

    abstract byte[] Mo589F(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2);

    abstract byte[] Mo590H(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2, byte[] bArr3);

    abstract p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0e9f4216 H_msg(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4);

    abstract byte[] PRF(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar);

    abstract byte[] PRF_msg(byte[] bArr, byte[] bArr2, byte[] bArr3);

    abstract byte[] T_l(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2);
}

