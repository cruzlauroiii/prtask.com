namespace WillowMaze.Wasm.Decompiled;

public class P3a869abe : DHPublicKey
{
    private static long F691d73e0;
    private static long Fc6e1e520;
    private p3cdccfc9 F088ff2be;
    private DHParameterSpec F1cbd3182;
    private System.Numerics.BigInteger F1fc4f20d;
    private System.Numerics.BigInteger F3da4f63a;
    private System.Numerics.BigInteger F41529076;
    private System.Numerics.BigInteger F45b01c74;
    private DHParameterSpec F5aecd571;
    private System.Numerics.BigInteger Fc62e98bd;
    private p3cdccfc9 Fcaf9b6b9;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: DHParameterSpec.getP
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.writeInt
        // call: DHParameterSpec.getG
        // call: p3a869abe.getY
        // call: DHParameterSpec.getL
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.f5aecd571
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: DHParameterSpec.<init>
        // call: ObjectInputStream.readObject
        // call: ObjectInputStream.readInt
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.f5aecd571
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.f41529076
        // type: DHParameterSpec
    }

    private bool Md065a21d(p80f8c729 P0)
    {
        // call: System.Numerics.BigInteger.valueOf
        // call: System.Numerics.BigInteger.compareTo
        // call: pf391b73d.m8bab0102
        // call: p80f8c729.size
        // call: pf391b73d.getValue
        // call: p80f8c729.getObjectAt
        // call: System.Numerics.BigInteger.bitLength
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "DH"
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: DHParameterSpec.getL
        // call: DHParameterSpec.getP
        // call: pf391b73d.<init>
        // call: pef342a14.<init>
        // call: p234a7530.<init>
        // call: p58ac1d27.mfef91d48
        // call: DHParameterSpec.getG
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.f5aecd571
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.f41529076
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.fcaf9b6b9
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da
        // type: pf391b73d
        // type: pef342a14
        // type: p234a7530
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public DHParameterSpec GetParams()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.f5aecd571
        return default!;
    }

    public System.Numerics.BigInteger GetY()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p3a869abe.f41529076
        return default!;
    }

}
