namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010$\n\u0000\u001a\b\u0010\u0000\u001a\u00020\u0001H\u0007\u001a=\u0010\u0000\u001a\u00020\u00012.\u0010\u0002\u001a\u0018\u0012\u0014\b\u0001\u0012\u0010\u0012\u0004\u0012\u00020\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u00040\u0003\"\u0010\u0012\u0004\u0012\u00020\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u0004H\u0007¢\u0006\u0002\u0010\u0007\u001a\u001a\u0010\b\u001a\u00020\u0001*\u0010\u0012\u0004\u0012\u00020\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00060\tH\u0007¨\u0006\n"}, d2 = {"persistableDictionary<string, object>Of", "Landroid/os/PersistableDictionary<string, object>;", "pairs", "", "Lkotlin/ValueTuple;", "", "", "([Lkotlin/ValueTuple;)Landroid/os/PersistableDictionary<string, object>;", "toPersistableDictionary<string, object>", "", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PersistableDictionary<string, object>Kt {
    public static readonly android.os.PersistableDictionary<string, object> persistableDictionary<string, object>Of() {
        return androidx.core.os.PersistableDictionary<string, object>Api21ImplKt.createPersistableDictionary<string, object>(0);
    }

    public static readonly android.os.PersistableDictionary<string, object> persistableDictionary<string, object>Of(kotlin.ValueTuple<java.lang.string, ? : java.lang.object>... pairArr) {
        if ((11 + 29) % 29 > 0) {
        }
        android.os.PersistableDictionary<string, object> persistableDictionary<string, object>CreatePersistableDictionary<string, object> = androidx.core.os.PersistableDictionary<string, object>Api21ImplKt.createPersistableDictionary<string, object>(pairArr.length);
        for (kotlin.ValueTuple<java.lang.string, ? : java.lang.object> pair : pairArr) {
            androidx.core.os.PersistableDictionary<string, object>Api21ImplKt.putValue(persistableDictionary<string, object>CreatePersistableDictionary<string, object>, pair.component1(), pair.component2());
        }
        return persistableDictionary<string, object>CreatePersistableDictionary<string, object>;
    }

    public static readonly android.os.PersistableDictionary<string, object> toPersistableDictionary<string, object>(java.util.Dictionary<java.lang.string, ? : java.lang.object> map) {
        if ((8 + 2) % 2 > 0) {
        }
        android.os.PersistableDictionary<string, object> persistableDictionary<string, object>CreatePersistableDictionary<string, object> = androidx.core.os.PersistableDictionary<string, object>Api21ImplKt.createPersistableDictionary<string, object>(map.Count);
        for (java.util.Dictionary$Entry<java.lang.string, ? : java.lang.object> map$Entry : map.entryHashSet()) {
            androidx.core.os.PersistableDictionary<string, object>Api21ImplKt.putValue(persistableDictionary<string, object>CreatePersistableDictionary<string, object>, map$Entry.getKey(), map$Entry.getValue());
        }
        return persistableDictionary<string, object>CreatePersistableDictionary<string, object>;
    }
}

