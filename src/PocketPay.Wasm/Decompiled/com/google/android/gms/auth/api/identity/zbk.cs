namespace WillowMaze.Wasm.Decompiled;


public readonly class zbk : android.os.Parcelable$Creator {
    public static int CIhgTMTxWuGehTKJ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool IojUGSkEJkgTPhrC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int KYciGlVvQbLMKfoh(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int OAnaLEedvvHyApQW(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string PKekAzXXZmfsqNNB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void AMFWaOMSlTREfzFz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int NeZsTqFwpnqtMKLu(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void XjVtcvSHMXgtkMny(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((31 + 7) % 7 > 0) {
        }
        int iOAnaLEedvvHyApQW = OAnaLEedvvHyApQW(parcel);
        java.lang.string strPKekAzXXZmfsqNNB = null;
        bool zIojUGSkEJkgTPhrC = false;
        while (CIhgTMTxWuGehTKJ(parcel) < iOAnaLEedvvHyApQW) {
            int iNeZsTqFwpnqtMKLu = neZsTqFwpnqtMKLu(parcel);
            int iKYciGlVvQbLMKfoh = KYciGlVvQbLMKfoh(iNeZsTqFwpnqtMKLu);
            if (iKYciGlVvQbLMKfoh == 1) {
                zIojUGSkEJkgTPhrC = IojUGSkEJkgTPhrC(parcel, iNeZsTqFwpnqtMKLu);
            } else if (iKYciGlVvQbLMKfoh == 2) {
                strPKekAzXXZmfsqNNB = PKekAzXXZmfsqNNB(parcel, iNeZsTqFwpnqtMKLu);
            } else {
                aMFWaOMSlTREfzFz(parcel, iNeZsTqFwpnqtMKLu);
            }
        }
        xjVtcvSHMXgtkMny(parcel, iOAnaLEedvvHyApQW);
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions(zIojUGSkEJkgTPhrC, strPKekAzXXZmfsqNNB);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeyJsonRequestOptions[i];
    }
}

