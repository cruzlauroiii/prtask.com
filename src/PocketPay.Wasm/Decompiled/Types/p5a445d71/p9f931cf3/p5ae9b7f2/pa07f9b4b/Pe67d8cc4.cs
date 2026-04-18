namespace WillowMaze.Wasm.Decompiled;

public class Pe67d8cc4 : P47b78e9d
{
    private byte F03c7c0ac;
    private byte[] F0d9d1f7a;
    private byte[] F3963d9dd;
    private byte[] F4074664c;
    private byte[] F4379944c;
    private byte[] F44c29edb;
    private byte[] F7893dde8;
    private byte F7b8b965a;
    private byte[] F8c557f4e;
    private byte[] F92d36d0e;
    private byte[] Fa6c87772;
    private byte[] Fb6ffd2ee;
    private byte Fd1fa4478;
    private byte[] Fd7cf4bdf;
    private byte Fee4194e9;

    public string GetAlgorithmName()
    {
        // str: "VMPC"
        return string.Empty;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "VMPC init parameters must include an IV"
        // str: "VMPC requires 1 to 768 bytes of IV"
        // str: "VMPC init parameters must include a key"
        // call: p94919be6.getKey
        // call: IllegalArgumentException.<init>
        // call: pdd5da44e.getParameters
        // call: pe67d8cc4.initKey
        // call: pdd5da44e.getIV
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.fb6ffd2ee
        // type: IllegalArgumentException
    }

    private void InitKey(byte[] P0, byte[] P1)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f7b8b965a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f03c7c0ac
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f44c29edb
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output buffer too short"
        // str: "input buffer too short"
        // call: p96068848.<init>
        // call: p2500579c.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f03c7c0ac
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f44c29edb
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f7b8b965a
        // type: p96068848
        // type: p2500579c
        return 0;
    }

    public void Reset()
    {
        // call: pe67d8cc4.initKey
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f0d9d1f7a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.fb6ffd2ee
    }

    public byte ReturnByte(byte P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f03c7c0ac
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f7b8b965a
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4.f44c29edb
        return 0;
    }

}
