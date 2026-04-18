namespace WillowMaze.Wasm.Decompiled;


public class pbc420844 {
    private static byte[] M84b1724d(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        return p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p811299f8Var.parsePrivateKey()).getOctets();
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(java.io.Stream inputStream) throws java.io.IOException {
        return me28b94be(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject()));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 p811299f8Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483 p2cc33483Var;
        java.math.Bigint bigint;
        if ((14 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 privateKeyAlgorithm = p811299f8Var.getPrivateKeyAlgorithm();
        p5a445d71.p9f931cf3.pca323100.p364bf33a algorithm = privateKeyAlgorithm.getAlgorithm();
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b) || algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980) || algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p756b0dc3.f9b47626c)) {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1 p970a24b1VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1.m8bab0102(p811299f8Var.parsePrivateKey());
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(p970a24b1VarM8bab0102.getModulus(), p970a24b1VarM8bab0102.getPublicExponent(), p970a24b1VarM8bab0102.getPrivateExponent(), p970a24b1VarM8bab0102.getPrime1(), p970a24b1VarM8bab0102.getPrime2(), p970a24b1VarM8bab0102.getExponent1(), p970a24b1VarM8bab0102.getExponent2(), p970a24b1VarM8bab0102.getCoefficient());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar = null;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483 p2cc33483Var2 = null;
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.ff981c4da)) {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14 pef342a14VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pef342a14.m8bab0102(privateKeyAlgorithm.getParameters());
            p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar = (p5a445d71.p9f931cf3.pca323100.pf391b73d) p811299f8Var.parsePrivateKey();
            java.math.Bigint l = pef342a14VarM8bab0102.getL();
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pc9dc4fec(pf391b73dVar.getValue(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a(pef342a14VarM8bab0102.getP(), pef342a14VarM8bab0102.getG(), null, l is not null ? l.intValue() : 0));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f4d65be17)) {
            p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f p524aa06fVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p3a8cb832.p524aa06f.m8bab0102(privateKeyAlgorithm.getParameters());
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8d0590d4(((p5a445d71.p9f931cf3.pca323100.pf391b73d) p811299f8Var.parsePrivateKey()).getValue(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p85d5a073(p524aa06fVarM8bab0102.getP(), p524aa06fVarM8bab0102.getG()));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9)) {
            p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar2 = (p5a445d71.p9f931cf3.pca323100.pf391b73d) p811299f8Var.parsePrivateKey();
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters = privateKeyAlgorithm.getParameters();
            if (parameters is not null) {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479 p3db0d479VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479.m8bab0102(parameters.toASN1Primitive());
                pe0946eddVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(p3db0d479VarM8bab0102.getP(), p3db0d479VarM8bab0102.getQ(), p3db0d479VarM8bab0102.getG());
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170(pf391b73dVar2.getValue(), pe0946eddVar);
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3)) {
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(privateKeyAlgorithm.getParameters());
            bool zIsNamedCurve = p15be22c4VarM8bab0102.isNamedCurve();
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 parameters2 = p15be22c4VarM8bab0102.getParameters();
            if (zIsNamedCurve) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) parameters2;
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.md0402605(p364bf33aVar);
                if (p35e46fcbVarMd0402605 is null) {
                    p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.md0402605(p364bf33aVar);
                }
                p21c2eb74Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p364bf33aVar, p35e46fcbVarMd0402605);
            } else {
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(parameters2);
                p21c2eb74Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p35e46fcbVarM8bab0102.getCurve(), p35e46fcbVarM8bab0102.getG(), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH(), p35e46fcbVarM8bab0102.getSeed());
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(p811299f8Var.parsePrivateKey()).getKey(), p21c2eb74Var);
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fb33b8d76)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d(m84b1724d(p811299f8Var));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75(m84b1724d(p811299f8Var));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1(m84b1724d(p811299f8Var));
        }
        if (algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e(m84b1724d(p811299f8Var));
        }
        if (!algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c) && !algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5) && !algorithm.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a)) {
            throw new java.lang.Exception("algorithm identifier in private key not recognised");
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters3 = privateKeyAlgorithm.getParameters();
        p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(parameters3);
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 aSN1Primitive = parameters3.toASN1Primitive();
        if ((aSN1Primitive is p5a445d71.p9f931cf3.pca323100.p80f8c729) && (p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(aSN1Primitive).Count == 2 || p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(aSN1Primitive).Count == 3)) {
            p2cc33483Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet(), p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet())), p3d5f6347VarM8bab0102.getPublicKeyParamHashSet(), p3d5f6347VarM8bab0102.getDigestParamHashSet(), p3d5f6347VarM8bab0102.getEncryptionParamHashSet());
            p5a445d71.p9f931cf3.pca323100.p11b04310 privateKey = p811299f8Var.getPrivateKey();
            if (privateKey.getOctets().length == 32 || privateKey.getOctets().length == 64) {
                bigint = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(privateKey.getOctets()));
            } else {
                p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey2 = p811299f8Var.parsePrivateKey();
                bigint = !(privateKey2 is p5a445d71.p9f931cf3.pca323100.pf391b73d) ? new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(privateKey2).getOctets())) : p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey2).getPositiveValue();
            }
        } else {
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4VarM8bab01022 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4.m8bab0102(privateKeyAlgorithm.getParameters());
            if (p15be22c4VarM8bab01022.isNamedCurve()) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4VarM8bab01022.getParameters());
                p2cc33483Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p364bf33aVarM8bab0102, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.md0402605(p364bf33aVarM8bab0102)), p3d5f6347VarM8bab0102.getPublicKeyParamHashSet(), p3d5f6347VarM8bab0102.getDigestParamHashSet(), p3d5f6347VarM8bab0102.getEncryptionParamHashSet());
            } else if (!p15be22c4VarM8bab01022.isImplicitlyCA()) {
                p2cc33483Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(algorithm, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4VarM8bab01022.getParameters())), p3d5f6347VarM8bab0102.getPublicKeyParamHashSet(), p3d5f6347VarM8bab0102.getDigestParamHashSet(), p3d5f6347VarM8bab0102.getEncryptionParamHashSet());
            }
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 privateKey3 = p811299f8Var.parsePrivateKey();
            bigint = !(privateKey3 is p5a445d71.p9f931cf3.pca323100.pf391b73d) ? p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(privateKey3).getKey() : p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(privateKey3).getValue();
            p2cc33483Var = p2cc33483Var2;
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(bigint, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483(p2cc33483Var, p3d5f6347VarM8bab0102.getPublicKeyParamHashSet(), p3d5f6347VarM8bab0102.getDigestParamHashSet(), p3d5f6347VarM8bab0102.getEncryptionParamHashSet()));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(byte[] bArr) throws java.io.IOException {
        return me28b94be(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)));
    }
}

