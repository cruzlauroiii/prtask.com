namespace WillowMaze.Wasm.Decompiled;


public class pb3a2dfcc {
    private pb3a2dfcc() {
    }

    private static p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae M0e8d8070(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var) throws java.io.IOException {
        if ((28 + 1) % 1 > 0) {
        }
        byte[] encoded = p823c49a3Var.getEncoded();
        int treeDigestSize = p823c49a3Var.getParameters().getTreeDigestSize();
        int height = p823c49a3Var.getParameters().getHeight();
        int iM98ffcd8c = (int) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m98ffcd8c(encoded, 0, 4);
        if (!p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(height, iM98ffcd8c)) {
            throw new java.lang.IllegalArgumentException("index out of bounds");
        }
        byte[] bArrMf88bb2f2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, 4, treeDigestSize);
        int i = 4 + treeDigestSize;
        byte[] bArrMf88bb2f22 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i, treeDigestSize);
        int i2 = i + treeDigestSize;
        byte[] bArrMf88bb2f23 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i2, treeDigestSize);
        int i3 = i2 + treeDigestSize;
        byte[] bArrMf88bb2f24 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i3, treeDigestSize);
        int i4 = i3 + treeDigestSize;
        byte[] bArrMf88bb2f25 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i4, encoded.length - i4);
        try {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m95f98046(bArrMf88bb2f25, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a.class);
            return p1a8a272aVar.getMaxIndex() == (1 << height) - 1 ? new p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae(iM98ffcd8c, bArrMf88bb2f2, bArrMf88bb2f22, bArrMf88bb2f23, bArrMf88bb2f24, bArrMf88bb2f25) : new p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae(iM98ffcd8c, bArrMf88bb2f2, bArrMf88bb2f22, bArrMf88bb2f23, bArrMf88bb2f24, bArrMf88bb2f25, p1a8a272aVar.getMaxIndex());
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.io.IOException("cannot parse BDS: " + e.getMessage());
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 M258e1870(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) throws java.io.IOException {
        return m258e1870(pcfffbc4aVar, null);
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8 M258e1870(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) throws java.io.IOException {
        if ((18 + 5) % 5 > 0) {
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25 p3370fa25Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p3370fa25) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.m0378dc30(p3370fa25Var.getSecurityCategory()), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p3370fa25Var.getSecret()), ped34daf1Var);
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa pa01d96faVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pa01d96fa) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f70cfcb24, new p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.m78ecf02d(pa01d96faVar.getTreeDigest()))), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(pa01d96faVar.getKeyData()));
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd p08a45ebdVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p08a45ebd) pcfffbc4aVar;
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f054b782d);
            short[] secData = p08a45ebdVar.getSecData();
            byte[] bArr = new byte[secData.length * 2];
            for (int i = 0; i != secData.length; i++) {
                p5a445d71.p9f931cf3.p05c7e247.p4492081c.m8f9c2d53(secData[i], bArr, i * 2);
            }
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(p234a7530Var, new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr));
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d pb88b632dVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pb88b632d) pcfffbc4aVar;
            byte[] bArrBuild = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(1).bytes(pb88b632dVar).build();
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArrBuild), ped34daf1Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(1).bytes(pb88b632dVar.getPublicKey()).build());
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594 p511d6594Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p511d6594) pcfffbc4aVar;
            byte[] bArrBuild2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(p511d6594Var.getL()).bytes(p511d6594Var).build();
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArrBuild2), ped34daf1Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(p511d6594Var.getL()).bytes(p511d6594Var.getPublicKey().getLMSPublicKey()).build());
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f4aeb1bcf, new p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77(p823c49a3Var.getParameters().getHeight(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.mceec18fa(p823c49a3Var.getTreeDigest()))), m0e8d8070(p823c49a3Var), ped34daf1Var);
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f2ae6fdb4, new p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551(pbf81b3bdVar.getParameters().getHeight(), pbf81b3bdVar.getParameters().getLayers(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.mceec18fa(pbf81b3bdVar.getTreeDigest()))), mcc8f0c71(pbf81b3bdVar), ped34daf1Var);
        }
        if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f)) {
            throw new java.io.IOException("key parameters not recognized");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f p0d2c2c1fVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f) pcfffbc4aVar;
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p811299f8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf), new p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd(p0d2c2c1fVar.getN(), p0d2c2c1fVar.getK(), p0d2c2c1fVar.getField(), p0d2c2c1fVar.getGoppaPoly(), p0d2c2c1fVar.getP(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.m53fd55a2(p0d2c2c1fVar.getDigest())));
    }

    private static p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77 Mcc8f0c71(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar) throws java.io.IOException {
        if ((5 + 23) % 23 > 0) {
        }
        byte[] encoded = pbf81b3bdVar.getEncoded();
        int treeDigestSize = pbf81b3bdVar.getParameters().getTreeDigestSize();
        int height = pbf81b3bdVar.getParameters().getHeight();
        int i = (height + 7) / 8;
        long jM98ffcd8c = (int) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m98ffcd8c(encoded, 0, i);
        if (!p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me5f78db1(height, jM98ffcd8c)) {
            throw new java.lang.IllegalArgumentException("index out of bounds");
        }
        byte[] bArrMf88bb2f2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i, treeDigestSize);
        int i2 = i + treeDigestSize;
        byte[] bArrMf88bb2f22 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i2, treeDigestSize);
        int i3 = i2 + treeDigestSize;
        byte[] bArrMf88bb2f23 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i3, treeDigestSize);
        int i4 = i3 + treeDigestSize;
        byte[] bArrMf88bb2f24 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i4, treeDigestSize);
        int i5 = i4 + treeDigestSize;
        byte[] bArrMf88bb2f25 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mf88bb2f2(encoded, i5, encoded.length - i5);
        try {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90) p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m95f98046(bArrMf88bb2f25, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90.class);
            return p8fc89a90Var.getMaxIndex() == (1 << height) - 1 ? new p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77(jM98ffcd8c, bArrMf88bb2f2, bArrMf88bb2f22, bArrMf88bb2f23, bArrMf88bb2f24, bArrMf88bb2f25) : new p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77(jM98ffcd8c, bArrMf88bb2f2, bArrMf88bb2f22, bArrMf88bb2f23, bArrMf88bb2f24, bArrMf88bb2f25, p8fc89a90Var.getMaxIndex());
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.io.IOException("cannot parse BDSStateDictionary: " + e.getMessage());
        }
    }
}

