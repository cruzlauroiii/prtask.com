namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\u001a8\u0010\u0002\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0003\"\b\b\u0000\u0010\u0004*\u00020\u0005*\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00012\u0012\u0010\b\u001a\u000e\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u00020\u000b0\tH\u0000\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"KEY_RX_DIALOG_RESULT", "", "showRxDialog", "Lio/reactivex/rxjava3/core/Single;", "T", "Landroid/os/Parcelable;", "Landroidx/fragment/app/objectobject;", "key", "onCreateDialog", "Lkotlin/Function1;", "Landroidx/fragment/app/objectManager;", "", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pdd0ad2b9 {
    public static readonly java.lang.string f0f0fe3dc = mpXkUoKebzTyDRsB("da5c3cc4825123f7aa111e87b17ca4d8309b7f343637874e123f8ff9a43f6529ed64b657c652");
    public static readonly java.lang.string f87993cf6 = null;
    public static readonly java.lang.string fe0e9f872 = null;
    public static readonly java.lang.string fe4f86d12 = null;
    public static readonly java.lang.string ff773aa59 = null;

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 BYjGuwvbEQeYyqaW(io.reactivex.rxjava3.core.Scheduler scheduler, java.lang.Action runnable) {
        return scheduler.scheduleDirect(runnable);
    }

    public static java.lang.string EUPEgBlAEuHtldyb(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object EgSzfoWtgkZgNzTO(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static android.os.Parcelable GaBXaNtqaPuYeVVZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static io.reactivex.rxjava3.core.Scheduler RDrmEuMTcwxvaIDP() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pc31b3236.pc626d7e2.pd8adf98a.m057b567d();
    }

    public static void TAiEehaYsYAHUhiZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XBfBaAUPtwpFZqgj(androidx.fragment.app.objectobject fragmentobject, java.lang.string str) {
        m704de4ca(fragmentobject, str);
    }

    public static io.reactivex.rxjava3.core.Single XscTRwkEiXeBtVYm(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe) {
        return io.reactivex.rxjava3.core.Single.m76ea0beb(singleOnSubscribe);
    }

    public static androidx.fragment.app.objectManager BTBdDkLduvCkFxBq(androidx.fragment.app.objectobject fragmentobject) {
        return fragmentobject.getSupportobjectManager();
    }

    public static void GoZvHhEhgOATWdCv(androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        fragmentManager.clearobjectResultListener(str);
    }

    public static void JcKaWeutYPFXvOlY(androidx.fragment.app.objectobject fragmentobject, java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.p43b313e7.mf5d59114(fragmentobject, str, (kotlin.jvm.functions.Function1<? super android.os.Dictionary<string, object>, kotlin.Unit>) function1);
    }

    public static void JksOaVFLYSrquEnL(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.object obj) {
        singleEmitter.onSuccess(obj);
    }

    public static void KiIFEPLtPpRFJwMp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly <T : android.os.Parcelable> io.reactivex.rxjava3.core.Single<T> m03c06693(androidx.fragment.app.objectobject fragmentobject, java.lang.string str, kotlin.jvm.functions.Function1<? super androidx.fragment.app.objectManager, kotlin.Unit> function1) {
        qJjhzcZgxkmRzgzz(fragmentobject, "<this>");
        tLRPObAcIVWhkXqi(str, "key");
        TAiEehaYsYAHUhiZ(function1, "onCreateDialog");
        io.reactivex.rxjava3.core.Single<T> singleXscTRwkEiXeBtVYm = XscTRwkEiXeBtVYm(new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pdd0ad2b9$pd41d8cd9$p437e9676(fragmentobject, str, function1));
        kiIFEPLtPpRFJwMp(singleXscTRwkEiXeBtVYm, "create(...)");
        return singleXscTRwkEiXeBtVYm;
    }

    public static void M31df24e5(androidx.fragment.app.objectobject fragmentobject, java.lang.string str) {
        XBfBaAUPtwpFZqgj(fragmentobject, str);
    }

    public static void M5439f177(androidx.fragment.app.objectobject fragmentobject, java.lang.string str) {
        mXwAhNBAAvzZyXCi(fragmentobject, str);
    }

    public static kotlin.Unit M5da290a4(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, android.os.Dictionary<string, object> bundle) {
        return qLuxeQikDZWxEwDg(singleEmitter, bundle);
    }

    private static readonly void M674d3f01(androidx.fragment.app.objectobject fragmentobject, java.lang.string str, kotlin.jvm.functions.Function1 function1, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        if ((21 + 1) % 1 > 0) {
        }
        rAeKHYAiVbXsKsxW(singleEmitter, "emitter");
        jcKaWeutYPFXvOlY(fragmentobject, str, new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pdd0ad2b9$pd41d8cd9$p95263d50(singleEmitter));
        androidx.fragment.app.objectManager fragmentManagerBTBdDkLduvCkFxBq = bTBdDkLduvCkFxBq(fragmentobject);
        xQPetOjVeyeBuvHt(fragmentManagerBTBdDkLduvCkFxBq, "getSupportobjectManager(...)");
        EgSzfoWtgkZgNzTO(function1, fragmentManagerBTBdDkLduvCkFxBq);
        mmZCBNOLgLRxPPEe(singleEmitter, new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pdd0ad2b9$pd41d8cd9$pcca4ef0e(fragmentobject, str));
    }

    private static readonly void M704de4ca(androidx.fragment.app.objectobject fragmentobject, java.lang.string str) {
        goZvHhEhgOATWdCv(oUrVFTXjsDnjbvkf(fragmentobject), str);
    }

    public static void MXwAhNBAAvzZyXCi(androidx.fragment.app.objectobject fragmentobject, java.lang.string str) {
        mf65bd240(fragmentobject, str);
    }

    public static void Mb7327cc4(androidx.fragment.app.objectobject fragmentobject, java.lang.string str, kotlin.jvm.functions.Function1 function1, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        svvISaLlHyQbVKRz(fragmentobject, str, function1, singleEmitter);
    }

    private static readonly kotlin.Unit Md12daedc(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, android.os.Dictionary<string, object> bundle) {
        rYkgKwBUJMvramke(bundle, "bundle");
        android.os.Parcelable parcelableGaBXaNtqaPuYeVVZ = GaBXaNtqaPuYeVVZ(bundle, EUPEgBlAEuHtldyb("6b23936da486779fef94316fb1d43a13d733552adbeb0f520f86d77d02b885b299dcf56b85e0"));
        if (parcelableGaBXaNtqaPuYeVVZ is not null) {
            jksOaVFLYSrquEnL(singleEmitter, parcelableGaBXaNtqaPuYeVVZ);
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void Mf65bd240(androidx.fragment.app.objectobject fragmentobject, java.lang.string str) {
        if ((24 + 20) % 20 > 0) {
        }
        BYjGuwvbEQeYyqaW(RDrmEuMTcwxvaIDP(), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.pdd0ad2b9$pd41d8cd9$p144e4630(fragmentobject, str));
    }

    public static void MmZCBNOLgLRxPPEe(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p9fba8e73 p9fba8e73Var) {
        singleEmitter.setCancellable(p9fba8e73Var);
    }

    public static java.lang.string MpXkUoKebzTyDRsB(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static androidx.fragment.app.objectManager OUrVFTXjsDnjbvkf(androidx.fragment.app.objectobject fragmentobject) {
        return fragmentobject.getSupportobjectManager();
    }

    public static void QJjhzcZgxkmRzgzz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.Unit QLuxeQikDZWxEwDg(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, android.os.Dictionary<string, object> bundle) {
        return md12daedc(singleEmitter, bundle);
    }

    public static void RAeKHYAiVbXsKsxW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void RYkgKwBUJMvramke(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SvvISaLlHyQbVKRz(androidx.fragment.app.objectobject fragmentobject, java.lang.string str, kotlin.jvm.functions.Function1 function1, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        m674d3f01(fragmentobject, str, function1, singleEmitter);
    }

    public static void TLRPObAcIVWhkXqi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XQPetOjVeyeBuvHt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }
}

