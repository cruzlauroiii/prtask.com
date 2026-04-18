namespace WillowMaze.Wasm.Decompiled;

public class Pdc6b8bc5 : CipherSpi
{
    private int F12a896cb;
    private System.Security.Cryptography.RandomNumberGenerator F1344b663;
    private pcfffbc4a F2404415e;
    private p41f9db06 F36c57275;
    private pcfffbc4a F3c6e0b8a;
    private System.Security.Cryptography.RandomNumberGenerator F45aac661;
    private pcfffbc4a F465142e0;
    private pcfffbc4a F506eaddf;
    private pdc6b8bc5$pf0d24f46 F694c4a59;
    private readonly pb3b7fb02 F6fb99045;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private pdc6b8bc5$pf0d24f46 F7f2db423;
    private readonly pb3b7fb02 F9c63a825;
    private int F9ed39e2e;
    private pdc6b8bc5$pf0d24f46 Fa3b49306;
    private readonly pb3b7fb02 Fa7d9eb96;
    private p41f9db06 Fad1943a9;
    private int Fbbcaa251;
    private p41f9db06 Fc3f1c152;
    private System.Security.Cryptography.RandomNumberGenerator Fc5505530;
    private readonly pb3b7fb02 Fcabfe87e;
    private int Feff5775d;
    private readonly pb3b7fb02 Ffde5d67b;

    public int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: System.arraycopy
        // call: pdc6b8bc5.engineDoFinal
        return 0;
    }

    public byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // str: "unable to process block"
        // str: "cipher not initialised"
        // call: pdc6b8bc5$pf0d24f46.erase
        // call: pec7a0e67.<init>
        // call: p4715f007.<init>
        // call: p41f9db06.init
        // call: pdc6b8bc5$pf0d24f46.getBuf
        // call: pdc6b8bc5$pf0d24f46.size
        // call: p41f9db06.processBlock
        // call: pdc6b8bc5$pf0d24f46.write
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f7f2db423
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f9ed39e2e
        // type: pec7a0e67
        // type: p4715f007
        // type: IllegalStateException
        return default!;
    }

    public int EngineGetBlockSize()
    {
        return 0;
    }

    public byte[] EngineGetIV()
    {
        return default!;
    }

    public int EngineGetKeySize(Key P0)
    {
        // str: "not an EC key"
        // call: IllegalArgumentException.<init>
        // call: pa827ecfa.getFieldSize
        // call: p835df581.getCurve
        // call: pc525de4e.getParameters
        // type: IllegalArgumentException
        return 0;
    }

    public int EngineGetOutputSize(int P0)
    {
        // str: "cipher not initialised"
        // call: p41f9db06.getOutputSize
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f9ed39e2e
        // type: IllegalStateException
        return 0;
    }

    public AlgorithmParameters EngineGetParameters()
    {
        return default!;
    }

    public void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "cannot recognise parameters: "
        // call: StringBuilder.toString
        // call: InvalidAlgorithmParameterException.<init>
        // call: StringBuilder.append
        // call: pdc6b8bc5.engineInit
        // call: object.getClass
        // call: Type.getName
        // call: StringBuilder.<init>
        // type: InvalidAlgorithmParameterException
        // type: StringBuilder
    }

    public void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "cannot handle supplied parameter spec: "
        // call: pdc6b8bc5.engineInit
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: InvalidAlgorithmParameterException.getMessage
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "must be passed private EC key for decryption"
        // str: "must be passed EC key"
        // str: "must be passed public EC key for encryption"
        // call: p1fb7a8a1.mc2499d21
        // call: pa9682fb5.m07091bf1
        // call: pdc6b8bc5$pf0d24f46.reset
        // call: InvalidKeyException.<init>
        // call: p37c4833e.m02ea6360
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f9ed39e2e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f7f2db423
        // type: InvalidKeyException
    }

    public void EngineSetMode(string P0)
    {
        // str: "4de67ece50c1f605eb5ad02d243621b841bc5b0e23f9f057b566006d6d232575"
        // str: "can't support mode "
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: p89be9433.mb8a8247c
        // call: StringBuilder.append
        // call: string.equals
        // call: DecryptString.decryptString
        // call: StringBuilder.<init>
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public void EngineSetPadding(string P0)
    {
        // str: "NOPADDING"
        // str: "padding not available with IESCipher"
        // call: string.equals
        // call: p89be9433.mb8a8247c
        // call: NoSuchPaddingException.<init>
        // type: NoSuchPaddingException
    }

    public int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: pdc6b8bc5$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f7f2db423
        return 0;
    }

    public byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: pdc6b8bc5$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pdc6b8bc5.f7f2db423
        return default!;
    }

}
