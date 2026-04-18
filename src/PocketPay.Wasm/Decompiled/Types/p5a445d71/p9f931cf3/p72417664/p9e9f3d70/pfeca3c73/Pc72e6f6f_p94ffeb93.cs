namespace WillowMaze.Wasm.Decompiled;

public class Pc72e6f6f_p94ffeb93 : Pcffc482e
{
    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "CAST5"
        // call: pa9682fb5.m07091bf1
        // call: Exception.<init>
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pc72e6f6f$p94ffeb93.createParametersInstance
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pc72e6f6f$p94ffeb93.f7ddf32e1
        // type: IvParameterSpec
        // type: Exception
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for CAST5 parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
