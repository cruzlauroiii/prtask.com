namespace WillowMaze.Wasm.Decompiled;


public class p9db259a7 {
    public static readonly int f01d57445 = 16;
    public static readonly int f0477f97d = 16;
    public static readonly int f04bd4cdb = 16;
    public static readonly int f0d4da357 = 1;
    public static readonly int f15b48da7 = 19;
    private static readonly int f1f13923d = 3;
    private static readonly int f261e7358 = 12;
    private static readonly int f28521a29 = 12;
    public static readonly int f32ac173d = 19;
    private static readonly int f3c463329 = 1;
    public static readonly int f3cd8c030 = 19;
    private static readonly int f4b557b0a = 1;
    private static readonly int f4bbaa882 = 12;
    public static readonly int f4cd0c1b4 = 2;
    private static readonly int f51e671c6 = 19;
    public static readonly int f6458e2b8 = 2;
    public static readonly int f6d117012 = 2;
    public static readonly int f90c2c2fb = 1;
    public static readonly int f9dc20412 = 1;
    private static readonly int fa32f750d = 19;
    private static readonly int faa5cc5c5 = 19;
    public static readonly int fadf954f4 = 16;
    private static readonly int fb341691f = 3;
    public static readonly int fb38901cf = 19;
    public static readonly int fb414e6dc = 0;
    public static readonly int fbaa2491a = 0;
    private static readonly int fbfac159e = 1;
    private static readonly int fc2cb700f = 3;
    private static readonly int fd3251697 = 1;
    private static readonly int fe41a08ee = 1;
    private static readonly int feb498711 = 1;
    private static readonly int ff1ac69b9 = 3;
    private static readonly int ff41ba9d9 = 1;
    private readonly int f090fc912;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed f0ea7dd4d;
    private readonly int f12cbc1d9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed f14aa8848;
    private readonly byte[] f15610cc2;
    private readonly byte[] f255627bd;
    private readonly int f2af72f10;
    private readonly byte[] f2d1b88dd;
    private readonly int f36373506;
    private readonly int f471dacea;
    private readonly int f563c4093;
    private readonly int f599dcce2;
    private readonly int f5ebc91d9;
    private readonly byte[] f5ebe2294;
    private readonly int f69e4e229;
    private readonly byte[] f6bd83708;
    private readonly int f7b6e145b;
    private readonly byte[] f7f25cc3f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed f977f327c;
    private readonly int fa29bcde4;
    private readonly byte[] fa9d7e076;
    private readonly int fb0b29ead;
    private readonly byte[] fbabc65eb;
    private readonly int fbeef14ad;
    private readonly int fc8d5a43e;
    private readonly int fcd69b495;
    private readonly byte[] fceb20772;
    private readonly int fd6a12085;
    private readonly byte[] fdb9dd295;
    private readonly int fec402a43;
    private readonly int ff0c0d119;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed ffdc561b1;

    private p9db259a7(int i, byte[] bArr, byte[] bArr2, byte[] bArr3, int i2, int i3, int i4, int i5, p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed p63c054edVar) {
        this.fceb20772 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f5ebe2294 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        this.f15610cc2 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        this.f471dacea = i2;
        this.fcd69b495 = i3;
        this.f36373506 = i4;
        this.f2af72f10 = i5;
        this.f599dcce2 = i;
        this.f0ea7dd4d = p63c054edVar;
    }

    p9db259a7(int i, byte[] bArr, byte[] bArr2, byte[] bArr3, int i2, int i3, int i4, int i5, p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed p63c054edVar, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9db259a7$1 p9db259a7_1) {
        this(i, bArr, bArr2, bArr3, i2, i3, i4, i5, p63c054edVar);
    }

    public void Clear() {
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.fceb20772);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f5ebe2294);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m01bc6f8e(this.f15610cc2);
    }

    public byte[] GetAdditional() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f15610cc2);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p63c054ed GetCharTobyteConverter() {
        return this.f0ea7dd4d;
    }

    public int GetIterations() {
        return this.f471dacea;
    }

    public int GetLanes() {
        return this.f36373506;
    }

    public int GetMemory() {
        return this.fcd69b495;
    }

    public byte[] GetSalt() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fceb20772);
    }

    public byte[] GetSecret() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f5ebe2294);
    }

    public int GetType() {
        return this.f599dcce2;
    }

    public int GetVersion() {
        return this.f2af72f10;
    }
}

