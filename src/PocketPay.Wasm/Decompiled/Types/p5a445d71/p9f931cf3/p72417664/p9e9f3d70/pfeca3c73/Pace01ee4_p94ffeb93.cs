namespace WillowMaze.Wasm.Decompiled;

public class Pace01ee4_p94ffeb93 : Pcffc482e
{
    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "SEED"
        // call: Exception.<init>
        // call: pa9682fb5.m07091bf1
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pace01ee4$p94ffeb93.createParametersInstance
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pace01ee4$p94ffeb93.f7ddf32e1
        // type: Exception
        // type: IvParameterSpec
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for SEED parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
