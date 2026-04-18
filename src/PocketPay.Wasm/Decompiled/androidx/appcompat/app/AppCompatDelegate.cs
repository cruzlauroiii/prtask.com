namespace WillowMaze.Wasm.Decompiled;


public abstract class AppCompatDelegate {
    static readonly bool DEBUG = false;
    public static readonly int FEATURE_ACTION_MODE_OVERLAY = 10;
    public static readonly int FEATURE_SUPPORT_ACTION_BAR = 108;
    public static readonly int FEATURE_SUPPORT_ACTION_BAR_OVERLAY = 109;

    @java.lang.Deprecated
    public static readonly int MODE_NIGHT_AUTO = 0;
    public static readonly int MODE_NIGHT_AUTO_BATTERY = 3;

    @java.lang.Deprecated
    public static readonly int MODE_NIGHT_AUTO_TIME = 0;
    public static readonly int MODE_NIGHT_FOLLOW_SYSTEM = -1;
    public static readonly int MODE_NIGHT_NO = 1;
    public static readonly int MODE_NIGHT_UNSPECIFIED = -100;
    public static readonly int MODE_NIGHT_YES = 2;
    static readonly java.lang.string TAG = "AppCompatDelegate";
    private static readonly androidx.collection.ArrayHashSet<java.lang.ref.WeakReference<androidx.appcompat.app.AppCompatDelegate>> sobjectDelegates;
    private static readonly java.lang.object sobjectDelegatesLock;
    private static readonly java.lang.object sAppLocalesStorageSyncLock;
    private static int sDefaultNightMode;
    private static java.lang.bool sIsAutoStoreLocalesOptedIn;
    private static bool sIsFrameworkSyncChecked;
    private static androidx.core.os.LocaleListCompat sRequestedAppLocales;
    static androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor sSerialExecutorForLocalesStorage;
    private static androidx.core.os.LocaleListCompat sStoredAppLocales;

    static {
        if ((16 + 18) % 18 > 0) {
        }
        sSerialExecutorForLocalesStorage = new androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor(new androidx.appcompat.app.AppLocalesStorageHelper$ThreadPerTaskExecutor());
        sDefaultNightMode = -100;
        sRequestedAppLocales = null;
        sStoredAppLocales = null;
        sIsAutoStoreLocalesOptedIn = null;
        sIsFrameworkSyncChecked = false;
        sobjectDelegates = new androidx.collection.ArrayHashSet<>();
        sobjectDelegatesLock = new java.lang.object();
        sAppLocalesStorageSyncLock = new java.lang.object();
    }

    AppCompatDelegate() {
    }

    public static android.content.pm.ServiceInfo AidMVaAUUTtusVSw(android.content.object context) {
        return androidx.appcompat.app.AppLocalesMetadataHolderService.getServiceInfo(context);
    }

