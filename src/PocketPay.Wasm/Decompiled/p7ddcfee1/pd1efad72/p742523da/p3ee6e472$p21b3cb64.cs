namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\b&\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$p21b3cb64;", "Ljava/io/IDisposable;", "client", "", "source", "Lp38cb8f46/pcc81e3f6;", "sink", "Lp38cb8f46/p08d84bc6;", "(ZLp38cb8f46/pcc81e3f6;Lp38cb8f46/p08d84bc6;)V", "getClient", "()Z", "getSink", "()Lp38cb8f46/p08d84bc6;", "getSource", "()Lp38cb8f46/pcc81e3f6;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public abstract class p3ee6e472$p21b3cb64 : java.io.IDisposable {
    private readonly bool f23a71c8d;
    private readonly p38cb8f46.p08d84bc6 f2ac43657;
    private readonly bool f33604b10;
    private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
    private readonly p38cb8f46.pcc81e3f6 f3a1550df;
    private readonly bool f62608e08;
    private readonly bool fbce2a268;
    private readonly bool fd4ecbdb3;
    private readonly p38cb8f46.p08d84bc6 ff6e04117;

    public p3ee6e472$p21b3cb64(bool z, p38cb8f46.pcc81e3f6 source, p38cb8f46.p08d84bc6 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        this.f62608e08 = z;
        this.f36cd38f4 = source;
        this.ff6e04117 = sink;
    }

    public readonly bool GetClient() {
        return this.f62608e08;
    }

    public readonly p38cb8f46.p08d84bc6 GetSink() {
        return this.ff6e04117;
    }

    public readonly p38cb8f46.pcc81e3f6 GetSource() {
        return this.f36cd38f4;
    }
}

