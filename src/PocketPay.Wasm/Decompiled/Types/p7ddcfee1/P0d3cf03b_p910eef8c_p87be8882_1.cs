namespace WillowMaze.Wasm.Decompiled;

public class P0d3cf03b_p910eef8c_p87be8882_1 : P0d3cf03b
{
    private readonly pba07c23c $contentType;
    private readonly string $this_asRequestBody;

    public long ContentLength()
    {
        // call: string.length
        // field: p7ddcfee1.p0d3cf03b$p910eef8c$p87be8882$1.$this_asRequestBody
        return 0;
    }

    public pba07c23c ContentType()
    {
        // field: p7ddcfee1.p0d3cf03b$p910eef8c$p87be8882$1.$contentType
        return default!;
    }

    public void WriteTo(p08d84bc6 P0)
    {
        // str: "sink"
        // call: Intrinsics.checkNotNullParameter
        // call: p0af9afa4.m36cd38f4
        // call: CloseableKt.closeFinally
        // call: p08d84bc6.writeAll
        // field: p7ddcfee1.p0d3cf03b$p910eef8c$p87be8882$1.$this_asRequestBody
    }

}
