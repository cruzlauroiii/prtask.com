namespace WillowMaze.Wasm.Decompiled;

public class P32551d15 : P66d30ee8
{
    private pa444028e F134e21b8;
    private pa444028e Fb70cdb87;

    public int DoFinal(byte[] P0, int P1)
    {
        // str: "last block incomplete in decryption"
        // str: "output buffer too short"
        // call: pa444028e.padCount
        // call: System.arraycopy
        // call: p96068848.<init>
        // call: pd81e8b93.processBlock
        // call: p32551d15.reset
        // call: p2500579c.<init>
        // call: pd81e8b93.getBlockSize
        // call: pa444028e.addPadding
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.fb70cdb87
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f9301aa9b
        // type: p2500579c
        // type: p96068848
        return 0;
    }

    public int GetOutputSize(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f9301aa9b
        return 0;
    }

    public int GetUpdateOutputSize(int P0)
    {
        // call: Math.max
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.fcb7e52b2
        return 0;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: pd81e8b93.init
        // call: pa444028e.init
        // call: p32551d15.reset
        // call: p4715f007.getParameters
        // call: p4715f007.getRandom
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.fb70cdb87
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f9301aa9b
    }

    public int ProcessByte(byte P0, byte[] P1, int P2)
    {
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f08406a6e
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output buffer too short"
        // str: "Can't have a negative input length!"
        // call: IllegalArgumentException.<init>
        // call: p32551d15.getBlockSize
        // call: pd81e8b93.processBlock
        // call: System.arraycopy
        // call: p2500579c.<init>
        // call: p32551d15.getUpdateOutputSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15.f08406a6e
        // type: p2500579c
        // type: IllegalArgumentException
        return 0;
    }

}
