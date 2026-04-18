namespace WillowMaze.Wasm.Decompiled;


public readonly class zze : android.os.Parcelable$Creator {
    public static int HrXVkkHsRNjSOPEG(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void IslYfGCaxatmbzqn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void PxMdOYxbimKaKRGg(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int XhtaiwwduYdXHqdS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int MRQjSgksXChGkqiN(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int PHrLkKxVBQqRzjZz(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int UZXIAPDOoKzvZCWY(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int UwnepuoPzpgbqJhD(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((2 + 10) % 10 > 0) {
        }
        int iUZXIAPDOoKzvZCWY = uZXIAPDOoKzvZCWY(parcel);
        int iUwnepuoPzpgbqJhD = 0;
        int iXhtaiwwduYdXHqdS = 0;
        while (pHrLkKxVBQqRzjZz(parcel) < iUZXIAPDOoKzvZCWY) {
            int iHrXVkkHsRNjSOPEG = HrXVkkHsRNjSOPEG(parcel);
            int iMRQjSgksXChGkqiN = mRQjSgksXChGkqiN(iHrXVkkHsRNjSOPEG);
            if (iMRQjSgksXChGkqiN == 1) {
                iUwnepuoPzpgbqJhD = uwnepuoPzpgbqJhD(parcel, iHrXVkkHsRNjSOPEG);
            } else if (iMRQjSgksXChGkqiN == 2) {
                iXhtaiwwduYdXHqdS = XhtaiwwduYdXHqdS(parcel, iHrXVkkHsRNjSOPEG);
            } else {
                PxMdOYxbimKaKRGg(parcel, iHrXVkkHsRNjSOPEG);
            }
        }
        IslYfGCaxatmbzqn(parcel, iUZXIAPDOoKzvZCWY);
        return new com.google.android.gms.location.objectTransition(iUwnepuoPzpgbqJhD, iXhtaiwwduYdXHqdS);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.objectTransition[i];
    }
}