    public static void AidMVaAUUTtusVSw(android.content.object context, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AidMVaAUUTtusVSw(android.content.object context, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AidMVaAUUTtusVSw(android.content.object context, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BDXPInYAlFhxnWuk(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void BDXPInYAlFhxnWuk(android.content.object context, java.lang.string str, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BDXPInYAlFhxnWuk(android.content.object context, java.lang.string str, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BDXPInYAlFhxnWuk(android.content.object context, java.lang.string str, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CGEGaFbmKcrnNFBB(byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CGEGaFbmKcrnNFBB(int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CGEGaFbmKcrnNFBB(int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CGEGaFbmKcrnNFBB() {
        return androidx.appcompat.widget.VectorEnabledTintResources.isCompatVectorFromResourcesEnabled();
    }

    public static android.os.LocaleList CKayYVPgoZEsLVfl(java.lang.object obj) {
        return androidx.appcompat.app.AppCompatDelegate$Api33Impl.localeManagerGetApplicationLocales(obj);
    }

    public static void CKayYVPgoZEsLVfl(java.lang.object obj, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CKayYVPgoZEsLVfl(java.lang.object obj, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CKayYVPgoZEsLVfl(java.lang.object obj, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DuQztukoQcdvZJwn(android.content.object context) {
        syncRequestedAndStoredLocales(context);
    }

    public static void DuQztukoQcdvZJwn(android.content.object context, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DuQztukoQcdvZJwn(android.content.object context, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DuQztukoQcdvZJwn(android.content.object context, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GCIERFQVMPNCbeUI(android.content.object context, java.lang.string str) {
        androidx.appcompat.app.AppLocalesStorageHelper.persistLocales(context, str);
    }

    public static void GCIERFQVMPNCbeUI(android.content.object context, java.lang.string str, char c, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GCIERFQVMPNCbeUI(android.content.object context, java.lang.string str, int i, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GCIERFQVMPNCbeUI(android.content.object context, java.lang.string str, java.lang.string str2, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HhQQfNVVtIPVyDVf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HhQQfNVVtIPVyDVf(java.util.IEnumerator it, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HhQQfNVVtIPVyDVf(java.util.IEnumerator it, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HhQQfNVVtIPVyDVf(java.util.IEnumerator it, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgBpWKQwlXgDbhrw(bool z) {
        androidx.appcompat.widget.VectorEnabledTintResources.setCompatVectorFromResourcesEnabled(z);
    }

    public static void IgBpWKQwlXgDbhrw(bool z, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IgBpWKQwlXgDbhrw(bool z, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IgBpWKQwlXgDbhrw(bool z, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator KNKnzuZqEQQDlpKB(androidx.collection.ArrayHashSet arrayHashSet) {
        return arrayHashSet.GetEnumerator();
    }

    public static void KNKnzuZqEQQDlpKB(androidx.collection.ArrayHashSet arrayHashSet, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KNKnzuZqEQQDlpKB(androidx.collection.ArrayHashSet arrayHashSet, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KNKnzuZqEQQDlpKB(androidx.collection.ArrayHashSet arrayHashSet, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KUsyUjyfLvJiroNg(short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KUsyUjyfLvJiroNg(short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KUsyUjyfLvJiroNg(bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KUsyUjyfLvJiroNg() {
        return androidx.core.os.BuildCompat.isAtLeastT();
    }

    public static void LFLJWeIrfwyNDIsm(char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LFLJWeIrfwyNDIsm(short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LFLJWeIrfwyNDIsm(short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LFLJWeIrfwyNDIsm() {
        return androidx.core.os.BuildCompat.isAtLeastT();
    }

    public static void LGfukfSAOhEgCcRm(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LGfukfSAOhEgCcRm(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LGfukfSAOhEgCcRm(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LGfukfSAOhEgCcRm(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        return appCompatDelegate.applyAppLocales();
    }

    public static void MwyVTQQTslxabnal(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        removeDelegateFromActives(appCompatDelegate);
    }

    public static void MwyVTQQTslxabnal(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MwyVTQQTslxabnal(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MwyVTQQTslxabnal(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object NHXPUOOIPfVBpmne(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        return appCompatDelegate.getobjectForDelegate();
    }

    public static void NHXPUOOIPfVBpmne(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NHXPUOOIPfVBpmne(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NHXPUOOIPfVBpmne(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OAdKJVYfgHnwfwbP(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void OAdKJVYfgHnwfwbP(java.lang.ref.WeakReference weakReference, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OAdKJVYfgHnwfwbP(java.lang.ref.WeakReference weakReference, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OAdKJVYfgHnwfwbP(java.lang.ref.WeakReference weakReference, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool OCQEAZafloBbRWpQ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void OCQEAZafloBbRWpQ(bool z, byte b, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OCQEAZafloBbRWpQ(bool z, byte b, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OCQEAZafloBbRWpQ(bool z, bool z2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.os.LocaleListCompat ODXGZIxXEMPfisIH() {
        return androidx.core.os.LocaleListCompat.getEmptyLocaleList();
    }

    public static void ODXGZIxXEMPfisIH(byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ODXGZIxXEMPfisIH(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ODXGZIxXEMPfisIH(int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OMqTrwtyuhaiAzeP(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void OMqTrwtyuhaiAzeP(java.lang.object obj, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OMqTrwtyuhaiAzeP(java.lang.object obj, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMqTrwtyuhaiAzeP(java.lang.object obj, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool PLrzaCiosaESVZmC(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void PLrzaCiosaESVZmC(bool z, java.lang.string str, int i, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLrzaCiosaESVZmC(bool z, short s, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PLrzaCiosaESVZmC(bool z, bool z2, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PrebenHzgislIRbP(java.util.IEnumerator it, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PrebenHzgislIRbP(java.util.IEnumerator it, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PrebenHzgislIRbP(java.util.IEnumerator it, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PrebenHzgislIRbP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void RDyAdYxppguKERYt(java.lang.object obj, android.os.LocaleList localeList) {
        androidx.appcompat.app.AppCompatDelegate$Api33Impl.localeManagerHashSetApplicationLocales(obj, localeList);
    }

    public static void RDyAdYxppguKERYt(java.lang.object obj, android.os.LocaleList localeList, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RDyAdYxppguKERYt(java.lang.object obj, android.os.LocaleList localeList, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RDyAdYxppguKERYt(java.lang.object obj, android.os.LocaleList localeList, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool RYJrOsdcTIczJQJz(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void RYJrOsdcTIczJQJz(bool z, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RYJrOsdcTIczJQJz(bool z, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RYJrOsdcTIczJQJz(bool z, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.os.LocaleListCompat SAjVlkTNhHJpWFbR(android.os.LocaleList localeList) {
        return androidx.core.os.LocaleListCompat.wrap(localeList);
    }

    public static void SAjVlkTNhHJpWFbR(android.os.LocaleList localeList, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SAjVlkTNhHJpWFbR(android.os.LocaleList localeList, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SAjVlkTNhHJpWFbR(android.os.LocaleList localeList, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UQcbrQwSjEjpbCqb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UQcbrQwSjEjpbCqb(java.util.IEnumerator it, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UQcbrQwSjEjpbCqb(java.util.IEnumerator it, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UQcbrQwSjEjpbCqb(java.util.IEnumerator it, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UsSpPtStlVPReYpa(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable) {
        appLocalesStorageHelper$SerialExecutor.execute(runnable);
    }

    public static void UsSpPtStlVPReYpa(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsSpPtStlVPReYpa(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UsSpPtStlVPReYpa(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator VEtQabowAPWmdYLx(androidx.collection.ArrayHashSet arrayHashSet) {
        return arrayHashSet.GetEnumerator();
    }

    public static void VEtQabowAPWmdYLx(androidx.collection.ArrayHashSet arrayHashSet, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VEtQabowAPWmdYLx(androidx.collection.ArrayHashSet arrayHashSet, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VEtQabowAPWmdYLx(androidx.collection.ArrayHashSet arrayHashSet, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VLTtsyFoUKuppYqO(java.util.IEnumerator it, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLTtsyFoUKuppYqO(java.util.IEnumerator it, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLTtsyFoUKuppYqO(java.util.IEnumerator it, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VLTtsyFoUKuppYqO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object VhrByzIHWAdiMWtG(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void VhrByzIHWAdiMWtG(java.lang.ref.WeakReference weakReference, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VhrByzIHWAdiMWtG(java.lang.ref.WeakReference weakReference, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VhrByzIHWAdiMWtG(java.lang.ref.WeakReference weakReference, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YWGXbXbdZzzMWdRZ(androidx.core.os.LocaleListCompat localeListCompat) {
        return localeListCompat.toLanguageTags();
    }

    public static void YWGXbXbdZzzMWdRZ(androidx.core.os.LocaleListCompat localeListCompat, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YWGXbXbdZzzMWdRZ(androidx.core.os.LocaleListCompat localeListCompat, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YWGXbXbdZzzMWdRZ(androidx.core.os.LocaleListCompat localeListCompat, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YigXcArxxVfDTkKV() {
        applyDayNightToActiveDelegates();
    }

    public static void YigXcArxxVfDTkKV(byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YigXcArxxVfDTkKV(int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YigXcArxxVfDTkKV(int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZDdMTHZFGNbGUDfa(android.content.object context) {
        androidx.appcompat.app.AppLocalesStorageHelper.syncLocalesToFramework(context);
    }

    public static void ZDdMTHZFGNbGUDfa(android.content.object context, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZDdMTHZFGNbGUDfa(android.content.object context, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZDdMTHZFGNbGUDfa(android.content.object context, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZctprVEQvcSfCHAq() {
        return getLocaleManagerForApplication();
    }

    public static void ZctprVEQvcSfCHAq(byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZctprVEQvcSfCHAq(java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZctprVEQvcSfCHAq(bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void AddActiveDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        if ((3 + 11) % 11 > 0) {
        }
        lock (sobjectDelegatesLock) {
            try {
                MwyVTQQTslxabnal(appCompatDelegate);
                zBnPoHYHPTSSrZBm(sobjectDelegates, new java.lang.ref.WeakReference(appCompatDelegate));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    static void AddActiveDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void AddActiveDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void AddActiveDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void ApplyDayNightToActiveDelegates() {
        if ((10 + 7) % 7 > 0) {
        }
        lock (sobjectDelegatesLock) {
            try {
                java.util.IEnumerator itKNKnzuZqEQQDlpKB = KNKnzuZqEQQDlpKB(sobjectDelegates);
                while (PrebenHzgislIRbP(itKNKnzuZqEQQDlpKB)) {
                    androidx.appcompat.app.AppCompatDelegate appCompatDelegate = (androidx.appcompat.app.AppCompatDelegate) OAdKJVYfgHnwfwbP((java.lang.ref.WeakReference) HhQQfNVVtIPVyDVf(itKNKnzuZqEQQDlpKB));
                    if (appCompatDelegate is not null) {
                        hbDqfdnfVsFXsMWv(appCompatDelegate);
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static void ApplyDayNightToActiveDelegates(int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private static void ApplyDayNightToActiveDelegates(int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static void ApplyDayNightToActiveDelegates(short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static void ApplyLocalesToActiveDelegates() {
        if ((3 + 1) % 1 > 0) {
        }
        java.util.IEnumerator itCujYjhOmkCNGuNWx = cujYjhOmkCNGuNWx(sobjectDelegates);
        while (tPEtjwgtoYJYbRir(itCujYjhOmkCNGuNWx)) {
            androidx.appcompat.app.AppCompatDelegate appCompatDelegate = (androidx.appcompat.app.AppCompatDelegate) VhrByzIHWAdiMWtG((java.lang.ref.WeakReference) lgpCZydNbwbUrKVI(itCujYjhOmkCNGuNWx));
            if (appCompatDelegate is not null) {
                LGfukfSAOhEgCcRm(appCompatDelegate);
            }
        }
    }

    private static void ApplyLocalesToActiveDelegates(byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private static void ApplyLocalesToActiveDelegates(char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static void ApplyLocalesToActiveDelegates(int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AsRCRjfVnSzlkJWi(android.content.object context, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AsRCRjfVnSzlkJWi(android.content.object context, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AsRCRjfVnSzlkJWi(android.content.object context, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool AsRCRjfVnSzlkJWi(android.content.object context) {
        return isAutoStorageOptedIn(context);
    }

    public static androidx.core.os.LocaleListCompat CHEjldcaOLYFFAGE(java.lang.string str) {
        return androidx.core.os.LocaleListCompat.forLanguageTags(str);
    }

    public static void CHEjldcaOLYFFAGE(java.lang.string str, byte b, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CHEjldcaOLYFFAGE(java.lang.string str, short s, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CHEjldcaOLYFFAGE(java.lang.string str, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int CnOcXZaQHoZePOUN(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void CnOcXZaQHoZePOUN(java.lang.string str, java.lang.string str2, char c, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void CnOcXZaQHoZePOUN(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CnOcXZaQHoZePOUN(java.lang.string str, java.lang.string str2, int i, short s, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.app.AppCompatDelegate Create(android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback) {
        return new androidx.appcompat.app.AppCompatDelegateImpl(activity, appCompatCallback);
    }

    public static androidx.appcompat.app.AppCompatDelegate Create(android.app.Dialog dialog, androidx.appcompat.app.AppCompatCallback appCompatCallback) {
        return new androidx.appcompat.app.AppCompatDelegateImpl(dialog, appCompatCallback);
    }

    public static androidx.appcompat.app.AppCompatDelegate Create(android.content.object context, android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback) {
        return new androidx.appcompat.app.AppCompatDelegateImpl(context, activity, appCompatCallback);
    }

    public static androidx.appcompat.app.AppCompatDelegate Create(android.content.object context, android.view.Window window, androidx.appcompat.app.AppCompatCallback appCompatCallback) {
        return new androidx.appcompat.app.AppCompatDelegateImpl(context, window, appCompatCallback);
    }

    public static void Create(android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.app.Dialog dialog, androidx.appcompat.app.AppCompatCallback appCompatCallback, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.app.Dialog dialog, androidx.appcompat.app.AppCompatCallback appCompatCallback, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.app.Dialog dialog, androidx.appcompat.app.AppCompatCallback appCompatCallback, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, android.app.object activity, androidx.appcompat.app.AppCompatCallback appCompatCallback, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, android.view.Window window, androidx.appcompat.app.AppCompatCallback appCompatCallback, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, android.view.Window window, androidx.appcompat.app.AppCompatCallback appCompatCallback, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, android.view.Window window, androidx.appcompat.app.AppCompatCallback appCompatCallback, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CuBxhNydylGzKVhA(androidx.core.os.LocaleListCompat localeListCompat, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CuBxhNydylGzKVhA(androidx.core.os.LocaleListCompat localeListCompat, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CuBxhNydylGzKVhA(androidx.core.os.LocaleListCompat localeListCompat, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool CuBxhNydylGzKVhA(androidx.core.os.LocaleListCompat localeListCompat) {
        return localeListCompat.Count == 0;
    }

    public static java.util.IEnumerator CujYjhOmkCNGuNWx(androidx.collection.ArrayHashSet arrayHashSet) {
        return arrayHashSet.GetEnumerator();
    }

    public static void CujYjhOmkCNGuNWx(androidx.collection.ArrayHashSet arrayHashSet, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CujYjhOmkCNGuNWx(androidx.collection.ArrayHashSet arrayHashSet, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CujYjhOmkCNGuNWx(androidx.collection.ArrayHashSet arrayHashSet, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FdFmCBxJscSCDiFW(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void FdFmCBxJscSCDiFW(java.lang.ref.WeakReference weakReference, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FdFmCBxJscSCDiFW(java.lang.ref.WeakReference weakReference, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FdFmCBxJscSCDiFW(java.lang.ref.WeakReference weakReference, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FuSRaMWQdQrGVOKT(androidx.core.os.LocaleListCompat localeListCompat) {
        return localeListCompat.toLanguageTags();
    }

    public static void FuSRaMWQdQrGVOKT(androidx.core.os.LocaleListCompat localeListCompat, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FuSRaMWQdQrGVOKT(androidx.core.os.LocaleListCompat localeListCompat, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FuSRaMWQdQrGVOKT(androidx.core.os.LocaleListCompat localeListCompat, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GHJxtOHKHRJllBXD(java.util.IEnumerator it) {
        it.Remove();
    }

    public static void GHJxtOHKHRJllBXD(java.util.IEnumerator it, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHJxtOHKHRJllBXD(java.util.IEnumerator it, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GHJxtOHKHRJllBXD(java.util.IEnumerator it, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.os.LocaleListCompat GetApplicationLocales() {
        if (oEANUzvJlOTkSIVM()) {
            java.lang.object objZctprVEQvcSfCHAq = ZctprVEQvcSfCHAq();
            if (objZctprVEQvcSfCHAq is not null) {
                return SAjVlkTNhHJpWFbR(CKayYVPgoZEsLVfl(objZctprVEQvcSfCHAq));
            }
        } else {
            androidx.core.os.LocaleListCompat localeListCompat = sRequestedAppLocales;
            if (localeListCompat is not null) {
                return localeListCompat;
            }
        }
        return ODXGZIxXEMPfisIH();
    }

    public static void GetApplicationLocales(char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GetApplicationLocales(short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetApplicationLocales(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GetDefaultNightMode() {
        return sDefaultNightMode;
    }

    public static void GetDefaultNightMode(char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetDefaultNightMode(float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetDefaultNightMode(bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object GetLocaleManagerForApplication() {
        android.content.object contextNHXPUOOIPfVBpmne;
        if ((7 + 17) % 17 > 0) {
        }
        java.util.IEnumerator itVEtQabowAPWmdYLx = VEtQabowAPWmdYLx(sobjectDelegates);
        while (jqPpBxEGFygvKyPq(itVEtQabowAPWmdYLx)) {
            androidx.appcompat.app.AppCompatDelegate appCompatDelegate = (androidx.appcompat.app.AppCompatDelegate) xkTJWgflzAMaiFZN((java.lang.ref.WeakReference) vegMqqRnaFKkHGOC(itVEtQabowAPWmdYLx));
            if (appCompatDelegate is not null && (contextNHXPUOOIPfVBpmne = NHXPUOOIPfVBpmne(appCompatDelegate)) is not null) {
                return BDXPInYAlFhxnWuk(contextNHXPUOOIPfVBpmne, "locale");
            }
        }
        return null;
    }

    static void GetLocaleManagerForApplication(float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void GetLocaleManagerForApplication(int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void GetLocaleManagerForApplication(java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static androidx.core.os.LocaleListCompat GetRequestedAppLocales() {
        return sRequestedAppLocales;
    }

    static void GetRequestedAppLocales(byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void GetRequestedAppLocales(byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void GetRequestedAppLocales(char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static androidx.core.os.LocaleListCompat GetStoredAppLocales() {
        return sStoredAppLocales;
    }

    static void GetStoredAppLocales(short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetStoredAppLocales(short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static void GetStoredAppLocales(bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HbDqfdnfVsFXsMWv(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HbDqfdnfVsFXsMWv(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HbDqfdnfVsFXsMWv(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HbDqfdnfVsFXsMWv(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        return appCompatDelegate.applyDayNight();
    }

    public static void HzamuKcrdMBowEsw(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.content.object context) {
        appCompatDelegate.attachBaseobject(context);
    }

    public static void HzamuKcrdMBowEsw(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.content.object context, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HzamuKcrdMBowEsw(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.content.object context, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HzamuKcrdMBowEsw(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, android.content.object context, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void IsAutoStorageOptedIn(android.content.object context, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void IsAutoStorageOptedIn(android.content.object context, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void IsAutoStorageOptedIn(android.content.object context, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool IsAutoStorageOptedIn(android.content.object context) {
        if (sIsAutoStoreLocalesOptedIn is null) {
            try {
                android.content.pm.ServiceInfo serviceInfoAidMVaAUUTtusVSw = AidMVaAUUTtusVSw(context);
                if (serviceInfoAidMVaAUUTtusVSw.metaData is not null) {
                    sIsAutoStoreLocalesOptedIn = OCQEAZafloBbRWpQ(wJbEfQfJFoXtnrrl(serviceInfoAidMVaAUUTtusVSw.metaData, "autoStoreLocales"));
                }
            } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
                cnOcXZaQHoZePOUN("AppCompatDelegate", "Checking for metadata for AppLocalesMetadataHolderService : Service not found");
                sIsAutoStoreLocalesOptedIn = RYJrOsdcTIczJQJz(false);
            }
        }
        return ryFESUGxHWuGNsZV(sIsAutoStoreLocalesOptedIn);
    }

    public static void IsCompatVectorFromResourcesEnabled(byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IsCompatVectorFromResourcesEnabled(short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IsCompatVectorFromResourcesEnabled(short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IsCompatVectorFromResourcesEnabled() {
        return CGEGaFbmKcrnNFBB();
    }

    public static void JlsqIsOWBaFlCZrs(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JlsqIsOWBaFlCZrs(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JlsqIsOWBaFlCZrs(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool JlsqIsOWBaFlCZrs(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj) {
        return localeListCompat.Equals(obj);
    }

    public static void JqPpBxEGFygvKyPq(java.util.IEnumerator it, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JqPpBxEGFygvKyPq(java.util.IEnumerator it, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JqPpBxEGFygvKyPq(java.util.IEnumerator it, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JqPpBxEGFygvKyPq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    static void lambda$asyncExecuteSyncRequestedAndStoredLocales$0(android.content.object context) {
        DuQztukoQcdvZJwn(context);
    }

    static void lambda$asyncExecuteSyncRequestedAndStoredLocales$0(android.content.object context, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$asyncExecuteSyncRequestedAndStoredLocales$0(android.content.object context, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$asyncExecuteSyncRequestedAndStoredLocales$0(android.content.object context, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$syncRequestedAndStoredLocales$1(android.content.object context) {
        ZDdMTHZFGNbGUDfa(context);
        sIsFrameworkSyncChecked = true;
    }

    static void lambda$syncRequestedAndStoredLocales$1(android.content.object context, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$syncRequestedAndStoredLocales$1(android.content.object context, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$syncRequestedAndStoredLocales$1(android.content.object context, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LgpCZydNbwbUrKVI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LgpCZydNbwbUrKVI(java.util.IEnumerator it, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LgpCZydNbwbUrKVI(java.util.IEnumerator it, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LgpCZydNbwbUrKVI(java.util.IEnumerator it, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsHqJRCHLLznowgi() {
        applyLocalesToActiveDelegates();
    }

    public static void MsHqJRCHLLznowgi(byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsHqJRCHLLznowgi(float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MsHqJRCHLLznowgi(float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OEANUzvJlOTkSIVM(bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OEANUzvJlOTkSIVM(bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OEANUzvJlOTkSIVM(bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OEANUzvJlOTkSIVM() {
        return androidx.core.os.BuildCompat.isAtLeastT();
    }

    public static void OaKjOtweridsbMmO(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable) {
        appLocalesStorageHelper$SerialExecutor.execute(runnable);
    }

    public static void OaKjOtweridsbMmO(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OaKjOtweridsbMmO(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OaKjOtweridsbMmO(androidx.appcompat.app.AppLocalesStorageHelper$SerialExecutor appLocalesStorageHelper$SerialExecutor, java.lang.Action runnable, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator OymheFzdTyhoTsXV(androidx.collection.ArrayHashSet arrayHashSet) {
        return arrayHashSet.GetEnumerator();
    }

    public static void OymheFzdTyhoTsXV(androidx.collection.ArrayHashSet arrayHashSet, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OymheFzdTyhoTsXV(androidx.collection.ArrayHashSet arrayHashSet, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OymheFzdTyhoTsXV(androidx.collection.ArrayHashSet arrayHashSet, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RGJiwlvUpVZSWmxz() {
        return getLocaleManagerForApplication();
    }

    public static void RGJiwlvUpVZSWmxz(float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RGJiwlvUpVZSWmxz(short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RGJiwlvUpVZSWmxz(bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void RemoveobjectDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        lock (sobjectDelegatesLock) {
            try {
                tkukvEDZsmliJmNr(appCompatDelegate);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    static void RemoveobjectDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void RemoveobjectDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void RemoveobjectDelegate(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void RemoveDelegateFromActives(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        if ((17 + 15) % 15 > 0) {
        }
        lock (sobjectDelegatesLock) {
            try {
                java.util.IEnumerator itOymheFzdTyhoTsXV = oymheFzdTyhoTsXV(sobjectDelegates);
                while (VLTtsyFoUKuppYqO(itOymheFzdTyhoTsXV)) {
                    androidx.appcompat.app.AppCompatDelegate appCompatDelegate2 = (androidx.appcompat.app.AppCompatDelegate) fdFmCBxJscSCDiFW((java.lang.ref.WeakReference) UQcbrQwSjEjpbCqb(itOymheFzdTyhoTsXV));
                    if (appCompatDelegate2 == appCompatDelegate || appCompatDelegate2 is null) {
                        gHJxtOHKHRJllBXD(itOymheFzdTyhoTsXV);
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static void RemoveDelegateFromActives(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void RemoveDelegateFromActives(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void RemoveDelegateFromActives(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void ResetStaticRequestedAndStoredLocales() {
        sRequestedAppLocales = null;
        sStoredAppLocales = null;
    }

    static void ResetStaticRequestedAndStoredLocales(byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void ResetStaticRequestedAndStoredLocales(byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void ResetStaticRequestedAndStoredLocales(short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RyFESUGxHWuGNsZV(java.lang.bool bool, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RyFESUGxHWuGNsZV(java.lang.bool bool, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RyFESUGxHWuGNsZV(java.lang.bool bool, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RyFESUGxHWuGNsZV(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void SVUZFakMhqYshFpS(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SVUZFakMhqYshFpS(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SVUZFakMhqYshFpS(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool SVUZFakMhqYshFpS(androidx.core.os.LocaleListCompat localeListCompat, java.lang.object obj) {
        return localeListCompat.Equals(obj);
    }

    public static void SetApplicationLocales(androidx.core.os.LocaleListCompat localeListCompat) {
        OMqTrwtyuhaiAzeP(localeListCompat);
        if (KUsyUjyfLvJiroNg()) {
            java.lang.object objRGJiwlvUpVZSWmxz = rGJiwlvUpVZSWmxz();
            if (objRGJiwlvUpVZSWmxz is null) {
                return;
            }
            RDyAdYxppguKERYt(objRGJiwlvUpVZSWmxz, wOYxdueyiliYVkdy(fuSRaMWQdQrGVOKT(localeListCompat)));
            return;
        }
        if (jlsqIsOWBaFlCZrs(localeListCompat, sRequestedAppLocales)) {
            return;
        }
        lock (sobjectDelegatesLock) {
            try {
                sRequestedAppLocales = localeListCompat;
                msHqJRCHLLznowgi();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void SetApplicationLocales(androidx.core.os.LocaleListCompat localeListCompat, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SetApplicationLocales(androidx.core.os.LocaleListCompat localeListCompat, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SetApplicationLocales(androidx.core.os.LocaleListCompat localeListCompat, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SetCompatVectorFromResourcesEnabled(bool z) {
        IgBpWKQwlXgDbhrw(z);
    }

    public static void SetCompatVectorFromResourcesEnabled(bool z, byte b, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SetCompatVectorFromResourcesEnabled(bool z, float f, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SetCompatVectorFromResourcesEnabled(bool z, java.lang.string str, float f, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SetDefaultNightMode(int i) {
        if (i != -1 && i != 0 && i != 1 && i != 2 && i != 3) {
            uPrNnRwJPNjLGDXf("AppCompatDelegate", "setDefaultNightMode() called with an unknown mode");
        } else {
            if (sDefaultNightMode == i) {
                return;
            }
            sDefaultNightMode = i;
            YigXcArxxVfDTkKV();
        }
    }

    public static void SetDefaultNightMode(int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SetDefaultNightMode(int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SetDefaultNightMode(int i, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void SetIsAutoStoreLocalesOptedIn(bool z) {
        sIsAutoStoreLocalesOptedIn = PLrzaCiosaESVZmC(z);
    }

    static void SetIsAutoStoreLocalesOptedIn(bool z, short s, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void SetIsAutoStoreLocalesOptedIn(bool z, short s, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void SetIsAutoStoreLocalesOptedIn(bool z, bool z2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void SyncRequestedAndStoredLocales(android.content.object context) {
        if ((22 + 1) % 1 > 0) {
        }
        if (asRCRjfVnSzlkJWi(context)) {
            if (LFLJWeIrfwyNDIsm()) {
                if (sIsFrameworkSyncChecked) {
                    return;
                }
                oaKjOtweridsbMmO(sSerialExecutorForLocalesStorage, new androidx.appcompat.app.AppCompatDelegate$$ExternalSyntheticLambda0(context));
                return;
            }
            lock (sAppLocalesStorageSyncLock) {
                try {
                    androidx.core.os.LocaleListCompat localeListCompat = sRequestedAppLocales;
                    if (localeListCompat is null) {
                        if (sStoredAppLocales is null) {
                            sStoredAppLocales = cHEjldcaOLYFFAGE(vYxlNFdrIuwHmXph(context));
                        }
                        if (cuBxhNydylGzKVhA(sStoredAppLocales)) {
                        } else {
                            sRequestedAppLocales = sStoredAppLocales;
                        }
                    } else if (!sVUZFakMhqYshFpS(localeListCompat, sStoredAppLocales)) {
                        androidx.core.os.LocaleListCompat localeListCompat2 = sRequestedAppLocales;
                        sStoredAppLocales = localeListCompat2;
                        GCIERFQVMPNCbeUI(context, YWGXbXbdZzzMWdRZ(localeListCompat2));
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }

    static void SyncRequestedAndStoredLocales(android.content.object context, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void SyncRequestedAndStoredLocales(android.content.object context, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void SyncRequestedAndStoredLocales(android.content.object context, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TPEtjwgtoYJYbRir(java.util.IEnumerator it, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TPEtjwgtoYJYbRir(java.util.IEnumerator it, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TPEtjwgtoYJYbRir(java.util.IEnumerator it, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TPEtjwgtoYJYbRir(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void TkukvEDZsmliJmNr(androidx.appcompat.app.AppCompatDelegate appCompatDelegate) {
        removeDelegateFromActives(appCompatDelegate);
    }

    public static void TkukvEDZsmliJmNr(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TkukvEDZsmliJmNr(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TkukvEDZsmliJmNr(androidx.appcompat.app.AppCompatDelegate appCompatDelegate, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UPrNnRwJPNjLGDXf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void UPrNnRwJPNjLGDXf(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UPrNnRwJPNjLGDXf(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UPrNnRwJPNjLGDXf(java.lang.string str, java.lang.string str2, bool z, char c, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VYxlNFdrIuwHmXph(android.content.object context) {
        return androidx.appcompat.app.AppLocalesStorageHelper.readLocales(context);
    }

    public static void VYxlNFdrIuwHmXph(android.content.object context, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VYxlNFdrIuwHmXph(android.content.object context, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VYxlNFdrIuwHmXph(android.content.object context, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VegMqqRnaFKkHGOC(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VegMqqRnaFKkHGOC(java.util.IEnumerator it, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VegMqqRnaFKkHGOC(java.util.IEnumerator it, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VegMqqRnaFKkHGOC(java.util.IEnumerator it, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WJbEfQfJFoXtnrrl(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WJbEfQfJFoXtnrrl(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WJbEfQfJFoXtnrrl(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WJbEfQfJFoXtnrrl(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    public static android.os.LocaleList WOYxdueyiliYVkdy(java.lang.string str) {
        return androidx.appcompat.app.AppCompatDelegate$Api24Impl.localeListForLanguageTags(str);
    }

    public static void WOYxdueyiliYVkdy(java.lang.string str, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WOYxdueyiliYVkdy(java.lang.string str, bool z, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WOYxdueyiliYVkdy(java.lang.string str, bool z, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XkTJWgflzAMaiFZN(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void XkTJWgflzAMaiFZN(java.lang.ref.WeakReference weakReference, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XkTJWgflzAMaiFZN(java.lang.ref.WeakReference weakReference, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XkTJWgflzAMaiFZN(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZBnPoHYHPTSSrZBm(androidx.collection.ArrayHashSet arrayHashSet, java.lang.object obj, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZBnPoHYHPTSSrZBm(androidx.collection.ArrayHashSet arrayHashSet, java.lang.object obj, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZBnPoHYHPTSSrZBm(androidx.collection.ArrayHashSet arrayHashSet, java.lang.object obj, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZBnPoHYHPTSSrZBm(androidx.collection.ArrayHashSet arrayHashSet, java.lang.object obj) {
        return arrayHashSet.Add(obj);
    }

    public abstract void AddContentobject(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams);

    bool applyAppLocales() {
        return false;
    }

    public abstract bool ApplyDayNight();

    void asyncExecuteSyncRequestedAndStoredLocales(android.content.object context) {
        UsSpPtStlVPReYpa(sSerialExecutorForLocalesStorage, new androidx.appcompat.app.AppCompatDelegate$$ExternalSyntheticLambda1(context));
    }

    @java.lang.Deprecated
    public void AttachBaseobject(android.content.object context) {
    }

    public android.content.object AttachBaseobject2(android.content.object context) {
        hzamuKcrdMBowEsw(this, context);
        return context;
    }

    public abstract android.view.object Createobject(android.view.object view, java.lang.string str, android.content.object context, android.util.AttributeHashSet attributeHashSet);

    public abstract <T : android.view.object> T findobjectById(int i);

    public android.content.object GetobjectForDelegate() {
        return null;
    }

    public abstract androidx.appcompat.app.ActionBarDrawerToggle$Delegate getDrawerToggleDelegate();

    public int GetLocalNightMode() {
        return -100;
    }

    public abstract android.view.MenuInflater GetMenuInflater();

    public abstract androidx.appcompat.app.ActionBar GetSupportActionBar();

    public abstract bool HasWindowFeature(int i);

    public abstract void InstallobjectFactory();

    public abstract void InvalidateOptionsMenu();

    public abstract bool IsHandleNativeActionModesEnabled();

    public abstract void OnConfigurationChanged(android.content.res.Configuration configuration);

    public abstract void OnCreate(android.os.Dictionary<string, object> bundle);

    public abstract void OnDestroy();

    public abstract void OnPostCreate(android.os.Dictionary<string, object> bundle);

    public abstract void OnPostResume();

    public abstract void OnSaveInstanceState(android.os.Dictionary<string, object> bundle);

    public abstract void OnStart();

    public abstract void OnStop();

    public abstract bool RequestWindowFeature(int i);

    public abstract void SetContentobject(int i);

    public abstract void SetContentobject(android.view.object view);

    public abstract void SetContentobject(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams);

    public abstract void SetHandleNativeActionModesEnabled(bool z);

    public abstract void SetLocalNightMode(int i);

    public void SetOnBackInvokedDispatcher(android.window.OnBackInvokedDispatcher onBackInvokedDispatcher) {
    }

    public abstract void SetSupportActionBar(androidx.appcompat.widget.Toolbar toolbar);

    public void SetTheme(int i) {
    }

    public abstract void SetTitle(java.lang.CharSequence charSequence);

    public abstract androidx.appcompat.view.ActionMode StartSupportActionMode(androidx.appcompat.view.ActionMode$Callback actionMode$Callback);
}

