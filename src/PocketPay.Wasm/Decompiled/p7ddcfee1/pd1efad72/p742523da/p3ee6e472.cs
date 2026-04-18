namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000¶\u0001\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u001c\u0018\u0000 `2\u00020\u00012\u00020\u0002:\u0005_`abcB?\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u0006\u0010\t\u001a\u00020\n\u0012\u0006\u0010\u000b\u001a\u00020\f\u0012\b\u0010\r\u001a\u0004\u0018\u00010\u000e\u0012\u0006\u0010\u000f\u001a\u00020\f¢\u0006\u0002\u0010\u0010J\u0016\u00102\u001a\u0002032\u0006\u00104\u001a\u00020\f2\u0006\u00105\u001a\u000206J\b\u00107\u001a\u000203H\u0016J\u001f\u00108\u001a\u0002032\u0006\u00109\u001a\u00020:2\b\u0010;\u001a\u0004\u0018\u00010<H\u0000¢\u0006\u0002\b=J\u001a\u0010>\u001a\u00020\u00122\u0006\u0010?\u001a\u00020%2\b\u0010@\u001a\u0004\u0018\u00010\u0018H\u0016J \u0010>\u001a\u00020\u00122\u0006\u0010?\u001a\u00020%2\b\u0010@\u001a\u0004\u0018\u00010\u00182\u0006\u0010A\u001a\u00020\fJ\u000e\u0010B\u001a\u0002032\u0006\u0010C\u001a\u00020DJ\u001c\u0010E\u001a\u0002032\n\u0010F\u001a\u00060Gj\u0002`H2\b\u00109\u001a\u0004\u0018\u00010:J\u0016\u0010I\u001a\u0002032\u0006\u0010\u001e\u001a\u00020\u00182\u0006\u0010*\u001a\u00020+J\u0006\u0010J\u001a\u000203J\u0018\u0010K\u001a\u0002032\u0006\u0010?\u001a\u00020%2\u0006\u0010@\u001a\u00020\u0018H\u0016J\u0010\u0010L\u001a\u0002032\u0006\u0010M\u001a\u00020\u0018H\u0016J\u0010\u0010L\u001a\u0002032\u0006\u0010N\u001a\u00020 H\u0016J\u0010\u0010O\u001a\u0002032\u0006\u0010P\u001a\u00020 H\u0016J\u0010\u0010Q\u001a\u0002032\u0006\u0010P\u001a\u00020 H\u0016J\u000e\u0010R\u001a\u00020\u00122\u0006\u0010P\u001a\u00020 J\u0006\u0010S\u001a\u00020\u0012J\b\u0010!\u001a\u00020\fH\u0016J\u0006\u0010'\u001a\u00020%J\u0006\u0010(\u001a\u00020%J\b\u0010T\u001a\u00020\u0006H\u0016J\b\u0010U\u001a\u000203H\u0002J\u0010\u0010V\u001a\u00020\u00122\u0006\u0010M\u001a\u00020\u0018H\u0016J\u0010\u0010V\u001a\u00020\u00122\u0006\u0010N\u001a\u00020 H\u0016J\u0018\u0010V\u001a\u00020\u00122\u0006\u0010W\u001a\u00020 2\u0006\u0010X\u001a\u00020%H\u0002J\u0006\u0010)\u001a\u00020%J\u0006\u0010Y\u001a\u000203J\r\u0010Z\u001a\u00020\u0012H\u0000¢\u0006\u0002\b[J\r\u0010\\\u001a\u000203H\u0000¢\u0006\u0002\b]J\f\u0010^\u001a\u00020\u0012*\u00020\u000eH\u0002R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0013\u001a\u0004\u0018\u00010\u0014X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0015\u001a\u00020\u0012X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\r\u001a\u0004\u0018\u00010\u000eX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0016\u001a\u00020\u0012X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0017\u001a\u00020\u0018X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\u00020\bX\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0019\u0010\u001aR\u0014\u0010\u001b\u001a\b\u0012\u0004\u0012\u00020\u001d0\u001cX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u001e\u001a\u0004\u0018\u00010\u0018X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u001f\u001a\b\u0012\u0004\u0012\u00020 0\u001cX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010!\u001a\u00020\fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\"\u001a\u0004\u0018\u00010#X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010$\u001a\u00020%X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010&\u001a\u0004\u0018\u00010\u0018X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010'\u001a\u00020%X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010(\u001a\u00020%X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010)\u001a\u00020%X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010*\u001a\u0004\u0018\u00010+X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010,\u001a\u00020-X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010.\u001a\u0004\u0018\u00010/X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u00100\u001a\u0004\u0018\u000101X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006d"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472;", "Lp7ddcfee1/p45edc1b9;", "Lp7ddcfee1/pd1efad72/p742523da/p3d6bb966$pa3496286;", "taskRunner", "Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;", "originalRequest", "Lp7ddcfee1/p15c2d85f;", "listener", "Lp7ddcfee1/p8b23b5f6;", "random", "Ljava/util/Random;", "pingIntervalMillis", "", "extensions", "Lp7ddcfee1/pd1efad72/p742523da/p495b756f;", "minimumDeflateSize", "(Lp7ddcfee1/pd1efad72/p7a3075c7/pf9f34f60;Lp7ddcfee1/p15c2d85f;Lp7ddcfee1/p8b23b5f6;Ljava/util/Random;JLp7ddcfee1/pd1efad72/p742523da/p495b756f;J)V", "awaitingPong", "", "call", "Lp7ddcfee1/pc3755e61;", "enqueuedClose", "failed", "key", "", "getListener$okhttp", "()Lp7ddcfee1/p8b23b5f6;", "messageAndCloseQueue", "Ljava/util/ArrayQueue;", "", "name", "pongQueue", "Lp38cb8f46/p58efa9e8;", "queueSize", "reader", "Lp7ddcfee1/pd1efad72/p742523da/p3d6bb966;", "receivedCloseCode", "", "receivedCloseReason", "receivedPingCount", "receivedPongCount", "sentPingCount", "streams", "Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$p21b3cb64;", "taskQueue", "Lp7ddcfee1/pd1efad72/p7a3075c7/p6d96efb7;", "writer", "Lp7ddcfee1/pd1efad72/p742523da/pd35bb464;", "writerTask", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "awaitTermination", "", "timeout", "timeUnit", "Ljava/util/concurrent/TimeUnit;", "cancel", "checkUpgradeSuccess", "response", "Lp7ddcfee1/pd64ed3e9;", "exchange", "Lp7ddcfee1/pd1efad72/p4717d53e/p992374d8;", "checkUpgradeSuccess$okhttp", "close", "code", "reason", "cancelAfterCloseMillis", "connect", "client", "Lp7ddcfee1/p1cda7fcc;", "failWebSocket", "e", "Ljava/lang/Exception;", "Lkotlin/Exception;", "initReaderAndWriter", "loopReader", "onReadClose", "onReadMessage", "text", "bytes", "onReadPing", "payload", "onReadPong", "pong", "processNextFrame", "request", "runWriter", "send", "data", "formatOpcode", "tearDown", "writeOneFrame", "writeOneFrame$okhttp", "writePingFrame", "writePingFrame$okhttp", "isValid", "Close", "Companion", "Message", "Streams", "WriterTask", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p3ee6e472 : p7ddcfee1.p45edc1b9, p7ddcfee1.pd1efad72.p742523da.p3d6bb966.pa3496286 {
    private static readonly long f0e4515f9 = 60000;
    private static readonly long f12333b54 = 16777216;
    private static readonly long f13f6d4a0 = 16777216;
    private static readonly long f150f4778 = 16777216;
    public static readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p910eef8c f3e4f41a3 = null;
    private static readonly long f4621b568 = 16777216;
    public static readonly long f582dc003 = 1024;
    public static readonly long f5ae66a24 = 1024;
    private static readonly java.util.List f5e48f584 = null;
    public static readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p910eef8c f85e17b3c = null;
    private static readonly java.util.List f8a3d8754 = null;
    private static readonly java.util.List<p7ddcfee1.p888a77f5> f8e2b292b = null;
    public static readonly p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p910eef8c f910eef8c = null;
    private static readonly long fb183ae3a = 60000;
    private static readonly java.util.List fb1b97eea = null;
    private static readonly java.util.List fb729f499 = null;
    private static readonly long fcc2da0af = 60000;
    public static readonly long fdf42bda1 = 1024;
    private static readonly long ff1c5c98d = 16777216;
    public static readonly long ff4461045 = 1024;
    private int f0ede009a;
    private int f1247ce20;
    private readonly java.util.ArrayQueue f134d3adf;
    private readonly java.lang.string f19b3f784;
    private readonly java.lang.string f1a256664;
    private java.lang.string f1ca5818b;
    private p7ddcfee1.pd1efad72.p742523da.p3d6bb966 f1de9b0a3;
    private p7ddcfee1.pd1efad72.p742523da.pd35bb464 f20e49c35;
    private p7ddcfee1.pd1efad72.p742523da.p495b756f f25919fee;
    private bool f26934eb3;
    private readonly p7ddcfee1.p15c2d85f f29ce7b72;
    private int f29d56da8;
    private p7ddcfee1.pd1efad72.p742523da.p495b756f f2ac737d2;
    private java.lang.string f2b80a574;
    private p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64 f2d9283e7;
    private p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64 f2f6f4768;
    private bool f353e16cb;
    private readonly java.util.ArrayQueue f3829d3c2;
    private readonly java.lang.string f3c6e0b8a;
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f3c8508f0;
    private java.lang.string f3f2138d5;
    private readonly p7ddcfee1.p8b23b5f6 f41bbd186;
    private java.lang.string f4474a732;
    private bool f44f185cb;
    private bool f491ac072;
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f4a9d1360;
    private bool f4f7539b7;
    private readonly p7ddcfee1.p15c2d85f f539f42cd;
    private p7ddcfee1.pc3755e61 f53b9e967;
    private readonly java.util.ArrayQueue f546dff49;
    private p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 f54c2564a;
    private int f593cf47e;
    private p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64 f5ba66881;
    private bool f5bd5ee4d;
    private p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 f5bf3947d;
    private readonly java.util.ArrayQueue<p38cb8f46.p58efa9e8> f5c4d9ec1;
    private bool f62d5be6f;
    private p7ddcfee1.pd1efad72.p742523da.pd35bb464 f676c9d71;
    private long f6907fd5c;
    private readonly java.util.ArrayQueue f6b4511b6;
    private readonly long f6dfd3d35;
    private java.lang.string f757ef688;
    private readonly p7ddcfee1.p15c2d85f f7ae19444;
    private p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 f7b25a1d3;
    private readonly p7ddcfee1.p8b23b5f6 f7ba825be;
    private bool f7c9b38a2;
    private p7ddcfee1.pc3755e61 f7ca1c56b;
    private readonly java.util.Random f7ddf32e1;
    private p7ddcfee1.pd1efad72.p742523da.p3d6bb966 f8093a217;
    private bool f80bacbe2;
    private long f853bf523;
    private long f86f7812c;
    private readonly java.util.ArrayQueue f8b9350a1;
    private java.lang.string f8c9bc449;
    private p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64 f8d7b00c0;
    private int f8e55a129;
    private p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64 f90ad89bf;
    private int f982e4299;
    private int f9b2188ec;
    private readonly java.util.ArrayQueue f9f078b49;
    private java.lang.string fa14fd14d;
    private long fa2bce941;
    private int fa3097f8e;
    private int fa4775091;
    private p7ddcfee1.pd1efad72.p742523da.pd35bb464 fa82feee3;
    private readonly java.util.ArrayQueue<java.lang.object> fabbd243b;
    private int fac77eaca;
    private java.lang.string fb068931c;
    private int fb2e86786;
    private int fb3486d44;
    private readonly java.util.Random fb80e6d78;
    private p7ddcfee1.pd1efad72.p742523da.pd35bb464 fb9a80272;
    private bool fbc6650b6;
    private long fbc6bcec1;
    private int fc786abbb;
    private int fccb82e79;
    private java.lang.string fcd815f45;
    private p7ddcfee1.pd1efad72.p742523da.p495b756f fce963acf;
    private long fd025fa77;
    private readonly p7ddcfee1.p8b23b5f6 fd0b62cf0;
    private long fd1e78209;
    private readonly long fe07b6573;
    private bool fe1c84007;
    private bool fe3924daf;
    private bool fe45fb09e;
    private readonly java.lang.string fe600e056;
    private bool fe7c28f53;
    private int ffb2495b7;
    private p7ddcfee1.pd1efad72.p742523da.p3d6bb966 ffb3c4c28;
    private java.lang.string ffba391e1;

    @kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\b&\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$p21b3cb64;", "Ljava/io/IDisposable;", "client", "", "source", "Lp38cb8f46/pcc81e3f6;", "sink", "Lp38cb8f46/p08d84bc6;", "(ZLp38cb8f46/pcc81e3f6;Lp38cb8f46/p08d84bc6;)V", "getClient", "()Z", "getSink", "()Lp38cb8f46/p08d84bc6;", "getSource", "()Lp38cb8f46/pcc81e3f6;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static abstract class p21b3cb64 : java.io.IDisposable {
        private readonly bool f23a71c8d;
        private readonly p38cb8f46.p08d84bc6 f2ac43657;
        private readonly bool f33604b10;
        private readonly p38cb8f46.pcc81e3f6 f36cd38f4;
        private readonly p38cb8f46.pcc81e3f6 f3a1550df;
        private readonly bool f62608e08;
        private readonly bool fbce2a268;
        private readonly bool fd4ecbdb3;
        private readonly p38cb8f46.p08d84bc6 ff6e04117;

        public p21b3cb64(bool r2, p38cb8f46.pcc81e3f6 r3, p38cb8f46.p08d84bc6 r4) {
                r1 = this;
                goto L2b
            L4:
                java.lang.string r0 = "sink"
                goto L32
            La:
                java.lang.string r0 = "source"
                goto L39
            L10:
                r1.<init>()
                goto L40
            L17:
                r1.f36cd38f4 = r3
                goto L20
            L1d:
                goto L2e
            L20:
                r1.ff6e04117 = r4
                goto L26
            L26:
                return
            L27:
                goto L1d
            L2b:
                goto L27
            L2e:
                goto La
            L32:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
                goto L10
            L39:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto L4
            L40:
                r1.f62608e08 = r2
                goto L17
        }

        public readonly bool GetClient() {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto Lf
            L9:
                bool r0 = r0.f62608e08
                goto L4
            Lf:
                goto L15
            L12:
                goto L5
            L15:
                goto L9
        }

        public readonly p38cb8f46.p08d84bc6 GetSink() {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto Lf
            L9:
                p38cb8f46.p08d84bc6 r0 = r0.ff6e04117
                goto L4
            Lf:
                goto L15
            L12:
                goto L5
            L15:
                goto L9
        }

        public readonly p38cb8f46.pcc81e3f6 GetSource() {
                r0 = this;
                goto La
            L4:
                p38cb8f46.pcc81e3f6 r0 = r0.f36cd38f4
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
    }

    @kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0000\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000b"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$p4c2a8fe7;", "", "formatOpcode", "", "data", "Lp38cb8f46/p58efa9e8;", "(ILp38cb8f46/p58efa9e8;)V", "getData", "()Lp38cb8f46/p58efa9e8;", "getFormatOpcode", "()I", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static readonly class p4c2a8fe7 {
        private readonly int f39617104;
        private readonly int f771d4c3a;
        private readonly p38cb8f46.p58efa9e8 f8d777f38;
        private readonly p38cb8f46.p58efa9e8 f8f88ddce;
        private readonly p38cb8f46.p58efa9e8 fb46b1db2;
        private readonly p38cb8f46.p58efa9e8 fbf8c04ce;

        public p4c2a8fe7(int r2, p38cb8f46.p58efa9e8 r3) {
                r1 = this;
                goto L9
            L4:
                return
            L5:
                goto L24
            L9:
                goto L5
            Lc:
                goto L17
            L10:
                r1.<init>()
                goto L2d
            L17:
                java.lang.string r0 = "data"
                goto L1d
            L1d:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
                goto L10
            L24:
                goto Lc
            L27:
                r1.f8d777f38 = r3
                goto L4
            L2d:
                r1.f39617104 = r2
                goto L27
        }

        public readonly p38cb8f46.p58efa9e8 GetData() {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto Lf
            L9:
                p38cb8f46.p58efa9e8 r0 = r0.f8d777f38
                goto L4
            Lf:
                goto L15
            L12:
                goto L5
            L15:
                goto L9
        }

        public readonly int GetFormatOpcode() {
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
                int r0 = r0.f39617104
                goto Lb
        }
    }

    @kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0004X\u0086T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$p910eef8c;", "", "()V", "CANCEL_AFTER_CLOSE_MILLIS", "", "DEFAULT_MINIMUM_DEFLATE_SIZE", "MAX_QUEUE_SIZE", "ONLY_HTTP1", "", "Lp7ddcfee1/p888a77f5;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static readonly class p910eef8c {
        private p910eef8c() {
                r0 = this;
                goto L13
            L4:
                return
            L5:
                goto L9
            L9:
                goto L16
            Lc:
                r0.<init>()
                goto L4
            L13:
                goto L5
            L16:
                goto Lc
        }

        public /* synthetic */ p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker r1) {
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
    }

    @kotlin.Metadata(d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0016¨\u0006\u0005"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$pce275d85;", "Lp7ddcfee1/pd1efad72/p7a3075c7/peaeb30f9;", "(Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472;)V", "runOnce", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    private readonly class pce275d85 : p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 {
        readonly /* synthetic */ p7ddcfee1.pd1efad72.p742523da.p3ee6e472 this$0;

        public pce275d85(p7ddcfee1.pd1efad72.p742523da.p3ee6e472 r4) {
                r3 = this;
                goto L63
            L4:
                java.lang.string r4 = p7ddcfee1.pd1efad72.p742523da.p3ee6e472.access$getName$p(r4)
                goto L32
            Lc:
                java.lang.string r4 = kotlin.jvm.internal.Intrinsics.stringPlus(r4, r0)
                goto L51
            L14:
                r3.<init>(r4, r2, r0, r1)
                goto L7e
            L1b:
                goto L5f
            L1e:
                goto L2f
            L22:
                int r0 = r0 + r1
                goto L56
            L28:
                r0 = 28
                goto L38
            L2f:
                goto L66
            L32:
                java.lang.string r0 = " writer"
                goto Lc
            L38:
                r1 = 6
                goto L22
            L3f:
                r2 = 0
                goto L14
            L44:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
                goto L78
            L4b:
                java.lang.string r0 = "this$0"
                goto L44
            L51:
                r0 = 2
                goto L73
            L56:
                int r0 = r0 % r1
                goto L6a
            L5c:
                goto L7f
            L5f:
                goto L4b
            L63:
                goto L1e
            L66:
                goto L28
            L6a:
                if (r0 <= 0) goto L6f
                goto L5f
            L6f:
                goto L5c
            L73:
                r1 = 0
                goto L3f
            L78:
                r3.this$0 = r4
                goto L4
            L7e:
                return
            L7f:
                goto L1b
        }

        @Override // p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9
        public long RunOnce() {
                r2 = this;
                goto L39
            L4:
                p7ddcfee1.pd1efad72.p742523da.p3ee6e472 r2 = r2.this$0
                goto L71
            La:
                int r0 = r0 % r1
                goto L46
            L10:
                r2.failWebSocket(r0, r1)
            L13:
                goto L77
            L17:
                r1 = 0
                goto L10
            L1c:
                r1 = 18
                goto L33
            L23:
                r0 = 0
                goto L40
            L29:
                goto L3c
            L2c:
                r0 = 30
                goto L1c
            L33:
                int r0 = r0 + r1
                goto La
            L39:
                goto L60
            L3c:
                goto L2c
            L40:
                return r0
            L41:
                r0 = move-exception
                goto L4
            L46:
                if (r0 <= 0) goto L4b
                goto L67
            L4b:
                goto L64
            L4f:
                if (r2 != 0) goto L54
                goto L13
            L54:
                goto L23
            L58:
                return r0
            L59:
                goto L5d
            L5d:
                goto L67
            L60:
                goto L29
            L64:
                goto L59
            L67:
                p7ddcfee1.pd1efad72.p742523da.p3ee6e472 r0 = r2.this$0     // Catch: java.io.IOException -> L41
                bool r2 = r0.writeOneFrame$okhttp()     // Catch: java.io.IOException -> L41
                goto L4f
            L71:
                java.lang.Exception r0 = (java.lang.Exception) r0
                goto L17
            L77:
                r0 = -1
                goto L58
        }
    }

    @kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\b\b\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u000f"}, d2 = {"Lp7ddcfee1/pd1efad72/p742523da/p3ee6e472$pd3d2e617;", "", "code", "", "reason", "Lp38cb8f46/p58efa9e8;", "cancelAfterCloseMillis", "", "(ILp38cb8f46/p58efa9e8;J)V", "getCancelAfterCloseMillis", "()J", "getCode", "()I", "getReason", "()Lp38cb8f46/p58efa9e8;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static readonly class pd3d2e617 {
        private readonly int f1987fa89;
        private readonly p38cb8f46.p58efa9e8 f1dc23ded;
        private readonly p38cb8f46.p58efa9e8 f28176be5;
        private readonly p38cb8f46.p58efa9e8 f40bea8d6;
        private readonly long f4d8bff31;
        private readonly int f8dca2472;
        private readonly int fa63f2e53;
        private readonly p38cb8f46.p58efa9e8 fa87b3cb9;
        private readonly int fbc130b02;
        private readonly int fc1336794;
        private readonly p38cb8f46.p58efa9e8 fd0875dec;
        private readonly long fe7d527d5;

        public pd3d2e617(int r1, p38cb8f46.p58efa9e8 r2, long r3) {
                r0 = this;
                goto L7
            L4:
                goto La
            L7:
                goto L15
            La:
                goto L19
            Le:
                r0.fe7d527d5 = r3
                goto L14
            L14:
                return
            L15:
                goto L4
            L19:
                r0.<init>()
                goto L26
            L20:
                r0.f40bea8d6 = r2
                goto Le
            L26:
                r0.fc1336794 = r1
                goto L20
        }

        public readonly long GetCancelAfterCloseMillis() {
                r2 = this;
                goto L1c
            L4:
                r1 = 20
                goto L3e
            Lb:
                goto L24
            Le:
                goto L44
            L12:
                goto L1f
            L15:
                goto Le
            L18:
                goto L12
            L1c:
                goto L18
            L1f:
                goto L31
            L23:
                return r0
            L24:
                goto L15
            L28:
                if (r0 <= 0) goto L2d
                goto Le
            L2d:
                goto Lb
            L31:
                r0 = 1
                goto L4
            L38:
                int r0 = r0 % r1
                goto L28
            L3e:
                int r0 = r0 + r1
                goto L38
            L44:
                long r0 = r2.fe7d527d5
                goto L23
        }

        public readonly int GetCode() {
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
                int r0 = r0.fc1336794
                goto L7
        }

        public readonly p38cb8f46.p58efa9e8 GetReason() {
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
                p38cb8f46.p58efa9e8 r0 = r0.f40bea8d6
                goto Lb
            L16:
                goto L7
        }
    }

    static {
            goto L33
        L4:
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472.f8e2b292b = r0
            goto L65
        La:
            r1 = 0
            goto L4d
        Lf:
            goto L66
        L12:
            goto L24
        L16:
            int r0 = r0 + r1
            goto L6a
        L1c:
            java.util.List r0 = kotlin.collections.ICollectionsKt.listOf(r0)
            goto L4
        L24:
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p910eef8c r0 = new p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p910eef8c
            goto La
        L2a:
            if (r0 <= 0) goto L2f
            goto L12
        L2f:
            goto Lf
        L33:
            goto L43
        L36:
            goto L57
        L3a:
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472.f910eef8c = r0
            goto L47
        L40:
            goto L12
        L43:
            goto L54
        L47:
            p7ddcfee1.p888a77f5 r0 = p7ddcfee1.p888a77f5.f5f1f9932
            goto L1c
        L4d:
            r0.<init>(r1)
            goto L3a
        L54:
            goto L36
        L57:
            r0 = 14
            goto L5e
        L5e:
            r1 = 13
            goto L16
        L65:
            return
        L66:
            goto L40
        L6a:
            int r0 = r0 % r1
            goto L2a
    }

    public p3ee6e472(p7ddcfee1.pd1efad72.p7a3075c7.pf9f34f60 r2, p7ddcfee1.p15c2d85f r3, p7ddcfee1.p8b23b5f6 r4, java.util.Random r5, long r6, p7ddcfee1.pd1efad72.p742523da.p495b756f r8, long r9) {
            r1 = this;
            goto L5f
        L4:
            java.lang.string r0 = "listener"
            goto L76
        La:
            java.lang.string r0 = "random"
            goto La1
        L10:
            java.lang.string r2 = r3.method()
            goto La8
        L18:
            java.util.ArrayQueue r2 = new java.util.ArrayQueue
            goto Lce
        L1e:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto Ld5
        L25:
            java.lang.IllegalArgumentException r2 = new java.lang.IllegalArgumentException
            goto Lf7
        L2b:
            r2 = 16
            goto L7d
        L31:
            throw r2
        L32:
            goto L73
        L36:
            java.lang.string r4 = r3.method()
            goto L89
        L3e:
            r2.<init>()
            goto L10d
        L45:
            r5.nextbytes(r4)
            goto L9b
        L4c:
            p38cb8f46.p58efa9e8 r2 = p38cb8f46.p58efa9e8.p910eef8c.m527a6c53(r3, r4, r5, r6, r7, r8)
            goto Lff
        L54:
            r1.fabbd243b = r2
            goto Lbd
        L5a:
            r8 = 0
            goto L96
        L5f:
            goto L32
        L62:
            goto L132
        L66:
            r1.f2ac737d2 = r8
            goto L138
        L6c:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L4
        L73:
            goto L62
        L76:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto La
        L7d:
            byte[] r4 = new byte[r2]
            goto L45
        L83:
            java.lang.string r1 = "Request must be GET: "
            goto L10
        L89:
            bool r2 = kotlin.jvm.internal.Intrinsics.areEqual(r2, r4)
            goto Le7
        L91:
            return
        L92:
            goto L83
        L96:
            r5 = 0
            goto L144
        L9b:
            kotlin.Unit r2 = kotlin.Unit.INSTANCE
            goto Lb0
        La1:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto L11f
        La8:
            java.lang.string r1 = kotlin.jvm.internal.Intrinsics.stringPlus(r1, r2)
            goto L25
        Lb0:
            r7 = 3
            goto L5a
        Lb5:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r2 = r2.newQueue()
            goto Ldb
        Lbd:
            r2 = -1
            goto L126
        Lc2:
            r1.f3c6e0b8a = r2
            goto L91
        Lc8:
            java.util.ArrayQueue r2 = new java.util.ArrayQueue
            goto L3e
        Lce:
            r2.<init>()
            goto L54
        Ld5:
            java.lang.string r0 = "originalRequest"
            goto L6c
        Ldb:
            r1.f54c2564a = r2
            goto Lc8
        Le1:
            r1.fd0b62cf0 = r4
            goto L113
        Le7:
            if (r2 != 0) goto Lec
            goto L92
        Lec:
            goto L12c
        Lf0:
            r2.<init>(r1)
            goto L31
        Lf7:
            java.lang.string r1 = r1.tostring()
            goto Lf0
        Lff:
            java.lang.string r2 = r2.base64()
            goto Lc2
        L107:
            r1.f539f42cd = r3
            goto Le1
        L10d:
            r1.f5c4d9ec1 = r2
            goto L18
        L113:
            r1.f7ddf32e1 = r5
            goto L119
        L119:
            r1.f6dfd3d35 = r6
            goto L66
        L11f:
            r1.<init>()
            goto L107
        L126:
            r1.f0ede009a = r2
            goto L13e
        L12c:
            p38cb8f46.p58efa9e8$p910eef8c r3 = p38cb8f46.p58efa9e8.f910eef8c
            goto L2b
        L132:
            java.lang.string r0 = "taskRunner"
            goto L1e
        L138:
            r1.fa2bce941 = r9
            goto Lb5
        L13e:
            java.lang.string r2 = "GET"
            goto L36
        L144:
            r6 = 0
            goto L4c
    }

    public static readonly /* synthetic */ java.util.ArrayQueue access$getMessageAndCloseQueue$p(p7ddcfee1.pd1efad72.p742523da.p3ee6e472 r0) {
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            java.util.ArrayQueue<java.lang.object> r0 = r0.fabbd243b
            goto L11
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L7
    }

    public static readonly /* synthetic */ java.lang.string access$getName$p(p7ddcfee1.pd1efad72.p742523da.p3ee6e472 r0) {
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            java.lang.string r0 = r0.fb068931c
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    public static readonly /* synthetic */ bool access$isValid(p7ddcfee1.pd1efad72.p742523da.p3ee6e472 r0, p7ddcfee1.pd1efad72.p742523da.p495b756f r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r0.isValid(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static readonly /* synthetic */ void access$setExtensions$p(p7ddcfee1.pd1efad72.p742523da.p3ee6e472 r0, p7ddcfee1.pd1efad72.p742523da.p495b756f r1) {
            goto Ld
        L4:
            r0.f2ac737d2 = r1
            goto L14
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return
        L15:
            goto La
    }

    private readonly bool IsValid(p7ddcfee1.pd1efad72.p742523da.p495b756f r4) {
            r3 = this;
            goto L5b
        L4:
            if (r0 <= 0) goto L9
            goto L6a
        L9:
            goto L67
        Ld:
            goto L5e
        L10:
            int r4 = r4.intValue()
            goto L53
        L18:
            java.lang.int r4 = r4.f257d7bdf
            goto L10
        L1e:
            r1 = 13
            goto Lbc
        L25:
            return r0
        L26:
            goto L9f
        L2a:
            r0 = 19
            goto L1e
        L31:
            kotlin.ranges.IntRange r3 = new kotlin.ranges.IntRange
            goto L46
        L37:
            if (r3 != 0) goto L3c
            goto L95
        L3c:
            goto L94
        L40:
            java.lang.int r3 = r4.fe3bd472c
            goto L80
        L46:
            r1 = 8
            goto La9
        L4c:
            goto L6a
        L4f:
            goto Ld
        L53:
            bool r3 = r3.Contains(r4)
            goto L77
        L5b:
            goto L4f
        L5e:
            goto L2a
        L62:
            return r3
        L63:
            goto L4c
        L67:
            goto L63
        L6a:
            goto L99
        L6e:
            if (r3 != 0) goto L73
            goto L26
        L73:
            goto L31
        L77:
            if (r3 == 0) goto L7c
            goto L26
        L7c:
            goto L25
        L80:
            if (r3 != 0) goto L85
            goto La5
        L85:
            goto La4
        L89:
            r0 = 0
            goto L37
        L8e:
            java.lang.int r3 = r4.f257d7bdf
            goto L6e
        L94:
            return r0
        L95:
            goto L40
        L99:
            bool r3 = r4.fcc1c3b46
            goto L89
        L9f:
            r3 = 1
            goto L62
        La4:
            return r0
        La5:
            goto L8e
        La9:
            r2 = 15
            goto Laf
        Laf:
            r3.<init>(r1, r2)
            goto L18
        Lb6:
            int r0 = r0 % r1
            goto L4
        Lbc:
            int r0 = r0 + r1
            goto Lb6
    }

    private readonly void RunWriter() {
            r7 = this;
            goto L3c
        L4:
            r5 = 2
            goto Le3
        L9:
            r0 = 7
            goto L80
        L10:
            int r0 = r0 % r1
            goto La7
        L16:
            if (r0 != 0) goto L1b
            goto L20
        L1b:
            goto L1f
        L1f:
            goto L76
        L20:
            goto Lca
        L24:
            goto Lb1
        L27:
            goto L43
        L2b:
            java.lang.string r2 = "Thread "
            goto L4f
        L31:
            goto L3f
        L34:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L67
        L3c:
            goto La3
        L3f:
            goto L9
        L43:
            bool r0 = p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
            goto L87
        L49:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r1 = r7.f54c2564a
            goto L4
        L4f:
            r1.<init>(r2)
            goto Le8
        L56:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L7a
        L5e:
            if (r2 != 0) goto L63
            goto Lc6
        L63:
            goto L49
        L67:
            java.lang.stringBuilder r7 = r1.append(r7)
            goto L98
        L6f:
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r2 = r7.f7b25a1d3
            goto L5e
        L75:
            throw r0
        L76:
            goto L6f
        L7a:
            java.lang.string r2 = " MUST hold lock on "
            goto L34
        L80:
            r1 = 28
            goto Ld0
        L87:
            if (r0 != 0) goto L8c
            goto L76
        L8c:
            goto Lbb
        L90:
            java.lang.string r2 = r2.getName()
            goto L56
        L98:
            java.lang.string r7 = r7.tostring()
            goto Ld6
        La0:
            goto L27
        La3:
            goto L31
        La7:
            if (r0 <= 0) goto Lac
            goto L27
        Lac:
            goto L24
        Lb0:
            return
        Lb1:
            goto La0
        Lb5:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L2b
        Lbb:
            bool r0 = java.lang.Thread.holdsLock(r7)
            goto L16
        Lc3:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7.schedule$default(r1, r2, r3, r5, r6)
        Lc6:
            goto Lb0
        Lca:
            java.lang.AssertionError r0 = new java.lang.AssertionError
            goto Lb5
        Ld0:
            int r0 = r0 + r1
            goto L10
        Ld6:
            r0.<init>(r7)
            goto L75
        Ldd:
            r3 = 0
            goto Lc3
        Le3:
            r6 = 0
            goto Ldd
        Le8:
            java.lang.Thread r2 = java.lang.Thread.currentThread()
            goto L90
    }

    private readonly bool Send(p38cb8f46.p58efa9e8 r7, int r8) {
            r6 = this;
            goto L9
        L4:
            return r6
        L5:
            goto L38
        L9:
            goto L34
        Lc:
            goto L3d
        L10:
            monitor-exit(r6)
            goto L4d
        L15:
            return r1
        L16:
            long r0 = r6.fbc6bcec1     // Catch: java.lang.Exception -> L81
            int r2 = r7.Count     // Catch: java.lang.Exception -> L81
            long r2 = (long) r2     // Catch: java.lang.Exception -> L81
            long r0 = r0 + r2
            r6.fbc6bcec1 = r0     // Catch: java.lang.Exception -> L81
            java.util.ArrayQueue<java.lang.object> r0 = r6.fabbd243b     // Catch: java.lang.Exception -> L81
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p4c2a8fe7 r1 = new p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p4c2a8fe7     // Catch: java.lang.Exception -> L81
            r1.<init>(r8, r7)     // Catch: java.lang.Exception -> L81
            r0.Add(r1)     // Catch: java.lang.Exception -> L81
            r6.runWriter()     // Catch: java.lang.Exception -> L81
            goto L10
        L31:
            goto L93
        L34:
            goto L44
        L38:
            monitor-exit(r6)
            goto L80
        L3d:
            r0 = 4
            goto L97
        L44:
            goto Lc
        L47:
            int r0 = r0 % r1
            goto L87
        L4d:
            r6 = 1
            goto L4
        L52:
            monitor-exit(r6)
            goto L15
        L57:
            monitor-enter(r6)
            bool r0 = r6.f26934eb3     // Catch: java.lang.Exception -> L81
            r1 = 0
            if (r0 != 0) goto L5
            bool r0 = r6.f491ac072     // Catch: java.lang.Exception -> L81
            if (r0 == 0) goto L62
            goto L5
        L62:
            long r2 = r6.fbc6bcec1     // Catch: java.lang.Exception -> L81
            int r0 = r7.Count     // Catch: java.lang.Exception -> L81
            long r4 = (long) r0     // Catch: java.lang.Exception -> L81
            long r2 = r2 + r4
            r4 = 16777216(0x1000000, double:8.289046E-317)
            int r0 = (r2 > r4 ? 1 : (r2 == r4 ? 0 : -1))
            if (r0 <= 0) goto L16
            r7 = 1001(0x3e9, float:1.403E-42)
            r8 = 0
            r6.close(r7, r8)     // Catch: java.lang.Exception -> L81
            goto L52
        L7b:
            throw r7
        L7c:
            goto L31
        L80:
            return r1
        L81:
            r7 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L81
            goto L7b
        L87:
            if (r0 <= 0) goto L8c
            goto L93
        L8c:
            goto L90
        L90:
            goto L7c
        L93:
            goto L57
        L97:
            r1 = 11
            goto L9e
        L9e:
            int r0 = r0 + r1
            goto L47
    }

    public readonly void AwaitTermination(long r2, java.util.concurrent.TimeUnit r4) throws java.lang.InterruptedException {
            r1 = this;
            goto L4
        L4:
            goto L2a
        L7:
            goto L1b
        Lb:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r1 = r1.f54c2564a
            goto L21
        L11:
            goto L7
        L14:
            r1.await(r2, r4)
            goto L29
        L1b:
            java.lang.string r0 = "timeUnit"
            goto L2e
        L21:
            java.util.concurrent.CountdownEvent r1 = r1.idleLatch()
            goto L14
        L29:
            return
        L2a:
            goto L11
        L2e:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto Lb
    }

    @Override // p7ddcfee1.p45edc1b9
    public void Cancel() {
            r0 = this;
            goto L1b
        L4:
            goto L1e
        L7:
            p7ddcfee1.pc3755e61 r0 = r0.f53b9e967
            goto Ld
        Ld:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L14
        L14:
            r0.cancel()
            goto L22
        L1b:
            goto L23
        L1e:
            goto L7
        L22:
            return
        L23:
            goto L4
    }

    public readonly void checkUpgradeSuccess$okhttp(p7ddcfee1.pd64ed3e9 r8, p7ddcfee1.pd1efad72.p4717d53e.p992374d8 r9) throws java.io.IOException {
            r7 = this;
            goto L123
        L4:
            java.lang.stringBuilder r8 = r9.append(r8)
            goto L4a
        Lc:
            if (r0 == r1) goto L11
            goto L1df
        L11:
            goto L86
        L15:
            java.lang.stringBuilder r8 = r8.append(r0)
            goto L65
        L1d:
            java.lang.stringBuilder r8 = r8.append(r0)
            goto L3c
        L25:
            java.lang.string r8 = r8.tostring()
            goto L207
        L2d:
            java.lang.string r4 = "Upgrade"
            goto L15a
        L33:
            if (r9 != 0) goto L38
            goto L148
        L38:
            goto L147
        L3c:
            java.lang.stringBuilder r8 = r8.append(r2)
            goto L1e3
        L44:
            java.net.ProtocolException r7 = new java.net.ProtocolException
            goto L184
        L4a:
            java.lang.stringBuilder r8 = r8.append(r2)
            goto Lc8
        L52:
            r7.<init>(r8)
            goto L10a
        L59:
            java.lang.string r4 = "websocket"
            goto Le2
        L5f:
            java.lang.string r0 = "Sec-WebSocket-Accept"
            goto L174
        L65:
            java.lang.stringBuilder r8 = r8.append(r2)
            goto L25
        L6d:
            if (r6 != 0) goto L72
            goto L253
        L72:
            goto L102
        L76:
            java.lang.string r0 = p7ddcfee1.pd64ed3e9.m28ab1449(r8, r0, r1, r3, r1)
            goto L2d
        L7e:
            p38cb8f46.p58efa9e8 r7 = r7.sha1()
            goto L17c
        L86:
            java.lang.string r0 = "Connection"
            goto L167
        L8c:
            r0 = 25
            goto Lba
        L93:
            r2 = 39
            goto Lc
        L99:
            java.net.ProtocolException r7 = new java.net.ProtocolException
            goto L1bf
        L9f:
            int r0 = r0 + r1
            goto L224
        La5:
            java.lang.string r8 = "Web Socket exchange missing: bad interceptor?"
            goto L52
        Lab:
            java.lang.string r1 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto L214
        Lb3:
            java.lang.string r1 = "d8cf68c836db3beda9b3ce60c0c02d847b5b609d3afc91af02ff113c89b5cdbc66833f3518a6869fa732bf9a53f1159aa2de82e56747fbf2307919c4ba947b4d"
            goto Lab
        Lba:
            r1 = 18
            goto L9f
        Lc1:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r8, r0)
            goto L1d3
        Lc8:
            java.lang.string r8 = r8.tostring()
            goto L132
        Ld0:
            java.lang.string r9 = "Expected 'Upgrade' header value 'websocket' but was '"
            goto L1b8
        Ld6:
            p38cb8f46.p58efa9e8$p910eef8c r0 = p38cb8f46.p58efa9e8.f910eef8c
            goto L1cd
        Ldc:
            java.lang.string r1 = "Expected 'Sec-WebSocket-Accept' header value '"
            goto L23e
        Le2:
            bool r4 = kotlin.text.stringsKt.Equals(r4, r0, r5)
            goto L1f1
        Lea:
            java.lang.string r7 = r7.tostring()
            goto L1a4
        Lf2:
            java.lang.stringBuilder r7 = r7.append(r2)
            goto Lea
        Lfa:
            java.lang.stringBuilder r9 = r9.append(r0)
            goto L201
        L102:
            java.lang.string r0 = p7ddcfee1.pd64ed3e9.m28ab1449(r8, r4, r1, r3, r1)
            goto L59
        L10a:
            throw r7
        L10b:
            goto L1ab
        L10f:
            if (r0 != 0) goto L114
            goto L10b
        L114:
            goto L33
        L118:
            java.lang.stringBuilder r8 = new java.lang.stringBuilder
            goto L24c
        L11e:
            throw r9
        L11f:
            goto L99
        L123:
            goto L248
        L126:
            goto L8c
        L12a:
            java.lang.stringBuilder r7 = r7.append(r0)
            goto L139
        L132:
            r7.<init>(r8)
            goto L19f
        L139:
            java.lang.stringBuilder r7 = r7.append(r8)
            goto Lf2
        L141:
            java.lang.string r0 = "response"
            goto Lc1
        L147:
            return
        L148:
            goto L22a
        L14c:
            if (r0 <= 0) goto L151
            goto L195
        L151:
            goto L192
        L155:
            r3 = 2
            goto L76
        L15a:
            r5 = 1
            goto L15f
        L15f:
            bool r6 = kotlin.text.stringsKt.Equals(r4, r0, r5)
            goto L6d
        L167:
            r1 = 0
            goto L155
        L16c:
            java.lang.stringBuilder r9 = r9.append(r0)
            goto L18a
        L174:
            java.lang.string r8 = p7ddcfee1.pd64ed3e9.m28ab1449(r8, r0, r1, r3, r1)
            goto Ld6
        L17c:
            java.lang.string r7 = r7.base64()
            goto L230
        L184:
            java.lang.stringBuilder r9 = new java.lang.stringBuilder
            goto L1eb
        L18a:
            java.lang.string r8 = r8.message()
            goto L4
        L192:
            goto L1a0
        L195:
            goto L141
        L199:
            r1 = 101(0x65, float:1.42E-43)
            goto L93
        L19f:
            throw r7
        L1a0:
            goto L245
        L1a4:
            r9.<init>(r7)
            goto L11e
        L1ab:
            java.net.ProtocolException r9 = new java.net.ProtocolException
            goto L238
        L1b1:
            r9.<init>(r0)
            goto L21c
        L1b8:
            r8.<init>(r9)
            goto L15
        L1bf:
            java.lang.stringBuilder r8 = new java.lang.stringBuilder
            goto Ld0
        L1c5:
            java.lang.stringBuilder r7 = r0.append(r7)
            goto L20e
        L1cd:
            java.lang.string r7 = r7.f3c6e0b8a
            goto Lb3
        L1d3:
            int r0 = r8.code()
            goto L199
        L1db:
            goto L126
        L1de:
            throw r7
        L1df:
            goto L44
        L1e3:
            java.lang.string r8 = r8.tostring()
            goto L257
        L1eb:
            java.lang.string r0 = "Expected HTTP 101 response but was '"
            goto L1b1
        L1f1:
            if (r4 != 0) goto L1f6
            goto L11f
        L1f6:
            goto L5f
        L1fa:
            r8.<init>(r9)
            goto L1d
        L201:
            r0 = 32
            goto L16c
        L207:
            r7.<init>(r8)
            goto L252
        L20e:
            java.lang.string r0 = "' but was '"
            goto L12a
        L214:
            java.lang.string r7 = kotlin.jvm.internal.Intrinsics.stringPlus(r7, r1)
            goto L25e
        L21c:
            int r0 = r8.code()
            goto Lfa
        L224:
            int r0 = r0 % r1
            goto L14c
        L22a:
            java.net.ProtocolException r7 = new java.net.ProtocolException
            goto La5
        L230:
            bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r7, r8)
            goto L10f
        L238:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Ldc
        L23e:
            r0.<init>(r1)
            goto L1c5
        L245:
            goto L195
        L248:
            goto L1db
        L24c:
            java.lang.string r9 = "Expected 'Connection' header value 'Upgrade' but was '"
            goto L1fa
        L252:
            throw r7
        L253:
            goto L266
        L257:
            r7.<init>(r8)
            goto L1de
        L25e:
            p38cb8f46.p58efa9e8 r7 = r0.encodeUtf8(r7)
            goto L7e
        L266:
            java.net.ProtocolException r7 = new java.net.ProtocolException
            goto L118
    }

    @Override // p7ddcfee1.p45edc1b9
    public bool Close(int r3, java.lang.string r4) {
            r2 = this;
            goto L45
        L4:
            if (r0 <= 0) goto L9
            goto L16
        L9:
            goto L13
        Ld:
            int r0 = r0 + r1
            goto L28
        L13:
            goto L3a
        L16:
            goto L4c
        L1a:
            goto L16
        L1d:
            goto L2e
        L21:
            r0 = 29
            goto L3e
        L28:
            int r0 = r0 % r1
            goto L4
        L2e:
            goto L48
        L31:
            bool r2 = r2.close(r3, r4, r0)
            goto L39
        L39:
            return r2
        L3a:
            goto L1a
        L3e:
            r1 = 26
            goto Ld
        L45:
            goto L1d
        L48:
            goto L21
        L4c:
            r0 = 60000(0xea60, double:2.9644E-319)
            goto L31
    }

    public readonly bool Close(int r6, java.lang.string r7, long r8) {
            r5 = this;
            goto L10
        L4:
            goto L9d
        L7:
            goto L39
        Lb:
            return r7
        Lc:
            goto L1c
        L10:
            goto L7
        L13:
            goto L32
        L17:
            throw r6
        L18:
            goto L4
        L1c:
            monitor-exit(r5)
            goto L26
        L21:
            monitor-exit(r5)
            goto Lb
        L26:
            r5 = 0
            goto L2b
        L2b:
            return r5
        L2c:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L2c
            goto L17
        L32:
            r0 = 18
            goto L93
        L39:
            goto L13
        L3c:
            if (r0 <= 0) goto L41
            goto L9d
        L41:
            goto L9a
        L45:
            monitor-enter(r5)
            p7ddcfee1.pd1efad72.p742523da.pd775ff95 r0 = p7ddcfee1.pd1efad72.p742523da.pd775ff95.f76425f17     // Catch: java.lang.Exception -> L2c
            r0.validateCloseCode(r6)     // Catch: java.lang.Exception -> L2c
            if (r7 == 0) goto L6f
            p38cb8f46.p58efa9e8$p910eef8c r0 = p38cb8f46.p58efa9e8.f910eef8c     // Catch: java.lang.Exception -> L2c
            p38cb8f46.p58efa9e8 r0 = r0.encodeUtf8(r7)     // Catch: java.lang.Exception -> L2c
            int r1 = r0.Count     // Catch: java.lang.Exception -> L2c
            long r1 = (long) r1     // Catch: java.lang.Exception -> L2c
            r3 = 123(0x7b, double:6.1E-322)
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            if (r1 > 0) goto L5f
            goto L70
        L5f:
            java.lang.string r6 = "reason.Count > 123: "
            java.lang.string r6 = kotlin.jvm.internal.Intrinsics.stringPlus(r6, r7)     // Catch: java.lang.Exception -> L2c
            java.lang.IllegalArgumentException r7 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L2c
            java.lang.string r6 = r6.tostring()     // Catch: java.lang.Exception -> L2c
            r7.<init>(r6)     // Catch: java.lang.Exception -> L2c
            throw r7     // Catch: java.lang.Exception -> L2c
        L6f:
            r0 = 0
        L70:
            bool r7 = r5.f26934eb3     // Catch: java.lang.Exception -> L2c
            if (r7 != 0) goto Lc
            bool r7 = r5.f491ac072     // Catch: java.lang.Exception -> L2c
            if (r7 == 0) goto L79
            goto Lc
        L79:
            r7 = 1
            r5.f491ac072 = r7     // Catch: java.lang.Exception -> L2c
            java.util.ArrayQueue<java.lang.object> r1 = r5.fabbd243b     // Catch: java.lang.Exception -> L2c
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pd3d2e617 r2 = new p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pd3d2e617     // Catch: java.lang.Exception -> L2c
            r2.<init>(r6, r0, r8)     // Catch: java.lang.Exception -> L2c
            r1.Add(r2)     // Catch: java.lang.Exception -> L2c
            r5.runWriter()     // Catch: java.lang.Exception -> L2c
            goto L21
        L8d:
            int r0 = r0 + r1
            goto La1
        L93:
            r1 = 3
            goto L8d
        L9a:
            goto L18
        L9d:
            goto L45
        La1:
            int r0 = r0 % r1
            goto L3c
    }

    public readonly void Connect(p7ddcfee1.p1cda7fcc r5) {
            r4 = this;
            goto L2d
        L4:
            goto L86
        L7:
            goto L7c
        Lb:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1)
            goto L68
        L12:
            java.lang.string r2 = "websocket"
            goto L11a
        L18:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r2, r3)
            goto L34
        L20:
            p7ddcfee1.p15c2d85f r0 = r0.build()
            goto L15b
        L28:
            r0 = 0
            goto L4f
        L2d:
            goto L179
        L30:
            goto L48
        L34:
            java.lang.string r2 = "Sec-WebSocket-Key"
            goto L92
        L3a:
            java.lang.string r0 = r0.header(r1)
            goto La1
        L42:
            r4.f53b9e967 = r1
            goto Lb
        L48:
            r0 = 30
            goto L167
        L4f:
            r4.failWebSocket(r5, r0)
            goto L63
        L56:
            r1.<init>(r5, r0, r2)
            goto L13a
        L5d:
            java.util.List<p7ddcfee1.p888a77f5> r0 = p7ddcfee1.pd1efad72.p742523da.p3ee6e472.f8e2b292b
            goto L16e
        L63:
            return
        L64:
            goto L112
        L68:
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pb640a0ce$1 r5 = new p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pb640a0ce$1
            goto Lc0
        L6e:
            java.lang.string r2 = "permessage-deflate"
            goto Ld4
        L74:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r3, r2)
            goto Lc7
        L7c:
            java.lang.string r0 = "client"
            goto L120
        L82:
            goto L30
        L85:
            return
        L86:
            goto L176
        L8a:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r2, r3)
            goto Ldc
        L92:
            java.lang.string r3 = r4.f3c6e0b8a
            goto L8a
        L98:
            if (r0 <= 0) goto L9d
            goto L7
        L9d:
            goto L4
        La1:
            if (r0 != 0) goto La6
            goto L64
        La6:
            goto Lba
        Laa:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.newBuilder()
            goto L12
        Lb2:
            p7ddcfee1.p1cda7fcc r5 = r5.build()
            goto L140
        Lba:
            java.net.ProtocolException r5 = new java.net.ProtocolException
            goto L10c
        Lc0:
            r5.<init>(r4, r0)
            goto L161
        Lc7:
            java.lang.string r2 = "Connection"
            goto L18
        Lcd:
            r5.<init>(r0)
            goto L134
        Ld4:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r1, r2)
            goto L20
        Ldc:
            java.lang.string r2 = "Sec-WebSocket-Version"
            goto L127
        Le2:
            p7ddcfee1.p1cda7fcc$p2bd4a59b r5 = r5.eventListener(r0)
            goto L5d
        Lea:
            int r0 = r0 + r1
            goto Lf8
        Lf0:
            java.lang.string r1 = com.decryptstringmanager.Decryptstring.decryptstring(r1)
            goto L3a
        Lf8:
            int r0 = r0 % r1
            goto L98
        Lfe:
            java.lang.string r1 = "dc7945a0f240128700689a6734f6788847a2867c424375b633b59b49bcf2ec646d4767029315469f61d1233c61d44287a09c4b4f"
            goto Lf0
        L105:
            r1.enqueue(r5)
            goto L85
        L10c:
            java.lang.string r0 = "Request header not permitted: 'Sec-WebSocket-Extensions'"
            goto Lcd
        L112:
            p7ddcfee1.p1cda7fcc$p2bd4a59b r5 = r5.newBuilder()
            goto L17d
        L11a:
            java.lang.string r3 = "Upgrade"
            goto L74
        L120:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto L12e
        L127:
            java.lang.string r3 = "1ecbfa66dcd2bc658a68f35e05fa2b374f957257bcf2b0035feebf9c8624"
            goto L153
        L12e:
            p7ddcfee1.p15c2d85f r0 = r4.f539f42cd
            goto Lfe
        L134:
            java.lang.Exception r5 = (java.lang.Exception) r5
            goto L28
        L13a:
            p7ddcfee1.pc3755e61 r1 = (p7ddcfee1.pc3755e61) r1
            goto L42
        L140:
            p7ddcfee1.p15c2d85f r0 = r4.f539f42cd
            goto Laa
        L146:
            p7ddcfee1.p15c2d85f$p2bd4a59b r0 = r0.header(r2, r3)
            goto L6e
        L14e:
            r2 = 1
            goto L56
        L153:
            java.lang.string r3 = com.decryptstringmanager.Decryptstring.decryptstring(r3)
            goto L146
        L15b:
            p7ddcfee1.pd1efad72.p4717d53e.p6d310f89 r1 = new p7ddcfee1.pd1efad72.p4717d53e.p6d310f89
            goto L14e
        L161:
            p7ddcfee1.p406c70d6 r5 = (p7ddcfee1.p406c70d6) r5
            goto L105
        L167:
            r1 = 11
            goto Lea
        L16e:
            p7ddcfee1.p1cda7fcc$p2bd4a59b r5 = r5.protocols(r0)
            goto Lb2
        L176:
            goto L7
        L179:
            goto L82
        L17d:
            p7ddcfee1.p4f9a1811 r0 = p7ddcfee1.p4f9a1811.fb50339a1
            goto Le2
    }

    public readonly void FailWebSocket(java.lang.Exception r5, p7ddcfee1.pd64ed3e9 r6) {
            r4 = this;
            goto L63
        L4:
            java.io.IDisposable r2 = (java.io.IDisposable) r2
            goto Lf1
        La:
            if (r3 == 0) goto Lf
            goto Lc7
        Lf:
            goto Lc6
        L13:
            throw r5
        L14:
            goto L108
        L18:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r3)
        L1b:
            goto L31
        L1f:
            if (r2 == 0) goto L24
            goto Lc2
        L24:
            goto Lc1
        L28:
            if (r0 != 0) goto L2d
            goto L9a
        L2d:
            goto L9e
        L31:
            throw r4
        L32:
            r5 = move-exception
            goto Le6
        L37:
            int r0 = r0 % r1
            goto L10f
        L3d:
            if (r0 == 0) goto L42
            goto L48
        L42:
            goto L46
        L46:
            goto L104
        L48:
            goto Laf
        L4c:
            goto L66
        L4f:
            java.io.IDisposable r2 = (java.io.IDisposable) r2
            goto L84
        L55:
            r1 = 12
            goto La3
        L5c:
            r0 = 4
            goto L55
        L63:
            goto L10b
        L66:
            goto L5c
        L6a:
            goto L14
        L6d:
            goto Lbb
        L71:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r3)
            goto La9
        L78:
            java.io.IDisposable r3 = (java.io.IDisposable) r3
            goto L18
        L7e:
            java.io.IDisposable r3 = (java.io.IDisposable) r3
            goto L71
        L84:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r2)
        L87:
            goto La
        L8b:
            monitor-exit(r4)
            p7ddcfee1.p8b23b5f6 r1 = r4.fd0b62cf0     // Catch: java.lang.Exception -> Laa
            p7ddcfee1.p45edc1b9 r4 = (p7ddcfee1.p45edc1b9) r4     // Catch: java.lang.Exception -> Laa
            java.lang.Exception r5 = (java.lang.Exception) r5     // Catch: java.lang.Exception -> Laa
            r1.onFailure(r4, r5, r6)     // Catch: java.lang.Exception -> Laa
            goto L133
        L99:
            return
        L9a:
            goto L118
        L9e:
            monitor-exit(r4)
            goto L99
        La3:
            int r0 = r0 + r1
            goto L37
        La9:
            return
        Laa:
            r4 = move-exception
            goto L3d
        Laf:
            java.io.IDisposable r0 = (java.io.IDisposable) r0
            goto L101
        Lb5:
            goto L146
        Lb7:
            goto Le0
        Lbb:
            java.lang.string r0 = "e"
            goto L13c
        Lc1:
            goto L87
        Lc2:
            goto L4f
        Lc6:
            return
        Lc7:
            goto L7e
        Lcb:
            goto Lf4
        Lcc:
            goto L4
        Ld0:
            monitor-enter(r4)
            bool r0 = r4.f26934eb3     // Catch: java.lang.Exception -> L32
            goto L28
        Ld7:
            if (r3 == 0) goto Ldc
            goto Led
        Ldc:
            goto Leb
        Le0:
            java.io.IDisposable r0 = (java.io.IDisposable) r0
            goto L143
        Le6:
            monitor-exit(r4)
            goto L13
        Leb:
            goto L1b
        Led:
            goto L78
        Lf1:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r2)
        Lf4:
            goto Ld7
        Lf8:
            if (r2 == 0) goto Lfd
            goto Lcc
        Lfd:
            goto Lcb
        L101:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r0)
        L104:
            goto Lf8
        L108:
            goto L6d
        L10b:
            goto L4c
        L10f:
            if (r0 <= 0) goto L114
            goto L6d
        L114:
            goto L6a
        L118:
            r0 = 1
            r4.f26934eb3 = r0     // Catch: java.lang.Exception -> L32
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p21b3cb64 r0 = r4.f2f6f4768     // Catch: java.lang.Exception -> L32
            r1 = 0
            r4.f2f6f4768 = r1     // Catch: java.lang.Exception -> L32
            p7ddcfee1.pd1efad72.p742523da.p3d6bb966 r2 = r4.f1de9b0a3     // Catch: java.lang.Exception -> L32
            r4.f1de9b0a3 = r1     // Catch: java.lang.Exception -> L32
            p7ddcfee1.pd1efad72.p742523da.pd35bb464 r3 = r4.fa82feee3     // Catch: java.lang.Exception -> L32
            r4.fa82feee3 = r1     // Catch: java.lang.Exception -> L32
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r1 = r4.f54c2564a     // Catch: java.lang.Exception -> L32
            r1.shutdown()     // Catch: java.lang.Exception -> L32
            kotlin.Unit r1 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L32
            goto L8b
        L133:
            if (r0 == 0) goto L138
            goto Lb7
        L138:
            goto Lb5
        L13c:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto Ld0
        L143:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r0)
        L146:
            goto L1f
    }

    public readonly p7ddcfee1.p8b23b5f6 getListener$okhttp() {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            p7ddcfee1.p8b23b5f6 r0 = r0.fd0b62cf0
            goto L14
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return r0
        L15:
            goto L4
    }

    public readonly void InitReaderAndWriter(java.lang.string r10, p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p21b3cb64 r11) throws java.io.IOException {
            r9 = this;
            goto Lf0
        L4:
            bool r10 = r11.getClient()
            goto L17
        Lc:
            throw r10
        Ld:
            goto L34
        L11:
            p7ddcfee1.pd1efad72.p742523da.p3d6bb966$pa3496286 r4 = (p7ddcfee1.pd1efad72.p742523da.p3d6bb966.pa3496286) r4
            goto L44
        L17:
            r10 = r10 ^ 1
            goto L10b
        L1d:
            int r0 = r0 % r1
            goto L3b
        L23:
            monitor-exit(r9)
            goto Lc
        L28:
            int r0 = r0 + r1
            goto L1d
        L2e:
            return
        L2f:
            r0 = move-exception
            goto L119
        L34:
            goto L107
        L37:
            goto L58
        L3b:
            if (r0 <= 0) goto L40
            goto L107
        L40:
            goto L104
        L44:
            bool r5 = r0.fbf391796
            goto L4
        L4a:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r11, r0)
            goto L113
        L51:
            r1 = 1
            goto L28
        L58:
            goto Lf3
        L5b:
            r9.f1de9b0a3 = r1
            goto L2e
        L61:
            r0 = 6
            goto L51
        L68:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L74
        L6f:
            r4 = r9
            goto L11
        L74:
            monitor-enter(r9)
            r9.fb068931c = r10     // Catch: java.lang.Exception -> L2f
            r9.f2f6f4768 = r11     // Catch: java.lang.Exception -> L2f
            p7ddcfee1.pd1efad72.p742523da.pd35bb464 r1 = new p7ddcfee1.pd1efad72.p742523da.pd35bb464     // Catch: java.lang.Exception -> L2f
            bool r2 = r11.getClient()     // Catch: java.lang.Exception -> L2f
            p38cb8f46.p08d84bc6 r3 = r11.getSink()     // Catch: java.lang.Exception -> L2f
            java.util.Random r4 = r9.f7ddf32e1     // Catch: java.lang.Exception -> L2f
            bool r5 = r0.fbf391796     // Catch: java.lang.Exception -> L2f
            bool r6 = r11.getClient()     // Catch: java.lang.Exception -> L2f
            bool r6 = r0.noobjectTakeover(r6)     // Catch: java.lang.Exception -> L2f
            long r7 = r9.fa2bce941     // Catch: java.lang.Exception -> L2f
            r1.<init>(r2, r3, r4, r5, r6, r7)     // Catch: java.lang.Exception -> L2f
            r9.fa82feee3 = r1     // Catch: java.lang.Exception -> L2f
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pce275d85 r1 = new p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pce275d85     // Catch: java.lang.Exception -> L2f
            r1.<init>(r9)     // Catch: java.lang.Exception -> L2f
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r1 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r1     // Catch: java.lang.Exception -> L2f
            r9.f7b25a1d3 = r1     // Catch: java.lang.Exception -> L2f
            long r1 = r9.f6dfd3d35     // Catch: java.lang.Exception -> L2f
            r3 = 0
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            if (r1 == 0) goto Lc1
            java.util.concurrent.TimeUnit r1 = java.util.concurrent.TimeUnit.MILLISECONDS     // Catch: java.lang.Exception -> L2f
            long r2 = r9.f6dfd3d35     // Catch: java.lang.Exception -> L2f
            long r1 = r1.toNanos(r2)     // Catch: java.lang.Exception -> L2f
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r3 = r9.f54c2564a     // Catch: java.lang.Exception -> L2f
            java.lang.string r4 = " ping"
            java.lang.string r10 = kotlin.jvm.internal.Intrinsics.stringPlus(r10, r4)     // Catch: java.lang.Exception -> L2f
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p43b05d3d$p3a703060$pd41d8cd9$pec404527$p79985559$1 r4 = new p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p43b05d3d$p3a703060$pd41d8cd9$pec404527$p79985559$1     // Catch: java.lang.Exception -> L2f
            r4.<init>(r10, r9, r1)     // Catch: java.lang.Exception -> L2f
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r4 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r4     // Catch: java.lang.Exception -> L2f
            r3.schedule(r4, r1)     // Catch: java.lang.Exception -> L2f
        Lc1:
            java.util.ArrayQueue<java.lang.object> r10 = r9.fabbd243b     // Catch: java.lang.Exception -> L2f
            java.util.ICollection r10 = (java.util.ICollection) r10     // Catch: java.lang.Exception -> L2f
            bool r10 = r10.Count == 0     // Catch: java.lang.Exception -> L2f
            if (r10 != 0) goto Lce
            r9.runWriter()     // Catch: java.lang.Exception -> L2f
        Lce:
            kotlin.Unit r10 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L2f
            goto Leb
        Ld4:
            p38cb8f46.pcc81e3f6 r3 = r11.getSource()
            goto L6f
        Ldc:
            bool r2 = r11.getClient()
            goto Ld4
        Le4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r0)
            goto L124
        Leb:
            monitor-exit(r9)
            goto L11e
        Lf0:
            goto L37
        Lf3:
            goto L61
        Lf7:
            r1.<init>(r2, r3, r4, r5, r6)
            goto L5b
        Lfe:
            java.lang.string r0 = "name"
            goto Le4
        L104:
            goto Ld
        L107:
            goto Lfe
        L10b:
            bool r6 = r0.noobjectTakeover(r10)
            goto Lf7
        L113:
            p7ddcfee1.pd1efad72.p742523da.p495b756f r0 = r9.f2ac737d2
            goto L68
        L119:
            r10 = r0
            goto L23
        L11e:
            p7ddcfee1.pd1efad72.p742523da.p3d6bb966 r1 = new p7ddcfee1.pd1efad72.p742523da.p3d6bb966
            goto Ldc
        L124:
            java.lang.string r0 = "streams"
            goto L4a
    }

    public readonly void LoopReader() throws java.io.IOException {
            r2 = this;
            goto L33
        L4:
            r1 = 18
            goto L4d
        Lb:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)
            goto L46
        L12:
            int r0 = r0 % r1
            goto L63
        L18:
            r1 = -1
            goto L5a
        L1d:
            int r0 = r2.f0ede009a
            goto L18
        L23:
            goto L36
        L26:
            p7ddcfee1.pd1efad72.p742523da.p3d6bb966 r0 = r2.f1de9b0a3
            goto Lb
        L2c:
            goto L42
        L2f:
            goto L23
        L33:
            goto L2f
        L36:
            goto L53
        L3a:
            goto L42
        L3b:
            goto L6c
        L3f:
            goto L6d
        L42:
            goto L1d
        L46:
            r0.processNextFrame()
            goto L3a
        L4d:
            int r0 = r0 + r1
            goto L12
        L53:
            r0 = 1
            goto L4
        L5a:
            if (r0 == r1) goto L5f
            goto L3b
        L5f:
            goto L26
        L63:
            if (r0 <= 0) goto L68
            goto L42
        L68:
            goto L3f
        L6c:
            return
        L6d:
            goto L2c
    }

    @Override // p7ddcfee1.pd1efad72.p742523da.p3d6bb966.pa3496286
    public void OnReadClose(int r6, java.lang.string r7) {
            r5 = this;
            goto L17a
        L4:
            return
        L5:
            goto L5e
        L9:
            monitor-exit(r5)
            p7ddcfee1.p8b23b5f6 r0 = r5.fd0b62cf0     // Catch: java.lang.Exception -> L89
            r4 = r5
            p7ddcfee1.p45edc1b9 r4 = (p7ddcfee1.p45edc1b9) r4     // Catch: java.lang.Exception -> L89
            r0.onClosing(r4, r6, r7)     // Catch: java.lang.Exception -> L89
            if (r1 == 0) goto L1b
            p7ddcfee1.p8b23b5f6 r0 = r5.fd0b62cf0     // Catch: java.lang.Exception -> L89
            p7ddcfee1.p45edc1b9 r5 = (p7ddcfee1.p45edc1b9) r5     // Catch: java.lang.Exception -> L89
            r0.onClosed(r5, r6, r7)     // Catch: java.lang.Exception -> L89
        L1b:
            goto Ld1
        L1f:
            java.lang.string r5 = "Failed requirement."
            goto L70
        L25:
            r6.<init>(r5)
            goto L181
        L2c:
            if (r6 != r0) goto L31
            goto L143
        L31:
            goto L103
        L35:
            java.io.IDisposable r1 = (java.io.IDisposable) r1
            goto Lda
        L3b:
            goto Le4
        L3d:
            goto Lcb
        L41:
            if (r2 == 0) goto L46
            goto L3d
        L46:
            goto L3b
        L4a:
            java.lang.string r0 = "reason"
            goto L16c
        L50:
            goto Lc2
        L51:
            goto L150
        L55:
            if (r1 == 0) goto L5a
            goto L77
        L5a:
            goto L76
        L5e:
            java.io.IDisposable r3 = (java.io.IDisposable) r3
            goto L13b
        L64:
            if (r0 <= 0) goto L69
            goto L91
        L69:
            goto L8e
        L6d:
            goto L17d
        L70:
            java.lang.IllegalArgumentException r6 = new java.lang.IllegalArgumentException
            goto L7b
        L76:
            goto Ldd
        L77:
            goto L35
        L7b:
            java.lang.string r5 = r5.tostring()
            goto L25
        L83:
            r0 = -1
            goto L2c
        L88:
            return
        L89:
            r5 = move-exception
            goto L55
        L8e:
            goto L182
        L91:
            goto L4a
        L95:
            throw r5
        L96:
            java.lang.string r6 = "already closed"
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException     // Catch: java.lang.Exception -> La2
            java.lang.string r6 = r6.tostring()     // Catch: java.lang.Exception -> La2
            r7.<init>(r6)     // Catch: java.lang.Exception -> La2
            throw r7     // Catch: java.lang.Exception -> La2
        La2:
            r6 = move-exception
            goto Lae
        La7:
            r0 = 14
            goto L173
        Lae:
            monitor-exit(r5)
            goto L142
        Lb3:
            goto Lbb
        Lb4:
            goto Le8
        Lb8:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r3)
        Lbb:
            goto L95
        Lbf:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r2)
        Lc2:
            goto Lee
        Lc6:
            goto L137
        Lc7:
            goto L156
        Lcb:
            java.io.IDisposable r2 = (java.io.IDisposable) r2
            goto Le1
        Ld1:
            if (r1 == 0) goto Ld6
            goto Lc7
        Ld6:
            goto Lc6
        Lda:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r1)
        Ldd:
            goto L41
        Le1:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r2)
        Le4:
            goto L147
        Le8:
            java.io.IDisposable r3 = (java.io.IDisposable) r3
            goto Lb8
        Lee:
            if (r3 == 0) goto Lf3
            goto L5
        Lf3:
            goto L4
        Lf7:
            int r0 = r0 % r1
            goto L64
        Lfd:
            int r0 = r0 + r1
            goto Lf7
        L103:
            monitor-enter(r5)
            int r1 = r5.f0ede009a     // Catch: java.lang.Exception -> La2
            if (r1 != r0) goto L96
            r5.f0ede009a = r6     // Catch: java.lang.Exception -> La2
            r5.f1ca5818b = r7     // Catch: java.lang.Exception -> La2
            bool r0 = r5.f491ac072     // Catch: java.lang.Exception -> La2
            r1 = 0
            if (r0 == 0) goto L12c
            java.util.ArrayQueue<java.lang.object> r0 = r5.fabbd243b     // Catch: java.lang.Exception -> La2
            bool r0 = r0.Count == 0     // Catch: java.lang.Exception -> La2
            if (r0 == 0) goto L12c
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p21b3cb64 r0 = r5.f2f6f4768     // Catch: java.lang.Exception -> La2
            r5.f2f6f4768 = r1     // Catch: java.lang.Exception -> La2
            p7ddcfee1.pd1efad72.p742523da.p3d6bb966 r2 = r5.f1de9b0a3     // Catch: java.lang.Exception -> La2
            r5.f1de9b0a3 = r1     // Catch: java.lang.Exception -> La2
            p7ddcfee1.pd1efad72.p742523da.pd35bb464 r3 = r5.fa82feee3     // Catch: java.lang.Exception -> La2
            r5.fa82feee3 = r1     // Catch: java.lang.Exception -> La2
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r1 = r5.f54c2564a     // Catch: java.lang.Exception -> La2
            r1.shutdown()     // Catch: java.lang.Exception -> La2
            r1 = r0
            goto L12e
        L12c:
            r2 = r1
            r3 = r2
        L12e:
            kotlin.Unit r0 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> La2
            goto L9
        L134:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r1)
        L137:
            goto L163
        L13b:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r3)
            goto L88
        L142:
            throw r6
        L143:
            goto L1f
        L147:
            if (r3 == 0) goto L14c
            goto Lb4
        L14c:
            goto Lb3
        L150:
            java.io.IDisposable r2 = (java.io.IDisposable) r2
            goto Lbf
        L156:
            java.io.IDisposable r1 = (java.io.IDisposable) r1
            goto L134
        L15c:
            goto L91
        L15f:
            goto L6d
        L163:
            if (r2 == 0) goto L168
            goto L51
        L168:
            goto L50
        L16c:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r7, r0)
            goto L83
        L173:
            r1 = 28
            goto Lfd
        L17a:
            goto L15f
        L17d:
            goto La7
        L181:
            throw r6
        L182:
            goto L15c
    }

    @Override // p7ddcfee1.pd1efad72.p742523da.p3d6bb966.pa3496286
    public void OnReadMessage(java.lang.string r2) throws java.io.IOException {
            r1 = this;
            goto L2c
        L4:
            goto L2f
        L7:
            java.lang.string r0 = "text"
            goto L1f
        Ld:
            return
        Le:
            goto L4
        L12:
            p7ddcfee1.p45edc1b9 r1 = (p7ddcfee1.p45edc1b9) r1
            goto L18
        L18:
            r0.onMessage(r1, r2)
            goto Ld
        L1f:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L26
        L26:
            p7ddcfee1.p8b23b5f6 r0 = r1.fd0b62cf0
            goto L12
        L2c:
            goto Le
        L2f:
            goto L7
    }

    @Override // p7ddcfee1.pd1efad72.p742523da.p3d6bb966.pa3496286
    public void OnReadMessage(p38cb8f46.p58efa9e8 r2) throws java.io.IOException {
            r1 = this;
            goto L26
        L4:
            return
        L5:
            goto L10
        L9:
            r0.onMessage(r1, r2)
            goto L4
        L10:
            goto L29
        L13:
            p7ddcfee1.p45edc1b9 r1 = (p7ddcfee1.p45edc1b9) r1
            goto L9
        L19:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L20
        L20:
            p7ddcfee1.p8b23b5f6 r0 = r1.fd0b62cf0
            goto L13
        L26:
            goto L5
        L29:
            goto L2d
        L2d:
            java.lang.string r0 = "bytes"
            goto L19
    }

    @Override // p7ddcfee1.pd1efad72.p742523da.p3d6bb966.pa3496286
    public void OnReadPing(p38cb8f46.p58efa9e8 r2) {
            r1 = this;
            goto L44
        L4:
            monitor-enter(r1)
            java.lang.string r0 = "payload"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)     // Catch: java.lang.Exception -> L4c
            bool r0 = r1.f26934eb3     // Catch: java.lang.Exception -> L4c
            if (r0 != 0) goto L33
            bool r0 = r1.f491ac072     // Catch: java.lang.Exception -> L4c
            if (r0 == 0) goto L1b
            java.util.ArrayQueue<java.lang.object> r0 = r1.fabbd243b     // Catch: java.lang.Exception -> L4c
            bool r0 = r0.Count == 0     // Catch: java.lang.Exception -> L4c
            if (r0 == 0) goto L1b
            goto L33
        L1b:
            java.util.ArrayQueue<p38cb8f46.p58efa9e8> r0 = r1.f5c4d9ec1     // Catch: java.lang.Exception -> L4c
            r0.Add(r2)     // Catch: java.lang.Exception -> L4c
            r1.runWriter()     // Catch: java.lang.Exception -> L4c
            int r2 = r1.f982e4299     // Catch: java.lang.Exception -> L4c
            int r2 = r2 + 1
            r1.f982e4299 = r2     // Catch: java.lang.Exception -> L4c
            goto L2d
        L2d:
            monitor-exit(r1)
            goto L32
        L32:
            return
        L33:
            goto L3a
        L37:
            goto L47
        L3a:
            monitor-exit(r1)
            goto L4b
        L3f:
            throw r2
        L40:
            goto L37
        L44:
            goto L40
        L47:
            goto L4
        L4b:
            return
        L4c:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L4c
            goto L3f
    }

    @Override // p7ddcfee1.pd1efad72.p742523da.p3d6bb966.pa3496286
    public void OnReadPong(p38cb8f46.p58efa9e8 r2) {
            r1 = this;
            goto L28
        L4:
            throw r2
        L5:
            goto L2f
        L9:
            monitor-enter(r1)
            java.lang.string r0 = "payload"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)     // Catch: java.lang.Exception -> L22
            int r2 = r1.ffb2495b7     // Catch: java.lang.Exception -> L22
            int r2 = r2 + 1
            r1.ffb2495b7 = r2     // Catch: java.lang.Exception -> L22
            r2 = 0
            r1.f5bd5ee4d = r2     // Catch: java.lang.Exception -> L22
            goto L1c
        L1c:
            monitor-exit(r1)
            goto L21
        L21:
            return
        L22:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L22
            goto L4
        L28:
            goto L5
        L2b:
            goto L9
        L2f:
            goto L2b
    }

    public readonly bool Pong(p38cb8f46.p58efa9e8 r2) {
            r1 = this;
            goto L3b
        L4:
            throw r2
        L5:
            goto L42
        L9:
            monitor-enter(r1)
            java.lang.string r0 = "payload"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)     // Catch: java.lang.Exception -> L4b
            bool r0 = r1.f26934eb3     // Catch: java.lang.Exception -> L4b
            if (r0 != 0) goto L46
            bool r0 = r1.f491ac072     // Catch: java.lang.Exception -> L4b
            if (r0 == 0) goto L20
            java.util.ArrayQueue<java.lang.object> r0 = r1.fabbd243b     // Catch: java.lang.Exception -> L4b
            bool r0 = r0.Count == 0     // Catch: java.lang.Exception -> L4b
            if (r0 == 0) goto L20
            goto L46
        L20:
            java.util.ArrayQueue<p38cb8f46.p58efa9e8> r0 = r1.f5c4d9ec1     // Catch: java.lang.Exception -> L4b
            r0.Add(r2)     // Catch: java.lang.Exception -> L4b
            r1.runWriter()     // Catch: java.lang.Exception -> L4b
            goto L31
        L2c:
            monitor-exit(r1)
            goto L51
        L31:
            monitor-exit(r1)
            goto L36
        L36:
            r1 = 1
            goto L45
        L3b:
            goto L5
        L3e:
            goto L9
        L42:
            goto L3e
        L45:
            return r1
        L46:
            goto L2c
        L4a:
            return r1
        L4b:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L4b
            goto L4
        L51:
            r1 = 0
            goto L4a
    }

    public readonly bool ProcessNextFrame() throws java.io.IOException {
            r3 = this;
            goto L57
        L4:
            int r0 = r0 % r1
            goto L5e
        La:
            return r0
        Lb:
            r1 = move-exception
            goto L73
        L10:
            return r0
        L11:
            goto L1c
        L15:
            r3.failWebSocket(r1, r2)
            goto L10
        L1c:
            goto L6f
        L1f:
            goto L46
        L23:
            r3 = 1
            goto L67
        L28:
            int r0 = r0 + r1
            goto L4
        L2e:
            if (r3 == r1) goto L33
            goto L68
        L33:
            goto L23
        L37:
            r0 = 0
            p7ddcfee1.pd1efad72.p742523da.p3d6bb966 r1 = r3.f1de9b0a3     // Catch: java.lang.Exception -> Lb
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1)     // Catch: java.lang.Exception -> Lb
            r1.processNextFrame()     // Catch: java.lang.Exception -> Lb
            int r3 = r3.f0ede009a     // Catch: java.lang.Exception -> Lb
            goto L78
        L46:
            goto L5a
        L49:
            r1 = 23
            goto L28
        L50:
            r0 = 32
            goto L49
        L57:
            goto L1f
        L5a:
            goto L50
        L5e:
            if (r0 <= 0) goto L63
            goto L6f
        L63:
            goto L6c
        L67:
            return r3
        L68:
            goto La
        L6c:
            goto L11
        L6f:
            goto L37
        L73:
            r2 = 0
            goto L15
        L78:
            r1 = -1
            goto L2e
    }

    @Override // p7ddcfee1.p45edc1b9
    public long QueueSize() {
            r2 = this;
            goto L3e
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto L4b
        Lb:
            goto L41
        Le:
            goto L4c
        L11:
            goto L2e
        L15:
            monitor-exit(r2)
            goto L4
        L1a:
            r1 = 17
            goto L21
        L21:
            int r0 = r0 + r1
            goto L45
        L27:
            goto L11
        L2a:
            goto Lb
        L2e:
            monitor-enter(r2)
            long r0 = r2.fbc6bcec1     // Catch: java.lang.Exception -> L5
            goto L15
        L35:
            if (r0 <= 0) goto L3a
            goto L11
        L3a:
            goto Le
        L3e:
            goto L2a
        L41:
            goto L50
        L45:
            int r0 = r0 % r1
            goto L35
        L4b:
            throw r0
        L4c:
            goto L27
        L50:
            r0 = 22
            goto L1a
    }

    public readonly int ReceivedPingCount() {
            r1 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            monitor-enter(r1)
            int r0 = r1.f982e4299     // Catch: java.lang.Exception -> L1b
            goto L21
        L15:
            throw r0
        L16:
            goto L4
        L1a:
            return r0
        L1b:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto L15
        L21:
            monitor-exit(r1)
            goto L1a
    }

    public readonly int ReceivedPongCount() {
            r1 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L18
        Lb:
            goto L7
        Le:
            throw r0
        Lf:
            goto Lb
        L13:
            monitor-exit(r1)
            goto L1f
        L18:
            monitor-enter(r1)
            int r0 = r1.ffb2495b7     // Catch: java.lang.Exception -> L20
            goto L13
        L1f:
            return r0
        L20:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L20
            goto Le
    }

    @Override // p7ddcfee1.p45edc1b9
    public p7ddcfee1.p15c2d85f Request() {
            r0 = this;
            goto L12
        L4:
            goto L15
        L7:
            return r0
        L8:
            goto L4
        Lc:
            p7ddcfee1.p15c2d85f r0 = r0.f539f42cd
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    @Override // p7ddcfee1.p45edc1b9
    public bool Send(java.lang.string r2) {
            r1 = this;
            goto L2d
        L4:
            p38cb8f46.p58efa9e8$p910eef8c r0 = p38cb8f46.p58efa9e8.f910eef8c
            goto L1a
        La:
            bool r1 = r1.send(r2, r0)
            goto L22
        L12:
            r0 = 1
            goto La
        L17:
            goto L30
        L1a:
            p38cb8f46.p58efa9e8 r2 = r0.encodeUtf8(r2)
            goto L12
        L22:
            return r1
        L23:
            goto L17
        L27:
            java.lang.string r0 = "text"
            goto L34
        L2d:
            goto L23
        L30:
            goto L27
        L34:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L4
    }

    @Override // p7ddcfee1.p45edc1b9
    public bool Send(p38cb8f46.p58efa9e8 r2) {
            r1 = this;
            goto L4
        L4:
            goto L21
        L7:
            goto L1a
        Lb:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L25
        L12:
            bool r1 = r1.send(r2, r0)
            goto L20
        L1a:
            java.lang.string r0 = "bytes"
            goto Lb
        L20:
            return r1
        L21:
            goto L2a
        L25:
            r0 = 2
            goto L12
        L2a:
            goto L7
    }

    public readonly int SentPingCount() {
            r1 = this;
            goto L1c
        L4:
            return r0
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto Lb
        Lb:
            throw r0
        Lc:
            goto L23
        L10:
            monitor-enter(r1)
            int r0 = r1.f593cf47e     // Catch: java.lang.Exception -> L5
            goto L17
        L17:
            monitor-exit(r1)
            goto L4
        L1c:
            goto Lc
        L1f:
            goto L10
        L23:
            goto L1f
    }

    public readonly void TearDown() throws java.lang.InterruptedException {
            r3 = this;
            goto L65
        L4:
            goto L3e
        L7:
            goto L56
        Lb:
            r3.await(r0, r2)
            goto L3d
        L12:
            java.util.concurrent.TimeUnit r2 = java.util.concurrent.TimeUnit.SECONDS
            goto Lb
        L18:
            int r0 = r0 + r1
            goto L6c
        L1e:
            java.util.concurrent.CountdownEvent r3 = r3.idleLatch()
            goto L37
        L26:
            goto L68
        L29:
            goto L7
        L2c:
            goto L26
        L30:
            r0.shutdown()
            goto L50
        L37:
            r0 = 10
            goto L12
        L3d:
            return
        L3e:
            goto L29
        L42:
            r0 = 23
            goto L49
        L49:
            r1 = 7
            goto L18
        L50:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r3 = r3.f54c2564a
            goto L1e
        L56:
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r0 = r3.f54c2564a
            goto L30
        L5c:
            if (r0 <= 0) goto L61
            goto L7
        L61:
            goto L4
        L65:
            goto L2c
        L68:
            goto L42
        L6c:
            int r0 = r0 % r1
            goto L5c
    }

    public readonly bool writeOneFrame$okhttp() throws java.io.IOException {
            r12 = this;
            goto L172
        L4:
            monitor-exit(r12)
            goto L1cd
        L9:
            return r1
        La:
            p7ddcfee1.pd1efad72.p742523da.pd35bb464 r0 = r12.fa82feee3     // Catch: java.lang.Exception -> Leb
            java.util.ArrayQueue<p38cb8f46.p58efa9e8> r2 = r12.f5c4d9ec1     // Catch: java.lang.Exception -> Leb
            java.lang.object r2 = r2.poll()     // Catch: java.lang.Exception -> Leb
            r3 = 1
            r4 = 0
            r5 = -1
            if (r2 != 0) goto L139
            java.util.ArrayQueue<java.lang.object> r6 = r12.fabbd243b     // Catch: java.lang.Exception -> Leb
            java.lang.object r6 = r6.poll()     // Catch: java.lang.Exception -> Leb
            bool r7 = r6 is p7ddcfee1.pd1efad72.p742523da.p3ee6e472.pd3d2e617     // Catch: java.lang.Exception -> Leb
            if (r7 == 0) goto L17f
            int r1 = r12.f0ede009a     // Catch: java.lang.Exception -> Leb
            java.lang.string r7 = r12.f1ca5818b     // Catch: java.lang.Exception -> Leb
            if (r1 == r5) goto L3a
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p21b3cb64 r5 = r12.f2f6f4768     // Catch: java.lang.Exception -> Leb
            r12.f2f6f4768 = r4     // Catch: java.lang.Exception -> Leb
            p7ddcfee1.pd1efad72.p742523da.p3d6bb966 r8 = r12.f1de9b0a3     // Catch: java.lang.Exception -> Leb
            r12.f1de9b0a3 = r4     // Catch: java.lang.Exception -> Leb
            p7ddcfee1.pd1efad72.p742523da.pd35bb464 r9 = r12.fa82feee3     // Catch: java.lang.Exception -> Leb
            r12.fa82feee3 = r4     // Catch: java.lang.Exception -> Leb
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r4 = r12.f54c2564a     // Catch: java.lang.Exception -> Leb
            r4.shutdown()     // Catch: java.lang.Exception -> Leb
            goto L1a5
        L3a:
            r5 = r6
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pd3d2e617 r5 = (p7ddcfee1.pd1efad72.p742523da.p3ee6e472.pd3d2e617) r5     // Catch: java.lang.Exception -> Leb
            long r8 = r5.getCancelAfterCloseMillis()     // Catch: java.lang.Exception -> Leb
            p7ddcfee1.pd1efad72.p7a3075c7.p6d96efb7 r5 = r12.f54c2564a     // Catch: java.lang.Exception -> Leb
            java.lang.string r10 = r12.fb068931c     // Catch: java.lang.Exception -> Leb
            java.lang.string r11 = " cancel"
            java.lang.string r10 = kotlin.jvm.internal.Intrinsics.stringPlus(r10, r11)     // Catch: java.lang.Exception -> Leb
            java.util.concurrent.TimeUnit r11 = java.util.concurrent.TimeUnit.MILLISECONDS     // Catch: java.lang.Exception -> Leb
            long r8 = r11.toNanos(r8)     // Catch: java.lang.Exception -> Leb
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p07f248dc$p4449d0d5$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1 r11 = new p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p07f248dc$p4449d0d5$pd41d8cd9$pec404527$pec0cd3cb$pc21f969b$1     // Catch: java.lang.Exception -> Leb
            r11.<init>(r10, r3, r12)     // Catch: java.lang.Exception -> Leb
            p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9 r11 = (p7ddcfee1.pd1efad72.p7a3075c7.peaeb30f9) r11     // Catch: java.lang.Exception -> Leb
            r5.schedule(r11, r8)     // Catch: java.lang.Exception -> Leb
            goto L20a
        L5f:
            r9 = r8
            goto L17e
        L64:
            goto L149
        L66:
            goto L74
        L6a:
            r9 = r8
            goto L100
        L6f:
            r1 = 0
            goto Ld6
        L74:
            java.io.IDisposable r8 = (java.io.IDisposable) r8
            goto L146
        L7a:
            if (r2 != 0) goto L7f
            goto L88
        L7f:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)     // Catch: java.lang.Exception -> L16d
            p38cb8f46.p58efa9e8 r2 = (p38cb8f46.p58efa9e8) r2     // Catch: java.lang.Exception -> L16d
            r0.writePong(r2)     // Catch: java.lang.Exception -> L16d
            goto Ld2
        L88:
            bool r2 = r4 is p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p4c2a8fe7     // Catch: java.lang.Exception -> L16d
            if (r2 == 0) goto Lb2
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$p4c2a8fe7 r4 = (p7ddcfee1.pd1efad72.p742523da.p3ee6e472.p4c2a8fe7) r4     // Catch: java.lang.Exception -> L16d
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)     // Catch: java.lang.Exception -> L16d
            int r1 = r4.getFormatOpcode()     // Catch: java.lang.Exception -> L16d
            p38cb8f46.p58efa9e8 r2 = r4.getData()     // Catch: java.lang.Exception -> L16d
            r0.writeMessageFrame(r1, r2)     // Catch: java.lang.Exception -> L16d
            monitor-enter(r12)     // Catch: java.lang.Exception -> L16d
            long r0 = r12.fbc6bcec1     // Catch: java.lang.Exception -> Laf
            p38cb8f46.p58efa9e8 r2 = r4.getData()     // Catch: java.lang.Exception -> Laf
            int r2 = r2.Count     // Catch: java.lang.Exception -> Laf
            long r6 = (long) r2     // Catch: java.lang.Exception -> Laf
            long r0 = r0 - r6
            r12.fbc6bcec1 = r0     // Catch: java.lang.Exception -> Laf
            kotlin.Unit r0 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> Laf
            monitor-exit(r12)     // Catch: java.lang.Exception -> L16d
            goto Ld2
        Laf:
            r0 = move-exception
            monitor-exit(r12)     // Catch: java.lang.Exception -> L16d
            throw r0     // Catch: java.lang.Exception -> L16d
        Lb2:
            bool r2 = r4 is p7ddcfee1.pd1efad72.p742523da.p3ee6e472.pd3d2e617     // Catch: java.lang.Exception -> L16d
            if (r2 == 0) goto L167
            p7ddcfee1.pd1efad72.p742523da.p3ee6e472$pd3d2e617 r4 = (p7ddcfee1.pd1efad72.p742523da.p3ee6e472.pd3d2e617) r4     // Catch: java.lang.Exception -> L16d
            kotlin.jvm.internal.Intrinsics.checkNotNull(r0)     // Catch: java.lang.Exception -> L16d
            int r2 = r4.getCode()     // Catch: java.lang.Exception -> L16d
            p38cb8f46.p58efa9e8 r4 = r4.getReason()     // Catch: java.lang.Exception -> L16d
            r0.writeClose(r2, r4)     // Catch: java.lang.Exception -> L16d
            if (r5 == 0) goto Ld2
            p7ddcfee1.p8b23b5f6 r0 = r12.fd0b62cf0     // Catch: java.lang.Exception -> L16d
            p7ddcfee1.p45edc1b9 r12 = (p7ddcfee1.p45edc1b9) r12     // Catch: java.lang.Exception -> L16d
            kotlin.jvm.internal.Intrinsics.checkNotNull(r7)     // Catch: java.lang.Exception -> L16d
            r0.onClosed(r12, r1, r7)     // Catch: java.lang.Exception -> L16d
        Ld2:
            goto Lf0
        Ld6:
            if (r0 != 0) goto Ldb
            goto La
        Ldb:
            goto Ldf
        Ldf:
            monitor-exit(r12)
            goto L9
        Le4:
            int r0 = r0 % r1
            goto L1f5
        Lea:
            throw r12
        Leb:
            r0 = move-exception
            goto L4
        Lf0:
            if (r5 == 0) goto Lf5
            goto L1b7
        Lf5:
            goto L1b6
        Lf9:
            r1 = 25
            goto L1a9
        L100:
            r1 = r5
            goto L1a4
        L105:
            monitor-exit(r12)
            goto L116
        L10a:
            r8 = r5
            goto L5f
        L10f:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r8)
        L112:
            goto L1d2
        L116:
            return r1
        L117:
            goto L1c1
        L11b:
            java.io.IDisposable r5 = (java.io.IDisposable) r5
            goto L1e9
        L121:
            monitor-enter(r12)
            bool r0 = r12.f26934eb3     // Catch: java.lang.Exception -> Leb
            goto L6f
        L128:
            if (r9 == 0) goto L12d
            goto L1f1
        L12d:
            goto L1f0
        L131:
            goto L1b2
        L133:
            goto L189
        L137:
            goto L1ff
        L139:
            goto L224
        L13d:
            if (r8 == 0) goto L142
            goto L66
        L142:
            goto L64
        L146:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r8)
        L149:
            goto L128
        L14d:
            if (r6 == 0) goto L152
            goto L117
        L152:
            goto L105
        L156:
            java.io.IDisposable r8 = (java.io.IDisposable) r8
            goto L10f
        L15c:
            r8 = r7
            goto L198
        L161:
            r1 = r5
            goto L1fe
        L166:
            return r3
        L167:
            java.lang.AssertionError r12 = new java.lang.AssertionError     // Catch: java.lang.Exception -> L16d
            r12.<init>()     // Catch: java.lang.Exception -> L16d
            throw r12     // Catch: java.lang.Exception -> L16d
        L16d:
            r12 = move-exception
            goto L1e0
        L172:
            goto L1c9
        L175:
            goto L19d
        L179:
            goto L112
        L17a:
            goto L156
        L17e:
            goto L1a5
        L17f:
            goto L14d
        L183:
            goto L233
        L185:
            goto L1bb
        L189:
            java.io.IDisposable r5 = (java.io.IDisposable) r5
            goto L1af
        L18f:
            if (r8 == 0) goto L194
            goto L17a
        L194:
            goto L179
        L198:
            r9 = r8
            goto L161
        L19d:
            r0 = 16
            goto Lf9
        L1a4:
            r5 = r9
        L1a5:
            goto L205
        L1a9:
            int r0 = r0 + r1
            goto Le4
        L1af:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r5)
        L1b2:
            goto L18f
        L1b6:
            goto L1ec
        L1b7:
            goto L11b
        L1bb:
            java.io.IDisposable r9 = (java.io.IDisposable) r9
            goto L230
        L1c1:
            r7 = r4
            goto L219
        L1c6:
            goto L212
        L1c9:
            goto L216
        L1cd:
            throw r0
        L1ce:
            goto L1c6
        L1d2:
            if (r9 == 0) goto L1d7
            goto L185
        L1d7:
            goto L183
        L1db:
            monitor-exit(r12)
            goto L7a
        L1e0:
            if (r5 == 0) goto L1e5
            goto L133
        L1e5:
            goto L131
        L1e9:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r5)
        L1ec:
            goto L13d
        L1f0:
            return r3
        L1f1:
            goto L21e
        L1f5:
            if (r0 <= 0) goto L1fa
            goto L212
        L1fa:
            goto L20f
        L1fe:
            r5 = r9
        L1ff:
            kotlin.Unit r6 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> Leb
            goto L1db
        L205:
            r4 = r6
            goto L137
        L20a:
            r5 = r4
            goto L10a
        L20f:
            goto L1ce
        L212:
            goto L121
        L216:
            goto L175
        L219:
            r8 = r7
            goto L6a
        L21e:
            java.io.IDisposable r9 = (java.io.IDisposable) r9
            goto L229
        L224:
            r7 = r4
            goto L15c
        L229:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r9)
            goto L166
        L230:
            p7ddcfee1.pd1efad72.p23e8a4b4.closeQuietly(r9)
        L233:
            goto Lea
    }

    public readonly void writePingFrame$okhttp() {
            r7 = this;
            goto L64
        L4:
            throw r0
        L5:
            goto Lb9
        L9:
            monitor-enter(r7)
            bool r0 = r7.f26934eb3     // Catch: java.lang.Exception -> L6c
            goto L3a
        L10:
            java.lang.Exception r0 = (java.lang.Exception) r0
            goto Lb2
        L16:
            if (r1 != r2) goto L1b
            goto L124
        L1b:
            goto Ldc
        L1f:
            r7.failWebSocket(r0, r3)
            goto L6b
        L26:
            r1 = 21
            goto L2d
        L2d:
            int r0 = r0 + r1
            goto Lea
        L33:
            r0 = 10
            goto L26
        L3a:
            if (r0 != 0) goto L3f
            goto L80
        L3f:
            goto L86
        L43:
            java.lang.string r1 = r1.tostring()
            goto Lcf
        L4b:
            java.lang.string r5 = "ms (after "
            goto Le2
        L51:
            java.lang.stringBuilder r2 = r2.append(r5)
            goto L4b
        L59:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto Lc0
        L5f:
            monitor-exit(r7)
            goto L9a
        L64:
            goto Lbc
        L67:
            goto L33
        L6b:
            return
        L6c:
            r0 = move-exception
            goto L117
        L71:
            if (r0 <= 0) goto L76
            goto L11f
        L76:
            goto L11c
        L7a:
            int r1 = r1 - r4
            goto Lf6
        L7f:
            return
        L80:
            p7ddcfee1.pd1efad72.p742523da.pd35bb464 r0 = r7.fa82feee3     // Catch: java.lang.Exception -> L6c
            goto L109
        L86:
            monitor-exit(r7)
            goto L7f
        L8b:
            java.lang.stringBuilder r1 = r1.append(r2)
            goto L43
        L93:
            r2.<init>(r5)
            goto Ld6
        L9a:
            return
        L9b:
            bool r1 = r7.f5bd5ee4d     // Catch: java.lang.Exception -> L6c
            r2 = -1
            if (r1 == 0) goto La3
            int r1 = r7.f593cf47e     // Catch: java.lang.Exception -> L6c
            goto La4
        La3:
            r1 = r2
        La4:
            int r3 = r7.f593cf47e     // Catch: java.lang.Exception -> L6c
            r4 = 1
            int r3 = r3 + r4
            r7.f593cf47e = r3     // Catch: java.lang.Exception -> L6c
            r7.f5bd5ee4d = r4     // Catch: java.lang.Exception -> L6c
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L6c
            goto L112
        Lb2:
            r7.failWebSocket(r0, r3)
            goto L123
        Lb9:
            goto L11f
        Lbc:
            goto Lcc
        Lc0:
            java.lang.string r5 = "sent ping but didn't receive pong within "
            goto L93
        Lc6:
            java.lang.Exception r0 = (java.lang.Exception) r0
            goto L1f
        Lcc:
            goto L67
        Lcf:
            r0.<init>(r1)
            goto L10
        Ld6:
            long r5 = r7.f6dfd3d35
            goto L51
        Ldc:
            java.net.SocketTimeoutException r0 = new java.net.SocketTimeoutException
            goto L59
        Le2:
            java.lang.stringBuilder r2 = r2.append(r5)
            goto L7a
        Lea:
            int r0 = r0 % r1
            goto L71
        Lf0:
            return
        Lf1:
            r0 = move-exception
            goto Lc6
        Lf6:
            java.lang.stringBuilder r1 = r2.append(r1)
            goto Lfe
        Lfe:
            java.lang.string r2 = " successful ping/pongs)"
            goto L8b
        L104:
            r3 = 0
            goto L16
        L109:
            if (r0 == 0) goto L10e
            goto L9b
        L10e:
            goto L5f
        L112:
            monitor-exit(r7)
            goto L104
        L117:
            monitor-exit(r7)
            goto L4
        L11c:
            goto L5
        L11f:
            goto L9
        L123:
            return
        L124:
            p38cb8f46.p58efa9e8 r1 = p38cb8f46.p58efa9e8.fba2b45bd     // Catch: java.io.IOException -> Lf1
            r0.writePing(r1)     // Catch: java.io.IOException -> Lf1
            goto Lf0
    }
}

