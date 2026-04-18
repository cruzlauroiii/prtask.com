namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public class Uploader {
    private static readonly java.lang.string CLIENT_HEALTH_METRICS_LOG_SOURCE = "GDT_CLIENT_METRICS";
    private static readonly java.lang.string LOG_TAG = "Uploader";
    private readonly com.google.android.datatransport.runtime.backends.BackendRegistry backendRegistry;
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore clientHealthMetricsStore;
    private readonly com.google.android.datatransport.runtime.time.Clock clock;
    private readonly android.content.object context;
    private readonly com.google.android.datatransport.runtime.scheduling.persistence.EventStore eventStore;
    private readonly java.util.concurrent.Executor executor;
    private readonly com.google.android.datatransport.runtime.synchronization.SynchronizationGuard guard;
    private readonly com.google.android.datatransport.runtime.time.Clock uptimeClock;
    private readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler workScheduler;

    @javax.inject.Inject
    public Uploader(android.content.object r1, com.google.android.datatransport.runtime.backends.BackendRegistry r2, com.google.android.datatransport.runtime.scheduling.persistence.EventStore r3, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler r4, java.util.concurrent.Executor r5, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r6, com.google.android.datatransport.runtime.time.Clock r7, com.google.android.datatransport.runtime.time.Clock r8, com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore r9) {
            r0 = this;
            goto L24
        L4:
            return
        L5:
            goto L1b
        L9:
            r0.backendRegistry = r2
            goto L15
        Lf:
            r0.clientHealthMetricsStore = r9
            goto L4
        L15:
            r0.eventStore = r3
            goto L3d
        L1b:
            goto L27
        L1e:
            r0.context = r1
            goto L9
        L24:
            goto L5
        L27:
            goto L43
        L2b:
            r0.uptimeClock = r8
            goto Lf
        L31:
            r0.executor = r5
            goto L37
        L37:
            r0.guard = r6
            goto L4a
        L3d:
            r0.workScheduler = r4
            goto L31
        L43:
            r0.<init>()
            goto L1e
        L4a:
            r0.clock = r7
            goto L2b
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder BgbMdgwRLLoQtzgC(com.google.android.datatransport.runtime.EventInternal.Builder r1, com.google.android.datatransport.runtime.EncodedPayload r2) {
            goto L11
        L4:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setEncodedPayload(r2)
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

    public static com.google.android.datatransport.Encoding BovtKhFiqHGcDyyh(java.lang.string r1) {
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
            com.google.android.datatransport.Encoding r0 = com.google.android.datatransport.Encoding.of(r1)
            goto Le
    }

    public static java.lang.object CHvLoZIzUhLWUyBN(java.lang.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = java.util.objects.requireNonNull(r1)
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

    public static bool DkAfzSBXOAmYKVza(java.util.List r1, java.lang.object r2) {
            goto Lc
        L4:
            bool r0 = r1.Add(r2)
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

    public static java.util.HashSet DzumTLJkEBoaVqgZ(java.util.Dictionary r1) {
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
            java.util.HashSet r0 = r1.entryHashSet()
            goto L4
    }

    public static com.google.android.datatransport.runtime.EventInternal FSqPqZTgcMROPJxU(com.google.android.datatransport.runtime.EventInternal.Builder r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.datatransport.runtime.EventInternal r0 = r1.build()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void FxghMkTaoyMdEHJm(java.util.concurrent.Executor r0, java.lang.Action r1) {
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
            r0.execute(r1)
            goto L7
    }

    public static bool FyqaPHvFLvXVkqhk(android.net.NetworkInfo r1) {
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
            bool r0 = r1.isConnected()
            goto Le
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder GTKNijPbsaYMDgUC(com.google.android.datatransport.runtime.EventInternal.Builder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setTransportName(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object GzDfRYSShvbMWajB(java.util.IEnumerator r1) {
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

    public static com.google.android.datatransport.runtime.EventInternal IKSfzPTcSPEDeoua(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.datatransport.runtime.EventInternal r0 = r1.getEvent()
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

    public static bool ITJASeyfoCuOvFKv(java.util.List r1, java.lang.object r2) {
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

    public static long IoJZECUAAJDmjugf(com.google.android.datatransport.runtime.time.Clock r2) {
            goto L29
        L4:
            return r0
        L5:
            goto L1b
        L9:
            if (r0 <= 0) goto Le
            goto L25
        Le:
            goto L22
        L12:
            goto L2c
        L15:
            int r0 = r0 % r1
            goto L9
        L1b:
            goto L25
        L1e:
            goto L12
        L22:
            goto L5
        L25:
            goto L44
        L29:
            goto L1e
        L2c:
            goto L3d
        L30:
            int r0 = r0 + r1
            goto L15
        L36:
            r1 = 14
            goto L30
        L3d:
            r0 = 5
            goto L36
        L44:
            long r0 = r2.getTime()
            goto L4
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse.Status JKJUfEQrReVEZfXK(com.google.android.datatransport.runtime.backends.BackendResponse r1) {
            goto L14
        L4:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r0 = r1.getStatus()
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

    public static com.google.android.datatransport.runtime.backends.BackendResponse JmTwzCtpUiXlUPdJ(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader r1, com.google.android.datatransport.runtime.Transportobject r2, int r3) {
            goto Lc
        L4:
            com.google.android.datatransport.runtime.backends.BackendResponse r0 = r1.logAndUpdateState(r2, r3)
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

    public static int KyOIkTMyKZpmOmNr(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto L7
    }

    public static java.lang.object LWNVRgAsiNBfnrCS(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
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
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.util.IEnumerator MNLEzXWCIXCfFBtI(java.lang.IEnumerable r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object OBrAbQYfHNeRgTGz(java.util.IEnumerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.Current
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void ODSSlJYGNDVdiTFN(com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0, java.lang.IEnumerable r1) {
            goto Lb
        L4:
            r0.recordFailure(r1)
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

    public static com.google.android.datatransport.runtime.EventInternal OdZLnYeLZXCySGld(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent r1) {
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
            com.google.android.datatransport.runtime.EventInternal r0 = r1.getEvent()
            goto L7
    }

    public static java.lang.object PVwzDFMCYSbkZcGf(java.util.IEnumerator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.Current
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.datatransport.runtime.backends.TransportBackend RbljpbEZxxNcGMNO(com.google.android.datatransport.runtime.backends.BackendRegistry r1, java.lang.string r2) {
            goto L14
        L4:
            com.google.android.datatransport.runtime.backends.TransportBackend r0 = r1[r2)
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

    public static byte[] RmfRdxMulpfbsuaZ(com.google.android.datatransport.runtime.Transportobject r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            byte[] r0 = r1.getExtras()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void SgEWErJvaOWJKbDU(com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler r0, com.google.android.datatransport.runtime.Transportobject r1, int r2, bool r3) {
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
            r0.schedule(r1, r2, r3)
            goto L7
    }

    public static java.util.IEnumerator TPLurPbuKvyswtip(java.lang.IEnumerable r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto Le
    }

    public static java.lang.object TwecbjLVpPXZfmZm(java.util.Dictionary.Entry r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.getKey()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.android.datatransport.runtime.EventInternal ULKVCXysatteigBw(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader r1, com.google.android.datatransport.runtime.backends.TransportBackend r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.datatransport.runtime.EventInternal r0 = r1.createMetricsEvent(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.int UgPZNRVkEYNupwWr(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Lb
        L18:
            goto L7
    }

    public static void UhtRPggSdirPhnwp(java.lang.Action r0) {
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

    public static java.lang.object VYhRaIMVKhsFbtpL(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool VcYOpErQVxLaRoFI(java.util.IEnumerator r1) {
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

    public static com.google.android.datatransport.runtime.backends.BackendResponse.Status VgjOTjvQDlduMNtP(com.google.android.datatransport.runtime.backends.BackendResponse r1) {
            goto L14
        L4:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r0 = r1.getStatus()
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

    public static void WTwxFLXqpVXTvVhD(java.lang.Action r0) {
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
            r0.run()
            goto Le
    }

    public static java.lang.object WvtKNVslKYAZIQJs(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder XTzeoTYptvJNhyyM(com.google.android.datatransport.runtime.EventInternal.Builder r1, long r2) {
            goto L11
        L4:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setEventMillis(r2)
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

    public static void XhJrRXOrThfGerCG(com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.resetClientMetrics()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static java.lang.object XtDrnzoELcnLZqBl(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static com.google.android.datatransport.runtime.backends.BackendRequest.Builder ZFLVscHwCyyUlAVD(com.google.android.datatransport.runtime.backends.BackendRequest.Builder r1, java.lang.IEnumerable r2) {
            goto Lc
        L4:
            com.google.android.datatransport.runtime.backends.BackendRequest$Builder r0 = r1.setEvents(r2)
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

    public static bool APFbYfdEmKzTagwN(java.util.IEnumerator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.MoveNext()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool AYkFuyQKYwZOCpka(java.util.IEnumerator r1) {
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

    public static java.lang.object AdDjwXCUZZhCvfqw(java.util.Dictionary r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1[r2)
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

    public static void BToILAvdwloNMGly(java.lang.Action r0) {
            goto Lb
        L4:
            r0.run()
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

    public static java.lang.object BhVPdJgeZGUEfPCi(android.content.object r1, java.lang.string r2) {
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
            java.lang.object r0 = r1.getSystemService(r2)
            goto L4
    }

    public static java.lang.object BpiDqySWYgYRQSRN(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.object r0 = r1.runCriticalSection(r2)
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

    public static bool CaXZdlBBWiEMaTzK(com.google.android.datatransport.runtime.Transportobject r1) {
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
            bool r0 = r1.shouldUploadClientHealthMetrics()
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.object DTEHRVpFUemRiDPW(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
            goto L11
        L4:
            java.lang.object r0 = r1.runCriticalSection(r2)
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

    public static java.lang.string DZZSyVxWmQERfswB(com.google.android.datatransport.runtime.Transportobject r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getBackendName()
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

    public static java.lang.object DlQdEBizubBzFIHq(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
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
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto L4
    }

    public static byte[] DqBTqHKnQirugkSN(com.google.android.datatransport.runtime.firebase.transport.ClientMetrics r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            byte[] r0 = r1.tobyteArray()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string DxdaxRoCpckPmGUw(com.google.android.datatransport.runtime.EventInternal r1) {
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
            java.lang.string r0 = r1.getTransportName()
            goto Le
    }

    public static java.lang.object EkFHMGDZydVtQPgn(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void ErZEDHfgJpPSYLsa(com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler r0, com.google.android.datatransport.runtime.Transportobject r1, int r2) {
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
            r0.schedule(r1, r2)
            goto Lb
        L17:
            goto L7
    }

    public static long EusQrShGRMiTwXDz(com.google.android.datatransport.runtime.time.Clock r2) {
            goto L13
        L4:
            goto L42
        L7:
            goto Lb
        Lb:
            goto L16
        Le:
            return r0
        Lf:
            goto L4
        L13:
            goto L7
        L16:
            goto L1a
        L1a:
            r0 = 27
            goto L29
        L21:
            long r0 = r2.getTime()
            goto Le
        L29:
            r1 = 16
            goto L30
        L30:
            int r0 = r0 + r1
            goto L46
        L36:
            if (r0 <= 0) goto L3b
            goto L42
        L3b:
            goto L3f
        L3f:
            goto Lf
        L42:
            goto L21
        L46:
            int r0 = r0 % r1
            goto L36
    }

    public static java.util.IEnumerator FKmFaxRxLJPPlevQ(java.util.HashSet r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
    }

    public static java.lang.int FnWOnxQVSWfFSOyX(int r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.int r0 = java.lang.int.valueOf(r1)
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

    public static void GZilCskzCZeBiQwY(com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0, com.google.android.datatransport.runtime.Transportobject r1, long r2) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.recordNextCallTime(r1, r2)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static com.google.android.datatransport.runtime.backends.BackendRequest GbTbmwRCGgGspiJM(com.google.android.datatransport.runtime.backends.BackendRequest.Builder r1) {
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
            com.google.android.datatransport.runtime.backends.BackendRequest r0 = r1.build()
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.object HbwvmqSKdkDuBDfe(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static long IaRmkIBLmaSAWfgf(com.google.android.datatransport.runtime.time.Clock r2) {
            goto L4
        L4:
            goto L39
        L7:
            goto L26
        Lb:
            return r0
        Lc:
            goto L36
        L10:
            long r0 = r2.getTime()
            goto Lb
        L18:
            r1 = 16
            goto L3d
        L1f:
            goto Lc
        L22:
            goto L10
        L26:
            r0 = 26
            goto L18
        L2d:
            if (r0 <= 0) goto L32
            goto L22
        L32:
            goto L1f
        L36:
            goto L22
        L39:
            goto L49
        L3d:
            int r0 = r0 + r1
            goto L43
        L43:
            int r0 = r0 % r1
            goto L2d
        L49:
            goto L7
    }

    public static bool JkvSgvgYoQUIjhDa(java.util.IEnumerator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.MoveNext()
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

    public static java.lang.bool JzjCceFWETmOmjHu(bool r1) {
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
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto L4
    }

    public static java.lang.object KCodtQNnIBmYojYz(java.util.Dictionary.Entry r1) {
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
            java.lang.object r0 = r1.getValue()
            goto Le
    }

    public static android.net.NetworkInfo KfPAuicdEKwleaGN(android.net.ConnectivityManager r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            android.net.NetworkInfo r0 = r1.getActiveNetworkInfo()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse KjYPxNSMzrlEVgIR(long r1) {
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
            com.google.android.datatransport.runtime.backends.BackendResponse r0 = com.google.android.datatransport.runtime.backends.BackendResponse.ok(r1)
            goto L4
        L18:
            goto Lc
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse LrdoImhTDrffvaxb() {
            goto L14
        L4:
            com.google.android.datatransport.runtime.backends.BackendResponse r0 = com.google.android.datatransport.runtime.backends.BackendResponse.fatalError()
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

    public static long MKAOzNwPdulOgoQs(com.google.android.datatransport.runtime.backends.BackendResponse r2) {
            goto L26
        L4:
            return r0
        L5:
            goto L3f
        L9:
            r0 = 6
            goto L30
        L10:
            int r0 = r0 + r1
            goto L46
        L16:
            goto L5
        L19:
            goto L37
        L1d:
            if (r0 <= 0) goto L22
            goto L19
        L22:
            goto L16
        L26:
            goto L42
        L29:
            goto L9
        L2d:
            goto L29
        L30:
            r1 = 3
            goto L10
        L37:
            long r0 = r2.getNextRequestWaitMillis()
            goto L4
        L3f:
            goto L19
        L42:
            goto L2d
        L46:
            int r0 = r0 % r1
            goto L1d
    }

    public static long MWrufuykctdyzJcM(com.google.android.datatransport.runtime.time.Clock r2) {
            goto L3e
        L4:
            if (r0 <= 0) goto L9
            goto L33
        L9:
            goto L30
        Ld:
            return r0
        Le:
            goto L37
        L12:
            long r0 = r2.getTime()
            goto Ld
        L1a:
            r1 = 6
            goto L24
        L21:
            goto L41
        L24:
            int r0 = r0 + r1
            goto L2a
        L2a:
            int r0 = r0 % r1
            goto L4
        L30:
            goto Le
        L33:
            goto L12
        L37:
            goto L33
        L3a:
            goto L21
        L3e:
            goto L3a
        L41:
            goto L45
        L45:
            r0 = 20
            goto L1a
    }

    public static void MdYnelAKzIakQbCR(java.lang.string r0, java.lang.string r1, java.lang.object r2) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            com.google.android.datatransport.runtime.logging.Consoleging.m57d(r0, r1, r2)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static java.lang.object NAIvRdLCRrCfdRia(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static long NsqvMiQxJMjsqAuE(long r2, long r4) {
            goto L45
        L4:
            long r0 = java.lang.Math.max(r2, r4)
            goto L30
        Lc:
            r0 = 1
            goto L3e
        L13:
            if (r0 <= 0) goto L18
            goto L25
        L18:
            goto L22
        L1c:
            int r0 = r0 + r1
            goto L38
        L22:
            goto L31
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L35
        L30:
            return r0
        L31:
            goto L29
        L35:
            goto L48
        L38:
            int r0 = r0 % r1
            goto L13
        L3e:
            r1 = 9
            goto L1c
        L45:
            goto L2c
        L48:
            goto Lc
    }

    public static void OEfywiHQMuVOqiPc(com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler r0, com.google.android.datatransport.runtime.Transportobject r1, int r2) {
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
            r0.schedule(r1, r2)
            goto L4
    }

    public static java.lang.object OIGfcWANFccKUepZ(com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1, com.google.android.datatransport.runtime.synchronization.SynchronizationGuard.CriticalSection r2) {
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
            java.lang.object r0 = r1.runCriticalSection(r2)
            goto Lb
    }

    public static bool OYbmgXxULBdxCxYG(java.util.Dictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.ContainsKey(r2)
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

    public static bool PXDrbqhvKGreneQo(com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader r1) {
            goto L14
        L4:
            bool r0 = r1.isNetworkAvailable()
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

    public static com.google.android.datatransport.runtime.backends.BackendResponse.Status PigqYWhburdPCzKM(com.google.android.datatransport.runtime.backends.BackendResponse r1) {
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
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r0 = r1.getStatus()
            goto L4
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder RZiSlNvVKVeldvyr(com.google.android.datatransport.runtime.EventInternal.Builder r1, long r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setUptimeMillis(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.android.datatransport.runtime.backends.BackendRequest.Builder RmiaalfLwkdXuefD(com.google.android.datatransport.runtime.backends.BackendRequest.Builder r1, byte[] r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.datatransport.runtime.backends.BackendRequest$Builder r0 = r1.setExtras(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool RquqyiWtSGhyBqcz(com.google.android.datatransport.runtime.scheduling.persistence.EventStore r1, com.google.android.datatransport.runtime.Transportobject r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.hasPendingEventsFor(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.util.IEnumerator RxKGkshVXgqCESsq(java.lang.IEnumerable r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse SXcufvZXypYaBazA(com.google.android.datatransport.runtime.backends.TransportBackend r1, com.google.android.datatransport.runtime.backends.BackendRequest r2) {
            goto L14
        L4:
            com.google.android.datatransport.runtime.backends.BackendResponse r0 = r1.send(r2)
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

    public static com.google.android.datatransport.runtime.EventInternal.Builder ShBajIYlOpRRKEiy() {
            goto L11
        L4:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = com.google.android.datatransport.runtime.EventInternal.builder()
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

    public static java.lang.object StiIngOmRPlwwQwV(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
    }

    public static void SxiGfTNtMqQhDBZZ(com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0, java.lang.IEnumerable r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.recordSuccess(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static bool TEglpAYAdRYbpCCI(java.lang.bool r1) {
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
            bool r0 = r1.boolValue()
            goto Lb
        L18:
            goto L7
    }

    public static com.google.android.datatransport.runtime.backends.BackendRequest.Builder TXwWQTVMCHaRJzJE() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.datatransport.runtime.backends.BackendRequest$Builder r0 = com.google.android.datatransport.runtime.backends.BackendRequest.builder()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.IEnumerable TuAcgWSkKVINNwJV(com.google.android.datatransport.runtime.scheduling.persistence.EventStore r1, com.google.android.datatransport.runtime.Transportobject r2) {
            goto L14
        L4:
            java.lang.IEnumerable r0 = r1.loadBatch(r2)
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

    public static java.lang.object WEZPelxvQfkQOGmn(java.lang.object r1) {
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
            java.lang.object r0 = java.util.objects.requireNonNull(r1)
            goto Lb
        L18:
            goto L7
    }

    public static com.google.android.datatransport.runtime.EventInternal XdOhiZxDbPJWMFYB(com.google.android.datatransport.runtime.backends.TransportBackend r1, com.google.android.datatransport.runtime.EventInternal r2) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.datatransport.runtime.EventInternal r0 = r1.decorate(r2)
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

    public static bool XmeLKVjCyIcEEyWw(com.google.android.datatransport.runtime.Transportobject r1) {
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
            bool r0 = r1.shouldUploadClientHealthMetrics()
            goto Lb
        L18:
            goto L7
    }

    public static void YkFknLfZCEThbASJ(com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0, com.google.android.datatransport.runtime.Transportobject r1, long r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.recordNextCallTime(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static int ZMpgtGQDsVaclfrF(java.lang.int r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.intValue()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void ZPPmVsoLMvZvaPtw(com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore r0, long r1, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped.Reason r3, java.lang.string r4) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.recordConsoleEventDropped(r1, r3, r4)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public com.google.android.datatransport.runtime.EventInternal CreateMetricsEvent(com.google.android.datatransport.runtime.backends.TransportBackend r5) {
            r4 = this;
            goto L11
        L4:
            com.google.android.datatransport.runtime.EventInternal$Builder r1 = shBajIYlOpRRKEiy()
            goto Lc4
        Lc:
            return r4
        Ld:
            goto L6f
        L11:
            goto L72
        L14:
            goto L8a
        L18:
            long r2 = eusQrShGRMiTwXDz(r4)
            goto Lb6
        L20:
            com.google.android.datatransport.runtime.EventInternal r4 = FSqPqZTgcMROPJxU(r4)
            goto Ld0
        L28:
            byte[] r0 = dqBTqHKnQirugkSN(r0)
            goto Laf
        L30:
            wEZPelxvQfkQOGmn(r1)
            goto L91
        L37:
            r1 = 16
            goto L9a
        L3e:
            java.lang.string r2 = "proto"
            goto Le7
        L44:
            com.google.android.datatransport.runtime.EventInternal$Builder r4 = GTKNijPbsaYMDgUC(r4, r1)
            goto L84
        L4c:
            com.google.android.datatransport.runtime.firebase.transport.ClientMetrics r0 = (com.google.android.datatransport.runtime.firebase.transport.ClientMetrics) r0
            goto L4
        L52:
            com.google.android.datatransport.runtime.EventInternal$Builder r1 = XTzeoTYptvJNhyyM(r1, r2)
            goto Lca
        L5a:
            int r0 = r0 % r1
            goto L66
        L60:
            com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore r1 = r4.clientHealthMetricsStore
            goto L30
        L66:
            if (r0 <= 0) goto L6b
            goto Lab
        L6b:
            goto La8
        L6f:
            goto Lab
        L72:
            goto L97
        L76:
            java.lang.string r1 = "GDT_CLIENT_METRICS"
            goto L44
        L7c:
            java.lang.object r0 = bpiDqySWYgYRQSRN(r0, r2)
            goto L4c
        L84:
            com.google.android.datatransport.runtime.EncodedPayload r1 = new com.google.android.datatransport.runtime.EncodedPayload
            goto L3e
        L8a:
            r0 = 19
            goto L37
        L91:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda4 r2 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda4
            goto Le0
        L97:
            goto L14
        L9a:
            int r0 = r0 + r1
            goto L5a
        La0:
            com.google.android.datatransport.runtime.EventInternal$Builder r4 = BgbMdgwRLLoQtzgC(r4, r1)
            goto L20
        La8:
            goto Ld
        Lab:
            goto Lbe
        Laf:
            r1.<init>(r2, r0)
            goto La0
        Lb6:
            com.google.android.datatransport.runtime.EventInternal$Builder r4 = rZiSlNvVKVeldvyr(r1, r2)
            goto L76
        Lbe:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r0 = r4.guard
            goto L60
        Lc4:
            com.google.android.datatransport.runtime.time.Clock r2 = r4.clock
            goto Ld8
        Lca:
            com.google.android.datatransport.runtime.time.Clock r4 = r4.uptimeClock
            goto L18
        Ld0:
            com.google.android.datatransport.runtime.EventInternal r4 = xdOhiZxDbPJWMFYB(r5, r4)
            goto Lc
        Ld8:
            long r2 = iaRmkIBLmaSAWfgf(r2)
            goto L52
        Le0:
            r2.<init>(r1)
            goto L7c
        Le7:
            com.google.android.datatransport.Encoding r2 = BovtKhFiqHGcDyyh(r2)
            goto L28
    }

    bool isNetworkAvailable() {
            r1 = this;
            goto Lc
        L4:
            java.lang.object r1 = bhVPdJgeZGUEfPCi(r1, r0)
            goto L19
        Lc:
            goto L42
        Lf:
            goto L13
        L13:
            android.content.object r1 = r1.context
            goto L46
        L19:
            android.net.ConnectivityManager r1 = (android.net.ConnectivityManager) r1
            goto L31
        L1f:
            if (r1 != 0) goto L24
            goto L3a
        L24:
            goto L51
        L28:
            if (r1 != 0) goto L2d
            goto L3a
        L2d:
            goto L59
        L31:
            android.net.NetworkInfo r1 = kfPAuicdEKwleaGN(r1)
            goto L1f
        L39:
            return r1
        L3a:
            goto L4c
        L3e:
            goto Lf
        L41:
            return r1
        L42:
            goto L3e
        L46:
            java.lang.string r0 = "connectivity"
            goto L4
        L4c:
            r1 = 0
            goto L41
        L51:
            bool r1 = FyqaPHvFLvXVkqhk(r1)
            goto L28
        L59:
            r1 = 1
            goto L39
    }

    /* JADX INFO: renamed from: lambda$logAndUpdateState$2$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.bool m66x65f78bd8(com.google.android.datatransport.runtime.Transportobject r1) {
            r0 = this;
            goto L1a
        L4:
            java.lang.bool r0 = jzjCceFWETmOmjHu(r0)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L17
        L11:
            com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0 = r0.eventStore
            goto L21
        L17:
            goto L1d
        L1a:
            goto Ld
        L1d:
            goto L11
        L21:
            bool r0 = rquqyiWtSGhyBqcz(r0, r1)
            goto L4
    }

    /* JADX INFO: renamed from: lambda$logAndUpdateState$3$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.IEnumerable m67xa80eb937(com.google.android.datatransport.runtime.Transportobject r1) {
            r0 = this;
            goto L12
        L4:
            com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0 = r0.eventStore
            goto L19
        La:
            goto L15
        Ld:
            return r0
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
        L19:
            java.lang.IEnumerable r0 = tuAcgWSkKVINNwJV(r0, r1)
            goto Ld
    }

    /* JADX INFO: renamed from: lambda$logAndUpdateState$4$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.object m68xea25e696(java.lang.IEnumerable r3, com.google.android.datatransport.runtime.Transportobject r4, long r5) {
            r2 = this;
            goto L2f
        L4:
            ODSSlJYGNDVdiTFN(r0, r3)
            goto L5e
        Lb:
            long r0 = mWrufuykctdyzJcM(r2)
            goto L13
        L13:
            long r0 = r0 + r5
            goto L28
        L18:
            goto L4e
        L1b:
            goto L52
        L1f:
            com.google.android.datatransport.runtime.time.Clock r2 = r2.clock
            goto Lb
        L25:
            goto L32
        L28:
            gZilCskzCZeBiQwY(r3, r4, r0)
            goto L71
        L2f:
            goto L40
        L32:
            goto L36
        L36:
            r0 = 10
            goto L64
        L3d:
            goto L1b
        L40:
            goto L25
        L44:
            if (r0 <= 0) goto L49
            goto L1b
        L49:
            goto L18
        L4d:
            return r2
        L4e:
            goto L3d
        L52:
            com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0 = r2.eventStore
            goto L4
        L58:
            int r0 = r0 % r1
            goto L44
        L5e:
            com.google.android.datatransport.runtime.scheduling.persistence.EventStore r3 = r2.eventStore
            goto L1f
        L64:
            r1 = 16
            goto L6b
        L6b:
            int r0 = r0 + r1
            goto L58
        L71:
            r2 = 0
            goto L4d
    }

    /* JADX INFO: renamed from: lambda$logAndUpdateState$5$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.object m69x2c3d13f5(java.lang.IEnumerable r1) {
            r0 = this;
            goto L1e
        L4:
            r0 = 0
            goto L19
        L9:
            sxiGfTNtMqQhDBZZ(r0, r1)
            goto L4
        L10:
            com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0 = r0.eventStore
            goto L9
        L16:
            goto L21
        L19:
            return r0
        L1a:
            goto L16
        L1e:
            goto L1a
        L21:
            goto L10
    }

    /* JADX INFO: renamed from: lambda$logAndUpdateState$6$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.object m70x6e544154() {
            r0 = this;
            goto L4
        L4:
            goto L21
        L7:
            goto L1a
        Lb:
            XhJrRXOrThfGerCG(r0)
            goto L12
        L12:
            r0 = 0
            goto L20
        L17:
            goto L7
        L1a:
            com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore r0 = r0.clientHealthMetricsStore
            goto Lb
        L20:
            return r0
        L21:
            goto L17
    }

    /* JADX INFO: renamed from: lambda$logAndUpdateState$7$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.object m71xb06b6eb3(java.util.Dictionary r6) {
            r5 = this;
            goto L31
        L4:
            java.lang.int r2 = (java.lang.int) r2
            goto L21
        La:
            java.util.Dictionary$Entry r0 = (java.util.Dictionary.Entry) r0
            goto Lb3
        L10:
            java.lang.object r0 = TwecbjLVpPXZfmZm(r0)
            goto L90
        L18:
            if (r0 != 0) goto L1d
            goto L55
        L1d:
            goto L9e
        L21:
            int r2 = zMpgtGQDsVaclfrF(r2)
            goto L3f
        L29:
            java.util.HashSet r6 = DzumTLJkEBoaVqgZ(r6)
            goto L7b
        L31:
            goto La9
        L34:
            goto L44
        L38:
            r1 = 31
            goto L67
        L3f:
            long r2 = (long) r2
            goto Lad
        L44:
            r0 = 29
            goto L38
        L4b:
            int r0 = r0 % r1
            goto L5e
        L51:
            goto L34
        L54:
            goto L7f
        L55:
            goto L59
        L59:
            r5 = 0
            goto L83
        L5e:
            if (r0 <= 0) goto L63
            goto L70
        L63:
            goto L6d
        L67:
            int r0 = r0 + r1
            goto L4b
        L6d:
            goto L84
        L70:
            goto L29
        L74:
            zPPmVsoLMvZvaPtw(r1, r2, r4, r0)
            goto L54
        L7b:
            java.util.IEnumerator r6 = fKmFaxRxLJPPlevQ(r6)
        L7f:
            goto L96
        L83:
            return r5
        L84:
            goto La6
        L88:
            java.lang.object r2 = kCodtQNnIBmYojYz(r0)
            goto L4
        L90:
            java.lang.string r0 = (java.lang.string) r0
            goto L74
        L96:
            bool r0 = VcYOpErQVxLaRoFI(r6)
            goto L18
        L9e:
            java.lang.object r0 = OBrAbQYfHNeRgTGz(r6)
            goto La
        La6:
            goto L70
        La9:
            goto L51
        Lad:
            com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped$Reason r4 = com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped.Reason.INVALID_PAYLOD
            goto L10
        Lb3:
            com.google.android.datatransport.runtime.scheduling.persistence.ClientHealthMetricsStore r1 = r5.clientHealthMetricsStore
            goto L88
    }

    /* JADX INFO: renamed from: lambda$logAndUpdateState$8$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.object m72xf2829c12(com.google.android.datatransport.runtime.Transportobject r4, long r5) {
            r3 = this;
            goto L4a
        L4:
            com.google.android.datatransport.runtime.time.Clock r3 = r3.clock
            goto La
        La:
            long r1 = IoJZECUAAJDmjugf(r3)
            goto L5e
        L12:
            int r0 = r0 + r1
            goto L58
        L18:
            goto L4d
        L1b:
            r3 = 0
            goto L45
        L20:
            r0 = 20
            goto L51
        L27:
            goto L46
        L2a:
            goto L63
        L2e:
            ykFknLfZCEThbASJ(r0, r4, r1)
            goto L1b
        L35:
            goto L2a
        L38:
            goto L18
        L3c:
            if (r0 <= 0) goto L41
            goto L2a
        L41:
            goto L27
        L45:
            return r3
        L46:
            goto L35
        L4a:
            goto L38
        L4d:
            goto L20
        L51:
            r1 = 23
            goto L12
        L58:
            int r0 = r0 % r1
            goto L3c
        L5e:
            long r1 = r1 + r5
            goto L2e
        L63:
            com.google.android.datatransport.runtime.scheduling.persistence.EventStore r0 = r3.eventStore
            goto L4
    }

    /* JADX INFO: renamed from: lambda$upload$0$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ java.lang.object m73x3eac4914(com.google.android.datatransport.runtime.Transportobject r1, int r2) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L22
        Lb:
            return r0
        Lc:
            goto L28
        L10:
            r0 = 0
            goto Lb
        L15:
            int r2 = r2 + 1
            goto L1b
        L1b:
            erZEDHfgJpPSYLsa(r0, r1, r2)
            goto L10
        L22:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler r0 = r0.workScheduler
            goto L15
        L28:
            goto L7
    }

    /* JADX INFO: renamed from: lambda$upload$1$com-google-android-datatransport-runtime-scheduling-jobscheduling-Uploader */
    /* synthetic */ void m74x80c37673(com.google.android.datatransport.runtime.Transportobject r4, int r5, java.lang.Action r6) {
            r3 = this;
            goto L34
        L4:
            r0 = 23
            goto L75
        Lb:
            goto L90
        Ld:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler r3 = r3.workScheduler     // Catch: java.lang.Exception -> L8a
            int r5 = r5 + 1
            oEfywiHQMuVOqiPc(r3, r4, r5)     // Catch: java.lang.Exception -> L8a
            goto L18
        L18:
            bToILAvdwloNMGly(r6)
            goto L8f
        L1f:
            throw r3
        L20:
            goto L41
        L24:
            if (r0 <= 0) goto L29
            goto L4e
        L29:
            goto L4b
        L2d:
            UhtRPggSdirPhnwp(r6)
            goto L89
        L34:
            goto L44
        L37:
            goto L4
        L3b:
            int r0 = r0 % r1
            goto L24
        L41:
            goto L4e
        L44:
            goto L48
        L48:
            goto L37
        L4b:
            goto L20
        L4e:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r0 = r3.guard     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            com.google.android.datatransport.runtime.scheduling.persistence.EventStore r1 = r3.eventStore     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            CHvLoZIzUhLWUyBN(r1)     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda0 r2 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda0     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            r2.<init>(r1)     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            oIGfcWANFccKUepZ(r0, r2)     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            bool r0 = pXDrbqhvKGreneQo(r3)     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            if (r0 != 0) goto L6e
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r0 = r3.guard     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda2 r1 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda2     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            r1.<init>(r3, r4, r5)     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            VYhRaIMVKhsFbtpL(r0, r1)     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
            goto L71
        L6e:
            JmTwzCtpUiXlUPdJ(r3, r4, r5)     // Catch: com.google.android.datatransport.runtime.synchronization.SynchronizationException -> Ld java.lang.Exception -> L8a
        L71:
            goto L2d
        L75:
            r1 = 5
            goto L83
        L7c:
            WTwxFLXqpVXTvVhD(r6)
            goto L1f
        L83:
            int r0 = r0 + r1
            goto L3b
        L89:
            return
        L8a:
            r3 = move-exception
            goto Lb
        L8f:
            return
        L90:
            goto L7c
    }

    public com.google.android.datatransport.runtime.backends.BackendResponse LogAndUpdateState(com.google.android.datatransport.runtime.Transportobject r12, int r13) {
            r11 = this;
            goto L79
        L4:
            int r13 = r13 + r10
            goto L2fd
        L9:
            long r11 = nsqvMiQxJMjsqAuE(r8, r11)
            goto L282
        L11:
            java.lang.object r1 = GzDfRYSShvbMWajB(r12)
            goto L100
        L19:
            if (r3 != 0) goto L1e
            goto L198
        L1e:
            goto L380
        L22:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda10 r1 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda10
            goto L8b
        L28:
            r12 = r7
            goto L168
        L2d:
            bool r1 = tEglpAYAdRYbpCCI(r1)
            goto L5e
        L35:
            r5 = r11
            goto L2a5
        L3a:
            java.lang.string r1 = dxdaxRoCpckPmGUw(r1)
            goto L19c
        L42:
            if (r2 == 0) goto L47
            goto Lb3
        L47:
            goto L262
        L4b:
            goto L2be
        L4d:
            goto L1b4
        L51:
            goto Le6
        L54:
            goto L9a
        L58:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r12 = com.google.android.datatransport.runtime.backends.BackendResponse.Status.INVALID_PAYLOAD
            goto L13f
        L5e:
            if (r1 != 0) goto L63
            goto L16a
        L63:
            goto L80
        L67:
            return r3
        L68:
            goto L51
        L6c:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda9 r2 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda9
            goto L1f2
        L72:
            r11.<init>()
            goto L1f9
        L79:
            goto L54
        L7c:
            goto L138
        L80:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1 = r11.guard
            goto L2d3
        L86:
            r7 = r12
            goto L350
        L8b:
            r1.<init>(r5, r11)
            goto L2bb
        L92:
            java.lang.object r1 = dlQdEBizubBzFIHq(r1, r2)
            goto L190
        L9a:
            goto L7c
        L9d:
            ITJASeyfoCuOvFKv(r1, r3)
            goto L196
        La4:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r11 = r5.guard
            goto L25c
        Laa:
            ekFHMGDZydVtQPgn(r1, r2)
        Lad:
            goto L21a
        Lb1:
            goto L1fd
        Lb3:
            goto Lce
        Lb7:
            DkAfzSBXOAmYKVza(r1, r2)
        Lba:
            goto L2ef
        Lbe:
            long r11 = mKAOzNwPdulOgoQs(r3)
            goto L9
        Lc6:
            java.util.IEnumerator r2 = TPLurPbuKvyswtip(r6)
        Lca:
            goto L24d
        Lce:
            java.lang.object r2 = adDjwXCUZZhCvfqw(r11, r1)
            goto L184
        Ld6:
            java.util.List r1 = new java.util.List
            goto L26a
        Ldc:
            WvtKNVslKYAZIQJs(r11, r12)
            goto L67
        Le3:
            goto L68
        Le6:
            goto L293
        Lea:
            r5 = r11
            goto L86
        Lef:
            com.google.android.datatransport.runtime.backends.BackendResponse r1 = lrdoImhTDrffvaxb()
        Lf3:
            goto L10b
        Lf7:
            if (r11 == r12) goto Lfc
            goto L4d
        Lfc:
            goto Lbe
        L100:
            com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent r1 = (com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent) r1
            goto L20c
        L106:
            r8 = r1
        L107:
            goto L15b
        L10b:
            r3 = r1
            goto L339
        L110:
            com.google.android.datatransport.runtime.EventInternal r2 = ULKVCXysatteigBw(r11, r0)
            goto Lb7
        L118:
            LWNVRgAsiNBfnrCS(r0, r4)
            goto L309
        L11f:
            bool r1 = jkvSgvgYoQUIjhDa(r12)
            goto L365
        L127:
            r11 = r5
            goto L28
        L12c:
            com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent r3 = (com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent) r3
            goto L16e
        L132:
            r1 = 0
            goto L237
        L138:
            r0 = 16
            goto L1d6
        L13f:
            if (r11 == r12) goto L144
            goto L2be
        L144:
            goto L23f
        L148:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda1 r12 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda1
            goto L161
        L14e:
            java.lang.string r1 = dZZSyVxWmQERfswB(r12)
            goto L31c
        L156:
            return r3
        L157:
            goto L28a
        L15b:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1 = r11.guard
            goto L201
        L161:
            r12.<init>(r5, r7, r8)
            goto Ldc
        L168:
            goto L107
        L16a:
            goto Lea
        L16e:
            com.google.android.datatransport.runtime.EventInternal r3 = OdZLnYeLZXCySGld(r3)
            goto L9d
        L176:
            mdYnelAKzIakQbCR(r1, r2, r12)
            goto Lef
        L17d:
            r2.<init>(r11, r12)
            goto L1c9
        L184:
            java.lang.int r2 = (java.lang.int) r2
            goto L2df
        L18a:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r1 = r5.guard
            goto L6c
        L190:
            java.lang.bool r1 = (java.lang.bool) r1
            goto L2d
        L196:
            goto Lca
        L198:
            goto L2b3
        L19c:
            bool r2 = oYbmgXxULBdxCxYG(r11, r1)
            goto L42
        L1a4:
            java.lang.int r2 = UgPZNRVkEYNupwWr(r2)
            goto L332
        L1ac:
            bool r1 = aPFbYfdEmKzTagwN(r1)
            goto L35c
        L1b4:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r11 = pigqYWhburdPCzKM(r3)
            goto L58
        L1bc:
            r4.<init>(r5, r6, r7, r8)
            goto L118
        L1c3:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r0 = r11.guard
            goto L2f7
        L1c9:
            java.lang.object r1 = hbwvmqSKdkDuBDfe(r1, r2)
            goto L271
        L1d1:
            r5 = r11
            goto L317
        L1d6:
            r1 = 24
            goto L214
        L1dd:
            java.util.IEnumerator r1 = MNLEzXWCIXCfFBtI(r6)
            goto L1ac
        L1e5:
            goto Lf3
        L1e7:
            goto L245
        L1eb:
            r12.<init>(r5, r6)
            goto L255
        L1f2:
            r2.<init>(r5)
            goto Laa
        L1f9:
            java.util.IEnumerator r12 = rxKGkshVXgqCESsq(r6)
        L1fd:
            goto L11f
        L201:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda5 r2 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda5
            goto L227
        L207:
            return r3
        L208:
            goto L1d1
        L20c:
            com.google.android.datatransport.runtime.EventInternal r1 = IKSfzPTcSPEDeoua(r1)
            goto L3a
        L214:
            int r0 = r0 + r1
            goto L2d9
        L21a:
            r8 = r11
            goto L4b
        L21f:
            com.google.android.datatransport.runtime.backends.BackendRequest$Builder r1 = ZFLVscHwCyyUlAVD(r2, r1)
            goto L324
        L227:
            r2.<init>(r11, r12)
            goto L92
        L22e:
            if (r1 == r2) goto L233
            goto L208
        L233:
            goto L1c3
        L237:
            com.google.android.datatransport.runtime.backends.BackendResponse r3 = kjYPxNSMzrlEVgIR(r1)
            goto L106
        L23f:
            java.util.HashDictionary r11 = new java.util.HashDictionary
            goto L72
        L245:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r1 = VgjOTjvQDlduMNtP(r3)
            goto L374
        L24d:
            bool r3 = aYkFuyQKYwZOCpka(r2)
            goto L19
        L255:
            nAIvRdLCRrCfdRia(r11, r12)
            goto L30f
        L25c:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda8 r12 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda8
            goto L1eb
        L262:
            java.lang.int r2 = fnWOnxQVSWfFSOyX(r10)
            goto L29e
        L26a:
            r1.<init>()
            goto Lc6
        L271:
            r6 = r1
            goto L37a
        L276:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r12 = com.google.android.datatransport.runtime.backends.BackendResponse.Status.OK
            goto Lf7
        L27c:
            java.lang.string r1 = "Uploader"
            goto L356
        L282:
            bool r1 = xmeLKVjCyIcEEyWw(r7)
            goto L347
        L28a:
            if (r0 == 0) goto L28f
            goto L33b
        L28f:
            goto L27c
        L293:
            com.google.android.datatransport.runtime.backends.BackendRegistry r0 = r11.backendRegistry
            goto L14e
        L299:
            r10 = 1
            goto L22e
        L29e:
            stiIngOmRPlwwQwV(r11, r1, r2)
            goto Lb1
        L2a5:
            r7 = r12
            goto L1bc
        L2aa:
            if (r2 != 0) goto L2af
            goto Lba
        L2af:
            goto L110
        L2b3:
            bool r2 = caXZdlBBWiEMaTzK(r12)
            goto L2aa
        L2bb:
            dTEHRVpFUemRiDPW(r12, r1)
        L2be:
            goto L127
        L2c2:
            if (r0 <= 0) goto L2c7
            goto Le6
        L2c7:
            goto Le3
        L2cb:
            com.google.android.datatransport.runtime.backends.BackendResponse r1 = sXcufvZXypYaBazA(r0, r1)
            goto L1e5
        L2d3:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda6 r2 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda6
            goto L17d
        L2d9:
            int r0 = r0 % r1
            goto L2c2
        L2df:
            int r2 = KyOIkTMyKZpmOmNr(r2)
            goto L304
        L2e7:
            com.google.android.datatransport.runtime.backends.BackendRequest r1 = gbTbmwRCGgGspiJM(r1)
            goto L2cb
        L2ef:
            com.google.android.datatransport.runtime.backends.BackendRequest$Builder r2 = tXwWQTVMCHaRJzJE()
            goto L21f
        L2f7:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda7 r4 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda7
            goto L35
        L2fd:
            SgEWErJvaOWJKbDU(r11, r7, r13, r10)
            goto L207
        L304:
            int r2 = r2 + r10
            goto L1a4
        L309:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkScheduler r11 = r5.workScheduler
            goto L4
        L30f:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r11 = JKJUfEQrReVEZfXK(r3)
            goto L276
        L317:
            r7 = r12
            goto La4
        L31c:
            com.google.android.datatransport.runtime.backends.TransportBackend r0 = RbljpbEZxxNcGMNO(r0, r1)
            goto L132
        L324:
            byte[] r2 = RmfRdxMulpfbsuaZ(r12)
            goto L33f
        L32c:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r12 = r5.guard
            goto L22
        L332:
            XtDrnzoELcnLZqBl(r11, r1, r2)
            goto L36e
        L339:
            goto L1e7
        L33b:
            goto Ld6
        L33f:
            com.google.android.datatransport.runtime.backends.BackendRequest$Builder r1 = rmiaalfLwkdXuefD(r1, r2)
            goto L2e7
        L347:
            if (r1 != 0) goto L34c
            goto Lad
        L34c:
            goto L18a
        L350:
            com.google.android.datatransport.runtime.synchronization.SynchronizationGuard r11 = r5.guard
            goto L148
        L356:
            java.lang.string r2 = "Unknown backend for %s, deleting event batch for it..."
            goto L176
        L35c:
            if (r1 == 0) goto L361
            goto L157
        L361:
            goto L156
        L365:
            if (r1 != 0) goto L36a
            goto L370
        L36a:
            goto L11
        L36e:
            goto L1fd
        L370:
            goto L32c
        L374:
            com.google.android.datatransport.runtime.backends.BackendResponse$Status r2 = com.google.android.datatransport.runtime.backends.BackendResponse.Status.TRANSIENT_ERROR
            goto L299
        L37a:
            java.lang.IEnumerable r6 = (java.lang.IEnumerable) r6
            goto L1dd
        L380:
            java.lang.object r3 = PVwzDFMCYSbkZcGf(r2)
            goto L12c
    }

    public void Upload(com.google.android.datatransport.runtime.Transportobject r3, int r4, java.lang.Action r5) {
            r2 = this;
            goto L35
        L4:
            goto L4a
        L7:
            goto L19
        Lb:
            r1.<init>(r2, r3, r4, r5)
            goto L12
        L12:
            FxghMkTaoyMdEHJm(r0, r1)
            goto L3c
        L19:
            goto L38
        L1c:
            int r0 = r0 + r1
            goto L22
        L22:
            int r0 = r0 % r1
            goto L4e
        L28:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda3 r1 = new com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader$$ExternalSyntheticLambda3
            goto Lb
        L2e:
            r0 = 10
            goto L57
        L35:
            goto L7
        L38:
            goto L2e
        L3c:
            return
        L3d:
            goto L4
        L41:
            java.util.concurrent.Executor r0 = r2.executor
            goto L28
        L47:
            goto L3d
        L4a:
            goto L41
        L4e:
            if (r0 <= 0) goto L53
            goto L4a
        L53:
            goto L47
        L57:
            r1 = 24
            goto L1c
    }
}

