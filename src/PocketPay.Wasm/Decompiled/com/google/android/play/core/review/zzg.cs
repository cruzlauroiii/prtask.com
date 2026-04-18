namespace WillowMaze.Wasm.Decompiled;


class zzg : com.google.android.play.core.review.internal.zzg {
    readonly com.google.android.play.core.review.internal.zzi zza;
    readonly com.google.android.gms.tasks.TaskCompletionSource zzb;
    readonly com.google.android.play.core.review.zzi zzc;

    zzg(com.google.android.play.core.review.zzi zziVar, com.google.android.play.core.review.internal.zzi zziVar2, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.zzc = zziVar;
        this.zza = zziVar2;
        this.zzb = taskCompletionSource;
    }

    public static int GlNagRJwCjlgmWzl(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzc(str, objArr);
    }

    public static void GUenUvqsTupBjilv(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        zztVar.zzu(taskCompletionSource);
    }

    public override void Zzb(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        com.google.android.play.core.review.internal.zzt zztVar = this.zzc.zza;
        if (zztVar is not null) {
            gUenUvqsTupBjilv(zztVar, this.zzb);
        }
        GlNagRJwCjlgmWzl(this.zza, "onGetLaunchReviewFlowInfo", new java.lang.object[0]);
    }
}

