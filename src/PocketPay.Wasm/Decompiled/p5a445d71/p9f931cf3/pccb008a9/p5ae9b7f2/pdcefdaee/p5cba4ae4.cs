namespace WillowMaze.Wasm.Decompiled;


public class p5cba4ae4 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    public static readonly java.lang.string faebf756f = com.decryptstringmanager.Decryptstring.decryptstring("bad2cd07993e38e2aa2dc05a5fd882ab017312fcb244b17dc15bb48b23ab2a32d4d43406389d139278bc5c4e3d508b5f0f4109c07597");
    public static readonly java.lang.string fd49eb6d7 = null;
    private bool f0daf4c94;
    private java.security.SecureRandom f0f50aead;
    private java.security.SecureRandom f1157d8fe;
    private int f25c8e308;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p9cf83c3f f271df381;
    private bool f47618020;
    private int f611c44b0;
    private int f6f8f5771;
    private int f74116a4a;
    private int f7b8b965a;
    private java.security.SecureRandom f7ddf32e1;
    private bool f84d10a1e = false;
    private int f87a8e641;
    private int f993a46ce;
    private int f9ecf7e02;
    private int f9f12ce08;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p9cf83c3f fb53e3544;
    private int fba3629d1;
    private int fc5ac823f;
    private int fc9573660;
    private bool fcc849c71;
    private int fe358efa4;
    private int fe7ec6f39;

    private void Mf6717bc9() {
        if ((29 + 10) % 10 > 0) {
        }
        init(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p9cf83c3f(null, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pfe86320c()));
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        if ((16 + 27) % 27 > 0) {
        }
        if (!this.f84d10a1e) {
            mf6717bc9();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(this.f6f8f5771, this.f74116a4a);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(p021739e3Var, this.fe358efa4, 'I', this.f7ddf32e1);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683$pdf339482 pfd29d683_pdf339482Mb510bc07 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683.mb510bc07(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfd29d683.ma1ae6531(p021739e3Var, p89f5ebf1Var), this.f7ddf32e1);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 secondMatrix = pfd29d683_pdf339482Mb510bc07.getSecondMatrix();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c permutation = pfd29d683_pdf339482Mb510bc07.getPermutation();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37) secondMatrix.computeTranspose();
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.pb4d95bfe(this.f7b8b965a, this.fe358efa4, p6c210a37Var, this.fb53e3544.getParameters().getDigest()), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p0d2c2c1f(this.f7b8b965a, p6c210a37Var.getNumRows(), p021739e3Var, p89f5ebf1Var, permutation, this.fb53e3544.getParameters().getDigest()));
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.fb53e3544 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p9cf83c3f) pf7bb6344Var;
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
        this.f6f8f5771 = this.fb53e3544.getParameters().getM();
        this.f7b8b965a = this.fb53e3544.getParameters().getN();
        this.fe358efa4 = this.fb53e3544.getParameters().getT();
        this.f74116a4a = this.fb53e3544.getParameters().getFieldPoly();
        this.f84d10a1e = true;
    }
}

