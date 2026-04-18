namespace WillowMaze.Wasm.Decompiled;

public class P4f5866f3_p94ffeb93 : Pcffc482e
{
    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "Noekeon"
        // call: Exception.<init>
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p4f5866f3$p94ffeb93.createParametersInstance
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: pa9682fb5.m07091bf1
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p4f5866f3$p94ffeb93.f7ddf32e1
        // type: IvParameterSpec
        // type: Exception
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for Noekeon parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
