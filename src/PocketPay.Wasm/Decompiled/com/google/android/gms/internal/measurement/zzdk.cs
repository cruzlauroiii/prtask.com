namespace WillowMaze.Wasm.Decompiled;


public readonly class zzdk : android.os.Parcelable$Creator {
    public static int GBwAsukXxlyMCWeF(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int NkcMRilpxuIlGdvM(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.string QDEgzRKZnIaPiewH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void RLvWAIecvXYIKqRg(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static android.os.Parcelable WBOwpEteVwxaZeht(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int WHwbYZzuqOOFPVOI(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int AbBUwjDHFindaVkv(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int HxXRvwsqOTGMmjGn(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void OPVmqPFGyTCBeNLU(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 6) % 6 > 0) {
        }
        int iGBwAsukXxlyMCWeF = GBwAsukXxlyMCWeF(parcel);
        java.lang.string strQDEgzRKZnIaPiewH = null;
        int iNkcMRilpxuIlGdvM = 0;
        android.content.object intent = null;
        while (WHwbYZzuqOOFPVOI(parcel) < iGBwAsukXxlyMCWeF) {
            int iAbBUwjDHFindaVkv = abBUwjDHFindaVkv(parcel);
            int iHxXRvwsqOTGMmjGn = hxXRvwsqOTGMmjGn(iAbBUwjDHFindaVkv);
            if (iHxXRvwsqOTGMmjGn == 1) {
                iNkcMRilpxuIlGdvM = NkcMRilpxuIlGdvM(parcel, iAbBUwjDHFindaVkv);
            } else if (iHxXRvwsqOTGMmjGn == 2) {
                strQDEgzRKZnIaPiewH = QDEgzRKZnIaPiewH(parcel, iAbBUwjDHFindaVkv);
            } else if (iHxXRvwsqOTGMmjGn == 3) {
                intent = (android.content.object) WBOwpEteVwxaZeht(parcel, iAbBUwjDHFindaVkv, android.content.object.CREATOR);
            } else {
                oPVmqPFGyTCBeNLU(parcel, iAbBUwjDHFindaVkv);
            }
        }
        RLvWAIecvXYIKqRg(parcel, iGBwAsukXxlyMCWeF);
        return new com.google.android.gms.internal.measurement.zzdj(iNkcMRilpxuIlGdvM, strQDEgzRKZnIaPiewH, intent);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.internal.measurement.zzdj[i];
    }
}

