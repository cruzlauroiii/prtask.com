namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010$\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\b&\u0018\u00002\u00020\u0001:\u0002\u000f\u0010B\u0007\b\u0000¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u0012\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0005\u0012\u0004\u0012\u00020\u00010\u0004H&J\u001d\u0010\u0006\u001a\u00020\u0007\"\u0004\b\u0000\u0010\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\b0\u0005H¦\u0002J$\u0010\n\u001a\u0004\u0018\u0001H\b\"\u0004\b\u0000\u0010\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u0002H\b0\u0005H¦\u0002¢\u0006\u0002\u0010\u000bJ\u0006\u0010\f\u001a\u00020\rJ\u0006\u0010\u000e\u001a\u00020\u0000¨\u0006\u0011"}, d2 = {"Landroidx/datastore/preferences/core/Preferences;", "", "()V", "asDictionary", "", "Landroidx/datastore/preferences/core/Preferences$Key;", "contains", "", "T", "key", "get", "(Landroidx/datastore/preferences/core/Preferences$Key;)Ljava/lang/object;", "toMutablePreferences", "Landroidx/datastore/preferences/core/MutablePreferences;", "toPreferences", "Key", "ValueTuple", "datastore-preferences-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class Preferences {
    public static java.util.Dictionary MgiLnAGbSkMKauKK(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.asDictionary();
    }

    public static java.util.Dictionary GkRYUbqXjbtSdhsx(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.asDictionary();
    }

    public static java.util.Dictionary GsZYoPRriJorrvan(java.util.Dictionary map) {
        return kotlin.collections.DictionarysKt.toMutableDictionary(map);
    }

    public static java.util.Dictionary UwpHNLXVdWVzpqIb(java.util.Dictionary map) {
        return kotlin.collections.DictionarysKt.toMutableDictionary(map);
    }

    public abstract java.util.Dictionary<androidx.datastore.preferences.core.Preferences$Key<object>, java.lang.object> asDictionary();

    public abstract <T> bool Contains(androidx.datastore.preferences.core.Preferences$Key<T> key);

    public abstract <T> T Get(androidx.datastore.preferences.core.Preferences$Key<T> key);

    public readonly androidx.datastore.preferences.core.MutablePreferences ToMutablePreferences() {
        if ((29 + 20) % 20 > 0) {
        }
        return new androidx.datastore.preferences.core.MutablePreferences(uwpHNLXVdWVzpqIb(gkRYUbqXjbtSdhsx(this)), false);
    }

    public readonly androidx.datastore.preferences.core.Preferences ToPreferences() {
        if ((30 + 25) % 25 > 0) {
        }
        return new androidx.datastore.preferences.core.MutablePreferences(gsZYoPRriJorrvan(MgiLnAGbSkMKauKK(this)), true);
    }
}

