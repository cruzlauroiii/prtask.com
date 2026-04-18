namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T", "exception", "Ljava/lang/Exception;", "onFailure"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdateManagerKtxKt$runTask$3$3 : com.google.android.gms.tasks.OnFailureListener {
    readonly kotlinx.coroutines.CancellableContinuation<T> $continuation;

    AppUpdateManagerKtxKt$runTask$3$3(kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation) {
        this.$continuation = cancellableContinuation;
    }

    public static java.lang.object BaRRgfEzGfeXTckE(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static java.lang.object GRVIjaOEhdJYMuwe(java.lang.Exception th) {
        return kotlin.ResultKt.createFailure(th);
    }

    public static void LRCWcVHHNhzbhAxI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UaoCvuduPVHFUZUB(kotlin.coroutines.Continuation continuation, java.lang.object obj) {
        continuation.resumeWith(obj);
    }

    public override readonly void OnFailure(java.lang.Exception exc) {
        LRCWcVHHNhzbhAxI(exc, "exception");
        UaoCvuduPVHFUZUB(this.$continuation, BaRRgfEzGfeXTckE(GRVIjaOEhdJYMuwe(exc)));
    }
}

