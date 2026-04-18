namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0001\u0018\u00002\u00020\u00012\u00020\u0002B\u0011\b\u0007\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\b\u0010\u0007\u001a\u00020\bH\u0016J\b\u0010\t\u001a\u00020\bH\u0016J\u001a\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH\u0016J\u0010\u0010\u0010\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u0011\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0010\u0010\u0012\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p06299358/pc601e51c;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p06299358/p3e126910;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/p80c2998c/p7f8e5663;", "app", "Landroid/app/Application;", "<init>", "(Landroid/app/Application;)V", "deviceHasNFC", "Lio/reactivex/rxjava3/core/Completable;", "nfcIsEnabled", "onobjectCreated", "", "activity", "Landroid/app/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onobjectResumed", "onobjectPaused", "onobjectPreDestroyed", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc601e51c : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p80c2998c.p7f8e5663 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.p3e126910 {
    private readonly android.app.Application fd2a57dc1;
    private readonly android.app.Application fe9392dd4;

    @javax.inject.Inject
    public pc601e51c(android.app.Application application) {
        yVJouJWxwnVQWTcT(application, "app");
        this.fd2a57dc1 = application;
    }

    public static android.content.object ANoFwoGdUOSneWJB(android.app.Application application) {
        return application.getApplicationobject();
    }

    public static android.content.object BhBiYJohLDSqettV(android.app.Application application) {
        return application.getApplicationobject();
    }

    public static void CxrsXkCffMTazdRE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.content.object DGwICNQxTzwHcNQy(android.app.Application application) {
        return application.getApplicationobject();
    }

    public static android.nfc.NfcAdapter DLgBkwofsBCbxcJF(android.content.object context) {
        return android.nfc.NfcAdapter.getDefaultAdapter(context);
    }

    public static android.content.object FbGmRQeGpwubWcpc(android.content.object intent, int i) {
        return intent.addFlags(i);
    }

    public static void HYMabBcOcqUllzUs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void HZesimFSWglFXSxX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.nfc.NfcAdapter MDkJbaFcdeEnidFn(android.content.object context) {
        return android.nfc.NfcAdapter.getDefaultAdapter(context);
    }

    public static void MdLYXxKseDBMjbQY(android.nfc.NfcAdapter nfcAdapter, android.app.object activity, android.nfc.NfcAdapter$ReaderCallback nfcAdapter$ReaderCallback, int i, android.os.Dictionary<string, object> bundle) {
        nfcAdapter.enableReaderMode(activity, nfcAdapter$ReaderCallback, i, bundle);
    }

    public static void NHaEnwbnLaGKgjQk(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        completableEmitter.onComplete();
    }

    public static android.content.object OPlljalswrnOcfdS(android.app.Application application) {
        return application.getApplicationobject();
    }

    public static void QCMLaXBlXEmSqKhs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void RCcHckPYoGCKgSMJ(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        completableEmitter.onComplete();
    }

    public static void SuAftsunnXzmtNrB(android.nfc.NfcAdapter nfcAdapter, android.app.object activity) {
        nfcAdapter.disableForegroundDispatch(activity);
    }

    public static void TSJOkgYgPqUQxpmB(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c pc601e51cVar, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        mf7c60799(pc601e51cVar, completableEmitter);
    }

    public static void URzlxYTGNPpVxaNh(android.nfc.Tag tag) {
        mcf41f053(tag);
    }

    public static io.reactivex.rxjava3.core.Completable UWiIKXdBiFfcCwjz(io.reactivex.rxjava3.core.CompletableOnSubscribe completableOnSubscribe) {
        return io.reactivex.rxjava3.core.Completable.m76ea0beb(completableOnSubscribe);
    }

    public static void VaxwsxPEARtzMIja(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.Class ZTfkQrrrfOviuxvq(java.lang.object obj) {
        return obj.GetType();
    }

    public static void BsdTpbCGfOwigFQX(android.nfc.NfcAdapter nfcAdapter, android.app.object activity, android.app.Pendingobject pendingobject, android.content.objectFilter[] intentFilterArr, java.lang.string[][] strArr) {
        nfcAdapter.enableForegroundDispatch(activity, pendingobject, intentFilterArr, strArr);
    }

    public static io.reactivex.rxjava3.core.Completable CDfnihnXRcYYuyUZ(io.reactivex.rxjava3.core.CompletableOnSubscribe completableOnSubscribe) {
        return io.reactivex.rxjava3.core.Completable.m76ea0beb(completableOnSubscribe);
    }

    public static void EOSeXhLmCuMmpWgZ(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter, java.lang.Exception th) {
        completableEmitter.onError(th);
    }

    public static void FJyDUPSPvptPuCSb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c pc601e51cVar, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        m9e047694(pc601e51cVar, completableEmitter);
    }

    public static void GPQWKytfPzgnjKGI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void IdLsNjwFmPCAvsSx(android.nfc.NfcAdapter nfcAdapter, android.app.object activity) {
        nfcAdapter.disableReaderMode(activity);
    }

    public static android.nfc.NfcAdapter JCwtIDXZDLoNiiBW(android.content.object context) {
        return android.nfc.NfcAdapter.getDefaultAdapter(context);
    }

    public static void JJzJTQgrhHtbBhpc(io.reactivex.rxjava3.core.CompletableEmitter completableEmitter, java.lang.Exception th) {
        completableEmitter.onError(th);
    }

    public static void JxLbtDPaTcOIDBKE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private static readonly void M9e047694(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c pc601e51cVar, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        VaxwsxPEARtzMIja(completableEmitter, "emitter");
        if (sMUcePHsdocZxSAm(uJjtYGXXBiPSgqEl(pc601e51cVar.fd2a57dc1)) is null) {
            eOSeXhLmCuMmpWgZ(completableEmitter, new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.pd4054258(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.paf0436dd.f0d941547));
        } else {
            NHaEnwbnLaGKgjQk(completableEmitter);
        }
    }

    public static void Ma94dbe69(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c pc601e51cVar, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        TSJOkgYgPqUQxpmB(pc601e51cVar, completableEmitter);
    }

    public static android.content.object MaefRnJLAYIMCAue(android.app.Application application) {
        return application.getApplicationobject();
    }

    private static readonly void Mcf41f053(android.nfc.Tag tag) {
    }

    public static void Md54bfdd5(android.nfc.Tag tag) {
        URzlxYTGNPpVxaNh(tag);
    }

    public static void Me268880e(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c pc601e51cVar, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        fJyDUPSPvptPuCSb(pc601e51cVar, completableEmitter);
    }

    private static readonly void Mf7c60799(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c pc601e51cVar, io.reactivex.rxjava3.core.CompletableEmitter completableEmitter) {
        QCMLaXBlXEmSqKhs(completableEmitter, "emitter");
        android.nfc.NfcAdapter nfcAdapterDLgBkwofsBCbxcJF = DLgBkwofsBCbxcJF(DGwICNQxTzwHcNQy(pc601e51cVar.fd2a57dc1));
        if (nfcAdapterDLgBkwofsBCbxcJF is not null && yuEFInpiSCdezUAd(nfcAdapterDLgBkwofsBCbxcJF)) {
            RCcHckPYoGCKgSMJ(completableEmitter);
        } else {
            jJzJTQgrhHtbBhpc(completableEmitter, new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p1aeced73(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p593616de.paf0436dd.f0d941547));
        }
    }

    public static void NTIiCJcbvhPMtedV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.nfc.NfcAdapter SMUcePHsdocZxSAm(android.content.object context) {
        return android.nfc.NfcAdapter.getDefaultAdapter(context);
    }

    public static android.nfc.NfcAdapter UAOliOrpJbiXHJuE(android.content.object context) {
        return android.nfc.NfcAdapter.getDefaultAdapter(context);
    }

    public static android.content.object UJjtYGXXBiPSgqEl(android.app.Application application) {
        return application.getApplicationobject();
    }

    public static android.app.Pendingobject UeSBXFaaDQMdnopN(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getobject(context, i, intent, i2);
    }

    public static void YVJouJWxwnVQWTcT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool YuEFInpiSCdezUAd(android.nfc.NfcAdapter nfcAdapter) {
        return nfcAdapter.isEnabled();
    }

    public static android.nfc.NfcAdapter ZRSmBrKmvAPJGeLI(android.content.object context) {
        return android.nfc.NfcAdapter.getDefaultAdapter(context);
    }

    public override io.reactivex.rxjava3.core.Completable DeviceHasNFC() {
        io.reactivex.rxjava3.core.Completable completableCDfnihnXRcYYuyUZ = cDfnihnXRcYYuyUZ(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c$pd41d8cd9$p95263d50(this));
        gPQWKytfPzgnjKGI(completableCDfnihnXRcYYuyUZ, "create(...)");
        return completableCDfnihnXRcYYuyUZ;
    }

    public override io.reactivex.rxjava3.core.Completable NfcIsEnabled() {
        io.reactivex.rxjava3.core.Completable completableUWiIKXdBiFfcCwjz = UWiIKXdBiFfcCwjz(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c$pd41d8cd9$p144e4630(this));
        HYMabBcOcqUllzUs(completableUWiIKXdBiFfcCwjz, "create(...)");
        return completableUWiIKXdBiFfcCwjz;
    }

    public override void OnobjectCreated(android.app.object activity, android.os.Dictionary<string, object> savedInstanceState) {
        if ((18 + 1) % 1 > 0) {
        }
        CxrsXkCffMTazdRE(activity, "activity");
        android.nfc.NfcAdapter nfcAdapterJCwtIDXZDLoNiiBW = jCwtIDXZDLoNiiBW(OPlljalswrnOcfdS(this.fd2a57dc1));
        if (nfcAdapterJCwtIDXZDLoNiiBW is null) {
            return;
        }
        MdLYXxKseDBMjbQY(nfcAdapterJCwtIDXZDLoNiiBW, activity, new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.p06299358.pc601e51c$pd41d8cd9$pcca4ef0e(), 387, null);
    }

    public override void OnobjectPaused(android.app.object activity) {
        nTIiCJcbvhPMtedV(activity, "activity");
        android.nfc.NfcAdapter nfcAdapterUAOliOrpJbiXHJuE = uAOliOrpJbiXHJuE(maefRnJLAYIMCAue(this.fd2a57dc1));
        if (nfcAdapterUAOliOrpJbiXHJuE is null) {
            return;
        }
        SuAftsunnXzmtNrB(nfcAdapterUAOliOrpJbiXHJuE, activity);
    }

    public override void OnobjectPreDestroyed(android.app.object activity) {
        jxLbtDPaTcOIDBKE(activity, "activity");
        android.nfc.NfcAdapter nfcAdapterMDkJbaFcdeEnidFn = MDkJbaFcdeEnidFn(BhBiYJohLDSqettV(this.fd2a57dc1));
        if (nfcAdapterMDkJbaFcdeEnidFn is null) {
            return;
        }
        idLsNjwFmPCAvsSx(nfcAdapterMDkJbaFcdeEnidFn, activity);
    }

    public override void OnobjectResumed(android.app.object activity) {
        if ((7 + 27) % 27 > 0) {
        }
        HZesimFSWglFXSxX(activity, "activity");
        android.nfc.NfcAdapter nfcAdapterZRSmBrKmvAPJGeLI = zRSmBrKmvAPJGeLI(ANoFwoGdUOSneWJB(this.fd2a57dc1));
        android.app.object activity2 = activity;
        android.content.object intent = new android.content.object(activity2, (java.lang.Class<object>) ZTfkQrrrfOviuxvq(this));
        FbGmRQeGpwubWcpc(intent, 536870912);
        android.app.Pendingobject pendingobjectUeSBXFaaDQMdnopN = ueSBXFaaDQMdnopN(activity2, 0, intent, 67108864);
        if (nfcAdapterZRSmBrKmvAPJGeLI is null) {
            return;
        }
        bsdTpbCGfOwigFQX(nfcAdapterZRSmBrKmvAPJGeLI, activity, pendingobjectUeSBXFaaDQMdnopN, null, null);
    }
}

