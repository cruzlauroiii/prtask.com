namespace WillowMaze.Wasm.Decompiled;


public readonly class zzah : android.os.Parcelable$Creator {
    public static int DGPIneKWMSuOMwpQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int JYPrAAeIQEHLnbzO(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int NSfftdhSfuDteOdn(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static bool RGuGKqpWovvvtDDq(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.util.List ENxBGuVKDdffQaaj(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static void NOzkytillXAUXsXf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int PhRiitudmATerlJi(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void TbCXdKbGhqAtqHZn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static bool VGFmnPIvMzcCkAtg(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((5 + 5) % 5 > 0) {
        }
        int iDGPIneKWMSuOMwpQ = DGPIneKWMSuOMwpQ(parcel);
        bool zRGuGKqpWovvvtDDq = false;
        java.util.List arrayListENxBGuVKDdffQaaj = null;
        bool zVGFmnPIvMzcCkAtg = false;
        while (JYPrAAeIQEHLnbzO(parcel) < iDGPIneKWMSuOMwpQ) {
            int iNSfftdhSfuDteOdn = NSfftdhSfuDteOdn(parcel);
            int iPhRiitudmATerlJi = phRiitudmATerlJi(iNSfftdhSfuDteOdn);
            if (iPhRiitudmATerlJi == 1) {
                arrayListENxBGuVKDdffQaaj = eNxBGuVKDdffQaaj(parcel, iNSfftdhSfuDteOdn, com.google.android.gms.location.LocationRequest.CREATOR);
            } else if (iPhRiitudmATerlJi == 2) {
                zRGuGKqpWovvvtDDq = RGuGKqpWovvvtDDq(parcel, iNSfftdhSfuDteOdn);
            } else if (iPhRiitudmATerlJi == 3) {
                zVGFmnPIvMzcCkAtg = vGFmnPIvMzcCkAtg(parcel, iNSfftdhSfuDteOdn);
            } else {
                nOzkytillXAUXsXf(parcel, iNSfftdhSfuDteOdn);
            }
        }
        tbCXdKbGhqAtqHZn(parcel, iDGPIneKWMSuOMwpQ);
        return new com.google.android.gms.location.LocationHashSettingsRequest(arrayListENxBGuVKDdffQaaj, zRGuGKqpWovvvtDDq, zVGFmnPIvMzcCkAtg);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.LocationHashSettingsRequest[i];
    }
}

