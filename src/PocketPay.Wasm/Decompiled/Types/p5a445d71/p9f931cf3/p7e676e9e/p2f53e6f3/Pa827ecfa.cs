namespace WillowMaze.Wasm.Decompiled;

public abstract class Pa827ecfa
{
    public static int F030454e5;
    public static int F11def183;
    public static int F1bff871d;
    public static int F28177f19;
    public static int F32950bbf;
    public static int F37154006;
    public static int F3cb4987d;
    public static int F410afdc3;
    public static int F4586f540;
    public static int F4705b768;
    public static int F526168dc;
    public static int F5297fd04;
    public static int F52f8030b;
    public static int F5e634101;
    public static int F645866e0;
    public static int F661a9150;
    public static int F6bcf181c;
    public static int F858b6df9;
    public static int F9f53d9ba;
    public static int Fa77dd6f9;
    public static int Fbc089044;
    public static int Fc0f39f82;
    public static int Fc3d691e5;
    public static int Fc60e46c9;
    public static int Fe9c17718;
    public static int Fee8aaba1;
    public static int Ff488500f;
    public static int Ff7fd4124;
    public static int Ff9f00eb1;
    private pe4575263 F03de3b2f;
    private pe4575263 F06e3d36f;
    private p5a196a0a F09e0163d;
    private p5a196a0a F0cc175b9;
    private p267d2b96 F2375dfa8;
    private pcb03a157 F2b9ec19f;
    private int F332de775;
    private System.Numerics.BigInteger F3a4b5a57;
    private p5a196a0a F432619e9;
    private System.Numerics.BigInteger F4d5021d8;
    private pcb03a157 F5304996d;
    private System.Numerics.BigInteger F60100147;
    private pcb03a157 F621c4948;
    private int F63c078ca;
    private System.Numerics.BigInteger F70a17ffa;
    private p5a196a0a F72c489ff;
    private p5a196a0a F92eb5ffe;
    private p5a196a0a F981869ef;
    private p5a196a0a F9bbc877f;
    private pcb03a157 Faeb7db3a;
    private pcb03a157 Fb0c98fb4;
    private int Fb3a0e30d;
    private pe4575263 Fb4896bc5;
    private p267d2b96 Fbc64a551;
    private pe4575263 Fc8923ff0;
    private p5a196a0a Fd5686c81;
    private pe4575263 Ff095f495;
    private System.Numerics.BigInteger Ff8552f35;
    private System.Numerics.BigInteger Ff89ed0d1;

    public static int[] M93027228()
    {
        return default!;
    }

    private void CheckPoint(p53a5793f P0)
    {
        // str: "'point' must be non-null and on this curve"
        // call: p53a5793f.getCurve
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    private void CheckPoints(p53a5793f[] P0)
    {
        // call: pa827ecfa.checkPoints
    }

    private void CheckPoints(p53a5793f[] P0, int P1, int P2)
    {
        // str: "'points' entries must be null or on this curve"
        // str: "invalid range specified for 'points'"
        // str: "'points' cannot be null"
        // call: IllegalArgumentException.<init>
        // call: p53a5793f.getCurve
        // type: IllegalArgumentException
    }

    private pa827ecfa CloneCurve()
    {
        return default!;
    }

    public pa827ecfa$pfa535ffb Configure()
    {
        // call: pa827ecfa$pfa535ffb.<init>
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f332de775
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.faeb7db3a
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f2375dfa8
        // type: pa827ecfa$pfa535ffb
        return default!;
    }

    public p2980d84f CreateCacheSafeLookupTable(p53a5793f[] P0, int P1, int P2)
    {
        // call: p53a5793f.getRawXCoord
        // call: System.arraycopy
        // call: pa827ecfa$1.<init>
        // call: System.Numerics.BigInteger.toByteArray
        // call: p53a5793f.getRawYCoord
        // call: p5a196a0a.toBigInteger
        // call: pa827ecfa.getFieldSize
        // type: pa827ecfa$1
        return default!;
    }

    private p267d2b96 CreateDefaultMultiplier()
    {
        // call: p590d0291.<init>
        // call: p67bbaf50.<init>
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.faeb7db3a
        // type: p67bbaf50
        // type: p590d0291
        return default!;
    }

    public p53a5793f CreatePoint(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // call: pa827ecfa.fromBigInteger
        // call: pa827ecfa.createRawPoint
        return default!;
    }

    private p53a5793f CreateRawPoint(p5a196a0a P0, p5a196a0a P1)
    {
        return default!;
    }

    private p53a5793f CreateRawPoint(p5a196a0a P0, p5a196a0a P1, p5a196a0a[] P2)
    {
        return default!;
    }

    public p53a5793f DecodePoint(byte[] P0)
    {
        // str: "Invalid point encoding 0x"
        // str: "Incorrect length for compressed encoding"
        // str: "Incorrect length for hybrid encoding"
        // str: "Incorrect length for infinity encoding"
        // str: "Inconsistent Y coordinate in hybrid encoding"
        // str: "Invalid infinity encoding"
        // str: "Invalid point"
        // str: "Incorrect length for uncompressed encoding"
        // call: IllegalArgumentException.<init>
        // call: p68e35a3f.m759f0662
        // call: pa827ecfa.validatePoint
        // call: int.toString
        // call: StringBuilder.toString
        // call: pa827ecfa.getInfinity
        // call: pa827ecfa.decompressPoint
        // call: StringBuilder.append
        // call: pa827ecfa.getFieldSize
        // call: p53a5793f.implIsValid
        // call: p53a5793f.isInfinity
        // call: StringBuilder.<init>
        // call: System.Numerics.BigInteger.testBit
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    private p53a5793f DecompressPoint(int P0, System.Numerics.BigInteger P1)
    {
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pa827ecfa.equals
        return false;
    }

    public bool Equals(pa827ecfa P0)
    {
        // call: pa827ecfa.getField
        // call: p5a196a0a.toBigInteger
        // call: System.Numerics.BigInteger.equals
        // call: pa827ecfa.getA
        // call: pa827ecfa.getB
        // call: object.equals
        return false;
    }

    public p5a196a0a FromBigInteger(System.Numerics.BigInteger P0)
    {
        return default!;
    }

    public p5a196a0a GetA()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f0cc175b9
        return default!;
    }

    public p5a196a0a GetB()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f92eb5ffe
        return default!;
    }

