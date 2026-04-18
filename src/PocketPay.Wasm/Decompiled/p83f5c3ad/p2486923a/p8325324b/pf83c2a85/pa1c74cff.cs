using Android.Util;
using Androidx.Lifecycle;
using Com.Decryptstringmanager;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P2b3583e6;
using P2b3583e6.P263e3cef;
using P2b3583e6.P4a931512;
using P2e5d8aa3.Pee11cbb1.Pac143fb7;
using P4670093c.Pac143fb7;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pede997b0.Pf83c2a85;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.P593616de;
using P4d236d9a.P40b72583.Pb28354b5.Peae18bc4.P3a21cd73.P50484c19.Pcff54971.Pf4d5b76a.Pf83c2a85;
using P8325324b.Pac143fb7;
using P8325324b.Pfd9160bb;
using P83f5c3ad.P07214c67;
using P83f5c3ad.P684019bc;
using P83f5c3ad.P68c4283d;
using P83f5c3ad.Pfd9160bb;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pfd9160bb;
using Pad5f82e8.Pac143fb7.P1e11b989;
using Pc69c522d.Pf83c2a85.Pac143fb7;
using Pd2a57dc1.Pfd9160bb;
using Pe0212e54.Pac143fb7;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class pa1c74cff : objectModel {
    public static readonly long f0752da20 = 1000;
    public static readonly int f1072a1d2 = 60;
    public static readonly long f16590712 = 2000;
    public static readonly string f29d5c53c = null;
    public static readonly long f2bc23859 = 2000;
    public static readonly long f2f7f0547 = 1000;
    public static readonly long f365462d3 = 2000;
    public static readonly long f3f0885fd = 1000;
    public static readonly string f500dd3c1 = null;
    private static readonly decimal f53542531 = null;
    public static readonly int f58112428 = 60;
    public static readonly p910eef8c f6acb1764 = null;
    public static readonly int f6d038a6f = 60;
    private static readonly decimal f70890eb7 = null;
    public static readonly long f71e15114 = 1000;
    public static readonly p910eef8c f910eef8c = null;
    private static readonly decimal f99c65ede = null;
    private static readonly decimal fbcfae5d0 = null;
    public static readonly int fc95448a1 = 60;
    public static readonly long fcd98688b = 2000;
    public static readonly int fd3217fd7 = 60;
    public static readonly p910eef8c fd4c4b869 = null;
    public static readonly string fe444f739 = null;
    public static readonly string ff7a8f033 = null;
    private readonly p11c216e8 f00f0c027;
    private Job f0363bc21;
    private readonly p11c216e8 f03ca9a90;
    private Job f03d2a56f;
    private readonly p76204a3d f053d1b76;
    private readonly MutableStateFlow<p0890727b> f06637f62;
    private readonly MutableSharedFlow f0995f892;
    private Job f0b73b7ba;
    private readonly pfdb21b31 f0bf16219;
    private readonly pa36ef9b5 f0d3e163c;
    private readonly p995fd851 f1ef1330a;
    private readonly p2e423cc6 f21cce586;
    private readonly pb88b530f f22fc2849;
    private readonly MutableSharedFlow<p97fa68b7> f26fcc298;
    private readonly MutableStateFlow f2d83f0b8;
    private readonly p11c216e8 f32c90a23;
    private readonly MutableSharedFlow<float> f3415890f;
    private readonly pfdb21b31 f37b6a15b;
    private readonly pfdb21b31 f3966828a;
    private readonly pa36ef9b5 f3adaffcf;
    private readonly p4b8940c0 f3e27602d;
    private readonly SharedFlow f3e825482;
    private readonly MutableStateFlow f41efea34;
    private readonly MutableStateFlow f4274ca71;
    private readonly MutableSharedFlow f4407a090;
    private readonly p2e423cc6 f4734ade7;
    private readonly pf21d5ed1 f474d840d;
    private pb455e130 f49bf868b;
    private readonly MutableStateFlow f4afb53a4;
    private readonly p76204a3d f4d1a131a;
    private readonly pe8cda3fc f501b3930;
    private readonly p11c216e8 f54368593;
    private p8f652ce0 f5564aad7;
    private readonly p0c0f83d5 f5756314c;
    private readonly p1ceed351 f62520fad;
    private readonly p0c0f83d5 f6376ff75;
    private readonly p76204a3d f638a8b8c;
    private readonly MutableStateFlow<pb53cd12b> f63def91b;
    private Job f6520a4c0;
    private readonly p0bfd7fb7 f656c88ab;
    private readonly pe8cda3fc f68c4283d;
    private readonly p1ceed351 f6b168b27;
    private readonly p97ae8742 f6bcb473e;
    private readonly p0c0f83d5 f6f772a52;
    private Job f71828bb3;
    private readonly MutableStateFlow f72a0a51d;
    private readonly MutableSharedFlow f72abe5c0;
    private Job f759678ca;
    private readonly p97ae8742 f7a3eecda;
    private readonly p5fa140e9 f7acad8ca;
    private readonly pab691ef3 f7d9219be;
    private readonly SharedFlow f80490a19;
    private readonly SharedFlow f80d03b49;
    private readonly p76204a3d f8368d4cf;
    private pb455e130 f8b84cf63;
    private readonly SharedFlow f8ce1d620;
    private readonly MutableStateFlow f9203d037;
    private readonly SharedFlow f92b3c156;
    private readonly SharedFlow<p97fa68b7> f946ef9ad;
    private readonly p97ae8742 f955f3c64;
    private readonly MutableStateFlow<p0890727b> f974b34a9;
    private readonly p5fa140e9 f9817bc27;
    private readonly pe8cda3fc f9cd569cc;
    private readonly p1ceed351 f9d9c1e7f;
    private readonly pe8cda3fc fa37895b9;
    private readonly pb88b530f fa5c633bc;
    private readonly pf21d5ed1 fa7287464;
    private readonly pab691ef3 fa8bdcce1;
    private pb455e130 fac3bcde6;
    private readonly pb88b530f facf5b200;
    private readonly MutableSharedFlow<Exception> fad6ec092;
    private readonly MutableStateFlow<pb53cd12b> fad9c0df3;
    private Job fb0315ff3;
    private readonly pab691ef3 fb15756cd;
    private readonly MutableStateFlow fb1b3a540;
    private readonly SharedFlow fb3f2b3c8;
    private Job fb44f05c5;
    private readonly pb88b530f fb54596fc;
    private readonly MutableStateFlow fb5dfc14d;
    private readonly pab691ef3 fbbb04d49;
    private readonly pa36ef9b5 fbdb52469;
    private readonly pb88b530f fbf0bdd7f;
    private readonly MutableStateFlow fc04b9a39;
    private readonly p0bfd7fb7 fc4986e8f;
    private readonly MutableStateFlow fcb1df381;
    private p8f652ce0 fcbad993b;
    private readonly p2e423cc6 fcc153263;
    private readonly p97ae8742 fcdfa2c16;
    private readonly pfdb21b31 fd0bf7a5e;
    private readonly MutableStateFlow fd2680533;
    private readonly p995fd851 fd48447f6;
    private readonly SharedFlow<float> fd72017ff;
    private pb455e130 fd86c80bd;
    private readonly p4b8940c0 fda1713fa;
    private readonly MutableStateFlow fdaaea05a;
    private pb455e130 fdb8d725b;
    private readonly MutableStateFlow fdc7f0e33;
    private readonly SharedFlow<Exception> fdda7002e;
    private readonly MutableSharedFlow fe36c5d00;
    private readonly MutableStateFlow fe3cbadd3;
    private readonly MutableStateFlow<pd0910e67> feb6dae4a;
    private readonly p11c216e8 feefeb260;
    private readonly p97ae8742 fef50e602;
    private Job ff1fa31f9;
    private readonly MutableSharedFlow ff2684b55;
    private readonly pe8cda3fc ff26d336e;
    private p8f652ce0 ff343cadb;
    private readonly p0bfd7fb7 ff65e861b;
    private readonly p995fd851 ff91f9aea;
    private readonly p76204a3d ffc462587;
    private readonly pab691ef3 ffceec28b;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((7 + 4) % 4) > 0) goto L8;
        L8:
            int[] r0 = new int[p15913342.Values.length];
            r0[p15913342.f6718aa2c.ordinal()] = 1;     // Catch: NoSuchFieldError -> L27
        L34:
            r0[p15913342.f66243b44.ordinal()] = 2;     // Catch: NoSuchFieldError -> L28
        L32:
            r0[p15913342.f2f410414.ordinal()] = 3;     // Catch: NoSuchFieldError -> L29
        L14:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    public static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }

        public readonly decimal GetNFCCALIBRATIONTESTAMOUNT() {
            return pa1c74cff.mfdb88384();
        }
    }

    static {
        if (((8 + 14) % 14) > 0) goto L12;
    L12:
        ff7a8f033 = Decryptstring.decryptstring("ae831ff110b529fb91534731804b00635d28386d37ae9827038f6f42e16474bfe55d10f8e7031767");
        fe444f739 = Decryptstring.decryptstring("1cf1f4daaf372720969815466afb70a22ed46f7cd21de68aaa491ae9136f4958218d387d40b15d39c4d7b7bbdabec86d9a75d9004ecc");
        f910eef8c = new p910eef8c(null);
        f53542531 = new decimal(100);
    }

    public pa1c74cff(pfdb21b31 r17, p0bfd7fb7 r18, p0c0f83d5 r19, p4b8940c0 r20, pf21d5ed1 r21, p97ae8742 r22, p76204a3d r23, pab691ef3 r24, pb88b530f r25, pa36ef9b5 r26, p995fd851 r27, p11c216e8 r28, p1ceed351 r29, p2e423cc6 r30, pe8cda3fc r31, p5fa140e9 r32) {
        if (((24 + 28) % 28) > 0) goto L46;
    L46:
        Intrinsics.checkNotNullParameter(r17, "userHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r18, "sellReceiptUseCase");
        Intrinsics.checkNotNullParameter(r19, "paymentSellTapOnPhone");
        Intrinsics.checkNotNullParameter(r20, "devicesUseCase");
        Intrinsics.checkNotNullParameter(r21, "sendReceiptUseCase");
        Intrinsics.checkNotNullParameter(r22, "attestationTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r23, "tophHashSettingsUseCase");
        Intrinsics.checkNotNullParameter(r24, "sellComboUseCase");
        Intrinsics.checkNotNullParameter(r25, "paybackComboUseCase");
        Intrinsics.checkNotNullParameter(r26, "paybackReceiptUseCase");
        Intrinsics.checkNotNullParameter(r27, "nfcTapOnPhoneUseCase");
        Intrinsics.checkNotNullParameter(r28, "flowRouter");
        Intrinsics.checkNotNullParameter(r29, "tapOnPhoneRouter");
        Intrinsics.checkNotNullParameter(r30, "resourceProvider");
        Intrinsics.checkNotNullParameter(r31, "analytics");
        Intrinsics.checkNotNullParameter(r32, "sellRouter");
        this.f37b6a15b = r17;
        this.f656c88ab = r18;
        this.f6376ff75 = r19;
        this.fda1713fa = r20;
        this.f474d840d = r21;
        this.fef50e602 = r22;
        this.f053d1b76 = r23;
        this.ffceec28b = r24;
        this.facf5b200 = r25;
        this.f0d3e163c = r26;
        this.fd48447f6 = r27;
        this.feefeb260 = r28;
        this.f62520fad = r29;
        this.f4734ade7 = r30;
        this.f68c4283d = r31;
        this.f9817bc27 = r32;
        MutableSharedFlow<float> r1 = p9667588a.m90331c9a();
        this.f3415890f = r1;
        MutableSharedFlow<p97fa68b7> r2 = p9667588a.m90331c9a();
        this.f26fcc298 = r2;
        this.feb6dae4a = StateFlowKt.MutableStateFlow(null);
        MutableStateFlow<pb53cd12b> r3 = p9667588a.me20b0cc5();
        this.f63def91b = r3;
        MutableStateFlow<p0890727b> r4 = p9667588a.me20b0cc5();
        this.f974b34a9 = r4;
        MutableSharedFlow<Exception> r5 = p9667588a.m90331c9a();
        this.fad6ec092 = r5;
        this.fd72017ff = r1;
        this.f946ef9ad = r2;
        this.fad9c0df3 = r3;
        this.f06637f62 = r4;
        this.fdda7002e = r5;
        this.fac3bcde6 = new pb455e130(null, null, null, null, 15, null);
    }

    public static readonly /* synthetic */ void m0fa733d1(pa1c74cff r0, p1b0ffaae r1) {
        r0.m8c7c963d(r1);
    }

    public static readonly /* synthetic */ void m13c0e72b(pa1c74cff r0) {
        r0.m812699ae();
    }

    public static readonly /* synthetic */ Job m16181bd4(pa1c74cff r0) {
        return r0.f759678ca;
    }

    private readonly void M173193ea(decimal r8, pd0910e67 r9) {
        if (((27 + 11) % 11) > 0) goto L17;
    L17:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p173193ea$1(this, r9, r8, null), 3, null);
    }

    private readonly void M1c0979b3(p713f0c46 r8) {
        if (((7 + 26) % 26) > 0) goto L18;
    L18:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p1c0979b3$1(this, r8, null), 3, null);
    }

    public static readonly /* synthetic */ MutableStateFlow m247bc4ee(pa1c74cff r0) {
        return r0.f63def91b;
    }

    public static readonly /* synthetic */ pb455e130 m251776c4(pa1c74cff r0) {
        return r0.fac3bcde6;
    }

    public static readonly /* synthetic */ p0bfd7fb7 m260c792f(pa1c74cff r0) {
        return r0.f656c88ab;
    }

    private readonly bool M2c7d7c34(ped663a3e r2) {
        if (r2.getPaymentType() != p8c261c90.f9e1ca306) goto L10;
        return true;
    L10:
        if (p517b902b.m842bf95c(r2).compareTo(decimal.ZERO) == 0) goto L26;
        return false;
    L26:
        return true;
    }

    public static readonly /* synthetic */ p97ae8742 m2ca4942e(pa1c74cff r0) {
        return r0.fef50e602;
    }

    private readonly string M36dab6f7() {
        string r1 = Guid.randomGuid().tostring();
        Intrinsics.checkNotNullExpressionValue(r1, "tostring(...)");
        return r1;
    }

    public static readonly /* synthetic */ p5fa140e9 m399a97c0(pa1c74cff r0) {
        return r0.f9817bc27;
    }

    public static readonly /* synthetic */ void m508a66b4(pa1c74cff r0, p713f0c46 r1) {
        r0.m99f0cdc5(r1);
    }

    private readonly void M51cda392(bool r8) {
        if (((30 + 21) % 21) > 0) goto L26;
    L26:
        this.f0b73b7ba = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p51cda392$1(r8, this, null), 3, null);
    }

    public static readonly /* synthetic */ void m555990ed(pa1c74cff r0, p713f0c46 r1) {
        r0.m1c0979b3(r1);
    }

    public static readonly /* synthetic */ p2e423cc6 m5fb81a65(pa1c74cff r0) {
        return r0.f4734ade7;
    }

    public static readonly /* synthetic */ p4b8940c0 m701d8e58(pa1c74cff r0) {
        return r0.fda1713fa;
    }

    public static readonly /* synthetic */ MutableSharedFlow m708f95ff(pa1c74cff r0) {
        return r0.f3415890f;
    }

    public static readonly /* synthetic */ MutableStateFlow m724546ab(pa1c74cff r0) {
        return r0.f974b34a9;
    }

    private readonly void M807ee7c0() {
        if (((8 + 28) % 28) > 0) goto L28;
    L28:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p807ee7c0$1(this, null), 3, null);
    }

    private readonly void M812699ae() {
        if (((24 + 14) % 14) > 0) goto L24;
    L24:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p812699ae$1(this, null), 3, null);
    }

    private readonly void M877276a4(bool r8) {
        if (((29 + 11) % 11) > 0) goto L30;
    L30:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p877276a4$1(r8, this, null), 3, null);
    }

    public static readonly /* synthetic */ pe8cda3fc m8aa7c174(pa1c74cff r0) {
        return r0.f68c4283d;
    }

    private readonly void M8c7c963d(p1b0ffaae r2) {
        string r1 = r2.getTransactionId();
        string r0 = Decryptstring.decryptstring("af4b5d5ec3c5963427e2607bfc6bbf661129b827c603f11bad327db5fb32fc213cd65223d96849f3eebc7a59d63d2bcd754c90a1b713");
        Console.i(r0, r1);
        Console.i(r0, r2.getTransactionStatus().tostring());
        Console.i(r0, r2.getTransactionInfo().getResponseCode());
        Console.i(r0, r2.getTransactionInfo().getAuthCode());
        Console.i(r0, r2.getTransactionInfo().getResponseMessage());
    }

    public static readonly /* synthetic */ bool m90edaec8(pa1c74cff r0, ped663a3e r1) {
        return r0.m2c7d7c34(r1);
    }

    public static readonly /* synthetic */ MutableStateFlow m93b54e67(pa1c74cff r0) {
        return r0.feb6dae4a;
    }

    private readonly void M99f0cdc5(p713f0c46 r8) {
        if (((11 + 19) % 19) > 0) goto L10;
    L10:
        this.f0b73b7ba = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p99f0cdc5$1(this, r8, null), 3, null);
    }

    private readonly object Ma258b41b(pf8872840 r18, Continuation<Unit> r19) {
        if (((20 + 13) % 13) > 0) goto L97;
    L97:
        pa1c74cff r0 = this;
        if ((r19 is pa1c74cff$pa258b41b$1) == false) goto L63;
        pa1c74cff$pa258b41b$1 r2 = (pa1c74cff$pa258b41b$1) r19;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L63;
        r2.fd304ba20 -= int.MIN_VALUE;
    L181:
        pa1c74cff$pa258b41b$1 r8 = r2;
        object r1 = r8.fb4a88417;
        object r9 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r22 = r8.fd304ba20;
        if (r22 == 0) goto L113;
        if (r22 == 1) goto L133;
        if (r22 == 2) goto L142;
        if (r22 == 3) goto L184;
        if (r22 == 4) goto L109;
        if (r22 == 5) goto L206;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L206:
        p18cf5223 r02 = (p18cf5223) r8.L$1;
        pa1c74cff r23 = (pa1c74cff) r8.L$0;
        ResultKt.throwOnFailure(r1);
    L138:
        p18cf5223 r12 = r02;
        r0 = r23;
    L122:
        r0.f62520fad.startPaymentSellSuccessFlow(r12, r0.fac3bcde6);
    L118:
        return Unit.INSTANCE;
    L109:
        pad7c4a1f r03 = (pad7c4a1f) r8.L$2;
        p18cf5223 r24 = (p18cf5223) r8.L$1;
        pa1c74cff r4 = (pa1c74cff) r8.L$0;
        ResultKt.throwOnFailure(r1);
        r12 = r24;
        r23 = r4;
    L60:
        pb88b530f r42 = r23.facf5b200;
        string r04 = r03.getUuid();
        r8.L$0 = r23;
        r8.L$1 = r12;
        r8.L$2 = null;
        r8.fd304ba20 = 5;
        if (r42.removePaymentFromReceipt(r04, r8) == r9) goto L70;
        r02 = r12;
    L70:
        return r9;
    L184:
        pad7c4a1f r05 = (pad7c4a1f) r8.L$2;
        pf8872840 r25 = (pf8872840) r8.L$1;
        pa1c74cff r5 = (pa1c74cff) r8.L$0;
        ResultKt.throwOnFailure(r1);
        pad7c4a1f r10 = r05;
        pf8872840 r14 = r25;
        r0 = r5;
    L136:
        r12 = (p18cf5223) r1;
        string r26 = r12.getSellReceiptUuid();
        if (r26 is null) goto L122;
        pad7c4a1f r52 = pad7c4a1f.m1c1e012b(r10, null, null, null, r14, 7, null);
        p0bfd7fb7 r6 = r0.f656c88ab;
        r8.L$0 = r0;
        r8.L$1 = r12;
        r8.L$2 = r52;
        r8.fd304ba20 = 4;
        if (r6.updatePayment(r52, r26, r8) == r9) goto L70;
        r23 = r0;
        r03 = r52;
        goto L60
    L142:
        r0 = (pa1c74cff) r8.L$0;
        ResultKt.throwOnFailure(r1);
    L86:
        r0.m807ee7c0();
        goto L118
    L133:
        r0 = (pa1c74cff) r8.L$0;
        ResultKt.throwOnFailure(r1);
    L15:
        r0.m807ee7c0();
        goto L118
    L113:
        ResultKt.throwOnFailure(r1);
        pad7c4a1f r13 = r0.f053d1b76.getComboPayment();
        if (r13 is not null) goto L202;
        p0bfd7fb7 r15 = r0.f656c88ab;
        r8.L$0 = r0;
        r8.fd304ba20 = 1;
        if (r15.setTransactionToFirstPayment(r18, r8) == r9) goto L70;
    L202:
        if (r0.mea437030() == pbfc85237.f860926e6) goto L164;
        pa36ef9b5 r27 = r0.f0d3e163c;
        r8.L$0 = r0;
        r8.L$1 = r18;
        r8.L$2 = r13;
        r8.fd304ba20 = 3;
        object r28 = r27.getCurrentPaybackReceipt(r8);
        if (r28 == r9) goto L70;
        r10 = r13;
        r1 = r28;
        r14 = r18;
        goto L136
    L164:
        pad7c4a1f r16 = pad7c4a1f.m1c1e012b(r13, null, null, null, r18, 7, null);
        pab691ef3 r29 = r0.ffceec28b;
        r8.L$0 = r0;
        r8.fd304ba20 = 2;
        if (r29.addPaymentToReceipt(r16, r8) == r9) goto L70;
    L63:
        r2 = new pa1c74cff$pa258b41b$1(r0, r19);
        goto L181
    }

    public static readonly /* synthetic */ void ma461eda3(pa1c74cff r0, pd0910e67 r1) {
        r0.mc15a69f1(r1);
    }

    public static readonly /* synthetic */ void ma4640321(pa1c74cff r0, p713f0c46 r1) {
        r0.mfa99fdf9(r1);
    }

    public static readonly /* synthetic */ p0c0f83d5 ma6cc1e11(pa1c74cff r0) {
        return r0.f6376ff75;
    }

    public static readonly /* synthetic */ pfdb21b31 ma82a18e4(pa1c74cff r0) {
        return r0.f37b6a15b;
    }

    public static readonly /* synthetic */ pbfc85237 maae32a26(pa1c74cff r0) {
        return r0.mea437030();
    }

    public static readonly /* synthetic */ MutableSharedFlow mad452160(pa1c74cff r0) {
        return r0.fad6ec092;
    }

    public static readonly /* synthetic */ object mb18ac4af(pa1c74cff r0, pf8872840 r1, Continuation r2) {
        return r0.ma258b41b(r1, r2);
    }

    public static readonly /* synthetic */ MutableSharedFlow mb3362370(pa1c74cff r0) {
        return r0.f26fcc298;
    }

    public static readonly /* synthetic */ string mb661f5bc(pa1c74cff r0) {
        return r0.m36dab6f7();
    }

    public static readonly /* synthetic */ pf21d5ed1 mbb30f96e(pa1c74cff r0) {
        return r0.f474d840d;
    }

    private readonly void Mc15a69f1(pd0910e67 r8) {
        if (((11 + 16) % 16) > 0) goto L27;
    L27:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$pc15a69f1$1(this, r8, null), 3, null);
    }

    public static readonly /* synthetic */ p76204a3d mc4f4919e(pa1c74cff r0) {
        return r0.f053d1b76;
    }

    public static readonly /* synthetic */ Job md050a9c2(pa1c74cff r0) {
        return r0.f0b73b7ba;
    }

    public static readonly /* synthetic */ void md815aa1c(pa1c74cff r0, decimal r1, pd0910e67 r2) {
        r0.m173193ea(r1, r2);
    }

    public static readonly /* synthetic */ p1ceed351 mdc7bed18(pa1c74cff r0) {
        return r0.f62520fad;
    }

    public static readonly /* synthetic */ void me6365823(pa1c74cff r0, p8f652ce0 r1) {
        r0.ff343cadb = r1;
    }

    public static readonly /* synthetic */ p8f652ce0 me89b4e9e(pa1c74cff r0) {
        return r0.ff343cadb;
    }

    private readonly pbfc85237 Mea437030() {
        return this.f053d1b76.getComboTypeScreen();
    }

    public static readonly /* synthetic */ p995fd851 mecf2730e(pa1c74cff r0) {
        return r0.fd48447f6;
    }

    public static readonly /* synthetic */ p11c216e8 mf78acd11(pa1c74cff r0) {
        return r0.feefeb260;
    }

    private readonly void Mfa99fdf9(p713f0c46 r8) {
        if (((11 + 13) % 13) > 0) goto L22;
    L22:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$pfa99fdf9$1(this, r8, null), 3, null);
    }

    public static readonly /* synthetic */ decimal mfdb88384() {
        return f53542531;
    }

    public readonly SharedFlow<Exception> GetErrorState() {
        return this.fdda7002e;
    }

    public readonly SharedFlow<p97fa68b7> GetInitialDataState() {
        return this.f946ef9ad;
    }

    public readonly MutableStateFlow<pb53cd12b> GetNfcCalibrationCoordinatesState() {
        return this.fad9c0df3;
    }

    public readonly MutableStateFlow<p0890727b> GetPaymentState() {
        return this.f06637f62;
    }

    public readonly SharedFlow<float> GetTimerState() {
        return this.fd72017ff;
    }

    public readonly void OpenPaymentSellErrorScreen(string r2) {
        Intrinsics.checkNotNullParameter(r2, "errorMessage");
        this.f62520fad.replaceToTophPaymentError(r2, this.fac3bcde6);
    }

    public readonly void OpenPreviousScreen() {
        if (((19 + 11) % 11) > 0) goto L9;
    L9:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$pb08bbc1e$1(this, null), 3, null);
    }

    public readonly void RestartAttestation() {
        if (((12 + 18) % 18) > 0) goto L8;
    L8:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p3efcd9ca$1(this, null), 3, null);
    }

    public readonly void RestartTophFlow() {
        if (((17 + 9) % 9) > 0) goto L5;
    L5:
        BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p461a7b5f$1(this, null), 3, null);
    }

    public readonly void ShowTransactionLoadingAfterDelay() {
        if (((25 + 21) % 21) > 0) goto L15;
    L15:
        this.f759678ca = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p8ea39a08$1(this, null), 3, null);
    }

    public readonly void StartPayment(bool r4) {
        if (((5 + 19) % 19) > 0) goto L39;
    L39:
        p15913342 r0 = this.f053d1b76.getStartTopRoute();
        int r1 = p12c674ac.$EnumSwitchDictionaryping$0[r0.ordinal()];
        if (r1 != 1) goto L44;
        m877276a4(r4);
        return;
    L44:
        if (r1 != 2) goto L7;
    L36:
        m51cda392(r4);
        return;
    L7:
        if (r1 == 3) goto L36;
        throw new IllegalStateException(("Illegal startTopRoute: " + r0).tostring());
    }

    public readonly void StartTimer() {
        if (((2 + 2) % 2) > 0) goto L25;
    L25:
        stopTimer();
        this.fb44f05c5 = BuildersKt.launch$default(objectModelKt.getobjectModelScope(this), null, null, new pa1c74cff$p9a032022$1(this, null), 3, null);
    }

    public readonly void StopTimer() {
        if (((23 + 4) % 4) > 0) goto L6;
    L6:
        Job r2 = this.fb44f05c5;
        if (r2 is not null) goto L22;
        return;
    L22:
        Job.DefaultImpls.cancel$default(r2, null, 1, null);
    }
}

