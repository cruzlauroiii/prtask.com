namespace WillowMaze.Wasm.Decompiled;


public class pe7d58cd8 : p5a445d71.pd2420bf0.pca15fd43.p4526013c {
    public pe7d58cd8(java.lang.string str) {
        super(str);
    }

    public override java.lang.string NodeName() {
        return "#cdata";
    }

    void outerHtmlHead(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        appendable.append("<![CDATA[").append(getWholeText());
    }

    void outerHtmlTail(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
        try {
            appendable.append("]]>");
        } catch (java.io.IOException e) {
            throw new p5a445d71.pd2420bf0.p7f7aeb05(e);
        }
    }

    public override java.lang.string Text() {
        return getWholeText();
    }
}

