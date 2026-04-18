namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : android.os.Parcelable$Creator {
    public static int ECrfhCyuyEHEjEYK(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int QvRClMAcVaZkNNfu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int VOMEfzAWFWwoZSUm(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void CjonzzGbZRQbrmTr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int MLHvTMgSrwTGzaHB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void TWGfxEIpwABkfHAr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int XhncAQnOMglOEuVy(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.util.List YIruwKTqDOsGhUrK(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 15) % 15 > 0) {
        }
        int iECrfhCyuyEHEjEYK = ECrfhCyuyEHEjEYK(parcel);
        java.util.List arrayListYIruwKTqDOsGhUrK = null;
        int iQvRClMAcVaZkNNfu = 0;
        while (xhncAQnOMglOEuVy(parcel) < iECrfhCyuyEHEjEYK) {
            int iMLHvTMgSrwTGzaHB = mLHvTMgSrwTGzaHB(parcel);
            int iVOMEfzAWFWwoZSUm = VOMEfzAWFWwoZSUm(iMLHvTMgSrwTGzaHB);
            if (iVOMEfzAWFWwoZSUm == 1) {
                iQvRClMAcVaZkNNfu = QvRClMAcVaZkNNfu(parcel, iMLHvTMgSrwTGzaHB);
            } else if (iVOMEfzAWFWwoZSUm == 2) {
                arrayListYIruwKTqDOsGhUrK = yIruwKTqDOsGhUrK(parcel, iMLHvTMgSrwTGzaHB, com.google.android.gms.auth.AccountChangeEvent.CREATOR);
            } else {
                tWGfxEIpwABkfHAr(parcel, iMLHvTMgSrwTGzaHB);
            }
        }
        cjonzzGbZRQbrmTr(parcel, iECrfhCyuyEHEjEYK);
        return new com.google.android.gms.auth.AccountChangeEventsResponse(iQvRClMAcVaZkNNfu, arrayListYIruwKTqDOsGhUrK);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.AccountChangeEventsResponse[i];
    }
}

