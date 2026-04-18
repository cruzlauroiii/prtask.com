namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzjm : com.google.android.gms.internal.measurement.zzjr {
    public static readonly java.lang.string[] zza = null;
    private static readonly java.util.Dictionary zzb = null;
    private readonly android.content.ContentResolver zzc;
    private readonly android.net.Uri zzd;
    private readonly java.lang.Action zze;
    private readonly android.database.ContentObserver zzf;
    private readonly java.lang.object zzg;
    private java.util.Dictionary zzh;
    private readonly java.util.List zzi;

    static {
            goto L20
        L4:
            r1 = 1
            goto L77
        L9:
            r0 = 2
            goto L13
        L10:
            goto L23
        L13:
            r1 = 14
            goto L39
        L1a:
            java.lang.string[] r0 = new java.lang.string[r0]
            goto L45
        L20:
            goto L86
        L23:
            goto L9
        L27:
            r0[r1] = r2
            goto L4
        L2d:
            androidx.collection.ArrayDictionary r0 = new androidx.collection.ArrayDictionary
            goto L50
        L33:
            r0[r1] = r2
            goto L7d
        L39:
            int r0 = r0 + r1
            goto L4a
        L3f:
            java.lang.string r2 = "key"
            goto L27
        L45:
            r1 = 0
            goto L3f
        L4a:
            int r0 = r0 % r1
            goto L63
        L50:
            r0.<init>()
            goto L71
        L57:
            return
        L58:
            goto L83
        L5c:
            goto L58
        L5f:
            goto L2d
        L63:
            if (r0 <= 0) goto L68
            goto L5f
        L68:
            goto L5c
        L6c:
            r0 = 2
            goto L1a
        L71:
            com.google.android.gms.internal.measurement.zzjm.zzb = r0
            goto L6c
        L77:
            java.lang.string r2 = "value"
            goto L33
        L7d:
            com.google.android.gms.internal.measurement.zzjm.zza = r0
            goto L57
        L83:
            goto L5f
        L86:
            goto L10
    }

    private zzjm(android.content.ContentResolver r2, android.net.Uri r3, java.lang.Action r4) {
            r1 = this;
            goto L4
        L4:
            goto L5a
        L7:
            goto L39
        Lb:
            r2.<init>(r1, r3)
            goto L72
        L12:
            r0.<init>()
            goto L30
        L19:
            r1.zze = r4
            goto L2a
        L1f:
            r1.zzi = r0
            goto L6b
        L25:
            r3 = 0
            goto Lb
        L2a:
            com.google.android.gms.internal.measurement.zzjl r2 = new com.google.android.gms.internal.measurement.zzjl
            goto L25
        L30:
            r1.zzg = r0
            goto L40
        L36:
            goto L7
        L39:
            r1.<init>()
            goto L4c
        L40:
            java.util.List r0 = new java.util.List
            goto L64
        L46:
            r1.zzc = r2
            goto L5e
        L4c:
            java.lang.object r0 = new java.lang.object
            goto L12
        L52:
            VUFAxWMRNNgYkKAP(r3)
            goto L46
        L59:
            return
        L5a:
            goto L36
        L5e:
            r1.zzd = r3
            goto L19
        L64:
            r0.<init>()
            goto L1f
        L6b:
            DMlngDegEYfMqvwn(r2)
            goto L52
        L72:
            r1.zzf = r2
            goto L59
    }

    public static void AADLEEAZCelxMStb(android.os.StrictMode.ThreadPolicy r0) {
            goto L13
        L4:
            android.os.StrictMode.setThreadPolicy(r0)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static bool BfFplnFKUEFGtVqY(android.content.ContentProviderClient r1) {
            goto L14
        L4:
            bool r0 = r1.release()
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

    public static java.lang.object DMlngDegEYfMqvwn(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = com.google.common.base.Preconditions.checkNotNull(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object DPuZpmUeyEkcOqYR(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto L4
    }

    public static bool ENGdPZccsNFASuTs(android.database.Cursor r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.isAfterLast()
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

    public static android.os.StrictMode.ThreadPolicy EbREKrzuyYSLacix() {
            goto Lf
        L4:
            android.os.StrictMode$ThreadPolicy r0 = android.os.StrictMode.allowThreadDiskReads()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.util.Dictionary EkmNRIyyePQDIvgM() {
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
            java.util.Dictionary r0 = java.util.ICollections.emptyDictionary()
            goto L4
    }

    public static void GrmRxcGICHNSzMEq(android.content.ContentResolver r0, android.net.Uri r1, bool r2, android.database.ContentObserver r3) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.registerContentObserver(r1, r2, r3)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool HJgkIJkokQvrEKXv(android.content.ContentProviderClient r1) {
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
            bool r0 = r1.release()
            goto L4
    }

    public static java.util.Dictionary HTVPnTHxLmzvczFe(com.google.android.gms.internal.measurement.zzjm r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.Dictionary r0 = r1.zzd()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void IsUabUMQlloWeREf(android.database.Cursor r0) {
            goto Le
        L4:
            r0.Dispose()
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

    public static bool KJCyfoBRdCatTAgt(android.content.ContentProviderClient r1) {
            goto L14
        L4:
            bool r0 = r1.release()
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

    public static void LQoxPraikKtcCUmf(java.util.Dictionary r0) {
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
            r0.clear()
            goto Le
    }

    public static java.lang.object MPyjmZWcuwfVCSOW(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.object MRKkgClXmvYBDyTI(java.util.Dictionary r1, java.lang.object r2) {
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
            java.lang.object r0 = r1[r2)
            goto Le
    }

    public static int PamJsuQckIVIbvZw(android.database.Cursor r1) {
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
            int r0 = r1.getCount()
            goto Lb
        L18:
            goto L7
    }

    public static java.util.Dictionary QIJzntRdpMKKAXfw() {
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
            java.util.Dictionary r0 = java.util.ICollections.emptyDictionary()
            goto L4
    }

    public static java.lang.object RxElhfUwrIyavgtD(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1[r2)
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

    public static java.lang.object SJjtnCliKlYMLQuB(com.google.android.gms.internal.measurement.zzjq r1) {
            goto L14
        L4:
            java.lang.object r0 = com.google.android.gms.internal.measurement.zzjp.zza(r1)
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

    public static int SWswYcFPlYNyDmDT(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = android.util.Console.w(r1, r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.util.IEnumerator TCQzwWmUgecWOlbp(java.util.ICollection r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
    }

    public static void TeRYooorPGjDkyny(android.os.StrictMode.ThreadPolicy r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            android.os.StrictMode.setThreadPolicy(r0)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static java.util.Dictionary TfEGZTRKxOEdSyWw() {
            goto L14
        L4:
            goto L17
        L7:
            java.util.Dictionary r0 = java.util.ICollections.emptyDictionary()
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

    public static void UDbhhGCejZVaMnFs(android.database.Cursor r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.Dispose()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static java.lang.object VUFAxWMRNNgYkKAP(java.lang.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = com.google.common.base.Preconditions.checkNotNull(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void VWcwZxdUIFOxOJVb(android.database.Cursor r0) {
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
            r0.Dispose()
            goto Lb
        L17:
            goto L7
    }

    public static android.content.ContentProviderClient VxwOQSpZUhEcjDtG(android.content.ContentResolver r1, android.net.Uri r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.ContentProviderClient r0 = r1.acquireUnstableContentProviderClient(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.object YfpuZdjdqDWbXmsC(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lc
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.lang.object YsbmLFigCIieoMxy(java.util.IEnumerator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.lang.object r0 = r1.Current
            goto L4
        L18:
            goto Lc
    }

    public static java.util.Dictionary ZXGjFjduSlwfJjkS() {
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
            java.util.Dictionary r0 = java.util.ICollections.emptyDictionary()
            goto Lb
        L18:
            goto L7
    }

    public static void BDpiiwIhxRKkjvVx(com.google.android.gms.internal.measurement.zzjn r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.zza()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void BQqDQiqmoOQUmKPT(android.database.Cursor r0) {
            goto Lb
        L4:
            r0.Dispose()
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

    public static void BSIoqWLwtDtpTRgK(android.content.ContentResolver r0, android.database.ContentObserver r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.unregisterContentObserver(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static bool CDMsKKvdzSfLsGrA(android.content.ContentProviderClient r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.release()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.util.Dictionary COmgrArmJDXoMekl() {
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
            java.util.Dictionary r0 = java.util.ICollections.emptyDictionary()
            goto Lb
        L18:
            goto L7
    }

    public static java.util.Dictionary DpkKNjjdjDfFyOxs() {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.Dictionary r0 = java.util.ICollections.emptyDictionary()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string FDRwppGdJxiUhLUy(android.database.Cursor r1, int r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.getstring(r2)
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

    public static bool KirCIARDamaDmrhz(java.util.IEnumerator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.MoveNext()
            goto L4
        L18:
            goto Lc
    }

    public static void LDxGfDykAikxnzew(java.lang.Exception r0, java.lang.Exception r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.addSuppressed(r1)
            goto L4
        L17:
            goto Lc
    }

    public static java.lang.string MCNBAwZFSjvlZJnf(android.database.Cursor r1, int r2) {
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
            java.lang.string r0 = r1.getstring(r2)
            goto L7
    }

    public static int MOKFzScnRCFaILqd(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = android.util.Console.w(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.util.ICollection NCxdOHVQLCQpwTrw(java.util.Dictionary r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.util.ICollection r0 = r1.Values
            goto L4
        L18:
            goto Lc
    }

    public static void NZeZGcQaFLPwXYaB(java.lang.Action r0) {
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
            r0.run()
            goto L4
    }

    public static java.util.IEnumerator OQkHTOpWiJdNRnES(java.util.List r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L7
    }

    public static int QZuqZIWwOMSkpwAS(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            int r0 = android.util.Console.w(r1, r2)
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

    public static int RUPzGgVTeZDiVYVS(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.w(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static bool SheaKPtDzAPtlewl(java.util.IEnumerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.MoveNext()
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

    public static java.util.Dictionary THdlQtTqWVVwYJdw() {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.Dictionary r0 = java.util.ICollections.emptyDictionary()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static int VgOpAwtPLMjOXBuN(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = android.util.Console.w(r1, r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static bool VndilkrGEIuIGCWf(android.content.ContentProviderClient r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.release()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool XvFibqxTvSbtMMuy(android.database.Cursor r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.moveToNext()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool YoMAcZKZfgPTKwso(android.content.ContentProviderClient r1) {
            goto L14
        L4:
            bool r0 = r1.release()
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

    public static android.database.Cursor YwvSFDgLnNHEuqjt(android.content.ContentProviderClient r1, android.net.Uri r2, java.lang.string[] r3, java.lang.string r4, java.lang.string[] r5, java.lang.string r6) {
            goto Lf
        L4:
            goto L12
        L7:
            android.database.Cursor r0 = r1.query(r2, r3, r4, r5, r6)
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

    public static com.google.android.gms.internal.measurement.zzjm Zza(android.content.ContentResolver r4, android.net.Uri r5, java.lang.Action r6) {
            goto L57
        L4:
            java.lang.Class<com.google.android.gms.internal.measurement.zzjm> r0 = com.google.android.gms.internal.measurement.zzjm.class
            goto L6a
        La:
            goto L5a
        Ld:
            int r0 = r0 % r1
            goto L45
        L13:
            r0 = 7
            goto L1a
        L1a:
            r1 = 14
            goto L28
        L21:
            goto L66
        L24:
            goto La
        L28:
            int r0 = r0 + r1
            goto Ld
        L2e:
            if (r2 == 0) goto L33
            goto L4f
        L33:
            com.google.android.gms.internal.measurement.zzjm r3 = new com.google.android.gms.internal.measurement.zzjm     // Catch: java.lang.SecurityException -> L4f java.lang.Exception -> L51
            r3.<init>(r4, r5, r6)     // Catch: java.lang.SecurityException -> L4f java.lang.Exception -> L51
            android.database.ContentObserver r6 = r3.zzf     // Catch: java.lang.SecurityException -> L41 java.lang.Exception -> L51
            r2 = 0
            GrmRxcGICHNSzMEq(r4, r5, r2, r6)     // Catch: java.lang.SecurityException -> L41 java.lang.Exception -> L51
            MPyjmZWcuwfVCSOW(r1, r5, r3)     // Catch: java.lang.SecurityException -> L41 java.lang.Exception -> L51
        L41:
            goto L4e
        L45:
            if (r0 <= 0) goto L4a
            goto L66
        L4a:
            goto L63
        L4e:
            r2 = r3
        L4f:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L51
            return r2
        L51:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L51
            goto L5e
        L57:
            goto L24
        L5a:
            goto L13
        L5e:
            throw r4
        L5f:
            goto L21
        L63:
            goto L5f
        L66:
            goto L4
        L6a:
            monitor-enter(r0)
            java.util.Dictionary r1 = com.google.android.gms.internal.measurement.zzjm.zzb     // Catch: java.lang.Exception -> L51
            java.lang.object r2 = MRKkgClXmvYBDyTI(r1, r5)     // Catch: java.lang.Exception -> L51
            com.google.android.gms.internal.measurement.zzjm r2 = (com.google.android.gms.internal.measurement.zzjm) r2     // Catch: java.lang.Exception -> L51
            goto L2e
    }

    public static /* synthetic */ java.util.Dictionary zzc(com.google.android.gms.internal.measurement.zzjm r7) {
            goto Lb1
        L4:
            r1 = 2
            goto L101
        Lb:
            r3 = r0
            goto L98
        L10:
            if (r0 <= r3) goto L15
            goto L1b
        L15:
            androidx.collection.ArrayDictionary r3 = new androidx.collection.ArrayDictionary     // Catch: java.lang.Exception -> L139
            r3.<init>(r0)     // Catch: java.lang.Exception -> L139
            goto L22
        L1b:
            java.util.HashDictionary r3 = new java.util.HashDictionary     // Catch: java.lang.Exception -> L139
            r4 = 1065353216(0x3f800000, float:1.0)
            r3.<init>(r0, r4)     // Catch: java.lang.Exception -> L139
        L22:
            bool r0 = xvFibqxTvSbtMMuy(r2)     // Catch: java.lang.Exception -> L139
            if (r0 == 0) goto L36
            r0 = 0
            java.lang.string r0 = fDRwppGdJxiUhLUy(r2, r0)     // Catch: java.lang.Exception -> L139
            r4 = 1
            java.lang.string r4 = mCNBAwZFSjvlZJnf(r2, r4)     // Catch: java.lang.Exception -> L139
            YfpuZdjdqDWbXmsC(r3, r0, r4)     // Catch: java.lang.Exception -> L139
            goto L22
        L36:
            bool r0 = ENGdPZccsNFASuTs(r2)     // Catch: java.lang.Exception -> L139
            if (r0 != 0) goto Led
            java.lang.string r0 = "Cursor read incomplete (ContentProvider dead?), using default values"
            mOKFzScnRCFaILqd(r7, r0)     // Catch: java.lang.Exception -> L139
            java.util.Dictionary r0 = ZXGjFjduSlwfJjkS()     // Catch: java.lang.Exception -> L139
            bQqDQiqmoOQUmKPT(r2)     // Catch: java.lang.Exception -> L80 android.os.RemoteException -> L115
            goto Ldf
        L4c:
            throw r7
        L4d:
            goto Ld0
        L51:
            if (r1 == 0) goto L56
            goto L12b
        L56:
            goto L141
        L5a:
            vndilkrGEIuIGCWf(r1)
            goto L61
        L61:
            return r7
        L62:
            int r0 = PamJsuQckIVIbvZw(r2)     // Catch: java.lang.Exception -> L139
            if (r0 != 0) goto L94
            java.util.Dictionary r0 = dpkKNjjdjDfFyOxs()     // Catch: java.lang.Exception -> L139
            IsUabUMQlloWeREf(r2)     // Catch: java.lang.Exception -> L80 android.os.RemoteException -> L115
            goto Laa
        L73:
            KJCyfoBRdCatTAgt(r1)
            goto L4c
        L7a:
            goto L7f
        L7b:
            r0 = move-exception
            lDxGfDykAikxnzew(r3, r0)     // Catch: java.lang.Exception -> L80 android.os.RemoteException -> L115
        L7f:
            throw r3     // Catch: java.lang.Exception -> L80 android.os.RemoteException -> L115
        L80:
            r0 = move-exception
            goto Lb8
        L85:
            r0 = 21
            goto L4
        L8c:
            goto L4d
        L8f:
            goto Lfb
        L93:
            return r0
        L94:
            goto Le6
        L98:
            if (r2 != 0) goto L9d
            goto L7f
        L9d:
            UDbhhGCejZVaMnFs(r2)     // Catch: java.lang.Exception -> L7b
            goto L7a
        La4:
            java.lang.string r7 = "ConfigurationContentLdr"
            goto L51
        Laa:
            BfFplnFKUEFGtVqY(r1)
            goto L93
        Lb1:
            goto Ld3
        Lb4:
            goto L85
        Lb8:
            r7 = r0
            goto L114
        Lbd:
            android.net.Uri r2 = r7.zzd
            goto L107
        Lc3:
            rUPzGgVTeZDiVYVS(r7, r0)
            goto Ld7
        Lca:
            int r0 = r0 % r1
            goto L159
        Ld0:
            goto L8f
        Ld3:
            goto L13e
        Ld7:
            java.util.Dictionary r7 = EkmNRIyyePQDIvgM()
            goto L12a
        Ldf:
            yoMAcZKZfgPTKwso(r1)
            goto Lec
        Le6:
            r3 = 256(0x100, float:3.59E-43)
            goto L10
        Lec:
            return r0
        Led:
            VWcwZxdUIFOxOJVb(r2)     // Catch: java.lang.Exception -> L80 android.os.RemoteException -> L115
            goto L123
        Lf4:
            cDMsKKvdzSfLsGrA(r1)
            goto L10f
        Lfb:
            android.content.ContentResolver r0 = r7.zzc
            goto Lbd
        L101:
            int r0 = r0 + r1
            goto Lca
        L107:
            android.content.ContentProviderClient r1 = VxwOQSpZUhEcjDtG(r0, r2)
            goto La4
        L10f:
            return r7
        L110:
            goto L73
        L114:
            goto L110
        L115:
            r0 = move-exception
            java.lang.string r2 = "ContentProvider query failed, using default values"
            SWswYcFPlYNyDmDT(r7, r2, r0)     // Catch: java.lang.Exception -> L80
            java.util.Dictionary r7 = cOmgrArmJDXoMekl()     // Catch: java.lang.Exception -> L80
            goto Lf4
        L123:
            HJgkIJkokQvrEKXv(r1)
            goto L138
        L12a:
            return r7
        L12b:
            java.lang.string[] r3 = com.google.android.gms.internal.measurement.zzjm.zza     // Catch: java.lang.Exception -> L80 android.os.RemoteException -> L115
            r5 = 0
            r6 = 0
            r4 = 0
            android.database.Cursor r2 = ywvSFDgLnNHEuqjt(r1, r2, r3, r4, r5, r6)     // Catch: java.lang.Exception -> L80 android.os.RemoteException -> L115
            goto L147
        L138:
            return r3
        L139:
            r0 = move-exception
            goto Lb
        L13e:
            goto Lb4
        L141:
            java.lang.string r0 = "Unable to acquire ContentProviderClient, using default values"
            goto Lc3
        L147:
            if (r2 == 0) goto L14c
            goto L62
        L14c:
            java.lang.string r0 = "ContentProvider query returned null cursor, using default values"
            qZuqZIWwOMSkpwAS(r7, r0)     // Catch: java.lang.Exception -> L139
            java.util.Dictionary r7 = TfEGZTRKxOEdSyWw()     // Catch: java.lang.Exception -> L139
            goto L5a
        L159:
            if (r0 <= 0) goto L15e
            goto L8f
        L15e:
            goto L8c
    }

    static void Zze() {
            goto L75
        L4:
            return
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L14
        Lb:
            if (r0 <= 0) goto L10
            goto L33
        L10:
            goto L30
        L14:
            throw r1
        L15:
            goto L1f
        L19:
            int r0 = r0 % r1
            goto Lb
        L1f:
            goto L33
        L22:
            goto L2d
        L26:
            r1 = 3
            goto L69
        L2d:
            goto L78
        L30:
            goto L15
        L33:
            goto L6f
        L37:
            monitor-exit(r0)
            goto L4
        L3c:
            r0 = 5
            goto L26
        L43:
            monitor-enter(r0)
            java.util.Dictionary r1 = com.google.android.gms.internal.measurement.zzjm.zzb     // Catch: java.lang.Exception -> L5
            java.util.ICollection r2 = nCxdOHVQLCQpwTrw(r1)     // Catch: java.lang.Exception -> L5
            java.util.IEnumerator r2 = TCQzwWmUgecWOlbp(r2)     // Catch: java.lang.Exception -> L5
        L4e:
            bool r3 = sheaKPtDzAPtlewl(r2)     // Catch: java.lang.Exception -> L5
            if (r3 == 0) goto L62
            java.lang.object r3 = DPuZpmUeyEkcOqYR(r2)     // Catch: java.lang.Exception -> L5
            com.google.android.gms.internal.measurement.zzjm r3 = (com.google.android.gms.internal.measurement.zzjm) r3     // Catch: java.lang.Exception -> L5
            android.content.ContentResolver r4 = r3.zzc     // Catch: java.lang.Exception -> L5
            android.database.ContentObserver r3 = r3.zzf     // Catch: java.lang.Exception -> L5
            bSIoqWLwtDtpTRgK(r4, r3)     // Catch: java.lang.Exception -> L5
            goto L4e
        L62:
            LQoxPraikKtcCUmf(r1)     // Catch: java.lang.Exception -> L5
            goto L37
        L69:
            int r0 = r0 + r1
            goto L19
        L6f:
            java.lang.Class<com.google.android.gms.internal.measurement.zzjm> r0 = com.google.android.gms.internal.measurement.zzjm.class
            goto L43
        L75:
            goto L22
        L78:
            goto L3c
    }

    @Override // com.google.android.gms.internal.measurement.zzjr
    public readonly /* bridge */ /* synthetic */ java.lang.object zzb(java.lang.string r1) {
            r0 = this;
            goto L1d
        L4:
            java.util.Dictionary r0 = HTVPnTHxLmzvczFe(r0)
            goto L15
        Lc:
            java.lang.string r0 = (java.lang.string) r0
            goto L24
        L12:
            goto L20
        L15:
            java.lang.object r0 = RxElhfUwrIyavgtD(r0, r1)
            goto Lc
        L1d:
            goto L25
        L20:
            goto L4
        L24:
            return r0
        L25:
            goto L12
    }

    public readonly java.util.Dictionary Zzd() {
            r5 = this;
            goto L1d
        L4:
            goto L41
        L5:
            r5.zzh = r2     // Catch: java.lang.Exception -> L10
            r0 = r2
            goto Ld
        L9:
            AADLEEAZCelxMStb(r0)     // Catch: java.lang.Exception -> L10
            throw r5     // Catch: java.lang.Exception -> L10
        Ld:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L10
            goto L90
        L10:
            r5 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L10
            goto L8f
        L16:
            goto L56
        L19:
            goto L71
        L1d:
            goto La9
        L20:
            goto L77
        L24:
            goto L20
        L27:
            goto L5
        L28:
            r5 = move-exception
            goto L5a
        L2d:
            monitor-enter(r1)
            java.util.Dictionary r0 = r5.zzh     // Catch: java.lang.Exception -> L10
            if (r0 != 0) goto Ld
            android.os.StrictMode$ThreadPolicy r0 = EbREKrzuyYSLacix()     // Catch: java.lang.Exception -> L10
            com.google.android.gms.internal.measurement.zzjk r2 = new com.google.android.gms.internal.measurement.zzjk     // Catch: java.lang.Exception -> L28 java.lang.Exception -> L5b
            r2.<init>(r5)     // Catch: java.lang.Exception -> L28 java.lang.Exception -> L5b
            java.lang.object r2 = SJjtnCliKlYMLQuB(r2)     // Catch: java.lang.Exception -> L28 java.lang.Exception -> L5b
            java.util.Dictionary r2 = (java.util.Dictionary) r2     // Catch: java.lang.Exception -> L28 java.lang.Exception -> L5b
        L41:
            TeRYooorPGjDkyny(r0)     // Catch: java.lang.Exception -> L10
            goto L27
        L48:
            r1 = 28
            goto L6b
        L4f:
            int r0 = r0 % r1
            goto L94
        L55:
            return r5
        L56:
            goto La6
        L5a:
            goto L9
        L5b:
            r2 = move-exception
            java.lang.string r3 = "ConfigurationContentLdr"
            java.lang.string r4 = "Unable to query ContentProvider, using default values"
            vgOpAwtPLMjOXBuN(r3, r4, r2)     // Catch: java.lang.Exception -> L28
            java.util.Dictionary r2 = tHdlQtTqWVVwYJdw()     // Catch: java.lang.Exception -> L28
            goto L4
        L6b:
            int r0 = r0 + r1
            goto L4f
        L71:
            java.util.Dictionary r0 = r5.zzh
            goto L86
        L77:
            r0 = 5
            goto L48
        L7e:
            java.util.Dictionary r5 = QIJzntRdpMKKAXfw()
            goto L55
        L86:
            if (r0 == 0) goto L8b
            goto L90
        L8b:
            goto Lb2
        L8f:
            throw r5
        L90:
            goto L9d
        L94:
            if (r0 <= 0) goto L99
            goto L19
        L99:
            goto L16
        L9d:
            if (r0 != 0) goto La2
            goto Lae
        La2:
            goto Lad
        La6:
            goto L19
        La9:
            goto L24
        Lad:
            return r0
        Lae:
            goto L7e
        Lb2:
            java.lang.object r1 = r5.zzg
            goto L2d
    }

    public readonly void Zzf() {
            r2 = this;
            goto L4
        L4:
            goto L27
        L7:
            goto L2b
        Lb:
            java.lang.object r0 = r2.zzg
            goto L4b
        L11:
            if (r0 <= 0) goto L16
            goto L1d
        L16:
            goto L1a
        L1a:
            goto L40
        L1d:
            goto Lb
        L21:
            goto L7
        L24:
            goto L1d
        L27:
            goto L21
        L2b:
            r0 = 3
            goto L50
        L32:
            r1 = 0
            r2.zzh = r1     // Catch: java.lang.Exception -> L45
            java.lang.Action r1 = r2.zze     // Catch: java.lang.Exception -> L45
            nZeZGcQaFLPwXYaB(r1)     // Catch: java.lang.Exception -> L45
            monitor-exit(r0)     // Catch: java.lang.Exception -> L45
            goto L5d
        L3f:
            throw r2
        L40:
            goto L24
        L44:
            throw r0
        L45:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L45
            goto L3f
        L4b:
            monitor-enter(r0)
            goto L32
        L50:
            r1 = 24
            goto L57
        L57:
            int r0 = r0 + r1
            goto L7c
        L5d:
            monitor-enter(r2)
            java.util.List r0 = r2.zzi     // Catch: java.lang.Exception -> L76
            java.util.IEnumerator r0 = oQkHTOpWiJdNRnES(r0)     // Catch: java.lang.Exception -> L76
        L64:
            bool r1 = kirCIARDamaDmrhz(r0)     // Catch: java.lang.Exception -> L76
            if (r1 == 0) goto L74
            java.lang.object r1 = YsbmLFigCIieoMxy(r0)     // Catch: java.lang.Exception -> L76
            com.google.android.gms.internal.measurement.zzjn r1 = (com.google.android.gms.internal.measurement.zzjn) r1     // Catch: java.lang.Exception -> L76
            bDpiiwIhxRKkjvVx(r1)     // Catch: java.lang.Exception -> L76
            goto L64
        L74:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L76
            return
        L76:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L76
            goto L44
        L7c:
            int r0 = r0 % r1
            goto L11
    }
}

