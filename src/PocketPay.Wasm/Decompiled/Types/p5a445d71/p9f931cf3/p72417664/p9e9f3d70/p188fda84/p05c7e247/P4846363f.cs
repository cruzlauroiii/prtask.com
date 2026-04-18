namespace WillowMaze.Wasm.Decompiled;

public abstract class P4846363f : KeyFactorySpi, Pae2f7198
{
    private PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "key spec not recognized"
        // str: "encoded key spec not recognized: "
        // call: StringBuilder.toString
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.append
        // call: Exception.getMessage
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p811299f8.m8bab0102
        // call: p4846363f.generatePrivate
        // call: StringBuilder.<init>
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    private PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "encoded key spec not recognized: "
        // str: "key spec not recognized"
        // call: StringBuilder.toString
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.<init>
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p4846363f.generatePublic
        // call: StringBuilder.append
        // call: Exception.getMessage
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    private KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "X.509"
        // str: "not implemented yet "
        // str: "25637144164fc0405044a3ead0a6989e0385512665d7e0e850bf9f8615"
        // str: "PKCS#8"
        // call: Key.getEncoded
        // call: string.equals
        // call: StringBuilder.append
        // call: X509EncodedKeySpec.<init>
        // call: PKCS8EncodedKeySpec.<init>
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.toString
        // call: Key.getFormat
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // call: Type.isAssignableFrom
        // type: PKCS8EncodedKeySpec
        // type: X509EncodedKeySpec
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

}
