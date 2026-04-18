namespace WillowMaze.Wasm.Decompiled;

public class Pd2b91404 : Pd9fd0eb7, DHPublicKey
{
    private static long F4a2ee910;
    private static long F4a7db27f;
    private static long Fc6e1e520;
    private static long Fd9bf883d;
    private System.Numerics.BigInteger F0c42448d;
    private System.Numerics.BigInteger F41529076;
    private pdcabce2f F808ee163;
    private pdcabce2f Fa886e764;
    private System.Numerics.BigInteger Fb25de942;
    private pdcabce2f Fc0726c67;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: pdcabce2f.getP
        // call: pdcabce2f.getG
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404.f808ee163
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: pdcabce2f.<init>
        // call: ObjectInputStream.readObject
        // call: ObjectInputStream.defaultReadObject
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404.f808ee163
        // type: pdcabce2f
    }

    public bool Equals(object P0)
    {
        // call: DHPublicKey.getParams
        // call: System.Numerics.BigInteger.equals
        // call: DHParameterSpec.getP
        // call: pd2b91404.getParams
        // call: DHPublicKey.getY
        // call: DHParameterSpec.getL
        // call: DHParameterSpec.getG
        // call: pd2b91404.getY
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "ElGamal"
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // str: "9c8e054286202d9e76589f23746075e4a9fc15b7820f48ff0721cad85f482b"
        // call: pdcabce2f.getP
        // call: pdcabce2f.getG
        // call: p524aa06f.<init>
        // call: p234a7530.<init>
        // call: pf391b73d.<init>
        // call: p3cdccfc9.<init>
        // call: DecryptString.decryptString
        // call: p3cdccfc9.getEncoded
        // field: p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404.f808ee163
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404.f41529076
        // type: p3cdccfc9
        // type: p234a7530
        // type: p524aa06f
        // type: pf391b73d
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public pdcabce2f GetParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404.f808ee163
        return default!;
    }

    public DHParameterSpec GetParams()
    {
        // call: DHParameterSpec.<init>
        // call: pdcabce2f.getP
        // call: pdcabce2f.getG
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404.f808ee163
        // type: DHParameterSpec
        return default!;
    }

    public System.Numerics.BigInteger GetY()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pd2b91404.f41529076
        return default!;
    }

    public int HashCode()
    {
        // call: System.Numerics.BigInteger.hashCode
        // call: DHParameterSpec.getG
        // call: DHParameterSpec.getP
        // call: pd2b91404.getParams
        // call: DHParameterSpec.getL
        // call: pd2b91404.getY
        return 0;
    }

}
