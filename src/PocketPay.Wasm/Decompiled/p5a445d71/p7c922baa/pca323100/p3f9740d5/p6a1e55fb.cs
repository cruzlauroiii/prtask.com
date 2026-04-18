namespace WillowMaze.Wasm.Decompiled;


public class p6a1e55fb : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 f0b3f66b2;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 f101517c1;
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 f3d4557e6;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 f4ddccf06;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 f871ab5e8;
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 f8e68df4c;
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 f97a2169e;
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 fb016d16e;
    private readonly p5a445d71.p7c922baa.pca323100.pb907b377 fbbb6c99b;

    public p6a1e55fb(java.util.DateTime date) {
        this(new p5a445d71.p7c922baa.pca323100.pb907b377(date));
    }

    public p6a1e55fb(p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 p32555e78Var) {
        this.f4ddccf06 = null;
        this.f97a2169e = p32555e78Var;
    }

    public p6a1e55fb(p5a445d71.p7c922baa.pca323100.pb907b377 pb907b377Var) {
        this.f4ddccf06 = pb907b377Var;
        this.f97a2169e = null;
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 BoCfHCZwHlYWbRtb(p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 p32555e78Var) {
        return p32555e78Var.toASN1Primitive();
    }

    public static java.lang.string FyaNLMayUDtwsXhI(java.lang.object obj) {
        return obj.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.pb907b377 JjYLtBpDqWyXOpQG(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pb907b377.m8bab0102(obj);
    }

    public static java.lang.string OmLZrvOTXrZCDYdW(java.lang.object obj) {
        return obj.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p3f9740d5.p6a1e55fb HROOkIqRjxRTNNJk(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 LisOxNqFKPCFPoSe(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p3f9740d5.p6a1e55fb M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p3f9740d5.p6a1e55fb) {
            return (p5a445d71.p7c922baa.pca323100.p3f9740d5.p6a1e55fb) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.pb907b377) {
            return new p5a445d71.p7c922baa.pca323100.p3f9740d5.p6a1e55fb(JjYLtBpDqWyXOpQG(obj));
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p3f9740d5.p6a1e55fb(lisOxNqFKPCFPoSe(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p3f9740d5.p6a1e55fb M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return hROOkIqRjxRTNNJk(xTjTRkfBUGtShNGc(p582a4948Var));
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 XTjTRkfBUGtShNGc(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public p5a445d71.p7c922baa.pca323100.pb907b377 GetGenTime() {
        return this.f4ddccf06;
    }

    public p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 GetTimeStampToken() {
        return this.f97a2169e;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        p5a445d71.p7c922baa.pca323100.pb907b377 pb907b377Var = this.f4ddccf06;
        return pb907b377Var is null ? BoCfHCZwHlYWbRtb(this.f97a2169e) : pb907b377Var;
    }

    public java.lang.string Tostring() {
        p5a445d71.p7c922baa.pca323100.pb907b377 pb907b377Var = this.f4ddccf06;
        return pb907b377Var is null ? OmLZrvOTXrZCDYdW(this.f97a2169e) : FyaNLMayUDtwsXhI(pb907b377Var);
    }
}

