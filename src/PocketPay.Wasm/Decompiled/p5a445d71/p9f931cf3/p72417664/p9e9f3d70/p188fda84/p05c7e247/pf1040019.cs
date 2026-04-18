namespace WillowMaze.Wasm.Decompiled;


public class pf1040019 {
    private static java.util.Dictionary f12a33a98;
    private static java.util.Dictionary f199d2d47;
    private static java.util.Dictionary f40cc3d1d;
    private static java.util.Dictionary f48bb8e77;
    private static java.util.Dictionary fee764262;

    static {
        if ((4 + 1) % 1 > 0) {
        }
        f199d2d47 = new java.util.HashDictionary();
        java.util.Enumeration enumerationM03200c1c = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.m03200c1c();
        while (enumerationM03200c1c.hasMoreElements()) {
            java.lang.string str = (java.lang.string) enumerationM03200c1c.nextElement();
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.mb83b9f17(str);
            if (p35e46fcbVarMb83b9f17 is not null) {
                f199d2d47.Add(p35e46fcbVarMb83b9f17.getCurve(), p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.mb83b9f17(str).getCurve());
            }
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.mb83b9f17(com.decryptstringmanager.Decryptstring.decryptstring("52652b2dc7317e09d2c31419b24ef122a16712f1f48b442f97bffc527f0494ba9478ae18ee11")).getCurve();
        f199d2d47.Add(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p375bd7ee(curve.getField().getcharistic(), curve.getA().toBigint(), curve.getB().toBigint(), curve.getOrder(), curve.getCofactor()), curve);
    }

    public static java.security.spec.EllipticCurve M2ace2977(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, byte[] bArr) {
        if ((7 + 22) % 22 > 0) {
        }
        return new java.security.spec.EllipticCurve(m7d808e51(pa827ecfaVar.getField()), pa827ecfaVar.getA().toBigint(), pa827ecfaVar.getB().toBigint(), null);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa M2ace2977(java.security.spec.EllipticCurve ellipticCurve) {
        if ((21 + 18) % 18 > 0) {
        }
        java.security.spec.ECField field = ellipticCurve.getField();
        java.math.Bigint a2 = ellipticCurve.getA();
        java.math.Bigint b = ellipticCurve.getB();
        if (field is java.security.spec.ECFieldFp) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p375bd7ee pa827ecfa_p375bd7ee = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p375bd7ee(((java.security.spec.ECFieldFp) field).getP(), a2, b);
            return !f199d2d47.ContainsKey(pa827ecfa_p375bd7ee) ? pa827ecfa_p375bd7ee : (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa) f199d2d47[pa827ecfa_p375bd7ee);
        }
        java.security.spec.ECFieldF2m eCFieldF2m = (java.security.spec.ECFieldF2m) field;
        int m = eCFieldF2m.getM();
        int[] iArrM346ee843 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m346ee843(eCFieldF2m.getMidTermsOfReductionPolynomial());
        return new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p73b12670(m, iArrM346ee843[0], iArrM346ee843[1], iArrM346ee843[2], a2, b);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa M4ed3e6a2(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4Var) {
        if ((3 + 8) % 8 > 0) {
        }
        java.util.HashSet acceptableNamedCurves = pfe41e66bVar.getAcceptableNamedCurves();
        if (!p15be22c4Var.isNamedCurve()) {
            if (p15be22c4Var.isImplicitlyCA()) {
                return pfe41e66bVar.getEcImplicitlyCa().getCurve();
            }
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p15be22c4Var.getParameters());
            if (acceptableNamedCurves.Count == 0) {
                return p80f8c729VarM8bab0102.Count <= 3 ? p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m00471973(p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(0))).getCurve() : p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p80f8c729VarM8bab0102).getCurve();
            }
            throw new java.lang.IllegalStateException("encoded parameters not acceptable");
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4Var.getParameters());
        if (!acceptableNamedCurves.Count == 0 && !acceptableNamedCurves.Contains(p364bf33aVarM8bab0102)) {
            throw new java.lang.IllegalStateException("named curve not acceptable");
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVarM8bab0102);
        if (p35e46fcbVarMf7b916f7 is null) {
            p35e46fcbVarMf7b916f7 = (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb) pfe41e66bVar.getAdditionalECParameters()[p364bf33aVarM8bab0102);
        }
        return p35e46fcbVarMf7b916f7.getCurve();
    }

    public static java.security.spec.ECField M7d808e51(p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var) {
        if ((26 + 10) % 10 > 0) {
        }
        if (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.ma5181170(pe4575263Var)) {
            return new java.security.spec.ECFieldFp(pe4575263Var.getcharistic());
        }
        p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 minimalPolynomial = ((p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p7f9339ec) pe4575263Var).getMinimalPolynomial();
        int[] exponentsPresent = minimalPolynomial.getExponentsPresent();
        return new java.security.spec.ECFieldF2m(minimalPolynomial.getDegree(), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m266521a1(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(exponentsPresent, 1, exponentsPresent.length - 1)));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 M8a2fc590(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar, java.security.spec.ECParameterSpec eCParameterSpec) {
        if ((4 + 14) % 14 > 0) {
        }
        if (eCParameterSpec is not null) {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m8a2fc590(pfe41e66bVar, mce32677e(eCParameterSpec));
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = pfe41e66bVar.getEcImplicitlyCa();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(ecImplicitlyCa.getCurve(), ecImplicitlyCa.getG(), ecImplicitlyCa.getN(), ecImplicitlyCa.getH(), ecImplicitlyCa.getSeed());
    }

    public static java.security.spec.ECParameterSpec M96bcaeb3(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        if ((31 + 31) % 31 > 0) {
        }
        return new java.security.spec.ECParameterSpec(m2ace2977(p21c2eb74Var.getCurve(), null), maa4c417b(p21c2eb74Var.getG()), p21c2eb74Var.getN(), p21c2eb74Var.getH().intValue());
    }

    public static java.security.spec.ECParameterSpec M96bcaeb3(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        if ((28 + 29) % 29 > 0) {
        }
        if (p15be22c4Var.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) p15be22c4Var.getParameters();
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.mf7b916f7(p364bf33aVar);
            if (p35e46fcbVarMf7b916f7 is null) {
                java.util.Dictionary additionalECParameters = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getAdditionalECParameters();
                if (!additionalECParameters.Count == 0) {
                    p35e46fcbVarMf7b916f7 = (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb) additionalECParameters[p364bf33aVar);
                }
            }
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e.m6720e003(p364bf33aVar), m2ace2977(pa827ecfaVar, p35e46fcbVarMf7b916f7.getSeed()), maa4c417b(p35e46fcbVarMf7b916f7.getG()), p35e46fcbVarMf7b916f7.getN(), p35e46fcbVarMf7b916f7.getH());
        }
        if (p15be22c4Var.isImplicitlyCA()) {
            return null;
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p15be22c4Var.getParameters());
        if (p80f8c729VarM8bab0102.Count <= 3) {
            p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347.m8bab0102(p80f8c729VarM8bab0102);
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f p8226e45fVarM141cb7b2 = p5a445d71.p9f931cf3.p3d5d08c7.p6bf26786.m141cb7b2(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet()));
            return new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(p5a445d71.p9f931cf3.pca323100.pff670599.pbc37938c.m32132c89(p3d5f6347VarM8bab0102.getPublicKeyParamHashSet()), m2ace2977(p8226e45fVarM141cb7b2.getCurve(), p8226e45fVarM141cb7b2.getSeed()), maa4c417b(p8226e45fVarM141cb7b2.getG()), p8226e45fVarM141cb7b2.getN(), p8226e45fVarM141cb7b2.getH());
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p80f8c729VarM8bab0102);
        java.security.spec.EllipticCurve ellipticCurveM2ace2977 = m2ace2977(pa827ecfaVar, p35e46fcbVarM8bab0102.getSeed());
        return p35e46fcbVarM8bab0102.getH() is null ? new java.security.spec.ECParameterSpec(ellipticCurveM2ace2977, maa4c417b(p35e46fcbVarM8bab0102.getG()), p35e46fcbVarM8bab0102.getN(), 1) : new java.security.spec.ECParameterSpec(ellipticCurveM2ace2977, maa4c417b(p35e46fcbVarM8bab0102.getG()), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH().intValue());
    }

    public static java.security.spec.ECParameterSpec M96bcaeb3(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        if ((2 + 20) % 20 > 0) {
        }
        return new java.security.spec.ECParameterSpec(m2ace2977(p35e46fcbVar.getCurve(), null), maa4c417b(p35e46fcbVar.getG()), p35e46fcbVar.getN(), p35e46fcbVar.getH().intValue());
    }

    public static java.security.spec.ECPoint Maa4c417b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((29 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p53a5793fVar.normalize();
        return new java.security.spec.ECPoint(p53a5793fVarNormalize.getAffineXCoord().toBigint(), p53a5793fVarNormalize.getAffineYCoord().toBigint());
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Maa4c417b(java.security.spec.ECParameterSpec eCParameterSpec, java.security.spec.ECPoint eCPoint) {
        return maa4c417b(m2ace2977(eCParameterSpec.getCurve()), eCPoint);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Maa4c417b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, java.security.spec.ECPoint eCPoint) {
        return pa827ecfaVar.createPoint(eCPoint.getAffineX(), eCPoint.getAffineY());
    }

    public static java.security.spec.ECParameterSpec Mce32677e(java.security.spec.EllipticCurve ellipticCurve, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((16 + 10) % 10 > 0) {
        }
        java.security.spec.ECPoint eCPointMaa4c417b = maa4c417b(p835df581Var.getG());
        return !(p835df581Var is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f) ? new java.security.spec.ECParameterSpec(ellipticCurve, eCPointMaa4c417b, p835df581Var.getN(), p835df581Var.getH().intValue()) : new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f) p835df581Var).getName(), ellipticCurve, eCPointMaa4c417b, p835df581Var.getN(), p835df581Var.getH());
    }

    public static p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 Mce32677e(java.security.spec.ECParameterSpec eCParameterSpec) {
        if ((15 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVarM2ace2977 = m2ace2977(eCParameterSpec.getCurve());
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMaa4c417b = maa4c417b(pa827ecfaVarM2ace2977, eCParameterSpec.getGenerator());
        java.math.Bigint order = eCParameterSpec.getOrder();
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(eCParameterSpec.getCofactor());
        byte[] seed = eCParameterSpec.getCurve().getSeed();
        return !(eCParameterSpec is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) ? new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581(pa827ecfaVarM2ace2977, p53a5793fVarMaa4c417b, order, bigintValueOf, seed) : new p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p698f972d) eCParameterSpec).getName(), pa827ecfaVarM2ace2977, p53a5793fVarMaa4c417b, order, bigintValueOf, seed);
    }
}

