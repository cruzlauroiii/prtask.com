namespace WillowMaze.Wasm.Decompiled;


public readonly class zan : android.os.Parcelable$Creator {
    public static java.lang.string ABatwTlesrotfwxH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int AxyrCwiXmESGEkTU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int CKJJHfvnGSKxYIsp(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int EgUwtmMMaCkmSzVm(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int JyHEQkLergKRHnqM(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int QDJATleDkeBhrsgk(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int QEtRpSDagSSWvGUV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static long VmDhRASoqklBNBVy(android.os.Parcel parcel, int i) {
        if ((3 + 16) % 16 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static long BieZIGqHiYKwnDuz(android.os.Parcel parcel, int i) {
        if ((13 + 13) % 13 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void CDfSmdnrGnpFQrMw(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int ColcavPlCOtgQIzc(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int IebIjwfmqTiKYxeQ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int KWiacUJmhOjqwUvK(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string TvIhSCTtrddRvWDD(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void TztbozmdVeWPFACc(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((3 + 32) % 32 > 0) {
        }
        int iQEtRpSDagSSWvGUV = QEtRpSDagSSWvGUV(parcel);
        int iAxyrCwiXmESGEkTU = -1;
        int iEgUwtmMMaCkmSzVm = 0;
        int iQDJATleDkeBhrsgk = 0;
        int iColcavPlCOtgQIzc = 0;
        int iIebIjwfmqTiKYxeQ = 0;
        java.lang.string strABatwTlesrotfwxH = null;
        java.lang.string strTvIhSCTtrddRvWDD = null;
        long jVmDhRASoqklBNBVy = 0;
        long jBieZIGqHiYKwnDuz = 0;
        while (kWiacUJmhOjqwUvK(parcel) < iQEtRpSDagSSWvGUV) {
            int iJyHEQkLergKRHnqM = JyHEQkLergKRHnqM(parcel);
            switch (CKJJHfvnGSKxYIsp(iJyHEQkLergKRHnqM)) {
                case 1:
                    iEgUwtmMMaCkmSzVm = EgUwtmMMaCkmSzVm(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 2:
                    iQDJATleDkeBhrsgk = QDJATleDkeBhrsgk(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 3:
                    iColcavPlCOtgQIzc = colcavPlCOtgQIzc(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 4:
                    jVmDhRASoqklBNBVy = VmDhRASoqklBNBVy(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 5:
                    jBieZIGqHiYKwnDuz = bieZIGqHiYKwnDuz(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 6:
                    strABatwTlesrotfwxH = ABatwTlesrotfwxH(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 7:
                    strTvIhSCTtrddRvWDD = tvIhSCTtrddRvWDD(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 8:
                    iIebIjwfmqTiKYxeQ = iebIjwfmqTiKYxeQ(parcel, iJyHEQkLergKRHnqM);
                    break;
                case 9:
                    iAxyrCwiXmESGEkTU = AxyrCwiXmESGEkTU(parcel, iJyHEQkLergKRHnqM);
                    break;
                default:
                    cDfSmdnrGnpFQrMw(parcel, iJyHEQkLergKRHnqM);
                    break;
            }
        }
        tztbozmdVeWPFACc(parcel, iQEtRpSDagSSWvGUV);
        return new com.google.android.gms.common.internal.MethodInvocation(iEgUwtmMMaCkmSzVm, iQDJATleDkeBhrsgk, iColcavPlCOtgQIzc, jVmDhRASoqklBNBVy, jBieZIGqHiYKwnDuz, strABatwTlesrotfwxH, strTvIhSCTtrddRvWDD, iIebIjwfmqTiKYxeQ, iAxyrCwiXmESGEkTU);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.MethodInvocation[i];
    }
}

