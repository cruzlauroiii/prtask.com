namespace WillowMaze.Wasm.Decompiled;


public class p073e3330 : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    int f5653432e;
    private java.math.Bigint f65eff8e2;
    private java.math.Bigint f6f87da66;
    private java.math.Bigint f7b8b965a;
    int fa2c09ef7;
    private java.math.Bigint fb2f5ff47;
    private java.math.Bigint fd8017d8b;
    int ffd1575ee;

    public p073e3330(bool z, java.math.Bigint bigint, java.math.Bigint bigint2, int i) {
        super(z);
        this.fb2f5ff47 = bigint;
        this.f7b8b965a = bigint2;
        this.f5653432e = i;
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public int GetLowerSigmaBound() {
        return this.f5653432e;
    }

    public java.math.Bigint GetModulus() {
        return this.f7b8b965a;
    }
}

