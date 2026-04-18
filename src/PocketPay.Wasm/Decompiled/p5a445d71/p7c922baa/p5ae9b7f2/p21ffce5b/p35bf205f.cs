namespace WillowMaze.Wasm.Decompiled;


public class p35bf205f : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f08edd4e1;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f6534c210;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e f67238b24;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a f9b987cc5;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e fbd839fe8;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a fbecc613c;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a fcdc8ced4;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e fe5d2d3ca;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a ff26b1375;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a ff8da9f2c;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e ff9974465;

    public p35bf205f(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2) {
        this(p06022b5aVar, p06022b5aVar2, null);
    }

    public p35bf205f(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar2, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        if ((1 + 26) % 26 > 0) {
        }
        if (p06022b5aVar is null) {
            throw new java.lang.NullPointerException("staticPrivateKey cannot be null");
        }
        if (p06022b5aVar2 is null) {
            throw new java.lang.NullPointerException("ephemeralPrivateKey cannot be null");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74VarGLUnLkOuSofTwMWJ = gLUnLkOuSofTwMWJ(p06022b5aVar);
        if (!ohNIYuRBUkshcUKl(p21c2eb74VarGLUnLkOuSofTwMWJ, pnCpmdqYuLOYfVBY(p06022b5aVar2))) {
            throw new java.lang.IllegalArgumentException("Static and ephemeral private keys have different domain parameters");
        }
        if (pd16c2d8eVar is null) {
            pd16c2d8eVar = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e(ilHCROtQEMoSQQQo(bZklcFhEfxAZZzbp(p21c2eb74VarGLUnLkOuSofTwMWJ), ynrvkfRVmBsPAUZA(p06022b5aVar2)), p21c2eb74VarGLUnLkOuSofTwMWJ);
        } else if (!DtbfaoJqFvJsuqcn(p21c2eb74VarGLUnLkOuSofTwMWJ, aXEDGTKnoxPfHEZT(pd16c2d8eVar))) {
            throw new java.lang.IllegalArgumentException("Ephemeral public key has different domain parameters");
        }
        this.f08edd4e1 = p06022b5aVar;
        this.ff8da9f2c = p06022b5aVar2;
        this.ff9974465 = pd16c2d8eVar;
    }

    public static bool DtbfaoJqFvJsuqcn(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.lang.object obj) {
        return p21c2eb74Var.Equals(obj);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 AXEDGTKnoxPfHEZT(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar) {
        return pd16c2d8eVar.getParameters();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f BZklcFhEfxAZZzbp(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getG();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 GLUnLkOuSofTwMWJ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getParameters();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f IlHCROtQEMoSQQQo(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p53a5793fVar.multiply(bigint);
    }

    public static bool OhNIYuRBUkshcUKl(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.lang.object obj) {
        return p21c2eb74Var.Equals(obj);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 PnCpmdqYuLOYfVBY(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getParameters();
    }

    public static java.math.Bigint YnrvkfRVmBsPAUZA(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar) {
        return p06022b5aVar.getD();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a GetEphemeralPrivateKey() {
        return this.ff8da9f2c;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e GetEphemeralPublicKey() {
        return this.ff9974465;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a GetStaticPrivateKey() {
        return this.f08edd4e1;
    }
}

