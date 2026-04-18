namespace WillowMaze.Wasm.Decompiled;

public class Pd0939147 : P1748c064
{
    private readonly pf78f8b44 F04f2c93b;
    private readonly pf78f8b44 F0c4115ba;
    private readonly pf78f8b44 F3c807ae1;
    private readonly pf78f8b44 F54088596;
    private readonly pf78f8b44 Fced84eb7;

    public int DoFinal(byte[] P0, int P1)
    {
        // call: pf78f8b44.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pd0939147.f0c4115ba
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "Mac"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pf78f8b44.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pd0939147.f0c4115ba
        // type: StringBuilder
        return string.Empty;
    }

    public int GetMacSize()
    {
        // call: pf78f8b44.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pd0939147.f0c4115ba
        return 0;
    }

    public void Init(pc9ef6b45 P0)
    {
        // str: "Invalid parameter passed to Blake3Mac init - "
        // str: "Blake3Mac requires a key parameter."
        // call: StringBuilder.toString
        // call: pc3f77815.m3c6e0b8a
        // call: IllegalArgumentException.<init>
        // call: pc3f77815.getKey
        // call: p94919be6.getKey
        // call: object.getClass
        // call: StringBuilder.<init>
        // call: pf78f8b44.init
        // call: Type.getName
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pd0939147.f0c4115ba
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public void Reset()
    {
        // call: pf78f8b44.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pd0939147.f0c4115ba
    }

    public void Update(byte P0)
    {
        // call: pf78f8b44.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pd0939147.f0c4115ba
    }

    public void Update(byte[] P0, int P1, int P2)
    {
        // call: pf78f8b44.update
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pd0939147.f0c4115ba
    }

}
