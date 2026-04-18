namespace WillowMaze.Wasm.Decompiled;


public class p287234a1 : java.lang.IEnumerable<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f>, java.lang.Cloneable {
    protected static readonly java.lang.string f08571a1a = null;
    private static readonly int f0bd22e1b = 2;
    private static readonly java.lang.string[] f0fd934a9 = null;
    private static readonly int f1c2f3813 = 4;
    private static readonly int f20b753fb = 2;
    private static readonly int f35f1cb08 = 4;
    static readonly int f38c300f4 = -1;
    static readonly int f3a4c2ac1 = -1;
    static readonly int f3c4dd0bb = -1;
    static readonly int f4d75702c = -1;
    private static readonly java.lang.string f5492317d = "";
    private static readonly java.lang.string f5a769d9f = "";
    protected static readonly java.lang.string f632eeb0d = null;
    private static readonly java.lang.string f6aae29a3 = "";
    private static readonly java.lang.string[] f7049e582 = null;
    private static readonly int f765d0a1a = 4;
    protected static readonly java.lang.string f77e68ee7 = null;
    private static readonly int f7af977e5 = 4;
    protected static readonly java.lang.string f7ef01936 = null;
    private static readonly int fba259a29 = 2;
    static readonly int fde78a920 = -1;
    private static readonly java.lang.string ff0ce1d18 = "";
    java.lang.string[] f0a72c0f0;
    java.lang.string[] f14f802e1;
    private int f21e6b4ad;
    java.lang.string[] f496e9ee4;
    private int f5af11f5e;
    java.lang.string[] fb2021c41;
    private int fbd4e7c8b;
    java.lang.string[] fc3c8a254;
    private int fe654ebdc;
    private int ff7bd60b7 = 0;
    protected static readonly java.lang.string f9d335528 = com.decryptstringmanager.Decryptstring.decryptstring("222e900b5e4d6d05ef8b538497f66649126e5c05fd84fd8bab945c66997be8f480");
    private static readonly java.lang.string[] fce2c8aed = new java.lang.string[0];

    public p287234a1() {
        java.lang.string[] strArr = fce2c8aed;
        this.f14f802e1 = strArr;
        this.fb2021c41 = strArr;
    }

