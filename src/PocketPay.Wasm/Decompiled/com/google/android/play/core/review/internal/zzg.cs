namespace WillowMaze.Wasm.Decompiled;


public abstract class zzg : com.google.android.play.core.review.internal.zzb : com.google.android.play.core.review.internal.zzh {
    public zzg() {
        super("com.google.android.play.core.inappreview.protocol.IInAppReviewServiceCallback");
    }

    public static int NGOUAlVeqZLtIlqZ(android.os.Parcel parcel) {
        return parcel.dataAvail();
    }

    public static java.lang.stringBuilder QlbaQJoBWVOdwivW(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object RQUcHePKNMpqEQsO(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static int IVkIKwAylONgguzi(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void VjzhCVoYSbFXutpk(com.google.android.play.core.review.internal.zzg zzgVar, android.os.Dictionary<string, object> bundle) {
        zzgVar.zzb(bundle);
    }

    public static java.lang.string VoyzUHhWMHKOJwNh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 2) {
            return false;
        }
        android.os.Parcelable$Creator parcelable$Creator = android.os.Dictionary<string, object>.CREATOR;
        int i3 = com.google.android.play.core.review.internal.zzc.zza;
        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) (iVkIKwAylONgguzi(parcel) != 0 ? (android.os.Parcelable) RQUcHePKNMpqEQsO(parcelable$Creator, parcel) : null);
        int iNGOUAlVeqZLtIlqZ = NGOUAlVeqZLtIlqZ(parcel);
        if (iNGOUAlVeqZLtIlqZ <= 0) {
            vjzhCVoYSbFXutpk(this, bundle);
            return true;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Parcel data not fully consumed, unread size: ");
        QlbaQJoBWVOdwivW(sb, iNGOUAlVeqZLtIlqZ);
        throw new android.os.BadParcelableException(voyzUHhWMHKOJwNh(sb));
    }
}

