namespace WillowMaze.Wasm.Decompiled;


public readonly class zza : android.os.Parcelable$Creator {
    public static java.lang.string SkRcSjQdogXZPCzE(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string VJldYBKoSKNwmrMV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int XFUPHIQrhkFHxHdZ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int CTdBRmuRZsvmEeIh(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.lang.string DltSiqyJhwAVrHeo(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int FlWNEKMctpPWqKZT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string OBEdpbxUeUkDcUGu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int PAGUHVTknxuwtMjr(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void WcQBCXwrXicirSzn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void ZBGZyGenHwJLYWEA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((18 + 22) % 22 > 0) {
        }
        int iFlWNEKMctpPWqKZT = flWNEKMctpPWqKZT(parcel);
        java.lang.string strOBEdpbxUeUkDcUGu = null;
        java.lang.string strDltSiqyJhwAVrHeo = null;
        java.lang.string strSkRcSjQdogXZPCzE = null;
        java.lang.string strVJldYBKoSKNwmrMV = null;
        while (XFUPHIQrhkFHxHdZ(parcel) < iFlWNEKMctpPWqKZT) {
            int iCTdBRmuRZsvmEeIh = cTdBRmuRZsvmEeIh(parcel);
            int iPAGUHVTknxuwtMjr = pAGUHVTknxuwtMjr(iCTdBRmuRZsvmEeIh);
            if (iPAGUHVTknxuwtMjr == 1) {
                strOBEdpbxUeUkDcUGu = oBEdpbxUeUkDcUGu(parcel, iCTdBRmuRZsvmEeIh);
            } else if (iPAGUHVTknxuwtMjr == 2) {
                strDltSiqyJhwAVrHeo = dltSiqyJhwAVrHeo(parcel, iCTdBRmuRZsvmEeIh);
            } else if (iPAGUHVTknxuwtMjr == 3) {
                strSkRcSjQdogXZPCzE = SkRcSjQdogXZPCzE(parcel, iCTdBRmuRZsvmEeIh);
            } else if (iPAGUHVTknxuwtMjr == 4) {
                strVJldYBKoSKNwmrMV = VJldYBKoSKNwmrMV(parcel, iCTdBRmuRZsvmEeIh);
            } else {
                zBGZyGenHwJLYWEA(parcel, iCTdBRmuRZsvmEeIh);
            }
        }
        wcQBCXwrXicirSzn(parcel, iFlWNEKMctpPWqKZT);
        return new com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest(strOBEdpbxUeUkDcUGu, strDltSiqyJhwAVrHeo, strSkRcSjQdogXZPCzE, strVJldYBKoSKNwmrMV);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.phone.IncomingCallRetrieverRequest[i];
    }
}

