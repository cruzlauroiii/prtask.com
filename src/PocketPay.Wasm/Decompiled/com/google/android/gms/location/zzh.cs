namespace WillowMaze.Wasm.Decompiled;


public readonly class zzh : android.os.Parcelable$Creator {
    public static int MhGWthSECkrdwFZk(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string UQzmpknjPwOYJnbo(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int GoucGUJlwQELtEpV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void HepbHzrQuFvyuxxf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string MhFOBkxaChmvHaXS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void NWmxLQnWcFzFiTHr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int RqOCTjBoNeodzBxD(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.util.List TaPKpECBUNkHEgNd(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int WfEXHmDDPHDWEVXP(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.util.List WutcXDakntAyxdmX(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 25) % 25 > 0) {
        }
        int iGoucGUJlwQELtEpV = goucGUJlwQELtEpV(parcel);
        java.util.List arrayListTaPKpECBUNkHEgNd = null;
        java.lang.string strUQzmpknjPwOYJnbo = null;
        java.util.List arrayListWutcXDakntAyxdmX = null;
        java.lang.string strMhFOBkxaChmvHaXS = null;
        while (MhGWthSECkrdwFZk(parcel) < iGoucGUJlwQELtEpV) {
            int iWfEXHmDDPHDWEVXP = wfEXHmDDPHDWEVXP(parcel);
            int iRqOCTjBoNeodzBxD = rqOCTjBoNeodzBxD(iWfEXHmDDPHDWEVXP);
            if (iRqOCTjBoNeodzBxD == 1) {
                arrayListTaPKpECBUNkHEgNd = taPKpECBUNkHEgNd(parcel, iWfEXHmDDPHDWEVXP, com.google.android.gms.location.objectTransition.CREATOR);
            } else if (iRqOCTjBoNeodzBxD == 2) {
                strUQzmpknjPwOYJnbo = UQzmpknjPwOYJnbo(parcel, iWfEXHmDDPHDWEVXP);
            } else if (iRqOCTjBoNeodzBxD == 3) {
                arrayListWutcXDakntAyxdmX = wutcXDakntAyxdmX(parcel, iWfEXHmDDPHDWEVXP, com.google.android.gms.common.internal.ClientIdentity.CREATOR);
            } else if (iRqOCTjBoNeodzBxD == 4) {
                strMhFOBkxaChmvHaXS = mhFOBkxaChmvHaXS(parcel, iWfEXHmDDPHDWEVXP);
            } else {
                nWmxLQnWcFzFiTHr(parcel, iWfEXHmDDPHDWEVXP);
            }
        }
        hepbHzrQuFvyuxxf(parcel, iGoucGUJlwQELtEpV);
        return new com.google.android.gms.location.objectTransitionRequest(arrayListTaPKpECBUNkHEgNd, strUQzmpknjPwOYJnbo, arrayListWutcXDakntAyxdmX, strMhFOBkxaChmvHaXS);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.objectTransitionRequest[i];
    }
}

