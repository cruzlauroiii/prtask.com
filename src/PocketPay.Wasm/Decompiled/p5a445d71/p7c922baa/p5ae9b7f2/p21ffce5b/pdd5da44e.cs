namespace WillowMaze.Wasm.Decompiled;


public class pdd5da44e : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private byte[] f106bc1ba;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f14600cd9;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f7fabae86;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 fc67c6d23;
    private byte[] ff0b53b2d;

    public pdd5da44e(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr) {
        this(pc9ef6b45Var, bArr, 0, bArr.length);
        if ((19 + 1) % 1 > 0) {
        }
    }

    public pdd5da44e(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.ff0b53b2d = bArr2;
        this.f166e64f6 = pc9ef6b45Var;
        TJNMWjaLRKdDOSZt(bArr, i, bArr2, 0, i2);
    }

    public static void TJNMWjaLRKdDOSZt(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public byte[] GetIV() {
        return this.ff0b53b2d;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }
}

