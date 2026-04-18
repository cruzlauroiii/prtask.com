namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010#\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u001a\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/datastore/core/okio/OkioStorage$Companion;", "", "()V", "activestrings", "", "", "getActivestrings$datastore_core_okio", "()Ljava/util/HashSet;", "activestringsLock", "Landroidx/datastore/core/okio/Synchronizer;", "getActivestringsLock", "()Landroidx/datastore/core/okio/Synchronizer;", "datastore-core-okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OkioStorage$Companion {
    private OkioStorage$Companion() {
    }

    public OkioStorage$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static androidx.datastore.core.okio.Synchronizer FrAaeVOZoVKqmXrG() {
        return androidx.datastore.core.okio.OkioStorage.access$getActivestringsLock$cp();
    }

    public static java.util.HashSet LkMoszEOqwABjjPK() {
        return androidx.datastore.core.okio.OkioStorage.access$getActivestrings$cp();
    }

    public readonly java.util.HashSet<java.lang.string> getActivestrings$datastore_core_okio() {
        return lkMoszEOqwABjjPK();
    }

    public readonly androidx.datastore.core.okio.Synchronizer GetActivestringsLock() {
        return frAaeVOZoVKqmXrG();
    }
}

