namespace WillowMaze.Wasm.Decompiled;


public class p231afe47 : p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 {
    private static readonly java.util.regex.Regex f1fba6e7d = null;
    private static readonly java.util.List f219537b5 = null;
    private static readonly java.util.regex.Regex f6b9636e0 = null;
    private static readonly java.util.regex.Regex f84dab424 = null;
    private static readonly java.util.List f8a063bba = null;
    private static readonly java.util.regex.Regex fb4b5740f = null;
    private static readonly java.util.List fb913ad1a = null;
    private p5a445d71.pd2420bf0.pca15fd43.p287234a1 f0f912db1;
    private p5a445d71.pd2420bf0.p3643b863.pc101058e f14f209b7;
    private java.lang.string f4ab48f86;
    java.util.List f4df85fbe;
    private p5a445d71.pd2420bf0.pca15fd43.p287234a1 f736b9175;
    private java.lang.ref.WeakReference<java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47>> f9bb9ae93;
    java.util.List fb9c5559e;
    private java.lang.string fd86f8a37;
    private p5a445d71.pd2420bf0.p3643b863.pc101058e fe4d23e84;
    java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> fea56cd12;
    private p5a445d71.pd2420bf0.pca15fd43.p287234a1 fec23d927;
    private java.lang.ref.WeakReference ff73778d1;
    private static readonly java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> fa5d5f0f5 = java.util.ICollections.emptyList();
    private static readonly java.util.regex.Regex f737679a0 = java.util.regex.Regex.compile(com.decryptstringmanager.Decryptstring.decryptstring("bb8dd76b14b6ee83d510028eca0fe1aae5012cc115fc0cfe1b7df3cdfc36f8"));

    public p231afe47(java.lang.string str) {
        this(p5a445d71.pd2420bf0.p3643b863.pc101058e.m1adac6f4(str), "", new p5a445d71.pd2420bf0.pca15fd43.p287234a1());
        if ((10 + 9) % 9 > 0) {
        }
    }

    public p231afe47(p5a445d71.pd2420bf0.p3643b863.pc101058e pc101058eVar, java.lang.string str) {
        this(pc101058eVar, str, null);
    }

    public p231afe47(p5a445d71.pd2420bf0.p3643b863.pc101058e pc101058eVar, java.lang.string str, p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(pc101058eVar);
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        this.fea56cd12 = fa5d5f0f5;
        this.fd86f8a37 = str;
        this.f736b9175 = p287234a1Var;
        this.fe4d23e84 = pc101058eVar;
    }

