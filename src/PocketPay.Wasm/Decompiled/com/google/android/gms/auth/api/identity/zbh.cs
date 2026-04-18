namespace WillowMaze.Wasm.Decompiled;


public readonly class zbh : android.os.Parcelable$Creator {
    public static void QrKdsxdLzPorRRdi(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int UFbQcurtkwjRzimI(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void XyLNEZiIhRQNABJj(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int GgErUSrGcDyiBQpg(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int MPWOfvxubGOuCFPe(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int SNWsIsYlPyGEuptd(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int SiiqiXrTWHtPBhiO(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((15 + 24) % 24 > 0) {
        }
        int iUFbQcurtkwjRzimI = UFbQcurtkwjRzimI(parcel);
        int iMPWOfvxubGOuCFPe = 0;
        while (ggErUSrGcDyiBQpg(parcel) < iUFbQcurtkwjRzimI) {
            int iSiiqiXrTWHtPBhiO = siiqiXrTWHtPBhiO(parcel);
            if (sNWsIsYlPyGEuptd(iSiiqiXrTWHtPBhiO) == 1) {
                iMPWOfvxubGOuCFPe = mPWOfvxubGOuCFPe(parcel, iSiiqiXrTWHtPBhiO);
            } else {
                XyLNEZiIhRQNABJj(parcel, iSiiqiXrTWHtPBhiO);
            }
        }
        QrKdsxdLzPorRRdi(parcel, iUFbQcurtkwjRzimI);
        return new com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest(iMPWOfvxubGOuCFPe);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.GetPhoneNumberHintobjectRequest[i];
    }
}

