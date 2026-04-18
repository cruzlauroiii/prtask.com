namespace WillowMaze.Wasm.Decompiled;


class p6860bf54 : p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.pe4575263 {
    protected readonly java.math.Bigint f8bbf73d1;
    protected readonly java.math.Bigint fa2de09ab;
    protected readonly java.math.Bigint fafe2a1eb;
    protected readonly java.math.Bigint fc533a84a;
    protected readonly java.math.Bigint fdba9b906;

    p6860bf54(java.math.Bigint bigint) {
        this.fa2de09ab = bigint;
    }

    public static bool NUWIYNnneftNgDbn(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int VKJxOcXrfzByJNQj(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p6860bf54)) {
            return false;
        }
        return NUWIYNnneftNgDbn(this.fa2de09ab, ((p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p6860bf54) obj).fa2de09ab);
    }

    public override java.math.Bigint Getcharistic() {
        return this.fa2de09ab;
    }

    public override int GetDimension() {
        return 1;
    }

    public int HashCode() {
        return vKJxOcXrfzByJNQj(this.fa2de09ab);
    }
}

