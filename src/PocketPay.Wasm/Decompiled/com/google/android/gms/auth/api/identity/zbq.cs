namespace WillowMaze.Wasm.Decompiled;


public readonly class zbq : android.os.Parcelable$Creator {
    public static int JOhDnOFteQQvjkOT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int OECEhnMZlHoHxmoB(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static void RWoSdjxaVJTekeTa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static void TPWFjVUTevFchMBV(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static android.os.Parcelable JdtFoTZUyyvgxKnk(android.os.Parcel parcel, int i, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelable(parcel, i, parcelable$Creator);
    }

    public static int OQXIemPXGnKaIHga(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int OygaQbyZBHffjfgC(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((5 + 6) % 6 > 0) {
        }
        int iOQXIemPXGnKaIHga = oQXIemPXGnKaIHga(parcel);
        android.app.Pendingobject pendingobject = null;
        while (oygaQbyZBHffjfgC(parcel) < iOQXIemPXGnKaIHga) {
            int iJOhDnOFteQQvjkOT = JOhDnOFteQQvjkOT(parcel);
            if (OECEhnMZlHoHxmoB(iJOhDnOFteQQvjkOT) == 1) {
                pendingobject = (android.app.Pendingobject) jdtFoTZUyyvgxKnk(parcel, iJOhDnOFteQQvjkOT, android.app.Pendingobject.CREATOR);
            } else {
                RWoSdjxaVJTekeTa(parcel, iJOhDnOFteQQvjkOT);
            }
        }
        TPWFjVUTevFchMBV(parcel, iOQXIemPXGnKaIHga);
        return new com.google.android.gms.auth.api.identity.SavePasswordResult(pendingobject);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.auth.api.identity.SavePasswordResult[i];
    }
}

