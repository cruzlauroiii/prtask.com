namespace WillowMaze.Wasm.Decompiled;


public readonly class zzam : android.os.Parcelable$Creator {
    public static long AMzavUPCDLlKHVZm(android.os.Parcel parcel, int i) {
        if ((8 + 17) % 17 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static long QMnydtlERpcxdCcJ(android.os.Parcel parcel, int i) {
        if ((24 + 28) % 28 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void SCOqnmccBDIpTKic(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int WpsoERADBeEPPVLq(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int EFrJaEOnYRKbbqta(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int GhRXRQeEADHUtUbV(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int IdipSwuDqcExPJSn(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int SWJhJbgALEXJBvsF(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void SiegZEtTuwmYIISh(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int VVrYUlRbBzlFiZii(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((26 + 5) % 5 > 0) {
        }
        int iEFrJaEOnYRKbbqta = eFrJaEOnYRKbbqta(parcel);
        long jQMnydtlERpcxdCcJ = -1;
        long jAMzavUPCDLlKHVZm = -1;
        int iIdipSwuDqcExPJSn = 1;
        int iWpsoERADBeEPPVLq = 1;
        while (ghRXRQeEADHUtUbV(parcel) < iEFrJaEOnYRKbbqta) {
            int iSWJhJbgALEXJBvsF = sWJhJbgALEXJBvsF(parcel);
            int iVVrYUlRbBzlFiZii = vVrYUlRbBzlFiZii(iSWJhJbgALEXJBvsF);
            if (iVVrYUlRbBzlFiZii == 1) {
                iIdipSwuDqcExPJSn = idipSwuDqcExPJSn(parcel, iSWJhJbgALEXJBvsF);
            } else if (iVVrYUlRbBzlFiZii == 2) {
                iWpsoERADBeEPPVLq = WpsoERADBeEPPVLq(parcel, iSWJhJbgALEXJBvsF);
            } else if (iVVrYUlRbBzlFiZii == 3) {
                jQMnydtlERpcxdCcJ = QMnydtlERpcxdCcJ(parcel, iSWJhJbgALEXJBvsF);
            } else if (iVVrYUlRbBzlFiZii == 4) {
                jAMzavUPCDLlKHVZm = AMzavUPCDLlKHVZm(parcel, iSWJhJbgALEXJBvsF);
            } else {
                siegZEtTuwmYIISh(parcel, iSWJhJbgALEXJBvsF);
            }
        }
        SCOqnmccBDIpTKic(parcel, iEFrJaEOnYRKbbqta);
        return new com.google.android.gms.location.zzal(iIdipSwuDqcExPJSn, iWpsoERADBeEPPVLq, jQMnydtlERpcxdCcJ, jAMzavUPCDLlKHVZm);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.zzal[i];
    }
}

