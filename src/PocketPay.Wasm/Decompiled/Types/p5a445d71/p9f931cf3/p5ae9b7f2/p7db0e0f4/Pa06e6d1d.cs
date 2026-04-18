namespace WillowMaze.Wasm.Decompiled;

public class Pa06e6d1d : P42a46bbe
{
    private pe5cfc515 F0db6d7a1;
    private pe5cfc515 F1be6ed7c;
    private System.Security.Cryptography.RandomNumberGenerator F28794f42;
    private pe5cfc515 F2d83a148;
    private System.Security.Cryptography.RandomNumberGenerator F6ad94312;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private bool F9301aa9b;
    private p42a46bbe Fad1943a9;
    private byte[] Fb6f5007a;
    private byte[] Fbdbf3e62;
    private System.Security.Cryptography.RandomNumberGenerator Fc57b1bd5;
    private bool Fd2ba2fcc;
    private byte[] Fd38e6340;
    private byte[] Fd6833906;
    private p42a46bbe Fdc761897;
    private System.Security.Cryptography.RandomNumberGenerator Fe16c7618;
    private pe5cfc515 Fee22b5bb;
    private pe5cfc515 Ff51df705;

    private byte[] Maafcb7af(byte[] P0, int P1, int P2, int P3)
    {
        // call: pe5cfc515.reset
        // call: System.arraycopy
        // call: p4492081c.m27c2615b
        // call: pe5cfc515.doFinal
        // call: pe5cfc515.update
        // call: pe5cfc515.getDigestSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f2d83a148
        return default!;
    }

    public byte[] DecodeBlock(byte[] P0, int P1, int P2)
    {
        // str: "data wrong"
        // call: pa06e6d1d.maafcb7af
        // call: pff43b8de.ma552c747
        // call: p42a46bbe.processBlock
        // call: System.arraycopy
        // call: p42a46bbe.getOutputBlockSize
        // call: p21c8c989.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        // type: p21c8c989
        return default!;
    }

    public byte[] EncodeBlock(byte[] P0, int P1, int P2)
    {
        // str: "input data too long"
        // call: System.arraycopy
        // call: pa06e6d1d.getInputBlockSize
        // call: pa06e6d1d.maafcb7af
        // call: p96068848.<init>
        // call: p42a46bbe.processBlock
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f7ddf32e1
        // type: p96068848
        return default!;
    }

    public int GetInputBlockSize()
    {
        // call: p42a46bbe.getInputBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: p42a46bbe.getOutputBlockSize
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        return 0;
    }

    public p42a46bbe GetUnderlyingCipher()
    {
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: pa9682fb5.m07091bf1
        // call: p4715f007.getRandom
        // call: p42a46bbe.init
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f7ddf32e1
    }

    public byte[] ProcessBlock(byte[] P0, int P1, int P2)
    {
        // call: pa06e6d1d.encodeBlock
        // call: pa06e6d1d.decodeBlock
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        return default!;
    }

}
