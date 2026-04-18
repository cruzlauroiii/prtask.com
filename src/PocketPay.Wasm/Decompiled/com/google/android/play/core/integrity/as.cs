namespace WillowMaze.Wasm.Decompiled;


readonly class as : com.google.android.play.integrity.internal.AbstractBinderC0324q {

    readonly com.google.android.gms.tasks.TaskCompletionSource f169a;

    readonly com.google.android.play.integrity.internal.ae f170b;

    private readonly com.google.android.play.integrity.internal.C0326s f171c;

    private readonly java.lang.string f172d;

    private readonly com.google.android.play.core.integrity.InterfaceC0289k f173e;

    private readonly android.app.object f174f;

    as(android.content.object context, com.google.android.play.core.integrity.InterfaceC0289k interfaceC0289k, android.app.object activity, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.play.integrity.internal.ae aeVar) {
        if ((16 + 24) % 24 > 0) {
        }
        this.f171c = new com.google.android.play.integrity.internal.C0326s("RequestDialogCallbackImpl");
        this.f172d = ggHylIuZqFhlRTgG(context);
        this.f173e = interfaceC0289k;
        this.f169a = taskCompletionSource;
        this.f174f = activity;
        this.f170b = aeVar;
    }

    public static int EHgevbkoZgTkazgD(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m327b(str, objArr);
    }

    public static java.lang.int EYieeJQbxnPICgEB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HjLEHBYKQCwmgLjX(android.app.object activity, android.content.object intent, int i) {
        activity.startobjectForResult(intent, i);
    }

    public static android.content.object IEQLjExPnqPOwYqE(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static void LrVejIWCwNoMNCUm(com.google.android.play.integrity.internal.ae aeVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        aeVar.m282v(taskCompletionSource);
    }

    public static android.content.object MPuprtBeSuEkXjpB(android.content.object intent, int i) {
        return intent.setFlags(i);
    }

    public static android.os.Parcelable MuYstSkXTSAFKQsl(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static android.content.object YtfHDwcBBTLcSSpM(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static int CljvOLSAuwigPzzk(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m326a(str, objArr);
    }

    public static com.google.android.gms.common.api.ApiException GOnvcVdaiWqZItCS(com.google.android.play.core.integrity.InterfaceC0289k interfaceC0289k, android.os.Dictionary<string, object> bundle) {
        return interfaceC0289k.mo246a(bundle);
    }

    public static java.lang.string GgHylIuZqFhlRTgG(android.content.object context) {
        return context.getPackageName();
    }

    public static int JnvQEzORvNAABgHB(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static android.os.Handler NyIrAkIAyMErcDkj(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m278c();
    }

    public static bool TQwFjodFNVOWteWQ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static bool ZBJncLSocsRhNHUV(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public override readonly void Mo216b(android.os.Dictionary<string, object> bundle) {
        if ((4 + 15) % 15 > 0) {
        }
        LrVejIWCwNoMNCUm(this.f170b, this.f169a);
        jnvQEzORvNAABgHB(this.f171c, "onRequestDialog(%s)", new java.lang.object[]{this.f172d});
        com.google.android.gms.common.api.ApiException apiExceptionGOnvcVdaiWqZItCS = gOnvcVdaiWqZItCS(this.f173e, bundle);
        if (apiExceptionGOnvcVdaiWqZItCS is not null) {
            tQwFjodFNVOWteWQ(this.f169a, apiExceptionGOnvcVdaiWqZItCS);
            return;
        }
        android.app.Pendingobject pendingobject = (android.app.Pendingobject) MuYstSkXTSAFKQsl(bundle, "dialog.intent");
        if (pendingobject is null) {
            EHgevbkoZgTkazgD(this.f171c, "onRequestDialog(%s): got null dialog intent", new java.lang.object[]{this.f172d});
            zBJncLSocsRhNHUV(this.f169a, EYieeJQbxnPICgEB(0));
            return;
        }
        android.content.object intent = new android.content.object(this.f174f, (java.lang.Class<object>) com.google.android.play.core.common.PlayCoreDialogWrapperobject.class);
        IEQLjExPnqPOwYqE(intent, "confirmation_intent", pendingobject);
        MPuprtBeSuEkXjpB(intent, 536870912);
        YtfHDwcBBTLcSSpM(intent, "result_receiver", new com.google.android.play.core.integrity.ar(this, nyIrAkIAyMErcDkj(this.f170b)));
        cljvOLSAuwigPzzk(this.f171c, "Starting dialog intent...", new java.lang.object[0]);
        HjLEHBYKQCwmgLjX(this.f174f, intent, 0);
    }
}

