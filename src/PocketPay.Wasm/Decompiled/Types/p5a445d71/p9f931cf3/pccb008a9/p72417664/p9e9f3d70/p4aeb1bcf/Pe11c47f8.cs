namespace WillowMaze.Wasm.Decompiled;

public class Pe11c47f8 : PrivateKey, P7e83e3ae
{
    private static long F77269df7;
    private static long Fc6e1e520;
    private ped34daf1 F0b29fda4;
    private ped34daf1 F2438a28b;
    private p364bf33a F2f54b034;
    private p364bf33a F42c28003;
    private ped34daf1 F736b9175;
    private p364bf33a F798dc541;
    private ped34daf1 F8a8252da;
    private p823c49a3 F99fe4a6d;
    private p823c49a3 F9c62ba94;
    private p364bf33a Fa83908c3;
    private p364bf33a Fb60153d5;
    private ped34daf1 Fd93a5d00;
    private p823c49a3 Fdb1df711;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: ObjectOutputStream.defaultWriteObject
        // call: pe11c47f8.getEncoded
        // call: ObjectOutputStream.writeObject
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.defaultReadObject
        // call: pe11c47f8.me37f0136
        // call: ObjectInputStream.readObject
        // call: p811299f8.m8bab0102
    }

    private void Me37f0136(p811299f8 P0)
    {
        // call: p234a7530.getParameters
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p2bd3ac77.m8bab0102
        // call: p234a7530.getAlgorithm
        // call: p2bd3ac77.getTreeDigest
        // call: pbc420844.me28b94be
        // call: p811299f8.getAttributes
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f736b9175
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f42c28003
    }

    public bool Equals(object P0)
    {
        // call: pff43b8de.m2a3f81d2
        // call: p364bf33a.equals
        // call: p823c49a3.toByteArray
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f42c28003
        return false;
    }

    public p7e83e3ae ExtractKeyShard(int P0)
    {
        // call: pe11c47f8.<init>
        // call: p823c49a3.extractKeyShard
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        // type: pe11c47f8
        return default!;
    }

    public string GetAlgorithm()
    {
        // str: "XMSS"
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: pb3a2dfcc.m258e1870
        // call: p811299f8.getEncoded
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f736b9175
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public int GetHeight()
    {
        // call: p823c49a3.getParameters
        // call: pf62ef2d9.getHeight
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        return 0;
    }

    public long GetIndex()
    {
        // str: "key exhausted"
        // call: p823c49a3.getIndex
        // call: IllegalStateException.<init>
        // call: pe11c47f8.getUsagesRemaining
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        // type: IllegalStateException
        return 0;
    }

    private pc9ef6b45 GetKeyParams()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        return default!;
    }

    public string GetTreeDigest()
    {
        // call: p69279707.m3d422dba
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f42c28003
        return string.Empty;
    }

    private p364bf33a GetTreeDigestOID()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f42c28003
        return default!;
    }

    public long GetUsagesRemaining()
    {
        // call: p823c49a3.getUsagesRemaining
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        return 0;
    }

    public int HashCode()
    {
        // call: pff43b8de.m550d1cc0
        // call: p823c49a3.toByteArray
        // call: p364bf33a.hashCode
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f99fe4a6d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.pe11c47f8.f42c28003
        return 0;
    }

}
