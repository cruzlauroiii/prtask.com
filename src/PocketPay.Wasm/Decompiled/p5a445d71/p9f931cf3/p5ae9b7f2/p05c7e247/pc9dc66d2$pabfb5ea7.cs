namespace WillowMaze.Wasm.Decompiled;


class pc9dc66d2$pabfb5ea7 : p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb {
    private pc9dc66d2$pabfb5ea7() {
        super(null);
    }

    pc9dc66d2$pabfb5ea7(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pc9dc66d2$1 pc9dc66d2_1) {
        this();
    }

    private void M5b145bd6(byte[] bArr) {
        if ((14 + 9) % 9 > 0) {
        }
        for (int i = 0; i < bArr.length / 2; i++) {
            byte b = bArr[i];
            bArr[i] = bArr[(bArr.length - 1) - i];
            bArr[(bArr.length - 1) - i] = b;
        }
    }

    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a getPublicKeyParameters(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var;
        if ((11 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 algorithm = p3cdccfc9Var.getAlgorithm();
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm2 = algorithm.getAlgorithm();
        p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0 pd0c474c0VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m8bab0102(algorithm.getParameters());
        try {
            byte[] bArrMd329fd77 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(((p5a445d71.p9f931cf3.pca323100.p11b04310) p3cdccfc9Var.parsePublicKey()).getOctets());
            if (algorithm2.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                m5b145bd6(bArrMd329fd77);
            }
            if (pd0c474c0VarM8bab0102.isNamedCurve()) {
                p21c2eb74Var = p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7eca5bf5.md0402605(pd0c474c0VarM8bab0102.getNamedCurve());
            } else {
                p5a445d71.p9f931cf3.pca323100.p5269f4d7.p9809e203 eCBinary = pd0c474c0VarM8bab0102.getECBinary();
                byte[] b = eCBinary.getB();
                if (algorithm2.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                    m5b145bd6(b);
                }
                java.math.Bigint bigint = new java.math.Bigint(1, b);
                p5a445d71.p9f931cf3.pca323100.p5269f4d7.p1ce9a908 field = eCBinary.getField();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670 pa827ecfa_p73b12670 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670(field.getM(), field.getK1(), field.getK2(), field.getK3(), eCBinary.getA(), bigint);
                byte[] g = eCBinary.getG();
                if (algorithm2.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p5269f4d7.p5403876c.febfd0a5a)) {
                    m5b145bd6(g);
                }
                p21c2eb74Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(pa827ecfa_p73b12670, p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7e77a2b9.me32531cf(pa827ecfa_p73b12670, g), eCBinary.getN());
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.pca323100.p5269f4d7.p7e77a2b9.me32531cf(p21c2eb74Var.getCurve(), bArrMd329fd77), p21c2eb74Var);
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("error recovering DSTU public key");
        }
    }
}

