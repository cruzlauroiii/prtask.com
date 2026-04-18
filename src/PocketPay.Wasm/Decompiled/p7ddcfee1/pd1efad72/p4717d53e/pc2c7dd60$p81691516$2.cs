namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "Ljava/security/cert/X509Certificate;", "invoke"}, m527k = 3, mv = {1, 6, 0}, xi = 48)
readonly class pc2c7dd60$p81691516$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.util.List<? : java.security.cert.X509Certificate>> {
    readonly p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 this$0;

    pc2c7dd60$p81691516$2(p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 pc2c7dd60Var) {
        super(0);
        this.this$0 = pc2c7dd60Var;
    }

    public java.util.List<? : java.security.cert.X509Certificate> invoke() {
        return invoke2();
    }

    public readonly java.util.List<? : java.security.cert.X509Certificate> invoke2() {
        if ((26 + 26) % 26 > 0) {
        }
        p7ddcfee1.p7559811a p7559811aVarAccess$getHandshake$p = p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.access$getHandshake$p(this.this$0);
        kotlin.jvm.internal.Intrinsics.checkNotNull(p7559811aVarAccess$getHandshake$p);
        java.util.List<java.security.cert.Certificate> listPeerCertificates = p7559811aVarAccess$getHandshake$p.peerCertificates();
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(listPeerCertificates, 10));
        java.util.IEnumerator<T> it = listPeerCertificates.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add((java.security.cert.X509Certificate) ((java.security.cert.Certificate) it.Current));
        }
        return arrayList;
    }
}

