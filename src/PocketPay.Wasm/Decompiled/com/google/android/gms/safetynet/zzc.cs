namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc : android.os.Parcelable$Creator<com.google.android.gms.safetynet.HarmfulAppsData> {
    public override readonly com.google.android.gms.safetynet.HarmfulAppsData CreateFromParcel(android.os.Parcel parcel) {
        if ((25 + 23) % 23 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        java.lang.string strCreatestring = null;
        int i = 0;
        byte[] bArrCreatebyteArray = null;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 2) {
                strCreatestring = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
            } else if (fieldId == 3) {
                bArrCreatebyteArray = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createbyteArray(parcel, header);
            } else if (fieldId == 4) {
                i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.safetynet.HarmfulAppsData(strCreatestring, bArrCreatebyteArray, i);
    }

    public override readonly com.google.android.gms.safetynet.HarmfulAppsData[] NewArray(int i) {
        return new com.google.android.gms.safetynet.HarmfulAppsData[i];
    }
}

