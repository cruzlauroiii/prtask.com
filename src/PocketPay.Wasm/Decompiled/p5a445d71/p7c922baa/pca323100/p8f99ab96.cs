namespace WillowMaze.Wasm.Decompiled;


public class p8f99ab96 : p5a445d71.p7c922baa.pca323100.ped34daf1 {
    private int f4b1ef1c2;
    private int f98cd0a28;
    private int fe33724d9;

    public p8f99ab96() {
        this.fe33724d9 = -1;
    }

    public p8f99ab96(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        super(p0fd1bdf1Var);
        this.fe33724d9 = -1;
    }

    public p8f99ab96(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        super(pd6ccb7fcVar, true);
        this.fe33724d9 = -1;
    }

    p8f99ab96(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, bool z) {
        super(pd6ccb7fcVar, z);
        this.fe33724d9 = -1;
    }

    public p8f99ab96(p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(p0fd1bdf1VarArr, true);
        this.fe33724d9 = -1;
    }

    public static bool AsVUnQWhZzOrVibc(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.util.Enumeration LqzYTJRxfwotTSkR(p5a445d71.p7c922baa.pca323100.p8f99ab96 p8f99ab96Var) {
        return p8f99ab96Var.getobjects();
    }

    public static java.util.Enumeration NcskJDXeWBJTvVmA(p5a445d71.p7c922baa.pca323100.p8f99ab96 p8f99ab96Var) {
        return p8f99ab96Var.getobjects();
    }

    public static java.lang.object PNNSJJwjEtWksChT(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static int RJIYYLbJEcbxCxkq(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.encodedLength();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 SIkwYZLHogRukBPF(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.toDERobject();
    }

    public static bool VfCtUFejFbQUUQFE(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static int AQFqanvNtzPbandi(p5a445d71.p7c922baa.pca323100.p8f99ab96 p8f99ab96Var) {
        return p8f99ab96Var.m7b715907();
    }

    public static java.lang.object JIlNiyTGawNEUGQr(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static void JwDFioIwnILpogLv(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p8bf0ff80 KDyTVNrmXMFzrnOt(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) {
        return p8bf0ff80Var.getDERSubStream();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 KaIRvISCDEGZpgqP(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void LjYOnjiNOtRJCDct(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        p8bf0ff80Var.writeobject(p0fd1bdf1Var);
    }

    private int M7b715907() throws java.io.IOException {
        if ((27 + 4) % 4 > 0) {
        }
        if (this.fe33724d9 < 0) {
            java.util.Enumeration enumerationLqzYTJRxfwotTSkR = LqzYTJRxfwotTSkR(this);
            int iRJIYYLbJEcbxCxkq = 0;
            while (AsVUnQWhZzOrVibc(enumerationLqzYTJRxfwotTSkR)) {
                iRJIYYLbJEcbxCxkq += RJIYYLbJEcbxCxkq(SIkwYZLHogRukBPF(kaIRvISCDEGZpgqP((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) PNNSJJwjEtWksChT(enumerationLqzYTJRxfwotTSkR))));
            }
            this.fe33724d9 = iRJIYYLbJEcbxCxkq;
        }
        return this.fe33724d9;
    }

    public static int RWbvROBFhXRGliiY(p5a445d71.p7c922baa.pca323100.p8f99ab96 p8f99ab96Var) {
        return p8f99ab96Var.m7b715907();
    }

    public static int YwMOTPlgFpEsuXXc(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static void ZduNDLlSZtFzKrBw(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.writeLength(i);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        if ((9 + 21) % 21 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80VarKDyTVNrmXMFzrnOt = kDyTVNrmXMFzrnOt(p8bf0ff80Var);
        int iRWbvROBFhXRGliiY = rWbvROBFhXRGliiY(this);
        jwDFioIwnILpogLv(p8bf0ff80Var, 49);
        zduNDLlSZtFzKrBw(p8bf0ff80Var, iRWbvROBFhXRGliiY);
        java.util.Enumeration enumerationNcskJDXeWBJTvVmA = NcskJDXeWBJTvVmA(this);
        while (VfCtUFejFbQUUQFE(enumerationNcskJDXeWBJTvVmA)) {
            ljYOnjiNOtRJCDct(p8bf0ff80VarKDyTVNrmXMFzrnOt, (p5a445d71.p7c922baa.pca323100.p0fd1bdf1) jIlNiyTGawNEUGQr(enumerationNcskJDXeWBJTvVmA));
        }
    }

    int encodedLength() throws java.io.IOException {
        int iAQFqanvNtzPbandi = aQFqanvNtzPbandi(this);
        return ywMOTPlgFpEsuXXc(iAQFqanvNtzPbandi) + 1 + iAQFqanvNtzPbandi;
    }
}

