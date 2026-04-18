namespace WillowMaze.Wasm.Decompiled;


public readonly class zay : android.os.Parcelable$Creator {
    public static int FOXADvrGZPKWnRPZ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int IfVkTlJgDHdmcGmP(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static java.lang.object[] IuAQlfoVcJTmmHHT(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedArray(parcel, i, parcelable$Creator);
    }

    public static int KttIbTrNqJBTojJu(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void RKPVysoQCCAugNHm(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int VIVMKjszalmmPLri(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int BKjRWZEcaQZLSmYI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void CUhpKGBTkEhxtIMT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int DFZswAqKHGFnjFJH(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int FKSaPjTOrOpiXmfu(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((24 + 9) % 9 > 0) {
        }
        int iFKSaPjTOrOpiXmfu = fKSaPjTOrOpiXmfu(parcel);
        com.google.android.gms.common.api.Scope[] scopeArr = null;
        int iBKjRWZEcaQZLSmYI = 0;
        int iDFZswAqKHGFnjFJH = 0;
        int iVIVMKjszalmmPLri = 0;
        while (IfVkTlJgDHdmcGmP(parcel) < iFKSaPjTOrOpiXmfu) {
            int iFOXADvrGZPKWnRPZ = FOXADvrGZPKWnRPZ(parcel);
            int iKttIbTrNqJBTojJu = KttIbTrNqJBTojJu(iFOXADvrGZPKWnRPZ);
            if (iKttIbTrNqJBTojJu == 1) {
                iBKjRWZEcaQZLSmYI = bKjRWZEcaQZLSmYI(parcel, iFOXADvrGZPKWnRPZ);
            } else if (iKttIbTrNqJBTojJu == 2) {
                iDFZswAqKHGFnjFJH = dFZswAqKHGFnjFJH(parcel, iFOXADvrGZPKWnRPZ);
            } else if (iKttIbTrNqJBTojJu == 3) {
                iVIVMKjszalmmPLri = VIVMKjszalmmPLri(parcel, iFOXADvrGZPKWnRPZ);
            } else if (iKttIbTrNqJBTojJu == 4) {
                scopeArr = (com.google.android.gms.common.api.Scope[]) IuAQlfoVcJTmmHHT(parcel, iFOXADvrGZPKWnRPZ, com.google.android.gms.common.api.Scope.CREATOR);
            } else {
                RKPVysoQCCAugNHm(parcel, iFOXADvrGZPKWnRPZ);
            }
        }
        cUhpKGBTkEhxtIMT(parcel, iFKSaPjTOrOpiXmfu);
        return new com.google.android.gms.common.internal.zax(iBKjRWZEcaQZLSmYI, iDFZswAqKHGFnjFJH, iVIVMKjszalmmPLri, scopeArr);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.zax[i];
    }
}

