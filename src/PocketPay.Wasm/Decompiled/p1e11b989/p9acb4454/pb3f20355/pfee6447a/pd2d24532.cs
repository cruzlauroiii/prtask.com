namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes21.dex */
@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\u0002\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001BA\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t\u0012\u0006\u0010\n\u001a\u00020\u000b\u0012\u0006\u0010\f\u001a\u00020\r\u0012\u0006\u0010\u000e\u001a\u00020\u000f\u0012\b\u0010\u0010\u001a\u0004\u0018\u00010\r¢\u0006\u0004\b\u0011\u0010\u0012J*\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00172\u0012\u0010\u0018\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0019H\u0096@¢\u0006\u0002\u0010\u001aJ\u0017\u0010\u001b\u001a\u0004\u0018\u00010\u00022\u0006\u0010\u0016\u001a\u00020\u0017H\u0002¢\u0006\u0002\u0010\u001cJ\u0016\u0010\u001d\u001a\u00020\u001e2\u0006\u0010\u001f\u001a\u00020\u0002H\u0082@¢\u0006\u0002\u0010 J\u0018\u0010!\u001a\n\u0012\u0004\u0012\u00020\r\u0018\u00010\"2\u0006\u0010\u000e\u001a\u00020\u000fH\u0002J\u0018\u0010#\u001a\n\u0012\u0004\u0012\u00020\r\u0018\u00010\"2\u0006\u0010\u000e\u001a\u00020\u000fH\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0010\u001a\u0004\u0018\u00010\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0013\u001a\u00020\u0002X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006$"}, d2 = {"Lp1e11b989/p9acb4454/pb3f20355/pfee6447a/pd2d24532;", "Landroidx/paging/RemoteMediator;", "", "Lpad5f82e8/p07214c67/pd77d5e50/pf6fe55a8;", "receiptStatusServerRepository", "Lp1e11b989/p9acb4454/pb3f20355/p5926f3a5;", "receiptDbRepository", "Lp8d777f38/pb3f20355/p1e11b989/p7638dcb8;", "devicesRepository", "Lpe0212e54/pb3f20355/p44cd4abe;", "employeesRepository", "Lp582ca3f7/pb3f20355/p0c2c0436;", "userId", "", "filter", "Lp1e11b989/p9acb4454/p07214c67/pc77da2af;", "shopId", "<init>", "(Lp1e11b989/p9acb4454/pb3f20355/p5926f3a5;Lp8d777f38/pb3f20355/p1e11b989/p7638dcb8;Lpe0212e54/pb3f20355/p44cd4abe;Lp582ca3f7/pb3f20355/p0c2c0436;Ljava/lang/string;Lp1e11b989/p9acb4454/p07214c67/pc77da2af;Ljava/lang/string;)V", "pageIndex", "load", "Landroidx/paging/RemoteMediator$MediatorResult;", "loadType", "Landroidx/paging/LoadType;", "state", "Landroidx/paging/PagingState;", "(Landroidx/paging/LoadType;Landroidx/paging/PagingState;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getPageIndex", "(Landroidx/paging/LoadType;)Ljava/lang/int;", "getReceiptsResponse", "Lp1e11b989/p9acb4454/p07214c67/pf7a6e566;", "size", "(ILkotlin/coroutines/Continuation;)Ljava/lang/object;", "getPaymentTypes", "", "getOperationTypes", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd2d24532 : androidx.paging.RemoteMediator<java.lang.int, pad5f82e8.p07214c67.pd77d5e50.pf6fe55a8> {
    private readonly p1e11b989.p9acb4454.pb3f20355.p5926f3a5 f0896d468;
    private readonly java.lang.string f0de561a8;
    private readonly p582ca3f7.pb3f20355.p0c2c0436 f0e8d1db9;
    private readonly java.lang.string f1cfa4150;
    private readonly pe0212e54.pb3f20355.p44cd4abe f24f0abd1;
    private int f256ba50b;
    private readonly pe0212e54.pb3f20355.p44cd4abe f2c25f011;
    private readonly java.lang.string f3fec2a59;
    private int f5305c22e;
    private readonly p1e11b989.p9acb4454.pb3f20355.p5926f3a5 f5d596069;
    private readonly p1e11b989.p9acb4454.p07214c67.pc77da2af f61de8cd5;
    private readonly p1e11b989.p9acb4454.pb3f20355.p5926f3a5 f6c07e981;
    private readonly p1e11b989.p9acb4454.p07214c67.pc77da2af f6dbcf59d;
    private readonly p1e11b989.p9acb4454.pb3f20355.p5926f3a5 f722c9cfa;
    private readonly p1e11b989.p9acb4454.pb3f20355.p5926f3a5 f74e5c634;
    private readonly java.lang.string f77ae2533;
    private readonly pe0212e54.pb3f20355.p44cd4abe f8af308bf;
    private readonly java.lang.string f8e44f008;
    private readonly p1e11b989.p9acb4454.p07214c67.pc77da2af f9d68486b;
    private readonly java.lang.string f9f0e5f1c;
    private readonly p8d777f38.pb3f20355.p1e11b989.p7638dcb8 fa31aa83b;
    private readonly p1e11b989.p9acb4454.p07214c67.pc77da2af faddaa96f;
    private readonly p1e11b989.p9acb4454.p07214c67.pc77da2af fb2c97ae4;
    private int fbef7cae5;
    private int fcf0afdce;
    private readonly p582ca3f7.pb3f20355.p0c2c0436 fdb4277a8;
    private readonly p582ca3f7.pb3f20355.p0c2c0436 fedc5f59e;
    private readonly p8d777f38.pb3f20355.p1e11b989.p7638dcb8 ff2fed930;
    private int ffc50742b;

    @kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
                goto L25
            L4:
                int r0 = r0 + r1
                goto L6a
            La:
                return
            Lb:
                goto L3c
            Lf:
                r1 = 24
                goto L4
            L16:
                int r0 = r0.length
                goto L49
            L1b:
                r0 = 17
                goto Lf
            L22:
                goto L28
            L25:
                goto L3f
            L28:
                goto L1b
            L2c:
                if (r0 <= 0) goto L31
                goto L38
            L31:
                goto L35
            L35:
                goto Lb
            L38:
                goto L70
            L3c:
                goto L38
            L3f:
                goto L22
            L43:
                p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532.p12c674ac.$EnumSwitchDictionaryping$0 = r0
                goto La
            L49:
                int[] r0 = new int[r0]
                androidx.paging.LoadType r1 = androidx.paging.LoadType.REFRESH     // Catch: java.lang.NoSuchFieldError -> L54
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L54
                r2 = 1
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L54
            L54:
                androidx.paging.LoadType r1 = androidx.paging.LoadType.PREPEND     // Catch: java.lang.NoSuchFieldError -> L5d
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L5d
                r2 = 2
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L5d
            L5d:
                androidx.paging.LoadType r1 = androidx.paging.LoadType.APPEND     // Catch: java.lang.NoSuchFieldError -> L66
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L66
                r2 = 3
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L66
            L66:
                goto L43
            L6a:
                int r0 = r0 % r1
                goto L2c
            L70:
                androidx.paging.LoadType[] r0 = androidx.paging.LoadType.Values
                goto L16
        }
    }

    public pd2d24532(p1e11b989.p9acb4454.pb3f20355.p5926f3a5 r2, p8d777f38.pb3f20355.p1e11b989.p7638dcb8 r3, pe0212e54.pb3f20355.p44cd4abe r4, p582ca3f7.pb3f20355.p0c2c0436 r5, java.lang.string r6, p1e11b989.p9acb4454.p07214c67.pc77da2af r7, java.lang.string r8) {
            r1 = this;
            goto L31
        L4:
            r1.f77ae2533 = r8
            goto L77
        La:
            r1.ff2fed930 = r3
            goto L2b
        L10:
            java.lang.string r0 = "devicesRepository"
            goto L59
        L16:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r5, r0)
            goto L1d
        L1d:
            java.lang.string r0 = "userId"
            goto L8e
        L24:
            java.lang.string r0 = "receiptStatusServerRepository"
            goto L52
        L2b:
            r1.f8af308bf = r4
            goto L88
        L31:
            goto L78
        L34:
            goto L24
        L38:
            java.lang.string r0 = "employeesRepository"
            goto L16
        L3e:
            java.lang.string r0 = "filter"
            goto L60
        L44:
            r1.<init>()
            goto L6e
        L4b:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L10
        L52:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L67
        L59:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r4, r0)
            goto L38
        L60:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r7, r0)
            goto L44
        L67:
            java.lang.string r0 = "receiptDbRepository"
            goto L4b
        L6e:
            r1.f0896d468 = r2
            goto La
        L74:
            goto L34
        L77:
            return
        L78:
            goto L74
        L7c:
            r1.f8e44f008 = r6
            goto L82
        L82:
            r1.fb2c97ae4 = r7
            goto L4
        L88:
            r1.fedc5f59e = r5
            goto L7c
        L8e:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r6, r0)
            goto L3e
    }

    private readonly java.lang.object M0f2d9a69(int r28, kotlin.coroutines.Continuation<p1e11b989.p9acb4454.p07214c67.pf7a6e566> r29) {
            r27 = this;
            goto L3ac
        L4:
            r7 = r15
            goto L234
        L9:
            r3.L$9 = r1
            goto L1d
        Lf:
            r10 = r11
            goto L2b9
        L14:
            if (r1 == r0) goto L19
            goto Lfd
        L19:
            goto Lfc
        L1d:
            r1 = 2
            goto Lcd
        L22:
            r12 = r8
            goto L437
        L27:
            java.lang.object r2 = r3.fb4a88417
            goto L2b1
        L2d:
            int r0 = r0 + r1
            goto L35c
        L33:
            r17 = r0
            goto L3c0
        L39:
            r10 = r14
            goto L2a1
        L3e:
            java.lang.object r0 = r3.L$4
            goto L390
        L44:
            p1e11b989.p9acb4454.pb3f20355.p5926f3a5 r0 = (p1e11b989.p9acb4454.pb3f20355.p5926f3a5) r0
            goto L55
        L4a:
            r1 = 0
            goto L2c4
        L4f:
            java.lang.string r0 = (java.lang.string) r0
            goto L447
        L55:
            r19 = r0
            goto L3e
        L5b:
            r3.<init>(r0, r2)
        L5e:
            goto L27
        L62:
            if (r4 != 0) goto L67
            goto L1e7
        L67:
            goto L8e
        L6b:
            goto L19
        L6d:
            goto L3d1
        L71:
            r23 = r0
            goto L190
        L77:
            r0 = r2
            goto L140
        L7c:
            p1e11b989.p9acb4454.p07214c67.pc77da2af r13 = r0.fb2c97ae4
            goto L396
        L82:
            r13 = r21
            goto L2a6
        L88:
            java.lang.object r8 = r3.L$9
            goto L311
        L8e:
            int r2 = r3.fd304ba20
            goto L2df
        L94:
            if (r0 <= 0) goto L99
            goto L10a
        L99:
            goto L107
        L9d:
            r19 = r9
            goto L1da
        La3:
            p1e11b989.p9acb4454.pb3f20355.p5926f3a5 r2 = r0.f0896d468
            goto L39e
        La9:
            r0 = r2
            goto L1b0
        Lae:
            long r11 = r11.getDateTimeEnd()
            goto L42b
        Lb6:
            int r6 = r3.I$0
            goto L88
        Lbc:
            r7 = r9
            goto L31d
        Lc1:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L11f
        Lc7:
            int r4 = r3.fd304ba20
            goto L441
        Lcd:
            r3.fd304ba20 = r1
            goto L210
        Ld3:
            r2 = r29
            goto L32f
        Ld9:
            goto L141
        Lda:
            goto L77
        Lde:
            java.util.List r0 = (java.util.List) r0
            goto L1f1
        Le4:
            r3.L$6 = r1
            goto L317
        Lea:
            long r11 = r3.J$1
            goto L3f5
        Lf0:
            r3.L$3 = r1
            goto L1d4
        Lf6:
            long r0 = r3.J$3
            goto L459
        Lfc:
            return r0
        Lfd:
            goto L2fb
        L101:
            java.lang.object r0 = r3.L$5
            goto L44
        L107:
            goto L2fc
        L10a:
            goto L3b3
        L10e:
            r8 = r19
            goto L29c
        L114:
            r4 = r0
            goto L373
        L119:
            p5a445d71.p228c1b3d.p07cc694b.p6f69c05f r8 = new p5a445d71.p228c1b3d.p07cc694b.p6f69c05f
            goto L17e
        L11f:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto L156
        L125:
            r9 = r15
        L126:
            pad5f82e8.p07214c67.pfa547353.pf8c8b903 r7 = (pad5f82e8.p07214c67.pfa547353.pf8c8b903) r7     // Catch: java.lang.Exception -> L29d
            java.lang.string r2 = r7.getId()     // Catch: java.lang.Exception -> L29d
            goto L259
        L130:
            r0 = r4
            goto L6b
        L135:
            r23 = r11
            goto L3dc
        L13b:
            r9 = r13
            goto L1df
        L140:
            r15 = r6
        L141:
            goto L3c6
        L145:
            r6 = r1
            goto L4a
        L14a:
            p5a445d71.p228c1b3d.p07cc694b.p34dacb78 r9 = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d
            goto L33a
        L150:
            java.lang.object r1 = r3.L$7
            goto L37e
        L156:
            r0.<init>(r1)
            goto L379
        L15d:
            java.lang.object r0 = r3.L$3
            goto L407
        L163:
            r1 = r28
            goto Ld3
        L169:
            if (r0 == r4) goto L16e
            goto L6d
        L16e:
            goto L130
        L172:
            r16 = r3
            goto L327
        L178:
            r23 = r11
            goto L22e
        L17e:
            p1e11b989.p9acb4454.p07214c67.pc77da2af r11 = r0.fb2c97ae4
            goto Lae
        L184:
            r3.fd304ba20 = r2
            goto L1e5
        L18a:
            r7 = r24
            goto L178
        L190:
            java.lang.object r0 = r3.L$0
            goto L196
        L196:
            p1e11b989.p9acb4454.pb3f20355.p5926f3a5 r0 = (p1e11b989.p9acb4454.pb3f20355.p5926f3a5) r0
            kotlin.ResultKt.throwOnFailure(r2)     // Catch: java.lang.Exception -> L2e6
            goto L425
        L19f:
            return r2
        L1a0:
            goto Lc1
        L1a4:
            r3.L$1 = r1
            goto L1b5
        L1aa:
            java.lang.string r0 = (java.lang.string) r0
            goto L71
        L1b0:
            r1 = r6
            goto L82
        L1b5:
            r3.L$2 = r1
            goto Lf0
        L1bb:
            kotlin.ResultKt.throwOnFailure(r2)
            goto La3
        L1c2:
            p5a445d71.p228c1b3d.p07cc694b.p34dacb78 r11 = p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d
            goto L3a4
        L1c8:
            r5 = r23
            goto L322
        L1ce:
            p1e11b989.p9acb4454.p07214c67.pc77da2af r9 = r0.fb2c97ae4
            goto L239
        L1d4:
            r3.L$4 = r1
            goto L3d6
        L1da:
            r9 = r5
            goto L2f6
        L1df:
            r14 = r20
            goto L3fb
        L1e5:
            goto L5e
        L1e7:
            goto L413
        L1eb:
            r0 = r19
            goto L9d
        L1f1:
            r22 = r0
            goto L368
        L1f7:
            java.util.List r8 = r0.m10cea955(r8)
            goto L7c
        L1ff:
            if (r5 != r7) goto L204
            goto L37a
        L204:
            goto L216
        L208:
            long r11 = r8.getMillis()
            goto L306
        L210:
            r16 = r4
            goto L114
        L216:
            if (r5 == r6) goto L21b
            goto L1a0
        L21b:
            goto L3e8
        L21f:
            r8 = r22
            goto L241
        L225:
            r21 = r0
            goto L419
        L22b:
            goto L3af
        L22e:
            r11 = r27
            goto L2e4
        L234:
            r15 = 0
        L235:
            goto L145
        L239:
            long r9 = r9.getDateTimeStart()
            goto L347
        L241:
            r5 = r23
            goto L362
        L247:
            r27 = r0
            goto L300
        L24d:
            r11 = r23
            goto L40d
        L253:
            r22 = r8
            goto L453
        L259:
            r15 = r2
            goto Lbc
        L25e:
            java.lang.string r14 = r0.f77ae2533
            p582ca3f7.pb3f20355.p0c2c0436 r0 = r0.fedc5f59e     // Catch: java.lang.Exception -> Lda
            r3.L$0 = r2     // Catch: java.lang.Exception -> Lda
            r3.L$1 = r5     // Catch: java.lang.Exception -> Lda
            r3.L$2 = r8     // Catch: java.lang.Exception -> Lda
            r3.L$3 = r13     // Catch: java.lang.Exception -> Lda
            r3.L$4 = r14     // Catch: java.lang.Exception -> Lda
            r3.L$5 = r2     // Catch: java.lang.Exception -> Lda
            r3.L$6 = r5     // Catch: java.lang.Exception -> Lda
            r3.L$7 = r8     // Catch: java.lang.Exception -> Lda
            r3.L$8 = r13     // Catch: java.lang.Exception -> Lda
            r3.L$9 = r14     // Catch: java.lang.Exception -> Lda
            r3.I$0 = r1     // Catch: java.lang.Exception -> Lda
            r3.I$1 = r6     // Catch: java.lang.Exception -> Lda
            r3.J$0 = r9     // Catch: java.lang.Exception -> Lda
            r3.J$1 = r11     // Catch: java.lang.Exception -> Lda
            r3.I$2 = r1     // Catch: java.lang.Exception -> Lda
            r3.I$3 = r6     // Catch: java.lang.Exception -> Lda
            r3.J$2 = r9     // Catch: java.lang.Exception -> Lda
            r3.J$3 = r11     // Catch: java.lang.Exception -> Lda
            r3.fd304ba20 = r7     // Catch: java.lang.Exception -> Lda
            java.lang.object r0 = r0.getSelectedEmployee(r3)     // Catch: java.lang.Exception -> Lda
            goto L169
        L290:
            goto L10a
        L293:
            goto L22b
        L297:
            r7 = 1
            goto L2d6
        L29c:
            goto L235
        L29d:
            goto La9
        L2a1:
            r6 = r1
            goto L125
        L2a6:
            r8 = r22
            goto L24d
        L2ac:
            r6 = 2
            goto L297
        L2b1:
            java.lang.object r4 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L478
        L2b9:
            r5 = r18
            goto L43c
        L2bf:
            r2 = r0
            goto L1eb
        L2c4:
            r3.L$0 = r1
            goto L1a4
        L2ca:
            r20 = r0
            goto L15d
        L2d0:
            r14 = r20
            goto L3e2
        L2d6:
            if (r5 != 0) goto L2db
            goto L364
        L2db:
            goto L1ff
        L2df:
            int r2 = r2 - r5
            goto L184
        L2e4:
            goto L126
        L2e6:
            goto L46d
        L2ea:
            int r7 = r3.I$2
            goto Lea
        L2f0:
            java.util.List r0 = (java.util.List) r0
            goto L150
        L2f6:
            r10 = r8
            goto L1c8
        L2fb:
            return r1
        L2fc:
            goto L290
        L300:
            java.lang.object r0 = r3.L$8
            goto L2f0
        L306:
            p1e11b989.p9acb4454.p07214c67.pc77da2af r8 = r0.fb2c97ae4
            goto L1f7
        L30c:
            r15 = r6
            goto L253
        L311:
            java.lang.string r8 = (java.lang.string) r8
            goto L247
        L317:
            r3.L$7 = r1
            goto L3ef
        L31d:
            r14 = r10
            goto Lf
        L322:
            r8 = r1
            goto L335
        L327:
            java.lang.object r1 = r4.getReceipts(r5, r6, r7, r8, r10, r12, r13, r14, r15, r16)
            goto L14
        L32f:
            bool r3 = r2 is p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$p0f2d9a69$1
            goto L34e
        L335:
            r1 = r7
            goto L18a
        L33a:
            p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 r8 = r8.toDateTimeTime(r9)
            goto L465
        L342:
            r4 = r4 & r5
            goto L62
        L347:
            r8.<init>(r9)
            goto L14a
        L34e:
            if (r3 != 0) goto L353
            goto L1e7
        L353:
            goto L36e
        L357:
            r0 = r2
            goto L384
        L35c:
            int r0 = r0 % r1
            goto L94
        L362:
            goto L141
        L364:
            goto L1bb
        L368:
            java.lang.object r0 = r3.L$1
            goto L1aa
        L36e:
            r3 = r2
            goto L45f
        L373:
            r0 = r16
            goto L172
        L379:
            throw r0
        L37a:
            goto Lf6
        L37e:
            java.util.List r1 = (java.util.List) r1
            goto L33
        L384:
            r18 = r5
            goto L30c
        L38a:
            r13 = r17
            goto L2d0
        L390:
            java.lang.string r0 = (java.lang.string) r0
            goto L2ca
        L396:
            java.util.List r13 = r0.m3cd1f3c6(r13)
            goto L25e
        L39e:
            java.lang.string r5 = r0.f8e44f008
            goto L401
        L3a4:
            p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 r8 = r8.toDateTimeTime(r11)
            goto L208
        L3ac:
            goto L293
        L3af:
            goto L3b9
        L3b3:
            r0 = r27
            goto L163
        L3b9:
            r0 = 7
            goto L47e
        L3c0:
            java.lang.object r0 = r3.L$6
            goto L4f
        L3c6:
            r6 = r11
            goto L22
        L3cb:
            p5a445d71.p228c1b3d.p07cc694b.p6f69c05f r8 = new p5a445d71.p228c1b3d.p07cc694b.p6f69c05f
            goto L1ce
        L3d1:
            r7 = r0
            goto L357
        L3d6:
            r3.L$5 = r1
            goto Le4
        L3dc:
            r21 = r13
            goto L39
        L3e2:
            r24 = r2
            goto L2bf
        L3e8:
            kotlin.ResultKt.throwOnFailure(r2)
            goto L19f
        L3ef:
            r3.L$8 = r1
            goto L9
        L3f5:
            long r13 = r3.J$0
            goto L41f
        L3fb:
            r13 = r21
            goto L21f
        L401:
            int r6 = r0.f5305c22e
            goto L3cb
        L407:
            java.util.List r0 = (java.util.List) r0
            goto L225
        L40d:
            r9 = r25
            goto Ld9
        L413:
            p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$p0f2d9a69$1 r3 = new p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$p0f2d9a69$1
            goto L5b
        L419:
            java.lang.object r0 = r3.L$2
            goto Lde
        L41f:
            int r15 = r3.I$1
            goto Lb6
        L425:
            r25 = r13
            goto L38a
        L42b:
            r8.<init>(r11)
            goto L1c2
        L432:
            r10 = r6
            goto L4
        L437:
            r8 = r9
            goto L432
        L43c:
            r12 = r8
            goto L10e
        L441:
            r5 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L342
        L447:
            r18 = r0
            goto L101
        L44d:
            r25 = r19
            goto L135
        L453:
            r19 = r9
            goto L44d
        L459:
            long r9 = r3.J$2
            goto L472
        L45f:
            p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$p0f2d9a69$1 r3 = (p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$p0f2d9a69$1) r3
            goto Lc7
        L465:
            long r9 = r8.getMillis()
            goto L119
        L46d:
            r1 = r6
            goto L13b
        L472:
            int r5 = r3.I$3
            goto L2ea
        L478:
            int r5 = r3.fd304ba20
            goto L2ac
        L47e:
            r1 = 14
            goto L2d
    }

    private readonly java.util.List<java.lang.string> M10cea955(p1e11b989.p9acb4454.p07214c67.pc77da2af r2) {
            r1 = this;
            goto L69
        L4:
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1
            goto L21
        La:
            java.util.List r1 = r2.getCurrentPaymentTypes()
            goto L54
        L12:
            return r2
        L13:
            goto L78
        L17:
            r2.Add(r0)
            goto L59
        L1e:
            goto L6c
        L21:
            java.util.List r2 = new java.util.List
            goto Laa
        L27:
            java.util.IEnumerator r1 = r1.GetEnumerator()
        L2b:
            goto L70
        L2f:
            pad5f82e8.p07214c67.p1e11b989.p8c261c90 r0 = (pad5f82e8.p07214c67.p1e11b989.p8c261c90) r0
            goto L43
        L35:
            java.util.ICollection r2 = (java.util.ICollection) r2
            goto La2
        L3b:
            java.lang.object r0 = r1.Current
            goto L2f
        L43:
            java.lang.string r0 = r0.name()
            goto L17
        L4b:
            if (r2 == 0) goto L50
            goto L96
        L50:
            goto L95
        L54:
            r2 = r1
            goto L35
        L59:
            goto L2b
        L5a:
            goto L63
        L5e:
            r0 = 0
            goto L4b
        L63:
            java.util.List r2 = (java.util.List) r2
            goto L12
        L69:
            goto L79
        L6c:
            goto La
        L70:
            bool r0 = r1.MoveNext()
            goto L83
        L78:
            return r0
        L79:
            goto L1e
        L7d:
            java.util.ICollection r2 = (java.util.ICollection) r2
            goto L27
        L83:
            if (r0 != 0) goto L88
            goto L5a
        L88:
            goto L3b
        L8c:
            if (r1 != 0) goto L91
            goto L13
        L91:
            goto L4
        L95:
            goto Lb1
        L96:
            goto Lb0
        L9a:
            int r0 = kotlin.collections.ICollectionsKt.collectionSizeOrDefault(r1, r0)
            goto Lb5
        La2:
            bool r2 = r2.Count == 0
            goto L5e
        Laa:
            r0 = 10
            goto L9a
        Lb0:
            r1 = r0
        Lb1:
            goto L8c
        Lb5:
            r2.<init>(r0)
            goto L7d
    }

    private readonly java.util.List<java.lang.string> M3cd1f3c6(p1e11b989.p9acb4454.p07214c67.pc77da2af r2) {
            r1 = this;
            goto L4d
        L4:
            java.util.ICollection r2 = (java.util.ICollection) r2
            goto L21
        La:
            java.util.List r1 = r2.getCurrentOperationTypes()
            goto L97
        L12:
            if (r0 != 0) goto L17
            goto Lb4
        L17:
            goto L80
        L1b:
            java.util.List r2 = new java.util.List
            goto L6a
        L21:
            bool r2 = r2.Count == 0
            goto Lad
        L29:
            java.util.IEnumerator r1 = r1.GetEnumerator()
        L2d:
            goto L45
        L31:
            java.lang.IEnumerable r1 = (java.lang.IEnumerable) r1
            goto L1b
        L37:
            if (r2 == 0) goto L3c
            goto La9
        L3c:
            goto La8
        L40:
            return r0
        L41:
            goto L70
        L45:
            bool r0 = r1.MoveNext()
            goto L12
        L4d:
            goto L41
        L50:
            goto La
        L54:
            if (r1 != 0) goto L59
            goto Lb9
        L59:
            goto L31
        L5d:
            r2.<init>(r0)
            goto La2
        L64:
            pad5f82e8.p07214c67.p1e11b989.p5a409c20 r0 = (pad5f82e8.p07214c67.p1e11b989.p5a409c20) r0
            goto L78
        L6a:
            r0 = 10
            goto L8f
        L70:
            goto L50
        L73:
            r1 = r0
        L74:
            goto L54
        L78:
            java.lang.string r0 = r0.name()
            goto L88
        L80:
            java.lang.object r0 = r1.Current
            goto L64
        L88:
            r2.Add(r0)
            goto Lb2
        L8f:
            int r0 = kotlin.collections.ICollectionsKt.collectionSizeOrDefault(r1, r0)
            goto L5d
        L97:
            r2 = r1
            goto L4
        L9c:
            java.util.List r2 = (java.util.List) r2
            goto Lb8
        La2:
            java.util.ICollection r2 = (java.util.ICollection) r2
            goto L29
        La8:
            goto L74
        La9:
            goto L73
        Lad:
            r0 = 0
            goto L37
        Lb2:
            goto L2d
        Lb4:
            goto L9c
        Lb8:
            return r2
        Lb9:
            goto L40
    }

    public static readonly /* synthetic */ java.lang.object m7f94808c(p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532 r0, int r1, kotlin.coroutines.Continuation r2) {
            goto Lc
        L4:
            java.lang.object r0 = r0.m0f2d9a69(r1, r2)
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

    private readonly java.lang.int Ma8371dc9(androidx.paging.LoadType r3) {
            r2 = this;
            goto L12
        L4:
            goto Laf
        L7:
            goto L64
        Lb:
            r2.<init>()
            goto La1
        L12:
            goto Lbb
        L15:
            goto L38
        L19:
            r3 = 0
        L1a:
            goto L84
        L1e:
            int r0 = r0 % r1
            goto L8a
        L24:
            r2.f5305c22e = r3
            goto L2a
        L2a:
            goto L1a
        L2b:
            goto L45
        L2f:
            if (r3 != r0) goto L34
            goto L73
        L34:
            goto Lb3
        L38:
            r0 = 4
            goto L7d
        L3f:
            int r3 = r2.f5305c22e
            goto L4b
        L45:
            kotlin.NoWhenBranchMatchedException r2 = new kotlin.NoWhenBranchMatchedException
            goto Lb
        L4b:
            int r3 = r3 + r0
            goto L24
        L50:
            r3 = r0[r3]
            goto L93
        L56:
            r1 = 3
            goto L98
        L5b:
            if (r3 != r1) goto L60
            goto La2
        L60:
            goto L56
        L64:
            int[] r0 = p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532.p12c674ac.$EnumSwitchDictionaryping$0
            goto Lbf
        L6a:
            r2 = 0
            goto L72
        L6f:
            goto L15
        L72:
            return r2
        L73:
            goto L19
        L77:
            int r0 = r0 + r1
            goto L1e
        L7d:
            r1 = 8
            goto L77
        L84:
            r2.f5305c22e = r3
            goto La6
        L8a:
            if (r0 <= 0) goto L8f
            goto L7
        L8f:
            goto L4
        L93:
            r0 = 1
            goto L2f
        L98:
            if (r3 == r1) goto L9d
            goto L2b
        L9d:
            goto L3f
        La1:
            throw r2
        La2:
            goto L6a
        La6:
            java.lang.int r2 = java.lang.int.valueOf(r3)
            goto Lae
        Lae:
            return r2
        Laf:
            goto Lb8
        Lb3:
            r1 = 2
            goto L5b
        Lb8:
            goto L7
        Lbb:
            goto L6f
        Lbf:
            int r3 = r3.ordinal()
            goto L50
    }

    @Override // androidx.paging.RemoteMediator
    public java.lang.object Load(androidx.paging.LoadType r18, androidx.paging.PagingState<java.lang.int, pad5f82e8.p07214c67.pd77d5e50.pf6fe55a8> r19, kotlin.coroutines.Continuation<androidx.paging.RemoteMediator.MediatorResult> r20) {
            r17 = this;
            goto L191
        L4:
            if (r4 != 0) goto L9
            goto L221
        L9:
            goto L275
        Ld:
            java.lang.object r6 = r2.L$1
            goto L2d3
        L13:
            r6 = 3
            goto L256
        L18:
            int r1 = r1.pageSize
            r2.L$0 = r0     // Catch: java.lang.Exception -> L22c
            r2.I$0 = r1     // Catch: java.lang.Exception -> L22c
            r2.fd304ba20 = r8     // Catch: java.lang.Exception -> L22c
            java.lang.object r4 = r0.m0f2d9a69(r1, r2)     // Catch: java.lang.Exception -> L22c
            if (r4 != r3) goto L28
            goto L100
        L28:
            p1e11b989.p9acb4454.p07214c67.pf7a6e566 r4 = (p1e11b989.p9acb4454.p07214c67.pf7a6e566) r4     // Catch: java.lang.Exception -> L22c
            java.util.HashDictionary r5 = new java.util.HashDictionary     // Catch: java.lang.Exception -> L22c
            r5.<init>()     // Catch: java.lang.Exception -> L22c
            java.util.List r6 = r4.getReceipts()     // Catch: java.lang.Exception -> L22c
            java.lang.IEnumerable r6 = (java.lang.IEnumerable) r6     // Catch: java.lang.Exception -> L22c
            java.util.List r9 = new java.util.List     // Catch: java.lang.Exception -> L22c
            r10 = 10
            int r10 = kotlin.collections.ICollectionsKt.collectionSizeOrDefault(r6, r10)     // Catch: java.lang.Exception -> L22c
            r9.<init>(r10)     // Catch: java.lang.Exception -> L22c
            java.util.ICollection r9 = (java.util.ICollection) r9     // Catch: java.lang.Exception -> L22c
            java.util.IEnumerator r6 = r6.GetEnumerator()     // Catch: java.lang.Exception -> L22c
            r14 = r6
            r6 = r0
            r0 = r1
            r1 = r4
            r4 = r9
        L4b:
            bool r9 = r14.MoveNext()     // Catch: java.lang.Exception -> L22c
            if (r9 == 0) goto Lc5
            java.lang.object r9 = r14.Current     // Catch: java.lang.Exception -> L22c
            r13 = r9
            p1e11b989.p9acb4454.p07214c67.pe8f32165 r13 = (p1e11b989.p9acb4454.p07214c67.pe8f32165) r13     // Catch: java.lang.Exception -> L22c
            java.lang.stringBuilder r11 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L22c
            r11.<init>()     // Catch: java.lang.Exception -> L22c
            java.lang.string r12 = r13.getDeviceUuid()     // Catch: java.lang.Exception -> L22c
            if (r12 == 0) goto La3
            r10 = r5
            java.util.Dictionary r10 = (java.util.Dictionary) r10     // Catch: java.lang.Exception -> L22c
            java.lang.object r9 = r10[r12)     // Catch: java.lang.Exception -> L22c
            if (r9 != 0) goto L9f
            pe0212e54.pb3f20355.p44cd4abe r9 = r6.f8af308bf     // Catch: java.lang.Exception -> L22c
            r2.L$0 = r6     // Catch: java.lang.Exception -> L22c
            r2.L$1 = r1     // Catch: java.lang.Exception -> L22c
            r2.L$2 = r5     // Catch: java.lang.Exception -> L22c
            r2.L$3 = r4     // Catch: java.lang.Exception -> L22c
            r2.L$4 = r14     // Catch: java.lang.Exception -> L22c
            r2.L$5 = r13     // Catch: java.lang.Exception -> L22c
            r2.L$6 = r12     // Catch: java.lang.Exception -> L22c
            r2.L$7 = r11     // Catch: java.lang.Exception -> L22c
            r2.L$8 = r10     // Catch: java.lang.Exception -> L22c
            r2.L$9 = r4     // Catch: java.lang.Exception -> L22c
            r2.I$0 = r0     // Catch: java.lang.Exception -> L22c
            r2.fd304ba20 = r7     // Catch: java.lang.Exception -> L22c
            java.lang.object r9 = r9.getDeviceIdByUuid(r12, r2)     // Catch: java.lang.Exception -> L22c
            if (r9 != r3) goto L8e
            goto L100
        L8e:
            r15 = r6
            r6 = r1
            r1 = r9
            r9 = r15
            r15 = r4
        L93:
            java.lang.string r1 = (java.lang.string) r1     // Catch: java.lang.Exception -> L22c
            r10.Add(r12, r1)     // Catch: java.lang.Exception -> L22c
            r16 = r9
            r9 = r1
            r1 = r6
            r6 = r16
            goto La0
        L9f:
            r15 = r4
        La0:
            java.lang.string r9 = (java.lang.string) r9     // Catch: java.lang.Exception -> L22c
            goto La5
        La3:
            r15 = r4
            r9 = 0
        La5:
            if (r9 != 0) goto La9
            java.lang.string r9 = ""
        La9:
            java.lang.stringBuilder r9 = r11.append(r9)     // Catch: java.lang.Exception -> L22c
            java.lang.string r10 = "ecd1e517360102046770bb4dde2c13d544a45067afed4b73152b43ec0b148ae5d6322c"
            java.lang.string r10 = com.decryptstringmanager.Decryptstring.decryptstring(r10)     // Catch: java.lang.Exception -> L22c
            java.lang.stringBuilder r9 = r9.append(r10)     // Catch: java.lang.Exception -> L22c
            java.lang.string r9 = r9.tostring()     // Catch: java.lang.Exception -> L22c
            pad5f82e8.p07214c67.pd77d5e50.pb433d3f3 r9 = p1e11b989.p9acb4454.p07214c67.p4b9f83e1.p60f1d024.me26e46c2(r13, r9)     // Catch: java.lang.Exception -> L22c
            r4.Add(r9)     // Catch: java.lang.Exception -> L22c
            r4 = r15
            goto L4b
        Lc5:
            java.util.List r4 = (java.util.List) r4     // Catch: java.lang.Exception -> L22c
            p8d777f38.pb3f20355.p1e11b989.p7638dcb8 r5 = r6.ff2fed930     // Catch: java.lang.Exception -> L22c
            int r1 = r1.getTotalElements()     // Catch: java.lang.Exception -> L22c
            r2.L$0 = r6     // Catch: java.lang.Exception -> L22c
            r2.L$1 = r4     // Catch: java.lang.Exception -> L22c
            r7 = 0
            r2.L$2 = r7     // Catch: java.lang.Exception -> L22c
            r2.L$3 = r7     // Catch: java.lang.Exception -> L22c
            r2.L$4 = r7     // Catch: java.lang.Exception -> L22c
            r2.L$5 = r7     // Catch: java.lang.Exception -> L22c
            r2.L$6 = r7     // Catch: java.lang.Exception -> L22c
            r2.L$7 = r7     // Catch: java.lang.Exception -> L22c
            r2.L$8 = r7     // Catch: java.lang.Exception -> L22c
            r2.L$9 = r7     // Catch: java.lang.Exception -> L22c
            r2.I$0 = r0     // Catch: java.lang.Exception -> L22c
            r7 = 3
            r2.fd304ba20 = r7     // Catch: java.lang.Exception -> L22c
            java.lang.object r1 = r5.insertReceiptTotalCount(r1, r2)     // Catch: java.lang.Exception -> L22c
            if (r1 != r3) goto L271
            goto L100
        Lee:
            p8d777f38.pb3f20355.p1e11b989.p7638dcb8 r4 = r6.ff2fed930     // Catch: java.lang.Exception -> L22c
            r1.L$0 = r2     // Catch: java.lang.Exception -> L22c
            r7 = 0
            r1.L$1 = r7     // Catch: java.lang.Exception -> L22c
            r1.I$0 = r0     // Catch: java.lang.Exception -> L22c
            r5 = 4
            r1.fd304ba20 = r5     // Catch: java.lang.Exception -> L22c
            java.lang.object r1 = r4.saveReceipts(r2, r1)     // Catch: java.lang.Exception -> L22c
            if (r1 != r3) goto L101
        L100:
            return r3
        L101:
            androidx.paging.RemoteMediator$MediatorResult$Success r1 = new androidx.paging.RemoteMediator$MediatorResult$Success     // Catch: java.lang.Exception -> L22c
            int r2 = r2.Count     // Catch: java.lang.Exception -> L22c
            if (r2 >= r0) goto L10b
            r0 = r8
            goto L10c
        L10b:
            r0 = 0
        L10c:
            r1.<init>(r0)     // Catch: java.lang.Exception -> L22c
            androidx.paging.RemoteMediator$MediatorResult r1 = (androidx.paging.RemoteMediator.MediatorResult) r1     // Catch: java.lang.Exception -> L22c
            goto L22b
        L115:
            goto L2f6
        L118:
            goto L27e
        L11c:
            p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532 r4 = (p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532) r4
            kotlin.ResultKt.throwOnFailure(r1)     // Catch: java.lang.Exception -> L22c
            goto L24b
        L125:
            r2.<init>(r0, r1)
        L128:
            goto L1b0
        L12c:
            java.lang.object r5 = r2.L$2
            goto L2e6
        L132:
            int r4 = r2.fd304ba20
            goto L368
        L138:
            java.lang.object r12 = r2.L$6
            goto L23f
        L13e:
            kotlin.ResultKt.throwOnFailure(r1)
            goto L360
        L145:
            p1e11b989.p9acb4454.p07214c67.pe8f32165 r13 = (p1e11b989.p9acb4454.p07214c67.pe8f32165) r13
            goto L1cd
        L14b:
            if (r4 != r7) goto L150
            goto L350
        L150:
            goto L1ec
        L154:
            r0 = r4
            goto L225
        L159:
            if (r2 != 0) goto L15e
            goto L1a5
        L15e:
            goto L28d
        L162:
            int r1 = r1.intValue()
            goto L287
        L16a:
            java.util.ICollection r4 = (java.util.ICollection) r4
            goto L297
        L170:
            java.lang.object r4 = r2.L$0
            goto L11c
        L176:
            int r1 = r2.fd304ba20
            goto L251
        L17c:
            java.util.List r4 = (java.util.List) r4
            goto L1d3
        L182:
            if (r4 == r5) goto L187
            goto L308
        L187:
            goto L300
        L18b:
            java.lang.object r2 = r2.L$0
            goto L230
        L191:
            goto L118
        L194:
            goto L2d9
        L198:
            java.lang.object r4 = r2.L$9
            goto L16a
        L19e:
            androidx.paging.RemoteMediator$MediatorResult$Success r0 = new androidx.paging.RemoteMediator$MediatorResult$Success
            goto L1a9
        L1a4:
            goto L128
        L1a5:
            goto L245
        L1a9:
            r0.<init>(r8)
            goto L29d
        L1b0:
            java.lang.object r1 = r2.fb4a88417
            goto L20b
        L1b6:
            androidx.paging.PagingConfig r1 = r19.getConfig()
            goto L18
        L1be:
            r0 = r17
            goto L323
        L1c4:
            if (r0 <= 0) goto L1c9
            goto L2f6
        L1c9:
            goto L2f3
        L1cd:
            java.lang.object r14 = r2.L$4
            goto L2e0
        L1d3:
            java.lang.object r6 = r2.L$0
            goto L26c
        L1d9:
            r0.<init>(r1)
            goto L30c
        L1e0:
            java.util.Dictionary r10 = (java.util.Dictionary) r10
            goto L2ac
        L1e6:
            java.lang.string r1 = "call to 'resume' before 'invoke' with coroutine"
            goto L1d9
        L1ec:
            if (r4 != r6) goto L1f1
            goto L30d
        L1f1:
            goto L182
        L1f5:
            r3 = r3 & r4
            goto L2a3
        L1fa:
            p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$pec4d1eb3$1 r2 = (p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$pec4d1eb3$1) r2
            goto L335
        L200:
            r1 = r2
            goto L25b
        L205:
            int r0 = r0 % r1
            goto L1c4
        L20b:
            java.lang.object r3 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
            goto L132
        L213:
            java.lang.object r13 = r2.L$5
            goto L145
        L219:
            int r0 = r2.I$0
            goto L239
        L21f:
            goto L28
        L221:
            goto L13e
        L225:
            r4 = r16
            goto L21f
        L22b:
            return r1
        L22c:
            goto L19e
        L230:
            java.util.List r2 = (java.util.List) r2
            kotlin.ResultKt.throwOnFailure(r1)     // Catch: java.lang.Exception -> L22c
            goto L306
        L239:
            java.lang.object r4 = r2.L$1
            goto L17c
        L23f:
            java.lang.string r12 = (java.lang.string) r12
            goto L213
        L245:
            p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$pec4d1eb3$1 r2 = new p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$pec4d1eb3$1
            goto L125
        L24b:
            r16 = r1
            goto L2b2
        L251:
            int r1 = r1 - r4
            goto L31d
        L256:
            r7 = 2
            goto L292
        L25b:
            r2 = r4
            goto L34e
        L260:
            java.lang.object r15 = r2.L$3
            goto L354
        L266:
            java.lang.object r9 = r2.L$0
            goto L2b7
        L26c:
            p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532 r6 = (p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532) r6
            kotlin.ResultKt.throwOnFailure(r1)     // Catch: java.lang.Exception -> L22c
        L271:
            goto L200
        L275:
            if (r4 != r8) goto L27a
            goto L343
        L27a:
            goto L14b
        L27e:
            goto L194
        L281:
            java.lang.IllegalStateException r0 = new java.lang.IllegalStateException
            goto L1e6
        L287:
            r0.f5305c22e = r1
            goto L1b6
        L28d:
            r2 = r1
            goto L1fa
        L292:
            r8 = 1
            goto L4
        L297:
            java.lang.object r10 = r2.L$8
            goto L1e0
        L29d:
            androidx.paging.RemoteMediator$MediatorResult r0 = (androidx.paging.RemoteMediator.MediatorResult) r0
            goto L2c0
        L2a3:
            if (r3 != 0) goto L2a8
            goto L1a5
        L2a8:
            goto L176
        L2ac:
            java.lang.object r11 = r2.L$7
            goto L32f
        L2b2:
            r1 = r0
            goto L154
        L2b7:
            p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532 r9 = (p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532) r9
            kotlin.ResultKt.throwOnFailure(r1)     // Catch: java.lang.Exception -> L22c
            goto L341
        L2c0:
            return r0
        L2c1:
            goto L311
        L2c5:
            if (r1 != 0) goto L2ca
            goto L2c1
        L2ca:
            goto L162
        L2ce:
            return r0
        L2cf:
            goto L115
        L2d3:
            p1e11b989.p9acb4454.p07214c67.pf7a6e566 r6 = (p1e11b989.p9acb4454.p07214c67.pf7a6e566) r6
            goto L266
        L2d9:
            r0 = 27
            goto L347
        L2e0:
            java.util.IEnumerator r14 = (java.util.IEnumerator) r14
            goto L260
        L2e6:
            java.util.HashDictionary r5 = (java.util.HashDictionary) r5
            goto Ld
        L2ec:
            r0.<init>(r8)
            goto L2ce
        L2f3:
            goto L2cf
        L2f6:
            goto L1be
        L2fa:
            r4 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L1f5
        L300:
            int r0 = r2.I$0
            goto L18b
        L306:
            goto L101
        L308:
            goto L281
        L30c:
            throw r0
        L30d:
            goto L219
        L311:
            androidx.paging.RemoteMediator$MediatorResult$Success r0 = new androidx.paging.RemoteMediator$MediatorResult$Success
            goto L2ec
        L317:
            int r0 = r2.I$0
            goto L198
        L31d:
            r2.fd304ba20 = r1
            goto L1a4
        L323:
            r1 = r20
            goto L35a
        L329:
            int r0 = r0 + r1
            goto L205
        L32f:
            java.lang.stringBuilder r11 = (java.lang.stringBuilder) r11
            goto L138
        L335:
            int r3 = r2.fd304ba20
            goto L2fa
        L33b:
            int r0 = r2.I$0
            goto L170
        L341:
            goto L93
        L343:
            goto L33b
        L347:
            r1 = 20
            goto L329
        L34e:
            goto Lee
        L350:
            goto L317
        L354:
            java.util.ICollection r15 = (java.util.ICollection) r15
            goto L12c
        L35a:
            bool r2 = r1 is p1e11b989.p9acb4454.pb3f20355.pfee6447a.pd2d24532$pec4d1eb3$1
            goto L159
        L360:
            java.lang.int r1 = r17.ma8371dc9(r18)
            goto L2c5
        L368:
            r5 = 4
            goto L13
    }
}

