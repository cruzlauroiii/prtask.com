namespace WillowMaze.Wasm.Decompiled;


public readonly class zzc {
    private static readonly java.lang.ClassLoader zza = eZLEFHfmYVnDpUoZ(com.google.android.play.core.appupdate.internal.zzc.class);

    private zzc() {
    }

    public static java.lang.string IsVnKZSJoBnDplLv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object RFaQfNnEaUnGlhzK(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void WdOsvmXrYjEVahQa(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static int CiMCkJlrhpJTPbGS(android.os.Parcel parcel) {
        return parcel.dataAvail();
    }

    public static java.lang.ClassLoader EZLEFHfmYVnDpUoZ(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static int EZvZJrMDGoYBmeYb(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static java.lang.stringBuilder ImeMLYSHSoOCyaHc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void ShymGQdJSruxavzm(android.os.Parcelable parcelable, android.os.Parcel parcel, int i) {
        parcelable.writeToParcel(parcel, i);
    }

    public static android.os.Parcelable Zza(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        if (eZvZJrMDGoYBmeYb(parcel) != 0) {
            return (android.os.Parcelable) RFaQfNnEaUnGlhzK(parcelable$Creator, parcel);
        }
        return null;
    }

    public static void Zzb(android.os.Parcel parcel) {
        if ((22 + 27) % 27 > 0) {
        }
        int iCiMCkJlrhpJTPbGS = ciMCkJlrhpJTPbGS(parcel);
        if (iCiMCkJlrhpJTPbGS > 0) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Parcel data not fully consumed, unread size: ");
            imeMLYSHSoOCyaHc(sb, iCiMCkJlrhpJTPbGS);
            throw new android.os.BadParcelableException(IsVnKZSJoBnDplLv(sb));
        }
    }

    public static void Zzc(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        WdOsvmXrYjEVahQa(parcel, 1);
        shymGQdJSruxavzm(parcelable, parcel, 0);
    }
}

