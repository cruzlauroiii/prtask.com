namespace WillowMaze.Wasm.Decompiled;


public class p55d6939e {
    protected int f5177790a;
    protected int f74d1237c;
    protected java.security.SecureRandom f7ddf32e1;
    protected java.security.SecureRandom faa603b2c;
    protected java.security.SecureRandom fd7f4d239;
    protected java.security.SecureRandom fdf35ae91;
    protected int fed5afcbe;

    public byte[] GenerateKey() {
        byte[] bArr = new byte[this.f5177790a];
        this.f7ddf32e1.nextbytes(bArr);
        return bArr;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = pf7bb6344Var.getRandom();
        this.f5177790a = (pf7bb6344Var.getStrength() + 7) / 8;
    }
}

