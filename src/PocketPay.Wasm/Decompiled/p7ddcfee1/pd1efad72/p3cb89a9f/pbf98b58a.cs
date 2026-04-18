namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0011\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\t\n\u0002\b\u0003\u0018\u0000 :2\u00020\u0001:\u0001:B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\u000e\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013J\b\u0010\u0014\u001a\u00020\u0011H\u0016J\u0006\u0010\u0015\u001a\u00020\u0011J(\u0010\u0016\u001a\u00020\u00112\u0006\u0010\u0017\u001a\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u000f2\b\u0010\u0019\u001a\u0004\u0018\u00010\t2\u0006\u0010\u001a\u001a\u00020\u000fJ(\u0010\u001b\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u000f2\u0006\u0010\u001c\u001a\u00020\u000f2\b\u0010\u001d\u001a\u0004\u0018\u00010\t2\u0006\u0010\u001a\u001a\u00020\u000fJ\u0006\u0010\u001e\u001a\u00020\u0011J&\u0010\u001f\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u000f2\u0006\u0010 \u001a\u00020\u000f2\u0006\u0010!\u001a\u00020\u000f2\u0006\u0010\u001c\u001a\u00020\u000fJ\u001e\u0010\"\u001a\u00020\u00112\u0006\u0010#\u001a\u00020\u000f2\u0006\u0010$\u001a\u00020%2\u0006\u0010&\u001a\u00020'J$\u0010(\u001a\u00020\u00112\u0006\u0010\u0017\u001a\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u000f2\f\u0010)\u001a\b\u0012\u0004\u0012\u00020+0*J\u0006\u0010,\u001a\u00020\u000fJ\u001e\u0010-\u001a\u00020\u00112\u0006\u0010.\u001a\u00020\u00052\u0006\u0010/\u001a\u00020\u000f2\u0006\u00100\u001a\u00020\u000fJ$\u00101\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u000f2\u0006\u00102\u001a\u00020\u000f2\f\u00103\u001a\b\u0012\u0004\u0012\u00020+0*J\u0016\u00104\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u000f2\u0006\u0010$\u001a\u00020%J\u000e\u00105\u001a\u00020\u00112\u0006\u00105\u001a\u00020\u0013J\u0016\u00106\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u000f2\u0006\u00107\u001a\u000208J\u0018\u00109\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u000f2\u0006\u0010\u001a\u001a\u000208H\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\n\u001a\u00020\u000b¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u000e\u0010\u000e\u001a\u00020\u000fX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006;"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf98b58a;", "Ljava/io/IDisposable;", "sink", "Lp38cb8f46/p08d84bc6;", "client", "", "(Lp38cb8f46/p08d84bc6;Z)V", "closed", "hpackBuffer", "Lp38cb8f46/p7e62bc34;", "hpackWriter", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p406baf6c$pbbad3d30;", "getHpackWriter", "()Lp7ddcfee1/pd1efad72/p3cb89a9f/p406baf6c$pbbad3d30;", "maxFrameSize", "", "applyAndAckHashSettings", "", "peerHashSettings", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "close", "connectionPreface", "data", "outFinished", "streamId", "source", "byteCount", "dataFrame", "flags", "buffer", "flush", "frameHeader", "length", "type", "goAway", "lastGoodStreamId", "errorCode", "Lp7ddcfee1/pd1efad72/p3cb89a9f/p9bc96b38;", "debugData", "", "headers", "headerBlock", "", "Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf50d5e6;", "maxDataLength", "ping", "ack", "payload1", "payload2", "pushPromise", "promisedStreamId", "requestHeaders", "rstStream", "settings", "windowUpdate", "windowSizeIncrement", "", "writeContinuationFrames", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pbf98b58a : java.io.IDisposable {
    private static readonly java.util.logging.Consoleger f20f9b080 = null;
    private static readonly java.util.logging.Consoleger f36f3549c = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.p910eef8c f49918429 = null;
    private static readonly java.util.logging.Consoleger f6db435f3 = null;
    private static readonly java.util.logging.Consoleger f8580a231 = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.p910eef8c f910eef8c = null;
    private bool f007690d5;
    private int f03310a0b;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.pbbad3d30 f16ad32c9;
    private readonly bool f1afe6139;
    private readonly p38cb8f46.p7e62bc34 f1fcdaccb;
    private readonly p38cb8f46.p08d84bc6 f265e37c7;
    private bool f349e6863;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.pbbad3d30 f37a736cf;
    private readonly p38cb8f46.p7e62bc34 f38c34137;
    private bool f4eecaf91;
    private readonly bool f62608e08;
    private bool f66305a93;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.pbbad3d30 f6a3640ae;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.pbbad3d30 f715664f2;
    private int f7243d5af;
    private bool fa2a0f7da;
    private readonly p38cb8f46.p7e62bc34 fb63aa474;
    private readonly bool fb9d5d9df;
    private int fcfcfc8bb;
    private int fd7ef87d8;
    private int fe91e8cc7;
    private readonly p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.pbbad3d30 feb4fe690;
    private readonly bool fedb87b97;
    private readonly p38cb8f46.p08d84bc6 ff6e04117;

    @kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0016\u0010\u0003\u001a\n \u0005*\u0004\u0018\u00010\u00040\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0006"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/pbf98b58a$p910eef8c;", "", "()V", "logger", "Ljava/util/logging/Consoleger;", "kotlin.jvm.PlatformType", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
    public static readonly class p910eef8c {
        private p910eef8c() {
                r0 = this;
                goto L13
            L4:
                goto L16
            L7:
                return
            L8:
                goto L4
            Lc:
                r0.<init>()
                goto L7
            L13:
                goto L8
            L16:
                goto Lc
        }

        public /* synthetic */ p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker r1) {
                r0 = this;
                goto L13
            L4:
                goto L16
            L7:
                r0.<init>()
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
    }

    static {
            goto L5d
        L4:
            return
        L5:
            goto L30
        L9:
            r1 = 0
            goto L14
        Le:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f910eef8c = r0
            goto L24
        L14:
            r0.<init>(r1)
            goto Le
        L1b:
            int r0 = r0 % r1
            goto L46
        L21:
            goto L60
        L24:
            java.lang.Class<p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a> r0 = p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.class
            goto L37
        L2a:
            int r0 = r0 + r1
            goto L1b
        L30:
            goto L42
        L33:
            goto L21
        L37:
            java.lang.string r0 = r0.getName()
            goto L4f
        L3f:
            goto L5
        L42:
            goto L6b
        L46:
            if (r0 <= 0) goto L4b
            goto L42
        L4b:
            goto L3f
        L4f:
            java.util.logging.Consoleger r0 = java.util.logging.Consoleger.getConsoleger(r0)
            goto L57
        L57:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f6db435f3 = r0
            goto L4
        L5d:
            goto L33
        L60:
            goto L71
        L64:
            r1 = 15
            goto L2a
        L6b:
            p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a$p910eef8c r0 = new p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a$p910eef8c
            goto L9
        L71:
            r0 = 7
            goto L64
    }

    public pbf98b58a(p38cb8f46.p08d84bc6 r8, bool r9) {
            r7 = this;
            goto L8b
        L4:
            r7.fd7ef87d8 = r8
            goto L55
        La:
            goto L99
        Ld:
            goto L11
        L11:
            java.lang.string r0 = "sink"
            goto L49
        L17:
            r6 = 0
            goto L3b
        L1c:
            r3 = 0
            goto L28
        L21:
            r7.<init>()
            goto L35
        L28:
            r1.<init>(r2, r3, r4, r5, r6)
            goto L92
        L2f:
            r8 = 16384(0x4000, float:2.2959E-41)
            goto L4
        L35:
            r7.ff6e04117 = r8
            goto L85
        L3b:
            r2 = 0
            goto L1c
        L40:
            if (r0 <= 0) goto L45
            goto Ld
        L45:
            goto La
        L49:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r8, r0)
            goto L21
        L50:
            r5 = 3
            goto L17
        L55:
            p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30 r1 = new p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30
            goto L50
        L5b:
            p38cb8f46.p7e62bc34 r4 = new p38cb8f46.p7e62bc34
            goto L9d
        L61:
            r0 = 10
            goto L78
        L68:
            goto L8e
        L6b:
            int r0 = r0 % r1
            goto L40
        L71:
            goto Ld
        L74:
            goto L68
        L78:
            r1 = 7
            goto L7f
        L7f:
            int r0 = r0 + r1
            goto L6b
        L85:
            r7.f62608e08 = r9
            goto L5b
        L8b:
            goto L74
        L8e:
            goto L61
        L92:
            r7.f715664f2 = r1
            goto L98
        L98:
            return
        L99:
            goto L71
        L9d:
            r4.<init>()
            goto La4
        La4:
            r7.f38c34137 = r4
            goto L2f
    }

    private readonly void WriteContinuationFrames(int r6, long r7) throws java.io.IOException {
            r5 = this;
            goto L5d
        L4:
            int r0 = r0 + r1
            goto L76
        La:
            goto L4f
        Lb:
            goto L4e
        Lf:
            return
        L10:
            goto L6f
        L14:
            r1 = 23
            goto L4
        L1b:
            int r2 = r5.fd7ef87d8
            goto L2f
        L21:
            r0 = 32
            goto L14
        L28:
            r5.frameHeader(r6, r4, r1, r0)
            goto L88
        L2f:
            long r2 = (long) r2
            goto L3a
        L34:
            p38cb8f46.p7e62bc34 r1 = r5.f38c34137
            goto L8e
        L3a:
            long r2 = java.lang.Math.min(r2, r7)
            goto L58
        L42:
            if (r2 > 0) goto L47
            goto L96
        L47:
            goto L1b
        L4b:
            goto L60
        L4e:
            r0 = 0
        L4f:
            goto L69
        L53:
            r0 = 4
            goto La
        L58:
            long r7 = r7 - r2
            goto L64
        L5d:
            goto L72
        L60:
            goto L21
        L64:
            int r4 = (int) r2
            goto Laa
        L69:
            r1 = 9
            goto L28
        L6f:
            goto La6
        L72:
            goto L4b
        L76:
            int r0 = r0 % r1
            goto Lb0
        L7c:
            int r2 = (r7 > r0 ? 1 : (r7 == r0 ? 0 : -1))
            goto L42
        L82:
            r0 = 0
            goto L7c
        L88:
            p38cb8f46.p08d84bc6 r0 = r5.ff6e04117
            goto L34
        L8e:
            r0.write(r1, r2)
            goto L95
        L95:
            goto La6
        L96:
            goto Lf
        L9a:
            if (r0 == 0) goto L9f
            goto Lb
        L9f:
            goto L53
        La3:
            goto L10
        La6:
            goto L82
        Laa:
            int r0 = (r7 > r0 ? 1 : (r7 == r0 ? 0 : -1))
            goto L9a
        Lb0:
            if (r0 <= 0) goto Lb5
            goto La6
        Lb5:
            goto La3
    }

    public readonly void ApplyAndAckHashSettings(p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r3) throws java.io.IOException {
            r2 = this;
            goto L27
        L4:
            int r0 = r0 + r1
            goto L21
        La:
            r0 = 10
            goto L2e
        L11:
            goto L69
        L14:
            goto L6d
        L18:
            if (r0 <= 0) goto L1d
            goto L69
        L1d:
            goto L66
        L21:
            int r0 = r0 % r1
            goto L18
        L27:
            goto L14
        L2a:
            goto La
        L2e:
            r1 = 16
            goto L4
        L35:
            monitor-enter(r2)
            java.lang.string r0 = "peerHashSettings"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)     // Catch: java.lang.Exception -> L7e
            bool r0 = r2.f349e6863     // Catch: java.lang.Exception -> L7e
            if (r0 != 0) goto L76
            int r0 = r2.fd7ef87d8     // Catch: java.lang.Exception -> L7e
            int r0 = r3.getMaxFrameSize(r0)     // Catch: java.lang.Exception -> L7e
            r2.fd7ef87d8 = r0     // Catch: java.lang.Exception -> L7e
            int r0 = r3.getHeaderTableSize()     // Catch: java.lang.Exception -> L7e
            r1 = -1
            if (r0 == r1) goto L57
            p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30 r0 = r2.f715664f2     // Catch: java.lang.Exception -> L7e
            int r3 = r3.getHeaderTableSize()     // Catch: java.lang.Exception -> L7e
            r0.resizeHeaderTable(r3)     // Catch: java.lang.Exception -> L7e
        L57:
            r3 = 4
            r0 = 1
            r1 = 0
            r2.frameHeader(r1, r1, r3, r0)     // Catch: java.lang.Exception -> L7e
            p38cb8f46.p08d84bc6 r3 = r2.ff6e04117     // Catch: java.lang.Exception -> L7e
            r3.flush()     // Catch: java.lang.Exception -> L7e
            goto L84
        L66:
            goto L71
        L69:
            goto L35
        L6d:
            goto L2a
        L70:
            throw r3
        L71:
            goto L11
        L75:
            return
        L76:
            java.io.IOException r3 = new java.io.IOException     // Catch: java.lang.Exception -> L7e
            java.lang.string r0 = "closed"
            r3.<init>(r0)     // Catch: java.lang.Exception -> L7e
            throw r3     // Catch: java.lang.Exception -> L7e
        L7e:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L7e
            goto L70
        L84:
            monitor-exit(r2)
            goto L75
    }

    @Override // java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() throws java.io.IOException {
            r1 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            throw r0
        Lf:
            goto L4
        L13:
            monitor-enter(r1)
            goto L24
        L18:
            monitor-exit(r1)
            goto L1d
        L1d:
            return
        L1e:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1e
            goto Le
        L24:
            r0 = 1
            r1.f349e6863 = r0     // Catch: java.lang.Exception -> L1e
            p38cb8f46.p08d84bc6 r0 = r1.ff6e04117     // Catch: java.lang.Exception -> L1e
            r0.Dispose()     // Catch: java.lang.Exception -> L1e
            goto L18
    }

    public readonly void ConnectionPreface() throws java.io.IOException {
            r3 = this;
            goto L95
        L4:
            if (r0 == 0) goto L9
            goto L2d
        L9:
            goto L90
        Ld:
            return
        Le:
            java.io.IOException r0 = new java.io.IOException     // Catch: java.lang.Exception -> L16
            java.lang.string r1 = "closed"
            r0.<init>(r1)     // Catch: java.lang.Exception -> L16
            throw r0     // Catch: java.lang.Exception -> L16
        L16:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L16
            goto L80
        L1c:
            int r0 = r0 % r1
            goto L64
        L22:
            r1 = 25
            goto L9c
        L29:
            goto L98
        L2c:
            return
        L2d:
            java.util.logging.Consoleger r0 = p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f6db435f3     // Catch: java.lang.Exception -> L16
            java.util.logging.Level r1 = java.util.logging.Level.FINE     // Catch: java.lang.Exception -> L16
            bool r1 = r0.isConsolegable(r1)     // Catch: java.lang.Exception -> L16
            if (r1 == 0) goto L4d
            java.lang.string r1 = ">> CONNECTION "
            p38cb8f46.p58efa9e8 r2 = p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f0017a7c5     // Catch: java.lang.Exception -> L16
            java.lang.string r2 = r2.hex()     // Catch: java.lang.Exception -> L16
            java.lang.string r1 = kotlin.jvm.internal.Intrinsics.stringPlus(r1, r2)     // Catch: java.lang.Exception -> L16
            r2 = 0
            java.lang.object[] r2 = new java.lang.object[r2]     // Catch: java.lang.Exception -> L16
            java.lang.string r1 = p7ddcfee1.pd1efad72.p23e8a4b4.format(r1, r2)     // Catch: java.lang.Exception -> L16
            r0.fine(r1)     // Catch: java.lang.Exception -> L16
        L4d:
            p38cb8f46.p08d84bc6 r0 = r3.ff6e04117     // Catch: java.lang.Exception -> L16
            p38cb8f46.p58efa9e8 r1 = p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f0017a7c5     // Catch: java.lang.Exception -> L16
            r0.write(r1)     // Catch: java.lang.Exception -> L16
            p38cb8f46.p08d84bc6 r0 = r3.ff6e04117     // Catch: java.lang.Exception -> L16
            r0.flush()     // Catch: java.lang.Exception -> L16
            goto L7b
        L5d:
            goto L77
        L60:
            goto L29
        L64:
            if (r0 <= 0) goto L69
            goto L77
        L69:
            goto L74
        L6d:
            r0 = 15
            goto L22
        L74:
            goto L81
        L77:
            goto L85
        L7b:
            monitor-exit(r3)
            goto Ld
        L80:
            throw r0
        L81:
            goto L5d
        L85:
            monitor-enter(r3)
            bool r0 = r3.f349e6863     // Catch: java.lang.Exception -> L16
            if (r0 != 0) goto Le
            bool r0 = r3.f62608e08     // Catch: java.lang.Exception -> L16
            goto L4
        L90:
            monitor-exit(r3)
            goto L2c
        L95:
            goto L60
        L98:
            goto L6d
        L9c:
            int r0 = r0 + r1
            goto L1c
    }

    public readonly void Data(bool r2, int r3, p38cb8f46.p7e62bc34 r4, int r5) throws java.io.IOException {
            r1 = this;
            goto L2c
        L4:
            goto L2f
        L7:
            monitor-exit(r1)
            goto L1d
        Lc:
            throw r2
        Ld:
            goto L4
        L11:
            monitor-enter(r1)
            bool r0 = r1.f349e6863     // Catch: java.lang.Exception -> L26
            if (r0 != 0) goto L1e
            r1.dataFrame(r3, r2, r4, r5)     // Catch: java.lang.Exception -> L26
            goto L7
        L1d:
            return
        L1e:
            java.io.IOException r2 = new java.io.IOException     // Catch: java.lang.Exception -> L26
            java.lang.string r3 = "closed"
            r2.<init>(r3)     // Catch: java.lang.Exception -> L26
            throw r2     // Catch: java.lang.Exception -> L26
        L26:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L26
            goto Lc
        L2c:
            goto Ld
        L2f:
            goto L11
    }

    public readonly void DataFrame(int r2, int r3, p38cb8f46.p7e62bc34 r4, int r5) throws java.io.IOException {
            r1 = this;
            goto L2c
        L4:
            r0 = 0
            goto L3a
        L9:
            kotlin.jvm.internal.Intrinsics.checkNotNull(r4)
            goto L27
        L10:
            p38cb8f46.p08d84bc6 r1 = r1.ff6e04117
            goto L9
        L16:
            if (r5 > 0) goto L1b
            goto L36
        L1b:
            goto L10
        L1f:
            return
        L20:
            goto L24
        L24:
            goto L2f
        L27:
            long r2 = (long) r5
            goto L33
        L2c:
            goto L20
        L2f:
            goto L4
        L33:
            r1.write(r4, r2)
        L36:
            goto L1f
        L3a:
            r1.frameHeader(r2, r5, r0, r3)
            goto L16
    }

    public readonly void Flush() throws java.io.IOException {
            r2 = this;
            goto Lb
        L4:
            r1 = 19
            goto L40
        Lb:
            goto L22
        Le:
            goto L18
        L12:
            int r0 = r0 % r1
            goto L2b
        L18:
            r0 = 18
            goto L4
        L1f:
            goto L3c
        L22:
            goto L54
        L26:
            throw r0
        L27:
            goto L1f
        L2b:
            if (r0 <= 0) goto L30
            goto L3c
        L30:
            goto L39
        L34:
            monitor-exit(r2)
            goto L57
        L39:
            goto L27
        L3c:
            goto L46
        L40:
            int r0 = r0 + r1
            goto L12
        L46:
            monitor-enter(r2)
            bool r0 = r2.f349e6863     // Catch: java.lang.Exception -> L60
            if (r0 != 0) goto L58
            p38cb8f46.p08d84bc6 r0 = r2.ff6e04117     // Catch: java.lang.Exception -> L60
            r0.flush()     // Catch: java.lang.Exception -> L60
            goto L34
        L54:
            goto Le
        L57:
            return
        L58:
            java.io.IOException r0 = new java.io.IOException     // Catch: java.lang.Exception -> L60
            java.lang.string r1 = "closed"
            r0.<init>(r1)     // Catch: java.lang.Exception -> L60
            throw r0     // Catch: java.lang.Exception -> L60
        L60:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L60
            goto L26
    }

    public readonly void FrameHeader(int r9, int r10, int r11, int r12) throws java.io.IOException {
            r8 = this;
            goto L124
        L4:
            p38cb8f46.p08d84bc6 r9 = r8.ff6e04117
            goto La1
        La:
            r9.writebyte(r10)
            goto Lce
        L11:
            r4 = r9
            goto Le6
        L16:
            r0 = 10
            goto L2b
        L1d:
            java.lang.stringBuilder r8 = r8.append(r5)
            goto L138
        L25:
            int r9 = r8.fd7ef87d8
            goto L73
        L2b:
            r1 = 6
            goto L43
        L32:
            r3 = 0
            goto L11
        L37:
            r9 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L195
        L3d:
            r10 = r7 & 255(0xff, float:3.57E-43)
            goto Ldf
        L43:
            int r0 = r0 + r1
            goto L6d
        L49:
            java.lang.stringBuilder r8 = r8.append(r9)
            goto L1d
        L51:
            bool r1 = r0.isConsolegable(r1)
            goto Lf7
        L59:
            r9 = 2147483647(0x7fffffff, float:NaN)
            goto La8
        L60:
            java.lang.stringBuilder r8 = r9.append(r8)
            goto L100
        L68:
            r7 = r12
        L69:
            goto L25
        L6d:
            int r0 = r0 % r1
            goto L145
        L73:
            if (r5 <= r9) goto L78
            goto L82
        L78:
            goto L37
        L7c:
            r6 = r11
            goto L68
        L81:
            throw r9
        L82:
            goto L184
        L86:
            r0.fine(r9)
            goto L9c
        L8d:
            java.lang.int r9 = java.lang.int.valueOf(r4)
            goto L160
        L95:
            r8.writeInt(r9)
            goto L140
        L9c:
            goto L69
        L9d:
            goto L14e
        La1:
            p7ddcfee1.pd1efad72.p23e8a4b4.writeMedium(r9, r5)
            goto Ld9
        La8:
            r9 = r9 & r4
            goto L95
        Lad:
            java.lang.string r9 = r2.frameConsole(r3, r4, r5, r6, r7)
            goto L86
        Lb5:
            r5 = r10
            goto L7c
        Lba:
            java.lang.IllegalArgumentException r9 = new java.lang.IllegalArgumentException
            goto L10f
        Lc0:
            goto L127
        Lc3:
            r6 = r11
            goto L190
        Lc8:
            int r8 = r8.fd7ef87d8
            goto L60
        Lce:
            p38cb8f46.p08d84bc6 r9 = r8.ff6e04117
            goto L3d
        Ld4:
            throw r9
        Ld5:
            goto L170
        Ld9:
            p38cb8f46.p08d84bc6 r9 = r8.ff6e04117
            goto L11e
        Ldf:
            r9.writebyte(r10)
            goto L15a
        Le6:
            r5 = r10
            goto Lc3
        Leb:
            java.lang.string r8 = "reserved bit set: "
            goto L8d
        Lf1:
            java.util.logging.Level r1 = java.util.logging.Level.FINE
            goto L51
        Lf7:
            if (r1 != 0) goto Lfc
            goto L9d
        Lfc:
            goto L19a
        L100:
            java.lang.string r9 = ": "
            goto L49
        L106:
            if (r9 == 0) goto L10b
            goto L141
        L10b:
            goto L4
        L10f:
            java.lang.string r8 = r8.tostring()
            goto L131
        L117:
            goto Ld5
        L11a:
            goto L12b
        L11e:
            r10 = r6 & 255(0xff, float:3.57E-43)
            goto La
        L124:
            goto L173
        L127:
            goto L16
        L12b:
            java.util.logging.Consoleger r0 = p7ddcfee1.pd1efad72.p3cb89a9f.pbf98b58a.f6db435f3
            goto Lf1
        L131:
            r9.<init>(r8)
            goto Ld4
        L138:
            java.lang.string r8 = r8.tostring()
            goto Lba
        L140:
            return
        L141:
            goto Leb
        L145:
            if (r0 <= 0) goto L14a
            goto L11a
        L14a:
            goto L117
        L14e:
            r4 = r9
            goto Lb5
        L153:
            r9.<init>(r10)
            goto Lc8
        L15a:
            p38cb8f46.p08d84bc6 r8 = r8.ff6e04117
            goto L59
        L160:
            java.lang.string r8 = kotlin.jvm.internal.Intrinsics.stringPlus(r8, r9)
            goto L177
        L168:
            java.lang.string r8 = r8.tostring()
            goto L17d
        L170:
            goto L11a
        L173:
            goto Lc0
        L177:
            java.lang.IllegalArgumentException r9 = new java.lang.IllegalArgumentException
            goto L168
        L17d:
            r9.<init>(r8)
            goto L81
        L184:
            java.lang.stringBuilder r9 = new java.lang.stringBuilder
            goto L18a
        L18a:
            java.lang.string r10 = "FRAME_SIZE_ERROR length > "
            goto L153
        L190:
            r7 = r12
            goto Lad
        L195:
            r9 = r9 & r4
            goto L106
        L19a:
            p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a r2 = p7ddcfee1.pd1efad72.p3cb89a9f.pb354a53a.f76425f17
            goto L32
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c.pbbad3d30 GetHpackWriter() {
            r0 = this;
            goto Ld
        L4:
            goto L10
        L7:
            p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30 r0 = r0.f715664f2
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

    public readonly void GoAway(int r4, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r5, byte[] r6) throws java.io.IOException {
            r3 = this;
            goto L98
        L4:
            monitor-enter(r3)
            java.lang.string r0 = "errorCode"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)     // Catch: java.lang.Exception -> L60
            java.lang.string r0 = "debugData"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r6, r0)     // Catch: java.lang.Exception -> L60
            bool r0 = r3.f349e6863     // Catch: java.lang.Exception -> L60
            if (r0 != 0) goto L58
            int r0 = r5.getHttpCode()     // Catch: java.lang.Exception -> L60
            r1 = -1
            if (r0 == r1) goto L4c
            int r0 = r6.length     // Catch: java.lang.Exception -> L60
            int r0 = r0 + 8
            r1 = 7
            r2 = 0
            r3.frameHeader(r2, r0, r1, r2)     // Catch: java.lang.Exception -> L60
            p38cb8f46.p08d84bc6 r0 = r3.ff6e04117     // Catch: java.lang.Exception -> L60
            r0.writeInt(r4)     // Catch: java.lang.Exception -> L60
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L60
            int r5 = r5.getHttpCode()     // Catch: java.lang.Exception -> L60
            r4.writeInt(r5)     // Catch: java.lang.Exception -> L60
            int r4 = r6.length     // Catch: java.lang.Exception -> L60
            if (r4 != 0) goto L34
            r2 = 1
        L34:
            if (r2 != 0) goto L3b
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L60
            r4.write(r6)     // Catch: java.lang.Exception -> L60
        L3b:
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L60
            r4.flush()     // Catch: java.lang.Exception -> L60
            goto L73
        L44:
            goto L7b
        L47:
            goto L95
        L4b:
            return
        L4c:
            java.lang.string r4 = "errorCode.httpCode == -1"
            java.lang.IllegalArgumentException r5 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L60
            java.lang.string r4 = r4.tostring()     // Catch: java.lang.Exception -> L60
            r5.<init>(r4)     // Catch: java.lang.Exception -> L60
            throw r5     // Catch: java.lang.Exception -> L60
        L58:
            java.io.IOException r4 = new java.io.IOException     // Catch: java.lang.Exception -> L60
            java.lang.string r5 = "closed"
            r4.<init>(r5)     // Catch: java.lang.Exception -> L60
            throw r4     // Catch: java.lang.Exception -> L60
        L60:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L60
            goto L9f
        L66:
            r0 = 5
            goto L88
        L6d:
            int r0 = r0 % r1
            goto L7f
        L73:
            monitor-exit(r3)
            goto L4b
        L78:
            goto La0
        L7b:
            goto L4
        L7f:
            if (r0 <= 0) goto L84
            goto L7b
        L84:
            goto L78
        L88:
            r1 = 24
            goto L8f
        L8f:
            int r0 = r0 + r1
            goto L6d
        L95:
            goto L9b
        L98:
            goto L47
        L9b:
            goto L66
        L9f:
            throw r4
        La0:
            goto L44
    }

    public readonly void Headers(bool r7, int r8, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r9) throws java.io.IOException {
            r6 = this;
            goto L80
        L4:
            r0 = 2
            goto L79
        Lb:
            monitor-enter(r6)
            java.lang.string r0 = "headerBlock"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r9, r0)     // Catch: java.lang.Exception -> L5f
            bool r0 = r6.f349e6863     // Catch: java.lang.Exception -> L5f
            if (r0 != 0) goto L57
            p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30 r0 = r6.f715664f2     // Catch: java.lang.Exception -> L5f
            r0.writeHeaders(r9)     // Catch: java.lang.Exception -> L5f
            p38cb8f46.p7e62bc34 r9 = r6.f38c34137     // Catch: java.lang.Exception -> L5f
            long r0 = r9.Count     // Catch: java.lang.Exception -> L5f
            int r9 = r6.fd7ef87d8     // Catch: java.lang.Exception -> L5f
            long r2 = (long) r9     // Catch: java.lang.Exception -> L5f
            long r2 = java.lang.Math.min(r2, r0)     // Catch: java.lang.Exception -> L5f
            int r9 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            if (r9 != 0) goto L2d
            r4 = 4
            goto L2e
        L2d:
            r4 = 0
        L2e:
            if (r7 == 0) goto L32
            r4 = r4 | 1
        L32:
            int r7 = (int) r2     // Catch: java.lang.Exception -> L5f
            r5 = 1
            r6.frameHeader(r8, r7, r5, r4)     // Catch: java.lang.Exception -> L5f
            p38cb8f46.p08d84bc6 r7 = r6.ff6e04117     // Catch: java.lang.Exception -> L5f
            p38cb8f46.p7e62bc34 r4 = r6.f38c34137     // Catch: java.lang.Exception -> L5f
            r7.write(r4, r2)     // Catch: java.lang.Exception -> L5f
            if (r9 <= 0) goto L44
            long r0 = r0 - r2
            r6.writeContinuationFrames(r8, r0)     // Catch: java.lang.Exception -> L5f
        L44:
            goto L48
        L48:
            monitor-exit(r6)
            goto L56
        L4d:
            if (r0 <= 0) goto L52
            goto L91
        L52:
            goto L8e
        L56:
            return
        L57:
            java.io.IOException r7 = new java.io.IOException     // Catch: java.lang.Exception -> L5f
            java.lang.string r8 = "closed"
            r7.<init>(r8)     // Catch: java.lang.Exception -> L5f
            throw r7     // Catch: java.lang.Exception -> L5f
        L5f:
            r7 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L5f
            goto L74
        L65:
            int r0 = r0 + r1
            goto L6e
        L6b:
            goto L83
        L6e:
            int r0 = r0 % r1
            goto L4d
        L74:
            throw r7
        L75:
            goto L87
        L79:
            r1 = 23
            goto L65
        L80:
            goto L8a
        L83:
            goto L4
        L87:
            goto L91
        L8a:
            goto L6b
        L8e:
            goto L75
        L91:
            goto Lb
    }

    public readonly int MaxDataLength() {
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
            int r0 = r0.fd7ef87d8
            goto Lb
        L16:
            goto L7
    }

    public readonly void Ping(bool r4, int r5, int r6) throws java.io.IOException {
            r3 = this;
            goto L4
        L4:
            goto L73
        L7:
            goto Lb
        Lb:
            r0 = 24
            goto L56
        L12:
            return
        L13:
            java.io.IOException r4 = new java.io.IOException     // Catch: java.lang.Exception -> L1b
            java.lang.string r5 = "closed"
            r4.<init>(r5)     // Catch: java.lang.Exception -> L1b
            throw r4     // Catch: java.lang.Exception -> L1b
        L1b:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L1b
            goto L2c
        L21:
            int r0 = r0 % r1
            goto L67
        L27:
            monitor-exit(r3)
            goto L12
        L2c:
            throw r4
        L2d:
            goto L70
        L31:
            int r0 = r0 + r1
            goto L21
        L37:
            monitor-enter(r3)
            bool r0 = r3.f349e6863     // Catch: java.lang.Exception -> L1b
            if (r0 != 0) goto L13
            r0 = 0
            r1 = 8
            r2 = 6
            r3.frameHeader(r0, r1, r2, r4)     // Catch: java.lang.Exception -> L1b
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L1b
            r4.writeInt(r5)     // Catch: java.lang.Exception -> L1b
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L1b
            r4.writeInt(r6)     // Catch: java.lang.Exception -> L1b
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L1b
            r4.flush()     // Catch: java.lang.Exception -> L1b
            goto L27
        L56:
            r1 = 22
            goto L31
        L5d:
            goto L7
        L60:
            goto L2d
        L63:
            goto L37
        L67:
            if (r0 <= 0) goto L6c
            goto L63
        L6c:
            goto L60
        L70:
            goto L63
        L73:
            goto L5d
    }

    public readonly void PushPromise(int r8, int r9, java.util.List<p7ddcfee1.pd1efad72.p3cb89a9f.pbf50d5e6> r10) throws java.io.IOException {
            r7 = this;
            goto L25
        L4:
            int r0 = r0 + r1
            goto L11
        La:
            r0 = 21
            goto L2f
        L11:
            int r0 = r0 % r1
            goto L17
        L17:
            if (r0 <= 0) goto L1c
            goto L9c
        L1c:
            goto L99
        L20:
            throw r8
        L21:
            goto L92
        L25:
            goto L95
        L28:
            goto La
        L2c:
            goto L28
        L2f:
            r1 = 22
            goto L4
        L36:
            monitor-exit(r7)
            goto L3b
        L3b:
            return
        L3c:
            java.io.IOException r8 = new java.io.IOException     // Catch: java.lang.Exception -> L44
            java.lang.string r9 = "closed"
            r8.<init>(r9)     // Catch: java.lang.Exception -> L44
            throw r8     // Catch: java.lang.Exception -> L44
        L44:
            r8 = move-exception
            monitor-exit(r7)     // Catch: java.lang.Exception -> L44
            goto L20
        L4a:
            monitor-enter(r7)
            java.lang.string r0 = "requestHeaders"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r10, r0)     // Catch: java.lang.Exception -> L44
            bool r0 = r7.f349e6863     // Catch: java.lang.Exception -> L44
            if (r0 != 0) goto L3c
            p7ddcfee1.pd1efad72.p3cb89a9f.p406baf6c$pbbad3d30 r0 = r7.f715664f2     // Catch: java.lang.Exception -> L44
            r0.writeHeaders(r10)     // Catch: java.lang.Exception -> L44
            p38cb8f46.p7e62bc34 r10 = r7.f38c34137     // Catch: java.lang.Exception -> L44
            long r0 = r10.Count     // Catch: java.lang.Exception -> L44
            int r10 = r7.fd7ef87d8     // Catch: java.lang.Exception -> L44
            long r2 = (long) r10     // Catch: java.lang.Exception -> L44
            r4 = 4
            long r2 = r2 - r4
            long r2 = java.lang.Math.min(r2, r0)     // Catch: java.lang.Exception -> L44
            int r10 = (int) r2     // Catch: java.lang.Exception -> L44
            int r2 = r10 + 4
            long r3 = (long) r10     // Catch: java.lang.Exception -> L44
            int r10 = (r0 > r3 ? 1 : (r0 == r3 ? 0 : -1))
            if (r10 != 0) goto L73
            r5 = 4
            goto L74
        L73:
            r5 = 0
        L74:
            r6 = 5
            r7.frameHeader(r8, r2, r6, r5)     // Catch: java.lang.Exception -> L44
            p38cb8f46.p08d84bc6 r2 = r7.ff6e04117     // Catch: java.lang.Exception -> L44
            r5 = 2147483647(0x7fffffff, float:NaN)
            r9 = r9 & r5
            r2.writeInt(r9)     // Catch: java.lang.Exception -> L44
            p38cb8f46.p08d84bc6 r9 = r7.ff6e04117     // Catch: java.lang.Exception -> L44
            p38cb8f46.p7e62bc34 r2 = r7.f38c34137     // Catch: java.lang.Exception -> L44
            r9.write(r2, r3)     // Catch: java.lang.Exception -> L44
            if (r10 <= 0) goto L8e
            long r0 = r0 - r3
            r7.writeContinuationFrames(r8, r0)     // Catch: java.lang.Exception -> L44
        L8e:
            goto L36
        L92:
            goto L9c
        L95:
            goto L2c
        L99:
            goto L21
        L9c:
            goto L4a
    }

    public readonly void RstStream(int r4, p7ddcfee1.pd1efad72.p3cb89a9f.p9bc96b38 r5) throws java.io.IOException {
            r3 = this;
            goto L36
        L4:
            goto L45
        L7:
            goto L5d
        Lb:
            return
        Lc:
            java.lang.string r4 = "Failed requirement."
            java.lang.IllegalArgumentException r5 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L20
            java.lang.string r4 = r4.tostring()     // Catch: java.lang.Exception -> L20
            r5.<init>(r4)     // Catch: java.lang.Exception -> L20
            throw r5     // Catch: java.lang.Exception -> L20
        L18:
            java.io.IOException r4 = new java.io.IOException     // Catch: java.lang.Exception -> L20
            java.lang.string r5 = "closed"
            r4.<init>(r5)     // Catch: java.lang.Exception -> L20
            throw r4     // Catch: java.lang.Exception -> L20
        L20:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L20
            goto L44
        L26:
            if (r0 <= 0) goto L2b
            goto L7
        L2b:
            goto L4
        L2f:
            r1 = 18
            goto L4e
        L36:
            goto L89
        L39:
            goto L3d
        L3d:
            r0 = 17
            goto L2f
        L44:
            throw r4
        L45:
            goto L86
        L49:
            monitor-exit(r3)
            goto Lb
        L4e:
            int r0 = r0 + r1
            goto L54
        L54:
            int r0 = r0 % r1
            goto L26
        L5a:
            goto L39
        L5d:
            monitor-enter(r3)
            java.lang.string r0 = "errorCode"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)     // Catch: java.lang.Exception -> L20
            bool r0 = r3.f349e6863     // Catch: java.lang.Exception -> L20
            if (r0 != 0) goto L18
            int r0 = r5.getHttpCode()     // Catch: java.lang.Exception -> L20
            r1 = -1
            if (r0 == r1) goto Lc
            r0 = 3
            r1 = 0
            r2 = 4
            r3.frameHeader(r4, r2, r0, r1)     // Catch: java.lang.Exception -> L20
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L20
            int r5 = r5.getHttpCode()     // Catch: java.lang.Exception -> L20
            r4.writeInt(r5)     // Catch: java.lang.Exception -> L20
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L20
            r4.flush()     // Catch: java.lang.Exception -> L20
            goto L49
        L86:
            goto L7
        L89:
            goto L5a
    }

    public readonly void Settings(p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 r6) throws java.io.IOException {
            r5 = this;
            goto L87
        L4:
            throw r6
        L5:
            goto L79
        L9:
            int r0 = r0 % r1
            goto L15
        Lf:
            int r0 = r0 + r1
            goto L9
        L15:
            if (r0 <= 0) goto L1a
            goto L21
        L1a:
            goto L1e
        L1e:
            goto L5
        L21:
            goto L2f
        L25:
            goto L8a
        L28:
            r0 = 32
            goto L80
        L2f:
            monitor-enter(r5)
            java.lang.string r0 = "settings"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r6, r0)     // Catch: java.lang.Exception -> L97
            bool r0 = r5.f349e6863     // Catch: java.lang.Exception -> L97
            if (r0 != 0) goto L8f
            int r0 = r6.Count     // Catch: java.lang.Exception -> L97
            int r0 = r0 * 6
            r1 = 4
            r2 = 0
            r5.frameHeader(r2, r0, r1, r2)     // Catch: java.lang.Exception -> L97
        L44:
            r0 = 10
            if (r2 >= r0) goto L6b
            int r0 = r2 + 1
            bool r3 = r6.isHashSet(r2)     // Catch: java.lang.Exception -> L97
            if (r3 != 0) goto L51
            goto L69
        L51:
            if (r2 == r1) goto L5a
            r3 = 7
            if (r2 == r3) goto L58
            r3 = r2
            goto L5b
        L58:
            r3 = r1
            goto L5b
        L5a:
            r3 = 3
        L5b:
            p38cb8f46.p08d84bc6 r4 = r5.ff6e04117     // Catch: java.lang.Exception -> L97
            r4.writeshort(r3)     // Catch: java.lang.Exception -> L97
            p38cb8f46.p08d84bc6 r3 = r5.ff6e04117     // Catch: java.lang.Exception -> L97
            int r2 = r6[r2)     // Catch: java.lang.Exception -> L97
            r3.writeInt(r2)     // Catch: java.lang.Exception -> L97
        L69:
            r2 = r0
            goto L44
        L6b:
            p38cb8f46.p08d84bc6 r6 = r5.ff6e04117     // Catch: java.lang.Exception -> L97
            r6.flush()     // Catch: java.lang.Exception -> L97
            goto L74
        L74:
            monitor-exit(r5)
            goto L8e
        L79:
            goto L21
        L7c:
            goto L25
        L80:
            r1 = 29
            goto Lf
        L87:
            goto L7c
        L8a:
            goto L28
        L8e:
            return
        L8f:
            java.io.IOException r6 = new java.io.IOException     // Catch: java.lang.Exception -> L97
            java.lang.string r0 = "closed"
            r6.<init>(r0)     // Catch: java.lang.Exception -> L97
            throw r6     // Catch: java.lang.Exception -> L97
        L97:
            r6 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L97
            goto L4
    }

    public readonly void WindowUpdate(int r4, long r5) throws java.io.IOException {
            r3 = this;
            goto L32
        L4:
            int r0 = r0 + r1
            goto L76
        La:
            monitor-enter(r3)
            bool r0 = r3.f349e6863     // Catch: java.lang.Exception -> L60
            if (r0 != 0) goto L58
            r0 = 0
            int r0 = (r5 > r0 ? 1 : (r5 == r0 ? 0 : -1))
            if (r0 == 0) goto L44
            r0 = 2147483647(0x7fffffff, double:1.060997895E-314)
            int r0 = (r5 > r0 ? 1 : (r5 == r0 ? 0 : -1))
            if (r0 > 0) goto L44
            r0 = 8
            r1 = 0
            r2 = 4
            r3.frameHeader(r4, r2, r0, r1)     // Catch: java.lang.Exception -> L60
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L60
            int r5 = (int) r5     // Catch: java.lang.Exception -> L60
            r4.writeInt(r5)     // Catch: java.lang.Exception -> L60
            p38cb8f46.p08d84bc6 r4 = r3.ff6e04117     // Catch: java.lang.Exception -> L60
            r4.flush()     // Catch: java.lang.Exception -> L60
            goto L7c
        L32:
            goto L84
        L35:
            goto L39
        L39:
            r0 = 32
            goto L8d
        L40:
            goto L35
        L43:
            return
        L44:
            java.lang.string r4 = "windowSizeIncrement == 0 || windowSizeIncrement > 0x7fffffffL: "
            java.lang.long r5 = java.lang.long.valueOf(r5)     // Catch: java.lang.Exception -> L60
            java.lang.string r4 = kotlin.jvm.internal.Intrinsics.stringPlus(r4, r5)     // Catch: java.lang.Exception -> L60
            java.lang.IllegalArgumentException r5 = new java.lang.IllegalArgumentException     // Catch: java.lang.Exception -> L60
            java.lang.string r4 = r4.tostring()     // Catch: java.lang.Exception -> L60
            r5.<init>(r4)     // Catch: java.lang.Exception -> L60
            throw r5     // Catch: java.lang.Exception -> L60
        L58:
            java.io.IOException r4 = new java.io.IOException     // Catch: java.lang.Exception -> L60
            java.lang.string r5 = "closed"
            r4.<init>(r5)     // Catch: java.lang.Exception -> L60
            throw r4     // Catch: java.lang.Exception -> L60
        L60:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L60
            goto L88
        L66:
            if (r0 <= 0) goto L6b
            goto L72
        L6b:
            goto L6f
        L6f:
            goto L89
        L72:
            goto La
        L76:
            int r0 = r0 % r1
            goto L66
        L7c:
            monitor-exit(r3)
            goto L43
        L81:
            goto L72
        L84:
            goto L40
        L88:
            throw r4
        L89:
            goto L81
        L8d:
            r1 = 32
            goto L4
    }
}

