namespace WillowMaze.Wasm.Decompiled;

public class Pd4093fa8 : P4846363f
{
    private PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "open SSH public key is not RSA private key"
        // str: "unknown KeySpec type: "
        // str: "unable to process key spec: "
        // call: StringBuilder.append
        // call: Exception.toString
        // call: Type.getName
        // call: p2baebdc5.<init>
        // call: StringBuilder.<init>
        // call: p44536675.<init>
        // call: StringBuilder.toString
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p811299f8.m8bab0102
        // call: pd4093fa8.generatePrivate
        // call: p6be59720.<init>
        // call: InvalidKeySpecException.<init>
        // call: p970a24b1.m8bab0102
        // call: object.getClass
        // call: p56177f0b.getEncoded
        // call: pc8fff9db.m72ace772
        // type: StringBuilder
        // type: p2baebdc5
        // type: p6be59720
        // type: InvalidKeySpecException
        // type: p44536675
        return default!;
    }

    private PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "Open SSH public key is not RSA public key"
        // call: p4846363f.engineGeneratePublic
        // call: pcc11822a.m5355d3b5
        // call: p3d891371.<init>
        // call: p0a9c4e5e.getEncoded
        // call: InvalidKeySpecException.<init>
        // type: p3d891371
        // type: InvalidKeySpecException
        return default!;
    }

    private KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "unable to produce encoding: "
        // call: RSAPrivateCrtKey.getPrimeExponentP
        // call: RSAPublicKey.getModulus
        // call: StringBuilder.append
        // call: Type.isAssignableFrom
        // call: RSAPrivateCrtKey.getPrimeExponentQ
        // call: IOException.getMessage
        // call: StringBuilder.toString
        // call: RSAPrivateCrtKey.getPrivateExponent
        // call: RSAPrivateCrtKey.getCrtCoefficient
        // call: StringBuilder.<init>
        // call: RSAPrivateKey.getModulus
        // call: RSAPrivateCrtKey.getPrimeQ
        // call: RSAPrivateCrtKey.getModulus
        // call: IllegalArgumentException.<init>
        // call: RSAPublicKeySpec.<init>
        // call: RSAPrivateKeySpec.<init>
        // call: RSAPublicKey.getPublicExponent
        // call: p753eae39.<init>
        // call: pcc11822a.m092fb0ff
        // call: p0a9c4e5e.<init>
        // type: KeySpec
        // type: RSAPublicKeySpec
        // type: StringBuilder
        // type: RSAPrivateCrtKeySpec
        // type: p0a9c4e5e
        // type: p753eae39
        // type: IllegalArgumentException
        // type: RSAPrivateKeySpec
        // type: p56177f0b
        // type: p859968b9
        return default!;
    }

    private Key EngineTranslateKey(Key P0)
    {
        // str: "key type unknown"
        // call: p3d891371.<init>
        // call: p44536675.<init>
        // call: p2baebdc5.<init>
        // call: InvalidKeyException.<init>
        // type: p44536675
        // type: InvalidKeyException
        // type: p2baebdc5
        // type: p3d891371
        return default!;
    }

    public PrivateKey GeneratePrivate(p811299f8 P0)
    {
        // str: "algorithm identifier "
        // str: " in key not recognised"
        // call: StringBuilder.toString
        // call: p811299f8.parsePrivateKey
        // call: System.Numerics.BigInteger.intValue
        // call: p234a7530.getAlgorithm
        // call: p970a24b1.getCoefficient
        // call: IOException.<init>
        // call: pf3488fc4.mb393402a
        // call: StringBuilder.<init>
        // call: p44536675.<init>
        // call: StringBuilder.append
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p970a24b1.m8bab0102
        // call: p2baebdc5.<init>
        // type: p2baebdc5
        // type: p44536675
        // type: StringBuilder
        // type: IOException
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // str: "algorithm identifier "
        // str: " in key not recognised"
        // call: p3d891371.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: pf3488fc4.mb393402a
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.toString
        // call: p3cdccfc9.getAlgorithm
        // type: IOException
        // type: p3d891371
        // type: StringBuilder
        return default!;
    }

}
