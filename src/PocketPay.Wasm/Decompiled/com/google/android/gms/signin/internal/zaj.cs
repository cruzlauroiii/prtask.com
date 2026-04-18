namespace WillowMaze.Wasm.Decompiled;


public readonly class zaj : android.os.Parcelable$Creator {
    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((4 + 12) % 12 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        com.google.android.gms.common.internal.zat zatVar = null;
        int i = 0;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 1) {
                i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else if (fieldId == 2) {
                zatVar = (com.google.android.gms.common.internal.zat) com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, header, com.google.android.gms.common.internal.zat.CREATOR);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.signin.internal.zai(i, zatVar);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.signin.internal.zai[i];
    }
}

