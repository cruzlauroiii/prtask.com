namespace WillowMaze.Wasm.Decompiled;

public class Pd7bf1aa6 : Pa80e639a, Peff7c557
{
    private p47b78e9d F08406a6e;
    private string F0d6f7c67;
    private int F0fc10154;
    private string F128a58a1;
    private p47b78e9d F13d56f7a;
    private int F154a9a98;
    private Type[] F18cc1005;
    private int F1e18ab02;
    private string F22979384;
    private int F2359ec32;
    private Type[] F2b6e75d1;
    private p47b78e9d F3f74b4e8;
    private p47b78e9d F4508232c;
    private int F47e838e0;
    private Type[] F503e7f14;
    private PBEParameterSpec F54a55195;
    private int F80269f47;
    private int F89acf998;
    private Type[] F9a952d37;
    private Type[] F9e0cde03;
    private pdd5da44e Fa014cfd4;
    private int Fa694c87d;
    private pdd5da44e Faebcbec4;
    private PBEParameterSpec Fb22d1d60;
    private int Fc10f7796;
    private pdd5da44e Fc4dcb379;
    private PBEParameterSpec Fd9d80f3c;
    private int Fe6f34574;
    private PBEParameterSpec Feb09b467;
    private p47b78e9d Fef4f475f;

    private int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output buffer too short for input."
        // call: ShortBufferException.<init>
        // call: p47b78e9d.reset
        // call: p47b78e9d.processBytes
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f08406a6e
        // type: ShortBufferException
        return 0;
    }

    private byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // call: pd7bf1aa6.engineUpdate
        // call: p47b78e9d.reset
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f08406a6e
        return default!;
    }

    private int EngineGetBlockSize()
    {
        return 0;
    }

    private byte[] EngineGetIV()
    {
        // call: pdd5da44e.getIV
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.fa014cfd4
        return default!;
    }

    private int EngineGetKeySize(Key P0)
    {
        // call: Key.getEncoded
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        // str: "Grainv1"
        // str: "ChaCha7539"
        // str: "HC"
        // str: "Grain"
        // call: string.substring
        // call: string.startsWith
        // call: pd7bf1aa6.createParametersInstance
        // call: AlgorithmParameters.init
        // call: StringBuilder.append
        // call: p47b78e9d.getAlgorithmName
        // call: string.indexOf
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pdd5da44e.getIV
        // call: IvParameterSpec.<init>
        // call: Exception.toString
        // call: Exception.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f0d6f7c67
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.feb09b467
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f20c904fb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.fa014cfd4
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f08406a6e
        // type: StringBuilder
        // type: IvParameterSpec
        // type: Exception
        return default!;
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "can't handle parameter "
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: InvalidAlgorithmParameterException.<init>
        // call: pd7bf1aa6.engineInit
        // call: StringBuilder.<init>
        // call: p6bf7077e.m0a78983b
        // call: AlgorithmParameters.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f18cc1005
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f20c904fb
        // type: StringBuilder
        // type: InvalidAlgorithmParameterException
    }

    private void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: InvalidKeyException.<init>
        // call: InvalidAlgorithmParameterException.getMessage
        // call: pd7bf1aa6.engineInit
        // type: InvalidKeyException
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "PBE requires PBE parameters to be set."
        // str: "Algorithm requires a PBE key"
        // str: " passed"
        // str: "unknown parameter type."
        // str: "Key for algorithm "
        // str: "no IV set when one expected"
        // str: " not suitable for symmetric enryption."
        // str: "unknown opmode "
        // call: p51ebc4fd.getParam
        // call: InvalidAlgorithmParameterException.<init>
        // call: Exception.getMessage
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: StringBuilder.toString
        // call: p94919be6.<init>
        // call: pa9682fb5.m07091bf1
        // call: p364bf33a.getId
        // call: Key.getEncoded
        // call: pb74cffe2.getSalt
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: InvalidParameterException.<init>
        // call: p47b78e9d.init
        // call: p51ebc4fd.getSalt
        // call: pdd5da44e.<init>
        // call: p51ebc4fd.getIterationCount
        // call: pb74cffe2.getIterationCount
        // call: InvalidKeyException.<init>
        // call: p51ebc4fd.getOID
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.feb09b467
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f0d6f7c67
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f47e838e0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.fa014cfd4
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.fa694c87d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f20c904fb
        // type: PBEParameterSpec
        // type: InvalidAlgorithmParameterException
        // type: StringBuilder
        // type: pdd5da44e
        // type: InvalidParameterException
        // type: InvalidKeyException
        // type: p94919be6
    }

    private void EngineSetMode(string P0)
    {
        // str: "can't support mode "
        // str: "7101c106c7a9a44e37fe2920ca50cc3d8db8962f700a64aef05fcb1eb9bcdfbf"
        // str: "ECB"
        // call: string.equals
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: string.equalsIgnoreCase
        // call: NoSuchAlgorithmException.<init>
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // type: StringBuilder
        // type: NoSuchAlgorithmException
    }

    private void EngineSetPadding(string P0)
    {
        // str: " unknown."
        // str: "Padding "
        // str: "NoPadding"
        // call: string.equalsIgnoreCase
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: NoSuchPaddingException.<init>
        // call: StringBuilder.append
        // type: NoSuchPaddingException
        // type: StringBuilder
    }

    private int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output buffer too short for input."
        // call: IllegalStateException.<init>
        // call: p96068848.getMessage
        // call: ShortBufferException.<init>
        // call: p47b78e9d.processBytes
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f08406a6e
        // type: ShortBufferException
        // type: IllegalStateException
        return 0;
    }

    private byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: p47b78e9d.processBytes
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pd7bf1aa6.f08406a6e
        return default!;
    }

}
