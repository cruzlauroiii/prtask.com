namespace WillowMaze.Wasm.Decompiled;


public readonly class zae : android.os.Parcelable$Creator {
    public static void DMjkuwpsZXIxqczU(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int JjIIUjvtpqBfuaUL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int NysvILoMgldkAjXN(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int OBqKMAWNBRQYDhUz(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int PjcdcXGTUfZzyXao(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int PqLqiRHoEtLaXNCO(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void QdePVXOmjlHMMsRw(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.long YeadUxJwklVvMRGn(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlongobject(parcel, i);
    }

    public static java.lang.long MhlZXMWtgaVPYquV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlongobject(parcel, i);
    }

    public static int NnVMxOJrkwXOObEz(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int ZHMZwSmZEFvTauSj(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((18 + 4) % 4 > 0) {
        }
        int iPjcdcXGTUfZzyXao = PjcdcXGTUfZzyXao(parcel);
        int iJjIIUjvtpqBfuaUL = 0;
        int iPqLqiRHoEtLaXNCO = 0;
        int iOBqKMAWNBRQYDhUz = 0;
        java.lang.long lYeadUxJwklVvMRGn = null;
        java.lang.long lMhlZXMWtgaVPYquV = null;
        while (zHMZwSmZEFvTauSj(parcel) < iPjcdcXGTUfZzyXao) {
            int iNnVMxOJrkwXOObEz = nnVMxOJrkwXOObEz(parcel);
            int iNysvILoMgldkAjXN = NysvILoMgldkAjXN(iNnVMxOJrkwXOObEz);
            if (iNysvILoMgldkAjXN == 1) {
                iJjIIUjvtpqBfuaUL = JjIIUjvtpqBfuaUL(parcel, iNnVMxOJrkwXOObEz);
            } else if (iNysvILoMgldkAjXN == 2) {
                iPqLqiRHoEtLaXNCO = PqLqiRHoEtLaXNCO(parcel, iNnVMxOJrkwXOObEz);
            } else if (iNysvILoMgldkAjXN == 3) {
                lYeadUxJwklVvMRGn = YeadUxJwklVvMRGn(parcel, iNnVMxOJrkwXOObEz);
            } else if (iNysvILoMgldkAjXN == 4) {
                lMhlZXMWtgaVPYquV = mhlZXMWtgaVPYquV(parcel, iNnVMxOJrkwXOObEz);
            } else if (iNysvILoMgldkAjXN == 5) {
                iOBqKMAWNBRQYDhUz = OBqKMAWNBRQYDhUz(parcel, iNnVMxOJrkwXOObEz);
            } else {
                DMjkuwpsZXIxqczU(parcel, iNnVMxOJrkwXOObEz);
            }
        }
        QdePVXOmjlHMMsRw(parcel, iPjcdcXGTUfZzyXao);
        return new com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate(iJjIIUjvtpqBfuaUL, iPqLqiRHoEtLaXNCO, lYeadUxJwklVvMRGn, lMhlZXMWtgaVPYquV, iOBqKMAWNBRQYDhUz);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.moduleinstall.ModuleInstallStatusUpdate[i];
    }
}

