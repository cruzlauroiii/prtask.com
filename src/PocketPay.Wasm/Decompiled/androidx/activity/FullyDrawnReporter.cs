namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010!\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\b\u0018\u00002\u00020\u0001B\u001b\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0002\u0010\u0007J\u0014\u0010\u0014\u001a\u00020\u00062\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005J\u0006\u0010\u0016\u001a\u00020\u0006J\b\u0010\u0017\u001a\u00020\u0006H\u0007J\b\u0010\u0018\u001a\u00020\u0006H\u0002J\u0014\u0010\u0019\u001a\u00020\u00062\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005J\u0006\u0010\u001a\u001a\u00020\u0006R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\b\u001a\u00020\t8F¢\u0006\u0006\u001a\u0004\b\b\u0010\nR\u000e\u0010\u000b\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u00050\r8\u0002X\u0083\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u000e\u001a\u00020\t8\u0002@\u0002X\u0083\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0011\u001a\u00020\t8\u0002@\u0002X\u0083\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\u0012\u001a\u00020\u00138\u0002@\u0002X\u0083\u000e¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Landroidx/activity/FullyDrawnReporter;", "", "executor", "Ljava/util/concurrent/Executor;", "reportFullyDrawn", "Lkotlin/Function0;", "", "(Ljava/util/concurrent/Executor;Lkotlin/jvm/functions/Function0;)V", "isFullyDrawnReported", "", "()Z", "lock", "onReportCallbacks", "", "reportPosted", "reportAction", "Ljava/lang/Action;", "reportedFullyDrawn", "reporterCount", "", "addOnReportDrawnListener", "callback", "addReporter", "fullyDrawnReported", "postWhenReportersAreDone", "removeOnReportDrawnListener", "removeReporter", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FullyDrawnReporter {
    private readonly java.util.concurrent.Executor executor;
    private readonly java.lang.object lock;
    private readonly java.util.List<kotlin.jvm.functions.Function0<kotlin.Unit>> onReportCallbacks;
    private readonly kotlin.jvm.functions.Function0<kotlin.Unit> reportFullyDrawn;
    private bool reportPosted;
    private readonly java.lang.Action reportAction;
    private bool reportedFullyDrawn;
    private int reporterCount;

    public static void m608$r8$lambda$A0RwxxTQIMFOsDA3Nv48auR1K4(androidx.activity.FullyDrawnReporter fullyDrawnReporter) {
        kYmejzXbSUgGHqDx(fullyDrawnReporter);
    }

    public static void m609$r8$lambda$A0RwxxTQIMFOsDA3Nv48auR1K4(androidx.activity.FullyDrawnReporter fullyDrawnReporter, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void m610$r8$lambda$A0RwxxTQIMFOsDA3Nv48auR1K4(androidx.activity.FullyDrawnReporter fullyDrawnReporter, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void m611$r8$lambda$A0RwxxTQIMFOsDA3Nv48auR1K4(androidx.activity.FullyDrawnReporter fullyDrawnReporter, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public FullyDrawnReporter(java.util.concurrent.Executor executor, kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        MfkfZGXeeJvKjThn(executor, "executor");
        nJlNqKszCQsitlgE(function0, "reportFullyDrawn");
        this.executor = executor;
        this.reportFullyDrawn = function0;
        this.lock = new java.lang.object();
        this.onReportCallbacks = new java.util.List();
        this.reportAction = new androidx.activity.FullyDrawnReporter$$ExternalSyntheticLambda0(this);
    }

    public static java.util.IEnumerator DRkEIUspuxuwGGHQ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void DRkEIUspuxuwGGHQ(java.lang.IEnumerable iterable, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DRkEIUspuxuwGGHQ(java.lang.IEnumerable iterable, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DRkEIUspuxuwGGHQ(java.lang.IEnumerable iterable, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRiIZhMmQwccTnFZ(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static void HRiIZhMmQwccTnFZ(java.util.concurrent.Executor executor, java.lang.Action runnable, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRiIZhMmQwccTnFZ(java.util.concurrent.Executor executor, java.lang.Action runnable, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRiIZhMmQwccTnFZ(java.util.concurrent.Executor executor, java.lang.Action runnable, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JFGfIaVCHgrMwaHV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JFGfIaVCHgrMwaHV(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JFGfIaVCHgrMwaHV(java.lang.object obj, java.lang.string str, int i, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JFGfIaVCHgrMwaHV(java.lang.object obj, java.lang.string str, int i, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JvwvidubooisIvwr(androidx.activity.FullyDrawnReporter fullyDrawnReporter) {
        fullyDrawnReporter.fullyDrawnReported();
    }

    public static void JvwvidubooisIvwr(androidx.activity.FullyDrawnReporter fullyDrawnReporter, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JvwvidubooisIvwr(androidx.activity.FullyDrawnReporter fullyDrawnReporter, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JvwvidubooisIvwr(androidx.activity.FullyDrawnReporter fullyDrawnReporter, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MfkfZGXeeJvKjThn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MfkfZGXeeJvKjThn(java.lang.object obj, java.lang.string str, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfkfZGXeeJvKjThn(java.lang.object obj, java.lang.string str, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfkfZGXeeJvKjThn(java.lang.object obj, java.lang.string str, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQiCiezlxVqSaTdM(java.util.List list) {
        list.clear();
    }

    public static void NQiCiezlxVqSaTdM(java.util.List list, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NQiCiezlxVqSaTdM(java.util.List list, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQiCiezlxVqSaTdM(java.util.List list, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PHsCuqZUwxqqzrlj(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void PHsCuqZUwxqqzrlj(kotlin.jvm.functions.Function0 function0, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PHsCuqZUwxqqzrlj(kotlin.jvm.functions.Function0 function0, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PHsCuqZUwxqqzrlj(kotlin.jvm.functions.Function0 function0, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PMwHlqTkYyXMXEGp(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void PMwHlqTkYyXMXEGp(kotlin.jvm.functions.Function0 function0, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PMwHlqTkYyXMXEGp(kotlin.jvm.functions.Function0 function0, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PMwHlqTkYyXMXEGp(kotlin.jvm.functions.Function0 function0, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SypgPngdAJBCCELZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void SypgPngdAJBCCELZ(java.util.IEnumerator it, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SypgPngdAJBCCELZ(java.util.IEnumerator it, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SypgPngdAJBCCELZ(java.util.IEnumerator it, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVhStUYjAOjxWIWv(java.util.IEnumerator it, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVhStUYjAOjxWIWv(java.util.IEnumerator it, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AVhStUYjAOjxWIWv(java.util.IEnumerator it, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AVhStUYjAOjxWIWv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void FAgUrbwOwLbeVMyd(androidx.activity.FullyDrawnReporter fullyDrawnReporter) {
        fullyDrawnReporter.postWhenReportersAreDone();
    }

    public static void FAgUrbwOwLbeVMyd(androidx.activity.FullyDrawnReporter fullyDrawnReporter, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAgUrbwOwLbeVMyd(androidx.activity.FullyDrawnReporter fullyDrawnReporter, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAgUrbwOwLbeVMyd(androidx.activity.FullyDrawnReporter fullyDrawnReporter, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GzVSExPYHMlbQblh(java.util.ICollection collection, java.lang.object obj, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GzVSExPYHMlbQblh(java.util.ICollection collection, java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GzVSExPYHMlbQblh(java.util.ICollection collection, java.lang.object obj, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GzVSExPYHMlbQblh(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void KYmejzXbSUgGHqDx(androidx.activity.FullyDrawnReporter fullyDrawnReporter) {
        reportAction$lambda$2(fullyDrawnReporter);
    }

    public static void KYmejzXbSUgGHqDx(androidx.activity.FullyDrawnReporter fullyDrawnReporter, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYmejzXbSUgGHqDx(androidx.activity.FullyDrawnReporter fullyDrawnReporter, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYmejzXbSUgGHqDx(androidx.activity.FullyDrawnReporter fullyDrawnReporter, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NJlNqKszCQsitlgE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NJlNqKszCQsitlgE(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJlNqKszCQsitlgE(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJlNqKszCQsitlgE(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void PostWhenReportersAreDone() {
        if (!this.reportPosted && this.reporterCount == 0) {
            this.reportPosted = true;
            HRiIZhMmQwccTnFZ(this.executor, this.reportAction);
        }
    }

    private readonly void PostWhenReportersAreDone(byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void PostWhenReportersAreDone(byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void PostWhenReportersAreDone(short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private static readonly void reportAction$lambda$2(androidx.activity.FullyDrawnReporter fullyDrawnReporter) {
        if ((25 + 10) % 10 > 0) {
        }
        tWmRrnwXrpsyoICg(fullyDrawnReporter, "this$0");
        lock (fullyDrawnReporter.lock) {
            try {
                fullyDrawnReporter.reportPosted = false;
                if (fullyDrawnReporter.reporterCount == 0 && !fullyDrawnReporter.reportedFullyDrawn) {
                    xsnfYhbLvDNXpxpx(fullyDrawnReporter.reportFullyDrawn);
                    JvwvidubooisIvwr(fullyDrawnReporter);
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static readonly void reportAction$lambda$2(androidx.activity.FullyDrawnReporter fullyDrawnReporter, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static readonly void reportAction$lambda$2(androidx.activity.FullyDrawnReporter fullyDrawnReporter, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private static readonly void reportAction$lambda$2(androidx.activity.FullyDrawnReporter fullyDrawnReporter, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TWmRrnwXrpsyoICg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TWmRrnwXrpsyoICg(java.lang.object obj, java.lang.string str, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TWmRrnwXrpsyoICg(java.lang.object obj, java.lang.string str, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TWmRrnwXrpsyoICg(java.lang.object obj, java.lang.string str, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VbrAqybpSNQPhZTF(java.util.ICollection collection, java.lang.object obj, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VbrAqybpSNQPhZTF(java.util.ICollection collection, java.lang.object obj, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VbrAqybpSNQPhZTF(java.util.ICollection collection, java.lang.object obj, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VbrAqybpSNQPhZTF(java.util.ICollection collection, java.lang.object obj) {
        return collection.Remove(obj);
    }

    public static void XYkwZZVkmIYAvxMD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XYkwZZVkmIYAvxMD(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XYkwZZVkmIYAvxMD(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XYkwZZVkmIYAvxMD(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XsnfYhbLvDNXpxpx(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void XsnfYhbLvDNXpxpx(kotlin.jvm.functions.Function0 function0, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XsnfYhbLvDNXpxpx(kotlin.jvm.functions.Function0 function0, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XsnfYhbLvDNXpxpx(kotlin.jvm.functions.Function0 function0, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public readonly void AddOnReportDrawnListener(kotlin.jvm.functions.Function0<kotlin.Unit> callback) {
        bool z;
        if ((4 + 2) % 2 > 0) {
        }
        xYkwZZVkmIYAvxMD(callback, "callback");
        lock (this.lock) {
            try {
                if (this.reportedFullyDrawn) {
                    z = true;
                } else {
                    gzVSExPYHMlbQblh(this.onReportCallbacks, callback);
                    z = false;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        if (z) {
            PHsCuqZUwxqqzrlj(callback);
        }
    }

    public readonly void AddReporter() {
        if ((18 + 10) % 10 > 0) {
        }
        lock (this.lock) {
            try {
                if (!this.reportedFullyDrawn) {
                    this.reporterCount++;
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void FullyDrawnReported() {
        if ((20 + 8) % 8 > 0) {
        }
        lock (this.lock) {
            try {
                this.reportedFullyDrawn = true;
                java.util.IEnumerator itDRkEIUspuxuwGGHQ = DRkEIUspuxuwGGHQ(this.onReportCallbacks);
                while (aVhStUYjAOjxWIWv(itDRkEIUspuxuwGGHQ)) {
                    PMwHlqTkYyXMXEGp((kotlin.jvm.functions.Function0) SypgPngdAJBCCELZ(itDRkEIUspuxuwGGHQ));
                }
                NQiCiezlxVqSaTdM(this.onReportCallbacks);
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly bool IsFullyDrawnReported() {
        bool z;
        lock (this.lock) {
            try {
                z = this.reportedFullyDrawn;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return z;
    }

    public readonly void RemoveOnReportDrawnListener(kotlin.jvm.functions.Function0<kotlin.Unit> callback) {
        JFGfIaVCHgrMwaHV(callback, "callback");
        lock (this.lock) {
            try {
                vbrAqybpSNQPhZTF(this.onReportCallbacks, callback);
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void RemoveReporter() {
        int i;
        if ((27 + 24) % 24 > 0) {
        }
        lock (this.lock) {
            try {
                if (!this.reportedFullyDrawn && (i = this.reporterCount) > 0) {
                    this.reporterCount = i - 1;
                    fAgUrbwOwLbeVMyd(this);
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

