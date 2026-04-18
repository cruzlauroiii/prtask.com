namespace WillowMaze.Wasm.Decompiled;


public readonly class zbj : android.os.Parcelable$Creator {
    public static java.lang.string FnjDLsrhGgyAkWEg(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void GmPkgThhabZyRKKz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static bool GoLjOeHhjDJitZqV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int IzvCdzFrHVwKnIKh(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.util.List JxfYOIgRijIKMtAI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static bool RQxJGttsikHRNtzI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static void ZUhfaxlzlHerNYzK(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string DudLVpewCfLKkwSp(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static bool GIBGnPOJfbXsivkm(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int GXKTJTZNyoJKQixC(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int IDxwLvBcuimNKFCb(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string LFViWHQdHZigVrJM(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int ShTteGkyPEzXLHIi(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((16 + 9) % 9 > 0) {
        }
        int iGXKTJTZNyoJKQixC = gXKTJTZNyoJKQixC(parcel);
        bool zRQxJGttsikHRNtzI = false;
        bool zGIBGnPOJfbXsivkm = false;
        bool zGoLjOeHhjDJitZqV = false;
        java.lang.string strLFViWHQdHZigVrJM = null;
        java.lang.string strDudLVpewCfLKkwSp = null;
        java.lang.string strFnjDLsrhGgyAkWEg = null;
        java.util.List arrayListJxfYOIgRijIKMtAI = null;
        while (shTteGkyPEzXLHIi(parcel) < iGXKTJTZNyoJKQixC) {
            int iIzvCdzFrHVwKnIKh = IzvCdzFrHVwKnIKh(parcel);
            switch (iDxwLvBcuimNKFCb(iIzvCdzFrHVwKnIKh)) {
                case 1:
                    zRQxJGttsikHRNtzI = RQxJGttsikHRNtzI(parcel, iIzvCdzFrHVwKnIKh);
                    break;
                case 2:
                    strLFViWHQdHZigVrJM = lFViWHQdHZigVrJM(parcel, iIzvCdzFrHVwKnIKh);
                    break;
                case 3:
                    strDudLVpewCfLKkwSp = dudLVpewCfLKkwSp(parcel, iIzvCdzFrHVwKnIKh);
                    break;
                case 4:
                    zGIBGnPOJfbXsivkm = gIBGnPOJfbXsivkm(parcel, iIzvCdzFrHVwKnIKh);
                    break;
                case 5:
                    strFnjDLsrhGgyAkWEg = FnjDLsrhGgyAkWEg(parcel, iIzvCdzFrHVwKnIKh);
                    break;
                case 6:
                    arrayListJxfYOIgRijIKMtAI = JxfYOIgRijIKMtAI(parcel, iIzvCdzFrHVwKnIKh);
                    break;
                case 7:
                    zGoLjOeHhjDJitZqV = GoLjOeHhjDJitZqV(parcel, iIzvCdzFrHVwKnIKh);
                    break;
                default:
                    GmPkgThhabZyRKKz(parcel, iIzvCdzFrHVwKnIKh);
                    break;
            }
        }
        ZUhfaxlzlHerNYzK(parcel, iGXKTJTZNyoJKQixC);
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions(zRQxJGttsikHRNtzI, strLFViWHQdHZigVrJM, strDudLVpewCfLKkwSp, zGIBGnPOJfbXsivkm, strFnjDLsrhGgyAkWEg, arrayListJxfYOIgRijIKMtAI, zGoLjOeHhjDJitZqV);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$GoogleIdTokenRequestOptions[i];
    }
}

