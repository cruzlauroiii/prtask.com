namespace WillowMaze.Wasm.Decompiled;

public class P83204de6 : KeyFactorySpi, Pae2f7198
{
    public PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "Unsupported key specification: "
        // str: "5a8b28daf762e59d2e23abd73db1b70cfce7aad03181d9747de8cf50d5"
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: InvalidKeySpecException.<init>
        // call: DecryptString.decryptString
        // call: StringBuilder.append
        // call: Exception.toString
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: p83204de6.generatePrivate
        // call: object.getClass
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "560574bf0fba28d0977a6fabc495d38291dbd28bbe96fbcb5931eb2ef3"
        // str: "Unknown key specification: "
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.append
        // call: Exception.toString
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p83204de6.generatePublic
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // type: StringBuilder
        // type: InvalidKeySpecException
        return default!;
    }

    public KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "Unsupported key type: "
        // str: "Unknown key specification: "
        // str: "aa4b76b94a079647d39a736116137091fb3041cdbb59cd4a064ef6de31"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: InvalidKeySpecException.<init>
        // call: PKCS8EncodedKeySpec.<init>
        // call: object.getClass
        // call: StringBuilder.toString
        // call: X509EncodedKeySpec.<init>
        // call: Key.getEncoded
        // call: DecryptString.decryptString
        // call: Type.isAssignableFrom
        // type: X509EncodedKeySpec
        // type: StringBuilder
        // type: PKCS8EncodedKeySpec
        // type: InvalidKeySpecException
        return default!;
    }

    public Key EngineTranslateKey(Key P0)
    {
        // str: "Unsupported key type"
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return default!;
    }

    public PrivateKey GeneratePrivate(p811299f8 P0)
    {
        // call: p2f864b5d.<init>
        // type: p2f864b5d
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: pa074df52.<init>
        // type: pa074df52
        return default!;
    }

}
