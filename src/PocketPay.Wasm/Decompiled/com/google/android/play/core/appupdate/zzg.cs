namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
readonly class zzg : com.google.android.play.core.appupdate.AppUpdateManager {
    private readonly com.google.android.play.core.appupdate.zzr zza;
    private readonly com.google.android.play.core.appupdate.zzc zzb;
    private readonly android.content.object zzc;
    private readonly android.os.Handler zzd;

    zzg(com.google.android.play.core.appupdate.zzr r3, com.google.android.play.core.appupdate.zzc r4, android.content.object r5) {
            r2 = this;
            goto L50
        L4:
            r2.zzb = r4
            goto L42
        La:
            return
        Lb:
            goto L3b
        Lf:
            r2.<init>()
            goto L66
        L16:
            if (r0 <= 0) goto L1b
            goto L29
        L1b:
            goto L26
        L1f:
            r0 = 20
            goto L2d
        L26:
            goto Lb
        L29:
            goto Lf
        L2d:
            r1 = 30
            goto L57
        L34:
            r0.<init>(r1)
            goto L6c
        L3b:
            goto L29
        L3e:
            goto L5d
        L42:
            r2.zzc = r5
            goto La
        L48:
            android.os.Looper r1 = NkhJMJDydCLXvgxR()
            goto L34
        L50:
            goto L3e
        L53:
            goto L1f
        L57:
            int r0 = r0 + r1
            goto L72
        L5d:
            goto L53
        L60:
            r2.zza = r3
            goto L4
        L66:
            android.os.Handler r0 = new android.os.Handler
            goto L48
        L6c:
            r2.zzd = r0
            goto L60
        L72:
            int r0 = r0 % r1
            goto L16
    }

    public static android.content.object BFFmfrZNdLPhLUky(android.content.object r1, java.lang.string r2, android.os.Parcelable r3) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.object r0 = r1.putExtra(r2, r3)
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

    public static void CSLfQBWdySJBbemJ(com.google.android.play.core.appupdate.internal.zzl r0, com.google.android.play.core.listener.StateUpdatedListener r1) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.zzb(r1)
            goto L4
    }

    public static com.google.android.gms.tasks.Task DNSKzfKdnCtPNHGM(java.lang.Exception r1) {
            goto L14
        L4:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void GBckJgNhlWtUqilh(com.google.android.play.core.appupdate.AppUpdateInfo r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.zzc()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void GuaSSIvCFiZczCQn(androidx.activity.result.objectResultLauncher r0, java.lang.object r1) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.launch(r1)
            goto L4
    }

    public static java.lang.string HqYvZPPrezNjiFhw(android.content.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.string r0 = r1.getPackageName()
            goto Le
    }

    public static java.lang.string JIMfjXYKOVtYVzAH(android.content.object r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.getPackageName()
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

    public static bool JvxeOurMQLdTAsOI(com.google.android.play.core.appupdate.zzg r1, com.google.android.play.core.appupdate.AppUpdateInfo r2, com.google.android.play.core.common.objectSenderForResultStarter r3, com.google.android.play.core.appupdate.AppUpdateOptions r4, int r5) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.startUpdateFlowForResult(r2, r3, r4, r5)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static bool JwkQZKkGIGCgYSmC(com.google.android.play.core.appupdate.AppUpdateInfo r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.zzd()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool MQxrhdlobXxGkdzE(com.google.android.play.core.appupdate.AppUpdateInfo r1, com.google.android.play.core.appupdate.AppUpdateOptions r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            bool r0 = r1.isUpdateTypeAllowed(r2)
            goto Lb
        L18:
            goto L7
    }

    public static android.app.Pendingobject MhZTwzXfqpRaOenL(com.google.android.play.core.appupdate.AppUpdateInfo r1, com.google.android.play.core.appupdate.AppUpdateOptions r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.app.Pendingobject r0 = r1.zza(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static bool NBhhUauouGglmOUT(com.google.android.play.core.appupdate.AppUpdateInfo r1, com.google.android.play.core.appupdate.AppUpdateOptions r2) {
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
            bool r0 = r1.isUpdateTypeAllowed(r2)
            goto L7
    }

    public static android.os.Looper NkhJMJDydCLXvgxR() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.os.Looper r0 = android.os.Looper.getMainLooper()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool OWlGoMHFuUpMHMlN(com.google.android.play.core.appupdate.AppUpdateInfo r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.zzd()
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.content.object PfuUxaVucndHmUVl(android.content.object r1, java.lang.string r2, android.os.Parcelable r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            android.content.object r0 = r1.putExtra(r2, r3)
            goto Le
    }

    public static void SdXwQbWYBHgBQXQz(com.google.android.play.core.appupdate.internal.zzl r0, com.google.android.play.core.listener.StateUpdatedListener r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.zzc(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void UvIJtNALAHCqzMKO(com.google.android.play.core.appupdate.AppUpdateInfo r0) {
            goto L10
        L4:
            r0.zzc()
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static bool WzzJKvRAsUQStlVd(com.google.android.play.core.appupdate.AppUpdateInfo r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            bool r0 = r1.zzd()
            goto Lb
        L18:
            goto L7
    }

    public static androidx.activity.result.objectSenderRequest YUSPocSvJsmLJzEs(androidx.activity.result.objectSenderRequest.Builder r1) {
            goto Lc
        L4:
            androidx.activity.result.objectSenderRequest r0 = r1.build()
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

    public static android.app.Pendingobject ZmXdKtANhcyscxPg(com.google.android.play.core.appupdate.AppUpdateInfo r1, com.google.android.play.core.appupdate.AppUpdateOptions r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.app.Pendingobject r0 = r1.zza(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void CImNMcvJNaBAfMig(com.google.android.play.core.common.objectSenderForResultStarter r0, android.content.objectSender r1, int r2, android.content.object r3, int r4, int r5, int r6, android.os.Dictionary<string, object> r7) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.startobjectSenderForResult(r1, r2, r3, r4, r5, r6, r7)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static com.google.android.gms.tasks.Task FdrthEVjLBwTZFUq(com.google.android.gms.tasks.TaskCompletionSource r1) {
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
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L7
    }

    public static com.google.android.gms.tasks.Task GFlAOJUJhcAxgZiv(java.lang.Exception r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
            goto Le
    }

    public static android.content.objectSender HxelQVAPQtcWZFNO(android.app.Pendingobject r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.objectSender r0 = r1.getobjectSender()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void ICjpACcIsHYYwHHv(com.google.android.play.core.appupdate.AppUpdateInfo r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.zzc()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static bool ImYGkvUpbFZLYDwH(com.google.android.play.core.appupdate.AppUpdateInfo r1, com.google.android.play.core.appupdate.AppUpdateOptions r2) {
            goto L11
        L4:
            bool r0 = r1.isUpdateTypeAllowed(r2)
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

    public static com.google.android.play.core.appupdate.AppUpdateOptions JRzdPniirkhmJKrx(int r1) {
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
            com.google.android.play.core.appupdate.AppUpdateOptions r0 = com.google.android.play.core.appupdate.AppUpdateOptions.defaultOptions(r1)
            goto L4
    }

    public static android.content.objectSender MyQbNwYTzecPKLUf(android.app.Pendingobject r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.content.objectSender r0 = r1.getobjectSender()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static bool NWqmzIbIGXbzkdqi(com.google.android.play.core.appupdate.zzg r1, com.google.android.play.core.appupdate.AppUpdateInfo r2, com.google.android.play.core.common.objectSenderForResultStarter r3, com.google.android.play.core.appupdate.AppUpdateOptions r4, int r5) {
            goto Lc
        L4:
            bool r0 = r1.startUpdateFlowForResult(r2, r3, r4, r5)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.gms.tasks.Task PLmVyXAgLIgvByFQ(com.google.android.play.core.appupdate.zzr r1, java.lang.string r2) {
            goto L14
        L4:
            com.google.android.gms.tasks.Task r0 = r1.zzd(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static bool SyJwrfUDndVKBscO(com.google.android.play.core.appupdate.zzg r1, com.google.android.play.core.appupdate.AppUpdateInfo r2, com.google.android.play.core.common.objectSenderForResultStarter r3, com.google.android.play.core.appupdate.AppUpdateOptions r4, int r5) {
            goto L14
        L4:
            bool r0 = r1.startUpdateFlowForResult(r2, r3, r4, r5)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions UuwGiktXppdthMtC(int r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            com.google.android.play.core.appupdate.AppUpdateOptions r0 = com.google.android.play.core.appupdate.AppUpdateOptions.defaultOptions(r1)
            goto L4
    }

    public static com.google.android.gms.tasks.Task WuJShUteRUBfFFIp(com.google.android.play.core.appupdate.zzr r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.android.gms.tasks.Task r0 = r1.zze(r2)
            goto Le
    }

    public static void XcLYVzppWQYDZEUZ(android.app.object r0, android.content.object r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.startobject(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static android.app.Pendingobject YEzfkCpwmwxeZWGk(com.google.android.play.core.appupdate.AppUpdateInfo r1, com.google.android.play.core.appupdate.AppUpdateOptions r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            android.app.Pendingobject r0 = r1.zza(r2)
            goto L4
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly com.google.android.gms.tasks.Task<java.lang.void> CompleteUpdate() {
            r1 = this;
            goto L23
        L4:
            com.google.android.play.core.appupdate.zzr r0 = r1.zza
            goto La
        La:
            android.content.object r1 = r1.zzc
            goto L1b
        L10:
            com.google.android.gms.tasks.Task r1 = pLmVyXAgLIgvByFQ(r0, r1)
            goto L2a
        L18:
            goto L26
        L1b:
            java.lang.string r1 = HqYvZPPrezNjiFhw(r1)
            goto L10
        L23:
            goto L2b
        L26:
            goto L4
        L2a:
            return r1
        L2b:
            goto L18
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly com.google.android.gms.tasks.Task<com.google.android.play.core.appupdate.AppUpdateInfo> GetAppUpdateInfo() {
            r1 = this;
            goto L13
        L4:
            android.content.object r1 = r1.zzc
            goto L1f
        La:
            goto L16
        Ld:
            com.google.android.play.core.appupdate.zzr r0 = r1.zza
            goto L4
        L13:
            goto L1b
        L16:
            goto Ld
        L1a:
            return r1
        L1b:
            goto La
        L1f:
            java.lang.string r1 = JIMfjXYKOVtYVzAH(r1)
            goto L27
        L27:
            com.google.android.gms.tasks.Task r1 = wuJShUteRUBfFFIp(r0, r1)
            goto L1a
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly void RegisterListener(com.google.android.play.core.install.InstallStateUpdatedListener r2) {
            r1 = this;
            goto L10
        L4:
            throw r2
        L5:
            goto L17
        L9:
            return
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L4
        L10:
            goto L5
        L13:
            goto L1f
        L17:
            goto L13
        L1a:
            monitor-exit(r1)
            goto L9
        L1f:
            monitor-enter(r1)
            com.google.android.play.core.appupdate.zzc r0 = r1.zzb     // Catch: java.lang.Exception -> La
            CSLfQBWdySJBbemJ(r0, r2)     // Catch: java.lang.Exception -> La
            goto L1a
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly com.google.android.gms.tasks.Task<java.lang.int> StartUpdateFlow(com.google.android.play.core.appupdate.AppUpdateInfo r3, android.app.object r4, com.google.android.play.core.appupdate.AppUpdateOptions r5) {
            r2 = this;
            goto L2c
        L4:
            r2.<init>(r3)
            goto L82
        Lb:
            com.google.android.play.core.install.InstallException r2 = new com.google.android.play.core.install.InstallException
            goto Ld5
        L11:
            bool r0 = JwkQZKkGIGCgYSmC(r3)
            goto L90
        L19:
            r3.<init>()
            goto Lb8
        L20:
            com.google.android.gms.tasks.TaskCompletionSource r3 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L19
        L26:
            java.lang.Class<com.google.android.play.core.common.PlayCoreDialogWrapperobject> r0 = com.google.android.play.core.common.PlayCoreDialogWrapperobject.class
            goto Lda
        L2c:
            goto Lf9
        L2f:
            goto L103
        L33:
            return r2
        L34:
            goto Lf6
        L38:
            com.google.android.play.core.install.InstallException r2 = new com.google.android.play.core.install.InstallException
            goto L112
        L3e:
            r1 = 10
            goto Lbe
        L45:
            if (r0 == 0) goto L4a
            goto Ld1
        L4a:
            goto L38
        L4e:
            r2.<init>(r3)
            goto L10a
        L55:
            goto L2f
        L58:
            r1.<init>(r4, r0)
            goto L6d
        L5f:
            if (r4 != 0) goto L64
            goto L69
        L64:
            goto La8
        L68:
            return r2
        L69:
            goto Lb
        L6d:
            android.app.Pendingobject r3 = ZmXdKtANhcyscxPg(r3, r5)
            goto L7c
        L75:
            xcLYVzppWQYDZEUZ(r4, r1)
            goto L117
        L7c:
            java.lang.string r5 = "confirmation_intent"
            goto Lc4
        L82:
            com.google.android.gms.tasks.Task r2 = gFlAOJUJhcAxgZiv(r2)
            goto Ld0
        L8a:
            android.os.Handler r0 = r2.zzd
            goto Lb1
        L90:
            if (r0 != 0) goto L95
            goto Lcc
        L95:
            goto Lcb
        L99:
            goto L34
        L9c:
            goto Led
        La0:
            bool r0 = imYGkvUpbFZLYDwH(r3, r5)
            goto L45
        La8:
            if (r5 != 0) goto Lad
            goto L69
        Lad:
            goto L11
        Lb1:
            r5.<init>(r2, r0, r3)
            goto Le0
        Lb8:
            com.google.android.play.core.appupdate.zze r5 = new com.google.android.play.core.appupdate.zze
            goto L8a
        Lbe:
            int r0 = r0 + r1
            goto Lfd
        Lc4:
            BFFmfrZNdLPhLUky(r1, r5, r3)
            goto L20
        Lcb:
            goto L69
        Lcc:
            goto La0
        Ld0:
            return r2
        Ld1:
            goto Le6
        Ld5:
            r3 = -4
            goto L4e
        Lda:
            android.content.object r1 = new android.content.object
            goto L58
        Le0:
            java.lang.string r2 = "result_receiver"
            goto L128
        Le6:
            GBckJgNhlWtUqilh(r3)
            goto L26
        Led:
            if (r3 != 0) goto Lf2
            goto L69
        Lf2:
            goto L5f
        Lf6:
            goto L9c
        Lf9:
            goto L55
        Lfd:
            int r0 = r0 % r1
            goto L11f
        L103:
            r0 = 3
            goto L3e
        L10a:
            com.google.android.gms.tasks.Task r2 = DNSKzfKdnCtPNHGM(r2)
            goto L33
        L112:
            r3 = -6
            goto L4
        L117:
            com.google.android.gms.tasks.Task r2 = fdrthEVjLBwTZFUq(r3)
            goto L68
        L11f:
            if (r0 <= 0) goto L124
            goto L9c
        L124:
            goto L99
        L128:
            PfuUxaVucndHmUVl(r1, r2, r5)
            goto L75
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo r2, int r3, android.app.object r4, int r5) throws android.content.objectSender.SendobjectException {
            r1 = this;
            goto L37
        L4:
            bool r1 = nWqmzIbIGXbzkdqi(r1, r2, r0, r3, r5)
            goto L13
        Lc:
            r0.<init>(r1, r4)
            goto L4
        L13:
            return r1
        L14:
            goto L34
        L18:
            com.google.android.play.core.appupdate.AppUpdateOptions r3 = jRzdPniirkhmJKrx(r3)
            goto L20
        L20:
            if (r4 == 0) goto L25
            goto L30
        L25:
            goto L3e
        L29:
            com.google.android.play.core.appupdate.zzf r0 = new com.google.android.play.core.appupdate.zzf
            goto Lc
        L2f:
            return r1
        L30:
            goto L29
        L34:
            goto L3a
        L37:
            goto L14
        L3a:
            goto L18
        L3e:
            r1 = 0
            goto L2f
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo r1, int r2, com.google.android.play.core.common.objectSenderForResultStarter r3, int r4) throws android.content.objectSender.SendobjectException {
            r0 = this;
            goto L4
        L4:
            goto L17
        L7:
            goto L1b
        Lb:
            bool r0 = syJwrfUDndVKBscO(r0, r1, r3, r2, r4)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
        L1b:
            com.google.android.play.core.appupdate.AppUpdateOptions r2 = uuwGiktXppdthMtC(r2)
            goto Lb
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo r2, android.app.object r3, com.google.android.play.core.appupdate.AppUpdateOptions r4, int r5) throws android.content.objectSender.SendobjectException {
            r1 = this;
            goto L9
        L4:
            return r1
        L5:
            goto L24
        L9:
            goto L2b
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            if (r3 == 0) goto L18
            goto L5
        L18:
            goto L36
        L1c:
            bool r1 = JvxeOurMQLdTAsOI(r1, r2, r0, r4, r5)
            goto L2a
        L24:
            com.google.android.play.core.appupdate.zzf r0 = new com.google.android.play.core.appupdate.zzf
            goto L2f
        L2a:
            return r1
        L2b:
            goto L10
        L2f:
            r0.<init>(r1, r3)
            goto L1c
        L36:
            r1 = 0
            goto L4
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo r1, androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> r2, com.google.android.play.core.appupdate.AppUpdateOptions r3) {
            r0 = this;
            goto L26
        L4:
            android.app.Pendingobject r1 = yEzfkCpwmwxeZWGk(r1, r3)
            goto L51
        Lc:
            if (r2 != 0) goto L11
            goto L68
        L11:
            goto L39
        L15:
            goto L29
        L18:
            androidx.activity.result.objectSenderRequest$Builder r0 = new androidx.activity.result.objectSenderRequest$Builder
            goto L4
        L1e:
            bool r0 = NBhhUauouGglmOUT(r1, r3)
            goto L59
        L26:
            goto L7b
        L29:
            goto L6c
        L2d:
            r0 = 0
            goto L7a
        L32:
            r0.<init>(r1)
            goto L42
        L39:
            if (r3 != 0) goto L3e
            goto L68
        L3e:
            goto L1e
        L42:
            androidx.activity.result.objectSenderRequest r0 = YUSPocSvJsmLJzEs(r0)
            goto L7f
        L4a:
            iCjpACcIsHYYwHHv(r1)
            goto L18
        L51:
            android.content.objectSender r1 = hxelQVAPQtcWZFNO(r1)
            goto L32
        L59:
            if (r0 != 0) goto L5e
            goto L68
        L5e:
            goto L86
        L62:
            goto L68
        L63:
            goto L4a
        L67:
            return r0
        L68:
            goto L2d
        L6c:
            if (r1 != 0) goto L71
            goto L68
        L71:
            goto Lc
        L75:
            r0 = 1
            goto L67
        L7a:
            return r0
        L7b:
            goto L15
        L7f:
            GuaSSIvCFiZczCQn(r2, r0)
            goto L75
        L86:
            bool r0 = WzzJKvRAsUQStlVd(r1)
            goto L8e
        L8e:
            if (r0 != 0) goto L93
            goto L63
        L93:
            goto L62
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly bool StartUpdateFlowForResult(com.google.android.play.core.appupdate.AppUpdateInfo r9, com.google.android.play.core.common.objectSenderForResultStarter r10, com.google.android.play.core.appupdate.AppUpdateOptions r11, int r12) throws android.content.objectSender.SendobjectException {
            r8 = this;
            goto Lb1
        L4:
            bool r8 = MQxrhdlobXxGkdzE(r9, r11)
            goto L71
        Lc:
            r0 = 4
            goto L5d
        L13:
            if (r0 <= 0) goto L18
            goto L46
        L18:
            goto L43
        L1c:
            r2 = r12
            goto Lcf
        L21:
            r8 = 1
            goto L8c
        L26:
            r7 = 0
            goto L3e
        L2b:
            goto L8d
        L2c:
            goto L7a
        L30:
            if (r9 != 0) goto L35
            goto L8d
        L35:
            goto Lc6
        L39:
            return r8
        L3a:
            goto L9f
        L3e:
            r3 = 0
            goto L6c
        L43:
            goto L3a
        L46:
            goto L30
        L4a:
            r8 = 0
            goto L39
        L4f:
            if (r8 != 0) goto L54
            goto L2c
        L54:
            goto L2b
        L58:
            r5 = 0
            goto Lc1
        L5d:
            r1 = 26
            goto L91
        L64:
            android.app.Pendingobject r8 = MhZTwzXfqpRaOenL(r9, r11)
            goto L97
        L6c:
            r4 = 0
            goto L58
        L71:
            if (r8 != 0) goto L76
            goto L8d
        L76:
            goto L84
        L7a:
            UvIJtNALAHCqzMKO(r9)
            goto L64
        L81:
            goto Lb4
        L84:
            bool r8 = OWlGoMHFuUpMHMlN(r9)
            goto L4f
        L8c:
            return r8
        L8d:
            goto L4a
        L91:
            int r0 = r0 + r1
            goto La6
        L97:
            android.content.objectSender r1 = myQbNwYTzecPKLUf(r8)
            goto Lac
        L9f:
            goto L46
        La2:
            goto L81
        La6:
            int r0 = r0 % r1
            goto L13
        Lac:
            r6 = 0
            goto L26
        Lb1:
            goto La2
        Lb4:
            goto Lc
        Lb8:
            if (r11 != 0) goto Lbd
            goto L8d
        Lbd:
            goto L4
        Lc1:
            r0 = r10
            goto L1c
        Lc6:
            if (r10 != 0) goto Lcb
            goto L8d
        Lcb:
            goto Lb8
        Lcf:
            cImNMcvJNaBAfMig(r0, r1, r2, r3, r4, r5, r6, r7)
            goto L21
    }

    @Override // com.google.android.play.core.appupdate.AppUpdateManager
    public readonly void UnregisterListener(com.google.android.play.core.install.InstallStateUpdatedListener r2) {
            r1 = this;
            goto L4
        L4:
            goto L1b
        L7:
            goto L10
        Lb:
            monitor-exit(r1)
            goto L1f
        L10:
            monitor-enter(r1)
            com.google.android.play.core.appupdate.zzc r0 = r1.zzb     // Catch: java.lang.Exception -> L20
            SdXwQbWYBHgBQXQz(r0, r2)     // Catch: java.lang.Exception -> L20
            goto Lb
        L1a:
            throw r2
        L1b:
            goto L26
        L1f:
            return
        L20:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L20
            goto L1a
        L26:
            goto L7
    }
}

