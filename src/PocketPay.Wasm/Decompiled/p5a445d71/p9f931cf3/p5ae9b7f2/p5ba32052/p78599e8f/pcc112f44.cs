namespace WillowMaze.Wasm.Decompiled;


public class pcc112f44 {
    private readonly java.math.Bigint f414ebe95;
    private readonly java.math.Bigint f5b6c5116;
    private readonly java.math.Bigint f7694f4a6;
    private readonly java.math.Bigint f83878c91;
    private readonly java.math.Bigint fb2f5ff47;
    private readonly java.math.Bigint fcfd45446;
    private readonly java.math.Bigint fdc6ccb6d;

    public pcc112f44(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this(bigint, bigint2, bigint3, false);
    }

    pcc112f44(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, bool z) {
        if ((14 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigint, "p");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigint2, "q");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigint3, "g");
        if (!z) {
            if (!bigint.subtract(p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.fbc21e648).mod(bigint2).Equals(p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.f529e9e0b)) {
                throw new java.lang.IllegalArgumentException("p-1 must be evenly divisible by q");
            }
            if (bigint3.compareTo(java.math.Bigint.valueOf(2L)) == -1 || bigint3.compareTo(bigint.subtract(p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.fbc21e648)) == 1) {
                throw new java.lang.IllegalArgumentException("g must be in [2, p-1]");
            }
            if (!bigint3.modPow(bigint2, bigint).Equals(p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.fbc21e648)) {
                throw new java.lang.IllegalArgumentException("g^q mod p must equal 1");
            }
            if (!bigint.isProbablePrime(20)) {
                throw new java.lang.IllegalArgumentException("p must be prime");
            }
            if (!bigint2.isProbablePrime(20)) {
                throw new java.lang.IllegalArgumentException("q must be prime");
            }
        }
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.fb2f5ff47 = bigint3;
    }

    public java.math.Bigint GetG() {
        return this.fb2f5ff47;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }
}

