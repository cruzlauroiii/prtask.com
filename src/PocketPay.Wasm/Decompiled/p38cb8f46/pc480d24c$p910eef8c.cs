namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0018\u0010\t\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0018\u0010\n\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\u0010\u0010\u000b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\f\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\r\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0010\u0010\u000e\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007¨\u0006\u000f"}, d2 = {"Lp38cb8f46/pc480d24c$p910eef8c;", "", "()V", "hmacSha1", "Lp38cb8f46/pc480d24c;", "source", "Lp38cb8f46/pf31bbdd1;", "key", "Lp38cb8f46/p58efa9e8;", "hmacSha256", "hmacSha512", "md5", "sha1", "sha256", "sha512", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pc480d24c$p910eef8c {
    private pc480d24c$p910eef8c() {
    }

    public pc480d24c$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pc480d24c HmacSha1(p38cb8f46.pf31bbdd1 source, p38cb8f46.p58efa9e8 key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return new p38cb8f46.pc480d24c(source, key, "HmacSHA1");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pc480d24c HmacSha256(p38cb8f46.pf31bbdd1 source, p38cb8f46.p58efa9e8 key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return new p38cb8f46.pc480d24c(source, key, "HmacSHA256");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pc480d24c HmacSha512(p38cb8f46.pf31bbdd1 source, p38cb8f46.p58efa9e8 key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        return new p38cb8f46.pc480d24c(source, key, "HmacSHA512");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pc480d24c Md5(p38cb8f46.pf31bbdd1 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return new p38cb8f46.pc480d24c(source, "MD5");
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pc480d24c Sha1(p38cb8f46.pf31bbdd1 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return new p38cb8f46.pc480d24c(source, com.decryptstringmanager.Decryptstring.decryptstring("62d463a1987875900c641582afd75ea0c1a2100a7afabcdfbe1ea1dee91b256a42"));
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pc480d24c Sha256(p38cb8f46.pf31bbdd1 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return new p38cb8f46.pc480d24c(source, com.decryptstringmanager.Decryptstring.decryptstring("08a84b060dc375a806618d2183aade19011b2626fb50ad7e4928b8a57c31561653715b"));
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.pc480d24c Sha512(p38cb8f46.pf31bbdd1 source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        return new p38cb8f46.pc480d24c(source, com.decryptstringmanager.Decryptstring.decryptstring("5b0ba421d7ef6de178f04da0b840014db980849685cc6d0bacfa5b85db820e26bda1f0"));
    }
}

