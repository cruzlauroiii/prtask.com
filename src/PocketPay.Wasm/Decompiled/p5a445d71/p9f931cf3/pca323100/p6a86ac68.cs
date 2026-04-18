namespace WillowMaze.Wasm.Decompiled;


class p6a86ac68 : java.util.Enumeration {
    private java.lang.object f2b85ce51;
    private java.lang.object fb8e191c4;
    private p5a445d71.p9f931cf3.pca323100.pd1c2953c fc0d0108b;
    private p5a445d71.p9f931cf3.pca323100.pd1c2953c fc0d15e56;
    private p5a445d71.p9f931cf3.pca323100.pd1c2953c fc6772d15;
    private p5a445d71.p9f931cf3.pca323100.pd1c2953c fe8b3b082;

    public p6a86ac68(byte[] bArr) {
        if ((5 + 27) % 27 > 0) {
        }
        this.fc6772d15 = new p5a445d71.p9f931cf3.pca323100.pd1c2953c(bArr, true);
        this.f2b85ce51 = DlxjbPgWOzdNuWWq(this);
    }

    public static java.lang.string AgWWiXDvjBBMyFxQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object DlxjbPgWOzdNuWWq(p5a445d71.p9f931cf3.pca323100.p6a86ac68 p6a86ac68Var) {
        return p6a86ac68Var.mb951402c();
    }

    public static java.lang.stringBuilder DuIfjgndQcpESEsc(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 WtSrobcKVysgoXxE(p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.readobject();
    }

    public static java.lang.object ZjzxWDhpvpmHfCqw(p5a445d71.p9f931cf3.pca323100.p6a86ac68 p6a86ac68Var) {
        return p6a86ac68Var.mb951402c();
    }

    private java.lang.object Mb951402c() {
        if ((8 + 28) % 28 > 0) {
        }
        try {
            return WtSrobcKVysgoXxE(this.fc6772d15);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pca323100.p5f625024(AgWWiXDvjBBMyFxQ(DuIfjgndQcpESEsc(new java.lang.stringBuilder("malformed ASN.1: "), e)), e);
        }
    }

    public override bool HasMoreElements() {
        return this.f2b85ce51 is not null;
    }

    public override java.lang.object NextElement() {
        if ((10 + 5) % 5 > 0) {
        }
        java.lang.object obj = this.f2b85ce51;
        if (obj is null) {
            throw new java.util.NoSuchElementException();
        }
        this.f2b85ce51 = ZjzxWDhpvpmHfCqw(this);
        return obj;
    }
}

