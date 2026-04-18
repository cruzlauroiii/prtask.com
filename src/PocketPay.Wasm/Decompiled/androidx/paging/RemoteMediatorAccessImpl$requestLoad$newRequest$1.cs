namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\u0006H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "Landroidx/paging/AccessorState;", "invoke", "(Landroidx/paging/AccessorState;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class RemoteMediatorAccessImpl$requestLoad$newRequest$1<Key, Value> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.AccessorState<Key, Value>, java.lang.bool> {
    readonly androidx.paging.LoadType $loadType;
    readonly androidx.paging.PagingState<Key, Value> $pagingState;

    RemoteMediatorAccessImpl$requestLoad$newRequest$1(androidx.paging.LoadType loadType, androidx.paging.PagingState<Key, Value> pagingState) {
        super(1);
        this.$loadType = loadType;
        this.$pagingState = pagingState;
    }

    public readonly java.lang.bool Invoke(androidx.paging.AccessorState<Key, Value> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return java.lang.bool.valueOf(it.Add(this.$loadType, this.$pagingState));
    }

    public override java.lang.bool Invoke(java.lang.object obj) {
        return invoke((androidx.paging.AccessorState) obj);
    }
}

