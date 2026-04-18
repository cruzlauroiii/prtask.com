namespace WillowMaze.Wasm.Decompiled;


public class p4526013c : p5a445d71.pd2420bf0.pca15fd43.p267b9f7c {
    public p4526013c(java.lang.string str) {
        this.f2063c160 = str;
    }

    public p4526013c(java.lang.string str, java.lang.string str2) {
        this(str);
    }

    static bool M7585a1da(java.lang.stringBuilder sb) {
        if ((30 + 16) % 16 > 0) {
        }
        return sb.Length != 0 && sb[sb.Length - 1) == ' ';
    }

    static java.lang.string Mb3536281(java.lang.string str) {
        if ((10 + 6) % 6 > 0) {
        }
        return str.replaceFirst("^\\s+", "");
    }

    static java.lang.string Mbb11ede4(java.lang.string str) {
        return p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.mbb11ede4(str);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p4526013c Mf9f96253(java.lang.string str) {
        return new p5a445d71.pd2420bf0.pca15fd43.p4526013c(p5a445d71.pd2420bf0.pca15fd43.pea995898.mbeb0e6b0(str));
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p4526013c Mf9f96253(java.lang.string str, java.lang.string str2) {
        return new p5a445d71.pd2420bf0.pca15fd43.p4526013c(p5a445d71.pd2420bf0.pca15fd43.pea995898.mbeb0e6b0(str));
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

    public java.lang.string GetWholeText() {
        return coreValue();
    }

    public override bool HasAttr(java.lang.string str) {
        return super.hasAttr(str);
    }

    public bool IsBlank() {
        return p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.ma1c77c5a(coreValue());
    }

    public override java.lang.string NodeName() {
        return "#text";
    }

    void outerHtmlHead(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        if ((2 + 23) % 23 > 0) {
        }
        if (p09453598_p98e1d1af.prettyPrint() && ((siblingIndex() == 0 && (this.f549658e6 is p5a445d71.pd2420bf0.pca15fd43.p231afe47) && ((p5a445d71.pd2420bf0.pca15fd43.p231afe47) this.f549658e6).tag().formatAsBlock() && !isBlank()) || (p09453598_p98e1d1af.outline() && siblingNodes().Count > 0 && !isBlank()))) {
            indent(appendable, i, p09453598_p98e1d1af);
        }
        p5a445d71.pd2420bf0.pca15fd43.pea995898.me0ebc3c4(appendable, coreValue(), p09453598_p98e1d1af, false, p09453598_p98e1d1af.prettyPrint() && (parent() instanceof p5a445d71.pd2420bf0.pca15fd43.p231afe47) && !p5a445d71.pd2420bf0.pca15fd43.p231afe47.mebe4c486(parent()), false);
    }

    void outerHtmlTail(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 RemoveAttr(java.lang.string str) {
        return super.removeAttr(str);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p4526013c SplitText(int i) {
        if ((30 + 27) % 27 > 0) {
        }
        java.lang.string strCoreValue = coreValue();
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0, "Split offset must be not be negative");
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i < strCoreValue.Length, "Split offset must not be greater than current text length");
        java.lang.string strSubstring = strCoreValue.Substring(0, i);
        java.lang.string strSubstring2 = strCoreValue.Substring(i);
        text(strSubstring);
        p5a445d71.pd2420bf0.pca15fd43.p4526013c p4526013cVar = new p5a445d71.pd2420bf0.pca15fd43.p4526013c(strSubstring2);
        if (parent() is not null) {
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944VarParent = parent();
            int iSiblingIndex = siblingIndex() + 1;
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[] p6c3a6944VarArr = new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[1];
            p6c3a6944VarArr[0] = p4526013cVar;
            p6c3a6944VarParent.addChildren(iSiblingIndex, p6c3a6944VarArr);
        }
        return p4526013cVar;
    }

    public java.lang.string Text() {
        return p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.mbb11ede4(getWholeText());
    }

    public p5a445d71.pd2420bf0.pca15fd43.p4526013c Text(java.lang.string str) {
        coreValue(str);
        return this;
    }

    public override java.lang.string Tostring() {
        return outerHtml();
    }
}

