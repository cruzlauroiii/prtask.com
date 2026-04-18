namespace WillowMaze.Wasm.Decompiled;


public class pbbfd3590 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 f1e4a1b20;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 f21ffce5b;

    protected pbbfd3590(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        super(z);
        this.f21ffce5b = p85d5a073Var;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 27) % 27 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590 pbbfd3590Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pbbfd3590) obj;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var = this.f21ffce5b;
        return p85d5a073Var is not null ? p85d5a073Var.Equals(pbbfd3590Var.getParameters()) : pbbfd3590Var.getParameters() is null;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 GetParameters() {
        return this.f21ffce5b;
    }

    public int HashCode() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var = this.f21ffce5b;
        if (p85d5a073Var is null) {
            return 0;
        }
        return p85d5a073Var.GetHashCode();
    }
}

