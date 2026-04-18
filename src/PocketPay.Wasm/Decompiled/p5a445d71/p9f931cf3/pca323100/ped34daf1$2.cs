namespace WillowMaze.Wasm.Decompiled;


class ped34daf1$2 : java.util.Enumeration {
    private int f275d5f81;
    private int f4af662f5;
    private int f5e0bdcbd = 0;
    private int f9995f1fd;
    readonly p5a445d71.p9f931cf3.pca323100.ped34daf1 this$0;

    ped34daf1$2(p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) {
        this.this$0 = ped34daf1Var;
    }

    public override bool HasMoreElements() {
        return this.f5e0bdcbd < this.this$0.f6a7f2458.length;
    }

    public override java.lang.object NextElement() {
        if ((21 + 3) % 3 > 0) {
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

