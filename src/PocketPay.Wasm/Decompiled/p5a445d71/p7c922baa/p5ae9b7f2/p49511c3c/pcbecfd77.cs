namespace WillowMaze.Wasm.Decompiled;


public class pcbecfd77 : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p3d024eaa f036d857a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p3d024eaa fd6d8a0d7;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p3d024eaa feca07335;

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 RgxfAqJYZbcGOwLl(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p3d024eaa p3d024eaaVar) {
        return p3d024eaaVar.getParameters();
    }

    public static java.math.Bigint WGwpWOdhRfXTCvcL(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.math.Bigint bigint) {
        return p4af08f62Var.calculatePublic(p4460e12aVar, bigint);
    }

    public static java.math.Bigint YkDEhaVhCbKdnSWz(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.security.SecureRandom secureRandom) {
        return p4af08f62Var.calculatePrivate(p4460e12aVar, secureRandom);
    }

    public static java.math.Bigint ZGWkCrrUmrTWaTve(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getP();
    }

    public static java.security.SecureRandom GMwCaFrFrPoDwtsY(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p3d024eaa p3d024eaaVar) {
        return p3d024eaaVar.getRandom();
    }

    public static java.math.Bigint MWwtwfaaGvYScbtY(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getG();
    }

    public static int RaGKBEkHGbBWgXfq(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073Var) {
        return p85d5a073Var.getL();
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((22 + 9) % 9 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 p4af08f62Var = p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62.f76425f17;
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p85d5a073 p85d5a073VarRgxfAqJYZbcGOwLl = RgxfAqJYZbcGOwLl(this.feca07335);
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar = new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a(ZGWkCrrUmrTWaTve(p85d5a073VarRgxfAqJYZbcGOwLl), mWwtwfaaGvYScbtY(p85d5a073VarRgxfAqJYZbcGOwLl), null, raGKBEkHGbBWgXfq(p85d5a073VarRgxfAqJYZbcGOwLl));
        java.math.Bigint bigintYkDEhaVhCbKdnSWz = YkDEhaVhCbKdnSWz(p4af08f62Var, p4460e12aVar, gMwCaFrFrPoDwtsY(this.feca07335));
        return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6fc6e0d0(WGwpWOdhRfXTCvcL(p4af08f62Var, p4460e12aVar, bigintYkDEhaVhCbKdnSWz), p85d5a073VarRgxfAqJYZbcGOwLl), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8d0590d4(bigintYkDEhaVhCbKdnSWz, p85d5a073VarRgxfAqJYZbcGOwLl));
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p3d024eaa) pf7bb6344Var;
    }
}

