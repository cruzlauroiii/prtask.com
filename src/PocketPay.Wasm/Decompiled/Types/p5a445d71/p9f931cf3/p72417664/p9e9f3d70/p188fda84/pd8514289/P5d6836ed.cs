namespace WillowMaze.Wasm.Decompiled;

public class P5d6836ed : ECPublicKey, Pe256531b, Pb45a567f
{
    private static long Fa0d5c13b;
    private static long Fc6e1e520;
    private static long Ff5bbbb2a;
    private static long Ffd939764;
    private pd16c2d8e F02d4294d;
    private ECParameterSpec F053a988c;
    private p3d5f6347 F15e15eee;
    private pd16c2d8e F1d1ecd14;
    private bool F2fcb0516;
    private ECParameterSpec F33c0f968;
    private p3d5f6347 F4f1bb49e;
    private p3d5f6347 F62f6f98d;
    private bool F782cb7ce;
    private string F7a9e2f66;
    private p3d5f6347 F92bc07e4;
    private bool F9d69c32a;
    private string F9ee3d9e7;
    private bool Fa04a9104;
    private pd16c2d8e Fa7d0d689;
    private pd16c2d8e Fd20c931a;
    private bool Fecf6324e;
    private string Fed469618;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
        // call: p5d6836ed.getEncoded
    }

    private void M97d9d39a(byte[] P0, int P1, int P2, System.Numerics.BigInteger P3)
    {
        // call: System.Numerics.BigInteger.toByteArray
        // call: System.arraycopy
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.defaultReadObject
        // call: p5d6836ed.mc82e2de0
        // call: p3cdccfc9.m8bab0102
        // call: ObjectInputStream.readObject
        // call: p301c7ed4.m89e75c46
    }

    private ECParameterSpec Mc1758262(EllipticCurve P0, p21c2eb74 P1)
    {
        // call: ECParameterSpec.<init>
        // call: p21c2eb74.getG
        // call: pf1040019.maa4c417b
        // call: p21c2eb74.getH
        // call: p21c2eb74.getN
        // call: System.Numerics.BigInteger.intValue
        // type: ECParameterSpec
        return default!;
    }

    private void Mc82e2de0(p3cdccfc9 P0)
    {
        // str: "ECGOST3410-2012"
        // str: "error recovering public key"
        // call: p8226e45f.getG
        // call: pd16c2d8e.<init>
        // call: pf1040019.m2ace2977
        // call: p37c4833e.m8a2fc590
        // call: p8226e45f.getCurve
        // call: p234a7530.getParameters
        // call: pbc37938c.m32132c89
        // call: p8226e45f.getSeed
        // call: p3d5f6347.getPublicKeyParamSet
        // call: p11b04310.getOctets
        // call: pa827ecfa.decodePoint
        // call: p3cdccfc9.getAlgorithm
        // call: IllegalArgumentException.<init>
        // call: pf1040019.maa4c417b
        // call: p29d19857.getBytes
        // call: p301c7ed4.m89e75c46
        // call: p6bf26786.m141cb7b2
        // call: p3d5f6347.m8bab0102
        // call: p8226e45f.getH
        // call: p3cdccfc9.getPublicKeyData
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f62f6f98d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f33c0f968
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fed469618
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        // field: p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5
        // type: p698f972d
        // type: IllegalArgumentException
        // type: pd16c2d8e
    }

    private pd16c2d8e EngineGetKeyParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        return default!;
    }

    private p835df581 EngineGetSpec()
    {
        // call: pfe41e66b.getEcImplicitlyCa
        // call: pf1040019.mce32677e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f33c0f968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pd16c2d8e.getQ
        // call: p5d6836ed.engineGetSpec
        // call: p835df581.equals
        // call: p53a5793f.equals
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        return false;
    }

    public string GetAlgorithm()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fed469618
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: p698f972d.getName
        // call: p53a5793f.getAffineXCoord
        // call: pf1040019.m2ace2977
        // call: p53a5793f.getAffineYCoord
        // call: pd16c2d8e.getQ
        // call: ECParameterSpec.getCurve
        // call: p15be22c4.<init>
        // call: p5d6836ed.m97d9d39a
        // call: p234a7530.<init>
        // call: p6f0e511c.<init>
        // call: p3cdccfc9.<init>
        // call: p713357f2.<init>
        // call: p5a196a0a.toBigInteger
        // call: ECParameterSpec.getOrder
        // call: p3d5f6347.<init>
        // call: p58ac1d27.mfef91d48
        // call: ECParameterSpec.getCofactor
        // call: ECParameterSpec.getGenerator
        // call: EllipticCurve.getSeed
        // call: p5d6836ed.getGostParams
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f33c0f968
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        // field: p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5
        // field: p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f86d3c5ee
        // field: p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f7fbdf1f9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa04a9104
        // field: p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a
        // type: p3cdccfc9
        // type: p234a7530
        // type: p6f0e511c
        // type: p3d5f6347
        // type: p713357f2
        // type: p35e46fcb
        // type: p15be22c4
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public p3d5f6347 GetGostParams()
    {
        // call: p5a196a0a.toBigInteger
        // call: p3d5f6347.<init>
        // call: p698f972d.getName
        // call: pbc37938c.m18da419b
        // call: p53a5793f.getAffineXCoord
        // call: pd16c2d8e.getQ
        // call: System.Numerics.BigInteger.bitLength
        // field: p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f86d3c5ee
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f33c0f968
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f62f6f98d
        // field: p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f7fbdf1f9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        // type: p3d5f6347
        return default!;
    }

    public p835df581 GetParameters()
    {
        // call: pf1040019.mce32677e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f33c0f968
        return default!;
    }

    public ECParameterSpec GetParams()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f33c0f968
        return default!;
    }

    public p53a5793f GetQ()
    {
        // call: p53a5793f.getDetachedPoint
        // call: pd16c2d8e.getQ
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.f33c0f968
        return default!;
    }

    public ECPoint GetW()
    {
        // call: pf1040019.maa4c417b
        // call: pd16c2d8e.getQ
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        return default!;
    }

    public int HashCode()
    {
        // call: p5d6836ed.engineGetSpec
        // call: p53a5793f.hashCode
        // call: p835df581.hashCode
        // call: pd16c2d8e.getQ
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        return 0;
    }

    public void SetPointFormat(string P0)
    {
        // str: "UNCOMPRESSED"
        // call: string.equalsIgnoreCase
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa04a9104
    }

    public string ToString()
    {
        // call: p37c4833e.m893c56d9
        // call: pd16c2d8e.getQ
        // call: p5d6836ed.engineGetSpec
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fa7d0d689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p5d6836ed.fed469618
        return string.Empty;
    }

}
