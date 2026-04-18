namespace WillowMaze.Wasm.Decompiled;

public class P33e2fd8f : P9fb233a6
{
    private int F0296dfda;
    private byte[] F04c5021b;
    private pd81e8b93 F08406a6e;
    private byte[] F0eba983a;
    private int F0fdf3ed7;
    private byte[] F127b5f82;
    private p33e2fd8f$p10ca60f3 F138a134f;
    private pc9ef6b45 F17f009cc;
    private byte[] F17ff1731;
    private pd81e8b93 F1a06a925;
    private pc9ef6b45 F36170b49;
    private p33e2fd8f$p10ca60f3 F3697d184;
    private int F480d1b61;
    private p33e2fd8f$p10ca60f3 F52221a22;
    private pd81e8b93 F5c084c75;
    private bool F6876789d;
    private int F6e97aabf;
    private byte[] F75582f98;
    private p33e2fd8f$p10ca60f3 F831cf984;
    private p33e2fd8f$p10ca60f3 F8b7a4e43;
    private p33e2fd8f$p10ca60f3 F8d777f38;
    private bool F9301aa9b;
    private bool F97552f0d;
    private byte[] F9f0f0f0c;
    private bool Fa33274d8;
    private pc9ef6b45 Fa3e29d28;
    private int Fa3e75e2d;
    private bool Fa920cc05;
    private byte[] Fa92a12dc;
    private byte[] Fafdb8521;
    private int Fb10caf3d;
    private pd81e8b93 Fc2385f63;
    private byte[] Fcb584e44;
    private pc9ef6b45 Fcf9eb47d;
    private p33e2fd8f$p10ca60f3 Fda3114a0;
    private byte[] Fdc3615b3;
    private byte[] Ff2605afa;
    private pd81e8b93 Ff7da3d32;

    private int M0066bf04(bool P0, int P1)
    {
        // str: "tag length in octets must be one of {4,6,8,10,12,14,16}"
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return 0;
    }

    private int M69aaadd3()
    {
        // call: p33e2fd8f$p10ca60f3.size
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fdc3615b3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8b7a4e43
        return 0;
    }

    private int M7b28ac1a(byte[] P0, int P1, int P2, byte[] P3)
    {
        // call: p1748c064.update
        // call: p33e2fd8f.m69aaadd3
        // call: p1748c064.init
        // call: p33e2fd8f.ma39aa3c3
        // call: p33e2fd8f$p10ca60f3.size
        // call: p1748c064.getMacSize
        // call: p1748c064.doFinal
        // call: p33e2fd8f$p10ca60f3.getBuffer
        // call: p48357ead.<init>
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f36170b49
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fdc3615b3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8b7a4e43
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fcb584e44
        // type: p48357ead
        return 0;
    }

    private bool Ma39aa3c3()
    {
        // call: p33e2fd8f.m69aaadd3
        return false;
    }

    public int DoFinal(byte[] P0, int P1)
    {
        // call: p33e2fd8f.reset
        // call: p33e2fd8f$p10ca60f3.size
        // call: p33e2fd8f.processPacket
        // call: p33e2fd8f$p10ca60f3.getBuffer
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8d777f38
        return 0;
    }

    public string GetAlgorithmName()
    {
        // str: "/CCM"
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pd81e8b93.getAlgorithmName
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f08406a6e
        // type: StringBuilder
        return string.Empty;
    }

    public byte[] GetMac()
    {
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f0eba983a
        return default!;
    }

    public int GetOutputSize(int P0)
    {
        // call: p33e2fd8f$p10ca60f3.size
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8d777f38
        return 0;
    }

    public pd81e8b93 GetUnderlyingCipher()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f08406a6e
        return default!;
    }

    public int GetUpdateOutputSize(int P0)
    {
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "invalid parameters passed to CCM: "
        // str: "nonce must have length from 7 to 13 octets"
        // call: Type.getName
        // call: StringBuilder.toString
        // call: p33e2fd8f.reset
        // call: object.getClass
        // call: p33e2fd8f.m0066bf04
        // call: ped128738.getKey
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: ped128738.getNonce
        // call: ped128738.getMacSize
        // call: pdd5da44e.getIV
        // call: StringBuilder.append
        // call: ped128738.getAssociatedText
        // call: pdd5da44e.getParameters
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fcb584e44
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f36170b49
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fdc3615b3
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f9301aa9b
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public void ProcessAADByte(byte P0)
    {
        // call: p33e2fd8f$p10ca60f3.write
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8b7a4e43
    }

    public void ProcessAADBytes(byte[] P0, int P1, int P2)
    {
        // call: p33e2fd8f$p10ca60f3.write
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8b7a4e43
    }

    public int ProcessByte(byte P0, byte[] P1, int P2)
    {
        // call: p33e2fd8f$p10ca60f3.write
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8d777f38
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Input buffer too short"
        // call: p96068848.<init>
        // call: p33e2fd8f$p10ca60f3.write
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8d777f38
        // type: p96068848
        return 0;
    }

    public int ProcessPacket(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Output buffer too short."
        // str: "CCM packet too large for choice of q."
        // str: "data too short"
        // str: "CCM cipher unitialized."
        // str: "mac check in CCM failed"
        // call: p33e2fd8f.m7b28ac1a
        // call: p21c8c989.<init>
        // call: System.arraycopy
        // call: pdd5da44e.<init>
        // call: pd81e8b93.processBlock
        // call: p2500579c.<init>
        // call: p0b9229ba.<init>
        // call: pff43b8de.m66e765de
        // call: IllegalStateException.<init>
        // call: pd81e8b93.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f480d1b61
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f0eba983a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f36170b49
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fcb584e44
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f9301aa9b
        // type: IllegalStateException
        // type: p21c8c989
        // type: p2500579c
        // type: pdd5da44e
        // type: p0b9229ba
        return 0;
    }

    public byte[] ProcessPacket(byte[] P0, int P1, int P2)
    {
        // str: "data too short"
        // call: p33e2fd8f.processPacket
        // call: p21c8c989.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.fa3e75e2d
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f9301aa9b
        // type: p21c8c989
        return default!;
    }

    public void Reset()
    {
        // call: pd81e8b93.reset
        // call: p33e2fd8f$p10ca60f3.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8b7a4e43
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p33e2fd8f.f8d777f38
    }

}
