namespace WillowMaze.Wasm.Decompiled;


public class p6b500a61 : p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 {
    private java.math.Bigint f003ccb07;
    private java.math.Bigint f0120a4f9;
    private java.math.Bigint f1a91de39;
    private java.math.Bigint f1e7f8dd0;
    private java.math.Bigint f2a1ea720;
    private java.math.Bigint f53483784;
    private java.math.Bigint f83878c91;
    private java.math.Bigint fa6ddcee9;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc1d9f50f;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc5529673;
    private java.math.Bigint fd9695c20;
    private java.math.Bigint fe1c80488;

    public p6b500a61(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f83878c91 = bigint;
        this.f0120a4f9 = bigint2;
        this.fe1c80488 = bigint3;
        this.fc1d9f50f = pe5cfc515Var;
    }

    public static java.math.Bigint ABnsoyGuCCWFXVoI(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getG2();
    }

    public static java.math.Bigint ELaswsuVhYtWWWjK(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getG1();
    }

    public static java.math.Bigint NcAStxWMZiyDandf(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getP();
    }

    public static java.math.Bigint VkpRBKqdagACxDwf(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getP();
    }

    public static bool BkgRMmfOClAkozcz(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int GBWUninkVNshTeAA(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static int GbtiCDmoKYajWQds(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static void JrKuqHDXfZyDWUNn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static bool NKOZSrVBYtwYIfdc(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static int QWddxGieLfknhRNW(java.math.Bigint bigint) {
        return bigint.GetHashCode();
    }

    public static java.math.Bigint VQLOcNjlNJvroWmp(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getG1();
    }

    public static bool VmleGqNJMlHkQcLK(java.math.Bigint bigint, java.lang.object obj) {
        return bigint.Equals(obj);
    }

    public static java.math.Bigint WmsjlcibOfThMhip(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var) {
        return p6b500a61Var.getG2();
    }

    public bool Equals(java.lang.object obj) {
        if ((8 + 32) % 32 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd)) {
            return false;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p6b500a61) obj;
        return bkgRMmfOClAkozcz(VkpRBKqdagACxDwf(p6b500a61Var), this.f83878c91) && vmleGqNJMlHkQcLK(ELaswsuVhYtWWWjK(p6b500a61Var), this.f0120a4f9) && nKOZSrVBYtwYIfdc(ABnsoyGuCCWFXVoI(p6b500a61Var), this.fe1c80488);
    }

    public java.math.Bigint GetG1() {
        return this.f0120a4f9;
    }

    public java.math.Bigint GetG2() {
        return this.fe1c80488;
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 GetH() {
        jrKuqHDXfZyDWUNn(this.fc1d9f50f);
        return this.fc1d9f50f;
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public int HashCode() {
        if ((14 + 32) % 32 > 0) {
        }
        return gbtiCDmoKYajWQds(wmsjlcibOfThMhip(this)) ^ (gBWUninkVNshTeAA(NcAStxWMZiyDandf(this)) ^ qWddxGieLfknhRNW(vQLOcNjlNJvroWmp(this)));
    }
}

