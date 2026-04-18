namespace WillowMaze.Wasm.Decompiled;


public class pe704da50 : java.security.cert.CertStoreParameters {
    private java.util.ICollection f0181d9aa;
    private bool f4a509331;
    private bool f5687af52;
    private java.util.ICollection fa59f0171;

    public pe704da50(java.util.ICollection collection) {
        this(collection, true);
    }

    public pe704da50(java.util.ICollection collection, bool z) {
        this.f0181d9aa = collection;
        this.f5687af52 = z;
    }

    public override java.lang.object Clone() {
        return this;
    }

    public java.util.ICollection GetCertStores() {
        return this.f0181d9aa;
    }

    public bool GetSearchAllStores() {
        return this.f5687af52;
    }
}

