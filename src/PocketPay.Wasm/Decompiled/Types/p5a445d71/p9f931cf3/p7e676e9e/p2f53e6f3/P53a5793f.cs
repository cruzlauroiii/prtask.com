namespace WillowMaze.Wasm.Decompiled;

public abstract class P53a5793f
{
    private static p5a196a0a[] F33bc3ab6;
    private static p5a196a0a[] F5943f8b3;
    private static p5a196a0a[] F7eb71803;
    private static p5a196a0a[] Fa5f393c1;
    private static p5a196a0a[] Fe6959a2d;
    private p5a196a0a F020661c8;
    private p5a196a0a[] F12c01c34;
    private pa827ecfa F171f4fad;
    private p5a196a0a F321ea044;
    private Hashtable F3258e8a3;
    private p5a196a0a F41529076;
    private pa827ecfa F4d218d9e;
    private pa827ecfa F4efa264f;
    private p5a196a0a F5c58270e;
    private Hashtable F7dc9077a;
    private Hashtable F8e56c109;
    private p5a196a0a F9dd4e461;
    private pa827ecfa Fbc22d02e;
    private p5a196a0a Fc95eb9ae;
    private p5a196a0a Fd2a69f00;
    private p5a196a0a[] Ff6706d5d;
    private p5a196a0a Ff795d7a9;
    private Hashtable Ffd8d30b5;

    private static p5a196a0a[] M08465ce4(pa827ecfa P0)
    {
        // str: "unknown coordinate system"
        // call: IllegalArgumentException.<init>
        // call: pa827ecfa.getA
        // call: pa827ecfa.fromBigInteger
        // call: pa827ecfa.getCoordinateSystem
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f7eb71803
        // type: IllegalArgumentException
        return default!;
    }

    public p53a5793f Add(p53a5793f P0)
    {
        return default!;
    }

    private void CheckNormalized()
    {
        // str: "point not in normal form"
        // call: IllegalStateException.<init>
        // call: p53a5793f.isNormalized
        // type: IllegalStateException
    }

    private p53a5793f CreateScaledPoint(p5a196a0a P0, p5a196a0a P1)
    {
        // call: pa827ecfa.createRawPoint
        // call: p5a196a0a.multiply
        // call: p53a5793f.getRawXCoord
        // call: p53a5793f.getRawYCoord
        // call: p53a5793f.getCurve
        return default!;
    }

    private p53a5793f Detach()
    {
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: p53a5793f.equals
        return false;
    }

    public bool Equals(p53a5793f P0)
    {
        // call: pa827ecfa.equals
        // call: pa827ecfa.normalizeAll
        // call: p53a5793f.getYCoord
        // call: p53a5793f.normalize
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getCurve
        // call: p53a5793f.getXCoord
        // call: object.equals
        // call: pa827ecfa.importPoint
        return false;
    }

    public p5a196a0a GetAffineXCoord()
    {
        // call: p53a5793f.getXCoord
        // call: p53a5793f.checkNormalized
        return default!;
    }

    public p5a196a0a GetAffineYCoord()
    {
        // call: p53a5793f.checkNormalized
        // call: p53a5793f.getYCoord
        return default!;
    }

    private bool GetCompressionYTilde()
    {
        return false;
    }

