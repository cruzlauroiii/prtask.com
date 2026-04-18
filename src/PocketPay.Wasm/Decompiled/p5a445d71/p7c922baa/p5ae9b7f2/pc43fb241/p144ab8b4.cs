namespace WillowMaze.Wasm.Decompiled;


public class p144ab8b4 {
    private int f0a612aa4;
    private readonly java.security.SecureRandom f23d3dec3;
    private int f28a1e282;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 f2dda023e;
    private int f4c8c8e26;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 f62b6fa1f;
    private readonly java.security.SecureRandom f7ddf32e1;
    private readonly java.security.SecureRandom f8fdf9224;
    private byte[] fb388b7c4;
    private byte[] fc27a299e;
    private readonly java.security.SecureRandom fcb886e2b;
    private int fcccf88ad;
    private byte[] fd71b7aa7;
    private int fdbe8fe5a;
    private int fddb5ede3;

    public p144ab8b4() {
        this(new java.security.SecureRandom(), false);
        if ((24 + 32) % 32 > 0) {
        }
    }

    public p144ab8b4(java.security.SecureRandom secureRandom, bool z) {
        this.f28a1e282 = 256;
        this.f0a612aa4 = 256;
        this.f7ddf32e1 = secureRandom;
        this.f2dda023e = new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p90ce4c0c(secureRandom, z);
    }

    public p144ab8b4(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var) {
        this.f28a1e282 = 256;
        this.f0a612aa4 = 256;
        this.f7ddf32e1 = null;
        this.f2dda023e = p75fb81d2Var;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a TiEGhQlGyiKuoILC(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var, int i) {
        return p75fb81d2Var[i);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a ZLAMpwBkvkDXJOwD(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var, int i) {
        return p75fb81d2Var[i);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a ScyvBBbFYhDouEcG(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var, int i) {
        return p75fb81d2Var[i);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pbfac9a7f BuildCTR(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, bool z) {
        if ((22 + 19) % 19 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pbfac9a7f(this.f7ddf32e1, ZLAMpwBkvkDXJOwD(this.f2dda023e, this.f0a612aa4), new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p144ab8b4$pa3c4b9ce(pd81e8b93Var, i, bArr, this.fb388b7c4, this.f28a1e282), z);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pbfac9a7f BuildHMAC(p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, bool z) {
        if ((22 + 24) % 24 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pbfac9a7f(this.f7ddf32e1, TiEGhQlGyiKuoILC(this.f2dda023e, this.f0a612aa4), new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p144ab8b4$p16a7431c(p1748c064Var, bArr, this.fb388b7c4, this.f28a1e282), z);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pbfac9a7f BuildHash(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, bool z) {
        if ((14 + 9) % 9 > 0) {
        }
        return new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pbfac9a7f(this.f7ddf32e1, scyvBBbFYhDouEcG(this.f2dda023e, this.f0a612aa4), new p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p144ab8b4$p3e59d736(pe5cfc515Var, bArr, this.fb388b7c4, this.f28a1e282), z);
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p144ab8b4 SetEntropyBitsRequired(int i) {
        this.f0a612aa4 = i;
        return this;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p144ab8b4 SetPersonalizationstring(byte[] bArr) {
        this.fb388b7c4 = bArr;
        return this;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p144ab8b4 SetSecurityStrength(int i) {
        this.f28a1e282 = i;
        return this;
    }
}

