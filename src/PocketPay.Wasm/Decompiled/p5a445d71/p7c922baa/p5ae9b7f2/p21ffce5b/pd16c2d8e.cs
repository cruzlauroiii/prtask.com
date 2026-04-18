namespace WillowMaze.Wasm.Decompiled;


public class pd16c2d8e : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p1235ff36 {
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f264a83c1;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f f39f99e12;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f fa24038e7;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f fab8dd4e9;
    private readonly p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f ff09564c9;

    public pd16c2d8e(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        super(false, p21c2eb74Var);
        this.ff09564c9 = CWVJiadEuqRTKgiI(this, p53a5793fVar);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f CWVJiadEuqRTKgiI(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pd16c2d8e pd16c2d8eVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return pd16c2d8eVar.mf9ab0545(p53a5793fVar);
    }

    public static bool RgomplLSFVrOjJvH(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.isInfinity();
    }

    public static bool TaabeKlfADcfaUfN(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.isValid();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f FURfFnIEONBRSCot(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.normalize();
    }

    private p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f Mf9ab0545(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if (p53a5793fVar is null) {
            throw new java.lang.IllegalArgumentException("point has null value");
        }
        if (RgomplLSFVrOjJvH(p53a5793fVar)) {
            throw new java.lang.IllegalArgumentException("point at infinity");
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarFURfFnIEONBRSCot = fURfFnIEONBRSCot(p53a5793fVar);
        if (TaabeKlfADcfaUfN(p53a5793fVarFURfFnIEONBRSCot)) {
            return p53a5793fVarFURfFnIEONBRSCot;
        }
        throw new java.lang.IllegalArgumentException("point not on curve");
    }

    public p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f GetQ() {
        return this.ff09564c9;
    }
}

