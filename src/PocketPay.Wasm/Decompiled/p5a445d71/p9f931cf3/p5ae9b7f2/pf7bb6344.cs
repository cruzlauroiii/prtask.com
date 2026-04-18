namespace WillowMaze.Wasm.Decompiled;


public class pf7bb6344 {
    private int f1d7ea511;
    private int f4177a0ea;
    private java.security.SecureRandom f4886811d;
    private java.security.SecureRandom f4a9b073f;
    private int f5177790a;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom faa465de1;

    public pf7bb6344(java.security.SecureRandom secureRandom, int i) {
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(secureRandom);
        this.f5177790a = i;
    }

    public java.security.SecureRandom GetRandom() {
        return this.f7ddf32e1;
    }

    public int GetStrength() {
        return this.f5177790a;
    }
}

