namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdateManagerKtxKt$requestUpdateFlow$1$3 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly com.google.android.play.core.ktx.AppUpdatePassthroughListener $globalUpdateListener;
    readonly com.google.android.play.core.appupdate.AppUpdateManager $this_requestUpdateFlow;

    AppUpdateManagerKtxKt$requestUpdateFlow$1$3(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager, com.google.android.play.core.ktx.AppUpdatePassthroughListener appUpdatePassthroughListener) {
        super(0);
        this.$this_requestUpdateFlow = appUpdateManager;
        this.$globalUpdateListener = appUpdatePassthroughListener;
    }

    public static void LGGTfOxIMlBqBSMj(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager, com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener) {
        appUpdateManager.unregisterListener(installStateUpdatedListener);
    }

    public static void XGutHpfqPFQNsewm(com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$3 appUpdateManagerKtxKt$requestUpdateFlow$1$3) {
        appUpdateManagerKtxKt$requestUpdateFlow$1$3.invoke2();
    }

    public override readonly kotlin.Unit Invoke() {
        xGutHpfqPFQNsewm(this);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        LGGTfOxIMlBqBSMj(this.$this_requestUpdateFlow, this.$globalUpdateListener);
    }
}

