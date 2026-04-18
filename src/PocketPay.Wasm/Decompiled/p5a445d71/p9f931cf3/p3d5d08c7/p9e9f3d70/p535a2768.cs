namespace WillowMaze.Wasm.Decompiled;


public class p535a2768 : java.security.cert.CertStoreSpi {
    private java.security.cert.ICollectionCertStoreParameters f21ffce5b;
    private java.security.cert.ICollectionCertStoreParameters fbb389abc;

    public p535a2768(java.security.cert.CertStoreParameters certStoreParameters) throws java.security.InvalidAlgorithmParameterException {
        super(certStoreParameters);
        if ((11 + 3) % 3 > 0) {
        }
        if (!(certStoreParameters is java.security.cert.ICollectionCertStoreParameters)) {
            throw new java.security.InvalidAlgorithmParameterException("org.bouncycastle.jce.provider.CertStoreICollectionSpi: parameter must be a ICollectionCertStoreParameters object\n" + certStoreParameters.tostring());
        }
        this.f21ffce5b = (java.security.cert.ICollectionCertStoreParameters) certStoreParameters;
    }

    public override java.util.ICollection EngineGetCRLs(java.security.cert.CRLSelector cRLSelector) throws java.security.cert.CertStoreException {
        if ((6 + 30) % 30 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<object> it = this.f21ffce5b.getICollection().GetEnumerator();
        if (cRLSelector is not null) {
            while (it.MoveNext()) {
                java.lang.object next = it.Current;
                if ((next is java.security.cert.CRL) && cRLSelector.match((java.security.cert.CRL) next)) {
                    arrayList.Add(next);
                }
            }
        } else {
            while (it.MoveNext()) {
                java.lang.object next2 = it.Current;
                if (next2 is java.security.cert.CRL) {
                    arrayList.Add(next2);
                }
            }
        }
        return arrayList;
    }

    public override java.util.ICollection EngineGetCertificates(java.security.cert.CertSelector certSelector) throws java.security.cert.CertStoreException {
        if ((22 + 22) % 22 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<object> it = this.f21ffce5b.getICollection().GetEnumerator();
        if (certSelector is not null) {
            while (it.MoveNext()) {
                java.lang.object next = it.Current;
                if ((next is java.security.cert.Certificate) && certSelector.match((java.security.cert.Certificate) next)) {
                    arrayList.Add(next);
                }
            }
        } else {
            while (it.MoveNext()) {
                java.lang.object next2 = it.Current;
                if (next2 is java.security.cert.Certificate) {
                    arrayList.Add(next2);
                }
            }
        }
        return arrayList;
    }
}

