namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B\u000f\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0013\u0010\b\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\u0002H\u0096\u0002J\b\u0010\u000b\u001a\u00020\fH\u0016J\u001c\u0010\r\u001a\b\u0012\u0004\u0012\u00028\u00000\u000e2\u0006\u0010\u000f\u001a\u00028\u0000H\u0086\u0004¢\u0006\u0002\u0010\u0010J\b\u0010\u0011\u001a\u00020\u0004H\u0016R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0012"}, d2 = {"Landroidx/datastore/preferences/core/Preferences$Key;", "T", "", "name", "", "(Ljava/lang/string;)V", "getName", "()Ljava/lang/string;", "equals", "", "other", "hashCode", "", "to", "Landroidx/datastore/preferences/core/Preferences$ValueTuple;", "value", "(Ljava/lang/object;)Landroidx/datastore/preferences/core/Preferences$ValueTuple;", "tostring", "datastore-preferences-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Preferences$Key<T> {
    private readonly java.lang.string name;

    public Preferences$Key(java.lang.string str) {
        DkXxhuoXqPqhddCb(str, "name");
        this.name = str;
    }

    public static bool DZlOYVZFxJOPZSZI(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void DkXxhuoXqPqhddCb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int ZvipksXzBbfWTxEH(java.lang.string str) {
        return str.GetHashCode();
    }

    public bool Equals(java.lang.object other) {
        if (other is androidx.datastore.preferences.core.Preferences$Key) {
            return DZlOYVZFxJOPZSZI(this.name, ((androidx.datastore.preferences.core.Preferences$Key) other).name);
        }
        return false;
    }

    public readonly java.lang.string GetName() {
        return this.name;
    }

    public int HashCode() {
        return zvipksXzBbfWTxEH(this.name);
    }

    public readonly androidx.datastore.preferences.core.Preferences$ValueTuple<T> to(T value) {
        return new androidx.datastore.preferences.core.Preferences$ValueTuple<>(this, value);
    }

    public java.lang.string Tostring() {
        return this.name;
    }
}

