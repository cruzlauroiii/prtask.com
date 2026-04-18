namespace WillowMaze.Wasm.Decompiled;

public class Pc7bcd95d : ECPublicKey, Pe256531b, Pb45a567f
{
    private ECParameterSpec F1af2cd90;
    private p53a5793f F24477236;
    private p3d5f6347 F2ccea0ac;
    private ECParameterSpec F33c0f968;
    private string F518324ca;
    private p3d5f6347 F62f6f98d;
    private p3d5f6347 F6323b875;
    private p53a5793f F69e08dee;
    private p53a5793f F7694f4a6;
    private string F7a8d8a85;
    private string F7b29c210;
    private p3d5f6347 F8982043f;
    private string F9776b15c;
    private bool Fa04a9104;
    private p3d5f6347 Fa54d9e92;
    private bool Fb6392984;
    private ECParameterSpec Fc5780ed2;
    private string Fed469618;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: pc7bcd95d.getEncoded
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.writeBoolean
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fa04a9104
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fed469618
    }

    private void M97d9d39a(byte[] P0, int P1, System.Numerics.BigInteger P2)
    {
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.arraycopy
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: pc7bcd95d.mc82e2de0
        // call: p301c7ed4.m89e75c46
        // call: p3cdccfc9.m8bab0102
        // call: ObjectInputStream.readObject
        // call: ObjectInputStream.readBoolean
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fa04a9104
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fed469618
    }

    private ECParameterSpec Mc1758262(EllipticCurve P0, p21c2eb74 P1)
    {
        // call: ECParameterSpec.<init>
        // call: System.Numerics.BigInteger.intValue
        // call: p21c2eb74.getH
        // call: p21c2eb74.getG
        // call: pf1040019.maa4c417b
        // call: p21c2eb74.getN
        // type: ECParameterSpec
        return default!;
    }

    private void Mc82e2de0(p3cdccfc9 P0)
    {
        // str: "ECGOST3410"
        // str: "error recovering public key"
        // call: pa827ecfa.decodePoint
        // call: p713357f2.<init>
        // call: p35e46fcb.getH
        // call: p3cdccfc9.getPublicKeyData
        // call: pf1040019.m2ace2977
        // call: p8226e45f.getN
        // call: p11b04310.getOctets
        // call: pfe41e66b.getEcImplicitlyCa
        // call: p8226e45f.getCurve
        // call: p713357f2.getPoint
        // call: p15be22c4.m8bab0102
        // call: p15be22c4.getParameters
        // call: pf1040019.maa4c417b
        // call: p35e46fcb.getN
        // call: p35e46fcb.m8bab0102
        // call: p364bf33a.equals
        // call: p35e46fcb.getCurve
        // call: p8226e45f.getSeed
        // call: p3d5f6347.m8bab0102
        // call: pb79a74f5.getByteLength
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f33c0f968
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fed469618
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f62f6f98d
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f7694f4a6
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        // type: p698f972d
        // type: IllegalArgumentException
        // type: pb79a74f5
        // type: ECParameterSpec
        // type: p6f0e511c
        // type: p713357f2
    }

    public p53a5793f EngineGetQ()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f7694f4a6
        return default!;
    }

    private p835df581 EngineGetSpec()
    {
        // call: pfe41e66b.getEcImplicitlyCa
        // call: pf1040019.mce32677e
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f33c0f968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pc7bcd95d.engineGetQ
        // call: pc7bcd95d.engineGetSpec
        // call: p835df581.equals
        // call: p53a5793f.equals
        return false;
    }

    public string GetAlgorithm()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fed469618
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // str: "ECGOST3410"
        // call: ECParameterSpec.getCurve
        // call: EllipticCurve.getSeed
        // call: p15be22c4.<init>
        // call: ECParameterSpec.getCofactor
        // call: ECParameterSpec.getGenerator
        // call: pc7bcd95d.m97d9d39a
        // call: p234a7530.<init>
        // call: p6f0e511c.<init>
        // call: p3cdccfc9.<init>
        // call: p53a5793f.getAffineYCoord
        // call: p5a196a0a.toBigInteger
        // call: pbc37938c.m18da419b
        // call: ECParameterSpec.getOrder
        // call: p713357f2.<init>
        // call: p58ac1d27.mfef91d48
        // call: p35e46fcb.<init>
        // call: p698f972d.getName
        // call: p364bf33a.<init>
        // call: p53a5793f.getEncoded
        // call: p53a5793f.getAffineXCoord
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f33c0f968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fa04a9104
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f7694f4a6
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f62f6f98d
        // field: p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fed469618
        // type: p234a7530
        // type: p35e46fcb
        // type: p713357f2
        // type: p3d5f6347
        // type: p3cdccfc9
        // type: p6f0e511c
        // type: p15be22c4
        // type: p364bf33a
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public p835df581 GetParameters()
    {
        // call: pf1040019.mce32677e
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f33c0f968
        return default!;
    }

    public ECParameterSpec GetParams()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f33c0f968
        return default!;
    }

    public p53a5793f GetQ()
    {
        // call: p53a5793f.getDetachedPoint
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f7694f4a6
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f33c0f968
        return default!;
    }

    public ECPoint GetW()
    {
        // call: pf1040019.maa4c417b
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f7694f4a6
        return default!;
    }

    public int HashCode()
    {
        // call: p53a5793f.hashCode
        // call: p835df581.hashCode
        // call: pc7bcd95d.engineGetSpec
        // call: pc7bcd95d.engineGetQ
        return 0;
    }

    public void SetPointFormat(string P0)
    {
        // str: "UNCOMPRESSED"
        // call: string.equalsIgnoreCase
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.fa04a9104
    }

    public string ToString()
    {
        // str: "EC Public Key"
        // str: "            Y: "
        // str: "            X: "
        // call: StringBuilder.append
        // call: p53a5793f.getAffineXCoord
        // call: p89be9433.m2295b6f1
        // call: p53a5793f.getAffineYCoord
        // call: StringBuilder.<init>
        // call: System.Numerics.BigInteger.toString
        // call: p5a196a0a.toBigInteger
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pc7bcd95d.f7694f4a6
        // type: StringBuilder
        return string.Empty;
    }

}
