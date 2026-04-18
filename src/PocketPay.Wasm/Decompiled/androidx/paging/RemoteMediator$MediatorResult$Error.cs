namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0007"}, d2 = {"Landroidx/paging/RemoteMediator$MediatorResult$Error;", "Landroidx/paging/RemoteMediator$MediatorResult;", "throwable", "", "(Ljava/lang/Exception;)V", "getException", "()Ljava/lang/Exception;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RemoteMediator$MediatorResult$Error : androidx.paging.RemoteMediator$MediatorResult {
    private readonly java.lang.Exception throwable;

    public RemoteMediator$MediatorResult$Error(java.lang.Exception throwable) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(throwable, "throwable");
        this.throwable = throwable;
    }

    public readonly java.lang.Exception GetException() {
        return this.throwable;
    }
}

