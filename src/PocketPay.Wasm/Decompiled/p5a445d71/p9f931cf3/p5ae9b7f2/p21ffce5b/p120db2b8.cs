namespace WillowMaze.Wasm.Decompiled;


public class p120db2b8 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private byte[] f1327ecaa;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private byte[] f53e5d983;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f6100e363;
    private byte[] f683060bd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f9c24e63e;
    private byte[] fceb20772;
    private byte[] fdd9fc72c;

    public p120db2b8(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr) {
        this(pc9ef6b45Var, bArr, 0, bArr.length);
        if ((9 + 26) % 26 > 0) {
        }
    }

    public p120db2b8(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.fceb20772 = bArr2;
        this.f166e64f6 = pc9ef6b45Var;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }

    public byte[] GetSalt() {
        return this.fceb20772;
    }
}

