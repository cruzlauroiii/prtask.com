namespace WillowMaze.Wasm.Decompiled;


public class p9b57ddd6 {
    private p9b57ddd6() {
    }

    public static void M0484893d(java.security.AlgorithmParameters algorithmParameters, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        if ((14 + 27) % 27 > 0) {
        }
        try {
            algorithmParameters.init(p0fd1bdf1Var.toASN1Primitive().getEncoded(), "ASN.1");
        } catch (java.lang.Exception unused) {
            algorithmParameters.init(p0fd1bdf1Var.toASN1Primitive().getEncoded());
        }
    }

    public static java.lang.string M15b600f8(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return !p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1bc29b36.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f144d5874.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f40964ed3.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.ff8ce6695.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f742a86b1.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.fbba06797.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? !p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f22a47664.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVar) ? p364bf33aVar.getId() : "GOST3411" : "RIPEMD256" : "RIPEMD160" : "RIPEMD128" : com.decryptstringmanager.Decryptstring.decryptstring("e4712feacd9ec551a4f1d1537f1311369d634be1f0e28940e32b1db61af8cd637b7c") : "SHA384" : com.decryptstringmanager.Decryptstring.decryptstring("5da3bccc3531dea542d3e9ce57c17055cda3a6f7367dcb6efbc9bfc2fbf0ff3fc272") : "SHA224" : "SHA1" : "MD5";
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Ma2e2da7c(java.security.AlgorithmParameters algorithmParameters) throws java.io.IOException {
        try {
            return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(algorithmParameters.getEncoded("ASN.1"));
        } catch (java.lang.Exception unused) {
            return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(algorithmParameters.getEncoded());
        }
    }
}

