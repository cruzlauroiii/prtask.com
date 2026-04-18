namespace WillowMaze.Wasm.Decompiled;

public class Pab2ee25d : Pe3d43295
{
    private byte[] F03dd1761;
    private byte[] F1cf15ddd;
    private pd81e8b93 F2aa278f9;
    private bool F3227d86a;
    private byte[] F38729c39;
    private bool F408037f2;
    private byte[] F4a1f429a;
    private pd81e8b93 F5fe2416e;
    private byte[] F6e5d7d25;
    private int F712060fd;
    private int F71b5ee32;
    private byte[] F7358b888;
    private pd81e8b93 F7585d2c1;
    private pd81e8b93 F7875c8c0;
    private int F8bcd042d;
    private byte[] F9dbfc835;
    private int Fa43ef6d6;
    private byte[] Fa9a01dd2;
    private bool Faa47a041;
    private pd81e8b93 Fad1943a9;
    private bool Fc015d693;
    private byte[] Fca0c9a3b;
    private byte[] Fcb729e60;
    private bool Fdb1687e1;
    private byte[] Fe644f079;
    private byte[] Fe6d4b993;
    private byte[] Ff0b53b2d;
    private byte[] Ff603d222;

    private void M09eb96ef()
    {
    }

    private void Mdc669dcd(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.ff603d222
    }

    private byte CalculateByte(byte P0)
    {
        // call: pab2ee25d.mdc669dcd
        // call: pab2ee25d.m09eb96ef
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.f38729c39
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.ff603d222
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fad1943a9
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "/KCTR"
        // call: pd81e8b93.getAlgorithmName
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fad1943a9
        // type: StringBuilder
        return string.Empty;
    }

    public int GetBlockSize()
    {
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fad1943a9
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameter passed"
        // call: System.arraycopy
        // call: pdd5da44e.getIV
        // call: pff43b8de.ma552c747
        // call: pab2ee25d.reset
        // call: pdd5da44e.getParameters
        // call: IllegalArgumentException.<init>
        // call: pd81e8b93.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fdb1687e1
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fad1943a9
        // type: IllegalArgumentException
    }

    public int ProcessBlock(byte[] P0, int P1, byte[] P2, int P3)
    {
        // str: "input buffer too short"
        // str: "output buffer too short"
        // call: pab2ee25d.getBlockSize
        // call: pab2ee25d.processBytes
        // call: p96068848.<init>
        // call: p2500579c.<init>
        // type: p96068848
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.ff603d222
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fa43ef6d6
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pab2ee25d.fdb1687e1
    }

}
