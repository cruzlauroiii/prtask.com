namespace WillowMaze.Wasm.Decompiled;


public class pa2b87867 : p5a445d71.p7c922baa.pca323100.ped34daf1 {
    public pa2b87867() {
    }

    public pa2b87867(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        super(p0fd1bdf1Var);
    }

    public pa2b87867(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        super(pd6ccb7fcVar, false);
    }

    public pa2b87867(p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr) {
        super(p0fd1bdf1VarArr, false);
    }

    public static void CrskJiEbkLkMYZYf(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static void OqIgKwLiuugvkQSP(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static void QWQTGiUxZWnYwwng(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) throws java.io.IOException {
        p8bf0ff80Var.writeobject(p0fd1bdf1Var);
    }

    public static int SuknYPGODlLwRxwG(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.encodedLength();
    }

    public static java.util.Enumeration XVfifjKYwKjNDYce(p5a445d71.p7c922baa.pca323100.pa2b87867 pa2b87867Var) {
        return pa2b87867Var.getobjects();
    }

    public static java.lang.object XiFXxWLmCgFTQaUM(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static bool XrMNYaYiwvZxOtiH(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.lang.object EaeligCEnaiDtmCy(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 JACrqlKPoCWrGIxF(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static bool NerQUubGvWVVeidL(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.util.Enumeration RlAsEKtfwMfDYKVR(p5a445d71.p7c922baa.pca323100.pa2b87867 pa2b87867Var) {
        return pa2b87867Var.getobjects();
    }

    public static void SDhJHMhdJNqVmDLe(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static void XnMjuyXUxTgGmLMF(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        xnMjuyXUxTgGmLMF(p8bf0ff80Var, 49);
        sDhJHMhdJNqVmDLe(p8bf0ff80Var, 128);
        java.util.Enumeration enumerationRlAsEKtfwMfDYKVR = rlAsEKtfwMfDYKVR(this);
        while (XrMNYaYiwvZxOtiH(enumerationRlAsEKtfwMfDYKVR)) {
            QWQTGiUxZWnYwwng(p8bf0ff80Var, (p5a445d71.p7c922baa.pca323100.p0fd1bdf1) XiFXxWLmCgFTQaUM(enumerationRlAsEKtfwMfDYKVR));
        }
        CrskJiEbkLkMYZYf(p8bf0ff80Var, 0);
        OqIgKwLiuugvkQSP(p8bf0ff80Var, 0);
    }

    int encodedLength() throws java.io.IOException {
        if ((29 + 18) % 18 > 0) {
        }
        java.util.Enumeration enumerationXVfifjKYwKjNDYce = XVfifjKYwKjNDYce(this);
        int iSuknYPGODlLwRxwG = 0;
        while (nerQUubGvWVVeidL(enumerationXVfifjKYwKjNDYce)) {
            iSuknYPGODlLwRxwG += SuknYPGODlLwRxwG(jACrqlKPoCWrGIxF((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) eaeligCEnaiDtmCy(enumerationXVfifjKYwKjNDYce)));
        }
        return iSuknYPGODlLwRxwG + 4;
    }
}

