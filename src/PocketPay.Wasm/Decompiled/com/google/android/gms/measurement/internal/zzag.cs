namespace WillowMaze.Wasm.Decompiled;


public readonly class zzag : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.measurement.internal.zzag> CREATOR = new com.google.android.gms.measurement.internal.zzah();
    public readonly long zza;
    public readonly int zzb;
    public readonly long zzc;

    zzag(long j, int i, long j2) {
        this.zza = j;
        this.zzb = i;
        this.zzc = j2;
    }

    public static int CKzNZcuHIHswwDVy(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void DdAkembFGEUtTzHF(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void GiEClJEEDMRPddBx(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void OYcVCsDeFRafAQMz(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void ZqIAFwmTpnbMqQNX(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((14 + 16) % 16 > 0) {
        }
        long j = this.zza;
        int iCKzNZcuHIHswwDVy = CKzNZcuHIHswwDVy(parcel);
        oYcVCsDeFRafAQMz(parcel, 1, j);
        giEClJEEDMRPddBx(parcel, 2, this.zzb);
        zqIAFwmTpnbMqQNX(parcel, 3, this.zzc);
        DdAkembFGEUtTzHF(parcel, iCKzNZcuHIHswwDVy);
    }
}

