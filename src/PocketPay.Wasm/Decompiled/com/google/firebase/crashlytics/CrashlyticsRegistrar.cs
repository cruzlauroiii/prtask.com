namespace WillowMaze.Wasm.Decompiled;


public class CrashlyticsRegistrar : com.google.firebase.components.ComponentRegistrar {
    private static readonly java.lang.string LIBRARY_NAME = "fire-cls";
    private readonly com.google.firebase.components.Qualified<java.util.concurrent.TaskScheduler> backgroundTaskScheduler;
    private readonly com.google.firebase.components.Qualified<java.util.concurrent.TaskScheduler> blockingTaskScheduler;
    private readonly com.google.firebase.components.Qualified<java.util.concurrent.TaskScheduler> lightweightTaskScheduler;

    public static com.google.firebase.crashlytics.FirebaseCrashlytics $r8$lambda$XFR966Xtld0zGICMasGRYAhWin4(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer) {
        return MXVGbrdYzgKXFXmx(crashlyticsRegistrar, componentContainer);
    }

    public static void $r8$lambda$XFR966Xtld0zGICMasGRYAhWin4(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$XFR966Xtld0zGICMasGRYAhWin4(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$XFR966Xtld0zGICMasGRYAhWin4(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static {
        urKySWoDBJLQoEBL(com.google.firebase.sessions.api.SessionSubscriber$Name.CRASHLYTICS);
    }

    public CrashlyticsRegistrar() {
        if ((17 + 30) % 30 > 0) {
        }
        this.backgroundTaskScheduler = DKXBjqALqFaZbNrN(com.google.firebase.annotations.concurrent.Background.class, java.util.concurrent.TaskScheduler.class);
        this.blockingTaskScheduler = vLZQcuYiSABJMjqU(com.google.firebase.annotations.concurrent.Blocking.class, java.util.concurrent.TaskScheduler.class);
        this.lightweightTaskScheduler = NPGMeVgaNUnkjaem(com.google.firebase.annotations.concurrent.Lightweight.class, java.util.concurrent.TaskScheduler.class);
    }

    public static com.google.firebase.inject.Deferred AUHRflTdgwRaruTC(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.getDeferred(cls);
    }

    public static void AUHRflTdgwRaruTC(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AUHRflTdgwRaruTC(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AUHRflTdgwRaruTC(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified DKXBjqALqFaZbNrN(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static void DKXBjqALqFaZbNrN(java.lang.Class cls, java.lang.Class cls2, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKXBjqALqFaZbNrN(java.lang.Class cls, java.lang.Class cls2, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKXBjqALqFaZbNrN(java.lang.Class cls, java.lang.Class cls2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EMlsdEGhOeOPgnyY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EMlsdEGhOeOPgnyY(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EMlsdEGhOeOPgnyY(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EMlsdEGhOeOPgnyY(java.lang.stringBuilder sb, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HNfZEzsVNkivAISE(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void HNfZEzsVNkivAISE(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNfZEzsVNkivAISE(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HNfZEzsVNkivAISE(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HvgdtDRYkrOLwFIg(bool z) {
        com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers.setEnforcement(z);
    }

    public static void HvgdtDRYkrOLwFIg(bool z, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HvgdtDRYkrOLwFIg(bool z, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HvgdtDRYkrOLwFIg(bool z, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.inject.Deferred IaDZCVvIHVluOTAd(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.getDeferred(cls);
    }

    public static void IaDZCVvIHVluOTAd(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IaDZCVvIHVluOTAd(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IaDZCVvIHVluOTAd(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder IjuefukagWOYRvyw(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void IjuefukagWOYRvyw(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IjuefukagWOYRvyw(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IjuefukagWOYRvyw(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder IyfHIpvGokhOWkso(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void IyfHIpvGokhOWkso(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IyfHIpvGokhOWkso(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IyfHIpvGokhOWkso(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency KOEdMSMBhaFJfFuh(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static void KOEdMSMBhaFJfFuh(java.lang.Class cls, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KOEdMSMBhaFJfFuh(java.lang.Class cls, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KOEdMSMBhaFJfFuh(java.lang.Class cls, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LCWUZNeWDFZjPXVW(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void LCWUZNeWDFZjPXVW(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LCWUZNeWDFZjPXVW(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LCWUZNeWDFZjPXVW(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics MXVGbrdYzgKXFXmx(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer) {
        return crashlyticsRegistrar.buildCrashlytics(componentContainer);
    }

    public static void MXVGbrdYzgKXFXmx(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MXVGbrdYzgKXFXmx(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MXVGbrdYzgKXFXmx(com.google.firebase.crashlytics.CrashlyticsRegistrar crashlyticsRegistrar, com.google.firebase.components.ComponentContainer componentContainer, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified NPGMeVgaNUnkjaem(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static void NPGMeVgaNUnkjaem(java.lang.Class cls, java.lang.Class cls2, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NPGMeVgaNUnkjaem(java.lang.Class cls, java.lang.Class cls2, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NPGMeVgaNUnkjaem(java.lang.Class cls, java.lang.Class cls2, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List OgjeXgpOjUpnpLxf(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static void OgjeXgpOjUpnpLxf(java.lang.object[] objArr, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OgjeXgpOjUpnpLxf(java.lang.object[] objArr, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OgjeXgpOjUpnpLxf(java.lang.object[] objArr, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RdZtrpqbDvUokSAj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RdZtrpqbDvUokSAj(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RdZtrpqbDvUokSAj(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RdZtrpqbDvUokSAj(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency ReTrwwgJauJtpbsE(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.deferred((java.lang.Class<object>) cls);
    }

    public static void ReTrwwgJauJtpbsE(java.lang.Class cls, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ReTrwwgJauJtpbsE(java.lang.Class cls, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ReTrwwgJauJtpbsE(java.lang.Class cls, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics SgqCZvpbmwXBwYfZ(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred deferred2, com.google.firebase.inject.Deferred deferred3, java.util.concurrent.TaskScheduler executorService, java.util.concurrent.TaskScheduler executorService2, java.util.concurrent.TaskScheduler executorService3) {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.init(firebaseApp, firebaseInstallationsApi, deferred, deferred2, deferred3, executorService, executorService2, executorService3);
    }

    public static void SgqCZvpbmwXBwYfZ(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred deferred2, com.google.firebase.inject.Deferred deferred3, java.util.concurrent.TaskScheduler executorService, java.util.concurrent.TaskScheduler executorService2, java.util.concurrent.TaskScheduler executorService3, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SgqCZvpbmwXBwYfZ(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred deferred2, com.google.firebase.inject.Deferred deferred3, java.util.concurrent.TaskScheduler executorService, java.util.concurrent.TaskScheduler executorService2, java.util.concurrent.TaskScheduler executorService3, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SgqCZvpbmwXBwYfZ(com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.inject.Deferred deferred, com.google.firebase.inject.Deferred deferred2, com.google.firebase.inject.Deferred deferred3, java.util.concurrent.TaskScheduler executorService, java.util.concurrent.TaskScheduler executorService2, java.util.concurrent.TaskScheduler executorService3, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency TnCPNchrSBkQvLft(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static void TnCPNchrSBkQvLft(com.google.firebase.components.Qualified qualified, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TnCPNchrSBkQvLft(com.google.firebase.components.Qualified qualified, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TnCPNchrSBkQvLft(com.google.firebase.components.Qualified qualified, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger UmCjHsASwvWflVRz() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void UmCjHsASwvWflVRz(float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UmCjHsASwvWflVRz(java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UmCjHsASwvWflVRz(short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VwqnImhtyRzVOyaU(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void VwqnImhtyRzVOyaU(java.lang.stringBuilder sb, long j, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VwqnImhtyRzVOyaU(java.lang.stringBuilder sb, long j, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VwqnImhtyRzVOyaU(java.lang.stringBuilder sb, long j, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder WauNcAnjbCeoPXzK(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void WauNcAnjbCeoPXzK(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WauNcAnjbCeoPXzK(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WauNcAnjbCeoPXzK(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder WiZpFJSghuhuJMkV(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.eagerInDefaultApp();
    }

    public static void WiZpFJSghuhuJMkV(com.google.firebase.components.Component$Builder component$Builder, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WiZpFJSghuhuJMkV(com.google.firebase.components.Component$Builder component$Builder, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WiZpFJSghuhuJMkV(com.google.firebase.components.Component$Builder component$Builder, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder XLWxaydaXJMJAXab(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory) {
        return component$Builder.factory(componentFactory);
    }

    public static void XLWxaydaXJMJAXab(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XLWxaydaXJMJAXab(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XLWxaydaXJMJAXab(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.ComponentFactory componentFactory, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency YDECKFtotyGhZmNv(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.deferred((java.lang.Class<object>) cls);
    }

    public static void YDECKFtotyGhZmNv(java.lang.Class cls, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YDECKFtotyGhZmNv(java.lang.Class cls, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YDECKFtotyGhZmNv(java.lang.Class cls, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder YFEqKJjQeQmfJhti(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str) {
        return component$Builder.name(str);
    }

    public static void YFEqKJjQeQmfJhti(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, char c, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YFEqKJjQeQmfJhti(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YFEqKJjQeQmfJhti(com.google.firebase.components.Component$Builder component$Builder, java.lang.string str, java.lang.string str2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YILCgQnsWBfhHCLl(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static void YILCgQnsWBfhHCLl(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YILCgQnsWBfhHCLl(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YILCgQnsWBfhHCLl(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZgqZfVIlLnlLiObk(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer[cls);
    }

    public static void ZgqZfVIlLnlLiObk(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZgqZfVIlLnlLiObk(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZgqZfVIlLnlLiObk(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component BJcYSxwymzvVbuMU(java.lang.string str, java.lang.string str2) {
        return com.google.firebase.platforminfo.LibraryVersionComponent.create(str, str2);
    }

    public static void BJcYSxwymzvVbuMU(java.lang.string str, java.lang.string str2, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJcYSxwymzvVbuMU(java.lang.string str, java.lang.string str2, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJcYSxwymzvVbuMU(java.lang.string str, java.lang.string str2, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.firebase.crashlytics.FirebaseCrashlytics BuildCrashlytics(com.google.firebase.components.ComponentContainer componentContainer) {
        if ((17 + 32) % 32 > 0) {
        }
        HvgdtDRYkrOLwFIg(false);
        long jNdvcibUIcTAozUQd = ndvcibUIcTAozUQd();
        com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlyticsSgqCZvpbmwXBwYfZ = SgqCZvpbmwXBwYfZ((com.google.firebase.FirebaseApp) ZgqZfVIlLnlLiObk(componentContainer, com.google.firebase.FirebaseApp.class), (com.google.firebase.installations.FirebaseInstallationsApi) YILCgQnsWBfhHCLl(componentContainer, com.google.firebase.installations.FirebaseInstallationsApi.class), IaDZCVvIHVluOTAd(componentContainer, com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent.class), nIGanOgiRYrULbgK(componentContainer, com.google.firebase.analytics.connector.AnalyticsConnector.class), AUHRflTdgwRaruTC(componentContainer, com.google.firebase.remoteconfig.interop.FirebaseRemoteConfigInterop.class), (java.util.concurrent.TaskScheduler) rtKPPnNctVMIYypp(componentContainer, this.backgroundTaskScheduler), (java.util.concurrent.TaskScheduler) HNfZEzsVNkivAISE(componentContainer, this.blockingTaskScheduler), (java.util.concurrent.TaskScheduler) LCWUZNeWDFZjPXVW(componentContainer, this.lightweightTaskScheduler));
        long jRGyduiQPrmBByVlp = rGyduiQPrmBByVlp() - jNdvcibUIcTAozUQd;
        if (jRGyduiQPrmBByVlp > 16) {
            mTMwkQKBiuIjrTPn(UmCjHsASwvWflVRz(), EMlsdEGhOeOPgnyY(RdZtrpqbDvUokSAj(VwqnImhtyRzVOyaU(new java.lang.stringBuilder("Initializing Crashlytics blocked main for "), jRGyduiQPrmBByVlp), " ms")));
        }
        return firebaseCrashlyticsSgqCZvpbmwXBwYfZ;
    }

    private void BuildCrashlytics(com.google.firebase.components.ComponentContainer componentContainer, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void BuildCrashlytics(com.google.firebase.components.ComponentContainer componentContainer, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void BuildCrashlytics(com.google.firebase.components.ComponentContainer componentContainer, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency CRQQysnHLGKkUsXQ(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.deferred((java.lang.Class<object>) cls);
    }

    public static void CRQQysnHLGKkUsXQ(java.lang.Class cls, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRQQysnHLGKkUsXQ(java.lang.Class cls, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CRQQysnHLGKkUsXQ(java.lang.Class cls, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder eUPhUsPlRzOODymW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void EUPhUsPlRzOODymW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EUPhUsPlRzOODymW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUPhUsPlRzOODymW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder hPrCNwTmvzjGauRY(java.lang.Class cls) {
        return com.google.firebase.components.Component.builder(cls);
    }

    public static void HPrCNwTmvzjGauRY(java.lang.Class cls, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPrCNwTmvzjGauRY(java.lang.Class cls, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HPrCNwTmvzjGauRY(java.lang.Class cls, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder iopBBHzEMTlttsej(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void IopBBHzEMTlttsej(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IopBBHzEMTlttsej(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IopBBHzEMTlttsej(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder lMgxxMWspATNpWuO(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void LMgxxMWspATNpWuO(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LMgxxMWspATNpWuO(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LMgxxMWspATNpWuO(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency LhblKbojsSbfPkAE(java.lang.Class cls) {
        return com.google.firebase.components.Dependency.required((java.lang.Class<object>) cls);
    }

    public static void LhblKbojsSbfPkAE(java.lang.Class cls, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LhblKbojsSbfPkAE(java.lang.Class cls, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LhblKbojsSbfPkAE(java.lang.Class cls, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MTMwkQKBiuIjrTPn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void MTMwkQKBiuIjrTPn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MTMwkQKBiuIjrTPn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MTMwkQKBiuIjrTPn(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.inject.Deferred NIGanOgiRYrULbgK(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls) {
        return componentContainer.getDeferred(cls);
    }

    public static void NIGanOgiRYrULbgK(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NIGanOgiRYrULbgK(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NIGanOgiRYrULbgK(com.google.firebase.components.ComponentContainer componentContainer, java.lang.Class cls, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency NbqaXzzbCJdKjOCm(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static void NbqaXzzbCJdKjOCm(com.google.firebase.components.Qualified qualified, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbqaXzzbCJdKjOCm(com.google.firebase.components.Qualified qualified, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbqaXzzbCJdKjOCm(com.google.firebase.components.Qualified qualified, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long NdvcibUIcTAozUQd() {
        if ((2 + 26) % 26 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void NdvcibUIcTAozUQd(int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NdvcibUIcTAozUQd(int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NdvcibUIcTAozUQd(java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component QATSbEOExqOjgDrm(com.google.firebase.components.Component$Builder component$Builder) {
        return component$Builder.build();
    }

    public static void QATSbEOExqOjgDrm(com.google.firebase.components.Component$Builder component$Builder, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QATSbEOExqOjgDrm(com.google.firebase.components.Component$Builder component$Builder, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QATSbEOExqOjgDrm(com.google.firebase.components.Component$Builder component$Builder, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long RGyduiQPrmBByVlp() {
        if ((10 + 9) % 9 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void RGyduiQPrmBByVlp(byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGyduiQPrmBByVlp(int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RGyduiQPrmBByVlp(java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RtKPPnNctVMIYypp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified) {
        return componentContainer[qualified);
    }

    public static void RtKPPnNctVMIYypp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RtKPPnNctVMIYypp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RtKPPnNctVMIYypp(com.google.firebase.components.ComponentContainer componentContainer, com.google.firebase.components.Qualified qualified, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Dependency TVxxysADAYuHunxJ(com.google.firebase.components.Qualified qualified) {
        return com.google.firebase.components.Dependency.required((com.google.firebase.components.Qualified<object>) qualified);
    }

    public static void TVxxysADAYuHunxJ(com.google.firebase.components.Qualified qualified, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TVxxysADAYuHunxJ(com.google.firebase.components.Qualified qualified, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TVxxysADAYuHunxJ(com.google.firebase.components.Qualified qualified, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder thGCHOzSreHsuJgT(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void ThGCHOzSreHsuJgT(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ThGCHOzSreHsuJgT(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ThGCHOzSreHsuJgT(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UrKySWoDBJLQoEBL(com.google.firebase.sessions.api.SessionSubscriber$Name sessionSubscriber$Name) {
        com.google.firebase.sessions.api.FirebaseSessionsDependencies.addDependency(sessionSubscriber$Name);
    }

    public static void UrKySWoDBJLQoEBL(com.google.firebase.sessions.api.SessionSubscriber$Name sessionSubscriber$Name, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UrKySWoDBJLQoEBL(com.google.firebase.sessions.api.SessionSubscriber$Name sessionSubscriber$Name, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UrKySWoDBJLQoEBL(com.google.firebase.sessions.api.SessionSubscriber$Name sessionSubscriber$Name, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Qualified VLZQcuYiSABJMjqU(java.lang.Class cls, java.lang.Class cls2) {
        return com.google.firebase.components.Qualified.qualified(cls, cls2);
    }

    public static void VLZQcuYiSABJMjqU(java.lang.Class cls, java.lang.Class cls2, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VLZQcuYiSABJMjqU(java.lang.Class cls, java.lang.Class cls2, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VLZQcuYiSABJMjqU(java.lang.Class cls, java.lang.Class cls2, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.components.Component$Builder yFNAFMIraEEWthHW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency) {
        return component$Builder.Add(dependency);
    }

    public static void YFNAFMIraEEWthHW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YFNAFMIraEEWthHW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YFNAFMIraEEWthHW(com.google.firebase.components.Component$Builder component$Builder, com.google.firebase.components.Dependency dependency, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override java.util.List<com.google.firebase.components.Component<object>> GetComponents() {
        if ((22 + 11) % 11 > 0) {
        }
        com.google.firebase.components.Component[] componentArr = new com.google.firebase.components.Component[2];
        componentArr[0] = qATSbEOExqOjgDrm(WiZpFJSghuhuJMkV(XLWxaydaXJMJAXab(iopBBHzEMTlttsej(eUPhUsPlRzOODymW(thGCHOzSreHsuJgT(lMgxxMWspATNpWuO(WauNcAnjbCeoPXzK(yFNAFMIraEEWthHW(IjuefukagWOYRvyw(IyfHIpvGokhOWkso(YFEqKJjQeQmfJhti(hPrCNwTmvzjGauRY(com.google.firebase.crashlytics.FirebaseCrashlytics.class), "fire-cls"), lhblKbojsSbfPkAE(com.google.firebase.FirebaseApp.class)), KOEdMSMBhaFJfFuh(com.google.firebase.installations.FirebaseInstallationsApi.class)), nbqaXzzbCJdKjOCm(this.backgroundTaskScheduler)), TnCPNchrSBkQvLft(this.blockingTaskScheduler)), tVxxysADAYuHunxJ(this.lightweightTaskScheduler)), ReTrwwgJauJtpbsE(com.google.firebase.crashlytics.internal.CrashlyticsNativeComponent.class)), YDECKFtotyGhZmNv(com.google.firebase.analytics.connector.AnalyticsConnector.class)), cRQQysnHLGKkUsXQ(com.google.firebase.remoteconfig.interop.FirebaseRemoteConfigInterop.class)), new com.google.firebase.crashlytics.CrashlyticsRegistrar$$ExternalSyntheticLambda0(this))));
        componentArr[1] = bJcYSxwymzvVbuMU("fire-cls", "19.4.2");
        return OgjeXgpOjUpnpLxf(componentArr);
    }
}

