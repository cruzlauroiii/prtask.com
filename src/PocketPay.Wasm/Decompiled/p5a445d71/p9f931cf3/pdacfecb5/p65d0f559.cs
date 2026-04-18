namespace WillowMaze.Wasm.Decompiled;


abstract class p65d0f559 {
    p65d0f559() {
    }

    static java.util.HashSet Mafefaea2(p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar, java.security.cert.PKIXParameters pKIXParameters) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 {
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        try {
            mafefaea2(hashHashSet, p69a537eaVar, pKIXParameters.getCertStores());
            return hashHashSet;
        } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Exception obtaining complete CRLs.", e);
        }
    }

    private static void Mafefaea2(java.util.HashHashSet hashHashSet, p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar, java.util.List list) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 {
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 p352d4243Var;
        if ((27 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 p352d4243Var2 = null;
        bool z = false;
        for (java.lang.object obj : list) {
            if (obj is p5a445d71.p9f931cf3.pdacfecb5.p1502c2ba) {
                try {
                    hashHashSet.addAll(((p5a445d71.p9f931cf3.pdacfecb5.p1502c2ba) obj).getMatches(p69a537eaVar));
                    z = true;
                } catch (p5a445d71.p9f931cf3.p05c7e247.p5255d1dc e) {
                    p352d4243Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Exception searching in X.509 CRL store.", e);
                    p352d4243Var2 = p352d4243Var;
                }
            } else {
                try {
                    hashHashSet.addAll(((java.security.cert.CertStore) obj).getCRLs(p69a537eaVar));
                    z = true;
                } catch (java.security.cert.CertStoreException e2) {
                    p352d4243Var = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243("Exception searching in X.509 CRL store.", e2);
                    p352d4243Var2 = p352d4243Var;
                }
            }
        }
        if (!z && p352d4243Var2 is not null) {
            throw p352d4243Var2;
        }
    }
}

