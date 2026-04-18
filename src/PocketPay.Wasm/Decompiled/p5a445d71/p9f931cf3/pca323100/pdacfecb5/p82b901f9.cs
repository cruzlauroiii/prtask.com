namespace WillowMaze.Wasm.Decompiled;


public class p82b901f9 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f1665294f;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f1a6de32b;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb80bb774;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fcb98288c;

    private p82b901f9(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        this.fb80bb774 = p364bf33aVar;
    }

    public static java.lang.string DJQiJaKYrMCYdtZj(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return p364bf33aVar.getId();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p82b901f9 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p82b901f9) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p82b901f9) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p82b901f9(yFqRXfAHPRJMmHha(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a YFqRXfAHPRJMmHha(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(obj);
    }

    public java.lang.string GetId() {
        return DJQiJaKYrMCYdtZj(this.fb80bb774);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.fb80bb774;
    }
}

