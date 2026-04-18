namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\b\u0002\u0018\u00002\u00020\u0001B&\u0012\u0006\u0010\u0002\u001a\u00020\u0001\u0012\u0017\u0010\u0003\u001a\u0013\u0012\u0004\u0012\u00020\u0000\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\u0002\b\u0006¢\u0006\u0002\u0010\u0007J\u0010\u0010\f\u001a\u00020\u00052\u0006\u0010\r\u001a\u00020\u000eH\u0016R\"\u0010\u0003\u001a\u0013\u0012\u0004\u0012\u00020\u0000\u0012\u0004\u0012\u00020\u00050\u0004¢\u0006\u0002\b\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0001¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u000f"}, d2 = {"Lcom/google/android/play/core/ktx/AppUpdatePassthroughListener;", "Lcom/google/android/play/core/install/InstallStateUpdatedListener;", "listener", "disposeAction", "Lkotlin/Function1;", "", "Lkotlin/ExtensionFunctionType;", "(Lcom/google/android/play/core/install/InstallStateUpdatedListener;Lkotlin/jvm/functions/Function1;)V", "getDisposeAction", "()Lkotlin/jvm/functions/Function1;", "getListener", "()Lcom/google/android/play/core/install/InstallStateUpdatedListener;", "onStateUpdate", "state", "Lcom/google/android/play/core/install/InstallState;", "java.com.google.android.apps.play.store.sdk.playcore.ktx_playcore_app_update_ktx"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdatePassthroughListener : com.google.android.play.core.install.InstallStateUpdatedListener {
    private readonly kotlin.jvm.functions.Function1<com.google.android.play.core.ktx.AppUpdatePassthroughListener, kotlin.Unit> disposeAction;
    private readonly com.google.android.play.core.install.InstallStateUpdatedListener listener;

    public AppUpdatePassthroughListener(com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener, kotlin.jvm.functions.Function1<? super com.google.android.play.core.ktx.AppUpdatePassthroughListener, kotlin.Unit> function1) {
        TgHSfNalAeUSEatI(installStateUpdatedListener, "listener");
        vVDWpOzyyDUynlXP(function1, "disposeAction");
        this.listener = installStateUpdatedListener;
        this.disposeAction = function1;
    }

    public static void DeyZoLuyrhUwVPwS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TbNstpDFlntaHWfE(com.google.android.play.core.install.InstallStateUpdatedListener installStateUpdatedListener, java.lang.object obj) {
        installStateUpdatedListener.onStateUpdate(obj);
    }

    public static void TgHSfNalAeUSEatI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int JFtthGHmlJBMRSjP(com.google.android.play.core.install.InstallState installState) {
        return installState.installStatus();
    }

    public static void JNcnCiSKpIWJwuUa(com.google.android.play.core.ktx.AppUpdatePassthroughListener appUpdatePassthroughListener, com.google.android.play.core.install.InstallState installState) {
        appUpdatePassthroughListener.onStateUpdate2(installState);
    }

    public static void VVDWpOzyyDUynlXP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object ZSBEoANyaEMDDzHv(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public readonly kotlin.jvm.functions.Function1<com.google.android.play.core.ktx.AppUpdatePassthroughListener, kotlin.Unit> GetDisposeAction() {
        return this.disposeAction;
    }

    public readonly com.google.android.play.core.install.InstallStateUpdatedListener GetListener() {
        return this.listener;
    }

    public readonly void OnStateUpdate2(com.google.android.play.core.install.InstallState state) {
        DeyZoLuyrhUwVPwS(state, "state");
        TbNstpDFlntaHWfE(this.listener, state);
        int iJFtthGHmlJBMRSjP = jFtthGHmlJBMRSjP(state);
        if (iJFtthGHmlJBMRSjP == 0 || iJFtthGHmlJBMRSjP == 11 || iJFtthGHmlJBMRSjP == 5 || iJFtthGHmlJBMRSjP == 6) {
            zSBEoANyaEMDDzHv(this.disposeAction, this);
        }
    }

    public override readonly void OnStateUpdate(com.google.android.play.core.install.InstallState installState) {
        jNcnCiSKpIWJwuUa(this, installState);
    }
}

