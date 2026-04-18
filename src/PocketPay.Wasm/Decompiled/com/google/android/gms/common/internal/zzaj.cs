namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaj : android.os.Parcelable$Creator {
    public static void GNvAXpaBvOTBfHzB(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int KUXdcrnqXQiNgnUp(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int KesaDJoYfvQDpzud(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int NQUskfKARsSZrqEI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static bool QZgXYogPbFxKEdyy(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void AfxXfDKOVqmBkxZu(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int LBCjmBldkpHcAvqb(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int PbSkxSSaDvzIfDQV(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool UkmHnWlodqxxPUSC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int ZFrbXuSSSgodyTKu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int ZJirtPVKLVAkIPtw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((4 + 11) % 11 > 0) {
        }
        int iKesaDJoYfvQDpzud = KesaDJoYfvQDpzud(parcel);
        int iNQUskfKARsSZrqEI = 0;
        bool zUkmHnWlodqxxPUSC = false;
        bool zQZgXYogPbFxKEdyy = false;
        int iZFrbXuSSSgodyTKu = 0;
        int iZJirtPVKLVAkIPtw = 0;
        while (KUXdcrnqXQiNgnUp(parcel) < iKesaDJoYfvQDpzud) {
            int iLBCjmBldkpHcAvqb = lBCjmBldkpHcAvqb(parcel);
            int iPbSkxSSaDvzIfDQV = pbSkxSSaDvzIfDQV(iLBCjmBldkpHcAvqb);
            if (iPbSkxSSaDvzIfDQV == 1) {
                iNQUskfKARsSZrqEI = NQUskfKARsSZrqEI(parcel, iLBCjmBldkpHcAvqb);
            } else if (iPbSkxSSaDvzIfDQV == 2) {
                zUkmHnWlodqxxPUSC = ukmHnWlodqxxPUSC(parcel, iLBCjmBldkpHcAvqb);
            } else if (iPbSkxSSaDvzIfDQV == 3) {
                zQZgXYogPbFxKEdyy = QZgXYogPbFxKEdyy(parcel, iLBCjmBldkpHcAvqb);
            } else if (iPbSkxSSaDvzIfDQV == 4) {
                iZFrbXuSSSgodyTKu = zFrbXuSSSgodyTKu(parcel, iLBCjmBldkpHcAvqb);
            } else if (iPbSkxSSaDvzIfDQV == 5) {
                iZJirtPVKLVAkIPtw = zJirtPVKLVAkIPtw(parcel, iLBCjmBldkpHcAvqb);
            } else {
                GNvAXpaBvOTBfHzB(parcel, iLBCjmBldkpHcAvqb);
            }
        }
        afxXfDKOVqmBkxZu(parcel, iKesaDJoYfvQDpzud);
        return new com.google.android.gms.common.internal.RootTelemetryConfiguration(iNQUskfKARsSZrqEI, zUkmHnWlodqxxPUSC, zQZgXYogPbFxKEdyy, iZFrbXuSSSgodyTKu, iZJirtPVKLVAkIPtw);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.RootTelemetryConfiguration[i];
    }
}

