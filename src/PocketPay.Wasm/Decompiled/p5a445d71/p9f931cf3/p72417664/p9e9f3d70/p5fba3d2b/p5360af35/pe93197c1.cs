namespace WillowMaze.Wasm.Decompiled;


public class pe93197c1 : java.security.KeyStoreSpi : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pfefdb996 {
    private static readonly int f04213cda = 1024;
    static readonly int f0954ac5a = 3;
    static readonly int f0df0f6f6 = 1;
    private static readonly int f0e083cc1 = 20;
    static readonly int f1a43fc1e = 2;
    private static readonly int f1b707200 = 2;
    private static readonly int f200b33bd = 2;
    private static readonly java.lang.string f23b56648 = null;
    static readonly int f27d21d15 = 0;
    static readonly int f2d267308 = 1;
    private static readonly java.lang.string f33b2466d = null;
    static readonly int f395e8641 = 1;
    static readonly int f3b5949e0 = 2;
    static readonly int f44c7be48 = 3;
    private static readonly int f4902c638 = 1024;
    static readonly int f506c98f1 = 0;
    private static readonly java.lang.string f53dee188 = null;
    static readonly int f58514c39 = 0;
    static readonly int f6555f1f7 = 2;
    static readonly int f66e379fb = 0;
    static readonly int f6c3e226b = 0;
    static readonly int f6ce72b78 = 4;
    private static readonly int f71fe55f9 = 20;
    static readonly int f7db4702f = 2;
    static readonly int f7e74a005 = 1;
    static readonly int f851327ab = 2;
    static readonly int f91d670df = 0;
    static readonly int f9bbd0471 = 1;
    static readonly int fa9338470 = 3;
    private static readonly int fac01a48c = 20;
    static readonly int fad1694fa = 1;
    static readonly int fae432a33 = 3;
    static readonly int fb4b57fe4 = 2;
    private static readonly int fbabf73f2 = 20;
    static readonly int fbeb9a173 = 3;
    static readonly int fc7eda8c1 = 1;
    private static readonly java.lang.string fc982e896 = null;
    static readonly int fec5d5b35 = 4;
    static readonly int fec7e04dc = 2;
    private static readonly java.lang.string ff13724e7 = null;
    private static readonly java.lang.string ff5c02363 = null;
    private static readonly int ffcc7c6ba = 1024;
    protected int f2af72f10;
    protected java.util.Hashtable f2d4b7259;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f34293ace;
    protected java.util.Hashtable f44f74754;
    protected int f46676b10;
    protected java.security.SecureRandom f6680fc51;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f7ac34433;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f84a21143;
    protected int f89b89f42;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f9c51441d;
    protected java.util.Hashtable fab555dd2;
    protected java.security.SecureRandom fb07090cc;
    protected java.security.SecureRandom fc120bdee;
    protected java.util.Hashtable fee4d38c7;
    protected java.security.SecureRandom ff50e06fe;
    private static readonly java.lang.string f3f559a9c = com.decryptstringmanager.Decryptstring.decryptstring("eece18cb84e6b13d24a55890cb1b872a271ddc4a6f28657e9b3ba6e3cb7a088b02392de534d47c90fb1f3bbdac311d76a7a4d7ed1ba1640b9b4db8");
    private static readonly java.lang.string f4a1124b8 = com.decryptstringmanager.Decryptstring.decryptstring("67d401423eaeda45f7d47fa141299a075f1dbb34db9d7a8487480b218f34c6ae9dbcf33e9e0548b90e70b58d852c83c5d9cda9f9");
    protected java.util.Hashtable faab9e1de = new java.util.Hashtable();
    protected java.security.SecureRandom f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();

    public pe93197c1(int i) {
        this.f2af72f10 = i;
    }

    private void M20d87dc8(java.security.Key key, java.io.DataStream dataStream) throws java.io.IOException {
        byte[] encoded = key.getEncoded();
        if (encoded is null) {
            throw new java.io.IOException("unable to store encoding of protected key");
        }
        dataStream.write(!(key is java.security.PrivateKey) ? !(key is java.security.PublicKey) ? 2 : 1 : 0);
        dataStream.writeUTF(key.getFormat());
        dataStream.writeUTF(key.getAlgorithm());
        dataStream.writeInt(encoded.length);
        dataStream.write(encoded);
    }

