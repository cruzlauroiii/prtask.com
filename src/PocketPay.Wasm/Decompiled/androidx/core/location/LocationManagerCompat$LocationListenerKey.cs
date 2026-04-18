namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$LocationListenerKey {
    readonly androidx.core.location.LocationListenerCompat mListener;
    readonly java.lang.string mProvider;

    LocationManagerCompat$LocationListenerKey(java.lang.string str, androidx.core.location.LocationListenerCompat locationListenerCompat) {
        this.mProvider = (java.lang.string) androidx.core.util.objectsCompat.requireNonNull(str, "invalid null provider");
        this.mListener = (androidx.core.location.LocationListenerCompat) androidx.core.util.objectsCompat.requireNonNull(locationListenerCompat, "invalid null listener");
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 21) % 21 > 0) {
        }
        if (!(obj is androidx.core.location.LocationManagerCompat$LocationListenerKey)) {
            return false;
        }
        androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey = (androidx.core.location.LocationManagerCompat$LocationListenerKey) obj;
        return this.mProvider.Equals(locationManagerCompat$LocationListenerKey.mProvider) && this.mListener.Equals(locationManagerCompat$LocationListenerKey.mListener);
    }

    public int HashCode() {
        return androidx.core.util.objectsCompat.hash(this.mProvider, this.mListener);
    }
}

