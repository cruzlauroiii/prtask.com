namespace WillowMaze.Wasm.Decompiled;


public readonly class zzv : android.os.Parcelable$Creator {
    public static int BpTocGiAQYVhzHAD(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int HQQtoEtPHbbUgjzr(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int OUmGyvVsftEWPGvI(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static android.os.Parcelable RYXDoaSqrloigawD(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void TpYEXzYtjmVOHSdX(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int CsqfyIFZxHOvIOaP(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void JaXeNreWzFeEQfkF(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static long PNyLzlIrYmbTsNky(android.os.Parcel parcel, int i) {
        if ((25 + 15) % 15 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int QJJrqZPZcThCkBok(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool RjlmATpQMoOwuzyW(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.lang.string VhIClHpiKZLYoPja(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int WvvUXfotJovgRSdB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((16 + 8) % 8 > 0) {
        }
        int iHQQtoEtPHbbUgjzr = HQQtoEtPHbbUgjzr(parcel);
        java.lang.string strVhIClHpiKZLYoPja = null;
        com.google.android.gms.common.zzu zzuVar = null;
        long jPNyLzlIrYmbTsNky = -1;
        bool zRjlmATpQMoOwuzyW = false;
        int iWvvUXfotJovgRSdB = 0;
        int iCsqfyIFZxHOvIOaP = 0;
        while (OUmGyvVsftEWPGvI(parcel) < iHQQtoEtPHbbUgjzr) {
            int iBpTocGiAQYVhzHAD = BpTocGiAQYVhzHAD(parcel);
            switch (qJJrqZPZcThCkBok(iBpTocGiAQYVhzHAD)) {
                case 1:
                    zRjlmATpQMoOwuzyW = rjlmATpQMoOwuzyW(parcel, iBpTocGiAQYVhzHAD);
                    break;
                case 2:
                    strVhIClHpiKZLYoPja = vhIClHpiKZLYoPja(parcel, iBpTocGiAQYVhzHAD);
                    break;
                case 3:
                    iWvvUXfotJovgRSdB = wvvUXfotJovgRSdB(parcel, iBpTocGiAQYVhzHAD);
                    break;
                case 4:
                    iCsqfyIFZxHOvIOaP = csqfyIFZxHOvIOaP(parcel, iBpTocGiAQYVhzHAD);
                    break;
                case 5:
                    jPNyLzlIrYmbTsNky = pNyLzlIrYmbTsNky(parcel, iBpTocGiAQYVhzHAD);
                    break;
                case 6:
                    zzuVar = (com.google.android.gms.common.zzu) RYXDoaSqrloigawD(parcel, iBpTocGiAQYVhzHAD, com.google.android.gms.common.zzu.CREATOR);
                    break;
                default:
                    TpYEXzYtjmVOHSdX(parcel, iBpTocGiAQYVhzHAD);
                    break;
            }
        }
        jaXeNreWzFeEQfkF(parcel, iHQQtoEtPHbbUgjzr);
        return new com.google.android.gms.common.zzu(zRjlmATpQMoOwuzyW, strVhIClHpiKZLYoPja, iWvvUXfotJovgRSdB, iCsqfyIFZxHOvIOaP, jPNyLzlIrYmbTsNky, zzuVar);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.zzu[i];
    }
}

