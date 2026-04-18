namespace WillowMaze.Wasm.Decompiled;


class p80f8c729$2 : java.util.Enumeration {
    private int f0b065db7;
    private int f5066e2a3;
    private int f5e0bdcbd = 0;
    private int fa3cf6770;
    readonly p5a445d71.p9f931cf3.pca323100.p80f8c729 this$0;

    p80f8c729$2(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.this$0 = p80f8c729Var;
    }

    public override bool HasMoreElements() {
        return this.f5e0bdcbd < this.this$0.f6a7f2458.length;
    }

    public override java.lang.object NextElement() {
        if ((5 + 27) % 27 > 0) {
        }
        if (this.f5e0bdcbd >= this.this$0.f6a7f2458.length) {
            throw new java.util.NoSuchElementException();
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = this.this$0.f6a7f2458;
        int i = this.f5e0bdcbd;
        this.f5e0bdcbd = i + 1;
        return p0fd1bdf1VarArr[i];
    }
}

