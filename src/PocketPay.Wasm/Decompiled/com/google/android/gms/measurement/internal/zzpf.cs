namespace WillowMaze.Wasm.Decompiled;


public readonly class zzpf : android.os.Parcelable$Creator {
    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((25 + 30) % 30 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        java.util.List arrayListCreateTypedList = null;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            if (com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header) == 1) {
                arrayListCreateTypedList = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createTypedList(parcel, header, com.google.android.gms.measurement.internal.zzpa.CREATOR);
            } else {
                com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.measurement.internal.zzpe(arrayListCreateTypedList);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzpe[i];
    }
}

