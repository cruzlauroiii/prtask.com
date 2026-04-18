namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50_p8c5e459e : Pa68c9a50
{
    private PSSParameterSpec F0d818b20;
    private PSSParameterSpec F19092485;
    private PSSParameterSpec F73366177;
    private PSSParameterSpec F88493c5c;
    private PSSParameterSpec F8a66b503;

    private byte[] EngineGetEncoded()
    {
        // str: "b562869315beaf788a92b45278cbb41d12f8b504e96d7f916213316f721d46"
        // str: "28e1fcedcab95408482036264b2ec7dcdcf1a92fd6ca5830f558a0ccdbe527b29d005075"
        // call: pfa0321ce.getEncoded
        // call: MGF1ParameterSpec.getDigestAlgorithm
        // call: string.equals
        // call: p234a7530.<init>
        // call: p92e20001.m18da419b
        // call: PSSParameterSpec.getTrailerField
        // call: PSSParameterSpec.getMGFAlgorithm
        // call: pf391b73d.<init>
        // call: PSSParameterSpec.getDigestAlgorithm
        // call: DecryptString.decryptString
        // call: PSSParameterSpec.getSaltLength
        // call: PSSParameterSpec.getMGFParameters
        // call: pfa0321ce.<init>
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$p8c5e459e.f0d818b20
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // type: p234a7530
        // type: pf391b73d
        // type: pfa0321ce
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "X.509"
        // str: "ASN.1"
        // call: string.equalsIgnoreCase
        // call: pa68c9a50$p8c5e459e.engineGetEncoded
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "PSSParameterSpec required to initialise an PSS algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$p8c5e459e.f0d818b20
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "Not a valid PSS Parameter encoding."
        // str: "unknown mask generation function: "
        // str: "e6d6c1f92c12897f2ae866575e0de3fd297096ee2d541b322cd1f7966f5c9be8f3200f8b"
        // str: "e678680f5a703b84c877d89f0b3bab6ac3dd648b74515dbed673d58d2a79e93fe95809da"
        // call: pfa0321ce.m8bab0102
        // call: pfa0321ce.getMaskGenAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // call: pfa0321ce.getHashAlgorithm
        // call: p45eb53fe.mba8d3a36
        // call: PSSParameterSpec.getMGFAlgorithm
        // call: p234a7530.getParameters
        // call: p234a7530.m8bab0102
        // call: MGF1ParameterSpec.<init>
        // call: pfa0321ce.getSaltLength
        // call: System.Numerics.BigInteger.intValue
        // call: pfa0321ce.getTrailerField
        // call: PSSParameterSpec.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c
        // field: java.security.spec.PSSParameterSpec.DEFAULT
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$p8c5e459e.f0d818b20
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af
        // type: PSSParameterSpec
        // type: MGF1ParameterSpec
        // type: IOException
        // type: StringBuilder
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown parameter format "
        // str: "X.509"
        // call: pa68c9a50$p8c5e459e.isASN1FormatString
        // call: IOException.<init>
        // call: StringBuilder.<init>
        // call: pa68c9a50$p8c5e459e.engineInit
        // call: StringBuilder.append
        // call: string.equalsIgnoreCase
        // call: StringBuilder.toString
        // type: IOException
        // type: StringBuilder
    }

    private string EngineToString()
    {
        // str: "PSS Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to PSS parameters object."
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.pa68c9a50$p8c5e459e.f0d818b20
        // type: AlgorithmParameterSpec
        // type: PSSParameterSpec
        // type: InvalidParameterSpecException
        return default!;
    }

}
