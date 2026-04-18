namespace WillowMaze.Wasm.Decompiled;


public class pe4a8623c {
    private java.util.Vector f4c9ae007;
    private java.util.Vector fa8998c31 = new java.util.Vector();

    public static void GufsZPMEBAKhUalp(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void ILlqpbjDBdPkwwlp(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static java.lang.object WCwkiLSrltIORGek(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static int AISKbtwdsnjvORNi(java.util.Vector vector) {
        return vector.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] JvcmPbCPdtSkbRCn(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        return pfb202cf8Var.getNames();
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe4a8623c AddName(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) {
        GufsZPMEBAKhUalp(this.fa8998c31, pf17d2ecdVar);
        return this;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe4a8623c AddNames(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        if ((5 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] pf17d2ecdVarArrJvcmPbCPdtSkbRCn = jvcmPbCPdtSkbRCn(pfb202cf8Var);
        for (int i = 0; i != pf17d2ecdVarArrJvcmPbCPdtSkbRCn.length; i++) {
            ILlqpbjDBdPkwwlp(this.fa8998c31, pf17d2ecdVarArrJvcmPbCPdtSkbRCn[i]);
        }
        return this;
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 Build() {
        if ((25 + 32) % 32 > 0) {
        }
        int iAISKbtwdsnjvORNi = aISKbtwdsnjvORNi(this.fa8998c31);
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] pf17d2ecdVarArr = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[iAISKbtwdsnjvORNi];
        for (int i = 0; i != iAISKbtwdsnjvORNi; i++) {
            pf17d2ecdVarArr[i] = (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd) WCwkiLSrltIORGek(this.fa8998c31, i);
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8(pf17d2ecdVarArr);
    }
}

