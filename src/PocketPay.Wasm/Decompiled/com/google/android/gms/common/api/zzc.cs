namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : android.os.Parcelable$Creator {
    public static int DPunAVEpcJQxsDrr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int JmXtTVHrcjbypaXH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void MNDZbdkqMXpDUTTb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int TYxDvkGaiOCHUobB(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int HjvDmpaFkCMbdcQs(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int KfrOTATVkkajfahl(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void LeOEabJorxLwYrLz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static bool OHAyYpUldjsPChFS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int QuYekLrlQqNMJjkg(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int XGwIOjvemhGGveSq(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((2 + 24) % 24 > 0) {
        }
        int iQuYekLrlQqNMJjkg = quYekLrlQqNMJjkg(parcel);
        int iDPunAVEpcJQxsDrr = 0;
        bool zOHAyYpUldjsPChFS = true;
        int iXGwIOjvemhGGveSq = 0;
        int iJmXtTVHrcjbypaXH = 0;
        while (kfrOTATVkkajfahl(parcel) < iQuYekLrlQqNMJjkg) {
            int iHjvDmpaFkCMbdcQs = hjvDmpaFkCMbdcQs(parcel);
            int iTYxDvkGaiOCHUobB = TYxDvkGaiOCHUobB(iHjvDmpaFkCMbdcQs);
            if (iTYxDvkGaiOCHUobB == 1) {
                iDPunAVEpcJQxsDrr = DPunAVEpcJQxsDrr(parcel, iHjvDmpaFkCMbdcQs);
            } else if (iTYxDvkGaiOCHUobB == 2) {
                iXGwIOjvemhGGveSq = xGwIOjvemhGGveSq(parcel, iHjvDmpaFkCMbdcQs);
            } else if (iTYxDvkGaiOCHUobB == 3) {
                iJmXtTVHrcjbypaXH = JmXtTVHrcjbypaXH(parcel, iHjvDmpaFkCMbdcQs);
            } else if (iTYxDvkGaiOCHUobB == 4) {
                zOHAyYpUldjsPChFS = oHAyYpUldjsPChFS(parcel, iHjvDmpaFkCMbdcQs);
            } else {
                MNDZbdkqMXpDUTTb(parcel, iHjvDmpaFkCMbdcQs);
            }
        }
        leOEabJorxLwYrLz(parcel, iQuYekLrlQqNMJjkg);
        return new com.google.android.gms.common.api.ComplianceOptions(iDPunAVEpcJQxsDrr, iXGwIOjvemhGGveSq, iJmXtTVHrcjbypaXH, zOHAyYpUldjsPChFS);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.api.ComplianceOptions[i];
    }
}

