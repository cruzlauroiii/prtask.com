namespace WillowMaze.Wasm.Decompiled;


public readonly class zzao : android.os.Parcelable$Creator {
    public static bool BrInFLZwzTzaFElM(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int KYVKdxNFRLMEfleu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int UXVCvYetQMuNVffB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int WFdHnqatTzApwKzp(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int YjVUcvcgeJmaezZC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void ZPEzmkemqaQYVMLm(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int FRVkhAqXsyhzIplM(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int GCoFEkyXduKAZbIa(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void IMSWjkIDIErGNxAe(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KpkpZgMYKZwLYWVr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int PVopGusWqyPtCjUE(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int QUxjcSSBPokzMxid(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int StUsOZVRqXCpnQoA(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int UVDLiarDVUnrQcxc(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int WWnFzYczIkQOYlTF(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((18 + 15) % 15 > 0) {
        }
        int iQUxjcSSBPokzMxid = qUxjcSSBPokzMxid(parcel);
        int iUXVCvYetQMuNVffB = 0;
        int iYjVUcvcgeJmaezZC = 0;
        int iKpkpZgMYKZwLYWVr = 0;
        int iWFdHnqatTzApwKzp = 0;
        int iUVDLiarDVUnrQcxc = 0;
        int iStUsOZVRqXCpnQoA = 0;
        int iWWnFzYczIkQOYlTF = 0;
        bool zBrInFLZwzTzaFElM = false;
        int iKYVKdxNFRLMEfleu = 0;
        while (pVopGusWqyPtCjUE(parcel) < iQUxjcSSBPokzMxid) {
            int iGCoFEkyXduKAZbIa = gCoFEkyXduKAZbIa(parcel);
            switch (fRVkhAqXsyhzIplM(iGCoFEkyXduKAZbIa)) {
                case 1:
                    iUXVCvYetQMuNVffB = UXVCvYetQMuNVffB(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 2:
                    iYjVUcvcgeJmaezZC = YjVUcvcgeJmaezZC(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 3:
                    iKpkpZgMYKZwLYWVr = kpkpZgMYKZwLYWVr(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 4:
                    iWFdHnqatTzApwKzp = WFdHnqatTzApwKzp(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 5:
                    iUVDLiarDVUnrQcxc = uVDLiarDVUnrQcxc(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 6:
                    iStUsOZVRqXCpnQoA = stUsOZVRqXCpnQoA(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 7:
                    iWWnFzYczIkQOYlTF = wWnFzYczIkQOYlTF(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 8:
                    zBrInFLZwzTzaFElM = BrInFLZwzTzaFElM(parcel, iGCoFEkyXduKAZbIa);
                    break;
                case 9:
                    iKYVKdxNFRLMEfleu = KYVKdxNFRLMEfleu(parcel, iGCoFEkyXduKAZbIa);
                    break;
                default:
                    ZPEzmkemqaQYVMLm(parcel, iGCoFEkyXduKAZbIa);
                    break;
            }
        }
        iMSWjkIDIErGNxAe(parcel, iQUxjcSSBPokzMxid);
        return new com.google.android.gms.location.SleepClassifyEvent(iUXVCvYetQMuNVffB, iYjVUcvcgeJmaezZC, iKpkpZgMYKZwLYWVr, iWFdHnqatTzApwKzp, iUVDLiarDVUnrQcxc, iStUsOZVRqXCpnQoA, iWWnFzYczIkQOYlTF, zBrInFLZwzTzaFElM, iKYVKdxNFRLMEfleu);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.SleepClassifyEvent[i];
    }
}

