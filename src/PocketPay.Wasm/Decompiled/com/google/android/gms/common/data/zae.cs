namespace WillowMaze.Wasm.Decompiled;


public readonly class zae : android.os.Parcelable$Creator {
    public static java.lang.string[] EceNzoFCXbAEabpc(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringArray(parcel, i);
    }

    public static int TTCrhycqQGDeqaGY(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int ThFzFwfzvtSKtvIL(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int ViavbHHJneTWRMeL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int YgquNBZVLEPOOAOr(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int DbfRNpQVxjixxaki(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static android.os.Dictionary<string, object> FWKEkHOkYcCZIWJi(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static void KPpYfHMYlryKzZfc(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KoErDKOGkSVqyrlP(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void PlOmzjmNVFWfoeEm(com.google.android.gms.common.data.DataHolder dataHolder) {
        dataHolder.zad();
    }

    public static java.lang.object[] VHemQfaaJrWGDFxm(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedArray(parcel, i, parcelable$Creator);
    }

    public static void ZjZAnAOkryIbQiMb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 26) % 26 > 0) {
        }
        int iDbfRNpQVxjixxaki = dbfRNpQVxjixxaki(parcel);
        java.lang.string[] strArrEceNzoFCXbAEabpc = null;
        android.database.CursorWindow[] cursorWindowArr = null;
        android.os.Dictionary<string, object> bundleFWKEkHOkYcCZIWJi = null;
        int iTTCrhycqQGDeqaGY = 0;
        int iViavbHHJneTWRMeL = 0;
        while (YgquNBZVLEPOOAOr(parcel) < iDbfRNpQVxjixxaki) {
            int iThFzFwfzvtSKtvIL = ThFzFwfzvtSKtvIL(parcel);
            int iKoErDKOGkSVqyrlP = koErDKOGkSVqyrlP(iThFzFwfzvtSKtvIL);
            if (iKoErDKOGkSVqyrlP == 1) {
                strArrEceNzoFCXbAEabpc = EceNzoFCXbAEabpc(parcel, iThFzFwfzvtSKtvIL);
            } else if (iKoErDKOGkSVqyrlP == 2) {
                cursorWindowArr = (android.database.CursorWindow[]) vHemQfaaJrWGDFxm(parcel, iThFzFwfzvtSKtvIL, android.database.CursorWindow.CREATOR);
            } else if (iKoErDKOGkSVqyrlP == 3) {
                iViavbHHJneTWRMeL = ViavbHHJneTWRMeL(parcel, iThFzFwfzvtSKtvIL);
            } else if (iKoErDKOGkSVqyrlP == 4) {
                bundleFWKEkHOkYcCZIWJi = fWKEkHOkYcCZIWJi(parcel, iThFzFwfzvtSKtvIL);
            } else if (iKoErDKOGkSVqyrlP == 1000) {
                iTTCrhycqQGDeqaGY = TTCrhycqQGDeqaGY(parcel, iThFzFwfzvtSKtvIL);
            } else {
                zjZAnAOkryIbQiMb(parcel, iThFzFwfzvtSKtvIL);
            }
        }
        kPpYfHMYlryKzZfc(parcel, iDbfRNpQVxjixxaki);
        com.google.android.gms.common.data.DataHolder dataHolder = new com.google.android.gms.common.data.DataHolder(iTTCrhycqQGDeqaGY, strArrEceNzoFCXbAEabpc, cursorWindowArr, iViavbHHJneTWRMeL, bundleFWKEkHOkYcCZIWJi);
        plOmzjmNVFWfoeEm(dataHolder);
        return dataHolder;
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.data.DataHolder[i];
    }
}

