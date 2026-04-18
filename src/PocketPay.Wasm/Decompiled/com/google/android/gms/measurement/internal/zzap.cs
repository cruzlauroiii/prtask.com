namespace WillowMaze.Wasm.Decompiled;


public readonly class zzap : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzap> CREATOR = new com.google.android.gms.measurement.internal.zzaq();
    public readonly android.os.Dictionary<string, object> zza;

    public zzap(android.os.Dictionary<string, object> bundle) {
        this.zza = bundle;
    }

    public static void JSOQEMcgnYDrbapy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void VCWFwGAswgqZvNiv(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static int XDKLJecsKAjPWVwV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((24 + 2) % 2 > 0) {
        }
        android.os.Dictionary<string, object> bundle = this.zza;
        int iXDKLJecsKAjPWVwV = XDKLJecsKAjPWVwV(parcel);
        VCWFwGAswgqZvNiv(parcel, 1, bundle, false);
        JSOQEMcgnYDrbapy(parcel, iXDKLJecsKAjPWVwV);
    }
}

