namespace WillowMaze.Wasm.Decompiled;


readonly class aa : com.google.android.play.integrity.internal.AbstractActionC0327t {

    readonly android.os.IBinder f264a;

    readonly com.google.android.play.integrity.internal.ad f265b;

    aa(com.google.android.play.integrity.internal.ad adVar, android.os.IBinder iBinder) {
        this.f264a = iBinder;
        this.f265b = adVar;
    }

    public static java.util.IEnumerator BClCOEFoYvFLIFuF(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void DRkqutOkmOTVJkis(java.lang.Action runnable) {
        runnable.run();
    }

    public static void PaURTElXYsFSLkpI(com.google.android.play.integrity.internal.ae aeVar, bool z) {
        com.google.android.play.integrity.internal.ae.m269m(aeVar, z);
    }

    public static bool UbTXJPHDmZOqBOVI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List VMdRCWexdAPVcZtf(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m265i(aeVar);
    }

    public static void LOFnNKECzfStAUak(com.google.android.play.integrity.internal.ae aeVar) {
        com.google.android.play.integrity.internal.ae.m274r(aeVar);
    }

    public static java.lang.object NSrlGCMwnFAdhGLk(com.google.android.play.integrity.internal.InterfaceC0333z interfaceC0333z, android.os.IBinder iBinder) {
        return interfaceC0333z.mo203a(iBinder);
    }

    public static java.lang.object RYYvEwqXYWfmlPyr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VfZMwmKqAAPLDWcw(com.google.android.play.integrity.internal.ae aeVar, android.os.IInterface iInterface) {
        com.google.android.play.integrity.internal.ae.m270n(aeVar, iInterface);
    }

    public static com.google.android.play.integrity.internal.InterfaceC0333z WllOvPkyGmeTuEkT(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m263g(aeVar);
    }

    public static java.util.List XjRmsZbOKSkKusvO(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m265i(aeVar);
    }

    public static void ZquIrlxgbFnBWFPk(java.util.List list) {
        list.clear();
    }

    public override readonly void Mo205b() {
        if ((30 + 28) % 28 > 0) {
        }
        vfZMwmKqAAPLDWcw(this.f265b.f267a, (android.os.IInterface) nSrlGCMwnFAdhGLk(wllOvPkyGmeTuEkT(this.f265b.f267a), this.f264a));
        lOFnNKECzfStAUak(this.f265b.f267a);
        PaURTElXYsFSLkpI(this.f265b.f267a, false);
        java.util.IEnumerator itBClCOEFoYvFLIFuF = BClCOEFoYvFLIFuF(xjRmsZbOKSkKusvO(this.f265b.f267a));
        while (UbTXJPHDmZOqBOVI(itBClCOEFoYvFLIFuF)) {
            DRkqutOkmOTVJkis((java.lang.Action) rYYvEwqXYWfmlPyr(itBClCOEFoYvFLIFuF));
        }
        zquIrlxgbFnBWFPk(VMdRCWexdAPVcZtf(this.f265b.f267a));
    }
}

