namespace WillowMaze.Wasm.Decompiled;


public class pd6ccb7fc {
    private readonly java.util.Vector f8f044a96;
    private readonly java.util.Vector f9e3669d1 = new java.util.Vector();

    public static java.lang.object FtrKjrlGztqlHGBL(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static void NKHogHeVIjugBikF(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static java.lang.object RELbzEmGqKPWPdpx(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.util.Enumeration XSDjGYUVWpbrlmaM(java.util.Vector vector) {
        return vector.elements();
    }

    public static void ZlazNjKPltCyNFyx(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static bool KwhGUGIqpvRIBYss(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static int VbVFPYlELuEjXZOx(java.util.Vector vector) {
        return vector.Count;
    }

    public void Add(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        NKHogHeVIjugBikF(this.f9e3669d1, p0fd1bdf1Var);
    }

    public void AddAll(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        if ((31 + 17) % 17 > 0) {
        }
        java.util.Enumeration enumerationXSDjGYUVWpbrlmaM = XSDjGYUVWpbrlmaM(pd6ccb7fcVar.f9e3669d1);
        while (kwhGUGIqpvRIBYss(enumerationXSDjGYUVWpbrlmaM)) {
            ZlazNjKPltCyNFyx(this.f9e3669d1, RELbzEmGqKPWPdpx(enumerationXSDjGYUVWpbrlmaM));
        }
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Get(int i) {
        return (p5a445d71.p7c922baa.pca323100.p0fd1bdf1) FtrKjrlGztqlHGBL(this.f9e3669d1, i);
    }

    public int Size() {
        return vbVFPYlELuEjXZOx(this.f9e3669d1);
    }
}

