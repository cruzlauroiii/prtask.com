namespace WillowMaze.Wasm.Decompiled;

public class P6c10573a : KeyFactorySpi, Pae2f7198
{
    public PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "84ba529e7338a17f22d428e5eddb10686e29fe0a5feb7d161ab3fbc835"
        // str: "Unsupported key specification: "
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.toString
        // call: object.getClass
        // call: DecryptString.decryptString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: p6c10573a.generatePrivate
        // call: Exception.toString
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "Unknown key specification: "
        // str: "eb89c9718f45f207318b9fc01a7e77bac8152c4ce2503da73b6368a983"
        // call: InvalidKeySpecException.<init>
        // call: Exception.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p6c10573a.generatePublic
        // call: StringBuilder.append
        // call: DecryptString.decryptString
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "Unsupported key type: "
        // str: "7722872f662cf4e86573518acb84742b6b9a5ead7c22fb2a049233f463"
        // str: "Unknown key specification: "
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: object.getClass
        // call: X509EncodedKeySpec.<init>
        // call: Key.getEncoded
        // call: PKCS8EncodedKeySpec.<init>
        // call: Type.isAssignableFrom
        // call: InvalidKeySpecException.<init>
        // call: DecryptString.decryptString
        // type: PKCS8EncodedKeySpec
        // type: InvalidKeySpecException
        // type: X509EncodedKeySpec
        // type: StringBuilder
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
        // call: p98e7d2a2.<init>
        // type: p98e7d2a2
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: p038797a3.<init>
        // type: p038797a3
        return default!;
    }

}
