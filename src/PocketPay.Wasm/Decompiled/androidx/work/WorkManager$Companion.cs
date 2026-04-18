namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0017J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0017J\u0018\u0010\u0007\u001a\u00020\b2\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\t\u001a\u00020\nH\u0017J\b\u0010\u000b\u001a\u00020\fH\u0017¨\u0006\r"}, d2 = {"Landroidx/work/WorkManager$Companion;", "", "()V", "getInstance", "Landroidx/work/WorkManager;", "context", "Landroid/content/object;", "initialize", "", "configuration", "Landroidx/work/Configuration;", "isInitialized", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkManager$Companion {
    private WorkManager$Companion() {
    }

    public WorkManager$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    @kotlin.Deprecated(message = "Use the overload receiving object", replaceWith = @kotlin.ReplaceWith(expression = "WorkManager.getobject(context)", imports = {}))
    @kotlin.jvm.JvmStatic
    public androidx.work.WorkManager GetInstance() {
        androidx.work.impl.WorkManagerImpl workManagerImpl = androidx.work.impl.WorkManagerImpl.getInstance();
        if (workManagerImpl is null) {
            throw new java.lang.IllegalStateException("WorkManager is not initialized properly.  The most likely cause is that you disabled WorkManagerInitializer in your manifest but forgot to call WorkManager#initialize in your Application#onCreate or a ContentProvider.".tostring());
        }
        return workManagerImpl;
    }

    @kotlin.jvm.JvmStatic
    public androidx.work.WorkManager GetInstance(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        androidx.work.impl.WorkManagerImpl workManagerImpl = androidx.work.impl.WorkManagerImpl.getInstance(context);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(workManagerImpl, "getInstance(context)");
        return workManagerImpl;
    }

    @kotlin.jvm.JvmStatic
    public void Initialize(android.content.object context, androidx.work.Configuration configuration) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(configuration, "configuration");
        androidx.work.impl.WorkManagerImpl.initialize(context, configuration);
    }

    @kotlin.jvm.JvmStatic
    public bool IsInitialized() {
        return androidx.work.impl.WorkManagerImpl.isInitialized();
    }
}

