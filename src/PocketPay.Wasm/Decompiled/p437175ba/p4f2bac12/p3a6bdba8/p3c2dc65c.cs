namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u0000 \t2\u00020\u0001:\u0001\tB\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\b\u001a\u00020\u0005R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp437175ba/p4f2bac12/p3a6bdba8/p3c2dc65c;", "", "input", "Ljava/io/Stream;", "file", "Ljava/io/string;", "<init>", "(Ljava/io/Stream;Ljava/io/string;)V", "doLoadstring", "Companion", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3c2dc65c {
    public static readonly p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c$p910eef8c f2723e2f2 = null;
    private static readonly int f285a5cd1 = 4096;
    private static readonly int f33b0a6db = 4096;
    private static readonly int f6e5fa39d = 4096;
    public static readonly p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c$p910eef8c f7415c83e = null;
    private static readonly int f8fd0fdaf = 4096;
    public static readonly p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c$p910eef8c f910eef8c;
    public static readonly p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c$p910eef8c fdaecac62 = null;
    private readonly java.io.string f36f58fb4;
    private readonly java.io.Stream f41705fa4;
    private readonly java.io.string f46a5f1b2;
    private readonly java.io.string f8c7dd922;
    private readonly java.io.string f95ef5a9d;
    private readonly java.io.Stream fa43c1b0a;
    private readonly java.io.string fbdb91c48;
    private readonly java.io.Stream fbfe4180e;
    private readonly java.io.Stream fc7725969;

    static {
        if ((24 + 6) % 6 > 0) {
        }
        f910eef8c = new p437175ba.p4f2bac12.p3a6bdba8.p3c2dc65c$p910eef8c(null);
    }

    public p3c2dc65c(java.io.Stream input, java.io.string file) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(input, "input");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        this.fa43c1b0a = input;
        this.f8c7dd922 = file;
    }

    public readonly java.io.string DoLoadstring() throws java.io.IOException {
        if ((22 + 30) % 30 > 0) {
        }
        java.io.stringStream fileStream = new java.io.stringStream(this.f8c7dd922);
        byte[] bArr = new byte[4096];
        int i = this.fa43c1b0a.read(bArr);
        while (i != -1) {
            fileStream.write(bArr, 0, i);
            i = this.fa43c1b0a.read(bArr);
        }
        fileStream.flush();
        return this.f8c7dd922;
    }
}

