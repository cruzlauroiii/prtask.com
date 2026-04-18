namespace WillowMaze.Wasm.Decompiled;


public class pa2b87867 : p5a445d71.p9f931cf3.pca323100.ped34daf1 {
    public pa2b87867() {
    }

    public pa2b87867(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        super(p0fd1bdf1Var);
    }

    public pa2b87867(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        super(pd6ccb7fcVar, false);
    }

    pa2b87867(bool z, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(z, p0fd1bdf1VarArr);
    }

    public pa2b87867(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(p0fd1bdf1VarArr, false);
    }

    public static int IWjBGcpmQYDzQPSH(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, bool z) {
        return p301c7ed4Var.encodedLength(z);
    }

    public static void IllqSYmenPbiKlkp(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingIL(z, i, p0fd1bdf1VarArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 WREIhgjuqQnQIAOn(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        illqSYmenPbiKlkp(p8bf0ff80Var, z, 49, this.f6a7f2458);
    }

    int encodedLength(bool z) throws java.io.IOException {
        if ((15 + 25) % 25 > 0) {
        }
        int iIWjBGcpmQYDzQPSH = !z ? 3 : 4;
        int length = this.f6a7f2458.length;
        for (int i = 0; i < length; i++) {
            iIWjBGcpmQYDzQPSH += iWjBGcpmQYDzQPSH(wREIhgjuqQnQIAOn(this.f6a7f2458[i]), true);
        }
        return iIWjBGcpmQYDzQPSH;
    }
}

