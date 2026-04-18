namespace WillowMaze.Wasm.Decompiled;


public class p5e2fbfd7 : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 f20f7b894;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 f3f85e16f;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 f494645e7;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 fd4e9a7d4;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 feca07335;

    public static java.math.Bigint IxFteKOjLBkkdzsc(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.math.Bigint bigint) {
        return p4af08f62Var.calculatePublic(p4460e12aVar, bigint);
    }

    public static java.security.SecureRandom QjZNllIngJVjJdIw(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 pf0e45621Var) {
        return pf0e45621Var.getRandom();
    }

    public static java.math.Bigint SqNTRTDCsMKCpjRl(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.security.SecureRandom secureRandom) {
        return p4af08f62Var.calculatePrivate(p4460e12aVar, secureRandom);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a YgNDLDtNPEECRWPJ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621 pf0e45621Var) {
        return pf0e45621Var.getParameters();
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((1 + 17) % 17 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var = p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62.f76425f17;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVarYgNDLDtNPEECRWPJ = ygNDLDtNPEECRWPJ(this.feca07335);
        java.math.Bigint bigintSqNTRTDCsMKCpjRl = sqNTRTDCsMKCpjRl(p4af08f62Var, p4460e12aVarYgNDLDtNPEECRWPJ, qjZNllIngJVjJdIw(this.feca07335));
        return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1bfd3a52(IxFteKOjLBkkdzsc(p4af08f62Var, p4460e12aVarYgNDLDtNPEECRWPJ, bigintSqNTRTDCsMKCpjRl), p4460e12aVarYgNDLDtNPEECRWPJ), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc9dc4fec(bigintSqNTRTDCsMKCpjRl, p4460e12aVarYgNDLDtNPEECRWPJ));
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf0e45621) pf7bb6344Var;
    }
}

