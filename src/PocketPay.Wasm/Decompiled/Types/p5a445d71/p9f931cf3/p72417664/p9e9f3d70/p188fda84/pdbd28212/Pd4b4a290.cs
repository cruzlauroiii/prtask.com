namespace WillowMaze.Wasm.Decompiled;

public class Pd4b4a290 : P20b9ccca
{
    private static long F6889ae85;
    private static long F81345e29;
    private static long Fc6e1e520;
    private static long Ff9a4dd06;
    private pcfffbc4a F2ee6ebf8;
    private pcfffbc4a F622fe8b9;
    private pcfffbc4a F8789fc19;
    private pcfffbc4a Faf5726a7;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: pd4b4a290.getEncoded
        // call: ObjectOutputStream.defaultWriteObject
        // call: ObjectOutputStream.writeObject
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.defaultReadObject
        // call: pd4b4a290.mc82e2de0
        // call: ObjectInputStream.readObject
        // call: p3cdccfc9.m8bab0102
    }

    private void Mc82e2de0(p3cdccfc9 P0)
    {
        // call: p25641b50.<init>
        // call: p234a7530.getAlgorithm
        // call: p3cdccfc9.getAlgorithm
        // call: p364bf33a.equals
        // call: p3cdccfc9.getPublicKeyData
        // call: p29d19857.getOctets
        // call: p2e18ebd5.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290.faf5726a7
        // field: p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e
        // type: p2e18ebd5
        // type: p25641b50
    }

    private pcfffbc4a EngineGetKeyParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290.faf5726a7
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pff43b8de.m2a3f81d2
        // call: PublicKey.getEncoded
        // call: pd4b4a290.getEncoded
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "47b5ebd6aed284e07b1b5cd43181ba4dbcc8083f4a2233beed3f198c8080d007"
        // str: "50d75154b437b049a0534d639001558425d6ded407923c5835de655fe40818c08cda"
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290.faf5726a7
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: System.arraycopy
        // call: p25641b50.encode
        // call: p2e18ebd5.encode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f407525d6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4093fa8.f072fcee7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290.faf5726a7
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public System.Numerics.BigInteger GetU()
    {
        // call: pff43b8de.m266521a1
        // call: System.Numerics.BigInteger.<init>
        // call: pd4b4a290.getUEncoding
        // type: System.Numerics.BigInteger
        return default!;
    }

    public byte[] GetUEncoding()
    {
        // call: p2e18ebd5.getEncoded
        // call: p25641b50.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290.faf5726a7
        return default!;
    }

    public int HashCode()
    {
        // call: pd4b4a290.getEncoded
        // call: pff43b8de.m550d1cc0
        return 0;
    }

    public string ToString()
    {
        // str: "Public Key"
        // call: pd4b4a290.getAlgorithm
        // call: pa470a233.mbdb612f8
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290.faf5726a7
        return string.Empty;
    }

}
