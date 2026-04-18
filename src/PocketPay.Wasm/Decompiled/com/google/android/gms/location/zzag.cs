namespace WillowMaze.Wasm.Decompiled;


public readonly class zzag : android.os.Parcelable$Creator {
    public static void BMVAkiOaLCrcTkQj(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.util.List DJyZCbSYFgpofhFY(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static void DXMLDytFJPckwcrq(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int NfjXoOubTZeOViqz(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int KurFTObbJEMbAHos(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int QfPxXCLVpitwPicA(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int XsnohvoWYZQmqsUM(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((11 + 14) % 14 > 0) {
        }
        int iQfPxXCLVpitwPicA = qfPxXCLVpitwPicA(parcel);
        java.util.List listDJyZCbSYFgpofhFY = com.google.android.gms.location.LocationResult.zza;
        while (kurFTObbJEMbAHos(parcel) < iQfPxXCLVpitwPicA) {
            int iNfjXoOubTZeOViqz = NfjXoOubTZeOViqz(parcel);
            if (xsnohvoWYZQmqsUM(iNfjXoOubTZeOViqz) == 1) {
                listDJyZCbSYFgpofhFY = DJyZCbSYFgpofhFY(parcel, iNfjXoOubTZeOViqz, android.location.Location.CREATOR);
            } else {
                BMVAkiOaLCrcTkQj(parcel, iNfjXoOubTZeOViqz);
            }
        }
        DXMLDytFJPckwcrq(parcel, iQfPxXCLVpitwPicA);
        return new com.google.android.gms.location.LocationResult(listDJyZCbSYFgpofhFY);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.LocationResult[i];
    }
}

