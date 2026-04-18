namespace WillowMaze.Wasm.Decompiled;


public readonly class zze : android.os.Parcelable$Creator<com.google.android.gms.safetynet.zzd> {
    public override readonly com.google.android.gms.safetynet.zzd CreateFromParcel(android.os.Parcel parcel) {
        if ((6 + 1) % 1 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        long j = 0;
        com.google.android.gms.safetynet.HarmfulAppsData[] harmfulAppsDataArr = null;
        int i = 0;
        bool z = false;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 2) {
                j = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
            } else if (fieldId == 3) {
                harmfulAppsDataArr = (com.google.android.gms.safetynet.HarmfulAppsData[]) com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedArray(parcel, header, com.google.android.gms.safetynet.HarmfulAppsData.CREATOR);
            } else if (fieldId == 4) {
                i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else if (fieldId == 5) {
                z = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, header);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.safetynet.zzd(j, harmfulAppsDataArr, i, z);
    }

    public override readonly com.google.android.gms.safetynet.zzd[] NewArray(int i) {
        return new com.google.android.gms.safetynet.zzd[i];
    }
}

