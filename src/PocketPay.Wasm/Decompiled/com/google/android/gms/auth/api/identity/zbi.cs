namespace WillowMaze.Wasm.Decompiled;


public readonly class zbi : android.os.Parcelable$Creator {
    public static int ApmkYqafyPpkHBrO(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int BUCaMjfqjTXbpcqO(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string CHPXTZVwGazpJLNZ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int DEgHIEhBtNJyTQmw(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void DULXipZWrtdmXRVR(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void IXcoNWmbOmHUvweY(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string UKcDuzzjTuZagEGc(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int WSClmKgaBKpsqVRu(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static bool HgoMNyTqUYEjYCfI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.lang.string JXPlyvDhkbReYogx(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string UfhBOkItGsetmDvA(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int WeidKcPhBRwHaPQV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 3) % 3 > 0) {
        }
        int iApmkYqafyPpkHBrO = ApmkYqafyPpkHBrO(parcel);
        bool zHgoMNyTqUYEjYCfI = false;
        int iWeidKcPhBRwHaPQV = 0;
        java.lang.string strJXPlyvDhkbReYogx = null;
        java.lang.string strUKcDuzzjTuZagEGc = null;
        java.lang.string strCHPXTZVwGazpJLNZ = null;
        java.lang.string strUfhBOkItGsetmDvA = null;
        while (BUCaMjfqjTXbpcqO(parcel) < iApmkYqafyPpkHBrO) {
            int iWSClmKgaBKpsqVRu = WSClmKgaBKpsqVRu(parcel);
            switch (DEgHIEhBtNJyTQmw(iWSClmKgaBKpsqVRu)) {
                case 1:
                    strJXPlyvDhkbReYogx = jXPlyvDhkbReYogx(parcel, iWSClmKgaBKpsqVRu);
                    break;
                case 2:
                    strUKcDuzzjTuZagEGc = UKcDuzzjTuZagEGc(parcel, iWSClmKgaBKpsqVRu);
                    break;
                case 3:
                    strCHPXTZVwGazpJLNZ = CHPXTZVwGazpJLNZ(parcel, iWSClmKgaBKpsqVRu);
                    break;
                case 4:
                    strUfhBOkItGsetmDvA = ufhBOkItGsetmDvA(parcel, iWSClmKgaBKpsqVRu);
                    break;
                case 5:
                    zHgoMNyTqUYEjYCfI = hgoMNyTqUYEjYCfI(parcel, iWSClmKgaBKpsqVRu);
                    break;
                case 6:
                    iWeidKcPhBRwHaPQV = weidKcPhBRwHaPQV(parcel, iWSClmKgaBKpsqVRu);
                    break;
                default:
                    DULXipZWrtdmXRVR(parcel, iWSClmKgaBKpsqVRu);
                    break;
            }
        }
        IXcoNWmbOmHUvweY(parcel, iApmkYqafyPpkHBrO);
        return new com.google.android.gms.auth.api.identity.GetSignInobjectRequest(strJXPlyvDhkbReYogx, strUKcDuzzjTuZagEGc, strCHPXTZVwGazpJLNZ, strUfhBOkItGsetmDvA, zHgoMNyTqUYEjYCfI, iWeidKcPhBRwHaPQV);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.GetSignInobjectRequest[i];
    }
}

