namespace WillowMaze.Wasm.Decompiled;

public class P8ffa3299 : DSAPrivateKey, Pc7effecb
{
    private static long F2c925984;
    private static long F3bf868df;
    private static long F5ee71930;
    private static long F6ea58271;
    private static long Fc6e1e520;
    private p99d12a64 F1626caa0;
    private p99d12a64 F201da641;
    private DSAParams F291f59b7;
    private System.Numerics.BigInteger F34494b9b;
    private System.Numerics.BigInteger F3f5359d4;
    private System.Numerics.BigInteger F46dbecc5;
    private p99d12a64 F4cd7ae60;
    private DSAParams F6e95014e;
    private p99d12a64 F7421d802;
    private DSAParams F759175d7;
    private System.Numerics.BigInteger F9dd4e461;
    private System.Numerics.BigInteger Fa5efeb4f;
    private p99d12a64 Fbc14c181;
    private DSAParams Fd3373b02;
    private DSAParams Ffc2465c1;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.defaultWriteObject
        // call: DSAParams.getG
        // call: DSAParams.getQ
        // call: ObjectOutputStream.writeObject
        // call: DSAParams.getP
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.fd3373b02
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.readObject
        // call: DSAParameterSpec.<init>
        // call: ObjectInputStream.defaultReadObject
        // call: p99d12a64.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.fd3373b02
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.f201da641
        // type: DSAParameterSpec
        // type: p99d12a64
    }

    public bool Equals(object P0)
    {
        // call: p8ffa3299.getParams
        // call: DSAPrivateKey.getParams
        // call: System.Numerics.BigInteger.equals
        // call: DSAParams.getQ
        // call: DSAPrivateKey.getX
        // call: DSAParams.getG
        // call: p8ffa3299.getX
        // call: DSAParams.getP
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
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.f201da641
        return default!;
    }

    public Enumeration GetBagAttributeKeys()
    {
        // call: p99d12a64.getBagAttributeKeys
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.f201da641
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: DSAParams.getG
        // call: p8ffa3299.getX
        // call: p234a7530.<init>
        // call: p3db0d479.<init>
        // call: p58ac1d27.m28fa3698
        // call: DSAParams.getQ
        // call: p3db0d479.toASN1Primitive
        // call: pf391b73d.<init>
        // call: DSAParams.getP
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.fd3373b02
        // field: p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9
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
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.fd3373b02
        return default!;
    }

    public System.Numerics.BigInteger GetX()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.f9dd4e461
        return default!;
    }

    public int HashCode()
    {
        // call: System.Numerics.BigInteger.hashCode
        // call: DSAParams.getQ
        // call: p8ffa3299.getParams
        // call: DSAParams.getG
        // call: DSAParams.getP
        // call: p8ffa3299.getX
        return 0;
    }

    public void SetBagAttribute(p364bf33a P0, p0fd1bdf1 P1)
    {
        // call: p99d12a64.setBagAttribute
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.f201da641
    }

    public string ToString()
    {
        // str: "            Y: "
        // str: "DSA Private Key ["
        // str: "]"
        // call: p8ffa3299.getParams
        // call: StringBuilder.append
        // call: DSAParams.getP
        // call: p89be9433.m2295b6f1
        // call: pff72be26.m718ba5d4
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: System.Numerics.BigInteger.modPow
        // call: System.Numerics.BigInteger.toString
        // call: DSAParams.getG
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.p8ffa3299.f9dd4e461
        // type: StringBuilder
        return string.Empty;
    }

}
