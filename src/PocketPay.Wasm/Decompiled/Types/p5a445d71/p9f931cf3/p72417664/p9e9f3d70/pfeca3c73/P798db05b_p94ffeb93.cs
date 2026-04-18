namespace WillowMaze.Wasm.Decompiled;

public class P798db05b_p94ffeb93 : Pcffc482e
{
    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "IDEA"
        // call: pa9682fb5.m07091bf1
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p798db05b$p94ffeb93.createParametersInstance
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: Exception.<init>
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p798db05b$p94ffeb93.f7ddf32e1
        // type: Exception
        // type: IvParameterSpec
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for IDEA parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
