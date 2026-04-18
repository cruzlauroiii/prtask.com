namespace WillowMaze.Wasm.Decompiled;

public class P511d6594 : Pcc0037e2, P64e649e3
{
    private List<object> F14f802e1;
    private long F188de01a;
    private List<object> F1dfe94af;
    private readonly long F2b00e85c;
    private readonly int F2db95e8e;
    private List<object> F3311842a;
    private readonly long F3d3b0a93;
    private readonly int F4865f96c;
    private List<object> F542a135a;
    private readonly long F5d97b6b8;
    private readonly bool F67f7e3f5;
    private readonly bool F695aaee5;
    private long F6a992d55;
    private pe32c2c6b F6b11e9c8;
    private pe32c2c6b F97f85610;
    private readonly int F9e3bdbea;
    private List<object> F9f9b292f;
    private readonly long Fac5befe0;
    private readonly int Fb475e65b;
    private readonly bool Fb6d4cfd3;
    private readonly bool Fbe948ccb;
    private List<object> Fbef46962;
    private pe32c2c6b Fc36853ea;
    private pe32c2c6b Fc5368bd9;
    private long Fc769a5b2;
    private readonly bool Fce32bd21;
    private List<object> Fce42e41e;
    private long Fdf74dd64;
    private List<object> Fe2cfc0e5;
    private long Ff64e00be;

    public static p511d6594 M8bab0102(object P0)
    {
        // str: "cannot parse "
        // str: "unknown version for hss private key"
        // call: List<object>.add
        // call: DataInputStream.readInt
        // call: pb88b632d.m8bab0102
        // call: DataInputStream.readBoolean
        // call: DataInputStream.readLong
        // call: p5a1c166f.m8bab0102
        // call: IllegalArgumentException.<init>
        // call: IllegalStateException.<init>
        // call: Stream.close
        // call: p511d6594.m8bab0102
        // call: p21b3cb64.m257a59b8
        // call: List<object>.<init>
        // call: StringBuilder.<init>
        // call: MemoryStream.<init>
        // call: DataInputStream.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p511d6594.<init>
        // type: StringBuilder
        // type: IllegalArgumentException
        // type: p511d6594
        // type: IllegalStateException
        // type: List<object>
        // type: DataInputStream
        // type: MemoryStream
        return default!;
    }

    public static p511d6594 M8bab0102(byte[] P0, byte[] P1)
    {
        // call: p511d6594.m8bab0102
        // call: pe32c2c6b.m8bab0102
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.fc36853ea
        return default!;
    }

    private static p511d6594 Mf55b5882(p511d6594 P0)
    {
        // call: Exception.getMessage
        // call: Exception.<init>
        // call: p511d6594.getEncoded
        // call: p511d6594.m8bab0102
        // type: Exception
        return default!;
    }

    private object Clone()
    {
        // call: p511d6594.mf55b5882
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: object.equals
        // call: object.getClass
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3311842a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f2db95e8e
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3d3b0a93
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f695aaee5
        return false;
    }

    public p511d6594 ExtractKeyShard(int P0)
    {
        // str: "usageCount exceeds usages remaining in current leaf"
        // call: p511d6594.getUsagesRemaining
        // call: p511d6594.getKeys
        // call: List<object>.<init>
        // call: p511d6594.getSig
        // call: p511d6594.<init>
        // call: p511d6594.mf55b5882
        // call: p511d6594.resetKeyToIndex
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f2db95e8e
        // type: List<object>
        // type: p511d6594
        // type: IllegalArgumentException
        return default!;
    }

    public pf502f530 GenerateLMSContext()
    {
        // call: pa356c796.m4f9c1785
        // call: p511d6594.getKeys
        // call: p511d6594.getSig
        // call: List<object>.get
        // call: pb88b632d.getPublicKey
        // call: pe0a7073e.<init>
        // call: p511d6594.incIndex
        // call: pb88b632d.generateLMSContext
        // call: p511d6594.getL
        // call: pf502f530.withSignedPublicKeys
        // type: pe0a7073e
        return default!;
    }

