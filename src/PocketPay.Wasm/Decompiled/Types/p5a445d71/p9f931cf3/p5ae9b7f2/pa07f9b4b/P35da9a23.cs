namespace WillowMaze.Wasm.Decompiled;

public class P35da9a23 : Pbd6909f5
{
    private static byte[] F4580c274;
    private static int F4a29b7cb;
    private static int F699ac2c8;
    private static int[] F6f2c6946;
    private static int F8cf397e2;
    private static byte[] F9b87c6d9;
    public static int Fa2d0f526;
    private static int[] Fa3fd9eb7;
    private static int Fb31d27aa;
    public static int Fc94ba713;
    private static byte[] Fe3b6fec1;
    public static int Fe486ab0e;
    private static byte[] Fe7735369;
    private static byte[] Fed64c16e;
    private static byte[] Ffc68b326;
    private int[] F05040e9d;
    private int[] F0dcc120c;
    private int[] F0e170b8c;
    private int F2d9d9879;
    private int F30bdc65f;
    private int[] F35062352;
    private int F3cf53cd9;
    private int F41b76d7b;
    private byte[] F4be0457b;
    private int F5266f0a9;
    private int F5efe4864;
    private int F6a992d55;
    private int F72388d97;
    private byte[] F73adcb9b;
    private int F7420fd7d;
    private bool F82acbc46;
    private byte[] F85c250af;
    private int F87a46249;
    private bool F88a5a1f7;
    private int F8d7e7aa4;
    private int[] F9457b3e2;
    private int F9520b4db;
    private int[] F9dd4e461;
    private int Fa17e20dc;
    private int Fa5ea047c;
    private bool Fa6e23d27;
    private int Fab4ecba9;
    private int Fba492423;
    private byte[] Fbe26106b;
    private int Fc1ac715e;
    private bool Fdb1687e1;
    private byte[] Fdf02ce23;
    private int Fdfcdb2c8;
    private int Fe9ba68ad;
    private int Ff9b8e5a5;

    private void Ma3963a4c()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fa5ea047c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f72388d97
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fab4ecba9
    }

    private bool Mc333fd01()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fa5ea047c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fab4ecba9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f72388d97
        return false;
    }

    private bool Mc333fd01(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fa5ea047c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f72388d97
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fab4ecba9
        return false;
    }

    public static void Me57bed54(int P0, int[] P1, int[] P2)
    {
        // str: "Number of rounds must be even"
        // str: ""
        // call: pf74464bf.mff847a50
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
    }

    private void AdvanceCounter()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
    }

    private void AdvanceCounter(long P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
    }

    private void GenerateKeyStream(byte[] P0)
    {
        // call: p35da9a23.me57bed54
        // call: p4492081c.m45d2d6ef
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9dd4e461
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f8d7e7aa4
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
    }

    public string GetAlgorithmName()
    {
        // str: "Salsa20"
        // str: "Salsa20/"
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f8d7e7aa4
        // type: StringBuilder
        return string.Empty;
    }

    private long GetCounter()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
        return 0;
    }

    private int GetNonceSize()
    {
        return 0;
    }

    public long GetPosition()
    {
        // call: p35da9a23.getCounter
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f6a992d55
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: " requires exactly "
        // str: " Init parameters must include an IV"
        // str: " bytes of IV"
        // str: " KeyParameter can not be null for first initialisation"
        // str: " Init parameters must contain a KeyParameter (or null for re-init)"
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p35da9a23.getNonceSize
        // call: p35da9a23.setKey
        // call: StringBuilder.<init>
        // call: p35da9a23.getAlgorithmName
        // call: pdd5da44e.getIV
        // call: pdd5da44e.getParameters
        // call: p35da9a23.reset
        // call: p94919be6.getKey
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fdb1687e1
        // type: StringBuilder
        // type: IllegalArgumentException
        // type: IllegalStateException
    }

    private void PackTauOrSigma(int P0, int[] P1, int P2)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fa3fd9eb7
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: " not initialised"
        // str: "input buffer too short"
        // str: "output buffer too short"
        // str: "2^70 byte limit per IV would be exceeded; Change IV"
        // call: p2500579c.<init>
        // call: p35da9a23.mc333fd01
        // call: IllegalStateException.<init>
        // call: p35da9a23.advanceCounter
        // call: StringBuilder.append
        // call: p9be27c4e.<init>
        // call: p35da9a23.generateKeyStream
        // call: p35da9a23.getAlgorithmName
        // call: p96068848.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f6a992d55
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fdb1687e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f85c250af
        // type: IllegalStateException
        // type: p2500579c
        // type: p9be27c4e
        // type: StringBuilder
        // type: p96068848
        return 0;
    }

    public void Reset()
    {
        // call: p35da9a23.ma3963a4c
        // call: p35da9a23.resetCounter
        // call: p35da9a23.generateKeyStream
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f6a992d55
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f85c250af
    }

    private void ResetCounter()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
    }

    private void RetreatCounter()
    {
        // str: "attempt to reduce counter past zero."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
        // type: IllegalStateException
    }

    private void RetreatCounter(long P0)
    {
        // str: "attempt to reduce counter past zero."
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
        // type: IllegalStateException
    }

    public byte ReturnByte(byte P0)
    {
        // str: "2^70 byte limit per IV; Change IV"
        // call: p35da9a23.advanceCounter
        // call: p35da9a23.generateKeyStream
        // call: p9be27c4e.<init>
        // call: p35da9a23.mc333fd01
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f85c250af
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f6a992d55
        // type: p9be27c4e
        return 0;
    }

    public long SeekTo(long P0)
    {
        // call: p35da9a23.skip
        // call: p35da9a23.reset
        return 0;
    }

    private void SetKey(byte[] P0, byte[] P1)
    {
        // str: " requires 128 bit or 256 bit key"
        // call: StringBuilder.append
        // call: p4492081c.m0eef4fb6
        // call: p35da9a23.getAlgorithmName
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f9457b3e2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.fa3fd9eb7
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public long Skip(long P0)
    {
        // call: p35da9a23.retreatCounter
        // call: p35da9a23.advanceCounter
        // call: p35da9a23.generateKeyStream
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f6a992d55
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p35da9a23.f85c250af
        return 0;
    }

}
