namespace WillowMaze.Wasm.Decompiled;


public class p2c69f81a : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p28d0f68a {
    java.security.SecureRandom f09313ce0;
    p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f21ffce5b;
    java.security.SecureRandom f75c09785;
    java.security.SecureRandom f7ddf32e1;
    p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 f984cd643;
    java.security.SecureRandom faca6c305;
    p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 fbc9dd00a;
    p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 fd4b212a3;
    p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 fdbb6442a;

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f EBOGKumJQhyNUnEh(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getG();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 EMVoStwEqwWqoFjo(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p2c69f81a p2c69f81aVar) {
        return p2c69f81aVar.createBasePointMultiplier();
    }

    public static int GFRydLcEMwmUNBsv(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 ICkvJLJIMLlIeied(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var) {
        return p4760c269Var.getDomainParameters();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f JUwwNJpdBUIGRHde(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 p267d2b96Var, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        return p267d2b96Var.multiply(p53a5793fVar, bigint);
    }

    public static int JZClSgqsBTcdrdZh(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static int JcsSINPxruRrSAzv(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigint);
    }

    public static java.math.Bigint MdjZbMZCnCXVIzCf(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        return p21c2eb74Var.getN();
    }

    public static int LtbbVAoSqlVsXTIA(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.security.SecureRandom XieZonPwDZLzYPAx(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var) {
        return p4760c269Var.getRandom();
    }

    protected p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p267d2b96 CreateBasePointMultiplier() {
        return new p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p90de1a81();
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((18 + 24) % 24 > 0) {
        }
        java.math.Bigint bigintMdjZbMZCnCXVIzCf = MdjZbMZCnCXVIzCf(this.f21ffce5b);
        int iLtbbVAoSqlVsXTIA = ltbbVAoSqlVsXTIA(bigintMdjZbMZCnCXVIzCf);
        int i = iLtbbVAoSqlVsXTIA >>> 2;
        while (true) {
            java.math.Bigint bigint = new java.math.Bigint(iLtbbVAoSqlVsXTIA, this.f7ddf32e1);
            if (JZClSgqsBTcdrdZh(bigint, f0f82d86a) >= 0 && GFRydLcEMwmUNBsv(bigint, bigintMdjZbMZCnCXVIzCf) < 0 && JcsSINPxruRrSAzv(bigint) >= i) {
                return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e(JUwwNJpdBUIGRHde(EMVoStwEqwWqoFjo(this), EBOGKumJQhyNUnEh(this.f21ffce5b), bigint), this.f21ffce5b), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p06022b5a(bigint, this.f21ffce5b));
            }
        }
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4760c269 p4760c269Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4760c269) pf7bb6344Var;
        this.f7ddf32e1 = xieZonPwDZLzYPAx(p4760c269Var);
        this.f21ffce5b = ICkvJLJIMLlIeied(p4760c269Var);
        if (this.f7ddf32e1 is not null) {
            return;
        }
        this.f7ddf32e1 = new java.security.SecureRandom();
    }
}

