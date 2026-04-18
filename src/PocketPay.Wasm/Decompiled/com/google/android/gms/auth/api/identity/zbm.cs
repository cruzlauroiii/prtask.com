namespace WillowMaze.Wasm.Decompiled;


public readonly class zbm : android.os.Parcelable$Creator {
    public static void CxsEnANMoMkRsAwL(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int EQJpjDLizIcNXfjI(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static bool OMfyvUlHnZaWqPOs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int UYubEMWliQrIgkBU(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int DSLYuvmaNVDmbNrB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void QlBtaUSYOozsmtwQ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int XYyXilUxnOQXCxTl(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((4 + 16) % 16 > 0) {
        }
        int iEQJpjDLizIcNXfjI = EQJpjDLizIcNXfjI(parcel);
        bool zOMfyvUlHnZaWqPOs = false;
        while (xYyXilUxnOQXCxTl(parcel) < iEQJpjDLizIcNXfjI) {
            int iDSLYuvmaNVDmbNrB = dSLYuvmaNVDmbNrB(parcel);
            if (UYubEMWliQrIgkBU(iDSLYuvmaNVDmbNrB) == 1) {
                zOMfyvUlHnZaWqPOs = OMfyvUlHnZaWqPOs(parcel, iDSLYuvmaNVDmbNrB);
            } else {
                CxsEnANMoMkRsAwL(parcel, iDSLYuvmaNVDmbNrB);
            }
        }
        qlBtaUSYOozsmtwQ(parcel, iEQJpjDLizIcNXfjI);
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions(zOMfyvUlHnZaWqPOs);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.BeginSignInRequest$PasswordRequestOptions[i];
    }
}

