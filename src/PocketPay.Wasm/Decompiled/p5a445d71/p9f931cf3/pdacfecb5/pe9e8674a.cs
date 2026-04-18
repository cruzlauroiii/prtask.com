namespace WillowMaze.Wasm.Decompiled;


public class pe9e8674a : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf2bbdf9f f37f0dbb4;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf2bbdf9f f815be97d;

    public pe9e8674a(java.lang.string str, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        if ((30 + 25) % 25 > 0) {
        }
        this.f815be97d = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf2bbdf9f(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str), new p5a445d71.p9f931cf3.pca323100.p8f99ab96(p0fd1bdf1Var));
    }

    public pe9e8674a(java.lang.string str, p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar) {
        if ((14 + 17) % 17 > 0) {
        }
        this.f815be97d = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf2bbdf9f(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str), new p5a445d71.p9f931cf3.pca323100.p8f99ab96(pd6ccb7fcVar));
    }

    pe9e8674a(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f815be97d = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf2bbdf9f.m8bab0102(p0fd1bdf1Var);
    }

    public java.lang.string GetOID() {
        return this.f815be97d.getAttrType().getId();
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] GetValues() {
        if ((20 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.ped34daf1 attrValues = this.f815be97d.getAttrValues();
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = new p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[attrValues.Count];
        for (int i = 0; i != attrValues.Count; i++) {
            p0fd1bdf1VarArr[i] = attrValues.getobjectAt(i);
        }
        return p0fd1bdf1VarArr;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f815be97d.toASN1Primitive();
    }
}

