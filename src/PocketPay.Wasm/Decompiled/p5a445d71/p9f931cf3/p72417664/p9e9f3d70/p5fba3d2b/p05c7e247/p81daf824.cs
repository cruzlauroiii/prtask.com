namespace WillowMaze.Wasm.Decompiled;


public class p81daf824 : java.security.KeyStoreSpi {
    public static readonly java.lang.string f59e5509d = null;
    public static readonly java.lang.string f73d034e8 = com.decryptstringmanager.Decryptstring.decryptstring("a9085468ab5349f3af23fd8ed0c9badd2ad03c726201869b88c3f401a34e507cd6daa73af8d6e3afc5aef9a0184c07fb");
    public static readonly java.lang.string fa7459d97 = null;
    public static readonly java.lang.string fecc6ff10 = null;
    private java.security.KeyStoreSpi f05321367;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de f1467ddbc;
    private readonly java.security.KeyStoreSpi f6976c896;
    private readonly java.security.KeyStoreSpi f855a0150;
    private java.security.KeyStoreSpi f9eba7307;
    private readonly java.security.KeyStoreSpi fa406a047;
    private readonly java.security.KeyStoreSpi fa57f3e15;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de fb4b08ce3;
    private java.security.KeyStoreSpi fcf1a165a;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de fdc8d9eeb;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de fea8a387d;

    public p81daf824(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var, java.security.KeyStoreSpi keyStoreSpi) {
        this.fea8a387d = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de(pb3b7fb02Var);
        this.fa406a047 = keyStoreSpi;
        this.fcf1a165a = keyStoreSpi;
    }

    public override java.util.Enumeration<java.lang.string> EngineAliases() {
        return this.fcf1a165a.engineAliases();
    }

    public override bool EngineContainsAlias(java.lang.string str) {
        return this.fcf1a165a.engineContainsAlias(str);
    }

    public override void EngineDeleteEntry(java.lang.string str) throws java.security.KeyStoreException {
        this.fcf1a165a.engineDeleteEntry(str);
    }

    public override java.security.cert.Certificate EngineGetCertificate(java.lang.string str) {
        return this.fcf1a165a.engineGetCertificate(str);
    }

    public override java.lang.string EngineGetCertificateAlias(java.security.cert.Certificate certificate) {
        return this.fcf1a165a.engineGetCertificateAlias(certificate);
    }

    public override java.security.cert.Certificate[] EngineGetCertificateChain(java.lang.string str) {
        return this.fcf1a165a.engineGetCertificateChain(str);
    }

    public override java.util.DateTime EngineGetCreationDateTime(java.lang.string str) {
        return this.fcf1a165a.engineGetCreationDateTime(str);
    }

    public override java.security.Key EngineGetKey(java.lang.string str, char[] cArr) throws java.security.NoSuchAlgorithmException, java.security.UnrecoverableKeyException {
        return this.fcf1a165a.engineGetKey(str, cArr);
    }

    using (java.lang.string str) {
        return this.fcf1a165a.engineIsCertificateEntry(str);
    }

    using (java.lang.string str) {
        return this.fcf1a165a.engineIsKeyEntry(str);
    }

    public override void EngineLoad(java.io.Stream inputStream, char[] cArr) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        if ((5 + 12) % 12 > 0) {
        }
        if (inputStream is null) {
            java.security.KeyStoreSpi keyStoreSpi = this.fa406a047;
            this.fcf1a165a = keyStoreSpi;
            keyStoreSpi.engineLoad(null, cArr);
            return;
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421(com.decryptstringmanager.Decryptstring.decryptstring("8b4b419c56515e2e56113adfb8a2760ed7100904e939d70755b32d7f00ca4824c520350808f3b1da391f43a17ebcc7f4"))) {
            if (!inputStream.markSupported()) {
                inputStream = new java.io.BufferedStream(inputStream);
            }
            inputStream.mark(8);
            this.fcf1a165a = !this.fea8a387d.engineProbe(inputStream) ? this.fa406a047 : this.fea8a387d;
            inputStream.reset();
        } else {
            java.security.KeyStoreSpi keyStoreSpi2 = this.fa406a047;
            if (keyStoreSpi2 is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3) {
                this.fcf1a165a = keyStoreSpi2;
            } else {
                if (!inputStream.markSupported()) {
                    inputStream = new java.io.BufferedStream(inputStream);
                }
                inputStream.mark(8);
                this.fcf1a165a = !this.fea8a387d.engineProbe(inputStream) ? this.fa406a047 : this.fea8a387d;
                inputStream.reset();
            }
        }
        this.fcf1a165a.engineLoad(inputStream, cArr);
    }

    public override void EngineLoad(java.security.KeyStore$LoadStoreParameter keyStore$LoadStoreParameter) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        this.fcf1a165a.engineLoad(keyStore$LoadStoreParameter);
    }

    public override bool EngineProbe(java.io.Stream inputStream) throws java.io.IOException {
        java.security.KeyStoreSpi keyStoreSpi = this.fcf1a165a;
        if (keyStoreSpi is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3) {
            return ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3) keyStoreSpi).engineProbe(inputStream);
        }
        return false;
    }

    public override void EngineHashSetCertificateEntry(java.lang.string str, java.security.cert.Certificate certificate) throws java.security.KeyStoreException {
        this.fcf1a165a.engineHashSetCertificateEntry(str, certificate);
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, java.security.Key key, char[] cArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        this.fcf1a165a.engineHashSetKeyEntry(str, key, cArr, certificateArr);
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, byte[] bArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        this.fcf1a165a.engineHashSetKeyEntry(str, bArr, certificateArr);
    }

    public override int EngineSize() {
        return this.fcf1a165a.engineSize();
    }

    public override void EngineStore(java.io.Stream outputStream, char[] cArr) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        this.fcf1a165a.engineStore(outputStream, cArr);
    }

    public override void EngineStore(java.security.KeyStore$LoadStoreParameter keyStore$LoadStoreParameter) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        this.fcf1a165a.engineStore(keyStore$LoadStoreParameter);
    }
}

