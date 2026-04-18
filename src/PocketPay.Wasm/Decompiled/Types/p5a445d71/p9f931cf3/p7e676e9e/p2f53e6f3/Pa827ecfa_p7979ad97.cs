namespace WillowMaze.Wasm.Decompiled;

public abstract class Pa827ecfa_p7979ad97 : Pa827ecfa
{
    private System.Numerics.BigInteger[] F14a047fc;
    private System.Numerics.BigInteger[] F3300ca07;
    private System.Numerics.BigInteger[] Fac5585d9;
    private System.Numerics.BigInteger[] Fc7c217b0;
    private System.Numerics.BigInteger[] Fdc902f61;

    private static pe4575263 M14402bcc(int P0, int P1, int P2, int P3)
    {
        // str: "k3 must be > k2"
        // str: "k2 must be > k1"
        // str: "k3 must be 0 if k2 == 0"
        // str: "k1 must be > 0"
        // call: IllegalArgumentException.<init>
        // call: p41678799.m606a117f
        // type: IllegalArgumentException
        return default!;
    }

    private static System.Numerics.BigInteger M7f54ec10(System.Security.Cryptography.RandomNumberGenerator P0, int P1)
    {
        // call: System.Numerics.BigInteger.signum
        // call: p68e35a3f.m861a7ab4
        return default!;
    }

    public static System.Numerics.BigInteger Ma91c78e0(int P0, int[] P1, System.Numerics.BigInteger P2)
    {
        // call: p8bbd1253.<init>
        // call: p8bbd1253.toBigInteger
        // call: p8bbd1253.modInverse
        // type: p8bbd1253
        return default!;
    }

    public p53a5793f CreatePoint(System.Numerics.BigInteger P0, System.Numerics.BigInteger P1)
    {
        // call: pa827ecfa$p7979ad97.fromBigInteger
        // call: p5a196a0a.isZero
        // call: p5a196a0a.add
        // call: pa827ecfa$p7979ad97.createRawPoint
        // call: p5a196a0a.square
        // call: pa827ecfa$p7979ad97.getB
        // call: object.equals
        // call: IllegalArgumentException.<init>
        // call: p5a196a0a.divide
        // call: pa827ecfa$p7979ad97.getCoordinateSystem
        // type: IllegalArgumentException
        return default!;
    }

    private p53a5793f DecompressPoint(int P0, System.Numerics.BigInteger P1)
    {
        // str: "Invalid point compression"
        // call: pa827ecfa$p7979ad97.getCoordinateSystem
        // call: p5a196a0a.square
        // call: pa827ecfa$p7979ad97.createRawPoint
        // call: p5a196a0a.addOne
        // call: p5a196a0a.testBitZero
        // call: p5a196a0a.multiply
        // call: pa827ecfa$p7979ad97.solveQuadraticEquation
        // call: pa827ecfa$p7979ad97.getB
        // call: p5a196a0a.add
        // call: IllegalArgumentException.<init>
        // call: pa827ecfa$p7979ad97.getA
        // call: p5a196a0a.sqrt
        // call: p5a196a0a.isZero
        // call: p5a196a0a.invert
        // call: pa827ecfa$p7979ad97.fromBigInteger
        // type: IllegalArgumentException
        return default!;
    }

    private System.Numerics.BigInteger[] GetSi()
    {
        // call: p485c63a4.m8a5de957
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97.fac5585d9
        return default!;
    }

    public bool IsKoblitz()
    {
        // call: p5a196a0a.isZero
        // call: p5a196a0a.isOne
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97.f0cc175b9
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97.ff89ed0d1
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97.f92eb5ffe
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97.f70a17ffa
        return false;
    }

    public bool IsValidFieldElement(System.Numerics.BigInteger P0)
    {
        // call: pa827ecfa$p7979ad97.getFieldSize
        // call: System.Numerics.BigInteger.signum
        // call: System.Numerics.BigInteger.bitLength
        return false;
    }

    public p5a196a0a RandomFieldElement(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        // call: p68e35a3f.m861a7ab4
        // call: pa827ecfa$p7979ad97.getFieldSize
        // call: pa827ecfa$p7979ad97.fromBigInteger
        return default!;
    }

    public p5a196a0a RandomFieldElementMult(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        // call: p5a196a0a.multiply
        // call: pa827ecfa$p7979ad97.getFieldSize
        // call: pa827ecfa$p7979ad97.fromBigInteger
        // call: pa827ecfa$p7979ad97.m7f54ec10
        return default!;
    }

    private p5a196a0a SolveQuadraticEquation(p5a196a0a P0)
    {
        // call: p5a196a0a.add
        // call: p5a196a0a$p7979ad97.hasFastTrace
        // call: p5a196a0a.isZero
        // call: pa827ecfa$p7979ad97.fromBigInteger
        // call: p5a196a0a.square
        // call: p5a196a0a.multiply
        // call: System.Numerics.BigInteger.<init>
        // call: pa827ecfa$p7979ad97.getFieldSize
        // call: Random.<init>
        // call: p5a196a0a$p7979ad97.trace
        // call: p5a196a0a$p7979ad97.halfTrace
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b
        // type: Random
        // type: System.Numerics.BigInteger
        return default!;
    }

}
