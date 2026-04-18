namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public class Rpc {
    private static int zza;
    private static android.app.Pendingobject zzb;
    private static readonly java.util.concurrent.Executor zzc = null;
    private static readonly java.util.regex.Regex zzd = null;
    private readonly androidx.collection.SimpleArrayDictionary zze;
    private readonly android.content.object zzf;
    private readonly com.google.android.gms.cloudmessaging.zzw zzg;
    private readonly java.util.concurrent.ScheduledTaskScheduler zzh;
    private readonly android.os.Messenger zzi;
    private android.os.Messenger zzj;
    private com.google.android.gms.cloudmessaging.zzd zzk;

    static {
            goto Lc
        L4:
            java.util.regex.Regex r0 = kgEeZyBKqhLPrsvC(r0)
            goto L24
        Lc:
            goto L1a
        Lf:
            goto L1e
        L13:
            java.lang.string r0 = "\\|ID\\|([^|]+)\\|:?+(.*)"
            goto L4
        L19:
            return
        L1a:
            goto L30
        L1e:
            com.google.android.gms.cloudmessaging.zzy r0 = com.google.android.gms.cloudmessaging.zzy.zza
            goto L2a
        L24:
            com.google.android.gms.cloudmessaging.Rpc.zzd = r0
            goto L19
        L2a:
            com.google.android.gms.cloudmessaging.Rpc.zzc = r0
            goto L13
        L30:
            goto Lf
    }

    public Rpc(android.content.object r5) {
            r4 = this;
            goto L33
        L4:
            r5.<init>(r0)
            goto Lc0
        Lb:
            r0.<init>(r5)
            goto La6
        L12:
            com.google.android.gms.cloudmessaging.zzae r0 = new com.google.android.gms.cloudmessaging.zzae
            goto L9e
        L18:
            r4.zze = r0
            goto L8d
        L1e:
            r0.<init>()
            goto L18
        L25:
            goto L56
        L28:
            goto L7e
        L2c:
            aiZzdinnkWAxfies(r5, r1, r3)
            goto L77
        L33:
            goto L28
        L36:
            goto Lb3
        L3a:
            java.util.concurrent.ScheduledThreadPoolExecutor r5 = new java.util.concurrent.ScheduledThreadPoolExecutor
            goto L99
        L40:
            int r0 = r0 + r1
            goto L81
        L46:
            r0.<init>(r4, r1)
            goto L69
        L4d:
            r4.zzi = r5
            goto L3a
        L53:
            goto Lcd
        L56:
            goto L70
        L5a:
            android.os.Messenger r5 = new android.os.Messenger
            goto L12
        L60:
            if (r0 <= 0) goto L65
            goto L56
        L65:
            goto L53
        L69:
            r5.<init>(r0)
            goto L4d
        L70:
            r4.<init>()
            goto Lba
        L77:
            tsceMheGxaQnXFqq(r5, r0)
            goto L87
        L7e:
            goto L36
        L81:
            int r0 = r0 % r1
            goto L60
        L87:
            r4.zzh = r5
            goto Lcc
        L8d:
            r4.zzf = r5
            goto Lc6
        L93:
            java.util.concurrent.TimeUnit r3 = java.util.concurrent.TimeUnit.SECONDS
            goto L2c
        L99:
            r0 = 1
            goto L4
        L9e:
            android.os.Looper r1 = GiZYDmxPSTTtLEHJ()
            goto L46
        La6:
            r4.zzg = r0
            goto L5a
        Lac:
            r1 = 1
            goto L40
        Lb3:
            r0 = 27
            goto Lac
        Lba:
            androidx.collection.SimpleArrayDictionary r0 = new androidx.collection.SimpleArrayDictionary
            goto L1e
        Lc0:
            r1 = 60
            goto L93
        Lc6:
            com.google.android.gms.cloudmessaging.zzw r0 = new com.google.android.gms.cloudmessaging.zzw
            goto Lb
        Lcc:
            return
        Lcd:
            goto L25
    }

    public static void ABkdAXAzcBaCfMZW(com.google.android.gms.cloudmessaging.zzd r0, android.os.Message r1) {
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
            r0.zzb(r1)
            goto Le
    }

    public static com.google.android.gms.cloudmessaging.zzv BOQBpnAUzxErwXGa(android.content.object r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.cloudmessaging.zzv r0 = com.google.android.gms.cloudmessaging.zzv.zzb(r1)
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

    public static java.lang.object BZjslSMDSNokjSap(androidx.collection.SimpleArrayDictionary r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.keyAt(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool CobWaNPSDsoQIRVE(android.os.Dictionary<string, object> r1, java.lang.string r2) {
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
            bool r0 = r1.ContainsKey(r2)
            goto Lb
    }

    public static com.google.android.gms.tasks.Task CqoBgiitMXafgTXL(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int DbrNtInWOQrwUlgc(com.google.android.gms.cloudmessaging.zzw r1) {
            goto L11
        L4:
            int r0 = r1.zza()
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

    public static void ENkeEzQsiPvYMfqu(android.os.Messenger r0, android.os.Message r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.send(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static int FCjNhneVLEGjXrAk(com.google.android.gms.cloudmessaging.zzw r1) {
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
            int r0 = r1.zzb()
            goto L7
    }

    public static void FIqbcJVGqNSHuJxe(android.os.Dictionary<string, object> r0, java.lang.string r1, java.lang.string r2) {
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
            r0.putstring(r1, r2)
            goto Lb
        L17:
            goto L7
    }

    public static void FceCXnfCtNUTalNw(com.google.android.gms.cloudmessaging.Rpc r0, java.lang.string r1, android.os.Dictionary<string, object> r2) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.zzh(r1, r2)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static com.google.android.gms.tasks.Task FkMPfvVivmHRbZwE(com.google.android.gms.cloudmessaging.zzv r1, int r2, android.os.Dictionary<string, object> r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = r1.zzc(r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string FnAxlnUiFMmaQJLk(android.content.object r1, java.lang.string r2) {
            goto L11
        L4:
            java.lang.string r0 = r1.getstringExtra(r2)
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

    public static android.os.Looper GiZYDmxPSTTtLEHJ() {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.os.Looper r0 = android.os.Looper.getMainLooper()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static int HfgtzgdiNpGCoXxJ(java.lang.string r1, java.lang.string r2) {
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

    public static bool IZjNGoUcHIchTiJi(android.os.Dictionary<string, object> r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = zzi(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.android.gms.cloudmessaging.zzv IuYVtVCviPbkhtBN(android.content.object r1) {
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
            com.google.android.gms.cloudmessaging.zzv r0 = com.google.android.gms.cloudmessaging.zzv.zzb(r1)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string IyzVHLNOQNwPOiwD(java.lang.string r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.concat(r2)
            goto Le
    }

    public static java.lang.object JFzOFrYFQATSxMbx(androidx.collection.SimpleArrayDictionary r1, java.lang.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Remove(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static android.content.object JSXOmAyhzWBxWomD(android.content.object r1, java.lang.string r2, android.os.Parcelable r3) {
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
            android.content.object r0 = r1.putExtra(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string JrYunqnXZLOtwJhm(java.lang.string r1, int r2) {
            goto Lf
        L4:
            java.lang.string r0 = r1.Substring(r2)
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

    public static com.google.android.gms.tasks.Task JvzpeVJBXIGJTexK(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.Continuation r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.continueWith(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static bool KfdpKkohIfKqCQby(com.google.android.gms.tasks.Task r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.isSuccessful()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object LOcKUlXgAejIUDQY(com.google.android.gms.tasks.Task r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.getResult()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string LPiLZRYvTqXDzyDb(android.content.object r1) {
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
            java.lang.string r0 = r1.getAction()
            goto Le
    }

    public static int MANadRnXNXUdxURb(com.google.android.gms.cloudmessaging.zzw r1) {
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
            int r0 = r1.zzb()
            goto Le
    }

    public static int MuMetUFDNjiDTWgi(com.google.android.gms.cloudmessaging.zzw r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.zzb()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static int NDfTTUoYOxyRkAQr(java.lang.string r1, java.lang.string r2) {
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

    public static bool NgovJjqmKLmaRJaf(java.lang.string r1, int r2) {
            goto Lf
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static android.content.object NotvJuoxDnFCFSNi(android.content.object r1, java.lang.string r2) {
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
            android.content.object r0 = r1.setPackage(r2)
            goto Le
    }

    public static void NsdDnPCCAgJkXIuT(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
            goto L13
        L4:
            r0.setResult(r1)
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

    public static java.lang.string OQtPmVoRVHLBSMbl(com.google.android.gms.cloudmessaging.CloudMessage r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getMessageId()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string OQwxSKODnTPZkDJe(java.lang.object r1) {
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

    public static void OVdsQwfOnoVFmIhf(android.os.Dictionary<string, object> r0, java.lang.string r1, java.lang.string r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.putstring(r1, r2)
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

    public static android.content.object OwaQKSKoFcaUCtpi(android.content.object r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.object r0 = r1.setPackage(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task PrwniDngNbuGihPe(java.lang.Exception r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
            goto Lb
    }

    public static java.lang.string QGEKaLRSbVsMGNxW(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.concat(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool QKMkCSlCpvOUjEjT(java.lang.string r1, int r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void QTcTToanvtVueXIt(com.google.android.gms.cloudmessaging.Rpc r0, java.lang.string r1, android.os.Dictionary<string, object> r2) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.zzh(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static android.content.object REKMMrYhjqFmMufw(android.content.object r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.object r0 = r1.setAction(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool RLGXYouDkfUtRZDw(java.lang.string r1, int r2) {
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

    public static com.google.android.gms.tasks.Task RSVNPcCylClqVCxk(com.google.android.gms.cloudmessaging.zzv r1, int r2, android.os.Dictionary<string, object> r3) {
            goto L11
        L4:
            com.google.android.gms.tasks.Task r0 = r1.zzd(r2, r3)
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

    public static int RVxfIfzpqUoHygES(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.w(r1, r2)
            goto Le
    }

    public static int RnbmUtjCyBcdFWla(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.d(r1, r2)
            goto Le
    }

    public static void RqTdkhDnygCkjeCa(android.content.object r0, android.content.object r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            zzg(r0, r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static java.lang.object RqhEFErUMytpDYTz(androidx.collection.SimpleArrayDictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.string SPwjOYbhicrxfLUy(int r1) {
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
            java.lang.string r0 = java.lang.int.tostring(r1)
            goto L4
    }

    public static java.lang.string SVvcBEFkwcCGsLow(java.lang.object r1) {
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
            java.lang.string r0 = java.lang.string.valueOf(r1)
            goto Lb
    }

    public static int TPHKrfVUainORnPu(androidx.collection.SimpleArrayDictionary r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.Count
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.os.Dictionary<string, object> TUhkhMadnyTjGUYU(android.content.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.os.Dictionary<string, object> r0 = r1.getExtras()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int TYOOUKSmKMoslIuK(java.lang.string r1, java.lang.string r2) {
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

    public static java.lang.stringBuilder TYiUdoVUueHShANQ(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static android.content.object TewnAtfZhCmnGORT(android.content.object r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.object r0 = r1.setAction(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task TkBOtbVqMpfLZcUD(com.google.android.gms.cloudmessaging.Rpc r1, android.os.Dictionary<string, object> r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.zze(r2)
            goto L4
    }

    public static java.lang.stringBuilder TnVJguWXAkIDqaIw(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.string TomIPTshbdpAZBqa(java.lang.object r1) {
            goto L11
        L4:
            java.lang.string r0 = java.lang.string.valueOf(r1)
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

    public static android.os.Dictionary<string, object> TzNisNkjHGeIohGM(android.content.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            android.os.Dictionary<string, object> r0 = r1.getExtras()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string[] TzOsASFQfnATMqgY(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string[] r0 = r1.Split(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.os.Parcelable UUpWASONikcGAoxY(android.content.object r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.os.Parcelable r0 = r1.getParcelableExtra(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool UdvfACbUOcCEelva(android.os.Dictionary<string, object> r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = zzi(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static android.content.object UjQqJcuSGtrDTsZI(android.content.object r1, java.lang.string r2, java.lang.string r3) {
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
            android.content.object r0 = r1.putExtra(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string UrBuzCzEjJYvpkSY(android.content.object r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getstringExtra(r2)
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

    public static com.google.android.gms.tasks.Task UwbZKQYqQtFOvSxu(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.Continuation r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.continueWith(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool VRfLpxOyClkTjyMv(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Le
    }

    public static com.google.android.gms.tasks.Task VRkbfUsXnwqiqhQD(com.google.android.gms.tasks.TaskCompletionSource r1) {
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
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto Le
    }

    public static android.os.Dictionary<string, object> VgqBUrsgdoTShdei(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.os.Dictionary<string, object> r0 = r1.getExtras()
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

    public static int VjroogztBzXTdnCf(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = android.util.Console.d(r1, r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int VzimCbCJyglvQbWM(com.google.android.gms.cloudmessaging.zzw r1) {
            goto L14
        L4:
            int r0 = r1.zza()
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

    public static com.google.android.gms.tasks.Task WuNkGgbgMxUZzBhL(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCompleteListener r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.addOnCompleteListener(r2, r3)
            goto Le
    }

    public static android.content.object XKcSsRZZkwHxchHk(android.content.object r1, java.lang.string r2, android.os.Parcelable r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.object r0 = r1.putExtra(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task XvVsiXIlRHDoqOok(com.google.android.gms.cloudmessaging.zzv r1, int r2, android.os.Dictionary<string, object> r3) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.gms.tasks.Task r0 = r1.zzc(r2, r3)
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

    public static void YGHIbrSrnwJyFHAI(android.os.Dictionary<string, object> r0, java.lang.string r1, int r2) {
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
            r0.putInt(r1, r2)
            goto Le
    }

    public static java.util.regex.Match YUOIMNOGffoyWQCy(java.util.regex.Regex r1, java.lang.CharSequence r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.util.regex.Match r0 = r1.matcher(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool ZRiWrBtEuMiJHgFD(java.lang.string r1, java.lang.string r2) {
            goto Lf
        L4:
            bool r0 = r1.StartsWith(r2)
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

    public static java.lang.string ZTMvGhhHXTDuwBNv(java.lang.string r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.concat(r2)
            goto L7
    }

    public static int ZzQdRrzPHxaBbykg(java.lang.string r1, java.lang.string r2) {
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

    public static void AiZzdinnkWAxfies(java.util.concurrent.ScheduledThreadPoolExecutor r0, long r1, java.util.concurrent.TimeUnit r3) {
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
            r0.setKeepAliveTime(r1, r3)
            goto L7
    }

    public static com.google.android.gms.tasks.Task BISiynJxXzUBIfvm(com.google.android.gms.cloudmessaging.zzv r1, int r2, android.os.Dictionary<string, object> r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.zzd(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static bool BmwSUjdyeBxniAQP(java.util.regex.Match r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.matches()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string COhVMqAzVxvcPiaf(android.content.object r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.getstringExtra(r2)
            goto Le
    }

    public static void DXIkljKHwYsnmSzA(android.content.object r0, android.content.object r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.sendBroadcast(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void DmcpjwfqXyGpIQfv(android.os.Dictionary<string, object> r0, java.lang.string r1, bool r2) {
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
            r0.putbool(r1, r2)
            goto Lb
    }

    public static java.lang.string DoykCDFsYGZlxcGq(java.lang.stringBuilder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.tostring()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object DsncqgYvoNdqFlZH(androidx.collection.SimpleArrayDictionary r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.Remove(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.string EQwzzJHwTFMquZbq(java.util.regex.Match r1, int r2) {
            goto L11
        L4:
            java.lang.string r0 = r1.group(r2)
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

    public static android.app.Pendingobject EdEDVoELEXRSIBaI(android.content.object r1, int r2, android.content.object r3, int r4) {
            goto L14
        L4:
            android.app.Pendingobject r0 = android.app.Pendingobject.getBroadcast(r1, r2, r3, r4)
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

    public static com.google.android.gms.tasks.Task ExFbSmASSyAYQEWg(java.lang.object r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string FMJPayDSKwWfsfGc(java.lang.object r1) {
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
            java.lang.string r0 = java.lang.string.valueOf(r1)
            goto L4
    }

    public static com.google.android.gms.tasks.Task FSlDSHppnjDdicxx(com.google.android.gms.cloudmessaging.Rpc r1, android.os.Dictionary<string, object> r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.zze(r2)
            goto L7
    }

    public static com.google.android.gms.tasks.Task FXZBBYphqryCPxRN(java.lang.Exception r1) {
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

    public static android.os.Dictionary<string, object> GbndilQUBAiOmaSj(android.content.object r1) {
            goto L11
        L4:
            android.os.Dictionary<string, object> r0 = r1.getExtras()
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

    public static int GrPyAjzEuAWeeEGV(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto Lb
        L18:
            goto L7
    }

    public static bool HFErZFtdcnQzQmjM(java.lang.object r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = java.util.objects.Equals(r1, r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string JFUbfikrCekELHLz(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = java.lang.string.valueOf(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.gms.cloudmessaging.zzv JKdeWPWcbPOFvVfX(android.content.object r1) {
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
            com.google.android.gms.cloudmessaging.zzv r0 = com.google.android.gms.cloudmessaging.zzv.zzb(r1)
            goto L4
    }

    public static bool JcOxpuwVgaWIxcnZ(java.lang.object r1, java.lang.object r2) {
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
            bool r0 = java.util.objects.Equals(r1, r2)
            goto Le
    }

    public static void KItuUaCfkdMEqzkN(com.google.android.gms.cloudmessaging.Rpc r0, java.lang.string r1, android.os.Dictionary<string, object> r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.zzh(r1, r2)
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

    public static android.os.Message KSgsuWZBMZhTCRHy() {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.os.Message r0 = android.os.Message.obtain()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.util.regex.Regex KgEeZyBKqhLPrsvC(java.lang.string r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.regex.Regex r0 = java.util.regex.Regex.compile(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static android.content.object KzIHyBvMSrTcRIkK(android.content.object r1, java.lang.string r2, java.lang.string r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.content.object r0 = r1.putExtra(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool LMFRyvXlWSaqkKUt(java.lang.string r1, int r2) {
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

    public static bool LXNLXWBCHRmYaCuc(java.lang.string r1, java.lang.string r2) {
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
            bool r0 = r1.StartsWith(r2)
            goto Le
    }

    public static com.google.android.gms.tasks.Task LditqxtfjscpyaRb(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.SuccessContinuation r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.onSuccessTask(r2, r3)
            goto L7
    }

    public static com.google.android.gms.tasks.Task MaCgmAMVWvagkoEK(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static android.os.Dictionary<string, object> NMwIYZmUEvMQnTSt(android.content.object r1) {
            goto Lc
        L4:
            android.os.Dictionary<string, object> r0 = r1.getExtras()
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

    public static android.content.object NNKLNXxgxKtWcACo(android.content.object r1, android.os.Dictionary<string, object> r2) {
            goto Lc
        L4:
            android.content.object r0 = r1.putExtras(r2)
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

    public static int OXOqLTciaMjxhzjx(java.lang.string r1, java.lang.string r2) {
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

    public static java.lang.string OmygEzPGwsQEieBt(java.lang.stringBuilder r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static java.lang.string PIEjNTFMvqfENJif(java.lang.string r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.string r0 = r1.concat(r2)
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

    public static bool PYQNbnWwaswghEhG(java.util.concurrent.ScheduledTask r1, bool r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.cancel(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder PxvfcArnWOdUaHPW(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.int QGcJvmmiJmufSjiH(com.google.android.gms.cloudmessaging.CloudMessage r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.int r0 = r1.zza()
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

    public static int QqSCTGguMEObVbeV(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.w(r1, r2)
            goto Lb
    }

    public static com.google.android.gms.cloudmessaging.zzv RCiwVBvcPVTKisOf(android.content.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.gms.cloudmessaging.zzv r0 = com.google.android.gms.cloudmessaging.zzv.zzb(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task RynHVMvCRLAvTiSw(java.lang.Exception r1) {
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

    public static int SSgEIKhHRXjEnbqf(com.google.android.gms.cloudmessaging.zzw r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.zza()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static bool SVBURSjwtxyxrxAP(android.content.object r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.hasExtra(r2)
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

    public static java.lang.string SenZfvwKLufQTLcc(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.string r0 = r1.concat(r2)
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

    public static com.google.android.gms.tasks.Task SlvkIODgALbYzWNI(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.Continuation r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.continueWithTask(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static android.content.ComponentName TKNjCsyuPzkGYStS(android.content.object r1, android.content.object r2) {
            goto L14
        L4:
            android.content.ComponentName r0 = r1.startService(r2)
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

    public static java.util.concurrent.ScheduledTask TUXokEHrMwiIIVps(java.util.concurrent.ScheduledTaskScheduler r1, java.lang.Action r2, long r3, java.util.concurrent.TimeUnit r5) {
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
            java.util.concurrent.ScheduledTask r0 = r1.schedule(r2, r3, r5)
            goto L4
    }

    public static void TsceMheGxaQnXFqq(java.util.concurrent.ScheduledThreadPoolExecutor r0, bool r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.allowCoreThreadTimeOut(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static com.google.android.gms.tasks.Task TtEMQuwZBwVDTMHU(java.lang.Exception r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
            goto L7
    }

    public static java.lang.string WgYHZtgnHAxIxBqw(java.lang.string r1, java.lang.string r2) {
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
            java.lang.string r0 = r1.concat(r2)
            goto L4
    }

    public static java.lang.string XAqDHZIELwPPWbbF() {
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
            java.lang.string r0 = zzf()
            goto L4
    }

    public static int XVlnOkUkCPtXzNxR(com.google.android.gms.cloudmessaging.zzw r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.zza()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string ZAzGOCsDrZrnniXq(java.util.regex.Match r1, int r2) {
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
            java.lang.string r0 = r1.group(r2)
            goto L4
        L18:
            goto Lc
    }

    public static void ZHepFMQvmqpBlLWx(android.content.object r0, java.lang.ClassLoader r1) {
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
            r0.setExtrasClassLoader(r1)
            goto Le
    }

    static /* synthetic */ com.google.android.gms.tasks.Task zza(android.os.Dictionary<string, object> r1) throws java.lang.Exception {
            goto Lc
        L4:
            bool r0 = IZjNGoUcHIchTiJi(r1)
            goto L2d
        Lc:
            goto L29
        Lf:
            goto L4
        L13:
            r1 = 0
            goto L36
        L18:
            return r1
        L19:
            goto L1d
        L1d:
            com.google.android.gms.tasks.Task r1 = exFbSmASSyAYQEWg(r1)
            goto L28
        L25:
            goto Lf
        L28:
            return r1
        L29:
            goto L25
        L2d:
            if (r0 != 0) goto L32
            goto L19
        L32:
            goto L13
        L36:
            com.google.android.gms.tasks.Task r1 = maCgmAMVWvagkoEK(r1)
            goto L18
    }

    static /* bridge */ /* synthetic */ void zzc(com.google.android.gms.cloudmessaging.Rpc r7, android.os.Message r8) {
            goto L165
        L4:
            if (r1 != 0) goto L9
            goto L318
        L9:
            goto L12f
        Ld:
            return
        Le:
            goto L1c4
        L12:
            bool r1 = r0 is com.google.android.gms.cloudmessaging.zzd
            goto L216
        L18:
            java.lang.string r0 = "Rpc"
            goto L2de
        L1e:
            java.lang.string r8 = "Rpc"
            goto Ld1
        L24:
            monitor-enter(r4)
            goto L2b5
        L29:
            return
        L2a:
            goto L21f
        L2e:
            if (r5 == 0) goto L33
            goto L7d
        L33:
            goto L7b
        L37:
            java.lang.string r0 = UrBuzCzEjJYvpkSY(r8, r0)
        L3b:
            goto L1fb
        L3f:
            int r0 = r0 + r1
            goto L1ca
        L45:
            java.lang.object r0 = r8.obj
            goto L272
        L4b:
            if (r7 != 0) goto L50
            goto Lf6
        L50:
            goto L1dd
        L54:
            com.google.android.gms.cloudmessaging.zzc r1 = new com.google.android.gms.cloudmessaging.zzc
            goto L1d6
        L5a:
            java.lang.string r7 = wgYHZtgnHAxIxBqw(r8, r7)
            goto L328
        L62:
            java.lang.string r6 = "ID"
            goto L367
        L68:
            java.lang.string r4 = "Rpc"
            goto L225
        L6e:
            RnbmUtjCyBcdFWla(r5, r4)
        L71:
            goto L16c
        L75:
            java.lang.string r7 = "Rpc"
            goto Ld8
        L7b:
            goto L144
        L7d:
            goto L118
        L81:
            com.google.android.gms.cloudmessaging.zzd r1 = (com.google.android.gms.cloudmessaging.zzd) r1
            goto L1ec
        L87:
            goto L244
        L8a:
            goto L34d
        L8e:
            if (r0 == 0) goto L93
            goto L3b
        L93:
            goto L172
        L97:
            android.content.object r8 = (android.content.object) r8
            goto L2f7
        L9d:
            android.os.Dictionary<string, object> r7 = TzNisNkjHGeIohGM(r8)
            goto L18d
        La5:
            java.lang.string r4 = IyzVHLNOQNwPOiwD(r4, r0)
            goto L10c
        Lad:
            NDfTTUoYOxyRkAQr(r8, r7)
            goto L209
        Lb4:
            java.lang.string r1 = "google.messenger"
            goto L135
        Lba:
            java.lang.string r4 = "\\|"
            goto L356
        Lc0:
            throw r7
        Lc1:
            goto L2af
        Lc5:
            r5 = r4[r3]
            goto L62
        Lcb:
            java.lang.string r7 = "Rpc"
            goto L24e
        Ld1:
            oXOqLTciaMjxhzjx(r8, r7)
            goto Ld
        Ld8:
            bool r7 = VRfLpxOyClkTjyMv(r7, r2)
            goto L1a3
        Le0:
            java.lang.string r4 = "Received InstanceID error "
            goto La5
        Le6:
            r2 = 3
            goto L1f2
        Leb:
            java.lang.string r1 = JrYunqnXZLOtwJhm(r1, r3)
        Lef:
            goto L31c
        Lf3:
            kItuUaCfkdMEqzkN(r7, r0, r8)
        Lf6:
            goto L29
        Lfa:
            r1 = r4[r2]
            goto L1be
        L100:
            goto L168
        L103:
            if (r0 != 0) goto L108
            goto L2a
        L108:
            goto L322
        L10c:
            java.lang.string r5 = "Rpc"
            goto L6e
        L112:
            java.lang.string r0 = "registration_id"
            goto L345
        L118:
            r0 = r4[r1]
            goto Lfa
        L11e:
            bool r1 = jcOxpuwVgaWIxcnZ(r0, r1)
            goto Le6
        L126:
            if (r0 <= 0) goto L12b
            goto L8a
        L12b:
            goto L87
        L12f:
            android.os.Messenger r0 = (android.os.Messenger) r0
            goto L316
        L135:
            android.os.Parcelable r0 = UUpWASONikcGAoxY(r0, r1)
            goto L12
        L13d:
            java.lang.string r8 = "Unexpected response, no error or registration id "
            goto L39d
        L143:
            return
        L144:
            goto L26c
        L148:
            r3 = 1
            goto L1b5
        L14d:
            java.lang.string r7 = "Unexpected response string: "
            goto L38d
        L153:
            java.lang.string r0 = "error"
            goto L20e
        L159:
            return
        L15a:
            goto L68
        L15e:
            r1 = 24
            goto L3f
        L165:
            goto L183
        L168:
            goto L1e5
        L16c:
            java.lang.string r4 = "|"
            goto L395
        L172:
            java.lang.string r0 = "unregistered"
            goto L37
        L178:
            java.lang.string r7 = ZTMvGhhHXTDuwBNv(r7, r0)
            goto L1e
        L180:
            goto L8a
        L183:
            goto L100
        L187:
            java.lang.string r8 = "Rpc"
            goto Lad
        L18d:
            java.lang.string r7 = jFUbfikrCekELHLz(r7)
            goto L278
        L195:
            java.lang.string r8 = "Dropping invalid message"
            goto L375
        L19b:
            bool r2 = ZRiWrBtEuMiJHgFD(r1, r2)
            goto L35e
        L1a3:
            if (r7 != 0) goto L1a8
            goto Lf6
        L1a8:
            goto L14d
        L1ac:
            if (r1 != 0) goto L1b1
            goto L318
        L1b1:
            goto Lb4
        L1b5:
            if (r0 == 0) goto L1ba
            goto Lc1
        L1ba:
            goto L153
        L1be:
            java.lang.string r2 = ":"
            goto L19b
        L1c4:
            androidx.collection.SimpleArrayDictionary r4 = r7.zze
            goto L24
        L1ca:
            int r0 = r0 % r1
            goto L126
        L1d0:
            java.lang.string r8 = "Unexpected response action: "
            goto L18
        L1d6:
            r1.<init>()
            goto L256
        L1dd:
            java.lang.string r7 = SVvcBEFkwcCGsLow(r0)
            goto L1d0
        L1e5:
            r0 = 12
            goto L15e
        L1ec:
            r7.zzk = r1
        L1ee:
            goto L233
        L1f2:
            if (r1 == 0) goto L1f7
            goto L338
        L1f7:
            goto Lcb
        L1fb:
            r1 = 2
            goto L148
        L200:
            if (r0 == 0) goto L205
            goto L15a
        L205:
            goto L9d
        L209:
            return
        L20a:
            goto L37c
        L20e:
            java.lang.string r0 = cOhVMqAzVxvcPiaf(r8, r0)
            goto L200
        L216:
            if (r1 != 0) goto L21b
            goto L1ee
        L21b:
            goto L239
        L21f:
            java.lang.string r7 = "Rpc"
            goto L195
        L225:
            bool r4 = lMFRyvXlWSaqkKUt(r4, r2)
            goto L297
        L22d:
            java.lang.string r1 = "com.google.android.c2dm.intent.REGISTRATION"
            goto L11e
        L233:
            bool r1 = r0 is android.os.Messenger
            goto L4
        L239:
            r1 = r0
            goto L81
        L23e:
            int r5 = r4.length
            goto L2ee
        L243:
            return
        L244:
            goto L180
        L248:
            java.lang.string r2 = "registration_id"
            goto L265
        L24e:
            bool r7 = RLGXYouDkfUtRZDw(r7, r2)
            goto L4b
        L256:
            zHepFMQvmqpBlLWx(r0, r1)
            goto L36f
        L25d:
            bool r1 = sVBURSjwtxyxrxAP(r0, r1)
            goto L1ac
        L265:
            OVdsQwfOnoVFmIhf(r8, r2, r1)
            goto Lf3
        L26c:
            java.lang.string r7 = "Unexpected structured response "
            goto L178
        L272:
            bool r0 = r0 is android.content.object
            goto L103
        L278:
            java.lang.string r7 = fMJPayDSKwWfsfGc(r7)
            goto L13d
        L280:
            if (r5 == 0) goto L285
            goto L20a
        L285:
            goto L75
        L289:
            java.lang.string r1 = zAzGOCsDrZrnniXq(r4, r1)
            goto L384
        L291:
            java.lang.object r8 = r8.obj
            goto L97
        L297:
            if (r4 != 0) goto L29c
            goto L71
        L29c:
            goto Le0
        L2a0:
            bool r5 = bmwSUjdyeBxniAQP(r4)
            goto L280
        L2a8:
            FceCXnfCtNUTalNw(r7, r0, r8)
            goto L143
        L2af:
            java.util.regex.Regex r4 = com.google.android.gms.cloudmessaging.Rpc.zzd
            goto L306
        L2b5:
            r0 = 0
        L2b6:
            androidx.collection.SimpleArrayDictionary r1 = r7.zze     // Catch: java.lang.Exception -> L2d2
            int r1 = TPHKrfVUainORnPu(r1)     // Catch: java.lang.Exception -> L2d2
            if (r0 >= r1) goto L2d0
            androidx.collection.SimpleArrayDictionary r1 = r7.zze     // Catch: java.lang.Exception -> L2d2
            java.lang.object r1 = BZjslSMDSNokjSap(r1, r0)     // Catch: java.lang.Exception -> L2d2
            java.lang.string r1 = (java.lang.string) r1     // Catch: java.lang.Exception -> L2d2
            android.os.Dictionary<string, object> r2 = VgqBUrsgdoTShdei(r8)     // Catch: java.lang.Exception -> L2d2
            QTcTToanvtVueXIt(r7, r1, r2)     // Catch: java.lang.Exception -> L2d2
            int r0 = r0 + 1
            goto L2b6
        L2d0:
            monitor-exit(r4)     // Catch: java.lang.Exception -> L2d2
            return
        L2d2:
            r7 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L2d2
            goto Lc0
        L2d8:
            android.content.object r0 = (android.content.object) r0
            goto L54
        L2de:
            java.lang.string r7 = pIEjNTFMvqfENJif(r8, r7)
            goto L2ff
        L2e6:
            android.content.object r8 = UjQqJcuSGtrDTsZI(r8, r2, r1)
            goto L32f
        L2ee:
            if (r5 > r1) goto L2f3
            goto L144
        L2f3:
            goto Lc5
        L2f7:
            java.lang.string r0 = LPiLZRYvTqXDzyDb(r8)
            goto L22d
        L2ff:
            ZzQdRrzPHxaBbykg(r0, r7)
            goto L337
        L306:
            java.util.regex.Match r4 = YUOIMNOGffoyWQCy(r4, r0)
            goto L2a0
        L30e:
            android.os.Dictionary<string, object> r8 = gbndilQUBAiOmaSj(r8)
            goto L248
        L316:
            r7.zzj = r0
        L318:
            goto L291
        L31c:
            java.lang.string r2 = "error"
            goto L2e6
        L322:
            java.lang.object r0 = r8.obj
            goto L2d8
        L328:
            TYOOUKSmKMoslIuK(r0, r7)
            goto L159
        L32f:
            android.os.Dictionary<string, object> r8 = TUhkhMadnyTjGUYU(r8)
            goto L2a8
        L337:
            return
        L338:
            goto L112
        L33c:
            if (r4 != 0) goto L341
            goto Le
        L341:
            goto Lba
        L345:
            java.lang.string r0 = FnAxlnUiFMmaQJLk(r8, r0)
            goto L8e
        L34d:
            if (r8 != 0) goto L352
            goto L2a
        L352:
            goto L45
        L356:
            java.lang.string[] r4 = TzOsASFQfnATMqgY(r0, r4)
            goto L23e
        L35e:
            if (r2 != 0) goto L363
            goto Lef
        L363:
            goto Leb
        L367:
            bool r5 = hFErZFtdcnQzQmjM(r5, r6)
            goto L2e
        L36f:
            java.lang.string r1 = "google.messenger"
            goto L25d
        L375:
            qqSCTGguMEObVbeV(r7, r8)
            goto L243
        L37c:
            java.lang.string r0 = eQwzzJHwTFMquZbq(r4, r3)
            goto L289
        L384:
            if (r0 != 0) goto L389
            goto Lf6
        L389:
            goto L30e
        L38d:
            java.lang.string r7 = senZfvwKLufQTLcc(r7, r0)
            goto L187
        L395:
            bool r4 = lXNLXWBCHRmYaCuc(r0, r4)
            goto L33c
        L39d:
            java.lang.string r0 = "Rpc"
            goto L5a
    }

    private readonly com.google.android.gms.tasks.Task Zze(android.os.Dictionary<string, object> r8) {
            r7 = this;
            goto L98
        L4:
            goto La6
        L7:
            goto L190
        Lb:
            com.google.android.gms.cloudmessaging.zzad r4 = new com.google.android.gms.cloudmessaging.zzad
            goto L11
        L11:
            r4.<init>(r7, r0, r8)
            goto L1af
        L18:
            if (r8 == 0) goto L1d
            goto Lc7
        L1d:
            goto Lf6
        L21:
            java.lang.stringBuilder r8 = new java.lang.stringBuilder
            goto L1c2
        L27:
            java.lang.string r3 = "|"
            goto L6f
        L2d:
            java.lang.string r6 = "Rpc"
            goto L132
        L33:
            java.util.concurrent.TimeUnit r5 = java.util.concurrent.TimeUnit.SECONDS
            goto L153
        L39:
            android.os.Messenger r8 = r7.zzj
            goto L18
        L3f:
            com.google.android.gms.cloudmessaging.zzw r3 = r7.zzg
            goto L25a
        L45:
            goto L114
        L47:
            goto L1df
        L4b:
            OwaQKSKoFcaUCtpi(r2, r3)
            goto L3f
        L52:
            java.lang.string r8 = TomIPTshbdpAZBqa(r8)
            goto L1e5
        L5a:
            java.lang.string r3 = "kid"
            goto Laa
        L60:
            VjroogztBzXTdnCf(r6, r8)
        L63:
            goto Lf0
        L67:
            android.os.Message r8 = kSgsuWZBMZhTCRHy()
            goto Ld7
        L6f:
            pxvfcArnWOdUaHPW(r8, r3)
            goto L76
        L76:
            java.lang.string r8 = doykCDFsYGZlxcGq(r8)
            goto L5a
        L7e:
            REKMMrYhjqFmMufw(r2, r3)
        L81:
            goto L1a1
        L85:
            android.content.object r2 = new android.content.object
            goto L10a
        L8b:
            r1 = 23
            goto L216
        L92:
            androidx.collection.SimpleArrayDictionary r2 = r7.zze
            goto L15b
        L98:
            goto L17d
        L9b:
            goto L1f5
        L9f:
            java.lang.string r3 = "com.google.iid.TOKEN_REQUEST"
            goto Ld0
        La5:
            throw r7
        La6:
            goto L17a
        Laa:
            kzIHyBvMSrTcRIkK(r2, r3, r8)
            goto L239
        Lb1:
            android.content.object r8 = r7.zzf
            goto L1a8
        Lb7:
            goto L114
        Lb8:
            goto L254
        Lbc:
            java.lang.string r3 = "com.google.android.gms"
            goto L4b
        Lc2:
            if (r8 != 0) goto Lc7
            goto L1cb
        Lc7:
            goto L67
        Lcb:
            goto L81
        Lcc:
            goto L140
        Ld0:
            TewnAtfZhCmnGORT(r2, r3)
            goto Lcb
        Ld7:
            r8.obj = r2
            android.os.Messenger r5 = r7.zzj     // Catch: android.os.RemoteException -> L47
            if (r5 == 0) goto Le1
            ENkeEzQsiPvYMfqu(r5, r8)     // Catch: android.os.RemoteException -> L47
            goto L114
        Le1:
            com.google.android.gms.cloudmessaging.zzd r5 = r7.zzk     // Catch: android.os.RemoteException -> L47
            ABkdAXAzcBaCfMZW(r5, r8)     // Catch: android.os.RemoteException -> L47
            goto L45
        Lea:
            java.lang.string r5 = "google.messenger"
            goto L16c
        Lf0:
            android.os.Messenger r8 = r7.zzi
            goto Lea
        Lf6:
            com.google.android.gms.cloudmessaging.zzd r8 = r7.zzk
            goto Lc2
        Lfc:
            r1.<init>()
            goto L92
        L103:
            r2.<init>(r1)
            goto L23f
        L10a:
            r2.<init>()
            goto Lbc
        L111:
            tKNjCsyuPzkGYStS(r8, r2)
        L114:
            goto L22b
        L118:
            r4 = 2
            goto L1fc
        L11d:
            bool r8 = QKMkCSlCpvOUjEjT(r8, r3)
            goto L205
        L125:
            return r7
        L126:
            r7 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L126
            goto La5
        L12c:
            java.util.concurrent.Executor r3 = com.google.android.gms.cloudmessaging.Rpc.zzc
            goto Lb
        L132:
            java.lang.string r8 = QGEKaLRSbVsMGNxW(r5, r8)
            goto L60
        L13a:
            java.lang.string r8 = "Rpc"
            goto L1b6
        L140:
            java.lang.string r3 = "com.google.android.c2dm.intent.REGISTER"
            goto L7e
        L146:
            r3 = 3
            goto L11d
        L14b:
            bool r8 = NgovJjqmKLmaRJaf(r8, r3)
            goto L198
        L153:
            java.util.concurrent.ScheduledTask r8 = tUXokEHrMwiIIVps(r8, r2, r3, r5)
            goto L1cf
        L15b:
            monitor-enter(r2)
            androidx.collection.SimpleArrayDictionary r3 = r7.zze     // Catch: java.lang.Exception -> L126
            RqhEFErUMytpDYTz(r3, r0, r1)     // Catch: java.lang.Exception -> L126
            monitor-exit(r2)     // Catch: java.lang.Exception -> L126
            goto L85
        L166:
            int r0 = r0 % r1
            goto L24b
        L16c:
            JSXOmAyhzWBxWomD(r2, r5, r8)
            goto L39
        L173:
            r8.<init>(r3)
            goto L181
        L17a:
            goto L7
        L17d:
            goto L1eb
        L181:
            TnVJguWXAkIDqaIw(r8, r0)
            goto L27
        L188:
            com.google.android.gms.tasks.Task r7 = VRkbfUsXnwqiqhQD(r1)
            goto L125
        L190:
            java.lang.string r0 = xAqDHZIELwPPWbbF()
            goto L21c
        L198:
            if (r8 != 0) goto L19d
            goto L1cb
        L19d:
            goto L13a
        L1a1:
            nNKLNXxgxKtWcACo(r2, r8)
            goto Lb1
        L1a8:
            RqTdkhDnygCkjeCa(r8, r2)
            goto L21
        L1af:
            WuNkGgbgMxUZzBhL(r2, r3, r4)
            goto L188
        L1b6:
            java.lang.string r3 = "Messenger failed, fallback to startService"
            goto L1c8
        L1bc:
            com.google.android.gms.cloudmessaging.zzac r2 = new com.google.android.gms.cloudmessaging.zzac
            goto L103
        L1c2:
            java.lang.string r3 = "|ID|"
            goto L173
        L1c8:
            HfgtzgdiNpGCoXxJ(r8, r3)
        L1cb:
            goto L262
        L1cf:
            com.google.android.gms.tasks.Task r2 = CqoBgiitMXafgTXL(r1)
            goto L12c
        L1d7:
            android.os.Dictionary<string, object> r8 = nMwIYZmUEvMQnTSt(r2)
            goto L231
        L1df:
            java.lang.string r8 = "Rpc"
            goto L14b
        L1e5:
            java.lang.string r5 = "Sending "
            goto L2d
        L1eb:
            goto L9b
        L1ee:
            dXIkljKHwYsnmSzA(r8, r2)
            goto Lb7
        L1f5:
            r0 = 3
            goto L8b
        L1fc:
            if (r3 == r4) goto L201
            goto Lcc
        L201:
            goto L9f
        L205:
            if (r8 != 0) goto L20a
            goto L63
        L20a:
            goto L1d7
        L20e:
            int r8 = MANadRnXNXUdxURb(r8)
            goto L222
        L216:
            int r0 = r0 + r1
            goto L166
        L21c:
            com.google.android.gms.tasks.TaskCompletionSource r1 = new com.google.android.gms.tasks.TaskCompletionSource
            goto Lfc
        L222:
            if (r8 == r4) goto L227
            goto Lb8
        L227:
            goto L245
        L22b:
            java.util.concurrent.ScheduledTaskScheduler r8 = r7.zzh
            goto L1bc
        L231:
            java.lang.string r8 = OQwxSKODnTPZkDJe(r8)
            goto L52
        L239:
            java.lang.string r8 = "Rpc"
            goto L146
        L23f:
            r3 = 30
            goto L33
        L245:
            android.content.object r8 = r7.zzf
            goto L1ee
        L24b:
            if (r0 <= 0) goto L250
            goto L7
        L250:
            goto L4
        L254:
            android.content.object r8 = r7.zzf
            goto L111
        L25a:
            int r3 = FCjNhneVLEGjXrAk(r3)
            goto L118
        L262:
            com.google.android.gms.cloudmessaging.zzw r8 = r7.zzg
            goto L20e
    }

    private static java.lang.string Zzf() {
            goto L46
        L4:
            java.lang.Class<com.google.android.gms.cloudmessaging.Rpc> r0 = com.google.android.gms.cloudmessaging.Rpc.class
            goto L1f
        La:
            if (r0 <= 0) goto Lf
            goto L5c
        Lf:
            goto L59
        L13:
            return r1
        L14:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L14
            goto L60
        L1a:
            monitor-exit(r0)
            goto L13
        L1f:
            monitor-enter(r0)
            int r1 = com.google.android.gms.cloudmessaging.Rpc.zza     // Catch: java.lang.Exception -> L14
            int r2 = r1 + 1
            com.google.android.gms.cloudmessaging.Rpc.zza = r2     // Catch: java.lang.Exception -> L14
            java.lang.string r1 = SPwjOYbhicrxfLUy(r1)     // Catch: java.lang.Exception -> L14
            goto L1a
        L2e:
            r0 = 24
            goto L3f
        L35:
            goto L49
        L38:
            goto L5c
        L3b:
            goto L35
        L3f:
            r1 = 18
            goto L53
        L46:
            goto L3b
        L49:
            goto L2e
        L4d:
            int r0 = r0 % r1
            goto La
        L53:
            int r0 = r0 + r1
            goto L4d
        L59:
            goto L61
        L5c:
            goto L4
        L60:
            throw r1
        L61:
            goto L38
    }

    private static void Zzg(android.content.object r4, android.content.object r5) {
            goto L3f
        L4:
            monitor-exit(r0)
            goto L51
        L9:
            int r0 = r0 % r1
            goto L66
        Lf:
            goto L62
        L12:
            goto L6f
        L16:
            monitor-enter(r0)
            android.app.Pendingobject r1 = com.google.android.gms.cloudmessaging.Rpc.zzb     // Catch: java.lang.Exception -> L52
            if (r1 != 0) goto L2e
            android.content.object r1 = new android.content.object     // Catch: java.lang.Exception -> L52
            r1.<init>()     // Catch: java.lang.Exception -> L52
            java.lang.string r2 = "com.google.example.invalidpackage"
            NotvJuoxDnFCFSNi(r1, r2)     // Catch: java.lang.Exception -> L52
            int r2 = com.google.android.gms.internal.cloudmessaging.zza.zza     // Catch: java.lang.Exception -> L52
            r3 = 0
            android.app.Pendingobject r4 = edEDVoELEXRSIBaI(r4, r3, r1, r2)     // Catch: java.lang.Exception -> L52
            com.google.android.gms.cloudmessaging.Rpc.zzb = r4     // Catch: java.lang.Exception -> L52
        L2e:
            java.lang.string r4 = "app"
            android.app.Pendingobject r1 = com.google.android.gms.cloudmessaging.Rpc.zzb     // Catch: java.lang.Exception -> L52
            XKcSsRZZkwHxchHk(r5, r4, r1)     // Catch: java.lang.Exception -> L52
            goto L4
        L39:
            int r0 = r0 + r1
            goto L9
        L3f:
            goto L12
        L42:
            goto L72
        L46:
            throw r4
        L47:
            goto Lf
        L4b:
            java.lang.Class<com.google.android.gms.cloudmessaging.Rpc> r0 = com.google.android.gms.cloudmessaging.Rpc.class
            goto L16
        L51:
            return
        L52:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L52
            goto L46
        L58:
            r1 = 12
            goto L39
        L5f:
            goto L47
        L62:
            goto L4b
        L66:
            if (r0 <= 0) goto L6b
            goto L62
        L6b:
            goto L5f
        L6f:
            goto L42
        L72:
            r0 = 7
            goto L58
    }

    private readonly void Zzh(java.lang.string r3, android.os.Dictionary<string, object> r4) {
            r2 = this;
            goto L3d
        L4:
            goto L40
        L7:
            int r0 = r0 % r1
            goto L5c
        Ld:
            monitor-enter(r1)
            androidx.collection.SimpleArrayDictionary r2 = r2.zze     // Catch: java.lang.Exception -> L30
            java.lang.object r2 = JFzOFrYFQATSxMbx(r2, r3)     // Catch: java.lang.Exception -> L30
            com.google.android.gms.tasks.TaskCompletionSource r2 = (com.google.android.gms.tasks.TaskCompletionSource) r2     // Catch: java.lang.Exception -> L30
            if (r2 != 0) goto L2b
            java.lang.string r2 = "Rpc"
            java.lang.stringBuilder r4 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L30
            r4.<init>(r0)     // Catch: java.lang.Exception -> L30
            TYiUdoVUueHShANQ(r4, r3)     // Catch: java.lang.Exception -> L30
            java.lang.string r3 = omygEzPGwsQEieBt(r4)     // Catch: java.lang.Exception -> L30
            RVxfIfzpqUoHygES(r2, r3)     // Catch: java.lang.Exception -> L30
            monitor-exit(r1)     // Catch: java.lang.Exception -> L30
            return
        L2b:
            NsdDnPCCAgJkXIuT(r2, r4)     // Catch: java.lang.Exception -> L30
            monitor-exit(r1)     // Catch: java.lang.Exception -> L30
            return
        L30:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L30
            goto L51
        L36:
            r1 = 5
            goto L4b
        L3d:
            goto L75
        L40:
            goto L44
        L44:
            r0 = 2
            goto L36
        L4b:
            int r0 = r0 + r1
            goto L7
        L51:
            throw r2
        L52:
            goto L72
        L56:
            java.lang.string r0 = "Missing callback for "
            goto L65
        L5c:
            if (r0 <= 0) goto L61
            goto L6e
        L61:
            goto L6b
        L65:
            androidx.collection.SimpleArrayDictionary r1 = r2.zze
            goto Ld
        L6b:
            goto L52
        L6e:
            goto L56
        L72:
            goto L6e
        L75:
            goto L4
    }

    private static bool Zzi(android.os.Dictionary<string, object> r1) {
            goto L4
        L4:
            goto L2f
        L7:
            goto L33
        Lb:
            return r1
        Lc:
            goto L29
        L10:
            if (r1 != 0) goto L15
            goto Lc
        L15:
            goto L21
        L19:
            bool r1 = CobWaNPSDsoQIRVE(r1, r0)
            goto L10
        L21:
            r1 = 1
            goto Lb
        L26:
            goto L7
        L29:
            r1 = 0
            goto L2e
        L2e:
            return r1
        L2f:
            goto L26
        L33:
            if (r1 != 0) goto L38
            goto Lc
        L38:
            goto L3c
        L3c:
            java.lang.string r0 = "google.messenger"
            goto L19
    }

    public com.google.android.gms.tasks.Task<com.google.android.gms.cloudmessaging.CloudMessage> GetProxiedNotificationData() {
            r2 = this;
            goto L42
        L4:
            if (r0 <= 0) goto L9
            goto L69
        L9:
            goto L66
        Ld:
            com.google.android.gms.tasks.Task r2 = RSVNPcCylClqVCxk(r2, r0, r1)
            goto L95
        L15:
            com.google.android.gms.cloudmessaging.zzv r2 = rCiwVBvcPVTKisOf(r2)
            goto L36
        L1d:
            r0 = 14
            goto L9b
        L24:
            com.google.android.gms.cloudmessaging.zzw r0 = r2.zzg
            goto Laf
        L2a:
            java.io.IOException r2 = new java.io.IOException
            goto L60
        L30:
            int r0 = r0 + r1
            goto L72
        L36:
            r0 = 5
            goto L5a
        L3b:
            goto L69
        L3e:
            goto L92
        L42:
            goto L3e
        L45:
            goto L1d
        L49:
            com.google.android.gms.tasks.Task r2 = rynHVMvCRLAvTiSw(r2)
            goto Laa
        L51:
            if (r0 >= r1) goto L56
            goto L6e
        L56:
            goto L7f
        L5a:
            android.os.Dictionary<string, object> r1 = android.os.Dictionary<string, object>.EMPTY
            goto Ld
        L60:
            java.lang.string r0 = "SERVICE_NOT_AVAILABLE"
            goto L85
        L66:
            goto Lab
        L69:
            goto L24
        L6d:
            return r2
        L6e:
            goto L2a
        L72:
            int r0 = r0 % r1
            goto L4
        L78:
            r1 = 241100000(0xe5ee4e0, float:2.7473812E-30)
            goto L51
        L7f:
            android.content.object r2 = r2.zzf
            goto L15
        L85:
            r2.<init>(r0)
            goto L49
        L8c:
            com.google.android.gms.cloudmessaging.zzab r1 = com.google.android.gms.cloudmessaging.zzab.zza
            goto La2
        L92:
            goto L45
        L95:
            java.util.concurrent.Executor r0 = com.google.android.gms.cloudmessaging.Rpc.zzc
            goto L8c
        L9b:
            r1 = 12
            goto L30
        La2:
            com.google.android.gms.tasks.Task r2 = UwbZKQYqQtFOvSxu(r2, r0, r1)
            goto L6d
        Laa:
            return r2
        Lab:
            goto L3b
        Laf:
            int r0 = VzimCbCJyglvQbWM(r0)
            goto L78
    }

    public com.google.android.gms.tasks.Task<java.lang.void> MessageHandled(com.google.android.gms.cloudmessaging.CloudMessage r4) {
            r3 = this;
            goto L1f
        L4:
            r0.<init>()
            goto L95
        Lb:
            com.google.android.gms.tasks.Task r3 = PrwniDngNbuGihPe(r3)
            goto Ld2
        L13:
            r1 = 20
            goto L26
        L1a:
            r4 = 3
            goto L59
        L1f:
            goto L55
        L22:
            goto L7b
        L26:
            int r0 = r0 + r1
            goto Lc7
        L2c:
            r3.<init>(r4)
            goto Lb
        L33:
            int r0 = DbrNtInWOQrwUlgc(r0)
            goto L61
        L3b:
            android.os.Dictionary<string, object> r0 = new android.os.Dictionary<string, object>
            goto L4
        L41:
            goto L22
        L44:
            java.io.IOException r3 = new java.io.IOException
            goto L8f
        L4a:
            int r4 = grPyAjzEuAWeeEGV(r4)
            goto L88
        L52:
            goto Lba
        L55:
            goto L41
        L59:
            com.google.android.gms.tasks.Task r3 = FkMPfvVivmHRbZwE(r3, r4, r0)
            goto Lcd
        L61:
            r1 = 233700000(0xdedfaa0, float:1.46665885E-30)
            goto L9d
        L68:
            android.content.object r3 = r3.zzf
            goto Ld7
        L6e:
            FIqbcJVGqNSHuJxe(r0, r2, r1)
            goto La6
        L75:
            com.google.android.gms.cloudmessaging.zzw r0 = r3.zzg
            goto L33
        L7b:
            r0 = 11
            goto L13
        L82:
            java.lang.string r1 = "google.product_id"
            goto L4a
        L88:
            YGHIbrSrnwJyFHAI(r0, r1, r4)
        L8b:
            goto L68
        L8f:
            java.lang.string r4 = "SERVICE_NOT_AVAILABLE"
            goto L2c
        L95:
            java.lang.string r1 = OQtPmVoRVHLBSMbl(r4)
            goto Ldf
        L9d:
            if (r0 >= r1) goto La2
            goto Lce
        La2:
            goto L3b
        La6:
            java.lang.int r4 = qGcJvmmiJmufSjiH(r4)
            goto Lbe
        Lae:
            if (r0 <= 0) goto Lb3
            goto Lba
        Lb3:
            goto Lb7
        Lb7:
            goto Ld3
        Lba:
            goto L75
        Lbe:
            if (r4 != 0) goto Lc3
            goto L8b
        Lc3:
            goto L82
        Lc7:
            int r0 = r0 % r1
            goto Lae
        Lcd:
            return r3
        Lce:
            goto L44
        Ld2:
            return r3
        Ld3:
            goto L52
        Ld7:
            com.google.android.gms.cloudmessaging.zzv r3 = BOQBpnAUzxErwXGa(r3)
            goto L1a
        Ldf:
            java.lang.string r2 = "google.message_id"
            goto L6e
    }

    public com.google.android.gms.tasks.Task<android.os.Dictionary<string, object>> Send(android.os.Dictionary<string, object> r4) {
            r3 = this;
            goto L89
        L4:
            r1 = 2
            goto L14
        Lb:
            goto L8c
        Le:
            java.lang.string r4 = "MISSING_INSTANCEID_SERVICE"
            goto L7b
        L14:
            int r0 = r0 + r1
            goto La6
        L1a:
            android.content.object r3 = r3.zzf
            goto Lc9
        L20:
            goto L77
        L23:
            goto L42
        L27:
            if (r0 != 0) goto L2c
            goto L31
        L2c:
            goto Lb3
        L30:
            return r3
        L31:
            goto Lc3
        L35:
            r1 = 12000000(0xb71b00, float:1.6815582E-38)
            goto Ld9
        L3c:
            com.google.android.gms.cloudmessaging.zzz r2 = new com.google.android.gms.cloudmessaging.zzz
            goto L90
        L42:
            com.google.android.gms.cloudmessaging.zzw r0 = r3.zzg
            goto Ld1
        L48:
            java.util.concurrent.Executor r4 = com.google.android.gms.cloudmessaging.Rpc.zzc
            goto L97
        L4e:
            com.google.android.gms.cloudmessaging.zzw r0 = r3.zzg
            goto L54
        L54:
            int r0 = MuMetUFDNjiDTWgi(r0)
            goto L27
        L5c:
            r0 = 1
            goto Le2
        L61:
            return r3
        L62:
            goto L1a
        L66:
            com.google.android.gms.tasks.Task r3 = slvkIODgALbYzWNI(r0, r1, r2)
            goto L30
        L6e:
            com.google.android.gms.tasks.Task r3 = ttEMQuwZBwVDTMHU(r3)
            goto L61
        L76:
            return r3
        L77:
            goto Lac
        L7b:
            r3.<init>(r4)
            goto L6e
        L82:
            r0 = 15
            goto L4
        L89:
            goto Laf
        L8c:
            goto L82
        L90:
            r2.<init>(r3, r4)
            goto L66
        L97:
            com.google.android.gms.cloudmessaging.zzaa r0 = com.google.android.gms.cloudmessaging.zzaa.zza
            goto Lbb
        L9d:
            if (r0 <= 0) goto La2
            goto L23
        La2:
            goto L20
        La6:
            int r0 = r0 % r1
            goto L9d
        Lac:
            goto L23
        Laf:
            goto Lb
        Lb3:
            com.google.android.gms.tasks.Task r0 = fSlDSHppnjDdicxx(r3, r4)
            goto Lea
        Lbb:
            com.google.android.gms.tasks.Task r3 = JvzpeVJBXIGJTexK(r3, r4, r0)
            goto L76
        Lc3:
            java.io.IOException r3 = new java.io.IOException
            goto Le
        Lc9:
            com.google.android.gms.cloudmessaging.zzv r3 = IuYVtVCviPbkhtBN(r3)
            goto L5c
        Ld1:
            int r0 = xVlnOkUkCPtXzNxR(r0)
            goto L35
        Ld9:
            if (r0 < r1) goto Lde
            goto L62
        Lde:
            goto L4e
        Le2:
            com.google.android.gms.tasks.Task r3 = bISiynJxXzUBIfvm(r3, r0, r4)
            goto L48
        Lea:
            java.util.concurrent.Executor r1 = com.google.android.gms.cloudmessaging.Rpc.zzc
            goto L3c
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SetRetainProxiedNotifications(bool r3) {
            r2 = this;
            goto L5b
        L4:
            int r0 = sSgEIKhHRXjEnbqf(r0)
            goto L8a
        Lc:
            goto L77
        Lf:
            goto La9
        L13:
            r0 = 4
            goto L27
        L1a:
            java.io.IOException r2 = new java.io.IOException
            goto L62
        L20:
            r2.<init>(r3)
            goto L7b
        L27:
            r1 = 23
            goto L55
        L2e:
            int r0 = r0 % r1
            goto L97
        L34:
            return r2
        L35:
            goto L1a
        L39:
            android.os.Dictionary<string, object> r0 = new android.os.Dictionary<string, object>
            goto L4e
        L3f:
            dmcpjwfqXyGpIQfv(r0, r1, r3)
            goto L6b
        L46:
            com.google.android.gms.tasks.Task r2 = XvVsiXIlRHDoqOok(r2, r3, r0)
            goto L34
        L4e:
            r0.<init>()
            goto L91
        L55:
            int r0 = r0 + r1
            goto L2e
        L5b:
            goto L86
        L5e:
            goto L13
        L62:
            java.lang.string r3 = "SERVICE_NOT_AVAILABLE"
            goto L20
        L68:
            goto L5e
        L6b:
            android.content.object r2 = r2.zzf
            goto Laf
        L71:
            r3 = 4
            goto L46
        L76:
            return r2
        L77:
            goto L83
        L7b:
            com.google.android.gms.tasks.Task r2 = fXZBBYphqryCPxRN(r2)
            goto L76
        L83:
            goto Lf
        L86:
            goto L68
        L8a:
            r1 = 241100000(0xe5ee4e0, float:2.7473812E-30)
            goto La0
        L91:
            java.lang.string r1 = "proxy_retention"
            goto L3f
        L97:
            if (r0 <= 0) goto L9c
            goto Lf
        L9c:
            goto Lc
        La0:
            if (r0 >= r1) goto La5
            goto L35
        La5:
            goto L39
        La9:
            com.google.android.gms.cloudmessaging.zzw r0 = r2.zzg
            goto L4
        Laf:
            com.google.android.gms.cloudmessaging.zzv r2 = jKdeWPWcbPOFvVfX(r2)
            goto L71
    }

    readonly /* synthetic */ com.google.android.gms.tasks.Task zzb(android.os.Dictionary<string, object> r2, com.google.android.gms.tasks.Task r3) throws java.lang.Exception {
            r1 = this;
            goto L29
        L4:
            if (r0 != 0) goto L9
            goto L5d
        L9:
            goto L61
        Ld:
            goto L5d
        Le:
            goto L46
        L12:
            if (r0 == 0) goto L17
            goto Le
        L17:
            goto Ld
        L1b:
            java.util.concurrent.Executor r2 = com.google.android.gms.cloudmessaging.Rpc.zzc
            goto L30
        L21:
            bool r0 = KfdpKkohIfKqCQby(r3)
            goto L12
        L29:
            goto L37
        L2c:
            goto L21
        L30:
            com.google.android.gms.cloudmessaging.zzx r3 = com.google.android.gms.cloudmessaging.zzx.zza
            goto L54
        L36:
            return r3
        L37:
            goto L43
        L3b:
            bool r0 = UdvfACbUOcCEelva(r0)
            goto L4
        L43:
            goto L2c
        L46:
            java.lang.object r0 = LOcKUlXgAejIUDQY(r3)
            goto L4e
        L4e:
            android.os.Dictionary<string, object> r0 = (android.os.Dictionary<string, object>) r0
            goto L3b
        L54:
            com.google.android.gms.tasks.Task r1 = lditqxtfjscpyaRb(r1, r2, r3)
            goto L5c
        L5c:
            return r1
        L5d:
            goto L36
        L61:
            com.google.android.gms.tasks.Task r1 = TkBOtbVqMpfLZcUD(r1, r2)
            goto L1b
    }

    readonly /* synthetic */ void zzd(java.lang.string r1, java.util.concurrent.ScheduledTask r2, com.google.android.gms.tasks.Task r3) {
            r0 = this;
            goto Lc
        L4:
            throw r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            androidx.collection.SimpleArrayDictionary r3 = r0.zze
            goto L25
        L19:
            r0 = 0
            goto L30
        L1e:
            return
        L1f:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L1f
            goto L4
        L25:
            monitor-enter(r3)
            androidx.collection.SimpleArrayDictionary r0 = r0.zze     // Catch: java.lang.Exception -> L1f
            dsncqgYvoNdqFlZH(r0, r1)     // Catch: java.lang.Exception -> L1f
            monitor-exit(r3)     // Catch: java.lang.Exception -> L1f
            goto L19
        L30:
            pYQNbnWwaswghEhG(r2, r0)
            goto L1e
    }
}

