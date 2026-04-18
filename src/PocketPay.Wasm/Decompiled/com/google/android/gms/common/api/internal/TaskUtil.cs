namespace WillowMaze.Wasm.Decompiled;


public class TaskUtil {
    public static void DcEECUklJaTiLZpA(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static bool FCormRPfyqXmXXno(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static void PmXrpVuDaqqwsGyZ(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static bool RUyiyPErENFFvAxY(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return tryHashSetResultOrApiException(status, obj, taskCompletionSource);
    }

    public static com.google.android.gms.tasks.Task TZXoEnxMhovKJpbI(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWith(continuation);
    }

    public static bool ZfAQRhlYhwBHBHNy(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static bool AcvFHItWseMrqhLg(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public static com.google.android.gms.common.api.ApiException CfLGWFkgxpEfVYfu(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }

    public static bool KcyGqcTMLedVKrno(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static void LxpQtIVqDLFpndpF(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void SetResultOrApiException(com.google.android.gms.common.api.Status status, com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> taskCompletionSource) {
        vLaezKLjtIrhsQxe(status, null, taskCompletionSource);
    }

    public static <ResultT> void SetResultOrApiException(com.google.android.gms.common.api.Status status, ResultT resultt, com.google.android.gms.tasks.TaskCompletionSource<ResultT> taskCompletionSource) {
        if (ZfAQRhlYhwBHBHNy(status)) {
            PmXrpVuDaqqwsGyZ(taskCompletionSource, resultt);
        } else {
            lxpQtIVqDLFpndpF(taskCompletionSource, zWeGDVadqmibNeER(status));
        }
    }

    public static <ResultT> void SetResultOrApiException(com.google.android.gms.common.api.Status status, ResultT resultt, com.google.android.gms.tasks.TaskCompletionSource<ResultT> taskCompletionSource, com.google.android.gms.common.api.ApiMetadata apiMetadata) {
        DcEECUklJaTiLZpA(status, resultt, taskCompletionSource);
    }

    @java.lang.Deprecated
    public static com.google.android.gms.tasks.Task<java.lang.void> TovoidTaskThatFailsOnFalse(com.google.android.gms.tasks.Task<java.lang.bool> task) {
        return TZXoEnxMhovKJpbI(task, new com.google.android.gms.common.api.internal.zacu());
    }

    public static <ResultT> bool TryHashSetResultOrApiException(com.google.android.gms.common.api.Status status, ResultT resultt, com.google.android.gms.tasks.TaskCompletionSource<ResultT> taskCompletionSource) {
        return !acvFHItWseMrqhLg(status) ? kcyGqcTMLedVKrno(taskCompletionSource, cfLGWFkgxpEfVYfu(status)) : FCormRPfyqXmXXno(taskCompletionSource, resultt);
    }

    public static <ResultT> bool TryHashSetResultOrApiException(com.google.android.gms.common.api.Status status, ResultT resultt, com.google.android.gms.tasks.TaskCompletionSource<ResultT> taskCompletionSource, com.google.android.gms.common.api.ApiMetadata apiMetadata) {
        return RUyiyPErENFFvAxY(status, resultt, taskCompletionSource);
    }

    public static void VLaezKLjtIrhsQxe(com.google.android.gms.common.api.Status status, java.lang.object obj, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        setResultOrApiException(status, obj, taskCompletionSource);
    }

    public static com.google.android.gms.common.api.ApiException ZWeGDVadqmibNeER(com.google.android.gms.common.api.Status status) {
        return com.google.android.gms.common.internal.ApiExceptionUtil.fromStatus(status);
    }
}

