namespace WillowMaze.Wasm.Decompiled;

public class P786b122d : KeyFactorySpi, Pae2f7198
{
    public PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "unsupported key specification: "
        // str: "8c9c8b63fe971b96671ec66c513c602c6e19764545c710ed58e9acd283"
        // call: StringBuilder.append
        // call: InvalidKeySpecException.<init>
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: p786b122d.generatePrivate
        // call: object.getClass
        // call: StringBuilder.<init>
        // call: Exception.toString
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    public PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "unknown key specification: "
        // str: "e3a3b6fd1905303a89f1d88569872738d0349e40a74a9f4a929faa347d"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p786b122d.generatePublic
        // call: Exception.toString
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // type: StringBuilder
        // type: InvalidKeySpecException
        return default!;
    }

    public KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "31df44e3f918a7d24ed7ed4a579140f03de98bc758e358b2c7ad681cb4"
        // str: "unsupported key type: "
        // str: "unknown key specification: "
        // call: Key.getEncoded
        // call: DecryptString.decryptString
        // call: StringBuilder.toString
        // call: object.getClass
        // call: InvalidKeySpecException.<init>
        // call: Type.isAssignableFrom
        // call: PKCS8EncodedKeySpec.<init>
        // call: X509EncodedKeySpec.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // type: X509EncodedKeySpec
        // type: PKCS8EncodedKeySpec
        // type: StringBuilder
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
        // call: peca3a970.<init>
        // type: peca3a970
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: pfc9dc6a3.<init>
        // type: pfc9dc6a3
        return default!;
    }

}
