namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
readonly class zzp : android.content.ServiceConnection {
    int zza;
    readonly android.os.Messenger zzb;
    com.google.android.gms.cloudmessaging.zzq zzc;
    readonly java.util.Queue zzd;
    readonly android.util.SparseArray zze;
    readonly /* synthetic */ com.google.android.gms.cloudmessaging.zzv zzf;

    /* synthetic */ zzp(com.google.android.gms.cloudmessaging.zzv r3, com.google.android.gms.cloudmessaging.zzo r4) {
            r2 = this;
            goto L26
        L4:
            if (r0 <= 0) goto L9
            goto L36
        L9:
            goto L33
        Ld:
            r2.zzf = r3
            goto L70
        L13:
            com.google.android.gms.cloudmessaging.zzm r1 = new com.google.android.gms.cloudmessaging.zzm
            goto L97
        L19:
            r3.<init>()
            goto L91
        L20:
            android.util.SparseArray r3 = new android.util.SparseArray
            goto L19
        L26:
            goto La6
        L29:
            goto Lb0
        L2d:
            java.util.ArrayQueue r3 = new java.util.ArrayQueue
            goto L82
        L33:
            goto L78
        L36:
            goto Ld
        L3a:
            r2.zza = r3
            goto L7c
        L40:
            r1 = 8
            goto L54
        L47:
            r4.<init>(r0, r1)
            goto L5d
        L4e:
            r2.zzb = r3
            goto L2d
        L54:
            int r0 = r0 + r1
            goto L64
        L5a:
            goto L29
        L5d:
            r3.<init>(r4)
            goto L4e
        L64:
            int r0 = r0 % r1
            goto L4
        L6a:
            com.google.android.gms.internal.cloudmessaging.zzf r4 = new com.google.android.gms.internal.cloudmessaging.zzf
            goto L89
        L70:
            r2.<init>()
            goto L9e
        L77:
            return
        L78:
            goto La3
        L7c:
            android.os.Messenger r3 = new android.os.Messenger
            goto L6a
        L82:
            r3.<init>()
            goto Laa
        L89:
            android.os.Looper r0 = zjjKoykbfuXnEgjZ()
            goto L13
        L91:
            r2.zze = r3
            goto L77
        L97:
            r1.<init>(r2)
            goto L47
        L9e:
            r3 = 0
            goto L3a
        La3:
            goto L36
        La6:
            goto L5a
        Laa:
            r2.zzd = r3
            goto L20
        Lb0:
            r0 = 6
            goto L40
    }

    public static java.lang.object BYqZOueSKUOCGJgZ(android.util.SparseArray r1, int r2) {
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
            java.lang.object r0 = r1[r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object CYnklOcyXMiuyTtf(android.util.SparseArray r1, int r2) {
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
            java.lang.object r0 = r1.valueAt(r2)
            goto Lb
    }

    public static bool EdDsNLDOMtqPWZYC(java.lang.string r1, int r2) {
            goto Lc
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static void FnjfnCirnmQMUpVn(android.util.SparseArray r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.clear()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static int GYvImevFlimJEteo(android.util.SparseArray r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.Count
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void IAJJDRZzlFJCkWBZ(com.google.android.gms.cloudmessaging.zzp r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.zzf()
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

    public static void JHXOFXFyEEBrWDva(com.google.android.gms.cloudmessaging.zzp r0, int r1, java.lang.string r2, java.lang.Exception r3) {
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
            r0.zzb(r1, r2, r3)
            goto L4
    }

    public static void JKAjOynYYvOnltzd(com.google.android.gms.cloudmessaging.zzp r0, int r1, java.lang.string r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.zza(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.string JhbxUxiIwIVgglky(java.lang.object r1) {
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
            java.lang.string r0 = java.lang.string.valueOf(r1)
            goto Le
    }

    public static java.lang.string KPkqwjiWLqkStXTK(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.concat(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.util.concurrent.ScheduledTask KSXAVbBqAhhuKwHc(java.util.concurrent.ScheduledTaskScheduler r1, java.lang.Action r2, long r3, java.util.concurrent.TimeUnit r5) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.concurrent.ScheduledTask r0 = r1.schedule(r2, r3, r5)
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

    public static java.util.IEnumerator KryBQRFyJiZLMHHC(java.util.Queue r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.util.IEnumerator r0 = r1.GetEnumerator()
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

    public static bool LKJXgZdzQZnScPUd(java.lang.string r1, int r2) {
            goto Lc
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static java.util.concurrent.ScheduledTaskScheduler MBLYFzIGMvBhhVaj(com.google.android.gms.cloudmessaging.zzv r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.android.gms.cloudmessaging.zzv.zze(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void MbWsdMvyrJLtbsec(com.google.android.gms.cloudmessaging.zzp r0, int r1, java.lang.string r2, java.lang.Exception r3) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.zzb(r1, r2, r3)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static bool MfIifLqiPjQrYeqn(java.lang.string r1, int r2) {
            goto L14
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static void NEOagMHnGdzLRGFP(android.util.SparseArray r0, int r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.Remove(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void NcgNAdbukhfQjtCk(java.util.concurrent.ScheduledTaskScheduler r0, java.lang.Action r1) {
            goto Lb
        L4:
            r0.execute(r1)
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

    public static void PnVSpzIFptpQGYFy(bool r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            com.google.android.gms.common.internal.Preconditions.checkState(r0)
            goto Le
    }

    public static java.lang.object QEYSZOcrUuFLYpCv(java.util.IEnumerator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1.Current
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

    public static void QURwRuXTVFgncrrc(com.google.android.gms.cloudmessaging.zzs r0, com.google.android.gms.cloudmessaging.zzt r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.zzc(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void RdkgKyvOKRBcZSGf(java.util.concurrent.ScheduledTaskScheduler r0, java.lang.Action r1) {
            goto Lb
        L4:
            r0.execute(r1)
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

    public static com.google.android.gms.common.stats.ConnectionTracker THUOvmIxwuPQmkFm() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.common.stats.ConnectionTracker r0 = com.google.android.gms.common.stats.ConnectionTracker.getInstance()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int TvqNCdltTHACGjrw(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.w(r1, r2)
            goto Le
    }

    public static bool XJwjUxMBeANaCsRB(java.util.Queue r1, java.lang.object r2) {
            goto L11
        L4:
            bool r0 = r1.Add(r2)
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

    public static bool YVmgCzxaRuIGSceK(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L4
    }

    public static int AQrGEoNsbeBUktbX(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = android.util.Console.v(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void BSvMmIjvdhdtGJwE(com.google.android.gms.common.stats.ConnectionTracker r0, android.content.object r1, android.content.ServiceConnection r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.unbindService(r1, r2)
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

    public static int CrXlqfrJFNZtkyJg(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.v(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static android.content.object DHVmEbtIshuREhTg(com.google.android.gms.cloudmessaging.zzv r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.content.object r0 = com.google.android.gms.cloudmessaging.zzv.zza(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void DHtNjqZciNrCueAi(com.google.android.gms.cloudmessaging.zzp r0, int r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.zza(r1, r2)
            goto Lb
    }

    public static int DmPPYbXmtYuCfqmh(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            int r0 = android.util.Console.d(r1, r2)
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

    public static bool FJNrmYQKTZxvczsK(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Lb
    }

    public static android.content.object FKuIDnYMotoeGUNY(com.google.android.gms.cloudmessaging.zzv r1) {
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
            android.content.object r0 = com.google.android.gms.cloudmessaging.zzv.zza(r1)
            goto Lb
        L18:
            goto L7
    }

    public static bool FdhcJpVZmhMYqDfq(com.google.android.gms.common.stats.ConnectionTracker r1, android.content.object r2, android.content.object r3, android.content.ServiceConnection r4, int r5) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.bindService(r2, r3, r4, r5)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.android.gms.common.stats.ConnectionTracker FhaisDKBJSeYoLZi() {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.common.stats.ConnectionTracker r0 = com.google.android.gms.common.stats.ConnectionTracker.getInstance()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void GukQYzTMUUWKKTnB(java.util.Queue r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.clear()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static java.util.concurrent.ScheduledTaskScheduler HmEasHeeUNiThIHy(com.google.android.gms.cloudmessaging.zzv r1) {
            goto Lf
        L4:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.android.gms.cloudmessaging.zzv.zze(r1)
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

    public static android.content.object HracgXcAbntoiyDM(android.content.object r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.content.object r0 = r1.setPackage(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void IwINbdsnyCIGhGgH(com.google.android.gms.cloudmessaging.zzs r0, com.google.android.gms.cloudmessaging.zzt r1) {
            goto Lb
        L4:
            r0.zzc(r1)
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

    public static int JMwtmqIJHtLTXzQp(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = android.util.Console.v(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool JlYYNdaAESjzadxN(java.lang.string r1, int r2) {
            goto Lc
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static java.util.concurrent.ScheduledTaskScheduler KCJNSdfxBYaWyxfE(com.google.android.gms.cloudmessaging.zzv r1) {
            goto Lc
        L4:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.android.gms.cloudmessaging.zzv.zze(r1)
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

    public static void LqmAVVdRXBmkcyEe(java.util.concurrent.ScheduledTaskScheduler r0, java.lang.Action r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.execute(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool MikgdxjkemUFAEMu(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.MoveNext()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static int MldYhFXYjQdRKzwY(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.v(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static int NyEWByOiANNpPSOZ(android.util.SparseArray r1) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.Count
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

    public static void RPNMsKxszkCKutzJ(com.google.android.gms.cloudmessaging.zzs r0, com.google.android.gms.cloudmessaging.zzt r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.zzc(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void RtewFcSMINcASspF(com.google.android.gms.common.stats.ConnectionTracker r0, android.content.object r1, android.content.ServiceConnection r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.unbindService(r1, r2)
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

    public static com.google.android.gms.common.stats.ConnectionTracker SnJkDkHRxNCanLOo() {
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
            com.google.android.gms.common.stats.ConnectionTracker r0 = com.google.android.gms.common.stats.ConnectionTracker.getInstance()
            goto Le
    }

    public static java.util.concurrent.ScheduledTaskScheduler SwboQqmflrakGcvX(com.google.android.gms.cloudmessaging.zzv r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.android.gms.cloudmessaging.zzv.zze(r1)
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

    public static bool UwfuhrbwtCzwANeu(java.util.Queue r1) {
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

    public static java.lang.stringBuilder VOnluFueMyCLhowj(java.lang.stringBuilder r1, int r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void WebHFtZuhvkzeAtl(com.google.android.gms.cloudmessaging.zzp r0) {
            goto L13
        L4:
            r0.zzc()
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

    public static bool XKnVBckHrSqQtYmn(java.util.Queue r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.Add(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int YrxVknthEkPnSYRz(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.v(r1, r2)
            goto Le
    }

    public static android.content.object ZSoqmLttZRBCwJVA(com.google.android.gms.cloudmessaging.zzv r1) {
            goto Lc
        L4:
            android.content.object r0 = com.google.android.gms.cloudmessaging.zzv.zza(r1)
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

    public static java.lang.string ZSrDBKutbhGbTdcm(java.lang.stringBuilder r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static bool ZUaWrmncoLhTShjO(java.util.Queue r1, java.lang.object r2) {
            goto L11
        L4:
            bool r0 = r1.Add(r2)
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

    public static android.os.Looper ZjjKoykbfuXnEgjZ() {
            goto L14
        L4:
            goto L17
        L7:
            android.os.Looper r0 = android.os.Looper.getMainLooper()
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

    @Override // android.content.ServiceConnection
    public readonly void OnServiceConnected(android.content.ComponentName r2, android.os.IBinder r3) {
            r1 = this;
            goto L31
        L4:
            return
        L5:
            goto L2e
        L9:
            r2 = 2
            goto L22
        Le:
            com.google.android.gms.cloudmessaging.zzi r0 = new com.google.android.gms.cloudmessaging.zzi
            goto L4e
        L14:
            java.util.concurrent.ScheduledTaskScheduler r2 = swboQqmflrakGcvX(r2)
            goto Le
        L1c:
            java.lang.string r2 = "Service connected"
            goto L47
        L22:
            java.lang.string r0 = "MessengerIpcClient"
            goto L3f
        L28:
            com.google.android.gms.cloudmessaging.zzv r2 = r1.zzf
            goto L14
        L2e:
            goto L34
        L31:
            goto L5
        L34:
            goto L9
        L38:
            lqmAVVdRXBmkcyEe(r2, r0)
            goto L4
        L3f:
            bool r2 = LKJXgZdzQZnScPUd(r0, r2)
            goto L55
        L47:
            crXlqfrJFNZtkyJg(r0, r2)
        L4a:
            goto L28
        L4e:
            r0.<init>(r1, r3)
            goto L38
        L55:
            if (r2 != 0) goto L5a
            goto L4a
        L5a:
            goto L1c
    }

    @Override // android.content.ServiceConnection
    public readonly void OnServiceDisconnected(android.content.ComponentName r2) {
            r1 = this;
            goto L23
        L4:
            bool r2 = fJNrmYQKTZxvczsK(r0, r2)
            goto L3e
        Lc:
            java.lang.string r2 = "Service disconnected"
            goto L2a
        L12:
            r2 = 2
            goto L38
        L17:
            com.google.android.gms.cloudmessaging.zzl r0 = new com.google.android.gms.cloudmessaging.zzl
            goto L4c
        L1d:
            com.google.android.gms.cloudmessaging.zzv r2 = r1.zzf
            goto L56
        L23:
            goto L48
        L26:
            goto L12
        L2a:
            jMwtmqIJHtLTXzQp(r0, r2)
        L2d:
            goto L1d
        L31:
            RdkgKyvOKRBcZSGf(r2, r0)
            goto L47
        L38:
            java.lang.string r0 = "MessengerIpcClient"
            goto L4
        L3e:
            if (r2 != 0) goto L43
            goto L2d
        L43:
            goto Lc
        L47:
            return
        L48:
            goto L53
        L4c:
            r0.<init>(r1)
            goto L31
        L53:
            goto L26
        L56:
            java.util.concurrent.ScheduledTaskScheduler r2 = kCJNSdfxBYaWyxfE(r2)
            goto L17
    }

    readonly void zza(int r2, java.lang.string r3) {
            r1 = this;
            goto L10
        L4:
            monitor-enter(r1)
            goto L17
        L9:
            return
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L1f
        L10:
            goto L20
        L13:
            goto L4
        L17:
            r0 = 0
            MbWsdMvyrJLtbsec(r1, r2, r3, r0)     // Catch: java.lang.Exception -> La
            goto L27
        L1f:
            throw r2
        L20:
            goto L24
        L24:
            goto L13
        L27:
            monitor-exit(r1)
            goto L9
    }

    readonly void zzb(int r6, java.lang.string r7, java.lang.Exception r8) {
            r5 = this;
            goto Lda
        L4:
            if (r0 <= 0) goto L9
            goto L70
        L9:
            goto L6d
        Ld:
            r2 = 4
            goto L59
        L12:
            r4 = 1
            goto Le1
        L17:
            int r0 = r0 + r1
            goto L112
        L1d:
            return
        L1e:
            r5.zza = r2     // Catch: java.lang.Exception -> L50
            goto L63
        L24:
            throw r6
        L25:
            goto L3b
        L29:
            if (r0 != 0) goto L2e
            goto L4a
        L2e:
            goto Ld
        L32:
            if (r0 != r3) goto L37
            goto L75
        L37:
            goto Lea
        L3b:
            goto L70
        L3e:
            goto L56
        L42:
            r0 = 31
            goto Ld3
        L49:
            return
        L4a:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> L50
            r6.<init>()     // Catch: java.lang.Exception -> L50
            throw r6     // Catch: java.lang.Exception -> L50
        L50:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L50
            goto L24
        L56:
            goto Ldd
        L59:
            r3 = 2
            goto L12
        L5e:
            monitor-exit(r5)
            goto L1d
        L63:
            monitor-exit(r5)
            goto L74
        L68:
            monitor-exit(r5)
            goto L49
        L6d:
            goto L25
        L70:
            goto Lf3
        L74:
            return
        L75:
            java.lang.string r0 = "MessengerIpcClient"
            bool r0 = MfIifLqiPjQrYeqn(r0, r3)     // Catch: java.lang.Exception -> L50
            if (r0 == 0) goto L84
            java.lang.string r0 = "MessengerIpcClient"
            java.lang.string r1 = "Unbinding service"
            yrxVknthEkPnSYRz(r0, r1)     // Catch: java.lang.Exception -> L50
        L84:
            r5.zza = r2     // Catch: java.lang.Exception -> L50
            com.google.android.gms.cloudmessaging.zzv r0 = r5.zzf     // Catch: java.lang.Exception -> L50
            com.google.android.gms.common.stats.ConnectionTracker r1 = THUOvmIxwuPQmkFm()     // Catch: java.lang.Exception -> L50
            android.content.object r0 = fKuIDnYMotoeGUNY(r0)     // Catch: java.lang.Exception -> L50
            bSvMmIjvdhdtGJwE(r1, r0, r5)     // Catch: java.lang.Exception -> L50
            com.google.android.gms.cloudmessaging.zzt r0 = new com.google.android.gms.cloudmessaging.zzt     // Catch: java.lang.Exception -> L50
            r0.<init>(r6, r7, r8)     // Catch: java.lang.Exception -> L50
            java.util.Queue r6 = r5.zzd     // Catch: java.lang.Exception -> L50
            java.util.IEnumerator r6 = KryBQRFyJiZLMHHC(r6)     // Catch: java.lang.Exception -> L50
        L9e:
            bool r7 = mikgdxjkemUFAEMu(r6)     // Catch: java.lang.Exception -> L50
            if (r7 == 0) goto Lae
            java.lang.object r7 = QEYSZOcrUuFLYpCv(r6)     // Catch: java.lang.Exception -> L50
            com.google.android.gms.cloudmessaging.zzs r7 = (com.google.android.gms.cloudmessaging.zzs) r7     // Catch: java.lang.Exception -> L50
            iwINbdsnyCIGhGgH(r7, r0)     // Catch: java.lang.Exception -> L50
            goto L9e
        Lae:
            java.util.Queue r6 = r5.zzd     // Catch: java.lang.Exception -> L50
            gukQYzTMUUWKKTnB(r6)     // Catch: java.lang.Exception -> L50
            r6 = 0
        Lb4:
            android.util.SparseArray r7 = r5.zze     // Catch: java.lang.Exception -> L50
            int r7 = nyEWByOiANNpPSOZ(r7)     // Catch: java.lang.Exception -> L50
            if (r6 >= r7) goto Lca
            android.util.SparseArray r7 = r5.zze     // Catch: java.lang.Exception -> L50
            java.lang.object r7 = CYnklOcyXMiuyTtf(r7, r6)     // Catch: java.lang.Exception -> L50
            com.google.android.gms.cloudmessaging.zzs r7 = (com.google.android.gms.cloudmessaging.zzs) r7     // Catch: java.lang.Exception -> L50
            rPNMsKxszkCKutzJ(r7, r0)     // Catch: java.lang.Exception -> L50
            int r6 = r6 + 1
            goto Lb4
        Lca:
            android.util.SparseArray r6 = r5.zze     // Catch: java.lang.Exception -> L50
            FnjfnCirnmQMUpVn(r6)     // Catch: java.lang.Exception -> L50
            goto L68
        Ld3:
            r1 = 26
            goto L17
        Lda:
            goto L3e
        Ldd:
            goto L42
        Le1:
            if (r0 != r4) goto Le6
            goto L75
        Le6:
            goto L32
        Lea:
            if (r0 != r1) goto Lef
            goto L1e
        Lef:
            goto L5e
        Lf3:
            monitor-enter(r5)
            java.lang.string r0 = "MessengerIpcClient"
            r1 = 3
            bool r0 = EdDsNLDOMtqPWZYC(r0, r1)     // Catch: java.lang.Exception -> L50
            if (r0 == 0) goto L10c
            java.lang.string r0 = JhbxUxiIwIVgglky(r7)     // Catch: java.lang.Exception -> L50
            java.lang.string r2 = "Disconnected: "
            java.lang.string r3 = "MessengerIpcClient"
            java.lang.string r0 = KPkqwjiWLqkStXTK(r2, r0)     // Catch: java.lang.Exception -> L50
            dmPPYbXmtYuCfqmh(r3, r0)     // Catch: java.lang.Exception -> L50
        L10c:
            int r0 = r5.zza     // Catch: java.lang.Exception -> L50
            goto L29
        L112:
            int r0 = r0 % r1
            goto L4
    }

    readonly void zzc() {
            r2 = this;
            goto L59
        L4:
            NcgNAdbukhfQjtCk(r0, r1)
            goto L19
        Lb:
            r1 = 29
            goto L1e
        L12:
            r0 = 26
            goto Lb
        L19:
            return
        L1a:
            goto L45
        L1e:
            int r0 = r0 + r1
            goto L4c
        L24:
            com.google.android.gms.cloudmessaging.zzv r0 = r2.zzf
            goto L3d
        L2a:
            goto L5c
        L2d:
            if (r0 <= 0) goto L32
            goto L55
        L32:
            goto L52
        L36:
            r1.<init>(r2)
            goto L4
        L3d:
            java.util.concurrent.ScheduledTaskScheduler r0 = hmEasHeeUNiThIHy(r0)
            goto L60
        L45:
            goto L55
        L48:
            goto L2a
        L4c:
            int r0 = r0 % r1
            goto L2d
        L52:
            goto L1a
        L55:
            goto L24
        L59:
            goto L48
        L5c:
            goto L12
        L60:
            com.google.android.gms.cloudmessaging.zzj r1 = new com.google.android.gms.cloudmessaging.zzj
            goto L36
    }

    readonly void zzd() {
            r2 = this;
            goto L62
        L4:
            goto L65
        L7:
            monitor-exit(r2)
            goto L50
        Lc:
            throw r0
        Ld:
            goto L35
        L11:
            if (r0 <= 0) goto L16
            goto L5e
        L16:
            goto L5b
        L1a:
            return
        L1b:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1b
            goto Lc
        L21:
            int r0 = r0 % r1
            goto L11
        L27:
            r0 = 19
            goto L2e
        L2e:
            r1 = 13
            goto L55
        L35:
            goto L5e
        L38:
            goto L4
        L3c:
            monitor-exit(r2)
            goto L1a
        L41:
            monitor-enter(r2)
            int r0 = r2.zza     // Catch: java.lang.Exception -> L1b
            r1 = 1
            if (r0 != r1) goto L51
            java.lang.string r0 = "Timed out while binding"
            dHtNjqZciNrCueAi(r2, r1, r0)     // Catch: java.lang.Exception -> L1b
            goto L7
        L50:
            return
        L51:
            goto L3c
        L55:
            int r0 = r0 + r1
            goto L21
        L5b:
            goto Ld
        L5e:
            goto L41
        L62:
            goto L38
        L65:
            goto L27
    }

    readonly void zze(int r5) {
            r4 = this;
            goto L77
        L4:
            if (r0 <= 0) goto L9
            goto L68
        L9:
            goto L65
        Ld:
            goto L7a
        L10:
            int r0 = r0 % r1
            goto L4
        L16:
            r0 = 13
            goto L5e
        L1d:
            return
        L1e:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L1e
            goto L83
        L24:
            monitor-enter(r4)
            android.util.SparseArray r1 = r4.zze     // Catch: java.lang.Exception -> L1e
            java.lang.object r1 = BYqZOueSKUOCGJgZ(r1, r5)     // Catch: java.lang.Exception -> L1e
            com.google.android.gms.cloudmessaging.zzs r1 = (com.google.android.gms.cloudmessaging.zzs) r1     // Catch: java.lang.Exception -> L1e
            if (r1 == 0) goto L7f
            java.lang.stringBuilder r2 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L1e
            r2.<init>(r0)     // Catch: java.lang.Exception -> L1e
            vOnluFueMyCLhowj(r2, r5)     // Catch: java.lang.Exception -> L1e
            java.lang.string r0 = zSrDBKutbhGbTdcm(r2)     // Catch: java.lang.Exception -> L1e
            java.lang.string r2 = "MessengerIpcClient"
            TvqNCdltTHACGjrw(r2, r0)     // Catch: java.lang.Exception -> L1e
            android.util.SparseArray r0 = r4.zze     // Catch: java.lang.Exception -> L1e
            NEOagMHnGdzLRGFP(r0, r5)     // Catch: java.lang.Exception -> L1e
            java.lang.string r5 = "Timed out waiting for response"
            com.google.android.gms.cloudmessaging.zzt r0 = new com.google.android.gms.cloudmessaging.zzt     // Catch: java.lang.Exception -> L1e
            r2 = 3
            r3 = 0
            r0.<init>(r2, r5, r3)     // Catch: java.lang.Exception -> L1e
            QURwRuXTVFgncrrc(r1, r0)     // Catch: java.lang.Exception -> L1e
            IAJJDRZzlFJCkWBZ(r4)     // Catch: java.lang.Exception -> L1e
            goto L8f
        L58:
            int r0 = r0 + r1
            goto L10
        L5e:
            r1 = 14
            goto L58
        L65:
            goto L84
        L68:
            goto L6c
        L6c:
            java.lang.string r0 = "Timing out request: "
            goto L24
        L72:
            monitor-exit(r4)
            goto L1d
        L77:
            goto L8b
        L7a:
            goto L16
        L7e:
            return
        L7f:
            goto L72
        L83:
            throw r5
        L84:
            goto L88
        L88:
            goto L68
        L8b:
            goto Ld
        L8f:
            monitor-exit(r4)
            goto L7e
    }

    readonly void zzf() {
            r2 = this;
            goto L32
        L4:
            if (r0 <= 0) goto L9
            goto L88
        L9:
            goto L85
        Ld:
            int r0 = r0 % r1
            goto L4
        L13:
            goto L35
        L16:
            monitor-exit(r2)
            goto L8c
        L1b:
            int r0 = r0 + r1
            goto Ld
        L21:
            r0 = 21
            goto L7e
        L28:
            monitor-exit(r2)
            goto L2d
        L2d:
            return
        L2e:
            goto L16
        L32:
            goto L7a
        L35:
            goto L21
        L39:
            monitor-enter(r2)
            int r0 = r2.zza     // Catch: java.lang.Exception -> L8d
            r1 = 2
            if (r0 != r1) goto L2e
            java.util.Queue r0 = r2.zzd     // Catch: java.lang.Exception -> L8d
            bool r0 = uwfuhrbwtCzwANeu(r0)     // Catch: java.lang.Exception -> L8d
            if (r0 == 0) goto L2e
            android.util.SparseArray r0 = r2.zze     // Catch: java.lang.Exception -> L8d
            int r0 = GYvImevFlimJEteo(r0)     // Catch: java.lang.Exception -> L8d
            if (r0 != 0) goto L2e
            java.lang.string r0 = "MessengerIpcClient"
            bool r0 = YVmgCzxaRuIGSceK(r0, r1)     // Catch: java.lang.Exception -> L8d
            if (r0 == 0) goto L5e
            java.lang.string r0 = "MessengerIpcClient"
            java.lang.string r1 = "Finished handling requests, unbinding"
            mldYhFXYjQdRKzwY(r0, r1)     // Catch: java.lang.Exception -> L8d
        L5e:
            r0 = 3
            r2.zza = r0     // Catch: java.lang.Exception -> L8d
            com.google.android.gms.cloudmessaging.zzv r0 = r2.zzf     // Catch: java.lang.Exception -> L8d
            com.google.android.gms.common.stats.ConnectionTracker r1 = snJkDkHRxNCanLOo()     // Catch: java.lang.Exception -> L8d
            android.content.object r0 = zSoqmLttZRBCwJVA(r0)     // Catch: java.lang.Exception -> L8d
            rtewFcSMINcASspF(r1, r0, r2)     // Catch: java.lang.Exception -> L8d
            goto L28
        L72:
            throw r0
        L73:
            goto L77
        L77:
            goto L88
        L7a:
            goto L13
        L7e:
            r1 = 15
            goto L1b
        L85:
            goto L73
        L88:
            goto L39
        L8c:
            return
        L8d:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L8d
            goto L72
    }

    readonly bool zzg(com.google.android.gms.cloudmessaging.zzs r7) {
            r6 = this;
            goto Lea
        L4:
            monitor-exit(r6)
            goto L7a
        L9:
            if (r0 != 0) goto Le
            goto L85
        Le:
            goto Lfd
        L12:
            r0 = 17
            goto L27
        L19:
            if (r0 != r1) goto L1e
            goto Ld7
        L1e:
            goto L106
        L22:
            r1 = 2
            goto L39
        L27:
            r1 = 32
            goto L43
        L2e:
            int r0 = r0 % r1
            goto Lf4
        L34:
            monitor-exit(r6)
            goto L84
        L39:
            r2 = 0
            goto Lca
        L3e:
            throw r7
        L3f:
            goto Lcf
        L43:
            int r0 = r0 + r1
            goto L2e
        L49:
            goto L3f
        L4c:
            goto Le3
        L50:
            goto L6a
        L51:
            com.google.android.gms.cloudmessaging.zzv r7 = r6.zzf     // Catch: java.lang.Exception -> L6f
            java.util.concurrent.ScheduledTaskScheduler r7 = MBLYFzIGMvBhhVaj(r7)     // Catch: java.lang.Exception -> L6f
            com.google.android.gms.cloudmessaging.zzk r0 = new com.google.android.gms.cloudmessaging.zzk     // Catch: java.lang.Exception -> L6f
            r0.<init>(r6)     // Catch: java.lang.Exception -> L6f
            java.util.concurrent.TimeUnit r1 = java.util.concurrent.TimeUnit.SECONDS     // Catch: java.lang.Exception -> L6f
            r4 = 30
            KSXAVbBqAhhuKwHc(r7, r0, r4, r1)     // Catch: java.lang.Exception -> L6f
            goto L6a
        L64:
            r7 = move-exception
            java.lang.string r0 = "Unable to bind to service"
            JHXOFXFyEEBrWDva(r6, r2, r0, r7)     // Catch: java.lang.Exception -> L6f
        L6a:
            goto L75
        L6e:
            return r3
        L6f:
            r7 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L6f
            goto L3e
        L75:
            monitor-exit(r6)
            goto L6e
        L7a:
            return r3
        L7b:
            java.util.Queue r0 = r6.zzd     // Catch: java.lang.Exception -> L6f
            zUaWrmncoLhTShjO(r0, r7)     // Catch: java.lang.Exception -> L6f
            goto L34
        L84:
            return r3
        L85:
            java.util.Queue r0 = r6.zzd     // Catch: java.lang.Exception -> L6f
            XJwjUxMBeANaCsRB(r0, r7)     // Catch: java.lang.Exception -> L6f
            int r7 = r6.zza     // Catch: java.lang.Exception -> L6f
            if (r7 != 0) goto L90
            r7 = r3
            goto L91
        L90:
            r7 = r2
        L91:
            PnVSpzIFptpQGYFy(r7)     // Catch: java.lang.Exception -> L6f
            java.lang.string r7 = "MessengerIpcClient"
            bool r7 = jlYYNdaAESjzadxN(r7, r1)     // Catch: java.lang.Exception -> L6f
            if (r7 == 0) goto La3
            java.lang.string r7 = "MessengerIpcClient"
            java.lang.string r0 = "Starting bind to GmsCore"
            aQrGEoNsbeBUktbX(r7, r0)     // Catch: java.lang.Exception -> L6f
        La3:
            r6.zza = r3     // Catch: java.lang.Exception -> L6f
            android.content.object r7 = new android.content.object     // Catch: java.lang.Exception -> L6f
            java.lang.string r0 = "com.google.android.c2dm.intent.REGISTER"
            r7.<init>(r0)     // Catch: java.lang.Exception -> L6f
            java.lang.string r0 = "com.google.android.gms"
            hracgXcAbntoiyDM(r7, r0)     // Catch: java.lang.Exception -> L6f
            com.google.android.gms.common.stats.ConnectionTracker r0 = fhaisDKBJSeYoLZi()     // Catch: java.lang.SecurityException -> L64 java.lang.Exception -> L6f
            com.google.android.gms.cloudmessaging.zzv r1 = r6.zzf     // Catch: java.lang.SecurityException -> L64 java.lang.Exception -> L6f
            android.content.object r1 = dHVmEbtIshuREhTg(r1)     // Catch: java.lang.SecurityException -> L64 java.lang.Exception -> L6f
            bool r7 = fdhcJpVZmhMYqDfq(r0, r1, r7, r6, r3)     // Catch: java.lang.SecurityException -> L64 java.lang.Exception -> L6f
            if (r7 != 0) goto L51
            java.lang.string r7 = "Unable to bind to service"
            JKAjOynYYvOnltzd(r6, r2, r7)     // Catch: java.lang.SecurityException -> L64 java.lang.Exception -> L6f
            goto L50
        Lca:
            r3 = 1
            goto L9
        Lcf:
            goto L4c
        Ld2:
            goto Lf1
        Ld6:
            return r2
        Ld7:
            java.util.Queue r0 = r6.zzd     // Catch: java.lang.Exception -> L6f
            xKnVBckHrSqQtYmn(r0, r7)     // Catch: java.lang.Exception -> L6f
            webHFtZuhvkzeAtl(r6)     // Catch: java.lang.Exception -> L6f
            goto L4
        Le3:
            monitor-enter(r6)
            int r0 = r6.zza     // Catch: java.lang.Exception -> L6f
            goto L22
        Lea:
            goto Ld2
        Led:
            goto L12
        Lf1:
            goto Led
        Lf4:
            if (r0 <= 0) goto Lf9
            goto L4c
        Lf9:
            goto L49
        Lfd:
            if (r0 != r3) goto L102
            goto L7b
        L102:
            goto L19
        L106:
            monitor-exit(r6)
            goto Ld6
    }
}

