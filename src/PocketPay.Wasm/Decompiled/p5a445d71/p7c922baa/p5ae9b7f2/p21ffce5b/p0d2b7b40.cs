namespace WillowMaze.Wasm.Decompiled;


public class p0d2b7b40 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p073e3330 {
    private java.util.Vector f42441d7d;
    private java.math.Bigint f802afc0a;
    private java.util.Vector fc7dcbd27;
    private java.math.Bigint ff0694351;

    public p0d2b7b40(java.math.Bigint bigint, java.math.Bigint bigint2, int i, java.util.Vector vector, java.math.Bigint bigint3) {
        super(true, bigint, bigint2, i);
        this.fc7dcbd27 = vector;
        this.f802afc0a = bigint3;
    }

    public java.math.Bigint GetPhiN() {
        return this.f802afc0a;
    }

    public java.util.Vector GetSmallPrimes() {
        return this.fc7dcbd27;
    }
}

