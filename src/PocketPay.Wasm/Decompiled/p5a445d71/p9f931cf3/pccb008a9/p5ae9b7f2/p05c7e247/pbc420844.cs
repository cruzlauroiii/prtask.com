namespace WillowMaze.Wasm.Decompiled;


public class pbc420844 {
    private static short[] M31168275(byte[] bArr) {
        if ((14 + 23) % 23 > 0) {
        }
        int length = bArr.length / 2;
        short[] sArr = new short[length];
        for (int i = 0; i != length; i++) {
            sArr[i] = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mfa04705f(bArr, i * 2);
        }
        return sArr;
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(java.io.Stream inputStream) throws java.io.IOException {
        return me28b94be(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject()));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        if ((24 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = p811299f8Var.getPrivateKeyAlgorithm().getAlgorithm();
        if (algorithm.on(p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.fc4a295a7)) {
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.m42b717ec(p811299f8Var.getPrivateKeyAlgorithm()), p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets());
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f70cfcb24)) {
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.mcc4f5c15(p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters())));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f054b782d)) {
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd(m31168275(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets()));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc)) {
            byte[] octets = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets();
            p5a445d71.p9f931cf3.pca323100.p29d19857 publicKeyData = p811299f8Var.getPublicKeyData();
            if (p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(octets, 0) != 1) {
                if (publicKeyData is null) {
                    return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(octets, 4, octets.length));
                }
                return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594.m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(octets, 4, octets.length), publicKeyData.getOctets());
            }
            if (publicKeyData is null) {
                return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d.m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(octets, 4, octets.length));
            }
            byte[] octets2 = publicKeyData.getOctets();
            return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d.m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(octets, 4, octets.length), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(octets2, 4, octets2.length));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5360af35.pf11f6ad9.f4aeb1bcf)) {
            p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77 p2bd3ac77VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
            p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm2 = p2bd3ac77VarM8bab0102.getTreeDigest().getAlgorithm();
            p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae p7e83e3aeVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae.m8bab0102(p811299f8Var.parsePrivateKey());
            try {
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b p823c49a3_p2bd4a59bWithRoot = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3$p2bd4a59b(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9(p2bd3ac77VarM8bab0102.getHeight(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.me0825354(algorithm2))).withIndex(p7e83e3aeVarM8bab0102.getIndex()).withSecretKeySeed(p7e83e3aeVarM8bab0102.getSecretKeySeed()).withSecretKeyPRF(p7e83e3aeVarM8bab0102.getSecretKeyPRF()).withPublicSeed(p7e83e3aeVarM8bab0102.getPublicSeed()).withRoot(p7e83e3aeVarM8bab0102.getRoot());
                if (p7e83e3aeVarM8bab0102.getVersion() != 0) {
                    p823c49a3_p2bd4a59bWithRoot.withMaxIndex(p7e83e3aeVarM8bab0102.getMaxIndex());
                }
                if (p7e83e3aeVarM8bab0102.getBdsState() is not null) {
                    p823c49a3_p2bd4a59bWithRoot.withBDSState(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m95f98046(p7e83e3aeVarM8bab0102.getBdsState(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a.class)).withWOTSDigest(algorithm2));
                }
                return p823c49a3_p2bd4a59bWithRoot.build();
            } catch (java.lang.ClassNotFoundException e) {
                throw new java.io.IOException("ClassNotFoundException processing BDS state: " + e.getMessage());
            }
        }
        if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f2ae6fdb4)) {
            if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf)) {
                throw new java.lang.Exception("algorithm identifier in private key not recognised");
            }
            p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd pddbd07cdVarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd.m8bab0102(p811299f8Var.parsePrivateKey());
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f(pddbd07cdVarM8bab0102.getN(), pddbd07cdVarM8bab0102.getK(), pddbd07cdVarM8bab0102.getField(), pddbd07cdVarM8bab0102.getGoppaPoly(), pddbd07cdVarM8bab0102.getP(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.mba8d3a36(pddbd07cdVarM8bab0102.getDigest().getAlgorithm()));
        }
        p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551 pacfb2551VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551.m8bab0102(p811299f8Var.getPrivateKeyAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm3 = pacfb2551VarM8bab0102.getTreeDigest().getAlgorithm();
        try {
            p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77 p404c8b77VarM8bab0102 = p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77.m8bab0102(p811299f8Var.parsePrivateKey());
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b pbf81b3bd_p2bd4a59bWithRoot = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd$p2bd4a59b(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194(pacfb2551VarM8bab0102.getHeight(), pacfb2551VarM8bab0102.getLayers(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.me0825354(algorithm3))).withIndex(p404c8b77VarM8bab0102.getIndex()).withSecretKeySeed(p404c8b77VarM8bab0102.getSecretKeySeed()).withSecretKeyPRF(p404c8b77VarM8bab0102.getSecretKeyPRF()).withPublicSeed(p404c8b77VarM8bab0102.getPublicSeed()).withRoot(p404c8b77VarM8bab0102.getRoot());
            if (p404c8b77VarM8bab0102.getVersion() != 0) {
                pbf81b3bd_p2bd4a59bWithRoot.withMaxIndex(p404c8b77VarM8bab0102.getMaxIndex());
            }
            if (p404c8b77VarM8bab0102.getBdsState() is not null) {
                pbf81b3bd_p2bd4a59bWithRoot.withBDSState(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m95f98046(p404c8b77VarM8bab0102.getBdsState(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90.class)).withWOTSDigest(algorithm3));
            }
            return pbf81b3bd_p2bd4a59bWithRoot.build();
        } catch (java.lang.ClassNotFoundException e2) {
            throw new java.io.IOException("ClassNotFoundException processing BDS state: " + e2.getMessage());
        }
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(byte[] bArr) throws java.io.IOException {
        return me28b94be(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)));
    }
}

