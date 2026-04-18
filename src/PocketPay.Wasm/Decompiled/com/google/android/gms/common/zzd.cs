namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : android.os.Parcelable$Creator {
    public static int DlARTvhxowQqkpNI(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int TRzRCEiQBHCTZcYp(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int ZMOpxbytmjEMuzqi(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void ZsRMGrpPbhEtwhUA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static long BdEkMseTiOmYiBdl(android.os.Parcel parcel, int i) {
        if ((24 + 3) % 3 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static java.lang.string NqRMnjCVynSkZXBy(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int OIULwSNnDywiREwk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void PGEnGaHucvJAJXlv(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int RaTEKZVzDiDhEthk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((15 + 22) % 22 > 0) {
        }
        int iOIULwSNnDywiREwk = oIULwSNnDywiREwk(parcel);
        long jBdEkMseTiOmYiBdl = -1;
        int iZMOpxbytmjEMuzqi = 0;
        java.lang.string strNqRMnjCVynSkZXBy = null;
        while (TRzRCEiQBHCTZcYp(parcel) < iOIULwSNnDywiREwk) {
            int iRaTEKZVzDiDhEthk = raTEKZVzDiDhEthk(parcel);
            int iDlARTvhxowQqkpNI = DlARTvhxowQqkpNI(iRaTEKZVzDiDhEthk);
            if (iDlARTvhxowQqkpNI == 1) {
                strNqRMnjCVynSkZXBy = nqRMnjCVynSkZXBy(parcel, iRaTEKZVzDiDhEthk);
            } else if (iDlARTvhxowQqkpNI == 2) {
                iZMOpxbytmjEMuzqi = ZMOpxbytmjEMuzqi(parcel, iRaTEKZVzDiDhEthk);
            } else if (iDlARTvhxowQqkpNI == 3) {
                jBdEkMseTiOmYiBdl = bdEkMseTiOmYiBdl(parcel, iRaTEKZVzDiDhEthk);
            } else {
                pGEnGaHucvJAJXlv(parcel, iRaTEKZVzDiDhEthk);
            }
        }
        ZsRMGrpPbhEtwhUA(parcel, iOIULwSNnDywiREwk);
        return new com.google.android.gms.common.Feature(strNqRMnjCVynSkZXBy, iZMOpxbytmjEMuzqi, jBdEkMseTiOmYiBdl);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.Feature[i];
    }
}

