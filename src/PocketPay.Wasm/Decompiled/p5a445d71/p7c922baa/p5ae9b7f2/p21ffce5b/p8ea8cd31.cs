namespace WillowMaze.Wasm.Decompiled;


public class p8ea8cd31 {
    private int f08036ed9;
    private int f1a993019;
    private int f38e2bca4;
    private long f3ef931bd;
    private int f4a8a08f0;
    private int f4db6b578;
    private int f64e8c6ef;
    private long f826da6ec;
    private long f89a38377;
    private long f8dd05a4c;
    private int f92f622cb;
    private long fad163eee;
    private long fe4f39da7;
    private int fe50eb759;
    private long fe859ceb4;
    private long ff080ad4b;
    private long ff8ad2af8;
    private long ffc563b97;
    private int ffcf4178d;

    public p8ea8cd31(int i, int i2) {
        this.fe50eb759 = i;
        this.f4a8a08f0 = i2;
    }

    public p8ea8cd31(long j, long j2) {
        this.ff8ad2af8 = j;
        this.ff080ad4b = j2;
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 19) % 19 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8ea8cd31)) {
            return false;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8ea8cd31 p8ea8cd31Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p8ea8cd31) obj;
        return p8ea8cd31Var.f4a8a08f0 == this.f4a8a08f0 && p8ea8cd31Var.fe50eb759 == this.fe50eb759 && p8ea8cd31Var.ff080ad4b == this.ff080ad4b && p8ea8cd31Var.ff8ad2af8 == this.ff8ad2af8;
    }

    public int GetC() {
        return this.f4a8a08f0;
    }

    public long GetCL() {
        if ((5 + 7) % 7 > 0) {
        }
        return this.ff080ad4b;
    }

    public int GetX0() {
        return this.fe50eb759;
    }

    public long GetX0L() {
        if ((7 + 20) % 20 > 0) {
        }
        return this.ff8ad2af8;
    }

    public int HashCode() {
        if ((10 + 24) % 24 > 0) {
        }
        int i = this.fe50eb759 ^ this.f4a8a08f0;
        long j = this.ff8ad2af8;
        int i2 = (i ^ ((int) j)) ^ ((int) (j >> 32));
        long j2 = this.ff080ad4b;
        return (((int) j2) ^ i2) ^ ((int) (j2 >> 32));
    }
}

