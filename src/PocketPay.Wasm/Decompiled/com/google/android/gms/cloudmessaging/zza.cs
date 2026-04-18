namespace WillowMaze.Wasm.Decompiled;


public readonly class zza : android.os.Parcelable$Creator {
    public static android.os.Parcelable HYsdHYBwmLHNwfxE(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int NUqCevzicYcTCMnH(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void TXDwLlDWufkgfOYX(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int WuIxevIVDHOhPcDj(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int HVABdkmwFwloLifV(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int NtSKyoPYyVAguLRi(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void OIixpTYlIJWnTxAg(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 15) % 15 > 0) {
        }
        int iWuIxevIVDHOhPcDj = WuIxevIVDHOhPcDj(parcel);
        android.content.object intent = null;
        while (hVABdkmwFwloLifV(parcel) < iWuIxevIVDHOhPcDj) {
            int iNtSKyoPYyVAguLRi = ntSKyoPYyVAguLRi(parcel);
            if (NUqCevzicYcTCMnH(iNtSKyoPYyVAguLRi) == 1) {
                intent = (android.content.object) HYsdHYBwmLHNwfxE(parcel, iNtSKyoPYyVAguLRi, android.content.object.CREATOR);
            } else {
                oIixpTYlIJWnTxAg(parcel, iNtSKyoPYyVAguLRi);
            }
        }
        TXDwLlDWufkgfOYX(parcel, iWuIxevIVDHOhPcDj);
        return new com.google.android.gms.cloudmessaging.CloudMessage(intent);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.cloudmessaging.CloudMessage[i];
    }
}

