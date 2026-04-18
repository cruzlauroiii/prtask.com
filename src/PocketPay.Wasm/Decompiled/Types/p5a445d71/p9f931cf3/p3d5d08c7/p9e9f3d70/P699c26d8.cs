namespace WillowMaze.Wasm.Decompiled;

public class P699c26d8 : ECPrivateKey, P5eff85bc, Pc7effecb, Pb45a567f
{
    private p99d12a64 F0982c3dc;
    private bool F14e94fae;
    private p99d12a64 F201da641;
    private string F21c99d8a;
    private ECParameterSpec F33c0f968;
    private System.Numerics.BigInteger F43e2a39a;
    private System.Numerics.BigInteger F5412972f;
    private p99d12a64 F65505b6e;
    private ECParameterSpec F67e06c88;
    private bool F7328cded;
    private string F7994b2ab;
    private System.Numerics.BigInteger F8277e091;
    private bool Fa04a9104;
    private p29d19857 Fc36853ea;
    private System.Numerics.BigInteger Fcb2d0781;
    private p99d12a64 Fd056a088;
    private p29d19857 Fd6806f6e;
    private bool Fe4b30525;
    private string Fed469618;

    private void M14800f1c(p811299f8 P0)
    {
        // call: p15be22c4.m8bab0102
        // call: ECParameterSpec.<init>
        // call: pf1040019.m2ace2977
        // call: p364bf33a.m8bab0102
        // call: p21c2eb74.getCurve
        // call: p16a76e39.getKey
        // call: p15be22c4.isImplicitlyCA
        // call: p811299f8.parsePrivateKey
        // call: p16a76e39.<init>
        // call: p21c2eb74.getN
        // call: p15be22c4.getParameters
        // call: System.Numerics.BigInteger.intValue
        // call: pbc37938c.md0402605
        // call: p35e46fcb.getCurve
        // call: p35e46fcb.getG
        // call: p21c2eb74.getH
        // call: p35e46fcb.getN
        // call: p35e46fcb.getSeed
        // call: p37c4833e.mf7b916f7
        // call: pf391b73d.getValue
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fc36853ea
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f33c0f968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f8277e091
        // type: p698f972d
        // type: ECParameterSpec
        // type: p16a76e39
    }

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.writeBoolean
        // call: p699c26d8.getEncoded
        // call: p99d12a64.writeObject
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f201da641
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fa04a9104
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fed469618
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: p811299f8.m8bab0102
        // call: p99d12a64.readObject
        // call: p301c7ed4.m89e75c46
        // call: ObjectInputStream.readObject
        // call: p99d12a64.<init>
        // call: ObjectInputStream.readBoolean
        // call: p699c26d8.m14800f1c
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fa04a9104
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fed469618
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f201da641
        // type: p99d12a64
    }

    private p29d19857 Mf2f0750f(pc7bcd95d P0)
    {
        // call: pc7bcd95d.getEncoded
        // call: p301c7ed4.m89e75c46
        // call: p3cdccfc9.m8bab0102
        // call: p3cdccfc9.getPublicKeyData
        return default!;
    }

    private p835df581 EngineGetSpec()
    {
        // call: pf1040019.mce32677e
        // call: pfe41e66b.getEcImplicitlyCa
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f33c0f968
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: System.Numerics.BigInteger.equals
        // call: p699c26d8.getD
        // call: p835df581.equals
        // call: p699c26d8.engineGetSpec
        return false;
    }

    public string GetAlgorithm()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fed469618
        return string.Empty;
    }

    public p0fd1bdf1 GetBagAttribute(p364bf33a P0)
    {
        // call: p99d12a64.getBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f201da641
        return default!;
    }

    public Enumeration GetBagAttributeKeys()
    {
        // call: p99d12a64.getBagAttributeKeys
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f201da641
        return default!;
    }

    public System.Numerics.BigInteger GetD()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f8277e091
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "ECGOST3410"
        // str: "7725b13b68688ea33b9cf9232666d559c65f06a0a23220d7af092cc485df5c"
        // call: System.Numerics.BigInteger.valueOf
        // call: EllipticCurve.getSeed
        // call: p15be22c4.<init>
        // call: p35e46fcb.<init>
        // call: p16a76e39.<init>
        // call: ECParameterSpec.getGenerator
        // call: string.equals
        // call: p15be22c4.toASN1Primitive
        // call: p234a7530.<init>
        // call: p16a76e39.toASN1Primitive
        // call: p811299f8.<init>
        // call: DecryptString.decryptString
        // call: p811299f8.getEncoded
        // call: ECParameterSpec.getCurve
        // call: p364bf33a.<init>
        // call: p698f972d.getName
        // call: ECParameterSpec.getCofactor
        // call: pf1040019.maa4c417b
        // call: p699c26d8.getS
        // call: p37c4833e.m9a2b7f82
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fc36853ea
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fa04a9104
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f33c0f968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fed469618
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c
        // field: p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // type: p364bf33a
        // type: p35e46fcb
        // type: p15be22c4
        // type: p16a76e39
        // type: p811299f8
        // type: p234a7530
        // type: p713357f2
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public p835df581 GetParameters()
    {
        // call: pf1040019.mce32677e
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f33c0f968
        return default!;
    }

    public ECParameterSpec GetParams()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f33c0f968
        return default!;
    }

    public System.Numerics.BigInteger GetS()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f8277e091
        return default!;
    }

    public int HashCode()
    {
        // call: p699c26d8.engineGetSpec
        // call: p699c26d8.getD
        // call: p835df581.hashCode
        // call: System.Numerics.BigInteger.hashCode
        return 0;
    }

    public void SetBagAttribute(p364bf33a P0, p0fd1bdf1 P1)
    {
        // call: p99d12a64.setBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f201da641
    }

    public void SetPointFormat(string P0)
    {
        // str: "UNCOMPRESSED"
        // call: string.equalsIgnoreCase
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.fa04a9104
    }

    public string ToString()
    {
        // str: "             S: "
        // str: "EC Private Key"
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p89be9433.m2295b6f1
        // call: System.Numerics.BigInteger.toString
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p699c26d8.f8277e091
        // type: StringBuilder
        return string.Empty;
    }

}
