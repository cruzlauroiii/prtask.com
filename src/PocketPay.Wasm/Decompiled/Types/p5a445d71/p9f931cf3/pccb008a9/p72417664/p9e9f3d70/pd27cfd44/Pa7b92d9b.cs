namespace WillowMaze.Wasm.Decompiled;

public class Pa7b92d9b : KeyFactorySpi, Pae2f7198
{
    public PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "unsupported key specification: "
        // str: "2d317a553aeb37ed16a8c069cb3a863594c36e5f731337686e10d7ce1b"
        // call: InvalidKeySpecException.<init>
        // call: object.getClass
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Exception.toString
        // call: StringBuilder.append
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: pa7b92d9b.generatePrivate
        // call: DecryptString.decryptString
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "6af92e64472c59dc5ddf332c249c460bc0f3fd02da5ef46720707aad23"
        // str: "unknown key specification: "
        // call: StringBuilder.toString
        // call: InvalidKeySpecException.<init>
        // call: Exception.toString
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // call: StringBuilder.<init>
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: pa7b92d9b.generatePublic
        // type: StringBuilder
        // type: InvalidKeySpecException
        return default!;
    }

    public KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "unsupported key type: "
        // str: "unknown key specification: "
        // str: "8ae2f1f2ce6ef3939bf7197912d07237d7416ab89e3b64f63ff5d682f2"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Type.isAssignableFrom
        // call: X509EncodedKeySpec.<init>
        // call: InvalidKeySpecException.<init>
        // call: Key.getEncoded
        // call: PKCS8EncodedKeySpec.<init>
        // call: object.getClass
        // call: DecryptString.decryptString
        // type: StringBuilder
        // type: PKCS8EncodedKeySpec
        // type: X509EncodedKeySpec
        // type: InvalidKeySpecException
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
        // call: p241bd5c3.<init>
        // type: p241bd5c3
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: pb98d31c4.<init>
        // type: pb98d31c4
        return default!;
    }

}
