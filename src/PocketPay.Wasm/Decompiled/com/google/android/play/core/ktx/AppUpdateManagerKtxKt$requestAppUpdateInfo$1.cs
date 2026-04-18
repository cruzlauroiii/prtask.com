namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "com.google.android.play.core.ktx.AppUpdateManagerKtxKt", m533f = "AppUpdateManagerKtx.kt", m534i = {}, m535l = {226}, m536m = "requestAppUpdateInfo", m537n = {}, m538s = {})
readonly class AppUpdateManagerKtxKt$requestAppUpdateInfo$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;

    AppUpdateManagerKtxKt$requestAppUpdateInfo$1(kotlin.coroutines.Continuation<? super com.google.android.play.core.ktx.AppUpdateManagerKtxKt$requestAppUpdateInfo$1> continuation) {
        super(continuation);
    }

    public static java.lang.object FrxhtQbdwzLMfMjx(com.google.android.play.core.appupdate.AppUpdateManager appUpdateManager, kotlin.coroutines.Continuation continuation) {
        return com.google.android.play.core.ktx.AppUpdateManagerKtxKt.requestAppUpdateInfo(appUpdateManager, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return frxhtQbdwzLMfMjx(null, this);
    }
}

