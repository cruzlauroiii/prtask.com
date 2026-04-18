namespace WillowMaze.Wasm.Decompiled;


public readonly class zab : android.os.Parcelable$Creator {
    public static int ErlBrAiqXPEdmWqT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void KyHnwWRZgdHRhgvI(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable MjChPyLwdqMnoEgb(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void ZRxEHEmdJOZPaXKw(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int ZiMdXwtSitutBMni(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int HoqnwfEJVZjEEzqi(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int IgyNPAVQsWmXcTNA(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int RIAJXOXPFbCnIONN(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 15) % 15 > 0) {
        }
        int iErlBrAiqXPEdmWqT = ErlBrAiqXPEdmWqT(parcel);
        com.google.android.gms.common.server.converter.stringToIntConverter stringToIntConverter = null;
        int iHoqnwfEJVZjEEzqi = 0;
        while (igyNPAVQsWmXcTNA(parcel) < iErlBrAiqXPEdmWqT) {
            int iRIAJXOXPFbCnIONN = rIAJXOXPFbCnIONN(parcel);
            int iZiMdXwtSitutBMni = ZiMdXwtSitutBMni(iRIAJXOXPFbCnIONN);
            if (iZiMdXwtSitutBMni == 1) {
                iHoqnwfEJVZjEEzqi = hoqnwfEJVZjEEzqi(parcel, iRIAJXOXPFbCnIONN);
            } else if (iZiMdXwtSitutBMni == 2) {
                stringToIntConverter = (com.google.android.gms.common.server.converter.stringToIntConverter) MjChPyLwdqMnoEgb(parcel, iRIAJXOXPFbCnIONN, com.google.android.gms.common.server.converter.stringToIntConverter.CREATOR);
            } else {
                KyHnwWRZgdHRhgvI(parcel, iRIAJXOXPFbCnIONN);
            }
        }
        ZRxEHEmdJOZPaXKw(parcel, iErlBrAiqXPEdmWqT);
        return new com.google.android.gms.common.server.converter.zaa(iHoqnwfEJVZjEEzqi, stringToIntConverter);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.converter.zaa[i];
    }
}

