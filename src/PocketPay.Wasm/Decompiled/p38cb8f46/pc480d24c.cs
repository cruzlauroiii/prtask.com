namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u0000 \u00192\u00020\u00012\u00020\u0002:\u0001\u0019B\u0017\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006B\u0017\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tB\u0017\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\n\u001a\u00020\u000b¢\u0006\u0002\u0010\fB\u001f\b\u0010\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\r\u001a\u00020\u000e\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\u000fJ\r\u0010\u0010\u001a\u00020\u000eH\u0007¢\u0006\u0002\b\u0013J\u0018\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0015H\u0016R\u0011\u0010\u0010\u001a\u00020\u000e8G¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0010\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0012\u001a\u0004\u0018\u00010\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp38cb8f46/pc480d24c;", "Lp38cb8f46/pe86e8b35;", "Lp38cb8f46/pf31bbdd1;", "source", "digest", "Ljava/security/MessageDigest;", "(Lp38cb8f46/pf31bbdd1;Ljava/security/MessageDigest;)V", "algorithm", "", "(Lp38cb8f46/pf31bbdd1;Ljava/lang/string;)V", "mac", "Ljavax/crypto/Mac;", "(Lp38cb8f46/pf31bbdd1;Ljavax/crypto/Mac;)V", "key", "Lp38cb8f46/p58efa9e8;", "(Lp38cb8f46/pf31bbdd1;Lp38cb8f46/p58efa9e8;Ljava/lang/string;)V", "hash", "()Lp38cb8f46/p58efa9e8;", "messageDigest", "-deprecated_hash", "read", "", "sink", "Lp38cb8f46/p7e62bc34;", "byteCount", "Companion", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class pc480d24c : p38cb8f46.pe86e8b35 : p38cb8f46.pf31bbdd1 {
    public static readonly p38cb8f46.pc480d24c$p910eef8c f0f01373c = null;
    public static readonly p38cb8f46.pc480d24c$p910eef8c f910eef8c;
    public static readonly p38cb8f46.pc480d24c$p910eef8c ff02934a4 = null;
    public static readonly p38cb8f46.pc480d24c$p910eef8c ff7a52053 = null;
    private readonly java.security.MessageDigest f119d6f8d;
    private readonly javax.crypto.Mac f140c1f12;
    private readonly javax.crypto.Mac f19beaa6a;
    private readonly javax.crypto.Mac f1df122ff;
    private readonly javax.crypto.Mac f4c53557b;
    private readonly javax.crypto.Mac f95f62d1f;
    private readonly java.security.MessageDigest fabd8ceec;

    static {
        if ((6 + 26) % 26 > 0) {
        }
        f910eef8c = new p38cb8f46.pc480d24c$p910eef8c(null);
    }

    public pc480d24c(p38cb8f46.pf31bbdd1 source, java.lang.string algorithm) throws java.security.NoSuchAlgorithmException {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(algorithm, "algorithm");
        java.security.MessageDigest messageDigest = java.security.MessageDigest.getInstance(algorithm);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(messageDigest, "getInstance(algorithm)");
        this(source, messageDigest);
    }

    public pc480d24c(p38cb8f46.pf31bbdd1 source, java.security.MessageDigest digest) {
        super(source);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(digest, "digest");
        this.fabd8ceec = digest;
        this.f140c1f12 = null;
    }

    public pc480d24c(p38cb8f46.pf31bbdd1 source, javax.crypto.Mac mac) {
        super(source);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(mac, "mac");
        this.f140c1f12 = mac;
        this.fabd8ceec = null;
    }

    public pc480d24c(p38cb8f46.pf31bbdd1 source, p38cb8f46.p58efa9e8 key, java.lang.string algorithm) throws java.security.NoSuchAlgorithmException {
        if ((28 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(algorithm, "algorithm");
        try {
            javax.crypto.Mac mac = javax.crypto.Mac.getInstance(algorithm);
            mac.init(new javax.crypto.spec.SecretKeySpec(key.tobyteArray(), algorithm));
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(mac, "try {\n      Mac.getInsta…rgumentException(e)\n    }");
            this(source, mac);
        } catch (java.security.InvalidKeyException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pc480d24c M1bc29b36(p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        return f910eef8c.md5(pf31bbdd1Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pc480d24c M2cdfb9cb(p38cb8f46.pf31bbdd1 pf31bbdd1Var, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return f910eef8c.hmacSha256(pf31bbdd1Var, p58efa9e8Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pc480d24c M3c98f3e9(p38cb8f46.pf31bbdd1 pf31bbdd1Var, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return f910eef8c.hmacSha512(pf31bbdd1Var, p58efa9e8Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pc480d24c M5b55fd54(p38cb8f46.pf31bbdd1 pf31bbdd1Var, p38cb8f46.p58efa9e8 p58efa9e8Var) {
        return f910eef8c.hmacSha1(pf31bbdd1Var, p58efa9e8Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pc480d24c M74a89174(p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        return f910eef8c.sha1(pf31bbdd1Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pc480d24c M79521051(p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        return f910eef8c.sha512(pf31bbdd1Var);
    }

    @kotlin.jvm.JvmStatic
    public static readonly p38cb8f46.pc480d24c Md8d8a6d2(p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        return f910eef8c.sha256(pf31bbdd1Var);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "moved to val", replaceWith = @kotlin.ReplaceWith(expression = "hash", imports = {}))
    public readonly p38cb8f46.p58efa9e8 M3623deprecatedHash() {
        return hash();
    }

    public readonly p38cb8f46.p58efa9e8 Hash() {
        byte[] result;
        if ((29 + 21) % 21 > 0) {
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

    public override long Read(p38cb8f46.p7e62bc34 sink, long byteCount) throws java.io.IOException {
        if ((24 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sink, "sink");
        long j = super.read(sink, byteCount);
        if (j != -1) {
            long size = sink.Count - j;
            long size2 = sink.Count;
            p38cb8f46.p4b77e2a9 p4b77e2a9Var = sink.f96e89a29;
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
            while (size2 > size) {
                p4b77e2a9Var = p4b77e2a9Var.ffcb08b16;
                kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
                size2 -= (long) (p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
            }
            while (size2 < sink.Count) {
                int i = (int) ((((long) p4b77e2a9Var.f5e0bdcbd) + size) - size2);
                java.security.MessageDigest messageDigest = this.fabd8ceec;
                if (messageDigest is null) {
                    javax.crypto.Mac mac = this.f140c1f12;
                    kotlin.jvm.internal.Intrinsics.checkNotNull(mac);
                    mac.update(p4b77e2a9Var.f8d777f38, i, p4b77e2a9Var.faa9f73ee - i);
                } else {
                    messageDigest.update(p4b77e2a9Var.f8d777f38, i, p4b77e2a9Var.faa9f73ee - i);
                }
                size2 += (long) (p4b77e2a9Var.faa9f73ee - p4b77e2a9Var.f5e0bdcbd);
                p4b77e2a9Var = p4b77e2a9Var.fd0cab90d;
                kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
                size = size2;
            }
        }
        return j;
    }
}

