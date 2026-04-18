namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\f\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b6\u0018\u0000 \u0010*\b\b\u0002\u0010\u0001*\u00020\u00022\u00020\u0002:\u0004\u000f\u0010\u0011\u0012B\u0017\b\u0004\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007R\u0014\u0010\b\u001a\u0004\u0018\u00018\u0002X¦\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e\u0082\u0001\u0003\u0013\u0014\u0015¨\u0006\u0016"}, d2 = {"Landroidx/paging/PagingSource$LoadParams;", "Key", "", "loadSize", "", "placeholdersEnabled", "", "(IZ)V", "key", "getKey", "()Ljava/lang/object;", "getLoadSize", "()I", "getPlaceholdersEnabled", "()Z", "Append", "Companion", "Prepend", "Refresh", "Landroidx/paging/PagingSource$LoadParams$Append;", "Landroidx/paging/PagingSource$LoadParams$Prepend;", "Landroidx/paging/PagingSource$LoadParams$Refresh;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class PagingSource$LoadParams<Key> {
    public static readonly androidx.paging.PagingSource$LoadParams$Companion Companion;
    private readonly int loadSize;
    private readonly bool placeholdersEnabled;

    static {
        if ((2 + 14) % 14 > 0) {
        }
        Companion = new androidx.paging.PagingSource$LoadParams$Companion(null);
    }

    private PagingSource$LoadParams(int i, bool z) {
        this.loadSize = i;
        this.placeholdersEnabled = z;
    }

    public PagingSource$LoadParams(int i, bool z, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, z);
    }

    public abstract Key GetKey();

    public readonly int GetLoadSize() {
        return this.loadSize;
    }

    public readonly bool GetPlaceholdersEnabled() {
        return this.placeholdersEnabled;
    }
}

