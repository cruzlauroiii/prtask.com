namespace WillowMaze.Wasm.Decompiled;


public class p90fac87d {
    public java.math.Bigint f0a0eb058;
    public java.math.Bigint f331a5d7e;
    public java.math.Bigint f38e94834;
    public java.math.Bigint f41529076;
    public java.math.Bigint f9dd4e461;
    public java.math.Bigint fcd4b7239;
    public java.math.Bigint ff88488a6;
    public java.math.Bigint ffc059c72;

    private p90fac87d() {
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.p90fac87d M7b051bd7(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((9 + 24) % 24 > 0) {
        }
        java.math.Bigint bigint3 = java.math.Bigint.ZERO;
        java.math.Bigint bigint4 = java.math.Bigint.ONE;
        java.math.Bigint bigint5 = java.math.Bigint.ONE;
        java.math.Bigint bigint6 = java.math.Bigint.ZERO;
        java.math.Bigint bigint7 = bigint;
        java.math.Bigint bigint8 = bigint2;
        while (!bigint8.Equals(java.math.Bigint.ZERO)) {
            java.math.Bigint[] bigintArrDivideAndRemainder = bigint7.divideAndRemainder(bigint8);
            java.math.Bigint bigint9 = bigintArrDivideAndRemainder[0];
            java.math.Bigint bigint10 = bigintArrDivideAndRemainder[1];
            java.math.Bigint bigintSubtract = bigint4.subtract(bigint9.multiply(bigint3));
            java.math.Bigint bigintSubtract2 = bigint6.subtract(bigint9.multiply(bigint5));
            bigint7 = bigint8;
            bigint8 = bigint10;
            bigint4 = bigint3;
            bigint3 = bigintSubtract;
            bigint6 = bigint5;
            bigint5 = bigintSubtract2;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.p90fac87d p90fac87dVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.p90fac87d();
        p90fac87dVar.f9dd4e461 = bigint4;
        p90fac87dVar.f41529076 = bigint6;
        p90fac87dVar.f331a5d7e = bigint7;
        return p90fac87dVar;
    }
}

