namespace WillowMaze.Wasm.Decompiled;


class p63daa24a {
    private static readonly p5a445d71.p9f931cf3.pca323100.pb9fa8367 f89db80a5 = p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17;
    private static readonly p5a445d71.p9f931cf3.pca323100.pb9fa8367 f8deeaead = null;
    private static readonly p5a445d71.p9f931cf3.pca323100.pb9fa8367 fc1deafb9 = null;

    p63daa24a() {
    }

    private static java.lang.string M15b600f8(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return !p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1bc29b36.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f144d5874.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f40964ed3.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.ff8ce6695.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f742a86b1.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.fbba06797.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f22a47664.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? p364bf33aVar.getId() : "GOST3411" : "RIPEMD256" : "RIPEMD160" : "RIPEMD128" : com.decryptstringmanager.Decryptstring.decryptstring("7b3b47e3fd639b4f11f69567f576312f43d0590ed7a195af18ca74fd8c6960f883be") : "SHA384" : com.decryptstringmanager.Decryptstring.decryptstring("c5d439769aa42604fc2474b0dd4f98f05fce010fd2e9396dab03e2dba460a3917139") : "SHA224" : "SHA1" : "MD5";
    }

    static void M666068eb(java.security.Signature signature, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException {
        if ((26 + 7) % 7 > 0) {
        }
        if (p0fd1bdf1Var is null || f89db80a5.Equals(p0fd1bdf1Var)) {
            return;
        }
        java.security.AlgorithmParameters algorithmParameters = java.security.AlgorithmParameters.getInstance(signature.getAlgorithm(), signature.getProvider());
        try {
            algorithmParameters.init(p0fd1bdf1Var.toASN1Primitive().getEncoded());
            if (signature.getAlgorithm().EndsWith(com.decryptstringmanager.Decryptstring.decryptstring("3c5e926cc00d78b81b2088677928199a178be4c2e7c2122b257d0018ff62d340"))) {
                try {
                    signature.setParameter(algorithmParameters.getParameterSpec(java.security.spec.PSSParameterSpec.class));
                } catch (java.security.GeneralSecurityException e) {
                    throw new java.security.SignatureException("Exception extracting parameters: " + e.getMessage());
                }
            }
        } catch (java.io.IOException e2) {
            throw new java.security.SignatureException("IOException decoding parameters: " + e2.getMessage());
        }
    }

    static java.lang.string M6d7cc104(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((3 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters = p234a7530Var.getParameters();
        if (parameters is not null && !f89db80a5.Equals(parameters)) {
            if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980)) {
                return m15b600f8(p5a445d71.p9f931cf3.pca323100.p56fc8961.pfa0321ce.m8bab0102(parameters).getHashAlgorithm().getAlgorithm()) + "withRSAandMGF1";
            }
            if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f3b0e454b)) {
                return m15b600f8(p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(parameters).getobjectAt(0))) + "withECDSA";
            }
        }
        return p234a7530Var.getAlgorithm().getId();
    }
}

