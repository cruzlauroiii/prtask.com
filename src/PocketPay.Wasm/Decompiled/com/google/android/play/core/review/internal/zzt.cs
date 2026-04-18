namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
public readonly class zzt {
    private static readonly java.util.Dictionary zza = null;
    private readonly android.content.object zzb;
    private readonly com.google.android.play.core.review.internal.zzi zzc;
    private readonly java.lang.string zzd;
    private readonly java.util.List zze;
    private readonly java.util.HashSet zzf;
    private readonly java.lang.object zzg;
    private bool zzh;
    private readonly android.content.object zzi;
    private readonly java.lang.ref.WeakReference zzj;
    private readonly android.os.IBinder.DeathRecipient zzk;
    private readonly java.util.concurrent.atomic.Atomicint zzl;
    private android.content.ServiceConnection zzm;
    private android.os.IInterface zzn;

    static {
            goto La
        L4:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L19
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L16
        L16:
            goto Ld
        L19:
            r0.<init>()
            goto L20
        L20:
            com.google.android.play.core.review.internal.zzt.zza = r0
            goto L11
    }

    public zzt(android.content.object r1, com.google.android.play.core.review.internal.zzi r2, java.lang.string r3, android.content.object r4, com.google.android.play.core.review.zze r5, com.google.android.play.core.review.internal.zzo r6) {
            r0 = this;
            goto L50
        L4:
            com.google.android.play.core.review.internal.zzk r3 = new com.google.android.play.core.review.internal.zzk
            goto L62
        La:
            r3.<init>()
            goto L44
        L11:
            r0.zzl = r3
            goto L90
        L17:
            r0.<init>()
            goto La3
        L1e:
            r3.<init>()
            goto L32
        L25:
            java.lang.string r1 = "com.google.android.finsky.inappreviewservice.InAppReviewService"
            goto L3e
        L2b:
            r1.<init>(r2)
            goto L75
        L32:
            r0.zze = r3
            goto L69
        L38:
            java.lang.object r3 = new java.lang.object
            goto L9c
        L3e:
            r0.zzd = r1
            goto L96
        L44:
            r0.zzf = r3
            goto L38
        L4a:
            java.util.concurrent.atomic.Atomicint r3 = new java.util.concurrent.atomic.Atomicint
            goto L7b
        L50:
            goto L58
        L53:
            goto L17
        L57:
            return
        L58:
            goto L8d
        L5c:
            r0.zzg = r3
            goto L4
        L62:
            r3.<init>(r0)
            goto L87
        L69:
            java.util.HashHashSet r3 = new java.util.HashHashSet
            goto La
        L6f:
            java.lang.ref.WeakReference r1 = new java.lang.ref.WeakReference
            goto La9
        L75:
            r0.zzj = r1
            goto L57
        L7b:
            r5 = 0
            goto L80
        L80:
            r3.<init>(r5)
            goto L11
        L87:
            r0.zzk = r3
            goto L4a
        L8d:
            goto L53
        L90:
            r0.zzb = r1
            goto Lae
        L96:
            r0.zzi = r4
            goto L6f
        L9c:
            r3.<init>()
            goto L5c
        La3:
            java.util.List r3 = new java.util.List
            goto L1e
        La9:
            r2 = 0
            goto L2b
        Lae:
            r0.zzc = r2
            goto L25
    }

    public static android.os.Looper ARGWGIBjwfNQnBHL(android.os.HandlerThread r1) {
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
            android.os.Looper r0 = r1.getLooper()
            goto L7
    }

    public static android.os.RemoteException ATqwtheveAvIhrDH(com.google.android.play.core.review.internal.zzt r1) {
            goto Lc
        L4:
            android.os.RemoteException r0 = r1.zzv()
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

    public static bool BQfpRYKLmRCRbZtp(java.util.IEnumerator r1) {
            goto L14
        L4:
            bool r0 = r1.MoveNext()
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

    public static void CRpviGJbPrTndtjs(android.os.IBinder r0, android.os.IBinder.DeathRecipient r1, int r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.linkToDeath(r1, r2)
            goto L7
    }

    public static int EPoDnOTmPrmQaPtf(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto Lc
        L4:
            int r0 = r1.zzc(r2, r3)
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

    public static com.google.android.gms.tasks.Task EvtIpoQNSGpeOJmY(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void EvvPsszUrVxCGpLw(com.google.android.play.core.review.internal.zzt r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.zzw()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.util.IEnumerator FZpIGmGhzkRafoCK(java.util.List r1) {
            goto Lc
        L4:
            java.util.IEnumerator r0 = r1.GetEnumerator()
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

    public static java.lang.object GxqsFdkwBuDMbeDL(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool JAitJzRYOqBreZXl(java.util.List r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Lb
    }

    public static java.lang.string KltZMZhiLkVQzbhp(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.concat(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool LwMRMNKPaUwLSkaX(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.Exception r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.tryHashSetException(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object MMqZoQjQIZyAFVUo(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static bool NhRewVWVpjmbvJZK(android.os.Handler r1, java.lang.Action r2) {
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
            bool r0 = r1.post(r2)
            goto Le
    }

    public static bool OjMKtwAJvEppjKhA(android.os.IBinder r1, android.os.IBinder.DeathRecipient r2, int r3) {
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
            bool r0 = r1.unlinkToDeath(r2, r3)
            goto L4
    }

    public static java.lang.object PVbKkgFjhwAUbLLL(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto Le
    }

    public static void PxwVIMOXdQpGwlGK(java.util.List r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.clear()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static int SBBnEYXayHqkPgLN(com.google.android.play.core.review.internal.zzi r1, java.lang.Exception r2, java.lang.string r3, java.lang.object[] r4) {
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
            int r0 = r1.zzb(r2, r3, r4)
            goto Lb
        L18:
            goto L7
    }

    public static void SkIyNiZmRhOFPEKU(android.os.HandlerThread r0) {
            goto Le
        L4:
            r0.start()
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

    public static bool TLRaalStFcJsdcYf(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.ContainsKey(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void TYVImarPWKjJoELk(com.google.android.play.core.review.internal.zzj r0, java.lang.Exception r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.zzc(r1)
            goto L7
    }

    public static bool VUrhjwvbFisikakw(java.util.List r1, java.lang.object r2) {
            goto Lc
        L4:
            bool r0 = r1.Add(r2)
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

    public static int VxlnITavaYKsFpXR(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto L11
        L4:
            int r0 = r1.zzc(r2, r3)
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

    public static int WLMoTQWkVosfjbww(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r1.zzc(r2, r3)
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

    public static bool WtpQBLXRbBncQKNi(java.util.HashSet r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.Add(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool XkiJKAarINxtHUYH(android.os.Handler r1, java.lang.Action r2) {
            goto L14
        L4:
            bool r0 = r1.post(r2)
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

    public static int YlbzeIhjqrIiOAjA(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.zzc(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object BQbWxyNJqSlyNOlm(java.lang.ref.WeakReference r1) {
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
            java.lang.object r0 = r1[)
            goto Le
    }

    public static int BhajHxDMIkOxcMwg(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.zzc(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.util.IEnumerator BsHkXIfyZmrFqlNA(java.util.HashSet r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto Lb
        L18:
            goto L7
    }

    public static bool DfymMknksauZICfk(java.util.HashSet r1, java.lang.object r2) {
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
            bool r0 = r1.Remove(r2)
            goto L7
    }

    public static void DiOQERQTttrKQyOK(java.util.HashSet r0) {
            goto Lb
        L4:
            r0.clear()
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

    public static com.google.android.gms.tasks.TaskCompletionSource DjKNyxiFemaHqOUC(com.google.android.play.core.review.internal.zzj r1) {
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
            com.google.android.gms.tasks.TaskCompletionSource r0 = r1.zzb()
            goto Le
    }

    public static int FEvjQBiglltwTIHt(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto L11
        L4:
            int r0 = r1.zzc(r2, r3)
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

    public static void FZArWSimICSUedML(com.google.android.play.core.review.internal.zzt r0) {
            goto L13
        L4:
            r0.zzw()
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

    public static java.lang.object HNrfGxrMrKasGgcp(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto Le
    }

    public static bool HbqTZSNhpMkNDFvz(java.util.IEnumerator r1) {
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
            bool r0 = r1.MoveNext()
            goto L4
    }

    public static java.lang.object HfrrYGWGnujvQQfp(java.util.IEnumerator r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1.Current
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.os.Handler HsFPNDROsVmZyJED(com.google.android.play.core.review.internal.zzt r1) {
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
            android.os.Handler r0 = r1.zzc()
            goto L4
        L18:
            goto Lc
    }

    public static android.os.IBinder IBmHlqqseXjwoTXB(android.os.IInterface r1) {
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
            android.os.IBinder r0 = r1.asBinder()
            goto L4
    }

    public static bool ILJGojXyHTQltlxs(java.util.HashSet r1, java.lang.object r2) {
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
            bool r0 = r1.Remove(r2)
            goto Lb
    }

    public static bool ImIsKckDrXKqWFiZ(java.util.IEnumerator r1) {
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

    public static bool KRpLQDPtFbYaCvcX(android.content.object r1, android.content.object r2, android.content.ServiceConnection r3, int r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.bindService(r2, r3, r4)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string LpgLRgfClphNNBKI(java.lang.object r1) {
            goto Lf
        L4:
            java.lang.string r0 = java.lang.string.valueOf(r1)
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

    public static int LxqYXIBFSeGbCTJz(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.zzc(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static android.os.IBinder NVlxEmcokEATtGcf(android.os.IInterface r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.os.IBinder r0 = r1.asBinder()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void QoUaWRDqwtYBMJWC(java.util.List r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.clear()
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static android.os.RemoteException RDGYrHbpNpDangGM(com.google.android.play.core.review.internal.zzt r1) {
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
            android.os.RemoteException r0 = r1.zzv()
            goto L7
    }

    public static void RlMAPLApfPewoIUJ(com.google.android.play.core.review.internal.zzo r0) {
            goto Lb
        L4:
            r0.zza()
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

    public static void RpfZhYoRcfctLNJN(com.google.android.play.core.review.internal.zzj r0) {
            goto L13
        L4:
            r0.run()
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

    public static com.google.android.gms.tasks.Task TvLEzfnuezuChceO(com.google.android.gms.tasks.Task r1, com.google.android.gms.tasks.OnCompleteListener r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.addOnCompleteListener(r2)
            goto L7
    }

    public static void UAlFCqOBnOzwlWXL(com.google.android.play.core.review.internal.zzj r0, java.lang.Exception r1) {
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
            r0.zzc(r1)
            goto L4
    }

    public static android.os.Handler VKlldyyLAHrOqkId(com.google.android.play.core.review.internal.zzt r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            android.os.Handler r0 = r1.zzc()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.util.IEnumerator VzAoBWAUvsNucJGo(java.util.List r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int ZlZrdRRSFJenzImB(com.google.android.play.core.review.internal.zzi r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.zzc(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    static /* bridge */ /* synthetic */ android.content.object zza(com.google.android.play.core.review.internal.zzt r0) {
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
            android.content.object r0 = r0.zzb
            goto Le
    }

    static /* bridge */ /* synthetic */ android.content.ServiceConnection zzb(com.google.android.play.core.review.internal.zzt r0) {
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
            android.content.ServiceConnection r0 = r0.zzm
            goto Le
    }

    static /* bridge */ /* synthetic */ android.os.IInterface zzd(com.google.android.play.core.review.internal.zzt r0) {
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            android.os.IInterface r0 = r0.zzn
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    static /* bridge */ /* synthetic */ com.google.android.play.core.review.internal.zzi zzf(com.google.android.play.core.review.internal.zzt r0) {
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
            com.google.android.play.core.review.internal.zzi r0 = r0.zzc
            goto L7
    }

    static /* bridge */ /* synthetic */ java.lang.object zzg(com.google.android.play.core.review.internal.zzt r0) {
            goto La
        L4:
            java.lang.object r0 = r0.zzg
            goto L11
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto Ld
    }

    static /* bridge */ /* synthetic */ java.util.List zzh(com.google.android.play.core.review.internal.zzt r0) {
            goto L4
        L4:
            goto L15
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.List r0 = r0.zze
            goto L14
        L14:
            return r0
        L15:
            goto Lb
    }

    static /* bridge */ /* synthetic */ java.util.concurrent.atomic.Atomicint zzi(com.google.android.play.core.review.internal.zzt r0) {
            goto L9
        L4:
            return r0
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.util.concurrent.atomic.Atomicint r0 = r0.zzl
            goto L4
        L16:
            goto Lc
    }

    public static /* synthetic */ void zzj(com.google.android.play.core.review.internal.zzt r4) {
            goto Ld2
        L4:
            java.lang.string r1 = "reportBinderDeath"
            goto L38
        La:
            rlMAPLApfPewoIUJ(r0)
            goto La1
        L11:
            int r0 = r0 % r1
            goto L116
        L17:
            java.lang.object r0 = r4.zzg
            goto Ld9
        L1d:
            PxwVIMOXdQpGwlGK(r0)
        L20:
            goto L17
        L24:
            com.google.android.play.core.review.internal.zzi r0 = r4.zzc
            goto L4
        L2a:
            java.lang.object[] r1 = new java.lang.object[]{r1}
            goto L3d
        L32:
            java.lang.string r3 = "calling onBinderDied"
            goto L7a
        L38:
            r2 = 0
            goto Lf3
        L3d:
            java.lang.string r2 = "%s : Binder has died."
            goto Le5
        L43:
            java.lang.object r0 = bQbWxyNJqSlyNOlm(r0)
            goto Lb8
        L4b:
            goto Lc7
        L4e:
            goto L24
        L52:
            java.util.List r0 = r4.zze
            goto L11f
        L58:
            if (r0 != 0) goto L5d
            goto La3
        L5d:
            goto L81
        L61:
            java.lang.object[] r2 = new java.lang.object[r2]
            goto L32
        L67:
            java.util.List r0 = r4.zze
            goto L1d
        L6d:
            goto L4e
        L70:
            goto Laf
        L74:
            java.lang.string r1 = r4.zzd
            goto L2a
        L7a:
            YlbzeIhjqrIiOAjA(r1, r3, r2)
            goto La
        L81:
            com.google.android.play.core.review.internal.zzi r1 = r4.zzc
            goto L61
        L87:
            java.lang.object r1 = PVbKkgFjhwAUbLLL(r0)
            goto Lb2
        L8f:
            java.lang.ref.WeakReference r0 = r4.zzj
            goto L43
        L95:
            com.google.android.play.core.review.internal.zzi r0 = r4.zzc
            goto L74
        L9b:
            goto L123
        L9d:
            goto L67
        La1:
            goto L20
        La3:
            goto L95
        La7:
            android.os.RemoteException r2 = rDGYrHbpNpDangGM(r4)
            goto Lcb
        Laf:
            goto Ld5
        Lb2:
            com.google.android.play.core.review.internal.zzj r1 = (com.google.android.play.core.review.internal.zzj) r1
            goto La7
        Lb8:
            com.google.android.play.core.review.internal.zzo r0 = (com.google.android.play.core.review.internal.zzo) r0
            goto L58
        Lbe:
            bool r1 = imIsKckDrXKqWFiZ(r0)
            goto L100
        Lc6:
            throw r4
        Lc7:
            goto L6d
        Lcb:
            uAlFCqOBnOzwlWXL(r1, r2)
            goto L9b
        Ld2:
            goto L70
        Ld5:
            goto L10f
        Ld9:
            monitor-enter(r0)
            EvvPsszUrVxCGpLw(r4)     // Catch: java.lang.Exception -> Ldf
            monitor-exit(r0)     // Catch: java.lang.Exception -> Ldf
            return
        Ldf:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Ldf
            goto Lc6
        Le5:
            EPoDnOTmPrmQaPtf(r0, r2, r1)
            goto L52
        Lec:
            zlZrdRRSFJenzImB(r0, r1, r3)
            goto L8f
        Lf3:
            java.lang.object[] r3 = new java.lang.object[r2]
            goto Lec
        Lf9:
            r1 = 12
            goto L109
        L100:
            if (r1 != 0) goto L105
            goto L9d
        L105:
            goto L87
        L109:
            int r0 = r0 + r1
            goto L11
        L10f:
            r0 = 5
            goto Lf9
        L116:
            if (r0 <= 0) goto L11b
            goto L4e
        L11b:
            goto L4b
        L11f:
            java.util.IEnumerator r0 = vzAoBWAUvsNucJGo(r0)
        L123:
            goto Lbe
    }

    static /* bridge */ /* synthetic */ void zzk(com.google.android.play.core.review.internal.zzt r0, android.content.ServiceConnection r1) {
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
            r1 = 0
            goto L18
        L18:
            r0.zzm = r1
            goto L4
    }

    static /* bridge */ /* synthetic */ void zzl(com.google.android.play.core.review.internal.zzt r0, bool r1) {
            goto L17
        L4:
            r1 = 0
            goto L9
        L9:
            r0.zzh = r1
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L1a
        L17:
            goto L10
        L1a:
            goto L4
    }

    static /* bridge */ /* synthetic */ void zzm(com.google.android.play.core.review.internal.zzt r0, android.os.IInterface r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L16
        L10:
            r0.zzn = r1
            goto Lb
        L16:
            goto L7
    }

    static /* bridge */ /* synthetic */ void zzn(com.google.android.play.core.review.internal.zzt r2, com.google.android.gms.tasks.TaskCompletionSource r3) {
            goto L23
        L4:
            int r0 = r0 % r1
            goto L2a
        La:
            goto L26
        Ld:
            com.google.android.gms.tasks.Task r0 = EvtIpoQNSGpeOJmY(r3)
            goto L3a
        L15:
            r0 = 7
            goto L54
        L1c:
            WtpQBLXRbBncQKNi(r0, r3)
            goto Ld
        L23:
            goto L43
        L26:
            goto L15
        L2a:
            if (r0 <= 0) goto L2f
            goto L50
        L2f:
            goto L4d
        L33:
            r1.<init>(r2, r3)
            goto L5b
        L3a:
            com.google.android.play.core.review.internal.zzl r1 = new com.google.android.play.core.review.internal.zzl
            goto L33
        L40:
            goto L50
        L43:
            goto La
        L47:
            java.util.HashSet r0 = r2.zzf
            goto L1c
        L4d:
            goto L63
        L50:
            goto L47
        L54:
            r1 = 23
            goto L67
        L5b:
            tvLEzfnuezuChceO(r0, r1)
            goto L62
        L62:
            return
        L63:
            goto L40
        L67:
            int r0 = r0 + r1
            goto L4
    }

    static /* bridge */ /* synthetic */ void zzo(com.google.android.play.core.review.internal.zzt r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            fZArWSimICSUedML(r0)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    static /* bridge */ /* synthetic */ void zzp(com.google.android.play.core.review.internal.zzt r4, com.google.android.play.core.review.internal.zzj r5) {
            goto L27
        L4:
            goto L15a
        L6:
            goto L99
        La:
            r4.zzh = r1
            goto Lfc
        L10:
            VxlnITavaYKsFpXR(r5, r2, r0)
            goto La
        L17:
            int r0 = r0 + r1
            goto L3b
        L1d:
            goto L2a
        L20:
            WLMoTQWkVosfjbww(r0, r3, r2)
            goto Ld7
        L27:
            goto Lba
        L2a:
            goto L127
        L2e:
            rpfZhYoRcfctLNJN(r5)
            goto Lac
        L35:
            java.lang.object[] r0 = new java.lang.object[r1]
            goto L121
        L3b:
            int r0 = r0 % r1
            goto L172
        L41:
            com.google.android.play.core.review.internal.zzj r0 = (com.google.android.play.core.review.internal.zzj) r0
            goto L149
        L47:
            android.content.object r3 = r4.zzi
            goto L102
        L4d:
            java.util.List r4 = r4.zze
            goto L136
        L53:
            fEvjQBiglltwTIHt(r0, r2, r1)
            goto L4d
        L5a:
            com.google.android.play.core.review.internal.zzi r0 = r4.zzc
            goto L85
        L60:
            goto Lad
        L63:
            goto L73
        L67:
            r4.zzh = r0
            goto L79
        L6d:
            bool r0 = r4.zzh
            goto Ldd
        L73:
            android.os.IInterface r0 = r4.zzn
            goto Lcb
        L79:
            android.content.object r2 = r4.zzb
            goto L47
        L7f:
            java.lang.object[] r1 = new java.lang.object[r1]
            goto L16c
        L85:
            java.lang.object[] r2 = new java.lang.object[r1]
            goto L17b
        L8b:
            return
        L8c:
            goto L13d
        L90:
            if (r0 == 0) goto L95
            goto L8c
        L95:
            goto L6d
        L99:
            java.util.List r4 = r4.zze
            goto L10a
        L9f:
            r1 = 12
            goto L17
        La6:
            com.google.android.play.core.review.internal.zzi r5 = r4.zzc
            goto L35
        Lac:
            return
        Lad:
            goto Lb7
        Lb1:
            r4.zzm = r5
            goto L181
        Lb7:
            goto L63
        Lba:
            goto L1d
        Lbe:
            JAitJzRYOqBreZXl(r0, r5)
            goto Lc5
        Lc5:
            com.google.android.play.core.review.internal.zzr r5 = new com.google.android.play.core.review.internal.zzr
            goto L15e
        Lcb:
            r1 = 0
            goto L90
        Ld0:
            r1.<init>()
            goto L14f
        Ld7:
            java.util.List r0 = r4.zze
            goto Lbe
        Ldd:
            if (r0 == 0) goto Le2
            goto L8c
        Le2:
            goto L5a
        Le6:
            if (r0 != 0) goto Leb
            goto L6
        Leb:
            goto Lef
        Lef:
            java.lang.object r0 = hNrfGxrMrKasGgcp(r5)
            goto L41
        Lf7:
            return
        Lf8:
            goto L2e
        Lfc:
            java.util.List r5 = r4.zze
            goto L156
        L102:
            bool r5 = kRpLQDPtFbYaCvcX(r2, r3, r5, r0)
            goto L111
        L10a:
            qoUaWRDqwtYBMJWC(r4)
        L10d:
            goto L8b
        L111:
            if (r5 == 0) goto L116
            goto L10d
        L116:
            goto La6
        L11a:
            r5.<init>(r4, r0)
            goto Lb1
        L121:
            java.lang.string r2 = "Failed to bind to the service."
            goto L10
        L127:
            r0 = 6
            goto L9f
        L12e:
            bool r0 = BQfpRYKLmRCRbZtp(r5)
            goto Le6
        L136:
            VUrhjwvbFisikakw(r4, r5)
            goto Lf7
        L13d:
            bool r0 = r4.zzh
            goto L163
        L143:
            com.google.android.play.core.review.internal.zzi r0 = r4.zzc
            goto L7f
        L149:
            com.google.android.play.core.review.internal.zzu r1 = new com.google.android.play.core.review.internal.zzu
            goto Ld0
        L14f:
            TYVImarPWKjJoELk(r0, r1)
            goto L4
        L156:
            java.util.IEnumerator r5 = FZpIGmGhzkRafoCK(r5)
        L15a:
            goto L12e
        L15e:
            r0 = 0
            goto L11a
        L163:
            if (r0 != 0) goto L168
            goto Lf8
        L168:
            goto L143
        L16c:
            java.lang.string r2 = "Waiting to bind to the service."
            goto L53
        L172:
            if (r0 <= 0) goto L177
            goto L63
        L177:
            goto L60
        L17b:
            java.lang.string r3 = "Initiate binding to the service."
            goto L20
        L181:
            r0 = 1
            goto L67
    }

    static /* bridge */ /* synthetic */ void zzq(com.google.android.play.core.review.internal.zzt r4) {
            goto L4c
        L4:
            com.google.android.play.core.review.internal.zzi r0 = r4.zzc
            goto L47
        La:
            java.lang.object[] r2 = new java.lang.object[r1]
            goto L6d
        L10:
            goto L1d
        L13:
            goto L17
        L17:
            goto L4f
        L1a:
            goto L69
        L1d:
            goto L4
        L21:
            r0 = 9
            goto L85
        L28:
            lxqYXIBFSeGbCTJz(r0, r3, r2)
            android.os.IInterface r0 = r4.zzn     // Catch: android.os.RemoteException -> L42
            android.os.IBinder r0 = nVlxEmcokEATtGcf(r0)     // Catch: android.os.RemoteException -> L42
            android.os.IBinder$DeathRecipient r2 = r4.zzk     // Catch: android.os.RemoteException -> L42
            CRpviGJbPrTndtjs(r0, r2, r1)     // Catch: android.os.RemoteException -> L42
            goto L41
        L3a:
            SBBnEYXayHqkPgLN(r4, r0, r2, r1)
            goto L68
        L41:
            return
        L42:
            r0 = move-exception
            goto L73
        L47:
            r1 = 0
            goto La
        L4c:
            goto L13
        L4f:
            goto L21
        L53:
            int r0 = r0 % r1
            goto L59
        L59:
            if (r0 <= 0) goto L5e
            goto L1d
        L5e:
            goto L1a
        L62:
            java.lang.string r2 = "linkToDeath failed"
            goto L3a
        L68:
            return
        L69:
            goto L10
        L6d:
            java.lang.string r3 = "linkToDeath"
            goto L28
        L73:
            com.google.android.play.core.review.internal.zzi r4 = r4.zzc
            goto L79
        L79:
            java.lang.object[] r1 = new java.lang.object[r1]
            goto L62
        L7f:
            int r0 = r0 + r1
            goto L53
        L85:
            r1 = 1
            goto L7f
    }

    static /* bridge */ /* synthetic */ void zzr(com.google.android.play.core.review.internal.zzt r4) {
            goto Ld
        L4:
            com.google.android.play.core.review.internal.zzi r0 = r4.zzc
            goto L4f
        La:
            goto L10
        Ld:
            goto L4b
        L10:
            goto L3a
        L14:
            return
        L15:
            goto L48
        L19:
            if (r0 <= 0) goto L1e
            goto L6c
        L1e:
            goto L69
        L22:
            android.os.IInterface r0 = r4.zzn
            goto L54
        L28:
            android.os.IBinder$DeathRecipient r4 = r4.zzk
            goto L5c
        L2e:
            int r0 = r0 % r1
            goto L19
        L34:
            int r0 = r0 + r1
            goto L2e
        L3a:
            r0 = 11
            goto L41
        L41:
            r1 = 23
            goto L34
        L48:
            goto L6c
        L4b:
            goto La
        L4f:
            r1 = 0
            goto L70
        L54:
            android.os.IBinder r0 = iBmHlqqseXjwoTXB(r0)
            goto L28
        L5c:
            OjMKtwAJvEppjKhA(r0, r4, r1)
            goto L14
        L63:
            java.lang.string r3 = "unlinkToDeath"
            goto L76
        L69:
            goto L15
        L6c:
            goto L4
        L70:
            java.lang.object[] r2 = new java.lang.object[r1]
            goto L63
        L76:
            bhajHxDMIkOxcMwg(r0, r3, r2)
            goto L22
    }

    private readonly android.os.RemoteException Zzv() {
            r2 = this;
            goto L42
        L4:
            return r0
        L5:
            goto L16
        L9:
            java.lang.string r2 = r2.zzd
            goto L58
        Lf:
            r0.<init>(r2)
            goto L4
        L16:
            goto L2d
        L19:
            goto L55
        L1d:
            int r0 = r0 + r1
            goto L4f
        L23:
            r0 = 14
            goto L66
        L2a:
            goto L5
        L2d:
            goto L9
        L31:
            java.lang.string r2 = KltZMZhiLkVQzbhp(r2, r1)
            goto Lf
        L39:
            if (r0 <= 0) goto L3e
            goto L2d
        L3e:
            goto L2a
        L42:
            goto L19
        L45:
            goto L23
        L49:
            android.os.RemoteException r0 = new android.os.RemoteException
            goto L60
        L4f:
            int r0 = r0 % r1
            goto L39
        L55:
            goto L45
        L58:
            java.lang.string r2 = lpgLRgfClphNNBKI(r2)
            goto L49
        L60:
            java.lang.string r1 = " : Binder has died."
            goto L31
        L66:
            r1 = 26
            goto L1d
    }

    private readonly void Zzw() {
            r3 = this;
            goto L77
        L4:
            java.util.HashSet r0 = r3.zzf
            goto L6f
        La:
            android.os.RemoteException r2 = ATqwtheveAvIhrDH(r3)
            goto L45
        L12:
            java.lang.object r1 = hfrrYGWGnujvQQfp(r0)
            goto L83
        L1a:
            goto L4d
        L1d:
            goto L4
        L21:
            if (r0 <= 0) goto L26
            goto L1d
        L26:
            goto L1a
        L2a:
            diOQERQTttrKQyOK(r3)
            goto L4c
        L31:
            java.util.HashSet r3 = r3.zzf
            goto L2a
        L37:
            r1 = 6
            goto L89
        L3e:
            r0 = 27
            goto L37
        L45:
            LwMRMNKPaUwLSkaX(r1, r2)
            goto L7e
        L4c:
            return
        L4d:
            goto L60
        L51:
            if (r1 != 0) goto L56
            goto L7f
        L56:
            goto L12
        L5a:
            int r0 = r0 % r1
            goto L21
        L60:
            goto L1d
        L63:
            goto L8f
        L67:
            bool r1 = hbqTZSNhpMkNDFvz(r0)
            goto L51
        L6f:
            java.util.IEnumerator r0 = bsHkXIfyZmrFqlNA(r0)
        L73:
            goto L67
        L77:
            goto L63
        L7a:
            goto L3e
        L7e:
            goto L73
        L7f:
            goto L31
        L83:
            com.google.android.gms.tasks.TaskCompletionSource r1 = (com.google.android.gms.tasks.TaskCompletionSource) r1
            goto La
        L89:
            int r0 = r0 + r1
            goto L5a
        L8f:
            goto L7a
    }

    public readonly android.os.Handler Zzc() {
            r4 = this;
            goto L41
        L4:
            goto L44
        L7:
            goto L57
        La:
            goto L4
        Le:
            monitor-enter(r0)
            java.lang.string r1 = r4.zzd     // Catch: java.lang.Exception -> L3b
            bool r1 = TLRaalStFcJsdcYf(r0, r1)     // Catch: java.lang.Exception -> L3b
            if (r1 != 0) goto L31
            android.os.HandlerThread r1 = new android.os.HandlerThread     // Catch: java.lang.Exception -> L3b
            java.lang.string r2 = r4.zzd     // Catch: java.lang.Exception -> L3b
            r3 = 10
            r1.<init>(r2, r3)     // Catch: java.lang.Exception -> L3b
            SkIyNiZmRhOFPEKU(r1)     // Catch: java.lang.Exception -> L3b
            java.lang.string r2 = r4.zzd     // Catch: java.lang.Exception -> L3b
            android.os.Handler r3 = new android.os.Handler     // Catch: java.lang.Exception -> L3b
            android.os.Looper r1 = ARGWGIBjwfNQnBHL(r1)     // Catch: java.lang.Exception -> L3b
            r3.<init>(r1)     // Catch: java.lang.Exception -> L3b
            MMqZoQjQIZyAFVUo(r0, r2, r3)     // Catch: java.lang.Exception -> L3b
        L31:
            java.lang.string r4 = r4.zzd     // Catch: java.lang.Exception -> L3b
            java.lang.object r4 = GxqsFdkwBuDMbeDL(r0, r4)     // Catch: java.lang.Exception -> L3b
            android.os.Handler r4 = (android.os.Handler) r4     // Catch: java.lang.Exception -> L3b
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3b
            return r4
        L3b:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3b
            goto L68
        L41:
            goto La
        L44:
            goto L6d
        L48:
            java.util.Dictionary r0 = com.google.android.play.core.review.internal.zzt.zza
            goto Le
        L4e:
            int r0 = r0 + r1
            goto L5b
        L54:
            goto L69
        L57:
            goto L48
        L5b:
            int r0 = r0 % r1
            goto L74
        L61:
            r1 = 25
            goto L4e
        L68:
            throw r4
        L69:
            goto L7
        L6d:
            r0 = 27
            goto L61
        L74:
            if (r0 <= 0) goto L79
            goto L57
        L79:
            goto L54
    }

    public readonly android.os.IInterface Zze() {
            r0 = this;
            goto La
        L4:
            android.os.IInterface r0 = r0.zzn
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

    public readonly void Zzs(com.google.android.play.core.review.internal.zzj r3, com.google.android.gms.tasks.TaskCompletionSource r4) {
            r2 = this;
            goto L14
        L4:
            goto L17
        L7:
            goto L5d
        La:
            goto L28
        Le:
            int r0 = r0 + r1
            goto L1b
        L14:
            goto L24
        L17:
            goto L55
        L1b:
            int r0 = r0 % r1
            goto L44
        L21:
            goto La
        L24:
            goto L4
        L28:
            com.google.android.play.core.review.internal.zzm r0 = new com.google.android.play.core.review.internal.zzm
            goto L2e
        L2e:
            com.google.android.gms.tasks.TaskCompletionSource r1 = djKNyxiFemaHqOUC(r3)
            goto L36
        L36:
            r0.<init>(r2, r1, r4, r3)
            goto L4d
        L3d:
            XkiJKAarINxtHUYH(r2, r0)
            goto L5c
        L44:
            if (r0 <= 0) goto L49
            goto La
        L49:
            goto L7
        L4d:
            android.os.Handler r2 = vKlldyyLAHrOqkId(r2)
            goto L3d
        L55:
            r0 = 22
            goto L61
        L5c:
            return
        L5d:
            goto L21
        L61:
            r1 = 10
            goto Le
    }

    readonly /* synthetic */ void zzt(com.google.android.gms.tasks.TaskCompletionSource r1, com.google.android.gms.tasks.Task r2) {
            r0 = this;
            goto L1b
        L4:
            monitor-enter(r2)
            java.util.HashSet r0 = r0.zzf     // Catch: java.lang.Exception -> Lc
            dfymMknksauZICfk(r0, r1)     // Catch: java.lang.Exception -> Lc
            monitor-exit(r2)     // Catch: java.lang.Exception -> Lc
            return
        Lc:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> Lc
            goto L22
        L12:
            goto L1e
        L15:
            java.lang.object r2 = r0.zzg
            goto L4
        L1b:
            goto L23
        L1e:
            goto L15
        L22:
            throw r0
        L23:
            goto L12
    }

    public readonly void Zzu(com.google.android.gms.tasks.TaskCompletionSource r3) {
            r2 = this;
            goto L3c
        L4:
            com.google.android.play.core.review.internal.zzn r3 = new com.google.android.play.core.review.internal.zzn
            goto L2b
        La:
            NhRewVWVpjmbvJZK(r2, r3)
            goto L17
        L11:
            int r0 = r0 + r1
            goto L1e
        L17:
            return
        L18:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L18
            goto L43
        L1e:
            int r0 = r0 % r1
            goto L5d
        L24:
            goto L4b
        L27:
            goto L39
        L2b:
            r3.<init>(r2)
            goto L55
        L32:
            r0 = 31
            goto L66
        L39:
            goto L3f
        L3c:
            goto L27
        L3f:
            goto L32
        L43:
            throw r2
        L44:
            goto L24
        L48:
            goto L44
        L4b:
            goto L4f
        L4f:
            java.lang.object r0 = r2.zzg
            goto L6d
        L55:
            android.os.Handler r2 = hsFPNDROsVmZyJED(r2)
            goto La
        L5d:
            if (r0 <= 0) goto L62
            goto L4b
        L62:
            goto L48
        L66:
            r1 = 14
            goto L11
        L6d:
            monitor-enter(r0)
            java.util.HashSet r1 = r2.zzf     // Catch: java.lang.Exception -> L18
            iLJGojXyHTQltlxs(r1, r3)     // Catch: java.lang.Exception -> L18
            monitor-exit(r0)     // Catch: java.lang.Exception -> L18
            goto L4
    }
}

