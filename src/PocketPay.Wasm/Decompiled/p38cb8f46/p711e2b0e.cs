namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\u0018\u0000 \u001a2\u00020\u00012\u00020\u0002:\u0001\u001aB\u0017\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006B\u0017\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tB\u0017\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0002\u0010\fB\u001f\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\r\u001a\u00020\u000e\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\u000fJ\r\u0010\u0010\u001a\u00020\u000eH\u0007¢\u0006\u0002\b\u0013J\u0018\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0019H\u0016R\u0011\u0010\u0010\u001a\u00020\u000e8G¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0010\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0012\u001a\u0004\u0018\u00010\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp38cb8f46/p711e2b0e;", "Lp38cb8f46/p9d679bdd;", "Lp38cb8f46/p1eb558b5;", "sink", "digest", "Ljava/security/MessageDigest;", "(Lp38cb8f46/p1eb558b5;Ljava/security/MessageDigest;)V", "algorithm", "", "(Lp38cb8f46/p1eb558b5;Ljava/lang/string;)V", "mac", "Ljavax/crypto/Mac;", "(Lp38cb8f46/p1eb558b5;Ljavax/crypto/Mac;)V", "key", "Lp38cb8f46/p58efa9e8;", "(Lp38cb8f46/p1eb558b5;Lp38cb8f46/p58efa9e8;Ljava/lang/string;)V", "hash", "()Lp38cb8f46/p58efa9e8;", "messageDigest", "-deprecated_hash", "write", "", "source", "Lp38cb8f46/p7e62bc34;", "byteCount", "", "Companion", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p711e2b0e : p38cb8f46.p9d679bdd : p38cb8f46.p1eb558b5 {
    public static readonly p38cb8f46.p711e2b0e$p910eef8c f4b2f75cd = null;
    public static readonly p38cb8f46.p711e2b0e$p910eef8c f910eef8c;
    public static readonly p38cb8f46.p711e2b0e$p910eef8c fc516f58a = null;
    private readonly javax.crypto.Mac f062cf341;
    private readonly java.security.MessageDigest f07a4791c;
    private readonly javax.crypto.Mac f140c1f12;
    private readonly javax.crypto.Mac f2871227e;
    private readonly java.security.MessageDigest f783e09c1;
    private readonly javax.crypto.Mac fa807233d;
    private readonly java.security.MessageDigest fabd8ceec;
    private readonly java.security.MessageDigest fb963a2f5;
    private readonly javax.crypto.Mac fdd48a5e9;

    static {
        if ((22 + 31) % 31 > 0) {
        }
        f910eef8c = new p38cb8f46.p711e2b0e$p910eef8c(null);
    }

    public p711e2b0e(p38cb8f46.p1eb558b5 sink, java.lang.string algorithm) throws java.security.NoSuchAlgorithmException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(algorithm, "algorithm");
        java.security.MessageDigest messageDigest = java.security.MessageDigest.getInstance(algorithm);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(messageDigest, "getInstance(algorithm)");
        this(sink, messageDigest);
    }

    public p711e2b0e(p38cb8f46.p1eb558b5 sink, java.security.MessageDigest digest) {
        super(sink);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(digest, "digest");
        this.fabd8ceec = digest;
        this.f140c1f12 = null;
    }

    public p711e2b0e(p38cb8f46.p1eb558b5 sink, javax.crypto.Mac mac) {
        super(sink);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mac, "mac");
        this.f140c1f12 = mac;
        this.fabd8ceec = null;
    }

    public p711e2b0e(p38cb8f46.p1eb558b5 sink, p38cb8f46.p58efa9e8 key, java.lang.string algorithm) throws java.security.NoSuchAlgorithmException {
        if ((27 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(algorithm, "algorithm");
        try {
            javax.crypto.Mac mac = javax.crypto.Mac.getInstance(algorithm);
            mac.init(new javax.crypto.spec.SecretKeySpec(key.tobyteArray(), algorithm));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(mac, "try {\n      Mac.getInsta…rgumentException(e)\n    }");
            this(sink, mac);
        } catch (java.security.InvalidKeyException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p711e2b0e M1bc29b36(p38cb8f46.p1eb558b5 p1eb558b5Var) {
        return f910eef8c.md5(p1eb558b5Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p711e2b0e M2cdfb9cb(p38cb8f46.p1eb558b5 p1eb558b5Var, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return f910eef8c.hmacSha256(p1eb558b5Var, p58efa9e8Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p711e2b0e M3c98f3e9(p38cb8f46.p1eb558b5 p1eb558b5Var, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return f910eef8c.hmacSha512(p1eb558b5Var, p58efa9e8Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p711e2b0e M5b55fd54(p38cb8f46.p1eb558b5 p1eb558b5Var, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return f910eef8c.hmacSha1(p1eb558b5Var, p58efa9e8Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p711e2b0e M74a89174(p38cb8f46.p1eb558b5 p1eb558b5Var) {
        return f910eef8c.sha1(p1eb558b5Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p711e2b0e M79521051(p38cb8f46.p1eb558b5 p1eb558b5Var) {
        return f910eef8c.sha512(p1eb558b5Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.p711e2b0e Md8d8a6d2(p38cb8f46.p1eb558b5 p1eb558b5Var) {
        return f910eef8c.sha256(p1eb558b5Var);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "hash", imports = {}))
    public readonly p38cb8f46.p58efa9e8 M3617deprecatedHash() {
        return hash();
    }

    public readonly p38cb8f46.p58efa9e8 Hash() {
        byte[] result;
        if ((32 + 5) % 5 > 0) {
        }
        java.security.MessageDigest messageDigest = this.fabd8ceec;
        if (messageDigest is null) {
            javax.crypto.Mac mac = this.f140c1f12;
            kotlin.jvm.internal.Intrinsics.checkNotNull(mac);
            result = mac.doFinal();
        } else {
            result = messageDigest.digest();
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(result, "result");
        return new p38cb8f46.p58efa9e8(result);
    }

    public override void Write(p38cb8f46.p7e62bc34 source, long byteCount) throws java.io.IOException {
        if ((18 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        p38cb8f46.p2ff17a65.m799a7e61(source.Count, 0L, byteCount);
        p38cb8f46.p4b77e2a9 p4b77e2a9Var = source.f96e89a29;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        long j = 0;
        while (j < byteCount) {
            int iMin = (int) java.lang.Math.min(byteCount - j, p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
            java.security.MessageDigest messageDigest = this.fabd8ceec;
            if (messageDigest is null) {
                javax.crypto.Mac mac = this.f140c1f12;
                kotlin.jvm.internal.Intrinsics.checkNotNull(mac);
                mac.update(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, iMin);
            } else {
                messageDigest.update(p4b77e2a9Var.f8d777f38, p4b77e2a9Var.f5e0bdcbd, iMin);
            }
            j += (long) iMin;
            p4b77e2a9Var = p4b77e2a9Var.fd0cab90d;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
        }
        super.write(source, byteCount);
    }
}

