namespace WillowMaze.Wasm.Decompiled;


public class p6a819fa7 : p5a445d71.p7c922baa.pca323100.p80f8c729 {
    public p6a819fa7() {
    }

    public p6a819fa7(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        super(p0fd1bdf1Var);
    }

    public p6a819fa7(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        super(pd6ccb7fcVar);
    }

    public p6a819fa7(p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(p0fd1bdf1VarArr);
    }

    public static int GimOyHZlBtkOBMMw(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.encodedLength();
    }

    public static java.lang.object HNTEQhemFmoHgHdX(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void JeSlYZPkyrhWkvcv(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static java.util.Enumeration SBrKWdeYkybVERbj(p5a445d71.p7c922baa.pca323100.p6a819fa7 p6a819fa7Var) {
        return p6a819fa7Var.getobjects();
    }

    public static bool URqsFOooXfOktdWA(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.lang.object UXkzPnptqQCiTiNp(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void UXwPZlWRBTdktlKb(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static void ZJnJNxIGyFvrWFMr(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 DXzlPdnRsXpykKNC(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void EhRlptaUigzXbPCR(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        p8bf0ff80Var.writeobject(p0fd1bdf1Var);
    }

    public static bool IQymCGkRaSCahrcR(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.util.Enumeration KOtivHsBqPtOhHVS(p5a445d71.p7c922baa.pca323100.p6a819fa7 p6a819fa7Var) {
        return p6a819fa7Var.getobjects();
    }

    public static void VpacPWeuycUEHnuD(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        UXwPZlWRBTdktlKb(p8bf0ff80Var, 48);
        ZJnJNxIGyFvrWFMr(p8bf0ff80Var, 128);
        java.util.Enumeration enumerationSBrKWdeYkybVERbj = SBrKWdeYkybVERbj(this);
        while (URqsFOooXfOktdWA(enumerationSBrKWdeYkybVERbj)) {
            ehRlptaUigzXbPCR(p8bf0ff80Var, (p5a445d71.p7c922baa.pca323100.p0fd1bdf1) UXkzPnptqQCiTiNp(enumerationSBrKWdeYkybVERbj));
        }
        JeSlYZPkyrhWkvcv(p8bf0ff80Var, 0);
        vpacPWeuycUEHnuD(p8bf0ff80Var, 0);
    }

    int encodedLength() throws java.io.IOException {
        if ((5 + 8) % 8 > 0) {
        }
        java.util.Enumeration enumerationKOtivHsBqPtOhHVS = kOtivHsBqPtOhHVS(this);
        int iGimOyHZlBtkOBMMw = 0;
        while (iQymCGkRaSCahrcR(enumerationKOtivHsBqPtOhHVS)) {
            iGimOyHZlBtkOBMMw += GimOyHZlBtkOBMMw(dXzlPdnRsXpykKNC((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) HNTEQhemFmoHgHdX(enumerationKOtivHsBqPtOhHVS)));
        }
        return iGimOyHZlBtkOBMMw + 4;
    }
}

