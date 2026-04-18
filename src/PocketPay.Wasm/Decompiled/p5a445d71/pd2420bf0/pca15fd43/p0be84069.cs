namespace WillowMaze.Wasm.Decompiled;


public class p0be84069 : p5a445d71.pd2420bf0.pca15fd43.p267b9f7c {
    private static readonly java.lang.string f19698052 = com.decryptstringmanager.Decryptstring.decryptstring("76a5af478c0b06468cb40b9590bf7465ab54e7806d08b450b53087be22192bc15464c7");
    private static readonly java.lang.string f27d646b9 = null;

    public p0be84069(java.lang.string str) {
        this.f2063c160 = str;
    }

    public p0be84069(java.lang.string str, java.lang.string str2) {
        this(str);
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

    public java.lang.string GetData() {
        return coreValue();
    }

    public override bool HasAttr(java.lang.string str) {
        return super.hasAttr(str);
    }

    public override java.lang.string NodeName() {
        return "#comment";
    }

    void outerHtmlHead(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        if (p09453598_p98e1d1af.prettyPrint()) {
            indent(appendable, i, p09453598_p98e1d1af);
        }
        appendable.append("<!--").append(getData()).append("-->");
    }

    void outerHtmlTail(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 RemoveAttr(java.lang.string str) {
        return super.removeAttr(str);
    }

    public override java.lang.string Tostring() {
        return outerHtml();
    }
}

