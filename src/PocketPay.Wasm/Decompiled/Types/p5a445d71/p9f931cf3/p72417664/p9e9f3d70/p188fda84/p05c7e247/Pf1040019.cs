namespace WillowMaze.Wasm.Decompiled;

public class Pf1040019
{
    private static Dictionary<string, object> F12a33a98;
    private static Dictionary<string, object> F199d2d47;
    private static Dictionary<string, object> F40cc3d1d;
    private static Dictionary<string, object> F48bb8e77;
    private static Dictionary<string, object> Fee764262;

    public static EllipticCurve M2ace2977(pa827ecfa P0, byte[] P1)
    {
        // call: pf1040019.m7d808e51
        // call: pa827ecfa.getB
        // call: pa827ecfa.getA
        // call: pa827ecfa.getField
        // call: p5a196a0a.toBigInteger
        // call: EllipticCurve.<init>
        // type: EllipticCurve
        return default!;
    }

    public static pa827ecfa M2ace2977(EllipticCurve P0)
    {
        // call: EllipticCurve.getField
        // call: EllipticCurve.getB
        // call: pa827ecfa$p375bd7ee.<init>
        // call: ECFieldF2m.getMidTermsOfReductionPolynomial
        // call: ECFieldFp.getP
        // call: EllipticCurve.getA
        // call: ECFieldF2m.getM
        // call: Dictionary<string, object>.containsKey
        // call: p37c4833e.m346ee843
        // call: pa827ecfa$p73b12670.<init>
        // call: Dictionary<string, object>.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.f199d2d47
        // type: pa827ecfa$p73b12670
        // type: pa827ecfa$p375bd7ee
        return default!;
    }

    public static pa827ecfa M4ed3e6a2(pfe41e66b P0, p15be22c4 P1)
    {
        // str: "encoded parameters not acceptable"
        // str: "named curve not acceptable"
        // call: p80f8c729.m8bab0102
        // call: p35e46fcb.m8bab0102
        // call: p364bf33a.m8bab0102
        // call: p835df581.getCurve
        // call: p15be22c4.isNamedCurve
        // call: p80f8c729.getObjectAt
        // call: pfe41e66b.getAcceptableNamedCurves
        // call: HashSet<object>.isEmpty
        // call: HashSet<object>.contains
        // call: p35e46fcb.getCurve
        // call: Dictionary<string, object>.get
        // call: pfe41e66b.getAdditionalECParameters
        // call: pbc37938c.m00471973
        // call: p37c4833e.mf7b916f7
        // call: p15be22c4.isImplicitlyCA
        // call: IllegalStateException.<init>
        // call: pfe41e66b.getEcImplicitlyCa
        // call: p15be22c4.getParameters
        // call: p80f8c729.size
        // type: IllegalStateException
        return default!;
    }

    public static ECField M7d808e51(pe4575263 P0)
    {
        // call: pe4575263.getCharacteristic
        // call: pff43b8de.m266521a1
        // call: p7f9339ec.getMinimalPolynomial
        // call: p8ede7675.ma5181170
        // call: p24ecfbe3.getDegree
        // call: pff43b8de.mb084e52d
        // call: ECFieldFp.<init>
        // call: ECFieldF2m.<init>
        // call: p24ecfbe3.getExponentsPresent
        // type: ECFieldF2m
        // type: ECFieldFp
        return default!;
    }

    public static p21c2eb74 M8a2fc590(pfe41e66b P0, ECParameterSpec P1)
    {
        // call: p835df581.getG
        // call: p835df581.getN
        // call: p37c4833e.m8a2fc590
        // call: p21c2eb74.<init>
        // call: p835df581.getCurve
        // call: p835df581.getSeed
        // call: p835df581.getH
        // call: pf1040019.mce32677e
        // call: pfe41e66b.getEcImplicitlyCa
        // type: p21c2eb74
        return default!;
    }

