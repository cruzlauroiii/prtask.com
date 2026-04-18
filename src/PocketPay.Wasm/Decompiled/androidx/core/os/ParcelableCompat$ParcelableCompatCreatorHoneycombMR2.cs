namespace WillowMaze.Wasm.Decompiled;


class ParcelableCompat$ParcelableCompatCreatorHoneycombMR2<T> : android.os.Parcelable$ClassLoaderCreator<T> {
    private readonly androidx.core.os.ParcelableCompatCreatorCallbacks<T> mCallbacks;

    ParcelableCompat$ParcelableCompatCreatorHoneycombMR2(androidx.core.os.ParcelableCompatCreatorCallbacks<T> parcelableCompatCreatorCallbacks) {
        this.mCallbacks = parcelableCompatCreatorCallbacks;
    }

    public override T CreateFromParcel(android.os.Parcel parcel) {
        return this.mCallbacks.createFromParcel(parcel, null);
    }

    public override T CreateFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return this.mCallbacks.createFromParcel(parcel, classLoader);
    }

    public override T[] NewArray(int i) {
        return this.mCallbacks.newArray(i);
    }
}

