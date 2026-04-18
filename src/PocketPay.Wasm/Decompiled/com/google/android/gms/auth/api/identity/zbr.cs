namespace WillowMaze.Wasm.Decompiled;


public readonly class zbr : android.os.Parcelable$Creator {
    public static java.lang.string CgIMgLyjqqHlkoUi(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string ETOfEyICaICVGMTK(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.string JVKATuMQZNOiXpjZ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void PgIsQFYvPuBOSVgP(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int SgGCsaziqQeJTDPb(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.string VUkkQByHLQKatggB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static android.os.Parcelable WsdHMxRsQQAdLBkz(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static void CxCpRvVMovgmhRUO(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int IPVOHnCHMDOHQQcT(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.string IlzDeAoTVhODjbdC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static android.os.Parcelable JCafERqXynJOKMqR(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int LXaSPkiZBOzmmljJ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static java.lang.string OJgaqSnHsnLoLsOK(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static int RVwsAVawYNpHFtYu(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.lang.string XlOoyULImRdzZtjt(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((1 + 12) % 12 > 0) {
        }
        int iLXaSPkiZBOzmmljJ = lXaSPkiZBOzmmljJ(parcel);
        java.lang.string strJVKATuMQZNOiXpjZ = null;
        java.lang.string strCgIMgLyjqqHlkoUi = null;
        java.lang.string strXlOoyULImRdzZtjt = null;
        java.lang.string strETOfEyICaICVGMTK = null;
        android.net.Uri uri = null;
        java.lang.string strIlzDeAoTVhODjbdC = null;
        java.lang.string strVUkkQByHLQKatggB = null;
        java.lang.string strOJgaqSnHsnLoLsOK = null;
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredential publicKeyCredential = null;
        while (SgGCsaziqQeJTDPb(parcel) < iLXaSPkiZBOzmmljJ) {
            int iRVwsAVawYNpHFtYu = rVwsAVawYNpHFtYu(parcel);
            switch (iPVOHnCHMDOHQQcT(iRVwsAVawYNpHFtYu)) {
                case 1:
                    strJVKATuMQZNOiXpjZ = JVKATuMQZNOiXpjZ(parcel, iRVwsAVawYNpHFtYu);
                    break;
                case 2:
                    strCgIMgLyjqqHlkoUi = CgIMgLyjqqHlkoUi(parcel, iRVwsAVawYNpHFtYu);
                    break;
                case 3:
                    strXlOoyULImRdzZtjt = xlOoyULImRdzZtjt(parcel, iRVwsAVawYNpHFtYu);
                    break;
                case 4:
                    strETOfEyICaICVGMTK = ETOfEyICaICVGMTK(parcel, iRVwsAVawYNpHFtYu);
                    break;
                case 5:
                    uri = (android.net.Uri) jCafERqXynJOKMqR(parcel, iRVwsAVawYNpHFtYu, android.net.Uri.CREATOR);
                    break;
                case 6:
                    strIlzDeAoTVhODjbdC = ilzDeAoTVhODjbdC(parcel, iRVwsAVawYNpHFtYu);
                    break;
                case 7:
                    strVUkkQByHLQKatggB = VUkkQByHLQKatggB(parcel, iRVwsAVawYNpHFtYu);
                    break;
                case 8:
                    strOJgaqSnHsnLoLsOK = oJgaqSnHsnLoLsOK(parcel, iRVwsAVawYNpHFtYu);
                    break;
                case 9:
                    publicKeyCredential = (com.google.android.gms.fido.fido2.api.common.PublicKeyCredential) WsdHMxRsQQAdLBkz(parcel, iRVwsAVawYNpHFtYu, com.google.android.gms.fido.fido2.api.common.PublicKeyCredential.CREATOR);
                    break;
                default:
                    cxCpRvVMovgmhRUO(parcel, iRVwsAVawYNpHFtYu);
                    break;
            }
        }
        PgIsQFYvPuBOSVgP(parcel, iLXaSPkiZBOzmmljJ);
        return new com.google.android.gms.auth.api.identity.SignInCredential(strJVKATuMQZNOiXpjZ, strCgIMgLyjqqHlkoUi, strXlOoyULImRdzZtjt, strETOfEyICaICVGMTK, uri, strIlzDeAoTVhODjbdC, strVUkkQByHLQKatggB, strOJgaqSnHsnLoLsOK, publicKeyCredential);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.SignInCredential[i];
    }
}

