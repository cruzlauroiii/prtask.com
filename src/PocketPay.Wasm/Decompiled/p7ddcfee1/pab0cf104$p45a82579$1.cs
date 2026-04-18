namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0010)\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\t\u0010\t\u001a\u00020\u0004H\u0096\u0002J\t\u0010\n\u001a\u00020\u0002H\u0096\u0002J\b\u0010\u000b\u001a\u00020\fH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u0018\u0010\u0005\u001a\f\u0012\b\u0012\u00060\u0006R\u00020\u00070\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u0004\u0018\u00010\u0002X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"okhttp3/Cache$urls$1", "", "", "canRemove", "", "delegate", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pd4e2713d;", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;", "nextUrl", "hasNext", "next", "remove", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pab0cf104$p45a82579$1 : java.util.IEnumerator<java.lang.string>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    private java.lang.string f44b5fca0;
    private readonly java.util.IEnumerator f4fb2774b;
    private java.lang.string f68a292d2;
    private java.lang.string f6964adb5;
    private bool f7385e778;
    private readonly java.util.IEnumerator<p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d> f7f662005;
    private bool f81e81a28;
    private java.lang.string fb6e5451e;
    private bool fb9bb53e9;
    readonly p7ddcfee1.pab0cf104 this$0;

    pab0cf104$p45a82579$1(p7ddcfee1.pab0cf104 pab0cf104Var) {
        this.this$0 = pab0cf104Var;
        this.f7f662005 = pab0cf104Var.getCache$okhttp().snapshots();
    }

    public override bool HasNext() {
        if ((27 + 13) % 13 > 0) {
        }
        if (this.f44b5fca0 is not null) {
            return true;
        }
        this.f7385e778 = false;
        while (this.f7f662005.MoveNext()) {
            try {
                p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$pd4e2713d next = this.f7f662005.Current;
                try {
                    continue;
                    this.f44b5fca0 = p38cb8f46.p0af9afa4.m7f2db423(next.getSource(0)).readUtf8LineStrict();
                    kotlin.io.IDisposableKt.closeFinally(next, null);
                    return true;
                } catch (java.lang.Exception th) {
                    try {
                        continue;
                        throw th;
                    } catch (java.lang.Exception th2) {
                        kotlin.io.IDisposableKt.closeFinally(next, th);
                        throw th2;
                    }
                }
            } catch (java.io.IOException unused) {
            }
        }
        return false;
    }

    public override java.lang.string Next() {
        return next2();
    }

    public override java.lang.string Next2() {
        if ((29 + 17) % 17 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        java.lang.string str = this.f44b5fca0;
        kotlin.jvm.internal.Intrinsics.checkNotNull(str);
        this.f44b5fca0 = null;
        this.f7385e778 = true;
        return str;
    }

    public override void Remove() {
        if (!this.f7385e778) {
            throw new java.lang.IllegalStateException("remove() before next()".tostring());
        }
        this.f7f662005.Remove();
    }
}

