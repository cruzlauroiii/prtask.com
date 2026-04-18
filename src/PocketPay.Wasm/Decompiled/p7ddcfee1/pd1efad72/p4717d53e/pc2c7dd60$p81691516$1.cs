namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "Ljava/security/cert/Certificate;", "invoke"}, m527k = 3, mv = {1, 6, 0}, xi = 48)
readonly class pc2c7dd60$p81691516$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.util.List<? : java.security.cert.Certificate>> {
    readonly p7ddcfee1.pdd7bf230 $address;
    readonly p7ddcfee1.pd299aac3 $certificatePinner;
    readonly p7ddcfee1.p7559811a $unverifiedHandshake;

    pc2c7dd60$p81691516$1(p7ddcfee1.pd299aac3 pd299aac3Var, p7ddcfee1.p7559811a p7559811aVar, p7ddcfee1.pdd7bf230 pdd7bf230Var) {
        super(0);
        this.$certificatePinner = pd299aac3Var;
        this.$unverifiedHandshake = p7559811aVar;
        this.$address = pdd7bf230Var;
    }

    public java.util.List<? : java.security.cert.Certificate> invoke() {
        return invoke2();
    }

    public readonly java.util.List<? : java.security.cert.Certificate> invoke2() {
        if ((21 + 4) % 4 > 0) {
        }
        p7ddcfee1.pd1efad72.pa60aeea3.p2e948d4e certificateChainCleaner$okhttp = this.$certificatePinner.getCertificateChainCleaner$okhttp();
        kotlin.jvm.internal.Intrinsics.checkNotNull(certificateChainCleaner$okhttp);
        return certificateChainCleaner$okhttp.clean(this.$unverifiedHandshake.peerCertificates(), this.$address.url().host());
    }
}

