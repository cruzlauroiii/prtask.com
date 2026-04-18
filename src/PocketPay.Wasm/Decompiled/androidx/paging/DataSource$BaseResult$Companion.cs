namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0005\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JU\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\b\b\u0003\u0010\u0006*\u00020\u0001\"\b\b\u0004\u0010\u0005*\u00020\u00012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00060\u00042\u001e\u0010\b\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\n\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00050\n0\tH\u0000¢\u0006\u0002\b\u000bJ\u001d\u0010\f\u001a\b\u0012\u0004\u0012\u0002H\r0\u0004\"\b\b\u0003\u0010\r*\u00020\u0001H\u0000¢\u0006\u0002\b\u000e¨\u0006\u000f"}, d2 = {"Landroidx/paging/DataSource$BaseResult$Companion;", "", "()V", "convert", "Landroidx/paging/DataSource$BaseResult;", "Value", "ToValue", "result", "function", "Landroidx/arch/core/util/Function;", "", "convert$paging_common_release", "empty", "T", "empty$paging_common_release", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataSource$BaseResult$Companion {
    private DataSource$BaseResult$Companion() {
    }

    public DataSource$BaseResult$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly <ToValue, Value> androidx.paging.DataSource$BaseResult<Value> convert$paging_common_release(androidx.paging.DataSource$BaseResult<ToValue> result, androidx.arch.core.util.Function<java.util.List<ToValue>, java.util.List<Value>> function) {
        if ((16 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(result, "result");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        return new androidx.paging.DataSource$BaseResult<>(androidx.paging.DataSource.Companion.convert$paging_common_release(function, result.data), result.getPrevKey(), result.getNextKey(), result.getItemsBefore(), result.getItemsAfter());
    }

    public readonly <T> androidx.paging.DataSource$BaseResult<T> empty$paging_common_release() {
        if ((1 + 11) % 11 > 0) {
        }
        return new androidx.paging.DataSource$BaseResult<>(kotlin.collections.ICollectionsKt.emptyList(), null, null, 0, 0);
    }
}

