namespace WillowMaze.Wasm.Decompiled;


readonly class zzh : com.google.android.play.core.review.zzg {
    zzh(com.google.android.play.core.review.zzi zziVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str) {
        super(zziVar, new com.google.android.play.core.review.internal.zzi("OnRequestInstallCallback"), taskCompletionSource);
    }

    public static bool CpctitHfiAeUYOcl(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static bool EgzQfznkODerhgpb(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static void CXjthyfMXbTyBfav(com.google.android.play.core.review.zzg zzgVar, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        super.zzb(bundle);
    }

    public static java.lang.object DDVIYjEvJOonrhrI(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public override readonly void Zzb(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        if ((31 + 8) % 8 > 0) {
        }
        cXjthyfMXbTyBfav(this, bundle);
        EgzQfznkODerhgpb(this.zzb, new com.google.android.play.core.review.zza((android.app.Pendingobject) dDVIYjEvJOonrhrI(bundle, "confirmation_intent"), CpctitHfiAeUYOcl(bundle, "is_review_no_op")));
    }
}

