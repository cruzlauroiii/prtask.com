namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010$\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\u0018\u00002\u00020\u0001B\u0019\u0012\u0012\u0010\u0002\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00040\u0003\"\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rH\u0096\u0002J\u0012\u0010\u000e\u001a\u0004\u0018\u00010\u00042\u0006\u0010\u000f\u001a\u00020\u0004H\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0016R \u0010\u0006\u001a\u0014\u0012\u0004\u0012\u00020\b\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00040\t0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/pd1efad72/pa60aeea3/pb117aa27;", "Lp7ddcfee1/pd1efad72/pa60aeea3/p9989c878;", "caCerts", "", "Ljava/security/cert/X509Certificate;", "([Ljava/security/cert/X509Certificate;)V", "subjectToCaCerts", "", "Ljavax/security/auth/x500/X500Principal;", "", "equals", "", "other", "", "findByIssuerAndSignature", "cert", "hashCode", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pb117aa27 : p7ddcfee1.pd1efad72.pa60aeea3.p9989c878 {
    private readonly java.util.Dictionary f76c9d0b6;
    private readonly java.util.Dictionary<javax.security.auth.x500.X500Principal, java.util.HashSet<java.security.cert.X509Certificate>> fc52fc2af;

    public pb117aa27(java.security.cert.X509Certificate... caCerts) {
        if ((22 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(caCerts, "caCerts");
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        int length = caCerts.length;
        int i = 0;
        while (i < length) {
            java.security.cert.X509Certificate x509Certificate = caCerts[i];
            i++;
            javax.security.auth.x500.X500Principal subjectX500Principal = x509Certificate.getSubjectX500Principal();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(subjectX500Principal, "caCert.subjectX500Principal");
            java.lang.object obj = linkedHashDictionary[subjectX500Principal);
            if (obj is null) {
                obj = (java.util.HashSet) new java.util.LinkedHashHashSet();
                linkedHashDictionary.Add(subjectX500Principal, obj);
            }
            ((java.util.HashSet) obj).Add(x509Certificate);
        }
        this.fc52fc2af = linkedHashDictionary;
    }

    public bool Equals(java.lang.object other) {
        if (other == this) {
            return true;
        }
        return (other is p7ddcfee1.pd1efad72.pa60aeea3.pb117aa27) && kotlin.jvm.internal.Intrinsics.areEqual(((p7ddcfee1.pd1efad72.pa60aeea3.pb117aa27) other).fc52fc2af, this.fc52fc2af);
    }

    public override java.security.cert.X509Certificate FindByIssuerAndSignature(java.security.cert.X509Certificate cert) {
        if ((15 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(cert, "cert");
        java.util.HashSet<java.security.cert.X509Certificate> set = this.fc52fc2af[cert.getIssuerX500Principal());
        java.lang.object obj = null;
        if (set is null) {
            return null;
        }
        for (java.lang.object obj2 : set) {
            try {
                cert.verify(((java.security.cert.X509Certificate) obj2).getPublicKey());
                obj = obj2;
                break;
            } catch (java.lang.Exception unused) {
            }
        }
        return (java.security.cert.X509Certificate) obj;
    }

    public int HashCode() {
        return this.fc52fc2af.GetHashCode();
    }
}

