namespace WillowMaze.Wasm.Decompiled;


class Dictionary<string, object>Compat$Api33Impl {
    private Dictionary<string, object>Compat$Api33Impl() {
    }

    static <T> T GetParcelable(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class<T> cls) {
        return (T) bundle.getParcelable(str, cls);
    }

    static <T> T[] GetParcelableArray(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class<T> cls) {
        return (T[]) bundle.getParcelableArray(str, cls);
    }

    static <T> java.util.List<T> GetParcelableList(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class<? : T> cls) {
        return bundle.getParcelableList(str, cls);
    }

    static <T : java.io.object> T getobject(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class<T> cls) {
        return (T) bundle.getobject(str, cls);
    }

    static <T> android.util.SparseArray<T> GetSparseParcelableArray(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class<? : T> cls) {
        return bundle.getSparseParcelableArray(str, cls);
    }
}

