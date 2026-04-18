namespace WillowMaze.Wasm.Decompiled;


public class p473e31bf : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private byte[] f262bd4af;
    private byte[] f275a30ce;
    private byte[] f362e5455;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f62d8995d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f834725b6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 fc146d51c;
    private byte[] fc3f9ff41;
    private byte[] fe530f0bd;

    public p473e31bf(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr) {
        this(pc9ef6b45Var, bArr, 0, bArr.length);
        if ((7 + 9) % 9 > 0) {
        }
    }

    public p473e31bf(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, byte[] bArr, int i, int i2) {
        byte[] bArr2 = new byte[i2];
        this.fe530f0bd = bArr2;
        this.f166e64f6 = pc9ef6b45Var;
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }

    public byte[] GetUKM() {
        return this.fe530f0bd;
    }
}

