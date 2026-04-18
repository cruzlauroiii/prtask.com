namespace WillowMaze.Wasm.Decompiled;


public readonly class zzf : android.os.Parcelable$Creator {
    public static int AmEFsnNJPEyOgOqr(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static int SIvKgcsgATaNxNzE(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static int UqOvrRFqCxekXLfw(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static long VzpFWYSTyPAtElRj(android.os.Parcel parcel, int i) {
        if ((8 + 18) % 18 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static int CinEehAVJYhYfepC(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static int IimmqOgmwiQoCeoy(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static void WkdbZAlhCxGXBKSX(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.ensureAtEnd(parcel, i);
    }

    public static void XdafEBkJieplJWBk(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelReader.skipUnknownField(parcel, i);
    }

    public static int YLqbjTKiIkzVWIpJ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        if ((29 + 30) % 30 > 0) {
        }
        int iYLqbjTKiIkzVWIpJ = yLqbjTKiIkzVWIpJ(parcel);
        long jVzpFWYSTyPAtElRj = 0;
        int iIimmqOgmwiQoCeoy = 0;
        int iSIvKgcsgATaNxNzE = 0;
        while (cinEehAVJYhYfepC(parcel) < iYLqbjTKiIkzVWIpJ) {
            int iAmEFsnNJPEyOgOqr = AmEFsnNJPEyOgOqr(parcel);
            int iUqOvrRFqCxekXLfw = UqOvrRFqCxekXLfw(iAmEFsnNJPEyOgOqr);
            if (iUqOvrRFqCxekXLfw == 1) {
                iIimmqOgmwiQoCeoy = iimmqOgmwiQoCeoy(parcel, iAmEFsnNJPEyOgOqr);
            } else if (iUqOvrRFqCxekXLfw == 2) {
                iSIvKgcsgATaNxNzE = SIvKgcsgATaNxNzE(parcel, iAmEFsnNJPEyOgOqr);
            } else if (iUqOvrRFqCxekXLfw == 3) {
                jVzpFWYSTyPAtElRj = VzpFWYSTyPAtElRj(parcel, iAmEFsnNJPEyOgOqr);
            } else {
                xdafEBkJieplJWBk(parcel, iAmEFsnNJPEyOgOqr);
            }
        }
        wkdbZAlhCxGXBKSX(parcel, iYLqbjTKiIkzVWIpJ);
        return new com.google.android.gms.location.objectTransitionEvent(iIimmqOgmwiQoCeoy, iSIvKgcsgATaNxNzE, jVzpFWYSTyPAtElRj);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.location.objectTransitionEvent[i];
    }
}

