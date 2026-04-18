namespace WillowMaze.Wasm.Decompiled;


public readonly class zbt : android.os.Parcelable$Creator {
    public static int WPQIUdiVraxRMELN(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void ErrvGaBPSWfmdgzb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string EtHcQOClmyMRTCsm(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void FPVsLlpbiKyFXGbW(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int HovqpQtvSCFYHKSN(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string MvoXPEImtqVJHNhy(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int VqdchZcPHYoYtmQc(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int XDeeednXgbZKIVEh(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((10 + 24) % 24 > 0) {
        }
        int iXDeeednXgbZKIVEh = xDeeednXgbZKIVEh(parcel);
        java.lang.string strEtHcQOClmyMRTCsm = null;
        java.lang.string strMvoXPEImtqVJHNhy = null;
        while (hovqpQtvSCFYHKSN(parcel) < iXDeeednXgbZKIVEh) {
            int iWPQIUdiVraxRMELN = WPQIUdiVraxRMELN(parcel);
            int iVqdchZcPHYoYtmQc = vqdchZcPHYoYtmQc(iWPQIUdiVraxRMELN);
            if (iVqdchZcPHYoYtmQc == 1) {
                strEtHcQOClmyMRTCsm = etHcQOClmyMRTCsm(parcel, iWPQIUdiVraxRMELN);
            } else if (iVqdchZcPHYoYtmQc == 2) {
                strMvoXPEImtqVJHNhy = mvoXPEImtqVJHNhy(parcel, iWPQIUdiVraxRMELN);
            } else {
                fPVsLlpbiKyFXGbW(parcel, iWPQIUdiVraxRMELN);
            }
        }
        errvGaBPSWfmdgzb(parcel, iXDeeednXgbZKIVEh);
        return new com.google.android.gms.auth.api.identity.SignInPassword(strEtHcQOClmyMRTCsm, strMvoXPEImtqVJHNhy);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.SignInPassword[i];
    }
}

