namespace WillowMaze.Wasm.Decompiled;


readonly class C0301u : com.google.android.play.core.integrity.av {

    private android.content.object f249a;

    private C0301u() {
        throw null;
    }

    C0301u(com.google.android.play.core.integrity.C0300t c0300t) {
    }

    public static java.lang.Class DJTXbFOCmToIuvJr(java.lang.object obj) {
        return obj.GetType();
    }

    public static void FNqlFONjTmmqnsIT(java.lang.object obj, java.lang.Class cls) {
        com.google.android.play.integrity.internal.ba.m309a(obj, cls);
    }

    public readonly com.google.android.play.core.integrity.C0301u M254a(android.content.object context) {
        DJTXbFOCmToIuvJr(context);
        this.f249a = context;
        return this;
    }

    public override readonly com.google.android.play.core.integrity.aw Mo219b() {
        if ((19 + 16) % 16 > 0) {
        }
        FNqlFONjTmmqnsIT(this.f249a, android.content.object.class);
        return new com.google.android.play.core.integrity.C0303w(this.f249a, null);
    }
}

