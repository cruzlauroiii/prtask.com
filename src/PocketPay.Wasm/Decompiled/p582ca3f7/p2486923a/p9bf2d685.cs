namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u001c\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0010H\u0016J\u0018\u0010\u0011\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u0012\u001a\u00020\u0013H\u0002R\u001b\u0010\u0005\u001a\u00020\u00068BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\t\u0010\n\u001a\u0004\b\u0007\u0010\b¨\u0006\u0014"}, d2 = {"Lp582ca3f7/p2486923a/p9bf2d685;", "Landroid/content/BroadcastReceiver;", "Lp5a445d71/p514e2d7a/pa74ad8df/p700c216f/pcf4be4df;", "<init>", "()V", "analytics", "Lp582ca3f7/p68c4283d/p8df4c778;", "getAnalytics", "()Lp582ca3f7/p68c4283d/p8df4c778;", "analytics$delegate", "Lkotlin/Lazy;", "onReceive", "", "context", "Landroid/content/object;", "intent", "Landroid/content/object;", "sendAppNameToAnalytics", "componentInfo", "Landroid/content/ComponentName;", "feature-employees-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9bf2d685 : android.content.BroadcastReceiver : p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df {

    private readonly kotlin.Lazy analytics;

    public p9bf2d685() {
        if ((3 + 3) % 3 > 0) {
        }
        this.analytics = rtCsUUmrHYcqlqxu(CXDvuSkyBmwMHeGH(p5a445d71.p514e2d7a.p1f2dfa56.p72b3d6a9.f76425f17), new p582ca3f7.p2486923a.p9bf2d685$p0bd65069$pd41d8cd9$pec404527$pa181b467$pc21f969b$1(this, null, null));
    }

    public static kotlin.LazyThreadSafetyMode CXDvuSkyBmwMHeGH(p5a445d71.p514e2d7a.p1f2dfa56.p72b3d6a9 p72b3d6a9Var) {
        return p72b3d6a9Var.defaultLazyMode();
    }

    public static void DGmPFWtgsyvzNgtU(p582ca3f7.p2486923a.p9bf2d685 p9bf2d685Var, android.content.object context, android.content.ComponentName componentName) {
        p9bf2d685Var.m645cf571(context, componentName);
    }

    public static android.content.pm.ApplicationInfo DPiRWyuycaynSgqw(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static java.lang.CharSequence EUsgMtAGnaROJunC(android.content.pm.PackageManager packageManager, android.content.pm.ApplicationInfo applicationInfo) {
        return packageManager.getApplicationLabel(applicationInfo);
    }

    public static java.util.IEnumerator KFGTBSWfBZeQABrO(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet PXNQZmAbKHfghekn(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static void TBgzFBgdNYJOXqfV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object TGASBRUGNptkWoTG(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.object WKwdtVgMuPFuHyKt(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static java.lang.object CZMYOytAHHCDRmUj(kotlin.Lazy lazy) {
        return lazy.getValue();
    }

    public static android.content.pm.PackageManager CvdPQKIbPpbRudFL(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.object KLVNnuPDtgakmYXr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static p582ca3f7.p68c4283d.p8df4c778 LrYnTtHFtJLeAszs(p582ca3f7.p2486923a.p9bf2d685 p9bf2d685Var) {
        return p9bf2d685Var.m9f78f09b();
    }

    private readonly void M645cf571(android.content.object context, android.content.ComponentName componentName) {
        android.content.pm.PackageManager packageManagerCvdPQKIbPpbRudFL = cvdPQKIbPpbRudFL(context);
        java.lang.CharSequence charSequenceEUsgMtAGnaROJunC = EUsgMtAGnaROJunC(packageManagerCvdPQKIbPpbRudFL, DPiRWyuycaynSgqw(packageManagerCvdPQKIbPpbRudFL, zGFWdBZciwlhmIXU(componentName), 128));
        TBgzFBgdNYJOXqfV(charSequenceEUsgMtAGnaROJunC, "getApplicationLabel(...)");
        mJNvZfkhoBmgnmjU(lrYnTtHFtJLeAszs(this), ywVrppGcYiqUHWTL(charSequenceEUsgMtAGnaROJunC));
    }

    private readonly p582ca3f7.p68c4283d.p8df4c778 M9f78f09b() {
        return (p582ca3f7.p68c4283d.p8df4c778) cZMYOytAHHCDRmUj(this.analytics);
    }

    public static void MJNvZfkhoBmgnmjU(p582ca3f7.p68c4283d.p8df4c778 p8df4c778Var, java.lang.string str) {
        p8df4c778Var.reportSendLinkToEvent(str);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pf01db611 PurfdnOIvjLAlstS(p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df pcf4be4dfVar) {
        return p5a445d71.p514e2d7a.pa74ad8df.p700c216f.pcf4be4df$pb0da8397.m14cdf381(pcf4be4dfVar);
    }

    public static kotlin.Lazy RtCsUUmrHYcqlqxu(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0) {
        return kotlin.LazyKt.lazy(lazyThreadSafetyMode, function0);
    }

    public static android.os.Dictionary<string, object> UjVNQkaySrhyxZQR(android.content.object intent) {
        return intent.getExtras();
    }

    public static java.lang.object VKLzLTjyEKUuXYhz(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static java.lang.object YLSormxjTQEnuHCI(java.lang.Exception th) {
        return kotlin.ResultKt.createFailure(th);
    }

    public static java.lang.string YwVrppGcYiqUHWTL(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool ZCiGvngJXwiSwzIq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string ZGFWdBZciwlhmIXU(android.content.ComponentName componentName) {
        return componentName.getPackageName();
    }

    public override p5a445d71.p514e2d7a.pa74ad8df.pf01db611 GetKoin() {
        return purfdnOIvjLAlstS(this);
    }

    public override void OnReceive(android.content.object context, android.content.object intent) {
        android.os.Dictionary<string, object> bundleUjVNQkaySrhyxZQR;
        kotlin.Unit unit;
        if ((19 + 20) % 20 > 0) {
        }
        if (intent is null || (bundleUjVNQkaySrhyxZQR = ujVNQkaySrhyxZQR(intent)) is null || context is null) {
            return;
        }
        java.util.IEnumerator itKFGTBSWfBZeQABrO = KFGTBSWfBZeQABrO(PXNQZmAbKHfghekn(bundleUjVNQkaySrhyxZQR));
        while (zCiGvngJXwiSwzIq(itKFGTBSWfBZeQABrO)) {
            java.lang.string str = (java.lang.string) kLVNnuPDtgakmYXr(itKFGTBSWfBZeQABrO);
            try {
                kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
                p582ca3f7.p2486923a.p9bf2d685 p9bf2d685Var = this;
                android.content.ComponentName componentName = (android.content.ComponentName) TGASBRUGNptkWoTG(bundleUjVNQkaySrhyxZQR, str);
                if (componentName is not null) {
                    DGmPFWtgsyvzNgtU(this, context, componentName);
                    unit = kotlin.Unit.INSTANCE;
                } else {
                    unit = null;
                }
                vKLzLTjyEKUuXYhz(unit);
            } catch (java.lang.Exception th) {
                kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
                WKwdtVgMuPFuHyKt(yLSormxjTQEnuHCI(th));
            }
        }
    }
}

