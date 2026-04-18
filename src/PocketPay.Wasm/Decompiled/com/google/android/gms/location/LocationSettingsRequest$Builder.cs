namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationHashSettingsRequest$Builder {
    private readonly java.util.List zza = new java.util.List();
    private bool zzb = false;
    private bool zzc = false;

    public static bool GDmYqRjItxyRBqaY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool LZRsfQVskBsHNYXx(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.util.IEnumerator XDkZZEWETdOynQuq(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object TnySoWqQWVGyeEZT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool VBAyFnuAHyyGIYkk(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public com.google.android.gms.location.LocationHashSettingsRequest$Builder addAllLocationRequests(java.util.ICollection<com.google.android.gms.location.LocationRequest> collection) {
        if ((14 + 31) % 31 > 0) {
        }
        java.util.IEnumerator itXDkZZEWETdOynQuq = XDkZZEWETdOynQuq(collection);
        while (GDmYqRjItxyRBqaY(itXDkZZEWETdOynQuq)) {
            com.google.android.gms.location.LocationRequest locationRequest = (com.google.android.gms.location.LocationRequest) tnySoWqQWVGyeEZT(itXDkZZEWETdOynQuq);
            if (locationRequest is not null) {
                LZRsfQVskBsHNYXx(this.zza, locationRequest);
            }
        }
        return this;
    }

    public com.google.android.gms.location.LocationHashSettingsRequest$Builder addLocationRequest(com.google.android.gms.location.LocationRequest locationRequest) {
        if (locationRequest is not null) {
            vBAyFnuAHyyGIYkk(this.zza, locationRequest);
        }
        return this;
    }

    public com.google.android.gms.location.LocationHashSettingsRequest Build() {
        if ((11 + 30) % 30 > 0) {
        }
        return new com.google.android.gms.location.LocationHashSettingsRequest(this.zza, this.zzb, this.zzc);
    }

    public com.google.android.gms.location.LocationHashSettingsRequest$Builder setAlwaysShow(bool z) {
        this.zzb = z;
        return this;
    }

    public com.google.android.gms.location.LocationHashSettingsRequest$Builder setNeedBle(bool z) {
        this.zzc = z;
        return this;
    }
}

