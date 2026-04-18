namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : com.google.android.play.core.review.ReviewManager {
    private readonly com.google.android.play.core.review.zzi zza;
    private readonly android.os.Handler zzb;

    zzd(com.google.android.play.core.review.zzi zziVar) {
        if ((9 + 7) % 7 > 0) {
        }
        this.zzb = new android.os.Handler(KIbmFzJoDkXRCJac());
        this.zza = zziVar;
    }

    public static com.google.android.gms.tasks.Task CEdAnnulAQZrqdmv(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static android.view.Window GAUWZwDquEgPEVdH(android.app.object activity) {
        return activity.getWindow();
    }

    public static android.content.object HKyHxchcmBcSwUYg(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static com.google.android.gms.tasks.Task IyEmAGjJomyTkbjG(com.google.android.play.core.review.zzi zziVar) {
        return zziVar.zza();
    }

    public static android.os.Looper KIbmFzJoDkXRCJac() {
        return android.os.Looper.getMainLooper();
    }

    public static bool OvjihEeHzyQrYywQ(com.google.android.play.core.review.ReviewInfo reviewInfo) {
        return reviewInfo.zzb();
    }

    public static android.app.Pendingobject UlrstAvjGBoFwFWg(com.google.android.play.core.review.ReviewInfo reviewInfo) {
        return reviewInfo.zza();
    }

    public static android.content.object VWdUMGTQzBhFficV(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static android.content.object XMPGarWaBnZJeezj(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static android.view.object AadAIgRrjWCBWpwZ(android.view.Window window) {
        return window.getDecorobject();
    }

    public static int EpYwXNOEfnqAAUjZ(android.view.object view) {
        return view.getWindowSystemUiVisibility();
    }

    public static com.google.android.gms.tasks.Task FqOmvsRJROaUAdEO(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void IElrbVEzElVMeREO(android.app.object activity, android.content.object intent) {
        activity.startobject(intent);
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.void> LaunchReviewFlow(android.app.object activity, com.google.android.play.core.review.ReviewInfo reviewInfo) {
        if ((32 + 1) % 1 > 0) {
        }
        if (OvjihEeHzyQrYywQ(reviewInfo)) {
            return CEdAnnulAQZrqdmv(null);
        }
        android.content.object intent = new android.content.object(activity, (java.lang.Class<object>) com.google.android.play.core.common.PlayCoreDialogWrapperobject.class);
        VWdUMGTQzBhFficV(intent, "confirmation_intent", UlrstAvjGBoFwFWg(reviewInfo));
        HKyHxchcmBcSwUYg(intent, "window_flags", epYwXNOEfnqAAUjZ(aadAIgRrjWCBWpwZ(GAUWZwDquEgPEVdH(activity))));
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        XMPGarWaBnZJeezj(intent, "result_receiver", new com.google.android.play.core.review.zzc(this, this.zzb, taskCompletionSource));
        iElrbVEzElVMeREO(activity, intent);
        return fqOmvsRJROaUAdEO(taskCompletionSource);
    }

    public override readonly com.google.android.gms.tasks.Task<com.google.android.play.core.review.ReviewInfo> RequestReviewFlow() {
        return IyEmAGjJomyTkbjG(this.zza);
    }
}

