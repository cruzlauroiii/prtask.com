namespace WillowMaze.Wasm.Decompiled;


class p6860bf54 : p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 {
    protected readonly java.math.Bigint f2aa499ab;
    protected readonly java.math.Bigint fa2de09ab;

    p6860bf54(java.math.Bigint bigint) {
        this.fa2de09ab = bigint;
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p6860bf54)) {
            return false;
        }
        return this.fa2de09ab.Equals(((p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p6860bf54) obj).fa2de09ab);
    }

    public override java.math.Bigint Getcharistic() {
        return this.fa2de09ab;
    }

    public override int GetDimension() {
        return 1;
    }

    public int HashCode() {
        return this.fa2de09ab.GetHashCode();
    }
}

