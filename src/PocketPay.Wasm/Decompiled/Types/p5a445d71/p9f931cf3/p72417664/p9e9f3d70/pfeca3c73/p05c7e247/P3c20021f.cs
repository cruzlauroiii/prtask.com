namespace WillowMaze.Wasm.Decompiled;

public class P3c20021f : P29bd365e
{
    private byte[] F3d6f7287;
    private byte[] F48f7e0dd;
    private byte[] Fa2c549ba;
    private byte[] Ff0b53b2d;
    private byte[] Ffca97462;

    private byte[] EngineGetEncoded()
    {
        // str: "ASN.1"
        // call: p3c20021f.engineGetEncoded
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "RAW"
        // call: string.equals
        // call: p3c20021f.engineGetEncoded
        // call: p3c20021f.isASN1FormatString
        // call: p6f0e511c.getEncoded
        // call: pff43b8de.md329fd77
        // call: p6f0e511c.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p3c20021f.ff0b53b2d
        // type: p6f0e511c
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "IvParameterSpec required to initialise a IV parameters algorithm parameters object"
        // call: IvParameterSpec.getIV
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p3c20021f.ff0b53b2d
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // call: p11b04310.getOctets
        // call: p301c7ed4.m89e75c46
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p3c20021f.ff0b53b2d
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "RAW"
        // str: "Unknown parameters format in IV parameters object"
        // str: "Exception decoding: "
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p3c20021f.isASN1FormatString
        // call: IOException.<init>
        // call: string.equals
        // call: StringBuilder.<init>
        // call: p301c7ed4.m89e75c46
        // call: p11b04310.getOctets
        // call: p3c20021f.engineInit
        // type: IOException
        // type: StringBuilder
    }

    private string EngineToString()
    {
        // str: "IV Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to IV parameters object."
        // call: InvalidParameterSpecException.<init>
        // call: IvParameterSpec.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p3c20021f.ff0b53b2d
        // type: IvParameterSpec
        // type: AlgorithmParameterSpec
        // type: InvalidParameterSpecException
        return default!;
    }

}
