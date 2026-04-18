namespace WillowMaze.Wasm.Decompiled;


public class pab3d9279 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 f2dda023e;
    private java.security.SecureRandom f5c6632a3;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 f634c2e79;
    private byte[] f6437a9d6;
    private java.security.SecureRandom f7ddf32e1;
    private byte[] fa67f0fd5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 fb06e8a2c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 ff2146dd3;

    public pab3d9279() {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(), false);
        if ((8 + 20) % 20 > 0) {
        }
    }

    public pab3d9279(java.security.SecureRandom secureRandom, bool z) {
        this.f7ddf32e1 = secureRandom;
        this.f2dda023e = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c(this.f7ddf32e1, z);
    }

    public pab3d9279(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var) {
        this.f7ddf32e1 = null;
        this.f2dda023e = p75fb81d2Var;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pcaa18ba8 Build(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, bool z) {
        if ((4 + 20) % 20 > 0) {
        }
        if (this.f6437a9d6 is null) {
            this.f6437a9d6 = new byte[pd81e8b93Var.getBlockSize()];
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m38b01934(java.lang.System.currentTimeMillis(), this.f6437a9d6, 0);
        }
        pd81e8b93Var.init(true, p94919be6Var);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pcaa18ba8(this.f7ddf32e1, new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pe1a82682(pd81e8b93Var, this.f6437a9d6, this.f2dda023e[pd81e8b93Var.getBlockSize() * 8)), z);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pab3d9279 SetDateTimeTimeVector(byte[] bArr) {
        this.f6437a9d6 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return this;
    }
}

