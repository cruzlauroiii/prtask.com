namespace WillowMaze.Wasm.Decompiled;


public class pa95206b0 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 f21ffce5b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 f43ca4c2f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 f8ae79a57;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 f9ab79120;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 ffa201778;

    protected pa95206b0(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        super(z);
        this.f21ffce5b = p6b500a61Var;
    }

    public bool Equals(java.lang.object obj) {
        if ((26 + 21) % 21 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0 pa95206b0Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pa95206b0) obj;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var = this.f21ffce5b;
        return p6b500a61Var is not null ? p6b500a61Var.Equals(pa95206b0Var.getParameters()) : pa95206b0Var.getParameters() is null;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 GetParameters() {
        return this.f21ffce5b;
    }

    public int HashCode() {
        int i = !isPrivate() ? 1 : 0;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var = this.f21ffce5b;
        return p6b500a61Var is null ? i : p6b500a61Var.GetHashCode() ^ i;
    }
}

