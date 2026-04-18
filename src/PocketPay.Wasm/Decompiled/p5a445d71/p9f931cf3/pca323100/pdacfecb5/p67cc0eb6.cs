namespace WillowMaze.Wasm.Decompiled;


public class p67cc0eb6 {
    private java.util.Hashtable f0709c0bc;
    private java.util.Vector f17b75a6c;
    private java.util.Vector f1bee1c52;
    private java.util.Hashtable f257df2c9;
    private java.util.Hashtable f2ac737d2 = new java.util.Hashtable();
    private java.util.Vector f2cf40685 = new java.util.Vector();
    private java.util.Hashtable f35b4bd2a;
    private java.util.Hashtable f54b90d5b;
    private java.util.Vector fdda40952;

    public static java.lang.string AveyEVNYxWSnVUjL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool HbaGAoyhGqMCPmou(java.util.Hashtable hashtable, java.lang.object obj) {
        return hashtable.ContainsKey(obj);
    }

    public static byte[] OYonkFVRczjWmdqb(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var, java.lang.string str) {
        return p301c7ed4Var.getEncoded(str);
    }

    public static java.lang.stringBuilder TNLkCKFbTpvnelhd(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder VixAUwdSObNhYMem(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CboPzJJzBnYrgnGn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool GKNzuceyyVadMcLX(java.util.Vector vector) {
        return vector.Count == 0;
    }

    public static java.lang.object NcaHemzwgGTCvMHU(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 NxhWmbhGMQkzVTkf(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.stringBuilder TIJmtRmtcwCFPdLx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void TVSGtNlvCmYEYGsy(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 p67cc0eb6Var, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, byte[] bArr) {
        p67cc0eb6Var.addExtension(p364bf33aVar, z, bArr);
    }

    public static java.lang.string XPOCrnZOlmKwGMGL(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void XRzqIWESnoWVCeZv(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public void AddExtension(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        try {
            tVSGtNlvCmYEYGsy(this, p364bf33aVar, z, OYonkFVRczjWmdqb(nxhWmbhGMQkzVTkf(p0fd1bdf1Var), xPOCrnZOlmKwGMGL("cce56d212e6dfcea9e87d7a635ec189883c34cc3df95763b6e03131f79304c")));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException(cboPzJJzBnYrgnGn(tIJmtRmtcwCFPdLx(new java.lang.stringBuilder("error encoding value: "), e)));
        }
    }

    public void AddExtension(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, byte[] bArr) {
        if ((24 + 20) % 20 > 0) {
        }
        if (HbaGAoyhGqMCPmou(this.f2ac737d2, p364bf33aVar)) {
            throw new java.lang.IllegalArgumentException(AveyEVNYxWSnVUjL(VixAUwdSObNhYMem(TNLkCKFbTpvnelhd(new java.lang.stringBuilder("extension "), p364bf33aVar), " already added")));
        }
        xRzqIWESnoWVCeZv(this.f2cf40685, p364bf33aVar);
        ncaHemzwgGTCvMHU(this.f2ac737d2, p364bf33aVar, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf801238f(z, new p5a445d71.p9f931cf3.pca323100.p6f0e511c(bArr)));
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb7e3050b Generate() {
        if ((10 + 15) % 15 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb7e3050b(this.f2cf40685, this.f2ac737d2);
    }

    public bool IsEmpty() {
        return gKNzuceyyVadMcLX(this.f2cf40685);
    }

    public void Reset() {
        this.f2ac737d2 = new java.util.Hashtable();
        this.f2cf40685 = new java.util.Vector();
    }
}

