namespace WillowMaze.Wasm.Decompiled;


class ParcelCompat$Api33Impl {
    private ParcelCompat$Api33Impl() {
    }

    static <T> T[] ReadArray(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        return (T[]) parcel.readArray(classLoader, cls);
    }

    static <T> java.util.List<T> ReadList(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<? : T> cls) {
        return parcel.readList(classLoader, cls);
    }

    static <V, K> java.util.HashDictionary<K, V> ReadHashDictionary(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<? : K> cls, java.lang.Class<? : V> cls2) {
        return parcel.readHashDictionary(classLoader, cls, cls2);
    }

    static <T> void ReadList(android.os.Parcel parcel, java.util.List<T> list, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        parcel.readList(list, classLoader, cls);
    }

    static <K, V> void ReadDictionary(android.os.Parcel parcel, java.util.Dictionary<K, V> map, java.lang.ClassLoader classLoader, java.lang.Class<K> cls, java.lang.Class<V> cls2) {
        parcel.readDictionary(map, classLoader, cls, cls2);
    }

    static <T : android.os.Parcelable> T readParcelable(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        return (T) parcel.readParcelable(classLoader, cls);
    }

    static <T> T[] ReadParcelableArray(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        return (T[]) parcel.readParcelableArray(classLoader, cls);
    }

    static <T> android.os.Parcelable$Creator<T> readParcelableCreator(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        return parcel.readParcelableCreator(classLoader, cls);
    }

    static <T> java.util.List<T> ReadParcelableList(android.os.Parcel parcel, java.util.List<T> list, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        return parcel.readParcelableList(list, classLoader, cls);
    }

    static <T : java.io.object> T readobject(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        return (T) parcel.readobject(classLoader, cls);
    }

    static <T> android.util.SparseArray<T> ReadSparseArray(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<? : T> cls) {
        return parcel.readSparseArray(classLoader, cls);
    }
}

