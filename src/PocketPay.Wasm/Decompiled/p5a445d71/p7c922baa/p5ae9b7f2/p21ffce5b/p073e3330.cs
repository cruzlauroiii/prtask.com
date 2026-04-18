namespace WillowMaze.Wasm.Decompiled;


public class p073e3330 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pcfffbc4a {
    private java.math.Bigint f0fabf8ae;
    int f51bf2555;
    int f5653432e;
    private java.math.Bigint f7b8b965a;
    private java.math.Bigint f8059142a;
    int f80e7368b;
    int fab491eff;
    private java.math.Bigint fafb972fe;
    private java.math.Bigint fb2f5ff47;
    private java.math.Bigint fba456d67;
    int fdcbe0104;

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

