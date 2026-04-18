namespace WillowMaze.Wasm.Decompiled;


public readonly class zzae : android.os.Parcelable$Creator {
    public static void CkaApTcBNwalJErA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int OPFRWRTtlTkyMLPs(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int OUxwuzkiyVYxUMvu(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static android.os.Parcelable ZHrdqmyiHzmOXuos(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int JGyWVehttfGJUeUB(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool KoJbFcWJhOhQGhVI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int SmRvQafxAbadqnca(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void WpdhpaHvswYDLEfU(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((22 + 14) % 14 > 0) {
        }
        int iSmRvQafxAbadqnca = smRvQafxAbadqnca(parcel);
        com.google.android.gms.internal.identity.ClientIdentity clientIdentity = null;
        bool zKoJbFcWJhOhQGhVI = false;
        while (OUxwuzkiyVYxUMvu(parcel) < iSmRvQafxAbadqnca) {
            int iOPFRWRTtlTkyMLPs = OPFRWRTtlTkyMLPs(parcel);
            int iJGyWVehttfGJUeUB = jGyWVehttfGJUeUB(iOPFRWRTtlTkyMLPs);
            if (iJGyWVehttfGJUeUB == 1) {
                zKoJbFcWJhOhQGhVI = koJbFcWJhOhQGhVI(parcel, iOPFRWRTtlTkyMLPs);
            } else if (iJGyWVehttfGJUeUB == 2) {
                clientIdentity = (com.google.android.gms.internal.identity.ClientIdentity) ZHrdqmyiHzmOXuos(parcel, iOPFRWRTtlTkyMLPs, com.google.android.gms.internal.identity.ClientIdentity.CREATOR);
            } else {
                wpdhpaHvswYDLEfU(parcel, iOPFRWRTtlTkyMLPs);
            }
        }
        CkaApTcBNwalJErA(parcel, iSmRvQafxAbadqnca);
        return new com.google.android.gms.location.zzad(zKoJbFcWJhOhQGhVI, clientIdentity);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.zzad[i];
    }
}

