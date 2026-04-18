namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzil : com.google.android.gms.measurement.internal.zzjr {
    private static readonly java.util.concurrent.atomic.Atomiclong zza = null;
    private com.google.android.gms.measurement.internal.zzik zzb;
    private com.google.android.gms.measurement.internal.zzik zzc;
    private readonly java.util.concurrent.PriorityBlockingQueue zzd;
    private readonly java.util.concurrent.BlockingQueue zze;
    private readonly java.lang.Thread.UncaughtExceptionHandler zzf;
    private readonly java.lang.Thread.UncaughtExceptionHandler zzg;
    private readonly java.lang.object zzh;
    private readonly java.util.concurrent.SemaphoreSlim zzi;
    private bool zzj;

    static {
            goto L44
        L4:
            int r0 = r0 + r1
            goto L4b
        La:
            if (r0 <= 0) goto Lf
            goto L2a
        Lf:
            goto L27
        L13:
            r0.<init>(r1)
            goto L21
        L1a:
            r1 = 3
            goto L4
        L21:
            com.google.android.gms.measurement.internal.zzil.zza = r0
            goto L58
        L27:
            goto L59
        L2a:
            goto L2e
        L2e:
            java.util.concurrent.atomic.Atomiclong r0 = new java.util.concurrent.atomic.Atomiclong
            goto L3e
        L34:
            r0 = 27
            goto L1a
        L3b:
            goto L47
        L3e:
            r1 = -9223372036854775808
            goto L13
        L44:
            goto L54
        L47:
            goto L34
        L4b:
            int r0 = r0 % r1
            goto La
        L51:
            goto L2a
        L54:
            goto L3b
        L58:
            return
        L59:
            goto L51
    }

    zzil(com.google.android.gms.measurement.internal.zzio r2) {
            r1 = this;
            goto L6a
        L4:
            goto L6d
        L7:
            com.google.android.gms.measurement.internal.zzii r2 = new com.google.android.gms.measurement.internal.zzii
            goto Ld
        Ld:
            java.lang.string r0 = "Thread death: Uncaught exception on worker thread"
            goto L1f
        L13:
            r1.zzi = r2
            goto L5e
        L19:
            com.google.android.gms.measurement.internal.zzii r2 = new com.google.android.gms.measurement.internal.zzii
            goto L71
        L1f:
            r2.<init>(r1, r0)
            goto L83
        L26:
            r2.<init>()
            goto L7d
        L2d:
            return
        L2e:
            goto L4
        L32:
            r1.zze = r2
            goto L7
        L38:
            r2.<init>()
            goto L97
        L3f:
            java.util.concurrent.LinkedBlockingQueue r2 = new java.util.concurrent.LinkedBlockingQueue
            goto L57
        L45:
            java.lang.object r2 = new java.lang.object
            goto L38
        L4b:
            r1.<init>(r2)
            goto L45
        L52:
            r0 = 2
            goto L90
        L57:
            r2.<init>()
            goto L32
        L5e:
            java.util.concurrent.PriorityBlockingQueue r2 = new java.util.concurrent.PriorityBlockingQueue
            goto L26
        L64:
            java.util.concurrent.SemaphoreSlim r2 = new java.util.concurrent.SemaphoreSlim
            goto L52
        L6a:
            goto L2e
        L6d:
            goto L4b
        L71:
            java.lang.string r0 = "Thread death: Uncaught exception on network thread"
            goto L89
        L77:
            r1.zzg = r2
            goto L2d
        L7d:
            r1.zzd = r2
            goto L3f
        L83:
            r1.zzf = r2
            goto L19
        L89:
            r2.<init>(r1, r0)
            goto L77
        L90:
            r2.<init>(r0)
            goto L13
        L97:
            r1.zzh = r2
            goto L64
    }

    public static java.lang.object AYZUGNqpVkiiFyxL(java.lang.object r1) {
            goto L11
        L4:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
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

    public static java.lang.object BEjechZRSnRWZSgq(java.lang.object r1) {
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
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
            goto L4
    }

    public static void EAKjezcbUHzpnKxo(com.google.android.gms.measurement.internal.zzil r0, com.google.android.gms.measurement.internal.zzij r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.zzz(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static java.lang.Thread ELxHYVBGmwVbgCjd() {
            goto L11
        L4:
            java.lang.Thread r0 = java.lang.Thread.currentThread()
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

    public static void FPmElmZGhlgOLSGR(com.google.android.gms.measurement.internal.zzik r0) {
            goto L13
        L4:
            r0.zza()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static bool FanfMZmOxKYTlarj(java.util.concurrent.BlockingQueue r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Le
    }

    public static void FjgEmYNdaBTrvxZB(com.google.android.gms.measurement.internal.zzik r0) {
            goto Lb
        L4:
            r0.start()
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void GyDQBhJieDfWvLBQ(com.google.android.gms.measurement.internal.zzik r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.start()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.Thread HpFcmyLltTLObbAZ() {
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
            java.lang.Thread r0 = java.lang.Thread.currentThread()
            goto L4
    }

    public static com.google.android.gms.measurement.internal.zzhc JePATQaMnNMfYJRf(com.google.android.gms.measurement.internal.zzhe r1) {
            goto Lc
        L4:
            com.google.android.gms.measurement.internal.zzhc r0 = r1.zzk()
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

    public static com.google.android.gms.measurement.internal.zzhe JhuHgUzfnVGpxyjy(com.google.android.gms.measurement.internal.zzio r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.gms.measurement.internal.zzhe r0 = r1.zzaW()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object KbJslKgJBkIoxHVl(java.lang.object r1) {
            goto L14
        L4:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
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

    public static void KoJdilcbFOjCioOL(com.google.android.gms.measurement.internal.zzhc r0, java.lang.string r1) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.zza(r1)
            goto L4
    }

    public static java.lang.Thread LfvbMUkIxsKZmiMo() {
            goto L14
        L4:
            java.lang.Thread r0 = java.lang.Thread.currentThread()
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

    public static void MsCutMbqwYNkXJTh(com.google.android.gms.measurement.internal.zzij r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.run()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static com.google.android.gms.measurement.internal.zzhe NZGFpsRPPDoZChVw(com.google.android.gms.measurement.internal.zzio r1) {
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
            com.google.android.gms.measurement.internal.zzhe r0 = r1.zzaW()
            goto Le
    }

    public static void OYvIGZExPFXvGTPT(com.google.android.gms.measurement.internal.zzhc r0, java.lang.string r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.zza(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static com.google.android.gms.measurement.internal.zzhc QHrnXxwIiHahSbGg(com.google.android.gms.measurement.internal.zzhe r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.gms.measurement.internal.zzhc r0 = r1.zzk()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string QUvHjYTqPVMKDiiv(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto L4
    }

    public static java.lang.string SHSjGgdwQAubBcij(java.lang.string r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.concat(r2)
            goto L4
    }

    public static java.lang.Thread TiQDLiKRvzPLzDJw() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.Thread r0 = java.lang.Thread.currentThread()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.Thread UxYopWqRmtrbRFJm() {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.Thread r0 = java.lang.Thread.currentThread()
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

    public static java.lang.Thread VfIVpgBRDrkciZra() {
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
            java.lang.Thread r0 = java.lang.Thread.currentThread()
            goto L4
    }

    public static void WFKetlXivrjXWGSY(com.google.android.gms.measurement.internal.zzhc r0, java.lang.string r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.zza(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void AEYIPazmciJLdqmI(com.google.android.gms.measurement.internal.zzik r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.zza()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.stringBuilder AgDMQdYtdnrGzBRA(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void BbSXQsOeSSvdhvME(com.google.android.gms.measurement.internal.zzjr r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.zzv()
            goto Lb
        L17:
            goto L7
    }

    public static void CgJXsjkAMyolUmOm(com.google.android.gms.measurement.internal.zzjr r0) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.zzv()
            goto L4
    }

    public static void DKPUxxhmYdtUrivs(com.google.android.gms.measurement.internal.zzjr r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.zzv()
            goto Lb
        L17:
            goto L7
    }

    public static com.google.android.gms.measurement.internal.zzhc DYWXLmiERcUlUEIv(com.google.android.gms.measurement.internal.zzhe r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.gms.measurement.internal.zzhc r0 = r1.zzk()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object EdSjTLgbVfHIKcSm(java.lang.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void EewJlJRmAytrInUU(com.google.android.gms.measurement.internal.zzil r0, com.google.android.gms.measurement.internal.zzij r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.zzz(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void FXSRpclThLWanFkx(com.google.android.gms.measurement.internal.zzil r0, com.google.android.gms.measurement.internal.zzij r1) {
            goto Lb
        L4:
            r0.zzz(r1)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void GNkFGLhcYkBSnZai(com.google.android.gms.measurement.internal.zzik r0, java.lang.Thread.UncaughtExceptionHandler r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.setUncaughtExceptionHandler(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static java.lang.object HlzVZfpVUrGKCiAb(java.util.concurrent.atomic.object r1) {
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
            java.lang.object r0 = r1[)
            goto Lb
        L18:
            goto L7
    }

    public static void IETiHcyrkjlVMcuN(com.google.android.gms.measurement.internal.zzil r0, com.google.android.gms.measurement.internal.zzij r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.zzz(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void IxkcYhTOVUlWtyUA(com.google.android.gms.measurement.internal.zzik r0, java.lang.Thread.UncaughtExceptionHandler r1) {
            goto Lb
        L4:
            r0.setUncaughtExceptionHandler(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static bool JccFvpWMDuXUScMz(java.util.concurrent.PriorityBlockingQueue r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.Add(r2)
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

    public static com.google.android.gms.measurement.internal.zzil KjeUBhvJqmyCKsyk(com.google.android.gms.measurement.internal.zzio r1) {
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
            com.google.android.gms.measurement.internal.zzil r0 = r1.zzaX()
            goto Le
    }

    public static void LwzIMsSIfFAGaxwF(com.google.android.gms.measurement.internal.zzij r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.run()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void MvcPXgOLmyBYTIhJ(com.google.android.gms.measurement.internal.zzjr r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.zzv()
            goto Lb
        L17:
            goto L7
    }

    public static java.lang.Thread OCugkraHTUNeiblG() {
            goto L14
        L4:
            java.lang.Thread r0 = java.lang.Thread.currentThread()
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

    public static java.lang.object PedladnShMIDAlWQ(java.lang.object r1) {
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
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
            goto Lb
        L18:
            goto L7
    }

    public static bool TDFzVPXcWVkdqCiG(java.util.concurrent.PriorityBlockingQueue r1) {
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
            bool r0 = r1.Count == 0
            goto L4
    }

    public static void ThEjPQOwwMEVuJGp(com.google.android.gms.measurement.internal.zzil r0, java.lang.Action r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.zzq(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static com.google.android.gms.measurement.internal.zzhe UODMGuvxmTCioZTv(com.google.android.gms.measurement.internal.zzio r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.measurement.internal.zzhe r0 = r1.zzaW()
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

    public static void WBNdMhuZlmosZlsS(com.google.android.gms.measurement.internal.zzjr r0) {
            goto Le
        L4:
            r0.zzv()
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void YsXychoOYeLLohQj(java.lang.object r0, long r1) {
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
            r0.wait(r1)
            goto L4
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.measurement.internal.zzik zza(com.google.android.gms.measurement.internal.zzil r0) {
            goto La
        L4:
            com.google.android.gms.measurement.internal.zzik r0 = r0.zzc
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return r0
        L15:
            goto L11
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.measurement.internal.zzik zzb(com.google.android.gms.measurement.internal.zzil r0) {
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            com.google.android.gms.measurement.internal.zzik r0 = r0.zzb
            goto L14
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
    }

    static /* bridge */ /* synthetic */ java.lang.object zzd(com.google.android.gms.measurement.internal.zzil r0) {
            goto L12
        L4:
            goto L15
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r0.zzh
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    static /* bridge */ /* synthetic */ java.util.concurrent.SemaphoreSlim zzi(com.google.android.gms.measurement.internal.zzil r0) {
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
            java.util.concurrent.SemaphoreSlim r0 = r0.zzi
            goto L7
    }

    static /* bridge */ /* synthetic */ java.util.concurrent.atomic.Atomiclong zzj() {
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
            java.util.concurrent.atomic.Atomiclong r0 = com.google.android.gms.measurement.internal.zzil.zza
            goto L7
    }

    static /* bridge */ /* synthetic */ void zzl(com.google.android.gms.measurement.internal.zzil r0, com.google.android.gms.measurement.internal.zzik r1) {
            goto L14
        L4:
            r1 = 0
            goto Le
        L9:
            return
        La:
            goto L1b
        Le:
            r0.zzc = r1
            goto L9
        L14:
            goto La
        L17:
            goto L4
        L1b:
            goto L17
    }

    static /* bridge */ /* synthetic */ void zzm(com.google.android.gms.measurement.internal.zzil r0, com.google.android.gms.measurement.internal.zzik r1) {
            goto L17
        L4:
            r1 = 0
            goto Le
        L9:
            return
        La:
            goto L14
        Le:
            r0.zzb = r1
            goto L9
        L14:
            goto L1a
        L17:
            goto La
        L1a:
            goto L4
    }

    static /* bridge */ /* synthetic */ bool zzs(com.google.android.gms.measurement.internal.zzil r0) {
            goto Lf
        L4:
            bool r0 = r0.zzj
            goto La
        La:
            r0 = 0
            goto L16
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto L1b
        L1b:
            goto L12
    }

    private readonly void Zzz(com.google.android.gms.measurement.internal.zzij r4) {
            r3 = this;
            goto L4c
        L4:
            int r0 = r0 + r1
            goto L6d
        La:
            java.lang.object r0 = r3.zzh
            goto L10
        L10:
            monitor-enter(r0)
            java.util.concurrent.PriorityBlockingQueue r1 = r3.zzd     // Catch: java.lang.Exception -> L33
            jccFvpWMDuXUScMz(r1, r4)     // Catch: java.lang.Exception -> L33
            com.google.android.gms.measurement.internal.zzik r4 = r3.zzb     // Catch: java.lang.Exception -> L33
            if (r4 != 0) goto L2e
            com.google.android.gms.measurement.internal.zzik r4 = new com.google.android.gms.measurement.internal.zzik     // Catch: java.lang.Exception -> L33
            java.lang.string r2 = "Measurement Worker"
            r4.<init>(r3, r2, r1)     // Catch: java.lang.Exception -> L33
            r3.zzb = r4     // Catch: java.lang.Exception -> L33
            java.lang.Thread$UncaughtExceptionHandler r1 = r3.zzf     // Catch: java.lang.Exception -> L33
            gNkFGLhcYkBSnZai(r4, r1)     // Catch: java.lang.Exception -> L33
            com.google.android.gms.measurement.internal.zzik r3 = r3.zzb     // Catch: java.lang.Exception -> L33
            GyDQBhJieDfWvLBQ(r3)     // Catch: java.lang.Exception -> L33
            goto L31
        L2e:
            aEYIPazmciJLdqmI(r4)     // Catch: java.lang.Exception -> L33
        L31:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            return
        L33:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            goto L47
        L39:
            goto L48
        L3c:
            goto La
        L40:
            r0 = 19
            goto L56
        L47:
            throw r3
        L48:
            goto L66
        L4c:
            goto L69
        L4f:
            goto L40
        L53:
            goto L4f
        L56:
            r1 = 12
            goto L4
        L5d:
            if (r0 <= 0) goto L62
            goto L3c
        L62:
            goto L39
        L66:
            goto L3c
        L69:
            goto L53
        L6d:
            int r0 = r0 % r1
            goto L5d
    }

    @Override // com.google.android.gms.measurement.internal.zzjq
    public readonly void ZzaY() {
            r1 = this;
            goto L21
        L4:
            goto L24
        L7:
            throw r1
        L8:
            goto L4
        Lc:
            java.lang.string r0 = "Call expected from network thread"
            goto L12
        L12:
            r1.<init>(r0)
            goto L7
        L19:
            java.lang.Thread r0 = ELxHYVBGmwVbgCjd()
            goto L2d
        L21:
            goto L8
        L24:
            goto L19
        L28:
            return
        L29:
            goto L33
        L2d:
            com.google.android.gms.measurement.internal.zzik r1 = r1.zzc
            goto L39
        L33:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto Lc
        L39:
            if (r0 == r1) goto L3e
            goto L29
        L3e:
            goto L28
    }

    @Override // com.google.android.gms.measurement.internal.zzjr
    protected readonly bool Zzc() {
            r0 = this;
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
            r0 = 0
            goto L4
    }

    readonly java.lang.object zze(java.util.concurrent.atomic.object r3, long r4, java.lang.string r6, java.lang.Action r7) {
            r2 = this;
            goto L20
        L4:
            r1 = 8
            goto L80
        Lb:
            KoJdilcbFOjCioOL(r2, r4)
        Le:
            goto L36
        L12:
            com.google.android.gms.measurement.internal.zzio r2 = r2.zzu
            goto L5f
        L18:
            com.google.android.gms.measurement.internal.zzhc r2 = dYWXLmiERcUlUEIv(r2)
            goto L86
        L20:
            goto L32
        L23:
            goto Lb4
        L27:
            goto L23
        L2a:
            throw r2
        L2b:
            goto L2f
        L2f:
            goto L73
        L32:
            goto L27
        L36:
            return r3
        L37:
            com.google.android.gms.measurement.internal.zzio r2 = r2.zzu     // Catch: java.lang.Exception -> L53
            com.google.android.gms.measurement.internal.zzhe r2 = uODMGuvxmTCioZTv(r2)     // Catch: java.lang.Exception -> L53
            com.google.android.gms.measurement.internal.zzhc r2 = QHrnXxwIiHahSbGg(r2)     // Catch: java.lang.Exception -> L53
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L53
            r4.<init>(r0)     // Catch: java.lang.Exception -> L53
            agDMQdYtdnrGzBRA(r4, r6)     // Catch: java.lang.Exception -> L53
            java.lang.string r4 = QUvHjYTqPVMKDiiv(r4)     // Catch: java.lang.Exception -> L53
            OYvIGZExPFXvGTPT(r2, r4)     // Catch: java.lang.Exception -> L53
            monitor-exit(r3)     // Catch: java.lang.Exception -> L53
            r2 = 0
            return r2
        L53:
            r2 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L53
            goto L2a
        L59:
            java.lang.string r0 = "Interrupted waiting for "
            goto La2
        L5f:
            com.google.android.gms.measurement.internal.zzhe r2 = JhuHgUzfnVGpxyjy(r2)
            goto L18
        L67:
            if (r3 == 0) goto L6c
            goto Le
        L6c:
            goto L12
        L70:
            goto L2b
        L73:
            goto L59
        L77:
            if (r0 <= 0) goto L7c
            goto L73
        L7c:
            goto L70
        L80:
            int r0 = r0 + r1
            goto L94
        L86:
            java.lang.string r4 = "Timed out waiting for "
            goto L8c
        L8c:
            java.lang.string r4 = SHSjGgdwQAubBcij(r4, r6)
            goto Lb
        L94:
            int r0 = r0 % r1
            goto L77
        L9a:
            java.lang.object r3 = hlzVZfpVUrGKCiAb(r3)
            goto L67
        La2:
            monitor-enter(r3)
            com.google.android.gms.measurement.internal.zzio r1 = r2.zzu     // Catch: java.lang.Exception -> L53
            com.google.android.gms.measurement.internal.zzil r1 = kjeUBhvJqmyCKsyk(r1)     // Catch: java.lang.Exception -> L53
            thEjPQOwwMEVuJGp(r1, r7)     // Catch: java.lang.Exception -> L53
            ysXychoOYeLLohQj(r3, r4)     // Catch: java.lang.InterruptedException -> L37 java.lang.Exception -> L53
            monitor-exit(r3)     // Catch: java.lang.Exception -> L53
            goto L9a
        Lb4:
            r0 = 8
            goto L4
    }

    public readonly java.util.concurrent.Task Zzf(java.util.concurrent.Func r4) throws java.lang.IllegalStateException {
            r3 = this;
            goto Lb0
        L4:
            goto Lb8
        L7:
            goto L1d
        Lb:
            java.lang.string r4 = "Func skipped the worker queue."
            goto L74
        L11:
            pedladnShMIDAlWQ(r4)
            goto Lbc
        L18:
            return r0
        L19:
            goto L2a
        L1d:
            dKPUxxhmYdtUrivs(r3)
            goto L11
        L24:
            java.util.concurrent.PriorityBlockingQueue r4 = r3.zzd
            goto L7b
        L2a:
            eewJlJRmAytrInUU(r3, r0)
            goto Lb7
        L31:
            if (r0 <= 0) goto L36
            goto L7
        L36:
            goto L4
        L3a:
            com.google.android.gms.measurement.internal.zzio r3 = r3.zzu
            goto L40
        L40:
            com.google.android.gms.measurement.internal.zzhe r3 = NZGFpsRPPDoZChVw(r3)
            goto L9c
        L48:
            r1 = 0
            goto Lc8
        L4d:
            r0.<init>(r3, r4, r1, r2)
            goto L5e
        L54:
            goto L7
        L57:
            goto L5b
        L5b:
            goto Lb3
        L5e:
            java.lang.Thread r4 = VfIVpgBRDrkciZra()
            goto Laa
        L66:
            MsCutMbqwYNkXJTh(r0)
            goto L18
        L6d:
            r1 = 4
            goto Lc2
        L74:
            WFKetlXivrjXWGSY(r3, r4)
        L77:
            goto L66
        L7b:
            bool r4 = tDFzVPXcWVkdqCiG(r4)
            goto L83
        L83:
            if (r4 == 0) goto L88
            goto L77
        L88:
            goto L3a
        L8c:
            if (r4 == r1) goto L91
            goto L19
        L91:
            goto L24
        L95:
            r0 = 30
            goto L6d
        L9c:
            com.google.android.gms.measurement.internal.zzhc r3 = JePATQaMnNMfYJRf(r3)
            goto Lb
        La4:
            int r0 = r0 % r1
            goto L31
        Laa:
            com.google.android.gms.measurement.internal.zzik r1 = r3.zzb
            goto L8c
        Lb0:
            goto L57
        Lb3:
            goto L95
        Lb7:
            return r0
        Lb8:
            goto L54
        Lbc:
            com.google.android.gms.measurement.internal.zzij r0 = new com.google.android.gms.measurement.internal.zzij
            goto L48
        Lc2:
            int r0 = r0 + r1
            goto La4
        Lc8:
            java.lang.string r2 = "Task exception on worker thread"
            goto L4d
    }

    @Override // com.google.android.gms.measurement.internal.zzjq
    public readonly void Zzg() {
            r1 = this;
            goto L38
        L4:
            java.lang.Thread r0 = HpFcmyLltTLObbAZ()
            goto L22
        Lc:
            r1.<init>(r0)
            goto L33
        L13:
            if (r0 == r1) goto L18
            goto L2f
        L18:
            goto L2e
        L1c:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto L28
        L22:
            com.google.android.gms.measurement.internal.zzik r1 = r1.zzb
            goto L13
        L28:
            java.lang.string r0 = "Call expected from worker thread"
            goto Lc
        L2e:
            return
        L2f:
            goto L1c
        L33:
            throw r1
        L34:
            goto L3f
        L38:
            goto L34
        L3b:
            goto L4
        L3f:
            goto L3b
    }

    public readonly java.util.concurrent.Task Zzh(java.util.concurrent.Func r4) throws java.lang.IllegalStateException {
            r3 = this;
            goto L40
        L4:
            r1 = 1
            goto L77
        L9:
            int r0 = r0 % r1
            goto L25
        Lf:
            r0.<init>(r3, r4, r1, r2)
            goto L2e
        L16:
            if (r4 == r1) goto L1b
            goto L37
        L1b:
            goto L4e
        L1f:
            com.google.android.gms.measurement.internal.zzij r0 = new com.google.android.gms.measurement.internal.zzij
            goto L4
        L25:
            if (r0 <= 0) goto L2a
            goto L73
        L2a:
            goto L70
        L2e:
            java.lang.Thread r4 = oCugkraHTUNeiblG()
            goto L63
        L36:
            return r0
        L37:
            goto L55
        L3b:
            return r0
        L3c:
            goto L8a
        L40:
            goto L8d
        L43:
            goto L47
        L47:
            r0 = 9
            goto L7d
        L4e:
            lwzIMsSIfFAGaxwF(r0)
            goto L36
        L55:
            iETiHcyrkjlVMcuN(r3, r0)
            goto L3b
        L5c:
            edSjTLgbVfHIKcSm(r4)
            goto L1f
        L63:
            com.google.android.gms.measurement.internal.zzik r1 = r3.zzb
            goto L16
        L69:
            bbSXQsOeSSvdhvME(r3)
            goto L5c
        L70:
            goto L3c
        L73:
            goto L69
        L77:
            java.lang.string r2 = "Task exception on worker thread"
            goto Lf
        L7d:
            r1 = 24
            goto L84
        L84:
            int r0 = r0 + r1
            goto L9
        L8a:
            goto L73
        L8d:
            goto L91
        L91:
            goto L43
    }

    public readonly void Zzn() {
            r1 = this;
            goto L1d
        L4:
            java.lang.string r0 = "Call not expected from worker thread"
            goto L32
        La:
            if (r0 != r1) goto Lf
            goto L19
        Lf:
            goto L18
        L13:
            throw r1
        L14:
            goto L39
        L18:
            return
        L19:
            goto L3c
        L1d:
            goto L14
        L20:
            goto L2a
        L24:
            com.google.android.gms.measurement.internal.zzik r1 = r1.zzb
            goto La
        L2a:
            java.lang.Thread r0 = TiQDLiKRvzPLzDJw()
            goto L24
        L32:
            r1.<init>(r0)
            goto L13
        L39:
            goto L20
        L3c:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto L4
    }

    public readonly void Zzp(java.lang.Action r4) throws java.lang.IllegalStateException {
            r3 = this;
            goto L14
        L4:
            java.lang.string r0 = "Task exception on network thread"
            goto L93
        La:
            r1 = 32
            goto L3a
        L11:
            goto L17
        L14:
            goto L1e
        L17:
            goto L77
        L1b:
            goto L4a
        L1e:
            goto L11
        L22:
            throw r3
        L23:
            goto L1b
        L27:
            r1.<init>(r3, r4, r2, r0)
            goto L34
        L2e:
            int r0 = r0 % r1
            goto L8a
        L34:
            java.lang.object r4 = r3.zzh
            goto L4e
        L3a:
            int r0 = r0 + r1
            goto L2e
        L40:
            wBNdMhuZlmosZlsS(r3)
            goto L7e
        L47:
            goto L23
        L4a:
            goto L40
        L4e:
            monitor-enter(r4)
            java.util.concurrent.BlockingQueue r0 = r3.zze     // Catch: java.lang.Exception -> L71
            FanfMZmOxKYTlarj(r0, r1)     // Catch: java.lang.Exception -> L71
            com.google.android.gms.measurement.internal.zzik r1 = r3.zzc     // Catch: java.lang.Exception -> L71
            if (r1 != 0) goto L6c
            com.google.android.gms.measurement.internal.zzik r1 = new com.google.android.gms.measurement.internal.zzik     // Catch: java.lang.Exception -> L71
            java.lang.string r2 = "Measurement Network"
            r1.<init>(r3, r2, r0)     // Catch: java.lang.Exception -> L71
            r3.zzc = r1     // Catch: java.lang.Exception -> L71
            java.lang.Thread$UncaughtExceptionHandler r0 = r3.zzg     // Catch: java.lang.Exception -> L71
            ixkcYhTOVUlWtyUA(r1, r0)     // Catch: java.lang.Exception -> L71
            com.google.android.gms.measurement.internal.zzik r3 = r3.zzc     // Catch: java.lang.Exception -> L71
            FjgEmYNdaBTrvxZB(r3)     // Catch: java.lang.Exception -> L71
            goto L6f
        L6c:
            FPmElmZGhlgOLSGR(r1)     // Catch: java.lang.Exception -> L71
        L6f:
            monitor-exit(r4)     // Catch: java.lang.Exception -> L71
            return
        L71:
            r3 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L71
            goto L22
        L77:
            r0 = 12
            goto La
        L7e:
            BEjechZRSnRWZSgq(r4)
            goto L4
        L85:
            r2 = 0
            goto L27
        L8a:
            if (r0 <= 0) goto L8f
            goto L4a
        L8f:
            goto L47
        L93:
            com.google.android.gms.measurement.internal.zzij r1 = new com.google.android.gms.measurement.internal.zzij
            goto L85
    }

    public readonly void Zzq(java.lang.Action r4) throws java.lang.IllegalStateException {
            r3 = this;
            goto L1f
        L4:
            goto L29
        L7:
            goto L67
        Lb:
            com.google.android.gms.measurement.internal.zzij r0 = new com.google.android.gms.measurement.internal.zzij
            goto L62
        L11:
            r0 = 12
            goto L6a
        L18:
            r0.<init>(r3, r4, r1, r2)
            goto L5b
        L1f:
            goto L7
        L22:
            goto L11
        L26:
            goto L57
        L29:
            goto L42
        L2d:
            java.lang.string r2 = "Task exception on worker thread"
            goto L18
        L33:
            int r0 = r0 + r1
            goto L50
        L39:
            if (r0 <= 0) goto L3e
            goto L29
        L3e:
            goto L26
        L42:
            mvcPXgOLmyBYTIhJ(r3)
            goto L49
        L49:
            AYZUGNqpVkiiFyxL(r4)
            goto Lb
        L50:
            int r0 = r0 % r1
            goto L39
        L56:
            return
        L57:
            goto L4
        L5b:
            EAKjezcbUHzpnKxo(r3, r0)
            goto L56
        L62:
            r1 = 0
            goto L2d
        L67:
            goto L22
        L6a:
            r1 = 11
            goto L33
    }

    public readonly void Zzr(java.lang.Action r4) throws java.lang.IllegalStateException {
            r3 = this;
            goto L4e
        L4:
            r0 = 29
            goto L42
        Lb:
            int r0 = r0 + r1
            goto L11
        L11:
            int r0 = r0 % r1
            goto L63
        L17:
            r0.<init>(r3, r4, r1, r2)
            goto L1e
        L1e:
            fXSRpclThLWanFkx(r3, r0)
            goto L6c
        L25:
            cgJXsjkAMyolUmOm(r3)
            goto L2c
        L2c:
            KbJslKgJBkIoxHVl(r4)
            goto L39
        L33:
            java.lang.string r2 = "Task exception on worker thread"
            goto L17
        L39:
            com.google.android.gms.measurement.internal.zzij r0 = new com.google.android.gms.measurement.internal.zzij
            goto L49
        L3f:
            goto L51
        L42:
            r1 = 31
            goto Lb
        L49:
            r1 = 1
            goto L33
        L4e:
            goto L58
        L51:
            goto L4
        L55:
            goto L5f
        L58:
            goto L3f
        L5c:
            goto L6d
        L5f:
            goto L25
        L63:
            if (r0 <= 0) goto L68
            goto L5f
        L68:
            goto L5c
        L6c:
            return
        L6d:
            goto L55
    }

    public readonly bool Zzt() {
            r1 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.Thread r0 = UxYopWqRmtrbRFJm()
            goto L18
        L13:
            return r1
        L14:
            goto L1e
        L18:
            com.google.android.gms.measurement.internal.zzik r1 = r1.zzc
            goto L30
        L1e:
            goto L7
        L21:
            r1 = 1
            goto L26
        L26:
            return r1
        L27:
            goto L2b
        L2b:
            r1 = 0
            goto L13
        L30:
            if (r0 == r1) goto L35
            goto L27
        L35:
            goto L21
    }

    public readonly bool Zzu() {
            r1 = this;
            goto L23
        L4:
            return r1
        L5:
            goto L9
        L9:
            goto L26
        Lc:
            r1 = 0
            goto L4
        L11:
            java.lang.Thread r0 = LfvbMUkIxsKZmiMo()
            goto L33
        L19:
            r1 = 1
            goto L1e
        L1e:
            return r1
        L1f:
            goto Lc
        L23:
            goto L5
        L26:
            goto L11
        L2a:
            if (r0 == r1) goto L2f
            goto L1f
        L2f:
            goto L19
        L33:
            com.google.android.gms.measurement.internal.zzik r1 = r1.zzb
            goto L2a
    }
}

