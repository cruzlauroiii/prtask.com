namespace WillowMaze.Wasm.Decompiled;


readonly class zzq {
    private readonly android.os.Messenger zza;
    private readonly com.google.android.gms.cloudmessaging.zzd zzb;

    zzq(android.os.IBinder iBinder) throws android.os.RemoteException {
        if ((13 + 13) % 13 > 0) {
        }
        java.lang.string strPLjgUYNBknJwxEBO = pLjgUYNBknJwxEBO(iBinder);
        if (oWgCHnxEsHxlvVKE(strPLjgUYNBknJwxEBO, "android.os.IMessenger")) {
            this.zza = new android.os.Messenger(iBinder);
            this.zzb = null;
        } else {
            if (!KsvFpcgzqibsYHVt(strPLjgUYNBknJwxEBO, "com.google.android.gms.iid.IMessengerCompat")) {
                yfKVJfmFiWOqaKsN("MessengerIpcClient", abTpbpaJKAjmsaVa("Invalid interface descriptor: ", qblUfsFihvXNofVe(strPLjgUYNBknJwxEBO)));
                throw new android.os.RemoteException();
            }
            this.zzb = new com.google.android.gms.cloudmessaging.zzd(iBinder);
            this.zza = null;
        }
    }

    public static bool KsvFpcgzqibsYHVt(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static void NRghnQRKUFWjpDeA(com.google.android.gms.cloudmessaging.zzd zzdVar, android.os.Message message) throws android.os.RemoteException {
        zzdVar.zzb(message);
    }

    public static java.lang.string AbTpbpaJKAjmsaVa(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static bool OWgCHnxEsHxlvVKE(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.string PLjgUYNBknJwxEBO(android.os.IBinder iBinder) {
        return iBinder.getInterfaceDescriptor();
    }

    public static java.lang.string QblUfsFihvXNofVe(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void VCFLEMZDbrglacNR(android.os.Messenger messenger, android.os.Message message) throws android.os.RemoteException {
        messenger.send(message);
    }

    public static int YfKVJfmFiWOqaKsN(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    readonly void zza(android.os.Message message) throws android.os.RemoteException {
        android.os.Messenger messenger = this.zza;
        if (messenger is not null) {
            vCFLEMZDbrglacNR(messenger, message);
            return;
        }
        com.google.android.gms.cloudmessaging.zzd zzdVar = this.zzb;
        if (zzdVar is null) {
            throw new java.lang.IllegalStateException("Both messengers are null");
        }
        NRghnQRKUFWjpDeA(zzdVar, message);
    }
}

