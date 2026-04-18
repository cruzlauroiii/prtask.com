namespace WillowMaze.Wasm.Decompiled;

public class P9d46b8e9 : P771f235f
{
    private int F02549460;
    private System.Security.Cryptography.RandomNumberGenerator F055604f4;
    private int F05b4ac16;
    private peccdefbd F21ffce5b;
    private peccdefbd F507a00da;
    private int F5177790a;
    private peccdefbd F648c0926;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private int Fd20da7f1;
    private System.Security.Cryptography.RandomNumberGenerator Fdfdeb977;

    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "DSA"
        // call: p47a1abc0.init
        // call: p08716e2c.<init>
        // call: peccdefbd.<init>
        // call: Exception.<init>
        // call: pa9682fb5.m07091bf1
        // call: p47a1abc0.<init>
        // call: p47a1abc0.generateParameters
        // call: p9d46b8e9.createParametersInstance
        // call: pe0946edd.getP
        // call: pe0946edd.getQ
        // call: pe0946edd.getG
        // call: DSAParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: pe65dc874.m7702ab0e
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p9d46b8e9.f21ffce5b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p9d46b8e9.f5177790a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p9d46b8e9.f7ddf32e1
        // type: p47a1abc0
        // type: Exception
        // type: DSAParameterSpec
        // type: peccdefbd
        // type: p08716e2c
        return default!;
    }

    private void EngineInit(int P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "strength must be from 512 - 3072"
        // str: "strength must be a multiple of 64 below 1024 bits."
        // str: "strength must be a multiple of 1024 above 1024 bits."
        // call: InvalidParameterException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p9d46b8e9.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p9d46b8e9.f5177790a
        // type: InvalidParameterException
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for DSA parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
