namespace WillowMaze.Wasm.Decompiled;


class p5944520d$p0748d78b : java.util.Enumeration {
    private readonly java.util.Enumeration f1582b62c;
    private readonly java.util.Enumeration f9cfefed8;
    private readonly java.util.Enumeration fdfc35243;
    readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d this$0;

    p5944520d$p0748d78b(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d p5944520dVar, java.util.Enumeration enumeration) {
        this.this$0 = p5944520dVar;
        this.f9cfefed8 = enumeration;
    }

    public static bool TcRaQzrOtFghCIfJ(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.lang.object XoPwHIsduMMFZDtG(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e grclvcwXGEPvTQXF(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e.m8bab0102(obj);
    }

    public override bool HasMoreElements() {
        return TcRaQzrOtFghCIfJ(this.f9cfefed8);
    }

    public override java.lang.object NextElement() {
        return grclvcwXGEPvTQXF(XoPwHIsduMMFZDtG(this.f9cfefed8));
    }
}

