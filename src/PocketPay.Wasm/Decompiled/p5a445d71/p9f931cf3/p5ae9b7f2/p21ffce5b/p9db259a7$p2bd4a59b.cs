namespace WillowMaze.Wasm.Decompiled;


public class p9db259a7$p2bd4a59b {
    private int f01924d52;
    private int f02ad2b3b;
    private int f02cbce78;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed f0ea7dd4d;
    private int f136d4431;
    private byte[] f15610cc2;
    private int f27bcec67;
    private int f2af72f10;
    private int f2e0038a7;
    private int f35022e7b;
    private int f36373506;
    private int f471dacea;
    private int f5048e74d;
    private readonly int f599dcce2;
    private int f5dd61dce;
    private byte[] f5ebe2294;
    private int f71494fdf;
    private int f73917b23;
    private int fa11f928c;
    private int fa43ad536;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed fc2db2d21;
    private int fcd69b495;
    private byte[] fceb20772;
    private readonly int fd30737d6;
    private byte[] fd4f68e8e;
    private readonly int fd951581b;
    private int fe5421f0d;
    private byte[] ffd049255;
    private byte[] fff65863e;

    public p9db259a7$p2bd4a59b() {
        this(1);
    }

    public p9db259a7$p2bd4a59b(int i) {
        this.f0ea7dd4d = p5a445d71.p9f931cf3.p5ae9b7f2.p3d454bee.feb7ee0fb;
        this.f599dcce2 = i;
        this.f36373506 = 1;
        this.fcd69b495 = 4096;
        this.f471dacea = 3;
        this.f2af72f10 = 19;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7 Build() {
        if ((8 + 6) % 6 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7(this.f599dcce2, this.fceb20772, this.f5ebe2294, this.f15610cc2, this.f471dacea, this.fcd69b495, this.f36373506, this.f2af72f10, this.f0ea7dd4d, null);
    }

    public void Clear() {
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.fceb20772);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f5ebe2294);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f15610cc2);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withAdditional(byte[] bArr) {
        this.f15610cc2 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withCharTobyteConverter(p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed p63c054edVar) {
        this.f0ea7dd4d = p63c054edVar;
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withIterations(int i) {
        this.f471dacea = i;
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withMemoryAsKB(int i) {
        this.fcd69b495 = i;
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withMemoryPowOfTwo(int i) {
        this.fcd69b495 = 1 << i;
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withParallelism(int i) {
        this.f36373506 = i;
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withSalt(byte[] bArr) {
        this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withSecret(byte[] bArr) {
        this.f5ebe2294 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$p2bd4a59b withVersion(int i) {
        this.f2af72f10 = i;
        return this;
    }
}

