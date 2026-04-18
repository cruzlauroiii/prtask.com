namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
@javax.inject.Singleton
public class TransportRuntime : com.google.android.datatransport.runtime.TransportInternal {
    private static com.google.android.datatransport.runtime.TransportRuntimeComponent instance;
    private readonly com.google.android.datatransport.runtime.time.Clock eventClock;
    private readonly com.google.android.datatransport.runtime.scheduling.Scheduler scheduler;
    private readonly com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader uploader;
    private readonly com.google.android.datatransport.runtime.time.Clock uptimeClock;

    static {
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
            goto L4
    }

    @javax.inject.Inject
    TransportRuntime(com.google.android.datatransport.runtime.time.Clock r1, com.google.android.datatransport.runtime.time.Clock r2, com.google.android.datatransport.runtime.scheduling.Scheduler r3, com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader r4, com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer r5) {
            r0 = this;
            goto La
        L4:
            r0.eventClock = r1
            goto L33
        La:
            goto L21
        Ld:
            goto L25
        L11:
            r0.scheduler = r3
            goto L17
        L17:
            r0.uploader = r4
            goto L2c
        L1d:
            goto Ld
        L20:
            return
        L21:
            goto L1d
        L25:
            r0.<init>()
            goto L4
        L2c:
            AofzwXKxyBTMjbIv(r5)
            goto L20
        L33:
            r0.uptimeClock = r2
            goto L11
    }

