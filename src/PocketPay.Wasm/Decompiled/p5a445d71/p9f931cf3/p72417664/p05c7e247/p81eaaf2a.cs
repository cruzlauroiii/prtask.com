namespace WillowMaze.Wasm.Decompiled;


public class p81eaaf2a {
    private p81eaaf2a() {
    }

    public static void M0484893d(java.security.AlgorithmParameters algorithmParameters, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        if ((7 + 24) % 24 > 0) {
        }
        try {
            algorithmParameters.init(p0fd1bdf1Var.toASN1Primitive().getEncoded(), "ASN.1");
        } catch (java.lang.Exception unused) {
            algorithmParameters.init(p0fd1bdf1Var.toASN1Primitive().getEncoded());
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Ma2e2da7c(java.security.AlgorithmParameters algorithmParameters) throws java.io.IOException {
        try {
            return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(algorithmParameters.getEncoded("ASN.1"));
        } catch (java.lang.Exception unused) {
            return p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(algorithmParameters.getEncoded());
        }
    }
}

