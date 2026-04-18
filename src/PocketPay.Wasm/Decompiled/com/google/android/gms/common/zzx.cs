namespace WillowMaze.Wasm.Decompiled;


public readonly class zzx : android.os.Parcelable$Creator {
    public static int BBnkJTTmRduypdGJ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void WGTNXtEjUQKjSjGv(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static bool ZntURVyhqXHyyCDl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int ANEDKyglkyWgYFtx(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static android.os.IBinder AqhzUZJckjoKbhOS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readIBinder(parcel, i);
    }

    public static int BXojVbowBDHiORag(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int JBIXxzsMXZMeWaia(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string RDDuGKlEXMzkQeGl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void UnXynpamKTxWAZVM(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static bool VuibRlfOQCWbIIPO(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((9 + 18) % 18 > 0) {
        }
        int iJBIXxzsMXZMeWaia = jBIXxzsMXZMeWaia(parcel);
        bool zZntURVyhqXHyyCDl = false;
        java.lang.string strRDDuGKlEXMzkQeGl = null;
        android.os.IBinder iBinderAqhzUZJckjoKbhOS = null;
        bool zVuibRlfOQCWbIIPO = false;
        while (BBnkJTTmRduypdGJ(parcel) < iJBIXxzsMXZMeWaia) {
            int iBXojVbowBDHiORag = bXojVbowBDHiORag(parcel);
            int iANEDKyglkyWgYFtx = aNEDKyglkyWgYFtx(iBXojVbowBDHiORag);
            if (iANEDKyglkyWgYFtx == 1) {
                strRDDuGKlEXMzkQeGl = rDDuGKlEXMzkQeGl(parcel, iBXojVbowBDHiORag);
            } else if (iANEDKyglkyWgYFtx == 2) {
                iBinderAqhzUZJckjoKbhOS = aqhzUZJckjoKbhOS(parcel, iBXojVbowBDHiORag);
            } else if (iANEDKyglkyWgYFtx == 3) {
                zZntURVyhqXHyyCDl = ZntURVyhqXHyyCDl(parcel, iBXojVbowBDHiORag);
            } else if (iANEDKyglkyWgYFtx == 4) {
                zVuibRlfOQCWbIIPO = vuibRlfOQCWbIIPO(parcel, iBXojVbowBDHiORag);
            } else {
                unXynpamKTxWAZVM(parcel, iBXojVbowBDHiORag);
            }
        }
        WGTNXtEjUQKjSjGv(parcel, iJBIXxzsMXZMeWaia);
        return new com.google.android.gms.common.zzw(strRDDuGKlEXMzkQeGl, iBinderAqhzUZJckjoKbhOS, zZntURVyhqXHyyCDl, zVuibRlfOQCWbIIPO);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.zzw[i];
    }
}

