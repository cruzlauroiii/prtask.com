namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50 : AlgorithmParametersSpi
{
    private DSAParameterSpec F0d818b20;
    private DSAParameterSpec F1b3ea1a1;
    private DSAParameterSpec F616ecab3;
    private DSAParameterSpec Fe4a61ce6;

    private byte[] EngineGetEncoded()
    {
        // str: "2eb2de4db477e68fec3b38e9ca4d7e9f93ba67d8a96dc3d81316b6216b8557"
        // str: "Error encoding DSAParameters"
        // call: DSAParameterSpec.getQ
        // call: p3db0d479.<init>
        // call: DecryptString.decryptString
        // call: p3db0d479.getEncoded
        // call: DSAParameterSpec.getG
        // call: DSAParameterSpec.getP
        // call: Exception.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pa68c9a50.f0d818b20
        // type: p3db0d479
        // type: Exception
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // call: pa68c9a50.engineGetEncoded
        // call: pa68c9a50.isASN1FormatString
        return default!;
    }

    private AlgorithmParameterSpec EngineGetParameterSpec(Type P0)
    {
        // str: "argument to getParameterSpec must not be null"
        // call: NullPointerException.<init>
        // call: pa68c9a50.localEngineGetParameterSpec
        // type: NullPointerException
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "DSAParameterSpec required to initialise a DSA algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pa68c9a50.f0d818b20
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "Not a valid DSA Parameter encoding."
        // call: p301c7ed4.m89e75c46
        // call: p3db0d479.m8bab0102
        // call: p3db0d479.getP
        // call: p3db0d479.getQ
        // call: p3db0d479.getG
        // call: DSAParameterSpec.<init>
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pa68c9a50.f0d818b20
        // type: IOException
        // type: DSAParameterSpec
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "X.509"
        // str: "Unknown parameter format "
        // call: string.equalsIgnoreCase
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IOException.<init>
        // call: pa68c9a50.isASN1FormatString
        // call: pa68c9a50.engineInit
        // type: IOException
        // type: StringBuilder
    }

    private string EngineToString()
    {
        // str: "DSA Parameters"
        return string.Empty;
    }

    private bool IsASN1FormatString(string P0)
    {
        // str: "ASN.1"
        // call: string.equals
        return false;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to DSA parameters object."
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pa68c9a50.f0d818b20
        // type: InvalidParameterSpecException
        // type: DSAParameterSpec
        // type: AlgorithmParameterSpec
        return default!;
    }

}
