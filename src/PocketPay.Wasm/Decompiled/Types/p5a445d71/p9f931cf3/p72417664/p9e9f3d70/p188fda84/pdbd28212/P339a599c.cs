namespace WillowMaze.Wasm.Decompiled;

public class P339a599c : P619e6fce
{
    private static long F06bbd3af;
    private static long Fa46c511b;
    private static long Fc6e1e520;
    private pcfffbc4a F05377aef;
    private readonly byte[] F101fcb52;
    private readonly bool F15aa8101;
    private pcfffbc4a F25ae97f1;
    private readonly bool F565c951a;
    private readonly bool F6fe0b66a;
    private readonly byte[] F736b9175;
    private readonly bool F992ff169;
    private pcfffbc4a Fa1ee506a;
    private pcfffbc4a Fa4c29e94;
    private readonly bool Fe4d2fd0d;

    private void M1ac5d76e(p811299f8 P0)
    {
        // call: p811299f8.parsePrivateKey
        // call: p62f08e75.<init>
        // call: p811299f8.getPrivateKey
        // call: p11b04310.m8bab0102
        // call: p364bf33a.equals
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p11b04310.getOctets
        // call: p11d92f7d.<init>
        // call: p234a7530.getAlgorithm
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.fa4c29e94
        // type: p11d92f7d
        // type: p62f08e75
    }

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: p339a599c.getEncoded
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.readObject
        // call: ObjectInputStream.defaultReadObject
        // call: p339a599c.m1ac5d76e
        // call: p811299f8.m8bab0102
    }

    private pcfffbc4a EngineGetKeyParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.fa4c29e94
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pff43b8de.m2a3f81d2
        // call: p339a599c.getEncoded
        // call: PrivateKey.getEncoded
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "2343c22220b9add2286f2b71f0d16b75769289d00dcd6cfa21e33ecc472431a5"
        // str: "98fca687e35986e1bcdbb05cd896b1112d881b4111cffe89ed394d0699b3ba848211"
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.fa4c29e94
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // str: "org.bouncycastle.pkcs8.v1_info_only"
        // call: ped34daf1.m8bab0102
        // call: pb3a2dfcc.m258e1870
        // call: p9fc2d28c.mf2b2f421
        // call: p811299f8.getEncoded
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p811299f8.parsePrivateKey
        // call: p811299f8.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.f736b9175
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.fa4c29e94
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.f565c951a
        // type: p811299f8
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public p20b9ccca GetPublicKey()
    {
        // call: pd4b4a290.<init>
        // call: p11d92f7d.generatePublicKey
        // call: p62f08e75.generatePublicKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.fa4c29e94
        // type: pd4b4a290
        return default!;
    }

    public int HashCode()
    {
        // call: p339a599c.getEncoded
        // call: pff43b8de.m550d1cc0
        return 0;
    }

    public string ToString()
    {
        // str: "Private Key"
        // call: pa470a233.mbdb612f8
        // call: p11d92f7d.generatePublicKey
        // call: p62f08e75.generatePublicKey
        // call: p339a599c.getAlgorithm
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c.fa4c29e94
        return string.Empty;
    }

}
