namespace WillowMaze.Wasm.Decompiled;


class pd5f7d89a : p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p7f9339ec {
    protected readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 f5f5c295c;
    protected readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 f718510fe;
    protected readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 f776ea908;
    protected readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 fb19eee46;
    protected readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 fd18dcfff;
    protected readonly p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 fe8d58f59;

    pd5f7d89a(p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var, p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 p24ecfbe3Var) {
        this.fe8d58f59 = pe4575263Var;
        this.fb19eee46 = p24ecfbe3Var;
    }

    public static java.math.Bigint CDSQUwqWSRYautrD(p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var) {
        return pe4575263Var.getcharistic();
    }

    public static int EhJvOChWnRLLotqe(p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var) {
        return pe4575263Var.getDimension();
    }

    public static int HKkGucuRuzuUJmGp(int i, int i2) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.mff847a50(i, i2);
    }

    public static int JWXNshOETGgJXOiK(p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 p24ecfbe3Var) {
        return p24ecfbe3Var.getDegree();
    }

    public static bool LvgTQiQqlfmTvNQf(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int MGKWmZhAFUeajPmv(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool OFyInTGEgLqMgAVF(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int ADfWhTwlNDOMKuxY(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int DGufqEsLIjeCAVQU(p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 p24ecfbe3Var) {
        return p24ecfbe3Var.getDegree();
    }

    public bool Equals(java.lang.object obj) {
        if ((12 + 15) % 15 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pd5f7d89a)) {
            return false;
        }
        p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pd5f7d89a pd5f7d89aVar = (p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pd5f7d89a) obj;
        return OFyInTGEgLqMgAVF(this.fe8d58f59, pd5f7d89aVar.fe8d58f59) && LvgTQiQqlfmTvNQf(this.fb19eee46, pd5f7d89aVar.fb19eee46);
    }

    public override java.math.Bigint Getcharistic() {
        return CDSQUwqWSRYautrD(this.fe8d58f59);
    }

    public override int GetDegree() {
        return JWXNshOETGgJXOiK(this.fb19eee46);
    }

    public override int GetDimension() {
        return EhJvOChWnRLLotqe(this.fe8d58f59) * dGufqEsLIjeCAVQU(this.fb19eee46);
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 GetMinimalPolynomial() {
        return this.fb19eee46;
    }

    public override p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 GetSubfield() {
        return this.fe8d58f59;
    }

    public int HashCode() {
        if ((14 + 14) % 14 > 0) {
        }
        return HKkGucuRuzuUJmGp(aDfWhTwlNDOMKuxY(this.fb19eee46), 16) ^ MGKWmZhAFUeajPmv(this.fe8d58f59);
    }
}

