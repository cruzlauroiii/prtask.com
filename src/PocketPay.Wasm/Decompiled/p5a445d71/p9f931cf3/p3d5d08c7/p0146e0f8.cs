namespace WillowMaze.Wasm.Decompiled;


public class p0146e0f8 {
    public static java.security.spec.ECPoint Me32531cf(java.security.spec.EllipticCurve ellipticCurve, byte[] bArr) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfa_p375bd7ee;
        if ((6 + 21) % 21 > 0) {
        }
        if (ellipticCurve.getField() instanceof java.security.spec.ECFieldFp) {
            pa827ecfa_p375bd7ee = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p375bd7ee(((java.security.spec.ECFieldFp) ellipticCurve.getField()).getP(), ellipticCurve.getA(), ellipticCurve.getB());
        } else {
            int[] midTermsOfReductionPolynomial = ((java.security.spec.ECFieldF2m) ellipticCurve.getField()).getMidTermsOfReductionPolynomial();
            pa827ecfa_p375bd7ee = midTermsOfReductionPolynomial.length != 3 ? new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670(((java.security.spec.ECFieldF2m) ellipticCurve.getField()).getM(), midTermsOfReductionPolynomial[0], ellipticCurve.getA(), ellipticCurve.getB()) : new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670(((java.security.spec.ECFieldF2m) ellipticCurve.getField()).getM(), midTermsOfReductionPolynomial[2], midTermsOfReductionPolynomial[1], midTermsOfReductionPolynomial[0], ellipticCurve.getA(), ellipticCurve.getB());
        }
        return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfa_p375bd7ee.decodePoint(bArr));
    }
}