    public static ECParameterSpec M96bcaeb3(p21c2eb74 P0)
    {
        // call: pf1040019.m2ace2977
        // call: p21c2eb74.getN
        // call: p21c2eb74.getH
        // call: p21c2eb74.getCurve
        // call: pf1040019.maa4c417b
        // call: ECParameterSpec.<init>
        // call: System.Numerics.BigInteger.intValue
        // call: p21c2eb74.getG
        // type: ECParameterSpec
        return default!;
    }

    public static ECParameterSpec M96bcaeb3(p15be22c4 P0, pa827ecfa P1)
    {
        // call: Dictionary<string, object>.isEmpty
        // call: p35e46fcb.getSeed
        // call: pbc37938c.m32132c89
        // call: p8226e45f.getSeed
        // call: p35e46fcb.getG
        // call: pf1040019.maa4c417b
        // call: p35e46fcb.getH
        // call: p8226e45f.getH
        // call: Dictionary<string, object>.get
        // call: p35e46fcb.getN
        // call: pf1040019.m2ace2977
        // call: p15be22c4.getParameters
        // call: p698f972d.<init>
        // call: p37c4833e.mf7b916f7
        // call: p8226e45f.getG
        // call: p3d5f6347.getPublicKeyParamSet
        // call: pfe41e66b.getAdditionalECParameters
        // call: p15be22c4.isImplicitlyCA
        // call: p8226e45f.getCurve
        // call: p8226e45f.getN
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        // type: ECParameterSpec
        // type: p698f972d
        return default!;
    }

    public static ECParameterSpec M96bcaeb3(p35e46fcb P0)
    {
        // call: pf1040019.m2ace2977
        // call: ECParameterSpec.<init>
        // call: p35e46fcb.getH
        // call: p35e46fcb.getCurve
        // call: p35e46fcb.getN
        // call: pf1040019.maa4c417b
        // call: p35e46fcb.getG
        // call: System.Numerics.BigInteger.intValue
        // type: ECParameterSpec
        return default!;
    }

    public static ECPoint Maa4c417b(p53a5793f P0)
    {
        // call: p53a5793f.getAffineYCoord
        // call: ECPoint.<init>
        // call: p53a5793f.normalize
        // call: p53a5793f.getAffineXCoord
        // call: p5a196a0a.toBigInteger
        // type: ECPoint
        return default!;
    }

    public static p53a5793f Maa4c417b(ECParameterSpec P0, ECPoint P1)
    {
        // call: pf1040019.m2ace2977
        // call: pf1040019.maa4c417b
        // call: ECParameterSpec.getCurve
        return default!;
    }

    public static p53a5793f Maa4c417b(pa827ecfa P0, ECPoint P1)
    {
        // call: ECPoint.getAffineY
        // call: pa827ecfa.createPoint
        // call: ECPoint.getAffineX
        return default!;
    }

    public static ECParameterSpec Mce32677e(EllipticCurve P0, p835df581 P1)
    {
        // call: System.Numerics.BigInteger.intValue
        // call: p835df581.getH
        // call: p698f972d.<init>
        // call: p8226e45f.getName
        // call: ECParameterSpec.<init>
        // call: p835df581.getN
        // call: p835df581.getG
        // call: pf1040019.maa4c417b
        // type: ECParameterSpec
        // type: p698f972d
        return default!;
    }

    public static p835df581 Mce32677e(ECParameterSpec P0)
    {
        // call: System.Numerics.BigInteger.valueOf
        // call: pf1040019.m2ace2977
        // call: ECParameterSpec.getGenerator
        // call: ECParameterSpec.getCurve
        // call: ECParameterSpec.getCofactor
        // call: EllipticCurve.getSeed
        // call: p698f972d.getName
        // call: p835df581.<init>
        // call: ECParameterSpec.getOrder
        // call: pf1040019.maa4c417b
        // call: p8226e45f.<init>
        // type: p835df581
        // type: p8226e45f
        return default!;
    }

}
