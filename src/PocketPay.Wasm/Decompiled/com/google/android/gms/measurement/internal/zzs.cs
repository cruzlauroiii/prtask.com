namespace WillowMaze.Wasm.Decompiled;


public readonly class zzs : android.os.Parcelable$Creator {
    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((1 + 16) % 16 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        bool z = false;
        int i = 0;
        bool z2 = false;
        bool z3 = false;
        int i2 = 0;
        int i3 = 0;
        long j = 0;
        long j2 = 0;
        long j3 = 0;
        long j4 = 0;
        long j5 = 0;
        long j6 = 0;
        long j7 = 0;
        java.lang.string strCreatestring = "";
        java.lang.string strCreatestring2 = strCreatestring;
        java.lang.string strCreatestring3 = strCreatestring2;
        java.lang.string strCreatestring4 = strCreatestring3;
        java.lang.string strCreatestring5 = null;
        java.lang.string strCreatestring6 = null;
        java.lang.string strCreatestring7 = null;
        java.lang.string strCreatestring8 = null;
        java.lang.string strCreatestring9 = null;
        java.lang.string strCreatestring10 = null;
        java.lang.string strCreatestring11 = null;
        java.lang.bool boolobject = null;
        java.util.List<java.lang.string> arrayListCreatestringList = null;
        java.lang.string strCreatestring12 = null;
        java.lang.string strCreatestring13 = null;
        java.lang.string strCreatestring14 = null;
        int i4 = 100;
        bool z4 = true;
        bool z5 = true;
        long j8 = -2147483648L;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            switch (com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header)) {
                case 2:
                    strCreatestring5 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 3:
                    strCreatestring6 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 4:
                    strCreatestring7 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 5:
                    strCreatestring8 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 6:
                    j = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 7:
                    j2 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 8:
                    strCreatestring9 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 9:
                    z4 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, header);
                    break;
                case 10:
                    z = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, header);
                    break;
                case 11:
                    j8 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 12:
                    strCreatestring10 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 13:
                case 17:
                case 20:
                case 33:
                default:
                    com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
                    break;
                case 14:
                    j3 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 15:
                    i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
                    break;
                case 16:
                    z5 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, header);
                    break;
                case 18:
                    z2 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, header);
                    break;
                case 19:
                    strCreatestring11 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 21:
                    boolobject = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readboolobject(parcel, header);
                    break;
                case 22:
                    j4 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 23:
                    arrayListCreatestringList = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringList(parcel, header);
                    break;
                case 24:
                    strCreatestring12 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 25:
                    strCreatestring = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 26:
                    strCreatestring2 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 27:
                    strCreatestring13 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 28:
                    z3 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, header);
                    break;
                case 29:
                    j5 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 30:
                    i4 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
                    break;
                case 31:
                    strCreatestring3 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 32:
                    i2 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
                    break;
                case 34:
                    j6 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 35:
                    strCreatestring14 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 36:
                    strCreatestring4 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 37:
                    j7 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 38:
                    i3 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
                    break;
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.measurement.internal.zzr(strCreatestring5, strCreatestring6, strCreatestring7, strCreatestring8, j, j2, strCreatestring9, z4, z, j8, strCreatestring10, j3, i, z5, z2, strCreatestring11, boolobject, j4, arrayListCreatestringList, strCreatestring12, strCreatestring, strCreatestring2, strCreatestring13, z3, j5, i4, strCreatestring3, i2, j6, strCreatestring14, strCreatestring4, j7, i3);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzr[i];
    }
}

