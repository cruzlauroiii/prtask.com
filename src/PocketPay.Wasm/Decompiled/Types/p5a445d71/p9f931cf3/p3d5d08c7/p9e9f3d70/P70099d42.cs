namespace WillowMaze.Wasm.Decompiled;

public class P70099d42 : Pd9fd0eb7, DHPublicKey
{
    private static long F4947beb8;
    private static long Fafa275c9;
    private static long Fc6e1e520;
    private static long Fc85d7ffb;
    private System.Numerics.BigInteger F33a96245;
    private System.Numerics.BigInteger F41529076;
    private pdcabce2f F5ec3918e;
    private System.Numerics.BigInteger F6eac1f3c;
    private pdcabce2f F7b655bf8;
    private pdcabce2f F808ee163;
    private pdcabce2f F8d3879b5;
    private pdcabce2f Fbb585b62;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: p70099d42.getY
        // call: ObjectOutputStream.writeObject
        // call: pdcabce2f.getG
        // call: pdcabce2f.getP
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f808ee163
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.readObject
        // call: pdcabce2f.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f41529076
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f808ee163
        // type: pdcabce2f
    }

    public string GetAlgorithm()
    {
        // str: "ElGamal"
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: p524aa06f.<init>
        // call: p234a7530.<init>
        // call: pf391b73d.<init>
        // call: pdcabce2f.getP
        // call: pdcabce2f.getG
        // call: p58ac1d27.mfef91d48
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f41529076
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f808ee163
        // field: p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17
        // type: p234a7530
        // type: pf391b73d
        // type: p524aa06f
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public pdcabce2f GetParameters()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f808ee163
        return default!;
    }

    public DHParameterSpec GetParams()
    {
        // call: pdcabce2f.getG
        // call: pdcabce2f.getP
        // call: DHParameterSpec.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f808ee163
        // type: DHParameterSpec
        return default!;
    }

    public System.Numerics.BigInteger GetY()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p70099d42.f41529076
        return default!;
    }

}
