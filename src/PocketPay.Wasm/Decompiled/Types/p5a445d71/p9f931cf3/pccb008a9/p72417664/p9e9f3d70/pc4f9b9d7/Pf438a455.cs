namespace WillowMaze.Wasm.Decompiled;

public class Pf438a455 : KeyFactorySpi, Pae2f7198
{
    public PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "Unsupported key specification: "
        // str: "5183ae622ef2b7221e9c9cb893263569c4311a98e9f6d1df06c6fd5f08"
        // call: InvalidKeySpecException.<init>
        // call: Exception.toString
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: pf438a455.generatePrivate
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // call: object.getClass
        // type: StringBuilder
        // type: InvalidKeySpecException
        return default!;
    }

    public PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "4652de4c6cd9803e957417d65fc71b3581c0ecf497130a979e17cd3461"
        // str: "Unknown key specification: "
        // call: StringBuilder.toString
        // call: Exception.toString
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // call: InvalidKeySpecException.<init>
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: pf438a455.generatePublic
        // call: StringBuilder.<init>
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "Unsupported key type: "
        // str: "Unknown key specification: "
        // str: "41b3f25384ecf8f32da996c286d20399da33079bb8825afc477061a7a7"
        // call: StringBuilder.append
        // call: InvalidKeySpecException.<init>
        // call: object.getClass
        // call: StringBuilder.toString
        // call: X509EncodedKeySpec.<init>
        // call: DecryptString.decryptString
        // call: Key.getEncoded
        // call: StringBuilder.<init>
        // call: Type.isAssignableFrom
        // call: PKCS8EncodedKeySpec.<init>
        // type: X509EncodedKeySpec
        // type: StringBuilder
        // type: InvalidKeySpecException
        // type: PKCS8EncodedKeySpec
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
        // call: p0b6b9099.<init>
        // type: p0b6b9099
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: pdf3790fe.<init>
        // type: pdf3790fe
        return default!;
    }

}
