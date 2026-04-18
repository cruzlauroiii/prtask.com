namespace WillowMaze.Wasm.Decompiled;


readonly class p64e72793 {
    private p64e72793() {
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52[] M1a332d23(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f p0d2c2c1fVar, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        if ((8 + 30) % 30 > 0) {
        }
        int k = p0d2c2c1fVar.getK();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c p = p0d2c2c1fVar.getP();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 field = p0d2c2c1fVar.getField();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 goppaPoly = p0d2c2c1fVar.getGoppaPoly();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 h = p0d2c2c1fVar.getH();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1[] qInv = p0d2c2c1fVar.getQInv();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var2 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) pf910dc52Var.multiply(p.computeInverse());
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52VarM19d66f68 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683.m19d66f68((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) h.rightMultiply(pf910dc52Var2), field, goppaPoly, qInv);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var3 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) pf910dc52Var2.Add(pf910dc52VarM19d66f68)).multiply(p);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var4 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) pf910dc52VarM19d66f68.multiply(p);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52VarExtractRightVector = pf910dc52Var3.extractRightVector(k);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52[] pf910dc52VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52[2];
        pf910dc52VarArr[0] = pf910dc52VarExtractRightVector;
        pf910dc52VarArr[1] = pf910dc52Var4;
        return pf910dc52VarArr;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 M6be4a434(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe pb4d95bfeVar, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var2) {
        return (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52) pb4d95bfeVar.getG().leftMultiplyLeftCompactForm(pf910dc52Var).Add(pf910dc52Var2);
    }
}

