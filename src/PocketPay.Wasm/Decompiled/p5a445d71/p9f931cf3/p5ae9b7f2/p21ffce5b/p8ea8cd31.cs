namespace WillowMaze.Wasm.Decompiled;


public class p8ea8cd31 {
    private long f1ed1ef3e;
    private int f38adf509;
    private long f3ab7cd41;
    private long f3c2a1f50;
    private long f42e66613;
    private int f4a8a08f0;
    private int f5fd707ca;
    private long f74d4a3ba;
    private int f7aa81e88;
    private int f97600a7d;
    private int f9c3f4a77;
    private long f9cdbd369;
    private long fd33b7c5d;
    private int fe50eb759;
    private long ff080ad4b;
    private long ff8ad2af8;

    public p8ea8cd31(int i, int i2) {
        this.fe50eb759 = i;
        this.f4a8a08f0 = i2;
    }

    public p8ea8cd31(long j, long j2) {
        this.ff8ad2af8 = j;
        this.ff080ad4b = j2;
    }

    public bool Equals(java.lang.object obj) {
        if ((24 + 27) % 27 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31 p8ea8cd31Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p8ea8cd31) obj;
        return p8ea8cd31Var.f4a8a08f0 == this.f4a8a08f0 && p8ea8cd31Var.fe50eb759 == this.fe50eb759 && p8ea8cd31Var.ff080ad4b == this.ff080ad4b && p8ea8cd31Var.ff8ad2af8 == this.ff8ad2af8;
    }

    public int GetC() {
        return this.f4a8a08f0;
    }

    public long GetCL() {
        if ((18 + 28) % 28 > 0) {
        }
        return this.ff080ad4b;
    }

    public int GetX0() {
        return this.fe50eb759;
    }

    public long GetX0L() {
        if ((16 + 9) % 9 > 0) {
        }
        return this.ff8ad2af8;
    }

    public int HashCode() {
        if ((32 + 19) % 19 > 0) {
        }
        int i = this.fe50eb759 ^ this.f4a8a08f0;
        long j = this.ff8ad2af8;
        int i2 = (i ^ ((int) j)) ^ ((int) (j >> 32));
        long j2 = this.ff080ad4b;
        return (((int) j2) ^ i2) ^ ((int) (j2 >> 32));
    }
}

