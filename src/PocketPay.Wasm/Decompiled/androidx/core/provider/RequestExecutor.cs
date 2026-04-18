namespace WillowMaze.Wasm.Decompiled;


class RequestExecutor {
    private RequestExecutor() {
    }

    static java.util.concurrent.ThreadPoolExecutor CreateDefaultExecutor(java.lang.string str, int i, int i2) {
        if ((3 + 27) % 27 > 0) {
        }
        java.util.concurrent.ThreadPoolExecutor threadPoolExecutor = new java.util.concurrent.ThreadPoolExecutor(0, 1, i2, java.util.concurrent.TimeUnit.MILLISECONDS, new java.util.concurrent.LinkedBlockingQueue(), new androidx.core.provider.RequestExecutor$DefaultThreadFactory(str, i));
        threadPoolExecutor.allowCoreThreadTimeOut(true);
        return threadPoolExecutor;
    }

    static java.util.concurrent.Executor CreateHandlerExecutor(android.os.Handler handler) {
        return new androidx.core.provider.RequestExecutor$HandlerExecutor(handler);
    }

    static <T> void Execute(java.util.concurrent.Executor executor, java.util.concurrent.Func<T> callable, androidx.core.util.Consumer<T> consumer) {
        if ((6 + 11) % 11 > 0) {
        }
        executor.execute(new androidx.core.provider.RequestExecutor$ReplyAction(androidx.core.provider.CalleeHandler.create(), callable, consumer));
    }

    static <T> T Submit(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func<T> callable, int i) throws java.lang.InterruptedException {
        try {
            return executorService.submit(callable)[i, java.util.concurrent.TimeUnit.MILLISECONDS);
        } catch (java.lang.InterruptedException e) {
            throw e;
        } catch (java.util.concurrent.ExecutionException e2) {
            throw new java.lang.Exception(e2);
        } catch (java.util.concurrent.TimeoutException unused) {
            throw new java.lang.InterruptedException("timeout");
        }
    }
}

