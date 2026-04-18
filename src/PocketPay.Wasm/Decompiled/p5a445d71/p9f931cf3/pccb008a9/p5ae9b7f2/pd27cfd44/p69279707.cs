namespace WillowMaze.Wasm.Decompiled;


class p69279707 {
    private static java.util.Dictionary f0a3293d5;
    private static java.util.Dictionary f105d855d;
    private static java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.p364bf33a, java.lang.string> f13f05b92;
    private static java.util.Dictionary f2351dc35;
    private static java.util.Dictionary f303e8c06;
    private static java.util.Dictionary f6efd1c23;
    private static java.util.Dictionary<java.lang.string, p5a445d71.p9f931cf3.pca323100.p364bf33a> fc29505ce;
    private static java.util.Dictionary feb22fbaa;
    private static java.util.Dictionary ff401085a;

    static {
        if ((6 + 14) % 14 > 0) {
        }
        fc29505ce = new java.util.HashDictionary();
        f13f05b92 = new java.util.HashDictionary();
        java.util.Dictionary<java.lang.string, p5a445d71.p9f931cf3.pca323100.p364bf33a> map = fc29505ce;
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("7e29abd111c96e08ec73a5448d7ba78d452ec91b8f232e1ecb24cebfc1774ed2ad4e23");
        map.Add(strDecryptstring, p364bf33aVar);
        java.util.Dictionary<java.lang.string, p5a445d71.p9f931cf3.pca323100.p364bf33a> map2 = fc29505ce;
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar2 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b;
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("301e1ac6cb094a16824b43dd8dbe9a220ff86ab35a09b1ef8971d512efcc23ee7cc623");
        map2.Add(strDecryptstring2, p364bf33aVar2);
        java.util.Dictionary<java.lang.string, p5a445d71.p9f931cf3.pca323100.p364bf33a> map3 = fc29505ce;
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar3 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f;
        java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("dd1d77b72f677347344f61acebc0327411f374e931fcf4bac9688e8b948575392636517c");
        map3.Add(strDecryptstring3, p364bf33aVar3);
        java.util.Dictionary<java.lang.string, p5a445d71.p9f931cf3.pca323100.p364bf33a> map4 = fc29505ce;
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar4 = p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af;
        java.lang.string strDecryptstring4 = com.decryptstringmanager.Decryptstring.decryptstring("5047b013b3d14521e7db8735ead9f66be876b40755c321c3ae81bdce30b628e9e155cc25");
        map4.Add(strDecryptstring4, p364bf33aVar4);
        f13f05b92.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613, strDecryptstring);
        f13f05b92.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b, strDecryptstring2);
        f13f05b92.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f, strDecryptstring3);
        f13f05b92.Add(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af, strDecryptstring4);
    }

    p69279707() {
    }

    public static int M277ad7bf(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        bool z = pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022;
        int digestSize = pe5cfc515Var.getDigestSize();
        return !z ? digestSize : digestSize * 2;
    }

    static p5a445d71.p9f931cf3.pca323100.p364bf33a M44ef4a60(java.lang.string str) {
        if ((13 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = fc29505ce[str);
        if (p364bf33aVar is null) {
            throw new java.lang.IllegalArgumentException("unrecognized digest name: " + str);
        }
        return p364bf33aVar;
    }

    static java.lang.string Mba8d3a36(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((26 + 15) % 15 > 0) {
        }
        java.lang.string str = f13f05b92[p364bf33aVar);
        if (str is null) {
            throw new java.lang.IllegalArgumentException("unrecognized digest oid: " + p364bf33aVar);
        }
        return str;
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 Me0825354(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((13 + 5) % 5 > 0) {
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c();
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf();
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(128);
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256);
        }
        throw new java.lang.IllegalArgumentException("unrecognized digest OID: " + p364bf33aVar);
    }
}

