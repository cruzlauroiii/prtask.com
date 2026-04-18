namespace WillowMaze.Wasm.Decompiled;


public readonly class zzbi : android.os.Parcelable$Creator {
    public static int BLquaDlvdUHhlILw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void CIUjmLFwMyACaRsf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void DAfdUMmzZeALJDTk(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static android.os.Parcelable IXAYGMDgoHUBUrwn(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.lang.string IgbNHizTFOiXDtGs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void IrVRfAiPXhnrXWOy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void JOFBwOxJDavHbISa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int QMmNxKViwEamXUcI(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int RNKqSzwFcAKorMaw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static long TdGKmkBaxLNERLAO(android.os.Parcel parcel, int i) {
        if ((6 + 22) % 22 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void AHxSzKWzIYfmQESr(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void AvdjyuSOYhwbYTUV(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int CzwhioGGNKgNnrza(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void SiKGJCQKzcVcaBog(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int YUdxzaSJemyXDaYi(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string ZsEFWaZAngkgbmxv(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    static void Zza(com.google.android.gms.measurement.internal.zzbh zzbhVar, android.os.Parcel parcel, int i) {
        if ((2 + 9) % 9 > 0) {
        }
        java.lang.string str = zzbhVar.zza;
        int iQMmNxKViwEamXUcI = QMmNxKViwEamXUcI(parcel);
        avdjyuSOYhwbYTUV(parcel, 2, str, false);
        aHxSzKWzIYfmQESr(parcel, 3, zzbhVar.zzb, i, false);
        siKGJCQKzcVcaBog(parcel, 4, zzbhVar.zzc, false);
        DAfdUMmzZeALJDTk(parcel, 5, zzbhVar.zzd);
        CIUjmLFwMyACaRsf(parcel, iQMmNxKViwEamXUcI);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((11 + 26) % 26 > 0) {
        }
        int iRNKqSzwFcAKorMaw = RNKqSzwFcAKorMaw(parcel);
        long jTdGKmkBaxLNERLAO = 0;
        java.lang.string strIgbNHizTFOiXDtGs = null;
        com.google.android.gms.measurement.internal.zzbf zzbfVar = null;
        java.lang.string strZsEFWaZAngkgbmxv = null;
        while (yUdxzaSJemyXDaYi(parcel) < iRNKqSzwFcAKorMaw) {
            int iBLquaDlvdUHhlILw = BLquaDlvdUHhlILw(parcel);
            int iCzwhioGGNKgNnrza = czwhioGGNKgNnrza(iBLquaDlvdUHhlILw);
            if (iCzwhioGGNKgNnrza == 2) {
                strIgbNHizTFOiXDtGs = IgbNHizTFOiXDtGs(parcel, iBLquaDlvdUHhlILw);
            } else if (iCzwhioGGNKgNnrza == 3) {
                zzbfVar = (com.google.android.gms.measurement.internal.zzbf) IXAYGMDgoHUBUrwn(parcel, iBLquaDlvdUHhlILw, com.google.android.gms.measurement.internal.zzbf.CREATOR);
            } else if (iCzwhioGGNKgNnrza == 4) {
                strZsEFWaZAngkgbmxv = zsEFWaZAngkgbmxv(parcel, iBLquaDlvdUHhlILw);
            } else if (iCzwhioGGNKgNnrza == 5) {
                jTdGKmkBaxLNERLAO = TdGKmkBaxLNERLAO(parcel, iBLquaDlvdUHhlILw);
            } else {
                JOFBwOxJDavHbISa(parcel, iBLquaDlvdUHhlILw);
            }
        }
        IrVRfAiPXhnrXWOy(parcel, iRNKqSzwFcAKorMaw);
        return new com.google.android.gms.measurement.internal.zzbh(strIgbNHizTFOiXDtGs, zzbfVar, strZsEFWaZAngkgbmxv, jTdGKmkBaxLNERLAO);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzbh[i];
    }
}

