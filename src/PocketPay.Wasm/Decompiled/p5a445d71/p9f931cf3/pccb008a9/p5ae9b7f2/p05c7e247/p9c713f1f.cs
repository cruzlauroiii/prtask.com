namespace WillowMaze.Wasm.Decompiled;


public class p9c713f1f {
    private p9c713f1f() {
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 M07deeeb8(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) throws java.io.IOException {
        if ((9 + 13) % 13 > 0) {
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30 p0f8e8a30Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.p0f8e8a30) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.m0378dc30(p0f8e8a30Var.getSecurityCategory()), p0f8e8a30Var.getPublicData());
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a p07661f3aVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p07661f3a) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f70cfcb24, new p5a445d71.p9f931cf3.pccb008a9.pca323100.p1ed4edc3(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.m78ecf02d(p07661f3aVar.getTreeDigest()))), p07661f3aVar.getKeyData());
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f054b782d), ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) pcfffbc4aVar).getPubData());
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(1).bytes((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6) pcfffbc4aVar).build()));
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b pe32c2c6bVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe32c2c6b) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().u32str(pe32c2c6bVar.getL()).bytes(pe32c2c6bVar.getLMSPublicKey()).build()));
        }
        if (pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e) pcfffbc4aVar;
            byte[] publicSeed = pe1225d2eVar.getPublicSeed();
            byte[] root = pe1225d2eVar.getRoot();
            byte[] encoded = pe1225d2eVar.getEncoded();
            return encoded.length <= publicSeed.length + root.length ? new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f4aeb1bcf, new p5a445d71.p9f931cf3.pccb008a9.pca323100.p2bd3ac77(pe1225d2eVar.getParameters().getHeight(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.mceec18fa(pe1225d2eVar.getTreeDigest()))), new p5a445d71.p9f931cf3.pccb008a9.pca323100.p81c0a6c0(publicSeed, root)) : new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.fec388c63), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(encoded));
        }
        if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148)) {
            if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe)) {
                throw new java.io.IOException("key parameters not recognized");
            }
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe pb4d95bfeVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe) pcfffbc4aVar;
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf), new p5a445d71.p9f931cf3.pccb008a9.pca323100.p751e4728(pb4d95bfeVar.getN(), pb4d95bfeVar.getT(), pb4d95bfeVar.getG(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.m53fd55a2(pb4d95bfeVar.getDigest())));
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 p51ac8148Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148) pcfffbc4aVar;
        byte[] publicSeed2 = p51ac8148Var.getPublicSeed();
        byte[] root2 = p51ac8148Var.getRoot();
        byte[] encoded2 = p51ac8148Var.getEncoded();
        return encoded2.length <= publicSeed2.length + root2.length ? new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f2ae6fdb4, new p5a445d71.p9f931cf3.pccb008a9.pca323100.pacfb2551(p51ac8148Var.getParameters().getHeight(), p51ac8148Var.getParameters().getLayers(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pa470a233.mceec18fa(p51ac8148Var.getTreeDigest()))), new p5a445d71.p9f931cf3.pccb008a9.pca323100.p4c41d770(p51ac8148Var.getPublicSeed(), p51ac8148Var.getRoot())) : new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.f18ac65f4), new p5a445d71.p9f931cf3.pca323100.p6f0e511c(encoded2));
    }
}

