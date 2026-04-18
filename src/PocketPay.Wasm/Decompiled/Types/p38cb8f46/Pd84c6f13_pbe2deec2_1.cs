namespace WillowMaze.Wasm.Decompiled;

public class Pd84c6f13_pbe2deec2_1 : Stream
{
    private readonly pd84c6f13 This$0;

    public void Close()
    {
        // call: pd84c6f13.close
        // field: p38cb8f46.pd84c6f13$pbe2deec2$1.this$0
    }

    public void Flush()
    {
        // call: pd84c6f13.flush
        // field: p38cb8f46.pd84c6f13$pbe2deec2$1.this$0
        // field: p38cb8f46.pd84c6f13.f349e6863
    }

    public string ToString()
    {
        // str: ".outputStream()"
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: p38cb8f46.pd84c6f13$pbe2deec2$1.this$0
        // type: StringBuilder
        return string.Empty;
    }

    public void Write(int P0)
    {
        // str: "closed"
        // call: IOException.<init>
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.writeByte
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // field: p38cb8f46.pd84c6f13$pbe2deec2$1.this$0
        // type: IOException
    }

    public void Write(byte[] P0, int P1, int P2)
    {
        // str: "data"
        // str: "closed"
        // call: IOException.<init>
        // call: pd84c6f13.emitCompleteSegments
        // call: p7e62bc34.write
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.pd84c6f13$pbe2deec2$1.this$0
        // field: p38cb8f46.pd84c6f13.ff4547fa3
        // field: p38cb8f46.pd84c6f13.f349e6863
        // type: IOException
    }

}
