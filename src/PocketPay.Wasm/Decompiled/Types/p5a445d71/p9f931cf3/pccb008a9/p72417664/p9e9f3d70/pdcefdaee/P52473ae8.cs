namespace WillowMaze.Wasm.Decompiled;

public class P52473ae8 : KeyFactorySpi, Pae2f7198
{
    public static string F8fb9cb6d;
    public static string Faebf756f;

    private static pe5cfc515 Me0825354(p234a7530 P0)
    {
        // call: p08716e2c.<init>
        // type: p08716e2c
        return default!;
    }

    private PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "Unable to decode PKCS8EncodedKeySpec."
        // str: "Unable to decode PKCS8EncodedKeySpec: "
        // str: "Unsupported key specification: "
        // str: "64f7331433ffd90bfce2f8de3ad698670c424956d73eb65f75e8cfa684"
        // str: "Unable to recognise OID in McEliece private key"
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: InvalidKeySpecException.<init>
        // call: DecryptString.decryptString
        // call: StringBuilder.append
        // call: object.getClass
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: p811299f8.parsePrivateKey
        // call: p3100400d.m8bab0102
        // call: p3100400d.getN
        // call: p3100400d.getK
        // call: p3100400d.getField
        // call: p3100400d.getGoppaPoly
        // call: p3100400d.getP1
        // call: p3100400d.getP2
        // field: p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fb0f41175
        // type: InvalidKeySpecException
        // type: StringBuilder
        // type: pace116e9
        // type: pa1d4de93
        return default!;
    }

    private PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "Unable to recognise OID in McEliece public key"
        // str: "3040a25c57a597dff8bc480e20369d6b93fcc94488453ae41c76d74500"
        // str: "Unsupported key specification: "
        // str: "Unable to decode X509EncodedKeySpec: "
        // call: StringBuilder.<init>
        // call: X509EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p3cdccfc9.m8bab0102
        // call: p3cdccfc9.getAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: p3cdccfc9.parsePublicKey
        // call: pec16886f.m8bab0102
        // call: pec16886f.getN
        // call: pec16886f.getT
        // call: pec16886f.getG
        // call: p62f43b9f.<init>
        // call: p7a0bdffc.<init>
        // call: InvalidKeySpecException.<init>
        // call: IOException.toString
        // call: StringBuilder.toString
        // call: object.getClass
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fb0f41175
        // type: InvalidKeySpecException
        // type: p7a0bdffc
        // type: p62f43b9f
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
        // call: p3100400d.getField
        // call: p3100400d.getP1
        // call: pa1d4de93.<init>
        // call: p3100400d.getN
        // call: p3100400d.getK
        // call: p3100400d.getGoppaPoly
        // call: p3100400d.m8bab0102
        // call: p811299f8.parsePrivateKey
        // call: p3100400d.getP2
        // call: p3100400d.getSInv
        // call: p0fd1bdf1.toASN1Primitive
        // call: pace116e9.<init>
        // type: pa1d4de93
        // type: pace116e9
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: p3cdccfc9.parsePublicKey
        // call: pec16886f.getG
        // call: pec16886f.m8bab0102
        // call: pec16886f.getT
        // call: p62f43b9f.<init>
        // call: pec16886f.getN
        // call: p7a0bdffc.<init>
        // type: p62f43b9f
        // type: p7a0bdffc
        return default!;
    }

    public KeySpec GetKeySpec(Key P0, Type P1)
    {
        // str: "9b4db1410e2fb10c50e7d054644990320a5c0b564f5096d2fe60d355b4"
        // str: "Unknown key specification: "
        // str: "Unsupported key type: "
        // call: Key.getEncoded
        // call: object.getClass
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: PKCS8EncodedKeySpec.<init>
        // call: StringBuilder.<init>
        // call: InvalidKeySpecException.<init>
        // call: Type.isAssignableFrom
        // call: DecryptString.decryptString
        // call: X509EncodedKeySpec.<init>
        // type: PKCS8EncodedKeySpec
        // type: InvalidKeySpecException
        // type: StringBuilder
        // type: X509EncodedKeySpec
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
