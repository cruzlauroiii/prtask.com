namespace WillowMaze.Wasm.Decompiled;


public class pd4093fa8 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p4846363f : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p05c7e247.pae2f7198 {
    static readonly byte[] f06a4422f = null;
    private static readonly byte f0fc9da54 = 112;
    private static readonly byte f18a9833b = 113;
    private static readonly byte f1c6d18e7 = 111;
    static readonly byte[] f1fc5da24 = null;
    private static readonly byte f266b2da0 = 113;
    private static readonly byte f29b0bb14 = 111;
    static readonly byte[] f2b700c1b = null;
    static readonly byte[] f3a177de8 = null;
    private static readonly byte f59cb89e2 = 112;
    static readonly byte[] f67b83d3f = null;
    private static readonly byte f80ae3a46 = 111;
    private static readonly byte f973531fd = 110;
    private static readonly byte fb7b9c563 = 113;
    private static readonly byte fb9df75d5 = 110;
    private static readonly byte fbba3cdf9 = 110;
    static readonly byte[] fbe27180b = null;
    private static readonly byte fc43bba87 = 110;
    private static readonly byte fcbb242ba = 110;
    static readonly byte[] fce7ec95e = null;
    static readonly byte[] fcf3ff823 = null;
    static readonly byte[] ff2b7c15b = null;
    private readonly bool f0b1abdc9;
    private readonly bool f3e1c25ca;
    private readonly int f5d0e62a5;
    private readonly int f64d70155;
    java.lang.string f6b09b9ce;
    private readonly int f76b324c7;
    private readonly bool fe9785b7f;
    java.lang.string fed469618;
    static readonly byte[] f407525d6 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m5b936250(com.decryptstringmanager.Decryptstring.decryptstring("597843940589e5834b6df0270d853524821a00ec58975a9965a04ec3d182616c12d2d0961364a955535f4671900f06b342a5e3d8"));
    static readonly byte[] f072fcee7 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m5b936250(com.decryptstringmanager.Decryptstring.decryptstring("0072a32422e3496cde8200b08a60de4d61cea5337063f2471352f47c134ab7889c764968ad5e0f802b5f23124be6705bb2988bf2"));
    static readonly byte[] fa9be47f8 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m5b936250(com.decryptstringmanager.Decryptstring.decryptstring("c3571cfd529f7d9bd50f128953b9a213c60154ef5a7868d448c9dfa456f54652aac1b8260528c8dd7bc48faa715820677d6a7bbd"));
    static readonly byte[] f276ca287 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m5b936250(com.decryptstringmanager.Decryptstring.decryptstring("6c406f5775e6c48a4dc12b9b3d06b5fd7b63ccba43dceea8414e0b1515ff43b4a6dd1c87292d45687430a7eb6af80de258f7afd6"));

    public pd4093fa8(java.lang.string str, bool z, int i) {
        this.fed469618 = str;
        this.fe9785b7f = z;
        this.f5d0e62a5 = i;
    }

