namespace WillowMaze.Wasm.Decompiled;

public class P798db05b_p33d3ae59 : P29bd365e
{
    private byte[] F24c382d9;
    private byte[] Fd6216b4f;
    private byte[] Ff0b53b2d;

    private byte[] EngineGetEncoded()
    {
        // str: "ASN.1"
        // call: p798db05b$p33d3ae59.engineGetEncoded
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "RAW"
        // call: System.arraycopy
        // call: p798db05b$p33d3ae59.isASN1FormatString
        // call: p9ae0536a.getEncoded
        // call: p9ae0536a.<init>
        // call: string.equals
        // call: p798db05b$p33d3ae59.engineGetEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p798db05b$p33d3ae59.ff0b53b2d
        // type: p9ae0536a
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "IvParameterSpec required to initialise a IV parameters algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // call: IvParameterSpec.getIV
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p798db05b$p33d3ae59.ff0b53b2d
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p798db05b$p33d3ae59.ff0b53b2d
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "RAW"
        // str: "Unknown parameters format in IV parameters object"
        // str: "ASN.1"
        // call: p9ae0536a.getIV
        // call: p9ae0536a.m8bab0102
        // call: p798db05b$p33d3ae59.engineInit
        // call: string.equals
        // call: IOException.<init>
        // type: IOException
    }

    private string EngineToString()
    {
        // str: "IDEA Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to IV parameters object."
        // call: IvParameterSpec.<init>
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p798db05b$p33d3ae59.ff0b53b2d
        // type: InvalidParameterSpecException
        // type: IvParameterSpec
        // type: AlgorithmParameterSpec
        return default!;
    }

}
