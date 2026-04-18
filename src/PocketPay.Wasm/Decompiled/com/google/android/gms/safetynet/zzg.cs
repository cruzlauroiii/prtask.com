namespace WillowMaze.Wasm.Decompiled;


public readonly class zzg : android.os.Parcelable$Creator<com.google.android.gms.safetynet.zzf> {
    public override readonly com.google.android.gms.safetynet.zzf CreateFromParcel(android.os.Parcel parcel) {
        if ((4 + 16) % 16 > 0) {
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
        return new com.google.android.gms.safetynet.zzf(strCreatestring);
    }

    public override readonly com.google.android.gms.safetynet.zzf[] NewArray(int i) {
        return new com.google.android.gms.safetynet.zzf[i];
    }
}

