namespace WillowMaze.Wasm.Decompiled;


public class p38871b97 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f3dc1ae7d;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f52d71581;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fb29185b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fe2db0a07;

    private p38871b97(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var2 = (p5a445d71.p7c922baa.pca323100.p80f8c729) jmIZXeENLAnuCgIW(p80f8c729Var, 0);
        this.f3dc1ae7d = p80f8c729Var2;
        java.util.Enumeration enumerationEzPmkoHHjoasZfmR = EzPmkoHHjoasZfmR(p80f8c729Var2);
        while (bIRhiijxnRyiImLM(enumerationEzPmkoHHjoasZfmR)) {
            LpJYsllYKotckSQm(NbNKgqPufIbKvFen(enumerationEzPmkoHHjoasZfmR));
        }
    }

    public p38871b97(p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82[] p5ada1d82VarArr) {
        this.f3dc1ae7d = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p5ada1d82VarArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DsVfoJBoyEZbhFLq(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.util.Enumeration EzPmkoHHjoasZfmR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82 LpJYsllYKotckSQm(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82.m8bab0102(obj);
    }

    public static java.lang.object NbNKgqPufIbKvFen(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static int XEwMvdJGyOLLZKzT(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static bool BIRhiijxnRyiImLM(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 HteaVgXurYaKeZSi(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JmIZXeENLAnuCgIW(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p38871b97 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.p38871b97) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.p38871b97) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.p38871b97(hteaVgXurYaKeZSi(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82 YalxEXOPjbuhwPGY(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82[] GetCrls() {
        if ((19 + 8) % 8 > 0) {
        }
        int iXEwMvdJGyOLLZKzT = XEwMvdJGyOLLZKzT(this.f3dc1ae7d);
        p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82[] p5ada1d82VarArr = new p5a445d71.p7c922baa.pca323100.pfa17f333.p5ada1d82[iXEwMvdJGyOLLZKzT];
        for (int i = 0; i < iXEwMvdJGyOLLZKzT; i++) {
            p5ada1d82VarArr[i] = yalxEXOPjbuhwPGY(DsVfoJBoyEZbhFLq(this.f3dc1ae7d, i));
        }
        return p5ada1d82VarArr;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(this.f3dc1ae7d);
    }
}

