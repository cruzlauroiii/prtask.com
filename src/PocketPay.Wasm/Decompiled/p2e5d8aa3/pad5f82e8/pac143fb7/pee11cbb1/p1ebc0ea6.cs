using Com.Google.Firebase.Crashlytics;
using Java.Util;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Internal;
using P2e5d8aa3.Pe0212e54.Pb3f20355;
using P2e5d8aa3.Pee11cbb1.Pac143fb7;
using P2e5d8aa3.Pf5e638cc;
using P8325324b.Pb3f20355;
using Pad5f82e8.P07214c67.Pe0212e54;
using Pe0212e54.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p1ebc0ea6 : pfdb21b31 {
    private readonly p44cd4abe f28945342;
    private readonly p3851083a f5763b9ea;
    private readonly p2d884c28 f61d07cbb;
    private readonly p44cd4abe f8af308bf;
    private readonly p3851083a f91b5f5ab;
    private readonly p44cd4abe fa3254a24;
    private readonly p3851083a facdd7b14;
    private readonly p2d884c28 fb3410804;
    private readonly p2d884c28 fbbcec403;
    private readonly p2d884c28 fd7313942;
    private readonly p3851083a fddc8a54d;
    private readonly p2d884c28 fe6316984;
    private readonly p3851083a ff618e1f8;
    private readonly p44cd4abe fff003797;

    public p1ebc0ea6(p2d884c28 r2, p44cd4abe r3, p3851083a r4) {
        Intrinsics.checkNotNullParameter(r2, "localHashSettingsRepository");
        Intrinsics.checkNotNullParameter(r3, "devicesRepository");
        Intrinsics.checkNotNullParameter(r4, "sellReceiptRepository");
        this.fbbcec403 = r2;
        this.f8af308bf = r3;
        this.f91b5f5ab = r4;
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void ClearLocalHashSettings() {
        this.fbbcec403.clearLocalHashSettings();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public p1c76cbfe GetCompany() {
        return this.fbbcec403.getCompany();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public List<string> GetCompanyobjectCodes() {
        return this.fbbcec403.getCompanyobjectCodes();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public pe95cecb3 GetInventoryDesignType() {
        return this.fbbcec403.getInventoryDesignType();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public string GetPaymentAddress() {
        return this.fbbcec403.getPaymentAddress();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public string GetPaymentPlace() {
        return this.fbbcec403.getPaymentPlace();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public pad7a6ae3 GetUserLocationInfo() {
        return this.fbbcec403.getLocationInfo();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public bool GetUserLocationHashSetting() {
        return this.fbbcec403.getUserLocationHashSetting();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public bool IsAddressesMatches() {
        return this.fbbcec403.isAddressesMatches();
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public object IsFastSellEnabled(Continuation<bool> r7) {
        if (((20 + 30) % 30) > 0) goto L5;
    L5:
        if ((r7 is p1ebc0ea6$pc6e59d49$1) == false) goto L35;
        p1ebc0ea6$pc6e59d49$1 r0 = (p1ebc0ea6$pc6e59d49$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L35;
        r0.fd304ba20 -= int.MIN_VALUE;
    L16:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L64;
        ResultKt.throwOnFailure(r72);
        p2d884c28 r73 = this.fbbcec403;     // Catch: Exception -> L73
        p44cd4abe r6 = this.f8af308bf;     // Catch: Exception -> L73
        r0.L$0 = r73;     // Catch: Exception -> L73
        r0.fd304ba20 = 1;     // Catch: Exception -> L73
        object r62 = r6.getSelectedDevice(r0);     // Catch: Exception -> L73
        if (r62 == r1) goto L60;
        r72 = r62;
        p2d884c28 r63 = r73;
    L58:
        string r74 = ((p4f30e9bd) r72).getDeviceId();     // Catch: Exception -> L73
        r0.L$0 = null;     // Catch: Exception -> L73
        r0.fd304ba20 = 2;     // Catch: Exception -> L73
        r72 = r63.isFastSellEnabled(r74, r0);     // Catch: Exception -> L73
        if (r72 == r1) goto L60;
    L61:
        return Boxing.boxbool(((bool) r72).boolValue());
    L60:
        return r1;
    L64:
        if (r2 == 1) goto L42;
        if (r2 != 2) goto L10;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L73
        goto L61
    L10:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L42:
        r63 = (p2d884c28) r0.L$0;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L73
    L73:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        return Boxing.boxbool(false);
    L35:
        r0 = new p1ebc0ea6$pc6e59d49$1(this, r7);
        goto L16
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public object IsFirstTimeFastSellEnabled(Continuation<bool> r7) {
        if (((16 + 28) % 28) > 0) goto L53;
    L53:
        if ((r7 is p1ebc0ea6$p9cde915b$1) == false) goto L43;
        p1ebc0ea6$p9cde915b$1 r0 = (p1ebc0ea6$p9cde915b$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L43;
        r0.fd304ba20 -= int.MIN_VALUE;
    L82:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L8;
        ResultKt.throwOnFailure(r72);
        p2d884c28 r73 = this.fbbcec403;
        p44cd4abe r6 = this.f8af308bf;
        r0.L$0 = r73;
        r0.fd304ba20 = 1;
        object r62 = r6.getSelectedDevice(r0);
        if (r62 != r1) goto L7;
    L21:
        return r1;
    L7:
        r72 = r62;
        p2d884c28 r63 = r73;
    L79:
        string r74 = ((p4f30e9bd) r72).getDeviceId();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        object r64 = r63.isFirstTimeFastSellEnabled(r74, r0);
        if (r64 == r1) goto L21;
        return r64;
    L8:
        if (r2 == 1) goto L87;
        if (r2 != 2) goto L26;
        ResultKt.throwOnFailure(r72);
        return r72;
    L26:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L87:
        r63 = (p2d884c28) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L43:
        r0 = new p1ebc0ea6$p9cde915b$1(this, r7);
        goto L82
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void SetAddressesMatches(bool r1) {
        this.fbbcec403.setAddressesMatches(r1);
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void SetCompany(p1c76cbfe r2) {
        Intrinsics.checkNotNullParameter(r2, "company");
        this.fbbcec403.setCompany(r2);
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public object SetFastSellEnabled(bool r9, Continuation<Unit> r10) {
        if (((17 + 22) % 22) > 0) goto L70;
    L70:
        if ((r10 is p1ebc0ea6$pf023e8c8$1) == true) goto L28;
    L77:
        p1ebc0ea6$pf023e8c8$1 r0 = new p1ebc0ea6$pf023e8c8$1(this, r10);
    L4:
        object r102 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L17;
        if (r2 == 1) goto L76;
        if (r2 == 2) goto L91;
        if (r2 != 3) goto L34;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L32
    L57:
        return Unit.INSTANCE;
    L34:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L91:
        p1ebc0ea6 r8 = (p1ebc0ea6) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L32
    L26:
        p3851083a r82 = r8.f91b5f5ab;     // Catch: Exception -> L32
        r0.L$0 = null;     // Catch: Exception -> L32
        r0.fd304ba20 = 3;     // Catch: Exception -> L32
        if (r82.removeCurrentReceipt(r0) != r1) goto L57;
    L31:
        return r1;
    L76:
        r9 = r0.Z$0;
        p2d884c28 r83 = (p2d884c28) r0.L$1;
        p1ebc0ea6 r22 = (p1ebc0ea6) r0.L$0;
        ResultKt.throwOnFailure(r102);     // Catch: Exception -> L32
    L22:
        string r103 = ((p4f30e9bd) r102).getDeviceId();     // Catch: Exception -> L32
        r0.L$0 = r22;     // Catch: Exception -> L32
        r0.L$1 = null;     // Catch: Exception -> L32
        r0.fd304ba20 = 2;     // Catch: Exception -> L32
        if (r83.setFastSellEnabled(r103, r9, r0) == r1) goto L31;
        r8 = r22;
        goto L26
    L17:
        ResultKt.throwOnFailure(r102);
        p2d884c28 r104 = this.fbbcec403;     // Catch: Exception -> L32
        p44cd4abe r23 = this.f8af308bf;     // Catch: Exception -> L32
        r0.L$0 = this;     // Catch: Exception -> L32
        r0.L$1 = r104;     // Catch: Exception -> L32
        r0.Z$0 = r9;     // Catch: Exception -> L32
        r0.fd304ba20 = 1;     // Catch: Exception -> L32
        object r24 = r23.getSelectedDevice(r0);     // Catch: Exception -> L32
        if (r24 == r1) goto L31;
        r22 = this;
        r83 = r104;
        r102 = r24;
    L32:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        goto L57
    L28:
        r0 = (p1ebc0ea6$pf023e8c8$1) r10;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L77;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L4
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public object SetFirstTimeFastSellEnabled(bool r7, Continuation<Unit> r8) {
        if (((8 + 3) % 3) > 0) goto L87;
    L87:
        if ((r8 is p1ebc0ea6$p11dd0d3e$1) == true) goto L86;
    L32:
        p1ebc0ea6$p11dd0d3e$1 r0 = new p1ebc0ea6$p11dd0d3e$1(this, r8);
    L94:
        object r82 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 != 0) goto L41;
        ResultKt.throwOnFailure(r82);
        p2d884c28 r83 = this.fbbcec403;
        p44cd4abe r6 = this.f8af308bf;
        r0.L$0 = r83;
        r0.Z$0 = r7;
        r0.fd304ba20 = 1;
        object r62 = r6.getSelectedDevice(r0);
        if (r62 != r1) goto L21;
    L59:
        return r1;
    L21:
        r82 = r62;
        p2d884c28 r63 = r83;
    L80:
        string r84 = ((p4f30e9bd) r82).getDeviceId();
        r0.L$0 = null;
        r0.fd304ba20 = 2;
        if (r63.setFirstTimeFastSellEnabled(r84, r7, r0) == r1) goto L59;
    L67:
        return Unit.INSTANCE;
    L41:
        if (r2 == 1) goto L34;
        if (r2 != 2) goto L62;
        ResultKt.throwOnFailure(r82);
        goto L67
    L62:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L34:
        r7 = r0.Z$0;
        r63 = (p2d884c28) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L80
    L86:
        r0 = (p1ebc0ea6$p11dd0d3e$1) r8;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L32;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L94
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void SetInventoryDesignType(pe95cecb3 r2) {
        Intrinsics.checkNotNullParameter(r2, "inventoryDesignType");
        this.fbbcec403.setInventoryDesignType(r2);
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void SetPaymentAddress(string r2) {
        Intrinsics.checkNotNullParameter(r2, "paymentAddress");
        this.fbbcec403.setPaymentAddress(r2);
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void SetPaymentPlace(string r2) {
        Intrinsics.checkNotNullParameter(r2, "paymentPlace");
        this.fbbcec403.setPaymentPlace(r2);
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void SetUserLocationHashSetting(bool r1) {
        this.fbbcec403.setUserLocationHashSetting(r1);
    }

    @Override // p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31
    public void UpdateLocationHashSettings(pad7a6ae3 r2) {
        Intrinsics.checkNotNullParameter(r2, "locationInfo");
        this.fbbcec403.setLocationInfo(r2);
    }
}

