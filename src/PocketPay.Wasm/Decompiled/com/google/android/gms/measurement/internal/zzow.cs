namespace WillowMaze.Wasm.Decompiled;


public readonly class zzow : android.os.Parcelable$Creator {
    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((7 + 30) % 30 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        int i = 0;
        long j = 0;
        java.lang.string strCreatestring = null;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 1) {
                strCreatestring = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
            } else if (fieldId == 2) {
                j = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
            } else if (fieldId == 3) {
                i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.measurement.internal.zzov(strCreatestring, j, i);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzov[i];
    }
}