    public byte[] GenerateSignature(pf502f530 P0)
    {
        // str: "unable to encode signature: "
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IOException.getMessage
        // call: p511d6594.getL
        // call: pa356c796.m42750aa6
        // call: pf82a7aa7.getEncoded
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: IllegalStateException
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: pbcba235a.m13b3f3e7
        // call: pbcba235a.u32str
        // call: pbcba235a.u64str
        // call: pbcba235a.bool
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: pbcba235a.bytes
        // call: pbcba235a.build
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f2db95e8e
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3d3b0a93
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f695aaee5
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3311842a
        return default!;
    }

    public long GetIndex()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f6a992d55
        return 0;
    }

    private long GetIndexLimit()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3d3b0a93
        return 0;
    }

    private List<object> GetKeys()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        return default!;
    }

    public int GetL()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f2db95e8e
        return 0;
    }

    public p936247f3[] GetLMSParameters()
    {
        // call: List<object>.size
        // call: List<object>.get
        // call: pb88b632d.getSigParameters
        // call: pb88b632d.getOtsParameters
        // call: p936247f3.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        // type: p936247f3
        return default!;
    }

    public pe32c2c6b GetPublicKey()
    {
        // call: p511d6594.getRootKey
        // call: pb88b632d.getPublicKey
        // call: pe32c2c6b.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f2db95e8e
        // type: pe32c2c6b
        return default!;
    }

    private pb88b632d GetRootKey()
    {
        // call: List<object>.get
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        return default!;
    }

    private List<object> GetSig()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3311842a
        return default!;
    }

    public long GetUsagesRemaining()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3d3b0a93
        return 0;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f695aaee5
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f2db95e8e
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3311842a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3d3b0a93
        return 0;
    }

    private void IncIndex()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f6a992d55
    }

    private bool IsShard()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f695aaee5
        return false;
    }

    private void ReplaceConsumedKey(int P0)
    {
        // call: List<object>.<init>
        // call: pb88b632d.getSigParameters
        // call: pb88b632d.getCurrentOTSKey
        // call: List<object>.get
        // call: Collections.unmodifiableList
        // call: pb88b632d.getPublicKey
        // call: pb88b632d.getOtsParameters
        // call: p66a8f281.m828114c8
        // call: pe1a02e85.deriveSeed
        // call: List<object>.set
        // call: pe1a02e85.setJ
        // call: System.arraycopy
        // call: p9064fad6.toByteArray
        // call: p5b89b9c3.getDerivationFunction
        // call: p66a8f281.m5ee7eb5d
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3311842a
        // type: List<object>
    }

    private void ResetKeyToIndex()
    {
        // call: List<object>.toArray
        // call: p511d6594.getKeys
        // call: List<object>.get
        // call: pe1a02e85.setJ
        // call: pe1a02e85.deriveSeed
        // call: p66a8f281.m5ee7eb5d
        // call: pb88b632d.getMasterSecret
        // call: p9064fad6.toByteArray
        // call: pb88b632d.getSigParameters
        // call: paa63fca2.getDigestOID
        // call: pe1a02e85.<init>
        // call: pb88b632d.getPublicKey
        // call: p69279707.me0825354
        // call: List<object>.size
        // call: p66a8f281.m828114c8
        // call: p511d6594.updateHierarchy
        // call: pb88b632d.getOtsParameters
        // call: p511d6594.getRootKey
        // call: pe1a02e85.setQ
        // call: pb88b632d.getI
        // field: android.content.pm.ActivityInfo.applicationInfo
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3311842a
        // type: pe1a02e85
    }

    private void UpdateHierarchy(pb88b632d[] P0, p5a1c166f[] P1)
    {
        // call: Arrays.asList
        // call: Collections.unmodifiableList
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f14f802e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.f3311842a
    }

}
