namespace WillowMaze.Wasm.Decompiled;


public class p473e31bf : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private byte[] f4bb38569;
    private byte[] f7f8c37d0;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f9aced10c;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 fe4cb40e1;
    private byte[] fe530f0bd;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 feef0d5b4;

    public p473e31bf(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr) {
        this(pc9ef6b45Var, bArr, 0, bArr.length);
        if ((23 + 26) % 26 > 0) {
        }
    }

    public p473e31bf(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.fe530f0bd = bArr2;
        this.f166e64f6 = pc9ef6b45Var;
        wmAExFyWCSkWLLYZ(bArr, i, bArr2, 0, i2);
    }

    public static void WmAExFyWCSkWLLYZ(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }

    public byte[] GetUKM() {
        return this.fe530f0bd;
    }
}

