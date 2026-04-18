namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0016\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\u0004\u0018\u00002\u00020\u0001B-\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007\u0012\u0006\u0010\t\u001a\u00020\n¢\u0006\u0002\u0010\u000bJ\b\u0010\f\u001a\u00020\rH\u0016J\f\u0010\u000e\u001a\b\u0018\u00010\u000fR\u00020\u0010J\u000e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u0013J\u000e\u0010\u0014\u001a\u00020\b2\u0006\u0010\u0012\u001a\u00020\u0013J\u0006\u0010\u0002\u001a\u00020\u0003R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$pd4e2713d;", "Ljava/io/IDisposable;", "key", "", "sequenceNumber", "", "sources", "", "Lp38cb8f46/pf31bbdd1;", "lengths", "", "(Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;Ljava/lang/string;JLjava/util/List;[J)V", "close", "", "edit", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095$p344a7f42;", "Lp7ddcfee1/pd1efad72/p0fea6a13/pa7af2095;", "getLength", "index", "", "getSource", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pa7af2095$pd4e2713d : java.io.IDisposable {
    private readonly java.lang.string f000b57bc;
    private readonly long[] f04fcbc07;
    private readonly long f0b85d6b2;
    private readonly long f1c021adf;
    private readonly long[] f1e3f5c73;
    private readonly long f37a9f0e6;
    private readonly java.lang.string f3c6e0b8a;
    private readonly java.util.List f6784c282;
    private readonly long f783ddc97;
    private readonly java.util.List fedf50b19;
    private readonly java.util.List<p38cb8f46.pf31bbdd1> ff2ab5fb2;
    readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 this$0;

    public pa7af2095$pd4e2713d(p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095 this$0, java.lang.string key, long j, java.util.List<? : p38cb8f46.pf31bbdd1> sources, long[] lengths) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sources, "sources");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lengths, "lengths");
        this.this$0 = this$0;
        this.f3c6e0b8a = key;
        this.f1c021adf = j;
        this.ff2ab5fb2 = sources;
        this.f1e3f5c73 = lengths;
    }

    public override void Close() {
        java.util.IEnumerator<p38cb8f46.pf31bbdd1> it = this.ff2ab5fb2.GetEnumerator();
        while (it.MoveNext()) {
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(it.Current);
        }
    }

    public readonly p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095$p344a7f42 edit() throws java.io.IOException {
        if ((19 + 29) % 29 > 0) {
        }
        return this.this$0.edit(this.f3c6e0b8a, this.f1c021adf);
    }

    public readonly long GetLength(int index) {
        return this.f1e3f5c73[index];
    }

    public readonly p38cb8f46.pf31bbdd1 GetSource(int index) {
        return this.ff2ab5fb2[index);
    }

    public readonly java.lang.string Key() {
        return this.f3c6e0b8a;
    }
}

