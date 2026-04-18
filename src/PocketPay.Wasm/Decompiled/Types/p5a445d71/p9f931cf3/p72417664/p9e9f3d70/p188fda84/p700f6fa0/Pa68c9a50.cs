namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50 : AlgorithmParametersSpi
{
    private DHParameterSpec F09fb6946;
    private DHParameterSpec F0b4f3b2c;
    private DHParameterSpec F0d818b20;
    private DHParameterSpec F8c225222;
    private DHParameterSpec Fb9405064;

    private byte[] EngineGetEncoded()
    {
        // str: "Error encoding DHParameters"
        // str: "ea2ea3c8a4953021388d0e40da1f0d972160bb67cfda3c31666e6c5ad45532"
        // call: DHParameterSpec.getP
        // call: pef342a14.<init>
        // call: DecryptString.decryptString
        // call: pef342a14.getEncoded
        // call: Exception.<init>
        // call: DHParameterSpec.getG
        // call: DHParameterSpec.getL
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pa68c9a50.f0d818b20
        // type: Exception
        // type: pef342a14
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
        // call: pa68c9a50.localEngineGetParameterSpec
        // call: NullPointerException.<init>
        // type: NullPointerException
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "DHParameterSpec required to initialise a Diffie-Hellman algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pa68c9a50.f0d818b20
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "Not a valid DH Parameter encoding."
        // call: IOException.<init>
        // call: pef342a14.m8bab0102
        // call: pef342a14.getL
        // call: pef342a14.getP
        // call: pef342a14.getG
        // call: System.Numerics.BigInteger.intValue
        // call: DHParameterSpec.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pa68c9a50.f0d818b20
        // type: IOException
        // type: DHParameterSpec
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameter format "
        // call: StringBuilder.toString
        // call: pa68c9a50.engineInit
        // call: StringBuilder.<init>
        // call: pa68c9a50.isASN1FormatString
        // call: StringBuilder.append
        // call: IOException.<init>
        // type: IOException
        // type: StringBuilder
    }

    private string EngineToString()
    {
        // str: "Diffie-Hellman Parameters"
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
        // str: "unknown parameter spec passed to DH parameters object."
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pa68c9a50.f0d818b20
        // type: AlgorithmParameterSpec
        // type: DHParameterSpec
        // type: InvalidParameterSpecException
        return default!;
    }

}
