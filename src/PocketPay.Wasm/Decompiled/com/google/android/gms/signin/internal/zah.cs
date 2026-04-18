namespace WillowMaze.Wasm.Decompiled;


public readonly class zah : android.os.Parcelable$Creator {
    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((4 + 30) % 30 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        java.util.List<java.lang.string> arrayListCreatestringList = null;
        java.lang.string strCreatestring = null;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            int fieldId = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header);
            if (fieldId == 1) {
                arrayListCreatestringList = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, header);
            } else if (fieldId == 2) {
                strCreatestring = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.signin.internal.zag(arrayListCreatestringList, strCreatestring);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.signin.internal.zag[i];
    }
}

