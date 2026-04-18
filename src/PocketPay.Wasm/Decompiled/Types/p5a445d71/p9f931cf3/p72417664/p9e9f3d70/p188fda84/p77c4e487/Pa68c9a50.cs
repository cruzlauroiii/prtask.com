namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50 : AlgorithmParametersSpi
{
    private p6b825a8d F0d818b20;
    private p6b825a8d F23f9d5cb;
    private p6b825a8d F5dd8ce7b;
    private p6b825a8d F8ec363ae;

    private byte[] EngineGetEncoded()
    {
        // str: "Error encoding GOST3410Parameters"
        // str: "20bc8bacc03ddb1857d80dc0c042ae4fbfc14e8d92b8475226ac07a9170eca"
        // call: p364bf33a.<init>
        // call: p6b825a8d.getDigestParamSetOID
        // call: p3d5f6347.<init>
        // call: DecryptString.decryptString
        // call: p3d5f6347.getEncoded
        // call: p6b825a8d.getEncryptionParamSetOID
        // call: Exception.<init>
        // call: p6b825a8d.getPublicKeyParamSetOID
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pa68c9a50.f0d818b20
        // type: p364bf33a
        // type: Exception
        // type: p3d5f6347
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "X.509"
        // call: string.equalsIgnoreCase
        // call: pa68c9a50.isASN1FormatString
        // call: pa68c9a50.engineGetEncoded
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
        // str: "GOST3410ParameterSpec required to initialise a GOST3410 algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pa68c9a50.f0d818b20
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "Not a valid GOST3410 Parameter encoding."
        // call: p301c7ed4.m89e75c46
        // call: p3d5f6347.m8bab0102
        // call: p6b825a8d.md6c1e629
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pa68c9a50.f0d818b20
        // type: IOException
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameter format "
        // str: "X.509"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: string.equalsIgnoreCase
        // call: pa68c9a50.engineInit
        // call: IOException.<init>
        // call: pa68c9a50.isASN1FormatString
        // type: IOException
        // type: StringBuilder
    }

    private string EngineToString()
    {
        // str: "GOST3410 Parameters"
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
        // str: "unknown parameter spec passed to GOST3410 parameters object."
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.pa68c9a50.f0d818b20
        // type: AlgorithmParameterSpec
        // type: p5e745417
        // type: InvalidParameterSpecException
        return default!;
    }

}
