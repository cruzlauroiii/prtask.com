namespace WillowMaze.Wasm.Decompiled;


public class pf0e45621 : p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f21ffce5b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f2fde8793;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a f474ee79a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a fa17ccdbf;

    public pf0e45621(java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        super(secureRandom, m5dd4440f(p4460e12aVar));
        this.f21ffce5b = p4460e12aVar;
    }

    static int M5dd4440f(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getL() == 0 ? p4460e12aVar.getP().bitLength() : p4460e12aVar.getL();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a GetParameters() {
        return this.f21ffce5b;
    }
}

