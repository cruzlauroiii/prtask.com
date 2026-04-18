namespace WillowMaze.Wasm.Decompiled;


public class pdbf06456 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f4c7e98b5;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f80f26bed;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;

    private pdbf06456(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public pdbf06456(p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131 p9d37b131Var) {
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p9d37b131Var);
    }

    public pdbf06456(p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131[] p9d37b131VarArr) {
        if ((25 + 21) % 21 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        for (p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131 p9d37b131Var : p9d37b131VarArr) {
            qoUyVHhshkxIypFU(pd6ccb7fcVar, p9d37b131Var);
        }
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 FuWVmLqYPxbpiTWE(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131 SuFjoFTeWewUhuCi(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 VgvYTjGonzxwWDzY(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pdbf06456 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pdbf06456) {
            return (p5a445d71.p7c922baa.pca323100.pc1cfc81b.pdbf06456) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pdbf06456(VgvYTjGonzxwWDzY(obj));
    }

    public static void QoUyVHhshkxIypFU(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int ZpTDZlyaToUnNKQZ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131[] ToCertReqMsgArray() {
        if ((1 + 9) % 9 > 0) {
        }
        int iZpTDZlyaToUnNKQZ = zpTDZlyaToUnNKQZ(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131[] p9d37b131VarArr = new p5a445d71.p7c922baa.pca323100.pc1cfc81b.p9d37b131[iZpTDZlyaToUnNKQZ];
        for (int i = 0; i != iZpTDZlyaToUnNKQZ; i++) {
            p9d37b131VarArr[i] = SuFjoFTeWewUhuCi(FuWVmLqYPxbpiTWE(this.f9a0364b9, i));
        }
        return p9d37b131VarArr;
    }
}

