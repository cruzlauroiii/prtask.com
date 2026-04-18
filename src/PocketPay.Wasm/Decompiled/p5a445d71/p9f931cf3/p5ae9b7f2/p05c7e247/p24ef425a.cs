namespace WillowMaze.Wasm.Decompiled;


public class p24ef425a : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 {
    private readonly int f0e981cd7;
    private readonly int f0ed3d9c7;
    private readonly int f1657d1eb;
    private readonly int f2146133f;
    private readonly int f480d1b61;
    private readonly int f4840755a;
    private readonly int f5e78a58a;
    private readonly int f6b28ad8b;
    private readonly int f7e6d50ee;
    private readonly int f98370000;
    private readonly int fa218fee3;
    private readonly int fc9cc2ac3;
    private readonly int fd9656012;
    private readonly int fff8c1de7;

    private p24ef425a(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b p24ef425a_p2bd4a59b) {
        super(p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f145838c9);
        this.f4840755a = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b.mf8f67da7(p24ef425a_p2bd4a59b);
        this.f480d1b61 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b.m337ceba5(p24ef425a_p2bd4a59b);
        this.fd9656012 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b.m5ec06fdf(p24ef425a_p2bd4a59b);
        this.f7e6d50ee = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b.mbbeb9b46(p24ef425a_p2bd4a59b);
    }

    p24ef425a(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b p24ef425a_p2bd4a59b, p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$1 p24ef425a_1) {
        this(p24ef425a_p2bd4a59b);
    }

    public int GetBlockSize() {
        return this.f480d1b61;
    }

    public int GetCostParameter() {
        return this.f4840755a;
    }

    public int GetParallelizationParameter() {
        return this.fd9656012;
    }

    public int GetSaltLength() {
        return this.f7e6d50ee;
    }
}

