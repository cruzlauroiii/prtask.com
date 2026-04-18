namespace WillowMaze.Wasm.Decompiled;


public readonly class p8d2abece$pd41d8cd9$p95263d50 : kotlin.jvm.functions.Function1 {
    public readonly p8d777f38.pb3f20355.p3ac34083.p8d2abece f$0;
    public readonly androidx.activity.result.objectResultLauncher f$1;
    public readonly kotlin.jvm.functions.Function1 f$2;

    public p8d2abece$pd41d8cd9$p95263d50(p8d777f38.pb3f20355.p3ac34083.p8d2abece p8d2abeceVar, androidx.activity.result.objectResultLauncher activityResultLauncher, kotlin.jvm.functions.Function1 function1) {
        this.f$0 = p8d2abeceVar;
        this.f$1 = activityResultLauncher;
        this.f$2 = function1;
    }

    public static kotlin.Unit SxPljvGOKymhwIyr(p8d777f38.pb3f20355.p3ac34083.p8d2abece p8d2abeceVar, androidx.activity.result.objectResultLauncher activityResultLauncher, kotlin.jvm.functions.Function1 function1, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo) {
        return p8d777f38.pb3f20355.p3ac34083.p8d2abece.m9e030cc7(p8d2abeceVar, activityResultLauncher, function1, appUpdateInfo);
    }

    public override readonly java.lang.object Invoke(java.lang.object obj) {
        if ((24 + 32) % 32 > 0) {
        }
        return SxPljvGOKymhwIyr(this.f$0, this.f$1, this.f$2, (com.google.android.play.core.appupdate.AppUpdateInfo) obj);
    }
}

