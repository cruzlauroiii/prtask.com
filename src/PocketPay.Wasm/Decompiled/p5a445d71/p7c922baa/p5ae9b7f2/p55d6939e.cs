namespace WillowMaze.Wasm.Decompiled;


public class p55d6939e {
    protected int f5177790a;
    protected java.security.SecureRandom f542356f7;
    protected java.security.SecureRandom f7ddf32e1;
    protected int f8c13450b;
    protected java.security.SecureRandom fe543aa04;

    public static void YzPYUupIeppbNRfa(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.nextbytes(bArr);
    }

    public static java.security.SecureRandom MKZNjaYDSvilOjWl(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        return pf7bb6344Var.getRandom();
    }

    public static int RMonfrfYrKjybJmI(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        return pf7bb6344Var.getStrength();
    }

    public byte[] GenerateKey() {
        byte[] bArr = new byte[this.f5177790a];
        YzPYUupIeppbNRfa(this.f7ddf32e1, bArr);
        return bArr;
    }

    public void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        this.f7ddf32e1 = mKZNjaYDSvilOjWl(pf7bb6344Var);
        this.f5177790a = (rMonfrfYrKjybJmI(pf7bb6344Var) + 7) / 8;
    }
}

