namespace WillowMaze.Wasm.Decompiled;


public class p31510492 : p5a445d71.pd2420bf0.pca15fd43.p267b9f7c {
    public p31510492(java.lang.string str) {
        this.f2063c160 = str;
    }

    public p31510492(java.lang.string str, java.lang.string str2) {
        this(str);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p31510492 Mf9f96253(java.lang.string str, java.lang.string str2) {
        return new p5a445d71.pd2420bf0.pca15fd43.p31510492(p5a445d71.pd2420bf0.pca15fd43.pea995898.mbeb0e6b0(str));
    }

    public override java.lang.string AbsUrl(java.lang.string str) {
        return super.absUrl(str);
    }

    public override java.lang.string Attr(java.lang.string str) {
        return super.attr(str);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Attr(java.lang.string str, java.lang.string str2) {
        return super.attr(str, str2);
    }

    public override java.lang.string BaseUri() {
        return super.baseUri();
    }

    public override int ChildNodeSize() {
        return super.childNodeSize();
    }

    public java.lang.string GetWholeData() {
        return coreValue();
    }

    public override bool HasAttr(java.lang.string str) {
        return super.hasAttr(str);
    }

    public override java.lang.string NodeName() {
        return "#data";
    }

    void outerHtmlHead(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        appendable.append(getWholeData());
    }

    void outerHtmlTail(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 RemoveAttr(java.lang.string str) {
        return super.removeAttr(str);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p31510492 SetWholeData(java.lang.string str) {
        coreValue(str);
        return this;
    }

    public override java.lang.string Tostring() {
        return outerHtml();
    }
}

