using Androidx.Paging;
using Com.Google.Android.Gms.Actions;
using Com.Google.Gson;
using Java.Math;
using Java.Sql;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using Kotlin.Text;
using Kotlinx.Coroutines.Flow;
using P2b3583e6.P19ad2780.P1e11b989;
using P2b3583e6.P4a931512;
using P2e5d8aa3.Pe0212e54.Pb3f20355;
using P4670093c.P07214c67.Pd77d5e50;
using P4670093c.P4b9f83e1;
using P4d236d9a.P2df4812c.Pf5d7e253.Pc075fab6;
using P5a445d71.P228c1b3d.P07cc694b;
using P8d777f38.Pb3f20355.P1e11b989;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.P4b9f83e1;
using Pe0212e54.Pb3f20355;
using Pe0212e54.Pf5e638cc.Pd77d5e50;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p9149ef5d : p24ddebba {
    private static readonly p910eef8c f0ed96b2d = null;
    private static readonly p910eef8c f1828c361 = null;
    public static readonly int f3aec897e = 30;
    public static readonly int f6fd29359 = 30;
    private static readonly p910eef8c f763ed11e = null;
    private static readonly p910eef8c f7a35390b = null;
    private static readonly p910eef8c f910eef8c = null;
    public static readonly int fbbfa5be4 = 30;

    [System.Obsolete]
    public static readonly int fbbfa5ff8 = 30;
    private readonly p7638dcb8 f214108c0;
    private readonly p8eeb7ddb f28db83c1;
    private readonly p7638dcb8 f30af2699;
    private readonly p8eeb7ddb f34fe34c5;
    private readonly p2e423cc6 f3ae1b0cb;
    private readonly p2e423cc6 f4734ade7;
    private readonly p7638dcb8 f4d5d5fbb;
    private readonly p8eeb7ddb f731892c2;
    private readonly p2e423cc6 faad70868;
    private readonly p2d884c28 fbbcec403;
    private readonly pfeb9ca41 fc5f908fe;
    private readonly p7638dcb8 fdafe7864;
    private readonly pfeb9ca41 fdcb3fe94;
    private readonly p2e423cc6 fdfe62aa4;
    private readonly p2d884c28 fe77fd233;
    private readonly p2e423cc6 fee952a16;
    private readonly p7638dcb8 ff2fed930;
    private readonly p2d884c28 ff649ded6;
    private readonly pfeb9ca41 ffa781974;

    private static readonly class p910eef8c {
        private p910eef8c() {
        }

        public /* synthetic */ p910eef8c(DefaultConstructorMarker r1) {
            this();
        }
    }

    static {
        if (((26 + 22) % 22) > 0) goto L11;
    L11:
        f910eef8c = new p910eef8c(null);
    }

    public p9149ef5d(p7638dcb8 r2, p2d884c28 r3, p8eeb7ddb r4, pfeb9ca41 r5, p2e423cc6 r6) {
        Intrinsics.checkNotNullParameter(r2, "receiptDbRepository");
        Intrinsics.checkNotNullParameter(r3, "localHashSettingsRepository");
        Intrinsics.checkNotNullParameter(r4, "currentPaybackReceiptDbRepository");
        Intrinsics.checkNotNullParameter(r5, "devicesDbRepository");
        Intrinsics.checkNotNullParameter(r6, "resourceProvider");
        this.ff2fed930 = r2;
        this.fbbcec403 = r3;
        this.f34fe34c5 = r4;
        this.ffa781974 = r5;
        this.f4734ade7 = r6;
    }

    private static readonly PagingSource M2b4ff531(p9149ef5d r1) {
        return new pf38d8cc7(r1.ff2fed930);
    }

    private readonly List<pd031d465> M4aa5bd3d(List<pd031d465> r4, string r5) {
        if (((17 + 2) % 2) > 0) goto L50;
    L50:
        string r0 = r5;
        if (r0 is not null) goto L22;
    L7:
        return r4;
    L22:
        if (r0.Length == 0) goto L7;
        List<pd031d465> r42 = r4;
        List r02 = new List();
        IEnumerator<T> r43 = r42.GetEnumerator();
    L3:
        if (r43.MoveNext() == false) goto L51;
        object r1 = r43.Current;
        if (mc802f568((pd031d465) r1, r5) == false) goto L3;
        r02.Add(r1);
        goto L3
    L51:
        return r02;
    }

    public static readonly /* synthetic */ object m952b0e0f(p9149ef5d r0, pd031d465 r1, Continuation r2) {
        return r0.m96ee847e(r1, r2);
    }

    private readonly object M96ee847e(pd031d465 r5, Continuation<pd031d465> r6) {
        if (((17 + 27) % 27) > 0) goto L49;
    L49:
        if ((r6 is p9149ef5d$p96ee847e$1) == true) goto L48;
    L54:
        p9149ef5d$p96ee847e$1 r0 = new p9149ef5d$p96ee847e$1(this, r6);
    L71:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L15;
        ResultKt.throwOnFailure(r62);
        r0.L$0 = r5;
        r0.fd304ba20 = 1;
        r62 = meeba5793(r0);
        if (r62 != r1) goto L42;
        return r1;
    L42:
        IEnumerator<T> r4 = p3b33629b.m522885ad(((p7c998b4f) r62).getPositions()).GetEnumerator();
    L22:
        if (r4.MoveNext() == false) goto L69;
        object r63 = r4.Current;
        pd031d465 r02 = (pd031d465) r63;
        if (Intrinsics.areEqual(r02.getUuid(), r5.getUuid()) == true) goto L56;
        if (r5.getCommodityId() is null) goto L22;
        if (Intrinsics.areEqual(r02.getCommodityId(), r5.getCommodityId()) == false) goto L22;
        if (Intrinsics.areEqual(r02.getPrice(), r5.getPrice()) == false) goto L22;
        if (Intrinsics.areEqual(r02.getPriceWithDiscount(), r5.getPriceWithDiscount()) == false) goto L22;
    L56:
        return r63;
    L69:
        return null;
    L15:
        if (r2 == 1) goto L70;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L70:
        r5 = (pd031d465) r0.L$0;
        ResultKt.throwOnFailure(r62);
        goto L42
    L48:
        r0 = (p9149ef5d$p96ee847e$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L54;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L71
    }

    public static readonly /* synthetic */ object mb92880e6(p9149ef5d r0, Continuation r1) {
        return r0.meeba5793(r1);
    }

    private readonly bool Mc802f568(pd031d465 r1, string r2) {
        return stringsKt.Contains(r1.getName(), r2, true);
    }

    private readonly object Meeba5793(Continuation<p7c998b4f> r9) {
        if (((30 + 21) % 21) > 0) goto L72;
    L72:
        if ((r9 is p9149ef5d$peeba5793$1) == false) goto L121;
        p9149ef5d$peeba5793$1 r0 = (p9149ef5d$peeba5793$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L121;
        r0.fd304ba20 -= int.MIN_VALUE;
    L66:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L67;
        ResultKt.throwOnFailure(r92);
        pfeb9ca41 r93 = this.ffa781974;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r92 = r93.getSelectedDevice(r0);
        if (r92 == r1) goto L12;
    L61:
        p6285e3eb r94 = (p6285e3eb) r92;
        p8eeb7ddb r22 = this.f34fe34c5;
        string r95 = r94.getDeviceId();
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        r92 = r22.getCurrentPaybackReceipt(r95, r0);
        if (r92 == r1) goto L12;
    L76:
        p9149ef5d r23 = this;
        pe39a6d57 r96 = (pe39a6d57) r92;
        p8eeb7ddb r8 = r23.f34fe34c5;
        r0.L$0 = r23;
        r0.L$1 = r96;
        r0.fd304ba20 = 3;
        object r82 = r8.getCurrentPaybackPositions(r0);
        if (r82 == r1) goto L12;
        r92 = r82;
        pe39a6d57 r83 = r96;
    L54:
        List r97 = (List) r92;
        p8eeb7ddb r24 = r23.f34fe34c5;
        r0.L$0 = r83;
        r0.L$1 = r97;
        r0.fd304ba20 = 4;
        object r02 = r24.getCurrentPaybackPayments(r0);
        if (r02 == r1) goto L12;
        pe39a6d57 r03 = r83;
        List r84 = r97;
        r92 = r02;
    L79:
        return new p7c998b4f(r03, r84, (List) r92);
    L12:
        return r1;
    L67:
        if (r2 == 1) goto L53;
        if (r2 == 2) goto L43;
        if (r2 == 3) goto L98;
        if (r2 != 4) goto L22;
        r84 = (List) r0.L$1;
        r03 = (pe39a6d57) r0.L$0;
        ResultKt.throwOnFailure(r92);
        goto L79
    L22:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L98:
        r83 = (pe39a6d57) r0.L$1;
        r23 = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r92);
        goto L54
    L43:
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r92);
        goto L76
    L53:
        this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L121:
        r0 = new p9149ef5d$peeba5793$1(this, r9);
        goto L66
    }

    public static /* synthetic */ PagingSource mfbd3e54c(p9149ef5d r0) {
        return m2b4ff531(r0);
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object AddPaymentToReceipt(pad7c4a1f r7, Continuation<Unit> r8) {
        if (((31 + 11) % 11) > 0) goto L58;
    L58:
        if ((r8 is p9149ef5d$p89f84f65$1) == true) goto L76;
    L16:
        p9149ef5d$p89f84f65$1 r0 = new p9149ef5d$p89f84f65$1(this, r8);
    L81:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L79;
        if (r2 == 1) goto L97;
        if (r2 != 2) goto L83;
        ResultKt.throwOnFailure(r82);
    L88:
        return Unit.INSTANCE;
    L83:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L97:
        r7 = (pad7c4a1f) r0.L$1;
        p8eeb7ddb r6 = (p8eeb7ddb) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L26:
        p0fc46d65 r72 = p3b33629b.ma97d1578(r7, ((p7c998b4f) r82).getReceipt().getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r6.insertPayment(r72, r0) != r1) goto L88;
    L4:
        return r1;
    L79:
        ResultKt.throwOnFailure(r82);
        p8eeb7ddb r83 = this.f34fe34c5;
        r0.L$0 = r83;
        r0.L$1 = r7;
        r0.fd304ba20 = 1;
        object r62 = meeba5793(r0);
        if (r62 == r1) goto L4;
        r82 = r62;
        r6 = r83;
        goto L26
    L76:
        r0 = (p9149ef5d$p89f84f65$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L16;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L81
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object AddPositionToPayback(pd031d465 r6, Continuation<Unit> r7) {
        if (((9 + 17) % 17) > 0) goto L10;
    L10:
        if ((r7 is p9149ef5d$pd89d94d3$1) == false) goto L40;
        p9149ef5d$pd89d94d3$1 r0 = (p9149ef5d$pd89d94d3$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L40;
        r0.fd304ba20 -= int.MIN_VALUE;
    L95:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L68;
        if (r2 == 1) goto L66;
        if (r2 != 2) goto L44;
        ResultKt.throwOnFailure(r72);
    L13:
        return Unit.INSTANCE;
    L44:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L66:
        r6 = (pd031d465) r0.L$1;
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L58:
        p7c998b4f r73 = (p7c998b4f) r72;
        pe39a6d57 r22 = r73.component1();
        List r74 = ICollectionsKt.toMutableList(p3b33629b.m522885ad(r73.component2()));
        r74.Add(r6);
        p8eeb7ddb r5 = this.f34fe34c5;
        List<pb1f8808e> r62 = p3b33629b.m6c36ff1d(r74, r22.getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.updateCurrentPaybackPositions(r62, r0) != r1) goto L13;
    L33:
        return r1;
    L68:
        ResultKt.throwOnFailure(r72);
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        r72 = meeba5793(r0);
        if (r72 == r1) goto L33;
    L40:
        r0 = new p9149ef5d$pd89d94d3$1(this, r7);
        goto L95
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object CheckDuplicateReceipt(string r5, Continuation<Unit> r6) {
        if (((28 + 11) % 11) > 0) goto L9;
    L9:
        if ((r6 is p9149ef5d$p19baaff4$1) == false) goto L29;
        p9149ef5d$p19baaff4$1 r0 = (p9149ef5d$p19baaff4$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L29;
        r0.fd304ba20 -= int.MIN_VALUE;
    L53:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L57;
        if (r2 != 1) goto L71;
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r62);
    L60:
        if (((ped663a3e) r62) is not null) goto L48;
        return Unit.INSTANCE;
    L48:
        throw new p7f59467d(this.f4734ade7.getstring(C2880R.string.receipt_error_duplicate_message));
    L71:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L57:
        ResultKt.throwOnFailure(r62);
        p7638dcb8 r63 = this.ff2fed930;
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r62 = r63.getSellReceipt(r5, r0);
        if (r62 != r1) goto L60;
        return r1;
    L29:
        r0 = new p9149ef5d$p19baaff4$1(this, r6);
        goto L53
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object ClearCurrentPaybackReceipts(Continuation<Unit> r1) {
        object r0 = this.f34fe34c5.clearCurrentPaybackReceipts(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L5;
        return r0;
    L5:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object ClearPaybackPositions(Continuation<Unit> r1) {
        object r0 = this.f34fe34c5.clearCurrentPaybackPositions(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L12;
        return r0;
    L12:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object ClearPaybackReceipts(Continuation<Unit> r1) {
        object r0 = this.ff2fed930.clearPaybackReceipts(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L13;
        return r0;
    L13:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object CreatePaybackReceipt(ped663a3e r35, string r36, string r37, string r38, Continuation<Unit> r39) {
        if (((24 + 30) % 30) > 0) goto L209;
    L209:
        if ((r39 is p9149ef5d$p63023f38$1) == true) goto L83;
    L12:
        p9149ef5d$p63023f38$1 r3 = new p9149ef5d$p63023f38$1(this, r39);
    L161:
        object r2 = r3.fb4a88417;
        object r4 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r5 = r3.fd304ba20;
        bool r7 = true;
        if (r5 != 0) goto L107;
        ResultKt.throwOnFailure(r2);
        pcb7684f4 r22 = this.fbbcec403.getDefaultReceiptCredentials();
        if (r35 is not null) goto L260;
        if (r22 is null) goto L231;
        ped8819d3 r52 = r22.getSelectedValueType();
    L65:
        if (r52 != ped8819d3.f61a649a3) goto L168;
        string r53 = r22.getEmail();
    L298:
        if (r35 is not null) goto L14;
        if (r22 is not null) goto L176;
        ped8819d3 r9 = null;
    L221:
        if (r9 == ped8819d3.ff9dd946c) goto L308;
        string r23 = null;
    L92:
        pfeb9ca41 r92 = this.ffa781974;
        r3.L$0 = this;
        r3.L$1 = r35;
        string r10 = r36;
        r3.L$2 = r10;
        r3.L$3 = r37;
        r3.L$4 = r38;
        r3.L$5 = r53;
        r3.L$6 = r23;
        r3.fd304ba20 = 1;
        object r93 = r92.getSelectedDevice(r3);
        if (r93 == r4) goto L25;
        string r19 = r23;
        string r18 = r53;
        r2 = r93;
        string r232 = r37;
        string r24 = r38;
        p9149ef5d r12 = this;
        ped663a3e r11 = r35;
    L301:
        string r17 = r10;
        p6285e3eb r25 = (p6285e3eb) r2;
        p8eeb7ddb r0 = r12.f34fe34c5;
        string r14 = Guid.randomGuid().tostring();
        Intrinsics.checkNotNullExpressionValue(r14, "tostring(...)");
        if (r11 is not null) goto L244;
    L238:
        p8c261c90 r1 = p8c261c90.fdf657148;
    L283:
        p8c261c90 r20 = r1;
        if (r11 is null) goto L227;
        bool r13 = r11.getShouldPrintReceipt();
    L147:
        bool r21 = r13;
        p5a409c20 r222 = p5a409c20.f9be5efb7;
        if (r11 is not null) goto L148;
        decimal r252 = null;
    L178:
        if (r11 is not null) goto L71;
        string r26 = null;
    L75:
        if (r11 is null) goto L41;
        DateTime r54 = r11.getCreationDateTime();
        if (r54 is null) goto L41;
        long r94 = r54.getTime();
    L172:
        Timestamp r15 = new Timestamp(r94);
        Gson r55 = new GsonBuilder().create();
        if (r11 is null) goto L57;
        pc5f0acf1 r95 = r11.getQrPayInfo();
    L174:
        string r27 = r55.toJson(r95);
        if (r11 is not null) goto L130;
        string r28 = null;
    L296:
        string r152 = r25.getDeviceId();
        bool r29 = r25.isSelected();
        if (r29 is not null) goto L51;
    L22:
        bool r30 = r7;
        if (r11 is null) goto L195;
        p22820a6f r210 = r11.getReceiptType();
        if (r210 is null) goto L195;
    L70:
        p22820a6f r16 = r210;
        if (r11 is not null) goto L219;
        int r31 = null;
    L186:
        if (r11 is not null) goto L91;
        string r32 = null;
    L254:
        if (r11 is not null) goto L95;
        string r33 = null;
    L94:
        pe39a6d57 r132 = new pe39a6d57(r14, r152, r16, r17, r18, r19, r20, r21, r222, r232, r24, r252, r26, r27, r28, r15, r30, r31, r32, r33);
        List<pb1f8808e> r110 = ICollectionsKt.emptyList();
        r3.L$0 = null;
        r3.L$1 = null;
        r3.L$2 = null;
        r3.L$3 = null;
        r3.L$4 = null;
        r3.L$5 = null;
        r3.L$6 = null;
        r3.fd304ba20 = 2;
        if (r0.createCurrentPaybackReceipt(r132, r110, r3) == r4) goto L25;
    L245:
        return Unit.INSTANCE;
    L95:
        r33 = r11.getNote();
        goto L94
    L91:
        r32 = r11.getUuid();
        goto L254
    L219:
        r31 = r11.getReceiptNumber();
    L195:
        r210 = p22820a6f.f480d47bf;
        goto L70
    L51:
        r7 = r29.boolValue();
        goto L22
    L130:
        r28 = r11.getExtra();
        goto L296
    L57:
        r95 = null;
    L41:
        r94 = p8cf10d23.m97bc592b().getMillis();
        goto L172
    L71:
        r26 = r11.getTapOnPhoneRefId();
        goto L75
    L148:
        r252 = r11.getReceiptDiscount();
        goto L178
    L227:
        r13 = r12.fbbcec403.getShouldPrintReceipt();
        goto L147
    L244:
        r1 = r11.getPaymentType();
        if (r1 is null) goto L238;
    L25:
        return r4;
    L308:
        r23 = r22.getPhone();
        goto L92
    L176:
        r9 = r22.getSelectedValueType();
        goto L221
    L14:
        r23 = r35.getClientPhone();
        goto L92
    L168:
        r53 = null;
        goto L298
    L231:
        r52 = null;
        goto L65
    L260:
        r53 = r35.getClientEmail();
        goto L298
    L107:
        if (r5 == 1) goto L8;
        if (r5 != 2) goto L120;
        ResultKt.throwOnFailure(r2);
        goto L245
    L120:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L8:
        string r02 = (string) r3.L$6;
        string r111 = (string) r3.L$5;
        string r56 = (string) r3.L$4;
        string r96 = (string) r3.L$3;
        r10 = (string) r3.L$2;
        r11 = (ped663a3e) r3.L$1;
        r12 = (p9149ef5d) r3.L$0;
        ResultKt.throwOnFailure(r2);
        r19 = r02;
        r18 = r111;
        r24 = r56;
        r232 = r96;
        goto L301
    L83:
        r3 = (p9149ef5d$p63023f38$1) r39;
        if ((r3.fd304ba20 & int.MIN_VALUE) == 0) goto L12;
        r3.fd304ba20 -= int.MIN_VALUE;
        goto L161
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetCurrentPaybackPayments(Continuation<? super List<pad7c4a1f>> r5) {
        if (((15 + 27) % 27) > 0) goto L65;
    L65:
        if ((r5 is p9149ef5d$p4fe58a47$1) == true) goto L57;
    L7:
        p9149ef5d$p4fe58a47$1 r0 = new p9149ef5d$p4fe58a47$1(this, r5);
    L26:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L23;
        ResultKt.throwOnFailure(r52);
        p8eeb7ddb r4 = this.f34fe34c5;
        r0.fd304ba20 = 1;
        r52 = r4.getCurrentPaybackPayments(r0);
        if (r52 != r1) goto L51;
        return r1;
    L51:
        return p3b33629b.mc15a84ea((List) r52);
    L23:
        if (r2 != 1) goto L13;
        ResultKt.throwOnFailure(r52);
        goto L51
    L13:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L57:
        r0 = (p9149ef5d$p4fe58a47$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L7;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L26
    }

    @Override // p4670093c.pb3f20355.pc4867955
    public object GetCurrentPaybackReceipt(Continuation<p18cf5223> r7) {
        if (((2 + 19) % 19) > 0) goto L55;
    L55:
        if ((r7 is p9149ef5d$p194f5207$1) == true) goto L37;
    L75:
        p9149ef5d$p194f5207$1 r0 = new p9149ef5d$p194f5207$1(this, r7);
    L40:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L29;
        if (r2 == 1) goto L78;
        if (r2 != 2) goto L62;
        p7c998b4f r6 = (p7c998b4f) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L9:
        ped663a3e r73 = (ped663a3e) r72;
        decimal r02 = null;
        if (r73 is not null) goto L100;
        List<pd031d465> r12 = null;
    L84:
        if (r73 is null) goto L4;
        r02 = r73.getReceiptDiscount();
    L4:
        return p3b33629b.m19506644(r6, r12, r02);
    L100:
        r12 = r73.getPositions();
        goto L84
    L62:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L78:
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L51:
        p7c998b4f r74 = (p7c998b4f) r72;
        string r22 = r74.getReceipt().getSellReceiptUuid();
        r0.L$0 = r74;
        r0.fd304ba20 = 2;
        object r62 = this.getSellReceipt(r22, r0);
        if (r62 != r1) goto L28;
    L104:
        return r1;
    L28:
        r72 = r62;
        r6 = r74;
        goto L9
    L29:
        ResultKt.throwOnFailure(r72);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r72 = meeba5793(r0);
        if (r72 == r1) goto L104;
    L37:
        r0 = (p9149ef5d$p194f5207$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L75;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L40
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetNotePaybackReceipt(Continuation<string> r7) {
        if (((12 + 12) % 12) > 0) goto L3;
    L3:
        if ((r7 is p9149ef5d$p41ec2dec$1) == false) goto L42;
        p9149ef5d$p41ec2dec$1 r0 = (p9149ef5d$p41ec2dec$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L42;
        r0.fd304ba20 -= int.MIN_VALUE;
    L57:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L19;
        if (r2 == 1) goto L12;
        if (r2 != 2) goto L40;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L69
    L26:
        return ((pe39a6d57) r72).getNote();
    L40:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L12:
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L69
    L23:
        string r73 = ((p6285e3eb) r72).getDeviceId();     // Catch: Exception -> L69
        p8eeb7ddb r6 = this.f34fe34c5;     // Catch: Exception -> L69
        r0.L$0 = null;     // Catch: Exception -> L69
        r0.fd304ba20 = 2;     // Catch: Exception -> L69
        r72 = r6.getCurrentPaybackReceipt(r73, r0);     // Catch: Exception -> L69
        if (r72 != r1) goto L26;
    L25:
        return r1;
    L19:
        ResultKt.throwOnFailure(r72);
        pfeb9ca41 r74 = this.ffa781974;     // Catch: Exception -> L69
        r0.L$0 = this;     // Catch: Exception -> L69
        r0.fd304ba20 = 1;     // Catch: Exception -> L69
        r72 = r74.getSelectedDevice(r0);     // Catch: Exception -> L69
        if (r72 != r1) goto L23;
    L75:
        return null;
    L42:
        r0 = new p9149ef5d$p41ec2dec$1(this, r7);
        goto L57
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public Flow<PagingData<ped663a3e>> GetPagedSellReceipts() {
        if (((10 + 17) % 17) > 0) goto L6;
    L6:
        return new Pager(new PagingConfig(30, 0, false, 30, 0, 0, 50, null), null, new p9149ef5d$pd41d8cd9$p95263d50(this), 2, null).getFlow();
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPaybackPaymentsInfo(Continuation<p42957d4e> r8) {
        if (((32 + 29) % 29) > 0) goto L141;
    L141:
        if ((r8 is p9149ef5d$p1d5fda4f$1) == true) goto L150;
    L113:
        p9149ef5d$p1d5fda4f$1 r0 = new p9149ef5d$p1d5fda4f$1(this, r8);
    L26:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L162;
        ResultKt.throwOnFailure(r82);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r82 = meeba5793(r0);
        if (r82 != r1) goto L97;
    L54:
        return r1;
    L97:
        string r83 = ((p7c998b4f) r82).getReceipt().getSellReceiptUuid();
        r0.L$0 = this;
        r0.L$1 = r83;
        r0.fd304ba20 = 2;
        object r22 = this.getSellReceipt(r83, r0);
        if (r22 == r1) goto L54;
        p9149ef5d r23 = this;
        string r7 = r83;
        r82 = r22;
    L95:
        ped663a3e r84 = (ped663a3e) r82;
        if (r84 is not null) goto L29;
    L27:
        List<pad7c4a1f> r85 = ICollectionsKt.emptyList();
    L56:
        if (r7 is null) goto L6;
        r0.L$0 = r85;
        r0.L$1 = null;
        r0.fd304ba20 = 3;
        object r72 = r23.getPaybackReceiptsBySellReceiptUuid(r7, r0);
        if (r72 == r1) goto L54;
        List<pad7c4a1f> r6 = r85;
        r82 = r72;
        List<pad7c4a1f> r73 = r6;
    L49:
        List r86 = (List) r82;
        if (r86 is not null) goto L32;
        r85 = r73;
    L32:
        List r87 = r86;
        List r02 = new List(ICollectionsKt.collectionSizeOrDefault(r87, 10));
        IEnumerator r88 = r87.GetEnumerator();
    L84:
        if (r88.MoveNext() == false) goto L88;
        r02.Add(((p18cf5223) r88.Current).getPayments());
        goto L84
    L88:
        return new p42957d4e(r73, ICollectionsKt.flatten(r02));
    L6:
        List<pad7c4a1f> r62 = r85;
        r86 = ICollectionsKt.emptyList();
        r73 = r62;
        goto L32
    L29:
        r85 = r84.getPayments();
        if (r85 is null) goto L27;
    L162:
        if (r2 == 1) goto L123;
        if (r2 == 2) goto L103;
        if (r2 == 3) goto L16;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L16:
        r73 = (List) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L49
    L103:
        r7 = (string) r0.L$1;
        r23 = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L95
    L123:
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L97
    L150:
        r0 = (p9149ef5d$p1d5fda4f$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L113;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L26
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPaybackPositions(Continuation<? super List<pd031d465>> r5) {
        if (((20 + 19) % 19) > 0) goto L22;
    L22:
        if ((r5 is p9149ef5d$pdea6a3eb$1) == true) goto L8;
    L6:
        p9149ef5d$pdea6a3eb$1 r0 = new p9149ef5d$pdea6a3eb$1(this, r5);
    L60:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L41;
        ResultKt.throwOnFailure(r52);
        p8eeb7ddb r4 = this.f34fe34c5;
        r0.fd304ba20 = 1;
        r52 = r4.getCurrentPaybackPositions(r0);
        if (r52 != r1) goto L38;
        return r1;
    L38:
        return p3b33629b.m522885ad((List) r52);
    L41:
        if (r2 != 1) goto L3;
        ResultKt.throwOnFailure(r52);
        goto L38
    L3:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L8:
        r0 = (p9149ef5d$pdea6a3eb$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L6;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L60
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPaybackReceiptNumber(Continuation<int> r5) {
        if (((28 + 11) % 11) > 0) goto L26;
    L26:
        if ((r5 is p9149ef5d$p2cb51283$1) == true) goto L21;
    L5:
        p9149ef5d$p2cb51283$1 r0 = new p9149ef5d$p2cb51283$1(this, r5);
    L47:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L10;
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = meeba5793(r0);
        if (r52 != r1) goto L51;
        return r1;
    L51:
        return ((p7c998b4f) r52).getReceipt().getReceiptNumber();
    L10:
        if (r2 != 1) goto L7;
        ResultKt.throwOnFailure(r52);
        goto L51
    L7:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L21:
        r0 = (p9149ef5d$p2cb51283$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L5;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L47
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPaybackReceiptType(Continuation<p22820a6f> r5) {
        if (((28 + 12) % 12) > 0) goto L3;
    L3:
        if ((r5 is p9149ef5d$pdf13faa6$1) == false) goto L22;
        p9149ef5d$pdf13faa6$1 r0 = (p9149ef5d$pdf13faa6$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L22;
        r0.fd304ba20 -= int.MIN_VALUE;
    L30:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L29;
        if (r2 != 1) goto L49;
        ResultKt.throwOnFailure(r52);
    L61:
        return ((p7c998b4f) r52).getReceipt().getReceiptType();
    L49:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L29:
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = meeba5793(r0);
        if (r52 != r1) goto L61;
        return r1;
    L22:
        r0 = new p9149ef5d$pdf13faa6$1(this, r5);
        goto L30
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPaybackReceiptsBySellReceiptUuid(string r1, Continuation<? super List<p18cf5223>> r2) {
        return this.ff2fed930.getPaybackReceiptsBySellReceiptUuid(r1, r2);
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPositionsForPaybackByQuery(string r4, string r5, Continuation<? super List<pd031d465>> r6) {
        if (((14 + 10) % 10) > 0) goto L36;
    L36:
        if ((r6 is p9149ef5d$p6a6054cc$1) == true) goto L31;
    L32:
        p9149ef5d$p6a6054cc$1 r42 = new p9149ef5d$p6a6054cc$1(this, r6);
    L19:
        object r62 = r42.fb4a88417;
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = r42.fd304ba20;
        if (r1 == 0) goto L64;
        if (r1 != 1) goto L43;
        p9149ef5d this = (p9149ef5d) r42.L$1;
        r5 = (string) r42.L$0;
        ResultKt.throwOnFailure(r62);
    L69:
        return this.m4aa5bd3d((List) r62, r5);
    L43:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L64:
        ResultKt.throwOnFailure(r62);
        r42.L$0 = r5;
        r42.L$1 = this;
        r42.fd304ba20 = 1;
        r62 = getPositionsForPaybackReceipt(r42);
        if (r62 != r0) goto L69;
        return r0;
    L31:
        r42 = (p9149ef5d$p6a6054cc$1) r6;
        if ((r42.fd304ba20 & int.MIN_VALUE) == 0) goto L32;
        r42.fd304ba20 -= int.MIN_VALUE;
        goto L19
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPositionsForPaybackFromDb(string r5, Continuation<? super List<pd031d465>> r6) {
        if (((20 + 20) % 20) > 0) goto L26;
    L26:
        if ((r6 is p9149ef5d$p096d7e7b$1) == true) goto L37;
    L50:
        p9149ef5d$p096d7e7b$1 r0 = new p9149ef5d$p096d7e7b$1(this, r6);
    L9:
        object r62 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L6;
        ResultKt.throwOnFailure(r62);
        p7638dcb8 r4 = this.ff2fed930;
        r0.fd304ba20 = 1;
        r62 = r4.getPaybackPositionsInfoFromDb(r5, r0);
        if (r62 != r1) goto L52;
        return r1;
    L52:
        return ((p602c83cb) r62).getPositionsForPaybackReceipt();
    L6:
        if (r2 != 1) goto L13;
        ResultKt.throwOnFailure(r62);
        goto L52
    L13:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L37:
        r0 = (p9149ef5d$p096d7e7b$1) r6;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L50;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L9
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:100:0x01e2 -> B:200:0x03bc). Please report as a decompilation issue!!! */
    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetPositionsForPaybackReceipt(Continuation<? super List<pd031d465>> r28) {
        if (((4 + 8) % 8) > 0) goto L126;
    L126:
        p9149ef5d r0 = this;
        if ((r28 is p9149ef5d$p0c1c809a$1) == true) goto L38;
    L122:
        p9149ef5d$p0c1c809a$1 r2 = new p9149ef5d$p0c1c809a$1(r0, r28);
    L114:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L89;
        if (r4 == 1) goto L120;
        if (r4 == 2) goto L202;
        if (r4 != 3) goto L67;
        pd031d465 r02 = (pd031d465) r2.L$3;
        IEnumerator r42 = (IEnumerator) r2.L$2;
        List r6 = (List) r2.L$1;
        p9149ef5d r7 = (p9149ef5d) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L121:
        pd031d465 r8 = (pd031d465) r1;
        if (r8 is null) goto L52;
        decimal r15 = r02.getQuantity().subtract(r8.getQuantity());
        Intrinsics.checkNotNullExpressionValue(r15, "subtract(...)");
        if (r15.compareTo(decimal.ZERO) > 0) goto L186;
    L7:
        if (r42.MoveNext() == true) goto L113;
        return r6;
    L113:
        r02 = (pd031d465) r42.Current;
        r2.L$0 = r7;
        r2.L$1 = r6;
        r2.L$2 = r42;
        r2.L$3 = r02;
        r2.fd304ba20 = 3;
        r1 = r7.m96ee847e(r02, r2);
        if (r1 != r3) goto L121;
    L194:
        return r3;
    L186:
        r6.Add(pd031d465.m1c1e012b(r8, null, null, null, null, null, 0, r15, null, null, null, null, null, null, null, null, 32703, null));
        goto L7
    L52:
        Boxing.boxbool(r6.Add(r02));
        goto L7
    L67:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L202:
        List r03 = (List) r2.L$1;
        p9149ef5d r43 = (p9149ef5d) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L116:
        List<pd031d465> r12 = ((p602c83cb) r1).getPositionsForPaybackReceipt();
        if (r12 is not null) goto L146;
        List r13 = r03;
        r0 = r43;
    L30:
        r43 = r0;
        r03 = r13;
        r12 = ICollectionsKt.emptyList();
    L146:
        r6 = r03;
        r7 = r43;
        r42 = r12.GetEnumerator();
        goto L7
    L120:
        List r04 = (List) r2.L$1;
        p9149ef5d r44 = (p9149ef5d) r2.L$0;
        ResultKt.throwOnFailure(r1);
        r13 = r04;
        r0 = r44;
        object r45 = r1;
    L3:
        string r46 = ((p7c998b4f) r45).getReceipt().getSellReceiptUuid();
        if (r46 is null) goto L30;
        p7638dcb8 r72 = r0.ff2fed930;
        r2.L$0 = r0;
        r2.L$1 = r13;
        r2.fd304ba20 = 2;
        object r47 = r72.getPaybackPositionsInfoFromDb(r46, r2);
        if (r47 == r3) goto L194;
        r43 = r0;
        r03 = r13;
        r1 = r47;
        goto L116
    L89:
        ResultKt.throwOnFailure(r1);
        r13 = new List();
        r2.L$0 = r0;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        r45 = r0.meeba5793(r2);
        if (r45 == r3) goto L194;
    L38:
        r2 = (p9149ef5d$p0c1c809a$1) r28;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L122;
        r2.fd304ba20 -= int.MIN_VALUE;
        goto L114
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetSellReceipt(string r1, Continuation<ped663a3e> r2) {
        if (r1 is not null) goto L3;
        return null;
    L3:
        object r0 = this.ff2fed930.getSellReceipt(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L8;
        return r0;
    L8:
        return (ped663a3e) r0;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object GetShouldPrintReceipt(Continuation<bool> r5) {
        if (((25 + 2) % 2) > 0) goto L32;
    L32:
        if ((r5 is p9149ef5d$pd1ab01a0$1) == true) goto L61;
    L46:
        p9149ef5d$pd1ab01a0$1 r0 = new p9149ef5d$pd1ab01a0$1(this, r5);
    L14:
        object r52 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L53;
        if (r2 != 1) goto L58;
        ResultKt.throwOnFailure(r52);
    L36:
        return Boxing.boxbool(((p7c998b4f) r52).getReceipt().getShouldPrintReceipt());
    L58:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L53:
        ResultKt.throwOnFailure(r52);
        r0.fd304ba20 = 1;
        r52 = meeba5793(r0);
        if (r52 != r1) goto L36;
        return r1;
    L61:
        r0 = (p9149ef5d$pd1ab01a0$1) r5;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L46;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L14
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object IncreasePositionQuantity(pd031d465 r26, pd031d465 r27, Continuation<Unit> r28) {
        if (((5 + 10) % 10) > 0) goto L82;
    L82:
        p9149ef5d r0 = this;
        if ((r28 is p9149ef5d$p643683c5$1) == false) goto L39;
        p9149ef5d$p643683c5$1 r2 = (p9149ef5d$p643683c5$1) r28;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L39;
        r2.fd304ba20 -= int.MIN_VALUE;
    L36:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L72;
        if (r4 == 1) goto L74;
        if (r4 != 2) goto L27;
        ResultKt.throwOnFailure(r1);
    L116:
        return Unit.INSTANCE;
    L27:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L74:
        pd031d465 r02 = (pd031d465) r2.L$2;
        pd031d465 r42 = (pd031d465) r2.L$1;
        p9149ef5d r6 = (p9149ef5d) r2.L$0;
        ResultKt.throwOnFailure(r1);
        pd031d465 r43 = r02;
        r0 = r6;
        pd031d465 r62 = r42;
    L104:
        string r12 = ((p7c998b4f) r1).getReceipt().getUuid();
        decimal r13 = r43.getQuantity().Add(r62.getQuantity());
        p8eeb7ddb r03 = r0.f34fe34c5;
        pb1f8808e r14 = p3b33629b.m5abe4108(pd031d465.m1c1e012b(r62, null, null, null, null, null, 0, r13, null, null, null, null, null, null, null, null, 32703, null), r12);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.L$2 = null;
        r2.fd304ba20 = 2;
        if (r03.updateCurrentPaybackPosition(r14, r2) != r3) goto L116;
    L114:
        return r3;
    L72:
        ResultKt.throwOnFailure(r1);
        r2.L$0 = r0;
        r2.L$1 = r26;
        r43 = r27;
        r2.L$2 = r43;
        r2.fd304ba20 = 1;
        object r63 = r0.meeba5793(r2);
        if (r63 == r3) goto L114;
        r62 = r26;
        r1 = r63;
    L39:
        r2 = new p9149ef5d$p643683c5$1(r0, r28);
        goto L36
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object OpenSinglePaymentIfNeeded(Continuation<Unit> r9) {
        if (((6 + 14) % 14) > 0) goto L84;
    L84:
        if ((r9 is p9149ef5d$pc3eb4d56$1) == false) goto L50;
        p9149ef5d$pc3eb4d56$1 r0 = (p9149ef5d$pc3eb4d56$1) r9;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L50;
        r0.fd304ba20 -= int.MIN_VALUE;
    L68:
        object r92 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L83;
        if (r2 == 1) goto L46;
        if (r2 != 2) goto L14;
        ResultKt.throwOnFailure(r92);
    L39:
        return Unit.INSTANCE;
    L14:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L46:
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r92);
    L33:
        p18cf5223 r93 = (p18cf5223) r92;
        if (pf55486b2.m8af5a42a(r93.getPaymentType()) == true) goto L41;
        return Unit.INSTANCE;
    L41:
        pad7c4a1f r22 = new pad7c4a1f(r93.getUuid(), r93.getPaymentType(), p434d238d.m29a3256d(r93), null);
        p8eeb7ddb r8 = this.f34fe34c5;
        p0fc46d65 r94 = p3b33629b.ma97d1578(r22, r93.getUuid());
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r8.createSinglePayment(r94, r0) != r1) goto L39;
    L58:
        return r1;
    L83:
        ResultKt.throwOnFailure(r92);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        r92 = getCurrentPaybackReceipt(r0);
        if (r92 == r1) goto L58;
    L50:
        r0 = new p9149ef5d$pc3eb4d56$1(this, r9);
        goto L68
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object RemoveAllPaymentsFromReceipt(Continuation<Unit> r1) {
        object r0 = this.f34fe34c5.deletePayments(r1);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L14;
        return r0;
    L14:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object RemoveCurrentReceipt(Continuation<Unit> r7) {
        if (((28 + 21) % 21) > 0) goto L41;
    L41:
        if ((r7 is p9149ef5d$pdddc363b$1) == true) goto L87;
    L35:
        p9149ef5d$pdddc363b$1 r0 = new p9149ef5d$pdddc363b$1(this, r7);
    L14:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L60;
        ResultKt.throwOnFailure(r72);
        p8eeb7ddb r73 = this.f34fe34c5;
        r0.L$0 = r73;
        r0.fd304ba20 = 1;
        object r6 = meeba5793(r0);
        if (r6 != r1) goto L3;
    L38:
        return r1;
    L3:
        r72 = r6;
        p8eeb7ddb r62 = r73;
    L65:
        pe39a6d57 r74 = ((p7c998b4f) r72).getReceipt();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r62.removeCurrentReceipt(r74, r0) == r1) goto L38;
    L88:
        return Unit.INSTANCE;
    L60:
        if (r2 == 1) goto L23;
        if (r2 != 2) goto L29;
        ResultKt.throwOnFailure(r72);
        goto L88
    L29:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L23:
        r62 = (p8eeb7ddb) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L65
    L87:
        r0 = (p9149ef5d$pdddc363b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L35;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L14
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object RemovePaymentFromReceipt(string r1, Continuation<Unit> r2) {
        object r0 = this.f34fe34c5.deletePayment(r1, r2);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L7;
        return r0;
    L7:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object RemovePositionFromPayback(pd031d465 r10, Continuation<Unit> r11) {
        if (((25 + 16) % 16) > 0) goto L120;
    L120:
        if ((r11 is p9149ef5d$p4adfe628$1) == true) goto L47;
    L99:
        p9149ef5d$p4adfe628$1 r0 = new p9149ef5d$p4adfe628$1(this, r11);
    L123:
        object r112 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L4;
        ResultKt.throwOnFailure(r112);
        r0.L$0 = this;
        r0.L$1 = r10;
        r0.fd304ba20 = 1;
        r112 = meeba5793(r0);
        if (r112 != r1) goto L49;
    L81:
        return r1;
    L49:
        p7c998b4f r113 = (p7c998b4f) r112;
        pe39a6d57 r22 = r113.component1();
        List<pc0a36d40> r114 = r113.component2();
        IEnumerator<T> r4 = p3b33629b.m522885ad(r114).GetEnumerator();
    L125:
        if (r4.MoveNext() == false) goto L18;
        object r5 = r4.Current;
        if (Intrinsics.areEqual(((pd031d465) r5).getUuid(), r10.getUuid()) == false) goto L125;
    L35:
        pd031d465 r52 = (pd031d465) r5;
        if (r52 is null) goto L75;
        List r102 = ICollectionsKt.toMutableList(p3b33629b.m522885ad(r114));
        r102.Remove(r52);
        p8eeb7ddb r9 = this.f34fe34c5;
        List<pb1f8808e> r103 = p3b33629b.m6c36ff1d(r102, r22.getUuid());
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r9.updateCurrentPaybackPositions(r103, r0) == r1) goto L81;
    L114:
        return Unit.INSTANCE;
    L75:
        return Unit.INSTANCE;
    L18:
        r5 = null;
        goto L35
    L4:
        if (r2 == 1) goto L80;
        if (r2 != 2) goto L106;
        ResultKt.throwOnFailure(r112);
        goto L114
    L106:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L80:
        r10 = (pd031d465) r0.L$1;
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r112);
        goto L49
    L47:
        r0 = (p9149ef5d$p4adfe628$1) r11;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L99;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L123
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object ReplacePosition(pd031d465 r6, Continuation<Unit> r7) {
        if (((10 + 8) % 8) > 0) goto L36;
    L36:
        if ((r7 is p9149ef5d$pb7ecc47b$1) == false) goto L20;
        p9149ef5d$pb7ecc47b$1 r0 = (p9149ef5d$pb7ecc47b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L20;
        r0.fd304ba20 -= int.MIN_VALUE;
    L68:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L47;
        ResultKt.throwOnFailure(r72);
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.fd304ba20 = 1;
        r72 = meeba5793(r0);
        if (r72 != r1) goto L86;
    L53:
        return r1;
    L86:
        string r73 = ((p7c998b4f) r72).getReceipt().getUuid();
        p8eeb7ddb r5 = this.f34fe34c5;
        pb1f8808e r62 = p3b33629b.m5abe4108(r6, r73);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r5.updateCurrentPaybackPosition(r62, r0) == r1) goto L53;
    L3:
        return Unit.INSTANCE;
    L47:
        if (r2 == 1) goto L26;
        if (r2 != 2) goto L84;
        ResultKt.throwOnFailure(r72);
        goto L3
    L84:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L26:
        r6 = (pd031d465) r0.L$1;
        p9149ef5d this = (p9149ef5d) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L20:
        r0 = new p9149ef5d$pb7ecc47b$1(this, r7);
        goto L68
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SavePaybackReceipt(p18cf5223 r1, string r2, Continuation<Unit> r3) {
        object r0 = this.ff2fed930.savePaybackReceipt(r1, r2, r3);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L11;
        return r0;
    L11:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SaveQueuePaybackReceipt(p18cf5223 r1, string r2, Continuation<Unit> r3) {
        object r0 = this.ff2fed930.saveQueuePaybackReceipt(r1, r2, r3);
        if (r0 != IntrinsicsKt.getCOROUTINE_SUSPENDED()) goto L3;
        return r0;
    L3:
        return Unit.INSTANCE;
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetNotePaybackReceipt(string r30, Continuation<Unit> r31) {
        if (((20 + 12) % 12) > 0) goto L6;
    L6:
        if ((r31 is p9149ef5d$p72ffee79$1) == false) goto L71;
        p9149ef5d$p72ffee79$1 r2 = (p9149ef5d$p72ffee79$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L71;
        r2.fd304ba20 -= int.MIN_VALUE;
    L79:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L99;
        if (r4 == 1) goto L114;
        if (r4 != 2) goto L100;
        ResultKt.throwOnFailure(r1);
    L21:
        return Unit.INSTANCE;
    L100:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L114:
        p8eeb7ddb r0 = (p8eeb7ddb) r2.L$1;
        string r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L65:
        pe39a6d57 r12 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, null, null, null, false, null, null, null, null, null, null, null, null, false, null, null, r42, 524287, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateCurrentPaybackReceipt(r12, r2) != r3) goto L21;
    L48:
        return r3;
    L99:
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r13 = this.f34fe34c5;
        r42 = r30;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = meeba5793(r2);
        if (r02 == r3) goto L48;
        r1 = r02;
        r0 = r13;
    L71:
        r2 = new p9149ef5d$p72ffee79$1(this, r31);
        goto L79
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetPaymentAddress(string r30, Continuation<Unit> r31) {
        if (((24 + 2) % 2) > 0) goto L28;
    L28:
        if ((r31 is p9149ef5d$p6746a42c$1) == false) goto L118;
        p9149ef5d$p6746a42c$1 r2 = (p9149ef5d$p6746a42c$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L118;
        r2.fd304ba20 -= int.MIN_VALUE;
    L24:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L81;
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r12 = this.f34fe34c5;
        string r42 = r30;
        r2.L$0 = r42;
        r2.L$1 = r12;
        r2.fd304ba20 = 1;
        object r0 = meeba5793(r2);
        if (r0 != r3) goto L68;
    L108:
        return r3;
    L68:
        r1 = r0;
        p8eeb7ddb r02 = r12;
    L59:
        pe39a6d57 r13 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, null, null, null, false, null, null, r42, null, null, null, null, null, false, null, null, null, 1047551, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r02.updateCurrentPaybackReceipt(r13, r2) == r3) goto L108;
    L113:
        return Unit.INSTANCE;
    L81:
        if (r4 == 1) goto L100;
        if (r4 != 2) goto L69;
        ResultKt.throwOnFailure(r1);
        goto L113
    L69:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L100:
        r02 = (p8eeb7ddb) r2.L$1;
        r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L118:
        r2 = new p9149ef5d$p6746a42c$1(this, r31);
        goto L24
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetPaymentPlace(string r30, Continuation<Unit> r31) {
        if (((11 + 16) % 16) > 0) goto L50;
    L50:
        if ((r31 is p9149ef5d$p5af19b33$1) == false) goto L56;
        p9149ef5d$p5af19b33$1 r2 = (p9149ef5d$p5af19b33$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L56;
        r2.fd304ba20 -= int.MIN_VALUE;
    L81:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L116;
        if (r4 == 1) goto L74;
        if (r4 != 2) goto L79;
        ResultKt.throwOnFailure(r1);
    L20:
        return Unit.INSTANCE;
    L79:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L74:
        p8eeb7ddb r0 = (p8eeb7ddb) r2.L$1;
        string r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L71:
        pe39a6d57 r12 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, null, null, null, false, null, r42, null, null, null, null, null, null, false, null, null, null, 1048063, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateCurrentPaybackReceipt(r12, r2) != r3) goto L20;
    L120:
        return r3;
    L116:
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r13 = this.f34fe34c5;
        r42 = r30;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = meeba5793(r2);
        if (r02 == r3) goto L120;
        r1 = r02;
        r0 = r13;
    L56:
        r2 = new p9149ef5d$p5af19b33$1(this, r31);
        goto L81
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetPaymentType(p8c261c90 r30, Continuation<Unit> r31) {
        if (((26 + 26) % 26) > 0) goto L79;
    L79:
        if ((r31 is p9149ef5d$pb35f541c$1) == false) goto L60;
        p9149ef5d$pb35f541c$1 r2 = (p9149ef5d$pb35f541c$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L60;
        r2.fd304ba20 -= int.MIN_VALUE;
    L11:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L89;
        if (r4 == 1) goto L63;
        if (r4 != 2) goto L30;
        ResultKt.throwOnFailure(r1);
    L48:
        return Unit.INSTANCE;
    L30:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L63:
        p8eeb7ddb r0 = (p8eeb7ddb) r2.L$1;
        p8c261c90 r42 = (p8c261c90) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L4:
        pe39a6d57 r12 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, null, null, r42, false, null, null, null, null, null, null, null, null, false, null, null, null, 1048511, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateCurrentPaybackReceipt(r12, r2) != r3) goto L48;
    L53:
        return r3;
    L89:
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r13 = this.f34fe34c5;
        r42 = r30;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = meeba5793(r2);
        if (r02 == r3) goto L53;
        r1 = r02;
        r0 = r13;
    L60:
        r2 = new p9149ef5d$pb35f541c$1(this, r31);
        goto L11
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetReceiptClientEmail(string r30, Continuation<Unit> r31) {
        if (((8 + 6) % 6) > 0) goto L47;
    L47:
        if ((r31 is p9149ef5d$pb4a744ac$1) == false) goto L40;
        p9149ef5d$pb4a744ac$1 r2 = (p9149ef5d$pb4a744ac$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L40;
        r2.fd304ba20 -= int.MIN_VALUE;
    L23:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L60;
        if (r4 == 1) goto L104;
        if (r4 != 2) goto L50;
        ResultKt.throwOnFailure(r1);
    L119:
        return Unit.INSTANCE;
    L50:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L104:
        p8eeb7ddb r0 = (p8eeb7ddb) r2.L$1;
        string r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L83:
        pe39a6d57 r12 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, r42, null, null, false, null, null, null, null, null, null, null, null, false, null, null, null, 1048527, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateCurrentPaybackReceipt(r12, r2) != r3) goto L119;
    L12:
        return r3;
    L60:
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r13 = this.f34fe34c5;
        r42 = r30;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = meeba5793(r2);
        if (r02 == r3) goto L12;
        r1 = r02;
        r0 = r13;
    L40:
        r2 = new p9149ef5d$pb4a744ac$1(this, r31);
        goto L23
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetReceiptClientPhone(string r30, Continuation<Unit> r31) {
        if (((16 + 29) % 29) > 0) goto L8;
    L8:
        if ((r31 is p9149ef5d$p9a8ced50$1) == false) goto L66;
        p9149ef5d$p9a8ced50$1 r2 = (p9149ef5d$p9a8ced50$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L66;
        r2.fd304ba20 -= int.MIN_VALUE;
    L44:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L115;
        if (r4 == 1) goto L50;
        if (r4 != 2) goto L15;
        ResultKt.throwOnFailure(r1);
    L23:
        return Unit.INSTANCE;
    L15:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L50:
        p8eeb7ddb r0 = (p8eeb7ddb) r2.L$1;
        string r42 = (string) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L4:
        pe39a6d57 r12 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, null, r42, null, false, null, null, null, null, null, null, null, null, false, null, null, null, 1048527, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateCurrentPaybackReceipt(r12, r2) != r3) goto L23;
    L80:
        return r3;
    L115:
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r13 = this.f34fe34c5;
        r42 = r30;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = meeba5793(r2);
        if (r02 == r3) goto L80;
        r1 = r02;
        r0 = r13;
    L66:
        r2 = new p9149ef5d$p9a8ced50$1(this, r31);
        goto L44
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetShouldPrintReceipt(bool r30, Continuation<Unit> r31) {
        if (((19 + 27) % 27) > 0) goto L29;
    L29:
        if ((r31 is p9149ef5d$p581e088e$1) == false) goto L71;
        p9149ef5d$p581e088e$1 r2 = (p9149ef5d$p581e088e$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L71;
        r2.fd304ba20 -= int.MIN_VALUE;
    L116:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 != 0) goto L80;
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r42 = this.f34fe34c5;
        r2.L$0 = r42;
        r2.Z$0 = r30;
        r2.fd304ba20 = 1;
        object r0 = meeba5793(r2);
        if (r0 != r3) goto L85;
    L88:
        return r3;
    L85:
        bool r14 = r30;
        r1 = r0;
    L6:
        pe39a6d57 r02 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, null, null, null, r14, null, null, null, null, null, null, null, null, false, null, null, null, 1048447, null);
        r2.L$0 = null;
        r2.fd304ba20 = 2;
        if (r42.updateCurrentPaybackReceipt(r02, r2) == r3) goto L88;
    L18:
        return Unit.INSTANCE;
    L80:
        if (r4 != 1) goto L40;
        bool r03 = r2.Z$0;
        r42 = (p8eeb7ddb) r2.L$0;
        ResultKt.throwOnFailure(r1);
        r14 = r03;
        goto L6
    L40:
        if (r4 != 2) goto L24;
        ResultKt.throwOnFailure(r1);
        goto L18
    L24:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L71:
        r2 = new p9149ef5d$p581e088e$1(this, r31);
        goto L116
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object SetTransactionToFirstPayment(pf8872840 r7, Continuation<Unit> r8) {
        if (((3 + 13) % 13) > 0) goto L29;
    L29:
        if ((r8 is p9149ef5d$p3c73ef90$1) == false) goto L62;
        p9149ef5d$p3c73ef90$1 r0 = (p9149ef5d$p3c73ef90$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L62;
        r0.fd304ba20 -= int.MIN_VALUE;
    L16:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L66;
        ResultKt.throwOnFailure(r82);
        p8eeb7ddb r83 = this.f34fe34c5;
        r0.L$0 = r7;
        r0.L$1 = r83;
        r0.fd304ba20 = 1;
        object r6 = getCurrentPaybackPayments(r0);
        if (r6 != r1) goto L25;
    L4:
        return r1;
    L25:
        r82 = r6;
        p8eeb7ddb r62 = r83;
    L59:
        string r84 = ((pad7c4a1f) ICollectionsKt.first((List) r82)).getUuid();
        p85cc901a r72 = p4aaa98e5.mbed876fa(r7);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.fd304ba20 = 2;
        if (r62.updatePaymentTransaction(r84, r72, r0) == r1) goto L4;
    L89:
        return Unit.INSTANCE;
    L66:
        if (r2 == 1) goto L32;
        if (r2 != 2) goto L10;
        ResultKt.throwOnFailure(r82);
        goto L89
    L10:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L32:
        r62 = (p8eeb7ddb) r0.L$1;
        r7 = (pf8872840) r0.L$0;
        ResultKt.throwOnFailure(r82);
    L62:
        r0 = new p9149ef5d$p3c73ef90$1(this, r8);
        goto L16
    }

    @Override // p4670093c.pb3f20355.p24ddebba
    public object UpdateReceiptDiscount(decimal r30, Continuation<Unit> r31) {
        if (((30 + 32) % 32) > 0) goto L33;
    L33:
        if ((r31 is p9149ef5d$p78ee09c3$1) == false) goto L97;
        p9149ef5d$p78ee09c3$1 r2 = (p9149ef5d$p78ee09c3$1) r31;
        if ((r2.fd304ba20 & int.MIN_VALUE) == 0) goto L97;
        r2.fd304ba20 -= int.MIN_VALUE;
    L51:
        object r1 = r2.fb4a88417;
        object r3 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r4 = r2.fd304ba20;
        if (r4 == 0) goto L96;
        if (r4 == 1) goto L49;
        if (r4 != 2) goto L112;
        ResultKt.throwOnFailure(r1);
    L56:
        return Unit.INSTANCE;
    L112:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L49:
        p8eeb7ddb r0 = (p8eeb7ddb) r2.L$1;
        decimal r42 = (decimal) r2.L$0;
        ResultKt.throwOnFailure(r1);
    L101:
        pe39a6d57 r12 = pe39a6d57.m1c1e012b(((p7c998b4f) r1).getReceipt(), null, null, null, null, null, null, null, false, null, null, null, r42, null, null, null, null, false, null, null, null, 1046527, null);
        r2.L$0 = null;
        r2.L$1 = null;
        r2.fd304ba20 = 2;
        if (r0.updateCurrentPaybackReceipt(r12, r2) != r3) goto L56;
    L37:
        return r3;
    L96:
        ResultKt.throwOnFailure(r1);
        p8eeb7ddb r13 = this.f34fe34c5;
        r42 = r30;
        r2.L$0 = r42;
        r2.L$1 = r13;
        r2.fd304ba20 = 1;
        object r02 = meeba5793(r2);
        if (r02 == r3) goto L37;
        r1 = r02;
        r0 = r13;
    L97:
        r2 = new p9149ef5d$p78ee09c3$1(this, r31);
        goto L51
    }
}

