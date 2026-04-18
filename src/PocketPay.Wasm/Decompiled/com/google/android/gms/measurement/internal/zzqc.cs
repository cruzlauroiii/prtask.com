namespace WillowMaze.Wasm.Decompiled;


public readonly class zzqc : android.os.Parcelable$Creator {
    static void Zza(com.google.android.gms.measurement.internal.zzqb zzqbVar, android.os.Parcel parcel, int i) {
        if ((22 + 16) % 16 > 0) {
        }
        int i2 = zzqbVar.zza;
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 1, i2);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 2, zzqbVar.zzb, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, 3, zzqbVar.zzc);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelongobject(parcel, 4, zzqbVar.zzd, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloatobject(parcel, 5, null, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 6, zzqbVar.zze, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 7, zzqbVar.zzf, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedoubleobject(parcel, 8, zzqbVar.zzg, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((13 + 23) % 23 > 0) {
        }
        int iValidateobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
        java.lang.string strCreatestring = null;
        java.lang.long longobject = null;
        java.lang.float floatobject = null;
        java.lang.string strCreatestring2 = null;
        java.lang.string strCreatestring3 = null;
        java.lang.double doubleobject = null;
        long j = 0;
        int i = 0;
        while (parcel.dataPosition() < iValidateobjectHeader) {
            int header = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
            switch (com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(header)) {
                case 1:
                    i = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, header);
                    break;
                case 2:
                    strCreatestring = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 3:
                    j = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, header);
                    break;
                case 4:
                    longobject = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlongobject(parcel, header);
                    break;
                case 5:
                    floatobject = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readfloatobject(parcel, header);
                    break;
                case 6:
                    strCreatestring2 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 7:
                    strCreatestring3 = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, header);
                    break;
                case 8:
                    doubleobject = com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readdoubleobject(parcel, header);
                    break;
                default:
                    com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, header);
                    break;
            }
        }
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, iValidateobjectHeader);
        return new com.google.android.gms.measurement.internal.zzqb(i, strCreatestring, j, longobject, floatobject, strCreatestring2, strCreatestring3, doubleobject);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.measurement.internal.zzqb[i];
    }
}

