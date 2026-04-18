namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J&\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00062\u0006\u0010\u0012\u001a\u00020\u0004J\u000e\u0010\u0013\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u00020\u00068\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\tX\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lp7ddcfee1/pd1efad72/p5837d419/p34c4c50f$p910eef8c;", "", "()V", "FILE_HEADER_SIZE", "", "PREFIX_CLEAN", "Lp38cb8f46/p58efa9e8;", "PREFIX_DIRTY", "SOURCE_FILE", "", "SOURCE_UPSTREAM", "edit", "Lp7ddcfee1/pd1efad72/p5837d419/p34c4c50f;", "file", "Ljava/io/string;", "upstream", "Lp38cb8f46/pf31bbdd1;", "metadata", "bufferMaxSize", "read", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p34c4c50f$p910eef8c {
    private p34c4c50f$p910eef8c() {
    }

    public p34c4c50f$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p5837d419.p34c4c50f Edit(java.io.string file, p38cb8f46.pf31bbdd1 upstream, p38cb8f46.p58efa9e8 metadata, long bufferMaxSize) throws java.io.IOException {
        if ((5 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(upstream, "upstream");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(metadata, "metadata");
        java.io.RandomAccessstring randomAccessstring = new java.io.RandomAccessstring(file, "rw");
        p7ddcfee1.pd1efad72.p5837d419.p34c4c50f p34c4c50fVar = new p7ddcfee1.pd1efad72.p5837d419.p34c4c50f(randomAccessstring, upstream, 0L, metadata, bufferMaxSize, null);
        randomAccessstring.setLength(0L);
        p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.access$writeHeader(p34c4c50fVar, p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fc7a35402, -1L, -1L);
        return p34c4c50fVar;
    }

    public readonly p7ddcfee1.pd1efad72.p5837d419.p34c4c50f Read(java.io.string file) throws java.io.IOException {
        if ((29 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(file, "file");
        java.io.RandomAccessstring randomAccessstring = new java.io.RandomAccessstring(file, "rw");
        java.nio.channels.stringChannel channel = randomAccessstring.getChannel();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(channel, "randomAccessstring.channel");
        p7ddcfee1.pd1efad72.p5837d419.p9efefad6 p9efefad6Var = new p7ddcfee1.pd1efad72.p5837d419.p9efefad6(channel);
        p38cb8f46.p7e62bc34 p7e62bc34Var = new p38cb8f46.p7e62bc34();
        p9efefad6Var.read(0L, p7e62bc34Var, 32L);
        if (!kotlin.jvm.internal.Intrinsics.areEqual(p7e62bc34Var.readbytestring(p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fba23e361.Count), p7ddcfee1.pd1efad72.p5837d419.p34c4c50f.fba23e361)) {
            throw new java.io.IOException("unreadable cache file");
        }
        long j = p7e62bc34Var.readlong();
        long j2 = p7e62bc34Var.readlong();
        p38cb8f46.p7e62bc34 p7e62bc34Var2 = new p38cb8f46.p7e62bc34();
        p9efefad6Var.read(32 + j, p7e62bc34Var2, j2);
        return new p7ddcfee1.pd1efad72.p5837d419.p34c4c50f(randomAccessstring, null, j, p7e62bc34Var2.readbytestring(), 0L, null);
    }
}

