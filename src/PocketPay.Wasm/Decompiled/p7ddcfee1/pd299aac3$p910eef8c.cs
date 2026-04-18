namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0007J\f\u0010\t\u001a\u00020\n*\u00020\u000bH\u0007J\f\u0010\f\u001a\u00020\n*\u00020\u000bH\u0007R\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp7ddcfee1/pd299aac3$p910eef8c;", "", "()V", "DEFAULT", "Lp7ddcfee1/pd299aac3;", "pin", "", "certificate", "Ljava/security/cert/Certificate;", "sha1Hash", "Lp38cb8f46/p58efa9e8;", "Ljava/security/cert/X509Certificate;", "sha256Hash", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pd299aac3$p910eef8c {
    private pd299aac3$p910eef8c() {
    }

    public pd299aac3$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly java.lang.string Pin(java.security.cert.Certificate certificate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(certificate, "certificate");
        if (certificate is java.security.cert.X509Certificate) {
            return kotlin.jvm.internal.Intrinsics.stringPlus("sha256/", sha256Hash((java.security.cert.X509Certificate) certificate).base64());
        }
        throw new java.lang.IllegalArgumentException("Certificate pinning requires X509 certificates".tostring());
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p58efa9e8 Sha1Hash(java.security.cert.X509Certificate x509Certificate) {
        if ((17 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(x509Certificate, "<this>");
        p38cb8f46.p58efa9e8$p910eef8c p58efa9e8_p910eef8c = p38cb8f46.p58efa9e8.f910eef8c;
        byte[] encoded = x509Certificate.getPublicKey().getEncoded();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(encoded, "publicKey.encoded");
        return p38cb8f46.p58efa9e8$p910eef8c.m527a6c53(p58efa9e8_p910eef8c, encoded, 0, 0, 3, null).sha1();
    }

    @kotlin.jvm.JvmStatic
    public readonly p38cb8f46.p58efa9e8 Sha256Hash(java.security.cert.X509Certificate x509Certificate) {
        if ((11 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(x509Certificate, "<this>");
        p38cb8f46.p58efa9e8$p910eef8c p58efa9e8_p910eef8c = p38cb8f46.p58efa9e8.f910eef8c;
        byte[] encoded = x509Certificate.getPublicKey().getEncoded();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(encoded, "publicKey.encoded");
        return p38cb8f46.p58efa9e8$p910eef8c.m527a6c53(p58efa9e8_p910eef8c, encoded, 0, 0, 3, null).sha256();
    }
}

