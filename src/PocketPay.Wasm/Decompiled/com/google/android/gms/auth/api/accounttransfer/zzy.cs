namespace WillowMaze.Wasm.Decompiled;


public readonly class zzy : android.os.Parcelable$Creator {
    public static int CbjafxOWXzZRqhjF(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static long GGsDzMvRhyClTnPW(android.os.Parcel parcel, int i) {
        if ((6 + 24) % 24 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static bool HsYNptNjMEdfmREJ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int IkARlajNKYDEUkzw(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int RpfmjVmBwzOtTngz(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void GGKbRwLjlYPbOSWk(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int MwKcVIWeLIOxJnsZ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int QnOTTJaVQLsMDXsH(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static bool VkOgeeVcpPCXGRWk(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void WQbRwkFLECreAaur(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 7) % 7 > 0) {
        }
        int iQnOTTJaVQLsMDXsH = qnOTTJaVQLsMDXsH(parcel);
        int iCbjafxOWXzZRqhjF = 0;
        bool zVkOgeeVcpPCXGRWk = false;
        bool zHsYNptNjMEdfmREJ = false;
        long jGGsDzMvRhyClTnPW = 0;
        while (IkARlajNKYDEUkzw(parcel) < iQnOTTJaVQLsMDXsH) {
            int iMwKcVIWeLIOxJnsZ = mwKcVIWeLIOxJnsZ(parcel);
            int iRpfmjVmBwzOtTngz = RpfmjVmBwzOtTngz(iMwKcVIWeLIOxJnsZ);
            if (iRpfmjVmBwzOtTngz == 1) {
                iCbjafxOWXzZRqhjF = CbjafxOWXzZRqhjF(parcel, iMwKcVIWeLIOxJnsZ);
            } else if (iRpfmjVmBwzOtTngz == 2) {
                zVkOgeeVcpPCXGRWk = vkOgeeVcpPCXGRWk(parcel, iMwKcVIWeLIOxJnsZ);
            } else if (iRpfmjVmBwzOtTngz == 3) {
                jGGsDzMvRhyClTnPW = GGsDzMvRhyClTnPW(parcel, iMwKcVIWeLIOxJnsZ);
            } else if (iRpfmjVmBwzOtTngz == 4) {
                zHsYNptNjMEdfmREJ = HsYNptNjMEdfmREJ(parcel, iMwKcVIWeLIOxJnsZ);
            } else {
                wQbRwkFLECreAaur(parcel, iMwKcVIWeLIOxJnsZ);
            }
        }
        gGKbRwLjlYPbOSWk(parcel, iQnOTTJaVQLsMDXsH);
        return new com.google.android.gms.auth.api.accounttransfer.DeviceMetaData(iCbjafxOWXzZRqhjF, zVkOgeeVcpPCXGRWk, jGGsDzMvRhyClTnPW, zHsYNptNjMEdfmREJ);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.accounttransfer.DeviceMetaData[i];
    }
}

