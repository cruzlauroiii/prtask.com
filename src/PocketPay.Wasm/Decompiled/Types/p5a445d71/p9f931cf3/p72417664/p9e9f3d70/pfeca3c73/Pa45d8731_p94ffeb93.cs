namespace WillowMaze.Wasm.Decompiled;

public class Pa45d8731_p94ffeb93 : Pcffc482e
{
    private RC2ParameterSpec F3f75a1f2;
    private RC2ParameterSpec F42050e3c;
    private RC2ParameterSpec F85745174;
    private RC2ParameterSpec Fb979c293;

    private AlgorithmParameters EngineGenerateParameters()
    {
        // str: "RC2"
        // call: Exception.<init>
        // call: Exception.getMessage
        // call: pa45d8731$p94ffeb93.createParametersInstance
        // call: AlgorithmParameters.init
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: IvParameterSpec.<init>
        // call: pa9682fb5.m07091bf1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa45d8731$p94ffeb93.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa45d8731$p94ffeb93.fb979c293
        // type: Exception
        // type: IvParameterSpec
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "No supported AlgorithmParameterSpec for RC2 parameter generation."
        // call: InvalidAlgorithmParameterException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa45d8731$p94ffeb93.fb979c293
        // type: InvalidAlgorithmParameterException
    }

}
