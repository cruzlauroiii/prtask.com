namespace WillowMaze.Wasm.Decompiled;


public readonly class zao : android.os.Parcelable$Creator {
    public static int BvVMYxRppPehPljf(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void GmzHlHyjdjVZWhBj(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void LyEmOFkJLaqQFECG(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string RYgjRbqgkUMHvrrs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int VRWVaQjDnTRPwcUD(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int KHitXVRTbYileXmp(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int KoOUbGjhvPdZIBTB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.util.List LqRdPyuOYVTejske(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int MDVVwfaGGdWQupSd(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((7 + 29) % 29 > 0) {
        }
        int iVRWVaQjDnTRPwcUD = VRWVaQjDnTRPwcUD(parcel);
        java.util.List arrayListLqRdPyuOYVTejske = null;
        int iMDVVwfaGGdWQupSd = 0;
        java.lang.string strRYgjRbqgkUMHvrrs = null;
        while (kHitXVRTbYileXmp(parcel) < iVRWVaQjDnTRPwcUD) {
            int iKoOUbGjhvPdZIBTB = koOUbGjhvPdZIBTB(parcel);
            int iBvVMYxRppPehPljf = BvVMYxRppPehPljf(iKoOUbGjhvPdZIBTB);
            if (iBvVMYxRppPehPljf == 1) {
                iMDVVwfaGGdWQupSd = mDVVwfaGGdWQupSd(parcel, iKoOUbGjhvPdZIBTB);
            } else if (iBvVMYxRppPehPljf == 2) {
                arrayListLqRdPyuOYVTejske = lqRdPyuOYVTejske(parcel, iKoOUbGjhvPdZIBTB, com.google.android.gms.common.server.response.zal.CREATOR);
            } else if (iBvVMYxRppPehPljf == 3) {
                strRYgjRbqgkUMHvrrs = RYgjRbqgkUMHvrrs(parcel, iKoOUbGjhvPdZIBTB);
            } else {
                GmzHlHyjdjVZWhBj(parcel, iKoOUbGjhvPdZIBTB);
            }
        }
        LyEmOFkJLaqQFECG(parcel, iVRWVaQjDnTRPwcUD);
        return new com.google.android.gms.common.server.response.zan(iMDVVwfaGGdWQupSd, arrayListLqRdPyuOYVTejske, strRYgjRbqgkUMHvrrs);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.response.zan[i];
    }
}