    public static com.google.android.datatransport.runtime.TransportRuntimeComponent ALUdtpejWAnCrJtE(com.google.android.datatransport.runtime.TransportRuntimeComponent.Builder r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.datatransport.runtime.TransportRuntimeComponent r0 = r1.build()
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

    public static void AofzwXKxyBTMjbIv(com.google.android.datatransport.runtime.scheduling.jobscheduling.WorkInitializer r0) {
            goto Le
        L4:
            r0.ensureobjectsScheduled()
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

    public static com.google.android.datatransport.Event BWuSLRtNHTOMOzgz(com.google.android.datatransport.runtime.SendRequest r1) {
            goto Lc
        L4:
            com.google.android.datatransport.Event r0 = r1.getEvent()
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

    public static java.lang.int BvuNUAqnRKeFSXyo(com.google.android.datatransport.ProductData r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.int r0 = r1.getProductId()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.datatransport.runtime.Transportobject.Builder CPMFgoeEdoQlHTsn(com.google.android.datatransport.runtime.Transportobject.Builder r1, java.lang.string r2) {
            goto L11
        L4:
            com.google.android.datatransport.runtime.Transportobject$Builder r0 = r1.setBackendName(r2)
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

    public static com.google.android.datatransport.Priority FnKQXkShcAspMHSy(com.google.android.datatransport.Event r1) {
            goto L14
        L4:
            com.google.android.datatransport.Priority r0 = r1.getPriority()
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

    public static java.lang.string GUlwZtSffDfjluiN(com.google.android.datatransport.Eventobject r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getPseudonymousId()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.android.datatransport.runtime.EventInternal GyzgBHArBnRQAjlw(com.google.android.datatransport.runtime.TransportRuntime r1, com.google.android.datatransport.runtime.SendRequest r2) {
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
            com.google.android.datatransport.runtime.EventInternal r0 = r1.convert(r2)
            goto Le
    }

    public static com.google.android.datatransport.runtime.Transportobject.Builder HCyXyaUjadsoPxnr(com.google.android.datatransport.runtime.Transportobject.Builder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.datatransport.runtime.Transportobject$Builder r0 = r1.setBackendName(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static byte[] ISZKJXauhzWrTLop(com.google.android.datatransport.Eventobject r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            byte[] r0 = r1.getExperimentIdsEncrypted()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.string KQEhPjaEQOyMxGTb(com.google.android.datatransport.runtime.SendRequest r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getTransportName()
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

    public static com.google.android.datatransport.runtime.EventInternal.Builder KScfCllFVbSdRwrR(com.google.android.datatransport.runtime.EventInternal.Builder r1, byte[] r2) {
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
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setExperimentIdsEncrypted(r2)
            goto L4
    }

    public static com.google.android.datatransport.runtime.TransportRuntime KrDSlooJnKPoxjHF(com.google.android.datatransport.runtime.TransportRuntimeComponent r1) {
            goto L11
        L4:
            com.google.android.datatransport.runtime.TransportRuntime r0 = r1.getTransportRuntime()
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

    public static byte[] MTdSVmpYnxMjCtXm(com.google.android.datatransport.runtime.SendRequest r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            byte[] r0 = r1.getPayload()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder MZpsAaGeJcicuLuF(com.google.android.datatransport.runtime.EventInternal.Builder r1, java.lang.int r2) {
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
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setCode(r2)
            goto L7
    }

    public static java.util.HashSet OoEGgLreIUzlUlAk(com.google.android.datatransport.runtime.EncodedDestination r1) {
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
            java.util.HashSet r0 = r1.getSupportedEncodings()
            goto Le
    }

    public static java.lang.object OpKbfRhyRJRtZIrC(java.util.concurrent.Func r1) {
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
            java.lang.object r0 = r1.call()
            goto Lb
    }

    public static com.google.android.datatransport.runtime.Transportobject.Builder RWzxLFuDcMTdHUuE() {
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
            com.google.android.datatransport.runtime.Transportobject$Builder r0 = com.google.android.datatransport.runtime.Transportobject.builder()
            goto L4
    }

    public static com.google.android.datatransport.Encoding UtZdsBXqVYKFmqdc(java.lang.string r1) {
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
            com.google.android.datatransport.Encoding r0 = com.google.android.datatransport.Encoding.of(r1)
            goto Le
    }

    public static java.lang.int VLLfTBtTYYaYWiUT(com.google.android.datatransport.ProductData r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.int r0 = r1.getProductId()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.android.datatransport.runtime.Transportobject WUnJNFFfyvNMJzHs(com.google.android.datatransport.runtime.Transportobject r1, com.google.android.datatransport.Priority r2) {
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
            com.google.android.datatransport.runtime.Transportobject r0 = r1.withPriority(r2)
            goto L7
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder WlWuMQOnxnNCdmkb(com.google.android.datatransport.runtime.EventInternal.Builder r1, long r2) {
            goto L11
        L4:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setUptimeMillis(r2)
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

    public static com.google.android.datatransport.Event WqNJtjuUpPKkPhtp(com.google.android.datatransport.runtime.SendRequest r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.datatransport.Event r0 = r1.getEvent()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.datatransport.runtime.Transportobject.Builder XLvWOLhwsRTkALZH(com.google.android.datatransport.runtime.Transportobject.Builder r1, byte[] r2) {
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
            com.google.android.datatransport.runtime.Transportobject$Builder r0 = r1.setExtras(r2)
            goto L4
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder XjKZRXMXwMjVacEO(com.google.android.datatransport.runtime.EventInternal.Builder r1, long r2) {
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
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setEventMillis(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string YqqomFzqznQkyNZh(com.google.android.datatransport.Eventobject r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.getPseudonymousId()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.android.datatransport.Eventobject YvkmRHGTWhOdwyrS(com.google.android.datatransport.Event r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.datatransport.Eventobject r0 = r1.getEventobject()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.datatransport.Event YxoSYaqaKwqCBbpx(com.google.android.datatransport.runtime.SendRequest r1) {
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
            com.google.android.datatransport.Event r0 = r1.getEvent()
            goto L4
    }

    public static com.google.android.datatransport.Event AZzVetvHRSBcsbUQ(com.google.android.datatransport.runtime.SendRequest r1) {
            goto L14
        L4:
            com.google.android.datatransport.Event r0 = r1.getEvent()
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

    public static java.util.HashSet BDYzhIOcyaMytAwG(java.lang.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.util.HashSet r0 = java.util.ICollections.singleton(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static byte[] BWplUswZWpsrExyA(com.google.android.datatransport.Eventobject r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            byte[] r0 = r1.getExperimentIdsClear()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.android.datatransport.Encoding CJKuCevrMoCodNWe(com.google.android.datatransport.runtime.SendRequest r1) {
            goto L14
        L4:
            com.google.android.datatransport.Encoding r0 = r1.getEncoding()
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

    public static com.google.android.datatransport.Eventobject CXxGHKLNLDmWWRFk(com.google.android.datatransport.Event r1) {
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
            com.google.android.datatransport.Eventobject r0 = r1.getEventobject()
            goto Lb
    }

    private com.google.android.datatransport.runtime.EventInternal Convert(com.google.android.datatransport.runtime.SendRequest r4) {
            r3 = this;
            goto L173
        L4:
            r0.<init>(r1, r2)
            goto Lf6
        Lb:
            java.lang.string r0 = YqqomFzqznQkyNZh(r4)
            goto L22
        L13:
            if (r0 != 0) goto L18
            goto L195
        L18:
            goto L5a
        L1c:
            com.google.android.datatransport.runtime.EncodedPayload r0 = new com.google.android.datatransport.runtime.EncodedPayload
            goto L10e
        L22:
            if (r0 != 0) goto L27
            goto L56
        L27:
            goto L15d
        L2b:
            r1 = 26
            goto L16d
        L32:
            long r1 = yasqaTgLCISHkIqS(r3)
            goto L125
        L3a:
            com.google.android.datatransport.runtime.EventInternal$Builder r3 = MZpsAaGeJcicuLuF(r3, r0)
            goto L13c
        L42:
            com.google.android.datatransport.Eventobject r0 = cXxGHKLNLDmWWRFk(r0)
            goto L13
        L4a:
            if (r0 != 0) goto L4f
            goto L7b
        L4f:
            goto L87
        L53:
            fNXIFenXhLPieVDW(r3, r0)
        L56:
            goto L7f
        L5a:
            com.google.android.datatransport.Event r4 = YxoSYaqaKwqCBbpx(r4)
            goto Ldf
        L62:
            com.google.android.datatransport.Event r0 = zMgIZjPoanklOQTl(r4)
            goto L42
        L6a:
            com.google.android.datatransport.runtime.time.Clock r1 = r3.eventClock
            goto L12d
        L70:
            java.lang.int r0 = tbMCiuYNFKLRYkYv(r0)
            goto L3a
        L78:
            rCkLDHNdCIwYAmss(r3, r0)
        L7b:
            goto L62
        L7f:
            byte[] r0 = tFSbciCVqdBnRJEF(r4)
            goto L154
        L87:
            com.google.android.datatransport.Event r0 = WqNJtjuUpPKkPhtp(r4)
            goto L1a7
        L8f:
            com.google.android.datatransport.ProductData r0 = fsVbFznTqSnglreF(r0)
            goto Lbe
        L97:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = XjKZRXMXwMjVacEO(r0, r1)
            goto L9f
        L9f:
            com.google.android.datatransport.runtime.time.Clock r3 = r3.uptimeClock
            goto L32
        La5:
            com.google.android.datatransport.Event r0 = zPMdzEcVtZEwjomF(r4)
            goto L8f
        Lad:
            if (r0 <= 0) goto Lb2
            goto L138
        Lb2:
            goto L135
        Lb6:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = jyLFNTkYXBmOVcSF()
            goto L6a
        Lbe:
            java.lang.int r0 = BvuNUAqnRKeFSXyo(r0)
            goto L78
        Lc6:
            com.google.android.datatransport.runtime.EventInternal r3 = fdvTquBWHRdSuzTT(r3)
            goto Ld1
        Lce:
            goto L176
        Ld1:
            return r3
        Ld2:
            goto Le7
        Ld6:
            if (r0 != 0) goto Ldb
            goto L195
        Ldb:
            goto L19f
        Ldf:
            com.google.android.datatransport.Eventobject r4 = YvkmRHGTWhOdwyrS(r4)
            goto Lb
        Le7:
            goto L138
        Lea:
            goto Lce
        Lee:
            byte[] r2 = MTdSVmpYnxMjCtXm(r4)
            goto L4
        Lf6:
            com.google.android.datatransport.runtime.EventInternal$Builder r3 = yXZonJqyNVMBFvAm(r3, r0)
            goto L11d
        Lfe:
            byte[] r0 = bWplUswZWpsrExyA(r4)
            goto L116
        L106:
            com.google.android.datatransport.ProductData r0 = jHjIQhFPPYNrEJCO(r0)
            goto L4a
        L10e:
            com.google.android.datatransport.Encoding r1 = cJKuCevrMoCodNWe(r4)
            goto Lee
        L116:
            udQsWNSEPlxtDhnW(r3, r0)
        L119:
            goto L18a
        L11d:
            com.google.android.datatransport.Event r0 = aZzVetvHRSBcsbUQ(r4)
            goto L70
        L125:
            com.google.android.datatransport.runtime.EventInternal$Builder r3 = WlWuMQOnxnNCdmkb(r0, r1)
            goto L165
        L12d:
            long r1 = lBoATLqzUALBnjUV(r1)
            goto L97
        L135:
            goto Ld2
        L138:
            goto Lb6
        L13c:
            com.google.android.datatransport.Event r0 = BWuSLRtNHTOMOzgz(r4)
            goto L106
        L144:
            java.lang.int r0 = VLLfTBtTYYaYWiUT(r0)
            goto L181
        L14c:
            com.google.android.datatransport.runtime.EventInternal$Builder r3 = zLANYnPhRQYxqNej(r3, r0)
            goto L1c
        L154:
            if (r0 != 0) goto L159
            goto L119
        L159:
            goto Lfe
        L15d:
            java.lang.string r0 = GUlwZtSffDfjluiN(r4)
            goto L53
        L165:
            java.lang.string r0 = KQEhPjaEQOyMxGTb(r4)
            goto L14c
        L16d:
            int r0 = r0 + r1
            goto L199
        L173:
            goto Lea
        L176:
            goto L17a
        L17a:
            r0 = 4
            goto L2b
        L181:
            if (r0 != 0) goto L186
            goto L7b
        L186:
            goto La5
        L18a:
            byte[] r0 = ISZKJXauhzWrTLop(r4)
            goto Ld6
        L192:
            KScfCllFVbSdRwrR(r3, r4)
        L195:
            goto Lc6
        L199:
            int r0 = r0 % r1
            goto Lad
        L19f:
            byte[] r4 = ocYarqpQSRJGYynk(r4)
            goto L192
        L1a7:
            com.google.android.datatransport.ProductData r0 = ggoxTTPOWICRewcm(r0)
            goto L144
    }

    public static java.lang.string EnKRuUUiMukANTSb(com.google.android.datatransport.runtime.Destination r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.getName()
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

    public static com.google.android.datatransport.runtime.EventInternal.Builder FNXIFenXhLPieVDW(com.google.android.datatransport.runtime.EventInternal.Builder r1, java.lang.string r2) {
            goto Lf
        L4:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setPseudonymousId(r2)
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

    public static com.google.android.datatransport.runtime.EventInternal FdvTquBWHRdSuzTT(com.google.android.datatransport.runtime.EventInternal.Builder r1) {
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
            com.google.android.datatransport.runtime.EventInternal r0 = r1.build()
            goto L4
    }

    public static com.google.android.datatransport.ProductData FsVbFznTqSnglreF(com.google.android.datatransport.Event r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.datatransport.ProductData r0 = r1.getProductData()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.util.HashSet GdnlhBsTdRIpjOUE(com.google.android.datatransport.runtime.Destination r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.HashSet r0 = getSupportedEncodings(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.datatransport.runtime.TransportRuntime GetInstance() {
            goto L63
        L4:
            com.google.android.datatransport.runtime.TransportRuntime r0 = KrDSlooJnKPoxjHF(r0)
            goto L26
        Lc:
            goto L35
        Lf:
            goto L57
        L13:
            java.lang.string r1 = "Not initialized!"
            goto L19
        L19:
            r0.<init>(r1)
            goto L52
        L20:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L13
        L26:
            return r0
        L27:
            goto L20
        L2b:
            r1 = 13
            goto L40
        L32:
            goto L53
        L35:
            goto L4c
        L39:
            r0 = 30
            goto L2b
        L40:
            int r0 = r0 + r1
            goto L46
        L46:
            int r0 = r0 % r1
            goto L5a
        L4c:
            com.google.android.datatransport.runtime.TransportRuntimeComponent r0 = com.google.android.datatransport.runtime.TransportRuntime.instance
            goto L6a
        L52:
            throw r0
        L53:
            goto Lc
        L57:
            goto L66
        L5a:
            if (r0 <= 0) goto L5f
            goto L35
        L5f:
            goto L32
        L63:
            goto Lf
        L66:
            goto L39
        L6a:
            if (r0 != 0) goto L6f
            goto L27
        L6f:
            goto L4
    }

    private static java.util.HashSet<com.google.android.datatransport.Encoding> GetSupportedEncodings(com.google.android.datatransport.runtime.Destination r1) {
            goto L18
        L4:
            java.lang.string r1 = "proto"
            goto L3b
        La:
            bool r0 = r1 is com.google.android.datatransport.runtime.EncodedDestination
            goto L27
        L10:
            java.util.HashSet r1 = hEOSLJBRfbhuiLde(r1)
            goto L36
        L18:
            goto L20
        L1b:
            goto La
        L1f:
            return r1
        L20:
            goto L24
        L24:
            goto L1b
        L27:
            if (r0 != 0) goto L2c
            goto L37
        L2c:
            goto L30
        L30:
            com.google.android.datatransport.runtime.EncodedDestination r1 = (com.google.android.datatransport.runtime.EncodedDestination) r1
            goto L4b
        L36:
            return r1
        L37:
            goto L4
        L3b:
            com.google.android.datatransport.Encoding r1 = UtZdsBXqVYKFmqdc(r1)
            goto L43
        L43:
            java.util.HashSet r1 = bDYzhIOcyaMytAwG(r1)
            goto L1f
        L4b:
            java.util.HashSet r1 = OoEGgLreIUzlUlAk(r1)
            goto L10
    }

    public static com.google.android.datatransport.ProductData GgoxTTPOWICRewcm(com.google.android.datatransport.Event r1) {
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
            com.google.android.datatransport.ProductData r0 = r1.getProductData()
            goto Lb
        L18:
            goto L7
    }

    public static java.util.HashSet HEOSLJBRfbhuiLde(java.util.HashSet r1) {
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
            java.util.HashSet r0 = java.util.ICollections.unmodifiableHashSet(r1)
            goto L4
    }

    public static void Initialize(android.content.object r2) {
            goto Lb
        L4:
            r0 = 29
            goto L31
        Lb:
            goto L53
        Le:
            goto L4
        L12:
            int r0 = r0 % r1
            goto L47
        L18:
            java.lang.Class<com.google.android.datatransport.runtime.TransportRuntime> r0 = com.google.android.datatransport.runtime.TransportRuntime.class
            goto L5e
        L1e:
            throw r2
        L1f:
            goto L26
        L23:
            goto Le
        L26:
            return
        L27:
            goto L50
        L2b:
            int r0 = r0 + r1
            goto L12
        L31:
            r1 = 9
            goto L2b
        L38:
            com.google.android.datatransport.runtime.TransportRuntimeComponent r0 = com.google.android.datatransport.runtime.TransportRuntime.instance
            goto L3e
        L3e:
            if (r0 == 0) goto L43
            goto L1f
        L43:
            goto L18
        L47:
            if (r0 <= 0) goto L4c
            goto L5a
        L4c:
            goto L57
        L50:
            goto L5a
        L53:
            goto L23
        L57:
            goto L27
        L5a:
            goto L38
        L5e:
            monitor-enter(r0)
            com.google.android.datatransport.runtime.TransportRuntimeComponent r1 = com.google.android.datatransport.runtime.TransportRuntime.instance     // Catch: java.lang.Exception -> L73
            if (r1 != 0) goto L71
            com.google.android.datatransport.runtime.TransportRuntimeComponent$Builder r1 = vymKVRYVhnStUeDk()     // Catch: java.lang.Exception -> L73
            com.google.android.datatransport.runtime.TransportRuntimeComponent$Builder r2 = lSftcGIQKTgXppTX(r1, r2)     // Catch: java.lang.Exception -> L73
            com.google.android.datatransport.runtime.TransportRuntimeComponent r2 = ALUdtpejWAnCrJtE(r2)     // Catch: java.lang.Exception -> L73
            com.google.android.datatransport.runtime.TransportRuntime.instance = r2     // Catch: java.lang.Exception -> L73
        L71:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L73
            return
        L73:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L73
            goto L1e
    }

    public static com.google.android.datatransport.ProductData JHjIQhFPPYNrEJCO(com.google.android.datatransport.Event r1) {
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
            com.google.android.datatransport.ProductData r0 = r1.getProductData()
            goto L4
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder JyLFNTkYXBmOVcSF() {
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
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = com.google.android.datatransport.runtime.EventInternal.builder()
            goto Lb
        L18:
            goto L7
    }

    public static com.google.android.datatransport.Event KLmPBcnRsVOedaTd(com.google.android.datatransport.runtime.SendRequest r1) {
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
            com.google.android.datatransport.Event r0 = r1.getEvent()
            goto Le
    }

    public static long LBoATLqzUALBnjUV(com.google.android.datatransport.runtime.time.Clock r2) {
            goto L3c
        L4:
            r0 = 6
            goto Lb
        Lb:
            r1 = 2
            goto L29
        L12:
            return r0
        L13:
            goto L2f
        L17:
            goto L13
        L1a:
            goto L21
        L1e:
            goto L3f
        L21:
            long r0 = r2.getTime()
            goto L12
        L29:
            int r0 = r0 + r1
            goto L36
        L2f:
            goto L1a
        L32:
            goto L1e
        L36:
            int r0 = r0 % r1
            goto L43
        L3c:
            goto L32
        L3f:
            goto L4
        L43:
            if (r0 <= 0) goto L48
            goto L1a
        L48:
            goto L17
    }

    public static com.google.android.datatransport.runtime.TransportRuntimeComponent.Builder LSftcGIQKTgXppTX(com.google.android.datatransport.runtime.TransportRuntimeComponent.Builder r1, android.content.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.datatransport.runtime.TransportRuntimeComponent$Builder r0 = r1.setApplicationobject(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static byte[] OcYarqpQSRJGYynk(com.google.android.datatransport.Eventobject r1) {
            goto L14
        L4:
            byte[] r0 = r1.getExperimentIdsEncrypted()
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

    public static java.util.HashSet QDkCnadrpEamVahY(com.google.android.datatransport.runtime.Destination r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.util.HashSet r0 = getSupportedEncodings(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.datatransport.runtime.Transportobject QaNcWOHIPPmnXXuA(com.google.android.datatransport.runtime.Transportobject.Builder r1) {
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
            com.google.android.datatransport.runtime.Transportobject r0 = r1.build()
            goto L4
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder RCkLDHNdCIwYAmss(com.google.android.datatransport.runtime.EventInternal.Builder r1, java.lang.int r2) {
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
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setProductId(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void StjrSMlqmWfZPFlD(com.google.android.datatransport.runtime.scheduling.Scheduler r0, com.google.android.datatransport.runtime.Transportobject r1, com.google.android.datatransport.runtime.EventInternal r2, com.google.android.datatransport.TransportScheduleCallback r3) {
            goto L13
        L4:
            r0.schedule(r1, r2, r3)
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

    public static byte[] StlZjPlGcfjqPKoo(com.google.android.datatransport.runtime.Destination r1) {
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
            byte[] r0 = r1.getExtras()
            goto Le
    }

    public static byte[] TFSbciCVqdBnRJEF(com.google.android.datatransport.Eventobject r1) {
            goto Lc
        L4:
            byte[] r0 = r1.getExperimentIdsClear()
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

    public static java.lang.int TbMCiuYNFKLRYkYv(com.google.android.datatransport.Event r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.int r0 = r1.getCode()
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

    public static com.google.android.datatransport.runtime.EventInternal.Builder UdQsWNSEPlxtDhnW(com.google.android.datatransport.runtime.EventInternal.Builder r1, byte[] r2) {
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
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setExperimentIdsClear(r2)
            goto L4
        L18:
            goto Lc
    }

    public static com.google.android.datatransport.runtime.TransportRuntimeComponent.Builder VymKVRYVhnStUeDk() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.datatransport.runtime.TransportRuntimeComponent$Builder r0 = com.google.android.datatransport.runtime.DaggerTransportRuntimeComponent.builder()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.android.datatransport.runtime.Transportobject WGyvFgMxkOFQkHLc(com.google.android.datatransport.runtime.Transportobject.Builder r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.datatransport.runtime.Transportobject r0 = r1.build()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    static void WithInstance(com.google.android.datatransport.runtime.TransportRuntimeComponent r2, java.util.concurrent.Func<java.lang.void> r3) throws java.lang.Exception {
            goto L63
        L4:
            throw r2
        L5:
            r2 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L5
            goto L11
        Lb:
            java.lang.Class<com.google.android.datatransport.runtime.TransportRuntime> r2 = com.google.android.datatransport.runtime.TransportRuntime.class
            goto L7f
        L11:
            throw r2
        L12:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            goto L47
        L18:
            monitor-enter(r0)
            com.google.android.datatransport.runtime.TransportRuntimeComponent r1 = com.google.android.datatransport.runtime.TransportRuntime.instance     // Catch: java.lang.Exception -> L12
            com.google.android.datatransport.runtime.TransportRuntime.instance = r2     // Catch: java.lang.Exception -> L12
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            OpKbfRhyRJRtZIrC(r3)     // Catch: java.lang.Exception -> L72
            goto Lb
        L25:
            if (r0 <= 0) goto L2a
            goto L5c
        L2a:
            goto L59
        L2e:
            java.lang.Class<com.google.android.datatransport.runtime.TransportRuntime> r3 = com.google.android.datatransport.runtime.TransportRuntime.class
            goto L77
        L34:
            int r0 = r0 + r1
            goto L3a
        L3a:
            int r0 = r0 % r1
            goto L25
        L40:
            r1 = 12
            goto L34
        L47:
            throw r2
        L48:
            goto L6a
        L4c:
            r0 = 1
            goto L40
        L53:
            java.lang.Class<com.google.android.datatransport.runtime.TransportRuntime> r0 = com.google.android.datatransport.runtime.TransportRuntime.class
            goto L18
        L59:
            goto L48
        L5c:
            goto L53
        L60:
            goto L66
        L63:
            goto L6d
        L66:
            goto L4c
        L6a:
            goto L5c
        L6d:
            goto L60
        L71:
            throw r3
        L72:
            r2 = move-exception
            goto L2e
        L77:
            monitor-enter(r3)
            com.google.android.datatransport.runtime.TransportRuntime.instance = r1     // Catch: java.lang.Exception -> L5
            monitor-exit(r3)     // Catch: java.lang.Exception -> L5
            goto L4
        L7f:
            monitor-enter(r2)
            com.google.android.datatransport.runtime.TransportRuntime.instance = r1     // Catch: java.lang.Exception -> L84
            monitor-exit(r2)     // Catch: java.lang.Exception -> L84
            return
        L84:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L84
            goto L71
    }

    public static com.google.android.datatransport.runtime.Transportobject XGjKgaLNSHmMNPyq(com.google.android.datatransport.runtime.SendRequest r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.datatransport.runtime.Transportobject r0 = r1.getTransportobject()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder YXZonJqyNVMBFvAm(com.google.android.datatransport.runtime.EventInternal.Builder r1, com.google.android.datatransport.runtime.EncodedPayload r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setEncodedPayload(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static long YasqaTgLCISHkIqS(com.google.android.datatransport.runtime.time.Clock r2) {
            goto L15
        L4:
            goto L18
        L7:
            int r0 = r0 % r1
            goto L38
        Ld:
            long r0 = r2.getTime()
            goto L41
        L15:
            goto L26
        L18:
            goto L31
        L1c:
            r1 = 9
            goto L46
        L23:
            goto L2d
        L26:
            goto L4
        L2a:
            goto L42
        L2d:
            goto Ld
        L31:
            r0 = 17
            goto L1c
        L38:
            if (r0 <= 0) goto L3d
            goto L2d
        L3d:
            goto L2a
        L41:
            return r0
        L42:
            goto L23
        L46:
            int r0 = r0 + r1
            goto L7
    }

    public static com.google.android.datatransport.runtime.EventInternal.Builder ZLANYnPhRQYxqNej(com.google.android.datatransport.runtime.EventInternal.Builder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.android.datatransport.runtime.EventInternal$Builder r0 = r1.setTransportName(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.datatransport.Event ZMgIZjPoanklOQTl(com.google.android.datatransport.runtime.SendRequest r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.datatransport.Event r0 = r1.getEvent()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.android.datatransport.Event ZPMdzEcVtZEwjomF(com.google.android.datatransport.runtime.SendRequest r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.datatransport.Event r0 = r1.getEvent()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.android.datatransport.runtime.Transportobject.Builder ZbxKubwUCpRmfTeu() {
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
            com.google.android.datatransport.runtime.Transportobject$Builder r0 = com.google.android.datatransport.runtime.Transportobject.builder()
            goto Le
    }

    public com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader GetUploader() {
            r0 = this;
            goto La
        L4:
            com.google.android.datatransport.runtime.scheduling.jobscheduling.Uploader r0 = r0.uploader
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

    public com.google.android.datatransport.TransportFactory NewFactory(com.google.android.datatransport.runtime.Destination r5) {
            r4 = this;
            goto L13
        L4:
            goto L85
        L7:
            goto L37
        Lb:
            com.google.android.datatransport.runtime.Transportobject$Builder r2 = RWzxLFuDcMTdHUuE()
            goto L3a
        L13:
            goto L7
        L16:
            goto L6c
        L1a:
            java.util.HashSet r1 = gdnlhBsTdRIpjOUE(r5)
            goto Lb
        L22:
            byte[] r5 = stlZjPlGcfjqPKoo(r5)
            goto L7a
        L2a:
            return r0
        L2b:
            goto L4
        L2f:
            com.google.android.datatransport.runtime.Transportobject r5 = wGyvFgMxkOFQkHLc(r5)
            goto L65
        L37:
            goto L16
        L3a:
            java.lang.string r3 = enKRuUUiMukANTSb(r5)
            goto L51
        L42:
            if (r0 <= 0) goto L47
            goto L85
        L47:
            goto L82
        L4b:
            int r0 = r0 % r1
            goto L42
        L51:
            com.google.android.datatransport.runtime.Transportobject$Builder r2 = HCyXyaUjadsoPxnr(r2, r3)
            goto L22
        L59:
            com.google.android.datatransport.runtime.TransportFactoryImpl r0 = new com.google.android.datatransport.runtime.TransportFactoryImpl
            goto L1a
        L5f:
            int r0 = r0 + r1
            goto L4b
        L65:
            r0.<init>(r1, r5, r4)
            goto L2a
        L6c:
            r0 = 4
            goto L73
        L73:
            r1 = 28
            goto L5f
        L7a:
            com.google.android.datatransport.runtime.Transportobject$Builder r5 = XLvWOLhwsRTkALZH(r2, r5)
            goto L2f
        L82:
            goto L2b
        L85:
            goto L59
    }

    @java.lang.Deprecated
    public com.google.android.datatransport.TransportFactory NewFactory(java.lang.string r4) {
            r3 = this;
            goto L4
        L4:
            goto L56
        L7:
            goto L43
        Lb:
            com.google.android.datatransport.runtime.Transportobject$Builder r2 = zbxKubwUCpRmfTeu()
            goto L69
        L13:
            return r0
        L14:
            goto L53
        L18:
            int r0 = r0 + r1
            goto L27
        L1e:
            if (r0 <= 0) goto L23
            goto L3f
        L23:
            goto L3c
        L27:
            int r0 = r0 % r1
            goto L1e
        L2d:
            r1 = 27
            goto L18
        L34:
            java.util.HashSet r1 = qDkCnadrpEamVahY(r1)
            goto Lb
        L3c:
            goto L14
        L3f:
            goto L4a
        L43:
            r0 = 27
            goto L2d
        L4a:
            com.google.android.datatransport.runtime.TransportFactoryImpl r0 = new com.google.android.datatransport.runtime.TransportFactoryImpl
            goto L71
        L50:
            goto L7
        L53:
            goto L3f
        L56:
            goto L50
        L5a:
            com.google.android.datatransport.runtime.Transportobject r4 = qaNcWOHIPPmnXXuA(r4)
            goto L62
        L62:
            r0.<init>(r1, r4, r3)
            goto L13
        L69:
            com.google.android.datatransport.runtime.Transportobject$Builder r4 = CPMFgoeEdoQlHTsn(r2, r4)
            goto L5a
        L71:
            r1 = 0
            goto L34
    }

    @Override // com.google.android.datatransport.runtime.TransportInternal
    public void Send(com.google.android.datatransport.runtime.SendRequest r4, com.google.android.datatransport.TransportScheduleCallback r5) {
            r3 = this;
            goto L61
        L4:
            com.google.android.datatransport.runtime.scheduling.Scheduler r0 = r3.scheduler
            goto L42
        La:
            int r0 = r0 + r1
            goto L3c
        L10:
            r1 = 31
            goto La
        L17:
            goto L4e
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            goto L4a
        L25:
            r0 = 1
            goto L10
        L2c:
            com.google.android.datatransport.runtime.Transportobject r1 = WUnJNFFfyvNMJzHs(r1, r2)
            goto L71
        L34:
            com.google.android.datatransport.Event r2 = kLmPBcnRsVOedaTd(r4)
            goto L59
        L3c:
            int r0 = r0 % r1
            goto L68
        L42:
            com.google.android.datatransport.runtime.Transportobject r1 = xGjKgaLNSHmMNPyq(r4)
            goto L34
        L4a:
            goto L64
        L4d:
            return
        L4e:
            goto L1e
        L52:
            stjrSMlqmWfZPFlD(r0, r1, r3, r5)
            goto L4d
        L59:
            com.google.android.datatransport.Priority r2 = FnKQXkShcAspMHSy(r2)
            goto L2c
        L61:
            goto L21
        L64:
            goto L25
        L68:
            if (r0 <= 0) goto L6d
            goto L1a
        L6d:
            goto L17
        L71:
            com.google.android.datatransport.runtime.EventInternal r3 = GyzgBHArBnRQAjlw(r3, r4)
            goto L52
    }
}

