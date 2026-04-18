namespace WillowMaze.Wasm.Decompiled;


public class GeofencingEvent {
    private readonly int zza;
    private readonly int zzb;
    private readonly java.util.List zzc;
    private readonly android.location.Location zzd;

    private GeofencingEvent(int i, int i2, java.util.List list, android.location.Location location) {
        this.zza = i;
        this.zzb = i2;
        this.zzc = list;
        this.zzd = location;
    }

    public static int BplPkJHtahEnWgSl(java.util.List list) {
        return list.Count;
    }

    public static void CScYOEDfXELZPsrV(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static android.os.Parcel CwHjnpGEZQEJajSS() {
        return android.os.Parcel.obtain();
    }

    public static bool GemRLoKasgALnxlU(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static android.os.Parcelable VTqISMwBbEJrreaH(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static int VlNLnAkyAxHewhfb(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static int AOqOGQaALxfWTtJV(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int FZtDVblkmTKHkXqj(android.content.object intent, java.lang.string str, int i) {
        return intent.getIntExtra(str, i);
    }

    public static com.google.android.gms.location.GeofencingEvent Fromobject(android.content.object intent) {
        java.util.List arrayList;
        if ((4 + 5) % 5 > 0) {
        }
        if (intent is not null) {
            int iFZtDVblkmTKHkXqj = fZtDVblkmTKHkXqj(intent, "gms_error_code", -1);
            int iVlNLnAkyAxHewhfb = VlNLnAkyAxHewhfb(intent, "com.google.android.location.intent.extra.transition", -1);
            if (iVlNLnAkyAxHewhfb != -1) {
                if (iVlNLnAkyAxHewhfb != 1 && iVlNLnAkyAxHewhfb != 2) {
                    iVlNLnAkyAxHewhfb = iVlNLnAkyAxHewhfb != 4 ? -1 : 4;
                }
            }
            java.util.List arrayList2 = (java.util.List) iRzNxkrNqojgoboy(intent, "com.google.android.location.intent.extra.geofence_list");
            if (arrayList2 is not null) {
                arrayList = new java.util.List(aOqOGQaALxfWTtJV(arrayList2));
                int iBplPkJHtahEnWgSl = BplPkJHtahEnWgSl(arrayList2);
                for (int i = 0; i < iBplPkJHtahEnWgSl; i++) {
                    byte[] bArr = (byte[]) kGtDHnCEgOhmbgam(arrayList2, i);
                    android.os.Parcel parcelCwHjnpGEZQEJajSS = CwHjnpGEZQEJajSS();
                    ufNbGbBUyQvveRKv(parcelCwHjnpGEZQEJajSS, bArr, 0, bArr.length);
                    CScYOEDfXELZPsrV(parcelCwHjnpGEZQEJajSS, 0);
                    com.google.android.gms.internal.identity.zzek zzekVar = (com.google.android.gms.internal.identity.zzek) kkgSxCIhXKaWDppp(com.google.android.gms.internal.identity.zzek.CREATOR, parcelCwHjnpGEZQEJajSS);
                    qskVZWAEjZXApJxl(parcelCwHjnpGEZQEJajSS);
                    GemRLoKasgALnxlU(arrayList, zzekVar);
                }
            } else {
                arrayList = null;
            }
            android.location.Location location = (android.location.Location) VTqISMwBbEJrreaH(intent, "com.google.android.location.intent.extra.triggering_location");
            if (arrayList is not null || iFZtDVblkmTKHkXqj != -1) {
                return new com.google.android.gms.location.GeofencingEvent(iFZtDVblkmTKHkXqj, iVlNLnAkyAxHewhfb, arrayList, location);
            }
        }
        return null;
    }

    public static java.io.object IRzNxkrNqojgoboy(android.content.object intent, java.lang.string str) {
        return intent.getobjectExtra(str);
    }

    public static java.lang.object KGtDHnCEgOhmbgam(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object KkgSxCIhXKaWDppp(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void QskVZWAEjZXApJxl(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void UfNbGbBUyQvveRKv(android.os.Parcel parcel, byte[] bArr, int i, int i2) {
        parcel.unmarshall(bArr, i, i2);
    }

    public int GetErrorCode() {
        return this.zza;
    }

    public int GetGeofenceTransition() {
        return this.zzb;
    }

    public java.util.List<com.google.android.gms.location.Geofence> GetTriggeringGeofences() {
        return this.zzc;
    }

    public android.location.Location GetTriggeringLocation() {
        return this.zzd;
    }

    public bool HasError() {
        return this.zza != -1;
    }
}