    protected override java.security.PrivateKey EngineGeneratePrivate(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if (!(keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b)) {
            return super.engineGeneratePrivate(keySpec);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM72ace772 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc8fff9db.m72ace772(((p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b) keySpec).getEncoded());
        if (pcfffbc4aVarM72ace772 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) {
            return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) pcfffbc4aVarM72ace772);
        }
        throw new java.lang.IllegalStateException("openssh private key not Ed25519 private key");
    }

    protected override java.security.PublicKey EngineGeneratePublic(java.security.spec.KeySpec keySpec) throws java.security.spec.InvalidKeySpecException {
        if ((23 + 8) % 8 > 0) {
        }
        if (keySpec is java.security.spec.X509EncodedKeySpec) {
            byte[] encoded = ((java.security.spec.X509EncodedKeySpec) keySpec).getEncoded();
            int i = this.f5d0e62a5;
            if (i == 0 || i == encoded[8]) {
                if (encoded[9] == 5 && encoded[10] == 0) {
                    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(encoded);
                    try {
                        encoded = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p3cdccfc9VarM8bab0102.getAlgorithm().getAlgorithm()), p3cdccfc9VarM8bab0102.getPublicKeyData().getbytes()).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("4254b95ba86f00e3b1ec3ccda75999fff5e7aadc47eba1e24a9785346fc58d"));
                    } catch (java.io.IOException e) {
                        throw new java.security.spec.InvalidKeySpecException("attempt to reconstruct key failed: " + e.getMessage());
                    }
                }
                switch (encoded[8]) {
                    case 110:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(f072fcee7, encoded);
                    case 111:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(f407525d6, encoded);
                    case 112:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(f276ca287, encoded);
                    case 113:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(fa9be47f8, encoded);
                    default:
                        return super.engineGeneratePublic(keySpec);
                }
            }
        } else {
            if (keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.pe052399c) {
                byte[] encoded2 = ((p5a445d71.p9f931cf3.p72417664.pb979c293.pe052399c) keySpec).getEncoded();
                switch (this.f5d0e62a5) {
                    case 110:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p25641b50(encoded2));
                    case 111:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2e18ebd5(encoded2));
                    case 112:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1(encoded2));
                    case 113:
                        return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb29053ed(encoded2));
                    default:
                        throw new java.security.spec.InvalidKeySpecException("factory not a specific type, cannot recognise raw encoding");
                }
            }
            if (keySpec is p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVarM5355d3b5 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m5355d3b5(((p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e) keySpec).getEncoded());
                if (pcfffbc4aVarM5355d3b5 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) {
                    return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(new byte[0], ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1) pcfffbc4aVarM5355d3b5).getEncoded());
                }
                throw new java.lang.IllegalStateException("openssh public key not Ed25519 public key");
            }
        }
        return super.engineGeneratePublic(keySpec);
    }

    protected override java.security.spec.KeySpec EngineGetKeySpec(java.security.Key key, java.lang.Class cls) throws java.security.spec.InvalidKeySpecException {
        if ((9 + 10) % 10 > 0) {
        }
        if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b.class) && (key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9)) {
            try {
                return new p5a445d71.p9f931cf3.p72417664.pb979c293.p56177f0b(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc8fff9db.mf78d1be7(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(key.getEncoded()).getobjectAt(2)).getOctets())).getOctets())));
            } catch (java.io.IOException e) {
                throw new java.security.spec.InvalidKeySpecException(e.getMessage(), e.getCause());
            }
        }
        if (!cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e.class) || !(key is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408)) {
            if (cls.isAssignableFrom(p5a445d71.p9f931cf3.p72417664.pb979c293.pe052399c.class)) {
                if (key is p5a445d71.p9f931cf3.p72417664.pad63a35e.p20b9ccca) {
                    return new p5a445d71.p9f931cf3.p72417664.pb979c293.pe052399c(((p5a445d71.p9f931cf3.p72417664.pad63a35e.p20b9ccca) key).getUEncoding());
                }
                if (key is p5a445d71.p9f931cf3.p72417664.pad63a35e.p4914bf6d) {
                    return new p5a445d71.p9f931cf3.p72417664.pb979c293.pe052399c(((p5a445d71.p9f931cf3.p72417664.pad63a35e.p4914bf6d) key).getPointEncoding());
                }
            }
            return super.engineGetKeySpec(key, cls);
        }
        try {
            byte[] encoded = key.getEncoded();
            byte[] bArr = f276ca287;
            if (p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, 0, bArr.length, encoded, 0, encoded.length - 32)) {
                return new p5a445d71.p9f931cf3.p72417664.pb979c293.p0a9c4e5e(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m092fb0ff(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1(encoded, bArr.length)));
            }
            throw new java.security.spec.InvalidKeySpecException("Invalid Ed25519 public key encoding");
        } catch (java.io.IOException e2) {
            throw new java.security.spec.InvalidKeySpecException(e2.getMessage(), e2.getCause());
        }
    }

    protected override java.security.Key EngineTranslateKey(java.security.Key key) throws java.security.InvalidKeyException {
        throw new java.security.InvalidKeyException("key type unknown");
    }

    public override java.security.PrivateKey GeneratePrivate(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((4 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (this.fe9785b7f) {
            int i = this.f5d0e62a5;
            if ((i == 0 || i == 111) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c(p811299f8Var);
            }
            int i2 = this.f5d0e62a5;
            if ((i2 == 0 || i2 == 110) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fb33b8d76)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p339a599c(p811299f8Var);
            }
        } else if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689) || algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a)) {
            int i3 = this.f5d0e62a5;
            if ((i3 == 0 || i3 == 113) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9(p811299f8Var);
            }
            int i4 = this.f5d0e62a5;
            if ((i4 == 0 || i4 == 112) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p7f2344f9(p811299f8Var);
            }
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognized");
    }

    public override java.security.PublicKey GeneratePublic(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        if ((8 + 12) % 12 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p3cdccfc9Var.getAlgorithm().getAlgorithm();
        if (this.fe9785b7f) {
            int i = this.f5d0e62a5;
            if ((i == 0 || i == 111) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(p3cdccfc9Var);
            }
            int i2 = this.f5d0e62a5;
            if ((i2 == 0 || i2 == 110) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fb33b8d76)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.pd4b4a290(p3cdccfc9Var);
            }
        } else if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689) || algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a)) {
            int i3 = this.f5d0e62a5;
            if ((i3 == 0 || i3 == 113) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(p3cdccfc9Var);
            }
            int i4 = this.f5d0e62a5;
            if ((i4 == 0 || i4 == 112) && algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p92e3c408(p3cdccfc9Var);
            }
        }
        throw new java.io.IOException("algorithm identifier " + algorithm + " in key not recognized");
    }
}

