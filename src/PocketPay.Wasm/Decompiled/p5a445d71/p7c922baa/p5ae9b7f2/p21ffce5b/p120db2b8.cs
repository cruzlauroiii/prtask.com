namespace WillowMaze.Wasm.Decompiled;


public class p120db2b8 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f2dba68cd;
    private byte[] f4241504b;
    private byte[] f4bea6ab1;
    private byte[] f8997c4bd;
    private byte[] f99b7bb31;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 fcea36fcd;
    private byte[] fceb20772;

    public p120db2b8(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr) {
        this(pc9ef6b45Var, bArr, 0, bArr.length);
        if ((6 + 10) % 10 > 0) {
        }
    }

    public p120db2b8(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.fceb20772 = bArr2;
        this.f166e64f6 = pc9ef6b45Var;
        CSyLjKvTFcgVGffs(bArr, i, bArr2, 0, i2);
    }

    public static void CSyLjKvTFcgVGffs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }

    public byte[] GetSalt() {
        return this.fceb20772;
    }
}

