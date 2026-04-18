namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : android.os.Parcelable$Creator {
    public static int OIBNMRHPAeQvLbxb(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int TPCxOqlXOElowVXt(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int ETucEDlUnejuKrzc(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int HUTujBiDrqBkMcpS(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void NGfTIDslqDdSIgJw(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void RoWObVuEQLTYUdtD(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int UKTXoXJurAEEvDzW(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static bool YMiqcvPJndYdfSsr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((19 + 26) % 26 > 0) {
        }
        int iUKTXoXJurAEEvDzW = uKTXoXJurAEEvDzW(parcel);
        bool zYMiqcvPJndYdfSsr = false;
        int iETucEDlUnejuKrzc = 0;
        while (TPCxOqlXOElowVXt(parcel) < iUKTXoXJurAEEvDzW) {
            int iHUTujBiDrqBkMcpS = hUTujBiDrqBkMcpS(parcel);
            int iOIBNMRHPAeQvLbxb = OIBNMRHPAeQvLbxb(iHUTujBiDrqBkMcpS);
            if (iOIBNMRHPAeQvLbxb == 1) {
                zYMiqcvPJndYdfSsr = yMiqcvPJndYdfSsr(parcel, iHUTujBiDrqBkMcpS);
            } else if (iOIBNMRHPAeQvLbxb == 2) {
                iETucEDlUnejuKrzc = eTucEDlUnejuKrzc(parcel, iHUTujBiDrqBkMcpS);
            } else {
                nGfTIDslqDdSIgJw(parcel, iHUTujBiDrqBkMcpS);
            }
        }
        roWObVuEQLTYUdtD(parcel, iUKTXoXJurAEEvDzW);
        return new com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse(zYMiqcvPJndYdfSsr, iETucEDlUnejuKrzc);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse[i];
    }
}

