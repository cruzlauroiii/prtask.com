namespace WillowMaze.Wasm.Decompiled;


public class p24b6472f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f7561fc69;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f8ce5fc54;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;

    private p24b6472f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public p24b6472f(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e pfeaff37eVar) {
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pfeaff37eVar);
    }

    public p24b6472f(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e[] pfeaff37eVarArr) {
        if ((3 + 20) % 20 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        for (p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e pfeaff37eVar : pfeaff37eVarArr) {
            ZMuqQNpVtPPYagrk(pd6ccb7fcVar, pfeaff37eVar);
        }
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 DSatOUaavVMaqdfL(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void ZMuqQNpVtPPYagrk(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.p24b6472f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.p24b6472f) {
            return (p5a445d71.p7c922baa.pca323100.pc1cfc81b.p24b6472f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pc1cfc81b.p24b6472f(DSatOUaavVMaqdfL(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 NSlXCBXWBispSqDw(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int QmDLrpZVwbNQEQGK(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e VRtKChoxmypXHzbz(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e.m8bab0102(obj);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e[] ToAttributeTypeAndValueArray() {
        if ((8 + 26) % 26 > 0) {
        }
        int iQmDLrpZVwbNQEQGK = qmDLrpZVwbNQEQGK(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e[] pfeaff37eVarArr = new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e[iQmDLrpZVwbNQEQGK];
        for (int i = 0; i != iQmDLrpZVwbNQEQGK; i++) {
            pfeaff37eVarArr[i] = vRtKChoxmypXHzbz(nSlXCBXWBispSqDw(this.f9a0364b9, i));
        }
        return pfeaff37eVarArr;
    }
}

