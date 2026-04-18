namespace WillowMaze.Wasm.Decompiled;

public class P406baf6c_p8a91260e
{
    public int F00d10611;
    private readonly pcc81e3f6 F09292f8e;
    private int F0a050724;
    public int F0a4da856;
    private readonly pcc81e3f6 F0cf759da;
    private readonly int F1db4d2d7;
    private int F1e120006;
    private int F21f8ab23;
    private int F2d270bb0;
    private readonly pcc81e3f6 F36cd38f4;
    public pbf50d5e6[] F5acbf786;
    private readonly List<object> F5cd6c612;
    private int F5fb32ccd;
    public pbf50d5e6[] F76345ca4;
    public int F82bb33eb;
    private int F85a1ea03;
    public int F88854ee9;
    private int F8c792b02;
    public int F8de65014;
    public int F981c237b;
    private int F99300e42;
    private readonly int F9a72012e;
    private readonly List<object> Fa9c82692;
    public pbf50d5e6[] Fb1d1a4da;
    public int Fc59c5864;
    private readonly pcc81e3f6 Fd6050cfb;
    private int Fd99c082a;
    public int Fe353ff03;
    public int Ff43372fb;

    private void AdjustDynamicTableByteCount()
    {
        // call: p406baf6c$p8a91260e.evictToRecoverBytes
        // call: p406baf6c$p8a91260e.clearDynamicTable
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f0a050724
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f82bb33eb
    }

    private void ClearDynamicTable()
    {
        // call: ArraysKt.fill$default
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f99300e42
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f82bb33eb
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f981c237b
    }

    private int DynamicTableIndex(int P0)
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f99300e42
        return 0;
    }

    private int EvictToRecoverBytes(int P0)
    {
        // call: Intrinsics.checkNotNull
        // call: System.arraycopy
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f99300e42
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f82bb33eb
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f3a8e5bd3
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f981c237b
        return 0;
    }

    private p58efa9e8 GetName(int P0)
    {
        // str: "Header index too large "
        // call: int.valueOf
        // call: Intrinsics.checkNotNull
        // call: p406baf6c$p8a91260e.dynamicTableIndex
        // call: p406baf6c.getSTATIC_HEADER_TABLE
        // call: p406baf6c$p8a91260e.isStaticHeader
        // call: Intrinsics.stringPlus
        // call: IOException.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.f76425f17
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.fb068931c
        // type: IOException
        return default!;
    }

    private void InsertIntoDynamicTable(int P0, pbf50d5e6 P1)
    {
        // call: p406baf6c$p8a91260e.dynamicTableIndex
        // call: List<object>.add
        // call: System.arraycopy
        // call: p406baf6c$p8a91260e.evictToRecoverBytes
        // call: p406baf6c$p8a91260e.clearDynamicTable
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f981c237b
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f99300e42
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f82bb33eb
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f3a8e5bd3
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.fa9c82692
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f0a050724
    }

    private bool IsStaticHeader(int P0)
    {
        // call: p406baf6c.getSTATIC_HEADER_TABLE
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.f76425f17
        return false;
    }

    private int ReadByte()
    {
        // call: p23e8a4b4.and
        // call: pcc81e3f6.readByte
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f36cd38f4
        return 0;
    }

    private void ReadIndexedHeader(int P0)
    {
        // str: "Header index too large "
        // call: p406baf6c$p8a91260e.isStaticHeader
        // call: Intrinsics.checkNotNull
        // call: ICollection<object>.add
        // call: IOException.<init>
        // call: p406baf6c$p8a91260e.dynamicTableIndex
        // call: p406baf6c.getSTATIC_HEADER_TABLE
        // call: List<object>.add
        // call: Intrinsics.stringPlus
        // call: int.valueOf
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.f76425f17
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.fa9c82692
        // type: IOException
    }

    private void ReadLiteralHeaderWithIncrementalIndexingIndexedName(int P0)
    {
        // call: pbf50d5e6.<init>
        // call: p406baf6c$p8a91260e.readByteString
        // call: p406baf6c$p8a91260e.insertIntoDynamicTable
        // call: p406baf6c$p8a91260e.getName
        // type: pbf50d5e6
    }

    private void ReadLiteralHeaderWithIncrementalIndexingNewName()
    {
        // call: p406baf6c.checkLowercase
        // call: pbf50d5e6.<init>
        // call: p406baf6c$p8a91260e.readByteString
        // call: p406baf6c$p8a91260e.insertIntoDynamicTable
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.f76425f17
        // type: pbf50d5e6
    }

    private void ReadLiteralHeaderWithoutIndexingIndexedName(int P0)
    {
        // call: List<object>.add
        // call: p406baf6c$p8a91260e.readByteString
        // call: pbf50d5e6.<init>
        // call: p406baf6c$p8a91260e.getName
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.fa9c82692
        // type: pbf50d5e6
    }

    private void ReadLiteralHeaderWithoutIndexingNewName()
    {
        // call: p406baf6c$p8a91260e.readByteString
        // call: p406baf6c.checkLowercase
        // call: pbf50d5e6.<init>
        // call: List<object>.add
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.fa9c82692
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.f76425f17
        // type: pbf50d5e6
    }

    public List<object> GetAndResetHeaderList()
    {
        // call: List<object>.clear
        // call: CollectionsKt.toList
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.fa9c82692
        return default!;
    }

    public int MaxDynamicTableByteCount()
    {
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f0a050724
        return 0;
    }

    public p58efa9e8 ReadByteString()
    {
        // call: pcc81e3f6.readByteString
        // call: p3342ecec.decode
        // call: p406baf6c$p8a91260e.readByte
        // call: p7e62bc34.readByteString
        // call: p406baf6c$p8a91260e.readInt
        // call: p7e62bc34.<init>
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p3342ecec.f76425f17
        // type: p7e62bc34
        return default!;
    }

    public void ReadHeaders()
    {
        // str: "index == 0"
        // str: "Invalid dynamic table size update "
        // call: IOException.<init>
        // call: p406baf6c$p8a91260e.readInt
        // call: p406baf6c$p8a91260e.adjustDynamicTableByteCount
        // call: Intrinsics.stringPlus
        // call: int.valueOf
        // call: p406baf6c$p8a91260e.readLiteralHeaderWithIncrementalIndexingIndexedName
        // call: pcc81e3f6.readByte
        // call: pcc81e3f6.exhausted
        // call: p406baf6c$p8a91260e.readIndexedHeader
        // call: p406baf6c$p8a91260e.readLiteralHeaderWithIncrementalIndexingNewName
        // call: p406baf6c$p8a91260e.readLiteralHeaderWithoutIndexingIndexedName
        // call: p406baf6c$p8a91260e.readLiteralHeaderWithoutIndexingNewName
        // call: p23e8a4b4.and
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f0a050724
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f36cd38f4
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$p8a91260e.f9a72012e
        // type: IOException
    }

    public int ReadInt(int P0, int P1)
    {
        // call: p406baf6c$p8a91260e.readByte
        return 0;
    }

}
