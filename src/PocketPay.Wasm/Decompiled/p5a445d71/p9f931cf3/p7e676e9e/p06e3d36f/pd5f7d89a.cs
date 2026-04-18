namespace WillowMaze.Wasm.Decompiled;


class pd5f7d89a : p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p7f9339ec {
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f1b572a39;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 f2205801e;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 f2efa1792;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 f3e9c5ae4;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 f4eec4ed4;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 fb19eee46;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 fd4e0c76e;
    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 fe8d58f59;

    pd5f7d89a(p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var, p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 p24ecfbe3Var) {
        this.fe8d58f59 = pe4575263Var;
        this.fb19eee46 = p24ecfbe3Var;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 4) % 4 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pd5f7d89a)) {
            return false;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pd5f7d89a pd5f7d89aVar = (p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pd5f7d89a) obj;
        return this.fe8d58f59.Equals(pd5f7d89aVar.fe8d58f59) && this.fb19eee46.Equals(pd5f7d89aVar.fb19eee46);
    }

    public override java.math.Bigint Getcharistic() {
        return this.fe8d58f59.getcharistic();
    }

    public override int GetDegree() {
        return this.fb19eee46.getDegree();
    }

    public override int GetDimension() {
        return this.fe8d58f59.getDimension() * this.fb19eee46.getDegree();
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p24ecfbe3 GetMinimalPolynomial() {
        return this.fb19eee46;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 GetSubfield() {
        return this.fe8d58f59;
    }

    public int HashCode() {
        if ((23 + 26) % 26 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.pf74464bf.mff847a50(this.fb19eee46.GetHashCode(), 16) ^ this.fe8d58f59.GetHashCode();
    }
}

