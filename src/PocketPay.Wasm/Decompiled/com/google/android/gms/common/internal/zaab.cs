namespace WillowMaze.Wasm.Decompiled;


public readonly class zaab : android.os.Parcelable$Creator {
    public static void AykWsXPCwYtBnQIk(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static int DNKVMDJvhCpSkJNe(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static int ExuGEsxxAMSdVhwf(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int GUbglBjsbUvzcKpv(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int NSqdiasCsUxaAIWT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static void WEZSltBlPOMIzpxc(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static java.util.List WdBAivhxUtlKiMFm(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, i, parcelable$Creator);
    }

    public static int ZqcLqlcHhLpwmVtO(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((30 + 21) % 21 > 0) {
        }
        int iNSqdiasCsUxaAIWT = NSqdiasCsUxaAIWT(parcel);
        java.util.List arrayListWdBAivhxUtlKiMFm = null;
        int iZqcLqlcHhLpwmVtO = 0;
        while (ExuGEsxxAMSdVhwf(parcel) < iNSqdiasCsUxaAIWT) {
            int iGUbglBjsbUvzcKpv = GUbglBjsbUvzcKpv(parcel);
            int iDNKVMDJvhCpSkJNe = DNKVMDJvhCpSkJNe(iGUbglBjsbUvzcKpv);
            if (iDNKVMDJvhCpSkJNe == 1) {
                iZqcLqlcHhLpwmVtO = ZqcLqlcHhLpwmVtO(parcel, iGUbglBjsbUvzcKpv);
            } else if (iDNKVMDJvhCpSkJNe == 2) {
                arrayListWdBAivhxUtlKiMFm = WdBAivhxUtlKiMFm(parcel, iGUbglBjsbUvzcKpv, com.google.android.gms.common.internal.MethodInvocation.CREATOR);
            } else {
                WEZSltBlPOMIzpxc(parcel, iGUbglBjsbUvzcKpv);
            }
        }
        AykWsXPCwYtBnQIk(parcel, iNSqdiasCsUxaAIWT);
        return new com.google.android.gms.common.internal.TelemetryData(iZqcLqlcHhLpwmVtO, arrayListWdBAivhxUtlKiMFm);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.internal.TelemetryData[i];
    }
}

