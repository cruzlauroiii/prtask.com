namespace WillowMaze.Wasm.Decompiled;

public class P977bfd24 : KeyFactorySpi
{
    private PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "no factory found for OID: "
        // str: "Unknown KeySpec type: "
        // call: object.getClass
        // call: Type.getName
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.append
        // call: Exception.toString
        // call: StringBuilder.toString
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p811299f8.m8bab0102
        // call: p63d19d11.me72b28f9
        // call: StringBuilder.<init>
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p234a7530.getAlgorithm
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    private PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "no factory found for OID: "
        // str: "Unknown KeySpec type: "
        // call: object.getClass
        // call: StringBuilder.toString
        // call: InvalidKeySpecException.<init>
        // call: Exception.toString
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p63d19d11.m1367c17c
        // call: StringBuilder.<init>
        // call: p3cdccfc9.getAlgorithm
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.append
        // call: Type.getName
        // type: InvalidKeySpecException
        // type: StringBuilder
        return default!;
    }

    private KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "2eba4162400bd70a5037099fb2878b63afbb742c8629ea80ebce94f0d2"
        // str: "PKCS#8"
        // str: "X.509"
        // str: "not implemented yet "
        // call: InvalidKeySpecException.<init>
        // call: string.equals
        // call: DecryptString.decryptString
        // call: StringBuilder.append
        // call: Key.getEncoded
        // call: Type.isAssignableFrom
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: Key.getFormat
        // call: PKCS8EncodedKeySpec.<init>
        // call: X509EncodedKeySpec.<init>
        // type: PKCS8EncodedKeySpec
        // type: X509EncodedKeySpec
        // type: StringBuilder
        // type: InvalidKeySpecException
        return default!;
    }

    private Key EngineTranslateKey(Key P0)
    {
        // str: "not implemented yet "
        // call: InvalidKeyException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: InvalidKeyException
        return default!;
    }

}
