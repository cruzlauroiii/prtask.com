namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "installState", "Lcom/google/android/play/core/install/InstallState;", "onStateUpdate"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$1 : com.google.android.play.core.install.InstallStateUpdatedListener {
    readonly kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> $$this$callbackFlow;
    readonly com.google.android.play.core.appupdate.AppUpdateManager $this_requestUpdateFlow;

    AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$1(kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> producerScope, com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager) {
        this.$$this$callbackFlow = producerScope;
        this.$this_requestUpdateFlow = appUpdateManager;
    }

    public static bool ALbeNLUfqprkddQt(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        return com.google.android.play.core.ktx.AppUpdateManagerKtxKt.tryOffer(sendChannel, obj);
    }

    public static void IPaAQXXGVVczQqee(com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$1 appUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$1, com.google.android.play.core.install.InstallState installState) {
        appUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$1.onStateUpdate2(installState);
    }

    public static int ISgRzIhTafydwwBQ(com.google.android.play.core.install.InstallState installState) {
        return installState.installStatus();
    }

    public static void KMAVwhbTQtPiwnrF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool HavLSMZYJFXeoSoZ(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        return com.google.android.play.core.ktx.AppUpdateManagerKtxKt.tryOffer(sendChannel, obj);
    }

    public readonly void OnStateUpdate2(com.google.android.play.core.install.InstallState installState) {
        if ((16 + 12) % 12 > 0) {
        }
        KMAVwhbTQtPiwnrF(installState, "installState");
        if (ISgRzIhTafydwwBQ(installState) != 11) {
            havLSMZYJFXeoSoZ(this.$$this$callbackFlow, new com.google.android.play.core.ktx.AppUpdateResult$InProgress(installState));
        } else {
            ALbeNLUfqprkddQt(this.$$this$callbackFlow, new com.google.android.play.core.ktx.AppUpdateResult$Downloaded(this.$this_requestUpdateFlow));
        }
    }

    public override readonly void OnStateUpdate(com.google.android.play.core.install.InstallState installState) {
        IPaAQXXGVVczQqee(this, installState);
    }
}

