using Com.Google.Gson;
using Java.Math;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using P2b3583e6.P19ad2780.P1e11b989;
using P2b3583e6.P4a931512;
using P2e5d8aa3.Pe0212e54.Pb3f20355;
using P4d236d9a.P2df4812c.Pf5d7e253.P705f8913.P518a4861.P8325324b.P86ccec3d;
using P582ca3f7.Pb3f20355;
using P8325324b.P07214c67.Pd77d5e50;
using P8325324b.P4b9f83e1;
using P8d777f38.Pb3f20355.P1e11b989;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.P4b9f83e1;
using Pad5f82e8.P07214c67.Pfa547353;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p9dc39adc : p3851083a {
    private readonly p7638dcb8 f04093f10;
    private readonly p2e423cc6 f207d4994;
    private readonly pfeb9ca41 f2bfcb628;
    private readonly pfeb9ca41 f41b17269;
    private readonly p2e423cc6 f4734ade7;
    private readonly p0c2c0436 f4c632831;
    private readonly pfeb9ca41 f5769ec15;
    private readonly pfeb9ca41 f64837f11;
    private readonly p2e423cc6 f67afdb4b;
    private readonly p7638dcb8 f7949eae8;
    private readonly p2d884c28 fbbcec403;
    private readonly p2d884c28 fc1883fa5;
    private readonly p2e423cc6 fcd05479f;
    private readonly pef9926d1 fd10299a2;
    private readonly pef9926d1 fd8f0064e;
    private readonly p2e423cc6 fe0efd1d3;
    private readonly p0c2c0436 fedc5f59e;
    private readonly p7638dcb8 ff2fed930;
    private readonly pfeb9ca41 ffa781974;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((6 + 18) % 18) > 0) goto L11;
        L11:
            int[] r0 = new int[ped8819d3.Values.length];
            r0[ped8819d3.f61a649a3.ordinal()] = 1;     // Catch: NoSuchFieldError -> L26
        L30:
            r0[ped8819d3.ff9dd946c.ordinal()] = 2;     // Catch: NoSuchFieldError -> L27
        L20:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    public p9dc39adc(pef9926d1 r2, p7638dcb8 r3, p0c2c0436 r4, p2d884c28 r5, pfeb9ca41 r6, p2e423cc6 r7) {
        Intrinsics.checkNotNullParameter(r2, "sellReceiptDbRepository");
        Intrinsics.checkNotNullParameter(r3, "receiptDbRepository");
        Intrinsics.checkNotNullParameter(r4, "employeesRepository");
        Intrinsics.checkNotNullParameter(r5, "localHashSettingsRepository");
        Intrinsics.checkNotNullParameter(r6, "devicesDbRepository");
        Intrinsics.checkNotNullParameter(r7, "resourceProvider");
        this.fd8f0064e = r2;
        this.ff2fed930 = r3;
        this.fedc5f59e = r4;
        this.fbbcec403 = r5;
        this.ffa781974 = r6;
        this.f4734ade7 = r7;
    }

    private readonly string M2a188a9f() {
        string r1 = Guid.randomGuid().tostring();
        Intrinsics.checkNotNullExpressionValue(r1, "tostring(...)");
        return r1;
    }

    private readonly object M2c2bcffd(Continuation<? super List<pa4e1ef7c>> r5) {
        if (((2 + 9) % 9) > 0) goto L31;
    L31:
        if ((r5 is p9dc39adc$p2c2bcffd$1) == true) goto L62;
    L13:
        p9dc39adc$p2c2bcffd$1 r0 = new p9dc39adc$p2c2bcffd$1(this, r5);
    L25:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L54;
        if (r2 != 1) goto L52;
        ResultKt.throwOnFailure(r52);     // Catch: Exception -> L18
    L58:
        return ((p2c903942) r52).getCurrentSellPositions();
    L52:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L54:
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;     // Catch: Exception -> L18
        r52 = md7b4f317(r0);     // Catch: Exception -> L18
        if (r52 != r1) goto L58;
        return r1;
    L23:
        return ICollectionsKt.emptyList();
    L62:
        r0 = (p9dc39adc$p2c2bcffd$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L13;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L25
    }

    public static readonly /* synthetic */ object m4ab4e0a4(p9dc39adc r0, Continuation r1) {
        return r0.m661f6c0a(r1);
    }

    public static readonly /* synthetic */ object m4b96c61a(p9dc39adc r0, string r1, Continuation r2) {
        return r0.m6cc3a56e(r1, r2);
    }

    public static readonly /* synthetic */ object m5e74564c(p9dc39adc r0, Continuation r1) {
        return r0.md7b4f317(r1);
    }

    private readonly object M63bfe3f4(string r5, Continuation<bool> r6) {
        if (((29 + 27) % 27) > 0) goto L76;
    L76:
        if ((r6 is p9dc39adc$p63bfe3f4$1) == true) goto L84;
    L40:
        p9dc39adc$p63bfe3f4$1 r0 = new p9dc39adc$p63bfe3f4$1(this, r6);
    L47:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        bool r3 = true;
        if (r2 == 0) goto L70;
        if (r2 != 1) goto L79;
        ResultKt.throwOnFailure(r62);
    L11:
        p2c903942 r63 = (p2c903942) r62;
        string r4 = null;
        if (r63 is not null) goto L63;
        List<pa4e1ef7c> r52 = null;
    L26:
        List<pa4e1ef7c> r53 = r52;
        if (r53 is not null) goto L59;
    L19:
        if (r63 is null) goto L34;
        pf79cee86 r54 = r63.getCurrentSellReceipt();
        if (r54 is null) goto L34;
        r4 = r54.getNote();
    L34:
        if (r4 is not null) goto L64;
        r3 = false;
    L64:
        return Boxing.boxbool(r3);
    L59:
        if (r53.Count == 0 == true) goto L19;
    L63:
        r52 = r63.getCurrentSellPositions();
        goto L26
    L79:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L70:
        ResultKt.throwOnFailure(r62);
        pef9926d1 r42 = this.fd8f0064e;
        r0.fd304ba20 = 1;
        r62 = r42.getSellReceiptByType(r5, "RECEIPT", r0);
        if (r62 != r1) goto L11;
        return r1;
    L84:
        r0 = (p9dc39adc$p63bfe3f4$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L40;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L47
    }

    private readonly object M661f6c0a(Continuation<pf79cee86> r5) {
        if (((27 + 18) % 18) > 0) goto L7;
    L7:
        if ((r5 is p9dc39adc$p661f6c0a$1) == false) goto L39;
        p9dc39adc$p661f6c0a$1 r0 = (p9dc39adc$p661f6c0a$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L39;
        r0.fd304ba20 -= int.MIN_VALUE;
    L50:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L14;
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = md7b4f317(r0);
        if (r52 != r1) goto L3;
        return r1;
    L3:
        return ((p2c903942) r52).getCurrentSellReceipt();
    L14:
        if (r2 != 1) goto L5;
        ResultKt.throwOnFailure(r52);
        goto L3
    L5:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L39:
        r0 = new p9dc39adc$p661f6c0a$1(this, r5);
        goto L50
    }

    private readonly object M6cc3a56e(string r28, Continuation<Unit> r29) {
        if (((3 + 26) % 26) > 0) goto L78;
    L78:
        p9dc39adc r0 = this;
        if ((r29 is p9dc39adc$p6cc3a56e$1) == true) goto L64;
    L73:
        p9dc39adc$p6cc3a56e$1 r2 = new p9dc39adc$p6cc3a56e$1(r0, r29);
    L116:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L150;
        if (r4 == 1) goto L121;
        if (r4 != 2) goto L46;
        ResultKt.throwOnFailure(r1);
    L136:
        return Unit.INSTANCE;
    L46:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L121:
        string r02 = (string) r2.L$3;
        string r42 = (string) r2.L$2;
        string r6 = (string) r2.L$1;
        p9dc39adc r8 = (p9dc39adc) r2.L$0;
        ResultKt.throwOnFailure(r1);
        string r14 = r02;
        string r10 = r6;
        r0 = r8;
    L115:
        string r13 = r42;
        string r12 = ((pf8c8b903) r1).getId();
        string r9 = r0.m2a188a9f();
        string r19 = r0.fbbcec403.getPaymentAddress();
        string r18 = r0.fbbcec403.getPaymentPlace();
        pf79cee86 r82 = new pf79cee86(r9, r10, p22820a6f.f52c9932e, r12, r13, r14, p8c261c90.fdf657148, r0.fbbcec403.getShouldPrintReceipt(), p5a409c20.f860926e6, r18, r19, null, null, null, null, true, true, null);
        pef9926d1 r03 = r0.fd8f0064e;
        List<p0160554c> r15 = ICollectionsKt.emptyList();
        List<p32a285cf> r43 = ICollectionsKt.emptyList();
        r2.L$0 = null;
        r2.L$1 = null;
        r2.L$2 = null;
        r2.L$3 = null;
        r2.fd304ba20 = 2;
        if (r03.createCurrentSellReceipt(r82, r15, r43, r2) != r3) goto L136;
    L35:
        return r3;
    L150:
        ResultKt.throwOnFailure(r1);
        pcb7684f4 r16 = r0.fbbcec403.getDefaultReceiptCredentials();
        if (r16 is null) goto L170;
        ped8819d3 r44 = r16.getSelectedValueType();
    L109:
        if (r44 is not null) goto L146;
        int r45 = -1;
    L100:
        if (r45 == 1) goto L67;
        if (r45 == 2) goto L38;
        string r17 = null;
        r42 = null;
    L143:
        p0c2c0436 r83 = r0.fedc5f59e;
        r2.L$0 = r0;
        r2.L$1 = r28;
        r2.L$2 = r42;
        r2.L$3 = r17;
        r2.fd304ba20 = 1;
        object r62 = r83.getSelectedEmployee(r2);
        if (r62 == r3) goto L35;
        r14 = r17;
        r1 = r62;
        r10 = r28;
        goto L115
    L38:
        r17 = r16.getPhone();
        r42 = null;
        goto L143
    L67:
        r42 = r16.getEmail();
        r17 = null;
        goto L143
    L146:
        r45 = p12c674ac.$EnumSwitchDictionaryping$0[r44.ordinal()];
        goto L100
    L170:
        r44 = null;
        goto L109
    L64:
        r2 = (p9dc39adc$p6cc3a56e$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L73;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L116
    }

    public static readonly /* synthetic */ object m81b26c46(p9dc39adc r0, Continuation r1) {
        return r0.maef0ec44(r1);
    }

    public static readonly /* synthetic */ object m983b4fc6(p9dc39adc r0, string r1, Continuation r2) {
        return r0.m63bfe3f4(r1, r2);
    }

    public static readonly /* synthetic */ object ma8fbd7bc(p9dc39adc r0, ped663a3e r1, string r2, Continuation r3) {
        return r0.mb6fc41ff(r1, r2, r3);
    }

    private readonly object Maef0ec44(Continuation<? super List<p32a285cf>> r5) {
        if (((11 + 8) % 8) > 0) goto L54;
    L54:
        if ((r5 is p9dc39adc$paef0ec44$1) == true) goto L37;
    L21:
        p9dc39adc$paef0ec44$1 r0 = new p9dc39adc$paef0ec44$1(this, r5);
    L43:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L66;
        if (r2 != 1) goto L60;
        ResultKt.throwOnFailure(r52);
    L30:
        return ((p2c903942) r52).getCurrentSellPayments();
    L60:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L66:
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = md7b4f317(r0);
        if (r52 != r1) goto L30;
        return r1;
    L37:
        r0 = (p9dc39adc$paef0ec44$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L21;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L43
    }

    private readonly object Mb6fc41ff(ped663a3e r2, string r3, Continuation<Unit> r4) {
        object r1 = this.fd8f0064e.createCurrentSellReceipt(p54789c03.m345be13d(r2, r3, true), p54789c03.m85b1d365(r2), p54789c03.m4b6a0ebe(r2), r4);
        if (r1 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r1;
    L5:
        return Unit.INSTANCE;
    }

    public static readonly /* synthetic */ object mb905c8ac(p9dc39adc r0, Continuation r1) {
        return r0.m2c2bcffd(r1);
    }

    private readonly object Md7b4f317(Continuation<p2c903942> r6) {
        if (((30 + 21) % 21) > 0) goto L75;
    L75:
        if ((r6 is p9dc39adc$pd7b4f317$1) == true) goto L28;
    L5:
        p9dc39adc$pd7b4f317$1 r0 = new p9dc39adc$pd7b4f317$1(this, r6);
    L68:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L49;
        ResultKt.throwOnFailure(r62);
        pfeb9ca41 r63 = this.ffa781974;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = r63.getSelectedDevice(r0);
        if (r62 != r1) goto L44;
    L29:
        return r1;
    L44:
        p6285e3eb r64 = (p6285e3eb) r62;
        pef9926d1 r5 = this.fd8f0064e;
        string r65 = r64.getDeviceId();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r52 = r5.getCurrentSellReceipt(r65, r0);
        if (r52 == r1) goto L29;
        return r52;
    L49:
        if (r2 == 1) goto L7;
        if (r2 != 2) goto L42;
        ResultKt.throwOnFailure(r62);
        return r62;
    L42:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L7:
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L44
    L28:
        r0 = (p9dc39adc$pd7b4f317$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L5;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L68
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object AddPaymentToReceipt(pad7c4a1f r7, Continuation<Unit> r8) {
        if (((27 + 8) % 8) > 0) goto L37;
    L37:
        if ((r8 is p9dc39adc$p89f84f65$1) == false) goto L73;
        p9dc39adc$p89f84f65$1 r0 = (p9dc39adc$p89f84f65$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L73;
        r0.fd304ba20 -= int.MIN_VALUE;
    L57:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L66;
        ResultKt.throwOnFailure(r82);
        pef9926d1 r83 = this.fd8f0064e;
        r0.L$0 = r83;
        r0.L$1 = r7;
        r0.fd304ba20 = 1;
        object r6 = m661f6c0a(r0);
        if (r6 != r1) goto L48;
    L19:
        return r1;
    L48:
        r82 = r6;
        pef9926d1 r62 = r83;
    L93:
        p32a285cf r72 = p54789c03.m6e4c3ee0(r7, ((pf79cee86) r82).getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r62.insertPayment(r72, r0) == r1) goto L19;
    L33:
        return Unit.INSTANCE;
    L66:
        if (r2 == 1) goto L63;
        if (r2 != 2) goto L70;
        ResultKt.throwOnFailure(r82);
        goto L33
    L70:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L63:
        r7 = (pad7c4a1f) r0.L$1;
        r62 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L73:
        r0 = new p9dc39adc$p89f84f65$1(this, r8);
        goto L57
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object AddPositionToReceipt(pd031d465 r7, Continuation<Unit> r8) {
        if (((30 + 2) % 2) > 0) goto L9;
    L9:
        if ((r8 is p9dc39adc$p234facb0$1) == false) goto L90;
        p9dc39adc$p234facb0$1 r0 = (p9dc39adc$p234facb0$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L90;
        r0.fd304ba20 -= int.MIN_VALUE;
    L16:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L47;
        if (r2 == 1) goto L81;
        if (r2 != 2) goto L85;
        ResultKt.throwOnFailure(r82);
    L74:
        return Unit.INSTANCE;
    L85:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L81:
        r7 = (pd031d465) r0.L$1;
        pef9926d1 r6 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L80:
        p0160554c r72 = p54789c03.mcf4608a5(r7, ((pf79cee86) r82).getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r6.insertPosition(r72, r0) != r1) goto L74;
    L42:
        return r1;
    L47:
        ResultKt.throwOnFailure(r82);
        pef9926d1 r83 = this.fd8f0064e;
        r0.L$0 = r83;
        r0.L$1 = r7;
        r0.fd304ba20 = 1;
        object r62 = m661f6c0a(r0);
        if (r62 == r1) goto L42;
        r82 = r62;
        r6 = r83;
    L90:
        r0 = new p9dc39adc$p234facb0$1(this, r8);
        goto L16
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object CheckDuplicateReceipt(string r5, Continuation<Unit> r6) {
        if (((15 + 14) % 14) > 0) goto L56;
    L56:
        if ((r6 is p9dc39adc$p19baaff4$1) == true) goto L67;
    L73:
        p9dc39adc$p19baaff4$1 r0 = new p9dc39adc$p19baaff4$1(this, r6);
    L70:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L25;
        if (r2 == 1) goto L69;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L69:
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L40:
        if (((ped663a3e) r62) is not null) goto L21;
        return Unit.INSTANCE;
    L21:
        throw new p7f59467d(this.f4734ade7.getstring(C2845R.string.receipt_error_duplicate_message));
    L25:
        ResultKt.throwOnFailure(r62);
        p7638dcb8 r63 = this.ff2fed930;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = r63.getSellReceipt(r5, r0);
        if (r62 != r1) goto L40;
        return r1;
    L67:
        r0 = (p9dc39adc$p19baaff4$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L73;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L70
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object ClearCurrentSellReceipts(Continuation<Unit> r1) {
        object r0 = this.fd8f0064e.clearCurrentSellReceipts(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L4;
        return r0;
    L4:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object ClearReceiptDiscount(Continuation<Unit> r29) {
        if (((23 + 31) % 31) > 0) goto L69;
    L69:
        if ((r29 is p9dc39adc$pfde1c496$1) == true) goto L52;
    L37:
        p9dc39adc$pfde1c496$1 r2 = new p9dc39adc$pfde1c496$1(this, r29);
    L6:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L103;
        if (r4 == 1) goto L77;
        if (r4 != 2) goto L54;
        ResultKt.throwOnFailure(r1);
    L95:
        return Unit.INSTANCE;
    L54:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L77:
        pef9926d1 r0 = (pef9926d1) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L91:
        pf79cee86 r12 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, null, false, null, null, null, null, null, null, null, false, false, null, 260095, null);
        r2.L$0 = null;
        r2.fd304ba20 = 2;
        if (r0.updateReceipt(r12, r2) != r3) goto L95;
    L79:
        return r3;
    L103:
        ResultKt.throwOnFailure(r1);
        pef9926d1 r13 = this.fd8f0064e;
        r2.L$0 = r13;
        r2.fd304ba20 = 1;
        object r02 = m661f6c0a(r2);
        if (r02 == r3) goto L79;
        r1 = r02;
        r0 = r13;
        goto L91
    L52:
        r2 = (p9dc39adc$pfde1c496$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L37;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L6
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object ClearSellReceipts(Continuation<Unit> r1) {
        object r0 = this.ff2fed930.clearSellReceipts(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object GetNoteReceipt(Continuation<string> r5) {
        if (((28 + 26) % 26) > 0) goto L27;
    L27:
        if ((r5 is p9dc39adc$p518c0d58$1) == true) goto L55;
    L24:
        p9dc39adc$p518c0d58$1 r0 = new p9dc39adc$p518c0d58$1(this, r5);
    L20:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L45;
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;     // Catch: Exception -> L44
        r52 = md7b4f317(r0);     // Catch: Exception -> L44
        if (r52 != r1) goto L53;
        return r1;
    L53:
        return ((p2c903942) r52).getCurrentSellReceipt().getNote();
    L45:
        if (r2 != 1) goto L35;
        ResultKt.throwOnFailure(r52);     // Catch: Exception -> L44
        goto L53
    L35:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L40:
        return null;
    L55:
        r0 = (p9dc39adc$p518c0d58$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L24;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L20
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object GetReceiptPayments(Continuation<? super List<pad7c4a1f>> r5) {
        if (((4 + 24) % 24) > 0) goto L57;
    L57:
        if ((r5 is p9dc39adc$p4a131e51$1) == false) goto L37;
        p9dc39adc$p4a131e51$1 r0 = (p9dc39adc$p4a131e51$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L37;
        r0.fd304ba20 -= int.MIN_VALUE;
    L3:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L13;
        if (r2 != 1) goto L54;
        ResultKt.throwOnFailure(r52);
    L21:
        return p54789c03.mc15a84ea((List) r52);
    L54:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L13:
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = maef0ec44(r0);
        if (r52 != r1) goto L21;
        return r1;
    L37:
        r0 = new p9dc39adc$p4a131e51$1(this, r5);
        goto L3
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object GetReceiptPositions(Continuation<? super List<pd031d465>> r5) {
        if (((2 + 29) % 29) > 0) goto L16;
    L16:
        if ((r5 is p9dc39adc$paf36a87b$1) == false) goto L38;
        p9dc39adc$paf36a87b$1 r0 = (p9dc39adc$paf36a87b$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L38;
        r0.fd304ba20 -= int.MIN_VALUE;
    L22:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L57;
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = m2c2bcffd(r0);
        if (r52 != r1) goto L5;
        return r1;
    L5:
        return p54789c03.m522885ad((List) r52);
    L57:
        if (r2 != 1) goto L11;
        ResultKt.throwOnFailure(r52);
        goto L5
    L11:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L38:
        r0 = new p9dc39adc$paf36a87b$1(this, r5);
        goto L22
    }

    @Override // p8325324b.pb3f20355.p17a4a1a5
    public object GetSellReceipt(Continuation<ped663a3e> r5) {
        if (((23 + 28) % 28) > 0) goto L41;
    L41:
        if ((r5 is p9dc39adc$p307e0fb7$1) == true) goto L26;
    L19:
        p9dc39adc$p307e0fb7$1 r0 = new p9dc39adc$p307e0fb7$1(this, r5);
    L12:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L16;
        if (r2 != 1) goto L54;
        ResultKt.throwOnFailure(r52);
    L24:
        return p54789c03.m19506644((p2c903942) r52);
    L54:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L16:
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = md7b4f317(r0);
        if (r52 != r1) goto L24;
        return r1;
    L26:
        r0 = (p9dc39adc$p307e0fb7$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L19;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L12
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object HasUnfinishedReceipt(Continuation<bool> r6) {
        if (((29 + 29) % 29) > 0) goto L72;
    L72:
        if ((r6 is p9dc39adc$p376e6596$1) == true) goto L26;
    L39:
        p9dc39adc$p376e6596$1 r0 = new p9dc39adc$p376e6596$1(this, r6);
    L43:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L86;
        if (r2 == 1) goto L58;
        if (r2 != 2) goto L16;
        ResultKt.throwOnFailure(r62);
        return r62;
    L16:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L58:
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L66:
        string r63 = ((p6285e3eb) r62).getDeviceId();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r5 = this.m63bfe3f4(r63, r0);
        if (r5 != r1) goto L59;
    L70:
        return r1;
    L59:
        return r5;
    L86:
        ResultKt.throwOnFailure(r62);
        pfeb9ca41 r64 = this.ffa781974;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = r64.getSelectedDevice(r0);
        if (r62 == r1) goto L70;
    L26:
        r0 = (p9dc39adc$p376e6596$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L39;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L43
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object IncreasePositionQuantity(pd031d465 r27, decimal r28, Continuation<Unit> r29) {
        if (((8 + 29) % 29) > 0) goto L24;
    L24:
        if ((r29 is p9dc39adc$p643683c5$1) == false) goto L63;
        p9dc39adc$p643683c5$1 r2 = (p9dc39adc$p643683c5$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L63;
        r2.fd304ba20 -= int.MIN_VALUE;
    L20:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L28;
        if (r4 == 1) goto L88;
        if (r4 != 2) goto L36;
        ResultKt.throwOnFailure(r1);
    L6:
        return Unit.INSTANCE;
    L36:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L88:
        pd031d465 r0 = (pd031d465) r2.L$1;
        pef9926d1 r42 = (pef9926d1) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L23:
        p0160554c r02 = p54789c03.mcf4608a5(r0, ((pf79cee86) r1).getUuid());
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r42.updatePosition(r02, r2) != r3) goto L6;
    L49:
        return r3;
    L28:
        ResultKt.throwOnFailure(r1);
        decimal r14 = r27.getQuantity().Add(r28);
        r42 = this.fd8f0064e;
        pd031d465 r12 = pd031d465.m1c1e012b(r27, null, null, null, null, null, 0, r14, null, null, null, null, null, null, null, null, 32703, null);
        r2.L$0 = r42;
        r2.L$1 = r12;
        r2.fd304ba20 = 1;
        object r03 = m661f6c0a(r2);
        if (r03 == r3) goto L49;
        r1 = r03;
        r0 = r12;
    L63:
        r2 = new p9dc39adc$p643683c5$1(this, r29);
        goto L20
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object OpenEmptySellReceipt(Continuation<Unit> r6) {
        if (((13 + 13) % 13) > 0) goto L14;
    L14:
        if ((r6 is p9dc39adc$p12917ccf$1) == true) goto L71;
    L35:
        p9dc39adc$p12917ccf$1 r0 = new p9dc39adc$p12917ccf$1(this, r6);
    L13:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L47;
        ResultKt.throwOnFailure(r62);
        pfeb9ca41 r63 = this.ffa781974;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = r63.getSelectedDevice(r0);
        if (r62 != r1) goto L43;
    L59:
        return r1;
    L43:
        string r64 = ((p6285e3eb) r62).getDeviceId();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (this.m6cc3a56e(r64, r0) == r1) goto L59;
    L68:
        return Unit.INSTANCE;
    L47:
        if (r2 == 1) goto L30;
        if (r2 != 2) goto L84;
        ResultKt.throwOnFailure(r62);
        goto L68
    L84:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L30:
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L43
    L71:
        r0 = (p9dc39adc$p12917ccf$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L35;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L13
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object OpenNotEmptySellReceipt(ped663a3e r38, Continuation<Unit> r39) {
        if (((1 + 12) % 12) > 0) goto L133;
    L133:
        p9dc39adc r0 = this;
        if ((r39 is p9dc39adc$pa7d64b4d$1) == true) goto L154;
    L56:
        p9dc39adc$pa7d64b4d$1 r2 = new p9dc39adc$pa7d64b4d$1(r0, r39);
    L68:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L118;
        if (r4 == 1) goto L77;
        if (r4 == 2) goto L48;
        if (r4 != 3) goto L124;
        ResultKt.throwOnFailure(r1);
    L92:
        return Unit.INSTANCE;
    L124:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L48:
        ped663a3e r02 = (ped663a3e) r2.L$1;
        p9dc39adc r42 = (p9dc39adc) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L98:
        string r12 = ((p6285e3eb) r1).getDeviceId();
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 3;
        if (r42.mb6fc41ff(r02, r12, r2) != r3) goto L92;
    L65:
        return r3;
    L77:
        ped663a3e r03 = (ped663a3e) r2.L$1;
        p9dc39adc r43 = (p9dc39adc) r2.L$0;
        ResultKt.throwOnFailure(r1);
        ped663a3e r7 = r03;
        r0 = r43;
    L19:
        ped663a3e r13 = ped663a3e.m1c1e012b(r7, ((pf8c8b903) r1).getId(), null, null, null, null, null, null, null, null, false, null, r0.fbbcec403.getPaymentPlace(), r0.fbbcec403.getPaymentAddress(), null, null, null, null, null, null, null, null, null, null, false, null, null, 67102718, null);
        pfeb9ca41 r44 = r0.ffa781974;
        r2.L$0 = r0;
        r2.L$1 = r13;
        r2.fd304ba20 = 2;
        object r45 = r44.getSelectedDevice(r2);
        if (r45 == r3) goto L65;
        r42 = r0;
        r02 = r13;
        r1 = r45;
        goto L98
    L118:
        ResultKt.throwOnFailure(r1);
        p0c2c0436 r14 = r0.fedc5f59e;
        r2.L$0 = r0;
        r2.L$1 = r38;
        r2.fd304ba20 = 1;
        r1 = r14.getSelectedEmployee(r2);
        if (r1 == r3) goto L65;
        r7 = r38;
        goto L19
    L154:
        r2 = (p9dc39adc$pa7d64b4d$1) r39;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L56;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L68
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object OpenOrEditSellReceipt(Continuation<Unit> r9) {
        if (((4 + 15) % 15) > 0) goto L42;
    L42:
        if ((r9 is p9dc39adc$pd1dc819f$1) == false) goto L82;
        p9dc39adc$pd1dc819f$1 r0 = (p9dc39adc$pd1dc819f$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L82;
        r0.fd304ba20 -= int.MIN_VALUE;
    L95:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L89;
        if (r2 == 1) goto L116;
        if (r2 == 2) goto L62;
        if (r2 != 3) goto L100;
        ResultKt.throwOnFailure(r92);
    L19:
        return Unit.INSTANCE;
    L100:
        if (r2 != 4) goto L26;
        ResultKt.throwOnFailure(r92);
    L58:
        return Unit.INSTANCE;
    L26:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L62:
        string r8 = (string) r0.L$1;
        p9dc39adc r22 = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L72:
        if (((bool) r92).boolValue() == false) goto L57;
        pef9926d1 r93 = r22.fd8f0064e;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 4;
        if (r93.selectReceipt(r8, "RECEIPT", r0) != r1) goto L58;
    L64:
        return r1;
    L57:
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 3;
        if (r22.m6cc3a56e(r8, r0) == r1) goto L64;
    L116:
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L119:
        string r94 = ((p6285e3eb) r92).getDeviceId();
        r0.L$0 = this;
        r0.L$1 = r94;
        r0.fd304ba20 = 2;
        object r23 = this.m63bfe3f4(r94, r0);
        if (r23 == r1) goto L64;
        r22 = this;
        r8 = r94;
        r92 = r23;
        goto L72
    L89:
        ResultKt.throwOnFailure(r92);
        pfeb9ca41 r95 = this.ffa781974;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r92 = r95.getSelectedDevice(r0);
        if (r92 == r1) goto L64;
    L82:
        r0 = new p9dc39adc$pd1dc819f$1(this, r9);
        goto L95
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object OpenSinglePaymentIfNeeded(Continuation<Unit> r9) {
        if (((27 + 16) % 16) > 0) goto L57;
    L57:
        if ((r9 is p9dc39adc$pc3eb4d56$1) == true) goto L18;
    L31:
        p9dc39adc$pc3eb4d56$1 r0 = new p9dc39adc$pc3eb4d56$1(this, r9);
    L93:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L62;
        ResultKt.throwOnFailure(r92);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r92 = getSellReceipt(r0);
        if (r92 == r1) goto L20;
    L30:
        ped663a3e r93 = (ped663a3e) r92;
        if (pf55486b2.m8af5a42a(r93.getPaymentType()) == true) goto L17;
        return Unit.INSTANCE;
    L17:
        pad7c4a1f r22 = new pad7c4a1f(r93.getUuid(), r93.getPaymentType(), p434d238d.m29a3256d(r93), null);
        pef9926d1 r8 = this.fd8f0064e;
        p32a285cf r94 = p54789c03.m6e4c3ee0(r22, r93.getUuid());
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r8.createSinglePayment(r94, r0) == r1) goto L20;
    L9:
        return Unit.INSTANCE;
    L20:
        return r1;
    L62:
        if (r2 == 1) goto L97;
        if (r2 != 2) goto L55;
        ResultKt.throwOnFailure(r92);
        goto L9
    L55:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L97:
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r92);
        goto L30
    L18:
        r0 = (p9dc39adc$pc3eb4d56$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L31;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L93
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object RemoveAllPaymentsFromReceipt(Continuation<Unit> r7) {
        if (((27 + 4) % 4) > 0) goto L36;
    L36:
        if ((r7 is p9dc39adc$pd68b1cff$1) == false) goto L15;
        p9dc39adc$pd68b1cff$1 r0 = (p9dc39adc$pd68b1cff$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L15;
        r0.fd304ba20 -= int.MIN_VALUE;
    L90:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L56;
        if (r2 == 1) goto L54;
        if (r2 != 2) goto L6;
        ResultKt.throwOnFailure(r72);
    L9:
        return Unit.INSTANCE;
    L6:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L54:
        pef9926d1 r6 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L75:
        List<p32a285cf> r73 = (List) r72;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r6.deletePayments(r73, r0) != r1) goto L9;
    L87:
        return r1;
    L56:
        ResultKt.throwOnFailure(r72);
        pef9926d1 r74 = this.fd8f0064e;
        r0.L$0 = r74;
        r0.fd304ba20 = 1;
        object r62 = maef0ec44(r0);
        if (r62 == r1) goto L87;
        r72 = r62;
        r6 = r74;
    L15:
        r0 = new p9dc39adc$pd68b1cff$1(this, r7);
        goto L90
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object RemoveAllPositionsFromReceipt(Continuation<Unit> r7) {
        if (((17 + 15) % 15) > 0) goto L52;
    L52:
        if ((r7 is p9dc39adc$p5be57e9d$1) == false) goto L16;
        p9dc39adc$p5be57e9d$1 r0 = (p9dc39adc$p5be57e9d$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L16;
        r0.fd304ba20 -= int.MIN_VALUE;
    L62:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L82;
        ResultKt.throwOnFailure(r72);
        pef9926d1 r73 = this.fd8f0064e;
        r0.L$0 = r73;
        r0.fd304ba20 = 1;
        object r6 = m2c2bcffd(r0);
        if (r6 != r1) goto L50;
    L25:
        return r1;
    L50:
        r72 = r6;
        pef9926d1 r62 = r73;
    L103:
        IEnumerable r74 = (IEnumerable) r72;
        List r22 = new List(ICollectionsKt.collectionSizeOrDefault(r74, 10));
        IEnumerator r75 = r74.GetEnumerator();
    L77:
        if (r75.MoveNext() == false) goto L104;
        r22.Add(((pa4e1ef7c) r75.Current).getCurrentSellPositionDbEntity());
        goto L77
    L104:
        List r23 = r22;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r62.deletePositions(r23, r0) == r1) goto L25;
    L40:
        return Unit.INSTANCE;
    L82:
        if (r2 == 1) goto L75;
        if (r2 != 2) goto L30;
        ResultKt.throwOnFailure(r72);
        goto L40
    L30:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L75:
        r62 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L16:
        r0 = new p9dc39adc$p5be57e9d$1(this, r7);
        goto L62
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object RemoveCurrentReceipt(Continuation<Unit> r7) {
        if (((29 + 2) % 2) > 0) goto L72;
    L72:
        if ((r7 is p9dc39adc$pdddc363b$1) == true) goto L3;
    L28:
        p9dc39adc$pdddc363b$1 r0 = new p9dc39adc$pdddc363b$1(this, r7);
    L42:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L14;
        ResultKt.throwOnFailure(r72);
        pef9926d1 r73 = this.fd8f0064e;
        r0.L$0 = r73;
        r0.fd304ba20 = 1;
        object r6 = m661f6c0a(r0);
        if (r6 != r1) goto L78;
    L35:
        return r1;
    L78:
        r72 = r6;
        pef9926d1 r62 = r73;
    L11:
        pf79cee86 r74 = (pf79cee86) r72;
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r62.deleteReceipt(r74, r0) == r1) goto L35;
    L24:
        return Unit.INSTANCE;
    L14:
        if (r2 == 1) goto L8;
        if (r2 != 2) goto L61;
        ResultKt.throwOnFailure(r72);
        goto L24
    L61:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L8:
        r62 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L11
    L3:
        r0 = (p9dc39adc$pdddc363b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L28;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L42
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object RemovePaymentFromReceipt(pad7c4a1f r7, Continuation<Unit> r8) {
        if (((23 + 11) % 11) > 0) goto L18;
    L18:
        if ((r8 is p9dc39adc$p2a2f124b$1) == false) goto L86;
        p9dc39adc$p2a2f124b$1 r0 = (p9dc39adc$p2a2f124b$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L86;
        r0.fd304ba20 -= int.MIN_VALUE;
    L94:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L47;
        if (r2 == 1) goto L6;
        if (r2 != 2) goto L29;
        ResultKt.throwOnFailure(r82);
    L79:
        return Unit.INSTANCE;
    L29:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L6:
        r7 = (pad7c4a1f) r0.L$1;
        pef9926d1 r6 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L17:
        p32a285cf r72 = p54789c03.m6e4c3ee0(r7, ((pf79cee86) r82).getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r6.deletePayment(r72, r0) != r1) goto L79;
    L76:
        return r1;
    L47:
        ResultKt.throwOnFailure(r82);
        pef9926d1 r83 = this.fd8f0064e;
        r0.L$0 = r83;
        r0.L$1 = r7;
        r0.fd304ba20 = 1;
        object r62 = m661f6c0a(r0);
        if (r62 == r1) goto L76;
        r82 = r62;
        r6 = r83;
    L86:
        r0 = new p9dc39adc$p2a2f124b$1(this, r8);
        goto L94
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object RemovePositionFromReceipt(pd031d465 r7, Continuation<Unit> r8) {
        if (((11 + 5) % 5) > 0) goto L25;
    L25:
        if ((r8 is p9dc39adc$pc5336464$1) == false) goto L84;
        p9dc39adc$pc5336464$1 r0 = (p9dc39adc$pc5336464$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L84;
        r0.fd304ba20 -= int.MIN_VALUE;
    L87:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L52;
        ResultKt.throwOnFailure(r82);
        pef9926d1 r83 = this.fd8f0064e;
        r0.L$0 = r83;
        r0.L$1 = r7;
        r0.fd304ba20 = 1;
        object r6 = m661f6c0a(r0);
        if (r6 != r1) goto L49;
    L34:
        return r1;
    L49:
        r82 = r6;
        pef9926d1 r62 = r83;
    L9:
        p0160554c r72 = p54789c03.mcf4608a5(r7, ((pf79cee86) r82).getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r62.deletePosition(r72, r0) == r1) goto L34;
    L70:
        return Unit.INSTANCE;
    L52:
        if (r2 == 1) goto L22;
        if (r2 != 2) goto L18;
        ResultKt.throwOnFailure(r82);
        goto L70
    L18:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L22:
        r7 = (pd031d465) r0.L$1;
        r62 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L84:
        r0 = new p9dc39adc$pc5336464$1(this, r8);
        goto L87
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object ReplacePosition(pd031d465 r6, pd031d465 r7, Continuation<Unit> r8) {
        if (((12 + 30) % 30) > 0) goto L61;
    L61:
        if ((r8 is p9dc39adc$pb7ecc47b$1) == true) goto L8;
    L20:
        p9dc39adc$pb7ecc47b$1 r0 = new p9dc39adc$pb7ecc47b$1(this, r8);
    L25:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L87;
        ResultKt.throwOnFailure(r82);
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r7;
        r0.fd304ba20 = 1;
        r82 = m661f6c0a(r0);
        if (r82 == r1) goto L57;
    L91:
        pf79cee86 r83 = (pf79cee86) r82;
        pef9926d1 r5 = this.fd8f0064e;
        p0160554c r62 = p54789c03.mcf4608a5(r6, r83.getUuid());
        p0160554c r72 = p54789c03.mcf4608a5(r7, r83.getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.fd304ba20 = 2;
        if (r5.replacePosition(r62, r72, r0) == r1) goto L57;
    L41:
        return Unit.INSTANCE;
    L57:
        return r1;
    L87:
        if (r2 == 1) goto L34;
        if (r2 != 2) goto L9;
        ResultKt.throwOnFailure(r82);
        goto L41
    L9:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L34:
        r7 = (pd031d465) r0.L$2;
        r6 = (pd031d465) r0.L$1;
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L91
    L8:
        r0 = (p9dc39adc$pb7ecc47b$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L20;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L25
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetNoteReceipt(string r28, Continuation<Unit> r29) {
        if (((6 + 21) % 21) > 0) goto L105;
    L105:
        if ((r29 is p9dc39adc$paaa6a072$1) == true) goto L16;
    L51:
        p9dc39adc$paaa6a072$1 r2 = new p9dc39adc$paaa6a072$1(this, r29);
    L97:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L46;
        if (r4 == 1) goto L88;
        if (r4 != 2) goto L41;
        ResultKt.throwOnFailure(r1);
    L79:
        return Unit.INSTANCE;
    L41:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L88:
        pef9926d1 r0 = (pef9926d1) r2.L$1;
        string r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L104:
        pf79cee86 r12 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, null, false, null, null, null, null, null, null, null, false, false, r42, 131071, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateReceipt(r12, r2) != r3) goto L79;
    L73:
        return r3;
    L46:
        ResultKt.throwOnFailure(r1);
        pef9926d1 r13 = this.fd8f0064e;
        r42 = r28;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = m661f6c0a(r2);
        if (r02 == r3) goto L73;
        r1 = r02;
        r0 = r13;
        goto L104
    L16:
        r2 = (p9dc39adc$paaa6a072$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L51;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L97
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetPaymentAddress(string r28, Continuation<Unit> r29) {
        if (((17 + 7) % 7) > 0) goto L52;
    L52:
        if ((r29 is p9dc39adc$p6746a42c$1) == false) goto L115;
        p9dc39adc$p6746a42c$1 r2 = (p9dc39adc$p6746a42c$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L115;
        r2.fd304ba20 -= int.MIN_VALUE;
    L49:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L85;
        ResultKt.throwOnFailure(r1);
        pef9926d1 r12 = this.fd8f0064e;
        string r42 = r28;
        r2.L$0 = r42;
        r2.L$1 = r12;
        r2.fd304ba20 = 1;
        object r0 = m661f6c0a(r2);
        if (r0 != r3) goto L93;
    L67:
        return r3;
    L93:
        r1 = r0;
        pef9926d1 r02 = r12;
    L66:
        pf79cee86 r13 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, null, false, null, null, r42, null, null, null, null, false, false, null, 261119, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r02.updateReceipt(r13, r2) == r3) goto L67;
    L4:
        return Unit.INSTANCE;
    L85:
        if (r4 == 1) goto L113;
        if (r4 != 2) goto L43;
        ResultKt.throwOnFailure(r1);
        goto L4
    L43:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L113:
        r02 = (pef9926d1) r2.L$1;
        r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L115:
        r2 = new p9dc39adc$p6746a42c$1(this, r29);
        goto L49
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetPaymentPlace(string r28, Continuation<Unit> r29) {
        if (((24 + 29) % 29) > 0) goto L8;
    L8:
        if ((r29 is p9dc39adc$p5af19b33$1) == false) goto L5;
        p9dc39adc$p5af19b33$1 r2 = (p9dc39adc$p5af19b33$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L5;
        r2.fd304ba20 -= int.MIN_VALUE;
    L20:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L100;
        if (r4 == 1) goto L47;
        if (r4 != 2) goto L114;
        ResultKt.throwOnFailure(r1);
    L16:
        return Unit.INSTANCE;
    L114:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L47:
        pef9926d1 r0 = (pef9926d1) r2.L$1;
        string r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L109:
        pf79cee86 r12 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, null, false, null, r42, null, null, null, null, null, false, false, null, 261631, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateReceipt(r12, r2) != r3) goto L16;
    L118:
        return r3;
    L100:
        ResultKt.throwOnFailure(r1);
        pef9926d1 r13 = this.fd8f0064e;
        r42 = r28;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = m661f6c0a(r2);
        if (r02 == r3) goto L118;
        r1 = r02;
        r0 = r13;
    L5:
        r2 = new p9dc39adc$p5af19b33$1(this, r29);
        goto L20
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetPaymentType(p8c261c90 r28, Continuation<Unit> r29) {
        if (((17 + 23) % 23) > 0) goto L96;
    L96:
        if ((r29 is p9dc39adc$pb35f541c$1) == true) goto L21;
    L118:
        p9dc39adc$pb35f541c$1 r2 = new p9dc39adc$pb35f541c$1(this, r29);
    L33:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L80;
        ResultKt.throwOnFailure(r1);
        pef9926d1 r12 = this.fd8f0064e;
        p8c261c90 r42 = r28;
        r2.L$0 = r42;
        r2.L$1 = r12;
        r2.fd304ba20 = 1;
        object r0 = m661f6c0a(r2);
        if (r0 != r3) goto L64;
    L77:
        return r3;
    L64:
        r1 = r0;
        pef9926d1 r02 = r12;
    L41:
        pf79cee86 r13 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, r42, false, null, null, null, null, null, null, null, false, false, null, 262079, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r02.updateReceipt(r13, r2) == r3) goto L77;
    L53:
        return Unit.INSTANCE;
    L80:
        if (r4 == 1) goto L84;
        if (r4 != 2) goto L114;
        ResultKt.throwOnFailure(r1);
        goto L53
    L114:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L84:
        r02 = (pef9926d1) r2.L$1;
        r42 = (p8c261c90) r2.L$0;
        ResultKt.throwOnFailure(r1);
        goto L41
    L21:
        r2 = (p9dc39adc$pb35f541c$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L118;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L33
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetQRPayInfo(pc5f0acf1 r28, Continuation<Unit> r29) {
        if (((16 + 30) % 30) > 0) goto L82;
    L82:
        if ((r29 is p9dc39adc$p6aae6063$1) == false) goto L97;
        p9dc39adc$p6aae6063$1 r2 = (p9dc39adc$p6aae6063$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L97;
        r2.fd304ba20 -= int.MIN_VALUE;
    L114:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L76;
        ResultKt.throwOnFailure(r1);
        string r42 = new GsonBuilder().create().toJson(r28);
        pef9926d1 r12 = this.fd8f0064e;
        r2.L$0 = r42;
        r2.L$1 = r12;
        r2.fd304ba20 = 1;
        object r0 = m661f6c0a(r2);
        if (r0 != r3) goto L116;
    L54:
        return r3;
    L116:
        r1 = r0;
        pef9926d1 r02 = r12;
    L11:
        pf79cee86 r13 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, null, false, null, null, null, null, null, r42, null, false, false, null, 253951, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r02.updateReceipt(r13, r2) == r3) goto L54;
    L119:
        return Unit.INSTANCE;
    L76:
        if (r4 == 1) goto L10;
        if (r4 != 2) goto L21;
        ResultKt.throwOnFailure(r1);
        goto L119
    L21:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L10:
        r02 = (pef9926d1) r2.L$1;
        r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L97:
        r2 = new p9dc39adc$p6aae6063$1(this, r29);
        goto L114
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetReceiptClientEmail(string r28, Continuation<Unit> r29) {
        if (((17 + 3) % 3) > 0) goto L111;
    L111:
        if ((r29 is p9dc39adc$pb4a744ac$1) == true) goto L45;
    L39:
        p9dc39adc$pb4a744ac$1 r2 = new p9dc39adc$pb4a744ac$1(this, r29);
    L97:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L63;
        ResultKt.throwOnFailure(r1);
        pef9926d1 r12 = this.fd8f0064e;
        string r42 = r28;
        r2.L$0 = r42;
        r2.L$1 = r12;
        r2.fd304ba20 = 1;
        object r0 = m661f6c0a(r2);
        if (r0 != r3) goto L107;
    L3:
        return r3;
    L107:
        r1 = r0;
        pef9926d1 r02 = r12;
    L35:
        pf79cee86 r13 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, r42, null, null, false, null, null, null, null, null, null, null, false, false, null, 262095, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r02.updateReceipt(r13, r2) == r3) goto L3;
    L50:
        return Unit.INSTANCE;
    L63:
        if (r4 == 1) goto L53;
        if (r4 != 2) goto L15;
        ResultKt.throwOnFailure(r1);
        goto L50
    L15:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L53:
        r02 = (pef9926d1) r2.L$1;
        r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
        goto L35
    L45:
        r2 = (p9dc39adc$pb4a744ac$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L39;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L97
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetReceiptClientPhone(string r28, Continuation<Unit> r29) {
        if (((16 + 6) % 6) > 0) goto L65;
    L65:
        if ((r29 is p9dc39adc$p9a8ced50$1) == true) goto L24;
    L49:
        p9dc39adc$p9a8ced50$1 r2 = new p9dc39adc$p9a8ced50$1(this, r29);
    L21:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L90;
        ResultKt.throwOnFailure(r1);
        pef9926d1 r12 = this.fd8f0064e;
        string r42 = r28;
        r2.L$0 = r42;
        r2.L$1 = r12;
        r2.fd304ba20 = 1;
        object r0 = m661f6c0a(r2);
        if (r0 != r3) goto L86;
    L106:
        return r3;
    L86:
        r1 = r0;
        pef9926d1 r02 = r12;
    L117:
        pf79cee86 r13 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, r42, null, false, null, null, null, null, null, null, null, false, false, null, 262095, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r02.updateReceipt(r13, r2) == r3) goto L106;
    L109:
        return Unit.INSTANCE;
    L90:
        if (r4 == 1) goto L99;
        if (r4 != 2) goto L76;
        ResultKt.throwOnFailure(r1);
        goto L109
    L76:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L99:
        r02 = (pef9926d1) r2.L$1;
        r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
        goto L117
    L24:
        r2 = (p9dc39adc$p9a8ced50$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L49;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L21
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetShouldPrintReceipt(bool r28, Continuation<Unit> r29) {
        if (((7 + 24) % 24) > 0) goto L7;
    L7:
        if ((r29 is p9dc39adc$p581e088e$1) == false) goto L11;
        p9dc39adc$p581e088e$1 r2 = (p9dc39adc$p581e088e$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L11;
        r2.fd304ba20 -= int.MIN_VALUE;
    L38:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L107;
        if (r4 == 1) goto L113;
        if (r4 != 2) goto L62;
        ResultKt.throwOnFailure(r1);
    L19:
        return Unit.INSTANCE;
    L62:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L113:
        bool r0 = r2.Z$0;
        pef9926d1 r42 = (pef9926d1) r2.L$0;
        ResultKt.throwOnFailure(r1);
        bool r14 = r0;
    L59:
        pf79cee86 r02 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, null, r14, null, null, null, null, null, null, null, false, false, null, 262015, null);
        r2.L$0 = null;
        r2.fd304ba20 = 2;
        if (r42.updateReceipt(r02, r2) != r3) goto L19;
    L48:
        return r3;
    L107:
        ResultKt.throwOnFailure(r1);
        r42 = this.fd8f0064e;
        r2.L$0 = r42;
        r2.Z$0 = r28;
        r2.fd304ba20 = 1;
        object r03 = m661f6c0a(r2);
        if (r03 == r3) goto L48;
        r14 = r28;
        r1 = r03;
    L11:
        r2 = new p9dc39adc$p581e088e$1(this, r29);
        goto L38
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object SetTransactionToFirstPayment(pf8872840 r7, Continuation<Unit> r8) {
        if (((30 + 21) % 21) > 0) goto L27;
    L27:
        if ((r8 is p9dc39adc$p3c73ef90$1) == false) goto L91;
        p9dc39adc$p3c73ef90$1 r0 = (p9dc39adc$p3c73ef90$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L91;
        r0.fd304ba20 -= int.MIN_VALUE;
    L23:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L55;
        if (r2 == 1) goto L41;
        if (r2 != 2) goto L79;
        ResultKt.throwOnFailure(r82);
    L83:
        return Unit.INSTANCE;
    L79:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L41:
        pef9926d1 r6 = (pef9926d1) r0.L$1;
        r7 = (pf8872840) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L3:
        string r83 = ((p32a285cf) ICollectionsKt.first((List) r82)).getUuid();
        p85cc901a r72 = p4aaa98e5.mbed876fa(r7);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r6.updatePaymentTransaction(r83, r72, r0) != r1) goto L83;
    L52:
        return r1;
    L55:
        ResultKt.throwOnFailure(r82);
        pef9926d1 r84 = this.fd8f0064e;
        r0.L$0 = r7;
        r0.L$1 = r84;
        r0.fd304ba20 = 1;
        object r62 = maef0ec44(r0);
        if (r62 == r1) goto L52;
        r82 = r62;
        r6 = r84;
    L91:
        r0 = new p9dc39adc$p3c73ef90$1(this, r8);
        goto L23
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object UpdatePayment(pad7c4a1f r1, string r2, Continuation<Unit> r3) {
        object r0 = this.ff2fed930.updatePayment(r1, r2, r3);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L12;
        return r0;
    L12:
        return Unit.INSTANCE;
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object UpdatePayment(pad7c4a1f r7, Continuation<Unit> r8) {
        if (((21 + 29) % 29) > 0) goto L93;
    L93:
        if ((r8 is p9dc39adc$p109f7b1b$2) == true) goto L53;
    L65:
        p9dc39adc$p109f7b1b$2 r0 = new p9dc39adc$p109f7b1b$2(this, r8);
    L92:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L63;
        if (r2 == 1) goto L91;
        if (r2 != 2) goto L54;
        ResultKt.throwOnFailure(r82);
    L13:
        return Unit.INSTANCE;
    L54:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L91:
        r7 = (pad7c4a1f) r0.L$1;
        pef9926d1 r6 = (pef9926d1) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L33:
        p32a285cf r72 = p54789c03.m6e4c3ee0(r7, ((pf79cee86) r82).getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r6.updatePayment(r72, r0) != r1) goto L13;
    L83:
        return r1;
    L63:
        ResultKt.throwOnFailure(r82);
        pef9926d1 r83 = this.fd8f0064e;
        r0.L$0 = r83;
        r0.L$1 = r7;
        r0.fd304ba20 = 1;
        object r62 = m661f6c0a(r0);
        if (r62 == r1) goto L83;
        r82 = r62;
        r6 = r83;
        goto L33
    L53:
        r0 = (p9dc39adc$p109f7b1b$2) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L65;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L92
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object UpdatePosition(pd031d465 r6, Continuation<Unit> r7) {
        if (((6 + 24) % 24) > 0) goto L29;
    L29:
        if ((r7 is p9dc39adc$p4c5a4754$1) == false) goto L4;
        p9dc39adc$p4c5a4754$1 r0 = (p9dc39adc$p4c5a4754$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L4;
        r0.fd304ba20 -= int.MIN_VALUE;
    L23:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L76;
        if (r2 == 1) goto L41;
        if (r2 != 2) goto L19;
        ResultKt.throwOnFailure(r72);
    L62:
        return Unit.INSTANCE;
    L19:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L41:
        r6 = (pd031d465) r0.L$1;
        p9dc39adc this = (p9dc39adc) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L89:
        pf79cee86 r73 = (pf79cee86) r72;
        pef9926d1 r5 = this.fd8f0064e;
        p0160554c r62 = p54789c03.mcf4608a5(r6, r73.getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.updatePosition(r62, r0) != r1) goto L62;
    L44:
        return r1;
    L76:
        ResultKt.throwOnFailure(r72);
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        r72 = m661f6c0a(r0);
        if (r72 == r1) goto L44;
    L4:
        r0 = new p9dc39adc$p4c5a4754$1(this, r7);
        goto L23
    }

    @Override // p8325324b.pb3f20355.p3851083a
    public object UpdateReceiptDiscount(decimal r28, Continuation<Unit> r29) {
        if (((12 + 17) % 17) > 0) goto L64;
    L64:
        if ((r29 is p9dc39adc$p78ee09c3$1) == true) goto L73;
    L115:
        p9dc39adc$p78ee09c3$1 r2 = new p9dc39adc$p78ee09c3$1(this, r29);
    L17:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L13;
        if (r4 == 1) goto L67;
        if (r4 != 2) goto L86;
        ResultKt.throwOnFailure(r1);
    L60:
        return Unit.INSTANCE;
    L86:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L67:
        pef9926d1 r0 = (pef9926d1) r2.L$1;
        decimal r42 = (decimal) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L68:
        pf79cee86 r12 = pf79cee86.m1c1e012b((pf79cee86) r1, null, null, null, null, null, null, null, false, null, null, null, r42, null, null, null, false, false, null, 260095, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateReceipt(r12, r2) != r3) goto L60;
    L7:
        return r3;
    L13:
        ResultKt.throwOnFailure(r1);
        pef9926d1 r13 = this.fd8f0064e;
        r42 = r28;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = m661f6c0a(r2);
        if (r02 == r3) goto L7;
        r1 = r02;
        r0 = r13;
        goto L68
    L73:
        r2 = (p9dc39adc$p78ee09c3$1) r29;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L115;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L17
    }
}

