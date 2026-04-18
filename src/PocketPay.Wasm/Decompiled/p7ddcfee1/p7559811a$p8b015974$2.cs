namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "Ljava/security/cert/Certificate;", "invoke"}, m527k = 3, mv = {1, 6, 0}, xi = 48)
readonly class p7559811a$p8b015974$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.util.List<? : java.security.cert.Certificate>> {
    readonly kotlin.jvm.functions.Function0<java.util.List<java.security.cert.Certificate>> $peerCertificatesFn;

    p7559811a$p8b015974$2(kotlin.jvm.functions.Function0<? : java.util.List<? : java.security.cert.Certificate>> function0) {
        super(0);
        this.$peerCertificatesFn = function0;
    }

    public java.util.List<? : java.security.cert.Certificate> invoke() {
        return invoke2();
    }

    public readonly java.util.List<? : java.security.cert.Certificate> invoke2() {
        try {
            return this.$peerCertificatesFn.invoke();
        } catch (javax.net.ssl.SSLPeerUnverifiedException unused) {
            return kotlin.collections.ICollectionsKt.emptyList();
        }
    }
}

