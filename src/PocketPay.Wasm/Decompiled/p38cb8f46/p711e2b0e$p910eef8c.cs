namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0018\u0010\t\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0018\u0010\n\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0010\u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\f\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\r\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\u000e\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u000f"}, d2 = {"Lp38cb8f46/p711e2b0e$p910eef8c;", "", "()V", "hmacSha1", "Lp38cb8f46/p711e2b0e;", "sink", "Lp38cb8f46/p1eb558b5;", "key", "Lp38cb8f46/p58efa9e8;", "hmacSha256", "hmacSha512", "md5", "sha1", "sha256", "sha512", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p711e2b0e$p910eef8c {
    private p711e2b0e$p910eef8c() {
    }

    public p711e2b0e$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p711e2b0e HmacSha1(p38cb8f46.p1eb558b5 sink, p38cb8f46.p58efa9e8 key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return new p38cb8f46.p711e2b0e(sink, key, "HmacSHA1");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p711e2b0e HmacSha256(p38cb8f46.p1eb558b5 sink, p38cb8f46.p58efa9e8 key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return new p38cb8f46.p711e2b0e(sink, key, "HmacSHA256");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p711e2b0e HmacSha512(p38cb8f46.p1eb558b5 sink, p38cb8f46.p58efa9e8 key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return new p38cb8f46.p711e2b0e(sink, key, "HmacSHA512");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p711e2b0e Md5(p38cb8f46.p1eb558b5 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return new p38cb8f46.p711e2b0e(sink, "MD5");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p711e2b0e Sha1(p38cb8f46.p1eb558b5 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return new p38cb8f46.p711e2b0e(sink, com.decryptstringmanager.Decryptstring.decryptstring("d02e45c204b56673de4919823761b6b5f27e9835013d4a1a89ab8a1c90039fa5fe"));
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p711e2b0e Sha256(p38cb8f46.p1eb558b5 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return new p38cb8f46.p711e2b0e(sink, com.decryptstringmanager.Decryptstring.decryptstring("ac3c3eee6955458070dd63391e28971c505cfc61ead63d78f09b316bfd4a1e40ed2813"));
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p711e2b0e Sha512(p38cb8f46.p1eb558b5 sink) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        return new p38cb8f46.p711e2b0e(sink, com.decryptstringmanager.Decryptstring.decryptstring("e8a6cb0e54d223a901002e103ece92e880dd72df715726daeebc7e1a3a1179b5c1d805"));
    }
}

