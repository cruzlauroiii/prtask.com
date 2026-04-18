namespace WillowMaze.Wasm.Decompiled;


public readonly class zbb : android.os.Parcelable$Creator {
    public static android.os.Parcelable BKvetNAIpvFZvSDB(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void KehDYHuhFOPfPpQU(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static bool KiXtQDKJKwsUALqe(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.lang.string TDpogXABpziMVdne(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int UpTloiRKqyzuECOF(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static bool ZnEixiJHKdvOsmkj(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.util.List BqYFLURmPznGhbgL(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static bool BuixCuhVZSuhAsHh(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static android.os.Dictionary<string, object> CJOlbWzfsSOLfsEe(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int EcKlurlwkhxZBKfQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string HWWdJROqQeejrYyV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string NAdGgwONSVLkEtRY(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static bool NoOhvZAcGzndPVWR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int OjuvBnnzrZTdepcA(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int UjxrqcaxvQBiVHaJ(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void WsgKnANogczcrPFa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((14 + 30) % 30 > 0) {
        }
        int iEcKlurlwkhxZBKfQ = ecKlurlwkhxZBKfQ(parcel);
        bool zNoOhvZAcGzndPVWR = false;
        bool zBuixCuhVZSuhAsHh = false;
        bool zKiXtQDKJKwsUALqe = false;
        bool zZnEixiJHKdvOsmkj = false;
        java.util.List arrayListBqYFLURmPznGhbgL = null;
        java.lang.string strHWWdJROqQeejrYyV = null;
        android.accounts.Account account = null;
        java.lang.string strNAdGgwONSVLkEtRY = null;
        java.lang.string strTDpogXABpziMVdne = null;
        android.os.Dictionary<string, object> bundleCJOlbWzfsSOLfsEe = null;
        while (UpTloiRKqyzuECOF(parcel) < iEcKlurlwkhxZBKfQ) {
            int iOjuvBnnzrZTdepcA = ojuvBnnzrZTdepcA(parcel);
            switch (ujxrqcaxvQBiVHaJ(iOjuvBnnzrZTdepcA)) {
                case 1:
                    arrayListBqYFLURmPznGhbgL = bqYFLURmPznGhbgL(parcel, iOjuvBnnzrZTdepcA, com.google.android.gms.common.api.Scope.CREATOR);
                    break;
                case 2:
                    strHWWdJROqQeejrYyV = hWWdJROqQeejrYyV(parcel, iOjuvBnnzrZTdepcA);
                    break;
                case 3:
                    zNoOhvZAcGzndPVWR = noOhvZAcGzndPVWR(parcel, iOjuvBnnzrZTdepcA);
                    break;
                case 4:
                    zBuixCuhVZSuhAsHh = buixCuhVZSuhAsHh(parcel, iOjuvBnnzrZTdepcA);
                    break;
                case 5:
                    account = (android.accounts.Account) BKvetNAIpvFZvSDB(parcel, iOjuvBnnzrZTdepcA, android.accounts.Account.CREATOR);
                    break;
                case 6:
                    strNAdGgwONSVLkEtRY = nAdGgwONSVLkEtRY(parcel, iOjuvBnnzrZTdepcA);
                    break;
                case 7:
                    strTDpogXABpziMVdne = TDpogXABpziMVdne(parcel, iOjuvBnnzrZTdepcA);
                    break;
                case 8:
                    zKiXtQDKJKwsUALqe = KiXtQDKJKwsUALqe(parcel, iOjuvBnnzrZTdepcA);
                    break;
                case 9:
                    bundleCJOlbWzfsSOLfsEe = cJOlbWzfsSOLfsEe(parcel, iOjuvBnnzrZTdepcA);
                    break;
                case 10:
                    zZnEixiJHKdvOsmkj = ZnEixiJHKdvOsmkj(parcel, iOjuvBnnzrZTdepcA);
                    break;
                default:
                    KehDYHuhFOPfPpQU(parcel, iOjuvBnnzrZTdepcA);
                    break;
            }
        }
        wsgKnANogczcrPFa(parcel, iEcKlurlwkhxZBKfQ);
        return new com.google.android.gms.auth.api.identity.AuthorizationRequest(arrayListBqYFLURmPznGhbgL, strHWWdJROqQeejrYyV, zNoOhvZAcGzndPVWR, zBuixCuhVZSuhAsHh, account, strNAdGgwONSVLkEtRY, strTDpogXABpziMVdne, zKiXtQDKJKwsUALqe, bundleCJOlbWzfsSOLfsEe, zZnEixiJHKdvOsmkj);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.AuthorizationRequest[i];
    }
}

