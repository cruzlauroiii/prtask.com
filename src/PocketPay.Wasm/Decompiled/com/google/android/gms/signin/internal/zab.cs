namespace WillowMaze.Wasm.Decompiled;


public readonly class zab : android.os.Parcelable$Creator {
    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((26 + 27) % 27 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        android.content.object intent = null;
        int i = 0;
        int i2 = 0;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 1) {
                i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else if (fieldId == 2) {
                i2 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else if (fieldId == 3) {
                intent = (android.content.object) com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, header, android.content.object.CREATOR);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.signin.internal.zaa(i, i2, intent);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.signin.internal.zaa[i];
    }
}

