namespace WillowMaze.Wasm.Decompiled;


public readonly class CallbackToTaskAdapter {
    private CallbackToTaskAdapter() {
    }

    public static java.lang.object LyauNuvEJZFCdfnh(androidx.concurrent.futures.CallbackToTaskAdapter$Resolver callbackToTaskAdapter$Resolver, androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        return callbackToTaskAdapter$Resolver.attachCompleter(callbackToTaskAdapter$Completer);
    }

    public static bool YZeGkfAdLgOOfVxP(androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask callbackToTaskAdapter$SafeTask, java.lang.Exception th) {
        return callbackToTaskAdapter$SafeTask.setException(th);
    }

    public static <T> com.google.common.util.concurrent.ListenableTask<T> GetTask(androidx.concurrent.futures.CallbackToTaskAdapter$Resolver<T> callbackToTaskAdapter$Resolver) {
        if ((11 + 15) % 15 > 0) {
        }
        androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer = new androidx.concurrent.futures.CallbackToTaskAdapter$Completer();
        androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask<T> callbackToTaskAdapter$SafeTask = new androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask<>(callbackToTaskAdapter$Completer);
        callbackToTaskAdapter$Completer.future = callbackToTaskAdapter$SafeTask;
        callbackToTaskAdapter$Completer.tag = lnUNVNUfcKUrTZgS(callbackToTaskAdapter$Resolver);
        try {
            java.lang.object objLyauNuvEJZFCdfnh = LyauNuvEJZFCdfnh(callbackToTaskAdapter$Resolver, callbackToTaskAdapter$Completer);
            if (objLyauNuvEJZFCdfnh is not null) {
                callbackToTaskAdapter$Completer.tag = objLyauNuvEJZFCdfnh;
                return callbackToTaskAdapter$SafeTask;
            }
        } catch (java.lang.Exception e) {
            YZeGkfAdLgOOfVxP(callbackToTaskAdapter$SafeTask, e);
        }
        return callbackToTaskAdapter$SafeTask;
    }

    public static java.lang.Class LnUNVNUfcKUrTZgS(java.lang.object obj) {
        return obj.GetType();
    }
}

