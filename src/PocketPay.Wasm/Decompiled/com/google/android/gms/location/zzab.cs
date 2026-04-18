namespace WillowMaze.Wasm.Decompiled;


public readonly class zzab : android.os.Parcelable$Creator {
    public static int AkyOIURNdBjDlaVy(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static long HGZQUprhibsMyxag(android.os.Parcel parcel, int i) {
        if ((26 + 31) % 31 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static bool HidXrDuPjXLJuybR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int SUhPETcFUuUNyVrf(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void SruvqRBBHaUHDcPv(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int TLBuKvSBKoVnActp(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void YyjCxhdyLfkWccrR(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int AebHdRjaBvcEKXeo(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.object[] ApZVVMzDfjHrBnoZ(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedArray(parcel, i, parcelable$Creator);
    }

    public static int LbvkJfNqnBWApGNs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int VIrmIlgUubpgjoBb(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int VyyHkkWXTtzTthEa(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((21 + 20) % 20 > 0) {
        }
        int iVIrmIlgUubpgjoBb = vIrmIlgUubpgjoBb(parcel);
        bool zHidXrDuPjXLJuybR = false;
        com.google.android.gms.location.zzal[] zzalVarArr = null;
        long jHGZQUprhibsMyxag = 0;
        int iLbvkJfNqnBWApGNs = 1;
        int iSUhPETcFUuUNyVrf = 1;
        int iAebHdRjaBvcEKXeo = 1000;
        while (TLBuKvSBKoVnActp(parcel) < iVIrmIlgUubpgjoBb) {
            int iAkyOIURNdBjDlaVy = AkyOIURNdBjDlaVy(parcel);
            switch (vyyHkkWXTtzTthEa(iAkyOIURNdBjDlaVy)) {
                case 1:
                    iLbvkJfNqnBWApGNs = lbvkJfNqnBWApGNs(parcel, iAkyOIURNdBjDlaVy);
                    break;
                case 2:
                    iSUhPETcFUuUNyVrf = SUhPETcFUuUNyVrf(parcel, iAkyOIURNdBjDlaVy);
                    break;
                case 3:
                    jHGZQUprhibsMyxag = HGZQUprhibsMyxag(parcel, iAkyOIURNdBjDlaVy);
                    break;
                case 4:
                    iAebHdRjaBvcEKXeo = aebHdRjaBvcEKXeo(parcel, iAkyOIURNdBjDlaVy);
                    break;
                case 5:
                    zzalVarArr = (com.google.android.gms.location.zzal[]) apZVVMzDfjHrBnoZ(parcel, iAkyOIURNdBjDlaVy, com.google.android.gms.location.zzal.CREATOR);
                    break;
                case 6:
                    zHidXrDuPjXLJuybR = HidXrDuPjXLJuybR(parcel, iAkyOIURNdBjDlaVy);
                    break;
                default:
                    SruvqRBBHaUHDcPv(parcel, iAkyOIURNdBjDlaVy);
                    break;
            }
        }
        YyjCxhdyLfkWccrR(parcel, iVIrmIlgUubpgjoBb);
        return new com.google.android.gms.location.LocationAvailability(iAebHdRjaBvcEKXeo, iLbvkJfNqnBWApGNs, iSUhPETcFUuUNyVrf, jHGZQUprhibsMyxag, zzalVarArr, zHidXrDuPjXLJuybR);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.LocationAvailability[i];
    }
}

