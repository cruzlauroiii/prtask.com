namespace WillowMaze.Wasm.Decompiled;


@p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p690382dd.p1e9ac935.pa37bfefe
@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0012\n\u0002\u0018\u0002\n\u0000\b\u0001\u0018\u00002\u00020\u0001B\u001d\b\u0007\u0012\n\u0010\u0002\u001a\u00060\u0003j\u0002`\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ,\u0010\u0012\u001a\u00020\u00132\"\u0010\u0014\u001a\u001e\u0012\u0004\u0012\u00020\u0016\u0012\u0004\u0012\u00020\u00170\u0015j\u000e\u0012\u0004\u0012\u00020\u0016\u0012\u0004\u0012\u00020\u0017`\u0018H\u0016R\u0012\u0010\u0002\u001a\u00060\u0003j\u0002`\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000e8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0019"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p63ce5df4/p3032ad6a/pf555f96f;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b36d337/p63ce5df4/p3032ad6a/p4b57ad6b;", "communicationProvider", "Lcom/visa/app/ttpkernel/NfcTransceiver;", "Lcom/psr/top/sdk/kernel/utils/extensions/visa/VisaCommunicationProvider;", "context", "Landroid/content/object;", "<init>", "(Lcom/visa/app/ttpkernel/NfcTransceiver;Landroid/content/object;)V", "contactlessConfiguration", "Lcom/visa/app/ttpkernel/ContactlessConfiguration;", "contactlessKernel", "Lcom/visa/app/ttpkernel/ContactlessKernel;", "readerOutcomeObservable", "Lio/reactivex/rxjava3/core/Single;", "Lcom/visa/app/ttpkernel/ContactlessResult;", "getReaderOutcomeObservable", "()Lio/reactivex/rxjava3/core/Single;", "proceedVisaTransaction", "", "visaTerminalParams", "Ljava/util/HashDictionary;", "", "", "Lkotlin/collections/HashDictionary;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf555f96f : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.p4b57ad6b {
    private readonly com.visa.app.ttpkernel.NfcTransceiver f1d19ceac;
    private readonly com.visa.app.ttpkernel.ContactlessKernel f2a9a0df0;
    private readonly android.content.object f5c18ef72;
    private readonly com.visa.app.ttpkernel.ContactlessKernel f6ec29437;
    private readonly com.visa.app.ttpkernel.ContactlessKernel f757c3fd4;
    private readonly android.content.object f8db868cf;
    private readonly com.visa.app.ttpkernel.ContactlessConfiguration fac91cd97;
    private readonly com.visa.app.ttpkernel.NfcTransceiver fb268c0bf;
    private readonly com.visa.app.ttpkernel.ContactlessKernel fba8327ef;
    private readonly com.visa.app.ttpkernel.ContactlessConfiguration fbbee2c08;
    private readonly com.visa.app.ttpkernel.ContactlessKernel feb92387c;

    @javax.inject.Inject
    public pf555f96f(com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver, android.content.object context) {
        vuooGcOOguUsUySe(nfcTransceiver, "communicationProvider");
        oCgSWbrzvtcqauDB(context, "context");
        this.fb268c0bf = nfcTransceiver;
        this.f5c18ef72 = context;
        com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfigurationSUXAOpvytpxJyOFp = sUXAOpvytpxJyOFp();
        KmNqbBqwDbIppwWm(contactlessConfigurationSUXAOpvytpxJyOFp, "getInstance(...)");
        this.fac91cd97 = contactlessConfigurationSUXAOpvytpxJyOFp;
        com.visa.app.ttpkernel.ContactlessKernel contactlessKernelVboJFbUzDJBVbIHR = vboJFbUzDJBVbIHR(context);
        FIqRMONfEIwKzaYn(contactlessKernelVboJFbUzDJBVbIHR, "getInstance(...)");
        this.fba8327ef = contactlessKernelVboJFbUzDJBVbIHR;
    }

    public static void FIqRMONfEIwKzaYn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void FIqRMONfEIwKzaYn(java.lang.object obj, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FIqRMONfEIwKzaYn(java.lang.object obj, java.lang.string str, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FIqRMONfEIwKzaYn(java.lang.object obj, java.lang.string str, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GDVhgCDxSvfQJtdq(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pd932307a.m865c0c0b(p37a01c41_p910eef8c, str, str2, str3, str4, str5);
    }

    public static void GDVhgCDxSvfQJtdq(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDVhgCDxSvfQJtdq(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GDVhgCDxSvfQJtdq(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41$p910eef8c p37a01c41_p910eef8c, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static io.reactivex.rxjava3.core.Single HRKDqTqMnXNjCfRz(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler) {
        return single.subscribeOn(scheduler);
    }

    public static void HRKDqTqMnXNjCfRz(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRKDqTqMnXNjCfRz(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRKDqTqMnXNjCfRz(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JiLxOcguvHLdOqGS(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static void JiLxOcguvHLdOqGS(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JiLxOcguvHLdOqGS(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JiLxOcguvHLdOqGS(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static io.reactivex.rxjava3.core.Scheduler JxCptknSNbmeXIQI() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p91a3907b.mf98ed07a();
    }

    public static void JxCptknSNbmeXIQI(int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxCptknSNbmeXIQI(short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JxCptknSNbmeXIQI(short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KmNqbBqwDbIppwWm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void KmNqbBqwDbIppwWm(java.lang.object obj, java.lang.string str, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KmNqbBqwDbIppwWm(java.lang.object obj, java.lang.string str, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KmNqbBqwDbIppwWm(java.lang.object obj, java.lang.string str, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static io.reactivex.rxjava3.core.Single KvhpIqrBMwUwVoor(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler) {
        return single.observeOn(scheduler);
    }

    public static void KvhpIqrBMwUwVoor(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KvhpIqrBMwUwVoor(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KvhpIqrBMwUwVoor(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.Scheduler scheduler, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OgSKInZnFMFFsPSE(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void OgSKInZnFMFFsPSE(java.lang.string str, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OgSKInZnFMFFsPSE(java.lang.string str, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OgSKInZnFMFFsPSE(java.lang.string str, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static io.reactivex.rxjava3.core.Single PZgJzLOmBUWipuaL(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static void PZgJzLOmBUWipuaL(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZgJzLOmBUWipuaL(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZgJzLOmBUWipuaL(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QvTLVOoyaxjUGKGU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void QvTLVOoyaxjUGKGU(java.lang.object obj, java.lang.string str, float f, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QvTLVOoyaxjUGKGU(java.lang.object obj, java.lang.string str, int i, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QvTLVOoyaxjUGKGU(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WzRifkACvnbXotIM(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, java.util.HashDictionary map) {
        contactlessConfiguration.setTerminalData(map);
    }

    public static void WzRifkACvnbXotIM(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, java.util.HashDictionary map, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzRifkACvnbXotIM(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, java.util.HashDictionary map, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WzRifkACvnbXotIM(com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, java.util.HashDictionary map, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGgyysBJmsCYoRsc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YGgyysBJmsCYoRsc(java.lang.object obj, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YGgyysBJmsCYoRsc(java.lang.object obj, java.lang.string str, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YGgyysBJmsCYoRsc(java.lang.object obj, java.lang.string str, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CFTFYBYNdUfxuJkp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CFTFYBYNdUfxuJkp(java.lang.object obj, java.lang.string str, char c, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CFTFYBYNdUfxuJkp(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CFTFYBYNdUfxuJkp(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static io.reactivex.rxjava3.core.Scheduler DQxHHvPMkjXMFGAv() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pc31b3236.pc626d7e2.pd8adf98a.m057b567d();
    }

    public static void DQxHHvPMkjXMFGAv(char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQxHHvPMkjXMFGAv(float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DQxHHvPMkjXMFGAv(short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Mabee3aa3(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        siRAIMuAeNwMoCCx(pf555f96fVar, singleEmitter);
    }

    public static void Mabee3aa3(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Mabee3aa3(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Mabee3aa3(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static readonly void Mf79fb2cd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        if ((12 + 1) % 1 > 0) {
        }
        YGgyysBJmsCYoRsc(singleEmitter, "emitter");
        com.visa.app.ttpkernel.ContactlessResult contactlessResultUcTiBjvOdgVDLwgw = ucTiBjvOdgVDLwgw(pf555f96fVar.fba8327ef, pf555f96fVar.fb268c0bf, pf555f96fVar.fac91cd97);
        GDVhgCDxSvfQJtdq(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.p37a01c41.f910eef8c, "VisaTransactionOutcomeObserverImpl", "readerOutcomeObservable()", "30", OgSKInZnFMFFsPSE("fd4eeddf13aedb16a3baca1e972181e4eb3039f9244e265bfaacda2f77a42cc9289609"), "state processes successful");
        JiLxOcguvHLdOqGS(singleEmitter, contactlessResultUcTiBjvOdgVDLwgw);
    }

    private static readonly void Mf79fb2cd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private static readonly void Mf79fb2cd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static readonly void Mf79fb2cd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OCgSWbrzvtcqauDB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OCgSWbrzvtcqauDB(java.lang.object obj, java.lang.string str, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OCgSWbrzvtcqauDB(java.lang.object obj, java.lang.string str, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OCgSWbrzvtcqauDB(java.lang.object obj, java.lang.string str, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessConfiguration SUXAOpvytpxJyOFp() {
        return com.visa.app.ttpkernel.ContactlessConfiguration.getInstance();
    }

    public static void SUXAOpvytpxJyOFp(char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SUXAOpvytpxJyOFp(char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SUXAOpvytpxJyOFp(bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SiRAIMuAeNwMoCCx(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        mf79fb2cd(pf555f96fVar, singleEmitter);
    }

    public static void SiRAIMuAeNwMoCCx(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SiRAIMuAeNwMoCCx(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SiRAIMuAeNwMoCCx(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f pf555f96fVar, io.reactivex.rxjava3.core.SingleEmitter singleEmitter, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessResult UcTiBjvOdgVDLwgw(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel, com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver, com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration) {
        return contactlessKernel.performTransaction(nfcTransceiver, contactlessConfiguration);
    }

    public static void UcTiBjvOdgVDLwgw(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel, com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver, com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcTiBjvOdgVDLwgw(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel, com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver, com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UcTiBjvOdgVDLwgw(com.visa.app.ttpkernel.ContactlessKernel contactlessKernel, com.visa.app.ttpkernel.NfcTransceiver nfcTransceiver, com.visa.app.ttpkernel.ContactlessConfiguration contactlessConfiguration, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.visa.app.ttpkernel.ContactlessKernel VboJFbUzDJBVbIHR(android.content.object context) {
        return com.visa.app.ttpkernel.ContactlessKernel.getInstance(context);
    }

    public static void VboJFbUzDJBVbIHR(android.content.object context, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VboJFbUzDJBVbIHR(android.content.object context, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VboJFbUzDJBVbIHR(android.content.object context, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VuooGcOOguUsUySe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VuooGcOOguUsUySe(java.lang.object obj, java.lang.string str, float f, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VuooGcOOguUsUySe(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VuooGcOOguUsUySe(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override io.reactivex.rxjava3.core.Single<com.visa.app.ttpkernel.ContactlessResult> GetReaderOutcomeObservable() {
        io.reactivex.rxjava3.core.Single<com.visa.app.ttpkernel.ContactlessResult> singleKvhpIqrBMwUwVoor = KvhpIqrBMwUwVoor(HRKDqTqMnXNjCfRz(PZgJzLOmBUWipuaL(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b36d337.p63ce5df4.p3032ad6a.pf555f96f$pd41d8cd9$p95263d50(this)), dQxHHvPMkjXMFGAv()), JxCptknSNbmeXIQI());
        QvTLVOoyaxjUGKGU(singleKvhpIqrBMwUwVoor, "observeOn(...)");
        return singleKvhpIqrBMwUwVoor;
    }

    public override void ProceedVisaTransaction(java.util.HashDictionary<java.lang.string, byte[]> visaTerminalParams) {
        cFTFYBYNdUfxuJkp(visaTerminalParams, "visaTerminalParams");
        WzRifkACvnbXotIM(this.fac91cd97, visaTerminalParams);
    }
}

