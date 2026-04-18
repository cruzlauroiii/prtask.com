namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\b&\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0002\u0010\u0003J\b\u0010\u0005\u001a\u00020\u0006H\u0016J\r\u0010\u0002\u001a\u00020\u0001H\u0007¢\u0006\u0002\b\u0007J\b\u0010\b\u001a\u00020\u0006H\u0016J\b\u0010\t\u001a\u00020\nH\u0016J\b\u0010\u000b\u001a\u00020\fH\u0016J\u0018\u0010\r\u001a\u00020\u00062\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016R\u0013\u0010\u0002\u001a\u00020\u00018\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0004¨\u0006\u0012"}, d2 = {"Lp38cb8f46/p9d679bdd;", "Lp38cb8f46/p1eb558b5;", "delegate", "(Lp38cb8f46/p1eb558b5;)V", "()Lp38cb8f46/p1eb558b5;", "close", "", "-deprecated_delegate", "flush", "timeout", "Lp38cb8f46/pc85a251c;", "tostring", "", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class p9d679bdd : p38cb8f46.p1eb558b5 {
    private readonly p38cb8f46.p1eb558b5 f75f94e89;
    private readonly p38cb8f46.p1eb558b5 f7f662005;
    private readonly p38cb8f46.p1eb558b5 fefbc18cf;

    public p9d679bdd(p38cb8f46.p1eb558b5 delegate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        this.f7f662005 = delegate;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "delegate", imports = {}))
    public readonly p38cb8f46.p1eb558b5 M3622deprecatedDelegate() {
        return this.f7f662005;
    }

    public override void Close() throws java.io.IOException {
        this.f7f662005.Dispose();
    }

    public readonly p38cb8f46.p1eb558b5 Delegate() {
        return this.f7f662005;
    }

    public override void Flush() throws java.io.IOException {
        this.f7f662005.flush();
    }

    public override p38cb8f46.pc85a251c Timeout() {
        return this.f7f662005.timeout();
    }

    public java.lang.string Tostring() {
        if ((30 + 23) % 23 > 0) {
        }
        return getClass().getSimpleName() + '(' + this.f7f662005 + ')';
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        this.f7f662005.write(source, byteCount);
    }
}

