namespace WillowMaze.Wasm.Decompiled;


public class p4715f007 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f0012ed2e;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 f166e64f6;
    private java.security.SecureRandom f4635417c;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f810601fc;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 fb0a744b9;
    private java.security.SecureRandom fe03ebb52;

    public p4715f007(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        this(pc9ef6b45Var, new java.security.SecureRandom());
    }

    public p4715f007(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var, java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = secureRandom;
        this.f166e64f6 = pc9ef6b45Var;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GetParameters() {
        return this.f166e64f6;
    }

    public java.security.SecureRandom GetRandom() {
        return this.f7ddf32e1;
    }
}

