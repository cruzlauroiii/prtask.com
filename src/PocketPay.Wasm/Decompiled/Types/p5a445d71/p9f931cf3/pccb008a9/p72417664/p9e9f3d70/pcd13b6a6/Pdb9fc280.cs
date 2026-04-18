namespace WillowMaze.Wasm.Decompiled;

public class Pdb9fc280 : KeyFactorySpi, Pae2f7198
{
    public PrivateKey EngineGeneratePrivate(KeySpec P0)
    {
        // str: "4e24038d7c6b6425cfa454317c734a83fb9b216d3aadf788e994c61df3"
        // str: "Unsupported key specification: "
        // call: StringBuilder.append
        // call: PKCS8EncodedKeySpec.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p811299f8.m8bab0102
        // call: pdb9fc280.generatePrivate
        // call: Exception.toString
        // call: StringBuilder.<init>
        // call: InvalidKeySpecException.<init>
        // call: StringBuilder.toString
        // call: pd2f390ee.<init>
        // call: object.getClass
        // call: DecryptString.decryptString
        // type: InvalidKeySpecException
        // type: pd2f390ee
        // type: StringBuilder
        return default!;
    }

    public PublicKey EngineGeneratePublic(KeySpec P0)
    {
        // str: "Unknown key specification: "
        // str: "3add9af74906c9eca3fd25f848b5518d75a8c79b8f37373c538aafd016"
        // call: StringBuilder.append
        // call: p3ec0531f.<init>
        // call: InvalidKeySpecException.<init>
        // call: X509EncodedKeySpec.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: pdb9fc280.generatePublic
        // call: DecryptString.decryptString
        // call: Exception.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: p3ec0531f
        // type: InvalidKeySpecException
        return default!;
    }

    public KeySpec EngineGetKeySpec(Key P0, Type P1)
    {
        // str: "9275569ebc0a70c2bbb9d86cda1331871200ad47ecd9ecba50fb3b459e"
        // str: "Unknown key specification: "
        // str: "Unsupported key type: "
        // call: p3ec0531f.getCoeffSingular
        // call: InvalidKeySpecException.<init>
        // call: Type.isAssignableFrom
        // call: p3ec0531f.getDocLength
        // call: pd2f390ee.getB2
        // call: DecryptString.decryptString
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pd2f390ee.getVi
        // call: Key.getEncoded
        // call: p3ec0531f.getCoeffQuadratic
        // call: pb83ae16d.<init>
        // call: object.getClass
        // call: pd2f390ee.getInvA2
        // call: StringBuilder.append
        // call: pd2f390ee.getB1
        // call: p4c73b922.<init>
        // call: PKCS8EncodedKeySpec.<init>
        // call: pd2f390ee.getInvA1
        // call: pd2f390ee.getLayers
        // type: pb83ae16d
        // type: StringBuilder
        // type: X509EncodedKeySpec
        // type: p4c73b922
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
        // call: p2f98f454.getVi
        // call: p2f98f454.getInvA2
        // call: p2f98f454.getB2
        // call: p2f98f454.getLayers
        // call: p2f98f454.getB1
        // call: p811299f8.parsePrivateKey
        // call: p2f98f454.getInvA1
        // call: pd2f390ee.<init>
        // call: p2f98f454.m8bab0102
        // type: pd2f390ee
        return default!;
    }

    public PublicKey GeneratePublic(p3cdccfc9 P0)
    {
        // call: pf9e213f1.m8bab0102
        // call: pf9e213f1.getCoeffScalar
        // call: pf9e213f1.getCoeffSingular
        // call: p3ec0531f.<init>
        // call: pf9e213f1.getDocLength
        // call: p3cdccfc9.parsePublicKey
        // call: pf9e213f1.getCoeffQuadratic
        // type: p3ec0531f
        return default!;
    }

}
