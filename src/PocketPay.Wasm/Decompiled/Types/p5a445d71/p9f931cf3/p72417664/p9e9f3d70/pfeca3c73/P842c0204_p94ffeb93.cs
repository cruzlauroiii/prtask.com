namespace WillowMaze.Wasm.Decompiled;

public class P842c0204_p94ffeb93 : Pcffc482e
{
    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "DES"
        // call: Exception.<init>
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p842c0204$p94ffeb93.createParametersInstance
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: Exception.getMessage
        // call: pa9682fb5.m07091bf1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p842c0204$p94ffeb93.f7ddf32e1
        // type: Exception
        // type: IvParameterSpec
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for DES parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
