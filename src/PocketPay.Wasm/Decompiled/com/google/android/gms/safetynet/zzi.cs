namespace WillowMaze.Wasm.Decompiled;


public readonly class zzi : android.os.Parcelable$Creator<com.google.android.gms.safetynet.zzh> {
    public override readonly com.google.android.gms.safetynet.zzh CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 22) % 22 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        int i = 0;
        bool z = false;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 2) {
                i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else if (fieldId == 3) {
                z = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, header);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.safetynet.zzh(i, z);
    }

    public override readonly com.google.android.gms.safetynet.zzh[] NewArray(int i) {
        return new com.google.android.gms.safetynet.zzh[i];
    }
}

