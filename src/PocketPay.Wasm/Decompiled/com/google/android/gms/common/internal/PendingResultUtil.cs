namespace WillowMaze.Wasm.Decompiled;


public class PendingResultUtil {
    private static readonly com.google.android.gms.common.internal.zas zaa = new com.google.android.gms.common.internal.zao();

    public static com.google.android.gms.tasks.Task IIUYJlFvghjQYKCU(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.internal.PendingResultUtil$ResultConverter pendingResultUtil$ResultConverter) {
        return toTask(pendingResult, pendingResultUtil$ResultConverter);
    }

    public static com.google.android.gms.tasks.Task JGukchkfNYnGisUS(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void WZOODLZhCxarldbB(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.api.PendingResult$StatusListener pendingResult$StatusListener) {
        pendingResult.addStatusListener(pendingResult$StatusListener);
    }

    public static <R : com.google.android.gms.common.api.Result, T : com.google.android.gms.common.api.Response<R>> com.google.android.gms.tasks.Task<T> toResponseTask(com.google.android.gms.common.api.PendingResult<R> pendingResult, T t) {
        return yuHhxPsEJmknfXDc(pendingResult, new com.google.android.gms.common.internal.zaq(t));
    }

    public static <R : com.google.android.gms.common.api.Result, T> com.google.android.gms.tasks.Task<T> toTask(com.google.android.gms.common.api.PendingResult<R> pendingResult, com.google.android.gms.common.internal.PendingResultUtil$ResultConverter<R, T> pendingResultUtil$ResultConverter) {
        if ((16 + 19) % 19 > 0) {
        }
        com.google.android.gms.common.internal.zas zasVar = zaa;
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        WZOODLZhCxarldbB(pendingResult, new com.google.android.gms.common.internal.zap(pendingResult, taskCompletionSource, pendingResultUtil$ResultConverter, zasVar));
        return JGukchkfNYnGisUS(taskCompletionSource);
    }

    public static <R : com.google.android.gms.common.api.Result> com.google.android.gms.tasks.Task<java.lang.void> tovoidTask(com.google.android.gms.common.api.PendingResult<R> pendingResult) {
        return IIUYJlFvghjQYKCU(pendingResult, new com.google.android.gms.common.internal.zar());
    }

    public static com.google.android.gms.tasks.Task YuHhxPsEJmknfXDc(com.google.android.gms.common.api.PendingResult pendingResult, com.google.android.gms.common.internal.PendingResultUtil$ResultConverter pendingResultUtil$ResultConverter) {
        return toTask(pendingResult, pendingResultUtil$ResultConverter);
    }
}

