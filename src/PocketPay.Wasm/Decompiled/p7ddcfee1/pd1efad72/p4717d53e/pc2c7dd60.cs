namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000ì\u0001\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0002\b\u0005\u0018\u0000 {2\u00020\u00012\u00020\u0002:\u0001{B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0006\u00105\u001a\u000206J\u0018\u00107\u001a\u00020\u001d2\u0006\u00108\u001a\u0002092\u0006\u0010\u0012\u001a\u00020\u0013H\u0002J>\u0010:\u001a\u0002062\u0006\u0010;\u001a\u00020\t2\u0006\u0010<\u001a\u00020\t2\u0006\u0010=\u001a\u00020\t2\u0006\u0010>\u001a\u00020\t2\u0006\u0010?\u001a\u00020\u001d2\u0006\u0010@\u001a\u00020A2\u0006\u0010B\u001a\u00020CJ%\u0010D\u001a\u0002062\u0006\u0010E\u001a\u00020F2\u0006\u0010G\u001a\u00020\u00062\u0006\u0010H\u001a\u00020IH\u0000¢\u0006\u0002\bJJ(\u0010K\u001a\u0002062\u0006\u0010;\u001a\u00020\t2\u0006\u0010<\u001a\u00020\t2\u0006\u0010@\u001a\u00020A2\u0006\u0010B\u001a\u00020CH\u0002J\u0010\u0010L\u001a\u0002062\u0006\u0010M\u001a\u00020NH\u0002J0\u0010O\u001a\u0002062\u0006\u0010;\u001a\u00020\t2\u0006\u0010<\u001a\u00020\t2\u0006\u0010=\u001a\u00020\t2\u0006\u0010@\u001a\u00020A2\u0006\u0010B\u001a\u00020CH\u0002J*\u0010P\u001a\u0004\u0018\u00010Q2\u0006\u0010<\u001a\u00020\t2\u0006\u0010=\u001a\u00020\t2\u0006\u0010R\u001a\u00020Q2\u0006\u00108\u001a\u000209H\u0002J\b\u0010S\u001a\u00020QH\u0002J(\u0010T\u001a\u0002062\u0006\u0010M\u001a\u00020N2\u0006\u0010>\u001a\u00020\t2\u0006\u0010@\u001a\u00020A2\u0006\u0010B\u001a\u00020CH\u0002J\n\u0010\u0012\u001a\u0004\u0018\u00010\u0013H\u0016J\r\u0010U\u001a\u000206H\u0000¢\u0006\u0002\bVJ%\u0010W\u001a\u00020\u001d2\u0006\u0010X\u001a\u00020Y2\u000e\u0010Z\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010[H\u0000¢\u0006\u0002\b\\J\u000e\u0010]\u001a\u00020\u001d2\u0006\u0010^\u001a\u00020\u001dJ\u001d\u0010_\u001a\u00020`2\u0006\u0010E\u001a\u00020F2\u0006\u0010a\u001a\u00020bH\u0000¢\u0006\u0002\bcJ\u0015\u0010d\u001a\u00020e2\u0006\u0010f\u001a\u00020gH\u0000¢\u0006\u0002\bhJ\r\u0010 \u001a\u000206H\u0000¢\u0006\u0002\biJ\r\u0010!\u001a\u000206H\u0000¢\u0006\u0002\bjJ\u0018\u0010k\u001a\u0002062\u0006\u0010l\u001a\u00020\u00152\u0006\u0010m\u001a\u00020nH\u0016J\u0010\u0010o\u001a\u0002062\u0006\u0010p\u001a\u00020qH\u0016J\b\u0010%\u001a\u00020&H\u0016J\b\u0010\u0005\u001a\u00020\u0006H\u0016J\u0016\u0010r\u001a\u00020\u001d2\f\u0010s\u001a\b\u0012\u0004\u0012\u00020\u00060[H\u0002J\b\u00101\u001a\u00020(H\u0016J\u0010\u0010t\u001a\u0002062\u0006\u0010>\u001a\u00020\tH\u0002J\u0010\u0010u\u001a\u00020\u001d2\u0006\u00108\u001a\u000209H\u0002J\b\u0010v\u001a\u00020wH\u0016J\u001f\u0010x\u001a\u0002062\u0006\u0010@\u001a\u00020\r2\b\u0010y\u001a\u0004\u0018\u00010IH\u0000¢\u0006\u0002\bzR\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u001d\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000b¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0010\u0010\u0012\u001a\u0004\u0018\u00010\u0013X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0014\u001a\u0004\u0018\u00010\u0015X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u0016\u001a\u00020\u0017X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0018\u0010\u0019\"\u0004\b\u001a\u0010\u001bR\u0014\u0010\u001c\u001a\u00020\u001d8@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u001e\u0010\u001fR\u000e\u0010 \u001a\u00020\u001dX\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010!\u001a\u00020\u001dX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\"\u0010\u001f\"\u0004\b#\u0010$R\u0010\u0010%\u001a\u0004\u0018\u00010&X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010'\u001a\u0004\u0018\u00010(X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010)\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010*\u001a\u00020\tX\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b+\u0010,\"\u0004\b-\u0010.R\u0010\u0010/\u001a\u0004\u0018\u000100X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u00101\u001a\u0004\u0018\u00010(X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u00102\u001a\u0004\u0018\u000103X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u00104\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006|"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/pc2c7dd60;", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;", "Lp7ddcfee1/pc2cc7082;", "connectionPool", "Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;", "route", "Lp7ddcfee1/p9405c3af;", "(Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;Lp7ddcfee1/p9405c3af;)V", "allocationLimit", "", "calls", "", "Ljava/lang/ref/Reference;", "Lp7ddcfee1/pd1efad72/p4717d53e/p6d310f89;", "getCalls", "()Ljava/util/List;", "getConnectionPool", "()Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;", "handshake", "Lp7ddcfee1/p7559811a;", "http2Connection", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184;", "idleAtNs", "", "getIdleAtNs$okhttp", "()J", "setIdleAtNs$okhttp", "(J)V", "isMultiplexed", "", "isMultiplexed$okhttp", "()Z", "noCoalescedConnections", "noNewExchanges", "getNoNewExchanges", "setNoNewExchanges", "(Z)V", "protocol", "Lp7ddcfee1/p888a77f5;", "rawSocket", "Ljava/net/Socket;", "refusedStreamCount", "routeFailureCount", "getRouteFailureCount$okhttp", "()I", "setRouteFailureCount$okhttp", "(I)V", "sink", "Lp38cb8f46/p08d84bc6;", "socket", "source", "Lp38cb8f46/pcc81e3f6;", "successCount", "cancel", "", "certificateSupportHost", "url", "Lp7ddcfee1/pdfadebdd;", "connect", "connectTimeout", "readTimeout", "writeTimeout", "pingIntervalMillis", "connectionRetryEnabled", "call", "Lp7ddcfee1/pc3755e61;", "eventListener", "Lp7ddcfee1/p4f9a1811;", "connectFailed", "client", "Lp7ddcfee1/p1cda7fcc;", "failedRoute", "failure", "Ljava/io/IOException;", "connectFailed$okhttp", "connectSocket", "connectTls", "connectionSpecSelector", "Lp7ddcfee1/pd1efad72/p4717d53e/p85246d20;", "connectTunnel", "createTunnel", "Lp7ddcfee1/p15c2d85f;", "tunnelRequest", "createTunnelRequest", "establishProtocol", "incrementSuccessCount", "incrementSuccessCount$okhttp", "isEligible", "address", "Lp7ddcfee1/pdd7bf230;", "routes", "", "isEligible$okhttp", "isHealthy", "doExtensiveChecks", "newCodec", "Lp7ddcfee1/pd1efad72/p80791b3a/p6eed9b4c;", "chain", "Lp7ddcfee1/pd1efad72/p80791b3a/pf1d5187f;", "newCodec$okhttp", "newWebSocketStreams", "Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$p21b3cb64;", "exchange", "Lp7ddcfee1/pd1efad72/p4717d53e/p992374d8;", "newWebSocketStreams$okhttp", "noCoalescedConnections$okhttp", "noNewExchanges$okhttp", "onHashSettings", "connection", "settings", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "onStream", "stream", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p87a6e6e6;", "routeMatchesAny", "candidates", "startHttp2", "supportsUrl", "tostring", "", "trackFailure", "e", "trackFailure$okhttp", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pc2c7dd60 : p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 : p7ddcfee1.pc2cc7082 {
    private static readonly int f03c8bffe = 21;
    private static readonly int f11f6ca2c = 21;
    public static readonly long f14da7fd8 = 10000000000L;
    public static readonly p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.p910eef8c f1a63bb1b = null;
    private static readonly java.lang.string f50445feb = null;
    public static readonly p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.p910eef8c f67902280 = null;
    public static readonly long f69b379a0 = 10000000000L;
    private static readonly java.lang.string f6d367104 = null;
    public static readonly p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.p910eef8c f910eef8c = null;
    public static readonly p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.p910eef8c f92aef518 = null;
    public static readonly long f9573411a = 10000000000L;
    public static readonly long fa2a21732 = 10000000000L;
    private int f01f3b538;
    private bool f0543ce99;
    private int f0d8f2499;
    private int f0ddbee1d;
    private int f0f99335f;
    private java.net.Socket f1388492f;
    private p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 f15f54d8c;
    private java.net.Socket f1639f777;
    private bool f1f51ecec;
    private readonly p7ddcfee1.p9405c3af f25dfe2ed;
    private int f26392cf6;
    private bool f30ea4479;
    private p38cb8f46.pcc81e3f6 f36cd38f4;
    private java.net.Socket f390f8142;
    private p38cb8f46.p08d84bc6 f3b701436;
    private bool f3bc2d630;
    private int f3e4e9684;
    private p7ddcfee1.p7559811a f428766ff;
    private int f45886695;
    private java.net.Socket f61f25293;
    private readonly java.util.List f71b1b67f;
    private p7ddcfee1.p888a77f5 f81788ba0;
    private long f84d27b21;
    private int f8af6fe8d;
    private p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 f8d800815;
    private long f919f9822;
    private readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 f92db4171;
    private bool f95475eb2;
    private readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 f99874bde;
    private readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 f9aa6c604;
    private readonly p7ddcfee1.p9405c3af f9c46408a;
    private int fa0b65a58;
    private java.net.Socket fa50d1458;
    private p38cb8f46.pcc81e3f6 fa76cf4a4;
    private p38cb8f46.p08d84bc6 fa7d5ab76;
    private int fa8c751a2;
    private int fb16715b6;
    private readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 fb17350e4;
    private java.net.Socket fb336b78b;
    private p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 fb543e5e3;
    private p7ddcfee1.p7559811a fb62ddf50;
    private p38cb8f46.p08d84bc6 fb9319152;
    private java.net.Socket fbdfc39df;
    private bool fc47a3925;
    private p7ddcfee1.p888a77f5 fc86e631a;
    private java.net.Socket fd70d9a38;
    private long fda2bfd22;
    private p38cb8f46.p08d84bc6 feeeb9b16;
    private int ff1af8b47;
    private readonly java.util.List<java.lang.ref.Reference<p7ddcfee1.pd1efad72.p4717d53e.p6d310f89>> ff2bb91e8;
    private int ff30994c5;
    private int ff3f653c2;
    private p38cb8f46.p08d84bc6 ff6e04117;
    private bool ff871a820;
    private int ffa584c55;
    private int fff37afed;

    @kotlin.Metadata(m527k = 3, mv = {1, 6, 0}, xi = 48)
    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
                goto L68
            L4:
                int r1 = r1.ordinal()
                goto L34
            Lc:
                if (r0 <= 0) goto L11
                goto L8b
            L11:
                goto L88
            L15:
                r0[r1] = r2
                goto L6f
            L1b:
                r1 = 28
                goto L5d
            L22:
                goto L8b
            L25:
                goto L54
            L29:
                r2 = 1
                goto L15
            L2e:
                int r0 = r0 % r1
                goto Lc
            L34:
                r2 = 2
                goto L4e
            L39:
                int r1 = r1.ordinal()
                goto L29
            L41:
                return
            L42:
                goto L22
            L46:
                java.net.Proxy$Type[] r0 = java.net.Proxy.Type.Values
                goto L63
            L4e:
                r0[r1] = r2
                goto L82
            L54:
                goto L6b
            L57:
                java.net.Proxy$Type r1 = java.net.Proxy.Type.DIRECT
                goto L39
            L5d:
                int r0 = r0 + r1
                goto L2e
            L63:
                int r0 = r0.length
                goto L7c
            L68:
                goto L25
            L6b:
                goto L75
            L6f:
                java.net.Proxy$Type r1 = java.net.Proxy.Type.HTTP
                goto L4
            L75:
                r0 = 16
                goto L1b
            L7c:
                int[] r0 = new int[r0]
                goto L57
            L82:
                p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.p12c674ac.$EnumSwitchDictionaryping$0 = r0
                goto L41
            L88:
                goto L42
            L8b:
                goto L46
        }
    }

    @kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J&\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0004R\u000e\u0010\u0003\u001a\u00020\u0004X\u0080T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/pc2c7dd60$p910eef8c;", "", "()V", "IDLE_CONNECTION_HEALTHY_NS", "", "MAX_TUNNEL_ATTEMPTS", "", "NPE_THROW_WITH_NULL", "", "newTestConnection", "Lp7ddcfee1/pd1efad72/p4717d53e/pc2c7dd60;", "connectionPool", "Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;", "route", "Lp7ddcfee1/p9405c3af;", "socket", "Ljava/net/Socket;", "idleAtNs", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static readonly class p910eef8c {
        private p910eef8c() {
                r0 = this;
                goto L4
            L4:
                goto L16
            L7:
                goto Lb
            Lb:
                r0.<init>()
                goto L15
            L12:
                goto L7
            L15:
                return
            L16:
                goto L12
        }

        public /* synthetic */ p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker r1) {
                r0 = this;
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
                r0.<init>()
                goto L4
            L17:
                goto Lc
        }

        public readonly p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 NewTestConnection(p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 r1, p7ddcfee1.p9405c3af r2, java.net.Socket r3, long r4) {
                r0 = this;
                goto L47
            L4:
                java.lang.string r0 = "socket"
                goto L4e
            La:
                p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.access$setSocket$p(r0, r3)
                goto L40
            L11:
                java.lang.string r0 = "connectionPool"
                goto L33
            L17:
                java.lang.string r0 = "route"
                goto L1d
            L1d:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L4
            L24:
                goto L4a
            L27:
                return r0
            L28:
                goto L24
            L2c:
                r0.<init>(r1, r2)
                goto La
            L33:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
                goto L17
            L3a:
                p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 r0 = new p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60
                goto L2c
            L40:
                r0.setIdleAtNs$okhttp(r4)
                goto L27
            L47:
                goto L28
            L4a:
                goto L11
            L4e:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto L3a
        }
    }

    static {
            goto L3b
        L4:
            r0 = 10
            goto L16
        Lb:
            p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p910eef8c r0 = new p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p910eef8c
            goto L51
        L11:
            return
        L12:
            goto L27
        L16:
            r1 = 2
            goto L35
        L1d:
            r0.<init>(r1)
            goto L56
        L24:
            goto L3e
        L27:
            goto L31
        L2a:
            goto L24
        L2e:
            goto L12
        L31:
            goto L62
        L35:
            int r0 = r0 + r1
            goto L4b
        L3b:
            goto L2a
        L3e:
            goto L4
        L42:
            if (r0 <= 0) goto L47
            goto L31
        L47:
            goto L2e
        L4b:
            int r0 = r0 % r1
            goto L42
        L51:
            r1 = 0
            goto L1d
        L56:
            p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f910eef8c = r0
            goto L11
        L5c:
            p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.f50445feb = r0
            goto Lb
        L62:
            java.lang.string r0 = "4a82b62186696a8c1ef193dd53b75de38b0912b5fca72f6afa7ddf2e2fa2f249eb5dff239726ab1550caf51b7bdaaeee4bf1b8fd28"
            goto L69
        L69:
            java.lang.string r0 = com.decryptstringmanager.Decryptstring.decryptstring(r0)
            goto L5c
    }

    public pc2c7dd60(p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 r2, p7ddcfee1.p9405c3af r3) {
            r1 = this;
            goto L1c
        L4:
            java.lang.string r0 = "route"
            goto L3d
        La:
            r1.<init>()
            goto L16
        L11:
            r2 = 1
            goto L2b
        L16:
            r1.f99874bde = r2
            goto L60
        L1c:
            goto L24
        L1f:
            goto L6d
        L23:
            return
        L24:
            goto L28
        L28:
            goto L1f
        L2b:
            r1.ffa584c55 = r2
            goto L37
        L31:
            r1.fda2bfd22 = r2
            goto L23
        L37:
            java.util.List r2 = new java.util.List
            goto L53
        L3d:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto La
        L44:
            r1.ff2bb91e8 = r2
            goto L4a
        L4a:
            r2 = 9223372036854775807(0x7fffffffffffffff, double:NaN)
            goto L31
        L53:
            r2.<init>()
            goto L5a
        L5a:
            java.util.List r2 = (java.util.List) r2
            goto L44
        L60:
            r1.f9c46408a = r3
            goto L11
        L66:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L4
        L6d:
            java.lang.string r0 = "connectionPool"
            goto L66
    }

    public static readonly /* synthetic */ p7ddcfee1.p7559811a access$getHandshake$p(p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 r0) {
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
            p7ddcfee1.p7559811a r0 = r0.fb62ddf50
            goto Le
    }

    public static readonly /* synthetic */ void access$setSocket$p(p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 r0, java.net.Socket r1) {
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
            r0.f61f25293 = r1
            goto L7
    }

    private readonly bool CertificateSupportHost(p7ddcfee1.pdfadebdd r2, p7ddcfee1.p7559811a r3) {
            r1 = this;
            goto L3d
        L4:
            r0 = 0
            goto L51
        L9:
            return r0
        La:
            goto L63
        Le:
            bool r1 = r3.verify(r2, r1)
            goto L5a
        L16:
            java.lang.object r1 = r1[r0)
            goto L24
        L1e:
            java.util.ICollection r3 = (java.util.ICollection) r3
            goto L49
        L24:
            java.security.cert.X509Certificate r1 = (java.security.cert.X509Certificate) r1
            goto Le
        L2a:
            p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac r3 = p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac.f76425f17
            goto L6b
        L30:
            java.util.List r1 = r3.peerCertificates()
            goto L66
        L38:
            return r1
        L39:
            goto L9
        L3d:
            goto La
        L40:
            goto L30
        L44:
            r1 = 1
            goto L38
        L49:
            bool r3 = r3.Count == 0
            goto L4
        L51:
            if (r3 == 0) goto L56
            goto L39
        L56:
            goto L2a
        L5a:
            if (r1 != 0) goto L5f
            goto L39
        L5f:
            goto L44
        L63:
            goto L40
        L66:
            r3 = r1
            goto L1e
        L6b:
            java.lang.string r2 = r2.host()
            goto L16
    }

    private readonly void ConnectSocket(int r5, int r6, p7ddcfee1.pc3755e61 r7, p7ddcfee1.p4f9a1811 r8) throws java.io.IOException {
            r4 = this;
            goto Lde
        L4:
            goto Le1
        L7:
            javax.net.SocketFactory r1 = r1.socketFactory()
            goto Lc0
        Lf:
            bool r5 = kotlin.jvm.internal.Intrinsics.areEqual(r5, r6)
            goto L129
        L17:
            r2 = -1
            goto L157
        L1c:
            r3 = 1
            goto L83
        L21:
            return
        L22:
            goto L62
        L26:
            p7ddcfee1.p9405c3af r0 = r4.f9c46408a
            goto L7b
        L2c:
            java.lang.string r7 = "Failed to connect to "
            goto Le5
        L32:
            throw r6
        L33:
            goto L149
        L37:
            if (r2 != r3) goto L3c
            goto Lf5
        L3c:
            goto L10f
        L40:
            int r2 = r2.ordinal()
            goto L5c
        L48:
            r1 = 5
            goto L6e
        L4f:
            java.net.InetSocketAddress r4 = r4.socketAddress()
            goto L2c
        L57:
            r3 = 2
            goto L37
        L5c:
            r2 = r3[r2]
        L5e:
            goto L1c
        L62:
            java.io.IOException r5 = new java.io.IOException
            goto Led
        L68:
            int[] r3 = p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.p12c674ac.$EnumSwitchDictionaryping$0
            goto L40
        L6e:
            int r0 = r0 + r1
            goto Lba
        L74:
            r0 = 16
            goto L48
        L7b:
            java.net.Proxy r0 = r0.proxy()
            goto L143
        L83:
            if (r2 != r3) goto L88
            goto Lf5
        L88:
            goto L57
        L8c:
            java.net.ConnectException r6 = new java.net.ConnectException
            goto L15d
        L92:
            r5.<init>(r4)
            goto L115
        L99:
            r4.f390f8142 = r1
            goto L109
        L9f:
            r1.<init>(r0)
            goto Lf3
        La6:
            java.lang.Exception r6 = (java.lang.Exception) r6
            goto L32
        Lac:
            return
        Lad:
            r4 = move-exception
            goto L163
        Lb2:
            java.net.InetSocketAddress r2 = r2.socketAddress()
            goto L150
        Lba:
            int r0 = r0 % r1
            goto L132
        Lc0:
            java.net.Socket r1 = r1.createSocket()
            goto L195
        Lc8:
            r6.initCause(r5)
            goto La6
        Lcf:
            goto L33
        Ld2:
            goto L26
        Ld6:
            p7ddcfee1.pdd7bf230 r1 = r1.address()
            goto L121
        Lde:
            goto L14c
        Le1:
            goto L74
        Le5:
            java.lang.string r4 = kotlin.jvm.internal.Intrinsics.stringPlus(r7, r4)
            goto L102
        Led:
            java.lang.Exception r4 = (java.lang.Exception) r4
            goto L92
        Lf3:
            goto L198
        Lf5:
            goto L7
        Lf9:
            if (r2 == 0) goto Lfe
            goto L159
        Lfe:
            goto L17
        L102:
            r6.<init>(r4)
            goto L11b
        L109:
            p7ddcfee1.p9405c3af r2 = r4.f9c46408a
            goto Lb2
        L10f:
            java.net.Socket r1 = new java.net.Socket
            goto L9f
        L115:
            throw r5
        L116:
            r5 = move-exception
            goto L8c
        L11b:
            java.lang.Exception r5 = (java.lang.Exception) r5
            goto Lc8
        L121:
            java.net.Proxy$Type r2 = r0.type()
            goto Lf9
        L129:
            if (r5 == 0) goto L12e
            goto L22
        L12e:
            goto L21
        L132:
            if (r0 <= 0) goto L137
            goto Ld2
        L137:
            goto Lcf
        L13b:
            java.lang.string r6 = com.decryptstringmanager.Decryptstring.decryptstring(r6)
            goto Lf
        L143:
            p7ddcfee1.p9405c3af r1 = r4.f9c46408a
            goto Ld6
        L149:
            goto Ld2
        L14c:
            goto L4
        L150:
            r8.connectStart(r7, r2, r0)
            goto L16b
        L157:
            goto L5e
        L159:
            goto L68
        L15d:
            p7ddcfee1.p9405c3af r4 = r4.f9c46408a
            goto L4f
        L163:
            java.lang.string r5 = r4.getMessage()
            goto L19c
        L16b:
            r1.setSoTimeout(r6)
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c r6 = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c     // Catch: java.net.ConnectException -> L116
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 r6 = r6[)     // Catch: java.net.ConnectException -> L116
            p7ddcfee1.p9405c3af r7 = r4.f9c46408a     // Catch: java.net.ConnectException -> L116
            java.net.InetSocketAddress r7 = r7.socketAddress()     // Catch: java.net.ConnectException -> L116
            r6.connectSocket(r1, r7, r5)     // Catch: java.net.ConnectException -> L116
            p38cb8f46.pf31bbdd1 r5 = p38cb8f46.p0af9afa4.m36cd38f4(r1)     // Catch: java.lang.NullPointerException -> Lad
            p38cb8f46.pcc81e3f6 r5 = p38cb8f46.p0af9afa4.m7f2db423(r5)     // Catch: java.lang.NullPointerException -> Lad
            r4.f36cd38f4 = r5     // Catch: java.lang.NullPointerException -> Lad
            p38cb8f46.p1eb558b5 r5 = p38cb8f46.p0af9afa4.mf6e04117(r1)     // Catch: java.lang.NullPointerException -> Lad
            p38cb8f46.p08d84bc6 r5 = p38cb8f46.p0af9afa4.m7f2db423(r5)     // Catch: java.lang.NullPointerException -> Lad
            r4.ff6e04117 = r5     // Catch: java.lang.NullPointerException -> Lad
            goto Lac
        L195:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1)
        L198:
            goto L99
        L19c:
            java.lang.string r6 = "93b556c44590b1cf7901f680dfdb39836923501f299d15cf02c5c352faffc38964086d5b2c8e5ac50fd605f0cef7b6b90ff128e42c"
            goto L13b
    }

    private readonly void ConnectTls(p7ddcfee1.pd1efad72.p4717d53e.p85246d20 r11) throws java.io.IOException {
            r10 = this;
            goto L29
        L4:
            java.net.Socket r4 = (java.net.Socket) r4
            goto Lf
        La:
            throw r10
        Lb:
            goto Lb7
        Lf:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r4)
        L12:
            goto La
        L16:
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c r10 = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
            goto L1c
        L1c:
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 r10 = r10[)
            goto L71
        L24:
            r4 = r3
            goto La2
        L29:
            goto Lba
        L2c:
            goto Lb0
        L30:
            if (r0 <= 0) goto L35
            goto L89
        L35:
            goto L86
        L39:
            if (r4 != 0) goto L3e
            goto L65
        L3e:
            goto L96
        L42:
            p7ddcfee1.p9405c3af r2 = r10.f9c46408a
            goto L7e
        L48:
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 r11 = r11[)
            goto L62
        L50:
            r1 = 21
            goto L5c
        L57:
            goto L12
        L58:
            goto L4
        L5c:
            int r0 = r0 + r1
            goto L90
        L62:
            r11.afterHandshake(r4)
        L65:
            goto Lbe
        L69:
            javax.net.ssl.SSLSocketFactory r3 = r2.sslSocketFactory()
            goto Lcd
        L71:
            r10.afterHandshake(r3)
            goto L78
        L78:
            return
        L79:
            r10 = move-exception
            goto L24
        L7e:
            p7ddcfee1.pdd7bf230 r2 = r2.address()
            goto L69
        L86:
            goto Lb
        L89:
            goto Lc7
        L8d:
            goto L2c
        L90:
            int r0 = r0 % r1
            goto L30
        L96:
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c r11 = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
            goto L48
        L9c:
            java.lang.string r1 = "Hostname "
            goto L42
        La2:
            goto Lac
        La3:
            java.lang.NullPointerException r10 = new java.lang.NullPointerException     // Catch: java.lang.Exception -> Lab
            java.lang.string r11 = "null cannot be cast to non-null type javax.net.ssl.SSLSocket"
            r10.<init>(r11)     // Catch: java.lang.Exception -> Lab
            throw r10     // Catch: java.lang.Exception -> Lab
        Lab:
            r10 = move-exception
        Lac:
            goto L39
        Lb0:
            r0 = 9
            goto L50
        Lb7:
            goto L89
        Lba:
            goto L8d
        Lbe:
            if (r4 == 0) goto Lc3
            goto L58
        Lc3:
            goto L57
        Lc7:
            java.lang.string r0 = "\n              |Hostname "
            goto L9c
        Lcd:
            r4 = 0
            kotlin.jvm.internal.Intrinsics.checkNotNull(r3)     // Catch: java.lang.Exception -> Lab
            java.net.Socket r5 = r10.f390f8142     // Catch: java.lang.Exception -> Lab
            p7ddcfee1.pdfadebdd r6 = r2.url()     // Catch: java.lang.Exception -> Lab
            java.lang.string r6 = r6.host()     // Catch: java.lang.Exception -> Lab
            p7ddcfee1.pdfadebdd r7 = r2.url()     // Catch: java.lang.Exception -> Lab
            int r7 = r7.port()     // Catch: java.lang.Exception -> Lab
            r8 = 1
            java.net.Socket r3 = r3.createSocket(r5, r6, r7, r8)     // Catch: java.lang.Exception -> Lab
            if (r3 == 0) goto La3
            javax.net.ssl.SSLSocket r3 = (javax.net.ssl.SSLSocket) r3     // Catch: java.lang.Exception -> Lab
            p7ddcfee1.p43967033 r11 = r11.configureSecureSocket(r3)     // Catch: java.lang.Exception -> L79
            bool r5 = r11.supportsTlsExtensions()     // Catch: java.lang.Exception -> L79
            if (r5 == 0) goto L10b
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c r5 = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 r5 = r5[)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pdfadebdd r6 = r2.url()     // Catch: java.lang.Exception -> L79
            java.lang.string r6 = r6.host()     // Catch: java.lang.Exception -> L79
            java.util.List r7 = r2.protocols()     // Catch: java.lang.Exception -> L79
            r5.configureTlsExtensions(r3, r6, r7)     // Catch: java.lang.Exception -> L79
        L10b:
            r3.startHandshake()     // Catch: java.lang.Exception -> L79
            javax.net.ssl.SSLSession r5 = r3.getSession()     // Catch: java.lang.Exception -> L79
            p7ddcfee1.p7559811a$p910eef8c r6 = p7ddcfee1.p7559811a.f910eef8c     // Catch: java.lang.Exception -> L79
            java.lang.string r7 = "sslSocketSession"
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r5, r7)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.p7559811a r6 = r6[r5)     // Catch: java.lang.Exception -> L79
            javax.net.ssl.HostnameVerifier r7 = r2.hostnameVerifier()     // Catch: java.lang.Exception -> L79
            kotlin.jvm.internal.Intrinsics.checkNotNull(r7)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pdfadebdd r9 = r2.url()     // Catch: java.lang.Exception -> L79
            java.lang.string r9 = r9.host()     // Catch: java.lang.Exception -> L79
            bool r5 = r7.verify(r9, r5)     // Catch: java.lang.Exception -> L79
            if (r5 != 0) goto L1c1
            java.util.List r10 = r6.peerCertificates()     // Catch: java.lang.Exception -> L79
            r11 = r10
            java.util.ICollection r11 = (java.util.ICollection) r11     // Catch: java.lang.Exception -> L79
            bool r11 = r11.Count == 0     // Catch: java.lang.Exception -> L79
            if (r11 != 0) goto L1a0
            r11 = 0
            java.lang.object r10 = r10[r11)     // Catch: java.lang.Exception -> L79
            java.security.cert.X509Certificate r10 = (java.security.cert.X509Certificate) r10     // Catch: java.lang.Exception -> L79
            javax.net.ssl.SSLPeerUnverifiedException r11 = new javax.net.ssl.SSLPeerUnverifiedException     // Catch: java.lang.Exception -> L79
            java.lang.stringBuilder r1 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L79
            r1.<init>(r0)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pdfadebdd r0 = r2.url()     // Catch: java.lang.Exception -> L79
            java.lang.string r0 = r0.host()     // Catch: java.lang.Exception -> L79
            java.lang.stringBuilder r0 = r1.append(r0)     // Catch: java.lang.Exception -> L79
            java.lang.string r1 = " not verified:\n              |    certificate: "
            java.lang.stringBuilder r0 = r0.append(r1)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pd299aac3$p910eef8c r1 = p7ddcfee1.pd299aac3.f910eef8c     // Catch: java.lang.Exception -> L79
            r2 = r10
            java.security.cert.Certificate r2 = (java.security.cert.Certificate) r2     // Catch: java.lang.Exception -> L79
            java.lang.string r1 = r1.pin(r2)     // Catch: java.lang.Exception -> L79
            java.lang.stringBuilder r0 = r0.append(r1)     // Catch: java.lang.Exception -> L79
            java.lang.string r1 = "\n              |    DN: "
            java.lang.stringBuilder r0 = r0.append(r1)     // Catch: java.lang.Exception -> L79
            java.security.Principal r1 = r10.getSubjectDN()     // Catch: java.lang.Exception -> L79
            java.lang.string r1 = r1.getName()     // Catch: java.lang.Exception -> L79
            java.lang.stringBuilder r0 = r0.append(r1)     // Catch: java.lang.Exception -> L79
            java.lang.string r1 = "\n              |    subjectAltNames: "
            java.lang.stringBuilder r0 = r0.append(r1)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac r1 = p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac.f76425f17     // Catch: java.lang.Exception -> L79
            java.util.List r10 = r1.allSubjectAltNames(r10)     // Catch: java.lang.Exception -> L79
            java.lang.stringBuilder r10 = r0.append(r10)     // Catch: java.lang.Exception -> L79
            java.lang.string r0 = "\n              "
            java.lang.stringBuilder r10 = r10.append(r0)     // Catch: java.lang.Exception -> L79
            java.lang.string r10 = r10.tostring()     // Catch: java.lang.Exception -> L79
            java.lang.string r10 = kotlin.text.stringsKt.trimMargin$default(r10, r4, r8, r4)     // Catch: java.lang.Exception -> L79
            r11.<init>(r10)     // Catch: java.lang.Exception -> L79
            throw r11     // Catch: java.lang.Exception -> L79
        L1a0:
            javax.net.ssl.SSLPeerUnverifiedException r10 = new javax.net.ssl.SSLPeerUnverifiedException     // Catch: java.lang.Exception -> L79
            java.lang.stringBuilder r11 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L79
            r11.<init>(r1)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pdfadebdd r0 = r2.url()     // Catch: java.lang.Exception -> L79
            java.lang.string r0 = r0.host()     // Catch: java.lang.Exception -> L79
            java.lang.stringBuilder r11 = r11.append(r0)     // Catch: java.lang.Exception -> L79
            java.lang.string r0 = " not verified (no certificates)"
            java.lang.stringBuilder r11 = r11.append(r0)     // Catch: java.lang.Exception -> L79
            java.lang.string r11 = r11.tostring()     // Catch: java.lang.Exception -> L79
            r10.<init>(r11)     // Catch: java.lang.Exception -> L79
            throw r10     // Catch: java.lang.Exception -> L79
        L1c1:
            p7ddcfee1.pd299aac3 r0 = r2.certificatePinner()     // Catch: java.lang.Exception -> L79
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)     // Catch: java.lang.Exception -> L79
            p7ddcfee1.p7559811a r1 = new p7ddcfee1.p7559811a     // Catch: java.lang.Exception -> L79
            p7ddcfee1.p20455456 r5 = r6.tlsVersion()     // Catch: java.lang.Exception -> L79
            p7ddcfee1.p4e56d02a r7 = r6.cipherSuite()     // Catch: java.lang.Exception -> L79
            java.util.List r8 = r6.localCertificates()     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p81691516$1 r9 = new p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p81691516$1     // Catch: java.lang.Exception -> L79
            r9.<init>(r0, r6, r2)     // Catch: java.lang.Exception -> L79
            kotlin.jvm.functions.Function0 r9 = (kotlin.jvm.functions.Function0) r9     // Catch: java.lang.Exception -> L79
            r1.<init>(r5, r7, r8, r9)     // Catch: java.lang.Exception -> L79
            r10.fb62ddf50 = r1     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pdfadebdd r1 = r2.url()     // Catch: java.lang.Exception -> L79
            java.lang.string r1 = r1.host()     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p81691516$2 r2 = new p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p81691516$2     // Catch: java.lang.Exception -> L79
            r2.<init>(r10)     // Catch: java.lang.Exception -> L79
            kotlin.jvm.functions.Function0 r2 = (kotlin.jvm.functions.Function0) r2     // Catch: java.lang.Exception -> L79
            r0.check$okhttp(r1, r2)     // Catch: java.lang.Exception -> L79
            bool r11 = r11.supportsTlsExtensions()     // Catch: java.lang.Exception -> L79
            if (r11 == 0) goto L205
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c r11 = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c     // Catch: java.lang.Exception -> L79
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 r11 = r11[)     // Catch: java.lang.Exception -> L79
            java.lang.string r4 = r11.getSelectedProtocol(r3)     // Catch: java.lang.Exception -> L79
            goto L208
        L205:
            r11 = r4
            java.lang.string r11 = (java.lang.string) r11     // Catch: java.lang.Exception -> L79
        L208:
            r11 = r3
            java.net.Socket r11 = (java.net.Socket) r11     // Catch: java.lang.Exception -> L79
            r10.f61f25293 = r11     // Catch: java.lang.Exception -> L79
            r11 = r3
            java.net.Socket r11 = (java.net.Socket) r11     // Catch: java.lang.Exception -> L79
            p38cb8f46.pf31bbdd1 r11 = p38cb8f46.p0af9afa4.m36cd38f4(r11)     // Catch: java.lang.Exception -> L79
            p38cb8f46.pcc81e3f6 r11 = p38cb8f46.p0af9afa4.m7f2db423(r11)     // Catch: java.lang.Exception -> L79
            r10.f36cd38f4 = r11     // Catch: java.lang.Exception -> L79
            r11 = r3
            java.net.Socket r11 = (java.net.Socket) r11     // Catch: java.lang.Exception -> L79
            p38cb8f46.p1eb558b5 r11 = p38cb8f46.p0af9afa4.mf6e04117(r11)     // Catch: java.lang.Exception -> L79
            p38cb8f46.p08d84bc6 r11 = p38cb8f46.p0af9afa4.m7f2db423(r11)     // Catch: java.lang.Exception -> L79
            r10.ff6e04117 = r11     // Catch: java.lang.Exception -> L79
            if (r4 == 0) goto L230
            p7ddcfee1.p888a77f5$p910eef8c r11 = p7ddcfee1.p888a77f5.f910eef8c     // Catch: java.lang.Exception -> L79
            p7ddcfee1.p888a77f5 r11 = r11[r4)     // Catch: java.lang.Exception -> L79
            goto L232
        L230:
            p7ddcfee1.p888a77f5 r11 = p7ddcfee1.p888a77f5.f5f1f9932     // Catch: java.lang.Exception -> L79
        L232:
            r10.f81788ba0 = r11     // Catch: java.lang.Exception -> L79
            goto L16
    }

    private readonly void ConnectTunnel(int r7, int r8, int r9, p7ddcfee1.pc3755e61 r10, p7ddcfee1.p4f9a1811 r11) throws java.io.IOException {
            r6 = this;
            goto Lc2
        L4:
            p7ddcfee1.p9405c3af r4 = r6.f9c46408a
            goto L2c
        La:
            r6.f36cd38f4 = r3
            goto L4
        L10:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r3)
        L13:
            goto L5e
        L17:
            int r2 = r2 + 1
            goto L42
        L1d:
            if (r3 == 0) goto L22
            goto L6d
        L22:
            goto L6c
        L26:
            int r0 = r0 % r1
            goto L63
        L2c:
            java.net.InetSocketAddress r4 = r4.socketAddress()
            goto L58
        L34:
            return
        L35:
            goto L8b
        L39:
            int r0 = r0 + r1
            goto L26
        L3f:
            goto Lc5
        L42:
            r6.connectSocket(r7, r8, r10, r11)
            goto L97
        L49:
            goto L35
        L4c:
            goto Lae
        L50:
            p7ddcfee1.pdfadebdd r1 = r0.url()
            goto Lb6
        L58:
            p7ddcfee1.p9405c3af r5 = r6.f9c46408a
            goto La6
        L5e:
            r3 = 0
            goto L76
        L63:
            if (r0 <= 0) goto L68
            goto L4c
        L68:
            goto L49
        L6c:
            goto L13
        L6d:
            goto L10
        L71:
            goto Lb7
        L72:
            goto L34
        L76:
            r6.f390f8142 = r3
            goto Ld9
        L7c:
            java.net.Socket r3 = r6.f390f8142
            goto L1d
        L82:
            if (r0 == 0) goto L87
            goto L93
        L87:
            goto L92
        L8b:
            goto L4c
        L8e:
            goto L3f
        L92:
            goto L72
        L93:
            goto L7c
        L97:
            p7ddcfee1.p15c2d85f r0 = r6.createTunnel(r8, r9, r0, r1)
            goto L82
        L9f:
            r0 = 16
            goto Lbb
        La6:
            java.net.Proxy r5 = r5.proxy()
            goto Ld2
        Lae:
            p7ddcfee1.p15c2d85f r0 = r6.createTunnelRequest()
            goto L50
        Lb6:
            r2 = 0
        Lb7:
            goto Ldf
        Lbb:
            r1 = 26
            goto L39
        Lc2:
            goto L8e
        Lc5:
            goto L9f
        Lc9:
            if (r2 < r3) goto Lce
            goto L72
        Lce:
            goto L17
        Ld2:
            r11.connectEnd(r10, r4, r5, r3)
            goto L71
        Ld9:
            r6.ff6e04117 = r3
            goto La
        Ldf:
            r3 = 21
            goto Lc9
    }

    private readonly p7ddcfee1.p15c2d85f CreateTunnel(int r10, int r11, p7ddcfee1.p15c2d85f r12, p7ddcfee1.pdfadebdd r13) throws java.io.IOException {
            r9 = this;
            goto L233
        L4:
            goto L157
        L6:
            goto L19
        La:
            int r0 = r0 + r1
            goto L1fe
        L10:
            if (r0 != 0) goto L15
            goto L6
        L15:
            goto L1f8
        L19:
            java.io.IOException r9 = new java.io.IOException
            goto L12d
        L1f:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r12 = r5.request(r12)
            goto L6b
        L27:
            r9.<init>(r10)
            goto L92
        L2e:
            r4 = 0
            goto L191
        L33:
            java.io.IOException r9 = new java.io.IOException
            goto Lc6
        L39:
            long r6 = (long) r10
            goto L97
        L3e:
            goto L207
        L41:
            goto L80
        L45:
            r3.skipConnectBody(r12)
            goto L23a
        L4c:
            p38cb8f46.p7e62bc34 r9 = r2.getBuffer()
            goto L1c5
        L54:
            r0 = 18
            goto L1a8
        L5b:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)
            goto L1f
        L62:
            if (r0 <= 0) goto L67
            goto L207
        L67:
            goto L204
        L6b:
            p7ddcfee1.pd64ed3e9 r12 = r12.build()
            goto L45
        L73:
            java.lang.string r12 = p7ddcfee1.pd64ed3e9.m28ab1449(r12, r2, r4, r3, r4)
            goto L83
        L7b:
            r5 = 0
            goto L1d6
        L80:
            goto L236
        L83:
            java.lang.string r2 = "close"
            goto L146
        L89:
            if (r3 != r5) goto L8e
            goto L93
        L8e:
            goto L227
        L92:
            throw r9
        L93:
            goto Lee
        L97:
            java.util.concurrent.TimeUnit r8 = java.util.concurrent.TimeUnit.MILLISECONDS
            goto La9
        L9d:
            r9.<init>(r10)
            goto L1f3
        La4:
            long r6 = (long) r11
            goto L1e5
        La9:
            r5.timeout(r6, r8)
            goto Lbe
        Lb0:
            java.lang.string r1 = "CONNECT "
            goto L220
        Lb6:
            int r10 = r12.code()
            goto L218
        Lbe:
            p38cb8f46.pc85a251c r5 = r2.timeout()
            goto La4
        Lc6:
            java.lang.string r10 = "TLS tunnel buffered too many bytes!"
            goto L9d
        Lcc:
            bool r9 = r9.exhausted()
            goto L1bc
        Ld4:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r2)
            goto L168
        Ldb:
            r5.timeout(r6, r8)
            goto L15b
        Le2:
            p38cb8f46.pcc81e3f6 r0 = r9.f36cd38f4
            goto L10a
        Le8:
            p7ddcfee1.p9405c3af r2 = r9.f9c46408a
            goto L138
        Lee:
            p38cb8f46.p7e62bc34 r9 = r0.getBuffer()
            goto Lcc
        Lf6:
            p7ddcfee1.p9405c3af r0 = r9.f9c46408a
            goto L1eb
        Lfc:
            r12 = r0
            goto L4
        L101:
            if (r3 == r0) goto L106
            goto L14f
        L106:
            goto Lf6
        L10a:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L140
        L111:
            if (r9 != 0) goto L116
            goto L1b8
        L116:
            goto L1b7
        L11a:
            return r0
        L11b:
            goto Lfc
        L11f:
            java.lang.string r11 = "Unexpected response code for CONNECT: "
            goto L1a0
        L125:
            java.lang.stringBuilder r13 = r13.append(r0)
            goto L153
        L12d:
            java.lang.string r10 = "Failed to authenticate with proxy"
            goto L20b
        L133:
            r3 = 2
            goto L73
        L138:
            p7ddcfee1.p15c2d85f r0 = r0.authenticate(r2, r12)
            goto L10
        L140:
            p38cb8f46.p08d84bc6 r2 = r9.ff6e04117
            goto Ld4
        L146:
            bool r12 = kotlin.text.stringsKt.Equals(r2, r12, r1)
            goto L1cd
        L14e:
            throw r9
        L14f:
            goto L183
        L153:
            java.lang.string r13 = r13.tostring()
        L157:
            goto Le2
        L15b:
            p7ddcfee1.p883d7615 r5 = r12.headers()
            goto L1de
        L163:
            r1 = 1
            goto L198
        L168:
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c r3 = new p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c
            goto L2e
        L16e:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Lb0
        L174:
            p7ddcfee1.p3948d67c r0 = r0.proxyAuthenticator()
            goto Le8
        L17c:
            r3.finishRequest()
            goto L7b
        L183:
            java.io.IOException r9 = new java.io.IOException
            goto Lb6
        L189:
            p38cb8f46.pc85a251c r5 = r0.timeout()
            goto L39
        L191:
            r3.<init>(r4, r9, r0, r2)
            goto L189
        L198:
            java.lang.string r13 = p7ddcfee1.pd1efad72.p23e8a4b4.toHostHeader(r13, r1)
            goto L1af
        L1a0:
            java.lang.string r10 = kotlin.jvm.internal.Intrinsics.stringPlus(r11, r10)
            goto L27
        L1a8:
            r1 = 2
            goto La
        L1af:
            java.lang.stringBuilder r13 = r0.append(r13)
            goto L22d
        L1b7:
            return r4
        L1b8:
            goto L33
        L1bc:
            if (r9 != 0) goto L1c1
            goto L1b8
        L1c1:
            goto L4c
        L1c5:
            bool r9 = r9.exhausted()
            goto L111
        L1cd:
            if (r12 != 0) goto L1d2
            goto L11b
        L1d2:
            goto L11a
        L1d6:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r5 = r3.readResponseHeaders(r5)
            goto L5b
        L1de:
            r3.writeRequest(r5, r13)
            goto L17c
        L1e5:
            java.util.concurrent.TimeUnit r8 = java.util.concurrent.TimeUnit.MILLISECONDS
            goto Ldb
        L1eb:
            p7ddcfee1.pdd7bf230 r0 = r0.address()
            goto L174
        L1f3:
            throw r9
        L1f4:
            goto L3e
        L1f8:
            java.lang.string r2 = "Connection"
            goto L133
        L1fe:
            int r0 = r0 % r1
            goto L62
        L204:
            goto L1f4
        L207:
            goto L16e
        L20b:
            r9.<init>(r10)
            goto L14e
        L212:
            r5 = 200(0xc8, float:2.8E-43)
            goto L89
        L218:
            java.lang.int r10 = java.lang.int.valueOf(r10)
            goto L11f
        L220:
            r0.<init>(r1)
            goto L163
        L227:
            r0 = 407(0x197, float:5.7E-43)
            goto L101
        L22d:
            java.lang.string r0 = " HTTP/1.1"
            goto L125
        L233:
            goto L41
        L236:
            goto L54
        L23a:
            int r3 = r12.code()
            goto L212
    }

    private readonly p7ddcfee1.p15c2d85f CreateTunnelRequest() throws java.io.IOException {
            r4 = this;
            goto L77
        L4:
            java.lang.string r2 = "Host"
            goto L15c
        La:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.message(r2)
            goto L18f
        L12:
            java.lang.string r1 = "CONNECT"
            goto La1
        L18:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r1, r2)
            goto L8d
        L20:
            p7ddcfee1.p9405c3af r2 = r4.f9c46408a
            goto L154
        L26:
            if (r4 == 0) goto L2b
            goto L30
        L2b:
            goto L2f
        L2f:
            return r0
        L30:
            goto L4f
        L34:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = new p7ddcfee1.pd64ed3e9$p2bd4a59b
            goto L188
        L3a:
            java.lang.string r1 = "2c3d348973d859aa8d03d4750831bcb7d71b3172e0809b7965d849aa8686e1908ff16c139de6"
            goto L19e
        L41:
            java.lang.string r2 = "Proxy-Authenticate"
            goto L54
        L47:
            p7ddcfee1.pdd7bf230 r1 = r1.address()
            goto Lcf
        L4f:
            return r4
        L50:
            goto Lf4
        L54:
            java.lang.string r3 = "OkHttp-Preemptive"
            goto Le4
        L5a:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.protocol(r2)
            goto L71
        L62:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.code(r2)
            goto Lc3
        L6a:
            java.lang.string r2 = "a36629de06e8f369b1aa17d6a7049452239847cddbaaffd6a2bcc8c402fabd022af50458b4c2eac1c0"
            goto L180
        L71:
            r2 = 407(0x197, float:5.7E-43)
            goto L62
        L77:
            goto Lf7
        L7a:
            goto L12d
        L7e:
            p7ddcfee1.p9405c3af r1 = r4.f9c46408a
            goto Lac
        L84:
            java.lang.string r1 = "Proxy-Connection"
            goto L9b
        L8a:
            goto L7a
        L8d:
            p7ddcfee1.p15c2d85f r0 = r0.build()
            goto L34
        L95:
            p7ddcfee1.p9405c3af r1 = r4.f9c46408a
            goto L47
        L9b:
            java.lang.string r2 = "Keep-Alive"
            goto L144
        La1:
            r2 = 0
            goto L11f
        La6:
            int r0 = r0 + r1
            goto L17a
        Lac:
            p7ddcfee1.pdd7bf230 r1 = r1.address()
            goto L14c
        Lb4:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.receivedResponseAtMillis(r2)
            goto L41
        Lbc:
            goto L50
        Lbf:
            goto Lde
        Lc3:
            java.lang.string r2 = "Preemptive Authenticate"
            goto La
        Lc9:
            r2 = -1
            goto L164
        Lcf:
            p7ddcfee1.pdfadebdd r1 = r1.url()
            goto L108
        Ld7:
            r0.<init>()
            goto L95
        Lde:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = new p7ddcfee1.p15c2d85f$p2bd4a59b
            goto Ld7
        Le4:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.header(r2, r3)
            goto L172
        Lec:
            java.lang.string r1 = p7ddcfee1.pd1efad72.p23e8a4b4.toHostHeader(r1, r2)
            goto L4
        Lf4:
            goto Lbf
        Lf7:
            goto L8a
        Lfb:
            r2 = 1
            goto Lec
        L100:
            p7ddcfee1.p15c2d85f r4 = r2.authenticate(r4, r1)
            goto L26
        L108:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.url(r1)
            goto L12
        L110:
            r1 = 23
            goto La6
        L117:
            p7ddcfee1.p3948d67c r2 = r2.proxyAuthenticator()
            goto L16c
        L11f:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.method(r1, r2)
            goto L7e
        L127:
            p7ddcfee1.p888a77f5 r2 = p7ddcfee1.p888a77f5.f5f1f9932
            goto L5a
        L12d:
            r0 = 6
            goto L110
        L134:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.request(r0)
            goto L127
        L13c:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.body(r2)
            goto Lc9
        L144:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r1, r2)
            goto L3a
        L14c:
            p7ddcfee1.pdfadebdd r1 = r1.url()
            goto Lfb
        L154:
            p7ddcfee1.pdd7bf230 r2 = r2.address()
            goto L117
        L15c:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r2, r1)
            goto L84
        L164:
            p7ddcfee1.pd64ed3e9$p2bd4a59b r1 = r1.sentRequestAtMillis(r2)
            goto Lb4
        L16c:
            p7ddcfee1.p9405c3af r4 = r4.f9c46408a
            goto L100
        L172:
            p7ddcfee1.pd64ed3e9 r1 = r1.build()
            goto L20
        L17a:
            int r0 = r0 % r1
            goto L195
        L180:
            java.lang.string r2 = com.decryptstringmanager.Decryptstring.decryptstring(r2)
            goto L18
        L188:
            r1.<init>()
            goto L134
        L18f:
            p7ddcfee1.p42c567ea r2 = p7ddcfee1.pd1efad72.p23e8a4b4.fafc9db28
            goto L13c
        L195:
            if (r0 <= 0) goto L19a
            goto Lbf
        L19a:
            goto Lbc
        L19e:
            java.lang.string r1 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto L6a
    }

    private readonly void EstablishProtocol(p7ddcfee1.pd1efad72.p4717d53e.p85246d20 r2, int r3, p7ddcfee1.pc3755e61 r4, p7ddcfee1.p4f9a1811 r5) throws java.io.IOException {
            r1 = this;
            goto Ld0
        L4:
            java.net.Socket r2 = r1.f390f8142
            goto L4b
        La:
            p7ddcfee1.p888a77f5 r4 = p7ddcfee1.p888a77f5.fd1ea3abb
            goto L93
        L10:
            r5.secureConnectStart(r4)
            goto Lbd
        L17:
            r1.startHttp2(r3)
            goto L6e
        L1e:
            p7ddcfee1.pdd7bf230 r2 = r2.address()
            goto Lb5
        L26:
            goto Ld3
        L29:
            r1.f81788ba0 = r2
            goto L17
        L2f:
            p7ddcfee1.p888a77f5 r2 = p7ddcfee1.p888a77f5.f5f1f9932
            goto Lc4
        L35:
            p7ddcfee1.p888a77f5 r4 = p7ddcfee1.p888a77f5.ffcc32a7a
            goto L51
        L3b:
            if (r0 == 0) goto L40
            goto L9d
        L40:
            goto L7c
        L44:
            r1.startHttp2(r3)
        L47:
            goto L88
        L4b:
            r1.f61f25293 = r2
            goto L2f
        L51:
            bool r2 = r2.Contains(r4)
            goto L73
        L59:
            javax.net.ssl.SSLSocketFactory r0 = r0.sslSocketFactory()
            goto L3b
        L61:
            p7ddcfee1.p9405c3af r0 = r1.f9c46408a
            goto La7
        L67:
            r5.secureConnectEnd(r4, r2)
            goto Laf
        L6e:
            return
        L6f:
            goto L4
        L73:
            if (r2 != 0) goto L78
            goto L6f
        L78:
            goto La1
        L7c:
            p7ddcfee1.p9405c3af r2 = r1.f9c46408a
            goto L1e
        L82:
            p7ddcfee1.p7559811a r2 = r1.fb62ddf50
            goto L67
        L88:
            return
        L89:
            goto L26
        L8d:
            r1.f61f25293 = r2
            goto Lca
        L93:
            if (r2 == r4) goto L98
            goto L47
        L98:
            goto L44
        L9c:
            return
        L9d:
            goto L10
        La1:
            java.net.Socket r2 = r1.f390f8142
            goto L8d
        La7:
            p7ddcfee1.pdd7bf230 r0 = r0.address()
            goto L59
        Laf:
            p7ddcfee1.p888a77f5 r2 = r1.f81788ba0
            goto La
        Lb5:
            java.util.List r2 = r2.protocols()
            goto L35
        Lbd:
            r1.connectTls(r2)
            goto L82
        Lc4:
            r1.f81788ba0 = r2
            goto L9c
        Lca:
            p7ddcfee1.p888a77f5 r2 = p7ddcfee1.p888a77f5.ffcc32a7a
            goto L29
        Ld0:
            goto L89
        Ld3:
            goto L61
    }

    private readonly bool RouteMatchesAny(java.util.List<p7ddcfee1.p9405c3af> r5) {
            r4 = this;
            goto L100
        L4:
            r0 = r5
            goto L9
        L9:
            java.util.ICollection r0 = (java.util.ICollection) r0
            goto L8d
        Lf:
            java.net.Proxy$Type r3 = java.net.Proxy.Type.DIRECT
            goto Lef
        L15:
            if (r0 <= 0) goto L1a
            goto L71
        L1a:
            goto L6e
        L1e:
            p7ddcfee1.p9405c3af r2 = r4.f9c46408a
            goto L9a
        L24:
            return r1
        L25:
            goto L66
        L29:
            goto L103
        L2c:
            if (r0 != 0) goto L31
            goto Lab
        L31:
            goto Lf8
        L35:
            java.net.Proxy r2 = r2.proxy()
            goto L85
        L3d:
            r4 = 1
            goto Laa
        L42:
            java.net.Proxy r2 = r0.proxy()
            goto Ld3
        L4a:
            java.lang.IEnumerable r5 = (java.lang.IEnumerable) r5
            goto Lbe
        L50:
            r1 = 6
            goto L107
        L57:
            p7ddcfee1.p9405c3af r2 = r4.f9c46408a
            goto L35
        L5d:
            if (r2 == r3) goto L62
            goto L6a
        L62:
            goto L57
        L66:
            java.util.IEnumerator r5 = r5.GetEnumerator()
        L6a:
            goto L10d
        L6e:
            goto Le4
        L71:
            goto L4a
        L75:
            if (r0 != 0) goto L7a
            goto L25
        L7a:
            goto L24
        L7e:
            r0 = 28
            goto L50
        L85:
            java.net.Proxy$Type r2 = r2.type()
            goto Lf
        L8d:
            bool r0 = r0.Count == 0
            goto L75
        L95:
            r1 = 0
            goto Lb5
        L9a:
            java.net.InetSocketAddress r2 = r2.socketAddress()
            goto Ldb
        La2:
            bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r2, r0)
            goto Lc4
        Laa:
            return r4
        Lab:
            goto Le3
        Laf:
            int r0 = r0 % r1
            goto L15
        Lb5:
            if (r0 != 0) goto Lba
            goto L25
        Lba:
            goto L4
        Lbe:
            bool r0 = r5 is java.util.ICollection
            goto L95
        Lc4:
            if (r0 != 0) goto Lc9
            goto L6a
        Lc9:
            goto L3d
        Lcd:
            java.net.Proxy$Type r3 = java.net.Proxy.Type.DIRECT
            goto L5d
        Ld3:
            java.net.Proxy$Type r2 = r2.type()
            goto Lcd
        Ldb:
            java.net.InetSocketAddress r0 = r0.socketAddress()
            goto La2
        Le3:
            return r1
        Le4:
            goto Le8
        Le8:
            goto L71
        Leb:
            goto L29
        Lef:
            if (r2 == r3) goto Lf4
            goto L6a
        Lf4:
            goto L1e
        Lf8:
            java.lang.object r0 = r5.Current
            goto L115
        L100:
            goto Leb
        L103:
            goto L7e
        L107:
            int r0 = r0 + r1
            goto Laf
        L10d:
            bool r0 = r5.MoveNext()
            goto L2c
        L115:
            p7ddcfee1.p9405c3af r0 = (p7ddcfee1.p9405c3af) r0
            goto L42
    }

    private readonly void StartHttp2(int r8) throws java.io.IOException {
            r7 = this;
            goto Lc4
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1)
            goto Lf9
        Lb:
            r7.ffa584c55 = r0
            goto L27
        L11:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4 r1 = (p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4) r1
            goto L79
        L17:
            int r0 = r0.getMaxConcurrentStreams()
            goto Lb
        L1f:
            p7ddcfee1.pdd7bf230 r5 = r5.address()
            goto Laa
        L27:
            r7 = 0
            goto Lcb
        L2c:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p910eef8c r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.f910eef8c
            goto Ld7
        L32:
            java.lang.string r5 = r5.host()
            goto L81
        L3a:
            r0 = 30
            goto L52
        L41:
            goto Lc7
        L44:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r8 = r8.build()
            goto L59
        L4c:
            java.net.Socket r0 = r7.f61f25293
            goto Lf2
        L52:
            r1 = 9
            goto L6d
        L59:
            r7.fb543e5e3 = r8
            goto L2c
        L5f:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r8 = r0.pingIntervalMillis(r8)
            goto L44
        L67:
            int r0 = r0 % r1
            goto L95
        L6d:
            int r0 = r0 + r1
            goto L67
        L73:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r4 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b
            goto Lb8
        L79:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r0 = r0.listener(r1)
            goto L5f
        L81:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r0 = r4.socket(r0, r5, r1, r2)
            goto L9e
        L89:
            r0.setSoTimeout(r3)
            goto L73
        L90:
            r3 = 0
            goto L89
        L95:
            if (r0 <= 0) goto L9a
            goto Lee
        L9a:
            goto Leb
        L9e:
            r1 = r7
            goto L11
        La3:
            goto Lee
        La6:
            goto L41
        Laa:
            p7ddcfee1.pdfadebdd r5 = r5.url()
            goto L32
        Lb2:
            p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r6 = p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f76425f17
            goto Lff
        Lb8:
            r5 = 1
            goto Lb2
        Lbd:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.start$default(r8, r3, r7, r0, r7)
            goto L106
        Lc4:
            goto La6
        Lc7:
            goto L3a
        Lcb:
            r0 = 3
            goto Lbd
        Ld0:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r2)
            goto L90
        Ld7:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = r0.getDEFAULT_SETTINGS()
            goto L17
        Ldf:
            p7ddcfee1.p9405c3af r5 = r7.f9c46408a
            goto L1f
        Le5:
            p38cb8f46.pcc81e3f6 r1 = r7.f36cd38f4
            goto L4
        Leb:
            goto L107
        Lee:
            goto L4c
        Lf2:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto Le5
        Lf9:
            p38cb8f46.p08d84bc6 r2 = r7.ff6e04117
            goto Ld0
        Lff:
            r4.<init>(r5, r6)
            goto Ldf
        L106:
            return
        L107:
            goto La3
    }

    private readonly bool SupportsUrl(p7ddcfee1.pdfadebdd r5) {
            r4 = this;
            goto L128
        L4:
            bool r4 = r4.certificateSupportHost(r5, r0)
            goto La4
        Lc:
            if (r0 == 0) goto L11
            goto L14c
        L11:
            goto L157
        L15:
            java.lang.AssertionError r5 = new java.lang.AssertionError
            goto L9e
        L1b:
            java.lang.string r1 = r1.getName()
            goto Lfb
        L23:
            if (r0 != 0) goto L28
            goto L70
        L28:
            goto L6e
        L2c:
            int r0 = r0 % r1
            goto L32
        L32:
            if (r0 <= 0) goto L37
            goto L153
        L37:
            goto L150
        L3b:
            p7ddcfee1.p9405c3af r0 = r4.f9c46408a
            goto Ldc
        L41:
            if (r0 != 0) goto L46
            goto L92
        L46:
            goto L91
        L4a:
            bool r0 = java.lang.Thread.holdsLock(r4)
            goto L23
        L52:
            r3 = 0
            goto L88
        L57:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L103
        L5f:
            java.lang.string r4 = r4.tostring()
            goto L79
        L67:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L4
        L6e:
            goto L147
        L70:
            goto L15
        L74:
            return r3
        L75:
            goto L10b
        L79:
            r5.<init>(r4)
            goto L146
        L80:
            r1 = 1
            goto L41
        L85:
            goto L12b
        L88:
            if (r1 != r2) goto L8d
            goto L75
        L8d:
            goto L74
        L91:
            return r1
        L92:
            goto L135
        L96:
            int r2 = r0.port()
            goto L52
        L9e:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L13b
        La4:
            if (r4 != 0) goto La9
            goto L14c
        La9:
            goto L14b
        Lad:
            java.lang.Thread r1 = java.lang.Thread.currentThread()
            goto L1b
        Lb5:
            r0 = 23
            goto L15d
        Lbc:
            bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r1, r0)
            goto L80
        Lc4:
            r0.<init>(r1)
            goto Lad
        Lcb:
            java.lang.string r0 = r0.host()
            goto Lbc
        Ld3:
            if (r0 != 0) goto Ld8
            goto L147
        Ld8:
            goto L4a
        Ldc:
            p7ddcfee1.pdd7bf230 r0 = r0.address()
            goto L119
        Le4:
            bool r0 = p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
            goto Ld3
        Lea:
            if (r0 != 0) goto Lef
            goto L14c
        Lef:
            goto L67
        Lf3:
            int r1 = r5.port()
            goto L96
        Lfb:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L113
        L103:
            java.lang.stringBuilder r4 = r0.append(r4)
            goto L5f
        L10b:
            java.lang.string r1 = r5.host()
            goto Lcb
        L113:
            java.lang.string r1 = " MUST hold lock on "
            goto L57
        L119:
            p7ddcfee1.pdfadebdd r0 = r0.url()
            goto Lf3
        L121:
            goto L153
        L124:
            goto L85
        L128:
            goto L124
        L12b:
            goto Lb5
        L12f:
            int r0 = r0 + r1
            goto L2c
        L135:
            bool r0 = r4.f3bc2d630
            goto Lc
        L13b:
            java.lang.string r1 = "Thread "
            goto Lc4
        L141:
            return r3
        L142:
            goto L121
        L146:
            throw r5
        L147:
            goto L3b
        L14b:
            return r1
        L14c:
            goto L141
        L150:
            goto L142
        L153:
            goto Le4
        L157:
            p7ddcfee1.p7559811a r0 = r4.fb62ddf50
            goto Lea
        L15d:
            r1 = 18
            goto L12f
    }

    public readonly void Cancel() {
            r0 = this;
            goto L27
        L4:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r0)
            goto L19
        Lb:
            goto L2a
        Le:
            return
        Lf:
            goto L4
        L13:
            java.net.Socket r0 = r0.f390f8142
            goto L1e
        L19:
            return
        L1a:
            goto Lb
        L1e:
            if (r0 == 0) goto L23
            goto Lf
        L23:
            goto Le
        L27:
            goto L1a
        L2a:
            goto L13
    }

    public readonly void Connect(int r13, int r14, int r15, int r16, bool r17, p7ddcfee1.pc3755e61 r18, p7ddcfee1.p4f9a1811 r19) {
            r12 = this;
            goto Le7
        L4:
            java.net.Proxy r4 = r0.proxy()
            goto L1e
        Lc:
            p7ddcfee1.pd1efad72.p4717d53e.p0a57af34 r12 = new p7ddcfee1.pd1efad72.p4717d53e.p0a57af34
            goto L1c1
        L12:
            p7ddcfee1.pd1efad72.p4717d53e.p0a57af34 r12 = new p7ddcfee1.pd1efad72.p4717d53e.p0a57af34
            goto L11f
        L18:
            r12.ff6e04117 = r8
            goto L16d
        L1e:
            r5 = 0
            goto L1c7
        L23:
            java.lang.stringBuilder r14 = new java.lang.stringBuilder
            goto Lda
        L29:
            goto L220
        L2b:
            r0 = move-exception
            goto L21f
        L30:
            if (r0 <= 0) goto L35
            goto L249
        L35:
            goto L246
        L39:
            p7ddcfee1.pd1efad72.p4717d53e.p0a57af34 r12 = new p7ddcfee1.pd1efad72.p4717d53e.p0a57af34
            goto L2f5
        L3f:
            p7ddcfee1.p9405c3af r0 = r12.f9c46408a
            goto L78
        L45:
            bool r0 = r0.Contains(r3)
            goto L312
        L4d:
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742$p910eef8c r3 = p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
            goto Ld2
        L53:
            java.io.IOException r13 = (java.io.IOException) r13
            goto L1ed
        L59:
            java.lang.stringBuilder r14 = r14.append(r15)
            goto L3da
        L61:
            java.net.Socket r0 = r12.f390f8142
            goto L97
        L67:
            throw r12
        L68:
            goto Lf3
        L6c:
            p7ddcfee1.p888a77f5 r3 = p7ddcfee1.p888a77f5.ffcc32a7a
            goto L45
        L72:
            r12.f390f8142 = r8
            goto L3ac
        L78:
            p7ddcfee1.pdd7bf230 r0 = r0.address()
            goto L1b1
        L80:
            r2 = r13
            r1.connectTunnel(r2, r3, r4, r5, r6)     // Catch: java.io.IOException -> L266
            goto L241
        L88:
            p7ddcfee1.pdd7bf230 r0 = r0.address()
            goto L2e4
        L90:
            r12.<init>(r13)
            goto L173
        L97:
            if (r0 == 0) goto L9c
            goto L308
        L9c:
            goto L306
        La0:
            if (r3 == 0) goto La5
            goto L68
        La5:
            goto L3b2
        La9:
            r7.<init>(r0)
            goto Lf9
        Lb0:
            java.lang.string r14 = "Too many tunnel connections attempted: 21"
            goto L2c2
        Lb6:
            if (r0 == 0) goto Lbb
            goto L19c
        Lbb:
            goto L19a
        Lbf:
            throw r12
        Lc0:
            goto L1de
        Lc4:
            p7ddcfee1.pdd7bf230 r3 = r3.address()
            goto L3c6
        Lcc:
            java.io.IOException r13 = (java.io.IOException) r13
            goto L2b3
        Ld2:
            p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742 r3 = r3[)
            goto L3b8
        Lda:
            java.lang.string r15 = "CLEARTEXT communication to "
            goto L2dd
        Le0:
            r9.<init>(r6)
            goto L3d4
        Le7:
            goto L1e1
        Lea:
            goto L107
        Lee:
            r6 = r0
            goto L210
        Lf3:
            p7ddcfee1.p9405c3af r0 = r12.f9c46408a
            goto L88
        Lf9:
            p7ddcfee1.p9405c3af r3 = r12.f9c46408a
            goto Lc4
        Lff:
            java.lang.string r13 = r13.tostring()
            goto L1ce
        L107:
            r0 = 13
            goto L1f4
        L10e:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
            goto L2fb
        L115:
            r0 = 1
            goto L369
        L11a:
            r4 = r15
            goto L1ac
        L11f:
            java.net.UnknownServiceException r13 = new java.net.UnknownServiceException
            goto L399
        L125:
            java.lang.string r0 = "call"
            goto L335
        L12b:
            r13.<init>(r14)
            goto L53
        L132:
            p7ddcfee1.p9405c3af r13 = r12.f9c46408a
            goto L233
        L138:
            p7ddcfee1.pd1efad72.p4717d53e.p85246d20 r7 = new p7ddcfee1.pd1efad72.p4717d53e.p85246d20
            goto La9
        L13e:
            r5 = r2
            goto L36f
        L143:
            java.lang.string r14 = "H2_PRIOR_KNOWLEDGE cannot be used with HTTPS"
            goto L2a6
        L149:
            r9 = r8
        L14a:
            p7ddcfee1.p9405c3af r0 = r12.f9c46408a     // Catch: java.io.IOException -> L2b
            bool r0 = r0.requiresTunnel()     // Catch: java.io.IOException -> L2b
            goto L1d5
        L154:
            java.lang.string r0 = "eventListener"
            goto L10e
        L15a:
            r1 = r19
            goto L28d
        L160:
            java.net.Socket r13 = r12.f390f8142
            goto L3e2
        L166:
            r9.addConnectException(r6)
        L169:
            goto L224
        L16d:
            r12.fb62ddf50 = r8
            goto L202
        L173:
            throw r12
        L174:
            goto L320
        L178:
            int r0 = r0 % r1
            goto L30
        L17e:
            r12.fb543e5e3 = r8
            goto L115
        L184:
            r12.<init>(r13)
            goto L34c
        L18b:
            r2 = r18
            goto L384
        L191:
            if (r9 == 0) goto L196
            goto L3d6
        L196:
            goto L2d1
        L19a:
            goto L360
        L19c:
            goto L35d
        L1a0:
            return
        L1a1:
            r0 = move-exception
            goto L29c
        L1a6:
            p7ddcfee1.p9405c3af r0 = r12.f9c46408a
            goto L4
        L1ac:
            r6 = r1
            goto L13e
        L1b1:
            p7ddcfee1.pdfadebdd r0 = r0.url()
            goto L208
        L1b9:
            p7ddcfee1.pdd7bf230 r0 = r0.address()
            goto L2ba
        L1c1:
            java.net.UnknownServiceException r13 = new java.net.UnknownServiceException
            goto L23
        L1c7:
            r1.connectFailed(r2, r3, r4, r5, r6)
            goto L191
        L1ce:
            r12.<init>(r13)
            goto Lbf
        L1d5:
            if (r0 != 0) goto L1da
            goto L26b
        L1da:
            goto L24d
        L1de:
            goto L249
        L1e1:
            goto L2a3
        L1e5:
            long r13 = java.lang.System.nanoTime()
            goto L326
        L1ed:
            r12.<init>(r13)
            goto L67
        L1f4:
            r1 = 4
            goto L252
        L1fb:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r0)
        L1fe:
            goto L357
        L202:
            r12.f81788ba0 = r8
            goto L17e
        L208:
            java.lang.string r0 = r0.host()
            goto L4d
        L210:
            java.net.Socket r0 = r12.f61f25293
            goto Lb6
        L216:
            if (r0 != 0) goto L21b
            goto L28f
        L21b:
            goto L374
        L21f:
            r10 = r14
        L220:
            goto L351
        L224:
            if (r17 != 0) goto L229
            goto L28f
        L229:
            goto L258
        L22d:
            p7ddcfee1.pd1efad72.p4717d53e.p0a57af34 r12 = new p7ddcfee1.pd1efad72.p4717d53e.p0a57af34
            goto L3a6
        L233:
            bool r13 = r13.requiresTunnel()
            goto L293
        L23b:
            goto L317
        L23d:
            goto Lc
        L241:
            r10 = r3
            goto L37a
        L246:
            goto Lc0
        L249:
            goto L18b
        L24d:
            r3 = r14
            goto L11a
        L252:
            int r0 = r0 + r1
            goto L178
        L258:
            bool r0 = r7.connectionFailed(r6)
            goto L216
        L260:
            r1 = r6
            java.net.Socket r0 = r12.f390f8142     // Catch: java.io.IOException -> L29e
            if (r0 != 0) goto L26f
            goto L289
        L266:
            r0 = move-exception
            r10 = r3
            r2 = r5
            r1 = r6
            goto L220
        L26b:
            r10 = r14
            r12.connectSocket(r13, r14, r2, r1)     // Catch: java.io.IOException -> L29e
        L26f:
            goto L273
        L273:
            r11 = r16
            r12.establishProtocol(r7, r11, r2, r1)     // Catch: java.io.IOException -> L1a1
            p7ddcfee1.p9405c3af r0 = r12.f9c46408a     // Catch: java.io.IOException -> L1a1
            java.net.InetSocketAddress r0 = r0.socketAddress()     // Catch: java.io.IOException -> L1a1
            p7ddcfee1.p9405c3af r3 = r12.f9c46408a     // Catch: java.io.IOException -> L1a1
            java.net.Proxy r3 = r3.proxy()     // Catch: java.io.IOException -> L1a1
            p7ddcfee1.p888a77f5 r4 = r12.f81788ba0     // Catch: java.io.IOException -> L1a1
            r1.connectEnd(r2, r0, r3, r4)     // Catch: java.io.IOException -> L1a1
        L289:
            goto L132
        L28d:
            goto L14a
        L28f:
            goto L364
        L293:
            if (r13 != 0) goto L298
            goto L34d
        L298:
            goto L160
        L29c:
            goto L353
        L29e:
            r0 = move-exception
            goto L29
        L2a3:
            goto Lea
        L2a6:
            r13.<init>(r14)
            goto L3ce
        L2ad:
            java.lang.string r13 = "already connected"
            goto Lff
        L2b3:
            r12.<init>(r13)
            goto L31b
        L2ba:
            java.util.List r0 = r0.connectionSpecs()
            goto L138
        L2c2:
            r13.<init>(r14)
            goto L3c0
        L2c9:
            java.lang.stringBuilder r14 = r14.append(r0)
            goto L2d7
        L2d1:
            p7ddcfee1.pd1efad72.p4717d53e.p0a57af34 r9 = new p7ddcfee1.pd1efad72.p4717d53e.p0a57af34
            goto Le0
        L2d7:
            java.lang.string r15 = " not permitted by network security policy"
            goto L59
        L2dd:
            r14.<init>(r15)
            goto L2c9
        L2e4:
            java.util.List r0 = r0.protocols()
            goto L6c
        L2ec:
            if (r0 != 0) goto L2f1
            goto L31c
        L2f1:
            goto L3f
        L2f5:
            java.net.UnknownServiceException r13 = new java.net.UnknownServiceException
            goto L143
        L2fb:
            p7ddcfee1.p888a77f5 r0 = r12.f81788ba0
            goto L390
        L301:
            r8 = 0
            goto L149
        L306:
            goto L1fe
        L308:
            goto L1fb
        L30c:
            p7ddcfee1.p9405c3af r0 = r12.f9c46408a
            goto L1b9
        L312:
            if (r0 == 0) goto L317
            goto L365
        L317:
            goto L301
        L31b:
            throw r12
        L31c:
            goto L12
        L320:
            java.lang.IllegalStateException r12 = new java.lang.IllegalStateException
            goto L2ad
        L326:
            r12.fda2bfd22 = r13
            goto L1a0
        L32c:
            if (r3 != 0) goto L331
            goto L23d
        L331:
            goto L23b
        L335:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L154
        L33c:
            java.net.InetSocketAddress r3 = r0.socketAddress()
            goto L1a6
        L344:
            bool r0 = r0.Contains(r3)
            goto L2ec
        L34c:
            throw r12
        L34d:
            goto L1e5
        L351:
            r11 = r16
        L353:
            goto Lee
        L357:
            r12.f61f25293 = r8
            goto L72
        L35d:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r0)
        L360:
            goto L61
        L364:
            throw r9
        L365:
            goto L39
        L369:
            r12.ffa584c55 = r0
            goto L38a
        L36f:
            r1 = r12
            goto L80
        L374:
            r2 = r18
            goto L15a
        L37a:
            r2 = r5
            goto L260
        L37f:
            goto L34d
        L380:
            goto L22d
        L384:
            r1 = r19
            goto L125
        L38a:
            p7ddcfee1.p9405c3af r0 = r12.f9c46408a
            goto L33c
        L390:
            if (r0 == 0) goto L395
            goto L174
        L395:
            goto L30c
        L399:
            java.lang.string r14 = "CLEARTEXT communication not enabled for client"
            goto L12b
        L39f:
            r13.<init>(r14)
            goto Lcc
        L3a6:
            java.net.ProtocolException r13 = new java.net.ProtocolException
            goto Lb0
        L3ac:
            r12.f36cd38f4 = r8
            goto L18
        L3b2:
            p7ddcfee1.p43967033 r3 = p7ddcfee1.p43967033.f947e023d
            goto L344
        L3b8:
            bool r3 = r3.isCleartextTrafficPermitted(r0)
            goto L32c
        L3c0:
            java.io.IOException r13 = (java.io.IOException) r13
            goto L184
        L3c6:
            javax.net.ssl.SSLSocketFactory r3 = r3.sslSocketFactory()
            goto La0
        L3ce:
            java.io.IOException r13 = (java.io.IOException) r13
            goto L90
        L3d4:
            goto L169
        L3d6:
            goto L166
        L3da:
            java.lang.string r14 = r14.tostring()
            goto L39f
        L3e2:
            if (r13 != 0) goto L3e7
            goto L380
        L3e7:
            goto L37f
    }

    public readonly void connectFailed$okhttp(p7ddcfee1.p1cda7fcc r3, p7ddcfee1.p9405c3af r4, java.io.IOException r5) {
            r2 = this;
            goto L72
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r2)
            goto Lc4
        Lb:
            p7ddcfee1.pd1efad72.p4717d53e.pe81f325d r2 = r3.getRouteDatabase()
            goto L1a
        L13:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r2)
            goto L8d
        L1a:
            r2.failed(r4)
            goto L88
        L21:
            r0 = 21
            goto L30
        L28:
            p7ddcfee1.pdfadebdd r2 = r2.url()
            goto L45
        L30:
            r1 = 20
            goto Lb1
        L37:
            goto L89
        L3a:
            goto Lca
        L3e:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r2)
            goto Lbe
        L45:
            java.net.Uri r2 = r2.uri()
            goto L62
        L4d:
            int r0 = r0 % r1
            goto La8
        L53:
            if (r2 != r0) goto L58
            goto L7c
        L58:
            goto L9d
        L5c:
            java.net.Proxy$Type r0 = java.net.Proxy.Type.DIRECT
            goto L53
        L62:
            java.net.Proxy r1 = r4.proxy()
            goto L95
        L6a:
            java.net.ProxySelector r0 = r2.proxySelector()
            goto L28
        L72:
            goto Lba
        L75:
            goto L21
        L79:
            r0.connectFailed(r2, r1, r5)
        L7c:
            goto Lb
        L80:
            java.net.Proxy$Type r2 = r2.type()
            goto L5c
        L88:
            return
        L89:
            goto Lb7
        L8d:
            java.net.Proxy r2 = r4.proxy()
            goto L80
        L95:
            java.net.SocketAddress r1 = r1.address()
            goto L79
        L9d:
            p7ddcfee1.pdd7bf230 r2 = r4.address()
            goto L6a
        La5:
            goto L75
        La8:
            if (r0 <= 0) goto Lad
            goto L3a
        Lad:
            goto L37
        Lb1:
            int r0 = r0 + r1
            goto L4d
        Lb7:
            goto L3a
        Lba:
            goto La5
        Lbe:
            java.lang.string r2 = "failure"
            goto L13
        Lc4:
            java.lang.string r2 = "failedRoute"
            goto L3e
        Lca:
            java.lang.string r2 = "client"
            goto L4
    }

    public readonly java.util.List<java.lang.ref.Reference<p7ddcfee1.pd1efad72.p4717d53e.p6d310f89>> GetCalls() {
            r0 = this;
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
            java.util.List<java.lang.ref.Reference<p7ddcfee1.pd1efad72.p4717d53e.p6d310f89>> r0 = r0.ff2bb91e8
            goto L4
        L16:
            goto Lc
    }

    public readonly p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 GetConnectionPool() {
            r0 = this;
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
            p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 r0 = r0.f99874bde
            goto Le
    }

    public readonly long getIdleAtNs$okhttp() {
            r2 = this;
            goto L4
        L4:
            goto L19
        L7:
            goto L3d
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            long r0 = r2.fda2bfd22
            goto Lb
        L16:
            goto L27
        L19:
            goto L2b
        L1d:
            r1 = 22
            goto L2e
        L24:
            goto Lc
        L27:
            goto L10
        L2b:
            goto L7
        L2e:
            int r0 = r0 + r1
            goto L44
        L34:
            if (r0 <= 0) goto L39
            goto L27
        L39:
            goto L24
        L3d:
            r0 = 25
            goto L1d
        L44:
            int r0 = r0 % r1
            goto L34
    }

    public readonly bool GetNoNewExchanges() {
            r0 = this;
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
            bool r0 = r0.f1f51ecec
            goto Lb
    }

    public readonly int getRouteFailureCount$okhttp() {
            r0 = this;
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
            int r0 = r0.fff37afed
            goto L7
    }

    @Override // p7ddcfee1.pc2cc7082
    public p7ddcfee1.p7559811a Handshake() {
            r0 = this;
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
            p7ddcfee1.p7559811a r0 = r0.fb62ddf50
            goto Le
    }

    public readonly void incrementSuccessCount$okhttp() {
            r1 = this;
            goto L13
        L4:
            throw r0
        L5:
            goto L10
        L9:
            return
        La:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L1f
        L1a:
            monitor-exit(r1)
            goto L9
        L1f:
            monitor-enter(r1)
            int r0 = r1.f0d8f2499     // Catch: java.lang.Exception -> La
            int r0 = r0 + 1
            r1.f0d8f2499 = r0     // Catch: java.lang.Exception -> La
            goto L1a
    }

    public readonly bool isEligible$okhttp(p7ddcfee1.pdd7bf230 r4, java.util.List<p7ddcfee1.p9405c3af> r5) {
            r3 = this;
            goto L117
        L4:
            return r2
        L5:
            goto L15f
        L9:
            goto L11a
        Lc:
            if (r0 <= 0) goto L11
            goto Le9
        L11:
            goto Le6
        L15:
            java.lang.AssertionError r4 = new java.lang.AssertionError
            goto Lfd
        L1b:
            bool r0 = java.lang.Thread.holdsLock(r3)
            goto L199
        L23:
            int r0 = r0 % r1
            goto Lc
        L29:
            if (r0 == 0) goto L2e
            goto Lbe
        L2e:
            goto Lbd
        L32:
            java.util.List<java.lang.ref.Reference<p7ddcfee1.pd1efad72.p4717d53e.p6d310f89>> r0 = r3.ff2bb91e8
            goto Lf5
        L38:
            r0 = 9
            goto L192
        L3f:
            return r1
        L40:
            goto L202
        L44:
            java.lang.string r0 = r0.host()
            goto L51
        L4c:
            return r1
        L4d:
            goto L59
        L51:
            p7ddcfee1.p9405c3af r1 = r3.route()
            goto L171
        L59:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r3.fb543e5e3
            goto L156
        L5f:
            p7ddcfee1.pdfadebdd r0 = r4.url()
            goto L44
        L67:
            r1 = 1
            goto L1a2
        L6c:
            java.lang.string r0 = " MUST hold lock on "
            goto L11e
        L72:
            java.lang.string r0 = "address"
            goto L1b9
        L78:
            goto Le9
        L7b:
            goto L9
        L7f:
            p7ddcfee1.pdd7bf230 r0 = r0.address()
            goto Lca
        L87:
            java.lang.string r0 = "Thread "
            goto L142
        L8d:
            javax.net.ssl.HostnameVerifier r5 = r4.hostnameVerifier()
            goto Lb7
        L95:
            return r2
        L96:
            p7ddcfee1.pd299aac3 r5 = r4.certificatePinner()     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            kotlin.jvm.internal.Intrinsics.checkNotNull(r5)     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            p7ddcfee1.pdfadebdd r4 = r4.url()     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            java.lang.string r4 = r4.host()     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            p7ddcfee1.p7559811a r3 = r3.handshake()     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            kotlin.jvm.internal.Intrinsics.checkNotNull(r3)     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            java.util.List r3 = r3.peerCertificates()     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            r5.check(r4, r3)     // Catch: javax.net.ssl.SSLPeerUnverifiedException -> L40
            goto L3f
        Lb7:
            p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac r0 = p7ddcfee1.pd1efad72.pa60aeea3.pc10505ac.f76425f17
            goto L181
        Lbd:
            return r2
        Lbe:
            goto L5f
        Lc2:
            bool r5 = r3.routeMatchesAny(r5)
            goto L1f0
        Lca:
            bool r0 = r0.equalsNonHost$okhttp(r4)
            goto L29
        Ld2:
            goto L40
        Ld4:
            goto L8d
        Ld8:
            if (r0 < r1) goto Ldd
            goto L40
        Ldd:
            goto L103
        Le1:
            goto L113
        Le2:
            goto L15
        Le6:
            goto L203
        Le9:
            goto L72
        Led:
            java.lang.stringBuilder r5 = r5.append(r0)
            goto L6c
        Lf5:
            int r0 = r0.Count
            goto L1b3
        Lfd:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L87
        L103:
            bool r0 = r3.f1f51ecec
            goto L1f9
        L109:
            if (r5 == 0) goto L10e
            goto L96
        L10e:
            goto L95
        L112:
            throw r4
        L113:
            goto L32
        L117:
            goto L7b
        L11a:
            goto L38
        L11e:
            java.lang.stringBuilder r5 = r5.append(r0)
            goto L18a
        L126:
            java.lang.Thread r0 = java.lang.Thread.currentThread()
            goto L13a
        L12e:
            bool r0 = p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
            goto L168
        L134:
            int r0 = r0 + r1
            goto L23
        L13a:
            java.lang.string r0 = r0.getName()
            goto Led
        L142:
            r5.<init>(r0)
            goto L126
        L149:
            return r2
        L14a:
            goto L1e0
        L14e:
            p7ddcfee1.pdfadebdd r1 = r1.url()
            goto L1d2
        L156:
            if (r0 == 0) goto L15b
            goto L5
        L15b:
            goto L4
        L15f:
            if (r5 != 0) goto L164
            goto L40
        L164:
            goto Lc2
        L168:
            if (r0 != 0) goto L16d
            goto L113
        L16d:
            goto L1b
        L171:
            p7ddcfee1.pdd7bf230 r1 = r1.address()
            goto L14e
        L179:
            java.lang.string r3 = r3.tostring()
            goto L1cb
        L181:
            if (r5 != r0) goto L186
            goto L14a
        L186:
            goto L149
        L18a:
            java.lang.stringBuilder r3 = r5.append(r3)
            goto L179
        L192:
            r1 = 4
            goto L134
        L199:
            if (r0 != 0) goto L19e
            goto Le2
        L19e:
            goto Le1
        L1a2:
            if (r0 != 0) goto L1a7
            goto L4d
        L1a7:
            goto L4c
        L1ab:
            bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r0, r1)
            goto L67
        L1b3:
            int r1 = r3.ffa584c55
            goto L1c0
        L1b9:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto L12e
        L1c0:
            r2 = 0
            goto Ld8
        L1c5:
            p7ddcfee1.p9405c3af r0 = r3.f9c46408a
            goto L7f
        L1cb:
            r4.<init>(r3)
            goto L112
        L1d2:
            java.lang.string r1 = r1.host()
            goto L1ab
        L1da:
            goto L40
        L1dc:
            goto L1c5
        L1e0:
            p7ddcfee1.pdfadebdd r5 = r4.url()
            goto L1e8
        L1e8:
            bool r5 = r3.supportsUrl(r5)
            goto L109
        L1f0:
            if (r5 == 0) goto L1f5
            goto Ld4
        L1f5:
            goto Ld2
        L1f9:
            if (r0 != 0) goto L1fe
            goto L1dc
        L1fe:
            goto L1da
        L202:
            return r2
        L203:
            goto L78
    }

    public readonly bool IsHealthy(bool r8) {
            r7 = this;
            goto L6a
        L4:
            bool r2 = r3.isOutputShutdown()
            goto L151
        Lc:
            r0.<init>(r1)
            goto L90
        L13:
            r8.<init>(r7)
            goto L8b
        L1a:
            monitor-enter(r7)
            long r5 = r7.getIdleAtNs$okhttp()     // Catch: java.lang.Exception -> L1af
            goto Lfc
        L23:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L101
        L2b:
            r1 = 1
            goto Ld9
        L32:
            bool r7 = p7ddcfee1.pd1efad72.p23e8a4b4.isHealthy(r3, r4)
            goto L134
        L3a:
            goto L13c
        L3d:
            goto L58
        L41:
            r7 = 1
            goto L1ae
        L46:
            return r7
        L47:
            goto L1a
        L4b:
            monitor-exit(r7)
            goto Lb4
        L50:
            long r0 = java.lang.System.nanoTime()
            goto Lae
        L58:
            goto L6d
        L5b:
            if (r2 == 0) goto L60
            goto Lb5
        L60:
            goto Ldf
        L64:
            java.net.Socket r3 = r7.f61f25293
            goto L9e
        L6a:
            goto L3d
        L6d:
            goto L16e
        L71:
            if (r2 == 0) goto L76
            goto Lb5
        L76:
            goto L4
        L7a:
            bool r2 = r2.isClosed()
            goto L1a5
        L82:
            if (r2 != 0) goto L87
            goto L47
        L87:
            goto L124
        L8b:
            throw r8
        L8c:
            goto L50
        L90:
            java.lang.Thread r1 = java.lang.Thread.currentThread()
            goto Le7
        L98:
            int r0 = r0 % r1
            goto La5
        L9e:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r3)
            goto L145
        La5:
            if (r0 <= 0) goto Laa
            goto L13c
        Laa:
            goto L139
        Lae:
            java.net.Socket r2 = r7.f390f8142
            goto L10d
        Lb4:
            throw r8
        Lb5:
            goto L15a
        Lb9:
            monitor-exit(r7)
            goto L15f
        Lbe:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2 = r7.fb543e5e3
            goto L82
        Lc4:
            int r7 = (r0 > r5 ? 1 : (r0 == r5 ? 0 : -1))
            goto L17e
        Lca:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L19f
        Ld0:
            if (r0 == 0) goto Ld5
            goto L16a
        Ld5:
            goto L168
        Ld9:
            int r0 = r0 + r1
            goto L98
        Ldf:
            bool r2 = r3.isInputShutdown()
            goto L71
        Le7:
            java.lang.string r1 = r1.getName()
            goto L23
        Lef:
            bool r2 = r3.isClosed()
            goto L5b
        Lf7:
            goto Lb5
        Lf8:
            goto Lbe
        Lfc:
            long r0 = r0 - r5
            goto Lb9
        L101:
            java.lang.string r1 = " MUST NOT hold lock on "
            goto L11c
        L107:
            bool r0 = p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
            goto L175
        L10d:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r2)
            goto L64
        L114:
            java.lang.stringBuilder r7 = r0.append(r7)
            goto L12c
        L11c:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L114
        L124:
            bool r7 = r2.isHealthy(r0)
            goto L46
        L12c:
            java.lang.string r7 = r7.tostring()
            goto L13
        L134:
            return r7
        L135:
            goto L41
        L139:
            goto L141
        L13c:
            goto L107
        L140:
            return r7
        L141:
            goto L3a
        L145:
            p38cb8f46.pcc81e3f6 r4 = r7.f36cd38f4
            goto L190
        L14b:
            java.lang.AssertionError r8 = new java.lang.AssertionError
            goto Lca
        L151:
            if (r2 != 0) goto L156
            goto Lf8
        L156:
            goto Lf7
        L15a:
            r7 = 0
            goto L140
        L15f:
            r5 = 10000000000(0x2540be400, double:4.9406564584E-314)
            goto Lc4
        L168:
            goto L8c
        L16a:
            goto L14b
        L16e:
            r0 = 6
            goto L2b
        L175:
            if (r0 != 0) goto L17a
            goto L8c
        L17a:
            goto L197
        L17e:
            if (r7 >= 0) goto L183
            goto L135
        L183:
            goto L187
        L187:
            if (r8 != 0) goto L18c
            goto L135
        L18c:
            goto L32
        L190:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r4)
            goto L7a
        L197:
            bool r0 = java.lang.Thread.holdsLock(r7)
            goto Ld0
        L19f:
            java.lang.string r1 = "Thread "
            goto Lc
        L1a5:
            if (r2 == 0) goto L1aa
            goto Lb5
        L1aa:
            goto Lef
        L1ae:
            return r7
        L1af:
            r8 = move-exception
            goto L4b
    }

    public readonly bool isMultiplexed$okhttp() {
            r0 = this;
            goto L4
        L4:
            goto L28
        L7:
            goto L21
        Lb:
            return r0
        Lc:
            goto L2c
        L10:
            r0 = 1
            goto Lb
        L15:
            if (r0 != 0) goto L1a
            goto Lc
        L1a:
            goto L10
        L1e:
            goto L7
        L21:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r0.fb543e5e3
            goto L15
        L27:
            return r0
        L28:
            goto L1e
        L2c:
            r0 = 0
            goto L27
    }

    public readonly p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c newCodec$okhttp(p7ddcfee1.p1cda7fcc r7, p7ddcfee1.pd1efad72.p80791b3a.pf1d5187f r8) throws java.net.SocketException {
            r6 = this;
            goto Lc9
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r7, r0)
            goto L56
        Lb:
            java.net.Socket r0 = r6.f61f25293
            goto L90
        L11:
            r8.<init>(r7, r6, r1, r2)
            goto L77
        L18:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1)
            goto L101
        L1f:
            p38cb8f46.pcc81e3f6 r1 = r6.f36cd38f4
            goto L18
        L25:
            int r3 = r8.readTimeoutMillis()
            goto Lc2
        L2d:
            int r8 = r8.getWriteTimeoutMillis$okhttp()
            goto L97
        L35:
            goto Lb6
        L38:
            goto L43
        L3c:
            r0.timeout(r3, r8)
            goto L84
        L43:
            java.lang.string r0 = "client"
            goto L4
        L49:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r8, r0)
            goto Lb
        L50:
            java.util.concurrent.TimeUnit r8 = java.util.concurrent.TimeUnit.MILLISECONDS
            goto L3c
        L56:
            java.lang.string r0 = "chain"
            goto L49
        L5c:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r2)
            goto Lee
        L63:
            p38cb8f46.pc85a251c r0 = r2.timeout()
            goto L2d
        L6b:
            long r3 = (long) r3
            goto L107
        L70:
            r1 = 25
            goto Ld8
        L77:
            p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c r8 = (p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c) r8
            goto Lb5
        L7d:
            r0.<init>(r7, r6, r8, r3)
            goto Lfb
        L84:
            p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c r8 = new p7ddcfee1.pd1efad72.pf3387e2d.p2bfb7a6c
            goto L11
        L8a:
            int r0 = r0 % r1
            goto Lde
        L90:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L1f
        L97:
            long r3 = (long) r8
            goto L50
        L9c:
            r0 = 32
            goto L70
        La3:
            p7ddcfee1.pd1efad72.p3cb89a9f.p900e8231 r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p900e8231
            goto L7d
        La9:
            goto Lcc
        Lac:
            if (r3 != 0) goto Lb1
            goto L10e
        Lb1:
            goto La3
        Lb5:
            return r8
        Lb6:
            goto Lf4
        Lba:
            p38cb8f46.pc85a251c r0 = r1.timeout()
            goto Ld0
        Lc2:
            r0.setSoTimeout(r3)
            goto Lba
        Lc9:
            goto Lf7
        Lcc:
            goto L9c
        Ld0:
            int r3 = r8.getReadTimeoutMillis$okhttp()
            goto L6b
        Ld8:
            int r0 = r0 + r1
            goto L8a
        Lde:
            if (r0 <= 0) goto Le3
            goto L38
        Le3:
            goto L35
        Le7:
            r0.timeout(r3, r5)
            goto L63
        Lee:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r3 = r6.fb543e5e3
            goto Lac
        Lf4:
            goto L38
        Lf7:
            goto La9
        Lfb:
            p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c r0 = (p7ddcfee1.pd1efad72.p80791b3a.p6eed9b4c) r0
            goto L10d
        L101:
            p38cb8f46.p08d84bc6 r2 = r6.ff6e04117
            goto L5c
        L107:
            java.util.concurrent.TimeUnit r5 = java.util.concurrent.TimeUnit.MILLISECONDS
            goto Le7
        L10d:
            return r0
        L10e:
            goto L25
    }

    public readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64 newWebSocketStreams$okhttp(p7ddcfee1.pd1efad72.p4717d53e.p992374d8 r5) throws java.net.SocketException {
            r4 = this;
            goto L68
        L4:
            return r4
        L5:
            goto L78
        L9:
            r4.noNewExchanges$okhttp()
            goto L1c
        L10:
            p38cb8f46.pcc81e3f6 r1 = r4.f36cd38f4
            goto L2e
        L16:
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p21b3cb64 r4 = (p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64) r4
            goto L4
        L1c:
            p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p8e9eb110$1 r4 = new p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60$p8e9eb110$1
            goto L27
        L22:
            r3 = 0
            goto L90
        L27:
            r4.<init>(r1, r2, r5)
            goto L16
        L2e:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1)
            goto L42
        L35:
            r1 = 12
            goto L55
        L3c:
            java.net.Socket r0 = r4.f61f25293
            goto L7f
        L42:
            p38cb8f46.p08d84bc6 r2 = r4.ff6e04117
            goto L61
        L48:
            java.lang.string r0 = "exchange"
            goto L89
        L4e:
            r0 = 19
            goto L35
        L55:
            int r0 = r0 + r1
            goto L5b
        L5b:
            int r0 = r0 % r1
            goto L6f
        L61:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r2)
            goto L22
        L68:
            goto L7b
        L6b:
            goto L4e
        L6f:
            if (r0 <= 0) goto L74
            goto L9a
        L74:
            goto L97
        L78:
            goto L9a
        L7b:
            goto L86
        L7f:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L10
        L86:
            goto L6b
        L89:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto L3c
        L90:
            r0.setSoTimeout(r3)
            goto L9
        L97:
            goto L5
        L9a:
            goto L48
    }

    public readonly void noCoalescedConnections$okhttp() {
            r1 = this;
            goto L4
        L4:
            goto L1d
        L7:
            goto Lb
        Lb:
            monitor-enter(r1)
            goto L15
        L10:
            monitor-exit(r1)
            goto L21
        L15:
            r0 = 1
            r1.f3bc2d630 = r0     // Catch: java.lang.Exception -> L22
            goto L10
        L1c:
            throw r0
        L1d:
            goto L28
        L21:
            return
        L22:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L22
            goto L1c
        L28:
            goto L7
    }

    public readonly void noNewExchanges$okhttp() {
            r1 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto L1c
        Lb:
            monitor-exit(r1)
            goto L15
        L10:
            throw r0
        L11:
            goto L21
        L15:
            return
        L16:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L16
            goto L10
        L1c:
            monitor-enter(r1)
            goto L24
        L21:
            goto L7
        L24:
            r0 = 1
            r1.f1f51ecec = r0     // Catch: java.lang.Exception -> L16
            goto Lb
    }

    @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4
    public void OnHashSettings(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2, p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r3) {
            r1 = this;
            goto L2d
        L4:
            monitor-enter(r1)
            java.lang.string r0 = "connection"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)     // Catch: java.lang.Exception -> L22
            java.lang.string r2 = "settings"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r2)     // Catch: java.lang.Exception -> L22
            int r2 = r3.getMaxConcurrentStreams()     // Catch: java.lang.Exception -> L22
            r1.ffa584c55 = r2     // Catch: java.lang.Exception -> L22
            goto L28
        L19:
            throw r2
        L1a:
            goto L1e
        L1e:
            goto L30
        L21:
            return
        L22:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L22
            goto L19
        L28:
            monitor-exit(r1)
            goto L21
        L2d:
            goto L1a
        L30:
            goto L4
    }

    @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4
    public void OnStream(p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r2) throws java.io.IOException {
            r1 = this;
            goto Lf
        L4:
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r1 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc
            goto La
        La:
            r0 = 0
            goto L22
        Lf:
            goto L1e
        L12:
            goto L29
        L16:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r1)
            goto L4
        L1d:
            return
        L1e:
            goto L2f
        L22:
            r2.close(r1, r0)
            goto L1d
        L29:
            java.lang.string r1 = "stream"
            goto L16
        L2f:
            goto L12
    }

    @Override // p7ddcfee1.pc2cc7082
    public p7ddcfee1.p888a77f5 Protocol() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            p7ddcfee1.p888a77f5 r0 = r0.f81788ba0
            goto L19
        L14:
            return r0
        L15:
            goto L4
        L19:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L14
    }

    @Override // p7ddcfee1.pc2cc7082
    public p7ddcfee1.p9405c3af Route() {
            r0 = this;
            goto Lf
        L4:
            return r0
        L5:
            goto L16
        L9:
            p7ddcfee1.p9405c3af r0 = r0.f9c46408a
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    public readonly void setIdleAtNs$okhttp(long r1) {
            r0 = this;
            goto Lf
        L4:
            return
        L5:
            goto L16
        L9:
            r0.fda2bfd22 = r1
            goto L4
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            goto L12
    }

    public readonly void SetNoNewExchanges(bool r1) {
            r0 = this;
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
            r0.f1f51ecec = r1
            goto Lb
    }

    public readonly void setRouteFailureCount$okhttp(int r1) {
            r0 = this;
            goto Lf
        L4:
            r0.fff37afed = r1
            goto La
        La:
            return
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            goto L12
    }

    @Override // p7ddcfee1.pc2cc7082
    public java.net.Socket Socket() {
            r0 = this;
            goto L11
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L18
        Lb:
            java.net.Socket r0 = r0.f61f25293
            goto L4
        L11:
            goto L19
        L14:
            goto Lb
        L18:
            return r0
        L19:
            goto L1d
        L1d:
            goto L14
    }

    public java.lang.string Tostring() {
            r3 = this;
            goto L6d
        L4:
            r1 = 3
            goto L8a
        Lb:
            int r0 = r0 % r1
            goto L17
        L11:
            p7ddcfee1.p9405c3af r1 = r3.f9c46408a
            goto Lcf
        L17:
            if (r0 <= 0) goto L1c
            goto Lef
        L1c:
            goto Lec
        L20:
            r0 = 125(0x7d, float:1.75E-43)
            goto Laa
        L26:
            if (r1 == 0) goto L2b
            goto La6
        L2b:
            goto La4
        L2f:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L96
        L37:
            java.lang.string r1 = " hostAddress="
            goto Lf9
        L3d:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L37
        L45:
            p7ddcfee1.pdfadebdd r1 = r1.url()
            goto L9c
        L4d:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto Lde
        L55:
            java.lang.stringBuilder r0 = r0.append(r2)
            goto L79
        L5d:
            java.lang.string r2 = com.decryptstringmanager.Decryptstring.decryptstring(r2)
            goto L170
        L65:
            java.lang.string r1 = r1.host()
            goto L2f
        L6d:
            goto L160
        L70:
            goto L10f
        L74:
            return r3
        L75:
            goto L15d
        L79:
            java.lang.string r1 = " protocol="
            goto L145
        L7f:
            goto L70
        L82:
            p7ddcfee1.pdd7bf230 r1 = r1.address()
            goto L45
        L8a:
            int r0 = r0 + r1
            goto Lb
        L90:
            goto L133
        L92:
            goto L11c
        L96:
            r1 = 58
            goto L4d
        L9c:
            int r1 = r1.port()
            goto L14d
        La4:
            goto L133
        La6:
            goto L132
        Laa:
            java.lang.stringBuilder r3 = r3.append(r0)
            goto Le4
        Lb2:
            p7ddcfee1.pdfadebdd r1 = r1.url()
            goto L65
        Lba:
            java.net.InetSocketAddress r1 = r1.socketAddress()
            goto L155
        Lc2:
            java.lang.string r2 = "08cf4ed7854189c673ccf35da5df5c08f609057dca9717deee66aee7ef543047"
            goto L5d
        Lc9:
            java.lang.string r1 = ", proxy="
            goto L179
        Lcf:
            p7ddcfee1.pdd7bf230 r1 = r1.address()
            goto Lb2
        Ld7:
            r0.<init>(r1)
            goto L11
        Lde:
            p7ddcfee1.p9405c3af r1 = r3.f9c46408a
            goto L82
        Le4:
            java.lang.string r3 = r3.tostring()
            goto L74
        Lec:
            goto L75
        Lef:
            goto L13f
        Lf3:
            p7ddcfee1.p888a77f5 r3 = r3.f81788ba0
            goto L137
        Lf9:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L12c
        L101:
            java.lang.string r1 = "Connection{"
            goto Ld7
        L107:
            java.net.Proxy r1 = r1.proxy()
            goto L3d
        L10f:
            r0 = 28
            goto L4
        L116:
            p7ddcfee1.p7559811a r1 = r3.fb62ddf50
            goto Lc2
        L11c:
            p7ddcfee1.p4e56d02a r1 = r1.cipherSuite()
            goto L26
        L124:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L116
        L12c:
            p7ddcfee1.p9405c3af r1 = r3.f9c46408a
            goto Lba
        L132:
            r2 = r1
        L133:
            goto L55
        L137:
            java.lang.stringBuilder r3 = r0.append(r3)
            goto L20
        L13f:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L101
        L145:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto Lf3
        L14d:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto Lc9
        L155:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L16a
        L15d:
            goto Lef
        L160:
            goto L7f
        L164:
            p7ddcfee1.p9405c3af r1 = r3.f9c46408a
            goto L107
        L16a:
            java.lang.string r1 = " cipherSuite="
            goto L124
        L170:
            if (r1 == 0) goto L175
            goto L92
        L175:
            goto L90
        L179:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L164
    }

    public readonly void trackFailure$okhttp(p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 r4, java.io.IOException r5) {
            r3 = this;
            goto L99
        L4:
            r0 = 7
            goto L14
        Lb:
            if (r0 <= 0) goto L10
            goto La3
        L10:
            goto La0
        L14:
            r1 = 16
            goto L1e
        L1b:
            goto L9c
        L1e:
            int r0 = r0 + r1
            goto L30
        L24:
            return
        L25:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L25
            goto L2b
        L2b:
            throw r4
        L2c:
            goto La7
        L30:
            int r0 = r0 % r1
            goto Lb
        L36:
            monitor-exit(r3)
            goto L24
        L3b:
            monitor-enter(r3)
            java.lang.string r0 = "call"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)     // Catch: java.lang.Exception -> L25
            bool r0 = r5 is p7ddcfee1.pd1efad72.p3cb89a9f.p1bf03f78     // Catch: java.lang.Exception -> L25
            r1 = 1
            if (r0 == 0) goto L75
            r0 = r5
            p7ddcfee1.pd1efad72.p3cb89a9f.p1bf03f78 r0 = (p7ddcfee1.pd1efad72.p3cb89a9f.p1bf03f78) r0     // Catch: java.lang.Exception -> L25
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = r0.f0279985c     // Catch: java.lang.Exception -> L25
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r2 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc     // Catch: java.lang.Exception -> L25
            if (r0 != r2) goto L5e
            int r4 = r3.f0f99335f     // Catch: java.lang.Exception -> L25
            int r4 = r4 + r1
            r3.f0f99335f = r4     // Catch: java.lang.Exception -> L25
            if (r4 <= r1) goto L95
            r3.f1f51ecec = r1     // Catch: java.lang.Exception -> L25
            int r4 = r3.fff37afed     // Catch: java.lang.Exception -> L25
            int r4 = r4 + r1
            r3.fff37afed = r4     // Catch: java.lang.Exception -> L25
            goto L95
        L5e:
            p7ddcfee1.pd1efad72.p3cb89a9f.p1bf03f78 r5 = (p7ddcfee1.pd1efad72.p3cb89a9f.p1bf03f78) r5     // Catch: java.lang.Exception -> L25
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r5 = r5.f0279985c     // Catch: java.lang.Exception -> L25
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027     // Catch: java.lang.Exception -> L25
            if (r5 != r0) goto L6d
            bool r4 = r4.isCanceled()     // Catch: java.lang.Exception -> L25
            if (r4 == 0) goto L6d
            goto L95
        L6d:
            r3.f1f51ecec = r1     // Catch: java.lang.Exception -> L25
            int r4 = r3.fff37afed     // Catch: java.lang.Exception -> L25
            int r4 = r4 + r1
            r3.fff37afed = r4     // Catch: java.lang.Exception -> L25
            goto L95
        L75:
            bool r0 = r3.isMultiplexed$okhttp()     // Catch: java.lang.Exception -> L25
            if (r0 == 0) goto L7f
            bool r0 = r5 is p7ddcfee1.pd1efad72.p3cb89a9f.p0172e76e     // Catch: java.lang.Exception -> L25
            if (r0 == 0) goto L95
        L7f:
            r3.f1f51ecec = r1     // Catch: java.lang.Exception -> L25
            int r0 = r3.f0d8f2499     // Catch: java.lang.Exception -> L25
            if (r0 != 0) goto L95
            if (r5 == 0) goto L90
            p7ddcfee1.p1cda7fcc r4 = r4.getClient()     // Catch: java.lang.Exception -> L25
            p7ddcfee1.p9405c3af r0 = r3.f9c46408a     // Catch: java.lang.Exception -> L25
            r3.connectFailed$okhttp(r4, r0, r5)     // Catch: java.lang.Exception -> L25
        L90:
            int r4 = r3.fff37afed     // Catch: java.lang.Exception -> L25
            int r4 = r4 + r1
            r3.fff37afed = r4     // Catch: java.lang.Exception -> L25
        L95:
            goto L36
        L99:
            goto Laa
        L9c:
            goto L4
        La0:
            goto L2c
        La3:
            goto L3b
        La7:
            goto La3
        Laa:
            goto L1b
    }
}

