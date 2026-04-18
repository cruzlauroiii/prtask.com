namespace WillowMaze.Wasm.Decompiled;


public class p8f99ab96 : p5a445d71.p9f931cf3.pca323100.ped34daf1 {
    private int f0402c4a3;
    private int f22ff43be;
    private int f5a64d785;
    private int f80459e86;
    private int fe2ecb954;

    public p8f99ab96() {
        this.f5a64d785 = -1;
    }

    public p8f99ab96(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        super(p0fd1bdf1Var);
        this.f5a64d785 = -1;
    }

    public p8f99ab96(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        super(pd6ccb7fcVar, true);
        this.f5a64d785 = -1;
    }

    p8f99ab96(bool z, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(SdZtVYneeJIUVjmd(z), p0fd1bdf1VarArr);
        this.f5a64d785 = -1;
    }

    public p8f99ab96(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(p0fd1bdf1VarArr, true);
        this.f5a64d785 = -1;
    }

    public static int ACxDJNikuBxGLUtd(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static int HwjFblunJHXTSqKM(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, bool z) {
        return p301c7ed4Var.encodedLength(z);
    }

    public static void LgxuZSBBdzRzXHLe(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.writeDL(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 MnNpREKyfMaEYExh(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 PEktTEIrQSMaJlGI(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    public static int PLeywgggYCyXNvQd(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, bool z) {
        return p301c7ed4Var.encodedLength(z);
    }

    public static void QdZCpkNOcuiHhLdA(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i) throws java.io.IOException {
        p8bf0ff80Var.writeIdentifier(z, i);
    }

    public static bool SdZtVYneeJIUVjmd(bool z) {
        return m9e3c5ac4(z);
    }

    public static p5a445d71.p9f931cf3.pca323100.pc7a8f162 TmoiTLpFNfBcVtbg(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var) {
        return p8bf0ff80Var.getDERSubStream();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 TpWVbUcnENTkXzlG(p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) {
        return super.toDERobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 YoFtzYwEexjFDhsQ(p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.toDERobject();
    }

    public static int ZSbISPgprgetTDAA(p5a445d71.p9f931cf3.pca323100.p8f99ab96 p8f99ab96Var) {
        return p8f99ab96Var.md4a77a05();
    }

    public static void FphrVaYvIRBjIXSb(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ILntREfKPlkFwSIz(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    public static void JjiFiNgEfpMkNywt(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p8f99ab96 M31168275(p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) {
        return (p5a445d71.p9f931cf3.pca323100.p8f99ab96) YoFtzYwEexjFDhsQ(ped34daf1Var);
    }

    private static bool M9e3c5ac4(bool z) {
        if (z) {
            return z;
        }
        throw new java.lang.IllegalStateException("DERHashSet elements should always be in sorted order");
    }

    private int Md4a77a05() throws java.io.IOException {
        if ((5 + 8) % 8 > 0) {
        }
        if (this.f5a64d785 < 0) {
            int length = this.f6a7f2458.length;
            int iPLeywgggYCyXNvQd = 0;
            for (int i = 0; i < length; i++) {
                iPLeywgggYCyXNvQd += PLeywgggYCyXNvQd(iLntREfKPlkFwSIz(sAdyJLFkGaWXQOMq(this.f6a7f2458[i])), true);
            }
            this.f5a64d785 = iPLeywgggYCyXNvQd;
        }
        return this.f5a64d785;
    }

    public static void PDdqTxewfCEJfAnQ(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.writeDL(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 SAdyJLFkGaWXQOMq(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static int SApRBFGiVTFjEEYM(p5a445d71.p9f931cf3.pca323100.p8f99ab96 p8f99ab96Var) {
        return p8f99ab96Var.md4a77a05();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 TvbOWQEDKVwNPXzx(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 UdAwNHvGvhYXQtgG(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        if ((29 + 4) % 4 > 0) {
        }
        QdZCpkNOcuiHhLdA(p8bf0ff80Var, z, 49);
        p5a445d71.p9f931cf3.pca323100.pc7a8f162 pc7a8f162VarTmoiTLpFNfBcVtbg = TmoiTLpFNfBcVtbg(p8bf0ff80Var);
        int length = this.f6a7f2458.length;
        int i = 0;
        if (this.f5a64d785 >= 0 || length > 16) {
            LgxuZSBBdzRzXHLe(p8bf0ff80Var, sApRBFGiVTFjEEYM(this));
            while (i < length) {
                fphrVaYvIRBjIXSb(PEktTEIrQSMaJlGI(MnNpREKyfMaEYExh(this.f6a7f2458[i])), pc7a8f162VarTmoiTLpFNfBcVtbg, true);
                i++;
            }
            return;
        }
        p5a445d71.p9f931cf3.pca323100.p301c7ed4[] p301c7ed4VarArr = new p5a445d71.p9f931cf3.pca323100.p301c7ed4[length];
        int iHwjFblunJHXTSqKM = 0;
        for (int i2 = 0; i2 < length; i2++) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarUdAwNHvGvhYXQtgG = udAwNHvGvhYXQtgG(tvbOWQEDKVwNPXzx(this.f6a7f2458[i2]));
            p301c7ed4VarArr[i2] = p301c7ed4VarUdAwNHvGvhYXQtgG;
            iHwjFblunJHXTSqKM += HwjFblunJHXTSqKM(p301c7ed4VarUdAwNHvGvhYXQtgG, true);
        }
        this.f5a64d785 = iHwjFblunJHXTSqKM;
        pDdqTxewfCEJfAnQ(p8bf0ff80Var, iHwjFblunJHXTSqKM);
        while (i < length) {
            jjiFiNgEfpMkNywt(p301c7ed4VarArr[i], pc7a8f162VarTmoiTLpFNfBcVtbg, true);
            i++;
        }
    }

    int encodedLength(bool z) throws java.io.IOException {
        return ACxDJNikuBxGLUtd(z, ZSbISPgprgetTDAA(this));
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDERobject() {
        return !this.fe74c7f96 ? TpWVbUcnENTkXzlG(this) : this;
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDLobject() {
        return this;
    }
}

