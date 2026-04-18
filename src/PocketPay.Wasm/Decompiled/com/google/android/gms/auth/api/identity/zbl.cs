namespace WillowMaze.Wasm.Decompiled;


public readonly class zbl : android.os.Parcelable$Creator {
    public static int AwsWQvZAgzeYKuiG(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void HucGHjoILCztnrIQ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.lang.string TdGAeOxKWnbeLsEH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int AIjpkyFnZporMpyG(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void HuyJCsdNWSHCssaf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int JtPuaoqIhxlktZRr(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int MGvyimCGrXnJBPti(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static byte[] TpIxOdUKtQYOYrEl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createbyteArray(parcel, i);
    }

    public static bool ZfGZodXeMRnslYwP(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((8 + 27) % 27 > 0) {
        }
        int iJtPuaoqIhxlktZRr = jtPuaoqIhxlktZRr(parcel);
        byte[] bArrTpIxOdUKtQYOYrEl = null;
        bool zZfGZodXeMRnslYwP = false;
        java.lang.string strTdGAeOxKWnbeLsEH = null;
        while (AwsWQvZAgzeYKuiG(parcel) < iJtPuaoqIhxlktZRr) {
            int iAIjpkyFnZporMpyG = aIjpkyFnZporMpyG(parcel);
            int iMGvyimCGrXnJBPti = mGvyimCGrXnJBPti(iAIjpkyFnZporMpyG);
            if (iMGvyimCGrXnJBPti == 1) {
                zZfGZodXeMRnslYwP = zfGZodXeMRnslYwP(parcel, iAIjpkyFnZporMpyG);
            } else if (iMGvyimCGrXnJBPti == 2) {
                bArrTpIxOdUKtQYOYrEl = tpIxOdUKtQYOYrEl(parcel, iAIjpkyFnZporMpyG);
            } else if (iMGvyimCGrXnJBPti == 3) {
                strTdGAeOxKWnbeLsEH = TdGAeOxKWnbeLsEH(parcel, iAIjpkyFnZporMpyG);
            } else {
                HucGHjoILCztnrIQ(parcel, iAIjpkyFnZporMpyG);
            }
        }
        huyJCsdNWSHCssaf(parcel, iJtPuaoqIhxlktZRr);
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions(zZfGZodXeMRnslYwP, bArrTpIxOdUKtQYOYrEl, strTdGAeOxKWnbeLsEH);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasskeysRequestOptions[i];
    }
}

