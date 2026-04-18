namespace WillowMaze.Wasm.Decompiled;


public readonly class zaw : android.os.Parcelable$Creator {
    public static int BjudnhKXXBnKnQmh(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int KlQHzVuYBSdVcgwN(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int OtailnRpSYDViOLV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int ExVWouuZPaDmxvDn(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static android.os.IBinder FstOaVrhtqoZFcQk(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readIBinder(parcel, i);
    }

    public static void IMGMadKUkgrRjLfH(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int PgJuawuVDMMcYBUZ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void TCNqQBkHvkeWEycL(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static bool TPLeKHyWgwBvfQSW(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static bool TnnBwUbkOETuMlwQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static android.os.Parcelable YkhNRKwnLccJdtRF(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((15 + 5) % 5 > 0) {
        }
        int iPgJuawuVDMMcYBUZ = pgJuawuVDMMcYBUZ(parcel);
        int iOtailnRpSYDViOLV = 0;
        bool zTPLeKHyWgwBvfQSW = false;
        bool zTnnBwUbkOETuMlwQ = false;
        android.os.IBinder iBinderFstOaVrhtqoZFcQk = null;
        com.google.android.gms.common.ConnectionResult connectionResult = null;
        while (exVWouuZPaDmxvDn(parcel) < iPgJuawuVDMMcYBUZ) {
            int iBjudnhKXXBnKnQmh = BjudnhKXXBnKnQmh(parcel);
            int iKlQHzVuYBSdVcgwN = KlQHzVuYBSdVcgwN(iBjudnhKXXBnKnQmh);
            if (iKlQHzVuYBSdVcgwN == 1) {
                iOtailnRpSYDViOLV = OtailnRpSYDViOLV(parcel, iBjudnhKXXBnKnQmh);
            } else if (iKlQHzVuYBSdVcgwN == 2) {
                iBinderFstOaVrhtqoZFcQk = fstOaVrhtqoZFcQk(parcel, iBjudnhKXXBnKnQmh);
            } else if (iKlQHzVuYBSdVcgwN == 3) {
                connectionResult = (com.google.android.gms.common.ConnectionResult) ykhNRKwnLccJdtRF(parcel, iBjudnhKXXBnKnQmh, com.google.android.gms.common.ConnectionResult.CREATOR);
            } else if (iKlQHzVuYBSdVcgwN == 4) {
                zTPLeKHyWgwBvfQSW = tPLeKHyWgwBvfQSW(parcel, iBjudnhKXXBnKnQmh);
            } else if (iKlQHzVuYBSdVcgwN == 5) {
                zTnnBwUbkOETuMlwQ = tnnBwUbkOETuMlwQ(parcel, iBjudnhKXXBnKnQmh);
            } else {
                iMGMadKUkgrRjLfH(parcel, iBjudnhKXXBnKnQmh);
            }
        }
        tCNqQBkHvkeWEycL(parcel, iPgJuawuVDMMcYBUZ);
        return new com.google.android.gms.common.internal.zav(iOtailnRpSYDViOLV, iBinderFstOaVrhtqoZFcQk, connectionResult, zTPLeKHyWgwBvfQSW, zTnnBwUbkOETuMlwQ);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.zav[i];
    }
}

