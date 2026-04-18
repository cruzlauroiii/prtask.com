namespace WillowMaze.Wasm.Decompiled;

public class P7ed0342b : P5b96aa5f, Pc7effecb
{
    private static long Faa649101;
    private static long Fc6e1e520;
    private System.Numerics.BigInteger F0eca1b6b;
    private p7cbf3bd3 F1000b67c;
    private pc7effecb F201da641;
    private pc7effecb F74c0600d;
    private p7cbf3bd3 F968273e2;
    private System.Numerics.BigInteger F9dd4e461;
    private System.Numerics.BigInteger Faea530a5;
    private System.Numerics.BigInteger Fba13f616;
    private System.Numerics.BigInteger Fc95a4489;
    private p7cbf3bd3 Fe1354f11;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: p7cbf3bd3.getEncryptionParamSetOID
        // call: p7cbf3bd3.getDigestParamSetOID
        // call: p5e745417.getP
        // call: p5e745417.getA
        // call: ObjectOutputStream.writeObject
        // call: p7cbf3bd3.getPublicKeyParameters
        // call: ObjectOutputStream.defaultWriteObject
        // call: p7cbf3bd3.getPublicKeyParamSetOID
        // call: p5e745417.getQ
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f968273e2
    }

    private bool Mad509ef7(object P0, object P1)
    {
        // call: object.equals
        return false;
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: p6b825a8d.<init>
        // call: ObjectInputStream.readObject
        // call: p5e745417.<init>
        // call: ObjectInputStream.defaultReadObject
        // call: p99d12a64.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f968273e2
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f201da641
        // type: p5e745417
        // type: p6b825a8d
        // type: p99d12a64
    }

    public bool Equals(object P0)
    {
        // call: p5b96aa5f.getParameters
        // call: p7cbf3bd3.getEncryptionParamSetOID
        // call: System.Numerics.BigInteger.equals
        // call: p7cbf3bd3.getPublicKeyParameters
        // call: p5b96aa5f.getX
        // call: string.equals
        // call: p7ed0342b.mad509ef7
        // call: p7ed0342b.getParameters
        // call: p7cbf3bd3.getDigestParamSetOID
        // call: p5e745417.equals
        // call: p7ed0342b.getX
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "GOST3410"
        return string.Empty;
    }

    public p0fd1bdf1 GetBagAttribute(p364bf33a P0)
    {
        // call: pc7effecb.getBagAttribute
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f201da641
        return default!;
    }

    public Enumeration GetBagAttributeKeys()
    {
        // call: pc7effecb.getBagAttributeKeys
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f201da641
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "2bc71fdcc6cee2d738a0c15a8656fb37a012bc15d700b06a5dcce295e0dffa"
        // call: p7cbf3bd3.getPublicKeyParamSetOID
        // call: p364bf33a.<init>
        // call: p7cbf3bd3.getDigestParamSetOID
        // call: p3d5f6347.<init>
        // call: p234a7530.<init>
        // call: p6f0e511c.<init>
        // call: p811299f8.<init>
        // call: DecryptString.decryptString
        // call: p811299f8.getEncoded
        // call: p7ed0342b.getX
        // call: System.Numerics.BigInteger.toByteArray
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f968273e2
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f4af268c3
        // type: p811299f8
        // type: p234a7530
        // type: p3d5f6347
        // type: p364bf33a
        // type: p6f0e511c
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public p7cbf3bd3 GetParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f968273e2
        return default!;
    }

    public System.Numerics.BigInteger GetX()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f9dd4e461
        return default!;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // call: p7ed0342b.getX
        // call: System.Numerics.BigInteger.hashCode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f968273e2
        return 0;
    }

    public void SetBagAttribute(p364bf33a P0, p0fd1bdf1 P1)
    {
        // call: pc7effecb.setBagAttribute
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f201da641
    }

    public string ToString()
    {
        // str: "GOST3410"
        // call: p7a5dfe3f.m02ea6360
        // call: p9c2a10cf.getParameters
        // call: p2b36b9dd.mcd18c471
        // call: InvalidKeyException.getMessage
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p77c4e487.p7ed0342b.f9dd4e461
        // type: IllegalStateException
        return string.Empty;
    }

}
