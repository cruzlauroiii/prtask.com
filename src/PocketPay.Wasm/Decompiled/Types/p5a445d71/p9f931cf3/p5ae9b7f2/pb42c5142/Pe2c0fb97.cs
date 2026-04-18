namespace WillowMaze.Wasm.Decompiled;

public class Pe2c0fb97 : Pd1977c1b
{
    public static int F08e13d21;
    public static int F0c75ecf5;
    public static int F1675dd31;
    public static int F1abcaf73;
    public static int F1d4f97fe;
    public static int F1ec38ab9;
    public static int F44b0aef3;
    public static int F5798dd45;
    public static int F58796b96;
    public static int F6684ec4a;
    public static int F6c6edc60;
    public static int F72d913d3;
    public static int F761458fd;
    public static int F7b8847c4;
    public static int F80ded36c;
    public static int F9456fec8;
    public static int F99884844;
    public static int Fa35badec;
    public static int Fa853a1b9;
    public static int Fb147e1f5;
    public static int Fb67d11bf;
    public static int Fc39d1664;
    public static int Fc61b3229;
    public static int Fcde38591;
    public static int Fd0ddb845;
    public static int Fe9b2ae5f;
    public static int Ffee94a1f;
    private int F029acd73;
    private p42a46bbe F08406a6e;
    private byte[] F14511f2f;
    private p42a46bbe F3e0af782;
    private int F4f56d52c;
    private p753eae39 F62eeaabd;
    private p753eae39 F71ca5a55;
    private p42a46bbe F7b42a766;
    private p42a46bbe F7ef69c1d;
    private byte[] F85a56770;
    private int F93707f72;
    private int Fb4046016;
    private int Fb4e9568a;
    private pe5cfc515 Fc10f7796;
    private int Fd99d6f3a;
    private pe5cfc515 Fe146d3dc;
    private pe5cfc515 Fe2bd114d;
    private int Fe7cebd22;
    private int Fea60231c;
    private p42a46bbe Fec00458a;

    private void M31ec78aa(int P0)
    {
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.fc10f7796
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f14511f2f
    }

    private void M8f780856(byte[] P0)
    {
    }

    public byte[] GenerateSignature()
    {
        // call: pe2c0fb97.m31ec78aa
        // call: p68e35a3f.m0894479c
        // call: p42a46bbe.processBlock
        // call: System.Numerics.BigInteger.min
        // call: p753eae39.getModulus
        // call: pe2c0fb97.m8f780856
        // call: System.Numerics.BigInteger.subtract
        // call: p68e35a3f.mec6269b9
        // call: System.Numerics.BigInteger.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f93707f72
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f14511f2f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f62eeaabd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f08406a6e
        // type: System.Numerics.BigInteger
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: System.Numerics.BigInteger.bitLength
        // call: p753eae39.getModulus
        // call: pe2c0fb97.reset
        // call: p42a46bbe.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f62eeaabd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f14511f2f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f4f56d52c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f08406a6e
    }

    public void Reset()
    {
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.fc10f7796
    }

    public void Update(byte P0)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.fc10f7796
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pe5cfc515.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.fc10f7796
    }

    public bool VerifySignature(byte[] P0)
    {
        // call: System.Numerics.BigInteger.intValue
        // call: pe2c0fb97.m8f780856
        // call: p68e35a3f.mec6269b9
        // call: p753eae39.getModulus
        // call: pff43b8de.m66e765de
        // call: pe2c0fb97.m31ec78aa
        // call: System.Numerics.BigInteger.<init>
        // call: p42a46bbe.processBlock
        // call: System.Numerics.BigInteger.subtract
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f93707f72
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f62eeaabd
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f14511f2f
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pe2c0fb97.f08406a6e
        // type: System.Numerics.BigInteger
        return false;
    }

}
