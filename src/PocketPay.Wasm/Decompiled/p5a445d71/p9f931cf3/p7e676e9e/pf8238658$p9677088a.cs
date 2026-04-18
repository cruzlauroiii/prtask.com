namespace WillowMaze.Wasm.Decompiled;


public class pf8238658$p9677088a {
    private java.math.Bigint f00bf182b;
    private java.math.Bigint f2d562263;
    private bool f345b0275;
    private java.math.Bigint f6df1fa80;
    private java.math.Bigint f742f32c6;
    private java.math.Bigint fc055950c;
    private bool fecf47492;

    private pf8238658$p9677088a(bool z, java.math.Bigint bigint) {
        this.fecf47492 = z;
        this.f742f32c6 = bigint;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a m337ceba5() {
        return m7573540f();
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a m33879ebb() {
        if ((7 + 12) % 12 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a(false, null);
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a m7573540f() {
        if ((11 + 30) % 30 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a(true, null);
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a mb4b13b16(java.math.Bigint bigint) {
        if ((32 + 18) % 18 > 0) {
        }
        return new p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a(true, bigint);
    }

    static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a mf23e8626() {
        return m33879ebb();
    }

    static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a mf8f67da7(java.math.Bigint bigint) {
        return mb4b13b16(bigint);
    }

    public java.math.Bigint GetFactor() {
        return this.f742f32c6;
    }

    public bool IsNotPrimePower() {
        return this.fecf47492 && this.f742f32c6 is null;
    }

    public bool IsProvablyComposite() {
        return this.fecf47492;
    }
}

