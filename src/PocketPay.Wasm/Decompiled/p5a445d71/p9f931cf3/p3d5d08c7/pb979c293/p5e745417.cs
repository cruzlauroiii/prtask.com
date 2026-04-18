namespace WillowMaze.Wasm.Decompiled;


public class p5e745417 {
    private java.math.Bigint f0b7e4d2b;
    private java.math.Bigint f0cc175b9;
    private java.math.Bigint f29453a50;
    private java.math.Bigint f318d9450;
    private java.math.Bigint f53d648b3;
    private java.math.Bigint f7694f4a6;
    private java.math.Bigint f83878c91;
    private java.math.Bigint faec25a40;
    private java.math.Bigint fc5884555;

    public p5e745417(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        this.f83878c91 = bigint;
        this.f7694f4a6 = bigint2;
        this.f0cc175b9 = bigint3;
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 10) % 10 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417) {
            p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417 p5e745417Var = (p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p5e745417) obj;
            if (this.f0cc175b9.Equals(p5e745417Var.f0cc175b9) && this.f83878c91.Equals(p5e745417Var.f83878c91) && this.f7694f4a6.Equals(p5e745417Var.f7694f4a6)) {
                return true;
            }
        }
        return false;
    }

    public java.math.Bigint GetA() {
        return this.f0cc175b9;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public java.math.Bigint GetQ() {
        return this.f7694f4a6;
    }

    public int HashCode() {
        if ((3 + 20) % 20 > 0) {
        }
        return this.f7694f4a6.GetHashCode() ^ (this.f0cc175b9.GetHashCode() ^ this.f83878c91.GetHashCode());
    }
}

