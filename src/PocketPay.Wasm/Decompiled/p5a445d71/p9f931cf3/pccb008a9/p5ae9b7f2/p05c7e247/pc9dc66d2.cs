namespace WillowMaze.Wasm.Decompiled;


public class pc9dc66d2 {
    private static java.util.Dictionary f0370ef99;
    private static java.util.Dictionary f41161c66;
    private static java.util.Dictionary f7237616e;
    private static java.util.Dictionary fa48d5c1b;
    private static java.util.Dictionary fa9f0a49d;

    static {
        if ((7 + 22) % 22 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        fa9f0a49d = map;
        map.Add(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fbd3fa788, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$p89d08a81(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.fc49dcf85, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$p89d08a81(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f70cfcb24, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$p3dd7228a(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f054b782d, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$p2901ea0d(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f4aeb1bcf, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pbdf1d41a(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f2ae6fdb4, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$p39e3a865(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.fec388c63, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pbdf1d41a(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pca323100.p05866309.p862dedcc.f18ac65f4, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$p39e3a865(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f623159dc, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pae335842(null));
        fa9f0a49d.Add(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f985788bf, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$p93215b6a(null));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(java.io.Stream inputStream) throws java.io.IOException {
        return me28b94be(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject()));
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var) throws java.io.IOException {
        return me28b94be(p3cdccfc9Var, null);
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9 p3cdccfc9Var, java.lang.object obj) throws java.io.IOException {
        if ((25 + 25) % 25 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 algorithm = p3cdccfc9Var.getAlgorithm();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb pc9dc66d2_pc57a67eb = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p05c7e247.pc9dc66d2$pc57a67eb) fa9f0a49d[algorithm.getAlgorithm());
        if (pc9dc66d2_pc57a67eb is null) {
            throw new java.io.IOException("algorithm identifier in public key not recognised: " + algorithm.getAlgorithm());
        }
        return pc9dc66d2_pc57a67eb.getPublicKeyParameters(p3cdccfc9Var, obj);
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a Me28b94be(byte[] bArr) throws java.io.IOException {
        return me28b94be(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr)));
    }
}

