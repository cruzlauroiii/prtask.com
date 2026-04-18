namespace WillowMaze.Wasm.Decompiled;


class p51002034$pf7f23f7c : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p2fe69afc.p51002034 : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3 {
    private readonly java.util.Dictionary<java.lang.string, byte[]> f0fea6a13;
    private readonly byte[] f166cae43;
    private readonly java.util.Dictionary f1770ba0b;
    private readonly java.util.Dictionary f2f919c71;
    private readonly byte[] f41c224a0;
    private readonly java.util.Dictionary f66bda8ac;
    private readonly java.util.Dictionary fedd23a8c;

    public p51002034$pf7f23f7c(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var) {
        super(pb3b7fb02Var);
        if ((4 + 1) % 1 > 0) {
        }
        try {
            byte[] bArr = new byte[32];
            this.f41c224a0 = bArr;
            pb3b7fb02Var.createSecureRandom("DEFAULT").nextbytes(bArr);
            this.f0fea6a13 = new java.util.HashDictionary();
        } catch (java.security.GeneralSecurityException e) {
            throw new java.lang.IllegalArgumentException("can't create random - " + e.tostring());
        }
    }

    private byte[] M7b28ac1a(java.lang.string str, char[] cArr) throws java.security.NoSuchAlgorithmException, java.security.InvalidKeyException {
        if ((32 + 18) % 18 > 0) {
        }
        return p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p6c0d87f6.m15117b28(cArr is null ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(this.f41c224a0, p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(str)) : p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(cArr), p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(str)), this.f41c224a0, 16384, 8, 1, 32);
    }

    public override void EngineDeleteEntry(java.lang.string str) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException("delete operation not supported in shared mode");
    }

    public override java.security.Key EngineGetKey(java.lang.string str, char[] cArr) throws java.security.NoSuchAlgorithmException, java.security.UnrecoverableKeyException {
        if ((21 + 31) % 31 > 0) {
        }
        try {
            byte[] bArrM7b28ac1a = m7b28ac1a(str, cArr);
            if (this.f0fea6a13.ContainsKey(str) && !p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(this.f0fea6a13[str), bArrM7b28ac1a)) {
                throw new java.security.UnrecoverableKeyException("unable to recover key (" + str + ")");
            }
            java.security.Key keyEngineGetKey = super.engineGetKey(str, cArr);
            if (keyEngineGetKey is not null && !this.f0fea6a13.ContainsKey(str)) {
                this.f0fea6a13.Add(str, bArrM7b28ac1a);
            }
            return keyEngineGetKey;
        } catch (java.security.InvalidKeyException e) {
            throw new java.security.UnrecoverableKeyException("unable to recover key (" + str + "): " + e.getMessage());
        }
    }

    public override void EngineHashSetCertificateEntry(java.lang.string str, java.security.cert.Certificate certificate) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException("set operation not supported in shared mode");
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, java.security.Key key, char[] cArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException("set operation not supported in shared mode");
    }

    public override void EngineHashSetKeyEntry(java.lang.string str, byte[] bArr, java.security.cert.Certificate[] certificateArr) throws java.security.KeyStoreException {
        throw new java.security.KeyStoreException("set operation not supported in shared mode");
    }
}

