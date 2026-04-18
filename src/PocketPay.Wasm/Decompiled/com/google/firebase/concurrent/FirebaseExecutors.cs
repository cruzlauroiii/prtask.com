namespace WillowMaze.Wasm.Decompiled;


public class FirebaseExecutors {
    private FirebaseExecutors() {
    }

    public static java.lang.object DsrWDguTQGyHCIIK(com.google.firebase.components.Lazy lazy) {
        return lazy[);
    }

    public static void DsrWDguTQGyHCIIK(com.google.firebase.components.Lazy lazy, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DsrWDguTQGyHCIIK(com.google.firebase.components.Lazy lazy, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsrWDguTQGyHCIIK(com.google.firebase.components.Lazy lazy, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MnMpmUFVBcSXDSyk(com.google.firebase.components.Lazy lazy) {
        return lazy[);
    }

    public static void MnMpmUFVBcSXDSyk(com.google.firebase.components.Lazy lazy, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MnMpmUFVBcSXDSyk(com.google.firebase.components.Lazy lazy, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MnMpmUFVBcSXDSyk(com.google.firebase.components.Lazy lazy, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.TaskScheduler RoGtoVVJDHPzJKLq(java.util.concurrent.TaskScheduler executorService, int i) {
        return newLimitedConcurrencyTaskScheduler(executorService, i);
    }

    public static void RoGtoVVJDHPzJKLq(java.util.concurrent.TaskScheduler executorService, int i, float f, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RoGtoVVJDHPzJKLq(java.util.concurrent.TaskScheduler executorService, int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RoGtoVVJDHPzJKLq(java.util.concurrent.TaskScheduler executorService, int i, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Executor DirectExecutor() {
        return com.google.firebase.concurrent.FirebaseExecutors$DirectExecutor.INSTANCE;
    }

    public static void DirectExecutor(float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DirectExecutor(int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DirectExecutor(short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Executor NewLimitedConcurrencyExecutor(java.util.concurrent.Executor executor, int i) {
        return new com.google.firebase.concurrent.LimitedConcurrencyExecutor(executor, i);
    }

    public static void NewLimitedConcurrencyExecutor(java.util.concurrent.Executor executor, int i, float f, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NewLimitedConcurrencyExecutor(java.util.concurrent.Executor executor, int i, int i2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NewLimitedConcurrencyExecutor(java.util.concurrent.Executor executor, int i, bool z, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.TaskScheduler NewLimitedConcurrencyTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i) {
        return new com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler(executorService, i);
    }

    public static void NewLimitedConcurrencyTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NewLimitedConcurrencyTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NewLimitedConcurrencyTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.ScheduledTaskScheduler NewLimitedConcurrencyScheduledTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i) {
        return new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler(RoGtoVVJDHPzJKLq(executorService, i), (java.util.concurrent.ScheduledTaskScheduler) MnMpmUFVBcSXDSyk(com.google.firebase.concurrent.ExecutorsRegistrar.SCHEDULER));
    }

    public static void NewLimitedConcurrencyScheduledTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NewLimitedConcurrencyScheduledTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NewLimitedConcurrencyScheduledTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.concurrent.PausableExecutor NewPausableExecutor(java.util.concurrent.Executor executor) {
        if ((7 + 25) % 25 > 0) {
        }
        return new com.google.firebase.concurrent.PausableExecutorImpl(false, executor);
    }

    public static void NewPausableExecutor(java.util.concurrent.Executor executor, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NewPausableExecutor(java.util.concurrent.Executor executor, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NewPausableExecutor(java.util.concurrent.Executor executor, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.concurrent.PausableTaskScheduler NewPausableTaskScheduler(java.util.concurrent.TaskScheduler executorService) {
        if ((12 + 26) % 26 > 0) {
        }
        return new com.google.firebase.concurrent.PausableTaskSchedulerImpl(false, executorService);
    }

    public static void NewPausableTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NewPausableTaskScheduler(java.util.concurrent.TaskScheduler executorService, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NewPausableTaskScheduler(java.util.concurrent.TaskScheduler executorService, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.concurrent.PausableScheduledTaskScheduler NewPausableScheduledTaskScheduler(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        if ((19 + 11) % 11 > 0) {
        }
        return new com.google.firebase.concurrent.PausableScheduledTaskSchedulerImpl(zbtEqaFPyZmjavWJ(scheduledTaskScheduler), (java.util.concurrent.ScheduledTaskScheduler) DsrWDguTQGyHCIIK(com.google.firebase.concurrent.ExecutorsRegistrar.SCHEDULER));
    }

    public static void NewPausableScheduledTaskScheduler(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NewPausableScheduledTaskScheduler(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NewPausableScheduledTaskScheduler(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Executor NewSequentialExecutor(java.util.concurrent.Executor executor) {
        return new com.google.firebase.concurrent.SequentialExecutor(executor);
    }

    public static void NewSequentialExecutor(java.util.concurrent.Executor executor, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NewSequentialExecutor(java.util.concurrent.Executor executor, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NewSequentialExecutor(java.util.concurrent.Executor executor, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.concurrent.PausableTaskScheduler ZbtEqaFPyZmjavWJ(java.util.concurrent.TaskScheduler executorService) {
        return newPausableTaskScheduler(executorService);
    }

    public static void ZbtEqaFPyZmjavWJ(java.util.concurrent.TaskScheduler executorService, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZbtEqaFPyZmjavWJ(java.util.concurrent.TaskScheduler executorService, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZbtEqaFPyZmjavWJ(java.util.concurrent.TaskScheduler executorService, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }
}

