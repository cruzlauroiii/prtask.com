using Androidx.Lifecycle;
using Domain.Entities;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using P2b3583e6;
using P2e5d8aa3.Pf83c2a85.Pac143fb7;
using P582ca3f7.Pac143fb7;
using P83f5c3ad.P684019bc;
using P83f5c3ad.Pfd9160bb;
using P8a6f5038.Pac143fb7;
using P8a6f5038.Pfd9160bb;
using P8d777f38.Pb3f20355.Pd2a57dc1;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pad5f82e8.P07214c67.Pfa547353;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pad5f82e8.Pac143fb7.P49f290d6;
using Pcbead733.Pfd9160bb;
using Pd2a57dc1.Pfd9160bb;
using Pe0212e54.Pac143fb7;
using Pfa53b91c.P913f9c49.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p5c6338ce : objectModel {
    private readonly MutableLiveData f0145f149;
    private readonly pe9ddd6b8 f10b47833;
    private readonly p2f3c4196 f12f2c0ff;
    private readonly MutableLiveData f13cd8be6;
    private readonly MutableLiveData<Event<object>> f177ac935;
    private readonly pe9ddd6b8 f18eeba9c;
    private readonly MutableLiveData f222fdf98;
    private readonly p4b8940c0 f34e0178b;
    private readonly p69d862b4 f40cfdeeb;
    private readonly p1ceed351 f477bf499;
    private readonly pfcf088e9 f4b3896fc;
    private readonly MutableLiveData f4d25866f;
    private readonly pdcfa0c32 f4e22ce24;
    private readonly p2f3c4196 f56da1d0a;
    private readonly p6d29e2ef f5d537bfa;
    private readonly p1ceed351 f62520fad;
    private readonly pfcf088e9 f66163ca0;
    private readonly pd5a8ad07 f7cd2235f;
    private readonly p4b8940c0 f8c0e706f;
    private readonly pfcf088e9 f8e6487d9;
    private readonly p69d862b4 f972367b3;
    private readonly MutableLiveData<Event<object>> f97d1efd1;
    private readonly p6d29e2ef f97e1f910;
    private readonly pfcf088e9 f9c274a9f;
    private readonly p168abf2d f9fd37df1;
    private readonly p6d29e2ef fa04fd38c;
    private readonly p11c216e8 fa5255de0;
    private readonly MutableLiveData faa10f037;
    private readonly pe9ddd6b8 fabfc6c5f;
    private readonly pd5a8ad07 fae6a8851;
    private readonly p6280b697 faf1a2641;
    private readonly p4b8940c0 fbfcfc817;
    private readonly p168abf2d fc4469539;
    private readonly MutableLiveData<pf8c8b903> fcbf49760;
    private readonly p6d29e2ef fce1dcbc6;
    private readonly pdcfa0c32 fce765563;
    private readonly MutableLiveData fcf95c854;
    private readonly MutableLiveData fd4a34339;
    private readonly p168abf2d fd802fce8;
    private readonly pfcf088e9 fd94b9eaa;
    private readonly p4b8940c0 fda1713fa;
    private readonly p69d862b4 fde9ea52d;
    private readonly p69d862b4 fe399a0a8;
    private readonly p6280b697 fe5cd47ae;
    private readonly p2f3c4196 fe639d08f;
    private readonly p6280b697 fe8f94695;
    private readonly p4b8940c0 fe9b05b65;
    private readonly p1ceed351 fec9384d8;
    private readonly p168abf2d fed1ddd53;
    private readonly p11c216e8 feefeb260;
    private readonly pd5a8ad07 ff3395cd5;
    private readonly p11c216e8 ff667cb6e;
    private readonly pdcfa0c32 ff777672a;
    private readonly pdcfa0c32 fffd3e3bb;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((22 + 26) % 26) > 0) goto L11;
        L11:
            int[] r0 = new int[p8ab1a15b.Values.length];
            r0[p8ab1a15b.faa7df3ed.ordinal()] = 1;     // Catch: NoSuchFieldError -> L26
        L30:
            r0[p8ab1a15b.fc457d59a.ordinal()] = 2;     // Catch: NoSuchFieldError -> L27
        L23:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    public p5c6338ce(p168abf2d r2, p69d862b4 r3, p4b8940c0 r4, p6d29e2ef r5, pe9ddd6b8 r6, p2f3c4196 r7, pdcfa0c32 r8, p11c216e8 r9, pd5a8ad07 r10, p1ceed351 r11, pfcf088e9 r12, p6280b697 r13) {
        Intrinsics.checkNotNullParameter(r2, "pinUseCase");
        Intrinsics.checkNotNullParameter(r3, "employeesUseCase");
        Intrinsics.checkNotNullParameter(r4, "devicesUseCase");
        Intrinsics.checkNotNullParameter(r5, "applicationStateRepository");
        Intrinsics.checkNotNullParameter(r6, "activationTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r7, "userInfoUseCase");
        Intrinsics.checkNotNullParameter(r8, "paymentHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r9, "flowRouter");
        Intrinsics.checkNotNullParameter(r10, "router");
        Intrinsics.checkNotNullParameter(r11, "tapOnPhoneRouter");
        Intrinsics.checkNotNullParameter(r12, "authDeviceRouter");
        Intrinsics.checkNotNullParameter(r13, "splashRouter");
        this.fed1ddd53 = r2;
        this.f972367b3 = r3;
        this.fda1713fa = r4;
        this.f97e1f910 = r5;
        this.f18eeba9c = r6;
        this.fe639d08f = r7;
        this.fce765563 = r8;
        this.feefeb260 = r9;
        this.ff3395cd5 = r10;
        this.f62520fad = r11;
        this.f66163ca0 = r12;
        this.faf1a2641 = r13;
        this.fcbf49760 = new MutableLiveData();
        this.f177ac935 = new p6a6d86aa();
        this.f97d1efd1 = new p6a6d86aa();
    }

    public static readonly /* synthetic */ object m1284aa01(p5c6338ce r0, Continuation r1) {
        return r0.m4d4a2367(r1);
    }

    public static readonly /* synthetic */ object m1691f79d(p5c6338ce r0, Continuation r1) {
        return r0.me5aba296(r1);
    }

    public static readonly /* synthetic */ p69d862b4 m2870858d(p5c6338ce r0) {
        return r0.f972367b3;
    }

    public static readonly /* synthetic */ object m35bacdbd(p5c6338ce r0, string r1, pf8c8b903 r2, Continuation r3) {
        return r0.m79e51dec(r1, r2, r3);
    }

    public static readonly /* synthetic */ MutableLiveData m44fe6253(p5c6338ce r0) {
        return r0.fcbf49760;
    }

    private readonly object M4d4a2367(Continuation<bool> r10) {
        if (((22 + 25) % 25) > 0) goto L59;
    L59:
        SafeContinuation r0 = new SafeContinuation(IntrinsicsKt.intercepted(r10));
        SafeContinuation r1 = r0;
        if (this.f18eeba9c.isActivatedCache() == true) goto L43;
        if (this.fe639d08f.hasTopToken() == true) goto L3;
        Result.Companion r9 = Result.Companion;
        r1.resumeWith(Result.m1390constructorimpl(Boxing.boxbool(false)));
    L71:
        object r92 = r0.getOrThrow();
        if (r92 == IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L13;
    L11:
        return r92;
    L13:
        DebugProbesKt.probeCoroutineSuspended(r10);
        goto L11
    L3:
        this.fe639d08f.clearTopToken();
        Result.Companion r93 = Result.Companion;
        r1.resumeWith(Result.m1390constructorimpl(Boxing.boxbool(true)));
        goto L71
    L43:
        this.f97d1efd1.setValue(pa4ecfc70.f910eef8c.loading());
        this.feefeb260.setResultListener(this.f62520fad.getTophConsoleoutKey(), new p5c6338ce$p4d4a2367$2$1(r1));
        this.feefeb260.startFlow(p1ceed351.pb0da8397.me3d62dc6(this.f62520fad, p15913342.f9cba22d7, null, null, null, 14, null));
        goto L71
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r10v0, types: [java.lang.object, p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v1 */
    /* JADX WARN: Type inference failed for: r10v13, types: [p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v17 */
    /* JADX WARN: Type inference failed for: r10v18 */
    /* JADX WARN: Type inference failed for: r10v2, types: [p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v23, types: [p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v25, types: [java.lang.object, p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v26, types: [java.lang.object, p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v28 */
    /* JADX WARN: Type inference failed for: r10v29, types: [java.lang.object, p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v31, types: [java.lang.object, p8a6f5038.p2486923a.p5c6338ce] */
    /* JADX WARN: Type inference failed for: r10v32 */
    /* JADX WARN: Type inference failed for: r10v33 */
    /* JADX WARN: Type inference failed for: r10v34 */
    /* JADX WARN: Type inference failed for: r10v35 */
    /* JADX WARN: Type inference failed for: r10v36 */
    /* JADX WARN: Type inference failed for: r10v37 */
    /* JADX WARN: Type inference failed for: r10v38 */
    /* JADX WARN: Type inference failed for: r10v5 */
    /* JADX WARN: Type inference failed for: r10v8 */
    /* JADX WARN: Type inference failed for: r12v15 */
    /* JADX WARN: Type inference failed for: r12v18 */
    /* JADX WARN: Type inference failed for: r12v20 */
    /* JADX WARN: Type inference failed for: r9v2 */
    private readonly object M79e51dec(string r11, pf8c8b903 r12, Continuation<Unit> r13) {
        if (((26 + 14) % 14) > 0) goto L144;
    L144:
        if ((r13 is p5c6338ce$p79e51dec$1) == true) goto L52;
    L40:
        p5c6338ce$p79e51dec$1 r0 = new p5c6338ce$p79e51dec$1(this, r13);
    L60:
        object r132 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L167;
        ResultKt.throwOnFailure(r132);
        ?? this = this;
        if (r11 is null) goto L121;
        r0.L$0 = this;     // Catch: Exception -> L22
        r0.L$1 = r11;     // Catch: Exception -> L22
        r0.L$2 = r12;     // Catch: Exception -> L22
        r0.fd304ba20 = 1;     // Catch: Exception -> L22
        r132 = me5aba296(r0);     // Catch: Exception -> L22
        ?? r10 = this;
        if (r132 == r1) goto L124;
    L106:
        ?? r102 = r10;
        if (Intrinsics.areEqual(r11, (string) r132) == true) goto L118;
        r0.L$0 = r10;     // Catch: Exception -> L22
        r0.L$1 = r11;     // Catch: Exception -> L22
        r0.L$2 = r12;     // Catch: Exception -> L22
        r0.fd304ba20 = 2;     // Catch: Exception -> L22
        r132 = r10.m4d4a2367(r0);     // Catch: Exception -> L22
        ?? r103 = r10;
        if (r132 == r1) goto L124;
    L111:
        r102 = r103;
        if (((bool) r132).boolValue() == false) goto L118;
        pdcfa0c32 r133 = r103.fce765563;     // Catch: Exception -> L22
        r0.L$0 = r103;     // Catch: Exception -> L22
        r0.L$1 = r11;     // Catch: Exception -> L22
        r0.L$2 = r12;     // Catch: Exception -> L22
        r0.fd304ba20 = 3;     // Catch: Exception -> L22
        if (r133.setTapOnPhonePaymentsEnabled(false, r0) == r1) goto L124;
        pf8c8b903 r9 = r12;
        ?? r122 = r103;
        pf8c8b903 r104 = r9;
    L117:
        ?? r92 = r122;
        r12 = r104;
        r102 = r92;
    L118:
        p4b8940c0 r134 = r102.fda1713fa;     // Catch: Exception -> L22
        r0.L$0 = r102;     // Catch: Exception -> L22
        r0.L$1 = r12;     // Catch: Exception -> L22
        r0.L$2 = null;     // Catch: Exception -> L22
        r0.fd304ba20 = 4;     // Catch: Exception -> L22
        this = r102;
        if (r134.applyDevice(r11, r0) != r1) goto L121;
    L124:
        return r1;
    L121:
        if (r12 is null) goto L125;
        p69d862b4 r112 = this.f972367b3;     // Catch: Exception -> L22
        r0.L$0 = this;     // Catch: Exception -> L22
        r0.L$1 = null;     // Catch: Exception -> L22
        r0.fd304ba20 = 5;     // Catch: Exception -> L22
        if (r112.applyEmployee(r12, r0) == r1) goto L124;
    L125:
        this.f97e1f910.setShowConsoleoutPin(true);     // Catch: Exception -> L22
        this.f97d1efd1.setValue(pa4ecfc70.p910eef8c.m02f94ccf(pa4ecfc70.f910eef8c, null, 1, null));     // Catch: Exception -> L22
        return Unit.INSTANCE;
    L167:
        if (r2 == 1) goto L140;
        if (r2 == 2) goto L151;
        if (r2 == 3) goto L32;
        if (r2 == 4) goto L36;
        if (r2 != 5) goto L50;
        this = (p5c6338ce) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L22
        goto L125
    L50:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L36:
        pf8c8b903 r105 = (pf8c8b903) r0.L$1;
        p5c6338ce r113 = (p5c6338ce) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L89
        r12 = r105;
        this = r113;
    L89:
        e = move-exception;
        e = e;
        this = r113;
    L166:
        Exception r114 = e;
        this.f97d1efd1.setValue(pa4ecfc70.f910eef8c.error(r114));
        throw new Exception(r114);
    L32:
        r104 = (pf8c8b903) r0.L$2;
        r11 = (string) r0.L$1;
        p5c6338ce r123 = (p5c6338ce) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L28
        r122 = r123;
        goto L117
    L151:
        pf8c8b903 r106 = (pf8c8b903) r0.L$2;
        r11 = (string) r0.L$1;
        p5c6338ce r124 = (p5c6338ce) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L28
        r12 = r106;
        r103 = r124;
    L28:
        e = e;
        this = r12;
        goto L166
    L140:
        r12 = (pf8c8b903) r0.L$2;
        r11 = (string) r0.L$1;
        p5c6338ce r107 = (p5c6338ce) r0.L$0;
        ResultKt.throwOnFailure(r132);     // Catch: Exception -> L22
        r10 = r107;
    L22:
        e = e;
        goto L166
    L52:
        r0 = (p5c6338ce$p79e51dec$1) r13;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L40;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L60
    }

    public static readonly /* synthetic */ MutableLiveData mc04d5e88(p5c6338ce r0) {
        return r0.f177ac935;
    }

    private readonly object Me5aba296(Continuation<string> r5) {
        if (((31 + 17) % 17) > 0) goto L63;
    L63:
        if ((r5 is p5c6338ce$pe5aba296$1) == true) goto L52;
    L14:
        p5c6338ce$pe5aba296$1 r0 = new p5c6338ce$pe5aba296$1(this, r5);
    L22:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L40;
        ResultKt.throwOnFailure(r52);
        p4b8940c0 r4 = this.fda1713fa;     // Catch: Exception -> L31
        r0.fd304ba20 = 1;     // Catch: Exception -> L31
        r52 = r4.getSelectedDevice(r0);     // Catch: Exception -> L31
        if (r52 != r1) goto L20;
        return r1;
    L20:
        return ((p4f30e9bd) r52).getDeviceId();
    L40:
        if (r2 != 1) goto L12;
        ResultKt.throwOnFailure(r52);     // Catch: Exception -> L31
        goto L20
    L12:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L59:
        return null;
    L52:
        r0 = (p5c6338ce$pe5aba296$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L14;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L22
    }

    public static readonly /* synthetic */ p168abf2d me660f895(p5c6338ce r0) {
        return r0.fed1ddd53;
    }

    public readonly LiveData<Event<object>> GetApplyEmployeeStatus() {
        return this.f97d1efd1;
    }

    public readonly void GetEmployee() {
        if (((30 + 7) % 7) > 0) goto L30;
    L30:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p5c6338ce$pfb68daca$1(this, null), 3, null);
    }

    public readonly LiveData<pf8c8b903> GetEmployeeLiveData() {
        return this.fcbf49760;
    }

    public readonly string GetEmployeeName(pf8c8b903 r2) {
        Intrinsics.checkNotNullParameter(r2, "employee");
        return this.f972367b3.getEmployeeName(r2);
    }

    public readonly LiveData<Event<object>> GetPinValidationStatus() {
        return this.f177ac935;
    }

    public readonly void OpenNextScreen(p8ab1a15b r2) {
        Intrinsics.checkNotNullParameter(r2, "showPinRoute");
        if (p12c674ac.$EnumSwitchDictionaryping$0[r2.ordinal()] == 1) goto L20;
        this.f66163ca0.replaceAuthDevice();
        return;
    L20:
        this.ff3395cd5.back();
    }

    public readonly void OpenPreviousScreen(p8ab1a15b r2) {
        Intrinsics.checkNotNullParameter(r2, "showPinRoute");
        if (p12c674ac.$EnumSwitchDictionaryping$0[r2.ordinal()] != 2) goto L3;
        this.ff3395cd5.back();
        return;
    L3:
        this.faf1a2641.startSplashFlow();
    }

    public readonly void ValidatePin(string r9, pf8c8b903 r10, string r11) {
        if (((17 + 18) % 18) > 0) goto L23;
    L23:
        Intrinsics.checkNotNullParameter(r9, "pin");
        Intrinsics.checkNotNullParameter(r10, "employee");
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new p5c6338ce$p8f946205$1(this, r9, r10, r11, null), 3, null);
    }
}

