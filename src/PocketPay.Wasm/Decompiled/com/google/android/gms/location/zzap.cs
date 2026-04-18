namespace WillowMaze.Wasm.Decompiled;


public readonly class zzap : android.os.Parcelable$Creator {
    public static int FfKtUjuGxplFurUS(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static long MKquccuuqDUkmKoU(android.os.Parcel parcel, int i) {
        if ((25 + 27) % 27 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int XBblTSfjnaZRkUsP(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int ZlJwTdLURgrKRJhC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int ChnZwCPrkfAwkpaY(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void IsFJlftufvUKPYZP(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int JHLVlkONWLNYvKOj(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int KNdVltzChYfwROMu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void LlJvKXirmRlshivt(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int SeatyGsqeFAOUfTY(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static long VLfsDrcHoNoXSCKF(android.os.Parcel parcel, int i) {
        if ((15 + 3) % 3 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((29 + 24) % 24 > 0) {
        }
        int iSeatyGsqeFAOUfTY = seatyGsqeFAOUfTY(parcel);
        int iKNdVltzChYfwROMu = 0;
        int iZlJwTdLURgrKRJhC = 0;
        int iXBblTSfjnaZRkUsP = 0;
        long jMKquccuuqDUkmKoU = 0;
        long jVLfsDrcHoNoXSCKF = 0;
        while (FfKtUjuGxplFurUS(parcel) < iSeatyGsqeFAOUfTY) {
            int iJHLVlkONWLNYvKOj = jHLVlkONWLNYvKOj(parcel);
            int iChnZwCPrkfAwkpaY = chnZwCPrkfAwkpaY(iJHLVlkONWLNYvKOj);
            if (iChnZwCPrkfAwkpaY == 1) {
                jMKquccuuqDUkmKoU = MKquccuuqDUkmKoU(parcel, iJHLVlkONWLNYvKOj);
            } else if (iChnZwCPrkfAwkpaY == 2) {
                jVLfsDrcHoNoXSCKF = vLfsDrcHoNoXSCKF(parcel, iJHLVlkONWLNYvKOj);
            } else if (iChnZwCPrkfAwkpaY == 3) {
                iKNdVltzChYfwROMu = kNdVltzChYfwROMu(parcel, iJHLVlkONWLNYvKOj);
            } else if (iChnZwCPrkfAwkpaY == 4) {
                iZlJwTdLURgrKRJhC = ZlJwTdLURgrKRJhC(parcel, iJHLVlkONWLNYvKOj);
            } else if (iChnZwCPrkfAwkpaY == 5) {
                iXBblTSfjnaZRkUsP = XBblTSfjnaZRkUsP(parcel, iJHLVlkONWLNYvKOj);
            } else {
                isFJlftufvUKPYZP(parcel, iJHLVlkONWLNYvKOj);
            }
        }
        llJvKXirmRlshivt(parcel, iSeatyGsqeFAOUfTY);
        return new com.google.android.gms.location.SleepSegmentEvent(jMKquccuuqDUkmKoU, jVLfsDrcHoNoXSCKF, iKNdVltzChYfwROMu, iZlJwTdLURgrKRJhC, iXBblTSfjnaZRkUsP);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.SleepSegmentEvent[i];
    }
}