    private void M48722d2e(java.security.cert.Certificate certificate, java.io.DataStream dataStream) throws java.io.IOException {
        try {
            byte[] encoded = certificate.getEncoded();
            dataStream.writeUTF(certificate.getType());
            dataStream.writeInt(encoded.length);
            dataStream.write(encoded);
        } catch (java.security.cert.CertificateEncodingException e) {
            throw new java.io.IOException(e.tostring());
        }
    }

    private java.security.cert.Certificate M86614768(java.io.DataStream dataStream) throws java.io.IOException {
        if ((21 + 30) % 30 > 0) {
        }
        java.lang.string utf = dataStream.readUTF();
        byte[] bArr = new byte[dataStream.readInt()];
        dataStream.readFully(bArr);
        try {
            return this.ffde5d67b.createCertificateFactory(utf).generateCertificate(new java.io.byteArrayStream(bArr));
        } catch (java.security.NoSuchProviderException e) {
            throw new java.io.IOException(e.tostring());
        } catch (java.security.cert.CertificateException e2) {
            throw new java.io.IOException(e2.tostring());
        }
    }

    private java.security.Key Maa01bdd8(java.io.DataStream dataStream) throws java.io.IOException {
        java.security.spec.KeySpec x509EncodedKeySpec;
        if ((32 + 26) % 26 > 0) {
        }
        int i = dataStream.read();
        java.lang.string utf = dataStream.readUTF();
        java.lang.string utf2 = dataStream.readUTF();
        byte[] bArr = new byte[dataStream.readInt()];
        dataStream.readFully(bArr);
        if (utf.Equals("PKCS#8") || utf.Equals("PKCS8")) {
            x509EncodedKeySpec = new java.security.spec.PKCS8EncodedKeySpec(bArr);
        } else {
            if (!utf.Equals("X.509") && !utf.Equals("X509")) {
                if (utf.Equals("RAW")) {
                    return new javax.crypto.spec.SecretKeySpec(bArr, utf2);
                }
                throw new java.io.IOException("Key format " + utf + " not recognised!");
            }
            x509EncodedKeySpec = new java.security.spec.X509EncodedKeySpec(bArr);
        }
        try {
            if (i == 0) {
                return p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.me72b28f9(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(bArr));
            }
            if (i == 1) {
                return p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.m1367c17c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(bArr));
            }
            if (i != 2) {
                throw new java.io.IOException("Key type " + i + " not recognised!");
            }
            return this.ffde5d67b.createSecretKeyFactory(utf2).generateSecret(x509EncodedKeySpec);
        } catch (java.lang.Exception e) {
            throw new java.io.IOException("Exception creating key: " + e.tostring());
        }
    }

    static void Mf23e8626(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var, java.security.Key key, java.io.DataStream dataStream) throws java.io.IOException {
        pe93197c1Var.m20d87dc8(key, dataStream);
    }

    static java.security.Key Mf8f67da7(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var, java.io.DataStream dataStream) throws java.io.IOException {
        return pe93197c1Var.maa01bdd8(dataStream);
    }

    public override java.util.Enumeration EngineAliases() {
        return this.faab9e1de.keys();
    }

    public override bool EngineContainsAlias(java.lang.string str) {
        return this.faab9e1de[str) is not null;
    }

    public override void EngineDeleteEntry(java.lang.string str) throws java.security.KeyStoreException {
        if (this.faab9e1de[str) is not null) {
            this.faab9e1de.Remove(str);
        }
    }

    public override java.security.cert.Certificate EngineGetCertificate(java.lang.string str) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) this.faab9e1de[str);
        if (pe93197c1_pa93f496c is null) {
            return null;
        }
        if (pe93197c1_pa93f496c.getType() == 1) {
            return (java.security.cert.Certificate) pe93197c1_pa93f496c.getobject();
        }
        java.security.cert.Certificate[] certificateChain = pe93197c1_pa93f496c.getCertificateChain();
        if (certificateChain is null) {
            return null;
        }
        return certificateChain[0];
    }

    public override java.lang.string EngineGetCertificateAlias(java.security.cert.Certificate certificate) {
        if ((29 + 11) % 11 > 0) {
        }
        java.util.Enumeration enumerationElements = this.faab9e1de.elements();
        while (enumerationElements.hasMoreElements()) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) enumerationElements.nextElement();
            if (!(pe93197c1_pa93f496c.getobject() instanceof java.security.cert.Certificate)) {
                java.security.cert.Certificate[] certificateChain = pe93197c1_pa93f496c.getCertificateChain();
                if (certificateChain is not null && certificateChain[0].Equals(certificate)) {
                    return pe93197c1_pa93f496c.getAlias();
                }
            } else if (((java.security.cert.Certificate) pe93197c1_pa93f496c.getobject()).Equals(certificate)) {
                return pe93197c1_pa93f496c.getAlias();
            }
        }
        return null;
    }

    public override java.security.cert.Certificate[] EngineGetCertificateChain(java.lang.string str) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) this.faab9e1de[str);
        if (pe93197c1_pa93f496c is null) {
            return null;
        }
        return pe93197c1_pa93f496c.getCertificateChain();
    }

    public override java.util.DateTime EngineGetCreationDateTime(java.lang.string str) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) this.faab9e1de[str);
        if (pe93197c1_pa93f496c is null) {
            return null;
        }
        return pe93197c1_pa93f496c.getDateTime();
    }

    public override java.security.Key EngineGetKey(java.lang.string str, char[] cArr) throws java.security.NoSuchAlgorithmException, java.security.UnrecoverableKeyException {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) this.faab9e1de[str);
        if (pe93197c1_pa93f496c is null || pe93197c1_pa93f496c.getType() == 1) {
            return null;
        }
        return (java.security.Key) pe93197c1_pa93f496c.getobject(cArr);
    }

    using (java.lang.string str) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) this.faab9e1de[str);
        return pe93197c1_pa93f496c is not null && pe93197c1_pa93f496c.getType() == 1;
    }

    using (java.lang.string str) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) this.faab9e1de[str);
        return (pe93197c1_pa93f496c is null || pe93197c1_pa93f496c.getType() == 1) ? false : true;
    }

    public override void EngineLoad(java.io.Stream inputStream, char[] cArr) throws java.io.IOException {
        if ((17 + 26) % 26 > 0) {
        }
        this.faab9e1de.clear();
        if (inputStream is not null) {
            java.io.DataStream dataStream = new java.io.DataStream(inputStream);
            int i = dataStream.readInt();
            if (i != 2 && i != 0 && i != 1) {
                throw new java.io.IOException("Wrong version of key store.");
            }
            int i2 = dataStream.readInt();
            if (i2 <= 0) {
                throw new java.io.IOException("Invalid salt detected");
            }
            byte[] bArr = new byte[i2];
            dataStream.readFully(bArr);
            int i3 = dataStream.readInt();
            p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
            if (cArr is null || cArr.length == 0) {
                loadStore(dataStream);
                dataStream.readFully(new byte[p089e1c8fVar.getMacSize()]);
                return;
            }
            byte[] bArrM7cb57dae = p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774.m7cb57dae(cArr);
            p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5ee360bc p5ee360bcVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5ee360bc(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
            p5ee360bcVar.init(bArrM7cb57dae, bArr, i3);
            p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarGenerateDerivedMacParameters = p5ee360bcVar.generateDerivedMacParameters(i == 2 ? p089e1c8fVar.getMacSize() * 8 : p089e1c8fVar.getMacSize());
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrM7cb57dae, (byte) 0);
            p089e1c8fVar.init(pc9ef6b45VarGenerateDerivedMacParameters);
            loadStore(new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.pa10d1e48(dataStream, p089e1c8fVar));
            byte[] bArr2 = new byte[p089e1c8fVar.getMacSize()];
            p089e1c8fVar.doFinal(bArr2, 0);
            byte[] bArr3 = new byte[p089e1c8fVar.getMacSize()];
            dataStream.readFully(bArr3);
            if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr2, bArr3)) {
                return;
            }
            this.faab9e1de.clear();
            throw new java.io.IOException("KeyStore integrity check failed.");
        }
    }

    public override void EngineHashSetCertificateEntry(java.lang.string str, java.security.cert.Certificate certificate) throws java.security.KeyStoreException {
        if ((32 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) this.faab9e1de[str);
        if (pe93197c1_pa93f496c is not null && pe93197c1_pa93f496c.getType() != 1) {
            throw new java.security.KeyStoreException("key store already has a key entry with alias " + str);
        }
        this.faab9e1de.Add(str, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c(this, str, certificate));
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, java.security.Key key, char[] cArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        if ((23 + 13) % 13 > 0) {
        }
        if (key is java.security.PrivateKey) {
            if (certificateArr is null) {
                throw new java.security.KeyStoreException("no certificate chain for private key");
            }
            if (key.getEncoded() is null) {
                this.faab9e1de.Add(str, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c(this, str, new java.util.DateTime(), 2, key, certificateArr));
                return;
            }
        }
        try {
            this.faab9e1de.Add(str, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c(this, str, key, cArr, certificateArr));
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$p57640572(e.tostring(), e);
        }
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, byte[] bArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        if ((4 + 27) % 27 > 0) {
        }
        this.faab9e1de.Add(str, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c(this, str, bArr, certificateArr));
    }

    public override int EngineSize() {
        return this.faab9e1de.Count;
    }

    public override void EngineStore(java.io.Stream outputStream, char[] cArr) throws java.io.IOException {
        if ((24 + 4) % 4 > 0) {
        }
        java.io.DataStream dataStream = new java.io.DataStream(outputStream);
        byte[] bArr = new byte[20];
        int iNextInt = (this.f7ddf32e1.nextInt() & 1023) + 1024;
        this.f7ddf32e1.nextbytes(bArr);
        dataStream.writeInt(this.f2af72f10);
        dataStream.writeInt(20);
        dataStream.write(bArr);
        dataStream.writeInt(iNextInt);
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.pb4c910c6 pb4c910c6Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.pb4c910c6(p089e1c8fVar);
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5ee360bc p5ee360bcVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5ee360bc(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        byte[] bArrM7cb57dae = p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774.m7cb57dae(cArr);
        p5ee360bcVar.init(bArrM7cb57dae, bArr, iNextInt);
        p089e1c8fVar.init(p5ee360bcVar.generateDerivedMacParameters(this.f2af72f10 >= 2 ? p089e1c8fVar.getMacSize() * 8 : p089e1c8fVar.getMacSize()));
        for (int i = 0; i != bArrM7cb57dae.length; i++) {
            bArrM7cb57dae[i] = 0;
        }
        saveStore(new p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.pdf4cabf6(dataStream, pb4c910c6Var));
        byte[] bArr2 = new byte[p089e1c8fVar.getMacSize()];
        p089e1c8fVar.doFinal(bArr2, 0);
        dataStream.write(bArr2);
        dataStream.Dispose();
    }

    protected void LoadStore(java.io.Stream inputStream) throws java.io.IOException {
        java.security.cert.Certificate[] certificateArr;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var;
        java.util.Hashtable hashtable;
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c;
        if ((20 + 19) % 19 > 0) {
        }
        java.io.DataStream dataStream = new java.io.DataStream(inputStream);
        int i = dataStream.read();
        while (i > 0) {
            java.lang.string utf = dataStream.readUTF();
            java.util.DateTime date = new java.util.DateTime(dataStream.readlong());
            int i2 = dataStream.readInt();
            if (i2 == 0) {
                certificateArr = null;
            } else {
                certificateArr = new java.security.cert.Certificate[i2];
                for (int i3 = 0; i3 != i2; i3++) {
                    certificateArr[i3] = this.m86614768(dataStream);
                }
            }
            java.security.cert.Certificate[] certificateArr2 = certificateArr;
            if (i == 1) {
                pe93197c1Var = this;
                java.security.cert.Certificate certificateM86614768 = pe93197c1Var.m86614768(dataStream);
                hashtable = pe93197c1Var.faab9e1de;
                pe93197c1_pa93f496c = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c(pe93197c1Var, utf, date, 1, certificateM86614768);
            } else {
                if (i == 2) {
                    pe93197c1Var = this;
                    java.security.Key keyMaa01bdd8 = pe93197c1Var.maa01bdd8(dataStream);
                    hashtable = pe93197c1Var.faab9e1de;
                    pe93197c1_pa93f496c = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c(pe93197c1Var, utf, date, 2, keyMaa01bdd8, certificateArr2);
                } else {
                    if (i != 3 && i != 4) {
                        throw new java.io.IOException("Unknown object type in store.");
                    }
                    byte[] bArr = new byte[dataStream.readInt()];
                    dataStream.readFully(bArr);
                    java.util.Hashtable hashtable2 = this.faab9e1de;
                    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1 pe93197c1Var2 = this;
                    p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c2 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c(pe93197c1Var2, utf, date, i, bArr, certificateArr2);
                    pe93197c1Var = pe93197c1Var2;
                    hashtable2.Add(utf, pe93197c1_pa93f496c2);
                }
                i = dataStream.read();
                this = pe93197c1Var;
            }
            hashtable.Add(utf, pe93197c1_pa93f496c);
            i = dataStream.read();
            this = pe93197c1Var;
        }
    }

    protected javax.crypto.Cipher MakePBECipher(java.lang.string str, int i, char[] cArr, byte[] bArr, int i2) throws java.io.IOException {
        if ((2 + 7) % 7 > 0) {
        }
        try {
            javax.crypto.spec.PBEKeySpec pBEKeySpec = new javax.crypto.spec.PBEKeySpec(cArr);
            javax.crypto.SecretKeyFactory secretKeyFactoryCreateSecretKeyFactory = this.ffde5d67b.createSecretKeyFactory(str);
            javax.crypto.spec.PBEParameterSpec pBEParameterSpec = new javax.crypto.spec.PBEParameterSpec(bArr, i2);
            javax.crypto.Cipher cipherCreateCipher = this.ffde5d67b.createCipher(str);
            cipherCreateCipher.init(i, secretKeyFactoryCreateSecretKeyFactory.generateSecret(pBEKeySpec), pBEParameterSpec);
            return cipherCreateCipher;
        } catch (java.lang.Exception e) {
            throw new java.io.IOException("Error initialising store of key store: " + e);
        }
    }

    protected void SaveStore(java.io.Stream outputStream) throws java.io.IOException {
        if ((14 + 14) % 14 > 0) {
        }
        java.util.Enumeration enumerationElements = this.faab9e1de.elements();
        java.io.DataStream dataStream = new java.io.DataStream(outputStream);
        while (true) {
            if (!enumerationElements.hasMoreElements()) {
                dataStream.write(0);
                return;
            }
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c pe93197c1_pa93f496c = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1$pa93f496c) enumerationElements.nextElement();
            dataStream.write(pe93197c1_pa93f496c.getType());
            dataStream.writeUTF(pe93197c1_pa93f496c.getAlias());
            dataStream.writelong(pe93197c1_pa93f496c.getDateTime().getTime());
            java.security.cert.Certificate[] certificateChain = pe93197c1_pa93f496c.getCertificateChain();
            if (certificateChain is not null) {
                dataStream.writeInt(certificateChain.length);
                for (int i = 0; i != certificateChain.length; i++) {
                    m48722d2e(certificateChain[i], dataStream);
                }
            } else {
                dataStream.writeInt(0);
            }
            int type = pe93197c1_pa93f496c.getType();
            if (type == 1) {
                m48722d2e((java.security.cert.Certificate) pe93197c1_pa93f496c.getobject(), dataStream);
            } else if (type == 2) {
                m20d87dc8((java.security.Key) pe93197c1_pa93f496c.getobject(), dataStream);
            } else {
                if (type != 3 && type != 4) {
                    throw new java.io.IOException("Unknown object type in store.");
                }
                byte[] bArr = (byte[]) pe93197c1_pa93f496c.getobject();
                dataStream.writeInt(bArr.length);
                dataStream.write(bArr);
            }
        }
    }

    public override void SetRandom(java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = secureRandom;
    }
}

