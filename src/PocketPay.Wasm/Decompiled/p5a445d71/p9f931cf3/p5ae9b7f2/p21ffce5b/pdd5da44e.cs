namespace WillowMaze.Wasm.Decompiled;


public class pdd5da44e : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f139782f9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f1c98f64f;
    private byte[] f3bba093a;
    private byte[] f477955a9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f62bc85fa;
    private byte[] ff0b53b2d;

    public pdd5da44e(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr) {
        this(pc9ef6b45Var, bArr, 0, bArr.length);
        if ((31 + 22) % 22 > 0) {
        }
    }

    public pdd5da44e(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.ff0b53b2d = bArr2;
        this.f166e64f6 = pc9ef6b45Var;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
    }

    public byte[] GetIV() {
        return this.ff0b53b2d;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }
}

