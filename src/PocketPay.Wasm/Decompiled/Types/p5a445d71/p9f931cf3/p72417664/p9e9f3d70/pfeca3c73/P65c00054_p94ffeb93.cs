namespace WillowMaze.Wasm.Decompiled;

public class P65c00054_p94ffeb93 : Pcffc482e
{
    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "SM4"
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: p65c00054$p94ffeb93.createParametersInstance
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: Exception.<init>
        // call: pa9682fb5.m07091bf1
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p65c00054$p94ffeb93.f7ddf32e1
        // type: IvParameterSpec
        // type: Exception
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for SM4 parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
