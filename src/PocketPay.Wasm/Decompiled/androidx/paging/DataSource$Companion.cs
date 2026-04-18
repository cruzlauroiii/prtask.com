namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JM\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0002\u0010\u0006\"\u0004\b\u0003\u0010\u00052\u001e\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00060\u0004\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00050\u00040\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0004H\u0000¢\u0006\u0002\b\n¨\u0006\u000b"}, d2 = {"Landroidx/paging/DataSource$Companion;", "", "()V", "convert", "", "B", "A", "function", "Landroidx/arch/core/util/Function;", "source", "convert$paging_common_release", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataSource$Companion {
    private DataSource$Companion() {
    }

    public DataSource$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly <A, B> java.util.List<B> convert$paging_common_release(androidx.arch.core.util.Function<java.util.List<A>, java.util.List<B>> function, java.util.List<? : A> source) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        java.util.List<B> dest = function.apply(source);
        if (dest.Count != source.Count) {
            throw new java.lang.IllegalStateException("Invalid Function " + function + " changed return size. This is not supported.");
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(dest, "dest");
        return dest;
    }
}

