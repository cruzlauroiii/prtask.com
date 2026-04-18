namespace WillowMaze.Wasm.Decompiled;

public class P730f208f : DHPrivateKey, Pc7effecb
{
    private static long F72ef40d9;
    private static long Fc6e1e520;
    private pc7effecb F0057a3ca;
    private pc7effecb F201da641;
    private pc7effecb F2ac02125;
    private p811299f8 F2e302d38;
    private DHParameterSpec F5aecd571;
    private pc7effecb F7300bd12;
    private System.Numerics.BigInteger F9dd4e461;
    private System.Numerics.BigInteger Fac65b63a;
    private p811299f8 Fcaf9b6b9;
    private DHParameterSpec Fcfa06534;
    private p811299f8 Fd7123f3a;
    private pc7effecb Fffdb18d2;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: DHParameterSpec.getP
        // call: ObjectOutputStream.writeInt
        // call: ObjectOutputStream.writeObject
        // call: p730f208f.getX
        // call: DHParameterSpec.getL
        // call: DHParameterSpec.getG
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f5aecd571
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: DHParameterSpec.<init>
        // call: ObjectInputStream.readObject
        // call: ObjectInputStream.readInt
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f5aecd571
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f9dd4e461
        // type: DHParameterSpec
    }

    public string GetAlgorithm()
    {
        // str: "DH"
        return string.Empty;
    }

    public p0fd1bdf1 GetBagAttribute(p364bf33a P0)
    {
        // call: pc7effecb.getBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f201da641
        return default!;
    }

    public Enumeration GetBagAttributeKeys()
    {
        // call: pc7effecb.getBagAttributeKeys
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f201da641
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "db5bbaf02065f0c227cee15161d8a8900f1584bc546221ed6fdddb1cb6c6b4"
        // call: DHParameterSpec.getP
        // call: DHParameterSpec.getG
        // call: DHParameterSpec.getL
        // call: pef342a14.<init>
        // call: p234a7530.<init>
        // call: p730f208f.getX
        // call: pf391b73d.<init>
        // call: p811299f8.<init>
        // call: p811299f8.getEncoded
        // call: DecryptString.decryptString
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.fcaf9b6b9
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f5aecd571
        // type: p811299f8
        // type: p234a7530
        // type: pef342a14
        // type: pf391b73d
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public DHParameterSpec GetParams()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f5aecd571
        return default!;
    }

    public System.Numerics.BigInteger GetX()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f9dd4e461
        return default!;
    }

    public void SetBagAttribute(p364bf33a P0, p0fd1bdf1 P1)
    {
        // call: pc7effecb.setBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p730f208f.f201da641
    }

}
