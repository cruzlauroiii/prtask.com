namespace WillowMaze.Wasm.Decompiled;


public readonly class zbp : android.os.Parcelable$Creator {
    public static int CuPzcxRxFOZwqhUI(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static android.os.Parcelable SCNaXfUaUoJNzkyW(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int XHjbaTowweeexidq(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void XatYuHUCKzUimXLr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int YKCVlPHOtgnNmtFE(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string EZnwdBFaxvWFNYXE(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int JZapGerNIiZofYZF(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int KLvuNXzRuLaRaCmV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void UgFzoJQbEGfjaMeo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((11 + 31) % 31 > 0) {
        }
        int iKLvuNXzRuLaRaCmV = kLvuNXzRuLaRaCmV(parcel);
        int iJZapGerNIiZofYZF = 0;
        com.google.android.gms.auth.api.identity.SignInPassword signInPassword = null;
        java.lang.string strEZnwdBFaxvWFNYXE = null;
        while (XHjbaTowweeexidq(parcel) < iKLvuNXzRuLaRaCmV) {
            int iCuPzcxRxFOZwqhUI = CuPzcxRxFOZwqhUI(parcel);
            int iYKCVlPHOtgnNmtFE = YKCVlPHOtgnNmtFE(iCuPzcxRxFOZwqhUI);
            if (iYKCVlPHOtgnNmtFE == 1) {
                signInPassword = (com.google.android.gms.auth.api.identity.SignInPassword) SCNaXfUaUoJNzkyW(parcel, iCuPzcxRxFOZwqhUI, com.google.android.gms.auth.api.identity.SignInPassword.CREATOR);
            } else if (iYKCVlPHOtgnNmtFE == 2) {
                strEZnwdBFaxvWFNYXE = eZnwdBFaxvWFNYXE(parcel, iCuPzcxRxFOZwqhUI);
            } else if (iYKCVlPHOtgnNmtFE == 3) {
                iJZapGerNIiZofYZF = jZapGerNIiZofYZF(parcel, iCuPzcxRxFOZwqhUI);
            } else {
                ugFzoJQbEGfjaMeo(parcel, iCuPzcxRxFOZwqhUI);
            }
        }
        XatYuHUCKzUimXLr(parcel, iKLvuNXzRuLaRaCmV);
        return new com.google.android.gms.auth.api.identity.SavePasswordRequest(signInPassword, strEZnwdBFaxvWFNYXE, iJZapGerNIiZofYZF);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.SavePasswordRequest[i];
    }
}

