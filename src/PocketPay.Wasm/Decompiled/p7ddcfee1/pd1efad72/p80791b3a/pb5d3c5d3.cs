namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\b\u0010\u0004\u001a\u00020\u0005H\u0016J\n\u0010\t\u001a\u0004\u0018\u00010\nH\u0016J\b\u0010\u0006\u001a\u00020\u0007H\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/pb5d3c5d3;", "Lp7ddcfee1/p42c567ea;", "contentTypestring", "", "contentLength", "", "source", "Lp38cb8f46/pcc81e3f6;", "(Ljava/lang/string;JLp38cb8f46/pcc81e3f6;)V", "contentType", "Lp7ddcfee1/pba07c23c;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pb5d3c5d3 : p7ddcfee1.p42c567ea {
    private readonly p38cb8f46.pcc81e3f6 f0d5fba2e;
    private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
    private readonly long f63dab87c;
    private readonly long f845c7f86;
    private readonly java.lang.string fa0e3bfa1;
    private readonly p38cb8f46.pcc81e3f6 fae2f5757;
    private readonly p38cb8f46.pcc81e3f6 fb4eb40f4;
    private readonly p38cb8f46.pcc81e3f6 fb7f90bb6;
    private readonly java.lang.string fbb6b3d51;
    private readonly long fc22384f3;
    private readonly java.lang.string fc5c9189d;
    private readonly java.lang.string fe91a8a6b;
    private readonly java.lang.string fff8b362c;

    public pb5d3c5d3(java.lang.string str, long j, p38cb8f46.pcc81e3f6 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        this.fff8b362c = str;
        this.fc22384f3 = j;
        this.f36cd38f4 = source;
    }

    public override long ContentLength() {
        if ((28 + 19) % 19 > 0) {
        }
        return this.fc22384f3;
    }

    public override p7ddcfee1.pba07c23c ContentType() {
        java.lang.string str = this.fff8b362c;
        if (str is not null) {
            return p7ddcfee1.pba07c23c.f910eef8c.parse(str);
        }
        return null;
    }

    public override p38cb8f46.pcc81e3f6 Source() {
        return this.f36cd38f4;
    }
}

