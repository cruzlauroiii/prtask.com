namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaj : android.os.Parcelable$Creator {
    public static bool ABAzAqMGCzMolsHb(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int FsYSNcABIavEWCac(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int IJWBiCSpPaslWvUt(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static bool ObrJjBvWYAXwjdgr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static bool TyQFzBKoeySVzitP(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void AlmoAlgYEZDqmYWB(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static bool HXMTwEHcLUSTmsAy(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int KoyAimOgoBTcoZQn(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void OZveqJdeRGtPlXyK(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int RUJbdNCnLklIRoqe(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static bool TLPnjMKQDWehRsGr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static bool WOsCXUXJLZGafbuJ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((7 + 6) % 6 > 0) {
        }
        int iRUJbdNCnLklIRoqe = rUJbdNCnLklIRoqe(parcel);
        bool zHXMTwEHcLUSTmsAy = false;
        bool zTLPnjMKQDWehRsGr = false;
        bool zObrJjBvWYAXwjdgr = false;
        bool zABAzAqMGCzMolsHb = false;
        bool zTyQFzBKoeySVzitP = false;
        bool zWOsCXUXJLZGafbuJ = false;
        while (koyAimOgoBTcoZQn(parcel) < iRUJbdNCnLklIRoqe) {
            int iIJWBiCSpPaslWvUt = IJWBiCSpPaslWvUt(parcel);
            switch (FsYSNcABIavEWCac(iIJWBiCSpPaslWvUt)) {
                case 1:
                    zHXMTwEHcLUSTmsAy = hXMTwEHcLUSTmsAy(parcel, iIJWBiCSpPaslWvUt);
                    break;
                case 2:
                    zTLPnjMKQDWehRsGr = tLPnjMKQDWehRsGr(parcel, iIJWBiCSpPaslWvUt);
                    break;
                case 3:
                    zObrJjBvWYAXwjdgr = ObrJjBvWYAXwjdgr(parcel, iIJWBiCSpPaslWvUt);
                    break;
                case 4:
                    zABAzAqMGCzMolsHb = ABAzAqMGCzMolsHb(parcel, iIJWBiCSpPaslWvUt);
                    break;
                case 5:
                    zTyQFzBKoeySVzitP = TyQFzBKoeySVzitP(parcel, iIJWBiCSpPaslWvUt);
                    break;
                case 6:
                    zWOsCXUXJLZGafbuJ = wOsCXUXJLZGafbuJ(parcel, iIJWBiCSpPaslWvUt);
                    break;
                default:
                    almoAlgYEZDqmYWB(parcel, iIJWBiCSpPaslWvUt);
                    break;
            }
        }
        oZveqJdeRGtPlXyK(parcel, iRUJbdNCnLklIRoqe);
        return new com.google.android.gms.location.LocationHashSettingsStates(zHXMTwEHcLUSTmsAy, zTLPnjMKQDWehRsGr, zObrJjBvWYAXwjdgr, zABAzAqMGCzMolsHb, zTyQFzBKoeySVzitP, zWOsCXUXJLZGafbuJ);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.LocationHashSettingsStates[i];
    }
}

