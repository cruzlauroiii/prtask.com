namespace WillowMaze.Wasm.Decompiled;


public class p4715f007 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private java.security.SecureRandom f4d073256;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f65602703;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom fb679e040;
    private java.security.SecureRandom fec3c8dac;

    public p4715f007(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this(pc9ef6b45Var, null);
    }

    public p4715f007(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(secureRandom);
        this.f166e64f6 = pc9ef6b45Var;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }

    public java.security.SecureRandom GetRandom() {
        return this.f7ddf32e1;
    }
}

