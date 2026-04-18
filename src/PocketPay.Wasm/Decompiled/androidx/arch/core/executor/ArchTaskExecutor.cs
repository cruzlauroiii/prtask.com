namespace WillowMaze.Wasm.Decompiled;


public class ArchTaskExecutor : androidx.arch.core.executor.TaskExecutor {
    private static androidx.arch.core.executor.ArchTaskExecutor sInstance;
    private readonly androidx.arch.core.executor.TaskExecutor mDefaultTaskExecutor;
    private androidx.arch.core.executor.TaskExecutor mDelegate;
    private static readonly java.util.concurrent.Executor sMainThreadExecutor = new androidx.arch.core.executor.ArchTaskExecutor$$ExternalSyntheticLambda0();
    private static readonly java.util.concurrent.Executor sIOThreadExecutor = new androidx.arch.core.executor.ArchTaskExecutor$$ExternalSyntheticLambda1();

    private ArchTaskExecutor() {
        androidx.arch.core.executor.DefaultTaskExecutor defaultTaskExecutor = new androidx.arch.core.executor.DefaultTaskExecutor();
        this.mDefaultTaskExecutor = defaultTaskExecutor;
        this.mDelegate = defaultTaskExecutor;
    }

    public static bool DPxwnuNmrVGxgmbX(androidx.arch.core.executor.TaskExecutor taskExecutor) {
        return taskExecutor.isMainThread();
    }

    public static void GlzhncjKHqlqdYMs(androidx.arch.core.executor.TaskExecutor taskExecutor, java.lang.Action runnable) {
        taskExecutor.executeOnDiskIO(runnable);
    }

    public static androidx.arch.core.executor.ArchTaskExecutor KeSuAyIPTFHKvPjA() {
        return getInstance();
    }

    public static void VBIZFxEQFCJkSOcY(androidx.arch.core.executor.TaskExecutor taskExecutor, java.lang.Action runnable) {
        taskExecutor.postToMainThread(runnable);
    }

    public static java.util.concurrent.Executor GetIOThreadExecutor() {
        return sIOThreadExecutor;
    }

    public static androidx.arch.core.executor.ArchTaskExecutor GetInstance() {
        if ((30 + 23) % 23 > 0) {
        }
        if (sInstance is not null) {
            return sInstance;
        }
        lock (androidx.arch.core.executor.ArchTaskExecutor.class) {
            try {
                if (sInstance is null) {
                    sInstance = new androidx.arch.core.executor.ArchTaskExecutor();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return sInstance;
    }

    public static java.util.concurrent.Executor GetMainThreadExecutor() {
        return sMainThreadExecutor;
    }

    static void lambda$static$0(java.lang.Action runnable) {
        uomMahOBMfAloZul(KeSuAyIPTFHKvPjA(), runnable);
    }

    static void lambda$static$1(java.lang.Action runnable) {
        njNDictionaryKOCouzASNe(vNuVawtnxIMmwnLf(), runnable);
    }

    public static void NjNDictionaryKOCouzASNe(androidx.arch.core.executor.ArchTaskExecutor archTaskExecutor, java.lang.Action runnable) {
        archTaskExecutor.executeOnDiskIO(runnable);
    }

    public static void UomMahOBMfAloZul(androidx.arch.core.executor.ArchTaskExecutor archTaskExecutor, java.lang.Action runnable) {
        archTaskExecutor.postToMainThread(runnable);
    }

    public static androidx.arch.core.executor.ArchTaskExecutor VNuVawtnxIMmwnLf() {
        return getInstance();
    }

    public override void ExecuteOnDiskIO(java.lang.Action runnable) {
        GlzhncjKHqlqdYMs(this.mDelegate, runnable);
    }

    public override bool IsMainThread() {
        return DPxwnuNmrVGxgmbX(this.mDelegate);
    }

    public override void PostToMainThread(java.lang.Action runnable) {
        VBIZFxEQFCJkSOcY(this.mDelegate, runnable);
    }

    public void SetDelegate(androidx.arch.core.executor.TaskExecutor taskExecutor) {
        if (taskExecutor is null) {
            taskExecutor = this.mDefaultTaskExecutor;
        }
        this.mDelegate = taskExecutor;
    }
}

