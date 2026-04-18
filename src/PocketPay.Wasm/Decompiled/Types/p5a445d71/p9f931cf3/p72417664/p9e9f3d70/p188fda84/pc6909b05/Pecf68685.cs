namespace WillowMaze.Wasm.Decompiled;

public class Pecf68685 : ECPublicKey, Pe256531b, Pb45a567f
{
    private static long F94a80167;
    private static long Fa6f6d637;
    private static long Fbc2b5ce6;
    private static long Fc6e1e520;
    private static long Fdc9b2664;
    private string F2a16a5ab;
    private pd16c2d8e F2a939c41;
    private ECParameterSpec F33c0f968;
    private string F36e064e3;
    private p0fd1bdf1 F41a30cda;
    private string F5a9142bd;
    private p0fd1bdf1 F62f6f98d;
    private p0fd1bdf1 F87868a67;
    private bool Fa04a9104;
    private pd16c2d8e Fa7d0d689;
    private bool Fb2d3bba9;
    private ECParameterSpec Fb48cd25f;
    private pd16c2d8e Fdc19459a;
    private pd16c2d8e Fdff1ef67;
    private string Fe7c1d29e;
    private string Fed469618;
    private pd16c2d8e Ff6a9ff0c;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: pecf68685.getEncoded
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
    }

    private void M97d9d39a(byte[] P0, int P1, System.Numerics.BigInteger P2)
    {
        // call: System.arraycopy
        // call: System.Numerics.BigInteger.toByteArray
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: pecf68685.mc82e2de0
        // call: p301c7ed4.m89e75c46
        // call: ObjectInputStream.defaultReadObject
        // call: p3cdccfc9.m8bab0102
        // call: ObjectInputStream.readObject
    }

    private ECParameterSpec Mc1758262(EllipticCurve P0, p21c2eb74 P1)
    {
        // call: p21c2eb74.getH
        // call: pf1040019.maa4c417b
        // call: System.Numerics.BigInteger.intValue
        // call: p21c2eb74.getG
        // call: ECParameterSpec.<init>
        // call: p21c2eb74.getN
        // type: ECParameterSpec
        return default!;
    }

    private void Mc82e2de0(p3cdccfc9 P0)
    {
        // str: "error recovering public key"
        // str: "ECGOST3410"
        // call: p234a7530.getParameters
        // call: p8226e45f.getH
        // call: p37c4833e.m8a2fc590
        // call: p6bf26786.m141cb7b2
        // call: p3d5f6347.m8bab0102
        // call: p3cdccfc9.getAlgorithm
        // call: pbc37938c.m32132c89
        // call: pa827ecfa.decodePoint
        // call: p698f972d.<init>
        // call: p11b04310.getOctets
        // call: p3d5f6347.getPublicKeyParamSet
        // call: p3cdccfc9.getPublicKeyData
        // call: p364bf33a.m8bab0102
        // call: p8226e45f.getN
        // call: p8226e45f.getSeed
        // call: pf1040019.maa4c417b
        // call: pf1040019.m2ace2977
        // call: p29d19857.getBytes
        // call: p301c7ed4.m89e75c46
        // call: pd16c2d8e.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f62f6f98d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f33c0f968
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fed469618
        // type: IllegalArgumentException
        // type: p698f972d
        // type: pd16c2d8e
    }

    private pd16c2d8e EngineGetKeyParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        return default!;
    }

    private p835df581 EngineGetSpec()
    {
        // call: pfe41e66b.getEcImplicitlyCa
        // call: pf1040019.mce32677e
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f33c0f968
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pd16c2d8e.getQ
        // call: p835df581.equals
        // call: pecf68685.engineGetSpec
        // call: p53a5793f.equals
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        return false;
    }

    public string GetAlgorithm()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fed469618
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: ECParameterSpec.getCurve
        // call: ECParameterSpec.getGenerator
        // call: p3d5f6347.<init>
        // call: p58ac1d27.mfef91d48
        // call: pecf68685.m97d9d39a
        // call: p234a7530.<init>
        // call: p6f0e511c.<init>
        // call: p3cdccfc9.<init>
        // call: pd16c2d8e.getQ
        // call: p53a5793f.getAffineYCoord
        // call: EllipticCurve.getSeed
        // call: p5a196a0a.toBigInteger
        // call: p698f972d.getName
        // call: p15be22c4.<init>
        // call: System.Numerics.BigInteger.valueOf
        // call: p713357f2.<init>
        // call: ECParameterSpec.getOrder
        // call: pf1040019.m2ace2977
        // call: pf1040019.maa4c417b
        // call: pecf68685.getGostParams
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f33c0f968
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa04a9104
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32
        // type: p3d5f6347
        // type: p3cdccfc9
        // type: p234a7530
        // type: p6f0e511c
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

    private p0fd1bdf1 GetGostParams()
    {
        // call: pbc37938c.m18da419b
        // call: p698f972d.getName
        // call: p3d5f6347.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f62f6f98d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f33c0f968
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f40f7fe32
        // type: p3d5f6347
        return default!;
    }

    public p835df581 GetParameters()
    {
        // call: pf1040019.mce32677e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f33c0f968
        return default!;
    }

    public ECParameterSpec GetParams()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f33c0f968
        return default!;
    }

    public p53a5793f GetQ()
    {
        // call: pd16c2d8e.getQ
        // call: p53a5793f.getDetachedPoint
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.f33c0f968
        return default!;
    }

    public ECPoint GetW()
    {
        // call: pf1040019.maa4c417b
        // call: pd16c2d8e.getQ
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        return default!;
    }

    public int HashCode()
    {
        // call: pd16c2d8e.getQ
        // call: pecf68685.engineGetSpec
        // call: p53a5793f.hashCode
        // call: p835df581.hashCode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        return 0;
    }

    public void SetPointFormat(string P0)
    {
        // str: "UNCOMPRESSED"
        // call: string.equalsIgnoreCase
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa04a9104
    }

    public string ToString()
    {
        // call: p37c4833e.m893c56d9
        // call: pd16c2d8e.getQ
        // call: pecf68685.engineGetSpec
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fa7d0d689
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.pecf68685.fed469618
        return string.Empty;
    }

}
