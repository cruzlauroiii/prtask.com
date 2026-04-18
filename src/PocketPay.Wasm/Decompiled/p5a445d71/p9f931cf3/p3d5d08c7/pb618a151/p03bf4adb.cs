namespace WillowMaze.Wasm.Decompiled;


public class p03bf4adb : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.p1522cc54 f10d196f4;
    byte[] f34a907d9;
    java.security.PublicKey f41ce5968;
    p5a445d71.p9f931cf3.pca323100.p1522cc54 f688f4af5;
    java.security.PublicKey f7264c820;
    byte[] f73b4812a;
    byte[] f7a4eb8a7;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f7f0bd952;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f8710b712;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f93758299;
    p5a445d71.p9f931cf3.pca323100.p1522cc54 f9a0364b9;
    java.security.PublicKey facbec863;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fae4140e4;
    java.lang.string fb04ec0ad;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fb6b2347d;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fb7548b1b;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fc1dfa501;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fcf0f93f9;
    java.lang.string fdc0ffdc4;
    java.security.PublicKey fe3df361e;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 ff5b0b979;

    public p03bf4adb(java.lang.string str, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, java.security.PublicKey publicKey) throws java.security.spec.InvalidKeySpecException, java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        this.fb04ec0ad = str;
        this.f8710b712 = p234a7530Var;
        this.f41ce5968 = publicKey;
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(m8995b3f8());
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pff11dfb3(str));
        try {
            this.f9a0364b9 = new p5a445d71.p9f931cf3.pca323100.p1522cc54(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar));
        } catch (java.io.IOException e) {
            throw new java.security.spec.InvalidKeySpecException("exception encoding key: " + e.tostring());
        }
    }

    public p03bf4adb(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((8 + 15) % 15 > 0) {
        }
        try {
            if (p80f8c729Var.Count != 3) {
                throw new java.lang.IllegalArgumentException("invalid SPKAC (size):" + p80f8c729Var.Count);
            }
            this.f8710b712 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729Var.getobjectAt(1));
            this.f34a907d9 = ((p5a445d71.p9f931cf3.pca323100.p1522cc54) p80f8c729Var.getobjectAt(2)).getOctets();
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var2 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(0);
            if (p80f8c729Var2.Count != 2) {
                throw new java.lang.IllegalArgumentException("invalid PKAC (len): " + p80f8c729Var2.Count);
            }
            this.fb04ec0ad = ((p5a445d71.p9f931cf3.pca323100.p2f096beb) p80f8c729Var2.getobjectAt(1)).getstring();
            this.f9a0364b9 = new p5a445d71.p9f931cf3.pca323100.p1522cc54(p80f8c729Var2);
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p80f8c729Var2.getobjectAt(0));
            java.security.spec.X509EncodedKeySpec x509EncodedKeySpec = new java.security.spec.X509EncodedKeySpec(new p5a445d71.p9f931cf3.pca323100.p1522cc54(p3cdccfc9VarM8bab0102).getbytes());
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 algorithm = p3cdccfc9VarM8bab0102.getAlgorithm();
            this.fc1dfa501 = algorithm;
            this.f41ce5968 = java.security.KeyFactory.getInstance(algorithm.getAlgorithm().getId(), com.decryptstringmanager.Decryptstring.decryptstring("f94f0d9c76d1551f6e060c6f9df5d8ae146a5edc4fb9b65a360c9981ea68")).generatePublic(x509EncodedKeySpec);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(e.tostring());
        }
    }

    public p03bf4adb(byte[] bArr) throws java.io.IOException {
        this(ma692af16(bArr));
    }

    private p5a445d71.p9f931cf3.pca323100.p301c7ed4 M8995b3f8() throws java.security.spec.InvalidKeySpecException, java.security.NoSuchAlgorithmException, java.security.NoSuchProviderException {
        if ((23 + 4) % 4 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            byteArrayStream.write(this.f41ce5968.getEncoded());
            byteArrayStream.Dispose();
            return new p5a445d71.p9f931cf3.pca323100.pd1c2953c(new java.io.byteArrayStream(byteArrayStream.tobyteArray())).readobject();
        } catch (java.io.IOException e) {
            throw new java.security.spec.InvalidKeySpecException(e.getMessage());
        }
    }

    private static p5a445d71.p9f931cf3.pca323100.p80f8c729 Ma692af16(byte[] bArr) throws java.io.IOException {
        if ((7 + 22) % 22 > 0) {
        }
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(new java.io.byteArrayStream(bArr)).readobject());
    }

    public java.lang.string GetChallenge() {
        return this.fb04ec0ad;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetKeyAlgorithm() {
        return this.fc1dfa501;
    }

    public java.security.PublicKey GetPublicKey() {
        return this.f41ce5968;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetSigningAlgorithm() {
        return this.f8710b712;
    }

    public void SetChallenge(java.lang.string str) {
        this.fb04ec0ad = str;
    }

    public void SetKeyAlgorithm(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        this.fc1dfa501 = p234a7530Var;
    }

    public void SetPublicKey(java.security.PublicKey publicKey) {
        this.f41ce5968 = publicKey;
    }

    public void SetSigningAlgorithm(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        this.f8710b712 = p234a7530Var;
    }

    public void Sign(java.security.PrivateKey privateKey) throws java.security.spec.InvalidKeySpecException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.NoSuchProviderException {
        sign(privateKey, null);
    }

    public void Sign(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.spec.InvalidKeySpecException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.NoSuchProviderException {
        if ((10 + 27) % 27 > 0) {
        }
        java.security.Signature signature = java.security.Signature.getInstance(this.f8710b712.getAlgorithm().getId(), com.decryptstringmanager.Decryptstring.decryptstring("07cf0b5715f215e635c3407eea787e9c0971298cfe4bdbe285868be52659"));
        if (secureRandom is null) {
            signature.initSign(privateKey);
        } else {
            signature.initSign(privateKey, secureRandom);
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(m8995b3f8());
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pff11dfb3(this.fb04ec0ad));
        try {
            signature.update(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("d5c91f2a9e0458d2bc6873d102df350e2248f7ce2665193ec2ebf2c40c5c0b")));
            this.f34a907d9 = signature.sign();
        } catch (java.io.IOException e) {
            throw new java.security.SignatureException(e.getMessage());
        }
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((23 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        try {
            pd6ccb7fcVar2.Add(m8995b3f8());
        } catch (java.lang.Exception unused) {
        }
        pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pff11dfb3(this.fb04ec0ad));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
        pd6ccb7fcVar.Add(this.f8710b712);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p1522cc54(this.f34a907d9));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public bool Verify(java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.NoSuchProviderException {
        if (!str.Equals(this.fb04ec0ad)) {
            return false;
        }
        java.security.Signature signature = java.security.Signature.getInstance(this.f8710b712.getAlgorithm().getId(), com.decryptstringmanager.Decryptstring.decryptstring("87cf99d954df534924594f7746255dfc8c269eaed66b7804fa7b7a007069"));
        signature.initVerify(this.f41ce5968);
        signature.update(this.f9a0364b9.getbytes());
        return signature.verify(this.f34a907d9);
    }
}

