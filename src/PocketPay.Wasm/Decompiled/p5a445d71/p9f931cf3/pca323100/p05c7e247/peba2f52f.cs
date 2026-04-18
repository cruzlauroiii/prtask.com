namespace WillowMaze.Wasm.Decompiled;


public class peba2f52f {
    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 NrvIigZDYDDIzjZm(p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.readobject();
    }

    public static java.lang.string IbPRrhUyDVUDuWMV(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p05c7e247.p3d470894.ma30a895b(obj);
    }

    public static void Mfad58de7(java.lang.string[] strArr) throws java.lang.Exception {
        if ((12 + 8) % 8 > 0) {
        }
        java.io.stringStream fileStream = new java.io.stringStream(strArr[0]);
        p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar = new p5a445d71.p9f931cf3.pca323100.pd1c2953c(fileStream);
        while (true) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarNrvIigZDYDDIzjZm = NrvIigZDYDDIzjZm(pd1c2953cVar);
            if (p301c7ed4VarNrvIigZDYDDIzjZm is null) {
                uzgWHJmiBrzkQxUo(fileStream);
                return;
            }
            suCJAtTnHgFqRmZO(java.lang.System.out, ibPRrhUyDVUDuWMV(p301c7ed4VarNrvIigZDYDDIzjZm));
        }
    }

    public static void SuCJAtTnHgFqRmZO(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static void UzgWHJmiBrzkQxUo(java.io.stringStream fileStream) throws java.io.IOException {
        fileStream.Dispose();
    }
}

