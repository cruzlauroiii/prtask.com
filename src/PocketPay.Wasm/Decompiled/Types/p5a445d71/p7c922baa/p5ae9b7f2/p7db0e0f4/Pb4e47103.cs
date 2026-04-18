namespace WillowMaze.Wasm.Decompiled;

public class Pb4e47103 : P42a46bbe
{
    public static string F058c388b;
    private static int F09863600;
    private static int F0d6d40ea;
    public static string F28e55e14;
    public static string F30752f6d;
    public static string F5b033db0;
    public static string Fa823b529;
    public static string Fb9a41006;
    private static int Fcfdca198;
    public static string Fe57dbe97;
    private static int Fe7441bfb;
    private static int Fe76f3b29;
    private bool F081b384e;
    private byte[] F0cc76793;
    private bool F163c0a05;
    private int F23db6d15;
    private bool F4abf8ea8;
    private byte[] F4ca837fe;
    private byte[] F4ccb1142;
    private bool F5c725a13;
    private p42a46bbe F63d90bcc;
    private byte[] F644b59c8;
    private bool F6ab47a2c;
    private byte[] F6cf1e137;
    private bool F7b0c1a40;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private bool F8612c245;
    private bool F9301aa9b;
    private byte[] F97d7a4b2;
    private int Fa1f83c16;
    private p42a46bbe Fa957c53a;
    private p42a46bbe Fad1943a9;
    private p42a46bbe Fb19767b6;
    private p42a46bbe Fb6137de1;
    private int Fc47db3b3;
    private int Fc5798c26;
    private System.Security.Cryptography.RandomNumberGenerator Fd56ac9a4;
    private bool Fd9c5e7ee;
    private bool Fe7fb2e81;
    private bool Fec2c5a9a;
    private byte[] Ff7bf6958;
    private bool Ffe4c6cae;

    private int M0289c195(byte P0, byte[] P1)
    {
        return 0;
    }

    private bool M07a61978()
    {
        // str: "true"
        // call: AccessController.doPrivileged
        // call: pb4e47103$2.<init>
        // call: pb4e47103$1.<init>
        // call: string.equals
        // type: pb4e47103$1
        // type: pb4e47103$2
        return false;
    }

    private byte[] M104cc47d(byte[] P0, int P1, int P2)
    {
        // str: "block incorrect size"
        // str: "block incorrect"
        // call: pb4e47103.m0289c195
        // call: pff43b8de.ma552c747
        // call: pb4e47103.getOutputBlockSize
        // call: pb4e47103.m6427120e
        // call: p42a46bbe.getOutputBlockSize
        // call: System.arraycopy
        // call: p21c8c989.<init>
        // call: p42a46bbe.processBlock
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.ffe4c6cae
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f23db6d15
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f97d7a4b2
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f6ab47a2c
        // type: p21c8c989
        return default!;
    }

    private byte[] M6427120e(byte[] P0, int P1, int P2)
    {
        // str: "sorry, this method is only for decryption, not for signing"
        // call: p21c8c989.<init>
        // call: p42a46bbe.getOutputBlockSize
        // call: pb4e47103.m7e94893c
        // call: pff43b8de.ma552c747
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p42a46bbe.processBlock
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f23db6d15
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f4ccb1142
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f7ddf32e1
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f97d7a4b2
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f6ab47a2c
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.ffe4c6cae
        // type: p21c8c989
        return default!;
    }

    private byte[] M7e820b64(byte[] P0, int P1, int P2)
    {
        // str: "input data too large"
        // call: System.Security.Cryptography.RandomNumberGenerator.nextInt
        // call: p42a46bbe.processBlock
        // call: p42a46bbe.getInputBlockSize
        // call: IllegalArgumentException.<init>
        // call: System.arraycopy
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pb4e47103.getInputBlockSize
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f7ddf32e1
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f6ab47a2c
        // type: IllegalArgumentException
        return default!;
    }

    private static int M7e94893c(byte[] P0, int P1)
    {
        return 0;
    }

    public int GetInputBlockSize()
    {
        // call: p42a46bbe.getInputBlockSize
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f9301aa9b
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.fad1943a9
        return 0;
    }

    public int GetOutputBlockSize()
    {
        // call: p42a46bbe.getOutputBlockSize
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f9301aa9b
        return 0;
    }

    public p42a46bbe GetUnderlyingCipher()
    {
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.fad1943a9
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // str: "encoder requires random"
        // call: p42a46bbe.init
        // call: p42a46bbe.getOutputBlockSize
        // call: System.Security.Cryptography.RandomNumberGenerator.<init>
        // call: p4715f007.getRandom
        // call: pcfffbc4a.isPrivate
        // call: p4715f007.getParameters
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f6ab47a2c
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f97d7a4b2
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f4ccb1142
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f7ddf32e1
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.fad1943a9
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f9301aa9b
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f23db6d15
        // type: IllegalArgumentException
        // type: System.Security.Cryptography.RandomNumberGenerator
    }

    public byte[] ProcessBlock(byte[] P0, int P1, int P2)
    {
        // call: pb4e47103.m7e820b64
        // call: pb4e47103.m104cc47d
        // field: p5a445d71.p7c922baa.p5ae9b7f2.p7db0e0f4.pb4e47103.f9301aa9b
        return default!;
    }

}
