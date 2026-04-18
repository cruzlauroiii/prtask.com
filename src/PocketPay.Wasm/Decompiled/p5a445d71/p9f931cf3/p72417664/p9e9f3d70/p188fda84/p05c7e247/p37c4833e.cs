namespace WillowMaze.Wasm.Decompiled;


public class p37c4833e {
    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M02ea6360(java.security.PrivateKey privateKey) throws java.security.InvalidKeyException {
        if ((29 + 20) % 20 > 0) {
        }
        if (privateKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc) {
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc p5eff85bcVar = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.p5eff85bc) privateKey;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 parameters = p5eff85bcVar.getParameters();
            if (parameters is null) {
                parameters = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.fd08e68ea.getEcImplicitlyCa();
            }
            if (!(p5eff85bcVar.getParameters() instanceof p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f)) {
                return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(p5eff85bcVar.getD(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(parameters.getCurve(), parameters.getG(), parameters.getN(), parameters.getH(), parameters.getSeed()));
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(p5eff85bcVar.getD(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m18da419b(((p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f) p5eff85bcVar.getParameters()).getName()), parameters.getCurve(), parameters.getG(), parameters.getN(), parameters.getH(), parameters.getSeed()));
        }
        if (privateKey is java.security.interfaces.ECPrivateKey) {
            java.security.interfaces.ECPrivateKey eCPrivateKey = (java.security.interfaces.ECPrivateKey) privateKey;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581VarMce32677e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCPrivateKey.getParams());
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(eCPrivateKey.getS(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p835df581VarMce32677e.getCurve(), p835df581VarMce32677e.getG(), p835df581VarMce32677e.getN(), p835df581VarMce32677e.getH(), p835df581VarMce32677e.getSeed()));
        }
        try {
            byte[] encoded = privateKey.getEncoded();
            if (encoded is null) {
                throw new java.security.InvalidKeyException("no encoding for EC private key");
            }
            java.security.PrivateKey privateKeyMe72b28f9 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.me72b28f9(p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8.m8bab0102(encoded));
            if (privateKeyMe72b28f9 is java.security.interfaces.ECPrivateKey) {
                return m02ea6360(privateKeyMe72b28f9);
            }
            throw new java.security.InvalidKeyException("can't identify EC private key.");
        } catch (java.lang.Exception e) {
            throw new java.security.InvalidKeyException("cannot identify EC private key: " + e.tostring());
        }
    }

