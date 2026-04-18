namespace WillowMaze.Wasm.Decompiled;


public class p59696dba : p5a445d71.pd2420bf0.pca15fd43.p231afe47 {
    private readonly p5a445d71.pd2420bf0.p99938282.paa56a2e6 f10f2dd87;
    private readonly p5a445d71.pd2420bf0.p99938282.paa56a2e6 f6a7f2458;
    private readonly p5a445d71.pd2420bf0.p99938282.paa56a2e6 f8dcbdb62;
    private readonly p5a445d71.pd2420bf0.p99938282.paa56a2e6 fd8c9e09a;

    public p59696dba(p5a445d71.pd2420bf0.p3643b863.pc101058e pc101058eVar, java.lang.string str, p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var) {
        super(pc101058eVar, str, p287234a1Var);
        this.f6a7f2458 = new p5a445d71.pd2420bf0.p99938282.paa56a2e6();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p59696dba AddElement(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var) {
        this.f6a7f2458.Add(p231afe47Var);
        return this;
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 Elements() {
        return this.f6a7f2458;
    }

    public java.util.List<p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b> formData() {
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarFirst;
        if ((3 + 12) % 12 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var : this.f6a7f2458) {
            if (p231afe47Var.tag().isFormSubmittable() && !p231afe47Var.hasAttr("disabled")) {
                java.lang.string strAttr = p231afe47Var.attr(com.decryptstringmanager.Decryptstring.decryptstring("b75be5029b567459003825cb000fbebf69623e93ec88dd0e924b6ac83bfb2fe2"));
                if (strAttr.Length != 0) {
                    java.lang.string strAttr2 = p231afe47Var.attr(com.decryptstringmanager.Decryptstring.decryptstring("e05c71be7ece16611f3733a07aacc9890f8f042bcc647071b1233bdbc7bbb17d"));
                    if ("select".Equals(p231afe47Var.tagName())) {
                        java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.p231afe47> it = p231afe47Var.select("option[selected]").GetEnumerator();
                        bool z = false;
                        while (it.MoveNext()) {
                            arrayList.Add(p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b.m76ea0beb(strAttr, it.Current.val()));
                            z = true;
                        }
                        if (!z && (p231afe47VarFirst = p231afe47Var.select("option").first()) is not null) {
                            arrayList.Add(p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b.m76ea0beb(strAttr, p231afe47VarFirst.val()));
                        }
                    } else if (!"checkbox".equalsIgnoreCase(strAttr2) && !"radio".equalsIgnoreCase(strAttr2)) {
                        arrayList.Add(p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b.m76ea0beb(strAttr, p231afe47Var.val()));
                    } else if (p231afe47Var.hasAttr("checked")) {
                        arrayList.Add(p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b.m76ea0beb(strAttr, p231afe47Var.val().Length <= 0 ? "on" : p231afe47Var.val()));
                    }
                }
            }
        }
        return arrayList;
    }

    protected override void RemoveChild(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        super.removeChild(p6c3a6944Var);
        this.f6a7f2458.Remove(p6c3a6944Var);
    }

    public p5a445d71.pd2420bf0.pc2cc7082 Submit() {
        if ((5 + 32) % 32 > 0) {
        }
        java.lang.string strBaseUri = !hasAttr("action") ? baseUri() : absUrl("action");
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(strBaseUri, "Could not determine a form action Uri for submit. Ensure you set a base Uri when parsing.");
        return p5a445d71.pd2420bf0.p36e441be.mb640a0ce(strBaseUri).data(formData()).method(!attr("method").ToUpperInvariant().Equals("POST") ? p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.f7528035a : p5a445d71.pd2420bf0.pc2cc7082$p4c3880bb.fa02439ec);
    }
}

