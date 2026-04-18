namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50 : AlgorithmParametersSpi
{
    private string F1416d8f3;
    private ECParameterSpec F8c07bf84;
    private string Fa0145593;
    private string Fa7746492;
    private ECParameterSpec Faf4062b5;
    private ECParameterSpec Fcf903549;
    private string Fd1bf3f8b;
    private ECParameterSpec Fe3249867;

    private byte[] EngineGetEncoded()
    {
        // str: "ASN.1"
        // call: pa68c9a50.engineGetEncoded
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "Unknown parameters format in AlgorithmParameters object: "
        // call: StringBuilder.toString
        // call: p835df581.getH
        // call: p835df581.getSeed
        // call: p835df581.getCurve
        // call: pa68c9a50.isASN1FormatString
        // call: StringBuilder.append
        // call: p35e46fcb.<init>
        // call: pf1040019.mce32677e
        // call: p835df581.getG
        // call: p15be22c4.<init>
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: p37c4833e.m9a2b7f82
        // call: p713357f2.<init>
        // call: p835df581.getN
        // call: p15be22c4.getEncoded
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fd1bf3f8b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fcf903549
        // type: p713357f2
        // type: p35e46fcb
        // type: p15be22c4
        // type: StringBuilder
        // type: IOException
        return default!;
    }

    private AlgorithmParameterSpec EngineGetParameterSpec(Type P0)
    {
        // str: "EC AlgorithmParameters cannot convert to "
        // call: p364bf33a.getId
        // call: StringBuilder.toString
        // call: ECGenParameterSpec.<init>
        // call: p37c4833e.m9a2b7f82
        // call: InvalidParameterSpecException.<init>
        // call: StringBuilder.append
        // call: pf1040019.mce32677e
        // call: Type.getName
        // call: StringBuilder.<init>
        // call: Type.isAssignableFrom
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fcf903549
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fd1bf3f8b
        // type: ECGenParameterSpec
        // type: InvalidParameterSpecException
        // type: StringBuilder
        // type: AlgorithmParameterSpec
        // type: ECParameterSpec
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "AlgorithmParameterSpec class not recognized: "
        // str: "EC curve name not recognized: "
        // call: System.Numerics.BigInteger.valueOf
        // call: StringBuilder.toString
        // call: ECParameterSpec.getGenerator
        // call: InvalidParameterSpecException.<init>
        // call: pf1040019.m96bcaeb3
        // call: ECGenParameterSpec.getName
        // call: p1fb7a8a1.m3c6b69a4
        // call: object.getClass
        // call: p698f972d.<init>
        // call: StringBuilder.<init>
        // call: p698f972d.getName
        // call: Type.getName
        // call: ECParameterSpec.getCurve
        // call: ECParameterSpec.getOrder
        // call: StringBuilder.append
        // call: ECParameterSpec.getCofactor
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fcf903549
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fd1bf3f8b
        // type: p698f972d
        // type: StringBuilder
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "ASN.1"
        // call: pa68c9a50.engineInit
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "Unknown encoded parameters format in AlgorithmParameters object: "
        // call: pf1040019.m4ed3e6a2
        // call: p364bf33a.m8bab0102
        // call: p15be22c4.isNamedCurve
        // call: p15be22c4.m8bab0102
        // call: StringBuilder.append
        // call: p625027bb.m32132c89
        // call: p364bf33a.getId
        // call: p15be22c4.getParameters
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: pf1040019.m96bcaeb3
        // call: pa68c9a50.isASN1FormatString
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fd1bf3f8b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pa68c9a50.fcf903549
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        // type: StringBuilder
        // type: IOException
    }

    private string EngineToString()
    {
        // str: "EC Parameters"
        return string.Empty;
    }

    private bool IsASN1FormatString(string P0)
    {
        // str: "ASN.1"
        // call: string.equals
        return false;
    }

}
