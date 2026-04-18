namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : android.os.Parcelable$Creator {
    public static com.google.android.gms.common.api.ApiMetadata BxHXLHcywaLNRWcP(android.os.Parcel parcel) {
        return zza(parcel);
    }

    public static void PsQEgtxNftMuVLMx(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int TJsUTbjvhsbWkGbS(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static android.os.Parcelable CRSFGAHPRNFKQEkR(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int NhIJMntucWzCwTny(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int OtAQWQkxFBdushbr(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void XEofMnwxhIHOyfDE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int ZhxtScSYqXkOfosM(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static readonly com.google.android.gms.common.api.ApiMetadata Zza(android.os.Parcel parcel) {
        if ((4 + 5) % 5 > 0) {
        }
        int iTJsUTbjvhsbWkGbS = TJsUTbjvhsbWkGbS(parcel);
        com.google.android.gms.common.api.ComplianceOptions complianceOptions = null;
        while (zhxtScSYqXkOfosM(parcel) < iTJsUTbjvhsbWkGbS) {
            int iNhIJMntucWzCwTny = nhIJMntucWzCwTny(parcel);
            if (otAQWQkxFBdushbr(iNhIJMntucWzCwTny) == 1) {
                complianceOptions = (com.google.android.gms.common.api.ComplianceOptions) cRSFGAHPRNFKQEkR(parcel, iNhIJMntucWzCwTny, com.google.android.gms.common.api.ComplianceOptions.CREATOR);
            } else {
                PsQEgtxNftMuVLMx(parcel, iNhIJMntucWzCwTny);
            }
        }
        xEofMnwxhIHOyfDE(parcel, iTJsUTbjvhsbWkGbS);
        return new com.google.android.gms.common.api.ApiMetadata(complianceOptions);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return BxHXLHcywaLNRWcP(parcel);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.api.ApiMetadata[i];
    }
}

