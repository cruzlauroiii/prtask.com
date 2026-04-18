namespace WillowMaze.Wasm.Decompiled;

public class Pa2e57f20_p33d3ae59 : P29bd365e
{
    private p8afe544a F0767668d;
    private p8afe544a F12f0b33d;
    private p8afe544a F21ffce5b;
    private p8afe544a Fdace7878;

    private byte[] EngineGetEncoded()
    {
        // str: "Oooops! "
        // str: "b0b09f10913f129cc53176c3d60f8bc68e715e5a8d454f53d13778b5ee2af1"
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: p8afe544a.getEncoded
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: IOException.toString
        // call: Exception.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa2e57f20$p33d3ae59.f21ffce5b
        // type: Exception
        // type: StringBuilder
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // call: pa2e57f20$p33d3ae59.isASN1FormatString
        // call: pa2e57f20$p33d3ae59.engineGetEncoded
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "PBEParameterSpec required to initialise a PBKDF2 PBE parameters algorithm parameters object"
        // call: p8afe544a.<init>
        // call: InvalidParameterSpecException.<init>
        // call: PBEParameterSpec.getSalt
        // call: PBEParameterSpec.getIterationCount
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa2e57f20$p33d3ae59.f21ffce5b
        // type: p8afe544a
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // call: p8afe544a.m8bab0102
        // call: p301c7ed4.m89e75c46
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa2e57f20$p33d3ae59.f21ffce5b
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameters format in PBKDF2 parameters object"
        // call: pa2e57f20$p33d3ae59.isASN1FormatString
        // call: IOException.<init>
        // call: pa2e57f20$p33d3ae59.engineInit
        // type: IOException
    }

    private string EngineToString()
    {
        // str: "PBKDF2 Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to PBKDF2 PBE parameters object."
        // call: PBEParameterSpec.<init>
        // call: System.Numerics.BigInteger.intValue
        // call: InvalidParameterSpecException.<init>
        // call: p8afe544a.getIterationCount
        // call: p8afe544a.getSalt
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pa2e57f20$p33d3ae59.f21ffce5b
        // type: PBEParameterSpec
        // type: InvalidParameterSpecException
        // type: AlgorithmParameterSpec
        return default!;
    }

}
