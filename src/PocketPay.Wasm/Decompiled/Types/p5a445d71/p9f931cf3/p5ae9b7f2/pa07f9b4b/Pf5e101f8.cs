namespace WillowMaze.Wasm.Decompiled;

public class Pf5e101f8 : P42a46bbe
{
    private static System.Numerics.BigInteger F529e9e0b;
    private static System.Numerics.BigInteger F6cd75690;
    private static System.Numerics.BigInteger F730a33c8;
    private static System.Numerics.BigInteger Fa36378d1;
    private static System.Numerics.BigInteger Fbc21e648;
    private bool F267330b8;
    private p073e3330 F2df6d6a6;
    private p073e3330 F3c6e0b8a;
    private Vector[] F43bbd7da;
    private bool F7cde744a;
    private bool F8bb21454;
    private bool F9301aa9b;
    private bool Fad42f669;
    private bool Fb6bd8cb1;
    private Vector[] Fbd95200a;
    private Vector[] Fcf5ee5cc;
    private Vector[] Ff0083b4e;

    private static System.Numerics.BigInteger M004a6054(Vector P0, Vector P1)
    {
        // call: System.Numerics.BigInteger.modInverse
        // call: Vector.size
        // call: System.Numerics.BigInteger.mod
        // call: System.Numerics.BigInteger.divide
        // call: System.Numerics.BigInteger.multiply
        // call: Vector.elementAt
        // call: System.Numerics.BigInteger.add
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fbc21e648
        return default!;
    }

    public byte[] AddCryptedBlocks(byte[] P0, byte[] P1)
    {
        // str: "c(m1)*c(m2)%n = c(m1+m2)%n: "
        // str: "c(m2) as BigInteger:....... "
        // str: "BlockLength too large for simple addition.\n"
        // str: "c(m1) as BigInteger:....... "
        // call: System.Numerics.BigInteger.mod
        // call: pff43b8de.ma552c747
        // call: System.Numerics.BigInteger.multiply
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: TextWriter.println
        // call: p21c8c989.<init>
        // call: pf5e101f8.getOutputBlockSize
        // call: pf5e101f8.getInputBlockSize
        // call: StringBuilder.<init>
        // call: p073e3330.getModulus
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.Numerics.BigInteger.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f3c6e0b8a
        // field: java.lang.System.out
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fad42f669
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f9301aa9b
        // type: StringBuilder
        // type: p21c8c989
        // type: System.Numerics.BigInteger
        return default!;
    }

    public byte[] Encrypt(System.Numerics.BigInteger P0)
    {
        // str: "Encrypted value is:  "
        // call: System.Numerics.BigInteger.modPow
        // call: p073e3330.getModulus
        // call: System.Numerics.BigInteger.toByteArray
        // call: pff43b8de.ma552c747
        // call: StringBuilder.append
        // call: p073e3330.getG
        // call: TextWriter.println
        // call: System.Numerics.BigInteger.<init>
        // call: System.arraycopy
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fad42f669
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f3c6e0b8a
        // field: java.lang.System.out
        // type: System.Numerics.BigInteger
        // type: StringBuilder
        return default!;
    }

    public int GetInputBlockSize()
    {
        // call: p073e3330.getLowerSigmaBound
        // call: p073e3330.getModulus
        // call: System.Numerics.BigInteger.toByteArray
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f9301aa9b
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: p073e3330.getModulus
        // call: System.Numerics.BigInteger.toByteArray
        // call: p073e3330.getLowerSigmaBound
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f3c6e0b8a
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "Constructing lookup ArrayList for "
        // str: "Constructing lookup Array"
        // call: System.Numerics.BigInteger.add
        // call: StringBuilder.append
        // call: Vector.size
        // call: p0d2b7b40.getSmallPrimes
        // call: Vector.addElement
        // call: TextWriter.println
        // call: p0d2b7b40.getPhi_n
        // call: p0d2b7b40.getG
        // call: Vector.elementAt
        // call: System.Numerics.BigInteger.modPow
        // call: p0d2b7b40.getModulus
        // call: Vector.<init>
        // call: p4715f007.getParameters
        // call: System.Numerics.BigInteger.divide
        // call: System.Numerics.BigInteger.intValue
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fbd95200a
        // field: java.lang.System.out
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fad42f669
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f529e9e0b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fbc21e648
        // type: Vector
        // type: StringBuilder
    }

    public byte[] ProcessBlock(byte[] P0, int P1, int P2)
    {
        // str: "BlockLength does not match modulus for Naccache-Stern cipher.\n"
        // str: "NaccacheStern engine not initialised"
        // str: "Actual prime is "
        // str: "Error in lookup Array for "
        // str: "Decrypted value is "
        // str: "Lookup failed"
        // str: " but found ArrayList of length "
        // str: "input too large for Naccache-Stern cipher.\n"
        // str: ", lookup table has size "
        // str: "input as BigInteger: "
        // str: " with size "
        // str: ": Size mismatch. Expected ArrayList with length "
        // str: " is: "
        // str: "Prime is "
        // str: "LookupList for "
        // call: p21c8c989.<init>
        // call: Vector.elementAt
        // call: pf5e101f8.encrypt
        // call: TextWriter.println
        // call: Vector.addElement
        // call: StringBuilder.append
        // call: Vector.size
        // call: StringBuilder.<init>
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.Numerics.BigInteger.divide
        // call: System.arraycopy
        // call: StringBuilder.toString
        // call: System.Numerics.BigInteger.modPow
        // call: Vector.<init>
        // call: System.Numerics.BigInteger.intValue
        // call: p0d2b7b40.getPhi_n
        // call: pf5e101f8.m004a6054
        // call: Vector.indexOf
        // call: p0d2b7b40.getSmallPrimes
        // call: p0d2b7b40.getModulus
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fbd95200a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f3c6e0b8a
        // field: java.lang.System.out
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fad42f669
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.f9301aa9b
        // type: IllegalStateException
        // type: p96068848
        // type: StringBuilder
        // type: p21c8c989
        // type: System.Numerics.BigInteger
        // type: Vector
        return default!;
    }

    public byte[] ProcessData(byte[] P0)
    {
        // str: "data size is less then input block size, processing directly"
        // str: "Data has length:.... "
        // str: " bytes"
        // str: "new datapos is "
        // str: "cipher returned null"
        // str: "returning "
        // str: "Output blocksize is: "
        // str: "Input blocksize is:  "
        // call: System.arraycopy
        // call: StringBuilder.append
        // call: p21c8c989.<init>
        // call: pf5e101f8.processBlock
        // call: TextWriter.println
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pf5e101f8.getInputBlockSize
        // call: pf5e101f8.getOutputBlockSize
        // field: java.lang.System.out
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fad42f669
        // type: StringBuilder
        // type: p21c8c989
        return default!;
    }

    public void SetDebug(bool P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf5e101f8.fad42f669
    }

}
