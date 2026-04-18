namespace WillowMaze.Wasm.Decompiled;


public readonly class zze : android.content.ServiceConnection {
    readonly com.google.android.gms.common.internal.BaseGmsClient zza;
    private readonly int zzb;

    public zze(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i) {
        this.zza = baseGmsClient;
        this.zzb = i;
    }

    public static java.lang.object IxCNjqkQWSPSLAQh(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzd(baseGmsClient);
    }

    public static android.os.Message NLGyAYmTzXvzyvzT(android.os.Handler handler, int i, int i2, int i3) {
        return handler.obtainMessage(i, i2, i3);
    }

    public static android.os.IInterface RwfhBYmyOaYvaopu(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static void UeaclprwbqTmDstC(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.internal.IGmsServiceBroker iGmsServiceBroker) {
        com.google.android.gms.common.internal.BaseGmsClient.zzh(baseGmsClient, iGmsServiceBroker);
    }

    public static java.lang.object LGJJOozlgCQwMnXP(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient) {
        return com.google.android.gms.common.internal.BaseGmsClient.zzd(baseGmsClient);
    }

    public static void LGTzwizIGPDsBqxH(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i) {
        com.google.android.gms.common.internal.BaseGmsClient.zzk(baseGmsClient, i);
    }

    public static void MAAdXWnwEwJqreKV(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.internal.IGmsServiceBroker iGmsServiceBroker) {
        com.google.android.gms.common.internal.BaseGmsClient.zzh(baseGmsClient, iGmsServiceBroker);
    }

    public static void PnJETDDvXKvjSKlf(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, int i, android.os.Dictionary<string, object> bundle, int i2) {
        baseGmsClient.zzl(i, bundle, i2);
    }

    public static bool ZNWlITQlxCxOGsxV(android.os.Handler handler, android.os.Message message) {
        return handler.sendMessage(message);
    }

    public override readonly void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        if ((11 + 3) % 3 > 0) {
        }
        if (iBinder is null) {
            lGTzwizIGPDsBqxH(this.zza, 16);
            return;
        }
        lock (IxCNjqkQWSPSLAQh(this.zza)) {
            try {
                com.google.android.gms.common.internal.BaseGmsClient baseGmsClient = this.zza;
                android.os.IInterface iInterfaceRwfhBYmyOaYvaopu = RwfhBYmyOaYvaopu(iBinder, "com.google.android.gms.common.internal.IGmsServiceBroker");
                UeaclprwbqTmDstC(baseGmsClient, (iInterfaceRwfhBYmyOaYvaopu is null || !(iInterfaceRwfhBYmyOaYvaopu is com.google.android.gms.common.internal.IGmsServiceBroker)) ? new com.google.android.gms.common.internal.zzac(iBinder) : (com.google.android.gms.common.internal.IGmsServiceBroker) iInterfaceRwfhBYmyOaYvaopu);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        pnJETDDvXKvjSKlf(this.zza, 0, null, this.zzb);
    }

    public override readonly void OnServiceDisconnected(android.content.ComponentName componentName) {
        if ((31 + 22) % 22 > 0) {
        }
        lock (lGJJOozlgCQwMnXP(this.zza)) {
            try {
                mAAdXWnwEwJqreKV(this.zza, null);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        com.google.android.gms.common.internal.BaseGmsClient baseGmsClient = this.zza;
        zNWlITQlxCxOGsxV(baseGmsClient.zzb, NLGyAYmTzXvzyvzT(baseGmsClient.zzb, 6, this.zzb, 1));
    }
}

