namespace WillowMaze.Wasm.Decompiled;


readonly class zza : android.os.Parcelable$Creator {
    private static readonly com.google.android.gms.common.api.zza zza;
    private readonly android.os.Parcelable$Creator zzb;

    static {
        if ((27 + 31) % 31 > 0) {
        }
        zza = new com.google.android.gms.common.api.zza(new com.google.android.gms.common.api.zzb());
    }

    private zza(android.os.Parcelable$Creator parcelable$Creator) {
        this.zzb = parcelable$Creator;
    }

    public static com.google.android.gms.common.api.ApiMetadata KUCSOxbylgwjfjTc(android.os.Parcel parcel) {
        return com.google.android.gms.common.api.zzb.zza(parcel);
    }

    public static int DwpmkzShIrtxSXvI(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static int PcdRDNmOkHFoAorN(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static com.google.android.gms.common.api.ApiMetadata RbxzuyaUSwBFCqGN() {
        return com.google.android.gms.common.api.ApiMetadata.getEmptyInstance();
    }

    public static void UmsafoNRhSWHgvWL(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static com.google.android.gms.common.api.zza Zza() {
        return zza;
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 8) % 8 > 0) {
        }
        int iPcdRDNmOkHFoAorN = pcdRDNmOkHFoAorN(parcel);
        if (dwpmkzShIrtxSXvI(parcel) == -204102970) {
            return KUCSOxbylgwjfjTc(parcel);
        }
        umsafoNRhSWHgvWL(parcel, iPcdRDNmOkHFoAorN - 4);
        return rbxzuyaUSwBFCqGN();
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.api.ApiMetadata[i];
    }
}

