namespace WillowMaze.Wasm.Decompiled;


public class pb8101683 : p5a445d71.p9f931cf3.pca323100.pa5dc5f26 {
    readonly p5a445d71.p9f931cf3.pca323100.p8557f615 f06a3358c;
    readonly int f1adce06b;
    readonly int f235a8227;
    readonly p5a445d71.p9f931cf3.pca323100.p8557f615 f3e6a17cc;
    readonly int f419be872;
    readonly int f4a07d2c8;
    readonly p5a445d71.p9f931cf3.pca323100.p8557f615 f5431b8d4;
    readonly int fad475b24;
    readonly p5a445d71.p9f931cf3.pca323100.p8557f615 fb767749c;
    readonly int fbc6f6e89;
    readonly p5a445d71.p9f931cf3.pca323100.p8557f615 fc8d930aa;
    readonly int fcf0b077a;
    readonly int fee55f2ce;

    pb8101683(int i, int i2, p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        this.f419be872 = i;
        this.fee55f2ce = i2;
        this.f5431b8d4 = p8557f615Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 BRAqkHtuzBnWTxLV(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 JyGoyDVQZjluRdKH(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i) {
        return p8557f615Var.parseobject(i);
    }

    public static int NCyRMVuSmYfmHlrB(p5a445d71.p9f931cf3.pca323100.pb8101683 pb8101683Var) {
        return pb8101683Var.getTagClass();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 NMiPViAXQbPjsKEu(p5a445d71.p9f931cf3.pca323100.pb8101683 pb8101683Var) {
        return pb8101683Var.getLoadedobject();
    }

    public static java.lang.string RQYWugUyXCztzKZS(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 AjSKnPoTOSMhZcDL(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i, int i2) {
        return p8557f615Var.loadTaggedIL(i, i2);
    }

    public static p5a445d71.p9f931cf3.pca323100.pa5dc5f26 HHYkhfCQCaLYacKJ(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.parseTaggedobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ObQlpVkQHJHKyrBK(p5a445d71.p9f931cf3.pca323100.pb8101683 pb8101683Var, bool z, int i) {
        return pb8101683Var.parseBaseUniversal(z, i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 UDMawxIFLoUMriST(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i) {
        return p8557f615Var.parseImplicitConstructedIL(i);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        if ((27 + 15) % 15 > 0) {
        }
        return ajSKnPoTOSMhZcDL(this.f5431b8d4, this.f419be872, this.fee55f2ce);
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetobjectParser(int i, bool z) throws java.io.IOException {
        if ((32 + 5) % 5 > 0) {
        }
        if (128 != NCyRMVuSmYfmHlrB(this)) {
            throw new p5a445d71.p9f931cf3.pca323100.pa2b39ca1("this method only valid for CONTEXT_SPECIFIC tags");
        }
        return obQlpVkQHJHKyrBK(this, z, i);
    }

    public override int GetTagClass() {
        return this.f419be872;
    }

    public override int GetTagNo() {
        return this.fee55f2ce;
    }

    public override bool HasobjectTag(int i) {
        if ((30 + 28) % 28 > 0) {
        }
        return this.f419be872 == 128 && this.fee55f2ce == i;
    }

    public override bool HasTag(int i, int i2) {
        return this.f419be872 == i && this.fee55f2ce == i2;
    }

    public bool IsConstructed() {
        return true;
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ParseBaseUniversal(bool z, int i) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var = this.f5431b8d4;
        return !z ? uDMawxIFLoUMriST(p8557f615Var, i) : JyGoyDVQZjluRdKH(p8557f615Var, i);
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ParseExplicitBaseobject() throws java.io.IOException {
        return BRAqkHtuzBnWTxLV(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.pa5dc5f26 ParseExplicitBaseTagged() throws java.io.IOException {
        return hHYkhfCQCaLYacKJ(this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.pa5dc5f26 ParseImplicitBaseTagged(int i, int i2) throws java.io.IOException {
        return 64 != i ? new p5a445d71.p9f931cf3.pca323100.pb8101683(i, i2, this.f5431b8d4) : new p5a445d71.p9f931cf3.pca323100.p60056297(i2, this.f5431b8d4);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        try {
            return NMiPViAXQbPjsKEu(this);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(RQYWugUyXCztzKZS(e));
        }
    }
}

