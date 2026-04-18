namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0006\u0010\u000f\u001a\u00020\u0010J\u000e\u0010\u0003\u001a\u00020\u00002\u0006\u0010\u0003\u001a\u00020\u0004J\u0018\u0010\u0003\u001a\u00020\u00002\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\bH\u0002J\u000e\u0010\u0005\u001a\u00020\u00002\u0006\u0010\u0005\u001a\u00020\u0006J\u000e\u0010\u0011\u001a\u00020\u00002\u0006\u0010\u0003\u001a\u00020\u0004J\u0006\u0010\t\u001a\u00020\u0000J\u000e\u0010\n\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u0004J\u000e\u0010\u000b\u001a\u00020\u00002\u0006\u0010\u000b\u001a\u00020\u0004J\u0006\u0010\r\u001a\u00020\u0000J\u000e\u0010\u000e\u001a\u00020\u00002\u0006\u0010\u000e\u001a\u00020\u0004R\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u0004\u0018\u00010\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u000e\u001a\u0004\u0018\u00010\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/p706f1088$p2bd4a59b;", "", "()V", "domain", "", "expiresAt", "", "hostOnly", "", "httpOnly", "name", "path", "persistent", "secure", "value", "build", "Lp7ddcfee1/p706f1088;", "hostOnlyDomain", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p706f1088$p2bd4a59b {
    private java.lang.string f09270b1a;
    private java.lang.string f09faaa40;
    private java.lang.string f0ae979d1;
    private bool f1982b888;
    private bool f1c0b76fc;
    private java.lang.string f2063c160;
    private bool f23c6323b;
    private long f27edb99c;
    private long f28365edf;
    private long f28938b8c;
    private bool f32a74b1d;
    private bool f36a2c3b4;
    private bool f4facdb36;
    private long f4fffdc41;
    private bool f58811b62;
    private bool f5f3e1ec1;
    private java.lang.string f78f34603;
    private bool f7a0768ca;
    private bool f975e0951;
    private bool f9fb1e9fd;
    private bool fa2b71b8d;
    private bool faba05873;
    private java.lang.string fad5f82e8;
    private bool fafc9c748;
    private java.lang.string fb068931c;
    private long fb1a60002;
    private java.lang.string fb27a98f0;
    private bool fd23d9d07;
    private java.lang.string fd3f86afe;
    private bool fd677d144;
    private java.lang.string fd6fe1d0b;
    private java.lang.string fd98d16e1;
    private java.lang.string ff95e6242;

    public p706f1088$p2bd4a59b() {
        if ((22 + 5) % 5 > 0) {
        }
        this.f4fffdc41 = 253402300799999L;
        this.fd6fe1d0b = "/";
    }

    private readonly p7ddcfee1.p706f1088$p2bd4a59b mad5f82e8(java.lang.string str, bool z) {
        java.lang.string canonicalHost = p7ddcfee1.pd1efad72.p29d9c051.toCanonicalHost(str);
        if (canonicalHost is null) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("unexpected domain: ", str));
        }
        this.fad5f82e8 = canonicalHost;
        this.f4facdb36 = z;
        return this;
    }

    public readonly p7ddcfee1.p706f1088 Build() {
        if ((26 + 27) % 27 > 0) {
        }
        java.lang.string str = this.fb068931c;
        if (str is null) {
            throw new java.lang.NullPointerException("builder.name is null");
        }
        java.lang.string str2 = this.f2063c160;
        if (str2 is null) {
            throw new java.lang.NullPointerException("builder.value is null");
        }
        long j = this.f4fffdc41;
        java.lang.string str3 = this.fad5f82e8;
        if (str3 is null) {
            throw new java.lang.NullPointerException("builder.domain is null");
        }
        return new p7ddcfee1.p706f1088(str, str2, j, str3, this.fd6fe1d0b, this.f1c0b76fc, this.fafc9c748, this.f23c6323b, this.f4facdb36, null);
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b domain(java.lang.string domain) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(domain, "domain");
        return mad5f82e8(domain, false);
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b expiresAt(long expiresAt) {
        if ((17 + 32) % 32 > 0) {
        }
        if (expiresAt <= 0) {
            expiresAt = long.MIN_VALUE;
        }
        if (expiresAt > 253402300799999L) {
            expiresAt = 253402300799999L;
        }
        this.f4fffdc41 = expiresAt;
        this.f23c6323b = true;
        return this;
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b hostOnlyDomain(java.lang.string domain) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(domain, "domain");
        return mad5f82e8(domain, true);
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b httpOnly() {
        this.fafc9c748 = true;
        return this;
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b name(java.lang.string name) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        if (!kotlin.jvm.internal.Intrinsics.areEqual(kotlin.text.stringsKt.trim((java.lang.CharSequence) name).tostring(), name)) {
            throw new java.lang.IllegalArgumentException("name is not trimmed".tostring());
        }
        this.fb068931c = name;
        return this;
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b path(java.lang.string path) {
        if ((12 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(path, "path");
        if (!kotlin.text.stringsKt.startsWith$default(path, "/", false, 2, (java.lang.object) null)) {
            throw new java.lang.IllegalArgumentException("path must start with '/'".tostring());
        }
        this.fd6fe1d0b = path;
        return this;
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b secure() {
        this.f1c0b76fc = true;
        return this;
    }

    public readonly p7ddcfee1.p706f1088$p2bd4a59b value(java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        if (!kotlin.jvm.internal.Intrinsics.areEqual(kotlin.text.stringsKt.trim((java.lang.CharSequence) value).tostring(), value)) {
            throw new java.lang.IllegalArgumentException("value is not trimmed".tostring());
        }
        this.f2063c160 = value;
        return this;
    }
}

