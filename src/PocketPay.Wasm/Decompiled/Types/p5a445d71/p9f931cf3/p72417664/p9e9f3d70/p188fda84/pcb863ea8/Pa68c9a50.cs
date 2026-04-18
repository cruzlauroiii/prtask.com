namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50 : P29bd365e
{
    private pdcabce2f F0d818b20;
    private pdcabce2f F75446da4;
    private pdcabce2f F9aa5da55;
    private pdcabce2f Fdfe562f3;
    private pdcabce2f Fef35410d;

    private byte[] EngineGetEncoded()
    {
        // str: "f7c82bf29591f3d2dae2d8b86825d9bf7669b54cd879411ffa3ed9ba582986"
        // str: "Error encoding ElGamalParameters"
        // call: p524aa06f.<init>
        // call: DecryptString.decryptString
        // call: p524aa06f.getEncoded
        // call: Exception.<init>
        // call: pdcabce2f.getG
        // call: pdcabce2f.getP
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pa68c9a50.f0d818b20
        // type: p524aa06f
        // type: Exception
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "X.509"
        // call: pa68c9a50.isASN1FormatString
        // call: pa68c9a50.engineGetEncoded
        // call: string.equalsIgnoreCase
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "DHParameterSpec required to initialise a ElGamal algorithm parameters object"
        // call: DHParameterSpec.getP
        // call: DHParameterSpec.getG
        // call: pdcabce2f.<init>
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pa68c9a50.f0d818b20
        // type: InvalidParameterSpecException
        // type: pdcabce2f
    }

    private void EngineInit(byte[] P0)
    {
        // str: "Not a valid ElGamal Parameter encoding."
        // call: IOException.<init>
        // call: p301c7ed4.m89e75c46
        // call: p524aa06f.m8bab0102
        // call: p524aa06f.getP
        // call: p524aa06f.getG
        // call: pdcabce2f.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pa68c9a50.f0d818b20
        // type: IOException
        // type: pdcabce2f
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameter format "
        // str: "X.509"
        // call: IOException.<init>
        // call: pa68c9a50.isASN1FormatString
        // call: string.equalsIgnoreCase
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: pa68c9a50.engineInit
        // call: StringBuilder.append
        // type: IOException
        // type: StringBuilder
    }

    private string EngineToString()
    {
        // str: "ElGamal Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to ElGamal parameters object."
        // call: InvalidParameterSpecException.<init>
        // call: pdcabce2f.getP
        // call: DHParameterSpec.<init>
        // call: pdcabce2f.getG
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pcb863ea8.pa68c9a50.f0d818b20
        // type: InvalidParameterSpecException
        // type: AlgorithmParameterSpec
        // type: DHParameterSpec
        // type: pdcabce2f
        return default!;
    }

}
