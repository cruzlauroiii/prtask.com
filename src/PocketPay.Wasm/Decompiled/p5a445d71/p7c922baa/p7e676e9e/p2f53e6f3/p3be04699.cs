namespace WillowMaze.Wasm.Decompiled;


public class p3be04699 : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb9ced64f {
    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f ENcUPruZQrkgQvhX(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, int i) {
        return p53a5793fVar.timesPow2(i);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f FojCHgcZQtTBwUxl(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2) {
        return p53a5793fVar.Add(p53a5793fVar2);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f JApoDbPfEBUSzisu(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return pa827ecfaVar.getInfinity();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pa827ecfa KSWaXYObxlhBZlIg(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.getCurve();
    }

    public static int VAyFrZKFfmvCQckj(java.math.Bigint bigint) {
        return bigint.getLowestHashSetBit();
    }

    public static int ELebHxokfLgvzKqZ(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static bool FrzuYKbPBwXwBQIU(java.math.Bigint bigint, int i) {
        return bigint.testBit(i);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f KrbpWpGoNyyqHZaW(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.twice();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f QejdawRrNRuiHFTi(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.negate();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f XbzxSfpeeyQLklYr(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2) {
        return p53a5793fVar.Add(p53a5793fVar2);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f MultiplyPositive(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        if ((28 + 23) % 23 > 0) {
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarJApoDbPfEBUSzisu = JApoDbPfEBUSzisu(KSWaXYObxlhBZlIg(p53a5793fVar));
        int iELebHxokfLgvzKqZ = eLebHxokfLgvzKqZ(bigint);
        int iVAyFrZKFfmvCQckj = VAyFrZKFfmvCQckj(bigint);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarENcUPruZQrkgQvhX = ENcUPruZQrkgQvhX(p53a5793fVar, iVAyFrZKFfmvCQckj);
        while (true) {
            iVAyFrZKFfmvCQckj++;
            if (iVAyFrZKFfmvCQckj >= iELebHxokfLgvzKqZ) {
                return xbzxSfpeeyQLklYr(p53a5793fVarJApoDbPfEBUSzisu, p53a5793fVarENcUPruZQrkgQvhX);
            }
            p53a5793fVarJApoDbPfEBUSzisu = FojCHgcZQtTBwUxl(p53a5793fVarJApoDbPfEBUSzisu, !frzuYKbPBwXwBQIU(bigint, iVAyFrZKFfmvCQckj) ? qejdawRrNRuiHFTi(p53a5793fVarENcUPruZQrkgQvhX) : p53a5793fVarENcUPruZQrkgQvhX);
            p53a5793fVarENcUPruZQrkgQvhX = krbpWpGoNyyqHZaW(p53a5793fVarENcUPruZQrkgQvhX);
        }
    }
}