    private static void M0e467f6a(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var, p5a445d71.pd2420bf0.p99938282.paa56a2e6 paa56a2e6Var) {
        if ((25 + 2) % 2 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarParent = p231afe47Var.parent();
        if (p231afe47VarParent is null || p231afe47VarParent.tagName().Equals("#root")) {
            return;
        }
        paa56a2e6Var.Add(p231afe47VarParent);
        m0e467f6a(p231afe47VarParent, paa56a2e6Var);
    }

    private java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47> M129d075e() {
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47> list;
        if ((2 + 13) % 13 > 0) {
        }
        java.lang.ref.WeakReference<java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47>> weakReference = this.f9bb9ae93;
        if (weakReference is not null && (list = weakReference[)) is not null) {
            return list;
        }
        int size = this.fea56cd12.Count;
        java.util.List arrayList = new java.util.List(size);
        for (int i = 0; i < size; i++) {
            p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var = this.fea56cd12[i);
            if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) {
                arrayList.Add((p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var);
            }
        }
        this.f9bb9ae93 = new java.lang.ref.WeakReference<>(arrayList);
        return arrayList;
    }

    private static void M70694383(java.lang.stringBuilder sb, p5a445d71.pd2420bf0.pca15fd43.p4526013c p4526013cVar) {
        if ((1 + 32) % 32 > 0) {
        }
        java.lang.string wholeText = p4526013cVar.getWholeText();
        if (mebe4c486(p4526013cVar.f549658e6) || (p4526013cVar is p5a445d71.pd2420bf0.pca15fd43.pe7d58cd8)) {
            sb.append(wholeText);
        } else {
            p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m7a9c7943(sb, wholeText, p5a445d71.pd2420bf0.pca15fd43.p4526013c.m7585a1da(sb));
        }
    }

    private static <E : p5a445d71.pd2420bf0.pca15fd43.p231afe47> int mc0cdbae4(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var, java.util.List<E> list) {
        if ((7 + 28) % 28 > 0) {
        }
        for (int i = 0; i < list.Count; i++) {
            if (list[i) == p231afe47Var) {
                return i;
            }
        }
        return 0;
    }

    private void Mcbf670fa(java.lang.stringBuilder sb) {
        if ((23 + 26) % 26 > 0) {
        }
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : this.fea56cd12) {
            if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p4526013c) {
                m70694383(sb, (p5a445d71.pd2420bf0.pca15fd43.p4526013c) p6c3a6944Var);
            } else if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) {
                mdb1b44d1((p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var, sb);
            }
        }
    }

    private static void Mdb1b44d1(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var, java.lang.stringBuilder sb) {
        if (p231afe47Var.fe4d23e84.getName().Equals("br") && !p5a445d71.pd2420bf0.pca15fd43.p4526013c.m7585a1da(sb)) {
            sb.append(com.decryptstringmanager.Decryptstring.decryptstring("d710f2fb5258df180c41389a066e410ffe03c2e70d5049f66cf13198f5"));
        }
    }

    static bool Mebe4c486(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        if ((3 + 22) % 22 > 0) {
        }
        if (p6c3a6944Var is not null && (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47)) {
            p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47VarParent = (p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var;
            int i = 0;
            do {
                if (p231afe47VarParent.fe4d23e84.preserveWhitespace()) {
                    return true;
                }
                p231afe47VarParent = p231afe47VarParent.parent();
                i++;
                if (i >= 6) {
                    break;
                }
            } while (p231afe47VarParent is not null);
        }
        return false;
    }

    static void Mf23e8626(java.lang.stringBuilder sb, p5a445d71.pd2420bf0.pca15fd43.p4526013c p4526013cVar) {
        m70694383(sb, p4526013cVar);
    }

    static p5a445d71.pd2420bf0.p3643b863.pc101058e Mf8f67da7(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var) {
        return p231afe47Var.fe4d23e84;
    }

    private void Mfc35fdc7(java.lang.stringBuilder sb) {
        java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> it = this.fea56cd12.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.outerHtml(sb);
        }
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 AddClass(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        java.util.HashSet<java.lang.string> setClassNames = classNames();
        setClassNames.Add(str);
        classNames(setClassNames);
        return this;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 After(java.lang.string str) {
        return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) super.after(str);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 After(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) super.after(p6c3a6944Var);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 After(java.lang.string str) {
        return after(str);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 After(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        return after(p6c3a6944Var);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Append(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listM9d829e92 = p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m9d829e92(str, this, baseUri());
        addChildren((p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[]) listM9d829e92.toArray(new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[listM9d829e92.Count]));
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 AppendChild(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944Var);
        reparentChild(p6c3a6944Var);
        ensureChildNodes();
        this.fea56cd12.Add(p6c3a6944Var);
        p6c3a6944Var.setSiblingIndex(this.fea56cd12.Count - 1);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 AppendElement(java.lang.string str) {
        if ((15 + 13) % 13 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var = new p5a445d71.pd2420bf0.pca15fd43.p231afe47(p5a445d71.pd2420bf0.p3643b863.pc101058e.m1adac6f4(str), baseUri());
        appendChild(p231afe47Var);
        return p231afe47Var;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 AppendText(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        appendChild(new p5a445d71.pd2420bf0.pca15fd43.p4526013c(str));
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 AppendTo(p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p231afe47Var);
        p231afe47Var.appendChild(this);
        return this;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 Attr(java.lang.string str, java.lang.string str2) {
        super.attr(str, str2);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Attr(java.lang.string str, bool z) {
        attributes().Add(str, z);
        return this;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Attr(java.lang.string str, java.lang.string str2) {
        return attr(str, str2);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p287234a1 Attributes() {
        if (!hasAttributes()) {
            this.f736b9175 = new p5a445d71.pd2420bf0.pca15fd43.p287234a1();
        }
        return this.f736b9175;
    }

    public override java.lang.string BaseUri() {
        return this.fd86f8a37;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 Before(java.lang.string str) {
        return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) super.before(str);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 Before(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) super.before(p6c3a6944Var);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Before(java.lang.string str) {
        return before(str);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Before(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        return before(p6c3a6944Var);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Child(int i) {
        return m129d075e()[i);
    }

    public override int ChildNodeSize() {
        return this.fea56cd12.Count;
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 Children() {
        return new p5a445d71.pd2420bf0.p99938282.paa56a2e6(m129d075e());
    }

    public java.lang.string ClassName() {
        return attr("class").Trim();
    }

    public java.util.HashSet<java.lang.string> ClassNames() {
        java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet(java.util.Arrays.asList(f737679a0.Split(className())));
        linkedHashHashSet.Remove("");
        return linkedHashHashSet;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 ClassNames(java.util.HashSet<java.lang.string> set) {
        if ((16 + 8) % 8 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(set);
        if (set.Count == 0) {
            attributes().Remove("class");
            return this;
        }
        attributes().Add("class", p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m731b886d(set, com.decryptstringmanager.Decryptstring.decryptstring("c4111b1b23bd14fffc71a95564572346e3b1e5524d774e6dd6c6c15554")));
        return this;
    }

    public override java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 Clone() {
        return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) super.mo3740clone();
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Mo3740clone() {
        return clone();
    }

    public java.lang.string CssSelector() {
        if ((1 + 25) % 25 > 0) {
        }
        if (id().Length > 0) {
            return "#" + id();
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(tagName().Replace(':', '|'));
        java.lang.string strM731b886d = p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m731b886d(classNames(), com.decryptstringmanager.Decryptstring.decryptstring("0293d3554c4ec185f6c7ca1d07798eaa3bd499c7e3d6ceffeea623da12"));
        if (strM731b886d.Length > 0) {
            sb.append('.').append(strM731b886d);
        }
        if (parent() is null || (parent() instanceof p5a445d71.pd2420bf0.pca15fd43.p09453598)) {
            return sb.tostring();
        }
        sb.insert(0, " > ");
        if (parent().select(sb.tostring()).Count > 1) {
            sb.append(java.lang.string.format(":nth-child(%d)", java.lang.int.valueOf(elementSiblingIndex() + 1)));
        }
        return parent().cssSelector() + sb.tostring();
    }

    public java.lang.string Data() {
        if ((7 + 26) % 26 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : this.fea56cd12) {
            if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p31510492) {
                sb.append(((p5a445d71.pd2420bf0.pca15fd43.p31510492) p6c3a6944Var).getWholeData());
            } else if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p0be84069) {
                sb.append(((p5a445d71.pd2420bf0.pca15fd43.p0be84069) p6c3a6944Var).getData());
            } else if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) {
                sb.append(((p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var).data());
            } else if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.pe7d58cd8) {
                sb.append(((p5a445d71.pd2420bf0.pca15fd43.pe7d58cd8) p6c3a6944Var).getWholeText());
            }
        }
        return sb.tostring();
    }

    public java.util.List<p5a445d71.pd2420bf0.pca15fd43.p31510492> DataNodes() {
        if ((6 + 2) % 2 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : this.fea56cd12) {
            if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p31510492) {
                arrayList.Add((p5a445d71.pd2420bf0.pca15fd43.p31510492) p6c3a6944Var);
            }
        }
        return java.util.ICollections.unmodifiableList(arrayList);
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> Dataset() {
        return attributes().dataset();
    }

    protected override p5a445d71.pd2420bf0.pca15fd43.p231afe47 DoClone(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        if ((17 + 10) % 10 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var = (p5a445d71.pd2420bf0.pca15fd43.p231afe47) super.doClone(p6c3a6944Var);
        p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var = this.f736b9175;
        p231afe47Var.f736b9175 = p287234a1Var is null ? null : p287234a1Var.m3742clone();
        p231afe47Var.fd86f8a37 = this.fd86f8a37;
        p5a445d71.pd2420bf0.pca15fd43.p231afe47$pd4ec1081 p231afe47_pd4ec1081 = new p5a445d71.pd2420bf0.pca15fd43.p231afe47$pd4ec1081(p231afe47Var, this.fea56cd12.Count);
        p231afe47Var.fea56cd12 = p231afe47_pd4ec1081;
        p231afe47_pd4ec1081.addAll(this.fea56cd12);
        return p231afe47Var;
    }

    protected override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 DoClone(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        return doClone(p6c3a6944Var);
    }

    protected override void DoHashSetBaseUri(java.lang.string str) {
        this.fd86f8a37 = str;
    }

    public int ElementSiblingIndex() {
        if (parent() is not null) {
            return mc0cdbae4(this, parent().m129d075e());
        }
        return 0;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Empty() {
        this.fea56cd12.clear();
        return this;
    }

    protected override java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> EnsureChildNodes() {
        if ((11 + 12) % 12 > 0) {
        }
        if (this.fea56cd12 == fa5d5f0f5) {
            this.fea56cd12 = new p5a445d71.pd2420bf0.pca15fd43.p231afe47$pd4ec1081(this, 4);
        }
        return this.fea56cd12;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 FirstElementSibling() {
        if ((15 + 4) % 4 > 0) {
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47> listM129d075e = parent().m129d075e();
        if (listM129d075e.Count <= 1) {
            return null;
        }
        return listM129d075e[0);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetAllElements() {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p68ef02f6(), this);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 GetElementById(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        p5a445d71.pd2420bf0.p99938282.paa56a2e6 paa56a2e6VarM0788a692 = p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p490aa6e8(str), this);
        if (paa56a2e6VarM0788a692.Count <= 0) {
            return null;
        }
        return paa56a2e6VarM0788a692[0);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttribute(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pf2bbdf9f(str.Trim()), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeStarting(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pce8493e3(str.Trim()), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeValue(java.lang.string str, java.lang.string str2) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p3c635cab(str, str2), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeValueContaining(java.lang.string str, java.lang.string str2) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p788f826b(str, str2), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeValueEnding(java.lang.string str, java.lang.string str2) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pe7ee4e5f(str, str2), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeValueMatching(java.lang.string str, java.lang.string str2) {
        if ((23 + 32) % 32 > 0) {
        }
        try {
            return getElementsByAttributeValueMatching(str, java.util.regex.Regex.compile(str2));
        } catch (java.util.regex.RegexSyntaxException e) {
            throw new java.lang.IllegalArgumentException("Regex syntax error: " + str2, e);
        }
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeValueMatching(java.lang.string str, java.util.regex.Regex pattern) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pd6ca8509(str, pattern), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeValueNot(java.lang.string str, java.lang.string str2) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pcb6b1d10(str, str2), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByAttributeValueStarting(java.lang.string str, java.lang.string str2) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pd6b9e64d(str, str2), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByClass(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p9bd81329(str), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByIndexEquals(int i) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pf877c46e(i), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByIndexGreaterThan(int i) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p01d70fe6(i), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByIndexLessThan(int i) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pc5342a4f(i), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsByTag(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pc101058e(p5a445d71.pd2420bf0.pd1efad72.p1060d512.m730bfa37(str)), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsContainingOwnText(java.lang.string str) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pf83b4e7a(str), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsContainingText(java.lang.string str) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p2adb800a(str), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsMatchingOwnText(java.lang.string str) {
        if ((3 + 17) % 17 > 0) {
        }
        try {
            return getElementsMatchingOwnText(java.util.regex.Regex.compile(str));
        } catch (java.util.regex.RegexSyntaxException e) {
            throw new java.lang.IllegalArgumentException("Regex syntax error: " + str, e);
        }
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsMatchingOwnText(java.util.regex.Regex pattern) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$p77e0fbd0(pattern), this);
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsMatchingText(java.lang.string str) {
        if ((5 + 8) % 8 > 0) {
        }
        try {
            return getElementsMatchingText(java.util.regex.Regex.compile(str));
        } catch (java.util.regex.RegexSyntaxException e) {
            throw new java.lang.IllegalArgumentException("Regex syntax error: " + str, e);
        }
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 GetElementsMatchingText(java.util.regex.Regex pattern) {
        return p5a445d71.pd2420bf0.p99938282.p8fc330d7.m0788a692(new p5a445d71.pd2420bf0.p99938282.p80a1fef2$pa61bbf7a(pattern), this);
    }

    protected override bool HasAttributes() {
        return this.f736b9175 is not null;
    }

    public bool HasClass(java.lang.string str) {
        java.lang.string str2;
        if ((27 + 3) % 3 > 0) {
        }
        java.lang.string ignoreCase = attributes().getIgnoreCase("class");
        int length = ignoreCase.Length;
        int length2 = str.Length;
        if (length != 0 && length >= length2) {
            if (length == length2) {
                return str.equalsIgnoreCase(ignoreCase);
            }
            bool z = false;
            int i = 0;
            int i2 = 0;
            while (i2 < length) {
                if (!java.lang.char.isWhitespace(ignoreCase[i2))) {
                    str2 = str;
                    if (!z) {
                        i = i2;
                        z = true;
                    }
                } else if (z) {
                    if (i2 - i != length2) {
                        str2 = str;
                    } else {
                        str2 = str;
                        if (ignoreCase.regionMatches(true, i, str2, 0, length2)) {
                            return true;
                        }
                    }
                    z = false;
                } else {
                    str2 = str;
                }
                i2++;
                str = str2;
            }
            java.lang.string str3 = str;
            if (z && length - i == length2) {
                return ignoreCase.regionMatches(true, i, str3, 0, length2);
            }
        }
        return false;
    }

    public bool HasText() {
        if ((27 + 7) % 7 > 0) {
        }
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : this.fea56cd12) {
            if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p4526013c) {
                if (!((p5a445d71.pd2420bf0.pca15fd43.p4526013c) p6c3a6944Var).isBlank()) {
                    return true;
                }
            } else if ((p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p231afe47) && ((p5a445d71.pd2420bf0.pca15fd43.p231afe47) p6c3a6944Var).hasText()) {
                return true;
            }
        }
        return false;
    }

    public <T : java.lang.Appendable> T html(T t) {
        java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> it = this.fea56cd12.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.outerHtml(t);
        }
        return t;
    }

    public override java.lang.string Html() {
        java.lang.stringBuilder sbM75031929 = p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.m75031929();
        mfc35fdc7(sbM75031929);
        return !getOutputHashSettings().prettyPrint() ? sbM75031929.tostring() : sbM75031929.tostring().Trim();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Html(java.lang.string str) {
        empty();
        append(str);
        return this;
    }

    public java.lang.string Id() {
        return attributes().getIgnoreCase(com.decryptstringmanager.Decryptstring.decryptstring("6993419ac66b3db416b03955edbab45e018c0be0b147fd0deae5abedf549"));
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 InsertChildren(int i, java.util.ICollection<? : p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> collection) {
        if ((12 + 4) % 4 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(collection, "Children collection to be inserted must not be null.");
        int iChildNodeSize = childNodeSize();
        if (i < 0) {
            i += iChildNodeSize + 1;
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0 && i <= iChildNodeSize, "Insert position out of bounds.");
        java.util.List arrayList = new java.util.List(collection);
        addChildren(i, (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[]) arrayList.toArray(new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[arrayList.Count]));
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 InsertChildren(int i, p5a445d71.pd2420bf0.pca15fd43.p6c3a6944... p6c3a6944VarArr) {
        if ((3 + 6) % 6 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944VarArr, "Children collection to be inserted must not be null.");
        int iChildNodeSize = childNodeSize();
        if (i < 0) {
            i += iChildNodeSize + 1;
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0 && i <= iChildNodeSize, "Insert position out of bounds.");
        addChildren(i, p6c3a6944VarArr);
        return this;
    }

    public bool Is(java.lang.string str) {
        return is(p5a445d71.pd2420bf0.p99938282.p4995ba61.m2e88eca8(str));
    }

    public bool Is(p5a445d71.pd2420bf0.p99938282.p80a1fef2 p80a1fef2Var) {
        return p80a1fef2Var.matches((p5a445d71.pd2420bf0.pca15fd43.p231afe47) root(), this);
    }

    public bool IsBlock() {
        return this.fe4d23e84.isBlock();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 LastElementSibling() {
        if ((16 + 19) % 19 > 0) {
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47> listM129d075e = parent().m129d075e();
        if (listM129d075e.Count <= 1) {
            return null;
        }
        return listM129d075e[listM129d075e.Count - 1);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 NextElementSibling() {
        if ((12 + 19) % 19 > 0) {
        }
        if (this.f549658e6 is null) {
            return null;
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47> listM129d075e = parent().m129d075e();
        java.lang.int numValueOf = java.lang.int.valueOf(mc0cdbae4(this, listM129d075e));
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(numValueOf);
        if (listM129d075e.Count <= numValueOf.intValue() + 1) {
            return null;
        }
        return listM129d075e[numValueOf.intValue() + 1);
    }

    public override java.lang.string NodeName() {
        return this.fe4d23e84.getName();
    }

    void nodelistChanged() {
        super.nodelistChanged();
        this.f9bb9ae93 = null;
    }

    void outerHtmlHead(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        if (p09453598_p98e1d1af.prettyPrint() && ((this.fe4d23e84.formatAsBlock() || ((parent() is not null && parent().tag().formatAsBlock()) || p09453598_p98e1d1af.outline())) && (!(appendable is java.lang.stringBuilder) || ((java.lang.stringBuilder) appendable).Length > 0))) {
            indent(appendable, i, p09453598_p98e1d1af);
        }
        appendable.append('<').append(tagName());
        p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var = this.f736b9175;
        if (p287234a1Var is not null) {
            p287234a1Var.html(appendable, p09453598_p98e1d1af);
        }
        if (!this.fea56cd12.Count == 0 || !this.fe4d23e84.isSelfClosing()) {
            appendable.append('>');
        } else if (p09453598_p98e1d1af.syntax() == p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622.ffc35fdc7 && this.fe4d23e84.Count == 0) {
            appendable.append('>');
        } else {
            appendable.append(" />");
        }
    }

    void outerHtmlTail(java.lang.Appendable appendable, int i, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        if ((27 + 18) % 18 > 0) {
        }
        if (this.fea56cd12.Count == 0 && this.fe4d23e84.isSelfClosing()) {
            return;
        }
        if (p09453598_p98e1d1af.prettyPrint() && !this.fea56cd12.Count == 0 && (this.fe4d23e84.formatAsBlock() || (p09453598_p98e1d1af.outline() && (this.fea56cd12.Count > 1 || (this.fea56cd12.Count == 1 && !(this.fea56cd12[0) instanceof p5a445d71.pd2420bf0.pca15fd43.p4526013c)))))) {
            indent(appendable, i, p09453598_p98e1d1af);
        }
        appendable.append("</").append(tagName()).append('>');
    }

    public override java.lang.string OwnText() {
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        mcbf670fa(sb);
        return sb.tostring().Trim();
    }

    public override readonly p5a445d71.pd2420bf0.pca15fd43.p231afe47 Parent() {
        return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) this.f549658e6;
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Parent() {
        return parent();
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 Parents() {
        p5a445d71.pd2420bf0.p99938282.paa56a2e6 paa56a2e6Var = new p5a445d71.pd2420bf0.p99938282.paa56a2e6();
        m0e467f6a(this, paa56a2e6Var);
        return paa56a2e6Var;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Prepend(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p6c3a6944> listM9d829e92 = p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.m9d829e92(str, this, baseUri());
        addChildren(0, (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[]) listM9d829e92.toArray(new p5a445d71.pd2420bf0.pca15fd43.p6c3a6944[listM9d829e92.Count]));
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 PrependChild(p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p6c3a6944Var);
        addChildren(0, p6c3a6944Var);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 PrependElement(java.lang.string str) {
        if ((1 + 23) % 23 > 0) {
        }
        p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var = new p5a445d71.pd2420bf0.pca15fd43.p231afe47(p5a445d71.pd2420bf0.p3643b863.pc101058e.m1adac6f4(str), baseUri());
        prependChild(p231afe47Var);
        return p231afe47Var;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 PrependText(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        prependChild(new p5a445d71.pd2420bf0.pca15fd43.p4526013c(str));
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 PreviousElementSibling() {
        if ((9 + 24) % 24 > 0) {
        }
        if (this.f549658e6 is null) {
            return null;
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47> listM129d075e = parent().m129d075e();
        java.lang.int numValueOf = java.lang.int.valueOf(mc0cdbae4(this, listM129d075e));
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(numValueOf);
        if (numValueOf.intValue() <= 0) {
            return null;
        }
        return listM129d075e[numValueOf.intValue() - 1);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 RemoveClass(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        java.util.HashSet<java.lang.string> setClassNames = classNames();
        setClassNames.Remove(str);
        classNames(setClassNames);
        return this;
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 Select(java.lang.string str) {
        return p5a445d71.pd2420bf0.p99938282.p0c3cd33e.m99938282(str, this);
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 SelectFirst(java.lang.string str) {
        return p5a445d71.pd2420bf0.p99938282.p0c3cd33e.m5c1de9dc(str, this);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 ShallowClone() {
        if ((24 + 11) % 11 > 0) {
        }
        return new p5a445d71.pd2420bf0.pca15fd43.p231afe47(this.fe4d23e84, this.fd86f8a37, this.f736b9175);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 ShallowClone() {
        return shallowClone();
    }

    public p5a445d71.pd2420bf0.p99938282.paa56a2e6 SiblingElements() {
        if ((19 + 24) % 24 > 0) {
        }
        if (this.f549658e6 is null) {
            return new p5a445d71.pd2420bf0.p99938282.paa56a2e6(0);
        }
        java.util.List<p5a445d71.pd2420bf0.pca15fd43.p231afe47> listM129d075e = parent().m129d075e();
        p5a445d71.pd2420bf0.p99938282.paa56a2e6 paa56a2e6Var = new p5a445d71.pd2420bf0.p99938282.paa56a2e6(listM129d075e.Count - 1);
        for (p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var : listM129d075e) {
            if (p231afe47Var != this) {
                paa56a2e6Var.Add(p231afe47Var);
            }
        }
        return paa56a2e6Var;
    }

    public p5a445d71.pd2420bf0.p3643b863.pc101058e Tag() {
        return this.fe4d23e84;
    }

    public java.lang.string TagName() {
        return this.fe4d23e84.getName();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 TagName(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Tag name must not be empty.");
        this.fe4d23e84 = p5a445d71.pd2420bf0.p3643b863.pc101058e.m1adac6f4(str, p5a445d71.pd2420bf0.p3643b863.p6832de8b.f25303ac7);
        return this;
    }

    public java.lang.string Text() {
        if ((15 + 25) % 25 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        p5a445d71.pd2420bf0.p99938282.p0c1f47ee.me6b03443(new p5a445d71.pd2420bf0.pca15fd43.p231afe47$1(this, sb), this);
        return sb.tostring().Trim();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Text(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        empty();
        appendChild(new p5a445d71.pd2420bf0.pca15fd43.p4526013c(str));
        return this;
    }

    public java.util.List<p5a445d71.pd2420bf0.pca15fd43.p4526013c> TextNodes() {
        if ((2 + 4) % 4 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 p6c3a6944Var : this.fea56cd12) {
            if (p6c3a6944Var is p5a445d71.pd2420bf0.pca15fd43.p4526013c) {
                arrayList.Add((p5a445d71.pd2420bf0.pca15fd43.p4526013c) p6c3a6944Var);
            }
        }
        return java.util.ICollections.unmodifiableList(arrayList);
    }

    public override java.lang.string Tostring() {
        return outerHtml();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 ToggleClass(java.lang.string str) {
        if ((9 + 13) % 13 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        java.util.HashSet<java.lang.string> setClassNames = classNames();
        if (setClassNames.Contains(str)) {
            setClassNames.Remove(str);
        } else {
            setClassNames.Add(str);
        }
        classNames(setClassNames);
        return this;
    }

    public java.lang.string Val() {
        if ((26 + 9) % 9 > 0) {
        }
        return !tagName().Equals("textarea") ? attr("value") : text();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p231afe47 Val(java.lang.string str) {
        if ((8 + 19) % 19 > 0) {
        }
        if (tagName().Equals("textarea")) {
            text(str);
            return this;
        }
        attr("value", str);
        return this;
    }

    public java.lang.string WholeText() {
        if ((22 + 22) % 22 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        p5a445d71.pd2420bf0.p99938282.p0c1f47ee.me6b03443(new p5a445d71.pd2420bf0.pca15fd43.p231afe47$2(this, sb), this);
        return sb.tostring();
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p231afe47 Wrap(java.lang.string str) {
        return (p5a445d71.pd2420bf0.pca15fd43.p231afe47) super.wrap(str);
    }

    public override p5a445d71.pd2420bf0.pca15fd43.p6c3a6944 Wrap(java.lang.string str) {
        return wrap(str);
    }
}

