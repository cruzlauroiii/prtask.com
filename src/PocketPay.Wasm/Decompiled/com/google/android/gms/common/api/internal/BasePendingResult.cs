namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public abstract class BasePendingResult<R : com.google.android.gms.common.api.Result> : com.google.android.gms.common.api.PendingResult<R> {
    static readonly java.lang.ThreadLocal zaa = null;
    public static readonly /* synthetic */ int zad = 0;
    private com.google.android.gms.common.api.internal.zar resultGuardian;
    protected readonly com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler zab;
    protected readonly java.lang.ref.WeakReference zac;
    private readonly java.lang.object zae;
    private readonly java.util.concurrent.CountdownEvent zaf;
    private readonly java.util.List zag;
    private com.google.android.gms.common.api.ResultCallback zah;
    private readonly java.util.concurrent.atomic.object zai;
    private com.google.android.gms.common.api.Result zaj;
    private com.google.android.gms.common.api.Status zak;
    private bool zal;
    private bool zam;
    private bool zan;
    private com.google.android.gms.common.internal.ICancelToken zao;
    private com.google.android.gms.common.api.internal.zacx zap;
    private bool zaq;

    public static class CallbackHandler<R : com.google.android.gms.common.api.Result> : com.google.android.gms.internal.base.zaq {
        public CallbackHandler() {
                r1 = this;
                goto L4
            L4:
                goto L1e
            L7:
                goto Lb
            Lb:
                android.os.Looper r0 = vTDiFBqSeVVBcNAX()
                goto L16
            L13:
                goto L7
            L16:
                r1.<init>(r0)
                goto L1d
            L1d:
                return
            L1e:
                goto L13
        }

        public CallbackHandler(android.os.Looper r1) {
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
                r0.<init>(r1)
                goto L4
            L17:
                goto Lc
        }

        public static void BNaIOJVgDdBaWdZS(com.google.android.gms.common.api.ResultCallback r0, com.google.android.gms.common.api.Result r1) {
                goto L10
            L4:
                return
            L5:
                goto L17
            L9:
                r0.onResult(r1)
                goto L4
            L10:
                goto L5
            L13:
                goto L9
            L17:
                goto L13
        }

        public static void BYjuwzdUjZHRMAWe(com.google.android.gms.common.api.internal.BasePendingResult r0, com.google.android.gms.common.api.Status r1) {
                goto L4
            L4:
                goto L16
            L7:
                goto Lb
            Lb:
                r0.forceFailureUnlessReady(r1)
                goto L15
            L12:
                goto L7
            L15:
                return
            L16:
                goto L12
        }

        public static java.lang.object IbzULEifZqdgCUNW(java.lang.object r1) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static void QLBRhHhlFHocgwQj(com.google.android.gms.common.api.Result r0) {
                goto L4
            L4:
                goto L16
            L7:
                goto Lb
            Lb:
                com.google.android.gms.common.api.internal.BasePendingResult.zal(r0)
                goto L15
            L12:
                goto L7
            L15:
                return
            L16:
                goto L12
        }

        public static bool XJZLGnoYJrRHAcRo(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r1, android.os.Message r2) {
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
                bool r0 = r1.sendMessage(r2)
                goto Lb
        }

        public static java.lang.string BcjgiStAKbWwTQKn(java.lang.stringBuilder r1) {
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
                java.lang.string r0 = r1.tostring()
                goto Lb
        }

        public static java.lang.stringBuilder IwlpJahflgJednnk(java.lang.stringBuilder r1, int r2) {
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
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L4
        }

        public static android.os.Looper VTDiFBqSeVVBcNAX() {
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
                android.os.Looper r0 = android.os.Looper.getMainLooper()
                goto Lb
        }

        public static int VnFFpzkuConsHodg(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
                goto Lc
            L4:
                int r0 = android.util.Console.wtf(r1, r2, r3)
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

        public static android.os.Message WzfmcTgAVyBOqKCf(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r1, int r2, java.lang.object r3) {
                goto L14
            L4:
                goto L17
            L7:
                android.os.Message r0 = r1.obtainMessage(r2, r3)
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

        @Override // android.os.Handler
        public readonly void HandleMessage(android.os.Message r2) {
                r1 = this;
                goto L41
            L4:
                vnFFpzkuConsHodg(r0, r1, r2)
                goto Lc3
            Lb:
                com.google.android.gms.common.api.internal.BasePendingResult r1 = (com.google.android.gms.common.api.internal.BasePendingResult) r1
                goto L54
            L11:
                com.google.android.gms.common.api.ResultCallback r2 = (com.google.android.gms.common.api.ResultCallback) r2
                goto L17
            L17:
                java.lang.object r1 = r1.second
                goto La8
            L1d:
                java.lang.Exception r2 = new java.lang.Exception
                goto L6e
            L23:
                int r1 = r2.what
                goto L36
            L29:
                iwlpJahflgJednnk(r2, r1)
                goto L9b
            L30:
                java.lang.string r0 = "Don't know how to handle message: "
                goto L94
            L36:
                java.lang.stringBuilder r2 = new java.lang.stringBuilder
                goto L30
            L3c:
                r0 = 1
                goto L7e
            L41:
                goto Lb8
            L44:
                goto L48
            L48:
                int r1 = r2.what
                goto L3c
            L4e:
                java.lang.object r1 = r2.obj
                goto Lb
            L54:
                com.google.android.gms.common.api.Status r2 = com.google.android.gms.common.api.Status.RESULT_TIMEOUT
                goto L8d
            L5a:
                return
            L5b:
                goto L65
            L5f:
                java.lang.object r2 = r1.first
                goto L11
            L65:
                java.lang.object r1 = r2.obj
                goto L87
            L6b:
                goto L44
            L6e:
                r2.<init>()
                goto Lb1
            L75:
                if (r1 != r0) goto L7a
                goto Lc4
            L7a:
                goto L23
            L7e:
                if (r1 != r0) goto L83
                goto L5b
            L83:
                goto La3
            L87:
                android.util.ValueTuple r1 = (android.util.ValueTuple) r1
                goto L5f
            L8d:
                BYjuwzdUjZHRMAWe(r1, r2)
                goto L5a
            L94:
                r2.<init>(r0)
                goto L29
            L9b:
                java.lang.string r1 = bcjgiStAKbWwTQKn(r2)
                goto L1d
            La3:
                r0 = 2
                goto L75
            La8:
                com.google.android.gms.common.api.Result r1 = (com.google.android.gms.common.api.Result) r1
                BNaIOJVgDdBaWdZS(r2, r1)     // Catch: java.lang.Exception -> Lc9
                goto Lc8
            Lb1:
                java.lang.string r0 = "BasePendingResult"
                goto L4
            Lb7:
                throw r2
            Lb8:
                goto L6b
            Lbc:
                QLBRhHhlFHocgwQj(r1)
                goto Lb7
            Lc3:
                return
            Lc4:
                goto L4e
            Lc8:
                return
            Lc9:
                r2 = move-exception
                goto Lbc
        }

        public readonly void Zaa(com.google.android.gms.common.api.ResultCallback r2, com.google.android.gms.common.api.Result r3) {
                r1 = this;
                goto L10
            L4:
                android.util.ValueTuple r0 = new android.util.ValueTuple
                goto L17
            La:
                int r0 = com.google.android.gms.common.api.internal.BasePendingResult.zad
                goto L1e
            L10:
                goto L3c
            L13:
                goto La
            L17:
                r0.<init>(r2, r3)
                goto L36
            L1e:
                java.lang.object r2 = IbzULEifZqdgCUNW(r2)
                goto L30
            L26:
                goto L13
            L29:
                XJZLGnoYJrRHAcRo(r1, r2)
                goto L3b
            L30:
                com.google.android.gms.common.api.ResultCallback r2 = (com.google.android.gms.common.api.ResultCallback) r2
                goto L4
            L36:
                r2 = 1
                goto L40
            L3b:
                return
            L3c:
                goto L26
            L40:
                android.os.Message r2 = wzfmcTgAVyBOqKCf(r1, r2, r0)
                goto L29
        }
    }

    static {
            goto L16
        L4:
            r0.<init>()
            goto L20
        Lb:
            com.google.android.gms.common.api.internal.zaq r0 = new com.google.android.gms.common.api.internal.zaq
            goto L4
        L11:
            return
        L12:
            goto L1d
        L16:
            goto L12
        L19:
            goto Lb
        L1d:
            goto L19
        L20:
            com.google.android.gms.common.api.internal.BasePendingResult.zaa = r0
            goto L11
    }

    @java.lang.Deprecated
    BasePendingResult() {
            r2 = this;
            goto L46
        L4:
            return
        L5:
            goto L9d
        L9:
            r0.<init>()
            goto L23
        L10:
            r0.<init>()
            goto L6c
        L17:
            java.util.concurrent.CountdownEvent r0 = new java.util.concurrent.CountdownEvent
            goto L30
        L1d:
            java.lang.ref.WeakReference r0 = new java.lang.ref.WeakReference
            goto L72
        L23:
            r2.zai = r0
            goto L98
        L29:
            r0.<init>(r1)
            goto L85
        L30:
            r1 = 1
            goto L53
        L35:
            goto L49
        L38:
            r0.<init>(r1)
            goto Lc0
        L3f:
            r2.<init>()
            goto L5a
        L46:
            goto La0
        L49:
            goto L91
        L4d:
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r0 = new com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler
            goto L77
        L53:
            r0.<init>(r1)
            goto Lcd
        L5a:
            java.lang.object r0 = new java.lang.object
            goto L10
        L60:
            r2.zag = r0
            goto L8b
        L66:
            int r0 = r0 + r1
            goto Laa
        L6c:
            r2.zae = r0
            goto L17
        L72:
            r1 = 0
            goto L38
        L77:
            android.os.Looper r1 = dtCfzjiPxRnrAgmD()
            goto L29
        L7f:
            java.util.List r0 = new java.util.List
            goto Ld3
        L85:
            r2.zab = r0
            goto L1d
        L8b:
            java.util.concurrent.atomic.object r0 = new java.util.concurrent.atomic.object
            goto L9
        L91:
            r0 = 3
            goto Lb9
        L98:
            r0 = 0
            goto La4
        L9d:
            goto Lc9
        La0:
            goto L35
        La4:
            r2.zaq = r0
            goto L4d
        Laa:
            int r0 = r0 % r1
            goto Lb0
        Lb0:
            if (r0 <= 0) goto Lb5
            goto Lc9
        Lb5:
            goto Lc6
        Lb9:
            r1 = 7
            goto L66
        Lc0:
            r2.zac = r0
            goto L4
        Lc6:
            goto L5
        Lc9:
            goto L3f
        Lcd:
            r2.zaf = r0
            goto L7f
        Ld3:
            r0.<init>()
            goto L60
    }

    @java.lang.Deprecated
    protected BasePendingResult(android.os.Looper r3) {
            r2 = this;
            goto L8b
        L4:
            r3.<init>(r0)
            goto Lcc
        Lb:
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r0 = new com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler
            goto L99
        L11:
            goto Lc8
        L14:
            goto L3f
        L18:
            java.util.concurrent.atomic.object r0 = new java.util.concurrent.atomic.object
            goto L5f
        L1e:
            r0.<init>(r1)
            goto La0
        L25:
            java.util.List r0 = new java.util.List
            goto Lab
        L2b:
            r2.zai = r0
            goto L3a
        L31:
            if (r0 <= 0) goto L36
            goto Lc8
        L36:
            goto Lc5
        L3a:
            r0 = 0
            goto L59
        L3f:
            goto L8e
        L42:
            r2.zae = r0
            goto L66
        L48:
            return
        L49:
            goto L11
        L4d:
            java.lang.ref.WeakReference r3 = new java.lang.ref.WeakReference
            goto La6
        L53:
            java.lang.object r0 = new java.lang.object
            goto L7f
        L59:
            r2.zaq = r0
            goto Lb
        L5f:
            r0.<init>()
            goto L2b
        L66:
            java.util.concurrent.CountdownEvent r0 = new java.util.concurrent.CountdownEvent
            goto L86
        L6c:
            int r0 = r0 % r1
            goto L31
        L72:
            r1 = 32
            goto Lb8
        L79:
            r2.zag = r0
            goto L18
        L7f:
            r0.<init>()
            goto L42
        L86:
            r1 = 1
            goto L1e
        L8b:
            goto L14
        L8e:
            goto Lbe
        L92:
            r2.<init>()
            goto L53
        L99:
            r0.<init>(r3)
            goto Lb2
        La0:
            r2.zaf = r0
            goto L25
        La6:
            r0 = 0
            goto L4
        Lab:
            r0.<init>()
            goto L79
        Lb2:
            r2.zab = r0
            goto L4d
        Lb8:
            int r0 = r0 + r1
            goto L6c
        Lbe:
            r0 = 11
            goto L72
        Lc5:
            goto L49
        Lc8:
            goto L92
        Lcc:
            r2.zac = r3
            goto L48
    }

    protected BasePendingResult(com.google.android.gms.common.api.GoogleApiClient r3) {
            r2 = this;
            goto Ldd
        L4:
            goto L44
        L7:
            goto Lb1
        Lb:
            r1.<init>(r0)
            goto L77
        L12:
            r2.zaq = r0
            goto L8a
        L18:
            r0.<init>()
            goto Ld1
        L1f:
            r2.zaf = r0
            goto L93
        L25:
            r2.zai = r0
            goto L48
        L2b:
            android.os.Looper r0 = newAwybvjuSIXVLa()
        L2f:
            goto L4d
        L33:
            r0.<init>()
            goto La6
        L3a:
            r0 = 19
            goto Le4
        L41:
            goto Lcd
        L44:
            goto L7d
        L48:
            r0 = 0
            goto L12
        L4d:
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r1 = new com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler
            goto Lb
        L53:
            r0.<init>(r1)
            goto L1f
        L5a:
            r1 = 1
            goto L53
        L5f:
            r0.<init>()
            goto L25
        L66:
            android.os.Looper r0 = fERBqgMWlgjOnVAN(r3)
            goto Lac
        L6e:
            if (r0 <= 0) goto L73
            goto L44
        L73:
            goto L41
        L77:
            r2.zab = r1
            goto Lc0
        L7d:
            r2.<init>()
            goto Ld7
        L84:
            java.util.concurrent.atomic.object r0 = new java.util.concurrent.atomic.object
            goto L5f
        L8a:
            if (r3 != 0) goto L8f
            goto Lad
        L8f:
            goto L66
        L93:
            java.util.List r0 = new java.util.List
            goto L18
        L99:
            int r0 = r0 + r1
            goto Lb4
        L9f:
            r0.<init>(r3)
            goto Lba
        La6:
            r2.zae = r0
            goto Lc6
        Lac:
            goto L2f
        Lad:
            goto L2b
        Lb1:
            goto Le0
        Lb4:
            int r0 = r0 % r1
            goto L6e
        Lba:
            r2.zac = r0
            goto Lcc
        Lc0:
            java.lang.ref.WeakReference r0 = new java.lang.ref.WeakReference
            goto L9f
        Lc6:
            java.util.concurrent.CountdownEvent r0 = new java.util.concurrent.CountdownEvent
            goto L5a
        Lcc:
            return
        Lcd:
            goto L4
        Ld1:
            r2.zag = r0
            goto L84
        Ld7:
            java.lang.object r0 = new java.lang.object
            goto L33
        Ldd:
            goto L7
        Le0:
            goto L3a
        Le4:
            r1 = 29
            goto L99
    }

    protected BasePendingResult(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler<R> r3) {
            r2 = this;
            goto L76
        L4:
            goto Lce
        L7:
            goto Lad
        Lb:
            java.lang.object r3 = SYnzLDVpJavvbCkn(r3, r0)
            goto L38
        L13:
            r2.zab = r3
            goto L52
        L19:
            r1 = 10
            goto L61
        L20:
            int r0 = r0 % r1
            goto L6d
        L26:
            r0 = 10
            goto L19
        L2d:
            java.util.concurrent.CountdownEvent r0 = new java.util.concurrent.CountdownEvent
            goto L33
        L33:
            r1 = 1
            goto L83
        L38:
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r3 = (com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler) r3
            goto L13
        L3e:
            r3.<init>(r0)
            goto La2
        L45:
            r2.zae = r0
            goto L2d
        L4b:
            r0.<init>()
            goto L45
        L52:
            java.lang.ref.WeakReference r3 = new java.lang.ref.WeakReference
            goto La8
        L58:
            goto L79
        L5b:
            r2.zag = r0
            goto L9c
        L61:
            int r0 = r0 + r1
            goto L20
        L67:
            java.lang.object r0 = new java.lang.object
            goto L4b
        L6d:
            if (r0 <= 0) goto L72
            goto L7
        L72:
            goto L4
        L76:
            goto Ld5
        L79:
            goto L26
        L7d:
            java.lang.string r0 = "CallbackHandler must not be null"
            goto Lb
        L83:
            r0.<init>(r1)
            goto Lc7
        L8a:
            r0 = 0
            goto Lc1
        L8f:
            r0.<init>()
            goto L5b
        L96:
            java.util.List r0 = new java.util.List
            goto L8f
        L9c:
            java.util.concurrent.atomic.object r0 = new java.util.concurrent.atomic.object
            goto Lb4
        La2:
            r2.zac = r3
            goto Lcd
        La8:
            r0 = 0
            goto L3e
        Lad:
            r2.<init>()
            goto L67
        Lb4:
            r0.<init>()
            goto Lbb
        Lbb:
            r2.zai = r0
            goto L8a
        Lc1:
            r2.zaq = r0
            goto L7d
        Lc7:
            r2.zaf = r0
            goto L96
        Lcd:
            return
        Lce:
            goto Ld2
        Ld2:
            goto L7
        Ld5:
            goto L58
    }

    public static com.google.android.gms.common.api.Result AlEaEOfuQUVOxjdA(com.google.android.gms.common.api.internal.BasePendingResult r1, com.google.android.gms.common.api.Status r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.gms.common.api.Result r0 = r1.createFailedResult(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void ArlVIXNwyrAKCRQe(bool r0, java.lang.object r1) {
            goto L13
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static com.google.android.gms.common.api.Status BYztWooARWUPqMjj(com.google.android.gms.common.api.Result r1) {
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
            com.google.android.gms.common.api.Status r0 = r1.getStatus()
            goto L4
    }

    public static long CCUIyiaNWFGFEuZY(java.util.concurrent.CountdownEvent r2) {
            goto L45
        L4:
            goto L41
        L7:
            goto L2b
        Lb:
            goto L48
        Le:
            if (r0 <= 0) goto L13
            goto L7
        L13:
            goto L4
        L17:
            goto L7
        L1a:
            goto Lb
        L1e:
            r0 = 23
            goto L33
        L25:
            int r0 = r0 % r1
            goto Le
        L2b:
            long r0 = r2.getCount()
            goto L40
        L33:
            r1 = 18
            goto L3a
        L3a:
            int r0 = r0 + r1
            goto L25
        L40:
            return r0
        L41:
            goto L17
        L45:
            goto L1a
        L48:
            goto L1e
    }

    public static com.google.android.gms.common.api.Result CJYjqMvVGfSgXUJu(com.google.android.gms.common.api.internal.BasePendingResult r1) {
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
            com.google.android.gms.common.api.Result r0 = r1.zaa()
            goto Lb
        L18:
            goto L7
    }

    public static void CNIlWDbHbdYUbVWy(java.util.concurrent.CountdownEvent r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.countDown()
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

    public static bool DVAYDMOWyxwGUswV(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.isReady()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.android.gms.common.api.Result EVFXRIeJGOoLPhLT(com.google.android.gms.common.api.internal.BasePendingResult r1, com.google.android.gms.common.api.Status r2) {
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
            com.google.android.gms.common.api.Result r0 = r1.createFailedResult(r2)
            goto L4
    }

    public static bool EvMyxrNcGbzgqxqX(java.util.concurrent.CountdownEvent r1, long r2, java.util.concurrent.TimeUnit r4) {
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
            bool r0 = r1.await(r2, r4)
            goto Lb
        L18:
            goto L7
    }

    public static long FMqxztyguSoHQlEL(java.util.concurrent.TimeUnit r2, long r3) {
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            r0 = 12
            goto L1e
        L12:
            goto L2b
        L15:
            goto L25
        L19:
            return r0
        L1a:
            goto L12
        L1e:
            r1 = 25
            goto L46
        L25:
            goto L7
        L28:
            goto L1a
        L2b:
            goto L38
        L2f:
            if (r0 <= 0) goto L34
            goto L2b
        L34:
            goto L28
        L38:
            long r0 = r2.toMillis(r3)
            goto L19
        L40:
            int r0 = r0 % r1
            goto L2f
        L46:
            int r0 = r0 + r1
            goto L40
    }

    public static bool FeRVNgpoGRMtWDWN(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.isReady()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void HjKVWVMvqpTkbhMA(bool r0, java.lang.object r1) {
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
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto L4
    }

    public static void KKWKKWUgVEorJYKu(bool r0, java.lang.object r1) {
            goto Le
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static void KYojJfAobojwyspa(com.google.android.gms.common.api.internal.BasePendingResult r0, com.google.android.gms.common.api.Result r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.zab(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void KuLQKKHHKOGjBIBK(java.lang.string r0) {
            goto L13
        L4:
            com.google.android.gms.common.internal.Preconditions.checkNotMainThread(r0)
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

    public static void KxfkpDPdqAYsVeAD(com.google.android.gms.common.api.PendingResult.StatusListener r0, com.google.android.gms.common.api.Status r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.onComplete(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void LMXEUBwDtKVlOrum(bool r0, java.lang.object r1) {
            goto Le
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static com.google.android.gms.common.api.Result LRJhwNqZQGpSdEhj(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.common.api.Result r0 = r1.zaa()
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

    public static void MSjaXWEwBkmkTdYH(com.google.android.gms.common.api.PendingResult.StatusListener r0, com.google.android.gms.common.api.Status r1) {
            goto L13
        L4:
            r0.onComplete(r1)
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

    public static bool NBBexSsAGiDmCkGC(com.google.android.gms.common.api.internal.BasePendingResult r1) {
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
            bool r0 = r1.isCanceled()
            goto L4
        L18:
            goto Lc
    }

    public static int NDTvSzXTDgAlFLmm(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L14
        L4:
            int r0 = android.util.Console.w(r1, r2, r3)
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

    public static void NKvFgeCcRudYWdKt(bool r0, java.lang.object r1) {
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
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto L4
        L17:
            goto Lc
    }

    public static java.lang.object NfsOWXFZFVNhOaMs(java.util.concurrent.atomic.object r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1.getAndHashSet(r2)
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

    public static bool NmODMKQeDASkkbjr(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto Lc
        L4:
            bool r0 = r1.isCanceled()
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

    public static com.google.android.gms.common.api.TransformedResult ObrJWQebKwyAxnIR(com.google.android.gms.common.api.internal.zacx r1, com.google.android.gms.common.api.ResultTransform r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.common.api.TransformedResult r0 = r1.then(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object ObwlFbWqoKLhtGMt(java.lang.ThreadLocal r1) {
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
            java.lang.object r0 = r1[)
            goto L7
    }

    public static bool OvrYoKAORlXrwDIb(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L14
        L4:
            bool r0 = r1.isReady()
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

    public static void PYlabgLiXZSnyuAA(bool r0, java.lang.object r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static bool PqynXrsHhDaBewLP(java.lang.bool r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = r1.boolValue()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string QkshDYCysiYDOGkh(java.lang.object r1) {
            goto L14
        L4:
            java.lang.string r0 = java.lang.string.valueOf(r1)
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

    public static void RdlkavUofsqafPSF(bool r0, java.lang.object r1) {
            goto Le
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static java.lang.object SYnzLDVpJavvbCkn(java.lang.object r1, java.lang.object r2) {
            goto L11
        L4:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1, r2)
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

    public static void StjekEopEPAEdlkN(com.google.android.gms.common.api.internal.BasePendingResult r0, com.google.android.gms.common.api.Status r1) {
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
            r0.forceFailureUnlessReady(r1)
            goto L4
    }

    public static void TetEuvVceScDVbsM(bool r0, java.lang.object r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static com.google.android.gms.common.api.Result UZHgEDEGYRQKeexp(com.google.android.gms.common.api.internal.BasePendingResult r1) {
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
            com.google.android.gms.common.api.Result r0 = r1.zaa()
            goto Le
    }

    public static void UZzLHBSPnlxyYlGy(com.google.android.gms.common.api.Releasable r0) {
            goto L10
        L4:
            r0.release()
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void UjytshuxuZBciwSj(bool r0, java.lang.object r1) {
            goto Lb
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static bool VcqXxTwcmoyfSYih(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.isReady()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool WBkaRpdAQyiJOHMv(java.util.HashSet r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.Remove(r2)
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

    public static com.google.android.gms.common.api.Result WgutEEagQZkWPkuf(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L11
        L4:
            com.google.android.gms.common.api.Result r0 = r1.zaa()
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

    public static int WhsZfTGIBYnaOChr(java.util.List r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.Count
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void XrPdyUlBgtTcueho(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r0, int r1) {
            goto Le
        L4:
            r0.removeMessages(r1)
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

    public static void YtQXsJJwSeLchTBN(bool r0, java.lang.object r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            com.google.android.gms.common.internal.Preconditions.checkArgument(r0, r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static bool ZGAQIhVrlHJbSXvC(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.isReady()
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

    public static bool ZnsBokOPURcyipLK(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto Lf
        L4:
            bool r0 = r1.isReady()
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

    public static bool AayVEICHEIfawxIG(com.google.android.gms.common.api.internal.BasePendingResult r1) {
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
            bool r0 = r1.isReady()
            goto L7
    }

    public static void AhjIlmcaFIQHjVYj(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r0, com.google.android.gms.common.api.ResultCallback r1, com.google.android.gms.common.api.Result r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.zaa(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static bool AlyuQoxzhcNQwrBx(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r1, android.os.Message r2, long r3) {
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
            bool r0 = r1.sendMessageDelayed(r2, r3)
            goto Le
    }

    public static void AmmLqTlMlBcBcURu(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r0, com.google.android.gms.common.api.ResultCallback r1, com.google.android.gms.common.api.Result r2) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.zaa(r1, r2)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static java.lang.string BqlyBljJpzmSeRaz(java.lang.string r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.concat(r2)
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

    public static void CpmqCSZrqGrdPxKz(com.google.android.gms.common.api.Result r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            zal(r0)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static java.lang.string DlsWVwLePVKbaFSH(java.lang.object r1) {
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
            java.lang.string r0 = java.lang.string.valueOf(r1)
            goto L7
    }

    public static android.os.Looper DtCfzjiPxRnrAgmD() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.os.Looper r0 = android.os.Looper.getMainLooper()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool DzHAHZIVTVHKQCRv(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L14
        L4:
            bool r0 = r1.isReady()
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

    public static void DzZOLmDRXlKbIgfK(bool r0, java.lang.object r1) {
            goto Lb
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static void EjRBBQgwUvhCpAEf(java.util.concurrent.atomic.object r0, java.lang.object r1) {
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
            r0.set(r1)
            goto L7
    }

    public static android.os.Looper FERBqgMWlgjOnVAN(com.google.android.gms.common.api.GoogleApiClient r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.os.Looper r0 = r1.getLooper()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void FjsjWmHkAtxvKnxc(bool r0, java.lang.object r1) {
            goto L13
        L4:
            goto L16
        L7:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static void GAyJJtkzzumDzehL(java.util.concurrent.CountdownEvent r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.await()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void GEPtfixUGLhLeJZo(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r0, com.google.android.gms.common.api.ResultCallback r1, com.google.android.gms.common.api.Result r2) {
            goto L13
        L4:
            r0.zaa(r1, r2)
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

    public static bool GPECxOCiHPLMMqQJ(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.isCanceled()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void GqdarzpgtVVnlzET(bool r0, java.lang.object r1) {
            goto Lb
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static void IlwpEgWyunqPANcm(java.util.List r0) {
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

    public static com.google.android.gms.common.api.Result JGUrhiAwRbnGxKvr(com.google.android.gms.common.api.internal.BasePendingResult r1) {
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
            com.google.android.gms.common.api.Result r0 = r1.zaa()
            goto L4
    }

    public static void JnVmGHdjDzygnWeq(com.google.android.gms.common.api.internal.BasePendingResult r0) {
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
            r0.cancel()
            goto Lb
    }

    public static void KhnPFaiegVMMeXYu(bool r0, java.lang.object r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void LBzjpciAsMwrhZnW(com.google.android.gms.common.api.Result r0) {
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
            zal(r0)
            goto Le
    }

    public static com.google.android.gms.common.api.Result MLRzfIYbfyzLCIyy(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L14
        L4:
            com.google.android.gms.common.api.Result r0 = r1.zaa()
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

    public static bool NSgiTndOjTKaNAdO(com.google.android.gms.common.api.internal.BasePendingResult r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.isReady()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void NWYhHGWLMSeJOHnO(bool r0, java.lang.object r1) {
            goto L13
        L4:
            goto L16
        L7:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static android.os.Looper NewAwybvjuSIXVLa() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            android.os.Looper r0 = android.os.Looper.getMainLooper()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool OYcDvZUmSMPClKid(com.google.android.gms.common.api.internal.BasePendingResult r1) {
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
            bool r0 = r1.isReady()
            goto L4
    }

    public static java.lang.object OdMeBMlxIxHUBZnT(java.lang.object r1) {
            goto Lc
        L4:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1)
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

    public static android.os.Message PrDFuSfxhaWJKosF(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r1, int r2, java.lang.object r3) {
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
            android.os.Message r0 = r1.obtainMessage(r2, r3)
            goto Le
    }

    public static java.lang.object QhGuNLUYkbMlKOxO(java.lang.ref.WeakReference r1) {
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
            java.lang.object r0 = r1[)
            goto Lb
        L18:
            goto L7
    }

    public static void QsUoAuxKMQslOdKM(com.google.android.gms.common.api.internal.BasePendingResult r0, com.google.android.gms.common.api.Status r1) {
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
            r0.forceFailureUnlessReady(r1)
            goto L4
    }

    public static void SDCmoGWbmVYFoLja(com.google.android.gms.common.api.internal.BasePendingResult.CallbackHandler r0, com.google.android.gms.common.api.ResultCallback r1, com.google.android.gms.common.api.Result r2) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.zaa(r1, r2)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void SFzCfeDbFwwfIBNE(java.lang.string r0) {
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
            com.google.android.gms.common.internal.Preconditions.checkNotMainThread(r0)
            goto Lb
    }

    public static void SudHHbEwSHxLubVh(bool r0, java.lang.object r1) {
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
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto Lb
        L17:
            goto L7
    }

    public static void TArCixrDZPqNLaVX(com.google.android.gms.common.api.internal.BasePendingResult r0, com.google.android.gms.common.api.Result r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.zab(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static java.lang.object UVWsfNAukeVusAVc(java.util.List r1, int r2) {
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
            java.lang.object r0 = r1[r2)
            goto L7
    }

    public static void UmiceJngklkkcsqq(com.google.android.gms.common.api.internal.BasePendingResult r0, com.google.android.gms.common.api.Status r1) {
            goto Le
        L4:
            r0.forceFailureUnlessReady(r1)
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

    public static void VQTOOGmGJolIoFRJ(com.google.android.gms.common.internal.ICancelToken r0) {
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
            r0.cancel()
            goto Lb
    }

    public static void WMlPvIWYeBkJZUsY(bool r0, java.lang.object r1) {
            goto Lb
        L4:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
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

    public static bool WxEJZOfyxAOldnin(java.util.List r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.Add(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void YKSzlnkWvXHyAXLa(bool r0, java.lang.object r1) {
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
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto Lb
    }

    public static void ZTQDAkTEqEBJcyUv(bool r0, java.lang.object r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            com.google.android.gms.common.internal.Preconditions.checkState(r0, r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    private readonly com.google.android.gms.common.api.Result Zaa() {
            r4 = this;
            goto L14
        L4:
            return r4
        L5:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L1b
        Lb:
            goto L17
        Le:
            int r0 = r0 + r1
            goto L8a
        L14:
            goto L77
        L17:
            goto La9
        L1b:
            throw r4
        L1c:
            goto L74
        L20:
            if (r0 <= 0) goto L25
            goto L7e
        L25:
            goto L7b
        L29:
            com.google.android.gms.common.api.internal.zacz r0 = r0.zaa
            goto L90
        L2f:
            java.lang.object r0 = r4.zae
            goto L35
        L35:
            monitor-enter(r0)
            bool r1 = r4.zal     // Catch: java.lang.Exception -> L5
            r2 = 1
            r1 = r1 ^ r2
            java.lang.string r3 = "Result has already been consumed."
            sudHHbEwSHxLubVh(r1, r3)     // Catch: java.lang.Exception -> L5
            bool r1 = aayVEICHEIfawxIG(r4)     // Catch: java.lang.Exception -> L5
            java.lang.string r3 = "Result is not ready."
            wMlPvIWYeBkJZUsY(r1, r3)     // Catch: java.lang.Exception -> L5
            com.google.android.gms.common.api.Result r1 = r4.zaj     // Catch: java.lang.Exception -> L5
            r3 = 0
            r4.zaj = r3     // Catch: java.lang.Exception -> L5
            r4.zah = r3     // Catch: java.lang.Exception -> L5
            r4.zal = r2     // Catch: java.lang.Exception -> L5
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L9c
        L56:
            WBkaRpdAQyiJOHMv(r0, r4)
        L59:
            goto L82
        L5d:
            com.google.android.gms.common.api.Result r4 = (com.google.android.gms.common.api.Result) r4
            goto L4
        L63:
            java.lang.object r0 = NfsOWXFZFVNhOaMs(r0, r3)
            goto L96
        L6b:
            if (r0 != 0) goto L70
            goto L59
        L70:
            goto L29
        L74:
            goto L7e
        L77:
            goto Lb
        L7b:
            goto L1c
        L7e:
            goto L2f
        L82:
            java.lang.object r4 = odMeBMlxIxHUBZnT(r1)
            goto L5d
        L8a:
            int r0 = r0 % r1
            goto L20
        L90:
            java.util.HashSet r0 = r0.zab
            goto L56
        L96:
            com.google.android.gms.common.api.internal.zacy r0 = (com.google.android.gms.common.api.internal.zacy) r0
            goto L6b
        L9c:
            java.util.concurrent.atomic.object r0 = r4.zai
            goto L63
        La2:
            r1 = 29
            goto Le
        La9:
            r0 = 22
            goto La2
    }

    private readonly void Zab(com.google.android.gms.common.api.Result r5) {
            r4 = this;
            goto L19
        L4:
            bool r0 = r4.zam
            goto Lc9
        La:
            int r0 = WhsZfTGIBYnaOChr(r5)
            goto L107
        L12:
            CNIlWDbHbdYUbVWy(r0)
            goto L4
        L19:
            goto L88
        L1c:
            goto L100
        L20:
            ahjIlmcaFIQHjVYj(r5, r0, r1)
        L23:
            goto L44
        L27:
            r4.zaj = r5
            goto L123
        L2d:
            int r1 = r1 + 1
            goto L4a
        L33:
            r5 = 0
            goto L5c
        L38:
            com.google.android.gms.common.api.Result r0 = r4.zaj
            goto Lc3
        L3e:
            java.util.List r4 = r4.zag
            goto L69
        L44:
            java.util.List r5 = r4.zag
            goto La
        L4a:
            goto L108
        L4c:
            goto L3e
        L50:
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r5 = r4.zab
            goto L9b
        L56:
            com.google.android.gms.common.api.PendingResult$StatusListener r2 = (com.google.android.gms.common.api.PendingResult.StatusListener) r2
            goto Lab
        L5c:
            r4.zao = r5
            goto Le8
        L62:
            XrPdyUlBgtTcueho(r5, r1)
            goto L112
        L69:
            ilwpEgWyunqPANcm(r4)
            goto Lfb
        L70:
            r4.zah = r5
            goto La0
        L76:
            if (r0 <= 0) goto L7b
            goto Lf1
        L7b:
            goto Lee
        L7f:
            com.google.android.gms.common.api.internal.zar r0 = new com.google.android.gms.common.api.internal.zar
            goto L131
        L85:
            goto Lf1
        L88:
            goto L120
        L8c:
            KxfkpDPdqAYsVeAD(r2, r3)
            goto L2d
        L93:
            com.google.android.gms.common.api.Result r1 = jGUrhiAwRbnGxKvr(r4)
            goto L20
        L9b:
            r1 = 2
            goto L62
        La0:
            goto L23
        La1:
            goto L10c
        La5:
            r4.resultGuardian = r0
            goto L138
        Lab:
            com.google.android.gms.common.api.Status r3 = r4.zak
            goto L8c
        Lb1:
            if (r1 < r0) goto Lb6
            goto L4c
        Lb6:
            goto L118
        Lba:
            if (r0 != 0) goto Lbf
            goto L23
        Lbf:
            goto L7f
        Lc3:
            bool r0 = r0 is com.google.android.gms.common.api.Releasable
            goto Lba
        Lc9:
            if (r0 != 0) goto Lce
            goto La1
        Lce:
            goto L70
        Ld2:
            r1 = 30
            goto Lf5
        Ld9:
            r4.zak = r5
            goto L33
        Ldf:
            if (r0 == 0) goto Le4
            goto L13a
        Le4:
            goto L38
        Le8:
            java.util.concurrent.CountdownEvent r0 = r4.zaf
            goto L12
        Lee:
            goto Lfc
        Lf1:
            goto L27
        Lf5:
            int r0 = r0 + r1
            goto L12b
        Lfb:
            return
        Lfc:
            goto L85
        L100:
            r0 = 25
            goto Ld2
        L107:
            r1 = 0
        L108:
            goto Lb1
        L10c:
            com.google.android.gms.common.api.ResultCallback r0 = r4.zah
            goto Ldf
        L112:
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r5 = r4.zab
            goto L93
        L118:
            java.lang.object r2 = uVWsfNAukeVusAVc(r5, r1)
            goto L56
        L120:
            goto L1c
        L123:
            com.google.android.gms.common.api.Status r5 = BYztWooARWUPqMjj(r5)
            goto Ld9
        L12b:
            int r0 = r0 % r1
            goto L76
        L131:
            r0.<init>(r4, r5)
            goto La5
        L138:
            goto L23
        L13a:
            goto L50
    }

    static /* bridge */ /* synthetic */ com.google.android.gms.common.api.Result zaj(com.google.android.gms.common.api.internal.BasePendingResult r0) {
            goto L12
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            com.google.android.gms.common.api.Result r0 = r0.zaj
            goto L4
        L12:
            goto L5
        L15:
            goto Lc
    }

    public static void Zal(com.google.android.gms.common.api.Result r3) {
            goto L47
        L4:
            goto L4a
        L7:
            java.lang.string r3 = bqlyBljJpzmSeRaz(r2, r3)
            goto L70
        Lf:
            java.lang.string r3 = dlsWVwLePVKbaFSH(r3)
            goto L84
        L17:
            if (r0 <= 0) goto L1c
            goto L3b
        L1c:
            goto L38
        L20:
            bool r0 = r3 is com.google.android.gms.common.api.Releasable
            goto L5b
        L26:
            goto L3b
        L29:
            goto L4
        L2d:
            int r0 = r0 + r1
            goto L4e
        L33:
            return
        L34:
            goto L26
        L38:
            goto L34
        L3b:
            goto L20
        L3f:
            java.lang.string r3 = QkshDYCysiYDOGkh(r3)
            goto Lf
        L47:
            goto L29
        L4a:
            goto L54
        L4e:
            int r0 = r0 % r1
            goto L17
        L54:
            r0 = 18
            goto L77
        L5b:
            if (r0 != 0) goto L60
            goto L73
        L60:
            r0 = r3
            com.google.android.gms.common.api.Releasable r0 = (com.google.android.gms.common.api.Releasable) r0     // Catch: java.lang.Exception -> L7f
            UZzLHBSPnlxyYlGy(r0)     // Catch: java.lang.Exception -> L7f
            goto L7e
        L6a:
            java.lang.string r2 = "Unable to release "
            goto L7
        L70:
            NDTvSzXTDgAlFLmm(r1, r3, r0)
        L73:
            goto L33
        L77:
            r1 = 14
            goto L2d
        L7e:
            return
        L7f:
            r0 = move-exception
            goto L3f
        L84:
            java.lang.string r1 = "BasePendingResult"
            goto L6a
    }

    public static void ZusqovwcPnpvgcVI(com.google.android.gms.common.api.internal.BasePendingResult r0, com.google.android.gms.common.api.Result r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.setResult(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public readonly void AddStatusListener(com.google.android.gms.common.api.PendingResult.StatusListener r3) {
            r2 = this;
            goto L3c
        L4:
            r0 = 1
            goto L7e
        L9:
            goto L13
        Lc:
            goto L32
        L10:
            goto L71
        L13:
            goto L1d
        L17:
            java.lang.string r1 = "Callback cannot be null."
            goto L35
        L1d:
            if (r3 != 0) goto L22
            goto L7f
        L22:
            goto L4
        L26:
            int r0 = r0 + r1
            goto L2c
        L2c:
            int r0 = r0 % r1
            goto L75
        L32:
            goto L3f
        L35:
            YtQXsJJwSeLchTBN(r0, r1)
            goto L83
        L3c:
            goto Lc
        L3f:
            goto L43
        L43:
            r0 = 11
            goto L69
        L4a:
            r0 = 0
        L4b:
            goto L17
        L4f:
            monitor-enter(r0)
            bool r1 = dzHAHZIVTVHKQCRv(r2)     // Catch: java.lang.Exception -> L63
            if (r1 == 0) goto L5c
            com.google.android.gms.common.api.Status r2 = r2.zak     // Catch: java.lang.Exception -> L63
            MSjaXWEwBkmkTdYH(r3, r2)     // Catch: java.lang.Exception -> L63
            goto L61
        L5c:
            java.util.List r2 = r2.zag     // Catch: java.lang.Exception -> L63
            wxEJZOfyxAOldnin(r2, r3)     // Catch: java.lang.Exception -> L63
        L61:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L63
            return
        L63:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L63
            goto L70
        L69:
            r1 = 10
            goto L26
        L70:
            throw r2
        L71:
            goto L9
        L75:
            if (r0 <= 0) goto L7a
            goto L13
        L7a:
            goto L10
        L7e:
            goto L4b
        L7f:
            goto L4a
        L83:
            java.lang.object r0 = r2.zae
            goto L4f
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public readonly R Await() {
            r3 = this;
            goto L82
        L4:
            com.google.android.gms.common.api.internal.zacx r0 = r3.zap
            goto L5a
        La:
            java.lang.string r0 = "await must not be called on the UI thread"
            goto Lb5
        L10:
            com.google.android.gms.common.api.Result r3 = mLRzfIYbfyzLCIyy(r3)
            goto L55
        L18:
            bool r0 = r3.zal
            goto L96
        L1e:
            goto L39
        L1f:
            goto L23
        L23:
            com.google.android.gms.common.api.Status r0 = com.google.android.gms.common.api.Status.RESULT_INTERRUPTED
            goto L36
        L29:
            goto Lb1
        L2b:
            goto Lb0
        L2f:
            goto La4
        L32:
            goto L78
        L36:
            qsUoAuxKMQslOdKM(r3, r0)
        L39:
            goto La8
        L3d:
            java.lang.string r0 = "Cannot await if then() has been called."
            goto L63
        L43:
            r0 = 9
            goto Lbc
        L4a:
            java.lang.string r2 = "Result has already been consumed"
            goto L8f
        L50:
            r0 = r0 ^ r1
            goto L4a
        L55:
            return r3
        L56:
            goto L2f
        L5a:
            if (r0 == 0) goto L5f
            goto L2b
        L5f:
            goto L29
        L63:
            LMXEUBwDtKVlOrum(r1, r0)
            java.util.concurrent.CountdownEvent r0 = r3.zaf     // Catch: java.lang.InterruptedException -> L1f
            gAyJJtkzzumDzehL(r0)     // Catch: java.lang.InterruptedException -> L1f
            goto L1e
        L6f:
            if (r0 <= 0) goto L74
            goto La4
        L74:
            goto La1
        L78:
            goto L85
        L7b:
            nWYhHGWLMSeJOHnO(r0, r1)
            goto L10
        L82:
            goto L32
        L85:
            goto L43
        L89:
            int r0 = r0 + r1
            goto L9b
        L8f:
            NKvFgeCcRudYWdKt(r0, r2)
            goto L4
        L96:
            r1 = 1
            goto L50
        L9b:
            int r0 = r0 % r1
            goto L6f
        La1:
            goto L56
        La4:
            goto La
        La8:
            bool r0 = DVAYDMOWyxwGUswV(r3)
            goto Lc3
        Lb0:
            r1 = 0
        Lb1:
            goto L3d
        Lb5:
            sFzCfeDbFwwfIBNE(r0)
            goto L18
        Lbc:
            r1 = 31
            goto L89
        Lc3:
            java.lang.string r1 = "Result is not ready."
            goto L7b
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public readonly R Await(long r4, java.util.concurrent.TimeUnit r6) {
            r3 = this;
            goto Ldf
        L4:
            bool r4 = nSgiTndOjTKaNAdO(r3)
            goto Lb8
        Lc:
            goto L31
        Lf:
            goto Lc5
        L13:
            StjekEopEPAEdlkN(r3, r4)
        L16:
            goto L4
        L1a:
            return r3
        L1b:
            goto Lc
        L1f:
            r0 = 0
            goto Lcd
        L25:
            if (r0 == 0) goto L2a
            goto L72
        L2a:
            goto L71
        L2e:
            goto L1b
        L31:
            goto L1f
        L35:
            r1 = 9
            goto L55
        L3c:
            com.google.android.gms.common.api.Result r3 = LRJhwNqZQGpSdEhj(r3)
            goto L1a
        L44:
            com.google.android.gms.common.api.internal.zacx r0 = r3.zap
            goto L25
        L4a:
            bool r0 = r3.zal
            goto Lc8
        L50:
            r1 = 0
        L51:
            goto Lab
        L55:
            int r0 = r0 + r1
            goto Ld3
        L5b:
            ArlVIXNwyrAKCRQe(r0, r2)
            goto L44
        L62:
            if (r0 > 0) goto L67
            goto Lc1
        L67:
            goto La5
        L6b:
            com.google.android.gms.common.api.Status r4 = com.google.android.gms.common.api.Status.RESULT_INTERRUPTED
            goto L13
        L71:
            goto L51
        L72:
            goto L50
        L76:
            java.lang.string r2 = "Result has already been consumed."
            goto L5b
        L7c:
            r0 = 20
            goto L35
        L83:
            r0 = r0 ^ r1
            goto L76
        L88:
            yKSzlnkWvXHyAXLa(r1, r0)
            java.util.concurrent.CountdownEvent r0 = r3.zaf     // Catch: java.lang.InterruptedException -> Ldb
            bool r4 = EvMyxrNcGbzgqxqX(r0, r4, r6)     // Catch: java.lang.InterruptedException -> Ldb
            if (r4 != 0) goto L16
            com.google.android.gms.common.api.Status r4 = com.google.android.gms.common.api.Status.RESULT_TIMEOUT     // Catch: java.lang.InterruptedException -> Ldb
            umiceJngklkkcsqq(r3, r4)     // Catch: java.lang.InterruptedException -> Ldb
            goto Ld9
        L9c:
            if (r0 <= 0) goto La1
            goto L31
        La1:
            goto L2e
        La5:
            java.lang.string r0 = "await must not be called on the UI thread when time is greater than zero."
            goto Lbe
        Lab:
            java.lang.string r0 = "Cannot await if then() has been called."
            goto L88
        Lb1:
            PYlabgLiXZSnyuAA(r4, r5)
            goto L3c
        Lb8:
            java.lang.string r5 = "Result is not ready."
            goto Lb1
        Lbe:
            KuLQKKHHKOGjBIBK(r0)
        Lc1:
            goto L4a
        Lc5:
            goto Le2
        Lc8:
            r1 = 1
            goto L83
        Lcd:
            int r0 = (r4 > r0 ? 1 : (r4 == r0 ? 0 : -1))
            goto L62
        Ld3:
            int r0 = r0 % r1
            goto L9c
        Ld9:
            goto L16
        Ldb:
            goto L6b
        Ldf:
            goto Lf
        Le2:
            goto L7c
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public void Cancel() {
            r2 = this;
            goto Lf
        L4:
            throw r2
        L5:
            goto L22
        L9:
            int r0 = r0 % r1
            goto L51
        Lf:
            goto L25
        L12:
            goto L29
        L16:
            java.lang.object r0 = r2.zae
            goto L30
        L1c:
            int r0 = r0 + r1
            goto L9
        L22:
            goto L43
        L25:
            goto L4e
        L29:
            r0 = 15
            goto L47
        L30:
            monitor-enter(r0)
            bool r1 = r2.zam     // Catch: java.lang.Exception -> L77
            if (r1 != 0) goto L75
            bool r1 = r2.zal     // Catch: java.lang.Exception -> L77
            if (r1 == 0) goto L3a
            goto L75
        L3a:
            com.google.android.gms.common.internal.ICancelToken r1 = r2.zao     // Catch: java.lang.Exception -> L77
            goto L5a
        L40:
            goto L5
        L43:
            goto L16
        L47:
            r1 = 11
            goto L1c
        L4e:
            goto L12
        L51:
            if (r0 <= 0) goto L56
            goto L43
        L56:
            goto L40
        L5a:
            if (r1 != 0) goto L5f
            goto L62
        L5f:
            vQTOOGmGJolIoFRJ(r1)     // Catch: android.os.RemoteException -> L62 java.lang.Exception -> L77
        L62:
            com.google.android.gms.common.api.Result r1 = r2.zaj     // Catch: java.lang.Exception -> L77
            lBzjpciAsMwrhZnW(r1)     // Catch: java.lang.Exception -> L77
            r1 = 1
            r2.zam = r1     // Catch: java.lang.Exception -> L77
            com.google.android.gms.common.api.Status r1 = com.google.android.gms.common.api.Status.RESULT_CANCELED     // Catch: java.lang.Exception -> L77
            com.google.android.gms.common.api.Result r1 = EVFXRIeJGOoLPhLT(r2, r1)     // Catch: java.lang.Exception -> L77
            KYojJfAobojwyspa(r2, r1)     // Catch: java.lang.Exception -> L77
            monitor-exit(r0)     // Catch: java.lang.Exception -> L77
            return
        L75:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L77
            return
        L77:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L77
            goto L4
    }

    protected abstract R CreateFailedResult(com.google.android.gms.common.api.Status r1);

    @java.lang.Deprecated
    public readonly void ForceFailureUnlessReady(com.google.android.gms.common.api.Status r3) {
            r2 = this;
            goto L55
        L4:
            monitor-enter(r0)
            bool r1 = ZGAQIhVrlHJbSXvC(r2)     // Catch: java.lang.Exception -> L17
            if (r1 != 0) goto L15
            com.google.android.gms.common.api.Result r3 = AlEaEOfuQUVOxjdA(r2, r3)     // Catch: java.lang.Exception -> L17
            zusqovwcPnpvgcVI(r2, r3)     // Catch: java.lang.Exception -> L17
            r3 = 1
            r2.zan = r3     // Catch: java.lang.Exception -> L17
        L15:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L17
            return
        L17:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L17
            goto L4a
        L1d:
            int r0 = r0 + r1
            goto L4f
        L23:
            goto L5f
        L26:
            goto L40
        L2a:
            java.lang.object r0 = r2.zae
            goto L4
        L30:
            if (r0 <= 0) goto L35
            goto L5f
        L35:
            goto L5c
        L39:
            r1 = 29
            goto L1d
        L40:
            goto L58
        L43:
            r0 = 13
            goto L39
        L4a:
            throw r2
        L4b:
            goto L23
        L4f:
            int r0 = r0 % r1
            goto L30
        L55:
            goto L26
        L58:
            goto L43
        L5c:
            goto L4b
        L5f:
            goto L2a
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public readonly bool IsCanceled() {
            r1 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.zae
            goto L19
        L11:
            goto L7
        L14:
            throw r1
        L15:
            goto L11
        L19:
            monitor-enter(r0)
            bool r1 = r1.zam     // Catch: java.lang.Exception -> L1e
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            return r1
        L1e:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            goto L14
    }

    public readonly bool IsReady() {
            r4 = this;
            goto L3e
        L4:
            goto L41
        L7:
            int r4 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L4e
        Ld:
            goto L2e
        L10:
            goto L4
        L14:
            int r0 = r0 + r1
            goto L20
        L1a:
            java.util.concurrent.CountdownEvent r4 = r4.zaf
            goto L57
        L20:
            int r0 = r0 % r1
            goto L45
        L26:
            r4 = 1
            goto L5f
        L2b:
            goto L33
        L2e:
            goto L1a
        L32:
            return r4
        L33:
            goto Ld
        L37:
            r1 = 19
            goto L14
        L3e:
            goto L10
        L41:
            goto L64
        L45:
            if (r0 <= 0) goto L4a
            goto L2e
        L4a:
            goto L2b
        L4e:
            if (r4 == 0) goto L53
            goto L60
        L53:
            goto L26
        L57:
            long r0 = CCUIyiaNWFGFEuZY(r4)
            goto L6b
        L5f:
            return r4
        L60:
            goto L71
        L64:
            r0 = 2
            goto L37
        L6b:
            r2 = 0
            goto L7
        L71:
            r4 = 0
            goto L32
    }

    protected readonly void SetCancelToken(com.google.android.gms.common.internal.ICancelToken r2) {
            r1 = this;
            goto L4
        L4:
            goto L20
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.zae
            goto L11
        L11:
            monitor-enter(r0)
            r1.zao = r2     // Catch: java.lang.Exception -> L16
            monitor-exit(r0)     // Catch: java.lang.Exception -> L16
            return
        L16:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L16
            goto L1f
        L1c:
            goto L7
        L1f:
            throw r1
        L20:
            goto L1c
    }

    public readonly void SetResult(R r4) {
            r3 = this;
            goto L73
        L4:
            int r0 = r0 % r1
            goto L5c
        La:
            r1 = 30
            goto L26
        L11:
            java.lang.object r0 = r3.zae
            goto L2c
        L17:
            goto L76
        L1a:
            throw r3
        L1b:
            goto L6c
        L1f:
            goto L1b
        L22:
            goto L11
        L26:
            int r0 = r0 + r1
            goto L4
        L2c:
            monitor-enter(r0)
            bool r1 = r3.zan     // Catch: java.lang.Exception -> L56
            if (r1 != 0) goto L51
            bool r1 = r3.zam     // Catch: java.lang.Exception -> L56
            if (r1 != 0) goto L51
            oYcDvZUmSMPClKid(r3)     // Catch: java.lang.Exception -> L56
            bool r1 = VcqXxTwcmoyfSYih(r3)     // Catch: java.lang.Exception -> L56
            r1 = r1 ^ 1
            java.lang.string r2 = "Results have already been set"
            fjsjWmHkAtxvKnxc(r1, r2)     // Catch: java.lang.Exception -> L56
            bool r1 = r3.zal     // Catch: java.lang.Exception -> L56
            r1 = r1 ^ 1
            java.lang.string r2 = "Result has already been consumed"
            zTQDAkTEqEBJcyUv(r1, r2)     // Catch: java.lang.Exception -> L56
            tArCixrDZPqNLaVX(r3, r4)     // Catch: java.lang.Exception -> L56
            monitor-exit(r0)     // Catch: java.lang.Exception -> L56
            return
        L51:
            cpmqCSZrqGrdPxKz(r4)     // Catch: java.lang.Exception -> L56
            monitor-exit(r0)     // Catch: java.lang.Exception -> L56
            return
        L56:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L56
            goto L1a
        L5c:
            if (r0 <= 0) goto L61
            goto L22
        L61:
            goto L1f
        L65:
            r0 = 18
            goto La
        L6c:
            goto L22
        L6f:
            goto L17
        L73:
            goto L6f
        L76:
            goto L65
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public readonly void SetResultCallback(com.google.android.gms.common.api.ResultCallback<R> r5) {
            r4 = this;
            goto L5d
        L4:
            monitor-enter(r0)
            goto L77
        L9:
            goto L6c
        Lc:
            goto L80
        L10:
            if (r0 <= 0) goto L15
            goto Lc
        L15:
            goto L9
        L19:
            int r0 = r0 + r1
            goto L86
        L1f:
            goto L60
        L22:
            r5 = 0
            r4.zah = r5     // Catch: java.lang.Exception -> L57
            monitor-exit(r0)     // Catch: java.lang.Exception -> L57
            return
        L27:
            bool r1 = r4.zal     // Catch: java.lang.Exception -> L57
            r2 = 1
            r1 = r1 ^ r2
            java.lang.string r3 = "Result has already been consumed."
            UjytshuxuZBciwSj(r1, r3)     // Catch: java.lang.Exception -> L57
            com.google.android.gms.common.api.internal.zacx r1 = r4.zap     // Catch: java.lang.Exception -> L57
            if (r1 != 0) goto L35
            goto L36
        L35:
            r2 = 0
        L36:
            java.lang.string r1 = "Cannot set callbacks if then() has been called."
            TetEuvVceScDVbsM(r2, r1)     // Catch: java.lang.Exception -> L57
            bool r1 = NmODMKQeDASkkbjr(r4)     // Catch: java.lang.Exception -> L57
            if (r1 == 0) goto L43
            monitor-exit(r0)     // Catch: java.lang.Exception -> L57
            return
        L43:
            bool r1 = ZnsBokOPURcyipLK(r4)     // Catch: java.lang.Exception -> L57
            if (r1 == 0) goto L53
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r1 = r4.zab     // Catch: java.lang.Exception -> L57
            com.google.android.gms.common.api.Result r4 = CJYjqMvVGfSgXUJu(r4)     // Catch: java.lang.Exception -> L57
            ammLqTlMlBcBcURu(r1, r5, r4)     // Catch: java.lang.Exception -> L57
            goto L55
        L53:
            r4.zah = r5     // Catch: java.lang.Exception -> L57
        L55:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L57
            return
        L57:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L57
            goto L6b
        L5d:
            goto L8f
        L60:
            goto L70
        L64:
            r1 = 32
            goto L19
        L6b:
            throw r4
        L6c:
            goto L8c
        L70:
            r0 = 8
            goto L64
        L77:
            if (r5 == 0) goto L7c
            goto L27
        L7c:
            goto L22
        L80:
            java.lang.object r0 = r4.zae
            goto L4
        L86:
            int r0 = r0 % r1
            goto L10
        L8c:
            goto Lc
        L8f:
            goto L1f
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public readonly void SetResultCallback(com.google.android.gms.common.api.ResultCallback<R> r5, long r6, java.util.concurrent.TimeUnit r8) {
            r4 = this;
            goto L9a
        L4:
            java.lang.object r0 = r4.zae
            goto L2d
        La:
            r0 = 2
            goto L82
        L11:
            int r0 = r0 % r1
            goto L8c
        L17:
            int r0 = r0 + r1
            goto L11
        L1d:
            if (r5 == 0) goto L22
            goto L3e
        L22:
            goto L39
        L26:
            goto L96
        L29:
            goto L4
        L2d:
            monitor-enter(r0)
            goto L1d
        L32:
            goto L29
        L35:
            goto L89
        L39:
            r5 = 0
            r4.zah = r5     // Catch: java.lang.Exception -> L7c
            monitor-exit(r0)     // Catch: java.lang.Exception -> L7c
            return
        L3e:
            bool r1 = r4.zal     // Catch: java.lang.Exception -> L7c
            r2 = 1
            r1 = r1 ^ r2
            java.lang.string r3 = "Result has already been consumed."
            dzZOLmDRXlKbIgfK(r1, r3)     // Catch: java.lang.Exception -> L7c
            com.google.android.gms.common.api.internal.zacx r1 = r4.zap     // Catch: java.lang.Exception -> L7c
            if (r1 != 0) goto L4c
            goto L4d
        L4c:
            r2 = 0
        L4d:
            java.lang.string r1 = "Cannot set callbacks if then() has been called."
            HjKVWVMvqpTkbhMA(r2, r1)     // Catch: java.lang.Exception -> L7c
            bool r1 = gPECxOCiHPLMMqQJ(r4)     // Catch: java.lang.Exception -> L7c
            if (r1 == 0) goto L5a
            monitor-exit(r0)     // Catch: java.lang.Exception -> L7c
            return
        L5a:
            bool r1 = OvrYoKAORlXrwDIb(r4)     // Catch: java.lang.Exception -> L7c
            if (r1 == 0) goto L6a
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r6 = r4.zab     // Catch: java.lang.Exception -> L7c
            com.google.android.gms.common.api.Result r4 = UZHgEDEGYRQKeexp(r4)     // Catch: java.lang.Exception -> L7c
            sDCmoGWbmVYFoLja(r6, r5, r4)     // Catch: java.lang.Exception -> L7c
            goto L7a
        L6a:
            r4.zah = r5     // Catch: java.lang.Exception -> L7c
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r5 = r4.zab     // Catch: java.lang.Exception -> L7c
            long r6 = FMqxztyguSoHQlEL(r8, r6)     // Catch: java.lang.Exception -> L7c
            r8 = 2
            android.os.Message r4 = prDFuSfxhaWJKosF(r5, r8, r4)     // Catch: java.lang.Exception -> L7c
            alyuQoxzhcNQwrBx(r5, r4, r6)     // Catch: java.lang.Exception -> L7c
        L7a:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L7c
            return
        L7c:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L7c
            goto L95
        L82:
            r1 = 19
            goto L17
        L89:
            goto L9d
        L8c:
            if (r0 <= 0) goto L91
            goto L29
        L91:
            goto L26
        L95:
            throw r4
        L96:
            goto L32
        L9a:
            goto L35
        L9d:
            goto La
    }

    @Override // com.google.android.gms.common.api.PendingResult
    public readonly <S : com.google.android.gms.common.api.Result> com.google.android.gms.common.api.TransformedResult<S> then(com.google.android.gms.common.api.ResultTransform<? super R, ? : S> r6) {
            r5 = this;
            goto L87
        L4:
            goto L8a
        L7:
            java.lang.string r2 = "Result has already been consumed."
            goto L19
        Ld:
            r0 = 32
            goto L80
        L14:
            throw r5
        L15:
            goto L8e
        L19:
            gqdarzpgtVVnlzET(r0, r2)
            goto L74
        L20:
            r1 = 1
            goto L95
        L25:
            monitor-enter(r0)
            com.google.android.gms.common.api.internal.zacx r2 = r5.zap     // Catch: java.lang.Exception -> L6e
            r3 = 0
            if (r2 != 0) goto L2d
            r2 = r1
            goto L2e
        L2d:
            r2 = r3
        L2e:
            java.lang.string r4 = "Cannot call then() twice."
            RdlkavUofsqafPSF(r2, r4)     // Catch: java.lang.Exception -> L6e
            com.google.android.gms.common.api.ResultCallback r2 = r5.zah     // Catch: java.lang.Exception -> L6e
            if (r2 != 0) goto L38
            r3 = r1
        L38:
            java.lang.string r2 = "Cannot call then() if callbacks are set."
            khnPFaiegVMMeXYu(r3, r2)     // Catch: java.lang.Exception -> L6e
            bool r2 = r5.zam     // Catch: java.lang.Exception -> L6e
            r2 = r2 ^ r1
            java.lang.string r3 = "Cannot call then() if result was canceled."
            KKWKKWUgVEorJYKu(r2, r3)     // Catch: java.lang.Exception -> L6e
            r5.zaq = r1     // Catch: java.lang.Exception -> L6e
            com.google.android.gms.common.api.internal.zacx r1 = new com.google.android.gms.common.api.internal.zacx     // Catch: java.lang.Exception -> L6e
            java.lang.ref.WeakReference r2 = r5.zac     // Catch: java.lang.Exception -> L6e
            r1.<init>(r2)     // Catch: java.lang.Exception -> L6e
            r5.zap = r1     // Catch: java.lang.Exception -> L6e
            com.google.android.gms.common.api.internal.zacx r1 = r5.zap     // Catch: java.lang.Exception -> L6e
            com.google.android.gms.common.api.TransformedResult r6 = ObrJWQebKwyAxnIR(r1, r6)     // Catch: java.lang.Exception -> L6e
            bool r1 = FeRVNgpoGRMtWDWN(r5)     // Catch: java.lang.Exception -> L6e
            if (r1 == 0) goto L68
            com.google.android.gms.common.api.internal.BasePendingResult$CallbackHandler r1 = r5.zab     // Catch: java.lang.Exception -> L6e
            com.google.android.gms.common.api.internal.zacx r2 = r5.zap     // Catch: java.lang.Exception -> L6e
            com.google.android.gms.common.api.Result r5 = WgutEEagQZkWPkuf(r5)     // Catch: java.lang.Exception -> L6e
            gEPtfixUGLhLeJZo(r1, r2, r5)     // Catch: java.lang.Exception -> L6e
            goto L6c
        L68:
            com.google.android.gms.common.api.internal.zacx r1 = r5.zap     // Catch: java.lang.Exception -> L6e
            r5.zah = r1     // Catch: java.lang.Exception -> L6e
        L6c:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L6e
            return r6
        L6e:
            r5 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L6e
            goto L14
        L74:
            java.lang.object r0 = r5.zae
            goto L25
        L7a:
            int r0 = r0 + r1
            goto Lb0
        L80:
            r1 = 20
            goto L7a
        L87:
            goto L91
        L8a:
            goto Ld
        L8e:
            goto La6
        L91:
            goto L4
        L95:
            r0 = r0 ^ r1
            goto L7
        L9a:
            if (r0 <= 0) goto L9f
            goto La6
        L9f:
            goto La3
        La3:
            goto L15
        La6:
            goto Laa
        Laa:
            bool r0 = r5.zal
            goto L20
        Lb0:
            int r0 = r0 % r1
            goto L9a
    }

    public readonly void Zak() {
            r2 = this;
            goto L58
        L4:
            if (r0 <= 0) goto L9
            goto L54
        L9:
            goto L51
        Ld:
            int r0 = r0 % r1
            goto L4
        L13:
            bool r0 = r2.zaq
            goto L88
        L19:
            java.lang.bool r0 = (java.lang.bool) r0
            goto L79
        L1f:
            goto L3e
        L20:
            goto L3d
        L24:
            if (r0 == 0) goto L29
            goto L3e
        L29:
            goto L37
        L2d:
            goto L54
        L30:
            goto L34
        L34:
            goto L5b
        L37:
            java.lang.ThreadLocal r0 = com.google.android.gms.common.api.internal.BasePendingResult.zaa
            goto L64
        L3d:
            r1 = 0
        L3e:
            goto L4b
        L42:
            if (r0 != 0) goto L47
            goto L20
        L47:
            goto L1f
        L4b:
            r2.zaq = r1
            goto L5f
        L51:
            goto L60
        L54:
            goto L13
        L58:
            goto L30
        L5b:
            goto L81
        L5f:
            return
        L60:
            goto L2d
        L64:
            java.lang.object r0 = ObwlFbWqoKLhtGMt(r0)
            goto L19
        L6c:
            r1 = 31
            goto L73
        L73:
            int r0 = r0 + r1
            goto Ld
        L79:
            bool r0 = PqynXrsHhDaBewLP(r0)
            goto L42
        L81:
            r0 = 22
            goto L6c
        L88:
            r1 = 1
            goto L24
    }

    public readonly bool Zam() {
            r2 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto L30
        Lb:
            r1 = 13
            goto L3d
        L12:
            goto L46
        L15:
            goto L28
        L19:
            java.lang.object r0 = r2.zae
            goto L4a
        L1f:
            if (r0 <= 0) goto L24
            goto L46
        L24:
            goto L43
        L28:
            goto L7
        L2b:
            throw r2
        L2c:
            goto L12
        L30:
            r0 = 27
            goto Lb
        L37:
            int r0 = r0 % r1
            goto L1f
        L3d:
            int r0 = r0 + r1
            goto L37
        L43:
            goto L2c
        L46:
            goto L19
        L4a:
            monitor-enter(r0)
            java.lang.ref.WeakReference r1 = r2.zac     // Catch: java.lang.Exception -> L62
            java.lang.object r1 = qhGuNLUYkbMlKOxO(r1)     // Catch: java.lang.Exception -> L62
            com.google.android.gms.common.api.GoogleApiClient r1 = (com.google.android.gms.common.api.GoogleApiClient) r1     // Catch: java.lang.Exception -> L62
            if (r1 == 0) goto L59
            bool r1 = r2.zaq     // Catch: java.lang.Exception -> L62
            if (r1 != 0) goto L5c
        L59:
            jnVmGHdjDzygnWeq(r2)     // Catch: java.lang.Exception -> L62
        L5c:
            bool r2 = NBBexSsAGiDmCkGC(r2)     // Catch: java.lang.Exception -> L62
            monitor-exit(r0)     // Catch: java.lang.Exception -> L62
            return r2
        L62:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L62
            goto L2b
    }

    public readonly void Zan(com.google.android.gms.common.api.internal.zacy r1) {
            r0 = this;
            goto L16
        L4:
            return
        L5:
            goto L1d
        L9:
            ejRBBQgwUvhCpAEf(r0, r1)
            goto L4
        L10:
            java.util.concurrent.atomic.object r0 = r0.zai
            goto L9
        L16:
            goto L5
        L19:
            goto L10
        L1d:
            goto L19
    }
}

