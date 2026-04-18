namespace WillowMaze.Wasm.Decompiled;

public class P1af12dbc : DSAPrivateKey, Pc7effecb
{
    private static long Fa5bd55c3;
    private static long Fc6e1e520;
    private p99d12a64 F02e4e32e;
    private p99d12a64 F201da641;
    private p99d12a64 F33e9fcb7;
    private DSAParams F3eba2789;
    private System.Numerics.BigInteger F47baf48a;
    private p99d12a64 F7af59b21;
    private System.Numerics.BigInteger F83da7436;
    private System.Numerics.BigInteger F9dd4e461;
    private p99d12a64 Fa9a4e5f3;
    private DSAParams Fd3373b02;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: DSAParams.getG
        // call: p99d12a64.writeObject
        // call: ObjectOutputStream.writeObject
        // call: DSAParams.getQ
        // call: DSAParams.getP
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.fd3373b02
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f9dd4e461
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f201da641
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.readObject
        // call: DSAParameterSpec.<init>
        // call: p99d12a64.<init>
        // call: p99d12a64.readObject
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f201da641
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f9dd4e461
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.fd3373b02
        // type: DSAParameterSpec
        // type: p99d12a64
    }

    public bool Equals(object P0)
    {
        // call: DSAParams.getG
        // call: DSAPrivateKey.getParams
        // call: DSAParams.getQ
        // call: p1af12dbc.getParams
        // call: System.Numerics.BigInteger.equals
        // call: DSAParams.getP
        // call: DSAPrivateKey.getX
        // call: p1af12dbc.getX
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "DSA"
        return string.Empty;
    }

    public p0fd1bdf1 GetBagAttribute(p364bf33a P0)
    {
        // call: p99d12a64.getBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f201da641
        return default!;
    }

    public Enumeration GetBagAttributeKeys()
    {
        // call: p99d12a64.getBagAttributeKeys
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f201da641
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "2bd0ba20092650d41c6bcbf5fb342a2a602b7ad68d8d8df1f50b5ee99895b8"
        // call: DSAParams.getP
        // call: DSAParams.getQ
        // call: DSAParams.getG
        // call: p3db0d479.<init>
        // call: p234a7530.<init>
        // call: p1af12dbc.getX
        // call: pf391b73d.<init>
        // call: p811299f8.<init>
        // call: DecryptString.decryptString
        // call: p811299f8.getEncoded
        // field: p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.fd3373b02
        // type: p811299f8
        // type: p234a7530
        // type: p3db0d479
        // type: pf391b73d
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public DSAParams GetParams()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.fd3373b02
        return default!;
    }

    public System.Numerics.BigInteger GetX()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f9dd4e461
        return default!;
    }

    public int HashCode()
    {
        // call: System.Numerics.BigInteger.hashCode
        // call: p1af12dbc.getX
        // call: DSAParams.getQ
        // call: DSAParams.getG
        // call: p1af12dbc.getParams
        // call: DSAParams.getP
        return 0;
    }

    public void SetBagAttribute(p364bf33a P0, p0fd1bdf1 P1)
    {
        // call: p99d12a64.setBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1af12dbc.f201da641
    }

}