    public pa827ecfa GetCurve()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f4efa264f
        return default!;
    }

    private int GetCurveCoordinateSystem()
    {
        // call: pa827ecfa.getCoordinateSystem
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f4efa264f
        return 0;
    }

    public p53a5793f GetDetachedPoint()
    {
        // call: p53a5793f.normalize
        // call: p53a5793f.detach
        return default!;
    }

    public byte[] GetEncoded(bool P0)
    {
        // call: p53a5793f.normalize
        // call: System.arraycopy
        // call: p5a196a0a.getEncoded
        // call: p53a5793f.getCompressionYTilde
        // call: p53a5793f.getXCoord
        // call: p53a5793f.getYCoord
        // call: p53a5793f.isInfinity
        return default!;
    }

    public p5a196a0a GetRawXCoord()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f9dd4e461
        return default!;
    }

    public p5a196a0a GetRawYCoord()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f41529076
        return default!;
    }

    private p5a196a0a[] GetRawZCoords()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ff6706d5d
        return default!;
    }

    public p5a196a0a GetXCoord()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f9dd4e461
        return default!;
    }

    public p5a196a0a GetYCoord()
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f41529076
        return default!;
    }

    public p5a196a0a GetZCoord(int P0)
    {
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ff6706d5d
        return default!;
    }

    public p5a196a0a[] GetZCoords()
    {
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f7eb71803
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ff6706d5d
        return default!;
    }

    public int HashCode()
    {
        // call: p53a5793f.getCurve
        // call: object.hashCode
        // call: p53a5793f.normalize
        // call: pa827ecfa.hashCode
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getYCoord
        // call: p53a5793f.getXCoord
        return 0;
    }

    private bool ImplIsValid(bool P0, bool P1)
    {
        // str: "41743c1ec5288640ff9498341e7fa62aed54cfef14cbb1a272dce0fd0d33ba309df2fa4089c6a2"
        // call: p53a5793f$1.<init>
        // call: DecryptString.decryptString
        // call: pa827ecfa.precompute
        // call: p7cf40e66.hasFailed
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getCurve
        // type: p53a5793f$1
        return false;
    }

    public bool IsInfinity()
    {
        // call: p5a196a0a.isZero
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f9dd4e461
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ff6706d5d
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f41529076
        return false;
    }

    public bool IsNormalized()
    {
        // call: p5a196a0a.isOne
        // call: p53a5793f.getCurveCoordinateSystem
        // call: p53a5793f.isInfinity
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ff6706d5d
        return false;
    }

    public bool IsValid()
    {
        // call: p53a5793f.implIsValid
        return false;
    }

    private bool IsValidPartial()
    {
        // call: p53a5793f.implIsValid
        return false;
    }

    public p53a5793f Multiply(System.Numerics.BigInteger P0)
    {
        // call: p53a5793f.getCurve
        // call: p267d2b96.multiply
        // call: pa827ecfa.getMultiplier
        return default!;
    }

    public p53a5793f Negate()
    {
        return default!;
    }

    public p53a5793f Normalize()
    {
        // str: "Detached points must be in affine coordinates"
        // call: p5a196a0a.multiply
        // call: p53a5793f.getCurveCoordinateSystem
        // call: p5a196a0a.invert
        // call: pa9682fb5.m07091bf1
        // call: pa827ecfa.randomFieldElementMult
        // call: p53a5793f.isInfinity
        // call: p5a196a0a.isOne
        // call: p53a5793f.normalize
        // call: IllegalStateException.<init>
        // call: p53a5793f.getZCoord
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f4efa264f
        // type: IllegalStateException
        return default!;
    }

    private p53a5793f Normalize(p5a196a0a P0)
    {
        // str: "not a projective coordinate system"
        // call: p53a5793f.getCurveCoordinateSystem
        // call: IllegalStateException.<init>
        // call: p5a196a0a.square
        // call: p53a5793f.createScaledPoint
        // call: p5a196a0a.multiply
        // type: IllegalStateException
        return default!;
    }

    private bool SatisfiesCurveEquation()
    {
        return false;
    }

    private bool SatisfiesOrder()
    {
        // call: pa827ecfa.getOrder
        // call: p53a5793f.isInfinity
        // call: System.Numerics.BigInteger.equals
        // call: pa827ecfa.getCofactor
        // call: p8ede7675.m00df1f7b
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.f4efa264f
        return false;
    }

    public p53a5793f ScaleX(p5a196a0a P0)
    {
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getRawZCoords
        // call: p53a5793f.getCurve
        // call: p5a196a0a.multiply
        // call: p53a5793f.getRawXCoord
        // call: pa827ecfa.createRawPoint
        // call: p53a5793f.getRawYCoord
        return default!;
    }

    public p53a5793f ScaleXNegateY(p5a196a0a P0)
    {
        // call: pa827ecfa.createRawPoint
        // call: p53a5793f.getRawXCoord
        // call: p53a5793f.getRawYCoord
        // call: p5a196a0a.negate
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getRawZCoords
        // call: p5a196a0a.multiply
        // call: p53a5793f.getCurve
        return default!;
    }

    public p53a5793f ScaleY(p5a196a0a P0)
    {
        // call: p53a5793f.getRawYCoord
        // call: p5a196a0a.multiply
        // call: p53a5793f.getRawXCoord
        // call: p53a5793f.getRawZCoords
        // call: p53a5793f.isInfinity
        // call: pa827ecfa.createRawPoint
        // call: p53a5793f.getCurve
        return default!;
    }

    public p53a5793f ScaleYNegateX(p5a196a0a P0)
    {
        // call: p53a5793f.getRawXCoord
        // call: p5a196a0a.multiply
        // call: p53a5793f.isInfinity
        // call: p53a5793f.getRawZCoords
        // call: p5a196a0a.negate
        // call: p53a5793f.getCurve
        // call: pa827ecfa.createRawPoint
        // call: p53a5793f.getRawYCoord
        return default!;
    }

    public p53a5793f Subtract(p53a5793f P0)
    {
        return default!;
    }

    public p53a5793f ThreeTimes()
    {
        // call: p53a5793f.twicePlus
        return default!;
    }

    public p53a5793f TimesPow2(int P0)
    {
        // str: "'e' cannot be negative"
        // call: p53a5793f.twice
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return default!;
    }

    public string ToString()
    {
        // str: "("
        // str: "INF"
        // call: StringBuilder.append
        // call: p53a5793f.getRawXCoord
        // call: p53a5793f.isInfinity
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p53a5793f.getRawYCoord
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f.ff6706d5d
        // type: StringBuilder
        return string.Empty;
    }

    public p53a5793f Twice()
    {
        return default!;
    }

    public p53a5793f TwicePlus(p53a5793f P0)
    {
        // call: p53a5793f.twice
        // call: p53a5793f.add
        return default!;
    }

}
