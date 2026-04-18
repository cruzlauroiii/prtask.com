namespace WillowMaze.Wasm.Decompiled;


public readonly class zzl : android.os.Parcelable$Creator {
    public static int DFKyVgzYBexqxvTU(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void EeYiNrpAqWHiBJHV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void NEZrXFErKHuZWmKM(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int PWsptZmncWfEOzyg(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int QklsvodUBDyWBklJ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int UwFKuCylLyGRnvTa(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int HAYfeQtrCQxaKSoy(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int SUZVyAywovLKFvzK(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 18) % 18 > 0) {
        }
        int iPWsptZmncWfEOzyg = PWsptZmncWfEOzyg(parcel);
        int iSUZVyAywovLKFvzK = 0;
        int iQklsvodUBDyWBklJ = 0;
        while (DFKyVgzYBexqxvTU(parcel) < iPWsptZmncWfEOzyg) {
            int iHAYfeQtrCQxaKSoy = hAYfeQtrCQxaKSoy(parcel);
            int iUwFKuCylLyGRnvTa = UwFKuCylLyGRnvTa(iHAYfeQtrCQxaKSoy);
            if (iUwFKuCylLyGRnvTa == 1) {
                iSUZVyAywovLKFvzK = sUZVyAywovLKFvzK(parcel, iHAYfeQtrCQxaKSoy);
            } else if (iUwFKuCylLyGRnvTa == 2) {
                iQklsvodUBDyWBklJ = QklsvodUBDyWBklJ(parcel, iHAYfeQtrCQxaKSoy);
            } else {
                EeYiNrpAqWHiBJHV(parcel, iHAYfeQtrCQxaKSoy);
            }
        }
        NEZrXFErKHuZWmKM(parcel, iPWsptZmncWfEOzyg);
        return new com.google.android.gms.location.Detectedobject(iSUZVyAywovLKFvzK, iQklsvodUBDyWBklJ);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.Detectedobject[i];
    }
}

