namespace WillowMaze.Wasm.Decompiled;


class p1fb7a8a1 {
    p1fb7a8a1() {
    }

    static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 M0daa78aa(java.security.spec.ECParameterSpec eCParameterSpec, bool z) {
        if ((17 + 17) % 17 > 0) {
        }
        if (!(eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d)) {
            if (eCParameterSpec is null) {
                return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.pb9fa8367) p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
            }
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m2ace2977(eCParameterSpec.getCurve());
            return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(pa827ecfaVarM2ace2977, new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(pa827ecfaVarM2ace2977, eCParameterSpec.getGenerator()), z), eCParameterSpec.getOrder(), java.math.Bigint.valueOf(eCParameterSpec.getCofactor()), eCParameterSpec.getCurve().getSeed()));
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d p698f972dVar = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec;
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM9a2b7f82 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m9a2b7f82(p698f972dVar.getName());
        if (p364bf33aVarM9a2b7f82 is null) {
            p364bf33aVarM9a2b7f82 = new p5a445d71.p9f931cf3.pca323100.p364bf33a(p698f972dVar.getName());
        }
        return new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(p364bf33aVarM9a2b7f82);
    }

    static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb M0daa78aa(java.lang.string str, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        if ((5 + 2) % 2 > 0) {
        }
        if (str is null || str.Length < 1) {
            return null;
        }
        int iIndexOf = str.IndexOf(32);
        if (iIndexOf > 0) {
            str = str.Substring(iIndexOf + 1);
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM18da419b = m18da419b(str);
        if (p364bf33aVarM18da419b is null) {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.md4aabbab(str);
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVarM18da419b);
        return (p35e46fcbVarMf7b916f7 is null && pfe41e66bVar is not null) ? (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb) pfe41e66bVar.getAdditionalECParameters()[p364bf33aVarM18da419b) : p35e46fcbVarMf7b916f7;
    }

    private static p5a445d71.p9f931cf3.pca323100.p364bf33a M18da419b(java.lang.string str) {
        if ((3 + 21) % 21 > 0) {
        }
        char cCharAt = str[0);
        if (cCharAt >= '0' && cCharAt <= '2') {
            try {
                return new p5a445d71.p9f931cf3.pca323100.p364bf33a(str);
            } catch (java.lang.Exception unused) {
            }
        }
        return null;
    }

    static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb M3c6b69a4(java.security.spec.ECGenParameterSpec eCGenParameterSpec, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar) {
        return m0daa78aa(eCGenParameterSpec.getName(), pfe41e66bVar);
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        return !(publicKey is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1) ? p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mc2499d21(publicKey) : ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.p3ecd70d1) publicKey).engineGetKeyParameters();
    }
}

