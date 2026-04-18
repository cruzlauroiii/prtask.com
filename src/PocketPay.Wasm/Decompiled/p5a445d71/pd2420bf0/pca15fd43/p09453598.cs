namespace WillowMaze.Wasm.Decompiled;


public class p09453598 : p5a445d71.pd2420bf0.pca15fd43.p231afe47 {
    private java.lang.string f1a31bb31;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af f368335df;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$pacbbb283 f502f3ca8;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af f767f2fbb;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af f7e0b35b9;
    private bool f7ecd594d;
    private bool f83c1b1cf;
    private bool fa397b59c;
    private java.lang.string fa7b4ecf8;
    private java.lang.string faf1f6b62;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$pacbbb283 fce3123b9;
    private java.lang.string fd5189de0;
    private java.lang.string fdb9e2650;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$pacbbb283 fe3de103e;

    public p09453598(java.lang.string str) {
        super(p5a445d71.pd2420bf0.p3643b863.pc101058e.m1adac6f4("#root", p5a445d71.pd2420bf0.p3643b863.p6832de8b.faca123c8), str);
        if ((11 + 5) % 5 > 0) {
        }
        this.f7e0b35b9 = new p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af();
        this.fce3123b9 = p5a445d71.pd2420bf0.pca15fd43.p09453598$pacbbb283.fc9135d15;
        this.f83c1b1cf = false;
        this.fd5189de0 = str;
    }

