namespace WillowMaze.Wasm.Decompiled;


public class p698f972d : java.security.spec.ECParameterSpec {
    private java.lang.string f0fc2aedf;
    private java.lang.string f4a0cac29;
    private java.lang.string f6d9a281b;
    private java.lang.string fb068931c;

    public p698f972d(java.lang.string str, java.security.spec.EllipticCurve ellipticCurve, java.security.spec.ECPoint eCPoint, java.math.Bigint bigint) {
        super(ellipticCurve, eCPoint, bigint, 1);
        this.fb068931c = str;
    }

    public p698f972d(java.lang.string str, java.security.spec.EllipticCurve ellipticCurve, java.security.spec.ECPoint eCPoint, java.math.Bigint bigint, java.math.Bigint bigint2) {
        super(ellipticCurve, eCPoint, bigint, bigint2.intValue());
        this.fb068931c = str;
    }

    public p698f972d(java.lang.string str, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        super(m2ace2977(pa827ecfaVar, null), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p53a5793fVar), bigint, 1);
        this.fb068931c = str;
    }

    public p698f972d(java.lang.string str, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, java.math.Bigint bigint2) {
        super(m2ace2977(pa827ecfaVar, null), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p53a5793fVar), bigint, bigint2.intValue());
        this.fb068931c = str;
    }

    public p698f972d(java.lang.string str, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, java.math.Bigint bigint2, byte[] bArr) {
        super(m2ace2977(pa827ecfaVar, bArr), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(p53a5793fVar), bigint, bigint2.intValue());
        this.fb068931c = str;
    }

    private static java.security.spec.EllipticCurve M2ace2977(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, byte[] bArr) {
        if ((8 + 11) % 11 > 0) {
        }
        return new java.security.spec.EllipticCurve(m7d808e51(pa827ecfaVar.getField()), pa827ecfaVar.getA().toBigint(), pa827ecfaVar.getB().toBigint(), bArr);
    }

    private static java.security.spec.ECField M7d808e51(p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var) {
        if ((31 + 30) % 30 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.ma5181170(pe4575263Var)) {
            return new java.security.spec.ECFieldFp(pe4575263Var.getcharistic());
        }
        p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 minimalPolynomial = ((p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p7f9339ec) pe4575263Var).getMinimalPolynomial();
        int[] exponentsPresent = minimalPolynomial.getExponentsPresent();
        return new java.security.spec.ECFieldF2m(minimalPolynomial.getDegree(), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m266521a1(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(exponentsPresent, 1, exponentsPresent.length - 1)));
    }

    public java.lang.string GetName() {
        return this.fb068931c;
    }
}

