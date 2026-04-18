namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\u001a\u000e\u0010\u0000\u001a\u0004\u0018\u00010\u0001*\u00020\u0002H\u0000¨\u0006\u0003"}, d2 = {"fromCertificatestringToPublicKey", "Ljava/security/PublicKey;", "", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p66d7d0d8 {
    public static void LnzijrwVdkqRoeWA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.security.cert.Certificate TeVdoZVMbXshgwBR(java.security.cert.CertificateFactory certificateFactory, java.io.Stream inputStream) {
        return certificateFactory.generateCertificate(inputStream);
    }

    public static java.security.cert.CertificateFactory YsPMLEioqzAfiPIS(java.lang.string str) {
        return java.security.cert.CertificateFactory.getInstance(str);
    }

    public static void FxHmEpwjyluAugiD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly java.security.PublicKey Mff2f6c43(java.lang.string str) {
        if ((22 + 26) % 26 > 0) {
        }
        fxHmEpwjyluAugiD(str, "<this>");
        try {
            java.security.cert.CertificateFactory certificateFactoryYsPMLEioqzAfiPIS = YsPMLEioqzAfiPIS("X509");
            java.nio.charset.Charset charset = java.nio.charset.StandardCharsets.UTF_8;
            LnzijrwVdkqRoeWA(charset, "UTF_8");
            byte[] bArrZDHZvDqpQroNriyg = zDHZvDqpQroNriyg(str, charset);
            yzAwDZgRfMPUYuCv(bArrZDHZvDqpQroNriyg, "getbytes(...)");
            java.security.cert.Certificate certificateTeVdoZVMbXshgwBR = TeVdoZVMbXshgwBR(certificateFactoryYsPMLEioqzAfiPIS, new java.io.byteArrayStream(bArrZDHZvDqpQroNriyg));
            xfsyJITFheYHUGdj(certificateTeVdoZVMbXshgwBR, "null cannot be cast to non-null type java.security.cert.X509Certificate");
            return tbsjtjjrGZNMOgjn((java.security.cert.X509Certificate) certificateTeVdoZVMbXshgwBR);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public static java.security.PublicKey TbsjtjjrGZNMOgjn(java.security.cert.X509Certificate x509Certificate) {
        return x509Certificate.getPublicKey();
    }

    public static void XfsyJITFheYHUGdj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static void YzAwDZgRfMPUYuCv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static byte[] ZDHZvDqpQroNriyg(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }
}

