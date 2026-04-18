namespace WillowMaze.Wasm.Decompiled;

public class Pd7f2a5f9_p33d3ae59 : P29bd365e
{
    private p46a7aa58 F11f7d269;
    private p46a7aa58 F21ffce5b;
    private p46a7aa58 F9d2f8f9b;

    private byte[] EngineGetEncoded()
    {
        // str: "4a91c90fd1b5fa432bcd6ade7dcd4a64880350e6324be3cc2ea06e6bf4b18a"
        // str: "Oooops! "
        // call: DecryptString.decryptString
        // call: p46a7aa58.getEncoded
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IOException.toString
        // call: Exception.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pd7f2a5f9$p33d3ae59.f21ffce5b
        // type: Exception
        // type: StringBuilder
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // call: pd7f2a5f9$p33d3ae59.isASN1FormatString
        // call: pd7f2a5f9$p33d3ae59.engineGetEncoded
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "PBEParameterSpec required to initialise a PKCS12 PBE parameters algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // call: PBEParameterSpec.getIterationCount
        // call: PBEParameterSpec.getSalt
        // call: p46a7aa58.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pd7f2a5f9$p33d3ae59.f21ffce5b
        // type: InvalidParameterSpecException
        // type: p46a7aa58
    }

    private void EngineInit(byte[] P0)
    {
        // call: p301c7ed4.m89e75c46
        // call: p46a7aa58.m8bab0102
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pd7f2a5f9$p33d3ae59.f21ffce5b
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameters format in PKCS12 PBE parameters object"
        // call: pd7f2a5f9$p33d3ae59.isASN1FormatString
        // call: IOException.<init>
        // call: pd7f2a5f9$p33d3ae59.engineInit
        // type: IOException
    }

    private string EngineToString()
    {
        // str: "PKCS12 PBE Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to PKCS12 PBE parameters object."
        // call: p46a7aa58.getIterations
        // call: PBEParameterSpec.<init>
        // call: p46a7aa58.getIV
        // call: System.Numerics.BigInteger.intValue
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.pd7f2a5f9$p33d3ae59.f21ffce5b
        // type: InvalidParameterSpecException
        // type: AlgorithmParameterSpec
        // type: PBEParameterSpec
        return default!;
    }

}
