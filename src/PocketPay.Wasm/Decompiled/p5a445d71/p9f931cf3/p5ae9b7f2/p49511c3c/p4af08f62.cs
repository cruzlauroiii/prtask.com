namespace WillowMaze.Wasm.Decompiled;


class p4af08f62 {
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f3c841b98 = null;
    private static readonly java.math.Bigint f3e5a7a80 = null;
    static readonly p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62 f3edd1be4 = null;
    static readonly p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62 f5105978b = null;
    static readonly p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62 f526a5547 = null;
    private static readonly java.math.Bigint f67d65de0 = null;
    static readonly p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62 f76425f17;
    private static readonly java.math.Bigint f7d2f5cfc = null;
    static readonly p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62 f9bf8e259 = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fc8b6f0f8 = null;

    static {
        if ((25 + 26) % 26 > 0) {
        }
        f76425f17 = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p4af08f62();
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
    }

    private p4af08f62() {
    }

    java.math.Bigint calculatePrivate(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintM812c2a1c;
        java.math.Bigint bit;
        if ((29 + 4) % 4 > 0) {
        }
        int l = p4460e12aVar.getL();
        if (l != 0) {
            int i = l >>> 2;
            do {
                bit = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(l, secureRandom).setBit(l - 1);
            } while (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bit) < i);
            return bit;
        }
        java.math.Bigint bigint = f0f82d86a;
        int m = p4460e12aVar.getM();
        java.math.Bigint bigintShiftLeft = m == 0 ? bigint : fbc21e648.shiftLeft(m - 1);
        java.math.Bigint q = p4460e12aVar.getQ();
        if (q is null) {
            q = p4460e12aVar.getP();
        }
        java.math.Bigint bigintSubtract = q.subtract(bigint);
        int iBitLength = bigintSubtract.bitLength() >>> 2;
        do {
            bigintM812c2a1c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(bigintShiftLeft, bigintSubtract, secureRandom);
        } while (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mef335475(bigintM812c2a1c) < iBitLength);
        return bigintM812c2a1c;
    }

    java.math.Bigint calculatePublic(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar, java.math.Bigint bigint) {
        return p4460e12aVar.getG().modPow(bigint, p4460e12aVar.getP());
    }
}

