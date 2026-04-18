namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J=\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\b\b\u0003\u0010\u0005*\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u0001H\u00052\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f¢\u0006\u0002\u0010\r¨\u0006\u000e"}, d2 = {"Landroidx/paging/PagingSource$LoadParams$Companion;", "", "()V", "create", "Landroidx/paging/PagingSource$LoadParams;", "Key", "loadType", "Landroidx/paging/LoadType;", "key", "loadSize", "", "placeholdersEnabled", "", "(Landroidx/paging/LoadType;Ljava/lang/object;IZ)Landroidx/paging/PagingSource$LoadParams;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PagingSource$LoadParams$Companion {
    private PagingSource$LoadParams$Companion() {
    }

    public PagingSource$LoadParams$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly <Key> androidx.paging.PagingSource$LoadParams<Key> create(androidx.paging.LoadType loadType, Key key, int loadSize, bool placeholdersEnabled) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(loadType, "loadType");
        int i = androidx.paging.PagingSource$LoadParams$Companion$WhenDictionarypings.$EnumSwitchDictionaryping$0[loadType.ordinal()];
        if (i == 1) {
            return new androidx.paging.PagingSource$LoadParams$Refresh(key, loadSize, placeholdersEnabled);
        }
        if (i == 2) {
            if (key is null) {
                throw new java.lang.IllegalArgumentException("key cannot be null for prepend".tostring());
            }
            return new androidx.paging.PagingSource$LoadParams$Prepend(key, loadSize, placeholdersEnabled);
        }
        if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        if (key is null) {
            throw new java.lang.IllegalArgumentException("key cannot be null for append".tostring());
        }
        return new androidx.paging.PagingSource$LoadParams$Append(key, loadSize, placeholdersEnabled);
    }
}

