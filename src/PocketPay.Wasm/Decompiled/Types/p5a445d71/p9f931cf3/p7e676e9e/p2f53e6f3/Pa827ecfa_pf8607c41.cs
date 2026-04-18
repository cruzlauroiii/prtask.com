namespace WillowMaze.Wasm.Decompiled;

public abstract class Pa827ecfa_pf8607c41 : Pa827ecfa
{
    private static System.Numerics.BigInteger M50f4b051(System.Security.Cryptography.RandomNumberGenerator P0, System.Numerics.BigInteger P1)
    {
        // call: p68e35a3f.m861a7ab4
        // call: System.Numerics.BigInteger.bitLength
        // call: System.Numerics.BigInteger.compareTo
        return default!;
    }

    private static System.Numerics.BigInteger M7f54ec10(System.Security.Cryptography.RandomNumberGenerator P0, System.Numerics.BigInteger P1)
    {
        // call: System.Numerics.BigInteger.signum
        // call: System.Numerics.BigInteger.compareTo
        // call: System.Numerics.BigInteger.bitLength
        // call: p68e35a3f.m861a7ab4
        return default!;
    }

    private p53a5793f DecompressPoint(int P0, System.Numerics.BigInteger P1)
    {
        // str: "Invalid point compression"
        // call: p5a196a0a.negate
        // call: IllegalArgumentException.<init>
        // call: p5a196a0a.testBitZero
        // call: p5a196a0a.square
        // call: p5a196a0a.multiply
        // call: pa827ecfa$pf8607c41.fromBigInteger
        // call: p5a196a0a.add
        // call: p5a196a0a.sqrt
        // call: pa827ecfa$pf8607c41.createRawPoint
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pf8607c41.f92eb5ffe
        // field: p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$pf8607c41.f0cc175b9
        // type: IllegalArgumentException
        return default!;
    }

    public bool IsValidFieldElement(System.Numerics.BigInteger P0)
    {
        // call: pe4575263.getCharacteristic
        // call: pa827ecfa$pf8607c41.getField
        // call: System.Numerics.BigInteger.signum
        // call: System.Numerics.BigInteger.compareTo
        return false;
    }

    public p5a196a0a RandomFieldElement(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        // call: pa827ecfa$pf8607c41.fromBigInteger
        // call: pe4575263.getCharacteristic
        // call: p5a196a0a.multiply
        // call: pa827ecfa$pf8607c41.m50f4b051
        // call: pa827ecfa$pf8607c41.getField
        return default!;
    }

    public p5a196a0a RandomFieldElementMult(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        // call: pe4575263.getCharacteristic
        // call: pa827ecfa$pf8607c41.m7f54ec10
        // call: pa827ecfa$pf8607c41.fromBigInteger
        // call: pa827ecfa$pf8607c41.getField
        // call: p5a196a0a.multiply
        return default!;
    }

}
