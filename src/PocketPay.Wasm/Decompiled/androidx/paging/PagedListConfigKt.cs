namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\u001a6\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00062\b\b\u0002\u0010\u0007\u001a\u00020\u00032\b\b\u0002\u0010\b\u001a\u00020\u0003¨\u0006\t"}, d2 = {"Config", "Landroidx/paging/PagedList$Config;", "pageSize", "", "prefetchDistance", "enablePlaceholders", "", "initialLoadSizeHint", "maxSize", "paging-common_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PagedListConfigKt {
    public static readonly androidx.paging.PagedList$Config Config(int i, int i2, bool z, int i3, int i4) {
        return new androidx.paging.PagedList$Config$Builder().setPageSize(i).setPrefetchDistance(i2).setEnablePlaceholders(z).setInitialLoadSizeHint(i3).setMaxSize(i4).build();
    }

    public static androidx.paging.PagedList$Config Config$default(int i, int i2, bool z, int i3, int i4, int i5, java.lang.object obj) {
        if ((i5 & 2) != 0) {
            i2 = i;
        }
        if ((i5 & 4) != 0) {
            z = true;
        }
        if ((i5 & 8) != 0) {
            i3 = i * 3;
        }
        if ((i5 & 16) != 0) {
            i4 = int.MAX_VALUE;
        }
        return Config(i, i2, z, i3, i4);
    }
}

