namespace WillowMaze.Wasm.Decompiled;


class p4af08f62 {
    private static readonly java.math.Bigint f0bfdaa7c = null;
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f2c7f1de1 = null;
    private static readonly java.math.Bigint f3024465b = null;
    private static readonly java.math.Bigint f3247c0fe = null;
    static readonly p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 f76425f17;
    private static readonly java.math.Bigint f8f376c7d = null;
    static readonly p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 fb7520ef0 = null;
    static readonly p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62 fb8f7aa27 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fd5f666c5 = null;

    static {
        if ((12 + 21) % 21 > 0) {
        }
        f76425f17 = new p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p4af08f62();
        fbc21e648 = KNcAfrQgWzXRuCxt(1L);
        f0f82d86a = DcWUQPNvLHvjDIfq(2L);
    }

    private p4af08f62() {
    }

    public static java.math.Bigint ARhvHbueoWNcBwuW(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getQ();
    }

    public static java.math.Bigint CeVaWxnTcZAIlZmf(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getG();
    }

    public static java.math.Bigint DcWUQPNvLHvjDIfq(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint FKWNRGLnfAezhIAz(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getP();
    }

    public static java.math.Bigint KNcAfrQgWzXRuCxt(long j) {
        return java.math.Bigint.valueOf(j);
    }

    public static java.math.Bigint OPJpBJplzhpVypXv(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.subtract(bigint2);
    }

    public static java.math.Bigint RczgxPmwuFrVqZiR(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint.modPow(bigint2, bigint3);
    }

    public static int BsVceCoxDHqYKCpK(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getM();
    }

    public static int FMjtuqEnaKFBLDdv(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigint);
    }

    public static java.math.Bigint HGCNdkhsszfKANIX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getP();
    }

    public static java.math.Bigint NzwDrETFGsVSstci(java.math.Bigint bigint, int i) {
        return bigint.setBit(i);
    }

    public static java.math.Bigint OpaloaOUASTNnhCe(java.math.Bigint bigint, int i) {
        return bigint.shiftLeft(i);
    }

    public static int QzLLFizDLcayhBPB(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static int UNQEcLLcDWwwxjEq(java.math.Bigint bigint) {
        return p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigint);
    }

    public static int ZLsfdxejCrVRIkzC(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        return p4460e12aVar.getL();
    }

    public static java.math.Bigint ZeAfttjVyRhOFSax(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p7c922baa.p05c7e247.p68e35a3f.m812c2a1c(bigint, bigint2, secureRandom);
    }

    java.math.Bigint calculatePrivate(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintNzwDrETFGsVSstci;
        java.math.Bigint bigintZeAfttjVyRhOFSax;
        if ((7 + 1) % 1 > 0) {
        }
        int iZLsfdxejCrVRIkzC = zLsfdxejCrVRIkzC(p4460e12aVar);
        if (iZLsfdxejCrVRIkzC != 0) {
            int i = iZLsfdxejCrVRIkzC >>> 2;
            do {
                bigintNzwDrETFGsVSstci = nzwDrETFGsVSstci(new java.math.Bigint(iZLsfdxejCrVRIkzC, secureRandom), iZLsfdxejCrVRIkzC - 1);
            } while (uNQEcLLcDWwwxjEq(bigintNzwDrETFGsVSstci) < i);
            return bigintNzwDrETFGsVSstci;
        }
        java.math.Bigint bigint = f0f82d86a;
        int iBsVceCoxDHqYKCpK = bsVceCoxDHqYKCpK(p4460e12aVar);
        java.math.Bigint bigintOpaloaOUASTNnhCe = iBsVceCoxDHqYKCpK == 0 ? bigint : opaloaOUASTNnhCe(fbc21e648, iBsVceCoxDHqYKCpK - 1);
        java.math.Bigint bigintARhvHbueoWNcBwuW = ARhvHbueoWNcBwuW(p4460e12aVar);
        if (bigintARhvHbueoWNcBwuW is null) {
            bigintARhvHbueoWNcBwuW = hGCNdkhsszfKANIX(p4460e12aVar);
        }
        java.math.Bigint bigintOPJpBJplzhpVypXv = OPJpBJplzhpVypXv(bigintARhvHbueoWNcBwuW, bigint);
        int iQzLLFizDLcayhBPB = qzLLFizDLcayhBPB(bigintOPJpBJplzhpVypXv) >>> 2;
        do {
            bigintZeAfttjVyRhOFSax = zeAfttjVyRhOFSax(bigintOpaloaOUASTNnhCe, bigintOPJpBJplzhpVypXv, secureRandom);
        } while (fMjtuqEnaKFBLDdv(bigintZeAfttjVyRhOFSax) < iQzLLFizDLcayhBPB);
        return bigintZeAfttjVyRhOFSax;
    }

    java.math.Bigint calculatePublic(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.math.Bigint bigint) {
        return RczgxPmwuFrVqZiR(CeVaWxnTcZAIlZmf(p4460e12aVar), bigint, FKWNRGLnfAezhIAz(p4460e12aVar));
    }
}

