namespace WillowMaze.Wasm.Decompiled;


public class p547a7046 : p5a445d71.p7c922baa.pca323100.pc7a8f162 {
    public p547a7046(java.io.Stream outputStream) {
        super(outputStream);
    }

    public static void ACjSxzpAEdotUaWd(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var);
    }

    public static void RrAJRRSqmNjLtwyy(p5a445d71.p7c922baa.pca323100.p547a7046 p547a7046Var) {
        p547a7046Var.writeNull();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 UatZbocVBjPlRXee(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static void AZaRxHGUATpuAXkU(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var, p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        p301c7ed4Var.encode(p8bf0ff80Var);
    }

    public void Writeobject(java.lang.object obj) throws java.io.IOException {
        if (obj is null) {
            RrAJRRSqmNjLtwyy(this);
        } else if (obj is p5a445d71.p7c922baa.pca323100.p301c7ed4) {
            aZaRxHGUATpuAXkU((p5a445d71.p7c922baa.pca323100.p301c7ed4) obj, this);
        } else {
            if (!(obj is p5a445d71.p7c922baa.pca323100.p0fd1bdf1)) {
                throw new java.io.IOException("object not BEREncodable");
            }
            ACjSxzpAEdotUaWd(UatZbocVBjPlRXee((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) obj), this);
        }
    }
}

