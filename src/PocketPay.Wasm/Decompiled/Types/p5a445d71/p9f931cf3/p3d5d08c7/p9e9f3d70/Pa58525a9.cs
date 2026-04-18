namespace WillowMaze.Wasm.Decompiled;

public class Pa58525a9 : DSAPublicKey
{
    private static long F19f85f89;
    private static long F29a47a14;
    private static long F313db123;
    private static long Fa048b623;
    private static long Fc6e1e520;
    private System.Numerics.BigInteger F41529076;
    private DSAParams F804dcaa0;
    private DSAParams Fba5e85e4;
    private DSAParams Fd3373b02;
    private System.Numerics.BigInteger Ff87951be;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.writeObject
        // call: DSAParams.getP
        // call: DSAParams.getG
        // call: DSAParams.getQ
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.fd3373b02
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.f41529076
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: DSAParameterSpec.<init>
        // call: ObjectInputStream.readObject
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.fd3373b02
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.f41529076
        // type: DSAParameterSpec
    }

    private bool Mf4c8c5ca(p0fd1bdf1 P0)
    {
        // call: p4631e342.equals
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        return false;
    }

    public bool Equals(object P0)
    {
        // call: pa58525a9.getParams
        // call: System.Numerics.BigInteger.equals
        // call: DSAParams.getG
        // call: DSAParams.getP
        // call: DSAParams.getQ
        // call: DSAPublicKey.getParams
        // call: pa58525a9.getY
        // call: DSAPublicKey.getY
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "DSA"
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // str: "ed8944d36687dbf1c3a19e2586de1130a536d4bc9e522fb4bae43195a682a6"
        // call: DecryptString.decryptString
        // call: p234a7530.<init>
        // call: pf391b73d.<init>
        // call: p3cdccfc9.<init>
        // call: DSAParams.getP
        // call: DSAParams.getQ
        // call: DSAParams.getG
        // call: p3db0d479.<init>
        // call: p3cdccfc9.getEncoded
        // field: p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.f41529076
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.fd3373b02
        // type: p3cdccfc9
        // type: p234a7530
        // type: pf391b73d
        // type: p3db0d479
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public DSAParams GetParams()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.fd3373b02
        return default!;
    }

    public System.Numerics.BigInteger GetY()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa58525a9.f41529076
        return default!;
    }

    public int HashCode()
    {
        // call: pa58525a9.getY
        // call: pa58525a9.getParams
        // call: DSAParams.getG
        // call: System.Numerics.BigInteger.hashCode
        // call: DSAParams.getQ
        // call: DSAParams.getP
        return 0;
    }

    public string ToString()
    {
        // str: "DSA Public Key"
        // str: "            y: "
        // call: StringBuilder.append
        // call: pa58525a9.getY
        // call: System.Numerics.BigInteger.toString
        // call: p89be9433.m2295b6f1
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        return string.Empty;
    }

}
