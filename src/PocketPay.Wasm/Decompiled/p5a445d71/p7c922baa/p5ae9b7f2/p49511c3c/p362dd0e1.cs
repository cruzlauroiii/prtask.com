namespace WillowMaze.Wasm.Decompiled;


public class p362dd0e1 : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 f972d2c44;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 fd4aed34c;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 feca07335;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 fed14b309;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 ffcb128d8;

    public static java.math.Bigint BBGDZqASAlcHqUOm(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.security.SecureRandom secureRandom) {
        return p4af08f62Var.calculatePrivate(p4460e12aVar, secureRandom);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a XnplshmyVSaxesVF(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 pf0e45621Var) {
        return pf0e45621Var.getParameters();
    }

    public static java.security.SecureRandom VasMMosHPlgRpjHN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 pf0e45621Var) {
        return pf0e45621Var.getRandom();
    }

    public static java.math.Bigint ZIxyCKXvqbUgEqOS(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.math.Bigint bigint) {
        return p4af08f62Var.calculatePublic(p4460e12aVar, bigint);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((29 + 30) % 30 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var = p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62.f76425f17;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVarXnplshmyVSaxesVF = XnplshmyVSaxesVF(this.feca07335);
        java.math.Bigint bigintBBGDZqASAlcHqUOm = BBGDZqASAlcHqUOm(p4af08f62Var, p4460e12aVarXnplshmyVSaxesVF, vasMMosHPlgRpjHN(this.feca07335));
        return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1bfd3a52(zIxyCKXvqbUgEqOS(p4af08f62Var, p4460e12aVarXnplshmyVSaxesVF, bigintBBGDZqASAlcHqUOm), p4460e12aVarXnplshmyVSaxesVF), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc9dc4fec(bigintBBGDZqASAlcHqUOm, p4460e12aVarXnplshmyVSaxesVF));
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621) pf7bb6344Var;
    }
}

