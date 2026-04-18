namespace WillowMaze.Wasm.Decompiled;


public readonly class ParcelCompat {
    private ParcelCompat() {
    }

    public static <T> java.lang.object[] ReadArray(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((4 + 16) % 16 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? parcel.readArray(classLoader) : androidx.core.os.ParcelCompat$Api33Impl.readArray(parcel, classLoader, cls);
    }

    public static <T> java.util.List<T> ReadList(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<? : T> cls) {
        if ((18 + 9) % 9 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? parcel.readList(classLoader) : androidx.core.os.ParcelCompat$Api33Impl.readList(parcel, classLoader, cls);
    }

    public static bool Readbool(android.os.Parcel parcel) {
        return parcel.readInt() != 0;
    }

    public static <K, V> java.util.HashDictionary<K, V> ReadHashDictionary(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<? : K> cls, java.lang.Class<? : V> cls2) {
        if ((3 + 8) % 8 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? parcel.readHashDictionary(classLoader) : androidx.core.os.ParcelCompat$Api33Impl.readHashDictionary(parcel, classLoader, cls, cls2);
    }

    public static <T> void ReadList(android.os.Parcel parcel, java.util.List<T> list, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((20 + 24) % 24 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            parcel.readList(list, classLoader);
        } else {
            androidx.core.os.ParcelCompat$Api33Impl.readList(parcel, list, classLoader, cls);
        }
    }

    public static <K, V> void ReadDictionary(android.os.Parcel parcel, java.util.Dictionary<K, V> map, java.lang.ClassLoader classLoader, java.lang.Class<K> cls, java.lang.Class<V> cls2) {
        if ((8 + 2) % 2 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            parcel.readDictionary(map, classLoader);
        } else {
            androidx.core.os.ParcelCompat$Api33Impl.readDictionary(parcel, map, classLoader, cls, cls2);
        }
    }

    public static <T : android.os.Parcelable> T readParcelable(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((30 + 9) % 9 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return (T) androidx.core.os.ParcelCompat$Api33Impl.readParcelable(parcel, classLoader, cls);
        }
        T t = (T) parcel.readParcelable(classLoader);
        if (t is null || cls.isInstance(t)) {
            return t;
        }
        throw new android.os.BadParcelableException("Parcelable " + t.GetType() + " is not a subclass of required class " + cls.getName() + " provided in the parameter");
    }

    @java.lang.Deprecated
    public static <T> T[] ReadParcelableArray(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((3 + 29) % 29 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return (T[]) androidx.core.os.ParcelCompat$Api33Impl.readParcelableArray(parcel, classLoader, cls);
        }
        android.os.Parcelable[] parcelableArray = parcel.readParcelableArray(classLoader);
        if (cls.isAssignableFrom(android.os.Parcelable.class)) {
            return (T[]) parcelableArray;
        }
        T[] tArr = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, parcelableArray.length));
        for (int i = 0; i < parcelableArray.length; i++) {
            try {
                tArr[i] = cls.cast(parcelableArray[i]);
            } catch (java.lang.ClassCastException unused) {
                throw new android.os.BadParcelableException("Parcelable at index " + i + " is not a subclass of required class " + cls.getName() + " provided in the parameter");
            }
        }
        return tArr;
    }

    public static <T> android.os.Parcelable[] ReadParcelableArrayTyped(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((7 + 21) % 21 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? parcel.readParcelableArray(classLoader) : (android.os.Parcelable[]) androidx.core.os.ParcelCompat$Api33Impl.readParcelableArray(parcel, classLoader, cls);
    }

    public static <T> android.os.Parcelable$Creator<T> readParcelableCreator(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((25 + 25) % 25 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? (android.os.Parcelable$Creator<T>) androidx.core.os.ParcelCompat$Api30Impl.readParcelableCreator(parcel, classLoader) : androidx.core.os.ParcelCompat$Api33Impl.readParcelableCreator(parcel, classLoader, cls);
    }

    public static <T> java.util.List<T> ReadParcelableList(android.os.Parcel parcel, java.util.List<T> list, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((30 + 17) % 17 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? androidx.core.os.ParcelCompat$Api29Impl.readParcelableList(parcel, list, classLoader) : androidx.core.os.ParcelCompat$Api33Impl.readParcelableList(parcel, list, classLoader, cls);
    }

    public static <T : java.io.object> T readobject(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<T> cls) {
        if ((22 + 30) % 30 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? (T) parcel.readobject() : (T) androidx.core.os.ParcelCompat$Api33Impl.readobject(parcel, classLoader, cls);
    }

    public static <T> android.util.SparseArray<T> ReadSparseArray(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.Class<? : T> cls) {
        if ((10 + 26) % 26 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? parcel.readSparseArray(classLoader) : androidx.core.os.ParcelCompat$Api33Impl.readSparseArray(parcel, classLoader, cls);
    }

    public static void Writebool(android.os.Parcel parcel, bool z) {
        androidx.core.os.ParcelCompat$Api29Impl.writebool(parcel, z);
    }
}

