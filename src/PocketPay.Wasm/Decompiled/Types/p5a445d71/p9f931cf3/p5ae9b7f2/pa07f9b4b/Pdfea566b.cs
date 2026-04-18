namespace WillowMaze.Wasm.Decompiled;

public class Pdfea566b
{
    private p753eae39 F3c6e0b8a;
    private p753eae39 F43d3963e;
    private bool F9301aa9b;
    private p753eae39 F93d50bdc;
    private bool Fc5342113;
    private p753eae39 Fe827144c;

    public System.Numerics.BigInteger ConvertInput(byte[] P0, int P1, int P2)
    {
        // str: "input too large for RSA cipher."
        // call: System.arraycopy
        // call: p753eae39.getModulus
        // call: pdfea566b.getInputBlockSize
        // call: p96068848.<init>
        // call: System.Numerics.BigInteger.compareTo
        // call: System.Numerics.BigInteger.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f3c6e0b8a
        // type: p96068848
        // type: System.Numerics.BigInteger
        return default!;
    }

    public byte[] ConvertOutput(System.Numerics.BigInteger P0)
    {
        // call: System.arraycopy
        // call: pff43b8de.ma552c747
        // call: System.Numerics.BigInteger.toByteArray
        // call: pdfea566b.getOutputBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f9301aa9b
        return default!;
    }

    public int GetInputBlockSize()
    {
        // call: p753eae39.getModulus
        // call: System.Numerics.BigInteger.bitLength
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f3c6e0b8a
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: p753eae39.getModulus
        // call: System.Numerics.BigInteger.bitLength
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f3c6e0b8a
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f3c6e0b8a
    }

    public System.Numerics.BigInteger ProcessBlock(System.Numerics.BigInteger P0)
    {
        // call: p859968b9.getQ
        // call: System.Numerics.BigInteger.modPow
        // call: p859968b9.getQInv
        // call: p859968b9.getDQ
        // call: System.Numerics.BigInteger.subtract
        // call: p753eae39.getExponent
        // call: System.Numerics.BigInteger.multiply
        // call: System.Numerics.BigInteger.remainder
        // call: System.Numerics.BigInteger.add
        // call: p753eae39.getModulus
        // call: p859968b9.getDP
        // call: p859968b9.getP
        // call: System.Numerics.BigInteger.mod
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pdfea566b.f3c6e0b8a
        return default!;
    }

}
