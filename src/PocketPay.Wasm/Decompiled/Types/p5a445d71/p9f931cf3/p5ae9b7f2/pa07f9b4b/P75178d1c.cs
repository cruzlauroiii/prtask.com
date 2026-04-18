namespace WillowMaze.Wasm.Decompiled;

public class P75178d1c : Pe229a672
{
    private p94919be6 F194c4117;
    private byte[] F26bc9344;
    private bool F32dd591b;
    private bool F4854e26d;
    private bool F57e901be;
    private p94919be6 F592314c6;
    private bool F5dcfed4c;
    private pd81e8b93 F72933feb;
    private bool F86cff5e7;
    private byte[] Fa9b8b4b1;
    private pd81e8b93 Fad1943a9;
    private bool Fe468b4bf;
    private p94919be6 Feca07335;
    private byte[] Ff0b53b2d;
    private byte[] Ff9365f4b;
    private bool Ffc3e3db6;

    public string GetAlgorithmName()
    {
        // call: pd81e8b93.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.fad1943a9
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "IV not equal to 8"
        // call: p4715f007.getParameters
        // call: pdd5da44e.getParameters
        // call: IllegalArgumentException.<init>
        // call: pdd5da44e.getIV
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.fe468b4bf
        // type: IllegalArgumentException
    }

    public byte[] Unwrap(byte[] P0, int P1, int P2)
    {
        // str: "checksum failed"
        // str: "unwrap data must be a multiple of 8 bytes"
        // str: "not set for unwrapping"
        // call: System.arraycopy
        // call: pd81e8b93.processBlock
        // call: p21c8c989.<init>
        // call: IllegalStateException.<init>
        // call: pff43b8de.m66e765de
        // call: pd81e8b93.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.f32dd591b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.feca07335
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.fe468b4bf
        // type: IllegalStateException
        // type: p21c8c989
        return default!;
    }

    public byte[] Wrap(byte[] P0, int P1, int P2)
    {
        // str: "not set for wrapping"
        // str: "wrap data must be a multiple of 8 bytes"
        // call: System.arraycopy
        // call: p96068848.<init>
        // call: pd81e8b93.processBlock
        // call: IllegalStateException.<init>
        // call: pd81e8b93.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.fe468b4bf
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.f32dd591b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75178d1c.feca07335
        // type: p96068848
        // type: IllegalStateException
        return default!;
    }

}
