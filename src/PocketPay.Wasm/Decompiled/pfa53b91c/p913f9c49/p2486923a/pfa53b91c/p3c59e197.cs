namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0002J\b\u0010\u001a\u001a\u00020\u0011H\u0002J\b\u0010\u001b\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001c"}, d2 = {"Lpfa53b91c/p913f9c49/p2486923a/pfa53b91c/p3c59e197;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pfa53b91c/p913f9c49/p86ccec3d/pec341acd/p9cbef37e;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pfa53b91c/p913f9c49/p86ccec3d/pec341acd/p9cbef37e;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "authDeviceobjectModel", "Lpfa53b91c/p913f9c49/p2486923a/pfa53b91c/pac7b19c6;", "getAuthDeviceobjectModel", "()Lpfa53b91c/p913f9c49/p2486923a/pfa53b91c/pac7b19c6;", "authDeviceobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "observeAuthDeviceStatus", "observeSaveSelectedCashierIdStatus", "showAuthErrorDeviceDialog", "showError", "showLoading", "onBackPressed", "feature-auth-device-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3c59e197 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly kotlin.Lazy authDeviceobjectModel;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    static {
        if ((12 + 26) % 26 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = NUklvmelYScAxEBM(new kotlin.jvm.internal.PropertyReference1Impl(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197.class, xyPtfpmWDTzXnFiA("d9cfd98a1c362a6b11738c2aa36460e0d8f1df56eb81c33dfc3ec0c6ec1e77738d8dc0"), NUcYUBabMwxLNHxc("47f377be9e9dbe8a2bc02f60c0b7ad3e5662ddda153aa4905e26c1f1ed10db18f795dcd381ecf51780f562d5c08077908b9725e75ad981ee0eca51ed2216ac22e8636363183dd1baf4c46196d3a1ad00cab6f474eddbf5eafcbfb6c4488d90400a7131be007eee1833bdf440a3aec5640b0c4f572f548cf36444cd3e39a2a104bad3812257"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p3c59e197() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.R$layout.fragment_auth_device);
        if ((21 + 3) % 3 > 0) {
        }
        pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var = this;
        this.binding = AdSnpiFTELCqtjkD(p3c59e197Var, pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$p001a249d$2.f76425f17);
        this.authDeviceobjectModel = ZjybibNmiYZoHiPy(kotlin.LazyThreadSafetyMode.NONE, new pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p3c59e197Var, null, new pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p3c59e197Var), null, null));
    }

    public static p2b3583e6.p7f662005.p001a249d.peaca9a1b AdSnpiFTELCqtjkD(androidx.fragment.app.object fragment, kotlin.jvm.functions.Function1 function1) {
        return p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(fragment, function1);
    }

    public static void AdSnpiFTELCqtjkD(androidx.fragment.app.object fragment, kotlin.jvm.functions.Function1 function1, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AdSnpiFTELCqtjkD(androidx.fragment.app.object fragment, kotlin.jvm.functions.Function1 function1, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AdSnpiFTELCqtjkD(androidx.fragment.app.object fragment, kotlin.jvm.functions.Function1 function1, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.fragment.app.objectManager BwjMkvzQhwtXsXfG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.getChildobjectManager();
    }

    public static void BwjMkvzQhwtXsXfG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BwjMkvzQhwtXsXfG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BwjMkvzQhwtXsXfG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 CiNMsujziHgGTxiR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void CiNMsujziHgGTxiR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CiNMsujziHgGTxiR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CiNMsujziHgGTxiR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DSdStrVPtitXGToD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DSdStrVPtitXGToD(java.lang.object obj, java.lang.string str, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DSdStrVPtitXGToD(java.lang.object obj, java.lang.string str, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DSdStrVPtitXGToD(java.lang.object obj, java.lang.string str, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DaedUneDquBRPtrD(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        pac7b19c6Var.authDevice();
    }

    public static void DaedUneDquBRPtrD(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DaedUneDquBRPtrD(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DaedUneDquBRPtrD(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 HpZCXsjocKYaXRAI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void HpZCXsjocKYaXRAI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HpZCXsjocKYaXRAI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HpZCXsjocKYaXRAI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HsiMxtumhIcoIcdm(p593616de.p9efab239.p0742d3f9 p0742d3f9Var, android.view.object view, android.os.Dictionary<string, object> bundle) {
        super.onobjectCreated(view, bundle);
    }

    public static void HsiMxtumhIcoIcdm(p593616de.p9efab239.p0742d3f9 p0742d3f9Var, android.view.object view, android.os.Dictionary<string, object> bundle, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HsiMxtumhIcoIcdm(p593616de.p9efab239.p0742d3f9 p0742d3f9Var, android.view.object view, android.os.Dictionary<string, object> bundle, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HsiMxtumhIcoIcdm(p593616de.p9efab239.p0742d3f9 p0742d3f9Var, android.view.object view, android.os.Dictionary<string, object> bundle, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImRzeHCmqwDiefPE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        p3c59e197Var.md6240053();
    }

    public static void ImRzeHCmqwDiefPE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImRzeHCmqwDiefPE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImRzeHCmqwDiefPE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JJaFHvCjkhGXycXG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void JJaFHvCjkhGXycXG(java.lang.object obj, java.lang.string str, float f, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JJaFHvCjkhGXycXG(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JJaFHvCjkhGXycXG(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KwoRlmefuXpqOAwN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        pac7b19c6Var.openPreviousScreen();
    }

    public static void KwoRlmefuXpqOAwN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KwoRlmefuXpqOAwN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KwoRlmefuXpqOAwN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LtVhEfQxcpIqNtlU(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        p3c59e197Var.mfacf56db();
    }

    public static void LtVhEfQxcpIqNtlU(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LtVhEfQxcpIqNtlU(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LtVhEfQxcpIqNtlU(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MksgzfkqbKCdkdSR(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void MksgzfkqbKCdkdSR(java.lang.string str, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MksgzfkqbKCdkdSR(java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MksgzfkqbKCdkdSR(java.lang.string str, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NUcYUBabMwxLNHxc(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void NUcYUBabMwxLNHxc(java.lang.string str, byte b, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NUcYUBabMwxLNHxc(java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NUcYUBabMwxLNHxc(java.lang.string str, float f, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.reflect.KProperty1 NUklvmelYScAxEBM(kotlin.jvm.internal.PropertyReference1 propertyReference1) {
        return kotlin.jvm.internal.Reflection.property1(propertyReference1);
    }

    public static void NUklvmelYScAxEBM(kotlin.jvm.internal.PropertyReference1 propertyReference1, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NUklvmelYScAxEBM(kotlin.jvm.internal.PropertyReference1 propertyReference1, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NUklvmelYScAxEBM(kotlin.jvm.internal.PropertyReference1 propertyReference1, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NknmYSlBybYqNvyL(kotlin.Lazy lazy) {
        return lazy.getValue();
    }

    public static void NknmYSlBybYqNvyL(kotlin.Lazy lazy, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NknmYSlBybYqNvyL(kotlin.Lazy lazy, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NknmYSlBybYqNvyL(kotlin.Lazy lazy, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NthYzMykQyOuLnll(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        pac7b19c6Var.saveSelectedCashierId();
    }

    public static void NthYzMykQyOuLnll(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NthYzMykQyOuLnll(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NthYzMykQyOuLnll(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e OcKjWpPGnwMXOYOL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mbcff50b6();
    }

    public static void OcKjWpPGnwMXOYOL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OcKjWpPGnwMXOYOL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OcKjWpPGnwMXOYOL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OsBTBUHDsbieFpWG(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void OsBTBUHDsbieFpWG(android.view.object view, int i, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OsBTBUHDsbieFpWG(android.view.object view, int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OsBTBUHDsbieFpWG(android.view.object view, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.lifecycle.LiveData PXoWRPMwFomDxqwt(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        return pac7b19c6Var.getAuthDeviceStatus();
    }

    public static void PXoWRPMwFomDxqwt(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PXoWRPMwFomDxqwt(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PXoWRPMwFomDxqwt(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PeYQClprMGrgFjqN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i) {
        return p3c59e197Var.getstring(i);
    }

    public static void PeYQClprMGrgFjqN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PeYQClprMGrgFjqN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PeYQClprMGrgFjqN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 PjzgviWdFtprdcOi(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void PjzgviWdFtprdcOi(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PjzgviWdFtprdcOi(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PjzgviWdFtprdcOi(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QdclNNTALgTToFsm(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void QdclNNTALgTToFsm(java.lang.string str, char c, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QdclNNTALgTToFsm(java.lang.string str, float f, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QdclNNTALgTToFsm(java.lang.string str, java.lang.string str2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e RcAiRKTHNxfLpyYK(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mbcff50b6();
    }

    public static void RcAiRKTHNxfLpyYK(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RcAiRKTHNxfLpyYK(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RcAiRKTHNxfLpyYK(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SDziSVztpUACFted(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void SDziSVztpUACFted(java.lang.object obj, java.lang.string str, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SDziSVztpUACFted(java.lang.object obj, java.lang.string str, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SDziSVztpUACFted(java.lang.object obj, java.lang.string str, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e TJwOsBGcZiJdmreg(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mbcff50b6();
    }

    public static void TJwOsBGcZiJdmreg(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TJwOsBGcZiJdmreg(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TJwOsBGcZiJdmreg(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 UrZPkWvuEaTMCGhN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void UrZPkWvuEaTMCGhN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UrZPkWvuEaTMCGhN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrZPkWvuEaTMCGhN(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UyUIAwMbWjwvqcxd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        p3c59e197Var.mad2d4a3f();
    }

    public static void UyUIAwMbWjwvqcxd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UyUIAwMbWjwvqcxd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UyUIAwMbWjwvqcxd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VDumMZUgtjQfhQZk(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void VDumMZUgtjQfhQZk(android.view.object view, int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VDumMZUgtjQfhQZk(android.view.object view, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VDumMZUgtjQfhQZk(android.view.object view, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VLKGTsbcekBykuuD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void VLKGTsbcekBykuuD(java.lang.object obj, java.lang.string str, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLKGTsbcekBykuuD(java.lang.object obj, java.lang.string str, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLKGTsbcekBykuuD(java.lang.object obj, java.lang.string str, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VZtTfKeyeLJFlVON(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        p3c59e197Var.m70daf3a9();
    }

    public static void VZtTfKeyeLJFlVON(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZtTfKeyeLJFlVON(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VZtTfKeyeLJFlVON(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ViOTjKskkFlqKRPi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void ViOTjKskkFlqKRPi(java.lang.object obj, java.lang.string str, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ViOTjKskkFlqKRPi(java.lang.object obj, java.lang.string str, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ViOTjKskkFlqKRPi(java.lang.object obj, java.lang.string str, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VuJjjlJbasJyzvCK(p59a14a57.p4a527f83.p5e9061ea p5e9061eaVar, java.lang.string str) {
        p5e9061eaVar.setMessage(str);
    }

    public static void VuJjjlJbasJyzvCK(p59a14a57.p4a527f83.p5e9061ea p5e9061eaVar, java.lang.string str, java.lang.string str2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VuJjjlJbasJyzvCK(p59a14a57.p4a527f83.p5e9061ea p5e9061eaVar, java.lang.string str, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VuJjjlJbasJyzvCK(p59a14a57.p4a527f83.p5e9061ea p5e9061eaVar, java.lang.string str, bool z, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.fragment.app.objectManager WaJFGiZtZNMfates(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.getChildobjectManager();
    }

    public static void WaJFGiZtZNMfates(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WaJFGiZtZNMfates(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WaJFGiZtZNMfates(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YHOvpFDwuBWCuqID(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        p593616de.p9efab239.pfafca1ef.mf5d59114(fragment, fragmentManager, str, function1);
    }

    public static void YHOvpFDwuBWCuqID(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YHOvpFDwuBWCuqID(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YHOvpFDwuBWCuqID(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Lazy ZjybibNmiYZoHiPy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0) {
        return kotlin.LazyKt.lazy(lazyThreadSafetyMode, function0);
    }

    public static void ZjybibNmiYZoHiPy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZjybibNmiYZoHiPy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjybibNmiYZoHiPy(kotlin.LazyThreadSafetyMode lazyThreadSafetyMode, kotlin.jvm.functions.Function0 function0, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit AAKAjRESJodLlTQj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle) {
        return ma55003ab(p3c59e197Var, bundle);
    }

    public static void AAKAjRESJodLlTQj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AAKAjRESJodLlTQj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AAKAjRESJodLlTQj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AYvXyBPuFkVnHIqL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var) {
        return p78205877Var.getTag();
    }

    public static void AYvXyBPuFkVnHIqL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AYvXyBPuFkVnHIqL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AYvXyBPuFkVnHIqL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AihFxgRjPRkibxES(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void AihFxgRjPRkibxES(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AihFxgRjPRkibxES(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AihFxgRjPRkibxES(java.lang.object obj, java.lang.string str, int i, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BxovtWHLzQhtyfna(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        p593616de.p9efab239.pfafca1ef.mf5d59114(fragment, fragmentManager, str, function1);
    }

    public static void BxovtWHLzQhtyfna(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1, float f, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BxovtWHLzQhtyfna(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1, float f, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BxovtWHLzQhtyfna(androidx.fragment.app.object fragment, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, kotlin.jvm.functions.Function1 function1, java.lang.string str2, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int CEPeOEnptyKLvpdH(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var) {
        return pec53a8c4Var.ordinal();
    }

    public static void CEPeOEnptyKLvpdH(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CEPeOEnptyKLvpdH(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CEPeOEnptyKLvpdH(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CGpRSBCRBfzNAJQr(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var, androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        p78205877Var.show(fragmentManager, str);
    }

    public static void CGpRSBCRBfzNAJQr(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, java.lang.string str2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CGpRSBCRBfzNAJQr(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, short s, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CGpRSBCRBfzNAJQr(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877Var, androidx.fragment.app.objectManager fragmentManager, java.lang.string str, bool z, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 CUzBuBlVYbdmHXaH(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void CUzBuBlVYbdmHXaH(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CUzBuBlVYbdmHXaH(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CUzBuBlVYbdmHXaH(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 CpaSqSnHqgVPvhjj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void CpaSqSnHqgVPvhjj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CpaSqSnHqgVPvhjj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpaSqSnHqgVPvhjj(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static pad5f82e8.p07214c67.pec53a8c4 CtEgokBHxZEkfHPY(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return pa4ecfc70Var.getStatus();
    }

    public static void CtEgokBHxZEkfHPY(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CtEgokBHxZEkfHPY(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CtEgokBHxZEkfHPY(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DKoJiZyzhPEprzqJ(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void DKoJiZyzhPEprzqJ(android.view.object view, int i, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DKoJiZyzhPEprzqJ(android.view.object view, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DKoJiZyzhPEprzqJ(android.view.object view, int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DviOfjaUxTbWhxqc(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1) {
        p593616de.p9efab239.pfafca1ef.m1b65e84b(fragment, liveData, function1);
    }

    public static void DviOfjaUxTbWhxqc(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DviOfjaUxTbWhxqc(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DviOfjaUxTbWhxqc(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e EyjzJTjuIrofXsGG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mbcff50b6();
    }

    public static void EyjzJTjuIrofXsGG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EyjzJTjuIrofXsGG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EyjzJTjuIrofXsGG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int FvoSEIRYfMVpZofT(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var) {
        return pec53a8c4Var.ordinal();
    }

    public static void FvoSEIRYfMVpZofT(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvoSEIRYfMVpZofT(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvoSEIRYfMVpZofT(pad5f82e8.p07214c67.pec53a8c4 pec53a8c4Var, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 GeYQjePZWKqhMwek(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877$p910eef8c p78205877_p910eef8c) {
        return p78205877_p910eef8c.newInstance();
    }

    public static void GeYQjePZWKqhMwek(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877$p910eef8c p78205877_p910eef8c, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GeYQjePZWKqhMwek(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877$p910eef8c p78205877_p910eef8c, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GeYQjePZWKqhMwek(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877$p910eef8c p78205877_p910eef8c, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GeltDVnyrtWPAelI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GeltDVnyrtWPAelI(java.lang.object obj, java.lang.string str, int i, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GeltDVnyrtWPAelI(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GeltDVnyrtWPAelI(java.lang.object obj, java.lang.string str, bool z, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GgUPLeWmKiBfnpkL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        pac7b19c6Var.startSplashFlow();
    }

    public static void GgUPLeWmKiBfnpkL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GgUPLeWmKiBfnpkL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GgUPLeWmKiBfnpkL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GhSqYbncteFlxDQE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i) {
        return p3c59e197Var.getstring(i);
    }

    public static void GhSqYbncteFlxDQE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GhSqYbncteFlxDQE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GhSqYbncteFlxDQE(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GkrrbmaSbphztWYt(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1) {
        p593616de.p9efab239.pfafca1ef.m1b65e84b(fragment, liveData, function1);
    }

    public static void GkrrbmaSbphztWYt(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkrrbmaSbphztWYt(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkrrbmaSbphztWYt(androidx.fragment.app.object fragment, androidx.lifecycle.LiveData liveData, kotlin.jvm.functions.Function1 function1, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.viewbinding.objectBinding GvklfIZvrKoSOhKE(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar, androidx.fragment.app.object fragment, kotlin.reflect.KProperty kProperty) {
        return peaca9a1bVar.getValue2(fragment, (kotlin.reflect.KProperty<object>) kProperty);
    }

    public static void GvklfIZvrKoSOhKE(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar, androidx.fragment.app.object fragment, kotlin.reflect.KProperty kProperty, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GvklfIZvrKoSOhKE(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar, androidx.fragment.app.object fragment, kotlin.reflect.KProperty kProperty, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GvklfIZvrKoSOhKE(p2b3583e6.p7f662005.p001a249d.peaca9a1b peaca9a1bVar, androidx.fragment.app.object fragment, kotlin.reflect.KProperty kProperty, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HIkzHIVrXDJHVNqo(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void HIkzHIVrXDJHVNqo(android.view.object view, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HIkzHIVrXDJHVNqo(android.view.object view, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HIkzHIVrXDJHVNqo(android.view.object view, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e HQsAIMpiNIZwFPei(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mbcff50b6();
    }

    public static void HQsAIMpiNIZwFPei(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HQsAIMpiNIZwFPei(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HQsAIMpiNIZwFPei(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HlhdsULlurjUOOeL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HlhdsULlurjUOOeL(java.lang.object obj, java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlhdsULlurjUOOeL(java.lang.object obj, java.lang.string str, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HlhdsULlurjUOOeL(java.lang.object obj, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 HnyzuQaHKIlwzjdJ(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void HnyzuQaHKIlwzjdJ(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HnyzuQaHKIlwzjdJ(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HnyzuQaHKIlwzjdJ(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IwiOzaJyXrWBLpgR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void IwiOzaJyXrWBLpgR(java.lang.object obj, java.lang.string str, float f, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IwiOzaJyXrWBLpgR(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IwiOzaJyXrWBLpgR(java.lang.object obj, java.lang.string str, bool z, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JBotQtXkOukYxsSR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JBotQtXkOukYxsSR(java.lang.object obj, java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBotQtXkOukYxsSR(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBotQtXkOukYxsSR(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KVJagMkjsgbeZaKR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        pac7b19c6Var.authDevice();
    }

    public static void KVJagMkjsgbeZaKR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KVJagMkjsgbeZaKR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KVJagMkjsgbeZaKR(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.fragment.app.objectManager LicDBAZotxfBYhdx(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.getChildobjectManager();
    }

    public static void LicDBAZotxfBYhdx(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LicDBAZotxfBYhdx(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LicDBAZotxfBYhdx(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit M157cae72(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return pkBkpZLHSDyaKwwC(p3c59e197Var, pa4ecfc70Var);
    }

    public static void M157cae72(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void M157cae72(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void M157cae72(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void M269b36ee() {
        if ((30 + 24) % 24 > 0) {
        }
        p59a14a57.p4a527f83.p5e9061ea p5e9061eaVar = OcKjWpPGnwMXOYOL(this).f4a527f83;
        VLKGTsbcekBykuuD(p5e9061eaVar, "loader");
        VDumMZUgtjQfhQZk(p5e9061eaVar, 8);
        p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var = oBrnbCyHCsHqCBik(this).fcb5e100e;
        JJaFHvCjkhGXycXG(pcc3d7046Var, "error");
        pxFScHekMpHqgIqf(pcc3d7046Var, 0);
    }

    private readonly void M269b36ee(char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void M269b36ee(char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void M269b36ee(int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit M49ba48ae(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return ttWWCrBUfYNTDdFI(p3c59e197Var, pa4ecfc70Var);
    }

    public static void M49ba48ae(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void M49ba48ae(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void M49ba48ae(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static readonly kotlin.Unit M5972ca3a(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        hlhdsULlurjUOOeL(pa4ecfc70Var, "event");
        int i = pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$p12c674ac.$EnumSwitchDictionaryping$0[fvoSEIRYfMVpZofT(vlXRFrSCYxewRXrS(pa4ecfc70Var))];
        if (i == 1) {
            NthYzMykQyOuLnll(cUzBuBlVYbdmHXaH(p3c59e197Var));
        } else if (i == 2) {
            zfqzYWOKooAEznzP(p3c59e197Var);
            LtVhEfQxcpIqNtlU(p3c59e197Var);
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            VZtTfKeyeLJFlVON(p3c59e197Var);
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void M5972ca3a(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M5972ca3a(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M5972ca3a(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit M5ed77fc3(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle) {
        return aAKAjRESJodLlTQj(p3c59e197Var, bundle);
    }

    public static void M5ed77fc3(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void M5ed77fc3(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void M5ed77fc3(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void M70daf3a9() {
        if ((21 + 15) % 15 > 0) {
        }
        p59a14a57.p4a527f83.p5e9061ea p5e9061eaVar = xCAkGUVZcWMHgUsp(this).f4a527f83;
        iwiOzaJyXrWBLpgR(p5e9061eaVar, "loader");
        dKoJiZyzhPEprzqJ(p5e9061eaVar, 0);
        p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var = RcAiRKTHNxfLpyYK(this).fcb5e100e;
        aihFxgRjPRkibxES(pcc3d7046Var, "error");
        hIkzHIVrXDJHVNqo(pcc3d7046Var, 8);
    }

    private readonly void M70daf3a9(float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void M70daf3a9(int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void M70daf3a9(int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private static readonly kotlin.Unit M9ea60c05(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        jBotQtXkOukYxsSR(pa4ecfc70Var, "event");
        int i = pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$p12c674ac.$EnumSwitchDictionaryping$0[cEPeOEnptyKLvpdH(ctEgokBHxZEkfHPY(pa4ecfc70Var))];
        if (i == 1) {
            tIZaPIYPBcuUZIWw(CiNMsujziHgGTxiR(p3c59e197Var));
        } else if (i == 2) {
            ggUPLeWmKiBfnpkL(UrZPkWvuEaTMCGhN(p3c59e197Var));
        } else if (i != 3) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void M9ea60c05(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M9ea60c05(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static readonly void M9ea60c05(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static readonly kotlin.Unit Ma55003ab(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle) {
        DSdStrVPtitXGToD(bundle, "it");
        kVJagMkjsgbeZaKR(hnyzuQaHKIlwzjdJ(p3c59e197Var));
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void Ma55003ab(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static readonly void Ma55003ab(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static readonly void Ma55003ab(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mad2d4a3f() {
        if ((12 + 12) % 12 > 0) {
        }
        dviOfjaUxTbWhxqc(this, ybrZoIFuWaetGtUc(PjzgviWdFtprdcOi(this)), new pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$pd41d8cd9$pcca4ef0e(this));
    }

    private readonly void Mad2d4a3f(byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mad2d4a3f(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mad2d4a3f(int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static readonly kotlin.Unit Mb3dbcecd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle) {
        xwTFCPhOIWcUSKUN(bundle, "it");
        KwoRlmefuXpqOAwN(zrzMFsHnSlxVvXby(p3c59e197Var));
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void Mb3dbcecd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private static readonly void Mb3dbcecd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static readonly void Mb3dbcecd(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e Mbcff50b6() {
        if ((19 + 3) % 3 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e) gvklfIZvrKoSOhKE(this.binding, this, $$delegatedProperties[0]);
    }

    private readonly void Mbcff50b6(byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mbcff50b6(bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mbcff50b6(bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit Mbe560c8b(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle) {
        return oOnrJErfPSfWfmrM(p3c59e197Var, bundle);
    }

    public static void Mbe560c8b(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Mbe560c8b(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Mbe560c8b(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void Md6240053() {
        if ((32 + 18) % 18 > 0) {
        }
        gkrrbmaSbphztWYt(this, PXoWRPMwFomDxqwt(HpZCXsjocKYaXRAI(this)), new pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$pd41d8cd9$p95263d50(this));
    }

    private readonly void Md6240053(java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void Md6240053(short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void Md6240053(short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 Mf202cdda() {
        return (pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6) NknmYSlBybYqNvyL(this.authDeviceobjectModel);
    }

    private readonly void Mf202cdda(byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mf202cdda(bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mf202cdda(bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mfacf56db() {
        if ((23 + 32) % 32 > 0) {
        }
        pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877 p78205877VarGeYQjePZWKqhMwek = geYQjePZWKqhMwek(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p91c7ec8d.p78205877.f910eef8c);
        cGpRSBCRBfzNAJQr(p78205877VarGeYQjePZWKqhMwek, WaJFGiZtZNMfates(this), aYvXyBPuFkVnHIqL(p78205877VarGeYQjePZWKqhMwek));
        pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var = this;
        androidx.fragment.app.objectManager fragmentManagerLicDBAZotxfBYhdx = licDBAZotxfBYhdx(this);
        SDziSVztpUACFted(fragmentManagerLicDBAZotxfBYhdx, "getChildobjectManager(...)");
        bxovtWHLzQhtyfna(p3c59e197Var, fragmentManagerLicDBAZotxfBYhdx, QdclNNTALgTToFsm("d604061fcba1b17ff28234f06b5f022ce6b7455a6c208bf0dd4ee6978eb5f31ca60a10450201fdf17e02eef5"), new pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$pd41d8cd9$p144e4630(this));
        androidx.fragment.app.objectManager fragmentManagerBwjMkvzQhwtXsXfG = BwjMkvzQhwtXsXfG(this);
        svAXraPldjZBReQq(fragmentManagerBwjMkvzQhwtXsXfG, "getChildobjectManager(...)");
        YHOvpFDwuBWCuqID(p3c59e197Var, fragmentManagerBwjMkvzQhwtXsXfG, MksgzfkqbKCdkdSR("ca75890876f3891b437155e26f0047bd1a90266e8ffa10352b7555dc548eb995405df2e4b4dbeab353a3c69521"), new pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197$pd41d8cd9$p437e9676(this));
    }

    private readonly void Mfacf56db(char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mfacf56db(char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void Mfacf56db(short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NQrbShHRBSuCLuAE(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void NQrbShHRBSuCLuAE(java.lang.string str, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQrbShHRBSuCLuAE(java.lang.string str, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQrbShHRBSuCLuAE(java.lang.string str, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Button NpIReMjHQZfQwmIc(p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var) {
        return pcc3d7046Var.getErrorRepeatButton();
    }

    public static void NpIReMjHQZfQwmIc(p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NpIReMjHQZfQwmIc(p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NpIReMjHQZfQwmIc(p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e OBrnbCyHCsHqCBik(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mbcff50b6();
    }

    public static void OBrnbCyHCsHqCBik(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBrnbCyHCsHqCBik(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OBrnbCyHCsHqCBik(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit OOnrJErfPSfWfmrM(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle) {
        return mb3dbcecd(p3c59e197Var, bundle);
    }

    public static void OOnrJErfPSfWfmrM(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OOnrJErfPSfWfmrM(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OOnrJErfPSfWfmrM(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, android.os.Dictionary<string, object> bundle, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit PkBkpZLHSDyaKwwC(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m9ea60c05(p3c59e197Var, pa4ecfc70Var);
    }

    public static void PkBkpZLHSDyaKwwC(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PkBkpZLHSDyaKwwC(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PkBkpZLHSDyaKwwC(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PxFScHekMpHqgIqf(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void PxFScHekMpHqgIqf(android.view.object view, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PxFScHekMpHqgIqf(android.view.object view, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PxFScHekMpHqgIqf(android.view.object view, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 RJAjzePTWtNIeeeG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void RJAjzePTWtNIeeeG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RJAjzePTWtNIeeeG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RJAjzePTWtNIeeeG(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SJPBTJOmaJaHQuVa(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void SJPBTJOmaJaHQuVa(java.lang.string str, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SJPBTJOmaJaHQuVa(java.lang.string str, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJPBTJOmaJaHQuVa(java.lang.string str, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SvAXraPldjZBReQq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void SvAXraPldjZBReQq(java.lang.object obj, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SvAXraPldjZBReQq(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SvAXraPldjZBReQq(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TIZaPIYPBcuUZIWw(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        pac7b19c6Var.authTop();
    }

    public static void TIZaPIYPBcuUZIWw(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TIZaPIYPBcuUZIWw(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TIZaPIYPBcuUZIWw(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Unit TtWWCrBUfYNTDdFI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m5972ca3a(p3c59e197Var, pa4ecfc70Var);
    }

    public static void TtWWCrBUfYNTDdFI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TtWWCrBUfYNTDdFI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TtWWCrBUfYNTDdFI(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UxUqSHGOJFozLYHL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        pac7b19c6Var.openPreviousScreen();
    }

    public static void UxUqSHGOJFozLYHL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UxUqSHGOJFozLYHL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UxUqSHGOJFozLYHL(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static pad5f82e8.p07214c67.pec53a8c4 VlXRFrSCYxewRXrS(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return pa4ecfc70Var.getStatus();
    }

    public static void VlXRFrSCYxewRXrS(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VlXRFrSCYxewRXrS(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VlXRFrSCYxewRXrS(pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.pec341acd.p9cbef37e XCAkGUVZcWMHgUsp(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mbcff50b6();
    }

    public static void XCAkGUVZcWMHgUsp(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCAkGUVZcWMHgUsp(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XCAkGUVZcWMHgUsp(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XwTFCPhOIWcUSKUN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XwTFCPhOIWcUSKUN(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XwTFCPhOIWcUSKUN(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XwTFCPhOIWcUSKUN(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XyPtfpmWDTzXnFiA(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void XyPtfpmWDTzXnFiA(java.lang.string str, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XyPtfpmWDTzXnFiA(java.lang.string str, short s, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XyPtfpmWDTzXnFiA(java.lang.string str, short s, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static androidx.lifecycle.LiveData YbrZoIFuWaetGtUc(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var) {
        return pac7b19c6Var.getSaveSelectedCashierIdStatus();
    }

    public static void YbrZoIFuWaetGtUc(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YbrZoIFuWaetGtUc(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YbrZoIFuWaetGtUc(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 pac7b19c6Var, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZGFrhDmneyzpSnzb(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setTitle(charSequence);
    }

    public static void ZGFrhDmneyzpSnzb(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZGFrhDmneyzpSnzb(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZGFrhDmneyzpSnzb(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZfqzYWOKooAEznzP(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        p3c59e197Var.m269b36ee();
    }

    public static void ZfqzYWOKooAEznzP(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZfqzYWOKooAEznzP(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZfqzYWOKooAEznzP(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static pfa53b91c.p913f9c49.p2486923a.pfa53b91c.pac7b19c6 ZrzMFsHnSlxVvXby(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var) {
        return p3c59e197Var.mf202cdda();
    }

    public static void ZrzMFsHnSlxVvXby(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrzMFsHnSlxVvXby(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZrzMFsHnSlxVvXby(pfa53b91c.p913f9c49.p2486923a.pfa53b91c.p3c59e197 p3c59e197Var, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void OnBackPressed() {
        uxUqSHGOJFozLYHL(cpaSqSnHqgVPvhjj(this));
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        geltDVnyrtWPAelI(view, "view");
        HsiMxtumhIcoIcdm(this, view, savedInstanceState);
        zGFrhDmneyzpSnzb(TJwOsBGcZiJdmreg(this).ff50b3c2a, nQrbShHRBSuCLuAE(ghSqYbncteFlxDQE(this, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.R$string.app_name_preview)));
        p59a14a57.p4a527f83.p5e9061ea p5e9061eaVar = hQsAIMpiNIZwFPei(this).f4a527f83;
        java.lang.string strSJPBTJOmaJaHQuVa = sJPBTJOmaJaHQuVa(PeYQClprMGrgFjqN(this, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pfa53b91c.p913f9c49.p86ccec3d.R$string.auth_sync_with_device_loader));
        ViOTjKskkFlqKRPi(strSJPBTJOmaJaHQuVa, "getstring(...)");
        VuJjjlJbasJyzvCK(p5e9061eaVar, strSJPBTJOmaJaHQuVa);
        ImRzeHCmqwDiefPE(this);
        UyUIAwMbWjwvqcxd(this);
        DaedUneDquBRPtrD(rJAjzePTWtNIeeeG(this));
        OsBTBUHDsbieFpWG(npIReMjHQZfQwmIc(eyjzJTjuIrofXsGG(this).fcb5e100e), 8);
    }
}

