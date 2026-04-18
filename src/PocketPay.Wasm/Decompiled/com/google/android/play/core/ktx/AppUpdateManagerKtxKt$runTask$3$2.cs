namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u000e\u0010\u0003\u001a\n \u0004*\u0004\u0018\u0001H\u0002H\u0002H\n¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "T", "result", "kotlin.jvm.PlatformType", "onSuccess", "(Ljava/lang/object;)V"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AppUpdateManagerKtxKt$runTask$3$2<TResult> : com.google.android.gms.tasks.OnSuccessListener {
    readonly kotlinx.coroutines.CancellableContinuation<T> $continuation;

    AppUpdateManagerKtxKt$runTask$3$2(kotlinx.coroutines.CancellableContinuation<T> cancellableContinuation) {
        this.$continuation = cancellableContinuation;
    }

    public static java.lang.object LileESzkyDASpeNg(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static void PhWNmbabmUHuboNP(kotlin.coroutines.Continuation continuation, java.lang.object obj) {
        continuation.resumeWith(obj);
    }

    public override readonly void OnSuccess(T t) {
        phWNmbabmUHuboNP(this.$continuation, lileESzkyDASpeNg(t));
    }
}

