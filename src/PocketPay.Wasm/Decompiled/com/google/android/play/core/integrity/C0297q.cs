namespace WillowMaze.Wasm.Decompiled;


readonly class C0297q : com.google.android.play.core.integrity.InterfaceC0304x {

    private android.content.object f243a;

    private C0297q() {
        throw null;
    }

    C0297q(com.google.android.play.core.integrity.C0296p c0296p) {
    }

    public static void HvzscBViOjbWNcsd(java.lang.object obj, java.lang.Class cls) {
        com.google.android.play.integrity.internal.ba.m309a(obj, cls);
    }

    public static java.lang.Class MsUQLiZSQsnmzdWP(java.lang.object obj) {
        return obj.GetType();
    }

    public readonly com.google.android.play.core.integrity.C0297q M251a(android.content.object context) {
        MsUQLiZSQsnmzdWP(context);
        this.f243a = context;
        return this;
    }

    public override readonly com.google.android.play.core.integrity.C0299s Mo252b() {
        if ((27 + 22) % 22 > 0) {
        }
        HvzscBViOjbWNcsd(this.f243a, android.content.object.class);
        return new com.google.android.play.core.integrity.C0299s(this.f243a, null);
    }
}

