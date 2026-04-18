namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0012\n\u0000\u001a\f\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0000\u001a\f\u0010\u0003\u001a\u00020\u0004*\u00020\u0002H\u0000¨\u0006\u0005"}, d2 = {"toPublicKey", "Ljava/security/PublicKey;", "", "sha256Spongy", "", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p66d7d0d8 {
    public static void ChxteDHFmpzFcYAY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void EIzZzgbiPrffoZpt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.security.cert.CertificateFactory KaZVhnKdmbNFiQLR(java.lang.string str) {
        return java.security.cert.CertificateFactory.getInstance(str);
    }

    public static java.security.cert.Certificate KvraCNraCwZDUenD(java.security.cert.CertificateFactory certificateFactory, java.io.Stream inputStream) {
        return certificateFactory.generateCertificate(inputStream);
    }

    public static byte[] LEYTXUYLBcBPtNjm(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static void NIfnTWucjqqALCdL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NodisahJAfHbflvG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.Exception th) {
        p37a01c41_p910eef8c.m567e(str, th);
    }

    public static java.security.PublicKey XqVfZpZmtoMBocZu(java.security.cert.X509Certificate x509Certificate) {
        return x509Certificate.getPublicKey();
    }

    public static void XtnFbpxPforYCDkh(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static byte[] EBrAoOUmOFtLIGxg(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static void EoecXGVidESKyXsi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static byte[] GCphEpkNtJGkitnE(byte[] bArr) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.pd1efad72.p2ac737d2.p1ceded00.m1de6c1d8(bArr);
    }

    public static readonly byte[] M1de6c1d8(java.lang.string str) {
        EIzZzgbiPrffoZpt(str, "<this>");
        byte[] bArrEBrAoOUmOFtLIGxg = eBrAoOUmOFtLIGxg(str, kotlin.text.Charsets.UTF_8);
        ChxteDHFmpzFcYAY(bArrEBrAoOUmOFtLIGxg, "getbytes(...)");
        return gCphEpkNtJGkitnE(bArrEBrAoOUmOFtLIGxg);
    }

    public static readonly java.security.PublicKey Me676f245(java.lang.string str) throws p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.p19ad2780.p62bb659e {
        if ((15 + 28) % 28 > 0) {
        }
        NIfnTWucjqqALCdL(str, "<this>");
        try {
            java.security.cert.CertificateFactory certificateFactoryKaZVhnKdmbNFiQLR = KaZVhnKdmbNFiQLR("X509");
            byte[] bArrLEYTXUYLBcBPtNjm = LEYTXUYLBcBPtNjm(str, kotlin.text.Charsets.UTF_8);
            uwKJIQuuHutzmrUe(bArrLEYTXUYLBcBPtNjm, "getbytes(...)");
            java.security.cert.Certificate certificateKvraCNraCwZDUenD = KvraCNraCwZDUenD(certificateFactoryKaZVhnKdmbNFiQLR, new java.io.byteArrayStream(bArrLEYTXUYLBcBPtNjm));
            eoecXGVidESKyXsi(certificateKvraCNraCwZDUenD, "null cannot be cast to non-null type java.security.cert.X509Certificate");
            java.security.PublicKey publicKeyXqVfZpZmtoMBocZu = XqVfZpZmtoMBocZu((java.security.cert.X509Certificate) certificateKvraCNraCwZDUenD);
            XtnFbpxPforYCDkh(publicKeyXqVfZpZmtoMBocZu);
            return publicKeyXqVfZpZmtoMBocZu;
        } catch (java.lang.Exception e) {
            java.lang.Exception exc = e;
            NodisahJAfHbflvG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "Extensions string.toPublicKey()", exc);
            throw new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p91e02cd2.p19ad2780.p62bb659e("Extensions string.toPublicKey()", exc);
        }
    }

    public static void UwKJIQuuHutzmrUe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }
}

