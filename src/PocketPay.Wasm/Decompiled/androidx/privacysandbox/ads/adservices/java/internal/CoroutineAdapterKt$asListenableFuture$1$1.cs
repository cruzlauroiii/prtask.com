namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "T", "it", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class CoroutineAdapterKt$asListenableTask$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T> $completer;
    readonly kotlinx.coroutines.Deferred<T> $this_asListenableTask;

    CoroutineAdapterKt$asListenableTask$1$1(androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T> callbackToTaskAdapter$Completer, kotlinx.coroutines.Deferred<? : T> deferred) {
        super(1);
        this.$completer = callbackToTaskAdapter$Completer;
        this.$this_asListenableTask = deferred;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        if (th is null) {
            this.$completer.set((T) this.$this_asListenableTask.getCompleted());
        } else if (th is java.util.concurrent.CancellationException) {
            this.$completer.setCancelled();
        } else {
            this.$completer.setException(th);
        }
    }
}

