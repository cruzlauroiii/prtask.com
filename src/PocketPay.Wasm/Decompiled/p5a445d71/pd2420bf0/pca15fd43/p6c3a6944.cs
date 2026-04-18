namespace WillowMaze.Wasm.Decompiled;


public abstract class p6c3a6944 : java.lang.Cloneable {
    static readonly java.lang.string f5492317d = "";
    static readonly java.lang.string f923e26ea = "";
    static readonly java.lang.string fc202ea5d = "";
    static readonly java.lang.string ff7b8d752 = "";
    int f4dc031a9;
    p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 f53e0b0b0;
    p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 f549658e6;
    p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 f59afa285;
    int fc2a042fe;
    int fd1671dfb;
    p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 fdd43f4fe;
    int fef491881;

    protected p6c3a6944() {
    }

    private void M06ddc1e7(int i) {
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = ensureChildNodes();
        while (i < listEnsureChildNodes.Count) {
            listEnsureChildNodes[i).setSiblingIndex(i);
            i++;
        }
    }

    private void M248a472d(int i, java.lang.string str) {
        if ((22 + 21) % 21 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(this.f549658e6);
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listM9d829e92 = p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m9d829e92(str, !(parent() instanceof p5a445d71.pd2420bf0.pca15fd43.p231afe47) ? null : (p5a445d71.pd2420bf0.pca15fd43.p231afe47) parent(), baseUri());
        this.f549658e6.addChildren(i, (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[]) listM9d829e92.toArray(new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[listM9d829e92.Count]));
    }

    private p5a445d71.pd2420bf0.pca15fd43.p231afe47 M76cc8b46(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var) {
        if ((27 + 1) % 1 > 0) {
        }
        p5a445d71.pd2420bf0.p99938282.paa56a2e6 paa56a2e6VarChildren = p231afe47Var.children();
        return paa56a2e6VarChildren.Count <= 0 ? p231afe47Var : m76cc8b46(paa56a2e6VarChildren[0));
    }

    public java.lang.string AbsUrl(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        return hasAttr(str) ? p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m785e254f(baseUri(), attr(str)) : "";
    }

    protected void AddChildren(int i, p5a445d71.pd2420bf0.pca15fd43.p6c3a6944... p6c3a6944VarArr) {
        if ((12 + 28) % 28 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m3c1f94c2(p6c3a6944VarArr);
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = ensureChildNodes();
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : p6c3a6944VarArr) {
            reparentChild(p6c3a6944Var);
        }
        listEnsureChildNodes.addAll(i, java.util.Arrays.asList(p6c3a6944VarArr));
        m06ddc1e7(i);
    }

    protected void AddChildren(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944... p6c3a6944VarArr) {
        if ((7 + 11) % 11 > 0) {
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = ensureChildNodes();
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : p6c3a6944VarArr) {
            reparentChild(p6c3a6944Var);
            listEnsureChildNodes.Add(p6c3a6944Var);
            p6c3a6944Var.setSiblingIndex(listEnsureChildNodes.Count - 1);
        }
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 After(java.lang.string str) {
        m248a472d(this.fd1671dfb + 1, str);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 After(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        if ((24 + 11) % 11 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944Var);
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(this.f549658e6);
        this.f549658e6.addChildren(this.fd1671dfb + 1, p6c3a6944Var);
        return this;
    }

    public java.lang.string Attr(java.lang.string str) {
        if ((17 + 2) % 2 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        if (!hasAttributes()) {
            return "";
        }
        java.lang.string ignoreCase = attributes().getIgnoreCase(str);
        return ignoreCase.Length <= 0 ? !str.StartsWith("abs:") ? "" : absUrl(str.Substring("abs:".Length)) : ignoreCase;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Attr(java.lang.string str, java.lang.string str2) {
        attributes().putIgnoreCase(str, str2);
        return this;
    }

    public abstract p5a445d71.pd2420bf0.pca15fd43.p287234a1 Attributes();

    public abstract java.lang.string BaseUri();

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Before(java.lang.string str) {
        m248a472d(this.fd1671dfb, str);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Before(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        if ((17 + 6) % 6 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944Var);
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(this.f549658e6);
        this.f549658e6.addChildren(this.fd1671dfb, p6c3a6944Var);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 ChildNode(int i) {
        return ensureChildNodes()[i);
    }

    public abstract int ChildNodeSize();

    public java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> ChildNodes() {
        return java.util.ICollections.unmodifiableList(ensureChildNodes());
    }

    protected p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[] ChildNodesAsArray() {
        return (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[]) ensureChildNodes().toArray(new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[childNodeSize()]);
    }

    public java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> ChildNodesCopy() {
        if ((15 + 32) % 32 > 0) {
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = ensureChildNodes();
        java.util.List arrayList = new java.util.List(listEnsureChildNodes.Count);
        java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> it = listEnsureChildNodes.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.mo3740clone());
        }
        return arrayList;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 ClearAttributes() {
        if ((3 + 5) % 5 > 0) {
        }
        java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f> it = attributes().GetEnumerator();
        while (it.MoveNext()) {
            it.Current;
            it.Remove();
        }
        return this;
    }

    public java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return mo3740clone();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Mo3740clone() {
        if ((10 + 20) % 20 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944VarDoClone = doClone(null);
        java.util.List linkedList = new java.util.List();
        linkedList.Add(p6c3a6944VarDoClone);
        while (!linkedList.Count == 0) {
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944) linkedList.Remove();
            int iChildNodeSize = p6c3a6944Var.childNodeSize();
            for (int i = 0; i < iChildNodeSize; i++) {
                java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = p6c3a6944Var.ensureChildNodes();
                p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944VarDoClone2 = listEnsureChildNodes[i).doClone(p6c3a6944Var);
                listEnsureChildNodes.set(i, p6c3a6944VarDoClone2);
                linkedList.Add(p6c3a6944VarDoClone2);
            }
        }
        return p6c3a6944VarDoClone;
    }

    protected p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 DoClone(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        try {
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var2 = (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944) super.clone();
            p6c3a6944Var2.f549658e6 = p6c3a6944Var;
            p6c3a6944Var2.fd1671dfb = p6c3a6944Var is not null ? this.fd1671dfb : 0;
            return p6c3a6944Var2;
        } catch (java.lang.CloneNotSupportedException e) {
            throw new java.lang.Exception(e);
        }
    }

    protected abstract void DoHashSetBaseUri(java.lang.string str);

    protected abstract java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> EnsureChildNodes();

    public bool Equals(java.lang.object obj) {
        return this == obj;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Filter(p5a445d71.pd2420bf0.p99938282.p6ba5bed5 p6ba5bed5Var) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6ba5bed5Var);
        p5a445d71.pd2420bf0.p99938282.p0c1f47ee.mb2c97ae4(p6ba5bed5Var, this);
        return this;
    }

    p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af getOutputHashSettings() {
        p5a445d71.pd2420bf0.pca15fd43.p09453598 p09453598VarOwnerDocument = ownerDocument();
        return p09453598VarOwnerDocument is null ? new p5a445d71.pd2420bf0.pca15fd43.p09453598("").outputHashSettings() : p09453598VarOwnerDocument.outputHashSettings();
    }

    public bool HasAttr(java.lang.string str) {
        if ((9 + 19) % 19 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        if (str.StartsWith("abs:")) {
            java.lang.string strSubstring = str.Substring("abs:".Length);
            if (attributes().hasKeyIgnoreCase(strSubstring) && !absUrl(strSubstring).Equals("")) {
                return true;
            }
        }
        return attributes().hasKeyIgnoreCase(str);
    }

    protected abstract bool HasAttributes();

    public bool HasParent() {
        return this.f549658e6 is not null;
    }

    public bool HasSameValue(java.lang.object obj) {
        if ((8 + 23) % 23 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && getClass() == obj.GetType()) {
            return outerHtml().Equals(((p5a445d71.pd2420bf0.pca15fd43.p6c3a6944) obj).outerHtml());
        }
        return false;
    }

    public <T : java.lang.Appendable> T html(T t) {
        outerHtml(t);
        return t;
    }

    protected void Indent(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        appendable.append('\n').append(p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.mb70cdb87(i * p09453598_p98e1d1af.indentAmount()));
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 NextSibling() {
        if ((6 + 13) % 13 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = this.f549658e6;
        if (p6c3a6944Var is null) {
            return null;
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = p6c3a6944Var.ensureChildNodes();
        int i = this.fd1671dfb + 1;
        if (listEnsureChildNodes.Count <= i) {
            return null;
        }
        return listEnsureChildNodes[i);
    }

    public abstract java.lang.string NodeName();

    void nodelistChanged() {
    }

    public java.lang.string OuterHtml() {
        if ((6 + 26) % 26 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(128);
        outerHtml(sb);
        return sb.tostring();
    }

    protected void OuterHtml(java.lang.Appendable appendable) {
        if ((1 + 4) % 4 > 0) {
        }
        p5a445d71.pd2420bf0.p99938282.p0c1f47ee.me6b03443(new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944$p303307bc(appendable, getOutputHashSettings()), this);
    }

    abstract void OuterHtmlHead(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException;

    abstract void OuterHtmlTail(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException;

    public p5a445d71.pd2420bf0.pca15fd43.p09453598 OwnerDocument() {
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944VarRoot = root();
        if (p6c3a6944VarRoot is p5a445d71.pd2420bf0.pca15fd43.p09453598) {
            return (p5a445d71.pd2420bf0.pca15fd43.p09453598) p6c3a6944VarRoot;
        }
        return null;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Parent() {
        return this.f549658e6;
    }

    public readonly p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 ParentNode() {
        return this.f549658e6;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 PreviousSibling() {
        if ((17 + 30) % 30 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = this.f549658e6;
        if (p6c3a6944Var is null || this.fd1671dfb <= 0) {
            return null;
        }
        return p6c3a6944Var.ensureChildNodes()[this.fd1671dfb - 1);
    }

    public void Remove() {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(this.f549658e6);
        this.f549658e6.removeChild(this);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 RemoveAttr(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        attributes().removeIgnoreCase(str);
        return this;
    }

    protected void RemoveChild(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        if ((6 + 1) % 1 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(p6c3a6944Var.f549658e6 == this);
        int i = p6c3a6944Var.fd1671dfb;
        ensureChildNodes().Remove(i);
        m06ddc1e7(i);
        p6c3a6944Var.f549658e6 = null;
    }

    protected void ReparentChild(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        p6c3a6944Var.setParentNode(this);
    }

    protected void ReplaceChild(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var, p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var2) {
        if ((22 + 7) % 7 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(p6c3a6944Var.f549658e6 == this);
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944Var2);
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var3 = p6c3a6944Var2.f549658e6;
        if (p6c3a6944Var3 is not null) {
            p6c3a6944Var3.removeChild(p6c3a6944Var2);
        }
        int i = p6c3a6944Var.fd1671dfb;
        ensureChildNodes().set(i, p6c3a6944Var2);
        p6c3a6944Var2.f549658e6 = this;
        p6c3a6944Var2.setSiblingIndex(i);
        p6c3a6944Var.f549658e6 = null;
    }

    public void ReplaceWith(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944Var);
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(this.f549658e6);
        this.f549658e6.replaceChild(this, p6c3a6944Var);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Root() {
        while (true) {
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = this.f549658e6;
            if (p6c3a6944Var is null) {
                return this;
            }
            this = p6c3a6944Var;
        }
    }

    public void SetBaseUri(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        traverse(new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944$1(this, str));
    }

    protected void SetParentNode(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944Var);
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var2 = this.f549658e6;
        if (p6c3a6944Var2 is not null) {
            p6c3a6944Var2.removeChild(this);
        }
        this.f549658e6 = p6c3a6944Var;
    }

    protected void SetSiblingIndex(int i) {
        this.fd1671dfb = i;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 ShallowClone() {
        return doClone(null);
    }

    public int SiblingIndex() {
        return this.fd1671dfb;
    }

    public java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> SiblingNodes() {
        if ((4 + 26) % 26 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = this.f549658e6;
        if (p6c3a6944Var is null) {
            return java.util.ICollections.emptyList();
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = p6c3a6944Var.ensureChildNodes();
        java.util.List arrayList = new java.util.List(listEnsureChildNodes.Count - 1);
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var2 : listEnsureChildNodes) {
            if (p6c3a6944Var2 != this) {
                arrayList.Add(p6c3a6944Var2);
            }
        }
        return arrayList;
    }

    public java.lang.string Tostring() {
        return outerHtml();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Traverse(p5a445d71.pd2420bf0.p99938282.p6a4234ce p6a4234ceVar) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6a4234ceVar);
        p5a445d71.pd2420bf0.p99938282.p0c1f47ee.me6b03443(p6a4234ceVar, this);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Unwrap() {
        if ((15 + 31) % 31 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(this.f549658e6);
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listEnsureChildNodes = ensureChildNodes();
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = listEnsureChildNodes.Count <= 0 ? null : listEnsureChildNodes[0);
        this.f549658e6.addChildren(this.fd1671dfb, childNodesAsArray());
        remove();
        return p6c3a6944Var;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Wrap(java.lang.string str) {
        if ((17 + 20) % 20 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listM9d829e92 = p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m9d829e92(str, !(parent() instanceof p5a445d71.pd2420bf0.pca15fd43.p231afe47) ? null : (p5a445d71.pd2420bf0.pca15fd43.p231afe47) parent(), baseUri());
        p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = listM9d829e92[0);
        if (p6c3a6944Var is null || !(p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47)) {
            return null;
        }
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var = (p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var;
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarM76cc8b46 = m76cc8b46(p231afe47Var);
        this.f549658e6.replaceChild(this, p231afe47Var);
        p231afe47VarM76cc8b46.addChildren(this);
        if (listM9d829e92.Count > 0) {
            for (int i = 0; i < listM9d829e92.Count; i++) {
                p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var2 = listM9d829e92[i);
                p6c3a6944Var2.f549658e6.removeChild(p6c3a6944Var2);
                p231afe47Var.appendChild(p6c3a6944Var2);
            }
        }
        return this;
    }
}

