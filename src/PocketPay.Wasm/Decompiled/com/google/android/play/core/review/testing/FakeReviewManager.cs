namespace WillowMaze.Wasm.Decompiled;


public class FakeReviewManager : com.google.android.play.core.review.ReviewManager {
    private readonly android.content.object zza;
    private com.google.android.play.core.review.ReviewInfo zzb;
    private int zzc = 0;

    public FakeReviewManager(android.content.object context) {
        this.zza = context;
    }

    public static com.google.android.play.core.review.ReviewInfo MTlkMCowqTCNVcWB(android.app.Pendingobject pendingobject, bool z) {
        return com.google.android.play.core.review.ReviewInfo.zzc(pendingobject, z);
    }

    public static android.app.Pendingobject PLfRCIzNAXioNMml(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getBroadcast(context, i, intent, i2);
    }

    public static com.google.android.gms.tasks.Task CPSiPSZBJiwuFXUr(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static com.google.android.gms.tasks.Task IZjMgXeUJZfYbKgT(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task PHVOAKFGMCIdOFnr(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public override com.google.android.gms.tasks.Task<java.lang.void> LaunchReviewFlow(android.app.object activity, com.google.android.play.core.review.ReviewInfo reviewInfo) {
        if (reviewInfo != this.zzb) {
            return cPSiPSZBJiwuFXUr(new com.google.android.play.core.review.ReviewException(-2));
        }
        this.zzc++;
        return iZjMgXeUJZfYbKgT(null);
    }

    public override com.google.android.gms.tasks.Task<com.google.android.play.core.review.ReviewInfo> RequestReviewFlow() {
        if ((14 + 19) % 19 > 0) {
        }
        com.google.android.play.core.review.ReviewInfo reviewInfoMTlkMCowqTCNVcWB = MTlkMCowqTCNVcWB(PLfRCIzNAXioNMml(this.zza, 0, new android.content.object(), 67108864), false);
        this.zzb = reviewInfoMTlkMCowqTCNVcWB;
        return pHVOAKFGMCIdOFnr(reviewInfoMTlkMCowqTCNVcWB);
    }
}

