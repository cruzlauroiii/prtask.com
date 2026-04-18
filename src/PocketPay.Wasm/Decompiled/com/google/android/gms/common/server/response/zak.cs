namespace WillowMaze.Wasm.Decompiled;


public readonly class zak : android.os.Parcelable$Creator {
    public static java.lang.string ACtveVwjLoPcFobU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void DEwjfdBNcahrCJDA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void GrvuHqosRHzFBFiJ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int JtsYkOVHwfadfRHY(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int YdtNwqnGkHpyZCVL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int CfWoJIUslYUiQiRV(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int CwelPzrQuRIbGMAd(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static android.os.Parcelable FLNejGMKwqNmBFph(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int XbueCLcjHMZUIlWg(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((23 + 9) % 9 > 0) {
        }
        int iJtsYkOVHwfadfRHY = JtsYkOVHwfadfRHY(parcel);
        java.lang.string strACtveVwjLoPcFobU = null;
        int iYdtNwqnGkHpyZCVL = 0;
        com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field = null;
        while (cwelPzrQuRIbGMAd(parcel) < iJtsYkOVHwfadfRHY) {
            int iXbueCLcjHMZUIlWg = xbueCLcjHMZUIlWg(parcel);
            int iCfWoJIUslYUiQiRV = cfWoJIUslYUiQiRV(iXbueCLcjHMZUIlWg);
            if (iCfWoJIUslYUiQiRV == 1) {
                iYdtNwqnGkHpyZCVL = YdtNwqnGkHpyZCVL(parcel, iXbueCLcjHMZUIlWg);
            } else if (iCfWoJIUslYUiQiRV == 2) {
                strACtveVwjLoPcFobU = ACtveVwjLoPcFobU(parcel, iXbueCLcjHMZUIlWg);
            } else if (iCfWoJIUslYUiQiRV == 3) {
                fastJsonResponse$Field = (com.google.android.gms.common.server.response.FastJsonResponse$Field) fLNejGMKwqNmBFph(parcel, iXbueCLcjHMZUIlWg, com.google.android.gms.common.server.response.FastJsonResponse$Field.CREATOR);
            } else {
                DEwjfdBNcahrCJDA(parcel, iXbueCLcjHMZUIlWg);
            }
        }
        GrvuHqosRHzFBFiJ(parcel, iJtsYkOVHwfadfRHY);
        return new com.google.android.gms.common.server.response.zam(iYdtNwqnGkHpyZCVL, strACtveVwjLoPcFobU, fastJsonResponse$Field);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.response.zam[i];
    }
}

