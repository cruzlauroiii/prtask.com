namespace WillowMaze.Wasm.Decompiled;

public class P1f409e46_p33d3ae59 : P29bd365e
{
    private pf8f35d1f F21ffce5b;
    private pf8f35d1f F73611e69;
    private pf8f35d1f F864acd27;
    private pf8f35d1f Fa85433cc;

    private byte[] EngineGetEncoded()
    {
        // str: "Oooops! "
        // str: "a41afda3df2a3abce12ee4e159ece504ff99753847686ff442c913799f45eb"
        // call: StringBuilder.append
        // call: IOException.toString
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: pf8f35d1f.getEncoded
        // call: StringBuilder.<init>
        // call: Exception.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p1f409e46$p33d3ae59.f21ffce5b
        // type: Exception
        // type: StringBuilder
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // call: p1f409e46$p33d3ae59.isASN1FormatString
        // call: p1f409e46$p33d3ae59.engineGetEncoded
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "PBEParameterSpec required to initialise a PBKDF1 PBE parameters algorithm parameters object"
        // call: pf8f35d1f.<init>
        // call: PBEParameterSpec.getSalt
        // call: InvalidParameterSpecException.<init>
        // call: PBEParameterSpec.getIterationCount
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p1f409e46$p33d3ae59.f21ffce5b
        // type: pf8f35d1f
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // call: pf8f35d1f.m8bab0102
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p1f409e46$p33d3ae59.f21ffce5b
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameters format in PBKDF2 parameters object"
        // call: p1f409e46$p33d3ae59.engineInit
        // call: p1f409e46$p33d3ae59.isASN1FormatString
        // call: IOException.<init>
        // type: IOException
    }

    private string EngineToString()
    {
        // str: "PBKDF1 Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to PBKDF1 PBE parameters object."
        // call: System.Numerics.BigInteger.intValue
        // call: PBEParameterSpec.<init>
        // call: pf8f35d1f.getIterationCount
        // call: InvalidParameterSpecException.<init>
        // call: pf8f35d1f.getSalt
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p1f409e46$p33d3ae59.f21ffce5b
        // type: AlgorithmParameterSpec
        // type: PBEParameterSpec
        // type: InvalidParameterSpecException
        return default!;
    }

}
