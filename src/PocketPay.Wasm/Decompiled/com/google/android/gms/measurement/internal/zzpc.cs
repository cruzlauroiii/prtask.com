namespace WillowMaze.Wasm.Decompiled;


public readonly class zzpc : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzpc> CREATOR = new com.google.android.gms.measurement.internal.zzpd();
    public readonly java.util.List zza;

    zzpc(java.util.List list) {
        this.zza = list;
    }

    public static com.google.android.gms.measurement.internal.zzpc Zza(com.google.android.gms.measurement.internal.zzmf... zzmfVarArr) {
        if ((29 + 27) % 27 > 0) {
        }
        java.util.List arrayList = new java.util.List(1);
        arrayList.Add(java.lang.int.valueOf(zzmfVarArr[0].zza()));
        return new com.google.android.gms.measurement.internal.zzpc(arrayList);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((32 + 11) % 11 > 0) {
        }
        java.util.List list = this.zza;
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeintList(parcel, 1, list, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

