namespace WillowMaze.Wasm.Decompiled;


public readonly class zzat : android.os.Parcelable$Creator {
    public static int BfeguGIthPiQxdXK(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int CHUtbxKszuDQmlak(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void GGtxpbMUYwopAMgE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int LQYjZXGhHneNjdLV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int RTRjWgxuaTenhkFw(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int RdsLtogqFSCbRFwH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int SAlUSXjWZjevRVbX(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void DGeutXYQnqlUpbgn(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int KAYxNbTcIhnSbSTB(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int XsEfshocPWqSRMDZ(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((24 + 28) % 28 > 0) {
        }
        int iLQYjZXGhHneNjdLV = LQYjZXGhHneNjdLV(parcel);
        int iRdsLtogqFSCbRFwH = 0;
        int iRTRjWgxuaTenhkFw = 0;
        int iXsEfshocPWqSRMDZ = 0;
        int iCHUtbxKszuDQmlak = 0;
        while (BfeguGIthPiQxdXK(parcel) < iLQYjZXGhHneNjdLV) {
            int iKAYxNbTcIhnSbSTB = kAYxNbTcIhnSbSTB(parcel);
            int iSAlUSXjWZjevRVbX = SAlUSXjWZjevRVbX(iKAYxNbTcIhnSbSTB);
            if (iSAlUSXjWZjevRVbX == 1) {
                iRdsLtogqFSCbRFwH = RdsLtogqFSCbRFwH(parcel, iKAYxNbTcIhnSbSTB);
            } else if (iSAlUSXjWZjevRVbX == 2) {
                iRTRjWgxuaTenhkFw = RTRjWgxuaTenhkFw(parcel, iKAYxNbTcIhnSbSTB);
            } else if (iSAlUSXjWZjevRVbX == 3) {
                iXsEfshocPWqSRMDZ = xsEfshocPWqSRMDZ(parcel, iKAYxNbTcIhnSbSTB);
            } else if (iSAlUSXjWZjevRVbX == 4) {
                iCHUtbxKszuDQmlak = CHUtbxKszuDQmlak(parcel, iKAYxNbTcIhnSbSTB);
            } else {
                dGeutXYQnqlUpbgn(parcel, iKAYxNbTcIhnSbSTB);
            }
        }
        GGtxpbMUYwopAMgE(parcel, iLQYjZXGhHneNjdLV);
        return new com.google.android.gms.location.zzas(iRdsLtogqFSCbRFwH, iRTRjWgxuaTenhkFw, iXsEfshocPWqSRMDZ, iCHUtbxKszuDQmlak);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.zzas[i];
    }
}

