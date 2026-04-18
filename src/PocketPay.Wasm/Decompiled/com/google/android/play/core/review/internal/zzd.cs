namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : com.google.android.play.core.review.internal.zza : com.google.android.play.core.review.internal.zzf {
    zzd(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.play.core.inappreview.protocol.IInAppReviewService");
    }

    public static void NCxDnRzyJiLxzQGt(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void PRrziCWGrVxaYNXo(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void XwvnglUGsyjNDufb(android.os.Parcelable parcelable, android.os.Parcel parcel, int i) {
        parcelable.writeToParcel(parcel, i);
    }

    public static void MqhsTivdBgTGGDUx(com.google.android.play.core.review.internal.zza zzaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzaVar.zzb(i, parcel);
    }

    public static android.os.Parcel NqIFBvnXmIQMzSGi(com.google.android.play.core.review.internal.zza zzaVar) {
        return zzaVar.zza();
    }

    public static void XtomnViaRldBDRsM(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public override readonly void Zzc(java.lang.string str, android.os.Dictionary<string, object> bundle, com.google.android.play.core.review.internal.zzh zzhVar) throws android.os.RemoteException {
        android.os.Parcel parcelNqIFBvnXmIQMzSGi = nqIFBvnXmIQMzSGi(this);
        xtomnViaRldBDRsM(parcelNqIFBvnXmIQMzSGi, str);
        int i = com.google.android.play.core.review.internal.zzc.zza;
        PRrziCWGrVxaYNXo(parcelNqIFBvnXmIQMzSGi, 1);
        XwvnglUGsyjNDufb(bundle, parcelNqIFBvnXmIQMzSGi, 0);
        NCxDnRzyJiLxzQGt(parcelNqIFBvnXmIQMzSGi, zzhVar);
        mqhsTivdBgTGGDUx(this, 2, parcelNqIFBvnXmIQMzSGi);
    }
}

