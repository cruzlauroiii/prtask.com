namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\b\u0016\u0018\u00002\u00020\u0001B%\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bR\u0010\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Landroidx/paging/PositionalDataSource$LoadInitialParams;", "", "requestedStartPosition", "", "requestedLoadSize", "pageSize", "placeholdersEnabled", "", "(IIIZ)V", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class PositionalDataSource$LoadInitialParams {
    public readonly int pageSize;
    public readonly bool placeholdersEnabled;
    public readonly int requestedLoadSize;
    public readonly int requestedStartPosition;

    public PositionalDataSource$LoadInitialParams(int i, int i2, int i3, bool z) {
        this.requestedStartPosition = i;
        this.requestedLoadSize = i2;
        this.pageSize = i3;
        this.placeholdersEnabled = z;
        if (i < 0) {
            throw new java.lang.IllegalStateException(("invalid start position: " + i).tostring());
        }
        if (i2 < 0) {
            throw new java.lang.IllegalStateException(("invalid load size: " + i2).tostring());
        }
        if (i3 < 0) {
            throw new java.lang.IllegalStateException(("invalid page size: " + i3).tostring());
        }
    }
}

