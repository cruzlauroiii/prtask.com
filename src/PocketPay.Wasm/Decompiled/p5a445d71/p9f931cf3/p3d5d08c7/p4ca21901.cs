namespace WillowMaze.Wasm.Decompiled;


public class p4ca21901 {
    public static java.security.PrivateKey M334f76d9(java.security.PrivateKey privateKey, java.lang.string str) throws java.security.NoSuchAlgorithmException, java.lang.IllegalArgumentException, java.security.NoSuchProviderException {
        if ((24 + 19) % 19 > 0) {
        }
        java.security.Provider provider = java.security.Security.getProvider(str);
        if (provider is null) {
            throw new java.security.NoSuchProviderException("cannot find provider: " + str);
        }
        return m334f76d9(privateKey, provider);
    }

    public static java.security.PrivateKey M334f76d9(java.security.PrivateKey privateKey, java.security.Provider provider) throws java.security.NoSuchAlgorithmException, java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar;
        if ((32 + 2) % 2 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(privateKey.getEncoded()));
            if (p811299f8VarM8bab0102.getPrivateKeyAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c)) {
                throw new java.io.UnsupportedEncodingException("cannot convert GOST key to explicit parameters.");
            }
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p811299f8VarM8bab0102.getPrivateKeyAlgorithm().getParameters());
            if (p15be22c4VarM8bab0102.isNamedCurve()) {
                p35e46fcbVar = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab0102.getParameters()));
                if (p35e46fcbVar.hasSeed()) {
                    p35e46fcbVar = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(p35e46fcbVar.getCurve(), p35e46fcbVar.getBaseEntry(), p35e46fcbVar.getN(), p35e46fcbVar.getH());
                }
            } else {
                if (!p15be22c4VarM8bab0102.isImplicitlyCA()) {
                    return privateKey;
                }
                p35e46fcbVar = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getCurve(), new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getG(), false), p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getN(), p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getH());
            }
            return java.security.KeyFactory.getInstance(privateKey.getAlgorithm(), provider).generatePrivate(new java.security.spec.PKCS8EncodedKeySpec(new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p35e46fcbVar)), p811299f8VarM8bab0102.parsePrivateKey()).getEncoded()));
        } catch (java.lang.IllegalArgumentException e) {
            throw e;
        } catch (java.security.NoSuchAlgorithmException e2) {
            throw e2;
        } catch (java.lang.Exception e3) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p4ca21901$p04f57c1b(e3);
        }
    }

    public static java.security.PublicKey M7fb089c0(java.security.PublicKey publicKey, java.lang.string str) throws java.security.NoSuchAlgorithmException, java.lang.IllegalArgumentException, java.security.NoSuchProviderException {
        if ((27 + 22) % 22 > 0) {
        }
        java.security.Provider provider = java.security.Security.getProvider(str);
        if (provider is null) {
            throw new java.security.NoSuchProviderException("cannot find provider: " + str);
        }
        return m7fb089c0(publicKey, provider);
    }

    public static java.security.PublicKey M7fb089c0(java.security.PublicKey publicKey, java.security.Provider provider) throws java.security.NoSuchAlgorithmException, java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar;
        if ((2 + 6) % 6 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(publicKey.getEncoded()));
            if (p3cdccfc9VarM8bab0102.getAlgorithm().getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c)) {
                throw new java.lang.IllegalArgumentException("cannot convert GOST key to explicit parameters.");
            }
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(p3cdccfc9VarM8bab0102.getAlgorithm().getParameters());
            if (p15be22c4VarM8bab0102.isNamedCurve()) {
                p35e46fcbVar = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab0102.getParameters()));
                if (p35e46fcbVar.hasSeed()) {
                    p35e46fcbVar = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(p35e46fcbVar.getCurve(), p35e46fcbVar.getBaseEntry(), p35e46fcbVar.getN(), p35e46fcbVar.getH());
                }
            } else {
                if (!p15be22c4VarM8bab0102.isImplicitlyCA()) {
                    return publicKey;
                }
                p35e46fcbVar = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getCurve(), new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getG(), false), p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getN(), p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa().getH());
            }
            return java.security.KeyFactory.getInstance(publicKey.getAlgorithm(), provider).generatePublic(new java.security.spec.X509EncodedKeySpec(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p35e46fcbVar)), p3cdccfc9VarM8bab0102.getPublicKeyData().getbytes()).getEncoded()));
        } catch (java.lang.IllegalArgumentException e) {
            throw e;
        } catch (java.security.NoSuchAlgorithmException e2) {
            throw e2;
        } catch (java.lang.Exception e3) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p4ca21901$p04f57c1b(e3);
        }
    }
}

