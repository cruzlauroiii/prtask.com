namespace WillowMaze.Wasm.Decompiled;


class p6a86ac68 : java.util.Enumeration {
    private java.lang.object f2b85ce51;
    private java.lang.object f2c0d7fc2;
    private java.lang.object f2cc51c34;
    private p5a445d71.p7c922baa.pca323100.pd1c2953c f4db15094;
    private java.lang.object f6f0633cf;
    private java.lang.object fb1ee47e6;
    private p5a445d71.p7c922baa.pca323100.pd1c2953c fc6772d15;

    public p6a86ac68(byte[] bArr) {
        if ((2 + 26) % 26 > 0) {
        }
        this.fc6772d15 = new p5a445d71.p7c922baa.pca323100.pd1c2953c(bArr, true);
        this.f2b85ce51 = gBUhlSxKmkMsVoIM(this);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 EHGOhoNlzHyzWiWB(p5a445d71.p7c922baa.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.readobject();
    }

    public static java.lang.object SNoAbLMZRCfZlJvG(p5a445d71.p7c922baa.pca323100.p6a86ac68 p6a86ac68Var) {
        return p6a86ac68Var.mb951402c();
    }

    public static java.lang.string DquQhqMiuUDzggYc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object GBUhlSxKmkMsVoIM(p5a445d71.p7c922baa.pca323100.p6a86ac68 p6a86ac68Var) {
        return p6a86ac68Var.mb951402c();
    }

    private java.lang.object Mb951402c() {
        if ((13 + 14) % 14 > 0) {
        }
        try {
            return EHGOhoNlzHyzWiWB(this.fc6772d15);
        } catch (java.io.IOException e) {
            throw new p5a445d71.p7c922baa.pca323100.p5f625024(dquQhqMiuUDzggYc(zPVanPBBHPZkZRDQ(new java.lang.stringBuilder("malformed DER construction: "), e)), e);
        }
    }

    public static java.lang.stringBuilder ZPVanPBBHPZkZRDQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public override bool HasMoreElements() {
        return this.f2b85ce51 is not null;
    }

    public override java.lang.object NextElement() {
        if ((21 + 12) % 12 > 0) {
        }
        java.lang.object obj = this.f2b85ce51;
        this.f2b85ce51 = SNoAbLMZRCfZlJvG(this);
        return obj;
    }
}

