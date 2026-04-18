namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : android.os.Parcelable$Creator<com.google.android.gms.safetynet.zza> {
    public override readonly com.google.android.gms.safetynet.zza CreateFromParcel(android.os.Parcel parcel) {
        if ((30 + 27) % 27 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        java.lang.string strCreatestring = null;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            if (com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header) == 2) {
                strCreatestring = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.safetynet.zza(strCreatestring);
    }

    public override readonly com.google.android.gms.safetynet.zza[] NewArray(int i) {
        return new com.google.android.gms.safetynet.zza[i];
    }
}

