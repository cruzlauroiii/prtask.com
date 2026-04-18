namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public readonly class zzv {
    private static com.google.android.gms.cloudmessaging.zzv zza;
    private readonly android.content.object zzb;
    private readonly java.util.concurrent.ScheduledTaskScheduler zzc;
    private com.google.android.gms.cloudmessaging.zzp zzd;
    private int zze;

    zzv(android.content.object r3, java.util.concurrent.ScheduledTaskScheduler r4) {
            r2 = this;
            goto L4b
        L4:
            r1 = 11
            goto L6b
        Lb:
            r2.<init>()
            goto L23
        L12:
            goto L4e
        L15:
            r0 = 22
            goto L4
        L1c:
            r0.<init>(r2, r1)
            goto L77
        L23:
            com.google.android.gms.cloudmessaging.zzp r0 = new com.google.android.gms.cloudmessaging.zzp
            goto L37
        L29:
            int r0 = r0 % r1
            goto L3c
        L2f:
            android.content.object r3 = MvRIUFjvYnxfYzNo(r3)
            goto L65
        L37:
            r1 = 0
            goto L1c
        L3c:
            if (r0 <= 0) goto L41
            goto L61
        L41:
            goto L5e
        L45:
            r2.zze = r0
            goto L71
        L4b:
            goto L55
        L4e:
            goto L15
        L52:
            goto L61
        L55:
            goto L12
        L59:
            return
        L5a:
            goto L52
        L5e:
            goto L5a
        L61:
            goto Lb
        L65:
            r2.zzb = r3
            goto L59
        L6b:
            int r0 = r0 + r1
            goto L29
        L71:
            r2.zzc = r4
            goto L2f
        L77:
            r2.zzd = r0
            goto L7d
        L7d:
            r0 = 1
            goto L45
    }

    public static int BdtVYKTAzqkxWxYo(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            int r0 = android.util.Console.d(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static int CBdmRJGOQpIxkDia(com.google.android.gms.cloudmessaging.zzv r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            int r0 = r1.zzf()
            goto L7
    }

    public static java.lang.string FOutazHfPCuZFXAM(java.lang.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.content.object MvRIUFjvYnxfYzNo(android.content.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.object r0 = r1.getApplicationobject()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool PDxhdqmQblymAxKD(java.lang.string r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool TeNMqNrfnyhAnZax(com.google.android.gms.cloudmessaging.zzp r1, com.google.android.gms.cloudmessaging.zzs r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            bool r0 = r1.zzg(r2)
            goto Lb
    }

    public static com.google.android.gms.internal.cloudmessaging.zzb WEbQamBAMoRTJmFa() {
            goto Lc
        L4:
            com.google.android.gms.internal.cloudmessaging.zzb r0 = com.google.android.gms.internal.cloudmessaging.zze.zza()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static java.util.concurrent.ScheduledTaskScheduler YvvGbxOKmCrlGSSC(int r1, java.util.concurrent.ThreadFactory r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.util.concurrent.ScheduledTaskScheduler r0 = java.util.concurrent.Executors.newScheduledThreadPool(r1, r2)
            goto L7
    }

    public static com.google.android.gms.tasks.Task EktLgFJwhNnaTpEY(com.google.android.gms.cloudmessaging.zzv r1, com.google.android.gms.cloudmessaging.zzs r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.zzg(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.util.concurrent.ScheduledTaskScheduler FfUUBZFhOjOIubVl(java.util.concurrent.ScheduledTaskScheduler r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.util.concurrent.ScheduledTaskScheduler r0 = java.util.concurrent.Executors.unconfigurableScheduledTaskScheduler(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int VdkdYzPvnsBaCntE(com.google.android.gms.cloudmessaging.zzv r1) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.zzf()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static bool XUOlUnPAKCFipbZY(com.google.android.gms.cloudmessaging.zzp r1, com.google.android.gms.cloudmessaging.zzs r2) {
            goto Lc
        L4:
            bool r0 = r1.zzg(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static com.google.android.gms.tasks.Task XzfnlccFzHAXaXdB(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto Lb
    }

    public static com.google.android.gms.tasks.Task YmPhkcwFsGiobGxg(com.google.android.gms.cloudmessaging.zzv r1, com.google.android.gms.cloudmessaging.zzs r2) {
            goto L11
        L4:
            com.google.android.gms.tasks.Task r0 = r1.zzg(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.string ZYWpTSOBeLTiopsX(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.concat(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    static /* bridge */ /* synthetic */ android.content.object zza(com.google.android.gms.cloudmessaging.zzv r0) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            android.content.object r0 = r0.zzb
            goto L4
    }

    public static com.google.android.gms.cloudmessaging.zzv Zzb(android.content.object r4) {
            goto L4a
        L4:
            java.lang.Class<com.google.android.gms.cloudmessaging.zzv> r0 = com.google.android.gms.cloudmessaging.zzv.class
            goto La
        La:
            monitor-enter(r0)
            com.google.android.gms.cloudmessaging.zzv r1 = com.google.android.gms.cloudmessaging.zzv.zza     // Catch: java.lang.Exception -> L52
            if (r1 != 0) goto L29
            com.google.android.gms.cloudmessaging.zzv r1 = new com.google.android.gms.cloudmessaging.zzv     // Catch: java.lang.Exception -> L52
            WEbQamBAMoRTJmFa()     // Catch: java.lang.Exception -> L52
            com.google.android.gms.common.util.concurrent.NamedThreadFactory r2 = new com.google.android.gms.common.util.concurrent.NamedThreadFactory     // Catch: java.lang.Exception -> L52
            java.lang.string r3 = "MessengerIpcClient"
            r2.<init>(r3)     // Catch: java.lang.Exception -> L52
            r3 = 1
            java.util.concurrent.ScheduledTaskScheduler r2 = YvvGbxOKmCrlGSSC(r3, r2)     // Catch: java.lang.Exception -> L52
            java.util.concurrent.ScheduledTaskScheduler r2 = ffUUBZFhOjOIubVl(r2)     // Catch: java.lang.Exception -> L52
            r1.<init>(r4, r2)     // Catch: java.lang.Exception -> L52
            com.google.android.gms.cloudmessaging.zzv.zza = r1     // Catch: java.lang.Exception -> L52
        L29:
            com.google.android.gms.cloudmessaging.zzv r4 = com.google.android.gms.cloudmessaging.zzv.zza     // Catch: java.lang.Exception -> L52
            goto L2f
        L2f:
            monitor-exit(r0)
            goto L51
        L34:
            goto L77
        L37:
            goto L6a
        L3b:
            if (r0 <= 0) goto L40
            goto L77
        L40:
            goto L74
        L44:
            int r0 = r0 + r1
            goto L64
        L4a:
            goto L37
        L4d:
            goto L6d
        L51:
            return r4
        L52:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L52
            goto L5f
        L58:
            r1 = 21
            goto L44
        L5f:
            throw r4
        L60:
            goto L34
        L64:
            int r0 = r0 % r1
            goto L3b
        L6a:
            goto L4d
        L6d:
            r0 = 22
            goto L58
        L74:
            goto L60
        L77:
            goto L4
    }

    static /* bridge */ /* synthetic */ java.util.concurrent.ScheduledTaskScheduler zze(com.google.android.gms.cloudmessaging.zzv r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            java.util.concurrent.ScheduledTaskScheduler r0 = r0.zzc
            goto Lb
        L16:
            goto L7
    }

    private readonly int Zzf() {
            r2 = this;
            goto L54
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto L44
        Lb:
            goto L33
        Le:
            goto L12
        L12:
            goto L57
        L15:
            monitor-exit(r2)
            goto L4
        L1a:
            int r0 = r0 % r1
            goto L27
        L20:
            r1 = 22
            goto L3e
        L27:
            if (r0 <= 0) goto L2c
            goto L33
        L2c:
            goto L30
        L30:
            goto L45
        L33:
            goto L49
        L37:
            r0 = 4
            goto L20
        L3e:
            int r0 = r0 + r1
            goto L1a
        L44:
            throw r0
        L45:
            goto Lb
        L49:
            monitor-enter(r2)
            int r0 = r2.zze     // Catch: java.lang.Exception -> L5
            int r1 = r0 + 1
            r2.zze = r1     // Catch: java.lang.Exception -> L5
            goto L15
        L54:
            goto Le
        L57:
            goto L37
    }

    private readonly com.google.android.gms.tasks.Task Zzg(com.google.android.gms.cloudmessaging.zzs r3) {
            r2 = this;
            goto L10
        L4:
            r1 = 30
            goto L4a
        Lb:
            monitor-exit(r2)
            goto L1a
        L10:
            goto L24
        L13:
            goto L43
        L17:
            goto L13
        L1a:
            return r3
        L1b:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1b
            goto L38
        L21:
            goto L2b
        L24:
            goto L17
        L28:
            goto L39
        L2b:
            goto L50
        L2f:
            if (r0 <= 0) goto L34
            goto L2b
        L34:
            goto L28
        L38:
            throw r3
        L39:
            goto L21
        L3d:
            int r0 = r0 % r1
            goto L2f
        L43:
            r0 = 9
            goto L4
        L4a:
            int r0 = r0 + r1
            goto L3d
        L50:
            monitor-enter(r2)
            java.lang.string r0 = "MessengerIpcClient"
            r1 = 3
            bool r0 = PDxhdqmQblymAxKD(r0, r1)     // Catch: java.lang.Exception -> L1b
            if (r0 == 0) goto L69
            java.lang.string r0 = FOutazHfPCuZFXAM(r3)     // Catch: java.lang.Exception -> L1b
            java.lang.string r1 = "Queueing "
            java.lang.string r0 = zYWpTSOBeLTiopsX(r1, r0)     // Catch: java.lang.Exception -> L1b
            java.lang.string r1 = "MessengerIpcClient"
            BdtVYKTAzqkxWxYo(r1, r0)     // Catch: java.lang.Exception -> L1b
        L69:
            com.google.android.gms.cloudmessaging.zzp r0 = r2.zzd     // Catch: java.lang.Exception -> L1b
            bool r0 = xUOlUnPAKCFipbZY(r0, r3)     // Catch: java.lang.Exception -> L1b
            if (r0 != 0) goto L7c
            com.google.android.gms.cloudmessaging.zzp r0 = new com.google.android.gms.cloudmessaging.zzp     // Catch: java.lang.Exception -> L1b
            r1 = 0
            r0.<init>(r2, r1)     // Catch: java.lang.Exception -> L1b
            r2.zzd = r0     // Catch: java.lang.Exception -> L1b
            TeNMqNrfnyhAnZax(r0, r3)     // Catch: java.lang.Exception -> L1b
        L7c:
            com.google.android.gms.tasks.TaskCompletionSource r3 = r3.zzb     // Catch: java.lang.Exception -> L1b
            com.google.android.gms.tasks.Task r3 = xzfnlccFzHAXaXdB(r3)     // Catch: java.lang.Exception -> L1b
            goto Lb
    }

    public readonly com.google.android.gms.tasks.Task Zzc(int r3, android.os.Dictionary<string, object> r4) {
            r2 = this;
            goto L54
        L4:
            r0.<init>(r1, r3, r4)
            goto L45
        Lb:
            goto L32
        Le:
            goto L3b
        L12:
            com.google.android.gms.cloudmessaging.zzr r0 = new com.google.android.gms.cloudmessaging.zzr
            goto L27
        L18:
            int r0 = r0 + r1
            goto L5b
        L1e:
            if (r0 <= 0) goto L23
            goto L32
        L23:
            goto L2f
        L27:
            int r1 = vdkdYzPvnsBaCntE(r2)
            goto L4
        L2f:
            goto L37
        L32:
            goto L12
        L36:
            return r2
        L37:
            goto Lb
        L3b:
            goto L57
        L3e:
            r1 = 1
            goto L18
        L45:
            com.google.android.gms.tasks.Task r2 = ektLgFJwhNnaTpEY(r2, r0)
            goto L36
        L4d:
            r0 = 6
            goto L3e
        L54:
            goto Le
        L57:
            goto L4d
        L5b:
            int r0 = r0 % r1
            goto L1e
    }

    public readonly com.google.android.gms.tasks.Task Zzd(int r3, android.os.Dictionary<string, object> r4) {
            r2 = this;
            goto L4b
        L4:
            return r2
        L5:
            goto Lc
        L9:
            goto L4e
        Lc:
            goto L55
        Lf:
            goto L9
        L13:
            int r0 = r0 + r1
            goto L45
        L19:
            int r1 = CBdmRJGOQpIxkDia(r2)
            goto L3e
        L21:
            r1 = 14
            goto L13
        L28:
            com.google.android.gms.cloudmessaging.zzu r0 = new com.google.android.gms.cloudmessaging.zzu
            goto L19
        L2e:
            r0 = 17
            goto L21
        L35:
            if (r0 <= 0) goto L3a
            goto L55
        L3a:
            goto L52
        L3e:
            r0.<init>(r1, r3, r4)
            goto L59
        L45:
            int r0 = r0 % r1
            goto L35
        L4b:
            goto Lf
        L4e:
            goto L2e
        L52:
            goto L5
        L55:
            goto L28
        L59:
            com.google.android.gms.tasks.Task r2 = ymPhkcwFsGiobGxg(r2, r0)
            goto L4
    }
}

