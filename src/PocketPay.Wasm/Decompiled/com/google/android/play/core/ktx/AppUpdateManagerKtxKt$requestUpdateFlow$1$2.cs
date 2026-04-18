namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "exception", "Ljava/lang/Exception;", "onFailure"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdateManagerKtxKt$requestUpdateFlow$1$2 : com.google.android.gms.tasks.OnFailureListener {
    readonly kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> $$this$callbackFlow;

    AppUpdateManagerKtxKt$requestUpdateFlow$1$2(kotlinx.coroutines.channels.ProducerScope<com.google.android.play.core.ktx.AppUpdateResult> producerScope) {
        this.$$this$callbackFlow = producerScope;
    }

    public static void FbNNxACeCiPthRdh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool SnHZoIpgnHvSFaaK(kotlinx.coroutines.channels.ProducerScope producerScope, java.lang.Exception th) {
        return producerScope.close(th);
    }

    public override readonly void OnFailure(java.lang.Exception exc) {
        FbNNxACeCiPthRdh(exc, "exception");
        SnHZoIpgnHvSFaaK(this.$$this$callbackFlow, exc);
    }
}

