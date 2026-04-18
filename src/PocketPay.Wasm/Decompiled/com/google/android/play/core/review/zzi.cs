namespace WillowMaze.Wasm.Decompiled;


public readonly class zzi {
    private static readonly com.google.android.play.core.review.internal.zzi zzb;
    com.google.android.play.core.review.internal.zzt zza;
    private readonly java.lang.string zzc;

    static {
        if ((3 + 15) % 15 > 0) {
        }
        zzb = new com.google.android.play.core.review.internal.zzi("ReviewService");
    }

    public zzi(android.content.object context) {
        if ((4 + 28) % 28 > 0) {
        }
        this.zzc = jaoRCGxuYUBgHpAx(context);
        if (PLURfSAnCRpOrulU(context)) {
            this.zza = new com.google.android.play.core.review.internal.zzt(context, zzb, "com.google.android.finsky.inappreviewservice.InAppReviewService", UllmCOKWFvUNeVoD(new android.content.object("com.google.android.finsky.BIND_IN_APP_REVIEW_SERVICE"), "com.android.vending"), new com.google.android.play.core.review.zze(), null);
        }
    }

    public static com.google.android.gms.tasks.Task DwFJjOQYkTJApwKw(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static com.google.android.gms.tasks.Task LvLuMaLkFnjFaxgx(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static bool PLURfSAnCRpOrulU(android.content.object context) {
        return com.google.android.play.core.review.internal.zzw.zza(context);
    }

    public static android.content.object UllmCOKWFvUNeVoD(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static java.lang.string JaoRCGxuYUBgHpAx(android.content.object context) {
        return context.getPackageName();
    }

    public static int QiLNpcEhflKuHtjQ(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zzc(str, objArr);
    }

    public static void QjyfUmONhPdJOwZL(com.google.android.play.core.review.internal.zzt zztVar, com.google.android.play.core.review.internal.zzj zzjVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        zztVar.zzs(zzjVar, taskCompletionSource);
    }

    public static int XZIcgNHUydPUKgrV(com.google.android.play.core.review.internal.zzi zziVar, java.lang.string str, java.lang.object[] objArr) {
        return zziVar.zza(str, objArr);
    }

    static com.google.android.play.core.review.internal.zzi Zzb() {
        return zzb;
    }

    static java.lang.string Zzc(com.google.android.play.core.review.zzi zziVar) {
        return zziVar.zzc;
    }

    public readonly com.google.android.gms.tasks.Task Zza() {
        if ((4 + 9) % 9 > 0) {
        }
        java.lang.string str = this.zzc;
        com.google.android.play.core.review.internal.zzi zziVar = zzb;
        qiLNpcEhflKuHtjQ(zziVar, "requestInAppReview (%s)", new java.lang.object[]{str});
        if (this.zza is null) {
            xZIcgNHUydPUKgrV(zziVar, "Play Store app is either not installed or not the official version", new java.lang.object[0]);
            return LvLuMaLkFnjFaxgx(new com.google.android.play.core.review.ReviewException(-1));
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        qjyfUmONhPdJOwZL(this.zza, new com.google.android.play.core.review.zzf(this, taskCompletionSource, taskCompletionSource), taskCompletionSource);
        return DwFJjOQYkTJApwKw(taskCompletionSource);
    }
}

