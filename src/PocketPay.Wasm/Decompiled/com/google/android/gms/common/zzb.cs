namespace WillowMaze.Wasm.Decompiled;


public readonly class zzb : android.os.Parcelable$Creator {
    public static int HTtPtSiuaBDcUUuV(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static bool IkjvDNWthubZoMXD(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int OvXOuHbpglqVZjbV(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static bool QeMbBTsRlFnuEFuG(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static int CSQoOxWSyWIyxonX(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int IfyeZcvAgBFxnRkP(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void QsXtiBIMaujDfjeT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void YhGhCyJlKfPksJiZ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((29 + 7) % 7 > 0) {
        }
        int iCSQoOxWSyWIyxonX = cSQoOxWSyWIyxonX(parcel);
        bool zQeMbBTsRlFnuEFuG = false;
        bool zIkjvDNWthubZoMXD = false;
        while (ifyeZcvAgBFxnRkP(parcel) < iCSQoOxWSyWIyxonX) {
            int iHTtPtSiuaBDcUUuV = HTtPtSiuaBDcUUuV(parcel);
            int iOvXOuHbpglqVZjbV = OvXOuHbpglqVZjbV(iHTtPtSiuaBDcUUuV);
            if (iOvXOuHbpglqVZjbV == 1) {
                zQeMbBTsRlFnuEFuG = QeMbBTsRlFnuEFuG(parcel, iHTtPtSiuaBDcUUuV);
            } else if (iOvXOuHbpglqVZjbV == 2) {
                zIkjvDNWthubZoMXD = IkjvDNWthubZoMXD(parcel, iHTtPtSiuaBDcUUuV);
            } else {
                qsXtiBIMaujDfjeT(parcel, iHTtPtSiuaBDcUUuV);
            }
        }
        yhGhCyJlKfPksJiZ(parcel, iCSQoOxWSyWIyxonX);
        return new com.google.android.gms.common.zzr(zQeMbBTsRlFnuEFuG, zIkjvDNWthubZoMXD);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.common.zzr[i];
    }
}

