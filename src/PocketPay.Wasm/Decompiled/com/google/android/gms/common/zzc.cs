namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : android.os.Parcelable$Creator {
    public static void FQjaRKtiMaUnaVxa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable TdysLDKbZqnhcESe(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int YmTLopcHySCUQGpQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int YqoyGUOSPngEKaWl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int GxSNBpRPNLPfQFxW(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int IFJwHdIQgIfoKdli(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void MiNGDZKwisijeDhT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static java.lang.string NaqCRKYUAeRQzYLq(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int RAfJSlGWzNSTjEMD(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int RFjpffSyEoBLIzEd(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((22 + 18) % 18 > 0) {
        }
        int iIFJwHdIQgIfoKdli = iFJwHdIQgIfoKdli(parcel);
        android.app.Pendingobject pendingobject = null;
        int iRFjpffSyEoBLIzEd = 0;
        int iYqoyGUOSPngEKaWl = 0;
        java.lang.string strNaqCRKYUAeRQzYLq = null;
        while (gxSNBpRPNLPfQFxW(parcel) < iIFJwHdIQgIfoKdli) {
            int iYmTLopcHySCUQGpQ = YmTLopcHySCUQGpQ(parcel);
            int iRAfJSlGWzNSTjEMD = rAfJSlGWzNSTjEMD(iYmTLopcHySCUQGpQ);
            if (iRAfJSlGWzNSTjEMD == 1) {
                iRFjpffSyEoBLIzEd = rFjpffSyEoBLIzEd(parcel, iYmTLopcHySCUQGpQ);
            } else if (iRAfJSlGWzNSTjEMD == 2) {
                iYqoyGUOSPngEKaWl = YqoyGUOSPngEKaWl(parcel, iYmTLopcHySCUQGpQ);
            } else if (iRAfJSlGWzNSTjEMD == 3) {
                pendingobject = (android.app.Pendingobject) TdysLDKbZqnhcESe(parcel, iYmTLopcHySCUQGpQ, android.app.Pendingobject.CREATOR);
            } else if (iRAfJSlGWzNSTjEMD == 4) {
                strNaqCRKYUAeRQzYLq = naqCRKYUAeRQzYLq(parcel, iYmTLopcHySCUQGpQ);
            } else {
                FQjaRKtiMaUnaVxa(parcel, iYmTLopcHySCUQGpQ);
            }
        }
        miNGDZKwisijeDhT(parcel, iIFJwHdIQgIfoKdli);
        return new com.google.android.gms.common.ConnectionResult(iRFjpffSyEoBLIzEd, iYqoyGUOSPngEKaWl, pendingobject, strNaqCRKYUAeRQzYLq);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.ConnectionResult[i];
    }
}

