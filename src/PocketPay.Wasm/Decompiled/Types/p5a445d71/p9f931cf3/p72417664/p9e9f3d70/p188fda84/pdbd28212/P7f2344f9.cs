namespace WillowMaze.Wasm.Decompiled;

public class P7f2344f9 : Pfb18e579
{
    private static long F2f649878;
    private static long Fc6e1e520;
    private readonly bool F565c951a;
    private pcfffbc4a F6824620b;
    private readonly byte[] F6e735296;
    private readonly byte[] F736b9175;
    private pcfffbc4a F79a92f43;
    private pcfffbc4a F82a0d3a5;
    private readonly bool Fb9b7d78a;

    private void M1ac5d76e(p811299f8 P0)
    {
        // call: p11b04310.getOctets
        // call: p364bf33a.equals
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p811299f8.parsePrivateKey
        // call: p11b04310.m8bab0102
        // call: p234a7530.getAlgorithm
        // call: pf1c3b35e.<init>
        // call: pe1b9a0e1.<init>
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f79a92f43
        // type: pe1b9a0e1
        // type: pf1c3b35e
    }

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
        // call: p7f2344f9.getEncoded
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.defaultReadObject
        // call: p811299f8.m8bab0102
        // call: ObjectInputStream.readObject
        // call: p7f2344f9.m1ac5d76e
    }

    private pcfffbc4a EngineGetKeyParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f79a92f43
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: p7f2344f9.getEncoded
        // call: pff43b8de.m2a3f81d2
        // call: PrivateKey.getEncoded
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "a87a032f6be1ac6ea3d666decb1571da4b4657694928c00d995acf2d10a051fe48f3c0"
        // str: "8233b22e19abab83270786ec049ba6c76040dff9894e3675a553c1bb50b7363fc9"
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f79a92f43
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
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f736b9175
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f79a92f43
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f565c951a
        // type: p811299f8
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public p4914bf6d GetPublicKey()
    {
        // call: pe1b9a0e1.generatePublicKey
        // call: p92e3c408.<init>
        // call: pf1c3b35e.generatePublicKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f79a92f43
        // type: p92e3c408
        return default!;
    }

    public int HashCode()
    {
        // call: pff43b8de.m550d1cc0
        // call: p7f2344f9.getEncoded
        return 0;
    }

    public string ToString()
    {
        // str: "Private Key"
        // call: p7f2344f9.getAlgorithm
        // call: pa470a233.mbdb612f8
        // call: pe1b9a0e1.generatePublicKey
        // call: pf1c3b35e.generatePublicKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9.f79a92f43
        return string.Empty;
    }

}
