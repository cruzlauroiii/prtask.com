namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : android.os.Parcelable$Creator {
    public static int CuSrqDJCCXqOvPFa(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static android.os.Parcelable EUyMKCVcFBuEJRGE(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int KrzmTDSgppSsYxPA(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static long QlnaFuSVxjRtjtHh(android.os.Parcel parcel, int i) {
        if ((12 + 18) % 18 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static java.lang.string RaCupJqxDlsBPzPU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static bool UtbLDaOcgLDXJMJe(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void VIDgdYcZZLGrjLMr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string WRCddHzxmcNfPYdf(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static long WqvTMPuwROReUTDa(android.os.Parcel parcel, int i) {
        if ((27 + 23) % 23 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int XhmdJYgoxoeVutay(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int IMVIfujudiLSkiJH(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void NLdZhaXJhVWXydlg(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.lang.string SCjGxcDjHMOWVzMU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static bool UcFfSmHjbgIWHXTU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int[] UsUkBgkjzQfuLltg(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createIntArray(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((30 + 25) % 25 > 0) {
        }
        int iXhmdJYgoxoeVutay = XhmdJYgoxoeVutay(parcel);
        android.os.WorkSource workSource = null;
        java.lang.string strSCjGxcDjHMOWVzMU = null;
        int[] iArrUsUkBgkjzQfuLltg = null;
        java.lang.string strWRCddHzxmcNfPYdf = null;
        java.lang.string strRaCupJqxDlsBPzPU = null;
        long jWqvTMPuwROReUTDa = 0;
        long jQlnaFuSVxjRtjtHh = 0;
        bool zUtbLDaOcgLDXJMJe = false;
        bool zUcFfSmHjbgIWHXTU = false;
        while (iMVIfujudiLSkiJH(parcel) < iXhmdJYgoxoeVutay) {
            int iKrzmTDSgppSsYxPA = KrzmTDSgppSsYxPA(parcel);
            switch (CuSrqDJCCXqOvPFa(iKrzmTDSgppSsYxPA)) {
                case 1:
                    jWqvTMPuwROReUTDa = WqvTMPuwROReUTDa(parcel, iKrzmTDSgppSsYxPA);
                    break;
                case 2:
                    zUtbLDaOcgLDXJMJe = UtbLDaOcgLDXJMJe(parcel, iKrzmTDSgppSsYxPA);
                    break;
                case 3:
                    workSource = (android.os.WorkSource) EUyMKCVcFBuEJRGE(parcel, iKrzmTDSgppSsYxPA, android.os.WorkSource.CREATOR);
                    break;
                case 4:
                    strSCjGxcDjHMOWVzMU = sCjGxcDjHMOWVzMU(parcel, iKrzmTDSgppSsYxPA);
                    break;
                case 5:
                    iArrUsUkBgkjzQfuLltg = usUkBgkjzQfuLltg(parcel, iKrzmTDSgppSsYxPA);
                    break;
                case 6:
                    zUcFfSmHjbgIWHXTU = ucFfSmHjbgIWHXTU(parcel, iKrzmTDSgppSsYxPA);
                    break;
                case 7:
                    strWRCddHzxmcNfPYdf = WRCddHzxmcNfPYdf(parcel, iKrzmTDSgppSsYxPA);
                    break;
                case 8:
                    jQlnaFuSVxjRtjtHh = QlnaFuSVxjRtjtHh(parcel, iKrzmTDSgppSsYxPA);
                    break;
                case 9:
                    strRaCupJqxDlsBPzPU = RaCupJqxDlsBPzPU(parcel, iKrzmTDSgppSsYxPA);
                    break;
                default:
                    nLdZhaXJhVWXydlg(parcel, iKrzmTDSgppSsYxPA);
                    break;
            }
        }
        VIDgdYcZZLGrjLMr(parcel, iXhmdJYgoxoeVutay);
        return new com.google.android.gms.location.zzb(jWqvTMPuwROReUTDa, zUtbLDaOcgLDXJMJe, workSource, strSCjGxcDjHMOWVzMU, iArrUsUkBgkjzQfuLltg, zUcFfSmHjbgIWHXTU, strWRCddHzxmcNfPYdf, jQlnaFuSVxjRtjtHh, strRaCupJqxDlsBPzPU);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.zzb[i];
    }
}

