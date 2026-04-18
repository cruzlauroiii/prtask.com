namespace WillowMaze.Wasm.Decompiled;

public class Pa0b28dcc : KeyFactorySpi, Pae2f7198
{
    public PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "be8986412af502da3ce6ea1e02ed45eeeecc7306b0cf14cfb779d31e72"
        // str: "unsupported key specification: "
        // call: StringBuilder.append
        // call: InvalidKeySpecException.<init>
        // call: object.getClass
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: pa0b28dcc.generatePrivate
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Exception.toString
        // call: DecryptString.decryptString
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "fb3ba9c6d5a2639309cf5e103b81f897c3d103a8166474b96de121ef2f"
        // str: "unknown key specification: "
        // call: InvalidKeySpecException.<init>
        // call: Exception.toString
        // call: DecryptString.decryptString
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: pa0b28dcc.generatePublic
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "unknown key specification: "
        // str: "unsupported key type: "
        // str: "3bfbe70f2accc087ace785c80a73eba446da7ebc2173ada6e2ad8620ad"
        // call: Key.getEncoded
        // call: PKCS8EncodedKeySpec.<init>
        // call: StringBuilder.append
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.toString
        // call: object.getClass
        // call: StringBuilder.<init>
        // call: Type.isAssignableFrom
        // call: DecryptString.decryptString
        // call: X509EncodedKeySpec.<init>
        // type: StringBuilder
        // type: InvalidKeySpecException
        // type: X509EncodedKeySpec
        // type: PKCS8EncodedKeySpec
        return default!;
    }

    public Key EngineTranslateKey(Key P0)
    {
        // str: "unsupported key type"
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return default!;
    }

    public PrivateKey GeneratePrivate(p811299f8 P0)
    {
        // call: pe11c47f8.<init>
        // type: pe11c47f8
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: p46415c23.<init>
        // type: p46415c23
        return default!;
    }

}
