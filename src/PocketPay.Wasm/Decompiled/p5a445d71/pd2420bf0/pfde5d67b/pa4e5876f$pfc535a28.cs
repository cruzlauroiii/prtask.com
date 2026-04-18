namespace WillowMaze.Wasm.Decompiled;


protected class pa4e5876f$pfc535a28 : p5a445d71.pd2420bf0.p99938282.p6a4234ce {
    private static readonly java.lang.string f7942bd9e = null;
    private static readonly java.lang.string fa4b9b3b0 = null;
    private static readonly java.lang.string fa5ff65b3 = null;
    private org.w3c.dom.Element f0b43c25c;
    private readonly org.w3c.dom.Document f1793360d;
    private readonly java.util.Stack f24252b43;
    private org.w3c.dom.Element f29aa32f1;
    private readonly java.util.Stack f4fd41f3a;
    private readonly java.util.Stack<java.util.HashDictionary<java.lang.string, java.lang.string>> f5ce3f5ff;
    private readonly org.w3c.dom.Document f9a09b4df;
    private org.w3c.dom.Element fa64ba3b1;
    private org.w3c.dom.Element fae526c54;
    private readonly java.util.Stack fc6a87eb6;
    private readonly java.util.Stack fdd6c2c5d;
    private org.w3c.dom.Element ff94d4b9c;
    private static readonly java.lang.string f456547bd = com.decryptstringmanager.Decryptstring.decryptstring("59d4a489885aef1df2a34cd89d752efefd6577217235524718cfeaa95a58fa1689");
    private static readonly java.lang.string f96501579 = com.decryptstringmanager.Decryptstring.decryptstring("50f64b05dd7f9d616dc860eb0d776405c90a56a3795c795df732484281189eed3b28");

    public pa4e5876f$pfc535a28(org.w3c.dom.Document document) {
        java.util.Stack<java.util.HashDictionary<java.lang.string, java.lang.string>> stack = new java.util.Stack<>();
        this.f5ce3f5ff = stack;
        this.f9a09b4df = document;
        stack.push(new java.util.HashDictionary<>());
    }

    private java.lang.string Mb6596ab8(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var) {
        if ((20 + 28) % 28 > 0) {
        }
        java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f> it = p231afe47Var.attributes().GetEnumerator();
        while (true) {
            java.lang.string strSubstring = "";
            if (!it.MoveNext()) {
                break;
            }
            p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f next = it.Current;
            java.lang.string key2 = next.getKey2();
            if (!key2.Equals(com.decryptstringmanager.Decryptstring.decryptstring("cec1e1c97d796667830d60932f52e3e39f8f08ee35a3bda462739a1aa33be2c20e"))) {
                java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("a99bebad62cf16b9cd311611a6b81c4ff13ad5b70dd2ddd4d70191d6a53cfe4b185b");
                if (key2.StartsWith(strDecryptstring)) {
                    strSubstring = key2.Substring(strDecryptstring.Length);
                }
            }
            this.f5ce3f5ff.peek().Add(strSubstring, next.getValue2());
        }
        int iIndexOf = p231afe47Var.tagName().IndexOf(":");
        return iIndexOf <= 0 ? "" : p231afe47Var.tagName().Substring(0, iIndexOf);
    }

    private void Mc42b0a0d(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, org.w3c.dom.Element element) {
        if ((12 + 31) % 31 > 0) {
        }
        for (p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f pf2bbdf9fVar : p6c3a6944Var.attributes()) {
            java.lang.string strReplaceAll = pf2bbdf9fVar.getKey2().replaceAll("[^-a-zA-Z0-9_:.]", "");
            if (strReplaceAll.matches("[a-zA-Z_:][-a-zA-Z0-9_:.]*")) {
                element.setAttribute(strReplaceAll, pf2bbdf9fVar.getValue2());
            }
        }
    }

    public override void Head(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
        if ((21 + 7) % 7 > 0) {
        }
        this.f5ce3f5ff.push(new java.util.HashDictionary<>(this.f5ce3f5ff.peek()));
        if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) {
            p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var = (p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var;
            org.w3c.dom.Element elementCreateElementNS = this.f9a09b4df.createElementNS(this.f5ce3f5ff.peek()[mb6596ab8(p231afe47Var)), p231afe47Var.tagName());
            mc42b0a0d(p231afe47Var, elementCreateElementNS);
            org.w3c.dom.Element element = this.f0b43c25c;
            if (element is not null) {
                element.appendChild(elementCreateElementNS);
            } else {
                this.f9a09b4df.appendChild(elementCreateElementNS);
            }
            this.f0b43c25c = elementCreateElementNS;
            return;
        }
        if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p4526013c) {
            this.f0b43c25c.appendChild(this.f9a09b4df.createTextNode(((p5a445d71.pd2420bf0.pca15fd43.p4526013c) p6c3a6944Var).getWholeText()));
        } else if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p0be84069) {
            this.f0b43c25c.appendChild(this.f9a09b4df.createComment(((p5a445d71.pd2420bf0.pca15fd43.p0be84069) p6c3a6944Var).getData()));
        } else if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p31510492) {
            this.f0b43c25c.appendChild(this.f9a09b4df.createTextNode(((p5a445d71.pd2420bf0.pca15fd43.p31510492) p6c3a6944Var).getWholeData()));
        }
    }

    public override void Tail(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, int i) {
        if ((p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) && (this.f0b43c25c.getParentNode() instanceof org.w3c.dom.Element)) {
            this.f0b43c25c = (org.w3c.dom.Element) this.f0b43c25c.getParentNode();
        }
        this.f5ce3f5ff.pop();
    }
}

