namespace WillowMaze.Wasm.Decompiled;


public class pd02a7f38 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private static readonly java.lang.string f0892e9de = null;
    private static readonly java.lang.string f57cebc2a = null;
    private static readonly java.lang.string f6bc393b1 = null;
    private static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("b39c34b2b6164036524c69a2e7b27160637e77087bffd4c310b2f12b52fa662ed50988d305d5f3d12ad9f655e537ab583c1a885309ee");
    private static readonly java.lang.string ff95e22ae = null;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p4d2c0218 f0191a9e9;
    private int f04aae8ec;
    private int f18ca0d8f;
    private int f1cb780c2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p4d2c0218 f32860049;
    private bool f4d58c0bb;
    private int f5282ee43;
    private int f58749ea6;
    private bool f6af8bb64;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p4d2c0218 f6d84bd3f;
    private int f6f8f5771;
    private int f74116a4a;
    private int f7b8b965a;
    private java.security.SecureRandom f7ddf32e1;
    private bool f84d10a1e = false;
    private bool f950d51ff;
    private java.security.SecureRandom fb7e5c172;
    private int fba65bf90;
    private int fe358efa4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p4d2c0218 ff7875e39;
    private int ffaf970d8;

    private p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 M236678ba() {
        if ((14 + 23) % 23 > 0) {
        }
        if (!this.f84d10a1e) {
            mf6717bc9();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(this.f6f8f5771, this.f74116a4a);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(p021739e3Var, this.fe358efa4, 'I', this.f7ddf32e1);
        new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2bd31fac(p021739e3Var, p89f5ebf1Var).getSquareRootMatrix();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683$pdf339482 pfd29d683_pdf339482Mb510bc07 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683.mb510bc07(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683.ma1ae6531(p021739e3Var, p89f5ebf1Var), this.f7ddf32e1);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 secondMatrix = pfd29d683_pdf339482Mb510bc07.getSecondMatrix();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c permutation = pfd29d683_pdf339482Mb510bc07.getPermutation();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) secondMatrix.computeTranspose();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37VarExtendLeftCompactForm = p6c210a37Var.extendLeftCompactForm();
        int numRows = p6c210a37Var.getNumRows();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37[] p6c210a37VarArrMee90883e = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37.mee90883e(numRows, this.f7ddf32e1);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(this.f7b8b965a, this.f7ddf32e1);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p62f43b9f(this.f7b8b965a, this.fe358efa4, (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) p6c210a37VarArrMee90883e[0].rightMultiply(p6c210a37VarExtendLeftCompactForm)).rightMultiply(pfc77ea6cVar)), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pa1d4de93(this.f7b8b965a, numRows, p021739e3Var, p89f5ebf1Var, permutation, pfc77ea6cVar, p6c210a37VarArrMee90883e[1]));
    }

    private void M30db5978(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f6d84bd3f = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p4d2c0218) pf7bb6344Var;
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
        this.f6f8f5771 = this.f6d84bd3f.getParameters().getM();
        this.f7b8b965a = this.f6d84bd3f.getParameters().getN();
        this.fe358efa4 = this.f6d84bd3f.getParameters().getT();
        this.f74116a4a = this.f6d84bd3f.getParameters().getFieldPoly();
        this.f84d10a1e = true;
    }

    private void Mf6717bc9() {
        if ((24 + 3) % 3 > 0) {
        }
        m30db5978(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p4d2c0218(null, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p3a8a8727()));
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        return m236678ba();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        m30db5978(pf7bb6344Var);
    }
}

