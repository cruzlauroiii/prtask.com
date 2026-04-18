namespace WillowMaze.Wasm.Decompiled;

public class P1e87fa68
{
    private readonly p42a46bbe F08406a6e;
    private int F4fe2f532;
    private byte[] F5ba4391d;
    private int F6c0e42ff;
    private byte[] Fcb7e52b2;
    private readonly p42a46bbe Ff322a131;

    public byte[] DoFinal()
    {
        // call: p42a46bbe.processBlock
        // call: p1e87fa68.reset
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f08406a6e
        return default!;
    }

    public int GetBufferPosition()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f4fe2f532
        return 0;
    }

    public int GetInputBlockSize()
    {
        // call: p42a46bbe.getInputBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f08406a6e
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: p42a46bbe.getOutputBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f08406a6e
        return 0;
    }

    public p42a46bbe GetUnderlyingCipher()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f08406a6e
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p42a46bbe.init
        // call: p1e87fa68.reset
        // call: p42a46bbe.getInputBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f4fe2f532
    }

    public void ProcessByte(byte P0)
    {
        // str: "attempt to process message too long for cipher"
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f4fe2f532
        // type: p96068848
    }

    public void ProcessBytes(byte[] P0, int P1, int P2)
    {
        // str: "Can't have a negative input length!"
        // str: "attempt to process message too long for cipher"
        // call: System.arraycopy
        // call: IllegalArgumentException.<init>
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.fcb7e52b2
        // type: IllegalArgumentException
        // type: p96068848
    }

    public void Reset()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p1e87fa68.fcb7e52b2
    }

}
