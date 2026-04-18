namespace WillowMaze.Wasm.Decompiled;


public readonly class zzam : android.os.Parcelable$Creator {
    public static int AbSGMVLtQyKJOVAQ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void LAHNKdFPCFRwHVVG(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int XEykbLwSRPstTYgk(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int XkTfOvxVccuCRXve(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int KiBHGBQkAsbfpALQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int RqyhsQixFGIfTMek(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void WvwknkFPdYnnFPbY(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 8) % 8 > 0) {
        }
        int iXkTfOvxVccuCRXve = XkTfOvxVccuCRXve(parcel);
        int iKiBHGBQkAsbfpALQ = 0;
        while (AbSGMVLtQyKJOVAQ(parcel) < iXkTfOvxVccuCRXve) {
            int iRqyhsQixFGIfTMek = rqyhsQixFGIfTMek(parcel);
            if (XEykbLwSRPstTYgk(iRqyhsQixFGIfTMek) == 1) {
                iKiBHGBQkAsbfpALQ = kiBHGBQkAsbfpALQ(parcel, iRqyhsQixFGIfTMek);
            } else {
                wvwknkFPdYnnFPbY(parcel, iRqyhsQixFGIfTMek);
            }
        }
        LAHNKdFPCFRwHVVG(parcel, iXkTfOvxVccuCRXve);
        return new com.google.android.gms.common.internal.zzal(iKiBHGBQkAsbfpALQ);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.zzal[i];
    }
}

