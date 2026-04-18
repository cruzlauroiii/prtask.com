namespace WillowMaze.Wasm.Decompiled;


public class pe83f9232 : p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e {
    private p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 f1951366f;
    private p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 f267eadb6;
    private p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 f3676b14a;
    private p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 f480d71d9;
    private p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 f763a7bd8;
    private p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 f7d881d23;
    private p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 f89e81ded;
    private p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 f8eaf7c9a;
    private p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 f94b4e103;
    private p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 f96a1ffe8;
    private p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 fd0acefea;
    private p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 ff625d89d;

    public override java.lang.object Clone() {
        if ((8 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pdacfecb5.pe83f9232 pe83f9232Var = new p5a445d71.p9f931cf3.pdacfecb5.pe83f9232();
        pe83f9232Var.f267eadb6 = this.f267eadb6;
        p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var = this.f94b4e103;
        if (p27cbb5a8Var is not null) {
            pe83f9232Var.setForwardSelector((p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8) p27cbb5a8Var.clone());
        }
        p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var2 = this.f96a1ffe8;
        if (p27cbb5a8Var2 is not null) {
            pe83f9232Var.setReverseSelector((p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8) p27cbb5a8Var2.clone());
        }
        return pe83f9232Var;
    }

    public p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 GetCertValueTuple() {
        return this.f267eadb6;
    }

    public p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 GetForwardSelector() {
        return this.f94b4e103;
    }

    public p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 GetReverseSelector() {
        return this.f96a1ffe8;
    }

    public override bool Match(java.lang.object obj) {
        if ((6 + 6) % 6 > 0) {
        }
        try {
            if (!(obj is p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4)) {
                return false;
            }
            p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 p0b7269c4Var = (p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4) obj;
            p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var = this.f94b4e103;
            if (p27cbb5a8Var is not null && !p27cbb5a8Var.match((java.lang.object) p0b7269c4Var.getForward())) {
                return false;
            }
            p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var2 = this.f96a1ffe8;
            if (p27cbb5a8Var2 is not null && !p27cbb5a8Var2.match((java.lang.object) p0b7269c4Var.getReverse())) {
                return false;
            }
            p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 p0b7269c4Var2 = this.f267eadb6;
            if (p0b7269c4Var2 is not null) {
                return p0b7269c4Var2.Equals(obj);
            }
            return true;
        } catch (java.lang.Exception unused) {
            return false;
        }
    }

    public void SetCertValueTuple(p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 p0b7269c4Var) {
        this.f267eadb6 = p0b7269c4Var;
    }

    public void SetForwardSelector(p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var) {
        this.f94b4e103 = p27cbb5a8Var;
    }

    public void SetReverseSelector(p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var) {
        this.f96a1ffe8 = p27cbb5a8Var;
    }
}

