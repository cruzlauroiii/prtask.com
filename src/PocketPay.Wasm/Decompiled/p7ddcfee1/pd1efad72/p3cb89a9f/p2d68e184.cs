namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000´\u0001\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010#\n\u0002\u0010\b\n\u0002\b\f\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u001d\n\u0002\u0018\u0002\n\u0002\b\u0014\u0018\u0000 \u0099\u00012\u00020\u0001:\b\u0098\u0001\u0099\u0001\u009a\u0001\u009b\u0001B\u000f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0006\u0010P\u001a\u00020QJ\b\u0010R\u001a\u00020QH\u0016J'\u0010R\u001a\u00020Q2\u0006\u0010S\u001a\u00020T2\u0006\u0010U\u001a\u00020T2\b\u0010V\u001a\u0004\u0018\u00010WH\u0000¢\u0006\u0002\bXJ\u0012\u0010Y\u001a\u00020Q2\b\u0010Z\u001a\u0004\u0018\u00010WH\u0002J\u0006\u0010[\u001a\u00020QJ\u0010\u0010\\\u001a\u0004\u0018\u00010B2\u0006\u0010]\u001a\u00020\u0012J\u000e\u0010^\u001a\u00020\t2\u0006\u0010_\u001a\u00020\u0006J&\u0010`\u001a\u00020B2\u0006\u0010a\u001a\u00020\u00122\f\u0010b\u001a\b\u0012\u0004\u0012\u00020d0c2\u0006\u0010e\u001a\u00020\tH\u0002J\u001c\u0010`\u001a\u00020B2\f\u0010b\u001a\b\u0012\u0004\u0012\u00020d0c2\u0006\u0010e\u001a\u00020\tJ\u0006\u0010f\u001a\u00020\u0012J-\u0010g\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\u0006\u0010i\u001a\u00020j2\u0006\u0010k\u001a\u00020\u00122\u0006\u0010l\u001a\u00020\tH\u0000¢\u0006\u0002\bmJ+\u0010n\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\f\u0010b\u001a\b\u0012\u0004\u0012\u00020d0c2\u0006\u0010l\u001a\u00020\tH\u0000¢\u0006\u0002\boJ#\u0010p\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\f\u0010b\u001a\b\u0012\u0004\u0012\u00020d0cH\u0000¢\u0006\u0002\bqJ\u001d\u0010r\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\u0006\u0010s\u001a\u00020TH\u0000¢\u0006\u0002\btJ$\u0010u\u001a\u00020B2\u0006\u0010a\u001a\u00020\u00122\f\u0010b\u001a\b\u0012\u0004\u0012\u00020d0c2\u0006\u0010e\u001a\u00020\tJ\u0015\u0010v\u001a\u00020\t2\u0006\u0010h\u001a\u00020\u0012H\u0000¢\u0006\u0002\bwJ\u0017\u0010x\u001a\u0004\u0018\u00010B2\u0006\u0010h\u001a\u00020\u0012H\u0000¢\u0006\u0002\byJ\r\u0010z\u001a\u00020QH\u0000¢\u0006\u0002\b{J\u000e\u0010|\u001a\u00020Q2\u0006\u0010}\u001a\u00020&J\u000e\u0010~\u001a\u00020Q2\u0006\u0010\u007f\u001a\u00020TJ\u001e\u0010\u0080\u0001\u001a\u00020Q2\t\b\u0002\u0010\u0081\u0001\u001a\u00020\t2\b\b\u0002\u0010E\u001a\u00020FH\u0007J\u0018\u0010\u0082\u0001\u001a\u00020Q2\u0007\u0010\u0083\u0001\u001a\u00020\u0006H\u0000¢\u0006\u0003\b\u0084\u0001J,\u0010\u0085\u0001\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\u0007\u0010\u0086\u0001\u001a\u00020\t2\n\u0010\u0087\u0001\u001a\u0005\u0018\u00010\u0088\u00012\u0006\u0010k\u001a\u00020\u0006J/\u0010\u0089\u0001\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\u0007\u0010\u0086\u0001\u001a\u00020\t2\r\u0010\u008a\u0001\u001a\b\u0012\u0004\u0012\u00020d0cH\u0000¢\u0006\u0003\b\u008b\u0001J\u0007\u0010\u008c\u0001\u001a\u00020QJ\"\u0010\u008c\u0001\u001a\u00020Q2\u0007\u0010\u008d\u0001\u001a\u00020\t2\u0007\u0010\u008e\u0001\u001a\u00020\u00122\u0007\u0010\u008f\u0001\u001a\u00020\u0012J\u0007\u0010\u0090\u0001\u001a\u00020QJ\u001f\u0010\u0091\u0001\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\u0006\u0010\u007f\u001a\u00020TH\u0000¢\u0006\u0003\b\u0092\u0001J\u001f\u0010\u0093\u0001\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\u0006\u0010s\u001a\u00020TH\u0000¢\u0006\u0003\b\u0094\u0001J \u0010\u0095\u0001\u001a\u00020Q2\u0006\u0010h\u001a\u00020\u00122\u0007\u0010\u0096\u0001\u001a\u00020\u0006H\u0000¢\u0006\u0003\b\u0097\u0001R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\u00020\tX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0014\u0010\f\u001a\u00020\rX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0014\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00120\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0013\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0014\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0015\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0016\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0017\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0018\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\u0019\u001a\u00020\u0012X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u001a\u0010\u001b\"\u0004\b\u001c\u0010\u001dR\u0014\u0010\u001e\u001a\u00020\u001fX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b \u0010!R\u001a\u0010\"\u001a\u00020\u0012X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b#\u0010\u001b\"\u0004\b$\u0010\u001dR\u0011\u0010%\u001a\u00020&¢\u0006\b\n\u0000\u001a\u0004\b'\u0010(R\u001a\u0010)\u001a\u00020&X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b*\u0010(\"\u0004\b+\u0010,R\u000e\u0010-\u001a\u00020.X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010/\u001a\u000200X\u0082\u0004¢\u0006\u0002\n\u0000R\u001e\u00102\u001a\u00020\u00062\u0006\u00101\u001a\u00020\u0006@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\b3\u00104R\u001e\u00105\u001a\u00020\u00062\u0006\u00101\u001a\u00020\u0006@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\b6\u00104R\u0015\u00107\u001a\u000608R\u00020\u0000¢\u0006\b\n\u0000\u001a\u0004\b9\u0010:R\u000e\u0010;\u001a\u000200X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010<\u001a\u00020=X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b>\u0010?R \u0010@\u001a\u000e\u0012\u0004\u0012\u00020\u0012\u0012\u0004\u0012\u00020B0AX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\bC\u0010DR\u000e\u0010E\u001a\u00020FX\u0082\u0004¢\u0006\u0002\n\u0000R\u001e\u0010G\u001a\u00020\u00062\u0006\u00101\u001a\u00020\u0006@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\bH\u00104R\u001e\u0010I\u001a\u00020\u00062\u0006\u00101\u001a\u00020\u0006@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\bJ\u00104R\u0011\u0010K\u001a\u00020L¢\u0006\b\n\u0000\u001a\u0004\bM\u0010NR\u000e\u0010O\u001a\u000200X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u009c\u0001"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184;", "Ljava/io/IDisposable;", "builder", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p2bd4a59b;", "(Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p2bd4a59b;)V", "awaitPingsSent", "", "awaitPongsReceived", "client", "", "getClient$okhttp", "()Z", "connectionName", "", "getConnectionName$okhttp", "()Ljava/lang/string;", "currentPushRequests", "", "", "degradedPingsSent", "degradedPongDeadlineNs", "degradedPongsReceived", "intervalPingsSent", "intervalPongsReceived", "isShutdown", "lastGoodStreamId", "getLastGoodStreamId$okhttp", "()I", "setLastGoodStreamId$okhttp", "(I)V", "listener", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;", "getListener$okhttp", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;", "nextStreamId", "getNextStreamId$okhttp", "setNextStreamId$okhttp", "okHttpHashSettings", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "getOkHttpHashSettings", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "peerHashSettings", "getPeerHashSettings", "setPeerHashSettings", "(Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;)V", "pushObserver", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p96b6dd38;", "pushQueue", "Lp7ddcfee1/pd1efad72/p7a3075c7/p6d96efb7;", "<set-?>", "readbytesAcknowledged", "getReadbytesAcknowledged", "()J", "readbytesTotal", "getReadbytesTotal", "readerAction", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p28bdc648;", "getReaderAction", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p28bdc648;", "settingsListenerQueue", "socket", "Ljava/net/Socket;", "getSocket$okhttp", "()Ljava/net/Socket;", "streams", "", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p87a6e6e6;", "getStreams$okhttp", "()Ljava/util/Dictionary;", "taskRunner", "Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;", "writebytesMaximum", "getWritebytesMaximum", "writebytesTotal", "getWritebytesTotal", "writer", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf98b58a;", "getWriter", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf98b58a;", "writerQueue", "awaitPong", "", "close", "connectionCode", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38;", "streamCode", "cause", "Ljava/io/IOException;", "close$okhttp", "failConnection", "e", "flush", "getStream", "id", "isHealthy", "nowNs", "newStream", "associatedStreamId", "requestHeaders", "", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf50d5e6;", "out", "openStreamCount", "pushDataLater", "streamId", "source", "Lp38cb8f46/pcc81e3f6;", "byteCount", "inFinished", "pushDataLater$okhttp", "pushHeadersLater", "pushHeadersLater$okhttp", "pushRequestLater", "pushRequestLater$okhttp", "pushResetLater", "errorCode", "pushResetLater$okhttp", "pushStream", "pushedStream", "pushedStream$okhttp", "removeStream", "removeStream$okhttp", "sendDegradedPingLater", "sendDegradedPingLater$okhttp", "setHashSettings", "settings", "shutdown", "statusCode", "start", "sendConnectionPreface", "updateConnectionFlowControl", "read", "updateConnectionFlowControl$okhttp", "writeData", "outFinished", "buffer", "Lp38cb8f46/p7e62bc34;", "writeHeaders", "alternating", "writeHeaders$okhttp", "writePing", "reply", "payload1", "payload2", "writePingAndAwaitPong", "writeSynReset", "writeSynReset$okhttp", "writeSynResetLater", "writeSynResetLater$okhttp", "writeWindowUpdateLater", "unacknowledgedbytesRead", "writeWindowUpdateLater$okhttp", "Builder", "Companion", "Listener", "ReaderAction", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p2d68e184 : java.io.IDisposable {
    public static readonly int f01255b9e = 2;
    public static readonly int f0e065c5d = 16777216;
    public static readonly int f164b5d58 = 1;
    private static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 f18d2e6b8 = null;
    public static readonly int f1fdd9c58 = 1000000000;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p910eef8c f254fa7fc = null;
    public static readonly int f566344af = 16777216;
    public static readonly int f71bd3ed8 = 1;
    public static readonly int f7bdc9cbb = 3;
    public static readonly int f88724bc2 = 1000000000;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p910eef8c f910eef8c = null;
    public static readonly int f91be2e84 = 16777216;
    public static readonly int f9e78bec3 = 2;
    public static readonly int fa68a1044 = 1000000000;
    public static readonly int fafece5c1 = 16777216;
    public static readonly int fb4823f2b = 3;
    public static readonly int fc7061aef = 1000000000;
    public static readonly int fd578dd34 = 16777216;
    public static readonly int fd83f4818 = 1;
    public static readonly int fd9f983fb = 2;
    public static readonly int fee667913 = 3;
    public static readonly int ff31c9388 = 1000000000;
    public static readonly int ff5333a6b = 3;
    private static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 ff8ca1fc5 = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p910eef8c ffffd97d1 = null;
    private long f03e3e134;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f0521301c;
    private long f05abb196;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 f08a34545;
    private long f098f5c58;
    private readonly java.lang.string f1a2e0cd3;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p28bdc648 f1f65fe92;
    private int f25560a87;
    private long f276510dd;
    private long f2b1ca2f8;
    private readonly java.util.Dictionary<java.lang.int, p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6> f2f6f4768;
    private long f3075f639;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 f35ce15db;
    private readonly java.net.Socket f3913b048;
    private readonly java.util.HashSet f3b294f75;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 f3e461eab;
    private long f42095970;
    private long f4532d9b3;
    private readonly java.lang.string f461434c6;
    private readonly java.util.HashSet f4614a24b;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 f46296d1b;
    private readonly java.net.Socket f4700f044;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f4e9356c0;
    private long f51cc4164;
    private long f5743cdb3;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 f5a5c6e5e;
    private long f5bab8e96;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 f5c0e4218;
    private readonly java.net.Socket f61f25293;
    private readonly bool f62608e08;
    private long f65d5de06;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f6a2d7521;
    private long f6de0abed;
    private long f6f1fd9b9;
    private readonly bool f716991cf;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 f787efb89;
    private long f7bf250bf;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f7c467725;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 f7c91eec5;
    private long f817b0393;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f81a61384;
    private long f869155b1;
    private long f87c45c3b;
    private readonly bool f89aff215;
    private bool f8aea5ac4;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f8f127178;
    private long f93aadf8a;
    private p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 f95e9b297;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 f960a5911;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f99bf7c1e;
    private long f9b866772;
    private readonly java.util.Dictionary fa098dfce;
    private long fa244b37a;
    private long fa415f05b;
    private long fa7196095;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a fa82feee3;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a fa908c0ab;
    private long fa98d03ae;
    private readonly java.util.HashSet<java.lang.int> fafd22e63;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p28bdc648 fb1b97849;
    private p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 fb5e2ad27;
    private readonly java.util.Dictionary fb6add320;
    private int fb973a5d8;
    private readonly bool fb9fae37a;
    private bool fba7da84d;
    private readonly java.lang.string fbdd3b5da;
    private long fc6076efd;
    private long fca5ceb37;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p28bdc648 fcb104449;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 fcc52fee6;
    private long fd0739828;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 fd0b62cf0;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 fd11703ef;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 fd1e2648c;
    private long fd4d7c000;
    private long fd7948be0;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 fd7d5a65e;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 fdaf438f7;
    private long fdbae46a1;
    private long fdc33b36e;
    private long fddba98ca;
    private readonly java.lang.string fe0c90dbe;
    private long fe0efa1b3;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 fe10edc3d;
    private long fe15a1b92;
    private int fe2d806df;
    private long fe68e41cd;
    private long fe6cb6f0b;
    private readonly bool fea6a7c9d;
    private bool fec251b09;
    private long fee4c6018;
    private long ff003faaf;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 ff11344bf;
    private bool ff4038ec1;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 ff4154b76;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 ffa4e167c;
    private int ffaf4bcff;
    private readonly p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 ffed859a6;
    private long fffd0d62d;

    @kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b&\u0018\u0000 \f2\u00020\u0001:\u0001\fB\u0005¢\u0006\u0002\u0010\u0002J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0016J\u0010\u0010\t\u001a\u00020\u00042\u0006\u0010\n\u001a\u00020\u000bH&¨\u0006\r"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;", "", "()V", "onHashSettings", "", "connection", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184;", "settings", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "onStream", "stream", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p87a6e6e6;", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static abstract class p0c951aa4 {
        public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4.p910eef8c f2d52ccd9 = null;
        public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4.p910eef8c f6269e1e1 = null;
        public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 f7c016208 = null;
        public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 f8fb2b43c = null;
        public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4.p910eef8c f910eef8c = null;
        public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4.p910eef8c f9acd3977 = null;
        public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 fa0c12409 = null;

        @kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0010\u0010\u0003\u001a\u00020\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0005"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4$p910eef8c;", "", "()V", "REFUSE_INCOMING_STREAMS", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
        public static readonly class p910eef8c {
            private p910eef8c() {
                    r0 = this;
                    goto Le
                L4:
                    goto L11
                L7:
                    r0.<init>()
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

            public /* synthetic */ p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker r1) {
                    r0 = this;
                    goto L4
                L4:
                    goto L13
                L7:
                    goto Lb
                Lb:
                    r0.<init>()
                    goto L12
                L12:
                    return
                L13:
                    goto L17
                L17:
                    goto L7
            }
        }

        static {
                goto L6e
            L4:
                int r0 = r0 + r1
                goto L2a
            La:
                r0 = 9
                goto L49
            L11:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4.f910eef8c = r0
                goto L43
            L17:
                r1 = 0
                goto L23
            L1c:
                goto L67
            L1f:
                goto L36
            L23:
                r0.<init>(r1)
                goto L11
            L2a:
                int r0 = r0 % r1
                goto L50
            L30:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4.f8fb2b43c = r0
                goto L66
            L36:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4$p910eef8c r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4$p910eef8c
                goto L17
            L3c:
                goto L1f
            L3f:
                goto L6b
            L43:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4$p910eef8c$p8fb2b43c$1 r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4$p910eef8c$p8fb2b43c$1
                goto L59
            L49:
                r1 = 8
                goto L4
            L50:
                if (r0 <= 0) goto L55
                goto L1f
            L55:
                goto L1c
            L59:
                r0.<init>()
                goto L60
            L60:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4 r0 = (p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4) r0
                goto L30
            L66:
                return
            L67:
                goto L3c
            L6b:
                goto L71
            L6e:
                goto L3f
            L71:
                goto La
        }

        public p0c951aa4() {
                r0 = this;
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
                r0.<init>()
                goto Le
        }

        public void OnHashSettings(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r1, p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r2) {
                r0 = this;
                goto L23
            L4:
                java.lang.string r0 = "settings"
                goto Lf
            La:
                return
            Lb:
                goto L2a
            Lf:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto La
            L16:
                java.lang.string r0 = "connection"
                goto L1c
            L1c:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r1, r0)
                goto L4
            L23:
                goto Lb
            L26:
                goto L16
            L2a:
                goto L26
        }

        public abstract void OnStream(p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r1) throws java.io.IOException;
    }

    @kotlin.Metadata(d1 = {"\u0000`\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0010\b\u0086\u0004\u0018\u00002\u00020\u00012\b\u0012\u0004\u0012\u00020\u00030\u0002B\u000f\b\u0000\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\b\u0010\t\u001a\u00020\u0003H\u0016J8\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\f2\u0006\u0010\u0013\u001a\u00020\u0014H\u0016J\u0016\u0010\u0015\u001a\u00020\u00032\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0019J(\u0010\u001a\u001a\u00020\u00032\u0006\u0010\u001b\u001a\u00020\u00172\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u001c\u001a\u00020\u001d2\u0006\u0010\u001e\u001a\u00020\fH\u0016J \u0010\u001f\u001a\u00020\u00032\u0006\u0010 \u001a\u00020\f2\u0006\u0010!\u001a\u00020\"2\u0006\u0010#\u001a\u00020\u0010H\u0016J.\u0010$\u001a\u00020\u00032\u0006\u0010\u001b\u001a\u00020\u00172\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010%\u001a\u00020\f2\f\u0010&\u001a\b\u0012\u0004\u0012\u00020(0'H\u0016J\t\u0010)\u001a\u00020\u0003H\u0096\u0002J \u0010*\u001a\u00020\u00032\u0006\u0010+\u001a\u00020\u00172\u0006\u0010,\u001a\u00020\f2\u0006\u0010-\u001a\u00020\fH\u0016J(\u0010.\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010/\u001a\u00020\f2\u0006\u00100\u001a\u00020\f2\u0006\u00101\u001a\u00020\u0017H\u0016J&\u00102\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\f2\u0006\u00103\u001a\u00020\f2\f\u00104\u001a\b\u0012\u0004\u0012\u00020(0'H\u0016J\u0018\u00105\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010!\u001a\u00020\"H\u0016J\u0018\u0010\u0018\u001a\u00020\u00032\u0006\u0010\u0016\u001a\u00020\u00172\u0006\u0010\u0018\u001a\u00020\u0019H\u0016J\u0018\u00106\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\f2\u0006\u00107\u001a\u00020\u0014H\u0016R\u0014\u0010\u0004\u001a\u00020\u0005X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u00068"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p28bdc648;", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p1b0ecc4e$p0bb4c52b;", "Lkotlin/Function0;", "", "reader", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p1b0ecc4e;", "(Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184;Lp7ddcfee1/pd1efad72/p3cb89a9f/p1b0ecc4e;)V", "getReader$okhttp", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/p1b0ecc4e;", "ackHashSettings", "alternateService", "streamId", "", "origin", "", "protocol", "Lp38cb8f46/p58efa9e8;", "host", "port", "maxAge", "", "applyAndAckHashSettings", "clearPrevious", "", "settings", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "data", "inFinished", "source", "Lp38cb8f46/pcc81e3f6;", "length", "goAway", "lastGoodStreamId", "errorCode", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38;", "debugData", "headers", "associatedStreamId", "headerBlock", "", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf50d5e6;", "invoke", "ping", "ack", "payload1", "payload2", "priority", "streamDependency", "weight", "exclusive", "pushPromise", "promisedStreamId", "requestHeaders", "rstStream", "windowUpdate", "windowSizeIncrement", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public readonly class p28bdc648 : p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b, kotlin.jvm.functions.Function0<kotlin.Unit> {
        private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e f1de9b0a3;
        private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e fcef6ee33;
        readonly /* synthetic */ p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 this$0;

        public p28bdc648(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2, p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r3) {
                r1 = this;
                goto L39
            L4:
                goto L3c
            L7:
                java.lang.string r0 = "reader"
                goto Ld
            Ld:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto L28
            L14:
                java.lang.string r0 = "this$0"
                goto L21
            L1a:
                r1.<init>()
                goto L33
            L21:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L7
            L28:
                r1.this$0 = r2
                goto L1a
            L2e:
                return
            L2f:
                goto L4
            L33:
                r1.f1de9b0a3 = r3
                goto L2e
            L39:
                goto L2f
            L3c:
                goto L14
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void AckHashSettings() {
                r0 = this;
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

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void AlternateService(int r1, java.lang.string r2, p38cb8f46.p58efa9e8 r3, java.lang.string r4, int r5, long r6) {
                r0 = this;
                goto L18
            L4:
                return
            L5:
                goto L9
            L9:
                goto L1b
            Lc:
                java.lang.string r0 = "host"
                goto L2c
            L12:
                java.lang.string r0 = "protocol"
                goto L25
            L18:
                goto L5
            L1b:
                goto L1f
            L1f:
                java.lang.string r0 = "origin"
                goto L33
            L25:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto Lc
            L2c:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
                goto L4
            L33:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L12
        }

        public readonly void ApplyAndAckHashSettings(bool r11, p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r12) {
                r10 = this;
                goto L77
            L4:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r10 = r10.this$0
                goto Laf
            La:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r12, r0)
                goto L66
            L11:
                goto L7a
            L14:
                monitor-exit(r1)
                goto La5
            L19:
                int r10 = r4.length
            L1a:
                goto L9c
            L1e:
                r1 = 30
                goto L147
            L25:
                r0 = r4[r5]
                goto L8d
            L2b:
                goto La6
            L2e:
                goto L32
            L32:
                java.lang.string r0 = "settings"
                goto La
            L38:
                if (r4 != 0) goto L3d
                goto L136
            L3d:
                goto L19
            L41:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r1 = r10.this$0
                goto L7e
            L47:
                r0 = 19
                goto L1e
            L4e:
                if (r0 <= 0) goto L53
                goto L2e
            L53:
                goto L2b
            L57:
                monitor-exit(r1)
                goto L38
            L5c:
                monitor-enter(r0)
                r0.addbytesToWriteWindow(r11)     // Catch: java.lang.Exception -> L6d
                kotlin.Unit r1 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L6d
                goto L72
            L66:
                kotlin.jvm.internal.Ref$objectRef r0 = new kotlin.jvm.internal.Ref$objectRef
                goto L86
            L6c:
                goto L1a
            L6d:
                r10 = move-exception
                goto Laa
            L72:
                monitor-exit(r0)
                goto L6c
            L77:
                goto L143
            L7a:
                goto L47
            L7e:
                p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r1 = r1.getWriter()
                goto L4
            L86:
                r0.<init>()
                goto L41
            L8d:
                int r5 = r5 + 1
                goto L5c
            L93:
                return
            L94:
                r11 = move-exception
                monitor-exit(r10)     // Catch: java.lang.Exception -> L97
                throw r11     // Catch: java.lang.Exception -> L97
            L97:
                r10 = move-exception
                goto L14
            L9c:
                if (r5 < r10) goto La1
                goto L136
            La1:
                goto L25
            La5:
                throw r10
            La6:
                goto L140
            Laa:
                monitor-exit(r0)
                goto L135
            Laf:
                monitor-enter(r1)
                monitor-enter(r10)     // Catch: java.lang.Exception -> L97
                p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r2 = r10.getPeerHashSettings()     // Catch: java.lang.Exception -> L94
                if (r11 == 0) goto Lb8
                goto Lc4
            Lb8:
                p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r11 = new p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727     // Catch: java.lang.Exception -> L94
                r11.<init>()     // Catch: java.lang.Exception -> L94
                r11.merge(r2)     // Catch: java.lang.Exception -> L94
                r11.merge(r12)     // Catch: java.lang.Exception -> L94
                r12 = r11
            Lc4:
                r0.element = r12     // Catch: java.lang.Exception -> L94
                T r11 = r0.element     // Catch: java.lang.Exception -> L94
                p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r11 = (p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727) r11     // Catch: java.lang.Exception -> L94
                int r11 = r11.getInitialWindowSize()     // Catch: java.lang.Exception -> L94
                long r11 = (long) r11     // Catch: java.lang.Exception -> L94
                int r2 = r2.getInitialWindowSize()     // Catch: java.lang.Exception -> L94
                long r2 = (long) r2     // Catch: java.lang.Exception -> L94
                long r11 = r11 - r2
                r2 = 0
                int r4 = (r11 > r2 ? 1 : (r11 == r2 ? 0 : -1))
                r5 = 0
                if (r4 == 0) goto L102
                java.util.Dictionary r4 = r10.getStreams$okhttp()     // Catch: java.lang.Exception -> L94
                bool r4 = r4.Count == 0     // Catch: java.lang.Exception -> L94
                if (r4 == 0) goto Le7
                goto L102
            Le7:
                java.util.Dictionary r4 = r10.getStreams$okhttp()     // Catch: java.lang.Exception -> L94
                java.util.ICollection r4 = r4.Values     // Catch: java.lang.Exception -> L94
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[] r6 = new p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[r5]     // Catch: java.lang.Exception -> L94
                java.lang.object[] r4 = r4.toArray(r6)     // Catch: java.lang.Exception -> L94
                if (r4 == 0) goto Lfa
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[] r4 = (p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[]) r4     // Catch: java.lang.Exception -> L94
                goto L103
            Lfa:
                java.lang.NullPointerException r11 = new java.lang.NullPointerException     // Catch: java.lang.Exception -> L94
                java.lang.string r12 = "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>"
                r11.<init>(r12)     // Catch: java.lang.Exception -> L94
                throw r11     // Catch: java.lang.Exception -> L94
            L102:
                r4 = 0
            L103:
                T r6 = r0.element     // Catch: java.lang.Exception -> L94
                p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r6 = (p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727) r6     // Catch: java.lang.Exception -> L94
                r10.setPeerHashSettings(r6)     // Catch: java.lang.Exception -> L94
                p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r6 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getHashSettingsListenerQueue$p(r10)     // Catch: java.lang.Exception -> L94
                java.lang.string r7 = r10.getConnectionName$okhttp()     // Catch: java.lang.Exception -> L94
                java.lang.string r8 = " onHashSettings"
                java.lang.string r7 = kotlin.jvm.internal.Intrinsics.stringPlus(r7, r8)     // Catch: java.lang.Exception -> L94
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$p5a6ca965$p1938d6cb$p0f68d17a$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r8 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$p5a6ca965$p1938d6cb$p0f68d17a$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1     // Catch: java.lang.Exception -> L94
                r9 = 1
                r8.<init>(r7, r9, r10, r0)     // Catch: java.lang.Exception -> L94
                p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r8 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r8     // Catch: java.lang.Exception -> L94
                r6.schedule(r8, r2)     // Catch: java.lang.Exception -> L94
                kotlin.Unit r2 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L94
                monitor-exit(r10)     // Catch: java.lang.Exception -> L97
                p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r2 = r10.getWriter()     // Catch: java.lang.Exception -> L97 java.io.IOException -> L14e
                T r0 = r0.element     // Catch: java.lang.Exception -> L97 java.io.IOException -> L14e
                p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = (p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727) r0     // Catch: java.lang.Exception -> L97 java.io.IOException -> L14e
                r2.applyAndAckHashSettings(r0)     // Catch: java.lang.Exception -> L97 java.io.IOException -> L14e
                goto L14d
            L135:
                throw r10
            L136:
                goto L93
            L13a:
                int r0 = r0 % r1
                goto L4e
            L140:
                goto L2e
            L143:
                goto L11
            L147:
                int r0 = r0 + r1
                goto L13a
            L14d:
                goto L152
            L14e:
                r0 = move-exception
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$failConnection(r10, r0)     // Catch: java.lang.Exception -> L97
            L152:
                kotlin.Unit r10 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L97
                goto L57
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void Data(bool r2, int r3, p38cb8f46.pcc81e3f6 r4, int r5) throws java.io.IOException {
                r1 = this;
                goto L76
            L4:
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r0 = r0.getStream(r3)
                goto L2f
            Lc:
                r0.receiveData(r4, r5)
                goto L50
            L13:
                return
            L14:
                goto L9b
            L18:
                r2 = 1
                goto L7d
            L1d:
                long r2 = (long) r5
                goto L59
            L22:
                r1.pushDataLater$okhttp(r3, r4, r5, r2)
                goto L13
            L29:
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0
                goto La1
            L2f:
                if (r0 == 0) goto L34
                goto L85
            L34:
                goto L3e
            L38:
                java.lang.string r0 = "source"
                goto L89
            L3e:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2 = r1.this$0
                goto L29
            L44:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r1.this$0
                goto La8
            L4a:
                p7ddcfee1.p883d7615 r1 = p7ddcfee1.pd1efad72.p23e8a4b4.f12ea5829
                goto L18
            L50:
                if (r2 != 0) goto L55
                goto L80
            L55:
                goto L4a
            L59:
                r1.updateConnectionFlowControl$okhttp(r2)
                goto L66
            L60:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r1 = r1.this$0
                goto L1d
            L66:
                r4.skip(r2)
                goto L84
            L6d:
                if (r0 != 0) goto L72
                goto L14
            L72:
                goto L95
            L76:
                goto L91
            L79:
                goto L38
            L7d:
                r0.receiveHeaders(r1, r2)
            L80:
                goto L90
            L84:
                return
            L85:
                goto Lc
            L89:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
                goto L44
            L90:
                return
            L91:
                goto Lb0
            L95:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r1 = r1.this$0
                goto L22
            L9b:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r1.this$0
                goto L4
            La1:
                r2.writeSynResetLater$okhttp(r3, r0)
                goto L60
            La8:
                bool r0 = r0.pushedStream$okhttp(r3)
                goto L6d
            Lb0:
                goto L79
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e getReader$okhttp() {
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
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r0 = r0.f1de9b0a3
                goto L7
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void GoAway(int r4, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r5, p38cb8f46.p58efa9e8 r6) {
                r3 = this;
                goto L81
            L4:
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r2 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc
                goto L19
            La:
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[] r6 = (p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[]) r6
                goto L9e
            L10:
                goto L84
            L13:
                java.lang.string r5 = "debugData"
                goto L37
            L19:
                r1.receiveRstStream(r2)
                goto L76
            L20:
                int r0 = r0 % r1
                goto Lc3
            L26:
                int r2 = r1.getId()
                goto L2e
            L2e:
                if (r2 > r4) goto L33
                goto L9f
            L33:
                goto Ld3
            L37:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r6, r5)
                goto L53
            L3e:
                r0 = 11
                goto Lcc
            L45:
                return
            L46:
                java.lang.NullPointerException r3 = new java.lang.NullPointerException     // Catch: java.lang.Exception -> L4e
                java.lang.string r4 = "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>"
                r3.<init>(r4)     // Catch: java.lang.Exception -> L4e
                throw r3     // Catch: java.lang.Exception -> L4e
            L4e:
                r3 = move-exception
                goto L99
            L53:
                r6.Count
                goto Ldb
            L5a:
                if (r2 != 0) goto L5f
                goto L9f
            L5f:
                goto L4
            L63:
                goto Lb9
            L66:
                goto L10
            L6a:
                monitor-exit(r5)
                goto La
            L6f:
                r2.removeStream$okhttp(r1)
                goto Lfd
            L76:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2 = r3.this$0
                goto L88
            L7c:
                throw r3
            L7d:
                goto L63
            L81:
                goto L66
            L84:
                goto L3e
            L88:
                int r1 = r1.getId()
                goto L6f
            L90:
                if (r0 < r5) goto L95
                goto Lfe
            L95:
                goto L102
            L99:
                monitor-exit(r5)
                goto L7c
            L9e:
                int r5 = r6.length
            L9f:
                goto L90
            La3:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
                goto L13
            Laa:
                java.lang.string r0 = "errorCode"
                goto La3
            Lb0:
                int r0 = r0 + 1
                goto L26
            Lb6:
                goto L7d
            Lb9:
                goto Laa
            Lbd:
                int r0 = r0 + r1
                goto L20
            Lc3:
                if (r0 <= 0) goto Lc8
                goto Lb9
            Lc8:
                goto Lb6
            Lcc:
                r1 = 2
                goto Lbd
            Ld3:
                bool r2 = r1.isLocallyInitiated()
                goto L5a
            Ldb:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r5 = r3.this$0
                goto Le1
            Le1:
                monitor-enter(r5)
                java.util.Dictionary r6 = r5.getStreams$okhttp()     // Catch: java.lang.Exception -> L4e
                java.util.ICollection r6 = r6.Values     // Catch: java.lang.Exception -> L4e
                r0 = 0
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[] r1 = new p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[r0]     // Catch: java.lang.Exception -> L4e
                java.lang.object[] r6 = r6.toArray(r1)     // Catch: java.lang.Exception -> L4e
                if (r6 == 0) goto L46
                r1 = 1
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$setShutdown$p(r5, r1)     // Catch: java.lang.Exception -> L4e
                kotlin.Unit r1 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L4e
                goto L6a
            Lfd:
                goto L9f
            Lfe:
                goto L45
            L102:
                r1 = r6[r0]
                goto Lb0
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void Headers(bool r7, int r8, int r9, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r10) {
                r6 = this;
                goto L39
            L4:
                return
            L5:
                goto L4f
            L9:
                return
            La:
                int r6 = r2.getLastGoodStreamId$okhttp()     // Catch: java.lang.Exception -> L80
                goto L6e
            L12:
                monitor-exit(r2)
                goto L85
            L17:
                r0 = 20
                goto L13d
            L1e:
                monitor-exit(r2)
                goto Lec
            L23:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r9)
                goto L12a
            L2a:
                monitor-enter(r2)
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r6 = r2.getStream(r8)     // Catch: java.lang.Exception -> L80
                if (r6 != 0) goto L5
                bool r6 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$isShutdown$p(r2)     // Catch: java.lang.Exception -> L80
                goto L118
            L39:
                goto L48
            L3c:
                goto L17
            L40:
                return
            L41:
                goto L5b
            L45:
                goto L64
            L48:
                goto L4c
            L4c:
                goto L3c
            L4f:
                r4 = r7
                kotlin.Unit r7 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L80
                goto L113
            L56:
                monitor-exit(r2)
                goto Ldf
            L5b:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2 = r6.this$0
                goto L2a
            L61:
                goto Le0
            L64:
                goto L14a
            L68:
                int r0 = r0 + r1
                goto L137
            L6e:
                if (r8 <= r6) goto L73
                goto Led
            L73:
                goto L1e
            L77:
                p7ddcfee1.p883d7615 r7 = p7ddcfee1.pd1efad72.p23e8a4b4.toHeaders(r10)
                goto L130
            L7f:
                return
            L80:
                r0 = move-exception
                goto L102
            L85:
                return
            L86:
                p7ddcfee1.p883d7615 r5 = p7ddcfee1.pd1efad72.p23e8a4b4.toHeaders(r10)     // Catch: java.lang.Exception -> L80
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6     // Catch: java.lang.Exception -> L80
                r3 = 0
                r4 = r7
                r1 = r8
                r0.<init>(r1, r2, r3, r4, r5)     // Catch: java.lang.Exception -> L80
                r2.setLastGoodStreamId$okhttp(r1)     // Catch: java.lang.Exception -> L80
                java.util.Dictionary r6 = r2.getStreams$okhttp()     // Catch: java.lang.Exception -> L80
                java.lang.int r7 = java.lang.int.valueOf(r1)     // Catch: java.lang.Exception -> L80
                r6.Add(r7, r0)     // Catch: java.lang.Exception -> L80
                p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r6 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getTaskRunner$p(r2)     // Catch: java.lang.Exception -> L80
                p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r6 = r6.newQueue()     // Catch: java.lang.Exception -> L80
                java.lang.stringBuilder r7 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L80
                r7.<init>()     // Catch: java.lang.Exception -> L80
                java.lang.string r8 = r2.getConnectionName$okhttp()     // Catch: java.lang.Exception -> L80
                java.lang.stringBuilder r7 = r7.append(r8)     // Catch: java.lang.Exception -> L80
                r8 = 91
                java.lang.stringBuilder r7 = r7.append(r8)     // Catch: java.lang.Exception -> L80
                java.lang.stringBuilder r7 = r7.append(r1)     // Catch: java.lang.Exception -> L80
                java.lang.string r8 = "] onStream"
                java.lang.stringBuilder r7 = r7.append(r8)     // Catch: java.lang.Exception -> L80
                java.lang.string r7 = r7.tostring()     // Catch: java.lang.Exception -> L80
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$p4340fd73$p67f7b4e7$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r8 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$p4340fd73$p67f7b4e7$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1     // Catch: java.lang.Exception -> L80
                r9 = 1
                r8.<init>(r7, r9, r2, r0)     // Catch: java.lang.Exception -> L80
                p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r8 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r8     // Catch: java.lang.Exception -> L80
                r9 = 0
                r6.schedule(r8, r9)     // Catch: java.lang.Exception -> L80
                goto L107
            Lda:
                monitor-exit(r2)
                goto L9
            Ldf:
                throw r6
            Le0:
                goto L45
            Le4:
                bool r9 = r9.pushedStream$okhttp(r8)
                goto Lf9
            Lec:
                return
            Led:
                int r6 = r8 % 2
                int r9 = r2.getNextStreamId$okhttp()     // Catch: java.lang.Exception -> L80
                int r9 = r9 % 2
                goto L121
            Lf9:
                if (r9 != 0) goto Lfe
                goto L41
            Lfe:
                goto L144
            L102:
                r6 = r0
                goto L56
            L107:
                monitor-exit(r2)
                goto L4
            L10c:
                r6.pushHeadersLater$okhttp(r8, r10, r7)
                goto L40
            L113:
                monitor-exit(r2)
                goto L77
            L118:
                if (r6 != 0) goto L11d
                goto La
            L11d:
                goto Lda
            L121:
                if (r6 == r9) goto L126
                goto L86
            L126:
                goto L12
            L12a:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r9 = r6.this$0
                goto Le4
            L130:
                r6.receiveHeaders(r7, r4)
                goto L7f
            L137:
                int r0 = r0 % r1
                goto L150
            L13d:
                r1 = 31
                goto L68
            L144:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r6 = r6.this$0
                goto L10c
            L14a:
                java.lang.string r9 = "headerBlock"
                goto L23
            L150:
                if (r0 <= 0) goto L155
                goto L64
            L155:
                goto L61
        }

        @Override // kotlin.jvm.functions.Function0
        public /* bridge */ /* synthetic */ kotlin.Unit invoke() {
                r0 = this;
                goto L12
            L4:
                kotlin.Unit r0 = kotlin.Unit.INSTANCE
                goto La
            La:
                return r0
            Lb:
                goto Lf
            Lf:
                goto L15
            L12:
                goto Lb
            L15:
                goto L19
            L19:
                r0.invoke2()
                goto L4
        }

        /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
        public void Invoke2() {
                r6 = this;
                goto Ld2
            L4:
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r6)
                goto Ldf
            Lb:
                r0 = 16
                goto L30
            L12:
                java.io.IDisposable r6 = (java.io.IDisposable) r6
                goto Lad
            L18:
                goto La9
            L1a:
                r2 = move-exception
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0     // Catch: java.lang.Exception -> L62
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r1 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0     // Catch: java.lang.Exception -> L62
                goto L23
            L23:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r3 = r6.this$0
                goto L53
            L29:
                goto Le0
            L2c:
                goto L3d
            L30:
                r1 = 17
                goto L8f
            L37:
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r6 = r6.f1de9b0a3
                goto L9b
            L3d:
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.fe8c0c708
                goto L67
            L43:
                if (r0 <= 0) goto L48
                goto L2c
            L48:
                goto L29
            L4c:
                r3.close$okhttp(r0, r1, r2)
                goto L6d
            L53:
                r3.close$okhttp(r0, r1, r2)
                goto L37
            L5a:
                r4.close$okhttp(r0, r1, r2)
                goto L80
            L61:
                return
            L62:
                r3 = move-exception
                goto L18
            L67:
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r1 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.fe8c0c708
                goto Lb4
            L6d:
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r6 = r6.f1de9b0a3
                goto L12
            L73:
                goto L2c
            L76:
                goto L8c
            L7a:
                int r0 = r0 % r1
                goto L43
            L80:
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r6 = r6.f1de9b0a3
                goto L95
            L86:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r3 = r6.this$0
                goto L4c
            L8c:
                goto Ld5
            L8f:
                int r0 = r0 + r1
                goto L7a
            L95:
                java.io.IDisposable r6 = (java.io.IDisposable) r6
                goto L4
            L9b:
                java.io.IDisposable r6 = (java.io.IDisposable) r6
                goto La1
            La1:
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r6)
                goto La8
            La8:
                return
            La9:
                goto Ld9
            Lad:
                p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r6)
                goto L61
            Lb4:
                r2 = 0
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r3 = r6.f1de9b0a3     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
                r4 = r6
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$p0bb4c52b r4 = (p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b) r4     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
                r3.readConnectionPreface(r4)     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
            Lbd:
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r3 = r6.f1de9b0a3     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
                r4 = r6
                p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e$p0bb4c52b r4 = (p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b) r4     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
                r5 = 0
                bool r3 = r3.nextFrame(r5, r4)     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
                if (r3 == 0) goto Lca
                goto Lbd
            Lca:
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.fd306b6fd     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
                p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r1 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027     // Catch: java.io.IOException -> L1a java.lang.Exception -> L62
                goto L86
            Ld2:
                goto L76
            Ld5:
                goto Lb
            Ld9:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r4 = r6.this$0
                goto L5a
            Ldf:
                throw r3
            Le0:
                goto L73
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void Ping(bool r9, int r10, int r11) {
                r8 = this;
                goto L55
            L4:
                int r0 = r0 % r1
                goto L41
            La:
                r6 = r10
                goto Lc4
            Lf:
                int r0 = r0 + r1
                goto L4
            L15:
                r9 = 3
                goto L85
            L1a:
                r9 = 1
                goto L5c
            L1f:
                monitor-enter(r8)
                goto L1a
            L24:
                p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r2
                goto Ldf
            L2a:
                return
            L2b:
                goto Ld8
            L2f:
                r9 = 2
                goto L104
            L34:
                monitor-exit(r8)
                goto L125
            L39:
                java.lang.string r3 = kotlin.jvm.internal.Intrinsics.stringPlus(r0, r1)
                goto L62
            L41:
                if (r0 <= 0) goto L46
                goto L81
            L46:
                goto L7e
            L4a:
                monitor-exit(r8)
                goto L11f
            L4f:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$pdf911f01$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$pdf911f01$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
                goto L79
            L55:
                goto Ldb
            L58:
                goto Lb7
            L5c:
                r0 = 1
                goto L70
            L62:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r5 = r8.this$0
                goto L4f
            L68:
                p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r9 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getWriterQueue$p(r9)
                goto Lbe
            L70:
                if (r10 != r9) goto L75
                goto La8
            L75:
                goto L2f
            L79:
                r4 = 1
                goto La
            L7e:
                goto L2b
            L81:
                goto Lf5
            L85:
                if (r10 != r9) goto L8a
                goto L8d
            L8a:
                kotlin.Unit r9 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L120
                goto Lb3
            L8d:
                long r9 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getAwaitPongsReceived$p(r8)     // Catch: java.lang.Exception -> L120
                long r9 = r9 + r0
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$setAwaitPongsReceived$p(r8, r9)     // Catch: java.lang.Exception -> L120
                r9 = r8
                java.lang.object r9 = (java.lang.object) r9     // Catch: java.lang.Exception -> L120
                r9.notifyAll()     // Catch: java.lang.Exception -> L120
                goto L8a
            L9c:
                long r9 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getDegradedPongsReceived$p(r8)     // Catch: java.lang.Exception -> L120
                long r0 = r0 + r9
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$setDegradedPongsReceived$p(r8, r0)     // Catch: java.lang.Exception -> L120
                java.lang.long.valueOf(r9)     // Catch: java.lang.Exception -> L120
                goto Lb3
            La8:
                long r9 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getIntervalPongsReceived$p(r8)     // Catch: java.lang.Exception -> L120
                long r0 = r0 + r9
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$setIntervalPongsReceived$p(r8, r0)     // Catch: java.lang.Exception -> L120
                java.lang.long.valueOf(r9)     // Catch: java.lang.Exception -> L120
            Lb3:
                goto L4a
            Lb7:
                r0 = 13
                goto Lee
            Lbe:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r8.this$0
                goto Lc9
            Lc4:
                r7 = r11
                goto Ld1
            Lc9:
                java.lang.string r0 = r0.getConnectionName$okhttp()
                goto Le8
            Ld1:
                r2.<init>(r3, r4, r5, r6, r7)
                goto L24
            Ld8:
                goto L81
            Ldb:
                goto Le5
            Ldf:
                r10 = 0
                goto L10d
            Le5:
                goto L58
            Le8:
                java.lang.string r1 = " ping"
                goto L39
            Lee:
                r1 = 4
                goto Lf
            Lf5:
                if (r9 != 0) goto Lfa
                goto L126
            Lfa:
                goto L114
            Lfe:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r9 = r8.this$0
                goto L68
            L104:
                if (r10 != r9) goto L109
                goto L9c
            L109:
                goto L15
            L10d:
                r9.schedule(r2, r10)
                goto L2a
            L114:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r8 = r8.this$0
                goto L1f
            L11a:
                r9 = r0
                goto L34
            L11f:
                return
            L120:
                r0 = move-exception
                goto L11a
            L125:
                throw r9
            L126:
                goto Lfe
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void Priority(int r1, int r2, int r3, bool r4) {
                r0 = this;
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
                goto L7
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void PushPromise(int r1, int r2, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r3) {
                r0 = this;
                goto L1d
            L4:
                java.lang.string r1 = "requestHeaders"
                goto L16
            La:
                return
            Lb:
                goto L24
            Lf:
                r0.pushRequestLater$okhttp(r2, r3)
                goto La
            L16:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r1)
                goto L27
            L1d:
                goto Lb
            L20:
                goto L4
            L24:
                goto L20
            L27:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r0.this$0
                goto Lf
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void RstStream(int r2, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r3) {
                r1 = this;
                goto L24
            L4:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r1 = r1.this$0
                goto L65
            La:
                java.lang.string r0 = "errorCode"
                goto L10
            L10:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto L39
            L17:
                return
            L18:
                goto L5f
            L1c:
                bool r0 = r0.pushedStream$okhttp(r2)
                goto L2b
            L24:
                goto L35
            L27:
                goto La
            L2b:
                if (r0 != 0) goto L30
                goto L18
            L30:
                goto L4
            L34:
                return
            L35:
                goto L4b
            L39:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r1.this$0
                goto L1c
            L3f:
                r1.receiveRstStream(r3)
                goto L34
            L46:
                return
            L47:
                goto L3f
            L4b:
                goto L27
            L4e:
                if (r1 == 0) goto L53
                goto L47
            L53:
                goto L46
            L57:
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r1 = r1.removeStream$okhttp(r2)
                goto L4e
            L5f:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r1 = r1.this$0
                goto L57
            L65:
                r1.pushResetLater$okhttp(r2, r3)
                goto L17
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void Settings(bool r10, p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r11) {
                r9 = this;
                goto L30
            L4:
                java.lang.string r4 = kotlin.jvm.internal.Intrinsics.stringPlus(r1, r2)
                goto L78
            Lc:
                goto L33
            Lf:
                if (r0 <= 0) goto L14
                goto L8f
            L14:
                goto L8c
            L18:
                p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r3 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r3
                goto L4e
            L1e:
                return
            L1f:
                goto L29
            L23:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r1 = r9.this$0
                goto La7
            L29:
                goto L8f
            L2c:
                goto Lc
            L30:
                goto L2c
            L33:
                goto L6b
            L37:
                r5 = 1
                goto L49
            L3c:
                java.lang.string r0 = "settings"
                goto L93
            L42:
                r3.<init>(r4, r5, r6, r7, r8)
                goto L18
            L49:
                r6 = r9
                goto L60
            L4e:
                r9 = 0
                goto La0
            L54:
                r8 = r11
                goto L42
            L59:
                r1 = 3
                goto L72
            L60:
                r7 = r10
                goto L54
            L65:
                int r0 = r0 % r1
                goto Lf
            L6b:
                r0 = 25
                goto L59
            L72:
                int r0 = r0 + r1
                goto L65
            L78:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$p2e5d8aa3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r3 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648$p2e5d8aa3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
                goto L37
            L7e:
                java.lang.string r2 = " applyAndAckHashSettings"
                goto L4
            L84:
                p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getWriterQueue$p(r0)
                goto L23
            L8c:
                goto L1f
            L8f:
                goto L3c
            L93:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r11, r0)
                goto L9a
            L9a:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = r9.this$0
                goto L84
            La0:
                r0.schedule(r3, r9)
                goto L1e
            La7:
                java.lang.string r1 = r1.getConnectionName$okhttp()
                goto L7e
        }

        @Override // p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e.p0bb4c52b
        public void WindowUpdate(int r3, long r4) {
                r2 = this;
                goto L64
            L4:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2 = r2.this$0
                goto La
            La:
                monitor-enter(r2)
                long r0 = r2.getWritebytesMaximum()     // Catch: java.lang.Exception -> L75
                long r0 = r0 + r4
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$setWritebytesMaximum$p(r2, r0)     // Catch: java.lang.Exception -> L75
                r3 = r2
                java.lang.object r3 = (java.lang.object) r3     // Catch: java.lang.Exception -> L75
                r3.notifyAll()     // Catch: java.lang.Exception -> L75
                kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L75
                goto L35
            L1f:
                throw r3
            L20:
                goto L7d
            L24:
                monitor-exit(r2)
                goto L82
            L29:
                monitor-exit(r2)
                goto L50
            L2e:
                r1 = 14
                goto L43
            L35:
                monitor-exit(r2)
                goto L74
            L3a:
                if (r0 <= 0) goto L3f
                goto L4c
            L3f:
                goto L49
            L43:
                int r0 = r0 + r1
                goto L97
            L49:
                goto L7e
            L4c:
                goto L6b
            L50:
                return
            L51:
                r3 = move-exception
                goto L56
            L56:
                monitor-exit(r2)
                goto L1f
            L5b:
                if (r2 != 0) goto L60
                goto L20
            L60:
                goto L8d
            L64:
                goto La0
            L67:
                goto Lac
            L6b:
                if (r3 == 0) goto L70
                goto L83
            L70:
                goto L4
            L74:
                return
            L75:
                r3 = move-exception
                goto L24
            L7a:
                goto L67
            L7d:
                return
            L7e:
                goto L9d
            L82:
                throw r3
            L83:
                goto L87
            L87:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2 = r2.this$0
                goto La4
            L8d:
                monitor-enter(r2)
                r2.addbytesToWriteWindow(r4)     // Catch: java.lang.Exception -> L51
                kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L51
                goto L29
            L97:
                int r0 = r0 % r1
                goto L3a
            L9d:
                goto L4c
            La0:
                goto L7a
            La4:
                p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r2 = r2.getStream(r3)
                goto L5b
            Lac:
                r0 = 13
                goto L2e
        }
    }

    @kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u0006\u00107\u001a\u000208J\u000e\u0010\u0011\u001a\u00020\u00002\u0006\u0010\u0011\u001a\u00020\u0012J\u000e\u0010\u0017\u001a\u00020\u00002\u0006\u0010\u0017\u001a\u00020\u0018J\u000e\u0010\u001d\u001a\u00020\u00002\u0006\u0010\u001d\u001a\u00020\u001eJ.\u0010)\u001a\u00020\u00002\u0006\u0010)\u001a\u00020*2\b\b\u0002\u00109\u001a\u00020\f2\b\b\u0002\u0010/\u001a\u0002002\b\b\u0002\u0010#\u001a\u00020$H\u0007R\u001a\u0010\u0002\u001a\u00020\u0003X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\nR\u001a\u0010\u000b\u001a\u00020\fX\u0080.¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u000e\"\u0004\b\u000f\u0010\u0010R\u001a\u0010\u0011\u001a\u00020\u0012X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0013\u0010\u0014\"\u0004\b\u0015\u0010\u0016R\u001a\u0010\u0017\u001a\u00020\u0018X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0019\u0010\u001a\"\u0004\b\u001b\u0010\u001cR\u001a\u0010\u001d\u001a\u00020\u001eX\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u001f\u0010 \"\u0004\b!\u0010\"R\u001a\u0010#\u001a\u00020$X\u0080.¢\u0006\u000e\n\u0000\u001a\u0004\b%\u0010&\"\u0004\b'\u0010(R\u001a\u0010)\u001a\u00020*X\u0080.¢\u0006\u000e\n\u0000\u001a\u0004\b+\u0010,\"\u0004\b-\u0010.R\u001a\u0010/\u001a\u000200X\u0080.¢\u0006\u000e\n\u0000\u001a\u0004\b1\u00102\"\u0004\b3\u00104R\u0014\u0010\u0004\u001a\u00020\u0005X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b5\u00106¨\u0006:"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p2bd4a59b;", "", "client", "", "taskRunner", "Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;", "(ZLp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;)V", "getClient$okhttp", "()Z", "setClient$okhttp", "(Z)V", "connectionName", "", "getConnectionName$okhttp", "()Ljava/lang/string;", "setConnectionName$okhttp", "(Ljava/lang/string;)V", "listener", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;", "getListener$okhttp", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;", "setListener$okhttp", "(Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p0c951aa4;)V", "pingIntervalMillis", "", "getPingIntervalMillis$okhttp", "()I", "setPingIntervalMillis$okhttp", "(I)V", "pushObserver", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p96b6dd38;", "getPushObserver$okhttp", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/p96b6dd38;", "setPushObserver$okhttp", "(Lp7ddcfee1/pd1efad72/p3cb89a9f/p96b6dd38;)V", "sink", "Lp38cb8f46/p08d84bc6;", "getSink$okhttp", "()Lp38cb8f46/p08d84bc6;", "setSink$okhttp", "(Lp38cb8f46/p08d84bc6;)V", "socket", "Ljava/net/Socket;", "getSocket$okhttp", "()Ljava/net/Socket;", "setSocket$okhttp", "(Ljava/net/Socket;)V", "source", "Lp38cb8f46/pcc81e3f6;", "getSource$okhttp", "()Lp38cb8f46/pcc81e3f6;", "setSource$okhttp", "(Lp38cb8f46/pcc81e3f6;)V", "getTaskRunner$okhttp", "()Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;", "build", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184;", "peerName", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static readonly class p2bd4a59b {
        private int f0feeadf4;
        public p38cb8f46.pcc81e3f6 f111893f0;
        private int f13ac1934;
        public java.lang.string f1a2e0cd3;
        private bool f1ddd9357;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 f1f96b9b6;
        public java.lang.string f26656d90;
        public java.net.Socket f26993b90;
        public p38cb8f46.p08d84bc6 f2702b197;
        private bool f3033a93c;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 f35ce15db;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 f366198b5;
        public p38cb8f46.pcc81e3f6 f36cd38f4;
        public java.net.Socket f40c39671;
        private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 f44a98691;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 f476f65d5;
        private bool f4d46cd7d;
        private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 f5c0e4218;
        public p38cb8f46.p08d84bc6 f619e1816;
        public java.net.Socket f61f25293;
        private bool f62608e08;
        private bool f66b826e9;
        private int f6dfd3d35;
        public p38cb8f46.pcc81e3f6 f6fdcf801;
        private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 f793f082c;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 f9c2cd46f;
        public p38cb8f46.p08d84bc6 fa76dab19;
        private int fa942e6d9;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 fd0b62cf0;
        public java.lang.string fd3a9a6ff;
        private readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 fdc540b29;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 fdf0d14be;
        private p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 ff2aadae6;
        public p38cb8f46.p08d84bc6 ff6e04117;

        public p2bd4a59b(bool r2, p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r3) {
                r1 = this;
                goto L1b
            L4:
                r1.f35ce15db = r2
                goto L46
            La:
                r1.<init>()
                goto L34
            L11:
                goto L1e
            L14:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto La
            L1b:
                goto L47
            L1e:
                goto L3a
            L22:
                r1.fd0b62cf0 = r2
                goto L40
            L28:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4 r2 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4.f8fb2b43c
                goto L22
            L2e:
                r1.f5c0e4218 = r3
                goto L28
            L34:
                r1.f62608e08 = r2
                goto L2e
            L3a:
                java.lang.string r0 = "taskRunner"
                goto L14
            L40:
                p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 r2 = p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38.f2027c027
                goto L4
            L46:
                return
            L47:
                goto L11
        }

        public static /* synthetic */ p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b socket$default(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b r0, java.net.Socket r1, java.lang.string r2, p38cb8f46.pcc81e3f6 r3, p38cb8f46.p08d84bc6 r4, int r5, java.lang.object r6) throws java.io.IOException {
                goto L61
            L4:
                r5 = r5 & 8
                goto L3c
            La:
                p38cb8f46.pcc81e3f6 r3 = p38cb8f46.p0af9afa4.m7f2db423(r3)
            Le:
                goto L4
            L12:
                p38cb8f46.pf31bbdd1 r3 = p38cb8f46.p0af9afa4.m36cd38f4(r1)
                goto La
            L1a:
                if (r6 != 0) goto L1f
                goto Le
            L1f:
                goto L12
            L23:
                if (r6 != 0) goto L28
                goto L30
            L28:
                goto L2c
            L2c:
                java.lang.string r2 = p7ddcfee1.pd1efad72.p23e8a4b4.peerName(r1)
            L30:
                goto L4a
            L34:
                p38cb8f46.p08d84bc6 r4 = p38cb8f46.p0af9afa4.m7f2db423(r4)
            L38:
                goto L68
            L3c:
                if (r5 != 0) goto L41
                goto L38
            L41:
                goto L59
            L45:
                return r0
            L46:
                goto L50
            L4a:
                r6 = r5 & 4
                goto L1a
            L50:
                goto L64
            L53:
                r6 = r5 & 2
                goto L23
            L59:
                p38cb8f46.p1eb558b5 r4 = p38cb8f46.p0af9afa4.mf6e04117(r1)
                goto L34
            L61:
                goto L46
            L64:
                goto L53
            L68:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r0 = r0.socket(r1, r2, r3, r4)
                goto L45
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 Build() {
                r1 = this;
                goto L19
            L4:
                return r0
            L5:
                goto L10
            L9:
                r0.<init>(r1)
                goto L4
            L10:
                goto L1c
            L13:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184
                goto L9
            L19:
                goto L5
            L1c:
                goto L13
        }

        public readonly bool getClient$okhttp() {
                r0 = this;
                goto L12
            L4:
                bool r0 = r0.f62608e08
                goto La
            La:
                return r0
            Lb:
                goto Lf
            Lf:
                goto L15
            L12:
                goto Lb
            L15:
                goto L4
        }

        public readonly java.lang.string getConnectionName$okhttp() {
                r0 = this;
                goto L4
            L4:
                goto L11
            L7:
                goto L15
            Lb:
                return r0
            Lc:
                goto L33
            L10:
                return r0
            L11:
                goto L1b
            L15:
                java.lang.string r0 = r0.f1a2e0cd3
                goto L1e
            L1b:
                goto L7
            L1e:
                if (r0 != 0) goto L23
                goto Lc
            L23:
                goto Lb
            L27:
                kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r0)
                goto L2e
            L2e:
                r0 = 0
                goto L10
            L33:
                java.lang.string r0 = "connectionName"
                goto L27
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 getListener$okhttp() {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto Lf
            L9:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4 r0 = r0.fd0b62cf0
                goto L4
            Lf:
                goto L15
            L12:
                goto L5
            L15:
                goto L9
        }

        public readonly int getPingIntervalMillis$okhttp() {
                r0 = this;
                goto L4
            L4:
                goto L12
            L7:
                goto Lb
            Lb:
                int r0 = r0.f6dfd3d35
                goto L11
            L11:
                return r0
            L12:
                goto L16
            L16:
                goto L7
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 getPushObserver$okhttp() {
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
                p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 r0 = r0.f35ce15db
                goto L7
        }

        public readonly p38cb8f46.p08d84bc6 getSink$okhttp() {
                r0 = this;
                goto L4
            L4:
                goto L1f
            L7:
                goto L11
            Lb:
                java.lang.string r0 = "sink"
                goto L17
            L11:
                p38cb8f46.p08d84bc6 r0 = r0.ff6e04117
                goto L23
            L17:
                kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r0)
                goto L2c
            L1e:
                return r0
            L1f:
                goto L31
            L23:
                if (r0 != 0) goto L28
                goto L35
            L28:
                goto L34
            L2c:
                r0 = 0
                goto L1e
            L31:
                goto L7
            L34:
                return r0
            L35:
                goto Lb
        }

        public readonly java.net.Socket getSocket$okhttp() {
                r0 = this;
                goto L2a
            L4:
                r0 = 0
                goto L25
            L9:
                java.lang.string r0 = "socket"
                goto Lf
            Lf:
                kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r0)
                goto L4
            L16:
                if (r0 != 0) goto L1b
                goto L32
            L1b:
                goto L31
            L1f:
                java.net.Socket r0 = r0.f61f25293
                goto L16
            L25:
                return r0
            L26:
                goto L36
            L2a:
                goto L26
            L2d:
                goto L1f
            L31:
                return r0
            L32:
                goto L9
            L36:
                goto L2d
        }

        public readonly p38cb8f46.pcc81e3f6 getSource$okhttp() {
                r0 = this;
                goto L22
            L4:
                goto L25
            L7:
                p38cb8f46.pcc81e3f6 r0 = r0.f36cd38f4
                goto Ld
            Ld:
                if (r0 != 0) goto L12
                goto L17
            L12:
                goto L16
            L16:
                return r0
            L17:
                goto L33
            L1b:
                kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(r0)
                goto L29
            L22:
                goto L2f
            L25:
                goto L7
            L29:
                r0 = 0
                goto L2e
            L2e:
                return r0
            L2f:
                goto L4
            L33:
                java.lang.string r0 = "source"
                goto L1b
        }

        public readonly p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 getTaskRunner$okhttp() {
                r0 = this;
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
                p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r0 = r0.f5c0e4218
                goto L4
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b Listener(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 r2) {
                r1 = this;
                goto L20
            L4:
                goto L23
            L7:
                r0 = r1
                goto L27
            Lc:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L7
            L13:
                r1.setListener$okhttp(r2)
                goto L2d
            L1a:
                java.lang.string r0 = "listener"
                goto Lc
            L20:
                goto L2e
            L23:
                goto L1a
            L27:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r0 = (p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b) r0
                goto L13
            L2d:
                return r1
            L2e:
                goto L4
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b PingIntervalMillis(int r2) {
                r1 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L1c
            La:
                goto L20
            Le:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r0 = (p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b) r0
                goto L14
            L14:
                r1.setPingIntervalMillis$okhttp(r2)
                goto L1b
            L1b:
                return r1
            L1c:
                goto L4
            L20:
                r0 = r1
                goto Le
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b PushObserver(p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 r2) {
                r1 = this;
                goto L4
            L4:
                goto L2e
            L7:
                goto L20
            Lb:
                r0 = r1
                goto L1a
            L10:
                r1.setPushObserver$okhttp(r2)
                goto L2d
            L17:
                goto L7
            L1a:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r0 = (p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b) r0
                goto L10
            L20:
                java.lang.string r0 = "pushObserver"
                goto L26
            L26:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto Lb
            L2d:
                return r1
            L2e:
                goto L17
        }

        public readonly void setClient$okhttp(bool r1) {
                r0 = this;
                goto L12
            L4:
                r0.f62608e08 = r1
                goto Ld
            La:
                goto L15
            Ld:
                return
            Le:
                goto La
            L12:
                goto Le
            L15:
                goto L4
        }

        public readonly void setConnectionName$okhttp(java.lang.string r2) {
                r1 = this;
                goto L12
            L4:
                return
            L5:
                goto Lf
            L9:
                r1.f1a2e0cd3 = r2
                goto L4
            Lf:
                goto L15
            L12:
                goto L5
            L15:
                goto L19
            L19:
                java.lang.string r0 = "<set-?>"
                goto L1f
            L1f:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L9
        }

        public readonly void setListener$okhttp(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 r2) {
                r1 = this;
                goto L11
            L4:
                r1.fd0b62cf0 = r2
                goto L21
            La:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L4
            L11:
                goto L22
            L14:
                goto L1b
            L18:
                goto L14
            L1b:
                java.lang.string r0 = "<set-?>"
                goto La
            L21:
                return
            L22:
                goto L18
        }

        public readonly void setPingIntervalMillis$okhttp(int r1) {
                r0 = this;
                goto L12
            L4:
                return
            L5:
                goto L9
            L9:
                goto L15
            Lc:
                r0.f6dfd3d35 = r1
                goto L4
            L12:
                goto L5
            L15:
                goto Lc
        }

        public readonly void setPushObserver$okhttp(p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 r2) {
                r1 = this;
                goto L11
            L4:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto Lb
            Lb:
                r1.f35ce15db = r2
                goto L1e
            L11:
                goto L1f
            L14:
                goto L18
            L18:
                java.lang.string r0 = "<set-?>"
                goto L4
            L1e:
                return
            L1f:
                goto L23
            L23:
                goto L14
        }

        public readonly void setSink$okhttp(p38cb8f46.p08d84bc6 r2) {
                r1 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L1c
            La:
                goto Le
            Le:
                java.lang.string r0 = "<set-?>"
                goto L14
            L14:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L20
            L1b:
                return
            L1c:
                goto L4
            L20:
                r1.ff6e04117 = r2
                goto L1b
        }

        public readonly void setSocket$okhttp(java.net.Socket r2) {
                r1 = this;
                goto Lf
            L4:
                java.lang.string r0 = "<set-?>"
                goto L19
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
            L19:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L20
            L20:
                r1.f61f25293 = r2
                goto La
        }

        public readonly void setSource$okhttp(p38cb8f46.pcc81e3f6 r2) {
                r1 = this;
                goto L4
            L4:
                goto L13
            L7:
                goto L17
            Lb:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L20
            L12:
                return
            L13:
                goto L1d
            L17:
                java.lang.string r0 = "<set-?>"
                goto Lb
            L1d:
                goto L7
            L20:
                r1.f36cd38f4 = r2
                goto L12
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b Socket(java.net.Socket r9) throws java.io.IOException {
                r8 = this;
                goto L42
            L4:
                goto L63
            L7:
                goto L5c
            Lb:
                r4 = 0
                goto L49
            L10:
                goto L45
            L13:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r8 = socket$default(r1, r2, r3, r4, r5, r6, r7)
                goto L62
            L1b:
                r6 = 14
                goto L6c
            L21:
                int r0 = r0 % r1
                goto L32
            L27:
                int r0 = r0 + r1
                goto L21
            L2d:
                r3 = 0
                goto Lb
            L32:
                if (r0 <= 0) goto L37
                goto L7
            L37:
                goto L4
            L3b:
                r0 = 27
                goto L55
            L42:
                goto L51
            L45:
                goto L3b
            L49:
                r5 = 0
                goto L67
            L4e:
                goto L7
            L51:
                goto L10
            L55:
                r1 = 26
                goto L27
            L5c:
                java.lang.string r0 = "socket"
                goto L76
            L62:
                return r8
            L63:
                goto L4e
            L67:
                r1 = r8
                goto L71
            L6c:
                r7 = 0
                goto L2d
            L71:
                r2 = r9
                goto L13
            L76:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r9, r0)
                goto L1b
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b Socket(java.net.Socket r9, java.lang.string r10) throws java.io.IOException {
                r8 = this;
                goto L36
            L4:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r8 = socket$default(r1, r2, r3, r4, r5, r6, r7)
                goto L69
            Lc:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r9, r0)
                goto L13
            L13:
                java.lang.string r0 = "peerName"
                goto L73
            L19:
                goto L6a
            L1c:
                goto L57
            L20:
                r4 = 0
                goto L3d
            L25:
                r1 = r8
                goto L6e
            L2a:
                r6 = 12
                goto L42
            L30:
                int r0 = r0 + r1
                goto L51
            L36:
                goto L7d
            L39:
                goto L5d
            L3d:
                r5 = 0
                goto L25
            L42:
                r7 = 0
                goto L20
            L47:
                goto L39
            L4a:
                r1 = 24
                goto L30
            L51:
                int r0 = r0 % r1
                goto L81
            L57:
                java.lang.string r0 = "socket"
                goto Lc
            L5d:
                r0 = 19
                goto L4a
            L64:
                r3 = r10
                goto L4
            L69:
                return r8
            L6a:
                goto L7a
            L6e:
                r2 = r9
                goto L64
            L73:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r0)
                goto L2a
            L7a:
                goto L1c
            L7d:
                goto L47
            L81:
                if (r0 <= 0) goto L86
                goto L1c
            L86:
                goto L19
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b Socket(java.net.Socket r9, java.lang.string r10, p38cb8f46.pcc81e3f6 r11) throws java.io.IOException {
                r8 = this;
                goto L3c
            L4:
                java.lang.string r0 = "socket"
                goto L26
            La:
                if (r0 <= 0) goto Lf
                goto L30
            Lf:
                goto L2d
            L13:
                int r0 = r0 % r1
                goto La
            L19:
                int r0 = r0 + r1
                goto L13
            L1f:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r0)
                goto L91
            L26:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r9, r0)
                goto L83
            L2d:
                goto L7f
            L30:
                goto L4
            L34:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r8 = socket$default(r1, r2, r3, r4, r5, r6, r7)
                goto L7e
            L3c:
                goto L5c
            L3f:
                goto L48
            L43:
                r5 = 0
                goto L72
            L48:
                r0 = 15
                goto L77
            L4f:
                r3 = r10
                goto L66
            L54:
                r7 = 0
                goto L43
            L59:
                goto L30
            L5c:
                goto L8e
            L60:
                r6 = 8
                goto L54
            L66:
                r4 = r11
                goto L34
            L6b:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r11, r0)
                goto L60
            L72:
                r1 = r8
                goto L89
            L77:
                r1 = 13
                goto L19
            L7e:
                return r8
            L7f:
                goto L59
            L83:
                java.lang.string r0 = "peerName"
                goto L1f
            L89:
                r2 = r9
                goto L4f
            L8e:
                goto L3f
            L91:
                java.lang.string r0 = "source"
                goto L6b
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b Socket(java.net.Socket r2, java.lang.string r3, p38cb8f46.pcc81e3f6 r4, p38cb8f46.p08d84bc6 r5) throws java.io.IOException {
                r1 = this;
                goto L40
            L4:
                java.lang.string r2 = r2.tostring()
                goto L35
            Lc:
                r1.setSocket$okhttp(r2)
                goto La3
            L13:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto L8d
            L1a:
                java.lang.stringBuilder r2 = r2.append(r0)
                goto L2f
            L22:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
                goto Lc5
            L29:
                p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p2bd4a59b r0 = (p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b) r0
                goto Lc
            L2f:
                r0 = 32
                goto L93
            L35:
                goto L9f
            L36:
                goto L58
            L3a:
                java.lang.string r0 = "peerName"
                goto L13
            L40:
                goto Lac
            L43:
                goto Lb0
            L47:
                goto L43
            L4a:
                r1.setSink$okhttp(r5)
                goto Lab
            L51:
                r2.<init>()
                goto L75
            L58:
                java.lang.string r2 = "MockWebServer "
                goto L9b
            L5e:
                r1.setSource$okhttp(r4)
                goto L4a
            L65:
                if (r2 != 0) goto L6a
                goto L36
            L6a:
                goto L87
            L6e:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
                goto L82
            L75:
                java.lang.string r0 = p7ddcfee1.pd1efad72.p23e8a4b4.ffcd12e30
                goto L1a
            L7b:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
                goto L3a
            L82:
                r0 = r1
                goto L29
            L87:
                java.lang.stringBuilder r2 = new java.lang.stringBuilder
                goto L51
            L8d:
                java.lang.string r0 = "source"
                goto L22
            L93:
                java.lang.stringBuilder r2 = r2.append(r0)
                goto Lb6
            L9b:
                java.lang.string r2 = kotlin.jvm.internal.Intrinsics.stringPlus(r2, r3)
            L9f:
                goto Lbe
            La3:
                bool r2 = r1.getClient$okhttp()
                goto L65
            Lab:
                return r1
            Lac:
                goto L47
            Lb0:
                java.lang.string r0 = "socket"
                goto L7b
            Lb6:
                java.lang.stringBuilder r2 = r2.append(r3)
                goto L4
            Lbe:
                r1.setConnectionName$okhttp(r2)
                goto L5e
            Lc5:
                java.lang.string r0 = "sink"
                goto L6e
        }
    }

    @kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u000e\u0010\t\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/p2d68e184$p910eef8c;", "", "()V", "AWAIT_PING", "", "DEFAULT_SETTINGS", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "getDEFAULT_SETTINGS", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "DEGRADED_PING", "DEGRADED_PONG_TIMEOUT_NS", "INTERVAL_PING", "OKHTTP_CLIENT_WINDOW_SIZE", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static readonly class p910eef8c {
        private p910eef8c() {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L16
            La:
                goto Le
            Le:
                r0.<init>()
                goto L15
            L15:
                return
            L16:
                goto L4
        }

        public /* synthetic */ p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker r1) {
                r0 = this;
                goto L13
            L4:
                return
            L5:
                goto L10
            L9:
                r0.<init>()
                goto L4
            L10:
                goto L16
            L13:
                goto L5
            L16:
                goto L9
        }

        public readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 GetDEFAULTSETTINGS() {
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
                p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.access$getDEFAULT_SETTINGS$cp()
                goto Lb
        }
    }

    static {
            goto L7f
        L4:
            goto L13
        L7:
            goto L5f
        Lb:
            r1 = 0
            goto L62
        L10:
            goto L43
        L13:
            goto L59
        L17:
            r2 = 65535(0xffff, float:9.1834E-41)
            goto L52
        L1e:
            r1 = 17
            goto L3c
        L25:
            int r0 = r0 % r1
            goto L76
        L2b:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727
            goto L86
        L31:
            r1 = 5
            goto L47
        L36:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.f910eef8c = r0
            goto L2b
        L3c:
            int r0 = r0 + r1
            goto L25
        L42:
            return
        L43:
            goto L4
        L47:
            r2 = 16384(0x4000, float:2.2959E-41)
            goto L8d
        L4d:
            r1 = 7
            goto L17
        L52:
            r0.set(r1, r2)
            goto L31
        L59:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p910eef8c r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p910eef8c
            goto Lb
        L5f:
            goto L82
        L62:
            r0.<init>(r1)
            goto L36
        L69:
            r0 = 3
            goto L1e
        L70:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.ff8ca1fc5 = r0
            goto L42
        L76:
            if (r0 <= 0) goto L7b
            goto L13
        L7b:
            goto L10
        L7f:
            goto L7
        L82:
            goto L69
        L86:
            r0.<init>()
            goto L4d
        L8d:
            r0.set(r1, r2)
            goto L70
    }

    public p2d68e184(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p2bd4a59b r7) {
            r6 = this;
            goto L1e5
        L4:
            r6.f61f25293 = r2
            goto L1c0
        La:
            r6.fafd22e63 = r0
            goto Lef
        L10:
            p38cb8f46.p08d84bc6 r4 = r7.getSink$okhttp()
            goto L13e
        L18:
            r0.<init>()
            goto Lb6
        L1f:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r2 = r2.newQueue()
            goto L200
        L27:
            r6.f62608e08 = r0
            goto L115
        L2d:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648
            goto L1cc
        L33:
            r6.f35ce15db = r2
            goto Lc9
        L39:
            long r4 = (long) r7
            goto L12f
        L3e:
            bool r0 = r7.getClient$okhttp()
            goto L27
        L46:
            r6.f99bf7c1e = r4
            goto L1f
        L4c:
            if (r0 != 0) goto L51
            goto L96
        L51:
            goto L14d
        L55:
            r6.f5c0e4218 = r2
            goto L17f
        L5b:
            bool r2 = r7.getClient$okhttp()
            goto La1
        L63:
            int r2 = r2.getInitialWindowSize()
            goto L1af
        L6b:
            java.lang.string r1 = r7.getConnectionName$okhttp()
            goto L1a9
        L73:
            r2.set(r4, r5)
        L76:
            goto L1b4
        L7a:
            r5 = 16777216(0x1000000, float:2.3509887E-38)
            goto L73
        L80:
            r2 = 3
            goto L1c6
        L85:
            r2.<init>()
            goto L16f
        L8c:
            r1 = 26
            goto L20c
        L93:
            r3.schedule(r0, r4)
        L96:
            goto L15b
        L9a:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r7, r0)
            goto L1f9
        La1:
            if (r2 != 0) goto La6
            goto L1c8
        La6:
            goto L80
        Laa:
            r6.fa82feee3 = r2
            goto L2d
        Lb0:
            r6.fd0b62cf0 = r1
            goto L206
        Lb6:
            java.util.HashSet r0 = (java.util.HashSet) r0
            goto La
        Lbc:
            goto L16b
        Lbf:
            goto Le0
        Lc3:
            java.util.LinkedHashHashSet r0 = new java.util.LinkedHashHashSet
            goto L18
        Lc9:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727
            goto L85
        Lcf:
            r2 = 2
        Ld0:
            goto L1a3
        Ld4:
            r4 = 7
            goto L7a
        Ld9:
            r0 = 12
            goto L8c
        Le0:
            goto L1e8
        Le3:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0bd65069$pd41d8cd9$pec404527$p79985559$1 r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0bd65069$pd41d8cd9$pec404527$p79985559$1
            goto L137
        Le9:
            int r0 = r0 % r1
            goto L10c
        Lef:
            int r0 = r7.getPingIntervalMillis$okhttp()
            goto L4c
        Lf7:
            r6.f1f65fe92 = r2
            goto Lc3
        Lfd:
            r1.<init>()
            goto L123
        L104:
            p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 r2 = r7.getPushObserver$okhttp()
            goto L33
        L10c:
            if (r0 <= 0) goto L111
            goto L16b
        L111:
            goto L168
        L115:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4 r1 = r7.getListener$okhttp()
            goto Lb0
        L11d:
            r6.f2f6f4768 = r1
            goto L6b
        L123:
            java.util.Dictionary r1 = (java.util.Dictionary) r1
            goto L11d
        L129:
            java.lang.string r0 = "builder"
            goto L9a
        L12f:
            long r4 = r0.toNanos(r4)
            goto L19d
        L137:
            r0.<init>(r7, r6, r4)
            goto L1d8
        L13e:
            r2.<init>(r4, r0)
            goto Laa
        L145:
            p38cb8f46.pcc81e3f6 r5 = r7.getSource$okhttp()
            goto L1de
        L14d:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.MILLISECONDS
            goto L187
        L153:
            p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r2 = r7.getTaskRunner$okhttp()
            goto L55
        L15b:
            return
        L15c:
            goto Lbc
        L160:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r4 = r2.newQueue()
            goto L46
        L168:
            goto L15c
        L16b:
            goto L129
        L16f:
            bool r4 = r7.getClient$okhttp()
            goto L212
        L177:
            java.lang.string r7 = kotlin.jvm.internal.Intrinsics.stringPlus(r1, r7)
            goto Le3
        L17f:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r3 = r2.newQueue()
            goto L1d2
        L187:
            int r7 = r7.getPingIntervalMillis$okhttp()
            goto L39
        L18f:
            r6.f95e9b297 = r2
            goto L63
        L195:
            java.net.Socket r2 = r7.getSocket$okhttp()
            goto L4
        L19d:
            java.lang.string r7 = " ping"
            goto L177
        L1a3:
            r6.fb973a5d8 = r2
            goto L153
        L1a9:
            r6.f1a2e0cd3 = r1
            goto L5b
        L1af:
            long r4 = (long) r2
            goto L1f3
        L1b4:
            r6.fe10edc3d = r2
            goto L1ba
        L1ba:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r2 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.ff8ca1fc5
            goto L18f
        L1c0:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a
            goto L10
        L1c6:
            goto Ld0
        L1c8:
            goto Lcf
        L1cc:
            p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e r4 = new p7ddcfee1.pd1efad72.p3cb89a9f.p1b0ecc4e
            goto L145
        L1d2:
            r6.ffed859a6 = r3
            goto L160
        L1d8:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r0 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r0
            goto L93
        L1de:
            r4.<init>(r5, r0)
            goto L1ec
        L1e5:
            goto Lbf
        L1e8:
            goto Ld9
        L1ec:
            r2.<init>(r6, r4)
            goto Lf7
        L1f3:
            r6.fe68e41cd = r4
            goto L195
        L1f9:
            r6.<init>()
            goto L3e
        L200:
            r6.f0521301c = r2
            goto L104
        L206:
            java.util.LinkedHashDictionary r1 = new java.util.LinkedHashDictionary
            goto Lfd
        L20c:
            int r0 = r0 + r1
            goto Le9
        L212:
            if (r4 != 0) goto L217
            goto L76
        L217:
            goto Ld4
    }

    public static readonly /* synthetic */ void access$failConnection(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, java.io.IOException r1) {
            goto Le
        L4:
            r0.failConnection(r1)
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

    public static readonly /* synthetic */ long access$getAwaitPongsReceived$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2) {
            goto Lb
        L4:
            r1 = 24
            goto L27
        Lb:
            goto L1e
        Le:
            goto L3d
        L12:
            if (r0 <= 0) goto L17
            goto L36
        L17:
            goto L33
        L1b:
            goto L36
        L1e:
            goto L3a
        L22:
            return r0
        L23:
            goto L1b
        L27:
            int r0 = r0 + r1
            goto L44
        L2d:
            long r0 = r2.fd0739828
            goto L22
        L33:
            goto L23
        L36:
            goto L2d
        L3a:
            goto Le
        L3d:
            r0 = 11
            goto L4
        L44:
            int r0 = r0 % r1
            goto L12
    }

    public static readonly /* synthetic */ java.util.HashSet access$getCurrentPushRequests$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0) {
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
            java.util.HashSet<java.lang.int> r0 = r0.fafd22e63
            goto Le
    }

    public static readonly /* synthetic */ p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 access$getDEFAULT_SETTINGS$cp() {
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.ff8ca1fc5
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    public static readonly /* synthetic */ long access$getDegradedPongsReceived$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2) {
            goto L20
        L4:
            r1 = 16
            goto L41
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L3d
        L13:
            goto L47
        L17:
            if (r0 <= 0) goto L1c
            goto L3d
        L1c:
            goto L3a
        L20:
            goto L13
        L23:
            goto L33
        L27:
            long r0 = r2.f42095970
            goto Lb
        L2d:
            int r0 = r0 % r1
            goto L17
        L33:
            r0 = 10
            goto L4
        L3a:
            goto Lc
        L3d:
            goto L27
        L41:
            int r0 = r0 + r1
            goto L2d
        L47:
            goto L23
    }

    public static readonly /* synthetic */ long access$getIntervalPingsSent$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2) {
            goto L4
        L4:
            goto L38
        L7:
            goto L1a
        Lb:
            goto L7
        Le:
            int r0 = r0 + r1
            goto L2f
        L14:
            long r0 = r2.f5bab8e96
            goto L45
        L1a:
            r0 = 8
            goto L28
        L21:
            goto L46
        L24:
            goto L14
        L28:
            r1 = 22
            goto Le
        L2f:
            int r0 = r0 % r1
            goto L3c
        L35:
            goto L24
        L38:
            goto Lb
        L3c:
            if (r0 <= 0) goto L41
            goto L24
        L41:
            goto L21
        L45:
            return r0
        L46:
            goto L35
    }

    public static readonly /* synthetic */ long access$getIntervalPongsReceived$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r2) {
            goto L1e
        L4:
            return r0
        L5:
            goto L28
        L9:
            int r0 = r0 % r1
            goto Lf
        Lf:
            if (r0 <= 0) goto L14
            goto L38
        L14:
            goto L35
        L18:
            int r0 = r0 + r1
            goto L9
        L1e:
            goto L2b
        L21:
            goto L3c
        L25:
            goto L21
        L28:
            goto L38
        L2b:
            goto L25
        L2f:
            long r0 = r2.fffd0d62d
            goto L4
        L35:
            goto L5
        L38:
            goto L2f
        L3c:
            r0 = 2
            goto L43
        L43:
            r1 = 3
            goto L18
    }

    public static readonly /* synthetic */ p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 access$getPushObserver$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0) {
            goto L12
        L4:
            goto L15
        L7:
            return r0
        L8:
            goto L4
        Lc:
            p7ddcfee1.pd1efad72.p3cb89a9f.p96b6dd38 r0 = r0.f35ce15db
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    public static readonly /* synthetic */ p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 access$getHashSettingsListenerQueue$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r0.f0521301c
            goto Lb
        L16:
            goto L7
    }

    public static readonly /* synthetic */ p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 access$getTaskRunner$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0) {
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r0 = r0.f5c0e4218
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    public static readonly /* synthetic */ p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 access$getWriterQueue$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0) {
            goto La
        L4:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r0.ffed859a6
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

    public static readonly /* synthetic */ bool access$isShutdown$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0) {
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            bool r0 = r0.f8aea5ac4
            goto L14
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
    }

    public static readonly /* synthetic */ void access$setAwaitPongsReceived$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, long r1) {
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
            r0.fd0739828 = r1
            goto Lb
        L16:
            goto L7
    }

    public static readonly /* synthetic */ void access$setDegradedPongsReceived$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, long r1) {
            goto Ld
        L4:
            goto L10
        L7:
            r0.f42095970 = r1
            goto L14
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return
        L15:
            goto L4
    }

    public static readonly /* synthetic */ void access$setIntervalPingsSent$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, long r1) {
            goto La
        L4:
            r0.f5bab8e96 = r1
            goto L14
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
    }

    public static readonly /* synthetic */ void access$setIntervalPongsReceived$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, long r1) {
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
            r0.fffd0d62d = r1
            goto Le
    }

    public static readonly /* synthetic */ void access$setShutdown$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, bool r1) {
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
            r0.f8aea5ac4 = r1
            goto Le
    }

    public static readonly /* synthetic */ void access$setWritebytesMaximum$p(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, long r1) {
            goto Ld
        L4:
            goto L10
        L7:
            r0.fe68e41cd = r1
            goto L14
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return
        L15:
            goto L4
    }

    private readonly void FailConnection(java.io.IOException r3) {
            r2 = this;
            goto L50
        L4:
            goto L1b
        L7:
            goto L28
        Lb:
            int r0 = r0 + r1
            goto L3d
        L11:
            r0 = 30
            goto L31
        L18:
            goto L39
        L1b:
            goto L2b
        L1f:
            if (r0 <= 0) goto L24
            goto L1b
        L24:
            goto L18
        L28:
            goto L53
        L2b:
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0
            goto L4a
        L31:
            r1 = 29
            goto Lb
        L38:
            return
        L39:
            goto L4
        L3d:
            int r0 = r0 % r1
            goto L1f
        L43:
            r2.close$okhttp(r0, r1, r3)
            goto L38
        L4a:
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r1 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0
            goto L43
        L50:
            goto L7
        L53:
            goto L11
    }

    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 NewStream(int r10, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r11, bool r12) throws java.io.IOException {
            r9 = this;
            goto Lbf
        L4:
            r2 = r9
            r0.<init>(r1, r2, r3, r4, r5)     // Catch: java.lang.Exception -> L71
            if (r12 == 0) goto L25
            long r4 = r2.getWritebytesTotal()     // Catch: java.lang.Exception -> L71
            long r7 = r2.getWritebytesMaximum()     // Catch: java.lang.Exception -> L71
            int r9 = (r4 > r7 ? 1 : (r4 == r7 ? 0 : -1))
            if (r9 >= 0) goto L25
            long r4 = r0.getWritebytesTotal()     // Catch: java.lang.Exception -> L71
            long r7 = r0.getWritebytesMaximum()     // Catch: java.lang.Exception -> L71
            int r9 = (r4 > r7 ? 1 : (r4 == r7 ? 0 : -1))
            if (r9 < 0) goto L23
            goto L25
        L23:
            r9 = 0
            goto L26
        L25:
            r9 = 1
        L26:
            bool r12 = r0.isOpen()     // Catch: java.lang.Exception -> L71
            if (r12 == 0) goto L37
            java.util.Dictionary r12 = r2.getStreams$okhttp()     // Catch: java.lang.Exception -> L71
            java.lang.int r4 = java.lang.int.valueOf(r1)     // Catch: java.lang.Exception -> L71
            r12.Add(r4, r0)     // Catch: java.lang.Exception -> L71
        L37:
            kotlin.Unit r12 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L71
            monitor-exit(r2)     // Catch: java.lang.Exception -> L89
            if (r10 != 0) goto L44
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r10 = r2.getWriter()     // Catch: java.lang.Exception -> L89
            r10.headers(r3, r1, r11)     // Catch: java.lang.Exception -> L89
            goto L51
        L44:
            bool r12 = r2.getClient$okhttp()     // Catch: java.lang.Exception -> L89
            if (r12 != 0) goto L10c
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r12 = r2.getWriter()     // Catch: java.lang.Exception -> L89
            r12.pushPromise(r10, r1, r11)     // Catch: java.lang.Exception -> L89
        L51:
            kotlin.Unit r10 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L89
            goto Lc6
        L57:
            goto L11e
        L59:
            r0 = move-exception
            goto Ld7
        L5e:
            r2 = r9
            goto L11c
        L63:
            goto Le9
        L65:
            r0 = move-exception
            goto Le8
        L6a:
            r2 = r9
            p7ddcfee1.pd1efad72.p3cb89a9f.p0172e76e r9 = new p7ddcfee1.pd1efad72.p3cb89a9f.p0172e76e     // Catch: java.lang.Exception -> L71
            r9.<init>()     // Catch: java.lang.Exception -> L71
            throw r9     // Catch: java.lang.Exception -> L71
        L71:
            r0 = move-exception
            goto L63
        L76:
            goto Lc2
        L79:
            r3 = r12 ^ 1
            goto Ldc
        L7f:
            goto L96
        L82:
            goto L76
        L86:
            r10 = r0
        L87:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L89
            throw r10     // Catch: java.lang.Exception -> L89
        L89:
            r0 = move-exception
            goto L147
        L8e:
            r5 = 0
            goto L135
        L93:
            goto La4
        L96:
            goto L79
        L9a:
            if (r0 <= 0) goto L9f
            goto L96
        L9f:
            goto L93
        La3:
            throw r9
        La4:
            goto L7f
        La8:
            r1 = 1073741823(0x3fffffff, float:1.9999999)
            goto Led
        Laf:
            if (r9 != 0) goto Lb4
            goto Ld3
        Lb4:
            goto L141
        Lb8:
            r1 = 27
            goto Le2
        Lbf:
            goto L82
        Lc2:
            goto L13a
        Lc6:
            monitor-exit(r6)
            goto Laf
        Lcb:
            monitor-exit(r6)
            goto La3
        Ld0:
            r9.flush()
        Ld3:
            goto L10b
        Ld7:
            r10 = r0
            goto L5e
        Ldc:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r6 = r9.fa82feee3
            goto Lfb
        Le2:
            int r0 = r0 + r1
            goto L105
        Le8:
            r2 = r9
        Le9:
            goto L86
        Led:
            if (r0 > r1) goto Lf2
            goto L11e
        Lf2:
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f3e2449dc     // Catch: java.lang.Exception -> L59
            r9.shutdown(r0)     // Catch: java.lang.Exception -> L59
            goto L57
        Lfb:
            monitor-enter(r6)
            monitor-enter(r9)     // Catch: java.lang.Exception -> L89
            int r0 = r9.getNextStreamId$okhttp()     // Catch: java.lang.Exception -> L65
            goto La8
        L105:
            int r0 = r0 % r1
            goto L9a
        L10b:
            return r0
        L10c:
            java.lang.string r9 = "client streams shouldn't have associated stream IDs"
            java.lang.IllegalArgumentException r10 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L89
            java.lang.string r9 = r9.tostring()     // Catch: java.lang.Exception -> L89
            r10.<init>(r9)     // Catch: java.lang.Exception -> L89
            throw r10     // Catch: java.lang.Exception -> L89
        L118:
            goto L6a
        L11c:
            goto L87
        L11e:
            bool r0 = r9.f8aea5ac4     // Catch: java.lang.Exception -> L65
            if (r0 != 0) goto L118
            int r1 = r9.getNextStreamId$okhttp()     // Catch: java.lang.Exception -> L65
            int r0 = r9.getNextStreamId$okhttp()     // Catch: java.lang.Exception -> L65
            int r0 = r0 + 2
            r9.setNextStreamId$okhttp(r0)     // Catch: java.lang.Exception -> L65
            p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6     // Catch: java.lang.Exception -> L65
            goto L8e
        L135:
            r4 = 0
            goto L4
        L13a:
            r0 = 10
            goto Lb8
        L141:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r9 = r2.fa82feee3
            goto Ld0
        L147:
            r9 = r0
            goto Lcb
    }

    public static /* synthetic */ void start$default(p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184 r0, bool r1, p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r2, int r3, java.lang.object r4) throws java.io.IOException {
            goto L18
        L4:
            if (r3 != 0) goto L9
            goto L21
        L9:
            goto L1f
        Ld:
            r4 = r3 & 1
            goto L25
        L13:
            r1 = 1
        L14:
            goto L3a
        L18:
            goto L36
        L1b:
            goto Ld
        L1f:
            p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r2 = p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60.f76425f17
        L21:
            goto L2e
        L25:
            if (r4 != 0) goto L2a
            goto L14
        L2a:
            goto L13
        L2e:
            r0.start(r1, r2)
            goto L35
        L35:
            return
        L36:
            goto L40
        L3a:
            r3 = r3 & 2
            goto L4
        L40:
            goto L1b
    }

    public readonly void AwaitPong() throws java.lang.InterruptedException {
            r4 = this;
            goto L52
        L4:
            r1 = 31
            goto L37
        Lb:
            r0 = 13
            goto L4
        L12:
            goto L4e
        L15:
            goto L59
        L19:
            monitor-exit(r4)
            goto L5c
        L1e:
            monitor-enter(r4)
        L1f:
            long r0 = r4.fd0739828     // Catch: java.lang.Exception -> L5d
            long r2 = r4.f6f1fd9b9     // Catch: java.lang.Exception -> L5d
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            if (r0 >= 0) goto L64
            r0 = r4
            java.lang.object r0 = (java.lang.object) r0     // Catch: java.lang.Exception -> L5d
            r0.wait()     // Catch: java.lang.Exception -> L5d
            goto L63
        L31:
            int r0 = r0 % r1
            goto L3d
        L37:
            int r0 = r0 + r1
            goto L31
        L3d:
            if (r0 <= 0) goto L42
            goto L4e
        L42:
            goto L4b
        L46:
            throw r0
        L47:
            goto L12
        L4b:
            goto L47
        L4e:
            goto L1e
        L52:
            goto L15
        L55:
            goto Lb
        L59:
            goto L55
        L5c:
            return
        L5d:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L5d
            goto L46
        L63:
            goto L1f
        L64:
            goto L19
    }

    @Override // java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() {
            r3 = this;
            goto L40
        L4:
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r0 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.fd306b6fd
            goto L33
        La:
            int r0 = r0 + r1
            goto L2d
        L10:
            goto L3c
        L13:
            goto L17
        L17:
            goto L43
        L1a:
            r1 = 29
            goto La
        L21:
            r0 = 3
            goto L1a
        L28:
            r2 = 0
            goto L55
        L2d:
            int r0 = r0 % r1
            goto L4c
        L33:
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r1 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f2027c027
            goto L28
        L39:
            goto L48
        L3c:
            goto L4
        L40:
            goto L13
        L43:
            goto L21
        L47:
            return
        L48:
            goto L10
        L4c:
            if (r0 <= 0) goto L51
            goto L3c
        L51:
            goto L39
        L55:
            r3.close$okhttp(r0, r1, r2)
            goto L47
    }

    public readonly void close$okhttp(p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r4, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r5, java.io.IOException r6) {
            r3 = this;
            goto Ld3
        L4:
            r1 = 11
            goto L16a
        Lb:
            java.lang.string r0 = "streamCode"
            goto L13d
        L11:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L94
        L17:
            java.lang.string r3 = r3.tostring()
            goto Lab
        L1f:
            r5.<init>(r6)
            goto Le5
        L26:
            goto Lc6
        L28:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r4 = r3.getWriter()     // Catch: java.io.IOException -> L2f
            r4.Dispose()     // Catch: java.io.IOException -> L2f
        L2f:
            java.net.Socket r4 = r3.getSocket$okhttp()     // Catch: java.io.IOException -> L36
            r4.Dispose()     // Catch: java.io.IOException -> L36
        L36:
            goto Lbf
        L3a:
            monitor-enter(r3)
            java.util.Dictionary r4 = r3.getStreams$okhttp()     // Catch: java.lang.Exception -> L12d
            bool r4 = r4.Count == 0     // Catch: java.lang.Exception -> L12d
            r0 = 0
            if (r4 != 0) goto L66
            java.util.Dictionary r4 = r3.getStreams$okhttp()     // Catch: java.lang.Exception -> L12d
            java.util.ICollection r4 = r4.Values     // Catch: java.lang.Exception -> L12d
            p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[] r1 = new p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[r0]     // Catch: java.lang.Exception -> L12d
            java.lang.object[] r4 = r4.toArray(r1)     // Catch: java.lang.Exception -> L12d
            if (r4 == 0) goto L5e
            java.util.Dictionary r1 = r3.getStreams$okhttp()     // Catch: java.lang.Exception -> L12d
            r1.clear()     // Catch: java.lang.Exception -> L12d
            goto L67
        L5e:
            java.lang.NullPointerException r4 = new java.lang.NullPointerException     // Catch: java.lang.Exception -> L12d
            java.lang.string r5 = "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>"
            r4.<init>(r5)     // Catch: java.lang.Exception -> L12d
            throw r4     // Catch: java.lang.Exception -> L12d
        L66:
            r4 = 0
        L67:
            kotlin.Unit r1 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L12d
            goto L118
        L6d:
            java.lang.AssertionError r4 = new java.lang.AssertionError
            goto L11
        L73:
            java.lang.stringBuilder r5 = r5.append(r6)
            goto L103
        L7b:
            if (r0 < r1) goto L80
            goto L28
        L80:
            goto L188
        L84:
            r4.shutdown()
            goto La5
        L8b:
            if (r0 <= 0) goto L90
            goto L150
        L90:
            goto L14d
        L94:
            java.lang.string r6 = "Thread "
            goto L1f
        L9a:
            java.lang.string r6 = " MUST NOT hold lock on "
            goto L73
        La0:
            goto Lf5
        La1:
            goto L6d
        La5:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r3 = r3.f0521301c
            goto Lb8
        Lab:
            r4.<init>(r3)
            goto Lf4
        Lb2:
            java.lang.string r0 = "connectionCode"
            goto Lfc
        Lb8:
            r3.shutdown()
            goto L12c
        Lbf:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r4 = r3.ffed859a6
            goto L15d
        Lc5:
            int r1 = r4.length
        Lc6:
            goto L7b
        Lca:
            if (r0 == 0) goto Lcf
            goto La1
        Lcf:
            goto La0
        Ld3:
            goto L128
        Ld6:
            goto Led
        Lda:
            goto L28
        Ldc:
            goto Lc5
        Le0:
            throw r4
        Le1:
            goto L125
        Le5:
            java.lang.Thread r6 = java.lang.Thread.currentThread()
            goto L10b
        Led:
            r0 = 24
            goto L4
        Lf4:
            throw r4
        Lf5:
            r3.shutdown(r4)     // Catch: java.io.IOException -> Lf8
        Lf8:
            goto L3a
        Lfc:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto Lb
        L103:
            java.lang.stringBuilder r3 = r5.append(r3)
            goto L17
        L10b:
            java.lang.string r6 = r6.getName()
            goto L11d
        L113:
            monitor-exit(r3)
            goto Le0
        L118:
            monitor-exit(r3)
            goto L182
        L11d:
            java.lang.stringBuilder r5 = r5.append(r6)
            goto L9a
        L125:
            goto L150
        L128:
            goto L132
        L12c:
            return
        L12d:
            r4 = move-exception
            goto L113
        L132:
            goto Ld6
        L135:
            bool r0 = java.lang.Thread.holdsLock(r3)
            goto Lca
        L13d:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto L17c
        L144:
            if (r4 == 0) goto L149
            goto Ldc
        L149:
            goto Lda
        L14d:
            goto Le1
        L150:
            goto Lb2
        L154:
            if (r0 != 0) goto L159
            goto Lf5
        L159:
            goto L135
        L15d:
            r4.shutdown()
            goto L164
        L164:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r4 = r3.f99bf7c1e
            goto L84
        L16a:
            int r0 = r0 + r1
            goto L176
        L170:
            int r0 = r0 + 1
            goto L26
        L176:
            int r0 = r0 % r1
            goto L8b
        L17c:
            bool r0 = p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
            goto L154
        L182:
            p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[] r4 = (p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6[]) r4
            goto L144
        L188:
            r2 = r4[r0]
            r2.close(r5, r6)     // Catch: java.io.IOException -> L18d
        L18d:
            goto L170
    }

    public readonly void Flush() throws java.io.IOException {
            r0 = this;
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.flush()
            goto L4
        L10:
            goto L5
        L13:
            goto L1a
        L17:
            goto L13
        L1a:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r0 = r0.fa82feee3
            goto L9
    }

    public readonly bool getClient$okhttp() {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            bool r0 = r0.f62608e08
            goto L11
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L7
    }

    public readonly java.lang.string getConnectionName$okhttp() {
            r0 = this;
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
            java.lang.string r0 = r0.f1a2e0cd3
            goto Le
    }

    public readonly int getLastGoodStreamId$okhttp() {
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
            int r0 = r0.fe2d806df
            goto Lb
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p0c951aa4 getListener$okhttp() {
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
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p0c951aa4 r0 = r0.fd0b62cf0
            goto L4
    }

    public readonly int getNextStreamId$okhttp() {
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
            int r0 = r0.fb973a5d8
            goto Le
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 GetOkHttpHashSettings() {
            r0 = this;
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
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = r0.fe10edc3d
            goto L4
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 GetPeerHashSettings() {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = r0.f95e9b297
            goto L11
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L7
    }

    public readonly long GetReadbytesAcknowledged() {
            r2 = this;
            goto L43
        L4:
            int r0 = r0 + r1
            goto L14
        La:
            r1 = 4
            goto L4
        L11:
            goto L46
        L14:
            int r0 = r0 % r1
            goto L21
        L1a:
            r0 = 19
            goto La
        L21:
            if (r0 <= 0) goto L26
            goto L3a
        L26:
            goto L37
        L2a:
            goto L3a
        L2d:
            goto L11
        L31:
            long r0 = r2.ff003faaf
            goto L3e
        L37:
            goto L3f
        L3a:
            goto L31
        L3e:
            return r0
        L3f:
            goto L2a
        L43:
            goto L2d
        L46:
            goto L1a
    }

    public readonly long GetReadbytesTotal() {
            r2 = this;
            goto L14
        L4:
            goto L17
        L7:
            goto L46
        La:
            goto L2f
        Le:
            int r0 = r0 + r1
            goto L29
        L14:
            goto L41
        L17:
            goto L22
        L1b:
            r1 = 3
            goto Le
        L22:
            r0 = 27
            goto L1b
        L29:
            int r0 = r0 % r1
            goto L35
        L2f:
            long r0 = r2.f098f5c58
            goto L45
        L35:
            if (r0 <= 0) goto L3a
            goto La
        L3a:
            goto L7
        L3e:
            goto La
        L41:
            goto L4
        L45:
            return r0
        L46:
            goto L3e
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184.p28bdc648 GetReaderAction() {
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
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648 r0 = r0.f1f65fe92
            goto L4
    }

    public readonly java.net.Socket getSocket$okhttp() {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L16
        L10:
            java.net.Socket r0 = r0.f61f25293
            goto Lb
        L16:
            goto L7
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 GetStream(int r2) {
            r1 = this;
            goto L4
        L4:
            goto L22
        L7:
            goto Lb
        Lb:
            monitor-enter(r1)
            java.util.Dictionary<java.lang.int, p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6> r0 = r1.f2f6f4768     // Catch: java.lang.Exception -> L2a
            java.lang.int r2 = java.lang.int.valueOf(r2)     // Catch: java.lang.Exception -> L2a
            java.lang.object r2 = r0[r2)     // Catch: java.lang.Exception -> L2a
            p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r2 = (p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6) r2     // Catch: java.lang.Exception -> L2a
            goto L1c
        L1c:
            monitor-exit(r1)
            goto L29
        L21:
            throw r2
        L22:
            goto L26
        L26:
            goto L7
        L29:
            return r2
        L2a:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L2a
            goto L21
    }

    public readonly java.util.Dictionary<java.lang.int, p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6> getStreams$okhttp() {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            java.util.Dictionary<java.lang.int, p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6> r0 = r0.f2f6f4768
            goto L14
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
    }

    public readonly long GetWritebytesMaximum() {
            r2 = this;
            goto L30
        L4:
            long r0 = r2.fe68e41cd
            goto L45
        La:
            goto L33
        Ld:
            if (r0 <= 0) goto L12
            goto L19
        L12:
            goto L16
        L16:
            goto L46
        L19:
            goto L4
        L1d:
            int r0 = r0 + r1
            goto L23
        L23:
            int r0 = r0 % r1
            goto Ld
        L29:
            r1 = 3
            goto L1d
        L30:
            goto L3a
        L33:
            goto L3e
        L37:
            goto L19
        L3a:
            goto La
        L3e:
            r0 = 15
            goto L29
        L45:
            return r0
        L46:
            goto L37
    }

    public readonly long GetWritebytesTotal() {
            r2 = this;
            goto L43
        L4:
            int r0 = r0 + r1
            goto L3d
        La:
            long r0 = r2.fca5ceb37
            goto L10
        L10:
            return r0
        L11:
            goto L2f
        L15:
            goto L11
        L18:
            goto La
        L1c:
            if (r0 <= 0) goto L21
            goto L18
        L21:
            goto L15
        L25:
            r0 = 32
            goto L36
        L2c:
            goto L46
        L2f:
            goto L18
        L32:
            goto L2c
        L36:
            r1 = 5
            goto L4
        L3d:
            int r0 = r0 % r1
            goto L1c
        L43:
            goto L32
        L46:
            goto L25
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a GetWriter() {
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
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r0 = r0.fa82feee3
            goto Lb
    }

    public readonly bool IsHealthy(long r7) {
            r6 = this;
            goto L2f
        L4:
            return r1
        L5:
            goto L3f
        L9:
            return r6
        La:
            r7 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> La
            goto L82
        L10:
            monitor-enter(r6)
            bool r0 = r6.f8aea5ac4     // Catch: java.lang.Exception -> La
            goto L17
        L17:
            r1 = 0
            goto L4a
        L1c:
            int r0 = r0 + r1
            goto L44
        L22:
            monitor-exit(r6)
            goto L73
        L27:
            r6 = 1
            goto L9
        L2c:
            goto L32
        L2f:
            goto L93
        L32:
            goto L61
        L36:
            if (r0 <= 0) goto L3b
            goto L56
        L3b:
            goto L53
        L3f:
            monitor-exit(r6)
            goto L27
        L44:
            int r0 = r0 % r1
            goto L36
        L4a:
            if (r0 != 0) goto L4f
            goto L74
        L4f:
            goto L22
        L53:
            goto L83
        L56:
            goto L10
        L5a:
            r1 = 27
            goto L1c
        L61:
            r0 = 22
            goto L5a
        L68:
            monitor-exit(r6)
            goto L4
        L6d:
            int r7 = (r7 > r2 ? 1 : (r7 == r2 ? 0 : -1))
            goto L87
        L73:
            return r1
        L74:
            long r2 = r6.f42095970     // Catch: java.lang.Exception -> La
            long r4 = r6.fc6076efd     // Catch: java.lang.Exception -> La
            int r0 = (r2 > r4 ? 1 : (r2 == r4 ? 0 : -1))
            if (r0 >= 0) goto L5
            long r2 = r6.fa415f05b     // Catch: java.lang.Exception -> La
            goto L6d
        L82:
            throw r7
        L83:
            goto L90
        L87:
            if (r7 >= 0) goto L8c
            goto L5
        L8c:
            goto L68
        L90:
            goto L56
        L93:
            goto L2c
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 NewStream(java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r2, bool r3) throws java.io.IOException {
            r1 = this;
            goto L16
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L23
        Lb:
            p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r1 = r1.newStream(r0, r2, r3)
            goto L28
        L13:
            goto L19
        L16:
            goto L29
        L19:
            goto L1d
        L1d:
            java.lang.string r0 = "requestHeaders"
            goto L4
        L23:
            r0 = 0
            goto Lb
        L28:
            return r1
        L29:
            goto L13
    }

    public readonly int OpenStreamCount() {
            r1 = this;
            goto Lb
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L25
        Lb:
            goto L26
        Le:
            goto L17
        L12:
            monitor-exit(r1)
            goto L4
        L17:
            monitor-enter(r1)
            java.util.Dictionary<java.lang.int, p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6> r0 = r1.f2f6f4768     // Catch: java.lang.Exception -> L5
            int r0 = r0.Count     // Catch: java.lang.Exception -> L5
            goto L12
        L22:
            goto Le
        L25:
            throw r0
        L26:
            goto L22
    }

    public readonly void pushDataLater$okhttp(int r10, p38cb8f46.pcc81e3f6 r11, int r12, bool r13) throws java.io.IOException {
            r9 = this;
            goto L9c
        L4:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L89
        Lc:
            r6.<init>()
            goto La3
        L13:
            r11.require(r0)
            goto L47
        L1a:
            return
        L1b:
            goto L25
        L1f:
            p38cb8f46.p7e62bc34 r6 = new p38cb8f46.p7e62bc34
            goto Lc
        L25:
            goto L5a
        L28:
            goto L54
        L2c:
            r1 = 91
            goto L65
        L32:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r11 = r9.f99bf7c1e
            goto Lec
        L38:
            if (r0 <= 0) goto L3d
            goto L5a
        L3d:
            goto L57
        L41:
            java.lang.string r1 = "] onData"
            goto L4
        L47:
            r11.read(r6, r0)
            goto L32
        L4e:
            int r0 = r0 % r1
            goto L38
        L54:
            goto L9f
        L57:
            goto L1b
        L5a:
            goto Le1
        L5e:
            r11.schedule(r1, r9)
            goto L1a
        L65:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto Ld9
        L6d:
            r0.<init>()
            goto L91
        L74:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r1 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r1
            goto Lbb
        L7a:
            r1 = 19
            goto Laf
        L81:
            java.lang.stringBuilder r0 = r0.append(r1)
            goto L2c
        L89:
            java.lang.string r2 = r0.tostring()
            goto Lb5
        L91:
            java.lang.string r1 = r9.f1a2e0cd3
            goto L81
        L97:
            r8 = r13
            goto Ld2
        L9c:
            goto L28
        L9f:
            goto La8
        La3:
            long r0 = (long) r12
            goto L13
        La8:
            r0 = 27
            goto L7a
        Laf:
            int r0 = r0 + r1
            goto L4e
        Lb5:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p8aabb579$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r1 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p8aabb579$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
            goto Lcd
        Lbb:
            r9 = 0
            goto L5e
        Lc1:
            r5 = r10
            goto Le7
        Lc6:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r11, r0)
            goto L1f
        Lcd:
            r3 = 1
            goto Lf2
        Ld2:
            r1.<init>(r2, r3, r4, r5, r6, r7, r8)
            goto L74
        Ld9:
            java.lang.stringBuilder r0 = r0.append(r10)
            goto L41
        Le1:
            java.lang.string r0 = "source"
            goto Lc6
        Le7:
            r7 = r12
            goto L97
        Lec:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L6d
        Lf2:
            r4 = r9
            goto Lc1
    }

    public readonly void pushHeadersLater$okhttp(int r10, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r11, bool r12) {
            r9 = this;
            goto L36
        L4:
            r0.schedule(r2, r9)
            goto Lb4
        Lb:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto Lc8
        L11:
            java.lang.string r2 = "] onHeaders"
            goto L66
        L17:
            r2.<init>(r3, r4, r5, r6, r7, r8)
            goto L82
        L1e:
            int r0 = r0 + r1
            goto L88
        L24:
            r9 = 0
            goto L4
        L2a:
            java.lang.string r0 = "requestHeaders"
            goto L94
        L30:
            r2 = 91
            goto Lcf
        L36:
            goto L45
        L39:
            goto L9b
        L3d:
            r4 = 1
            goto Laa
        L42:
            goto L5d
        L45:
            goto L4f
        L49:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r9.f99bf7c1e
            goto Lb
        L4f:
            goto L39
        L52:
            java.lang.string r3 = r1.tostring()
            goto Lb9
        L5a:
            goto Lb5
        L5d:
            goto L2a
        L61:
            r7 = r11
            goto L6e
        L66:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L52
        L6e:
            r8 = r12
            goto L17
        L73:
            r1 = 31
            goto L1e
        L7a:
            java.lang.stringBuilder r1 = r1.append(r10)
            goto L11
        L82:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r2
            goto L24
        L88:
            int r0 = r0 % r1
            goto Lbf
        L8e:
            java.lang.string r2 = r9.f1a2e0cd3
            goto La2
        L94:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r11, r0)
            goto L49
        L9b:
            r0 = 27
            goto L73
        La2:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L30
        Laa:
            r5 = r9
            goto Laf
        Laf:
            r6 = r10
            goto L61
        Lb4:
            return
        Lb5:
            goto L42
        Lb9:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p8e424555$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p8e424555$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
            goto L3d
        Lbf:
            if (r0 <= 0) goto Lc4
            goto L5d
        Lc4:
            goto L5a
        Lc8:
            r1.<init>()
            goto L8e
        Lcf:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L7a
    }

    public readonly void pushRequestLater$okhttp(int r9, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r10) {
            r8 = this;
            goto L103
        L4:
            int r0 = r0 % r1
            goto Lbb
        La:
            return
        Lb:
            r0 = move-exception
            goto L128
        L10:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto Lad
        L18:
            monitor-enter(r8)
            java.util.HashSet<java.lang.int> r0 = r8.fafd22e63     // Catch: java.lang.Exception -> Lb
            java.lang.int r1 = java.lang.int.valueOf(r9)     // Catch: java.lang.Exception -> Lb
            bool r0 = r0.Contains(r1)     // Catch: java.lang.Exception -> Lb
            goto L94
        L27:
            r0.schedule(r2, r8)
            goto La
        L2e:
            r2 = 91
            goto L10
        L34:
            r9 = r0
            goto L3f
        L39:
            java.lang.string r2 = "] onRequest"
            goto Ldf
        L3f:
            r5 = r8
            goto L72
        L44:
            r7 = r10
            goto L11c
        L49:
            monitor-exit(r8)
            goto Lb5
        L4e:
            throw r9
        L4f:
            goto L115
        L53:
            r1 = 11
            goto Lca
        L5a:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r8.f99bf7c1e
            goto L8e
        L60:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r0)
            goto L18
        L67:
            java.lang.string r3 = r1.tostring()
            goto Lf1
        L6f:
            goto L106
        L72:
            goto L124
        L74:
            java.util.HashSet<java.lang.int> r0 = r8.fafd22e63     // Catch: java.lang.Exception -> Lb
            java.lang.int r1 = java.lang.int.valueOf(r9)     // Catch: java.lang.Exception -> Lb
            r0.Add(r1)     // Catch: java.lang.Exception -> Lb
            goto L10a
        L81:
            r1.<init>()
            goto Lc4
        L88:
            java.lang.string r0 = "requestHeaders"
            goto L60
        L8e:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L81
        L94:
            if (r0 != 0) goto L99
            goto L74
        L99:
            p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r10 = p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38.f23f149f0     // Catch: java.lang.Exception -> Lb6
            r8.writeSynResetLater$okhttp(r9, r10)     // Catch: java.lang.Exception -> Lb6
            goto L49
        La2:
            r8 = 0
            goto L27
        La8:
            r4 = 1
            goto Le7
        Lad:
            java.lang.stringBuilder r1 = r1.append(r9)
            goto L39
        Lb5:
            return
        Lb6:
            r0 = move-exception
            goto L34
        Lbb:
            if (r0 <= 0) goto Lc0
            goto Ldb
        Lc0:
            goto Ld8
        Lc4:
            java.lang.string r2 = r8.f1a2e0cd3
            goto Ld0
        Lca:
            int r0 = r0 + r1
            goto L4
        Ld0:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L2e
        Ld8:
            goto L4f
        Ldb:
            goto L88
        Ldf:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L67
        Le7:
            r5 = r8
            goto Lf7
        Lec:
            monitor-exit(r5)
            goto L4e
        Lf1:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$peff049d0$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$peff049d0$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
            goto La8
        Lf7:
            r6 = r9
            goto L44
        Lfc:
            r0 = 15
            goto L53
        L103:
            goto L118
        L106:
            goto Lfc
        L10a:
            monitor-exit(r8)
            goto L5a
        L10f:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r2
            goto La2
        L115:
            goto Ldb
        L118:
            goto L6f
        L11c:
            r2.<init>(r3, r4, r5, r6, r7)
            goto L10f
        L123:
            r9 = r0
        L124:
            goto Lec
        L128:
            r5 = r8
            goto L123
    }

    public readonly void pushResetLater$okhttp(int r9, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r10) {
            r8 = this;
            goto L52
        L4:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto Lc5
        La:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r8.f99bf7c1e
            goto L4
        L10:
            r2 = 91
            goto L7d
        L16:
            java.lang.string r2 = "] onReset"
            goto Lb4
        L1c:
            r7 = r10
            goto L24
        L21:
            goto L55
        L24:
            r2.<init>(r3, r4, r5, r6, r7)
            goto Lcc
        L2b:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L10
        L33:
            java.lang.string r2 = r8.f1a2e0cd3
            goto L2b
        L39:
            r8 = 0
            goto L8c
        L3f:
            java.lang.string r3 = r1.tostring()
            goto L9a
        L47:
            int r0 = r0 + r1
            goto L60
        L4d:
            r5 = r8
            goto L66
        L52:
            goto L88
        L55:
            goto La0
        L59:
            goto Lb0
        L5c:
            goto L70
        L60:
            int r0 = r0 % r1
            goto Lbc
        L66:
            r6 = r9
            goto L1c
        L6b:
            r4 = 1
            goto L4d
        L70:
            java.lang.string r0 = "errorCode"
            goto L76
        L76:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r0)
            goto La
        L7d:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto La7
        L85:
            goto L5c
        L88:
            goto L21
        L8c:
            r0.schedule(r2, r8)
            goto Laf
        L93:
            r1 = 10
            goto L47
        L9a:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$pd56569a4$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$pd56569a4$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
            goto L6b
        La0:
            r0 = 4
            goto L93
        La7:
            java.lang.stringBuilder r1 = r1.append(r9)
            goto L16
        Laf:
            return
        Lb0:
            goto L85
        Lb4:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L3f
        Lbc:
            if (r0 <= 0) goto Lc1
            goto L5c
        Lc1:
            goto L59
        Lc5:
            r1.<init>()
            goto L33
        Lcc:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r2
            goto L39
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 PushStream(int r2, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r3, bool r4) throws java.io.IOException {
            r1 = this;
            goto L26
        L4:
            java.lang.IllegalStateException r1 = new java.lang.IllegalStateException
            goto L30
        La:
            bool r0 = r1.f62608e08
            goto L1d
        L10:
            p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r1 = r1.newStream(r2, r3, r4)
            goto L18
        L18:
            return r1
        L19:
            goto L4
        L1d:
            if (r0 == 0) goto L22
            goto L19
        L22:
            goto L10
        L26:
            goto L37
        L29:
            goto L49
        L2d:
            goto L29
        L30:
            java.lang.string r2 = "Client cannot push requests."
            goto L4f
        L36:
            throw r1
        L37:
            goto L2d
        L3b:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto La
        L42:
            r1.<init>(r2)
            goto L36
        L49:
            java.lang.string r0 = "requestHeaders"
            goto L3b
        L4f:
            java.lang.string r2 = r2.tostring()
            goto L42
    }

    public readonly bool pushedStream$okhttp(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L32
        L7:
            goto L10
        Lb:
            r0 = 0
            goto L31
        L10:
            if (r1 != 0) goto L15
            goto L23
        L15:
            goto L2c
        L19:
            if (r1 == 0) goto L1e
            goto L23
        L1e:
            goto L22
        L22:
            return r0
        L23:
            goto Lb
        L27:
            r1 = r1 & r0
            goto L19
        L2c:
            r0 = 1
            goto L27
        L31:
            return r0
        L32:
            goto L36
        L36:
            goto L7
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 removeStream$okhttp(int r2) {
            r1 = this;
            goto L10
        L4:
            return r2
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L1a
        Lb:
            monitor-exit(r1)
            goto L4
        L10:
            goto L1b
        L13:
            goto L1f
        L17:
            goto L13
        L1a:
            throw r2
        L1b:
            goto L17
        L1f:
            monitor-enter(r1)
            java.util.Dictionary<java.lang.int, p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6> r0 = r1.f2f6f4768     // Catch: java.lang.Exception -> L5
            java.lang.int r2 = java.lang.int.valueOf(r2)     // Catch: java.lang.Exception -> L5
            java.lang.object r2 = r0.Remove(r2)     // Catch: java.lang.Exception -> L5
            p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6 r2 = (p7ddcfee1.pd1efad72.p3cb89a9f.p87a6e6e6) r2     // Catch: java.lang.Exception -> L5
            r0 = r1
            java.lang.object r0 = (java.lang.object) r0     // Catch: java.lang.Exception -> L5
            r0.notifyAll()     // Catch: java.lang.Exception -> L5
            goto Lb
    }

    public readonly void sendDegradedPingLater$okhttp() {
            r5 = this;
            goto L7f
        L4:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r2
            goto L3f
        La:
            r1 = 30
            goto Lb7
        L11:
            if (r0 < 0) goto L16
            goto L46
        L16:
            goto L5c
        L1a:
            long r2 = r2 + r0
            r5.fc6076efd = r2     // Catch: java.lang.Exception -> L35
            long r0 = java.lang.System.nanoTime()     // Catch: java.lang.Exception -> L35
            r2 = 1000000000(0x3b9aca00, float:0.0047237873)
            long r2 = (long) r2     // Catch: java.lang.Exception -> L35
            long r0 = r0 + r2
            r5.fa415f05b = r0     // Catch: java.lang.Exception -> L35
            kotlin.Unit r0 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L35
            goto L3a
        L2e:
            int r0 = r0 % r1
            goto L9c
        L34:
            return
        L35:
            r0 = move-exception
            goto Lbd
        L3a:
            monitor-exit(r5)
            goto L71
        L3f:
            r3 = 0
            goto L95
        L45:
            return
        L46:
            goto Lab
        L4a:
            r0 = 1
            goto La
        L51:
            r3 = 1
            goto L8e
        L56:
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L11
        L5c:
            monitor-exit(r5)
            goto L45
        L61:
            monitor-enter(r5)
            long r0 = r5.f42095970     // Catch: java.lang.Exception -> L35
            long r2 = r5.fc6076efd     // Catch: java.lang.Exception -> L35
            goto L56
        L6a:
            goto Lcb
        L6d:
            goto L77
        L71:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r5.ffed859a6
            goto Lc2
        L77:
            goto L82
        L7a:
            throw r0
        L7b:
            goto L6a
        L7f:
            goto L6d
        L82:
            goto L4a
        L86:
            java.lang.string r1 = kotlin.jvm.internal.Intrinsics.stringPlus(r1, r2)
            goto La5
        L8e:
            r2.<init>(r1, r3, r5)
            goto L4
        L95:
            r0.schedule(r2, r3)
            goto L34
        L9c:
            if (r0 <= 0) goto La1
            goto Lcb
        La1:
            goto Lc8
        La5:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p8ce26adb$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p8ce26adb$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
            goto L51
        Lab:
            r0 = 1
            goto L1a
        Lb1:
            java.lang.string r2 = " ping"
            goto L86
        Lb7:
            int r0 = r0 + r1
            goto L2e
        Lbd:
            monitor-exit(r5)
            goto L7a
        Lc2:
            java.lang.string r1 = r5.f1a2e0cd3
            goto Lb1
        Lc8:
            goto L7b
        Lcb:
            goto L61
    }

    public readonly void setLastGoodStreamId$okhttp(int r1) {
            r0 = this;
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
            r0.fe2d806df = r1
            goto L4
    }

    public readonly void setNextStreamId$okhttp(int r1) {
            r0 = this;
            goto L12
        L4:
            return
        L5:
            goto Lf
        L9:
            r0.fb973a5d8 = r1
            goto L4
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
    }

    public readonly void SetPeerHashSettings(p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r2) {
            r1 = this;
            goto L1f
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto Le
        Lb:
            goto L22
        Le:
            r1.f95e9b297 = r2
            goto L14
        L14:
            return
        L15:
            goto Lb
        L19:
            java.lang.string r0 = "<set-?>"
            goto L4
        L1f:
            goto L15
        L22:
            goto L19
    }

    public readonly void SetHashSettings(p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r3) throws java.io.IOException {
            r2 = this;
            goto L45
        L4:
            int r0 = r0 % r1
            goto L37
        La:
            r1 = 20
            goto L11
        L11:
            int r0 = r0 + r1
            goto L4
        L17:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L23
        L1e:
            monitor-exit(r0)
            goto L7e
        L23:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r0 = r2.fa82feee3
            goto L61
        L29:
            goto L52
        L2c:
            goto L4c
        L30:
            r0 = 29
            goto La
        L37:
            if (r0 <= 0) goto L3c
            goto L52
        L3c:
            goto L4f
        L40:
            monitor-exit(r0)
            goto L56
        L45:
            goto L2c
        L48:
            goto L30
        L4c:
            goto L48
        L4f:
            goto L57
        L52:
            goto L5b
        L56:
            throw r2
        L57:
            goto L29
        L5b:
            java.lang.string r0 = "settings"
            goto L17
        L61:
            monitor-enter(r0)
            monitor-enter(r2)     // Catch: java.lang.Exception -> L88
            bool r1 = r2.f8aea5ac4     // Catch: java.lang.Exception -> L85
            if (r1 != 0) goto L7f
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r1 = r2.getOkHttpHashSettings()     // Catch: java.lang.Exception -> L85
            r1.merge(r3)     // Catch: java.lang.Exception -> L85
            kotlin.Unit r1 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L85
            monitor-exit(r2)     // Catch: java.lang.Exception -> L88
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r2 = r2.getWriter()     // Catch: java.lang.Exception -> L88
            r2.settings(r3)     // Catch: java.lang.Exception -> L88
            kotlin.Unit r2 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L88
            goto L1e
        L7e:
            return
        L7f:
            p7ddcfee1.pd1efad72.p3cb89a9f.p0172e76e r3 = new p7ddcfee1.pd1efad72.p3cb89a9f.p0172e76e     // Catch: java.lang.Exception -> L85
            r3.<init>()     // Catch: java.lang.Exception -> L85
            throw r3     // Catch: java.lang.Exception -> L85
        L85:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L88
            throw r3     // Catch: java.lang.Exception -> L88
        L88:
            r2 = move-exception
            goto L40
    }

    public readonly void Shutdown(p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r4) throws java.io.IOException {
            r3 = this;
            goto L1e
        L4:
            goto L7c
        L7:
            goto L2a
        Lb:
            return
        Lc:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> Lf
            throw r4     // Catch: java.lang.Exception -> Lf
        Lf:
            r3 = move-exception
            goto L14
        L14:
            monitor-exit(r0)
            goto L19
        L19:
            throw r3
        L1a:
            goto L4
        L1e:
            goto L7
        L21:
            goto L34
        L25:
            monitor-exit(r0)
            goto L8c
        L2a:
            goto L21
        L2d:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto L4f
        L34:
            r0 = 13
            goto L72
        L3b:
            if (r0 <= 0) goto L40
            goto L7c
        L40:
            goto L79
        L44:
            java.lang.string r0 = "statusCode"
            goto L2d
        L4a:
            monitor-exit(r0)
            goto Lb
        L4f:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r0 = r3.fa82feee3
            goto L91
        L55:
            r2 = 1
            r3.f8aea5ac4 = r2     // Catch: java.lang.Exception -> Lc
            int r2 = r3.getLastGoodStreamId$okhttp()     // Catch: java.lang.Exception -> Lc
            r1.element = r2     // Catch: java.lang.Exception -> Lc
            kotlin.Unit r2 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> Lc
            monitor-exit(r3)     // Catch: java.lang.Exception -> Lf
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r3 = r3.getWriter()     // Catch: java.lang.Exception -> Lf
            int r1 = r1.element     // Catch: java.lang.Exception -> Lf
            byte[] r2 = p7ddcfee1.pd1efad72.p23e8a4b4.ff39c2294     // Catch: java.lang.Exception -> Lf
            r3.goAway(r1, r4, r2)     // Catch: java.lang.Exception -> Lf
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> Lf
            goto L4a
        L72:
            r1 = 12
            goto L80
        L79:
            goto L1a
        L7c:
            goto L44
        L80:
            int r0 = r0 + r1
            goto L86
        L86:
            int r0 = r0 % r1
            goto L3b
        L8c:
            return
        L8d:
            goto L55
        L91:
            monitor-enter(r0)
            kotlin.jvm.internal.Ref$IntRef r1 = new kotlin.jvm.internal.Ref$IntRef     // Catch: java.lang.Exception -> Lf
            r1.<init>()     // Catch: java.lang.Exception -> Lf
            monitor-enter(r3)     // Catch: java.lang.Exception -> Lf
            bool r2 = r3.f8aea5ac4     // Catch: java.lang.Exception -> Lc
            goto L9e
        L9e:
            if (r2 != 0) goto La3
            goto L8d
        La3:
            monitor-exit(r3)     // Catch: java.lang.Exception -> Lf
            goto L25
    }

    public readonly void Start() throws java.io.IOException {
            r3 = this;
            goto L14
        L4:
            r0 = 0
            goto L9
        L9:
            r1 = 3
            goto L4e
        Le:
            int r0 = r0 + r1
            goto L31
        L14:
            goto L2d
        L17:
            goto L53
        L1b:
            goto L26
        L1e:
            goto L4
        L22:
            goto L17
        L25:
            return
        L26:
            goto L2a
        L2a:
            goto L1e
        L2d:
            goto L22
        L31:
            int r0 = r0 % r1
            goto L45
        L37:
            r1 = 8
            goto Le
        L3e:
            start$default(r3, r2, r0, r1, r0)
            goto L25
        L45:
            if (r0 <= 0) goto L4a
            goto L1e
        L4a:
            goto L1b
        L4e:
            r2 = 0
            goto L3e
        L53:
            r0 = 19
            goto L37
    }

    public readonly void Start(bool r3) throws java.io.IOException {
            r2 = this;
            goto L18
        L4:
            int r0 = r0 + r1
            goto L4f
        La:
            if (r0 <= 0) goto Lf
            goto L22
        Lf:
            goto L1f
        L13:
            return
        L14:
            goto L29
        L18:
            goto L2c
        L1b:
            goto L43
        L1f:
            goto L14
        L22:
            goto L37
        L26:
            goto L1b
        L29:
            goto L22
        L2c:
            goto L26
        L30:
            start$default(r2, r3, r0, r1, r0)
            goto L13
        L37:
            r0 = 0
            goto L4a
        L3c:
            r1 = 23
            goto L4
        L43:
            r0 = 18
            goto L3c
        L4a:
            r1 = 2
            goto L30
        L4f:
            int r0 = r0 % r1
            goto La
    }

    public readonly void Start(bool r5, p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r6) throws java.io.IOException {
            r4 = this;
            goto Ld6
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r6, r0)
            goto L97
        Lb:
            int r0 = r0 + r1
            goto L3c
        L11:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7$pec0cd3cb$1 r0 = new p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7$pec0cd3cb$1
            goto L4a
        L17:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r1 = r4.fa82feee3
            goto L92
        L1d:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p28bdc648 r4 = r4.f1f65fe92
            goto Lc0
        L23:
            r1 = 0
            goto Le6
        L29:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r0 = r4.fe10edc3d
            goto L70
        L2f:
            r1.windowUpdate(r5, r2)
        L32:
            goto L8a
        L36:
            java.lang.string r6 = r4.f1a2e0cd3
            goto L1d
        L3c:
            int r0 = r0 % r1
            goto Ldd
        L42:
            int r5 = r5.getInitialWindowSize()
            goto La0
        L4a:
            r1 = 1
            goto L56
        L4f:
            r0 = 29
            goto Lae
        L56:
            r0.<init>(r6, r1, r4)
            goto Lba
        L5d:
            java.lang.string r0 = "taskRunner"
            goto L4
        L63:
            goto L78
        L66:
            goto L5d
        L6a:
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r5 = r4.fe10edc3d
            goto L42
        L70:
            r5.settings(r0)
            goto L6a
        L77:
            return
        L78:
            goto La7
        L7c:
            r5 = 0
            goto L2f
        L81:
            if (r5 != r0) goto L86
            goto L32
        L86:
            goto L17
        L8a:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r5 = r6.newQueue()
            goto L36
        L92:
            int r5 = r5 - r0
            goto Lb5
        L97:
            if (r5 != 0) goto L9c
            goto L32
        L9c:
            goto Led
        La0:
            r0 = 65535(0xffff, float:9.1834E-41)
            goto L81
        La7:
            goto L66
        Laa:
            goto Lc6
        Lae:
            r1 = 10
            goto Lb
        Lb5:
            long r2 = (long) r5
            goto L7c
        Lba:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r0 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r0
            goto L23
        Lc0:
            kotlin.jvm.functions.Function0 r4 = (kotlin.jvm.functions.Function0) r4
            goto L11
        Lc6:
            goto Ld9
        Lc9:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r5 = r4.fa82feee3
            goto L29
        Lcf:
            r5.connectionPreface()
            goto Lc9
        Ld6:
            goto Laa
        Ld9:
            goto L4f
        Ldd:
            if (r0 <= 0) goto Le2
            goto L66
        Le2:
            goto L63
        Le6:
            r5.schedule(r0, r1)
            goto L77
        Led:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r5 = r4.fa82feee3
            goto Lcf
    }

    public readonly void updateConnectionFlowControl$okhttp(long r3) {
            r2 = this;
            goto L5b
        L4:
            int r0 = r0 + r1
            goto L2d
        La:
            monitor-enter(r2)
            long r0 = r2.f098f5c58     // Catch: java.lang.Exception -> L63
            long r0 = r0 + r3
            r2.f098f5c58 = r0     // Catch: java.lang.Exception -> L63
            long r3 = r2.ff003faaf     // Catch: java.lang.Exception -> L63
            long r0 = r0 - r3
            p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r3 = r2.fe10edc3d     // Catch: java.lang.Exception -> L63
            int r3 = r3.getInitialWindowSize()     // Catch: java.lang.Exception -> L63
            int r3 = r3 / 2
            long r3 = (long) r3     // Catch: java.lang.Exception -> L63
            int r3 = (r0 > r3 ? 1 : (r0 == r3 ? 0 : -1))
            if (r3 < 0) goto L29
            r3 = 0
            r2.writeWindowUpdateLater$okhttp(r3, r0)     // Catch: java.lang.Exception -> L63
            long r3 = r2.ff003faaf     // Catch: java.lang.Exception -> L63
            long r3 = r3 + r0
            r2.ff003faaf = r3     // Catch: java.lang.Exception -> L63
        L29:
            goto L3a
        L2d:
            int r0 = r0 % r1
            goto L4b
        L33:
            r0 = 7
            goto L44
        L3a:
            monitor-exit(r2)
            goto L62
        L3f:
            throw r3
        L40:
            goto L54
        L44:
            r1 = 18
            goto L4
        L4b:
            if (r0 <= 0) goto L50
            goto L6c
        L50:
            goto L69
        L54:
            goto L6c
        L57:
            goto L70
        L5b:
            goto L57
        L5e:
            goto L33
        L62:
            return
        L63:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L63
            goto L3f
        L69:
            goto L40
        L6c:
            goto La
        L70:
            goto L5e
    }

    public readonly void WriteData(int r9, bool r10, p38cb8f46.p7e62bc34 r11, long r12) throws java.io.IOException {
            r8 = this;
            goto L2e
        L4:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r8 = r8.fa82feee3
            goto Le9
        La:
            goto L18
        Lb:
            java.lang.Thread r9 = java.lang.Thread.currentThread()     // Catch: java.lang.Exception -> L37
            r9.interrupt()     // Catch: java.lang.Exception -> L37
            java.io.InterruptedIOException r9 = new java.io.InterruptedIOException     // Catch: java.lang.Exception -> L37
            r9.<init>()     // Catch: java.lang.Exception -> L37
            throw r9     // Catch: java.lang.Exception -> L37
        L18:
            goto Lfb
        L1c:
            r1 = 7
            goto L100
        L23:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r4 = r8.fa82feee3
            goto Lab
        L29:
            monitor-exit(r8)
            goto L122
        L2e:
            goto Ld4
        L31:
            goto L10c
        L35:
            goto L128
        L37:
            r9 = move-exception
            goto La
        L3c:
            int r0 = r0 % r1
            goto L42
        L42:
            if (r0 <= 0) goto L47
            goto L12f
        L47:
            goto L12c
        L4b:
            int r5 = (r12 > r0 ? 1 : (r12 == r0 ? 0 : -1))
            goto Lbd
        L51:
            r5 = r3
        L52:
            goto Ldd
        L56:
            monitor-enter(r8)
        L57:
            long r4 = r8.getWritebytesTotal()     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            long r6 = r8.getWritebytesMaximum()     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            int r2 = (r4 > r6 ? 1 : (r4 == r6 ? 0 : -1))
            if (r2 < 0) goto L80
            java.util.Dictionary r2 = r8.getStreams$okhttp()     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            java.lang.int r4 = java.lang.int.valueOf(r9)     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            bool r2 = r2.ContainsKey(r4)     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            if (r2 == 0) goto L78
            r2 = r8
            java.lang.object r2 = (java.lang.object) r2     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            r2.wait()     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            goto L57
        L78:
            java.io.IOException r9 = new java.io.IOException     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            java.lang.string r10 = "stream closed"
            r9.<init>(r10)     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
            throw r9     // Catch: java.lang.InterruptedException -> Lb java.lang.Exception -> L37
        L80:
            long r4 = r8.getWritebytesMaximum()     // Catch: java.lang.Exception -> L37
            long r6 = r8.getWritebytesTotal()     // Catch: java.lang.Exception -> L37
            long r4 = r4 - r6
            long r4 = java.lang.Math.min(r12, r4)     // Catch: java.lang.Exception -> L37
            int r2 = (int) r4     // Catch: java.lang.Exception -> L37
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r4 = r8.getWriter()     // Catch: java.lang.Exception -> L37
            int r4 = r4.maxDataLength()     // Catch: java.lang.Exception -> L37
            int r2 = java.lang.Math.min(r2, r4)     // Catch: java.lang.Exception -> L37
            long r4 = r8.getWritebytesTotal()     // Catch: java.lang.Exception -> L37
            long r6 = (long) r2     // Catch: java.lang.Exception -> L37
            long r4 = r4 + r6
            r8.fca5ceb37 = r4     // Catch: java.lang.Exception -> L37
            kotlin.Unit r4 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L37
            goto L29
        La8:
            goto L31
        Lab:
            if (r10 != 0) goto Lb0
            goto L108
        Lb0:
            goto L4b
        Lb4:
            if (r2 > 0) goto Lb9
            goto Lf7
        Lb9:
            goto L56
        Lbd:
            if (r5 == 0) goto Lc2
            goto L108
        Lc2:
            goto Le4
        Lc6:
            r0 = 0
            goto Lf0
        Lcc:
            r3 = 0
            goto L119
        Ld1:
            goto L12f
        Ld4:
            goto La8
        Ld8:
            return
        Ld9:
            goto Ld1
        Ldd:
            r4.data(r5, r9, r11, r2)
            goto L35
        Le4:
            r5 = 1
            goto L106
        Le9:
            r8.data(r10, r9, r11, r3)
            goto L127
        Lf0:
            int r2 = (r12 > r0 ? 1 : (r12 == r0 ? 0 : -1))
            goto Lcc
        Lf6:
            throw r9
        Lf7:
            goto Ld8
        Lfb:
            monitor-exit(r8)
            goto Lf6
        L100:
            int r0 = r0 + r1
            goto L3c
        L106:
            goto L52
        L108:
            goto L51
        L10c:
            r0 = 7
            goto L1c
        L113:
            int r2 = (r12 > r0 ? 1 : (r12 == r0 ? 0 : -1))
            goto Lb4
        L119:
            if (r2 == 0) goto L11e
            goto L128
        L11e:
            goto L4
        L122:
            long r12 = r12 - r6
            goto L23
        L127:
            return
        L128:
            goto L113
        L12c:
            goto Ld9
        L12f:
            goto Lc6
    }

    public readonly void writeHeaders$okhttp(int r2, bool r3, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r4) throws java.io.IOException {
            r1 = this;
            goto L26
        L4:
            java.lang.string r0 = "alternating"
            goto L11
        La:
            r1.headers(r3, r2, r4)
            goto L1e
        L11:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto L18
        L18:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r1 = r1.fa82feee3
            goto La
        L1e:
            return
        L1f:
            goto L23
        L23:
            goto L29
        L26:
            goto L1f
        L29:
            goto L4
    }

    public readonly void WritePing() throws java.lang.InterruptedException {
            r4 = this;
            goto L3e
        L4:
            r0 = 3
            goto L50
        L9:
            monitor-exit(r4)
            goto L4
        Le:
            if (r0 <= 0) goto L13
            goto L6d
        L13:
            goto L6a
        L17:
            monitor-exit(r4)
            goto L4b
        L1c:
            r4.writePing(r2, r0, r1)
            goto L38
        L23:
            goto L6d
        L26:
            goto L35
        L2a:
            int r0 = r0 % r1
            goto Le
        L30:
            r2 = 0
            goto L1c
        L35:
            goto L41
        L38:
            return
        L39:
            r0 = move-exception
            goto L17
        L3e:
            goto L26
        L41:
            goto L71
        L45:
            int r0 = r0 + r1
            goto L2a
        L4b:
            throw r0
        L4c:
            goto L23
        L50:
            r1 = 1330343787(0x4f4b6f6b, float:3.4130767E9)
            goto L30
        L57:
            r1 = 3
            goto L45
        L5e:
            monitor-enter(r4)
            long r0 = r4.f6f1fd9b9     // Catch: java.lang.Exception -> L39
            r2 = 1
            long r0 = r0 + r2
            r4.f6f1fd9b9 = r0     // Catch: java.lang.Exception -> L39
            goto L9
        L6a:
            goto L4c
        L6d:
            goto L5e
        L71:
            r0 = 25
            goto L57
    }

    public readonly void WritePing(bool r2, int r3, int r4) {
            r1 = this;
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            return
        Ld:
            r2 = move-exception
            goto L1e
        L12:
            goto L5
        L15:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r0 = r1.fa82feee3     // Catch: java.io.IOException -> Ld
            r0.ping(r2, r3, r4)     // Catch: java.io.IOException -> Ld
            goto Lc
        L1e:
            r1.failConnection(r2)
            goto L4
    }

    public readonly void WritePingAndAwaitPong() throws java.lang.InterruptedException {
            r0 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto L1a
        Lb:
            r0.awaitPong()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
        L1a:
            r0.writePing()
            goto Lb
    }

    public readonly void writeSynReset$okhttp(int r2, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r3) throws java.io.IOException {
            r1 = this;
            goto L17
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto Lb
        Lb:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a r1 = r1.fa82feee3
            goto L23
        L11:
            java.lang.string r0 = "statusCode"
            goto L4
        L17:
            goto L1f
        L1a:
            goto L11
        L1e:
            return
        L1f:
            goto L2a
        L23:
            r1.rstStream(r2, r3)
            goto L1e
        L2a:
            goto L1a
    }

    public readonly void writeSynResetLater$okhttp(int r9, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r10) {
            r8 = this;
            goto Lb2
        L4:
            int r0 = r0 + r1
            goto L5d
        La:
            java.lang.stringBuilder r1 = r1.append(r9)
            goto L1e
        L12:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r2
            goto L29
        L18:
            java.lang.string r0 = "errorCode"
            goto L71
        L1e:
            java.lang.string r2 = "] writeSynReset"
            goto L36
        L24:
            r5 = r8
            goto Lcd
        L29:
            r8 = 0
            goto L2f
        L2f:
            r0.schedule(r2, r8)
            goto La5
        L36:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto Lbf
        L3e:
            r7 = r10
            goto L43
        L43:
            r2.<init>(r3, r4, r5, r6, r7)
            goto L12
        L4a:
            java.lang.string r2 = r8.f1a2e0cd3
            goto L69
        L50:
            goto La6
        L53:
            goto L18
        L57:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L7f
        L5d:
            int r0 = r0 % r1
            goto L97
        L63:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r8.ffed859a6
            goto L57
        L69:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto Lb9
        L71:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r0)
            goto L63
        L78:
            r1 = 1
            goto L4
        L7f:
            r1.<init>()
            goto L4a
        L86:
            goto Lb5
        L89:
            goto L53
        L8c:
            goto L86
        L90:
            r0 = 28
            goto L78
        L97:
            if (r0 <= 0) goto L9c
            goto L53
        L9c:
            goto L50
        La0:
            r4 = 1
            goto L24
        La5:
            return
        La6:
            goto L89
        Laa:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto La
        Lb2:
            goto L8c
        Lb5:
            goto L90
        Lb9:
            r2 = 91
            goto Laa
        Lbf:
            java.lang.string r3 = r1.tostring()
            goto Lc7
        Lc7:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$pc621ddf3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$pc621ddf3$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
            goto La0
        Lcd:
            r6 = r9
            goto L3e
    }

    public readonly void writeWindowUpdateLater$okhttp(int r10, long r11) {
            r9 = this;
            goto L58
        L4:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto Laa
        La:
            java.lang.string r3 = r1.tostring()
            goto L52
        L12:
            r0 = 5
            goto L7c
        L19:
            goto L8c
        L1c:
            goto L64
        L20:
            int r0 = r0 % r1
            goto L42
        L26:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L76
        L2e:
            r5 = r9
            goto Lc0
        L33:
            java.lang.stringBuilder r1 = r1.append(r10)
            goto L70
        L3b:
            r2.<init>(r3, r4, r5, r6, r7)
            goto L90
        L42:
            if (r0 <= 0) goto L47
            goto L1c
        L47:
            goto L19
        L4b:
            goto L1c
        L4e:
            goto L9b
        L52:
            p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p1506dee7$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r2 = new p7ddcfee1.pd1efad72.p3cb89a9f.p2d68e184$p1506dee7$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1
            goto L5f
        L58:
            goto L4e
        L5b:
            goto L12
        L5f:
            r4 = 1
            goto L2e
        L64:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r9.ffed859a6
            goto L4
        L6a:
            r9 = 0
            goto Lb9
        L70:
            java.lang.string r2 = "] windowUpdate"
            goto L83
        L76:
            r2 = 91
            goto Lb1
        L7c:
            r1 = 10
            goto La4
        L83:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto La
        L8b:
            return
        L8c:
            goto L4b
        L90:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r2
            goto L6a
        L96:
            r7 = r11
            goto L3b
        L9b:
            goto L5b
        L9e:
            java.lang.string r2 = r9.f1a2e0cd3
            goto L26
        La4:
            int r0 = r0 + r1
            goto L20
        Laa:
            r1.<init>()
            goto L9e
        Lb1:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L33
        Lb9:
            r0.schedule(r2, r9)
            goto L8b
        Lc0:
            r6 = r10
            goto L96
    }
}

