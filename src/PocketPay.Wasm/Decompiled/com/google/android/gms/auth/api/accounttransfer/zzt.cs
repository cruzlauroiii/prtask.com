namespace WillowMaze.Wasm.Decompiled;


public readonly class zzt : android.os.Parcelable$Creator {
    public static java.util.List JQOwsilQMElvTCHR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static int KrXTJcSxMFNNLjfn(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int NoWjiVOXapzBFPAk(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.util.List XlegGTWsuEdiItDf(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static java.util.List DmVViGNaoqmsiaMu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static int DrZBvXstMHOcxUEW(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int EkUIugWfiJFovcAw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void MpbotoPMWXEglKeO(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void RXEKkMHSzniZwmPl(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.util.List TAFupHMVQlTTSAXX(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static int YYvnadqMsPJCDNZs(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.util.List YieYqVvcJEjOmBBw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 7) % 7 > 0) {
        }
        int iNoWjiVOXapzBFPAk = NoWjiVOXapzBFPAk(parcel);
        java.util.List arrayListXlegGTWsuEdiItDf = null;
        java.util.List arrayListJQOwsilQMElvTCHR = null;
        java.util.List arrayListTAFupHMVQlTTSAXX = null;
        java.util.List arrayListDmVViGNaoqmsiaMu = null;
        java.util.List arrayListYieYqVvcJEjOmBBw = null;
        int iEkUIugWfiJFovcAw = 0;
        while (yYvnadqMsPJCDNZs(parcel) < iNoWjiVOXapzBFPAk) {
            int iDrZBvXstMHOcxUEW = drZBvXstMHOcxUEW(parcel);
            switch (KrXTJcSxMFNNLjfn(iDrZBvXstMHOcxUEW)) {
                case 1:
                    iEkUIugWfiJFovcAw = ekUIugWfiJFovcAw(parcel, iDrZBvXstMHOcxUEW);
                    break;
                case 2:
                    arrayListXlegGTWsuEdiItDf = XlegGTWsuEdiItDf(parcel, iDrZBvXstMHOcxUEW);
                    break;
                case 3:
                    arrayListJQOwsilQMElvTCHR = JQOwsilQMElvTCHR(parcel, iDrZBvXstMHOcxUEW);
                    break;
                case 4:
                    arrayListTAFupHMVQlTTSAXX = tAFupHMVQlTTSAXX(parcel, iDrZBvXstMHOcxUEW);
                    break;
                case 5:
                    arrayListDmVViGNaoqmsiaMu = dmVViGNaoqmsiaMu(parcel, iDrZBvXstMHOcxUEW);
                    break;
                case 6:
                    arrayListYieYqVvcJEjOmBBw = yieYqVvcJEjOmBBw(parcel, iDrZBvXstMHOcxUEW);
                    break;
                default:
                    rXEKkMHSzniZwmPl(parcel, iDrZBvXstMHOcxUEW);
                    break;
            }
        }
        mpbotoPMWXEglKeO(parcel, iNoWjiVOXapzBFPAk);
        return new com.google.android.gms.auth.api.accounttransfer.zzs(iEkUIugWfiJFovcAw, arrayListXlegGTWsuEdiItDf, arrayListJQOwsilQMElvTCHR, arrayListTAFupHMVQlTTSAXX, arrayListDmVViGNaoqmsiaMu, arrayListYieYqVvcJEjOmBBw);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.accounttransfer.zzs[i];
    }
}

