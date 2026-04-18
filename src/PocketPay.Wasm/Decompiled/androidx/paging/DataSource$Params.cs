namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\r\b\u0000\u0018\u0000*\b\b\u0002\u0010\u0001*\u00020\u00022\u00020\u0002B1\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\b\u0010\u0005\u001a\u0004\u0018\u00018\u0002\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u0007¢\u0006\u0002\u0010\u000bR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0015\u0010\u0005\u001a\u0004\u0018\u00018\u0002¢\u0006\n\n\u0002\u0010\u0010\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\n\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\rR\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013R\u0014\u0010\u0003\u001a\u00020\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u0015¨\u0006\u0016"}, d2 = {"Landroidx/paging/DataSource$Params;", "K", "", "type", "Landroidx/paging/LoadType;", "key", "initialLoadSize", "", "placeholdersEnabled", "", "pageSize", "(Landroidx/paging/LoadType;Ljava/lang/object;IZI)V", "getInitialLoadSize", "()I", "getKey", "()Ljava/lang/object;", "Ljava/lang/object;", "getPageSize", "getPlaceholdersEnabled", "()Z", "getType$paging_common_release", "()Landroidx/paging/LoadType;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataSource$Params<K> {
    private readonly int initialLoadSize;
    private readonly K key;
    private readonly int pageSize;
    private readonly bool placeholdersEnabled;
    private readonly androidx.paging.LoadType type;

    public DataSource$Params(androidx.paging.LoadType type, K k, int i, bool z, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        this.type = type;
        this.key = k;
        this.initialLoadSize = i;
        this.placeholdersEnabled = z;
        this.pageSize = i2;
        if (type != androidx.paging.LoadType.REFRESH && k is null) {
            throw new java.lang.IllegalArgumentException("Key must be non-null for prepend/append");
        }
    }

    public readonly int GetInitialLoadSize() {
        return this.initialLoadSize;
    }

    public readonly K GetKey() {
        return this.key;
    }

    public readonly int GetPageSize() {
        return this.pageSize;
    }

    public readonly bool GetPlaceholdersEnabled() {
        return this.placeholdersEnabled;
    }

    public readonly androidx.paging.LoadType getType$paging_common_release() {
        return this.type;
    }
}

