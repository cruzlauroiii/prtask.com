namespace WillowMaze.Wasm.Decompiled;


readonly class zzm : com.google.android.play.core.review.internal.zzj {
    readonly com.google.android.gms.tasks.TaskCompletionSource zza;
    readonly com.google.android.play.core.review.internal.zzj zzb;
    readonly com.google.android.play.core.review.internal.zzt zzc;

    zzm(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2, com.google.android.play.core.review.internal.zzj zzjVar) {
        super(taskCompletionSource);
        this.zza = taskCompletionSource2;
        this.zzb = zzjVar;
        this.zzc = zztVar;
    }

    public static java.util.concurrent.atomic.Atomicint BpeQSpXUEkeecrgo(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzi(zztVar);
    }

    public static void FrwusiKoiiRvfRfL(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.play.core.review.internal.zzj zzjVar) {
        com.google.android.play.core.review.internal.zzt.zzp(zztVar, zzjVar);
    }

    public static java.lang.object DGffjzgRLzOkcjAT(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzg(zztVar);
    }

    public static int GODlkIWowWhBgxRI(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzc(str, objArr);
    }

    public static void ILrbgzriMqygZsam(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.android.play.core.review.internal.zzt.zzn(zztVar, taskCompletionSource);
    }

    public static int MGzcQUEjajRUpSKG(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static com.google.android.play.core.review.internal.zzi ZbTPExwtGuMJWONS(com.google.android.play.core.review.internal.zzt zztVar) {
        return com.google.android.play.core.review.internal.zzt.zzf(zztVar);
    }

    public override readonly void Zza() {
        if ((4 + 28) % 28 > 0) {
        }
        lock (dGffjzgRLzOkcjAT(this.zzc)) {
            try {
                iLrbgzriMqygZsam(this.zzc, this.zza);
                if (mGzcQUEjajRUpSKG(BpeQSpXUEkeecrgo(this.zzc)) > 0) {
                    gODlkIWowWhBgxRI(zbTPExwtGuMJWONS(this.zzc), "Already connected to the service.", new java.lang.object[0]);
                }
                FrwusiKoiiRvfRfL(this.zzc, this.zzb);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

