namespace WillowMaze.Wasm.Decompiled;

public class P9682f740 : Pd81e8b93
{
    private static Hashtable F00ab0648;
    private static byte[] F057eb618;
    private static byte[] F0b59b769;
    private static Hashtable F0c7be7a3;
    private static byte[] F1d51e3ae;
    private static byte[] F3004e69c;
    private static int F350b0a70;
    private static byte[] F36e33aac;
    private static byte[] F37b3364e;
    private static byte[] F43efaa3e;
    private static byte[] F48a5603d;
    private static byte[] F496f7223;
    private static byte[] F5111910f;
    private static Hashtable F55bff335;
    private static byte[] F60f027b0;
    private static byte[] F6ace6182;
    private static byte[] F6c5f1057;
    private static byte[] F7445c53c;
    private static byte[] F768f3acf;
    private static byte[] F793ebe0d;
    private static byte[] F802b5545;
    private static byte[] F81ffe968;
    private static byte[] F8391297b;
    private static Hashtable F88a67230;
    private static int F9be348e6;
    private static byte[] F9faa3fe4;
    private static byte[] Fa09dbe0a;
    private static byte[] Faba72906;
    private static byte[] Fad051a11;
    private static Hashtable Fba80cc6d;
    private static byte[] Fbb64006e;
    private static byte[] Fc13ab3bc;
    private static int Fc75e2054;
    private static byte[] Fd4398eed;
    private static int Fd4c0cc77;
    private static byte[] Fd668e768;
    private static byte[] Fddc26865;
    private static byte[] Fe532b17e;
    private static byte[] Fedd2d453;
    private static byte[] Fee3418c1;
    private static byte[] Ff0230247;
    private static byte[] Ff058a1ab;
    private static byte[] Ff8e0d227;
    private static byte[] Ffff7c92a;
    private bool F08277871;
    private int[] F0d9d1f7a;
    private byte[] F292029f4;
    private int[] F2a0ef8d2;
    private byte[] F5dbc98dc;
    private byte[] F7ccc6bac;
    private bool F9301aa9b;
    private int[] Fa2f40f12;
    private int[] Fdfa8e5da;
    private bool Fe8bb9f75;

    private void M01b0436d(int P0, byte[] P1, int P2)
    {
    }

    private static void M058d8373(string P0, byte[] P1)
    {
        // call: Hashtable.put
        // call: p89be9433.mb8a8247c
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.fba80cc6d
    }

    private int M168eeabd(int P0, int P1)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.f5dbc98dc
        return 0;
    }

    public static byte[] M702bdf8e(string P0)
    {
        // str: "Unknown S-Box - possible types: \"Default\", \"E-Test\", \"E-A\", \"E-B\", \"E-C\", \"E-D\", \"Pa..."
        // call: p89be9433.mb8a8247c
        // call: Hashtable.get
        // call: IllegalArgumentException.<init>
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.fba80cc6d
        // type: IllegalArgumentException
        return default!;
    }

    public static string M875e8966(byte[] P0)
    {
        // str: "SBOX provided did not map to a known one"
        // call: Hashtable.get
        // call: pff43b8de.m2a3f81d2
        // call: IllegalArgumentException.<init>
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: Hashtable.keys
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.fba80cc6d
        // type: IllegalArgumentException
        return string.Empty;
    }

    private int[] M9e03abad(bool P0, byte[] P1)
    {
        // str: "Key length invalid. Key needs to be 32 byte - 256 bit!!!"
        // call: IllegalArgumentException.<init>
        // call: p9682f740.mc4dbe288
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.f9301aa9b
        // type: IllegalArgumentException
        return default!;
    }

    private int Mc4dbe288(byte[] P0, int P1)
    {
        return 0;
    }

    private void Mcae43528(int[] P0, byte[] P1, int P2, byte[] P3, int P4)
    {
        // call: p9682f740.m168eeabd
        // call: p9682f740.mc4dbe288
        // call: p9682f740.m01b0436d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.f9301aa9b
    }

    public string GetAlgorithmName()
    {
        // str: "GOST28147"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid S-box passed to GOST28147 init"
        // str: "invalid parameter passed to GOST28147 init - "
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p819716a1.getParameters
        // call: p94919be6.getKey
        // call: p9682f740.m9e03abad
        // call: IllegalArgumentException.<init>
        // call: object.getClass
        // call: p819716a1.getSBox
        // call: StringBuilder.<init>
        // call: pff43b8de.md329fd77
        // call: Type.getName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.f36e33aac
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.f5dbc98dc
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.f0d9d1f7a
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "GOST28147 engine not initialised"
        // str: "output buffer too short"
        // str: "input buffer too short"
        // call: p9682f740.mcae43528
        // call: p96068848.<init>
        // call: IllegalStateException.<init>
        // call: p2500579c.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740.f0d9d1f7a
        // type: p96068848
        // type: p2500579c
        // type: IllegalStateException
        return 0;
    }

    public void Reset()
    {
    }

}
