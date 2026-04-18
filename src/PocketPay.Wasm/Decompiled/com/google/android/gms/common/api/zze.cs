namespace WillowMaze.Wasm.Decompiled;


public readonly class zze : android.os.Parcelable$Creator {
    public static int DRJcQHyeplxhDneH(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int GwCOsABmmbfhmKoX(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int NVLYanOjfsPCCKwX(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static android.os.Parcelable WxHFzPlKorhFOplm(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void ZNGYVNJJjmJLNIbo(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void KzJRVISFZhejIvrV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int MQkYXsspncfQeNHd(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static android.os.Parcelable MhIewZAvIrfmlHXx(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int RwlOKeHEdAhosSuG(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string VSvBvJNWPUgwxVEL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((28 + 6) % 6 > 0) {
        }
        int iRwlOKeHEdAhosSuG = rwlOKeHEdAhosSuG(parcel);
        java.lang.string strVSvBvJNWPUgwxVEL = null;
        com.google.android.gms.common.ConnectionResult connectionResult = null;
        int iGwCOsABmmbfhmKoX = 0;
        android.app.Pendingobject pendingobject = null;
        while (mQkYXsspncfQeNHd(parcel) < iRwlOKeHEdAhosSuG) {
            int iNVLYanOjfsPCCKwX = NVLYanOjfsPCCKwX(parcel);
            int iDRJcQHyeplxhDneH = DRJcQHyeplxhDneH(iNVLYanOjfsPCCKwX);
            if (iDRJcQHyeplxhDneH == 1) {
                iGwCOsABmmbfhmKoX = GwCOsABmmbfhmKoX(parcel, iNVLYanOjfsPCCKwX);
            } else if (iDRJcQHyeplxhDneH == 2) {
                strVSvBvJNWPUgwxVEL = vSvBvJNWPUgwxVEL(parcel, iNVLYanOjfsPCCKwX);
            } else if (iDRJcQHyeplxhDneH == 3) {
                pendingobject = (android.app.Pendingobject) mhIewZAvIrfmlHXx(parcel, iNVLYanOjfsPCCKwX, android.app.Pendingobject.CREATOR);
            } else if (iDRJcQHyeplxhDneH == 4) {
                connectionResult = (com.google.android.gms.common.ConnectionResult) WxHFzPlKorhFOplm(parcel, iNVLYanOjfsPCCKwX, com.google.android.gms.common.ConnectionResult.CREATOR);
            } else {
                ZNGYVNJJjmJLNIbo(parcel, iNVLYanOjfsPCCKwX);
            }
        }
        kzJRVISFZhejIvrV(parcel, iRwlOKeHEdAhosSuG);
        return new com.google.android.gms.common.api.Status(iGwCOsABmmbfhmKoX, strVSvBvJNWPUgwxVEL, pendingobject, connectionResult);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.api.Status[i];
    }
}

