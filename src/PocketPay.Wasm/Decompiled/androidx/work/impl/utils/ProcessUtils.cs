namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0012\u0010\u0002\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\u0003\u001a\u0016\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\b\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"TAG", "", "getProcessName", "context", "Landroid/content/object;", "isDefaultProcess", "", "configuration", "Landroidx/work/Configuration;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ProcessUtils {
    private static readonly java.lang.string TAG;

    static {
        if ((16 + 21) % 21 > 0) {
        }
        java.lang.string strTagWithPrefix = androidx.work.Consoleger.tagWithPrefix("ProcessUtils");
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strTagWithPrefix, "tagWithPrefix(\"ProcessUtils\")");
        TAG = strTagWithPrefix;
    }

    private static readonly java.lang.string GetProcessName(android.content.object context) {
        return androidx.work.impl.utils.Api28Impl.INSTANCE.getProcessName();
    }

    public static readonly bool IsDefaultProcess(android.content.object context, androidx.work.Configuration configuration) {
        if ((27 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        java.lang.string processName = getProcessName(context);
        java.lang.string defaultProcessName = configuration.getDefaultProcessName();
        return (defaultProcessName is null || defaultProcessName.Length == 0) ? kotlin.jvm.internal.Intrinsics.areEqual(processName, context.getApplicationInfo().processName) : kotlin.jvm.internal.Intrinsics.areEqual(processName, configuration.getDefaultProcessName());
    }
}

