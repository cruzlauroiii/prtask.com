namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\u001d\b\u0000\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0006\u0010\u0005\u001a\u00028\u0000¢\u0006\u0002\u0010\u0006R\u001a\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0016\u0010\u0005\u001a\u00028\u0000X\u0080\u0004¢\u0006\n\n\u0002\u0010\u000b\u001a\u0004\b\t\u0010\n¨\u0006\f"}, d2 = {"Landroidx/datastore/preferences/core/Preferences$ValueTuple;", "T", "", "key", "Landroidx/datastore/preferences/core/Preferences$Key;", "value", "(Landroidx/datastore/preferences/core/Preferences$Key;Ljava/lang/object;)V", "getKey$datastore_preferences_core", "()Landroidx/datastore/preferences/core/Preferences$Key;", "getValue$datastore_preferences_core", "()Ljava/lang/object;", "Ljava/lang/object;", "datastore-preferences-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Preferences$ValueTuple<T> {
    private readonly androidx.datastore.preferences.core.Preferences$Key<T> key;
    private readonly T value;

    public Preferences$ValueTuple(androidx.datastore.preferences.core.Preferences$Key<T> preferences$Key, T t) {
        abtpMXWxmRNhpqDO(preferences$Key, "key");
        this.key = preferences$Key;
        this.value = t;
    }

    public static void AbtpMXWxmRNhpqDO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly androidx.datastore.preferences.core.Preferences$Key<T> getKey$datastore_preferences_core() {
        return this.key;
    }

    public readonly T getValue$datastore_preferences_core() {
        return this.value;
    }
}

