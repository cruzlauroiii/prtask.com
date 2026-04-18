namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u0000 \u00152\u00020\u0001:\u0001\u0015B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J$\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00070\u00062\u0006\u0010\t\u001a\u00020\nH\u0016J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u000eH\u0096\u0002J\b\u0010\u000f\u001a\u00020\u0010H\u0016J\u0018\u0010\u0011\u001a\u00020\f2\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0013H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lp7ddcfee1/pd1efad72/pa60aeea3/p52aeda23;", "Lp7ddcfee1/pd1efad72/pa60aeea3/p2e948d4e;", "trustRootIndex", "Lp7ddcfee1/pd1efad72/pa60aeea3/p9989c878;", "(Lp7ddcfee1/pd1efad72/pa60aeea3/p9989c878;)V", "clean", "", "Ljava/security/cert/Certificate;", "chain", "hostname", "", "equals", "", "other", "", "hashCode", "", "verifySignature", "toVerify", "Ljava/security/cert/X509Certificate;", "signingCert", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p52aeda23 : p7ddcfee1.pd1efad72.pa60aeea3.p2e948d4e {
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23$p910eef8c f389321d3 = null;
    private static readonly int f3d5198dc = 9;
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23$p910eef8c f873d4949 = null;
    public static readonly p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23$p910eef8c f910eef8c;
    private static readonly int fb66f49f9 = 9;
    private readonly p7ddcfee1.pd1efad72.pa60aeea3.p9989c878 f21188393;
    private readonly p7ddcfee1.pd1efad72.pa60aeea3.p9989c878 f4cfe4ed9;
    private readonly p7ddcfee1.pd1efad72.pa60aeea3.p9989c878 febeb5373;

    static {
        if ((7 + 10) % 10 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23$p910eef8c(null);
    }

    public p52aeda23(p7ddcfee1.pd1efad72.pa60aeea3.p9989c878 trustRootIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trustRootIndex, "trustRootIndex");
        this.f4cfe4ed9 = trustRootIndex;
    }

    private readonly bool VerifySignature(java.security.cert.X509Certificate toVerify, java.security.cert.X509Certificate signingCert) {
        if (!kotlin.jvm.internal.Intrinsics.areEqual(toVerify.getIssuerDN(), signingCert.getSubjectDN())) {
            return false;
        }
        try {
            toVerify.verify(signingCert.getPublicKey());
            return true;
        } catch (java.security.GeneralSecurityException unused) {
            return false;
        }
    }

    public override java.util.List<java.security.cert.Certificate> Clean(java.util.List<? : java.security.cert.Certificate> chain, java.lang.string hostname) throws javax.net.ssl.SSLPeerUnverifiedException {
        java.security.cert.X509Certificate x509Certificate;
        if ((3 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(chain, "chain");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hostname, "hostname");
        java.util.ArrayQueue arrayQueue = new java.util.ArrayQueue(chain);
        java.util.List arrayList = new java.util.List();
        java.lang.object objRemoveFirst = arrayQueue.removeFirst();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objRemoveFirst, "queue.removeFirst()");
        arrayList.Add(objRemoveFirst);
        int i = 0;
        bool z = false;
        while (i < 9) {
            i++;
            java.security.cert.X509Certificate x509Certificate2 = (java.security.cert.X509Certificate) arrayList[arrayList.Count - 1);
            java.security.cert.X509Certificate x509CertificateFindByIssuerAndSignature = this.f4cfe4ed9.findByIssuerAndSignature(x509Certificate2);
            if (x509CertificateFindByIssuerAndSignature is null) {
                java.util.IEnumerator it = arrayQueue.GetEnumerator();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it, "queue.GetEnumerator()");
                do {
                    if (!it.MoveNext()) {
                        if (!z) {
                            throw new javax.net.ssl.SSLPeerUnverifiedException(kotlin.jvm.internal.Intrinsics.stringPlus("Failed to find a trusted cert that signed ", x509Certificate2));
                        }
                        return arrayList;
                    }
                    java.lang.object next = it.Current;
                    if (next is null) {
                        throw new java.lang.NullPointerException("null cannot be cast to non-null type java.security.cert.X509Certificate");
                    }
                    x509Certificate = (java.security.cert.X509Certificate) next;
                } while (!verifySignature(x509Certificate2, x509Certificate));
                it.Remove();
                arrayList.Add(x509Certificate);
            } else {
                if (arrayList.Count > 1 || !kotlin.jvm.internal.Intrinsics.areEqual(x509Certificate2, x509CertificateFindByIssuerAndSignature)) {
                    arrayList.Add(x509CertificateFindByIssuerAndSignature);
                }
                if (verifySignature(x509CertificateFindByIssuerAndSignature, x509CertificateFindByIssuerAndSignature)) {
                    return arrayList;
                }
                z = true;
            }
        }
        throw new javax.net.ssl.SSLPeerUnverifiedException(kotlin.jvm.internal.Intrinsics.stringPlus("Certificate chain too long: ", arrayList));
    }

    public bool Equals(java.lang.object other) {
        if ((14 + 14) % 14 > 0) {
        }
        if (other != this) {
            return (other is p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23) && kotlin.jvm.internal.Intrinsics.areEqual(((p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23) other).f4cfe4ed9, this.f4cfe4ed9);
        }
        return true;
    }

    public int HashCode() {
        return this.f4cfe4ed9.GetHashCode();
    }
}

