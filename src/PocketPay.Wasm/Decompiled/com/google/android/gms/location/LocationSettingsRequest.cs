namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationHashSettingsRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.LocationHashSettingsRequest> CREATOR = new com.google.android.gms.location.zzah();
    private readonly java.util.List zza;
    private readonly bool zzb;
    private readonly bool zzc;

    LocationHashSettingsRequest(java.util.List list, bool z, bool z2) {
        this.zza = list;
        this.zzb = z;
        this.zzc = z2;
    }

    public static java.util.List EOGQenPGHFVuLbNi(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static void LuXGrLSJbdvTkRcY(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int UAHcILKhOkOOMBop(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void XxMXTNNEiZyjYSpj(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void BOEVWFsCoToquLEz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void HqhoPIHKkqZNZyOc(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((15 + 22) % 22 > 0) {
        }
        java.util.List list = this.zza;
        int iUAHcILKhOkOOMBop = UAHcILKhOkOOMBop(parcel);
        hqhoPIHKkqZNZyOc(parcel, 1, EOGQenPGHFVuLbNi(list), false);
        LuXGrLSJbdvTkRcY(parcel, 2, this.zzb);
        XxMXTNNEiZyjYSpj(parcel, 3, this.zzc);
        bOEVWFsCoToquLEz(parcel, iUAHcILKhOkOOMBop);
    }
}

