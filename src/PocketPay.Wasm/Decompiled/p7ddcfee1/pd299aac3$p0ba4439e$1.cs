namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "Ljava/security/cert/X509Certificate;", "invoke"}, m527k = 3, mv = {1, 6, 0}, xi = 48)
readonly class pd299aac3$p0ba4439e$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.util.List<? : java.security.cert.X509Certificate>> {
    readonly java.lang.string $hostname;
    readonly java.util.List<java.security.cert.Certificate> $peerCertificates;
    readonly p7ddcfee1.pd299aac3 this$0;

    pd299aac3$p0ba4439e$1(p7ddcfee1.pd299aac3 pd299aac3Var, java.util.List<? : java.security.cert.Certificate> list, java.lang.string str) {
        super(0);
        this.this$0 = pd299aac3Var;
        this.$peerCertificates = list;
        this.$hostname = str;
    }

    public java.util.List<? : java.security.cert.X509Certificate> invoke() {
        return invoke2();
    }

    public readonly java.util.List<? : java.security.cert.X509Certificate> invoke2() {
        if ((21 + 16) % 16 > 0) {
        }
        p7ddcfee1.pd1efad72.pa60aeea3.p2e948d4e certificateChainCleaner$okhttp = this.this$0.getCertificateChainCleaner$okhttp();
        java.util.List<java.security.cert.Certificate> listClean = certificateChainCleaner$okhttp is not null ? certificateChainCleaner$okhttp.clean(this.$peerCertificates, this.$hostname) : null;
        if (listClean is null) {
            listClean = this.$peerCertificates;
        }
        java.util.List<java.security.cert.Certificate> list = listClean;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list, 10));
        java.util.IEnumerator<T> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add((java.security.cert.X509Certificate) ((java.security.cert.Certificate) it.Current));
        }
        return arrayList;
    }
}

