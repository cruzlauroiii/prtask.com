namespace WillowMaze.Wasm.Decompiled;

public class Pcb13bc34 : DHPublicKey
{
    private static long F460a0ec2;
    private static long F4a02e980;
    private static long Fc6e1e520;
    private static long Fcdc0c95b;
    private static long Fe4cbd62c;
    private DHParameterSpec F04ac45b3;
    private p3cdccfc9 F0bea1553;
    private p1bfd3a52 F1357436f;
    private DHParameterSpec F231c457b;
    private DHParameterSpec F244b73e7;
    private System.Numerics.BigInteger F3446fbae;
    private System.Numerics.BigInteger F41529076;
    private DHParameterSpec F5aecd571;
    private p1bfd3a52 F988617c2;
    private DHParameterSpec Fa50d3a94;
    private p3cdccfc9 Fc660446d;
    private p3cdccfc9 Fcaf9b6b9;
    private p3cdccfc9 Fd8fac1f4;
    private p1bfd3a52 Fe910eb58;
    private p1bfd3a52 Ff316485e;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.writeObject
        // call: ObjectOutputStream.defaultWriteObject
        // call: DHParameterSpec.getP
        // call: DHParameterSpec.getL
        // call: DHParameterSpec.getG
        // call: ObjectOutputStream.writeInt
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f5aecd571
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.readObject
        // call: DHParameterSpec.<init>
        // call: ObjectInputStream.readInt
        // call: ObjectInputStream.defaultReadObject
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f5aecd571
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.fcaf9b6b9
        // type: DHParameterSpec
    }

    private bool Md065a21d(p80f8c729 P0)
    {
        // call: p80f8c729.getObjectAt
        // call: System.Numerics.BigInteger.compareTo
        // call: p80f8c729.size
        // call: pf391b73d.getValue
        // call: System.Numerics.BigInteger.bitLength
        // call: pf391b73d.m8bab0102
        // call: System.Numerics.BigInteger.valueOf
        return false;
    }

    public p1bfd3a52 EngineGetKeyParameters()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f988617c2
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: DHPublicKey.getY
        // call: pcb13bc34.getY
        // call: DHParameterSpec.getP
        // call: DHPublicKey.getParams
        // call: System.Numerics.BigInteger.equals
        // call: DHParameterSpec.getL
        // call: DHParameterSpec.getG
        // call: pcb13bc34.getParams
        return false;
    }

    public string GetAlgorithm()
    {
        // str: "DH"
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: p2d99d697.getSeed
        // call: pae8d7c13.getDomainParameters
        // call: p58ac1d27.mfef91d48
        // call: DHParameterSpec.getG
        // call: p4460e12a.getP
        // call: p1dd1689b.<init>
        // call: p4460e12a.getG
        // call: p2d99d697.getCounter
        // call: pf391b73d.<init>
        // call: p9bd379ee.toASN1Primitive
        // call: p234a7530.<init>
        // call: p4460e12a.getQ
        // call: pef342a14.<init>
        // call: p4460e12a.getValidationParameters
        // call: pef342a14.toASN1Primitive
        // call: pae8d7c13.getQ
        // call: p4460e12a.getJ
        // call: p9bd379ee.<init>
        // call: DHParameterSpec.getL
        // call: DHParameterSpec.getP
        // field: p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f0532ccd0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f5aecd571
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.fcaf9b6b9
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f41529076
        // type: pef342a14
        // type: pf391b73d
        // type: p234a7530
        // type: p9bd379ee
        // type: p1dd1689b
        return default!;
    }

    public string GetFormat()
    {
        // str: "X.509"
        return string.Empty;
    }

    public DHParameterSpec GetParams()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f5aecd571
        return default!;
    }

    public System.Numerics.BigInteger GetY()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f41529076
        return default!;
    }

    public int HashCode()
    {
        // call: DHParameterSpec.getL
        // call: DHParameterSpec.getP
        // call: System.Numerics.BigInteger.hashCode
        // call: pcb13bc34.getParams
        // call: pcb13bc34.getY
        // call: DHParameterSpec.getG
        return 0;
    }

    public string ToString()
    {
        // str: "DH"
        // call: DHParameterSpec.getP
        // call: p4460e12a.<init>
        // call: p239111a1.m893c56d9
        // call: DHParameterSpec.getG
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f41529076
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p700f6fa0.pcb13bc34.f5aecd571
        // type: p4460e12a
        return string.Empty;
    }

}
