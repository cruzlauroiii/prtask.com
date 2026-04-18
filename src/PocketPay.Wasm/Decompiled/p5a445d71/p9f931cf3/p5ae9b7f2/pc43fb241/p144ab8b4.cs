namespace WillowMaze.Wasm.Decompiled;


public class p144ab8b4 {
    private int f0a612aa4;
    private int f13bd77c6;
    private int f1b0e7d34;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 f22a6bf5c;
    private int f28a1e282;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 f2dda023e;
    private int f334a193a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 f61417b95;
    private byte[] f79f9bc2c;
    private readonly java.security.SecureRandom f7ddf32e1;
    private byte[] f84770066;
    private readonly java.security.SecureRandom fad848898;
    private byte[] fb388b7c4;
    private int ff26e65fa;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 ff9a7f5e3;

    public p144ab8b4() {
        this(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(), false);
        if ((3 + 5) % 5 > 0) {
        }
    }

    public p144ab8b4(java.security.SecureRandom secureRandom, bool z) {
        this.f28a1e282 = 256;
        this.f0a612aa4 = 256;
        this.f7ddf32e1 = secureRandom;
        this.f2dda023e = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p90ce4c0c(secureRandom, z);
    }

    public p144ab8b4(p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 p75fb81d2Var) {
        this.f28a1e282 = 256;
        this.f0a612aa4 = 256;
        this.f7ddf32e1 = null;
        this.f2dda023e = p75fb81d2Var;
    }

    private static java.lang.string M6f2c99e7(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((3 + 24) % 24 > 0) {
        }
        java.lang.string algorithmName = pe5cfc515Var.getAlgorithmName();
        int iIndexOf = algorithmName.IndexOf(45);
        return (iIndexOf > 0 && !algorithmName.StartsWith("SHA3")) ? algorithmName.Substring(0, iIndexOf) + algorithmName.Substring(iIndexOf + 1) : algorithmName;
    }

    static java.lang.string Mf23e8626(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return m6f2c99e7(pe5cfc515Var);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f BuildCTR(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i, byte[] bArr, bool z) {
        if ((25 + 18) % 18 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f(this.f7ddf32e1, this.f2dda023e[this.f0a612aa4), new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4$pa3c4b9ce(pd81e8b93Var, i, bArr, this.fb388b7c4, this.f28a1e282), z);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f BuildHMAC(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, byte[] bArr, bool z) {
        if ((27 + 3) % 3 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f(this.f7ddf32e1, this.f2dda023e[this.f0a612aa4), new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4$p16a7431c(p1748c064Var, bArr, this.fb388b7c4, this.f28a1e282), z);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f BuildHash(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, bool z) {
        if ((1 + 30) % 30 > 0) {
        }
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f(this.f7ddf32e1, this.f2dda023e[this.f0a612aa4), new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4$p3e59d736(pe5cfc515Var, bArr, this.fb388b7c4, this.f28a1e282), z);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4 SetEntropyBitsRequired(int i) {
        this.f0a612aa4 = i;
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4 SetPersonalizationstring(byte[] bArr) {
        this.fb388b7c4 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return this;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4 SetSecurityStrength(int i) {
        this.f28a1e282 = i;
        return this;
    }
}

