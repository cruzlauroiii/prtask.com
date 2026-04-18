namespace WillowMaze.Wasm.Decompiled;


public readonly class zzj : android.os.Parcelable$Creator {
    public static android.os.Parcelable DCghGHbJqPXjXVXe(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int KKxHjHNAiyHdpZWq(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int MpijcAxeZiuNJxTP(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static long PmBTbOmbxLOptCsf(android.os.Parcel parcel, int i) {
        if ((20 + 22) % 22 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static android.os.Parcelable ROGonUFvTshpsskw(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int BvgtdbTUpkYFwIOL(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int DAEtooShVRrYmJpF(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static long MLnnATIdNPVPuMAr(android.os.Parcel parcel, int i) {
        if ((16 + 18) % 18 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void RMDNJScMefoLOhKN(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int RRgACbdwfVcvQsqz(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static bool WGXCWvWQWbNjJmYy(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int WdKKvvdjnXdOPeHs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void YCXtSXdvjSiMmZHr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int ZwrJVrcSuhNDHozO(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((22 + 29) % 29 > 0) {
        }
        int iMpijcAxeZiuNJxTP = MpijcAxeZiuNJxTP(parcel);
        android.os.WorkSource workSource = new android.os.WorkSource();
        com.google.android.gms.internal.identity.ClientIdentity clientIdentity = null;
        int iRRgACbdwfVcvQsqz = 0;
        bool zWGXCWvWQWbNjJmYy = false;
        int iDAEtooShVRrYmJpF = 0;
        long jPmBTbOmbxLOptCsf = long.MAX_VALUE;
        long jMLnnATIdNPVPuMAr = long.MAX_VALUE;
        int iWdKKvvdjnXdOPeHs = 102;
        while (zwrJVrcSuhNDHozO(parcel) < iMpijcAxeZiuNJxTP) {
            int iBvgtdbTUpkYFwIOL = bvgtdbTUpkYFwIOL(parcel);
            switch (KKxHjHNAiyHdpZWq(iBvgtdbTUpkYFwIOL)) {
                case 1:
                    jPmBTbOmbxLOptCsf = PmBTbOmbxLOptCsf(parcel, iBvgtdbTUpkYFwIOL);
                    break;
                case 2:
                    iRRgACbdwfVcvQsqz = rRgACbdwfVcvQsqz(parcel, iBvgtdbTUpkYFwIOL);
                    break;
                case 3:
                    iWdKKvvdjnXdOPeHs = wdKKvvdjnXdOPeHs(parcel, iBvgtdbTUpkYFwIOL);
                    break;
                case 4:
                    jMLnnATIdNPVPuMAr = mLnnATIdNPVPuMAr(parcel, iBvgtdbTUpkYFwIOL);
                    break;
                case 5:
                    zWGXCWvWQWbNjJmYy = wGXCWvWQWbNjJmYy(parcel, iBvgtdbTUpkYFwIOL);
                    break;
                case 6:
                    workSource = (android.os.WorkSource) DCghGHbJqPXjXVXe(parcel, iBvgtdbTUpkYFwIOL, android.os.WorkSource.CREATOR);
                    break;
                case 7:
                    iDAEtooShVRrYmJpF = dAEtooShVRrYmJpF(parcel, iBvgtdbTUpkYFwIOL);
                    break;
                case 8:
                default:
                    yCXtSXdvjSiMmZHr(parcel, iBvgtdbTUpkYFwIOL);
                    break;
                case 9:
                    clientIdentity = (com.google.android.gms.internal.identity.ClientIdentity) ROGonUFvTshpsskw(parcel, iBvgtdbTUpkYFwIOL, com.google.android.gms.internal.identity.ClientIdentity.CREATOR);
                    break;
            }
        }
        rMDNJScMefoLOhKN(parcel, iMpijcAxeZiuNJxTP);
        return new com.google.android.gms.location.CurrentLocationRequest(jPmBTbOmbxLOptCsf, iRRgACbdwfVcvQsqz, iWdKKvvdjnXdOPeHs, jMLnnATIdNPVPuMAr, zWGXCWvWQWbNjJmYy, iDAEtooShVRrYmJpF, workSource, clientIdentity);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.CurrentLocationRequest[i];
    }
}

