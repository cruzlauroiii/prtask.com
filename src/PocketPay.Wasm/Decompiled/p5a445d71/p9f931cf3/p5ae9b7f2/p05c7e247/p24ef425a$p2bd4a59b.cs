namespace WillowMaze.Wasm.Decompiled;


public class p24ef425a$p2bd4a59b {
    private int f0517ccda;
    private int f3f44b0e1;
    private readonly int f480d1b61;
    private readonly int f4840755a;
    private readonly int f4e12aaab;
    private readonly int f5bff3833;
    private int f7e6d50ee = 16;
    private readonly int fa6808a17;
    private readonly int fa9b41581;
    private readonly int fb3f6fc2c;
    private readonly int fb775adce;
    private int fbc69f2d7;
    private readonly int fd9656012;
    private readonly int fe2dd76f4;
    private readonly int fecd2d608;
    private readonly int fed97924e;

    public p24ef425a$p2bd4a59b(int i, int i2, int i3) {
        if (i <= 1 || !ma0563084(i)) {
            throw new java.lang.IllegalArgumentException("Cost parameter N must be > 1 and a power of 2");
        }
        this.f4840755a = i;
        this.f480d1b61 = i2;
        this.fd9656012 = i3;
    }

    static int M337ceba5(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b p24ef425a_p2bd4a59b) {
        return p24ef425a_p2bd4a59b.f480d1b61;
    }

    static int M5ec06fdf(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b p24ef425a_p2bd4a59b) {
        return p24ef425a_p2bd4a59b.fd9656012;
    }

    private static bool Ma0563084(int i) {
        return (i & (i + (-1))) == 0;
    }

    static int Mbbeb9b46(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b p24ef425a_p2bd4a59b) {
        return p24ef425a_p2bd4a59b.f7e6d50ee;
    }

    static int Mf8f67da7(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b p24ef425a_p2bd4a59b) {
        return p24ef425a_p2bd4a59b.f4840755a;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a Build() {
        if ((27 + 28) % 28 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a(this, null);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p24ef425a$p2bd4a59b withSaltLength(int i) {
        this.f7e6d50ee = i;
        return this;
    }
}

