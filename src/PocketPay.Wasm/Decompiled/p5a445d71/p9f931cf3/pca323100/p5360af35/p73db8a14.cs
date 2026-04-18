namespace WillowMaze.Wasm.Decompiled;


public class p73db8a14 : p5a445d71.p9f931cf3.pca323100.p54252eff : org.bouncycastle.util.IEnumerable<p5a445d71.p9f931cf3.pca323100.p0fd1bdf1> {
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] f483af475;
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] f83056c1f;
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] fca436efb;
    private readonly p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] fd50667c6;

    private p73db8a14(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((1 + 22) % 22 > 0) {
        }
        this.fd50667c6 = new p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[vdCfNRRKAkZjVTxI(p80f8c729Var)];
        int i = 0;
        while (true) {
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = this.fd50667c6;
            if (i == p0fd1bdf1VarArr.length) {
                return;
            }
            p0fd1bdf1VarArr[i] = BjSMKbtEindOLWFz(xFjxAcRidvwTAncX(p80f8c729Var, i));
            i++;
        }
    }

    public p73db8a14(p5a445d71.p9f931cf3.pca323100.p5360af35.p9e565970[] p9e565970VarArr) {
        if ((12 + 4) % 4 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = new p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[p9e565970VarArr.length];
        this.fd50667c6 = p0fd1bdf1VarArr;
        OrVrDXdXccEmvXqm(p9e565970VarArr, 0, p0fd1bdf1VarArr, 0, p9e565970VarArr.length);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.p9e565970 BjSMKbtEindOLWFz(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p5360af35.p9e565970.m8bab0102(obj);
    }

    public static void OrVrDXdXccEmvXqm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 LyWBXFfchoJyKtPG(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p5360af35.p73db8a14 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p5360af35.p73db8a14) {
            return (p5a445d71.p9f931cf3.pca323100.p5360af35.p73db8a14) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p5360af35.p73db8a14(lyWBXFfchoJyKtPG(obj));
    }

    public static int VdCfNRRKAkZjVTxI(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 XFjxAcRidvwTAncX(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public java.util.IEnumerator<p5a445d71.p9f931cf3.pca323100.p0fd1bdf1> Iterator() {
        return new p5a445d71.p9f931cf3.p05c7e247.pff43b8de$p2a29178a(this.fd50667c6);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(this.fd50667c6);
    }
}

