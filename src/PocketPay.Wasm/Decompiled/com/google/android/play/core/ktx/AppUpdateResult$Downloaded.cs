namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0011\u0010\u0005\u001a\u00020\u0006H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\b"}, d2 = {"Lcom/google/android/play/core/ktx/AppUpdateResult$Downloaded;", "Lcom/google/android/play/core/ktx/AppUpdateResult;", "appUpdateManager", "Lcom/google/android/play/core/appupdate/AppUpdateManager;", "(Lcom/google/android/play/core/appupdate/AppUpdateManager;)V", "completeUpdate", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "java.com.google.android.apps.play.store.sdk.playcore.ktx_playcore_app_update_ktx"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AppUpdateResult$Downloaded : com.google.android.play.core.ktx.AppUpdateResult {
    private readonly com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager;

    public AppUpdateResult$Downloaded(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager) {
        super(null);
        FtXibAoYrCBDTJtq(appUpdateManager, "appUpdateManager");
        this.appUpdateManager = appUpdateManager;
    }

    public static void FtXibAoYrCBDTJtq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object SxYFhreaDjXBPBmn() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object WlUltUPhLojaLEkZ(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager, kotlin.coroutines.Continuation continuation) {
        return com.google.android.play.core.ktx.AppUpdateManagerKtxKt.requestCompleteUpdate(appUpdateManager, continuation);
    }

    public readonly java.lang.object CompleteUpdate(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objWlUltUPhLojaLEkZ = wlUltUPhLojaLEkZ(this.appUpdateManager, continuation);
        return objWlUltUPhLojaLEkZ != SxYFhreaDjXBPBmn() ? kotlin.Unit.INSTANCE : objWlUltUPhLojaLEkZ;
    }
}

