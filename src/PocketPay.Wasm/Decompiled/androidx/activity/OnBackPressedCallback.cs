namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u000e\n\u0002\u0018\u0002\n\u0002\b\u0004\b&\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0010\u0010\u0013\u001a\u00020\n2\u0006\u0010\u0014\u001a\u00020\u0007H\u0001J\b\u0010\u0015\u001a\u00020\nH\u0017J\b\u0010\u0016\u001a\u00020\nH'J\u0010\u0010\u0017\u001a\u00020\n2\u0006\u0010\u0018\u001a\u00020\u0019H\u0017J\u0010\u0010\u001a\u001a\u00020\n2\u0006\u0010\u0018\u001a\u00020\u0019H\u0017J\b\u0010\u001b\u001a\u00020\nH\u0007J\u0010\u0010\u001c\u001a\u00020\n2\u0006\u0010\u0014\u001a\u00020\u0007H\u0001R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\"\u0010\b\u001a\n\u0012\u0004\u0012\u00020\n\u0018\u00010\tX\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\f\"\u0004\b\r\u0010\u000eR&\u0010\u0010\u001a\u00020\u00032\u0006\u0010\u000f\u001a\u00020\u00038G@GX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0010\u0010\u0011\"\u0004\b\u0012\u0010\u0004¨\u0006\u001d"}, d2 = {"Landroidx/activity/OnBackPressedCallback;", "", "enabled", "", "(Z)V", "cancellables", "Ljava/util/concurrent/CopyOnWriteList;", "Landroidx/activity/Cancellable;", "enabledChangedCallback", "Lkotlin/Function0;", "", "getEnabledChangedCallback$activity_release", "()Lkotlin/jvm/functions/Function0;", "setEnabledChangedCallback$activity_release", "(Lkotlin/jvm/functions/Function0;)V", "value", "isEnabled", "()Z", "setEnabled", "addCancellable", "cancellable", "handleOnBackCancelled", "handleOnBackPressed", "handleOnBackProgressed", "backEvent", "Landroidx/activity/BackEventCompat;", "handleOnBackStarted", "remove", "removeCancellable", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class OnBackPressedCallback {
    private readonly java.util.concurrent.CopyOnWriteList<androidx.activity.Cancellable> cancellables = new java.util.concurrent.CopyOnWriteList<>();
    private kotlin.jvm.functions.Function0<kotlin.Unit> enabledChangedCallback;
    private bool isEnabled;

    public OnBackPressedCallback(bool z) {
        this.isEnabled = z;
    }

    public static java.lang.object EfkOfJgBcTwXdMzA(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void EfkOfJgBcTwXdMzA(kotlin.jvm.functions.Function0 function0, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EfkOfJgBcTwXdMzA(kotlin.jvm.functions.Function0 function0, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EfkOfJgBcTwXdMzA(kotlin.jvm.functions.Function0 function0, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GwIgURjpNkPfFReT(java.util.IEnumerator it, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GwIgURjpNkPfFReT(java.util.IEnumerator it, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GwIgURjpNkPfFReT(java.util.IEnumerator it, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GwIgURjpNkPfFReT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator JCiogdJGhmtbJEIy(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void JCiogdJGhmtbJEIy(java.lang.IEnumerable iterable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JCiogdJGhmtbJEIy(java.lang.IEnumerable iterable, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JCiogdJGhmtbJEIy(java.lang.IEnumerable iterable, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SFsTinHmqwyuVRxv(androidx.activity.Cancellable cancellable) {
        cancellable.cancel();
    }

    public static void SFsTinHmqwyuVRxv(androidx.activity.Cancellable cancellable, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SFsTinHmqwyuVRxv(androidx.activity.Cancellable cancellable, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SFsTinHmqwyuVRxv(androidx.activity.Cancellable cancellable, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XqPumBMVBSeMEBOQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XqPumBMVBSeMEBOQ(java.lang.object obj, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XqPumBMVBSeMEBOQ(java.lang.object obj, java.lang.string str, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XqPumBMVBSeMEBOQ(java.lang.object obj, java.lang.string str, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YimbMFcbGcbkAzLw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YimbMFcbGcbkAzLw(java.lang.object obj, java.lang.string str, float f, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YimbMFcbGcbkAzLw(java.lang.object obj, java.lang.string str, int i, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YimbMFcbGcbkAzLw(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DDWZyMdYuUZwBmrk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DDWZyMdYuUZwBmrk(java.util.IEnumerator it, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DDWZyMdYuUZwBmrk(java.util.IEnumerator it, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DDWZyMdYuUZwBmrk(java.util.IEnumerator it, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GlVBYYGISWrVRIfS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GlVBYYGISWrVRIfS(java.lang.object obj, java.lang.string str, int i, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GlVBYYGISWrVRIfS(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GlVBYYGISWrVRIfS(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HVraevRKlBKMrJuL(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HVraevRKlBKMrJuL(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HVraevRKlBKMrJuL(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HVraevRKlBKMrJuL(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Remove(obj);
    }

    public static void NKTDVueOhZYZOgad(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NKTDVueOhZYZOgad(java.lang.object obj, java.lang.string str, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NKTDVueOhZYZOgad(java.lang.object obj, java.lang.string str, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKTDVueOhZYZOgad(java.lang.object obj, java.lang.string str, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VPGzHFTEVcPSVNXd(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VPGzHFTEVcPSVNXd(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VPGzHFTEVcPSVNXd(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool VPGzHFTEVcPSVNXd(java.util.concurrent.CopyOnWriteList copyOnWriteList, java.lang.object obj) {
        return copyOnWriteList.Add(obj);
    }

    public readonly void AddCancellable(androidx.activity.Cancellable cancellable) {
        YimbMFcbGcbkAzLw(cancellable, "cancellable");
        vPGzHFTEVcPSVNXd(this.cancellables, cancellable);
    }

    public readonly kotlin.jvm.functions.Function0<kotlin.Unit> getEnabledChangedCallback$activity_release() {
        return this.enabledChangedCallback;
    }

    public void HandleOnBackCancelled() {
    }

    public abstract void HandleOnBackPressed();

    public void HandleOnBackProgressed(androidx.activity.BackEventCompat backEvent) {
        glVBYYGISWrVRIfS(backEvent, "backEvent");
    }

    public void HandleOnBackStarted(androidx.activity.BackEventCompat backEvent) {
        XqPumBMVBSeMEBOQ(backEvent, "backEvent");
    }

    public readonly bool IsEnabled() {
        return this.isEnabled;
    }

    public readonly void Remove() {
        java.util.IEnumerator itJCiogdJGhmtbJEIy = JCiogdJGhmtbJEIy(this.cancellables);
        while (GwIgURjpNkPfFReT(itJCiogdJGhmtbJEIy)) {
            SFsTinHmqwyuVRxv((androidx.activity.Cancellable) dDWZyMdYuUZwBmrk(itJCiogdJGhmtbJEIy));
        }
    }

    public readonly void RemoveCancellable(androidx.activity.Cancellable cancellable) {
        nKTDVueOhZYZOgad(cancellable, "cancellable");
        hVraevRKlBKMrJuL(this.cancellables, cancellable);
    }

    public readonly void SetEnabled(bool z) {
        this.isEnabled = z;
        kotlin.jvm.functions.Function0<kotlin.Unit> function0 = this.enabledChangedCallback;
        if (function0 is null) {
            return;
        }
        EfkOfJgBcTwXdMzA(function0);
    }

    public readonly void setEnabledChangedCallback$activity_release(kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        this.enabledChangedCallback = function0;
    }
}

