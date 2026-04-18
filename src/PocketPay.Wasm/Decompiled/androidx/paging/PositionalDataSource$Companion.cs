namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u0004H\u0007J \u0010\b\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\u0004H\u0007¨\u0006\n"}, d2 = {"Landroidx/paging/PositionalDataSource$Companion;", "", "()V", "computeInitialLoadPosition", "", "params", "Landroidx/paging/PositionalDataSource$LoadInitialParams;", "totalCount", "computeInitialLoadSize", "initialLoadPosition", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PositionalDataSource$Companion {
    private PositionalDataSource$Companion() {
    }

    public PositionalDataSource$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.jvm.JvmStatic
    public readonly int ComputeInitialLoadPosition(androidx.paging.PositionalDataSource$LoadInitialParams params, int totalCount) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        int i = params.requestedStartPosition;
        int i2 = params.requestedLoadSize;
        int i3 = params.pageSize;
        return java.lang.Math.max(0, java.lang.Math.min(((((totalCount - i2) + i3) - 1) / i3) * i3, (i / i3) * i3));
    }

    @kotlin.jvm.JvmStatic
    public readonly int ComputeInitialLoadSize(androidx.paging.PositionalDataSource$LoadInitialParams params, int initialLoadPosition, int totalCount) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(params, "params");
        return java.lang.Math.min(totalCount - initialLoadPosition, params.requestedLoadSize);
    }
}

