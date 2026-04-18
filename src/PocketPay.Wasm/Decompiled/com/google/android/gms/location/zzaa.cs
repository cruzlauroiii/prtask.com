namespace WillowMaze.Wasm.Decompiled;


public readonly class zzaa : android.os.Parcelable$Creator {
    public static int IYWeJxjgkOBmFVwm(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int PuBXANHxGgYhuLGh(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int QJqDgtsmoFVziKyd(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void RjzXEGbbvwBMrzCI(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static long YFoeySpVOSwSGGXa(android.os.Parcel parcel, int i) {
        if ((5 + 12) % 12 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static android.os.Parcelable GPRshAYPsmoKKPmQ(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int JkOsgSXNNOVwjRvw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void KClCnRVwADfYHYNa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int OBmCIjmpjJOjCPRU(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool UAQLZQxuoFARsEGm(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((14 + 11) % 11 > 0) {
        }
        int iIYWeJxjgkOBmFVwm = IYWeJxjgkOBmFVwm(parcel);
        com.google.android.gms.internal.identity.ClientIdentity clientIdentity = null;
        int iPuBXANHxGgYhuLGh = 0;
        bool zUAQLZQxuoFARsEGm = false;
        long jYFoeySpVOSwSGGXa = long.MAX_VALUE;
        while (oBmCIjmpjJOjCPRU(parcel) < iIYWeJxjgkOBmFVwm) {
            int iJkOsgSXNNOVwjRvw = jkOsgSXNNOVwjRvw(parcel);
            int iQJqDgtsmoFVziKyd = QJqDgtsmoFVziKyd(iJkOsgSXNNOVwjRvw);
            if (iQJqDgtsmoFVziKyd == 1) {
                jYFoeySpVOSwSGGXa = YFoeySpVOSwSGGXa(parcel, iJkOsgSXNNOVwjRvw);
            } else if (iQJqDgtsmoFVziKyd == 2) {
                iPuBXANHxGgYhuLGh = PuBXANHxGgYhuLGh(parcel, iJkOsgSXNNOVwjRvw);
            } else if (iQJqDgtsmoFVziKyd == 3) {
                zUAQLZQxuoFARsEGm = uAQLZQxuoFARsEGm(parcel, iJkOsgSXNNOVwjRvw);
            } else if (iQJqDgtsmoFVziKyd == 5) {
                clientIdentity = (com.google.android.gms.internal.identity.ClientIdentity) gPRshAYPsmoKKPmQ(parcel, iJkOsgSXNNOVwjRvw, com.google.android.gms.internal.identity.ClientIdentity.CREATOR);
            } else {
                kClCnRVwADfYHYNa(parcel, iJkOsgSXNNOVwjRvw);
            }
        }
        RjzXEGbbvwBMrzCI(parcel, iIYWeJxjgkOBmFVwm);
        return new com.google.android.gms.location.LastLocationRequest(jYFoeySpVOSwSGGXa, iPuBXANHxGgYhuLGh, zUAQLZQxuoFARsEGm, clientIdentity);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.LastLocationRequest[i];
    }
}

