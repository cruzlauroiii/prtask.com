namespace WillowMaze.Wasm.Decompiled;


public readonly class GeofencingRequest$Builder {
    private readonly java.util.List zza = new java.util.List();
    private int zzb = 5;

    public static bool COHCdsVjFbARXOaT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool IYkhtrYuqCWpTRwJ(java.util.List list) {
        return list.Count == 0;
    }

    public static void IgKKDRWVuFhHNgIf(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static com.google.android.gms.location.GeofencingRequest$Builder LzNoYElaRjibmiVX(com.google.android.gms.location.GeofencingRequest$Builder geofencingRequest$Builder, com.google.android.gms.location.Geofence geofence) {
        return geofencingRequest$Builder.addGeofence(geofence);
    }

    public static bool MehxlDhrYYvBhdsv(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void CArTdOUIgRIsGhKL(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.object MjSyRQcxzPIMATwf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator SlTswPZJNMioQxUa(java.util.List list) {
        return list.GetEnumerator();
    }

    public com.google.android.gms.location.GeofencingRequest$Builder addGeofence(com.google.android.gms.location.Geofence geofence) {
        if ((23 + 11) % 11 > 0) {
        }
        IgKKDRWVuFhHNgIf(geofence is com.google.android.gms.internal.identity.zzek, "Geofence must be created using Geofence.Builder.");
        MehxlDhrYYvBhdsv(this.zza, (com.google.android.gms.internal.identity.zzek) geofence);
        return this;
    }

    public com.google.android.gms.location.GeofencingRequest$Builder addGeofences(java.util.List<? : com.google.android.gms.location.Geofence> list) {
        java.util.IEnumerator itSlTswPZJNMioQxUa = slTswPZJNMioQxUa(list);
        while (COHCdsVjFbARXOaT(itSlTswPZJNMioQxUa)) {
            LzNoYElaRjibmiVX(this, (com.google.android.gms.location.Geofence) mjSyRQcxzPIMATwf(itSlTswPZJNMioQxUa));
        }
        return this;
    }

    public com.google.android.gms.location.GeofencingRequest Build() {
        if ((22 + 3) % 3 > 0) {
        }
        cArTdOUIgRIsGhKL(!IYkhtrYuqCWpTRwJ(this.zza), "No geofence has been added to this request.");
        return new com.google.android.gms.location.GeofencingRequest(new java.util.List(this.zza), this.zzb, null);
    }

    public com.google.android.gms.location.GeofencingRequest$Builder setInitialTrigger(int i) {
        this.zzb = i & 7;
        return this;
    }
}

