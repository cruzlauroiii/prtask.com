namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : android.os.Parcelable$Creator {
    public static byte[] AOpFemeWuWermeXL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createbyteArray(parcel, i);
    }

    public static android.os.Dictionary<string, object> DgZYgUUCOdVRNbax(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int HhdOzzHVCBQrjZLg(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int MKhcbgYaYodnKfwS(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void PTohbVWRhgKWsfiV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static android.os.Parcelable VBUUmLVXFSFhSWIT(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int VYNUWWFweoUeAPjc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int WEtGbqWphLIBruZi(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void ElEOTrIsuFSsGmXh(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int KGtsQfgXmEFiZqkr(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int RvYphOvQqfiGFYcI(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int UwxlkWAdsfJHePtx(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((27 + 4) % 4 > 0) {
        }
        int iRvYphOvQqfiGFYcI = rvYphOvQqfiGFYcI(parcel);
        android.app.Pendingobject pendingobject = null;
        android.os.Dictionary<string, object> bundleDgZYgUUCOdVRNbax = null;
        byte[] bArrAOpFemeWuWermeXL = null;
        int iUwxlkWAdsfJHePtx = 0;
        int iHhdOzzHVCBQrjZLg = 0;
        int iWEtGbqWphLIBruZi = 0;
        while (MKhcbgYaYodnKfwS(parcel) < iRvYphOvQqfiGFYcI) {
            int iVYNUWWFweoUeAPjc = VYNUWWFweoUeAPjc(parcel);
            int iKGtsQfgXmEFiZqkr = kGtsQfgXmEFiZqkr(iVYNUWWFweoUeAPjc);
            if (iKGtsQfgXmEFiZqkr == 1) {
                iHhdOzzHVCBQrjZLg = HhdOzzHVCBQrjZLg(parcel, iVYNUWWFweoUeAPjc);
            } else if (iKGtsQfgXmEFiZqkr == 2) {
                pendingobject = (android.app.Pendingobject) VBUUmLVXFSFhSWIT(parcel, iVYNUWWFweoUeAPjc, android.app.Pendingobject.CREATOR);
            } else if (iKGtsQfgXmEFiZqkr == 3) {
                iWEtGbqWphLIBruZi = WEtGbqWphLIBruZi(parcel, iVYNUWWFweoUeAPjc);
            } else if (iKGtsQfgXmEFiZqkr == 4) {
                bundleDgZYgUUCOdVRNbax = DgZYgUUCOdVRNbax(parcel, iVYNUWWFweoUeAPjc);
            } else if (iKGtsQfgXmEFiZqkr == 5) {
                bArrAOpFemeWuWermeXL = AOpFemeWuWermeXL(parcel, iVYNUWWFweoUeAPjc);
            } else if (iKGtsQfgXmEFiZqkr == 1000) {
                iUwxlkWAdsfJHePtx = uwxlkWAdsfJHePtx(parcel, iVYNUWWFweoUeAPjc);
            } else {
                PTohbVWRhgKWsfiV(parcel, iVYNUWWFweoUeAPjc);
            }
        }
        elEOTrIsuFSsGmXh(parcel, iRvYphOvQqfiGFYcI);
        return new com.google.android.gms.auth.api.proxy.ProxyResponse(iUwxlkWAdsfJHePtx, iHhdOzzHVCBQrjZLg, pendingobject, iWEtGbqWphLIBruZi, bundleDgZYgUUCOdVRNbax, bArrAOpFemeWuWermeXL);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.proxy.ProxyResponse[i];
    }
}

