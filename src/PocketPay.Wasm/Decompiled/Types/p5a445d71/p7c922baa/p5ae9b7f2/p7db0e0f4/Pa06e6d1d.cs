namespace WillowMaze.Wasm.Decompiled;

public class Pa06e6d1d : P42a46bbe
{
    private pe5cfc515 F0de7dddd;
    private System.Security.Cryptography.RandomNumberGenerator F1ad46f03;
    private pe5cfc515 F2d83a148;
    private bool F3734fe5f;
    private System.Security.Cryptography.RandomNumberGenerator F451b78b3;
    private byte[] F5367e101;
    private p42a46bbe F5cd2192a;
    private bool F5fb93a57;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private p42a46bbe F84088c09;
    private bool F9301aa9b;
    private p42a46bbe Fad1943a9;
    private byte[] Fd38e6340;
    private p42a46bbe Ff940088f;
    private System.Security.Cryptography.RandomNumberGenerator Ffe656936;

    private void M634ed66f(int P0, byte[] P1)
    {
    }

    private byte[] Maafcb7af(byte[] P0, int P1, int P2, int P3)
    {
        // call: System.arraycopy
        // call: pa06e6d1d.m634ed66f
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.update
        // call: pe5cfc515.reset
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f2d83a148
        return default!;
    }

    public byte[] DecodeBlock(byte[] P0, int P1, int P2)
    {
        // str: "data wrong"
        // call: pa06e6d1d.maafcb7af
        // call: p42a46bbe.getOutputBlockSize
        // call: System.arraycopy
        // call: pff43b8de.ma552c747
        // call: p21c8c989.<init>
        // call: p42a46bbe.processBlock
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // type: p21c8c989
        return default!;
    }

    public byte[] EncodeBlock(byte[] P0, int P1, int P2)
    {
        // str: "input data too long"
        // call: pa06e6d1d.getInputBlockSize
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: System.arraycopy
        // call: p96068848.<init>
        // call: pa06e6d1d.maafcb7af
        // call: p42a46bbe.processBlock
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f7ddf32e1
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // type: p96068848
        return default!;
    }

    public int GetInputBlockSize()
    {
        // call: p42a46bbe.getInputBlockSize
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: p42a46bbe.getOutputBlockSize
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fd38e6340
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        return 0;
    }

    public p42a46bbe GetUnderlyingCipher()
    {
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p4715f007.getRandom
        // call: System.Security.Cryptography.RandomNumberGenerator.<init>
        // call: p42a46bbe.init
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f7ddf32e1
        // type: System.Security.Cryptography.RandomNumberGenerator
    }

    public byte[] ProcessBlock(byte[] P0, int P1, int P2)
    {
        // call: pa06e6d1d.encodeBlock
        // call: pa06e6d1d.decodeBlock
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pa06e6d1d.f9301aa9b
        return default!;
    }

}
