namespace WillowMaze.Wasm.Decompiled;


public class p24d9a6a4 : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe5a0758c f6d1b294d;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe5a0758c f70b65add;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe5a0758c fb094a2ef;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe5a0758c feca07335;

    public static java.security.SecureRandom ELzkvWIsznVJfjfc(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe5a0758c pe5a0758cVar) {
        return pe5a0758cVar.getRandom();
    }

    public static java.math.Bigint MaqBcTwZiJoqLZMM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        return p9c4e2d05Var.getQ();
    }

    public static java.math.Bigint PxgbnEwAMZEETKZh(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static int SBvbPbXZPlRYaKSv(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigint);
    }

    public static int DWYaFfCUMTrZEBoq(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.compareTo(bigint2);
    }

    public static int FqhfgbYGXrYGSROn(java.math.Bigint bigint) {
        return bigint.signum();
    }

    public static java.math.Bigint JWaVcjbZqFpiBsvk(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        return p9c4e2d05Var.getA();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 XUnkzumWjXvpFWlN(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe5a0758c pe5a0758cVar) {
        return pe5a0758cVar.getParameters();
    }

    public static java.math.Bigint ZzKlDLkBUjQsehpV(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05Var) {
        return p9c4e2d05Var.getP();
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((29 + 6) % 6 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c4e2d05 p9c4e2d05VarXUnkzumWjXvpFWlN = xUnkzumWjXvpFWlN(this.feca07335);
        java.security.SecureRandom secureRandomELzkvWIsznVJfjfc = ELzkvWIsznVJfjfc(this.feca07335);
        java.math.Bigint bigintMaqBcTwZiJoqLZMM = MaqBcTwZiJoqLZMM(p9c4e2d05VarXUnkzumWjXvpFWlN);
        java.math.Bigint bigintZzKlDLkBUjQsehpV = zzKlDLkBUjQsehpV(p9c4e2d05VarXUnkzumWjXvpFWlN);
        java.math.Bigint bigintJWaVcjbZqFpiBsvk = jWaVcjbZqFpiBsvk(p9c4e2d05VarXUnkzumWjXvpFWlN);
        while (true) {
            java.math.Bigint bigint = new java.math.Bigint(256, secureRandomELzkvWIsznVJfjfc);
            if (fqhfgbYGXrYGSROn(bigint) >= 1 && dWYaFfCUMTrZEBoq(bigint, bigintMaqBcTwZiJoqLZMM) < 0 && SBvbPbXZPlRYaKSv(bigint) >= 64) {
                return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p23005be8(PxgbnEwAMZEETKZh(bigintJWaVcjbZqFpiBsvk, bigint, bigintZzKlDLkBUjQsehpV), p9c4e2d05VarXUnkzumWjXvpFWlN), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c2a10cf(bigint, p9c4e2d05VarXUnkzumWjXvpFWlN));
            }
        }
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe5a0758c) pf7bb6344Var;
    }
}

