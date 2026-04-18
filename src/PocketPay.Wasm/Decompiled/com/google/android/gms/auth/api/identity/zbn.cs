namespace WillowMaze.Wasm.Decompiled;


public readonly class zbn : android.os.Parcelable$Creator {
    public static int CvyYjAbVljLAnuTN(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int EEkQqOWvHrTdpOAe(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int FgBSVaIZOahiUWVM(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string JBjhQzEsNIJphRZC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void NRTuDDbQKVcmkTEu(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.lang.string SjUazOeEcwaBDGzR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void UHsGNioXgwTNwwrR(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int CnzOCbUXiuQTqiYb(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static android.os.Parcelable DMvFoCKutNuZIWUY(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int JRBMqOMyNbEFhYcO(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.util.List VMbCGexVgibqqNRl(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, i);
    }

    public static java.lang.string XbCQCvlLysuGPotE(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((17 + 22) % 22 > 0) {
        }
        int iCvyYjAbVljLAnuTN = CvyYjAbVljLAnuTN(parcel);
        int iJRBMqOMyNbEFhYcO = 0;
        android.app.Pendingobject pendingobject = null;
        java.lang.string strSjUazOeEcwaBDGzR = null;
        java.lang.string strJBjhQzEsNIJphRZC = null;
        java.util.List arrayListVMbCGexVgibqqNRl = null;
        java.lang.string strXbCQCvlLysuGPotE = null;
        while (cnzOCbUXiuQTqiYb(parcel) < iCvyYjAbVljLAnuTN) {
            int iEEkQqOWvHrTdpOAe = EEkQqOWvHrTdpOAe(parcel);
            switch (FgBSVaIZOahiUWVM(iEEkQqOWvHrTdpOAe)) {
                case 1:
                    pendingobject = (android.app.Pendingobject) dMvFoCKutNuZIWUY(parcel, iEEkQqOWvHrTdpOAe, android.app.Pendingobject.CREATOR);
                    break;
                case 2:
                    strSjUazOeEcwaBDGzR = SjUazOeEcwaBDGzR(parcel, iEEkQqOWvHrTdpOAe);
                    break;
                case 3:
                    strJBjhQzEsNIJphRZC = JBjhQzEsNIJphRZC(parcel, iEEkQqOWvHrTdpOAe);
                    break;
                case 4:
                    arrayListVMbCGexVgibqqNRl = vMbCGexVgibqqNRl(parcel, iEEkQqOWvHrTdpOAe);
                    break;
                case 5:
                    strXbCQCvlLysuGPotE = xbCQCvlLysuGPotE(parcel, iEEkQqOWvHrTdpOAe);
                    break;
                case 6:
                    iJRBMqOMyNbEFhYcO = jRBMqOMyNbEFhYcO(parcel, iEEkQqOWvHrTdpOAe);
                    break;
                default:
                    NRTuDDbQKVcmkTEu(parcel, iEEkQqOWvHrTdpOAe);
                    break;
            }
        }
        UHsGNioXgwTNwwrR(parcel, iCvyYjAbVljLAnuTN);
        return new com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest(pendingobject, strSjUazOeEcwaBDGzR, strJBjhQzEsNIJphRZC, arrayListVMbCGexVgibqqNRl, strXbCQCvlLysuGPotE, iJRBMqOMyNbEFhYcO);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenRequest[i];
    }
}

