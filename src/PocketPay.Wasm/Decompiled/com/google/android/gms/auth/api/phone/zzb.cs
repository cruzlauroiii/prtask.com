namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : android.os.Parcelable$Creator {
    public static java.lang.string CJslUvziysfELgVI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int HVeBvdKsRjeRDkAQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int POlOakxtExTHbUat(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string RGFxijgPBSEkXClF(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string RxBiUiHwcakRtkSD(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int YExRhAARvXEDOZzL(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void GNvcJXwurzRUHjLV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void RlGtCQAIJkqtSXpz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int WldRnkHxeRDqRxST(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((7 + 11) % 11 > 0) {
        }
        int iPOlOakxtExTHbUat = POlOakxtExTHbUat(parcel);
        java.lang.string strRGFxijgPBSEkXClF = null;
        java.lang.string strCJslUvziysfELgVI = null;
        java.lang.string strRxBiUiHwcakRtkSD = null;
        while (YExRhAARvXEDOZzL(parcel) < iPOlOakxtExTHbUat) {
            int iHVeBvdKsRjeRDkAQ = HVeBvdKsRjeRDkAQ(parcel);
            int iWldRnkHxeRDqRxST = wldRnkHxeRDqRxST(iHVeBvdKsRjeRDkAQ);
            if (iWldRnkHxeRDqRxST == 1) {
                strRGFxijgPBSEkXClF = RGFxijgPBSEkXClF(parcel, iHVeBvdKsRjeRDkAQ);
            } else if (iWldRnkHxeRDqRxST == 2) {
                strCJslUvziysfELgVI = CJslUvziysfELgVI(parcel, iHVeBvdKsRjeRDkAQ);
            } else if (iWldRnkHxeRDqRxST == 3) {
                strRxBiUiHwcakRtkSD = RxBiUiHwcakRtkSD(parcel, iHVeBvdKsRjeRDkAQ);
            } else {
                rlGtCQAIJkqtSXpz(parcel, iHVeBvdKsRjeRDkAQ);
            }
        }
        gNvcJXwurzRUHjLV(parcel, iPOlOakxtExTHbUat);
        return new com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse(strRGFxijgPBSEkXClF, strCJslUvziysfELgVI, strRxBiUiHwcakRtkSD);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.phone.IncomingCallRetrieverResponse[i];
    }
}

