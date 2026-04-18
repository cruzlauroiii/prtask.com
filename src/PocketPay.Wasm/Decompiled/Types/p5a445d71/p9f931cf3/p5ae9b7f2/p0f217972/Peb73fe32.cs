namespace WillowMaze.Wasm.Decompiled;

public class Peb73fe32 : P66d30ee8
{
    public int DoFinal(byte[] P0, int P1)
    {
        // str: "pad block corrupted"
        // str: "output buffer too short"
        // str: "last block incomplete in decryption"
        // call: pd81e8b93.processBlock
        // call: peb73fe32.reset
        // call: pd81e8b93.getBlockSize
        // call: p21c8c989.<init>
        // call: p2500579c.<init>
        // call: p96068848.<init>
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f9301aa9b
        // type: p96068848
        // type: p21c8c989
        // type: p2500579c
        return 0;
    }

    public int GetOutputSize(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.fcb7e52b2
        return 0;
    }

    public int GetUpdateOutputSize(int P0)
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.fcb7e52b2
        return 0;
    }

    public int ProcessByte(byte P0, byte[] P1, int P2)
    {
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f08406a6e
        return 0;
    }

    public int ProcessBytes(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "Can't have a negative input length!"
        // str: "output buffer too short"
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // call: peb73fe32.getUpdateOutputSize
        // call: p2500579c.<init>
        // call: peb73fe32.getBlockSize
        // call: pd81e8b93.processBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f08406a6e
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.f4fe2f532
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.peb73fe32.fcb7e52b2
        // type: p2500579c
        // type: IllegalArgumentException
        return 0;
    }

}
