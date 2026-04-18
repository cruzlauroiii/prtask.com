namespace WillowMaze.Wasm.Decompiled;

public class Pc7eced35 : CipherSpi
{
    private System.Security.Cryptography.RandomNumberGenerator F03338fcb;
    private AlgorithmParameters F129a3abe;
    private readonly pb3b7fb02 F198ca2a6;
    private bool F1a980786;
    private pdd952c9d F1c094ab4;
    private pdd952c9d F30f21b61;
    private AlgorithmParameters F3584fcc6;
    private pcfffbc4a F3c6e0b8a;
    private int F47e838e0;
    private int F55b42e9c;
    private AlgorithmParameters F58163324;
    private MemoryStream F5ace44c2;
    private p8b9ea2ac F6977e73b;
    private pcfffbc4a F753bb310;
    private bool F7a5f093a;
    private bool F7be14ee9;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private MemoryStream F7f2db423;
    private MemoryStream F7facfe20;
    private int F8304832d;
    private MemoryStream F8dac63ae;
    private bool F90c2a945;
    private pcfffbc4a F90d576eb;
    private readonly pb3b7fb02 F95a56826;
    private p8b9ea2ac F9b5ff6e0;
    private int F9ed39e2e;
    private p8b9ea2ac Fad1943a9;
    private int Fc6199611;
    private AlgorithmParameters Fc86dfd3b;
    private readonly pb3b7fb02 Fcce6253e;
    private int Fcd61488b;
    private pcfffbc4a Fd021a4b6;
    private pcfffbc4a Fd821b60a;
    private readonly pb3b7fb02 Fd8658d3d;
    private pcfffbc4a Fdfafde64;
    private pcfffbc4a Fe07341c2;
    private int Ffa47b2cf;
    private pdd952c9d Ffb826d36;
    private bool Ffd491d8b;
    private readonly pb3b7fb02 Ffde5d67b;

    public int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: System.arraycopy
        // call: pc7eced35.engineDoFinal
        return 0;
    }

    public byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // str: "cipher not initialised"
        // str: "unable to process block"
        // call: MemoryStream.toByteArray
        // call: IllegalStateException.<init>
        // call: pdd952c9d.getCipherKeySize
        // call: p56a617c5.<init>
        // call: p8b9ea2ac.init
        // call: p8b9ea2ac.processBlock
        // call: pdd952c9d.getEncodingV
        // call: pdd952c9d.getNonce
        // call: pec7a0e67.<init>
        // call: MemoryStream.write
        // call: pdd952c9d.getMacKeySize
        // call: pdd952c9d.getDerivationV
        // call: pdd5da44e.<init>
        // call: pae87d463.<init>
        // call: p2c69f81a.init
        // call: p2c69f81a.<init>
        // call: p4760c269.<init>
        // call: p3451b390.<init>
        // call: p1235ff36.getParameters
        // call: MemoryStream.reset
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7f2db423
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f753bb310
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f9ed39e2e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f30f21b61
        // type: pec7a0e67
        // type: pdd5da44e
        // type: p2c69f81a
        // type: pc7eced35$1
        // type: p56a617c5
        // type: p3451b390
        // type: p4760c269
        // type: IllegalStateException
        // type: pae87d463
        return default!;
    }

    public int EngineGetBlockSize()
    {
        // call: p66d30ee8.getBlockSize
        // call: p8b9ea2ac.getCipher
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.fad1943a9
        return 0;
    }

    public byte[] EngineGetIV()
    {
        // call: pdd952c9d.getNonce
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f30f21b61
        return default!;
    }

    public int EngineGetKeySize(Key P0)
    {
        // str: "not an EC key"
        // call: IllegalArgumentException.<init>
        // call: p835df581.getCurve
        // call: pa827ecfa.getFieldSize
        // call: pc525de4e.getParameters
        // type: IllegalArgumentException
        return 0;
    }

    public int EngineGetOutputSize(int P0)
    {
        // str: "cipher not initialised"
        // call: pa827ecfa.getFieldSize
        // call: p1235ff36.getParameters
        // call: p8b9ea2ac.getMac
        // call: p8b9ea2ac.getCipher
        // call: p66d30ee8.getOutputSize
        // call: MemoryStream.size
        // call: IllegalStateException.<init>
        // call: p1748c064.getMacSize
        // call: p21c2eb74.getCurve
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f9ed39e2e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7f2db423
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f753bb310
        // type: IllegalStateException
        return 0;
    }

    public AlgorithmParameters EngineGetParameters()
    {
        // str: "IES"
        // call: pb3b7fb02.createAlgorithmParameters
        // call: AlgorithmParameters.init
        // call: Exception.toString
        // call: Exception.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.ffde5d67b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f58163324
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f30f21b61
        // type: Exception
        return default!;
    }

    public void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "cannot recognise parameters: "
        // call: Exception.toString
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pc7eced35.engineInit
        // call: InvalidAlgorithmParameterException.<init>
        // call: StringBuilder.append
        // call: AlgorithmParameters.getParameterSpec
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f58163324
        // type: InvalidAlgorithmParameterException
        // type: StringBuilder
        // type: pdd952c9d
    }

    public void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "cannot handle supplied parameter spec: "
        // call: StringBuilder.append
        // call: pc7eced35.engineInit
        // call: InvalidAlgorithmParameterException.getMessage
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "must be passed IES parameters"
        // str: "NONCE in IES Parameters needs to be "
        // str: "must be passed recipient's private EC key for decryption"
        // str: "must be passed recipient's public EC key for encryption"
        // str: " bytes long"
        // str: "must be passed EC key"
        // call: InvalidAlgorithmParameterException.<init>
        // call: p8b9ea2ac.getCipher
        // call: p37c4833e.m02ea6360
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p1fb7a8a1.mc2499d21
        // call: StringBuilder.append
        // call: MemoryStream.reset
        // call: pdd952c9d.getNonce
        // call: pc1b7c67f.getPublic
        // call: InvalidKeyException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pc1b7c67f.getPrivate
        // call: p67f289ed.m5edb6578
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f47e838e0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f753bb310
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f30f21b61
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.fad1943a9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7f2db423
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f9ed39e2e
        // type: StringBuilder
        // type: InvalidKeyException
        // type: InvalidAlgorithmParameterException
    }

    public void EngineSetMode(string P0)
    {
        // str: "DHAES"
        // str: "154652ccfb5fbff153f082c3cc5d3572c739915ecbe905559772e6f58cc8a93c"
        // str: "can't support mode "
        // call: p89be9433.mb8a8247c
        // call: string.equals
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7be14ee9
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public void EngineSetPadding(string P0)
    {
        // str: "padding not available with IESCipher"
        // str: "PKCS5PADDING"
        // str: "PKCS7PADDING"
        // str: "NOPADDING"
        // call: string.equals
        // call: p89be9433.mb8a8247c
        // call: NoSuchPaddingException.<init>
        // type: NoSuchPaddingException
    }

    public int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7f2db423
        return 0;
    }

    public byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: MemoryStream.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35.f7f2db423
        return default!;
    }

}
