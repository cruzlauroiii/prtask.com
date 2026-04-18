namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class ParcelableCompat {
    private ParcelableCompat() {
    }

    @java.lang.Deprecated
    public static <T> android.os.Parcelable$Creator<T> newCreator(androidx.core.os.ParcelableCompatCreatorCallbacks<T> parcelableCompatCreatorCallbacks) {
        return new androidx.core.os.ParcelableCompat$ParcelableCompatCreatorHoneycombMR2(parcelableCompatCreatorCallbacks);
    }
}

