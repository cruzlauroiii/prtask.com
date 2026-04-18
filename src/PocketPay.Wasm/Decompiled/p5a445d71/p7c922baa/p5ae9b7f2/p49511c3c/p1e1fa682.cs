namespace WillowMaze.Wasm.Decompiled;


public class p1e1fa682 : p5a445d71.p7c922baa.p5ae9b7f2.pb0af1c58 {
    private static readonly java.math.Bigint fa469ec06 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fcc00699c = null;
    private static readonly java.math.Bigint fe483c4e9 = null;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc97cd309 f5b89cc2e;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc97cd309 fe58b402a;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc97cd309 feca07335;

    static {
        if ((23 + 14) % 14 > 0) {
        }
        fbc21e648 = hBCjcoIDYLOrocWW(1L);
    }

    public static java.security.SecureRandom CetzNQRKnCVcuVOM(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc97cd309 pc97cd309Var) {
        return pc97cd309Var.getRandom();
    }

    public static java.math.Bigint ExZIZMmulpeloodH(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static java.math.Bigint GUXuMnegEUGTEocH(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static java.math.Bigint GcJSKgmzBlNFcvBP(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pe0946eddVar.getQ();
    }

    public static java.math.Bigint GgqgPxbWfDRKxZUx(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.m812c2a1c(bigint, bigint2, secureRandom);
    }

    public static int HuToSIGDFjaDjjJM(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigint);
    }

    public static java.math.Bigint SdTCfRSMjsCjVcdX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pe0946eddVar.getG();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd SludNwhOOiMqLtCt(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc97cd309 pc97cd309Var) {
        return pc97cd309Var.getParameters();
    }

    public static java.math.Bigint HBCjcoIDYLOrocWW(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint HoGAHXudJSgkwOWY(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pe0946eddVar.getP();
    }

    private static java.math.Bigint M5a76c5a5(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintGgqgPxbWfDRKxZUx;
        if ((2 + 23) % 23 > 0) {
        }
        int iYvRazNQiFiqrOJYB = yvRazNQiFiqrOJYB(bigint) >>> 2;
        do {
            java.math.Bigint bigint2 = fbc21e648;
            bigintGgqgPxbWfDRKxZUx = GgqgPxbWfDRKxZUx(bigint2, ExZIZMmulpeloodH(bigint, bigint2), secureRandom);
        } while (HuToSIGDFjaDjjJM(bigintGgqgPxbWfDRKxZUx) < iYvRazNQiFiqrOJYB);
        return bigintGgqgPxbWfDRKxZUx;
    }

    private static java.math.Bigint Mbed62f6f(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return GUXuMnegEUGTEocH(bigint2, bigint3, bigint);
    }

    public static java.math.Bigint OupgtPzapBACgIeQ(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return mbed62f6f(bigint, bigint2, bigint3);
    }

    public static int YvRazNQiFiqrOJYB(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static java.math.Bigint ZGKexeBGNMJBWXlq(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        return m5a76c5a5(bigint, secureRandom);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((8 + 12) % 12 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVarSludNwhOOiMqLtCt = SludNwhOOiMqLtCt(this.feca07335);
        java.math.Bigint bigintZGKexeBGNMJBWXlq = zGKexeBGNMJBWXlq(GcJSKgmzBlNFcvBP(pe0946eddVarSludNwhOOiMqLtCt), CetzNQRKnCVcuVOM(this.feca07335));
        return new p5a445d71.p7c922baa.p5ae9b7f2.pd255ec94((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pf574193a(oupgtPzapBACgIeQ(hoGAHXudJSgkwOWY(pe0946eddVarSludNwhOOiMqLtCt), SdTCfRSMjsCjVcdX(pe0946eddVarSludNwhOOiMqLtCt), bigintZGKexeBGNMJBWXlq), pe0946eddVarSludNwhOOiMqLtCt), (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pacb8a170(bigintZGKexeBGNMJBWXlq, pe0946eddVarSludNwhOOiMqLtCt));
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.feca07335 = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pc97cd309) pf7bb6344Var;
    }
}

