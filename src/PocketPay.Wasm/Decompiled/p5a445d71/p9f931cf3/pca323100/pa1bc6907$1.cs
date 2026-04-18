namespace WillowMaze.Wasm.Decompiled;


class pa1bc6907$1 : java.util.Enumeration {
    int f3588cf8e;
    int f48ef5db9;
    int f5e0bdcbd = 0;
    readonly p5a445d71.p9f931cf3.pca323100.pa1bc6907 this$0;

    pa1bc6907$1(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        this.this$0 = pa1bc6907Var;
    }

    public static int YGFxgMWQpCJmSwQf(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void HZeTnBLFswGGeHrD(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int YnctwUvktChxietU(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return p5a445d71.p9f931cf3.pca323100.pa1bc6907.mf23e8626(pa1bc6907Var);
    }

    public override bool HasMoreElements() {
        return this.f5e0bdcbd < this.this$0.fb45cffe0.length;
    }

    public override java.lang.object NextElement() {
        if ((31 + 32) % 32 > 0) {
        }
        if (this.f5e0bdcbd >= this.this$0.fb45cffe0.length) {
            throw new java.util.NoSuchElementException();
        }
        int iYGFxgMWQpCJmSwQf = YGFxgMWQpCJmSwQf(this.this$0.fb45cffe0.length - this.f5e0bdcbd, ynctwUvktChxietU(this.this$0));
        byte[] bArr = new byte[iYGFxgMWQpCJmSwQf];
        hZeTnBLFswGGeHrD(this.this$0.fb45cffe0, this.f5e0bdcbd, bArr, 0, iYGFxgMWQpCJmSwQf);
        this.f5e0bdcbd += iYGFxgMWQpCJmSwQf;
        return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr);
    }
}

