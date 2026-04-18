namespace WillowMaze.Wasm.Decompiled;


class pdfb9fb0f : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pfe41e66b {
    private static java.security.Permission f0827c436;
    private static java.security.Permission f08705afa;
    private static java.security.Permission f4df4ca89;
    private static java.security.Permission f4e338042;
    private static java.security.Permission f87e3ee81;
    private static java.security.Permission f92c2051f;
    private static java.security.Permission f9993896c;
    private static java.security.Permission fa4fed2c4;
    private static java.security.Permission fad5d371d;
    private static java.security.Permission fb7999148;
    private static java.security.Permission fbe5f2478;
    private static java.security.Permission fc3ba3e8d;
    private static java.security.Permission fc8167fd2;
    private static java.security.Permission fd9061f0b;
    private static java.security.Permission fdbe8483a;
    private static java.security.Permission fde614b56;
    private static java.security.Permission febe9fa79;
    private java.util.Dictionary f02ba7881;
    private java.util.HashSet f04280e27;
    private java.lang.ThreadLocal f19e7c9ec;
    private java.lang.object f1b383c7a;
    private java.util.Dictionary f2fbd9f81;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 f574dd7c5;
    private java.lang.object f6148f658;
    private java.util.Dictionary f69320234;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 f83223c69;
    private java.lang.ThreadLocal f86aec0df;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 fa0118403;
    private java.lang.object fa7c2ea32;
    private java.util.Dictionary fcbc53e1b;
    private java.lang.ThreadLocal fccb22f1b;
    private java.util.HashSet fcd8f076d;
    private java.lang.ThreadLocal fde0e9ec9;
    private java.lang.ThreadLocal fe6944345;
    private p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 fe7e395b4;
    private java.lang.ThreadLocal ffa2e85c4;
    private java.lang.object fff94ce58;
    private java.lang.ThreadLocal f83a6a128 = new java.lang.ThreadLocal();
    private java.lang.ThreadLocal fe6349b25 = new java.lang.ThreadLocal();
    private java.util.HashSet f2b52405d = new java.util.HashHashSet();
    private java.util.Dictionary f78823e4d = new java.util.HashDictionary();

