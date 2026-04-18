namespace WillowMaze.Wasm.Decompiled;

public class P92e3c408 : P4914bf6d
{
    private static long F5c91dafa;
    private static long Fa71dfb44;
    private static long Fc6e1e520;
    private pcfffbc4a F1e865d6c;
    private pcfffbc4a F4f3d7940;
    private pcfffbc4a Fd4024d2f;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
        // call: p92e3c408.getEncoded
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: p92e3c408.mc82e2de0
        // call: ObjectInputStream.readObject
        // call: ObjectInputStream.defaultReadObject
        // call: p3cdccfc9.m8bab0102
    }

    private void Mc82e2de0(p3cdccfc9 P0)
    {
        // call: p29d19857.getOctets
        // call: p364bf33a.equals
        // call: p070794c1.<init>
        // call: p3cdccfc9.getPublicKeyData
        // call: pb29053ed.<init>
        // call: p3cdccfc9.getAlgorithm
        // call: p234a7530.getAlgorithm
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408.fd4024d2f
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689
        // type: p070794c1
        // type: pb29053ed
    }

    private pcfffbc4a EngineGetKeyParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408.fd4024d2f
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: p92e3c408.getEncoded
        // call: PublicKey.getEncoded
        // call: pff43b8de.m2a3f81d2
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "f84d8709893c997817dba532597f0eabd1c232e0b8723887584b469f2bdc5071dd"
        // str: "0543b70d5c2b0d40434043aa838b6e1658a8cacbbd3b807ba46a0135d0bfdbcd7850eb"
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408.fd4024d2f
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: System.arraycopy
        // call: p070794c1.encode
        // call: pb29053ed.encode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408.fd4024d2f
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.fa9be47f8
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f276ca287
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public byte[] GetPointEncoding()
    {
        // call: pb29053ed.getEncoded
        // call: p070794c1.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408.fd4024d2f
        return default!;
    }

    public int HashCode()
    {
        // call: pff43b8de.m550d1cc0
        // call: p92e3c408.getEncoded
        return 0;
    }

    public string ToString()
    {
        // str: "Public Key"
        // call: pa470a233.mbdb612f8
        // call: p92e3c408.getAlgorithm
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408.fd4024d2f
        return string.Empty;
    }

}
