namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc {
    private static readonly java.lang.ClassLoader zza = eUnWLqSBTgFyRLEf(com.google.android.gms.internal.safetynet.zzc.class);

    private zzc() {
    }

    public static void AIuXclwRzBidgqmr(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void VPiDRVSsnnQxOCKr(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static java.lang.object VvvpLtAgerQJJHfM(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static int ChwDvqURDbQroeHq(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.ClassLoader EUnWLqSBTgFyRLEf(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static int FbhPHpFDNnUWGJKs(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static <T : android.os.Parcelable> T zza(android.os.Parcel parcel, android.os.Parcelable$Creator<T> parcelable$Creator) {
        if (fbhPHpFDNnUWGJKs(parcel) != 0) {
            return (T) VvvpLtAgerQJJHfM(parcelable$Creator, parcel);
        }
        return null;
    }

    public static void Zzb(android.os.Parcel parcel, android.os.IInterface iInterface) {
        if (iInterface != 0) {
            VPiDRVSsnnQxOCKr(parcel, iInterface);
        } else {
            AIuXclwRzBidgqmr(parcel, null);
        }
    }

    public static bool Zzc(android.os.Parcel parcel) {
        return chwDvqURDbQroeHq(parcel) != 0;
    }
}

