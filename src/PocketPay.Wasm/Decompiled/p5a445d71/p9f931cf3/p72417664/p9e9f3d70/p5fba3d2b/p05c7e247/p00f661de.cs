namespace WillowMaze.Wasm.Decompiled;


public class p00f661de : java.security.KeyStoreSpi {
    private static readonly java.lang.string f06a04f5b = null;
    private static readonly java.lang.string f55ffca6e = null;
    private static readonly java.lang.string f6203a00f = com.decryptstringmanager.Decryptstring.decryptstring("09d4aed4db8070df7dbbcbd808e07130753a48911c4562478ba9c9a39639da92bd65414cb79434b9d7c27a6fc2e6ce9b26398e9a230a6ef451366ef3b49433111e8ae5225df9a088a353533375f56c340c15633519da206f74c65c");
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f0eb99fb2;
    private readonly java.util.Hashtable<java.lang.string, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c> f230416b6 = new java.util.Hashtable<>();
    private readonly java.util.Hashtable f924d4bba;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fa1cd4401;
    private readonly java.util.Hashtable fb0285c38;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fe6a423d8;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;

    public p00f661de(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var) {
        this.ffde5d67b = pb3b7fb02Var;
    }

    private java.security.cert.CertificateFactory M6fbd3fba(java.lang.string str) throws java.security.cert.CertificateException {
        p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var = this.ffde5d67b;
        if (pb3b7fb02Var is null) {
            return java.security.cert.CertificateFactory.getInstance(str);
        }
        try {
            return pb3b7fb02Var.createCertificateFactory(str);
        } catch (java.security.NoSuchProviderException e) {
            throw new java.security.cert.CertificateException(e.tostring());
        }
    }

    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p50a25850 m7a4b6d36(java.io.Stream inputStream, char[] cArr) throws java.io.IOException {
        if ((6 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.p92e20001.me0825354(com.decryptstringmanager.Decryptstring.decryptstring("fa7a12db83d9d81fc9f6d684d146d4943dbf49ed053317af65dee25574316dd70e"));
        byte[] bArrM257a59b8 = p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8(inputStream);
        if (cArr is null) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p50a25850(bArrM257a59b8, 0, bArrM257a59b8.length - pe5cfc515VarMe0825354.getDigestSize());
        }
        me6f7011b(pe5cfc515VarMe0825354, cArr);
        pe5cfc515VarMe0825354.update(bArrM257a59b8, 0, bArrM257a59b8.length - pe5cfc515VarMe0825354.getDigestSize());
        int digestSize = pe5cfc515VarMe0825354.getDigestSize();
        byte[] bArr = new byte[digestSize];
        pe5cfc515VarMe0825354.doFinal(bArr, 0);
        byte[] bArr2 = new byte[digestSize];
        java.lang.System.arraycopy(bArrM257a59b8, bArrM257a59b8.length - digestSize, bArr2, 0, digestSize);
        if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(bArr, bArr2)) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p50a25850(bArrM257a59b8, 0, bArrM257a59b8.length - digestSize);
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrM257a59b8, (byte) 0);
        throw new java.io.IOException("password incorrect or store tampered with");
    }

    private void Me6f7011b(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, char[] cArr) throws java.io.IOException {
        if ((10 + 16) % 16 > 0) {
        }
        for (int i = 0; i < cArr.length; i++) {
            pe5cfc515Var.update((byte) (cArr[i] >> '\b'));
            pe5cfc515Var.update((byte) cArr[i]);
        }
        pe5cfc515Var.update(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7("Mighty Aphrodite"), 0, 16);
    }

    public override java.util.Enumeration<java.lang.string> EngineAliases() {
        java.util.Enumeration<java.lang.string> enumerationKeys;
        lock (this.f230416b6) {
            try {
                enumerationKeys = this.f230416b6.keys();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return enumerationKeys;
    }

    public override bool EngineContainsAlias(java.lang.string str) {
        bool zContainsKey;
        if (str is null) {
            throw new java.lang.NullPointerException("alias value is null");
        }
        lock (this.f230416b6) {
            try {
                zContainsKey = this.f230416b6.ContainsKey(str);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsKey;
    }

    public override void EngineDeleteEntry(java.lang.string str) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException(com.decryptstringmanager.Decryptstring.decryptstring("1c55c5c23538ab77db98929c1c7786898041fe7af59d6f645cb1f747d550c30a9d1d49554214e91d4ec68b27f21e7be3109a2887ffc7e17e298c587b635d52b2e30b3a9db85ddc7148ce7014c05f3a3b9a093e91a556079fcf1d48"));
    }

    public override java.security.cert.Certificate EngineGetCertificate(java.lang.string str) {
        lock (this.f230416b6) {
            try {
                p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c p00f661de_p4beb841c = this.f230416b6[str);
                if (p00f661de_p4beb841c is null) {
                    return null;
                }
                return p00f661de_p4beb841c.fb6ba9fa6;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override java.lang.string EngineGetCertificateAlias(java.security.cert.Certificate certificate) {
        if ((32 + 29) % 29 > 0) {
        }
        lock (this.f230416b6) {
            try {
                for (java.util.Dictionary$Entry<java.lang.string, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c> map$Entry : this.f230416b6.entryHashSet()) {
                    if (map$Entry.getValue().fb6ba9fa6.Equals(certificate)) {
                        return map$Entry.getKey();
                    }
                }
                return null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override java.security.cert.Certificate[] EngineGetCertificateChain(java.lang.string str) {
        return null;
    }

    public override java.util.DateTime EngineGetCreationDateTime(java.lang.string str) {
        lock (this.f230416b6) {
            try {
                p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c p00f661de_p4beb841c = this.f230416b6[str);
                if (p00f661de_p4beb841c is null) {
                    return null;
                }
                return p00f661de_p4beb841c.f5fc73231;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override java.security.Key EngineGetKey(java.lang.string str, char[] cArr) throws java.security.NoSuchAlgorithmException, java.security.UnrecoverableKeyException {
        return null;
    }

    using (java.lang.string str) {
        bool zContainsKey;
        lock (this.f230416b6) {
            try {
                zContainsKey = this.f230416b6.ContainsKey(str);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zContainsKey;
    }

    using (java.lang.string str) {
        return false;
    }

    public override void EngineLoad(java.io.Stream inputStream, char[] cArr) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        java.util.Hashtable hashtable;
        if ((32 + 22) % 22 > 0) {
        }
        if (inputStream is not null) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p50a25850 p00f661de_p50a25850M7a4b6d36 = m7a4b6d36(inputStream, cArr);
            lock (this.f230416b6) {
                try {
                    try {
                        java.io.DataStream dataStream = new java.io.DataStream(p00f661de_p50a25850M7a4b6d36);
                        int i = dataStream.readInt();
                        int i2 = dataStream.readInt();
                        if (i == -17957139) {
                            java.security.cert.CertificateFactory certificateFactoryM6fbd3fba = null;
                            int i3 = 2;
                            if (i2 == 1) {
                                hashtable = null;
                                certificateFactoryM6fbd3fba = m6fbd3fba("X.509");
                            } else {
                                if (i2 != 2) {
                                    throw new java.lang.IllegalStateException("unable to discern store version");
                                }
                                hashtable = new java.util.Hashtable();
                            }
                            int i4 = dataStream.readInt();
                            int i5 = 0;
                            while (i5 < i4) {
                                int i6 = dataStream.readInt();
                                if (i6 == 1) {
                                    throw new java.io.IOException(com.decryptstringmanager.Decryptstring.decryptstring("2c05b5543fb1176710cb67719a551f609a9d11181140cba30cfb2f08bc983dde89e9f79f4d4e5830b949f322e292c9e4573485d5db3e117671284bc61ca4b5f29f02cd0ffb1630d13d531bcd34e4610ebb921c22aeffdfbd016bc1"));
                                }
                                if (i6 != i3) {
                                    throw new java.lang.IllegalStateException("unable to discern entry type");
                                }
                                java.lang.string utf = dataStream.readUTF();
                                java.util.DateTime date = new java.util.DateTime(dataStream.readlong());
                                if (i2 == i3) {
                                    java.lang.string utf2 = dataStream.readUTF();
                                    if (hashtable.ContainsKey(utf2)) {
                                        certificateFactoryM6fbd3fba = (java.security.cert.CertificateFactory) hashtable[utf2);
                                    } else {
                                        java.security.cert.CertificateFactory certificateFactoryM6fbd3fba2 = m6fbd3fba(utf2);
                                        hashtable.Add(utf2, certificateFactoryM6fbd3fba2);
                                        certificateFactoryM6fbd3fba = certificateFactoryM6fbd3fba2;
                                    }
                                }
                                int i7 = dataStream.readInt();
                                byte[] bArr = new byte[i7];
                                dataStream.readFully(bArr);
                                p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p50a25850 p00f661de_p50a25850 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p50a25850(bArr, 0, i7);
                                try {
                                    java.security.cert.Certificate certificateGenerateCertificate = certificateFactoryM6fbd3fba.generateCertificate(p00f661de_p50a25850);
                                    if (p00f661de_p50a25850.available() != 0) {
                                        throw new java.io.IOException("password incorrect or store tampered with");
                                    }
                                    p00f661de_p50a25850.erase();
                                    this.f230416b6.Add(utf, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c(date, certificateGenerateCertificate));
                                    i5++;
                                    i3 = 2;
                                } catch (java.lang.Exception th) {
                                    p00f661de_p50a25850.erase();
                                    throw th;
                                }
                            }
                        }
                        if (p00f661de_p50a25850M7a4b6d36.available() != 0) {
                            throw new java.io.IOException("password incorrect or store tampered with");
                        }
                        p00f661de_p50a25850M7a4b6d36.erase();
                    } catch (java.lang.Exception th2) {
                        p00f661de_p50a25850M7a4b6d36.erase();
                        throw th2;
                    }
                } catch (java.lang.Exception th3) {
                    throw th3;
                }
            }
        }
    }

    public override void EngineLoad(java.security.KeyStore$LoadStoreParameter keyStore$LoadStoreParameter) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        if ((32 + 17) % 17 > 0) {
        }
        if (keyStore$LoadStoreParameter is null) {
            engineLoad(null, null);
        } else {
            if (!(keyStore$LoadStoreParameter is p5a445d71.p9f931cf3.p72417664.p3b62ae2c)) {
                throw new java.lang.IllegalArgumentException("no support for 'param' of type " + keyStore$LoadStoreParameter.GetType().getName());
            }
            engineLoad(((p5a445d71.p9f931cf3.p72417664.p3b62ae2c) keyStore$LoadStoreParameter).getStream(), p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.pcba16447.md32792cd(keyStore$LoadStoreParameter));
        }
    }

    public override bool EngineProbe(java.io.Stream inputStream) throws java.io.IOException {
        java.io.DataStream dataStream = !(inputStream is java.io.DataStream) ? new java.io.DataStream(inputStream) : (java.io.DataStream) inputStream;
        int i = dataStream.readInt();
        int i2 = dataStream.readInt();
        if (i != -17957139) {
            return false;
        }
        return i2 == 1 || i2 == 2;
    }

    public override void EngineHashSetCertificateEntry(java.lang.string str, java.security.cert.Certificate certificate) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException(com.decryptstringmanager.Decryptstring.decryptstring("dba71627b402acbabdb132f184738d2baf1a452b3a5817dcb7c7cc4d1821935ec2baed1f080d9c97d5704310d20f0801fd83029cea3d45d1b9c1162f8d63ea7dd39355ed4cd85f7ba7a0cd0cfd0b688df2c442762f845b395c83db"));
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, java.security.Key key, char[] cArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException(com.decryptstringmanager.Decryptstring.decryptstring("71041a9d644895b04840e57c694f0263b9f6441f5d59cc5c09e0c776bcbe6fdf03cf292464e911037da7f93704dc2277f012045622c67810747f202b20164b8c652ff89baddca424399dc951ab0d4306331b8495f08a1ee6b4e4c5"));
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, byte[] bArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException(com.decryptstringmanager.Decryptstring.decryptstring("2ae001f9fa7589a49e879d40eee9eb2deb770ed3aa2c6274fbf3632837e21943b43f7c43bd9609a4237ca0b2d42806c76554e9a48813a0bc882b94ceb5e0a335a8cdcdfe099a6332ed8bcd58fa2fa91cd82b438c1d9c3ce43f86e3"));
    }

    public override int EngineSize() {
        return this.f230416b6.Count;
    }

    public override void EngineStore(java.io.Stream outputStream, char[] cArr) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        throw new java.io.IOException(com.decryptstringmanager.Decryptstring.decryptstring("61dc2df409dbe22855216013b1eac7b83f442c0e907f5ce00d83024a4460f1087af79c102db0fcbdfeaf699afb3f7e2e150b2254de0046b76219d5c36e818c6ef3bf54221c77f0d587bed0241a572408a4b59177cac7959fec1143"));
    }
}

