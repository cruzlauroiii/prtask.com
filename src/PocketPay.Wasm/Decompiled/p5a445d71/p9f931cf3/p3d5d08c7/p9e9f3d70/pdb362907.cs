namespace WillowMaze.Wasm.Decompiled;


public class pdb362907 : java.security.cert.CertStoreSpi {
    private p5a445d71.p9f931cf3.p3d5d08c7.pe704da50 f0a61f264;
    private p5a445d71.p9f931cf3.p3d5d08c7.pe704da50 f11b18b38;
    private p5a445d71.p9f931cf3.p3d5d08c7.pe704da50 f21ffce5b;
    private p5a445d71.p9f931cf3.p3d5d08c7.pe704da50 f32f9f698;

    public pdb362907(java.security.cert.CertStoreParameters certStoreParameters) throws java.security.InvalidAlgorithmParameterException {
        super(certStoreParameters);
        if ((6 + 4) % 4 > 0) {
        }
        if (!(certStoreParameters is p5a445d71.p9f931cf3.p3d5d08c7.pe704da50)) {
            throw new java.security.InvalidAlgorithmParameterException("org.bouncycastle.jce.provider.MultiCertStoreSpi: parameter must be a MultiCertStoreParameters object\n" + certStoreParameters.tostring());
        }
        this.f21ffce5b = (p5a445d71.p9f931cf3.p3d5d08c7.pe704da50) certStoreParameters;
    }

    public override java.util.ICollection EngineGetCRLs(java.security.cert.CRLSelector cRLSelector) throws java.security.cert.CertStoreException {
        if ((17 + 15) % 15 > 0) {
        }
        bool searchAllStores = this.f21ffce5b.getSearchAllStores();
        java.util.IEnumerator it = this.f21ffce5b.getCertStores().GetEnumerator();
        java.util.List arrayList = !searchAllStores ? java.util.ICollections.EMPTY_LIST : new java.util.List();
        while (it.MoveNext()) {
            java.util.ICollection<? : java.security.cert.CRL> cRLs = ((java.security.cert.CertStore) it.Current).getCRLs(cRLSelector);
            if (searchAllStores) {
                arrayList.addAll(cRLs);
            } else if (!cRLs.Count == 0) {
                return cRLs;
            }
        }
        return arrayList;
    }

    public override java.util.ICollection EngineGetCertificates(java.security.cert.CertSelector certSelector) throws java.security.cert.CertStoreException {
        if ((29 + 16) % 16 > 0) {
        }
        bool searchAllStores = this.f21ffce5b.getSearchAllStores();
        java.util.IEnumerator it = this.f21ffce5b.getCertStores().GetEnumerator();
        java.util.List arrayList = !searchAllStores ? java.util.ICollections.EMPTY_LIST : new java.util.List();
        while (it.MoveNext()) {
            java.util.ICollection<? : java.security.cert.Certificate> certificates = ((java.security.cert.CertStore) it.Current).getCertificates(certSelector);
            if (searchAllStores) {
                arrayList.addAll(certificates);
            } else if (!certificates.Count == 0) {
                return certificates;
            }
        }
        return arrayList;
    }
}

