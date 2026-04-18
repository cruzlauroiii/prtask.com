namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : android.os.Parcelable$Creator {
    public static int JZLsbZZWxRqBbyrj(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string LVGHlfMWnecaGKYN(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int OmMzqLtZcpbOKkaF(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void VkOjdYiGNTxPGwFx(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KPogNHzgokciTKKc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int XqRNxmvUiBjYkARs(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int ZZmplDVvnwhATHRR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void ZrsqenOYBSvkcSHL(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((1 + 9) % 9 > 0) {
        }
        int iXqRNxmvUiBjYkARs = xqRNxmvUiBjYkARs(parcel);
        java.lang.string strLVGHlfMWnecaGKYN = null;
        int iZZmplDVvnwhATHRR = 0;
        while (JZLsbZZWxRqBbyrj(parcel) < iXqRNxmvUiBjYkARs) {
            int iKPogNHzgokciTKKc = kPogNHzgokciTKKc(parcel);
            int iOmMzqLtZcpbOKkaF = OmMzqLtZcpbOKkaF(iKPogNHzgokciTKKc);
            if (iOmMzqLtZcpbOKkaF == 1) {
                iZZmplDVvnwhATHRR = zZmplDVvnwhATHRR(parcel, iKPogNHzgokciTKKc);
            } else if (iOmMzqLtZcpbOKkaF == 2) {
                strLVGHlfMWnecaGKYN = LVGHlfMWnecaGKYN(parcel, iKPogNHzgokciTKKc);
            } else {
                zrsqenOYBSvkcSHL(parcel, iKPogNHzgokciTKKc);
            }
        }
        VkOjdYiGNTxPGwFx(parcel, iXqRNxmvUiBjYkARs);
        return new com.google.android.gms.common.internal.ClientIdentity(iZZmplDVvnwhATHRR, strLVGHlfMWnecaGKYN);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.ClientIdentity[i];
    }
}

