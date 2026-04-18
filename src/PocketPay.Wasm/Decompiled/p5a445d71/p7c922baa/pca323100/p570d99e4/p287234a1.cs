namespace WillowMaze.Wasm.Decompiled;


public class p287234a1 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f736b9175;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 fb0b6f34a;

    public p287234a1(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        this.f736b9175 = new p5a445d71.p7c922baa.pca323100.pf39f0079(pd6ccb7fcVar);
    }

    private p287234a1(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        this.f736b9175 = ped34daf1Var;
    }

    public static int WpJYordSAsNYPOyE(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.ped34daf1 XnQMEiZWINHMowbb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.ped34daf1.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f ZCTGZdUKguSMJhHq(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JxCGCyBYJjzIaJYs(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var, int i) {
        return ped34daf1Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p287234a1 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p287234a1) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p287234a1) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p287234a1(XnQMEiZWINHMowbb(obj));
    }

    public p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f[] GetAttributes() {
        if ((27 + 27) % 27 > 0) {
        }
        int iWpJYordSAsNYPOyE = WpJYordSAsNYPOyE(this.f736b9175);
        p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f[] pf2bbdf9fVarArr = new p5a445d71.p7c922baa.pca323100.p570d99e4.pf2bbdf9f[iWpJYordSAsNYPOyE];
        for (int i = 0; i != iWpJYordSAsNYPOyE; i++) {
            pf2bbdf9fVarArr[i] = ZCTGZdUKguSMJhHq(jxCGCyBYJjzIaJYs(this.f736b9175, i));
        }
        return pf2bbdf9fVarArr;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f736b9175;
    }
}

