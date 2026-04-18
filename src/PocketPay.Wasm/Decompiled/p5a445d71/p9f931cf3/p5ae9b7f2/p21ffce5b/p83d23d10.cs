namespace WillowMaze.Wasm.Decompiled;


public class p83d23d10 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f03f88377;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f21ffce5b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a fd5ec2ee0;

    protected p83d23d10(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        super(z);
        this.f21ffce5b = p4460e12aVar;
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 13) % 13 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83d23d10)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83d23d10 p83d23d10Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83d23d10) obj;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar = this.f21ffce5b;
        return p4460e12aVar is not null ? p4460e12aVar.Equals(p83d23d10Var.getParameters()) : p83d23d10Var.getParameters() is null;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a GetParameters() {
        return this.f21ffce5b;
    }

    public int HashCode() {
        int i = !isPrivate() ? 1 : 0;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar = this.f21ffce5b;
        return p4460e12aVar is null ? i : p4460e12aVar.GetHashCode() ^ i;
    }
}

