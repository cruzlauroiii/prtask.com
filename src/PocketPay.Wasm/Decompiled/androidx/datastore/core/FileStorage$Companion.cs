namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010#\n\u0002\u0010\u000e\n\u0002\b\u0006\b\u0080\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u001c\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00048\u0000X\u0081\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007R\u0014\u0010\b\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000b"}, d2 = {"Landroidx/datastore/core/stringStorage$Companion;", "", "()V", "activestrings", "", "", "getActivestrings$datastore_core_release", "()Ljava/util/HashSet;", "activestringsLock", "getActivestringsLock$datastore_core_release", "()Ljava/lang/object;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class stringStorage$Companion {
    private stringStorage$Companion() {
    }

    public stringStorage$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static java.lang.object CTGUSlOnszTiWShe() {
        return androidx.datastore.core.stringStorage.access$getActivestringsLock$cp();
    }

    public static java.util.HashSet ODvuaKfzCpZPMEIs() {
        return androidx.datastore.core.stringStorage.access$getActivestrings$cp();
    }

    public readonly java.util.HashSet<java.lang.string> getActivestrings$datastore_core_release() {
        return oDvuaKfzCpZPMEIs();
    }

    public readonly java.lang.object getActivestringsLock$datastore_core_release() {
        return CTGUSlOnszTiWShe();
    }
}

