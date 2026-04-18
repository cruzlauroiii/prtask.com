namespace WillowMaze.Wasm.Decompiled;

public class P5630c550 : KeyFactorySpi, Pae2f7198
{
    public static string Faebf756f;
    public static string Fcd8a57f1;

    private PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "Unsupported key specification: "
        // str: "Unable to decode PKCS8EncodedKeySpec: "
        // str: "5b17399505dd4d6a304b3162f3162943db227487198707dd5b45bd6265"
        // str: "Unable to decode PKCS8EncodedKeySpec."
        // str: "Unable to recognise OID in McEliece public key"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.toString
        // call: object.getClass
        // call: DecryptString.decryptString
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: p811299f8.parsePrivateKey
        // call: pddbd07cd.m8bab0102
        // call: pddbd07cd.getN
        // call: pddbd07cd.getK
        // call: pddbd07cd.getField
        // call: pddbd07cd.getGoppaPoly
        // call: pddbd07cd.getP
        // call: pddbd07cd.getDigest
        // field: p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf
        // type: InvalidKeySpecException
        // type: StringBuilder
        // type: pdfc33cf2
        // type: p0d2c2c1f
        return default!;
    }

    private PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "Unable to recognise OID in McEliece private key"
        // str: "53ae6efdd875f08fae90b1eded0014e09f2fa719beaa278bcd91d9a42f"
        // str: "Unable to decode X509EncodedKeySpec: "
        // str: "Unsupported key specification: "
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.append
        // call: X509EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p3cdccfc9.m8bab0102
        // call: p3cdccfc9.getAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: p3cdccfc9.parsePublicKey
        // call: p751e4728.m8bab0102
        // call: p751e4728.getN
        // call: p751e4728.getT
        // call: p751e4728.getG
        // call: p751e4728.getDigest
        // call: pa470a233.me0825354
        // call: pe5cfc515.getAlgorithmName
        // call: pb4d95bfe.<init>
        // call: p002d5cbb.<init>
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf
        // type: InvalidKeySpecException
        // type: p002d5cbb
        // type: pb4d95bfe
        // type: StringBuilder
        return default!;
    }

    private KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        return default!;
    }

    private Key EngineTranslateKey(Key P0)
    {
        return default!;
    }

    public PrivateKey GeneratePrivate(p811299f8 P0)
    {
        // call: pdfc33cf2.<init>
        // call: p0fd1bdf1.toASN1Primitive
        // call: p0d2c2c1f.<init>
        // call: pddbd07cd.getField
        // call: p811299f8.parsePrivateKey
        // call: pddbd07cd.getP
        // call: pddbd07cd.getK
        // call: pddbd07cd.getGoppaPoly
        // call: pddbd07cd.m8bab0102
        // call: pddbd07cd.getN
        // type: pdfc33cf2
        // type: p0d2c2c1f
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: p751e4728.getG
        // call: p002d5cbb.<init>
        // call: pe5cfc515.getAlgorithmName
        // call: pa470a233.me0825354
        // call: p751e4728.getDigest
        // call: p3cdccfc9.parsePublicKey
        // call: p751e4728.m8bab0102
        // call: pb4d95bfe.<init>
        // call: p751e4728.getT
        // call: p751e4728.getN
        // type: pb4d95bfe
        // type: p002d5cbb
        return default!;
    }

    public KeySpec GetKeySpec(Key P0, Type P1)
    {
        // str: "Unknown key specification: "
        // str: "Unsupported key type: "
        // str: "427367e7b7e735b82b2f9b454310655bec2c8e5debd888290d4d9286ca"
        // call: StringBuilder.append
        // call: Key.getEncoded
        // call: DecryptString.decryptString
        // call: StringBuilder.toString
        // call: PKCS8EncodedKeySpec.<init>
        // call: Type.isAssignableFrom
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: X509EncodedKeySpec.<init>
        // type: StringBuilder
        // type: X509EncodedKeySpec
        // type: InvalidKeySpecException
        // type: PKCS8EncodedKeySpec
        return default!;
    }

    public Key TranslateKey(Key P0)
    {
        // str: "Unsupported key type."
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return default!;
    }

}
