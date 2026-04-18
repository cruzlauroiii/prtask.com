namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : android.os.Parcelable$Creator {
    public static int FYpngldjBCSLCjDA(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void REYdCvgRXgtKXCdq(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int UKSqJKUonfgwpvIw(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void ELVJebcQsJlSGczA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int LgclngFxoJSBLBUO(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int NzItXrAsOyPtVuHg(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static android.os.Parcelable RTKFumPYvMHXQHjp(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int UmoVxWaAYHnuwemZ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int ZqvHzkuKWbJCKeab(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((11 + 2) % 2 > 0) {
        }
        int iLgclngFxoJSBLBUO = lgclngFxoJSBLBUO(parcel);
        int iUmoVxWaAYHnuwemZ = 0;
        android.os.ParcelstringDescriptor parcelstringDescriptor = null;
        int iFYpngldjBCSLCjDA = 0;
        while (nzItXrAsOyPtVuHg(parcel) < iLgclngFxoJSBLBUO) {
            int iZqvHzkuKWbJCKeab = zqvHzkuKWbJCKeab(parcel);
            int iUKSqJKUonfgwpvIw = UKSqJKUonfgwpvIw(iZqvHzkuKWbJCKeab);
            if (iUKSqJKUonfgwpvIw == 1) {
                iUmoVxWaAYHnuwemZ = umoVxWaAYHnuwemZ(parcel, iZqvHzkuKWbJCKeab);
            } else if (iUKSqJKUonfgwpvIw == 2) {
                parcelstringDescriptor = (android.os.ParcelstringDescriptor) rTKFumPYvMHXQHjp(parcel, iZqvHzkuKWbJCKeab, android.os.ParcelstringDescriptor.CREATOR);
            } else if (iUKSqJKUonfgwpvIw == 3) {
                iFYpngldjBCSLCjDA = FYpngldjBCSLCjDA(parcel, iZqvHzkuKWbJCKeab);
            } else {
                REYdCvgRXgtKXCdq(parcel, iZqvHzkuKWbJCKeab);
            }
        }
        eLVJebcQsJlSGczA(parcel, iLgclngFxoJSBLBUO);
        return new com.google.android.gms.common.data.BitmapTeleporter(iUmoVxWaAYHnuwemZ, parcelstringDescriptor, iFYpngldjBCSLCjDA);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.data.BitmapTeleporter[i];
    }
}