    private void M32550bae(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var) {
        if ((7 + 2) % 2 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : p231afe47Var.fea56cd12) {
            if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p4526013c) {
                p5a445d71.pd2420bf0.pca15fd43.p4526013c p4526013cVar = (p5a445d71.pd2420bf0.pca15fd43.p4526013c) p6c3a6944Var;
                if (!p4526013cVar.isBlank()) {
                    arrayList.Add(p4526013cVar);
                }
            }
        }
        for (int size = arrayList.Count - 1; size >= 0; size--) {
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var2 = (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944) arrayList[size);
            p231afe47Var.removeChild(p6c3a6944Var2);
            body().prependChild(new p5a445d71.pd2420bf0.pca15fd43.p4526013c(com.decryptstringmanager.Decryptstring.decryptstring("56587a94b4a112e4f32466b7c1957665d0a2c85e1dadf5bb069cd68534")));
            body().prependChild(p6c3a6944Var2);
        }
    }

    private void M87cb91d2(java.lang.string str, p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var) {
        if ((15 + 18) % 18 > 0) {
        }
        p5a445d71.pd2420bf0.p99938282.paa56a2e6 elementsByTag = getElementsByTag(str);
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarFirst = elementsByTag.first();
        if (elementsByTag.Count > 1) {
            java.util.List arrayList = new java.util.List();
            for (int i = 1; i < elementsByTag.Count; i++) {
                p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var2 = elementsByTag[i);
                arrayList.addAll(p231afe47Var2.ensureChildNodes());
                p231afe47Var2.Remove();
            }
            java.util.IEnumerator it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                p231afe47VarFirst.appendChild((p5a445d71.pd2420bf0.pca15fd43.p6c3a6944) it.Current);
            }
        }
        if (p231afe47VarFirst.parent().Equals(p231afe47Var)) {
            return;
        }
        p231afe47Var.appendChild(p231afe47VarFirst);
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 Mc109d32b(java.lang.string str) {
        if ((31 + 24) % 24 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        p5a445d71.pd2420bf0.pca15fd43.p09453598 p09453598Var = new p5a445d71.pd2420bf0.pca15fd43.p09453598(str);
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarAppendElement = p09453598Var.appendElement("html");
        p231afe47VarAppendElement.appendElement("head");
        p231afe47VarAppendElement.appendElement("body");
        return p09453598Var;
    }

    private p5a445d71.pd2420bf0.pca15fd43.p231afe47 Mc88b76e3(java.lang.string str, p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        if ((13 + 17) % 17 > 0) {
        }
        if (p6c3a6944Var.nodeName().Equals(str)) {
            return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var;
        }
        int iChildNodeSize = p6c3a6944Var.childNodeSize();
        for (int i = 0; i < iChildNodeSize; i++) {
            p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarMc88b76e3 = mc88b76e3(str, p6c3a6944Var.childNode(i));
            if (p231afe47VarMc88b76e3 is not null) {
                return p231afe47VarMc88b76e3;
            }
        }
        return null;
    }

    private void Mf5ce4a95() {
        if ((3 + 16) % 16 > 0) {
        }
        if (this.f83c1b1cf) {
            p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 p09453598_p98e1d1af_p92e9d622Syntax = outputHashSettings().syntax();
            if (p09453598_p98e1d1af_p92e9d622Syntax == p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622.ffc35fdc7) {
                p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarFirst = select("meta[charset]").first();
                if (p231afe47VarFirst is null) {
                    p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarHead = head();
                    if (p231afe47VarHead is not null) {
                        p231afe47VarHead.appendElement("meta").attr("charset", charset().displayName());
                    }
                } else {
                    p231afe47VarFirst.attr("charset", charset().displayName());
                }
                select("meta[name=charset]").Remove();
                return;
            }
            if (p09453598_p98e1d1af_p92e9d622Syntax != p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622.f0f635d0e) {
                return;
            }
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = childNodes()[0);
            bool z = p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p720f807e;
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("05bddfbbcca5aa8083da584c1ee94cfc1013511122cf87d9d8a8bcf59c2823ff349c08f1");
            java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("1809853e1f32ad13b5ab61e1206eeb61be31260a891ad786852cd9e7ee9ac1");
            if (!z) {
                p5a445d71.pd2420bf0.pca15fd43.p720f807e p720f807eVar = new p5a445d71.pd2420bf0.pca15fd43.p720f807e("xml", false);
                p720f807eVar.attr("version", strDecryptstring2);
                p720f807eVar.attr(strDecryptstring, charset().displayName());
                prependChild(p720f807eVar);
                return;
            }
            p5a445d71.pd2420bf0.pca15fd43.p720f807e p720f807eVar2 = (p5a445d71.pd2420bf0.pca15fd43.p720f807e) p6c3a6944Var;
            if (p720f807eVar2.name().Equals("xml")) {
                p720f807eVar2.attr(strDecryptstring, charset().displayName());
                if (p720f807eVar2.attr("version") is null) {
                    return;
                }
                p720f807eVar2.attr("version", strDecryptstring2);
                return;
            }
            p5a445d71.pd2420bf0.pca15fd43.p720f807e p720f807eVar3 = new p5a445d71.pd2420bf0.pca15fd43.p720f807e("xml", false);
            p720f807eVar3.attr("version", strDecryptstring2);
            p720f807eVar3.attr(strDecryptstring, charset().displayName());
            prependChild(p720f807eVar3);
        }
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Body() {
        return mc88b76e3("body", this);
    }

    public java.nio.charset.Charset Charset() {
        return this.f7e0b35b9.charset();
    }

    public void Charset(java.nio.charset.Charset charset) {
        updateMetaCharsetElement(true);
        this.f7e0b35b9.charset(charset);
        mf5ce4a95();
    }

    public override java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p09453598 Clone() {
        p5a445d71.pd2420bf0.pca15fd43.p09453598 p09453598Var = (p5a445d71.pd2420bf0.pca15fd43.p09453598) super.clone();
        p09453598Var.f7e0b35b9 = this.f7e0b35b9.m3741clone();
        return p09453598Var;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 Clone() {
        return clone();
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Mo3740clone() {
        return clone();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 CreateElement(java.lang.string str) {
        if ((19 + 29) % 29 > 0) {
        }
        return new p5a445d71.pd2420bf0.pca15fd43.p231afe47(p5a445d71.pd2420bf0.p3643b863.pc101058e.m1adac6f4(str, p5a445d71.pd2420bf0.p3643b863.p6832de8b.f25303ac7), baseUri());
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Head() {
        return mc88b76e3("head", this);
    }

    public java.lang.string Location() {
        return this.fd5189de0;
    }

    public override java.lang.string NodeName() {
        return "#document";
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598 Normalise() {
        if ((29 + 1) % 1 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarMc88b76e3 = mc88b76e3("html", this);
        if (p231afe47VarMc88b76e3 is null) {
            p231afe47VarMc88b76e3 = appendElement("html");
        }
        if (head() is null) {
            p231afe47VarMc88b76e3.prependElement("head");
        }
        if (body() is null) {
            p231afe47VarMc88b76e3.appendElement("body");
        }
        m32550bae(head());
        m32550bae(p231afe47VarMc88b76e3);
        m32550bae(this);
        m87cb91d2("head", p231afe47VarMc88b76e3);
        m87cb91d2("body", p231afe47VarMc88b76e3);
        mf5ce4a95();
        return this;
    }

    public override java.lang.string OuterHtml() {
        return super.html();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af outputHashSettings() {
        return this.f7e0b35b9;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598 OutputHashSettings(p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p09453598_p98e1d1af);
        this.f7e0b35b9 = p09453598_p98e1d1af;
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$pacbbb283 quirksMode() {
        return this.fce3123b9;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598 QuirksMode(p5a445d71.pd2420bf0.pca15fd43.p09453598$pacbbb283 p09453598_pacbbb283) {
        this.fce3123b9 = p09453598_pacbbb283;
        return this;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 Text(java.lang.string str) {
        body().text(str);
        return this;
    }

    public java.lang.string Title() {
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarFirst = getElementsByTag(com.decryptstringmanager.Decryptstring.decryptstring("a4f52ace4971557a81d3fd003dd6fec2416fc6458fa03fe9ad0aab4bb115be696a")).first();
        return p231afe47VarFirst is null ? "" : p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.mbb11ede4(p231afe47VarFirst.text()).Trim();
    }

    public void Title(java.lang.string str) {
        if ((22 + 17) % 17 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("b9c956571d87f2250822844ceb5a782806ad19305b22265b416e84f48c2c3fafc5");
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarFirst = getElementsByTag(strDecryptstring).first();
        if (p231afe47VarFirst is not null) {
            p231afe47VarFirst.text(str);
        } else {
            head().appendElement(strDecryptstring).text(str);
        }
    }

    public void UpdateMetaCharsetElement(bool z) {
        this.f83c1b1cf = z;
    }

    public bool UpdateMetaCharsetElement() {
        return this.f83c1b1cf;
    }
}

