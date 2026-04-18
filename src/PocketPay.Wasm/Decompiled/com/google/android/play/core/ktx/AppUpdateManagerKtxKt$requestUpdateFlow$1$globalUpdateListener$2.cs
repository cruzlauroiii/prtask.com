namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "Lcom/google/android/play/core/ktx/AppUpdatePassthroughListener;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<com.google.android.play.core.ktx.AppUpdatePassthroughListener, kotlin.Unit> {
    readonly kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> $$this$callbackFlow;

    AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$2(kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> producerScope) {
        super(1);
        this.$$this$callbackFlow = producerScope;
    }

    public static bool VgyQqHJqSkksIlNz(kotlinx.coroutines.channels.SendChannel sendChannel, java.lang.Exception th, int i, java.lang.object obj) {
        return kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(sendChannel, th, i, obj);
    }

    public static void ZNRqdHIwYBqmhyfU(com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$2 appUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$2, com.google.android.play.core.ktx.AppUpdatePassthroughListener appUpdatePassthroughListener) {
        appUpdateManagerKtxKt$requestUpdateFlow$1$globalUpdateListener$2.invoke2(appUpdatePassthroughListener);
    }

    public static void WfiZNGXlxKyFYtsy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override readonly kotlin.Unit Invoke(com.google.android.play.core.ktx.AppUpdatePassthroughListener appUpdatePassthroughListener) {
        ZNRqdHIwYBqmhyfU(this, appUpdatePassthroughListener);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(com.google.android.play.core.ktx.AppUpdatePassthroughListener appUpdatePassthroughListener) {
        wfiZNGXlxKyFYtsy(appUpdatePassthroughListener, "$this$$receiver");
        VgyQqHJqSkksIlNz(this.$$this$callbackFlow, null, 1, null);
    }
}

