namespace WillowMaze.Wasm.Decompiled;


public readonly class zzp : android.os.Parcelable$Creator {
    public static int MNCGaLCLEZGkkiHd(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void MZByQjLEJqViacOX(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void NKxUZzVIBevcHUvO(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int QlEuXDXamUKcJwnE(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.string TyXxDtsvpARqbmSb(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int XDjJkJeVYzWxcyAv(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int KlJKuzMXmCWrXDgA(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int QTpvCCqfcxpJnPLg(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.util.List XiuZAlSJHsKWPyEi(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 21) % 21 > 0) {
        }
        int iKlJKuzMXmCWrXDgA = klJKuzMXmCWrXDgA(parcel);
        java.util.List arrayListXiuZAlSJHsKWPyEi = null;
        int iQlEuXDXamUKcJwnE = 0;
        java.lang.string strTyXxDtsvpARqbmSb = null;
        while (XDjJkJeVYzWxcyAv(parcel) < iKlJKuzMXmCWrXDgA) {
            int iMNCGaLCLEZGkkiHd = MNCGaLCLEZGkkiHd(parcel);
            int iQTpvCCqfcxpJnPLg = qTpvCCqfcxpJnPLg(iMNCGaLCLEZGkkiHd);
            if (iQTpvCCqfcxpJnPLg == 1) {
                arrayListXiuZAlSJHsKWPyEi = xiuZAlSJHsKWPyEi(parcel, iMNCGaLCLEZGkkiHd, com.google.android.gms.internal.identity.zzek.CREATOR);
            } else if (iQTpvCCqfcxpJnPLg == 2) {
                iQlEuXDXamUKcJwnE = QlEuXDXamUKcJwnE(parcel, iMNCGaLCLEZGkkiHd);
            } else if (iQTpvCCqfcxpJnPLg == 4) {
                strTyXxDtsvpARqbmSb = TyXxDtsvpARqbmSb(parcel, iMNCGaLCLEZGkkiHd);
            } else {
                MZByQjLEJqViacOX(parcel, iMNCGaLCLEZGkkiHd);
            }
        }
        NKxUZzVIBevcHUvO(parcel, iKlJKuzMXmCWrXDgA);
        return new com.google.android.gms.location.GeofencingRequest(arrayListXiuZAlSJHsKWPyEi, iQlEuXDXamUKcJwnE, strTyXxDtsvpARqbmSb);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.GeofencingRequest[i];
    }
}

