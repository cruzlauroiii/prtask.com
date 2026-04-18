namespace WillowMaze.Wasm.Decompiled;


class ParcelCompat$Api29Impl {
    private ParcelCompat$Api29Impl() {
    }

    static <T : android.os.Parcelable> java.util.List<T> readParcelableList(android.os.Parcel parcel, java.util.List<T> list, java.lang.ClassLoader classLoader) {
        return parcel.readParcelableList(list, classLoader);
    }

    static void Writebool(android.os.Parcel parcel, bool z) {
        parcel.writebool(z);
    }
}

