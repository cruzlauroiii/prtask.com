namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : android.os.Parcelable$Creator {
    public static java.lang.string CBcPykYyppEEZAqP(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int JbuncxgIPOMwcWwL(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int KNKslyHOTufzkhrZ(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int OjuQueuXUpPdqZoc(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int TRLccTefyiALNgqy(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void XVyxEFBMAOCKRynX(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable HSSUDYVOfAssQMtc(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void LAfqkmvPplDgtnpH(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int OQHyCamDAXPHNWSq(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int WukGPGQCzandBkai(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((30 + 27) % 27 > 0) {
        }
        int iTRLccTefyiALNgqy = TRLccTefyiALNgqy(parcel);
        java.lang.string strCBcPykYyppEEZAqP = null;
        int iOjuQueuXUpPdqZoc = 0;
        int iWukGPGQCzandBkai = 0;
        android.accounts.Account account = null;
        while (JbuncxgIPOMwcWwL(parcel) < iTRLccTefyiALNgqy) {
            int iOQHyCamDAXPHNWSq = oQHyCamDAXPHNWSq(parcel);
            int iKNKslyHOTufzkhrZ = KNKslyHOTufzkhrZ(iOQHyCamDAXPHNWSq);
            if (iKNKslyHOTufzkhrZ == 1) {
                iOjuQueuXUpPdqZoc = OjuQueuXUpPdqZoc(parcel, iOQHyCamDAXPHNWSq);
            } else if (iKNKslyHOTufzkhrZ == 2) {
                iWukGPGQCzandBkai = wukGPGQCzandBkai(parcel, iOQHyCamDAXPHNWSq);
            } else if (iKNKslyHOTufzkhrZ == 3) {
                strCBcPykYyppEEZAqP = CBcPykYyppEEZAqP(parcel, iOQHyCamDAXPHNWSq);
            } else if (iKNKslyHOTufzkhrZ == 4) {
                account = (android.accounts.Account) hSSUDYVOfAssQMtc(parcel, iOQHyCamDAXPHNWSq, android.accounts.Account.CREATOR);
            } else {
                XVyxEFBMAOCKRynX(parcel, iOQHyCamDAXPHNWSq);
            }
        }
        lAfqkmvPplDgtnpH(parcel, iTRLccTefyiALNgqy);
        return new com.google.android.gms.auth.AccountChangeEventsRequest(iOjuQueuXUpPdqZoc, iWukGPGQCzandBkai, strCBcPykYyppEEZAqP, account);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.AccountChangeEventsRequest[i];
    }
}

