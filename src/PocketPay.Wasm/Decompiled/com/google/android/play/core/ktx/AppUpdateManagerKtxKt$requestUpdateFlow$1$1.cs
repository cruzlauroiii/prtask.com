namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u000e\u0010\u0002\u001a\n \u0004*\u0004\u0018\u00010\u00030\u0003H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "updateInfo", "Lcom/google/android/play/core/appupdate/AppUpdateInfo;", "kotlin.jvm.PlatformType", "onSuccess"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdateManagerKtxKt$requestUpdateFlow$1$1<TResult> : com.google.android.gms.tasks.OnSuccessListener {
    readonly kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> $$this$callbackFlow;
    readonly com.google.android.play.core.ktx.AppUpdatePassthroughListener $globalUpdateListener;
    readonly com.google.android.play.core.appupdate.AppUpdateManager $this_requestUpdateFlow;

    AppUpdateManagerKtxKt$requestUpdateFlow$1$1(kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> producerScope, com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager, com.google.android.play.core.ktx.AppUpdatePassthroughListener appUpdatePassthroughListener) {
        this.$$this$callbackFlow = producerScope;
        this.$this_requestUpdateFlow = appUpdateManager;
        this.$globalUpdateListener = appUpdatePassthroughListener;
    }

    public static void BmmWRAJkxRHcuYIc(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager, com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener) {
        appUpdateManager.registerListener(installStateUpdatedListener);
    }

    public static bool FjBgZdZHOXTOXRln(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.Exception th, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(sendChannel, th, i, obj);
    }

    public static bool IxnfWNrTsUmIxCpG(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.Exception th, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(sendChannel, th, i, obj);
    }

    public static int PwsNApeYTVrQldFS(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo) {
        return appUpdateInfo.updateAvailability();
    }

    public static void QpuHnIHNNBeNljyC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool TqlKdtbXGbUozUdq(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        return com.google.android.play.core.ktx.AppUpdateManagerKtxKt.tryOffer(sendChannel, obj);
    }

    public static bool ZEPCDyOxfrzpyLSO(kotlinx.coroutines.channels.ProducerScope producerScope, java.lang.Exception th) {
        return producerScope.close(th);
    }

    public static void BWmMdeEoZlmuvfgQ(com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$1 appUpdateManagerKtxKt$requestUpdateFlow$1$1, com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo) {
        appUpdateManagerKtxKt$requestUpdateFlow$1$1.onSuccess(appUpdateInfo);
    }

    public static bool OEJNGvtpqJLcYQIu(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        return com.google.android.play.core.ktx.AppUpdateManagerKtxKt.tryOffer(sendChannel, obj);
    }

    public static int RzdZZGDxuoUxPQMy(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo) {
        return appUpdateInfo.installStatus();
    }

    public static bool VsAuCLqArJeNcAxb(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.object obj) {
        return com.google.android.play.core.ktx.AppUpdateManagerKtxKt.tryOffer(sendChannel, obj);
    }

    public readonly void OnSuccess(com.google.android.play.core.appupdate.AppUpdateInfo appUpdateInfo) {
        if ((25 + 7) % 7 > 0) {
        }
        int iPwsNApeYTVrQldFS = PwsNApeYTVrQldFS(appUpdateInfo);
        if (iPwsNApeYTVrQldFS == 0) {
            ZEPCDyOxfrzpyLSO(this.$$this$callbackFlow, new com.google.android.play.core.install.InstallException(-2));
            return;
        }
        if (iPwsNApeYTVrQldFS == 1) {
            oEJNGvtpqJLcYQIu(this.$$this$callbackFlow, com.google.android.play.core.ktx.AppUpdateResult$NotAvailable.INSTANCE);
            FjBgZdZHOXTOXRln(this.$$this$callbackFlow, null, 1, null);
        } else if (iPwsNApeYTVrQldFS == 2 || iPwsNApeYTVrQldFS == 3) {
            QpuHnIHNNBeNljyC(appUpdateInfo, "updateInfo");
            if (rzdZZGDxuoUxPQMy(appUpdateInfo) != 11) {
                BmmWRAJkxRHcuYIc(this.$this_requestUpdateFlow, this.$globalUpdateListener);
                vsAuCLqArJeNcAxb(this.$$this$callbackFlow, new com.google.android.play.core.ktx.AppUpdateResult$Available(this.$this_requestUpdateFlow, appUpdateInfo));
            } else {
                TqlKdtbXGbUozUdq(this.$$this$callbackFlow, new com.google.android.play.core.ktx.AppUpdateResult$Downloaded(this.$this_requestUpdateFlow));
                IxnfWNrTsUmIxCpG(this.$$this$callbackFlow, null, 1, null);
            }
        }
    }

    public override readonly void OnSuccess(java.lang.object obj) {
        bWmMdeEoZlmuvfgQ(this, (com.google.android.play.core.appupdate.AppUpdateInfo) obj);
    }
}

