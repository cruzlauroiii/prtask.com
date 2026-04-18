namespace WillowMaze.Wasm.Decompiled;

public class Pf4a06df0 : Pd81e8b93
{
    private static int F0266ffa8;
    private static int F048d50cd;
    private static int F07b6b703;
    private static int F07fa0948;
    private static int F0a92e086;
    private static int F1d503eb0;
    private static int F208cb3ec;
    private static int F33139d3d;
    private static int F65ce0eed;
    private static int F71dfcecc;
    private static int F8748950e;
    private static int F9063f895;
    private static int F9513b6a7;
    private static int Fa322ac69;
    private static int Fb24d7545;
    private static int Fb9a2324b;
    private static int Fd770f896;
    private static int Fdd97404a;
    private static int Febf25eec;
    private static int Ff278ea34;
    private static int Ff2c36c81;
    private static int Ff5fa341e;
    private static int Ffc87d1c8;
    private int[] F4a3d5076;
    private bool F6a5439b2;
    private bool F9301aa9b;
    private int[] F9e28ebf8;

    private int M38ba9ce4(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: pf4a06df0.mdde1faa5
        // call: pf4a06df0.m707a37c3
        // call: pf4a06df0.mff847a50
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf4a06df0.f9e28ebf8
        return 0;
    }

    private void M40939905(byte[] P0)
    {
        // call: pf4a06df0.mff847a50
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf4a06df0.f9e28ebf8
    }

    private int M54b8c68b(byte[] P0, int P1, byte[] P2, int P3)
    {
        // call: pf4a06df0.mdde1faa5
        // call: pf4a06df0.ma12752e3
        // call: pf4a06df0.m707a37c3
        // call: pf4a06df0.mff847a50
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf4a06df0.f9e28ebf8
        return 0;
    }

    private void M707a37c3(int P0, byte[] P1, int P2)
    {
    }

    private int Ma12752e3(int P0, int P1)
    {
        return 0;
    }

    private int Mdde1faa5(byte[] P0, int P1)
    {
        return 0;
    }

    private int Mff847a50(int P0, int P1)
    {
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "RC6"
        return string.Empty;
    }

    public int GetBlockSize()
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed to RC6 init - "
        // call: p94919be6.getKey
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: Type.getName
        // call: pf4a06df0.m40939905
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf4a06df0.f9301aa9b
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "RC6 engine not initialised"
        // str: "output buffer too short"
        // str: "input buffer too short"
        // call: p96068848.<init>
        // call: pf4a06df0.m38ba9ce4
        // call: IllegalStateException.<init>
        // call: pf4a06df0.m54b8c68b
        // call: p2500579c.<init>
        // call: pf4a06df0.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf4a06df0.f9e28ebf8
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pf4a06df0.f9301aa9b
        // type: IllegalStateException
        // type: p2500579c
        // type: p96068848
        return 0;
    }

    public void Reset()
    {
    }

}
