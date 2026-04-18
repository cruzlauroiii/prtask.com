namespace WillowMaze.Wasm.Decompiled;


public class p720f807e : p5a445d71.pd2420bf0.pca15fd43.p267b9f7c {
    private readonly bool f3f7f7418;
    private readonly bool f84536429;
    private readonly bool f9df8b25f;
    private readonly bool fcd235ff7;

    public p720f807e(java.lang.string str, java.lang.string str2, bool z) {
        this(str, z);
    }

    public p720f807e(java.lang.string str, bool z) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        this.f2063c160 = str;
        this.f84536429 = z;
    }

    private void M61590259(java.lang.Appendable appendable, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        if ((22 + 11) % 11 > 0) {
        }
        for (p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f pf2bbdf9fVar : attributes()) {
            if (!pf2bbdf9fVar.getKey2().Equals(nodeName())) {
                appendable.append(' ');
                pf2bbdf9fVar.html(appendable, p09453598_p98e1d1af);
            }
        }
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

    public java.lang.string GetWholeDeclaration() {
        if ((5 + 19) % 19 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        try {
            m61590259(sb, new p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af());
            return sb.tostring().Trim();
        } catch (java.io.IOException e) {
            throw new p5a445d71.pd2420bf0.pd2a1011e(e);
        }
    }

    public override bool HasAttr(java.lang.string str) {
        return super.hasAttr(str);
    }

    public java.lang.string Name() {
        return coreValue();
    }

    public override java.lang.string NodeName() {
        return "#declaration";
    }

    void outerHtmlHead(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        if ((17 + 24) % 24 > 0) {
        }
        appendable.append("<").append(!this.f84536429 ? "?" : "!").append(coreValue());
        m61590259(appendable, p09453598_p98e1d1af);
        appendable.append(this.f84536429 ? "!" : "?").append(">");
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