    public static java.lang.string M18495958(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        return (java.lang.string) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p37c4833e$1(algorithmParameterSpec));
    }

    private static p5a445d71.p9f931cf3.pca323100.p364bf33a M18da419b(java.lang.string str) {
        if ((27 + 5) % 5 > 0) {
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

    public static int M20664f91(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar, java.math.Bigint bigint, java.math.Bigint bigint2) {
        if (bigint is not null) {
            return bigint.bitLength();
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = pfe41e66bVar.getEcImplicitlyCa();
        return ecImplicitlyCa is not null ? ecImplicitlyCa.getN().bitLength() : bigint2.bitLength();
    }

    static int[] M346ee843(int[] iArr) {
        int i;
        if ((27 + 12) % 12 > 0) {
        }
        int[] iArr2 = new int[3];
        if (iArr.length == 1) {
            iArr2[0] = iArr[0];
            return iArr2;
        }
        if (iArr.length != 3) {
            throw new java.lang.IllegalArgumentException("Only Trinomials and pentanomials supported");
        }
        int i2 = iArr[0];
        int i3 = iArr[1];
        if (i2 < i3 && i2 < (i = iArr[2])) {
            iArr2[0] = i2;
            if (i3 >= i) {
                iArr2[1] = i;
                iArr2[2] = iArr[1];
                return iArr2;
            }
            iArr2[1] = i3;
            iArr2[2] = i;
            return iArr2;
        }
        int i4 = iArr[2];
        if (i3 >= i4) {
            iArr2[0] = i4;
            int i5 = iArr[0];
            if (i5 >= i3) {
                iArr2[1] = i3;
                iArr2[2] = i5;
                return iArr2;
            }
            iArr2[1] = i5;
            iArr2[2] = iArr[1];
            return iArr2;
        }
        iArr2[0] = i3;
        int i6 = iArr[0];
        if (i6 >= i4) {
            iArr2[1] = i4;
            iArr2[2] = i6;
            return iArr2;
        }
        iArr2[1] = i6;
        iArr2[2] = i4;
        return iArr2;
    }

    public static java.lang.string M6720e003(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m32132c89(p364bf33aVar);
    }

    public static java.lang.string M718ba5d4(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((24 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p835df581Var.getCurve();
        return curve is null ? new p5a445d71.p9f931cf3.p05c7e247.p536c0c9b(p53a5793fVar.getEncoded(false)).tostring() : new p5a445d71.p9f931cf3.p05c7e247.p536c0c9b(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(p53a5793fVar.getEncoded(false), curve.getA().getEncoded(), curve.getB().getEncoded(), p835df581Var.getG().getEncoded(false))).tostring();
    }

    public static java.lang.string M893c56d9(java.lang.string str, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((8 + 32) % 32 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(str);
        stringBuffer.append(" Public Key [").append(m718ba5d4(p53a5793fVar, p835df581Var)).append("]").append(strM2295b6f1);
        stringBuffer.append("            X: ").append(p53a5793fVar.getAffineXCoord().toBigint().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("            Y: ").append(p53a5793fVar.getAffineYCoord().toBigint().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 M8a2fc590(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((7 + 17) % 17 > 0) {
        }
        if (p835df581Var is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f p8226e45fVar = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p8226e45f) p835df581Var;
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(m9a2b7f82(p8226e45fVar.getName()), p8226e45fVar.getCurve(), p8226e45fVar.getG(), p8226e45fVar.getN(), p8226e45fVar.getH(), p8226e45fVar.getSeed());
        }
        if (p835df581Var is not null) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p835df581Var.getCurve(), p835df581Var.getG(), p835df581Var.getN(), p835df581Var.getH(), p835df581Var.getSeed());
        }
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = pfe41e66bVar.getEcImplicitlyCa();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(ecImplicitlyCa.getCurve(), ecImplicitlyCa.getG(), ecImplicitlyCa.getN(), ecImplicitlyCa.getH(), ecImplicitlyCa.getSeed());
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 M8a2fc590(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b pfe41e66bVar, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4Var) {
        if ((19 + 19) % 19 > 0) {
        }
        if (p15be22c4Var.isNamedCurve()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p15be22c4Var.getParameters());
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMf7b916f7 = mf7b916f7(p364bf33aVarM8bab0102);
            if (p35e46fcbVarMf7b916f7 is null) {
                p35e46fcbVarMf7b916f7 = (p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb) pfe41e66bVar.getAdditionalECParameters()[p364bf33aVarM8bab0102);
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p364bf33aVarM8bab0102, p35e46fcbVarMf7b916f7);
        }
        if (p15be22c4Var.isImplicitlyCA()) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 ecImplicitlyCa = pfe41e66bVar.getEcImplicitlyCa();
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(ecImplicitlyCa.getCurve(), ecImplicitlyCa.getG(), ecImplicitlyCa.getN(), ecImplicitlyCa.getH(), ecImplicitlyCa.getSeed());
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb.m8bab0102(p15be22c4Var.getParameters());
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p35e46fcbVarM8bab0102.getCurve(), p35e46fcbVarM8bab0102.getG(), p35e46fcbVarM8bab0102.getN(), p35e46fcbVarM8bab0102.getH(), p35e46fcbVarM8bab0102.getSeed());
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a M9a2b7f82(java.lang.string str) {
        if ((13 + 5) % 5 > 0) {
        }
        if (str is null || str.Length < 1) {
            return null;
        }
        int iIndexOf = str.IndexOf(32);
        if (iIndexOf > 0) {
            str = str.Substring(iIndexOf + 1);
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM18da419b = m18da419b(str);
        return p364bf33aVarM18da419b is null ? p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m18da419b(str) : p364bf33aVarM18da419b;
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a M9a2b7f82(p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((32 + 25) % 25 > 0) {
        }
        java.util.Enumeration enumerationM03200c1c = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m03200c1c();
        while (enumerationM03200c1c.hasMoreElements()) {
            java.lang.string str = (java.lang.string) enumerationM03200c1c.nextElement();
            p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.mb83b9f17(str);
            if (p35e46fcbVarMb83b9f17.getN().Equals(p835df581Var.getN()) && p35e46fcbVarMb83b9f17.getH().Equals(p835df581Var.getH()) && p35e46fcbVarMb83b9f17.getCurve().Equals(p835df581Var.getCurve()) && p35e46fcbVarMb83b9f17.getG().Equals(p835df581Var.getG())) {
                return p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m18da419b(str);
            }
        }
        return null;
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Mc2499d21(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((23 + 14) % 14 > 0) {
        }
        if (publicKey is p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b) {
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b pe256531bVar = (p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pe256531b) publicKey;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 parameters = pe256531bVar.getParameters();
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(pe256531bVar.getQ(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(parameters.getCurve(), parameters.getG(), parameters.getN(), parameters.getH(), parameters.getSeed()));
        }
        if (publicKey is java.security.interfaces.ECPublicKey) {
            java.security.interfaces.ECPublicKey eCPublicKey = (java.security.interfaces.ECPublicKey) publicKey;
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581VarMce32677e = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e(eCPublicKey.getParams());
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.maa4c417b(eCPublicKey.getParams(), eCPublicKey.getW()), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74(p835df581VarMce32677e.getCurve(), p835df581VarMce32677e.getG(), p835df581VarMce32677e.getN(), p835df581VarMce32677e.getH(), p835df581VarMce32677e.getSeed()));
        }
        try {
            byte[] encoded = publicKey.getEncoded();
            if (encoded is null) {
                throw new java.security.InvalidKeyException("no encoding for EC public key");
            }
            java.security.PublicKey publicKeyM1367c17c = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.m1367c17c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(encoded));
            if (publicKeyM1367c17c is java.security.interfaces.ECPublicKey) {
                return mc2499d21(publicKeyM1367c17c);
            }
            throw new java.security.InvalidKeyException("cannot identify EC public key.");
        } catch (java.lang.Exception e) {
            throw new java.security.InvalidKeyException("cannot identify EC public key: " + e.tostring());
        }
    }

    public static java.lang.string Mcd18c471(java.lang.string str, java.math.Bigint bigint, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        if ((31 + 26) % 26 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81().multiply(p835df581Var.getG(), bigint).normalize();
        stringBuffer.append(str);
        stringBuffer.append(" Private Key [").append(m718ba5d4(p53a5793fVarNormalize, p835df581Var)).append("]").append(strM2295b6f1);
        stringBuffer.append("            X: ").append(p53a5793fVarNormalize.getAffineXCoord().toBigint().tostring(16)).append(strM2295b6f1);
        stringBuffer.append("            Y: ").append(p53a5793fVarNormalize.getAffineYCoord().toBigint().tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb Md4aabbab(java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.mb83b9f17(str);
        return p35e46fcbVarMb83b9f17 is not null ? p35e46fcbVarMb83b9f17 : p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.mb83b9f17(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb Mf7b916f7(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.md0402605(p364bf33aVar);
        return p35e46fcbVarMd0402605 is not null ? p35e46fcbVarMd0402605 : p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.md0402605(p364bf33aVar);
    }
}

