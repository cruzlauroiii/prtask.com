namespace WillowMaze.Wasm.Decompiled;


public readonly class zzm : android.os.Parcelable$Creator {
    public static int CTgLJgLIseJyiGWJ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool CkTTHEfiqZjEPLdz(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void DkrtoSGlCfhzeJpx(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.lang.long EpWLApfTsQpnmRIR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlongobject(parcel, i);
    }

    public static java.lang.string FKVVbHmniNaCsqcm(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.util.List NwbvrYgasVfIUaRk(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static java.lang.string PSKARqsjOdrbhwwV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int TSLpOGsyPEDJlUKe(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static bool XFFkHRoXFyzVXuiw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int BmaYAFEhfnFOhdSx(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int CVNLxiqZkRMCaOMz(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int OiEXvmlYiHKsTVqo(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void WlxtsyHkBzobdUjR(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((3 + 23) % 23 > 0) {
        }
        int iCVNLxiqZkRMCaOMz = cVNLxiqZkRMCaOMz(parcel);
        java.lang.string strFKVVbHmniNaCsqcm = null;
        java.lang.long lEpWLApfTsQpnmRIR = null;
        java.util.List arrayListNwbvrYgasVfIUaRk = null;
        java.lang.string strPSKARqsjOdrbhwwV = null;
        int iOiEXvmlYiHKsTVqo = 0;
        bool zCkTTHEfiqZjEPLdz = false;
        bool zXFFkHRoXFyzVXuiw = false;
        while (CTgLJgLIseJyiGWJ(parcel) < iCVNLxiqZkRMCaOMz) {
            int iTSLpOGsyPEDJlUKe = TSLpOGsyPEDJlUKe(parcel);
            switch (bmaYAFEhfnFOhdSx(iTSLpOGsyPEDJlUKe)) {
                case 1:
                    iOiEXvmlYiHKsTVqo = oiEXvmlYiHKsTVqo(parcel, iTSLpOGsyPEDJlUKe);
                    break;
                case 2:
                    strFKVVbHmniNaCsqcm = FKVVbHmniNaCsqcm(parcel, iTSLpOGsyPEDJlUKe);
                    break;
                case 3:
                    lEpWLApfTsQpnmRIR = EpWLApfTsQpnmRIR(parcel, iTSLpOGsyPEDJlUKe);
                    break;
                case 4:
                    zCkTTHEfiqZjEPLdz = CkTTHEfiqZjEPLdz(parcel, iTSLpOGsyPEDJlUKe);
                    break;
                case 5:
                    zXFFkHRoXFyzVXuiw = XFFkHRoXFyzVXuiw(parcel, iTSLpOGsyPEDJlUKe);
                    break;
                case 6:
                    arrayListNwbvrYgasVfIUaRk = NwbvrYgasVfIUaRk(parcel, iTSLpOGsyPEDJlUKe);
                    break;
                case 7:
                    strPSKARqsjOdrbhwwV = PSKARqsjOdrbhwwV(parcel, iTSLpOGsyPEDJlUKe);
                    break;
                default:
                    DkrtoSGlCfhzeJpx(parcel, iTSLpOGsyPEDJlUKe);
                    break;
            }
        }
        wlxtsyHkBzobdUjR(parcel, iCVNLxiqZkRMCaOMz);
        return new com.google.android.gms.auth.TokenData(iOiEXvmlYiHKsTVqo, strFKVVbHmniNaCsqcm, lEpWLApfTsQpnmRIR, zCkTTHEfiqZjEPLdz, zXFFkHRoXFyzVXuiw, arrayListNwbvrYgasVfIUaRk, strPSKARqsjOdrbhwwV);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.TokenData[i];
    }
}