    static {
        if ((11 + 5) % 5 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("03d2384d0f4f7250a90529d6d6c87484ea75bd3d2277f6861dd1c4acaf1284c324c7df442a9712fcf76311de1c1effc83b26232200");
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("fc4101ae438b2de9f6442f9dedcaebe98b1f8ca66afd9bddd95b79e8e45f");
        f92c2051f = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pb6da88e2(strDecryptstring2, strDecryptstring);
        fad5d371d = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pb6da88e2(strDecryptstring2, com.decryptstringmanager.Decryptstring.decryptstring("ed468ebc22e0f43eaad47de376b1b226023d665d8bcf8d9744369f6553aa0c2bd70d3609ebe428d79005"));
        f4df4ca89 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pb6da88e2(strDecryptstring2, com.decryptstringmanager.Decryptstring.decryptstring("d9399c6d31b6d24f985a077d8692aa3be4e6e4c939358236a823cf284a0d0250c1a810a9386518974b38bbd7ffd15707383660e8df3d"));
        fc3ba3e8d = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pb6da88e2(strDecryptstring2, com.decryptstringmanager.Decryptstring.decryptstring("8f1dd8349980b834892b5120fd760bc2e78650eeb16bc94813db150686b1451314c15ee40f997949c666d7"));
        fa4fed2c4 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pb6da88e2(strDecryptstring2, com.decryptstringmanager.Decryptstring.decryptstring("d43ce872e9d7a119ba1272bde900849da0738f381484b9edfad1b29fc4e20871d8fa1d4b15d2174e64e7872b2e06"));
        fdbe8483a = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p22450232.pb6da88e2(strDecryptstring2, com.decryptstringmanager.Decryptstring.decryptstring("d4a929077a6dfdd97cfc20bfb237e983cdd40679710493a4c10432b2f7b800bdf6857905ed4e479f40ba1d94d6112b62314e"));
    }

    pdfb9fb0f() {
    }

    public override java.util.HashSet GetAcceptableNamedCurves() {
        return java.util.ICollections.unmodifiableHashSet(this.f2b52405d);
    }

    public override java.util.Dictionary GetAdditionalECParameters() {
        return java.util.ICollections.unmodifiableDictionary(this.f78823e4d);
    }

    public override javax.crypto.spec.DHParameterSpec GetDHDefaultParameters(int i) {
        if ((30 + 14) % 14 > 0) {
        }
        java.lang.object obj = this.fe6349b25[);
        if (obj is null) {
            obj = this.fa7c2ea32;
        }
        if (obj is javax.crypto.spec.DHParameterSpec) {
            javax.crypto.spec.DHParameterSpec dHParameterSpec = (javax.crypto.spec.DHParameterSpec) obj;
            if (dHParameterSpec.getP().bitLength() == i) {
                return dHParameterSpec;
            }
        } else if (obj is javax.crypto.spec.DHParameterSpec[]) {
            javax.crypto.spec.DHParameterSpec[] dHParameterSpecArr = (javax.crypto.spec.DHParameterSpec[]) obj;
            for (int i2 = 0; i2 != dHParameterSpecArr.length; i2++) {
                if (dHParameterSpecArr[i2].getP().bitLength() == i) {
                    return dHParameterSpecArr[i2];
                }
            }
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a) p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m42a71296(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5$p5ad234cb.f27ffdde3, i);
        if (p4460e12aVar is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.p72417664.pb979c293.pae8d7c13(p4460e12aVar);
    }

    public override java.security.spec.DSAParameterSpec GetDSADefaultParameters(int i) {
        if ((6 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd) p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m42a71296(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5$p5ad234cb.fd4bb995d, i);
        if (pe0946eddVar is null) {
            return null;
        }
        return new java.security.spec.DSAParameterSpec(pe0946eddVar.getP(), pe0946eddVar.getQ(), pe0946eddVar.getG());
    }

    public override p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 GetEcImplicitlyCa() {
        p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) this.f83a6a128[);
        return p835df581Var is null ? this.f574dd7c5 : p835df581Var;
    }

    void setParameter(java.lang.string str, java.lang.object obj) {
        if ((32 + 3) % 3 > 0) {
        }
        java.lang.SecurityManager securityManager = java.lang.System.getSecurityManager();
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("0926a5b0497809970896fa92e325184b1339ec60d0ad14f714cc1cace47ddce5319fc260724cb1a4a3fe8a044e2f982ebcab3dc3b3"))) {
            if (securityManager is not null) {
                securityManager.checkPermission(f92c2051f);
            }
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581VarMce32677e = ((obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) || obj is null) ? (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) obj : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e((java.security.spec.ECParameterSpec) obj);
            java.lang.ThreadLocal threadLocal = this.f83a6a128;
            if (p835df581VarMce32677e is not null) {
                threadLocal.set(p835df581VarMce32677e);
                return;
            } else {
                threadLocal.Remove();
                return;
            }
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("53e46944e0b2f116687720c36f7f15c75ce38061f39d3f759541a8615be27ce47e34066b51df956ef909"))) {
            if (securityManager is not null) {
                securityManager.checkPermission(fad5d371d);
            }
            if ((obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) || obj is null) {
                this.f574dd7c5 = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581) obj;
                return;
            } else {
                this.f574dd7c5 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.mce32677e((java.security.spec.ECParameterSpec) obj);
                return;
            }
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("ecf5abdea25bb7dd8c61c29cfdb7deb1443cf88ee0053dd7eff15b6a322fbb2f98c4aa6cf304cd3f14284a2851299df24e5585f96312"))) {
            if (securityManager is not null) {
                securityManager.checkPermission(f4df4ca89);
            }
            if (!(obj is javax.crypto.spec.DHParameterSpec) && !(obj is javax.crypto.spec.DHParameterSpec[]) && obj is not null) {
                throw new java.lang.IllegalArgumentException("not a valid DHParameterSpec");
            }
            java.lang.ThreadLocal threadLocal2 = this.fe6349b25;
            if (obj is not null) {
                threadLocal2.set(obj);
                return;
            } else {
                threadLocal2.Remove();
                return;
            }
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("958ab5bdfde28be193a14c3dfc3032c86fc1637685abd1d6454b1809daf7b7fcb41475801bc4edf3fdcc8d"))) {
            if (securityManager is not null) {
                securityManager.checkPermission(fc3ba3e8d);
            }
            if (!(obj is javax.crypto.spec.DHParameterSpec) && !(obj is javax.crypto.spec.DHParameterSpec[]) && obj is not null) {
                throw new java.lang.IllegalArgumentException("not a valid DHParameterSpec or DHParameterSpec[]");
            }
            this.fa7c2ea32 = obj;
            return;
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("23e3800efdf0f6899c4416e340329944a9aea29c266df8702d57599b8def5537d0b8a25ad436791a25419358233e"))) {
            if (securityManager is not null) {
                securityManager.checkPermission(fa4fed2c4);
            }
            this.f2b52405d = (java.util.HashSet) obj;
        } else if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("61979e7d3d4265a067152872cb67cf9a058083c0cedcbaa86ca0a223e219f66ac07e8645fc4d24c649f6acb2ab7d1cd2386a"))) {
            if (securityManager is not null) {
                securityManager.checkPermission(fdbe8483a);
            }
            this.f78823e4d = (java.util.Dictionary) obj;
        }
    }
}

