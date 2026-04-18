namespace WillowMaze.Wasm.Decompiled;


public class p73db8a14 : p5a445d71.p7c922baa.pca323100.p54252eff : org.spongycastle.util.IEnumerable<p5a445d71.p7c922baa.pca323100.p0fd1bdf1> {
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] f0493f828;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] fbb82a7c7;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] fbced26ec;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] fd50667c6;

    private p73db8a14(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((8 + 14) % 14 > 0) {
        }
        this.fd50667c6 = new p5a445d71.p7c922baa.pca323100.p0fd1bdf1[fGOTgytjEpNlhfgp(p80f8c729Var)];
        int i = 0;
        while (true) {
            p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = this.fd50667c6;
            if (i == p0fd1bdf1VarArr.length) {
                return;
            }
            p0fd1bdf1VarArr[i] = VmtkVjvHNjnidqWo(JhIJfZTqTLvUTpDB(p80f8c729Var, i));
            i++;
        }
    }

    public p73db8a14(p5a445d71.p7c922baa.pca323100.p5360af35.p9e565970[] p9e565970VarArr) {
        if ((3 + 10) % 10 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = new p5a445d71.p7c922baa.pca323100.p0fd1bdf1[p9e565970VarArr.length];
        this.fd50667c6 = p0fd1bdf1VarArr;
        JnVMriWfqNqsUvBg(p9e565970VarArr, 0, p0fd1bdf1VarArr, 0, p9e565970VarArr.length);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JhIJfZTqTLvUTpDB(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void JnVMriWfqNqsUvBg(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static p5a445d71.p7c922baa.pca323100.p5360af35.p9e565970 VmtkVjvHNjnidqWo(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p5360af35.p9e565970.m8bab0102(obj);
    }

    public static int FGOTgytjEpNlhfgp(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 HrGyAgnUbCAJTUAB(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p5360af35.p73db8a14 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p5360af35.p73db8a14) {
            return (p5a445d71.p7c922baa.pca323100.p5360af35.p73db8a14) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p5360af35.p73db8a14(hrGyAgnUbCAJTUAB(obj));
    }

    public java.util.IEnumerator<p5a445d71.p7c922baa.pca323100.p0fd1bdf1> Iterator() {
        return new p5a445d71.p7c922baa.p05c7e247.pff43b8de$p2a29178a(this.fd50667c6);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(this.fd50667c6);
    }
}

