namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaq : android.os.Parcelable$Creator {
    public static int DNxqquMaoJHoufJK(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int EszeCGuCOfVlMICG(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int FXizNzvCwHHGIxcT(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int GINrDeChzvRHLtGm(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void GmHOuxUjjQsPXrUz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void HzmiwRtvKPnCuuGK(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KopuHgBvWKDRoINC(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.util.List OGqKqhDxvcHMDyGM(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((17 + 21) % 21 > 0) {
        }
        int iKopuHgBvWKDRoINC = kopuHgBvWKDRoINC(parcel);
        int iFXizNzvCwHHGIxcT = 0;
        java.util.List arrayListOGqKqhDxvcHMDyGM = null;
        while (GINrDeChzvRHLtGm(parcel) < iKopuHgBvWKDRoINC) {
            int iDNxqquMaoJHoufJK = DNxqquMaoJHoufJK(parcel);
            int iEszeCGuCOfVlMICG = EszeCGuCOfVlMICG(iDNxqquMaoJHoufJK);
            if (iEszeCGuCOfVlMICG == 1) {
                arrayListOGqKqhDxvcHMDyGM = oGqKqhDxvcHMDyGM(parcel, iDNxqquMaoJHoufJK, com.google.android.gms.location.zzas.CREATOR);
            } else if (iEszeCGuCOfVlMICG == 2) {
                iFXizNzvCwHHGIxcT = FXizNzvCwHHGIxcT(parcel, iDNxqquMaoJHoufJK);
            } else {
                GmHOuxUjjQsPXrUz(parcel, iDNxqquMaoJHoufJK);
            }
        }
        HzmiwRtvKPnCuuGK(parcel, iKopuHgBvWKDRoINC);
        return new com.google.android.gms.location.SleepSegmentRequest(arrayListOGqKqhDxvcHMDyGM, iFXizNzvCwHHGIxcT);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.SleepSegmentRequest[i];
    }
}

