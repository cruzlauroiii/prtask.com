namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public abstract class GservicesValue<T> {
    private static readonly java.lang.object zzc = null;
    protected readonly java.lang.string zza;
    protected readonly java.lang.object zzb;
    private java.lang.object zzd;

    static {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            java.lang.object r0 = new java.lang.object
            goto L1f
        L19:
            com.google.android.gms.common.config.GservicesValue.zzc = r0
            goto Le
        L1f:
            r0.<init>()
            goto L19
    }

    protected GservicesValue(java.lang.string r2, java.lang.object r3) {
            r1 = this;
            goto La
        L4:
            r1.zzb = r3
            goto L17
        La:
            goto L18
        Ld:
            goto L24
        L11:
            r1.zzd = r0
            goto L2b
        L17:
            return
        L18:
            goto L21
        L1c:
            r0 = 0
            goto L11
        L21:
            goto Ld
        L24:
            r1.<init>()
            goto L1c
        L2b:
            r1.zza = r2
            goto L4
    }

    public static java.lang.object ASJiqbFbDdtcDGgV(com.google.android.gms.common.config.GservicesValue r1, java.lang.string r2) {
            goto L11
        L4:
            java.lang.object r0 = r1.zza(r2)
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

    public static java.lang.bool DXKRXPFWNftWfESs(bool r1) {
            goto Lc
        L4:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
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

    public static android.os.StrictMode.ThreadPolicy GCVYnyurypXDXHZf() {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.os.StrictMode$ThreadPolicy r0 = android.os.StrictMode.allowThreadDiskReads()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void RKUxExAxIjrOGzES(long r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.os.Binder.restoreCallingIdentity(r0)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static int RrMWXSuvuzNsLZtT(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.w(r1, r2)
            goto L4
    }

    public static void TkHkBQTVWYHOViXH(android.os.StrictMode.ThreadPolicy r0) {
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
            android.os.StrictMode.setThreadPolicy(r0)
            goto L4
    }

    public static java.lang.object AunCrKrWwqynXsmx(com.google.android.gms.common.config.GservicesValue r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1[)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object FNkZRiROXNDfNoxP(com.google.android.gms.common.config.GservicesValue r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = r1.zza(r2)
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

    public static void HhdJgLAuejuCdGpP(long r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            android.os.Binder.restoreCallingIdentity(r0)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static bool IsInitialized() {
            goto L23
        L4:
            throw r1
        L5:
            goto L46
        L9:
            monitor-enter(r0)
            monitor-exit(r0)     // Catch: java.lang.Exception -> Ld
            r0 = 0
            return r0
        Ld:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Ld
            goto L4
        L13:
            goto L26
        L16:
            int r0 = r0 % r1
            goto L3d
        L1c:
            r0 = 11
            goto L2a
        L23:
            goto L49
        L26:
            goto L1c
        L2a:
            r1 = 17
            goto L37
        L31:
            java.lang.object r0 = com.google.android.gms.common.config.GservicesValue.zzc
            goto L9
        L37:
            int r0 = r0 + r1
            goto L16
        L3d:
            if (r0 <= 0) goto L42
            goto L50
        L42:
            goto L4d
        L46:
            goto L50
        L49:
            goto L13
        L4d:
            goto L5
        L50:
            goto L31
    }

    public static long KqQFoYMwRTznhkTx() {
            goto L3e
        L4:
            r1 = 24
            goto L14
        Lb:
            if (r0 <= 0) goto L10
            goto L37
        L10:
            goto L34
        L14:
            int r0 = r0 + r1
            goto L2e
        L1a:
            return r0
        L1b:
            goto L1f
        L1f:
            goto L37
        L22:
            goto L3b
        L26:
            long r0 = android.os.Binder.clearCallingIdentity()
            goto L1a
        L2e:
            int r0 = r0 % r1
            goto Lb
        L34:
            goto L1b
        L37:
            goto L26
        L3b:
            goto L41
        L3e:
            goto L22
        L41:
            goto L45
        L45:
            r0 = 16
            goto L4
    }

    public static void MGyNoOnHQztTzdvL(android.os.StrictMode.ThreadPolicy r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.os.StrictMode.setThreadPolicy(r0)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static com.google.android.gms.common.config.GservicesValue<java.lang.float> Value(java.lang.string r1, java.lang.float r2) {
            goto Ld
        L4:
            goto L10
        L7:
            com.google.android.gms.common.config.zzd r0 = new com.google.android.gms.common.config.zzd
            goto L19
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return r0
        L15:
            goto L4
        L19:
            r0.<init>(r1, r2)
            goto L14
    }

    public static com.google.android.gms.common.config.GservicesValue<java.lang.int> Value(java.lang.string r1, java.lang.int r2) {
            goto La
        L4:
            com.google.android.gms.common.config.zzc r0 = new com.google.android.gms.common.config.zzc
            goto L11
        La:
            goto L1c
        Ld:
            goto L4
        L11:
            r0.<init>(r1, r2)
            goto L1b
        L18:
            goto Ld
        L1b:
            return r0
        L1c:
            goto L18
    }

    public static com.google.android.gms.common.config.GservicesValue<java.lang.long> Value(java.lang.string r1, java.lang.long r2) {
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
            com.google.android.gms.common.config.zzb r0 = new com.google.android.gms.common.config.zzb
            goto L19
        L19:
            r0.<init>(r1, r2)
            goto Le
    }

    public static com.google.android.gms.common.config.GservicesValue<java.lang.string> Value(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto L1a
        Lb:
            r0.<init>(r1, r2)
            goto L12
        L12:
            return r0
        L13:
            goto L17
        L17:
            goto L7
        L1a:
            com.google.android.gms.common.config.zze r0 = new com.google.android.gms.common.config.zze
            goto Lb
    }

    public static com.google.android.gms.common.config.GservicesValue<java.lang.bool> Value(java.lang.string r1, bool r2) {
            goto L1a
        L4:
            goto L1d
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.bool r2 = DXKRXPFWNftWfESs(r2)
            goto L21
        L14:
            com.google.android.gms.common.config.zza r0 = new com.google.android.gms.common.config.zza
            goto Lc
        L1a:
            goto L8
        L1d:
            goto L14
        L21:
            r0.<init>(r1, r2)
            goto L7
    }

    public readonly T Get() {
            r4 = this;
            goto L56
        L4:
            TkHkBQTVWYHOViXH(r0)
            goto L8b
        Lb:
            monitor-enter(r1)
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1f
            goto Laa
        L11:
            r1 = 8
            goto L7f
        L18:
            java.lang.object r1 = com.google.android.gms.common.config.GservicesValue.zzc
            goto Lb
        L1e:
            throw r4
        L1f:
            r4 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1f
            goto La5
        L25:
            goto L3a
        L28:
            goto L6d
        L2c:
            return r0
        L2d:
            goto L77
        L31:
            int r0 = r0 % r1
            goto L9c
        L37:
            goto La6
        L3a:
            goto L85
        L3e:
            goto L91
        L3f:
            long r1 = kqQFoYMwRTznhkTx()     // Catch: java.lang.Exception -> L51
            java.lang.string r3 = r4.zza     // Catch: java.lang.Exception -> L8c
            java.lang.object r4 = ASJiqbFbDdtcDGgV(r4, r3)     // Catch: java.lang.Exception -> L8c
            hhdJgLAuejuCdGpP(r1)     // Catch: java.lang.Exception -> L51
        L4c:
            goto L4
        L50:
            goto L4c
        L51:
            r4 = move-exception
            goto L3e
        L56:
            goto L28
        L59:
            goto L70
        L5d:
            if (r0 != 0) goto L62
            goto L2d
        L62:
            goto L2c
        L66:
            mGyNoOnHQztTzdvL(r0)
            goto L95
        L6d:
            goto L59
        L70:
            r0 = 1
            goto L11
        L77:
            android.os.StrictMode$ThreadPolicy r0 = GCVYnyurypXDXHZf()
            goto L18
        L7f:
            int r0 = r0 + r1
            goto L31
        L85:
            java.lang.object r0 = r4.zzd
            goto L5d
        L8b:
            return r4
        L8c:
            r4 = move-exception
            RKUxExAxIjrOGzES(r1)     // Catch: java.lang.Exception -> L51
            throw r4     // Catch: java.lang.Exception -> L51
        L91:
            goto L66
        L95:
            throw r4
        L96:
            r4 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L96
            goto L1e
        L9c:
            if (r0 <= 0) goto La1
            goto L3a
        La1:
            goto L37
        La5:
            throw r4
        La6:
            goto L25
        Laa:
            monitor-enter(r1)
            monitor-exit(r1)     // Catch: java.lang.Exception -> L96
            java.lang.string r1 = r4.zza     // Catch: java.lang.SecurityException -> L3f java.lang.Exception -> L51
            java.lang.object r4 = fNkZRiROXNDfNoxP(r4, r1)     // Catch: java.lang.SecurityException -> L3f java.lang.Exception -> L51
            goto L50
    }

    @java.lang.Deprecated
    public readonly T GetBinderSafe() {
            r0 = this;
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = aunCrKrWwqynXsmx(r0)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public void Override(T r3) {
            r2 = this;
            goto L5a
        L4:
            int r0 = r0 % r1
            goto L20
        La:
            int r0 = r0 + r1
            goto L4
        L10:
            r2.zzd = r3
            goto L2c
        L16:
            return
        L17:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L17
            throw r3     // Catch: java.lang.Exception -> L1a
        L1a:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1a
            goto L4f
        L20:
            if (r0 <= 0) goto L25
            goto L44
        L25:
            goto L41
        L29:
            goto L5d
        L2c:
            java.lang.object r2 = com.google.android.gms.common.config.GservicesValue.zzc
            goto L32
        L32:
            monitor-enter(r2)
            monitor-enter(r2)     // Catch: java.lang.Exception -> L1a
            monitor-exit(r2)     // Catch: java.lang.Exception -> L17
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1a
            goto L16
        L3a:
            RrMWXSuvuzNsLZtT(r0, r1)
            goto L10
        L41:
            goto L50
        L44:
            goto L54
        L48:
            r1 = 1
            goto La
        L4f:
            throw r3
        L50:
            goto L68
        L54:
            java.lang.string r0 = "GservicesValue"
            goto L6f
        L5a:
            goto L6b
        L5d:
            goto L61
        L61:
            r0 = 31
            goto L48
        L68:
            goto L44
        L6b:
            goto L29
        L6f:
            java.lang.string r1 = "GservicesValue.override(): test should probably call initForTests() first"
            goto L3a
    }

    public void ResetOverride() {
            r1 = this;
            goto Lf
        L4:
            r1.zzd = r0
            goto L16
        La:
            r0 = 0
            goto L4
        Lf:
            goto L17
        L12:
            goto La
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L12
    }

    protected abstract java.lang.object Zza(java.lang.string r1);
}

