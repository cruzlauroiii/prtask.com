namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : android.os.Parcelable$Creator {
    public static android.os.Dictionary<string, object> NTCMxJUuvifZhJDM(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static int TBGXorBNwwamHALL(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int WDukcSUoMGkBXLIA(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void XcRpcRtVjlhCUdHF(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void YQbxkcVCvONOpUsn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int HLCJMCodfXlQZxwg(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int MqCYFiJfUvNZUmvg(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int UFvSWOZHCqUsGiFT(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int ZuLKCznrJMDWrsPu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((20 + 7) % 7 > 0) {
        }
        int iWDukcSUoMGkBXLIA = WDukcSUoMGkBXLIA(parcel);
        android.os.Dictionary<string, object> bundleNTCMxJUuvifZhJDM = null;
        int iHLCJMCodfXlQZxwg = 0;
        int iZuLKCznrJMDWrsPu = 0;
        while (mqCYFiJfUvNZUmvg(parcel) < iWDukcSUoMGkBXLIA) {
            int iTBGXorBNwwamHALL = TBGXorBNwwamHALL(parcel);
            int iUFvSWOZHCqUsGiFT = uFvSWOZHCqUsGiFT(iTBGXorBNwwamHALL);
            if (iUFvSWOZHCqUsGiFT == 1) {
                iHLCJMCodfXlQZxwg = hLCJMCodfXlQZxwg(parcel, iTBGXorBNwwamHALL);
            } else if (iUFvSWOZHCqUsGiFT == 2) {
                iZuLKCznrJMDWrsPu = zuLKCznrJMDWrsPu(parcel, iTBGXorBNwwamHALL);
            } else if (iUFvSWOZHCqUsGiFT == 3) {
                bundleNTCMxJUuvifZhJDM = NTCMxJUuvifZhJDM(parcel, iTBGXorBNwwamHALL);
            } else {
                YQbxkcVCvONOpUsn(parcel, iTBGXorBNwwamHALL);
            }
        }
        XcRpcRtVjlhCUdHF(parcel, iWDukcSUoMGkBXLIA);
        return new com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable(iHLCJMCodfXlQZxwg, iZuLKCznrJMDWrsPu, bundleNTCMxJUuvifZhJDM);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.signin.internal.GoogleSignInOptionsExtensionParcelable[i];
    }
}

