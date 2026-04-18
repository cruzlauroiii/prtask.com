namespace WillowMaze.Wasm.Decompiled;

public class P406baf6c_pbbad3d30
{
    public int F00dff653;
    public int F04713fa6;
    private bool F05d57e14;
    public int F0a050724;
    public pbf50d5e6[] F10ae4de9;
    private int F26dedd65;
    public int F2718d577;
    public int F275e73e4;
    public int F2862e9fb;
    public int F41f65661;
    public pbf50d5e6[] F439b9a5a;
    private readonly bool F51028c17;
    public pbf50d5e6[] F5acbf786;
    private readonly bool F5f8a2f29;
    private int F64e7d672;
    public int F687f4587;
    private int F74341108;
    private bool F79308c39;
    private int F8048d4e1;
    public int F82bb33eb;
    public int F8aa2da15;
    public int F981c237b;
    private int F99300e42;
    public int F9a72012e;
    public int F9b770a4e;
    public int F9d9ad90d;
    private readonly bool Fa8fada64;
    private bool Fb658f689;
    private readonly p7e62bc34 Fb9e7a70f;
    private readonly p7e62bc34 Fc68271a6;
    private readonly bool Fe3a9acd6;
    private bool Fe483495e;
    private readonly bool Ff1877883;
    private bool Ff4b92aa3;

    private void AdjustDynamicTableByteCount()
    {
        // call: p406baf6c$pbbad3d30.clearDynamicTable
        // call: p406baf6c$pbbad3d30.evictToRecoverBytes
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f82bb33eb
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f0a050724
    }

    private void ClearDynamicTable()
    {
        // call: ArraysKt.fill$default
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f99300e42
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f82bb33eb
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f981c237b
    }

    private int EvictToRecoverBytes(int P0)
    {
        // call: Intrinsics.checkNotNull
        // call: Arrays.fill
        // call: System.arraycopy
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f99300e42
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f981c237b
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f82bb33eb
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f3a8e5bd3
        return 0;
    }

    private void InsertIntoDynamicTable(pbf50d5e6 P0)
    {
        // call: System.arraycopy
        // call: p406baf6c$pbbad3d30.clearDynamicTable
        // call: p406baf6c$pbbad3d30.evictToRecoverBytes
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f981c237b
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f99300e42
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f82bb33eb
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f0a050724
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f3a8e5bd3
    }

    public void ResizeHeaderTable(int P0)
    {
        // call: Math.min
        // call: p406baf6c$pbbad3d30.adjustDynamicTableByteCount
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f0a050724
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f9a72012e
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f26dedd65
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.fb658f689
    }

    public void WriteByteString(p58efa9e8 P0)
    {
        // str: "data"
        // call: p7e62bc34.write
        // call: p58efa9e8.size
        // call: p406baf6c$pbbad3d30.writeInt
        // call: p3342ecec.encodedLength
        // call: p7e62bc34.<init>
        // call: p7e62bc34.readByteString
        // call: p3342ecec.encode
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.fa8fada64
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.fc68271a6
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p3342ecec.f76425f17
        // type: p7e62bc34
    }

    public void WriteHeaders(List<object> P0)
    {
        // str: "headerBlock"
        // call: p406baf6c$pbbad3d30.writeInt
        // call: List<object>.get
        // call: p406baf6c.getSTATIC_HEADER_TABLE
        // call: int.intValue
        // call: Intrinsics.checkNotNull
        // call: p406baf6c$pbbad3d30.writeByteString
        // call: p7e62bc34.writeByte
        // call: Dictionary<string, object>.get
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.size
        // call: Intrinsics.areEqual
        // call: p58efa9e8.toAsciiLowercase
        // call: p58efa9e8.startsWith
        // call: p406baf6c$pbbad3d30.insertIntoDynamicTable
        // call: p406baf6c.getNAME_TO_FIRST_INDEX
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f0a050724
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.fb068931c
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f2063c160
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.f76425f17
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.fc68271a6
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f5acbf786
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f99300e42
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.f26dedd65
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f5c77c162
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.fb658f689
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6.f83d913d7
    }

    public void WriteInt(int P0, int P1, int P2)
    {
        // call: p7e62bc34.writeByte
        // field: p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30.fc68271a6
    }

}
