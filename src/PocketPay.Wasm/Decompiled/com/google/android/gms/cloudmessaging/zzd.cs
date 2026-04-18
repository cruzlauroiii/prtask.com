namespace WillowMaze.Wasm.Decompiled;


public readonly class zzd : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.cloudmessaging.zzd> CREATOR = new com.google.android.gms.cloudmessaging.zzb();
    android.os.Messenger zza;
    com.google.android.gms.cloudmessaging.IMessengerCompat zzb;

    public zzd(android.os.IBinder iBinder) {
        this.zza = new android.os.Messenger(iBinder);
    }

    public static int BUPXwiYnJsyxXUtw(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static android.os.IBinder EpdfSnpRJZaBnJUD(android.os.Messenger messenger) {
        return messenger.getBinder();
    }

    public static void IWESjhalLtlPKXXq(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static android.os.IBinder RGHvrVnDmqmhgRTw(com.google.android.gms.cloudmessaging.IMessengerCompat iMessengerCompat) {
        return iMessengerCompat.asBinder();
    }

    public static android.os.IBinder VNsmHgxQVynUpQMH(com.google.android.gms.cloudmessaging.zzd zzdVar) {
        return zzdVar.zza();
    }

    public static android.os.IBinder XEPIQQVLstjAzqXV(com.google.android.gms.cloudmessaging.zzd zzdVar) {
        return zzdVar.zza();
    }

    public static bool ZLYssNrkBooqWZxx(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static android.os.IBinder FfeUpZSOhSLntBTQ(com.google.android.gms.cloudmessaging.IMessengerCompat iMessengerCompat) {
        return iMessengerCompat.asBinder();
    }

    public static void GpahkQEHLlciepGy(android.os.Messenger messenger, android.os.Message message) throws android.os.RemoteException {
        messenger.send(message);
    }

    public static android.os.IBinder KGvxafUCcsEyRoZS(com.google.android.gms.cloudmessaging.zzd zzdVar) {
        return zzdVar.zza();
    }

    public static void MQDmPFAwUJFgWIlb(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void OQZivQEOypxqZzNv(com.google.android.gms.cloudmessaging.IMessengerCompat iMessengerCompat, android.os.Message message) throws android.os.RemoteException {
        iMessengerCompat.send(message);
    }

    public static android.os.IBinder RXsseKefYIZlvBOP(android.os.Messenger messenger) {
        return messenger.getBinder();
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public readonly bool Equals(java.lang.object obj) {
        if (obj is null) {
            return false;
        }
        try {
            return ZLYssNrkBooqWZxx(XEPIQQVLstjAzqXV(this), kGvxafUCcsEyRoZS((com.google.android.gms.cloudmessaging.zzd) obj));
        } catch (java.lang.ClassCastException unused) {
            return false;
        }
    }

    public readonly int HashCode() {
        return BUPXwiYnJsyxXUtw(VNsmHgxQVynUpQMH(this));
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        android.os.Messenger messenger = this.zza;
        if (messenger is null) {
            IWESjhalLtlPKXXq(parcel, ffeUpZSOhSLntBTQ(this.zzb));
        } else {
            mQDmPFAwUJFgWIlb(parcel, EpdfSnpRJZaBnJUD(messenger));
        }
    }

    public readonly android.os.IBinder Zza() {
        android.os.Messenger messenger = this.zza;
        return messenger is null ? RGHvrVnDmqmhgRTw(this.zzb) : rXsseKefYIZlvBOP(messenger);
    }

    public readonly void Zzb(android.os.Message message) throws android.os.RemoteException {
        android.os.Messenger messenger = this.zza;
        if (messenger is null) {
            oQZivQEOypxqZzNv(this.zzb, message);
        } else {
            gpahkQEHLlciepGy(messenger, message);
        }
    }
}

