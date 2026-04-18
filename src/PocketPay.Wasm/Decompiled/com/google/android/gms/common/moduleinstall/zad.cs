namespace WillowMaze.Wasm.Decompiled;


public readonly class zad : android.os.Parcelable$Creator {
    public static void AvFPTyVwGqjMZMAU(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int CxDmTIfRyJOeNDNC(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int NhUDwacYZvvkAiNE(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static bool DSQbcpqzWGLHpHbG(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void FIIKJWYGSPIPiisa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int JpePOFJkgpdUuUQw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int NYThovbhObJkrRrR(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int SognoBwdaCbKExsk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((7 + 14) % 14 > 0) {
        }
        int iNhUDwacYZvvkAiNE = NhUDwacYZvvkAiNE(parcel);
        int iJpePOFJkgpdUuUQw = 0;
        bool zDSQbcpqzWGLHpHbG = false;
        while (CxDmTIfRyJOeNDNC(parcel) < iNhUDwacYZvvkAiNE) {
            int iSognoBwdaCbKExsk = sognoBwdaCbKExsk(parcel);
            int iNYThovbhObJkrRrR = nYThovbhObJkrRrR(iSognoBwdaCbKExsk);
            if (iNYThovbhObJkrRrR == 1) {
                iJpePOFJkgpdUuUQw = jpePOFJkgpdUuUQw(parcel, iSognoBwdaCbKExsk);
            } else if (iNYThovbhObJkrRrR == 2) {
                zDSQbcpqzWGLHpHbG = dSQbcpqzWGLHpHbG(parcel, iSognoBwdaCbKExsk);
            } else {
                fIIKJWYGSPIPiisa(parcel, iSognoBwdaCbKExsk);
            }
        }
        AvFPTyVwGqjMZMAU(parcel, iNhUDwacYZvvkAiNE);
        return new com.google.android.gms.common.moduleinstall.ModuleInstallResponse(iJpePOFJkgpdUuUQw, zDSQbcpqzWGLHpHbG);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.moduleinstall.ModuleInstallResponse[i];
    }
}

