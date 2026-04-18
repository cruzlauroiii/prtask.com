namespace WillowMaze.Wasm.Decompiled;


public readonly class zal : android.os.Parcelable$Creator {
    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((6 + 29) % 29 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        com.google.android.gms.common.ConnectionResult connectionResult = null;
        int i = 0;
        com.google.android.gms.common.internal.zav zavVar = null;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 1) {
                i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
            } else if (fieldId == 2) {
                connectionResult = (com.google.android.gms.common.ConnectionResult) com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, header, com.google.android.gms.common.ConnectionResult.CREATOR);
            } else if (fieldId == 3) {
                zavVar = (com.google.android.gms.common.internal.zav) com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, header, com.google.android.gms.common.internal.zav.CREATOR);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.signin.internal.zak(i, connectionResult, zavVar);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.signin.internal.zak[i];
    }
}

