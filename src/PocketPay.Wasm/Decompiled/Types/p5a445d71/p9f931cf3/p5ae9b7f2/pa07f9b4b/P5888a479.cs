namespace WillowMaze.Wasm.Decompiled;

public class P5888a479 : Pd81e8b93
{
    private static short[] F16d00045;
    private static int F378475e7;
    private static short[] F87a202b6;
    private static int F8943bd76;
    private static int Fc75e2054;
    private static short[] Fe0b2cf52;
    private static int Fef15a63a;
    private bool F0a4bd994;
    private bool F126963e6;
    private int[] F19704f9f;
    private int[] F21f402f2;
    private int[] F36315785;
    private int[] F384a8571;
    private bool F78e3449f;
    private int[] F78f825aa;
    private int[] F896ed9e5;
    private int[] F8b95c95a;
    private int[] F8c44a613;
    private bool F92f5fcfb;
    private int[] F9858a334;
    private int[] Fac68abdc;
    private int[] Fb9387fbc;
    private int[] Fc2add694;
    private int[] Fdea6cf9c;
    private int[] Ffa54a34b;
    private int[] Ffa901fbd;

    private int M2510c390(int P0, int P1)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f36315785
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.fe0b2cf52
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f78f825aa
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f21f402f2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.fc2add694
        return 0;
    }

    private int Mb2f5ff47(int P0, int P1)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.fe0b2cf52
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f21f402f2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.fc2add694
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f36315785
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f78f825aa
        return 0;
    }

    public int DecryptBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p5888a479.m2510c390
        return 0;
    }

    public int EncryptBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: p5888a479.mb2f5ff47
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "SKIPJACK"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to SKIPJACK init - "
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: p94919be6.getKey
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: Type.getName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.fc2add694
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f21f402f2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f36315785
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f78f825aa
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f78e3449f
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "output buffer too short"
        // str: "input buffer too short"
        // str: "SKIPJACK engine not initialised"
        // call: IllegalStateException.<init>
        // call: p2500579c.<init>
        // call: p96068848.<init>
        // call: p5888a479.decryptBlock
        // call: p5888a479.encryptBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.fc2add694
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p5888a479.f78e3449f
        // type: p2500579c
        // type: p96068848
        // type: IllegalStateException
        return 0;
    }

    public void Reset()
    {
    }

}
