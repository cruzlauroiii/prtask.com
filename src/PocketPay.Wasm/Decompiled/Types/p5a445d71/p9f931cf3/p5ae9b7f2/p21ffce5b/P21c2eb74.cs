namespace WillowMaze.Wasm.Decompiled;

public class P21c2eb74 : P28d0f68a
{
    private readonly byte[] F11da661a;
    private readonly System.Numerics.BigInteger F2510c390;
    private readonly pa827ecfa F423b9df0;
    private readonly pa827ecfa F4efa264f;
    private readonly p53a5793f F5640bd78;
    private System.Numerics.BigInteger F627e2ce8;
    private readonly p53a5793f F6b59b75a;
    private readonly System.Numerics.BigInteger F7b8b965a;
    private readonly System.Numerics.BigInteger F7c7948f3;
    private readonly System.Numerics.BigInteger Fbbf2736a;
    private System.Numerics.BigInteger Fbf96db07;
    private readonly System.Numerics.BigInteger Fc35ffbb2;
    private readonly p53a5793f Fdfcf28d0;
    private readonly System.Numerics.BigInteger Fe3ce376c;
    private readonly p53a5793f Feab58e12;
    private readonly System.Numerics.BigInteger Ffa83985c;
    private readonly byte[] Ffe4c0f30;

    private static p53a5793f Mb4fe9ca0(pa827ecfa P0, p53a5793f P1)
    {
        // str: "Point not on curve"
        // str: "Point at infinity"
        // str: "Point cannot be null"
        // call: p53a5793f.normalize
        // call: p8ede7675.ma15c73e8
        // call: IllegalArgumentException.<init>
        // call: p53a5793f.isInfinity
        // call: NullPointerException.<init>
        // call: p53a5793f.isValid
        // type: IllegalArgumentException
        // type: NullPointerException
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pa827ecfa.equals
        // call: p53a5793f.equals
        // call: System.Numerics.BigInteger.equals
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.fdfcf28d0
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f7b8b965a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f4efa264f
        return false;
    }

    public pa827ecfa GetCurve()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f4efa264f
        return default!;
    }

    public p53a5793f GetG()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.fdfcf28d0
        return default!;
    }

    public System.Numerics.BigInteger GetH()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f2510c390
        return default!;
    }

    public System.Numerics.BigInteger GetHInv()
    {
        // call: p68e35a3f.me90945d8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f627e2ce8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f7b8b965a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f2510c390
        return default!;
    }

    public System.Numerics.BigInteger GetN()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f7b8b965a
        return default!;
    }

    public byte[] GetSeed()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.ffe4c0f30
        return default!;
    }

    public int HashCode()
    {
        // call: System.Numerics.BigInteger.hashCode
        // call: pa827ecfa.hashCode
        // call: p53a5793f.hashCode
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f7b8b965a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.f4efa264f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74.fdfcf28d0
        return 0;
    }

    public System.Numerics.BigInteger ValidatePrivateScalar(System.Numerics.BigInteger P0)
    {
        // str: "Scalar cannot be null"
        // str: "Scalar is not in the interval [1, n - 1]"
        // call: System.Numerics.BigInteger.compareTo
        // call: p21c2eb74.getN
        // call: NullPointerException.<init>
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648
        // type: IllegalArgumentException
        // type: NullPointerException
        return default!;
    }

    public p53a5793f ValidatePublicPoint(p53a5793f P0)
    {
        // call: p21c2eb74.getCurve
        // call: p21c2eb74.mb4fe9ca0
        return default!;
    }

}
