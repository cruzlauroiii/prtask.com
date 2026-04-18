namespace WillowMaze.Wasm.Decompiled;

public class Peca3a970 : PrivateKey, P404c8b77
{
    private static long F20baa942;
    private static long F427ace34;
    private static long Fada38d89;
    private static long Fc6e1e520;
    private static long Ffa59d890;
    private pbf81b3bd F13d393fd;
    private p364bf33a F237da399;
    private p364bf33a F42c28003;
    private ped34daf1 F736b9175;
    private pbf81b3bd F8ececa4f;
    private pbf81b3bd F99fe4a6d;
    private ped34daf1 Faa3413bb;
    private p364bf33a Fc0bb76d8;
    private ped34daf1 Fc908487e;
    private p364bf33a Fd10c6ab7;

    private void M25b00872(ObjectOutputStream P0)
    {
        // call: peca3a970.getEncoded
        // call: ObjectOutputStream.defaultWriteObject
        // call: ObjectOutputStream.writeObject
    }

    private void Mb951402c(ObjectInputStream P0)
    {
        // call: ObjectInputStream.defaultReadObject
        // call: p811299f8.m8bab0102
        // call: ObjectInputStream.readObject
        // call: peca3a970.me37f0136
    }

    private void Me37f0136(p811299f8 P0)
    {
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p811299f8.getAttributes
        // call: pbc420844.me28b94be
        // call: p234a7530.getParameters
        // call: pacfb2551.m8bab0102
        // call: p234a7530.getAlgorithm
        // call: pacfb2551.getTreeDigest
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f736b9175
    }

    public bool Equals(object P0)
    {
        // call: p364bf33a.equals
        // call: pff43b8de.m2a3f81d2
        // call: pbf81b3bd.toByteArray
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        return false;
    }

    public p404c8b77 ExtractKeyShard(int P0)
    {
        // call: pbf81b3bd.extractKeyShard
        // call: peca3a970.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f42c28003
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        // type: peca3a970
        return default!;
    }

    public string GetAlgorithm()
    {
        // str: "XMSSMT"
        return string.Empty;
    }

    public byte[] GetEncoded()
    {
        // call: pb3a2dfcc.m258e1870
        // call: p811299f8.getEncoded
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f736b9175
        return default!;
    }

    public string GetFormat()
    {
        // str: "PKCS#8"
        return string.Empty;
    }

    public int GetHeight()
    {
        // call: pbf81b3bd.getParameters
        // call: pe6015194.getHeight
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        return 0;
    }

    public long GetIndex()
    {
        // str: "key exhausted"
        // call: IllegalStateException.<init>
        // call: peca3a970.getUsagesRemaining
        // call: pbf81b3bd.getIndex
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        // type: IllegalStateException
        return 0;
    }

    private pc9ef6b45 GetKeyParams()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        return default!;
    }

    public int GetLayers()
    {
        // call: pbf81b3bd.getParameters
        // call: pe6015194.getLayers
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        return 0;
    }

    public string GetTreeDigest()
    {
        // call: p69279707.m3d422dba
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f42c28003
        return string.Empty;
    }

    private p364bf33a GetTreeDigestOID()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f42c28003
        return default!;
    }

    public long GetUsagesRemaining()
    {
        // call: pbf81b3bd.getUsagesRemaining
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        return 0;
    }

    public int HashCode()
    {
        // call: pbf81b3bd.toByteArray
        // call: p364bf33a.hashCode
        // call: pff43b8de.m550d1cc0
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f99fe4a6d
        // field: p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p4aeb1bcf.peca3a970.f42c28003
        return 0;
    }

}
