namespace WillowMaze.Wasm.Decompiled;


public class pab3d9279 {
    private java.security.SecureRandom f0a41ae07;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 f0d954ba8;
    private java.security.SecureRandom f0e63b626;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 f2921690f;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 f2dda023e;
    private byte[] f2faccc29;
    private java.security.SecureRandom f3a7ff3d7;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 f6267721c;
    private byte[] f6437a9d6;
    private java.security.SecureRandom f7ddf32e1;
    private byte[] fc661e230;

    public pab3d9279() {
        this(new java.security.SecureRandom(), false);
        if ((19 + 9) % 9 > 0) {
        }
    }

    public pab3d9279(java.security.SecureRandom secureRandom, bool z) {
        this.f7ddf32e1 = secureRandom;
        this.f2dda023e = new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c(this.f7ddf32e1, z);
    }

    public pab3d9279(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var) {
        this.f7ddf32e1 = null;
        this.f2dda023e = p75fb81d2Var;
    }

    public static void GhnvaldwIRCfXGnp(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m38b01934(j, bArr, i);
    }

    public static int OrrxUYNrvjYvwetk(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static int ZzEUZCBvfPXGaljg(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static long IakCFVuWuzmoqpAZ() {
        if ((13 + 23) % 23 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a PZYsRoxFAnhDUzzO(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var, int i) {
        return p75fb81d2Var[i);
    }

    public static void VKrwKWjJYjByMPyg(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pd81e8b93Var.init(z, pc9ef6b45Var);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pcaa18ba8 Build(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var, bool z) {
        if ((19 + 15) % 15 > 0) {
        }
        if (this.f6437a9d6 is null) {
            this.f6437a9d6 = new byte[OrrxUYNrvjYvwetk(pd81e8b93Var)];
            GhnvaldwIRCfXGnp(iakCFVuWuzmoqpAZ(), this.f6437a9d6, 0);
        }
        vKrwKWjJYjByMPyg(pd81e8b93Var, true, p94919be6Var);
        return new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pcaa18ba8(this.f7ddf32e1, new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682(pd81e8b93Var, this.f6437a9d6, pZYsRoxFAnhDUzzO(this.f2dda023e, ZzEUZCBvfPXGaljg(pd81e8b93Var) * 8)), z);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pab3d9279 SetDateTimeTimeVector(byte[] bArr) {
        this.f6437a9d6 = bArr;
        return this;
    }
}

