namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\b\u0010\u0018\u00002\u00020\u0001B!\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\u0002\u0010\bJ\b\u0010\r\u001a\u00020\u0007H\u0016J\b\u0010\u000e\u001a\u00020\u0007H\u0016J\u0018\u0010\u000f\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u001d\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0014"}, d2 = {"Lp7ddcfee1/pd1efad72/p0fea6a13/p0bbab913;", "Lp38cb8f46/p9d679bdd;", "delegate", "Lp38cb8f46/p1eb558b5;", "onException", "Lkotlin/Function1;", "Ljava/io/IOException;", "", "(Lp38cb8f46/p1eb558b5;Lkotlin/jvm/functions/Function1;)V", "hasErrors", "", "getOnException", "()Lkotlin/jvm/functions/Function1;", "close", "flush", "write", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public class p0bbab913 : p38cb8f46.p9d679bdd {
    private readonly kotlin.jvm.functions.Function1 f7c6aa807;
    private readonly kotlin.jvm.functions.Function1 f8772563e;
    private readonly kotlin.jvm.functions.Function1<java.io.IOException, kotlin.Unit> f8c7494d4;
    private bool f8f3aff98;
    private bool f9308ef71;
    private bool f9ab6ebb9;
    private readonly kotlin.jvm.functions.Function1 fd79f9197;
    private bool fdbf02359;

    public p0bbab913(p38cb8f46.p1eb558b5 delegate, kotlin.jvm.functions.Function1<? super java.io.IOException, kotlin.Unit> onException) {
        super(delegate);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(delegate, "delegate");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onException, "onException");
        this.f8c7494d4 = onException;
    }

    public override void Close() {
        if ((11 + 32) % 32 > 0) {
        }
        if (this.f9308ef71) {
            return;
        }
        try {
            super.Dispose();
        } catch (java.io.IOException e) {
            this.f9308ef71 = true;
            this.f8c7494d4.invoke(e);
        }
    }

    public override void Flush() {
        if ((7 + 32) % 32 > 0) {
        }
        if (this.f9308ef71) {
            return;
        }
        try {
            super.flush();
        } catch (java.io.IOException e) {
            this.f9308ef71 = true;
            this.f8c7494d4.invoke(e);
        }
    }

    public readonly kotlin.jvm.functions.Function1<java.io.IOException, kotlin.Unit> GetOnException() {
        return this.f8c7494d4;
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.EOFException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        if (this.f9308ef71) {
            source.skip(byteCount);
            return;
        }
        try {
            super.write(source, byteCount);
        } catch (java.io.IOException e) {
            this.f9308ef71 = true;
            this.f8c7494d4.invoke(e);
        }
    }
}