    public System.Numerics.BigInteger GetCofactor()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.ff89ed0d1
        return default!;
    }

    public int GetCoordinateSystem()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f332de775
        return 0;
    }

    public pcb03a157 GetEndomorphism()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.faeb7db3a
        return default!;
    }

    public pe4575263 GetField()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f06e3d36f
        return default!;
    }

    public int GetFieldSize()
    {
        return 0;
    }

    public p53a5793f GetInfinity()
    {
        return default!;
    }

    public p267d2b96 GetMultiplier()
    {
        // call: pa827ecfa.createDefaultMultiplier
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f2375dfa8
        return default!;
    }

    public System.Numerics.BigInteger GetOrder()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa.f70a17ffa
        return default!;
    }

    public pabc8833a GetPreCompInfo(p53a5793f P0, string P1)
    {
        // call: pa827ecfa.checkPoint
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ffd8d30b5
        return default!;
    }

    public int HashCode()
    {
        // call: pf74464bf.mff847a50
        // call: pa827ecfa.getB
        // call: System.Numerics.BigInteger.hashCode
        // call: pa827ecfa.getA
        // call: object.hashCode
        // call: p5a196a0a.toBigInteger
        // call: pa827ecfa.getField
        return 0;
    }

    public p53a5793f ImportPoint(p53a5793f P0)
    {
        // call: p5a196a0a.toBigInteger
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getCurve
        // call: p53a5793f.getYCoord
        // call: pa827ecfa.createPoint
        // call: p53a5793f.normalize
        // call: p53a5793f.getXCoord
        // call: pa827ecfa.getInfinity
        return default!;
    }

    public bool IsValidFieldElement(System.Numerics.BigInteger P0)
    {
        return false;
    }

    public void NormalizeAll(p53a5793f[] P0)
    {
        // call: pa827ecfa.normalizeAll
    }

    public void NormalizeAll(p53a5793f[] P0, int P1, int P2, p5a196a0a P3)
    {
        // str: "'iso' not valid for affine coordinates"
        // call: pa827ecfa.getCoordinateSystem
        // call: p53a5793f.getZCoord
        // call: pa827ecfa.checkPoints
        // call: IllegalArgumentException.<init>
        // call: p53a5793f.normalize
        // call: p8ede7675.m166474f7
        // call: p53a5793f.isNormalized
        // type: IllegalArgumentException
    }

    public pabc8833a Precompute(p53a5793f P0, string P1, p9d3c9ec4 P2)
    {
        // call: Hashtable.get
        // call: p9d3c9ec4.precompute
        // call: Hashtable.put
        // call: pa827ecfa.checkPoint
        // call: Hashtable.<init>
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ffd8d30b5
        // type: Hashtable
        return default!;
    }

    public p5a196a0a RandomFieldElement(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        return default!;
    }

    public p5a196a0a RandomFieldElementMult(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        return default!;
    }

    public bool SupportsCoordinateSystem(int P0)
    {
        return false;
    }

    public p53a5793f ValidatePoint(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // str: "Invalid point coordinates"
        // call: IllegalArgumentException.<init>
        // call: p53a5793f.isValid
        // call: pa827ecfa.createPoint
        // type: IllegalArgumentException
        return default!;
    }

}
