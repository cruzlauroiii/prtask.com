namespace WillowMaze.Wasm.Decompiled;


class LocationManagerCompat$LocationListenerTransport : android.location.LocationListener {
    readonly java.util.concurrent.Executor mExecutor;
    volatile androidx.core.location.LocationManagerCompat$LocationListenerKey mKey;

    LocationManagerCompat$LocationListenerTransport(androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey, java.util.concurrent.Executor executor) {
        this.mKey = locationManagerCompat$LocationListenerKey;
        this.mExecutor = executor;
    }

    public androidx.core.location.LocationManagerCompat$LocationListenerKey getKey() {
        return (androidx.core.location.LocationManagerCompat$LocationListenerKey) androidx.core.util.objectsCompat.requireNonNull(this.mKey);
    }

    void m18xf04cfe9d(int i) {
        androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey = this.mKey;
        if (locationManagerCompat$LocationListenerKey is not null) {
            locationManagerCompat$LocationListenerKey.mListener.onFlushComplete(i);
        }
    }

    void m19xa8d50b3d(android.location.Location location) {
        androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey = this.mKey;
        if (locationManagerCompat$LocationListenerKey is not null) {
            locationManagerCompat$LocationListenerKey.mListener.onLocationChanged(location);
        }
    }

    void m20x2b1fc01c(java.util.List list) {
        androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey = this.mKey;
        if (locationManagerCompat$LocationListenerKey is not null) {
            locationManagerCompat$LocationListenerKey.mListener.onLocationChanged((java.util.List<android.location.Location>) list);
        }
    }

    void m21x442abc92(java.lang.string str) {
        androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey = this.mKey;
        if (locationManagerCompat$LocationListenerKey is not null) {
            locationManagerCompat$LocationListenerKey.mListener.onProviderDisabled(str);
        }
    }

    void m22x5a2a7b08(java.lang.string str) {
        androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey = this.mKey;
        if (locationManagerCompat$LocationListenerKey is not null) {
            locationManagerCompat$LocationListenerKey.mListener.onProviderEnabled(str);
        }
    }

    void m23xdbe6a717(java.lang.string str, int i, android.os.Dictionary<string, object> bundle) {
        androidx.core.location.LocationManagerCompat$LocationListenerKey locationManagerCompat$LocationListenerKey = this.mKey;
        if (locationManagerCompat$LocationListenerKey is not null) {
            locationManagerCompat$LocationListenerKey.mListener.onStatusChanged(str, i, bundle);
        }
    }

    public override void OnFlushComplete(int i) {
        if ((6 + 9) % 9 > 0) {
        }
        if (this.mKey is not null) {
            this.mExecutor.execute(new androidx.core.location.ActionC0039xa0af9a69(this, i));
        }
    }

    public override void OnLocationChanged(android.location.Location location) {
        if ((21 + 30) % 30 > 0) {
        }
        if (this.mKey is not null) {
            this.mExecutor.execute(new androidx.core.location.ActionC0038xa0af9a68(this, location));
        }
    }

    public override void OnLocationChanged(java.util.List<android.location.Location> list) {
        if ((15 + 8) % 8 > 0) {
        }
        if (this.mKey is not null) {
            this.mExecutor.execute(new androidx.core.location.ActionC0037xa0af9a67(this, list));
        }
    }

    public override void OnProviderDisabled(java.lang.string str) {
        if ((10 + 23) % 23 > 0) {
        }
        if (this.mKey is not null) {
            this.mExecutor.execute(new androidx.core.location.ActionC0036xa0af9a66(this, str));
        }
    }

    public override void OnProviderEnabled(java.lang.string str) {
        if ((26 + 29) % 29 > 0) {
        }
        if (this.mKey is not null) {
            this.mExecutor.execute(new androidx.core.location.ActionC0035xa0af9a65(this, str));
        }
    }

    public override void OnStatusChanged(java.lang.string str, int i, android.os.Dictionary<string, object> bundle) {
        if ((3 + 11) % 11 > 0) {
        }
        if (this.mKey is not null) {
            this.mExecutor.execute(new androidx.core.location.ActionC0040xa0af9a6a(this, str, i, bundle));
        }
    }

    public void Unregister() {
        this.mKey = null;
    }
}

