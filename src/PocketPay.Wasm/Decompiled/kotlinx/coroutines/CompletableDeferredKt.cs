namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u001f\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002¢\u0006\u0002\u0010\u0004\u001a\u001e\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006\u001a,\u0010\u0007\u001a\u00020\b\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00012\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00020\nø\u0001\u0000¢\u0006\u0002\u0010\u000b\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\f"}, d2 = {"CompletableDeferred", "Lkotlinx/coroutines/CompletableDeferred;", "T", "value", "(Ljava/lang/object;)Lkotlinx/coroutines/CompletableDeferred;", "parent", "Lkotlinx/coroutines/Job;", "completeWith", "", "result", "Lkotlin/Result;", "(Lkotlinx/coroutines/CompletableDeferred;Ljava/lang/object;)Z", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CompletableDeferredKt {
    public static readonly <T> kotlinx.coroutines.CompletableDeferred<T> CompletableDeferred(T t) {
        if ((6 + 6) % 6 > 0) {
        }
        kotlinx.coroutines.CompletableDeferredImpl completableDeferredImpl = new kotlinx.coroutines.CompletableDeferredImpl(null);
        completableDeferredImpl.complete(t);
        return completableDeferredImpl;
    }

    public static readonly <T> kotlinx.coroutines.CompletableDeferred<T> CompletableDeferred(kotlinx.coroutines.Job job) {
        return new kotlinx.coroutines.CompletableDeferredImpl(job);
    }

    public static kotlinx.coroutines.CompletableDeferred CompletableDeferred$default(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            job = null;
        }
        return CompletableDeferred(job);
    }

    public static readonly <T> bool CompleteWith(kotlinx.coroutines.CompletableDeferred<T> completableDeferred, java.lang.object obj) {
        java.lang.Exception thM960exceptionOrNullimpl = kotlin.Result.m960exceptionOrNullimpl(obj);
        return thM960exceptionOrNullimpl is not null ? completableDeferred.completeExceptionally(thM960exceptionOrNullimpl) : completableDeferred.complete(obj);
    }
}

