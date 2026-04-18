namespace WillowMaze.Wasm.Decompiled;


public readonly class zae : android.os.Parcelable$Creator {
    public static bool CotSDyQlTZBrOkow(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static android.os.Parcelable LCLifERexYgiPXra(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static java.lang.string TWFTOqLGrAmaMNYB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.util.List YiEXfVeFatokYjQY(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int AYBzwbsAQOOGEVPB(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int CoRlzlqATKwfKBdH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static bool DmtWDfitxvyTmWaF(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.lang.string IhoELqptCYdTfGeQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.util.List IrkHcNnMfnysjgUy(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int JCZpWyuLYvdqCGgF(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void KKZvabJBYtaHnhJt(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.lang.string NvKFFFTypAHXztFk(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int PuRohORzTvaIvMzf(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool QUeuSmjNqNMOcGzJ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void ROPYKUZInPOwxiUz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int YelyhHmdukANsfTu(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((10 + 24) % 24 > 0) {
        }
        int iYelyhHmdukANsfTu = yelyhHmdukANsfTu(parcel);
        java.util.List arrayListYiEXfVeFatokYjQY = null;
        android.accounts.Account account = null;
        java.lang.string strTWFTOqLGrAmaMNYB = null;
        java.lang.string strIhoELqptCYdTfGeQ = null;
        java.util.List arrayListIrkHcNnMfnysjgUy = null;
        java.lang.string strNvKFFFTypAHXztFk = null;
        int iCoRlzlqATKwfKBdH = 0;
        bool zCotSDyQlTZBrOkow = false;
        bool zDmtWDfitxvyTmWaF = false;
        bool zQUeuSmjNqNMOcGzJ = false;
        while (aYBzwbsAQOOGEVPB(parcel) < iYelyhHmdukANsfTu) {
            int iJCZpWyuLYvdqCGgF = jCZpWyuLYvdqCGgF(parcel);
            switch (puRohORzTvaIvMzf(iJCZpWyuLYvdqCGgF)) {
                case 1:
                    iCoRlzlqATKwfKBdH = coRlzlqATKwfKBdH(parcel, iJCZpWyuLYvdqCGgF);
                    break;
                case 2:
                    arrayListYiEXfVeFatokYjQY = YiEXfVeFatokYjQY(parcel, iJCZpWyuLYvdqCGgF, com.google.android.gms.common.api.Scope.CREATOR);
                    break;
                case 3:
                    account = (android.accounts.Account) LCLifERexYgiPXra(parcel, iJCZpWyuLYvdqCGgF, android.accounts.Account.CREATOR);
                    break;
                case 4:
                    zCotSDyQlTZBrOkow = CotSDyQlTZBrOkow(parcel, iJCZpWyuLYvdqCGgF);
                    break;
                case 5:
                    zDmtWDfitxvyTmWaF = dmtWDfitxvyTmWaF(parcel, iJCZpWyuLYvdqCGgF);
                    break;
                case 6:
                    zQUeuSmjNqNMOcGzJ = qUeuSmjNqNMOcGzJ(parcel, iJCZpWyuLYvdqCGgF);
                    break;
                case 7:
                    strTWFTOqLGrAmaMNYB = TWFTOqLGrAmaMNYB(parcel, iJCZpWyuLYvdqCGgF);
                    break;
                case 8:
                    strIhoELqptCYdTfGeQ = ihoELqptCYdTfGeQ(parcel, iJCZpWyuLYvdqCGgF);
                    break;
                case 9:
                    arrayListIrkHcNnMfnysjgUy = irkHcNnMfnysjgUy(parcel, iJCZpWyuLYvdqCGgF, com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable.CREATOR);
                    break;
                case 10:
                    strNvKFFFTypAHXztFk = nvKFFFTypAHXztFk(parcel, iJCZpWyuLYvdqCGgF);
                    break;
                default:
                    kKZvabJBYtaHnhJt(parcel, iJCZpWyuLYvdqCGgF);
                    break;
            }
        }
        rOPYKUZInPOwxiUz(parcel, iYelyhHmdukANsfTu);
        return new com.google.android.gms.auth.api.signin.GoogleSignInOptions(iCoRlzlqATKwfKBdH, arrayListYiEXfVeFatokYjQY, account, zCotSDyQlTZBrOkow, zDmtWDfitxvyTmWaF, zQUeuSmjNqNMOcGzJ, strTWFTOqLGrAmaMNYB, strIhoELqptCYdTfGeQ, arrayListIrkHcNnMfnysjgUy, strNvKFFFTypAHXztFk);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.signin.GoogleSignInOptions[i];
    }
}

