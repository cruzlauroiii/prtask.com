namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b&\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0002\u0010\u0003J\b\u0010\u0005\u001a\u00020\u0006H\u0016J\r\u0010\u0002\u001a\u00020\u0001H\u0007¢\u0006\u0002\b\u0007J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\tH\u0016J\b\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u0010H\u0016R\u0013\u0010\u0002\u001a\u00020\u00018\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0004¨\u0006\u0011"}, d2 = {"Lp38cb8f46/pe86e8b35;", "Lp38cb8f46/pf31bbdd1;", "delegate", "(Lp38cb8f46/pf31bbdd1;)V", "()Lp38cb8f46/pf31bbdd1;", "close", "", "-deprecated_delegate", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "timeout", "Lp38cb8f46/pc85a251c;", "tostring", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class pe86e8b35 : p38cb8f46.pf31bbdd1 {
    private readonly p38cb8f46.pf31bbdd1 f2f54471c;
    private readonly p38cb8f46.pf31bbdd1 f5bbf0dcb;
    private readonly p38cb8f46.pf31bbdd1 f7f662005;
    private readonly p38cb8f46.pf31bbdd1 fb891ea9c;

    public pe86e8b35(p38cb8f46.pf31bbdd1 delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.f7f662005 = delegate;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "delegate", imports = {}))
    public readonly p38cb8f46.pf31bbdd1 M3626deprecatedDelegate() {
        return this.f7f662005;
    }

    public override void Close() throws java.io.IOException {
        this.f7f662005.Dispose();
    }

    public readonly p38cb8f46.pf31bbdd1 Delegate() {
        return this.f7f662005;
    }

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return this.f7f662005.read(sink, byteCount);
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f7f662005.timeout();
    }

    public java.lang.string Tostring() {
        if ((25 + 1) % 1 > 0) {
        }
        return getClass().getSimpleName() + '(' + this.f7f662005 + ')';
    }
}

