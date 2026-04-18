namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0013\u0010\u0002\u001a\u00020\u00038\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0005¨\u0006\u0006"}, d2 = {"Landroidx/paging/RemoteMediator$MediatorResult$Success;", "Landroidx/paging/RemoteMediator$MediatorResult;", "endOfPaginationReached", "", "(Z)V", "()Z", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RemoteMediator$MediatorResult$Success : androidx.paging.RemoteMediator$MediatorResult {
    private readonly bool endOfPaginationReached;

    public RemoteMediator$MediatorResult$Success(bool z) {
        super(null);
        this.endOfPaginationReached = z;
    }

    public readonly bool EndOfPaginationReached() {
        return this.endOfPaginationReached;
    }
}

