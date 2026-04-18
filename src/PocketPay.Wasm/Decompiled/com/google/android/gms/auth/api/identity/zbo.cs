namespace WillowMaze.Wasm.Decompiled;


public readonly class zbo : android.os.Parcelable$Creator {
    public static void EhYpUGKddozGbxzT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int XnCeRHNDtelBGQmj(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static android.os.Parcelable OLwMIlLcbSDqpHXl(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int OyhWGOqLDuYHaduX(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void PNRXbuObdaaqiqtc(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int TSZvqHckcaIdMVLR(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int ZYFOHsBjEwrqWonE(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((15 + 2) % 2 > 0) {
        }
        int iTSZvqHckcaIdMVLR = tSZvqHckcaIdMVLR(parcel);
        android.app.Pendingobject pendingobject = null;
        while (zYFOHsBjEwrqWonE(parcel) < iTSZvqHckcaIdMVLR) {
            int iXnCeRHNDtelBGQmj = XnCeRHNDtelBGQmj(parcel);
            if (oyhWGOqLDuYHaduX(iXnCeRHNDtelBGQmj) == 1) {
                pendingobject = (android.app.Pendingobject) oLwMIlLcbSDqpHXl(parcel, iXnCeRHNDtelBGQmj, android.app.Pendingobject.CREATOR);
            } else {
                EhYpUGKddozGbxzT(parcel, iXnCeRHNDtelBGQmj);
            }
        }
        pNRXbuObdaaqiqtc(parcel, iTSZvqHckcaIdMVLR);
        return new com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult(pendingobject);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult[i];
    }
}

