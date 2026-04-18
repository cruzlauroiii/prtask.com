namespace WillowMaze.Wasm.Decompiled;


public class pb3a2dfcc {
    private static java.util.HashSet f3e3a2044;
    private static java.util.HashSet f77657376;

    static {
        if ((31 + 30) % 30 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(5);
        f3e3a2044 = hashHashSet;
        hashHashSet.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fbc73b0ac);
        f3e3a2044.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f869add67);
        f3e3a2044.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.fb03ec018);
        f3e3a2044.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f887b8f48);
        f3e3a2044.Add(p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f7f5a379a);
    }

    private pb3a2dfcc() {
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 M258e1870(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) throws java.io.IOException {
        return m258e1870(pcfffbc4aVar, null);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 M258e1870(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4 p15be22c4Var;
        java.math.Bigint d;
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar;
        if ((21 + 26) % 26 > 0) {
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p753eae39) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9 p859968b9Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fc5069f4b, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17), new p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1(p859968b9Var.getModulus(), p859968b9Var.getPublicExponent(), p859968b9Var.getExponent(), p859968b9Var.getP(), p859968b9Var.getQ(), p859968b9Var.getDP(), p859968b9Var.getDQ(), p859968b9Var.getQInv()), ped34daf1Var);
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170 pacb8a170Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) pcfffbc4aVar;
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd parameters = pacb8a170Var.getParameters();
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f5ecd4ad9, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3db0d479(parameters.getP(), parameters.getQ(), parameters.getG())), new p5a445d71.p9f931cf3.pca323100.pf391b73d(pacb8a170Var.getX()), ped34daf1Var);
        }
        if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a)) {
            if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75 p62f08e75Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p62f08e75) pcfffbc4aVar;
                return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fa0d3fc7e), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p62f08e75Var.getEncoded()), ped34daf1Var, p62f08e75Var.generatePublicKey().getEncoded());
            }
            if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d p11d92f7dVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p11d92f7d) pcfffbc4aVar;
                return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.fb33b8d76), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p11d92f7dVar.getEncoded()), ped34daf1Var, p11d92f7dVar.generatePublicKey().getEncoded());
            }
            if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e pf1c3b35eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pf1c3b35e) pcfffbc4aVar;
                return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f37149689), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pf1c3b35eVar.getEncoded()), ped34daf1Var, pf1c3b35eVar.generatePublicKey().getEncoded());
            }
            if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1)) {
                throw new java.io.IOException("key parameters not recognized");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 pe1b9a0e1Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pdbd28212.p8b31b482.f3b7f504a), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pe1b9a0e1Var.getEncoded()), ped34daf1Var, pe1b9a0e1Var.generatePublicKey().getEncoded());
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a p06022b5aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a) pcfffbc4aVar;
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 parameters2 = p06022b5aVar.getParameters();
        if (parameters2 is null) {
            p15be22c4Var = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4((p5a445d71.p9f931cf3.pca323100.pb9fa8367) p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
            d = p06022b5aVar.getD();
        } else {
            if (parameters2 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483 p2cc33483Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2cc33483) parameters2;
                p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347 p3d5f6347Var = new p5a445d71.p9f931cf3.pca323100.pff670599.p3d5f6347(p2cc33483Var.getPublicKeyParamHashSet(), p2cc33483Var.getDigestParamHashSet(), p2cc33483Var.getEncryptionParamHashSet());
                if (f3e3a2044.Contains(p3d5f6347Var.getPublicKeyParamHashSet())) {
                    p364bf33aVar = p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f35728f7c;
                } else {
                    bool z = p06022b5aVar.getD().bitLength() > 256;
                    p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar2 = !z ? p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.f39e9543a : p5a445d71.p9f931cf3.pca323100.pa3a9d01b.pe227bd0e.fbeb24ab5;
                    i = z ? 64 : 32;
                    p364bf33aVar = p364bf33aVar2;
                }
                byte[] bArr = new byte[i];
                m97d9d39a(bArr, i, 0, p06022b5aVar.getD());
                return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p364bf33aVar, p3d5f6347Var), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr));
            }
            p15be22c4Var = !(parameters2 is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c) ? new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb(parameters2.getCurve(), new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p713357f2(parameters2.getG(), false), parameters2.getN(), parameters2.getH(), parameters2.getSeed())) : new p5a445d71.p9f931cf3.pca323100.pd0c2225b.p15be22c4(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c) parameters2).getName());
            d = parameters2.getN();
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f070fb7e3, p15be22c4Var), new p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc(d.bitLength(), p06022b5aVar.getD(), new p5a445d71.p9f931cf3.pca323100.p1522cc54(new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81().multiply(parameters2.getG(), p06022b5aVar.getD()).getEncoded(false)), p15be22c4Var), ped34daf1Var);
    }

    private static void M97d9d39a(byte[] bArr, int i, int i2, java.math.Bigint bigint) {
        if ((29 + 15) % 15 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length < i) {
            byte[] bArr2 = new byte[i];
            java.lang.System.arraycopy(byteArray, 0, bArr2, i - byteArray.length, byteArray.length);
            byteArray = bArr2;
        }
        for (int i3 = 0; i3 != i; i3++) {
            bArr[i2 + i3] = byteArray[(byteArray.length - 1) - i3];
        }
    }
}