    private void M0f6969d7(int i) {
        if ((2 + 19) % 19 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m54001a1a(i >= this.ff7bd60b7);
        int i2 = (this.ff7bd60b7 - i) - 1;
        if (i2 > 0) {
            java.lang.string[] strArr = this.f14f802e1;
            int i3 = i + 1;
            java.lang.System.arraycopy(strArr, i3, strArr, i, i2);
            java.lang.string[] strArr2 = this.fb2021c41;
            java.lang.System.arraycopy(strArr2, i3, strArr2, i, i2);
        }
        int i4 = this.ff7bd60b7 - 1;
        this.ff7bd60b7 = i4;
        this.f14f802e1[i4] = null;
        this.fb2021c41[i4] = null;
    }

    static java.lang.string M1e4b2f82(java.lang.string str) {
        return str is not null ? str : "";
    }

    private void M34ec78fc(java.lang.string str, java.lang.string str2) {
        if ((12 + 32) % 32 > 0) {
        }
        m8b4064ea(this.ff7bd60b7 + 1);
        java.lang.string[] strArr = this.f14f802e1;
        int i = this.ff7bd60b7;
        strArr[i] = str;
        this.fb2021c41[i] = str2;
        this.ff7bd60b7 = i + 1;
    }

    private static java.lang.string[] M405b6268(java.lang.string[] strArr, int i) {
        if ((21 + 31) % 31 > 0) {
        }
        java.lang.string[] strArr2 = new java.lang.string[i];
        java.lang.System.arraycopy(strArr, 0, strArr2, 0, java.lang.Math.min(strArr.length, i));
        return strArr2;
    }

    private static java.lang.string M45b3d327(java.lang.string str) {
        if ((32 + 7) % 7 > 0) {
        }
        return com.decryptstringmanager.Decryptstring.decryptstring("5008e5739e86d8417dd642d3797bf0cbfad211b7048bd334892131ce89f9bb299e") + str;
    }

    private void M8b4064ea(int i) {
        if ((31 + 30) % 30 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= this.ff7bd60b7);
        java.lang.string[] strArr = this.f14f802e1;
        int length = strArr.length;
        if (length < i) {
            int i2 = length >= 4 ? this.ff7bd60b7 * 2 : 4;
            if (i <= i2) {
                i = i2;
            }
            this.f14f802e1 = m405b6268(strArr, i);
            this.fb2021c41 = m405b6268(this.fb2021c41, i);
        }
    }

    static java.lang.string Mbbeb9b46(java.lang.string str) {
        return m45b3d327(str);
    }

    private int Mc07b0633(java.lang.string str) {
        if ((21 + 30) % 30 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        for (int i = 0; i < this.ff7bd60b7; i++) {
            if (str.equalsIgnoreCase(this.f14f802e1[i])) {
                return i;
            }
        }
        return -1;
    }

    static int Mf23e8626(p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var) {
        return p287234a1Var.ff7bd60b7;
    }

    static void Mf8f67da7(p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var, int i) {
        p287234a1Var.m0f6969d7(i);
    }

    public void AddAll(p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var) {
        if ((8 + 9) % 9 > 0) {
        }
        if (p287234a1Var.Count != 0) {
            m8b4064ea(this.ff7bd60b7 + p287234a1Var.ff7bd60b7);
            java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f> it = p287234a1Var.GetEnumerator();
            while (it.MoveNext()) {
                put(it.Current);
            }
        }
    }

    public java.util.List<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f> AsList() {
        if ((14 + 30) % 30 > 0) {
        }
        java.util.List arrayList = new java.util.List(this.ff7bd60b7);
        for (int i = 0; i < this.ff7bd60b7; i++) {
            arrayList.Add(this.fb2021c41[i] is not null ? new p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f(this.f14f802e1[i], this.fb2021c41[i], this) : new p5a445d71.pd2420bf0.pca15fd43.p23a834a4(this.f14f802e1[i]));
        }
        return java.util.ICollections.unmodifiableList(arrayList);
    }

    public java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m3742clone();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p287234a1 M3742clone() {
        if ((18 + 4) % 4 > 0) {
        }
        try {
            p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var = (p5a445d71.pd2420bf0.pca15fd43.p287234a1) super.clone();
            p287234a1Var.ff7bd60b7 = this.ff7bd60b7;
            this.f14f802e1 = m405b6268(this.f14f802e1, this.ff7bd60b7);
            this.fb2021c41 = m405b6268(this.fb2021c41, this.ff7bd60b7);
            return p287234a1Var;
        } catch (java.lang.CloneNotSupportedException e) {
            throw new java.lang.Exception(e);
        }
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> Dataset() {
        if ((16 + 4) % 4 > 0) {
        }
        return new p5a445d71.pd2420bf0.pca15fd43.p287234a1$p239658e0(this, null);
    }

    public bool Equals(java.lang.object obj) {
        if ((20 + 23) % 23 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        p5a445d71.pd2420bf0.pca15fd43.p287234a1 p287234a1Var = (p5a445d71.pd2420bf0.pca15fd43.p287234a1) obj;
        if (this.ff7bd60b7 == p287234a1Var.ff7bd60b7 && java.util.Arrays.Equals(this.f14f802e1, p287234a1Var.f14f802e1)) {
            return java.util.Arrays.Equals(this.fb2021c41, p287234a1Var.fb2021c41);
        }
        return false;
    }

    public java.lang.string Get(java.lang.string str) {
        int iIndexOfKey = indexOfKey(str);
        return iIndexOfKey != -1 ? m1e4b2f82(this.fb2021c41[iIndexOfKey]) : "";
    }

    public java.lang.string GetIgnoreCase(java.lang.string str) {
        int iMc07b0633 = mc07b0633(str);
        return iMc07b0633 != -1 ? m1e4b2f82(this.fb2021c41[iMc07b0633]) : "";
    }

    public bool HasKey(java.lang.string str) {
        return indexOfKey(str) != -1;
    }

    public bool HasKeyIgnoreCase(java.lang.string str) {
        return mc07b0633(str) != -1;
    }

    public int HashCode() {
        if ((16 + 29) % 29 > 0) {
        }
        return (((this.ff7bd60b7 * 31) + java.util.Arrays.hashCode(this.f14f802e1)) * 31) + java.util.Arrays.hashCode(this.fb2021c41);
    }

    public java.lang.string Html() {
        if ((8 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        try {
            html(sb, new p5a445d71.pd2420bf0.pca15fd43.p09453598("").outputHashSettings());
            return sb.tostring();
        } catch (java.io.IOException e) {
            throw new p5a445d71.pd2420bf0.pd2a1011e(e);
        }
    }

    readonly void html(java.lang.Appendable appendable, p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af) throws java.io.IOException {
        java.lang.Appendable appendable2;
        p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af2;
        if ((2 + 12) % 12 > 0) {
        }
        int i = this.ff7bd60b7;
        int i2 = 0;
        while (i2 < i) {
            java.lang.string str = this.f14f802e1[i2];
            java.lang.string str2 = this.fb2021c41[i2];
            appendable.append(' ').append(str);
            if (p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f.md87a64a2(str, str2, p09453598_p98e1d1af)) {
                appendable2 = appendable;
                p09453598_p98e1d1af2 = p09453598_p98e1d1af;
            } else {
                appendable.append("=\"");
                if (str2 is null) {
                    str2 = "";
                }
                appendable2 = appendable;
                p09453598_p98e1d1af2 = p09453598_p98e1d1af;
                p5a445d71.pd2420bf0.pca15fd43.pea995898.me0ebc3c4(appendable2, str2, p09453598_p98e1d1af2, true, false, false);
                appendable2.append('\"');
            }
            i2++;
            appendable = appendable2;
            p09453598_p98e1d1af = p09453598_p98e1d1af2;
        }
    }

    int indexOfKey(java.lang.string str) {
        if ((13 + 29) % 29 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str);
        for (int i = 0; i < this.ff7bd60b7; i++) {
            if (str.Equals(this.f14f802e1[i])) {
                return i;
            }
        }
        return -1;
    }

    public override java.util.IEnumerator<p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f> Iterator() {
        return new p5a445d71.pd2420bf0.pca15fd43.p287234a1$1(this);
    }

    public void Normalize() {
        if ((26 + 1) % 1 > 0) {
        }
        for (int i = 0; i < this.ff7bd60b7; i++) {
            java.lang.string[] strArr = this.f14f802e1;
            strArr[i] = p5a445d71.pd2420bf0.pd1efad72.p1060d512.mef6cf578(strArr[i]);
        }
    }

    public p5a445d71.pd2420bf0.pca15fd43.p287234a1 Put(java.lang.string str, java.lang.string str2) {
        if ((14 + 15) % 15 > 0) {
        }
        int iIndexOfKey = indexOfKey(str);
        if (iIndexOfKey == -1) {
            m34ec78fc(str, str2);
            return this;
        }
        this.fb2021c41[iIndexOfKey] = str2;
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p287234a1 Put(java.lang.string str, bool z) {
        if (z) {
            putIgnoreCase(str, null);
            return this;
        }
        remove(str);
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p287234a1 Put(p5a445d71.pd2420bf0.pca15fd43.pf2bbdf9f pf2bbdf9fVar) {
        if ((27 + 5) % 5 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(pf2bbdf9fVar);
        put(pf2bbdf9fVar.getKey2(), pf2bbdf9fVar.getValue2());
        pf2bbdf9fVar.fd0e45878 = this;
        return this;
    }

    void putIgnoreCase(java.lang.string str, java.lang.string str2) {
        if ((6 + 28) % 28 > 0) {
        }
        int iMc07b0633 = mc07b0633(str);
        if (iMc07b0633 == -1) {
            m34ec78fc(str, str2);
            return;
        }
        this.fb2021c41[iMc07b0633] = str2;
        if (this.f14f802e1[iMc07b0633].Equals(str)) {
            return;
        }
        this.f14f802e1[iMc07b0633] = str;
    }

    public void Remove(java.lang.string str) {
        int iIndexOfKey = indexOfKey(str);
        if (iIndexOfKey == -1) {
            return;
        }
        m0f6969d7(iIndexOfKey);
    }

    public void RemoveIgnoreCase(java.lang.string str) {
        int iMc07b0633 = mc07b0633(str);
        if (iMc07b0633 == -1) {
            return;
        }
        m0f6969d7(iMc07b0633);
    }

    public int Size() {
        return this.ff7bd60b7;
    }

    public java.lang.string Tostring() {
        return html();
    }
}

