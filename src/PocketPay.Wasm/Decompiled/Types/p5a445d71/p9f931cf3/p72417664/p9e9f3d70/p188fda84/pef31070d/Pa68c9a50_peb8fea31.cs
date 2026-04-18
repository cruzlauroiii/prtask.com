namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50_peb8fea31 : Pa68c9a50
{
    private OAEPParameterSpec F0d818b20;
    private OAEPParameterSpec F45356a0f;
    private OAEPParameterSpec F8d26b63e;
    private OAEPParameterSpec F99998930;

    private byte[] EngineGetEncoded()
    {
        // str: "Error encoding OAEPParameters"
        // str: "28079f37ffc342da423f970c7912f49ddfbcec2ea7a71c1ecacc7c5e327faa"
        // call: p92e20001.m18da419b
        // call: p234a7530.<init>
        // call: OAEPParameterSpec.getMGFParameters
        // call: Exception.<init>
        // call: OAEPParameterSpec.getDigestAlgorithm
        // call: PSource$PSpecified.getValue
        // call: p6f0e511c.<init>
        // call: p3dfcf319.<init>
        // call: DecryptString.decryptString
        // call: p3dfcf319.getEncoded
        // call: OAEPParameterSpec.getPSource
        // call: MGF1ParameterSpec.getDigestAlgorithm
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$peb8fea31.f0d818b20
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f477b5532
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c
        // type: p234a7530
        // type: p6f0e511c
        // type: Exception
        // type: p3dfcf319
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "X.509"
        // call: pa68c9a50$peb8fea31.isASN1FormatString
        // call: pa68c9a50$peb8fea31.engineGetEncoded
        // call: string.equalsIgnoreCase
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "OAEPParameterSpec required to initialise an OAEP algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$peb8fea31.f0d818b20
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "Not a valid OAEP Parameter encoding."
        // str: "unknown mask generation function: "
        // call: IOException.<init>
        // call: p3dfcf319.m8bab0102
        // call: p3dfcf319.getMaskGenAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: p3dfcf319.getHashAlgorithm
        // call: p45eb53fe.mba8d3a36
        // call: OAEPParameterSpec.getMGFAlgorithm
        // call: p234a7530.getParameters
        // call: p234a7530.m8bab0102
        // call: MGF1ParameterSpec.<init>
        // call: p3dfcf319.getPSourceAlgorithm
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: PSource$PSpecified.<init>
        // call: OAEPParameterSpec.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c
        // field: javax.crypto.spec.OAEPParameterSpec.DEFAULT
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$peb8fea31.f0d818b20
        // type: IOException
        // type: OAEPParameterSpec
        // type: MGF1ParameterSpec
        // type: PSource$PSpecified
        // type: StringBuilder
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "X.509"
        // str: "ASN.1"
        // str: "Unknown parameter format "
        // call: StringBuilder.<init>
        // call: string.equalsIgnoreCase
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: pa68c9a50$peb8fea31.engineInit
        // call: IOException.<init>
        // type: StringBuilder
        // type: IOException
    }

    private string EngineToString()
    {
        // str: "OAEP Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to OAEP parameters object."
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$peb8fea31.f0d818b20
        // type: OAEPParameterSpec
        // type: InvalidParameterSpecException
        // type: AlgorithmParameterSpec
        return default!;
    }

}
