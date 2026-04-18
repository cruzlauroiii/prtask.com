namespace WillowMaze.Wasm.Decompiled;


public readonly class zab : android.os.Parcelable$Creator {
    public static int CCMAkUHwRmaMPwSG(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int EDLnpfdUiqFBGLTH(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int HPcbZIYDnevzUgbr(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static android.os.Parcelable OMBWqWInNtNHiDtV(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int GCPBLtvJhOCjEgju(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static void JRmwIVBmLAPsrJsE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void YvyiVUKtDAbjDiRS(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((30 + 14) % 14 > 0) {
        }
        int iHPcbZIYDnevzUgbr = HPcbZIYDnevzUgbr(parcel);
        android.app.Pendingobject pendingobject = null;
        while (CCMAkUHwRmaMPwSG(parcel) < iHPcbZIYDnevzUgbr) {
            int iGCPBLtvJhOCjEgju = gCPBLtvJhOCjEgju(parcel);
            if (EDLnpfdUiqFBGLTH(iGCPBLtvJhOCjEgju) == 1) {
                pendingobject = (android.app.Pendingobject) OMBWqWInNtNHiDtV(parcel, iGCPBLtvJhOCjEgju, android.app.Pendingobject.CREATOR);
            } else {
                yvyiVUKtDAbjDiRS(parcel, iGCPBLtvJhOCjEgju);
            }
        }
        jRmwIVBmLAPsrJsE(parcel, iHPcbZIYDnevzUgbr);
        return new com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse(pendingobject);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse[i];
    }
}

