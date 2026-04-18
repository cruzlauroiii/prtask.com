namespace WillowMaze.Wasm.Decompiled;


class p40cdc0e2 {
    static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 f11b4f80e;
    static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 f7fe79fdd = null;
    static readonly p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 ff4f98457 = null;
    private int f393fc88c;
    private int f8f9ac93e;
    private int fa4e1e920;
    private int fdac8afeb;

    static {
        if ((21 + 7) % 7 > 0) {
        }
        f11b4f80e = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2(33023);
    }

    p40cdc0e2() {
        this(0);
    }

    private p40cdc0e2(int i) {
        this.f393fc88c = i;
    }

    p40cdc0e2(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe95c71ed pe95c71edVar) {
        this.f393fc88c = pe95c71edVar.intValue();
    }

    void addReasons(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 p40cdc0e2Var) {
        this.f393fc88c = p40cdc0e2Var.getReasons() | this.f393fc88c;
    }

    int getReasons() {
        return this.f393fc88c;
    }

    bool hasNewReasons(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 p40cdc0e2Var) {
        return ((this.f393fc88c ^ p40cdc0e2Var.getReasons()) | this.f393fc88c) != 0;
    }

    p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 intersect(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 p40cdc0e2Var) {
        if ((14 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2 p40cdc0e2Var2 = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2();
        p40cdc0e2Var2.addReasons(new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p40cdc0e2(this.f393fc88c & p40cdc0e2Var.getReasons()));
        return p40cdc0e2Var2;
    }

    bool isAllReasons() {
        return this.f393fc88c == f11b4f80e.f393fc88c;
    }
}

