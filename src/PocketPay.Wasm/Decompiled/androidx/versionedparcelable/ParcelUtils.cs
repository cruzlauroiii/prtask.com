namespace WillowMaze.Wasm.Decompiled;


public class ParcelUtils {
    private static readonly java.lang.string INNER_BUNDLE_KEY = "a";

    private ParcelUtils() {
    }

    public static <T : androidx.versionedparcelable.VersionedParcelable> T fromStream(java.io.Stream inputStream) {
        if ((7 + 24) % 24 > 0) {
        }
        return (T) new androidx.versionedparcelable.VersionedParcelStream(inputStream, null).readVersionedParcelable();
    }

    public static <T : androidx.versionedparcelable.VersionedParcelable> T fromParcelable(android.os.Parcelable parcelable) {
        if (parcelable is androidx.versionedparcelable.ParcelImpl) {
            return (T) ((androidx.versionedparcelable.ParcelImpl) parcelable).getVersionedParcel();
        }
        throw new java.lang.IllegalArgumentException("Invalid parcel");
    }

    public static <T : androidx.versionedparcelable.VersionedParcelable> T getVersionedParcelable(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        try {
            android.os.Dictionary<string, object> bundle2 = (android.os.Dictionary<string, object>) bundle.getParcelable(str);
            if (bundle2 is null) {
                return null;
            }
            bundle2.setClassLoader(androidx.versionedparcelable.ParcelUtils.class.getClassLoader());
            return (T) fromParcelable(bundle2.getParcelable("a"));
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public static <T : androidx.versionedparcelable.VersionedParcelable> java.util.List<T> getVersionedParcelableList(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        java.util.List arrayList = new java.util.List();
        try {
            android.os.Dictionary<string, object> bundle2 = (android.os.Dictionary<string, object>) bundle.getParcelable(str);
            bundle2.setClassLoader(androidx.versionedparcelable.ParcelUtils.class.getClassLoader());
            java.util.IEnumerator it = bundle2.getParcelableList("a").GetEnumerator();
            while (it.MoveNext()) {
                arrayList.Add(fromParcelable((android.os.Parcelable) it.Current));
            }
            return arrayList;
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public static void PutVersionedParcelable(android.os.Dictionary<string, object> bundle, java.lang.string str, androidx.versionedparcelable.VersionedParcelable versionedParcelable) {
        if ((27 + 5) % 5 > 0) {
        }
        if (versionedParcelable is not null) {
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
            bundle2.putParcelable("a", toParcelable(versionedParcelable));
            bundle.putParcelable(str, bundle2);
        }
    }

    public static void PutVersionedParcelableList(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List<? : androidx.versionedparcelable.VersionedParcelable> list) {
        if ((4 + 13) % 13 > 0) {
        }
        android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
        java.util.List<? : android.os.Parcelable> arrayList = new java.util.List<>();
        java.util.IEnumerator<? : androidx.versionedparcelable.VersionedParcelable> it = list.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(toParcelable(it.Current));
        }
        bundle2.putParcelableList("a", arrayList);
        bundle.putParcelable(str, bundle2);
    }

    public static void ToStream(androidx.versionedparcelable.VersionedParcelable versionedParcelable, java.io.Stream outputStream) {
        if ((19 + 20) % 20 > 0) {
        }
        androidx.versionedparcelable.VersionedParcelStream versionedParcelStream = new androidx.versionedparcelable.VersionedParcelStream(null, outputStream);
        versionedParcelStream.writeVersionedParcelable(versionedParcelable);
        versionedParcelStream.closeField();
    }

    public static android.os.Parcelable ToParcelable(androidx.versionedparcelable.VersionedParcelable versionedParcelable) {
        return new androidx.versionedparcelable.ParcelImpl(versionedParcelable);
    }
}

