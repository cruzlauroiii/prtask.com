namespace WillowMaze.Wasm.Decompiled;

public class Pd4093fa8 : P4846363f, Pae2f7198
{
    private static byte[] F06a4422f;
    private static byte[] F072fcee7;
    private static byte F0fc9da54;
    private static byte F18a9833b;
    private static byte F1c6d18e7;
    private static byte[] F1fc5da24;
    private static byte F266b2da0;
    private static byte[] F276ca287;
    private static byte F29b0bb14;
    private static byte[] F2b700c1b;
    private static byte[] F3a177de8;
    private static byte[] F407525d6;
    private static byte F59cb89e2;
    private static byte[] F67b83d3f;
    private static byte F80ae3a46;
    private static byte F973531fd;
    private static byte[] Fa9be47f8;
    private static byte Fb7b9c563;
    private static byte Fb9df75d5;
    private static byte Fbba3cdf9;
    private static byte[] Fbe27180b;
    private static byte Fc43bba87;
    private static byte Fcbb242ba;
    private static byte[] Fce7ec95e;
    private static byte[] Fcf3ff823;
    private static byte[] Ff2b7c15b;
    private readonly bool F0b1abdc9;
    private readonly bool F3e1c25ca;
    private readonly int F5d0e62a5;
    private readonly int F64d70155;
    private string F6b09b9ce;
    private readonly int F76b324c7;
    private readonly bool Fe9785b7f;
    private string Fed469618;

    private PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "openssh private key not Ed25519 private key"
        // call: pc8fff9db.m72ace772
        // call: p7f2344f9.<init>
        // call: p56177f0b.getEncoded
        // call: IllegalStateException.<init>
        // call: p4846363f.engineGeneratePrivate
        // type: p7f2344f9
        // type: IllegalStateException
        return default!;
    }

    private PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "openssh public key not Ed25519 public key"
        // str: "attempt to reconstruct key failed: "
        // str: "factory not a specific type, cannot recognise raw encoding"
        // str: "4254b95ba86f00e3b1ec3ccda75999fff5e7aadc47eba1e24a9785346fc58d"
        // call: StringBuilder.<init>
        // call: p3cdccfc9.getPublicKeyData
        // call: p92e3c408.<init>
        // call: pd4b4a290.<init>
        // call: p25641b50.<init>
        // call: p3cdccfc9.m8bab0102
        // call: pe052399c.getEncoded
        // call: p070794c1.getEncoded
        // call: InvalidKeySpecException.<init>
        // call: IllegalStateException.<init>
        // call: p3cdccfc9.getAlgorithm
        // call: X509EncodedKeySpec.getEncoded
        // call: p4846363f.engineGeneratePublic
        // call: StringBuilder.append
        // call: object.getSystemService
        // call: pcc11822a.m5355d3b5
        // call: p0a9c4e5e.getEncoded
        // call: p2e18ebd5.<init>
        // call: IOException.getMessage
        // call: p3cdccfc9.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f407525d6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f5d0e62a5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f276ca287
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f072fcee7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fa9be47f8
        // type: pb29053ed
        // type: p92e3c408
        // type: p070794c1
        // type: IllegalStateException
        // type: p3cdccfc9
        // type: p234a7530
        // type: pd4b4a290
        // type: InvalidKeySpecException
        // type: StringBuilder
        // type: p25641b50
        return default!;
    }

    private KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "Invalid Ed25519 public key encoding"
        // call: Type.isAssignableFrom
        // call: Key.getEncoded
        // call: p80f8c729.m8bab0102
        // call: p80f8c729.getObjectAt
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: p301c7ed4.m89e75c46
        // call: pe1b9a0e1.<init>
        // call: pc8fff9db.mf78d1be7
        // call: p56177f0b.<init>
        // call: p4914bf6d.getPointEncoding
        // call: pff43b8de.m2a3f81d2
        // call: p070794c1.<init>
        // call: pcc11822a.m092fb0ff
        // call: p0a9c4e5e.<init>
        // call: InvalidKeySpecException.<init>
        // call: IOException.getCause
        // call: pe052399c.<init>
        // call: p20b9ccca.getUEncoding
        // call: IOException.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f276ca287
        // type: pe052399c
        // type: p56177f0b
        // type: pe1b9a0e1
        // type: p0a9c4e5e
        // type: p070794c1
        // type: InvalidKeySpecException
        return default!;
    }

    private Key EngineTranslateKey(Key P0)
    {
        // str: "key type unknown"
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return default!;
    }

    public PrivateKey GeneratePrivate(p811299f8 P0)
    {
        // str: " in key not recognized"
        // str: "algorithm identifier "
        // call: p7f2344f9.<init>
        // call: StringBuilder.toString
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p339a599c.<init>
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f5d0e62a5
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fe9785b7f
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fb33b8d76
        // type: p339a599c
        // type: IOException
        // type: StringBuilder
        // type: p7f2344f9
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // str: " in key not recognized"
        // str: "algorithm identifier "
        // call: StringBuilder.append
        // call: pd4b4a290.<init>
        // call: p364bf33a.equals
        // call: p234a7530.getAlgorithm
        // call: IOException.<init>
        // call: p92e3c408.<init>
        // call: p3cdccfc9.getAlgorithm
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fe9785b7f
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f5d0e62a5
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fb33b8d76
        // type: pd4b4a290
        // type: IOException
        // type: p92e3c408
        // type: StringBuilder
        return default!;
    }

}
