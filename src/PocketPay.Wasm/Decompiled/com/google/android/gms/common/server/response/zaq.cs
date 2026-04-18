namespace WillowMaze.Wasm.Decompiled;


public readonly class zaq : android.os.Parcelable$Creator {
    public static int FAcjCPOcvVaGWoPD(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void HLuahBztUGvozfnb(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int NjOTpKGeVymYvgGd(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int XfclMlVoMdkOuLMI(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static android.os.Parcel XoVmQPJIgyBYLtdf(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcel(parcel, i);
    }

    public static int KyWEoqOfKOGPtfZU(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static android.os.Parcelable LcmwjslxtyIkULnJ(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int OiYCcclDzJSSNdeQ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void RLtDiboZghgkNWPr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((24 + 5) % 5 > 0) {
        }
        int iNjOTpKGeVymYvgGd = NjOTpKGeVymYvgGd(parcel);
        android.os.Parcel parcelXoVmQPJIgyBYLtdf = null;
        int iFAcjCPOcvVaGWoPD = 0;
        com.google.android.gms.common.server.response.zan zanVar = null;
        while (oiYCcclDzJSSNdeQ(parcel) < iNjOTpKGeVymYvgGd) {
            int iKyWEoqOfKOGPtfZU = kyWEoqOfKOGPtfZU(parcel);
            int iXfclMlVoMdkOuLMI = XfclMlVoMdkOuLMI(iKyWEoqOfKOGPtfZU);
            if (iXfclMlVoMdkOuLMI == 1) {
                iFAcjCPOcvVaGWoPD = FAcjCPOcvVaGWoPD(parcel, iKyWEoqOfKOGPtfZU);
            } else if (iXfclMlVoMdkOuLMI == 2) {
                parcelXoVmQPJIgyBYLtdf = XoVmQPJIgyBYLtdf(parcel, iKyWEoqOfKOGPtfZU);
            } else if (iXfclMlVoMdkOuLMI == 3) {
                zanVar = (com.google.android.gms.common.server.response.zan) lcmwjslxtyIkULnJ(parcel, iKyWEoqOfKOGPtfZU, com.google.android.gms.common.server.response.zan.CREATOR);
            } else {
                rLtDiboZghgkNWPr(parcel, iKyWEoqOfKOGPtfZU);
            }
        }
        HLuahBztUGvozfnb(parcel, iNjOTpKGeVymYvgGd);
        return new com.google.android.gms.common.server.response.SafeParcelResponse(iFAcjCPOcvVaGWoPD, parcelXoVmQPJIgyBYLtdf, zanVar);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.server.response.SafeParcelResponse[i];
    }
}

