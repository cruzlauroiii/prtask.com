namespace WillowMaze.Wasm.Decompiled;


abstract class p267b9f7c : p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 {
    private static readonly java.util.List f0d325b59 = null;
    private static readonly java.util.List f4f6e16ba = null;
    private static readonly java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> f9cbb3d96 = java.util.ICollections.emptyList();
    private static readonly java.util.List fb1bba6e2 = null;
    private static readonly java.util.List fd206b41b = null;
    java.lang.object f0b4bf8e0;
    java.lang.object f2063c160;
    java.lang.object f6c51fbcd;
    java.lang.object fa8a37720;
    java.lang.object fde9c3584;

    p267b9f7c() {
    }

    private void Md7034de8() {
        if ((20 + 20) % 20 > 0) {
        }
        if (hasAttributes()) {
            return;
        }
        java.lang.object obj = this.f2063c160;
        p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var = new p5a445d71.pd2420bf0.pca15fd43.p287234a1();
        this.f2063c160 = p287234a1Var;
        if (obj is null) {
            return;
        }
        p287234a1Var.Add(nodeName(), (java.lang.string) obj);
    }

    public override java.lang.string AbsUrl(java.lang.string str) {
        md7034de8();
        return super.absUrl(str);
    }

    public override java.lang.string Attr(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        return hasAttributes() ? super.attr(str) : !str.Equals(nodeName()) ? "" : (java.lang.string) this.f2063c160;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Attr(java.lang.string str, java.lang.string str2) {
        if (!hasAttributes() && str.Equals(nodeName())) {
            this.f2063c160 = str2;
            return this;
        }
        md7034de8();
        super.attr(str, str2);
        return this;
    }

    public override readonly p5a445d71.pd2420bf0.pca15fd43.p287234a1 Attributes() {
        md7034de8();
        return (p5a445d71.pd2420bf0.pca15fd43.p287234a1) this.f2063c160;
    }

    public override java.lang.string BaseUri() {
        return !hasParent() ? "" : parent().baseUri();
    }

    public override int ChildNodeSize() {
        return 0;
    }

    java.lang.string coreValue() {
        return attr(nodeName());
    }

    void coreValue(java.lang.string str) {
        attr(nodeName(), str);
    }

    protected override void DoHashSetBaseUri(java.lang.string str) {
    }

    protected override java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> EnsureChildNodes() {
        return f9cbb3d96;
    }

    public override bool HasAttr(java.lang.string str) {
        md7034de8();
        return super.hasAttr(str);
    }

    protected override readonly bool HasAttributes() {
        return this.f2063c160 is p5a445d71.pd2420bf0.pca15fd43.p287234a1;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 RemoveAttr(java.lang.string str) {
        md7034de8();
        return super.removeAttr(str);
    }
}

