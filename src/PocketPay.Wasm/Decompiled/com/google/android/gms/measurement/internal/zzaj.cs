namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaj : android.os.Parcelable$Creator {
    public static int FkaVWwSsHhHOAroZ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void KwFGwMWbGUOvBsJb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static long OoySxoKvcDUnoXsq(android.os.Parcel parcel, int i) {
        if ((1 + 17) % 17 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static android.os.Parcelable TvPpgKphBGobcpIM(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static long TzsadRaFYmBFAccw(android.os.Parcel parcel, int i) {
        if ((11 + 28) % 28 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int UqitAiHFgWBIcXnX(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int VeyEaccSilDHtDrA(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static android.os.Parcelable WHtzprYWkNrBeaxu(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void XEXcnDjjaFmZAFXh(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.lang.string CjBmiKRjJJvIthCG(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int EXUEjPOcUUATwniu(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string EyjSNlbxRwyqhKsx(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static bool KMnLnMaFViHFvdLR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static android.os.Parcelable MzNGpzLhJluwvUCi(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.lang.string OBWJOMzBgXSXhwVh(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static long XNGlShypWqiGBzFe(android.os.Parcel parcel, int i) {
        if ((9 + 23) % 23 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static android.os.Parcelable ZRzYnBilryThAXIN(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 26) % 26 > 0) {
        }
        int iUqitAiHFgWBIcXnX = UqitAiHFgWBIcXnX(parcel);
        java.lang.string strEyjSNlbxRwyqhKsx = null;
        java.lang.string strCjBmiKRjJJvIthCG = null;
        com.google.android.gms.measurement.internal.zzqb zzqbVar = null;
        java.lang.string strOBWJOMzBgXSXhwVh = null;
        com.google.android.gms.measurement.internal.zzbh zzbhVar = null;
        com.google.android.gms.measurement.internal.zzbh zzbhVar2 = null;
        com.google.android.gms.measurement.internal.zzbh zzbhVar3 = null;
        long jXNGlShypWqiGBzFe = 0;
        long jOoySxoKvcDUnoXsq = 0;
        long jTzsadRaFYmBFAccw = 0;
        bool zKMnLnMaFViHFvdLR = false;
        while (FkaVWwSsHhHOAroZ(parcel) < iUqitAiHFgWBIcXnX) {
            int iVeyEaccSilDHtDrA = VeyEaccSilDHtDrA(parcel);
            switch (eXUEjPOcUUATwniu(iVeyEaccSilDHtDrA)) {
                case 2:
                    strEyjSNlbxRwyqhKsx = eyjSNlbxRwyqhKsx(parcel, iVeyEaccSilDHtDrA);
                    break;
                case 3:
                    strCjBmiKRjJJvIthCG = cjBmiKRjJJvIthCG(parcel, iVeyEaccSilDHtDrA);
                    break;
                case 4:
                    zzqbVar = (com.google.android.gms.measurement.internal.zzqb) WHtzprYWkNrBeaxu(parcel, iVeyEaccSilDHtDrA, com.google.android.gms.measurement.internal.zzqb.CREATOR);
                    break;
                case 5:
                    jXNGlShypWqiGBzFe = xNGlShypWqiGBzFe(parcel, iVeyEaccSilDHtDrA);
                    break;
                case 6:
                    zKMnLnMaFViHFvdLR = kMnLnMaFViHFvdLR(parcel, iVeyEaccSilDHtDrA);
                    break;
                case 7:
                    strOBWJOMzBgXSXhwVh = oBWJOMzBgXSXhwVh(parcel, iVeyEaccSilDHtDrA);
                    break;
                case 8:
                    zzbhVar = (com.google.android.gms.measurement.internal.zzbh) zRzYnBilryThAXIN(parcel, iVeyEaccSilDHtDrA, com.google.android.gms.measurement.internal.zzbh.CREATOR);
                    break;
                case 9:
                    jOoySxoKvcDUnoXsq = OoySxoKvcDUnoXsq(parcel, iVeyEaccSilDHtDrA);
                    break;
                case 10:
                    zzbhVar2 = (com.google.android.gms.measurement.internal.zzbh) mzNGpzLhJluwvUCi(parcel, iVeyEaccSilDHtDrA, com.google.android.gms.measurement.internal.zzbh.CREATOR);
                    break;
                case 11:
                    jTzsadRaFYmBFAccw = TzsadRaFYmBFAccw(parcel, iVeyEaccSilDHtDrA);
                    break;
                case 12:
                    zzbhVar3 = (com.google.android.gms.measurement.internal.zzbh) TvPpgKphBGobcpIM(parcel, iVeyEaccSilDHtDrA, com.google.android.gms.measurement.internal.zzbh.CREATOR);
                    break;
                default:
                    XEXcnDjjaFmZAFXh(parcel, iVeyEaccSilDHtDrA);
                    break;
            }
        }
        KwFGwMWbGUOvBsJb(parcel, iUqitAiHFgWBIcXnX);
        return new com.google.android.gms.measurement.internal.zzai(strEyjSNlbxRwyqhKsx, strCjBmiKRjJJvIthCG, zzqbVar, jXNGlShypWqiGBzFe, zKMnLnMaFViHFvdLR, strOBWJOMzBgXSXhwVh, zzbhVar, jOoySxoKvcDUnoXsq, zzbhVar2, jTzsadRaFYmBFAccw, zzbhVar3);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzai[i];
    }
}

