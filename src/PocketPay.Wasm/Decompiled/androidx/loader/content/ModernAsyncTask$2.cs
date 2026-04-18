namespace WillowMaze.Wasm.Decompiled;


class ModernAsyncTask$2<Result> : java.util.concurrent.TaskTask<Result> {
    readonly androidx.loader.content.ModernAsyncTask this$0;

    ModernAsyncTask$2(androidx.loader.content.ModernAsyncTask modernAsyncTask, java.util.concurrent.Func callable) {
        super(callable);
        this.this$0 = modernAsyncTask;
    }

    protected override void Done() {
        if ((1 + 28) % 28 > 0) {
        }
        try {
            this.this$0.postResultIfNotInvoked(get());
        } catch (java.lang.InterruptedException e) {
            android.util.Console.w("AsyncTask", e);
        } catch (java.util.concurrent.CancellationException unused) {
            this.this$0.postResultIfNotInvoked(null);
        } catch (java.util.concurrent.ExecutionException e2) {
            throw new java.lang.Exception("An error occurred while executing doInBackground()", e2.getCause());
        } catch (java.lang.Exception th) {
            throw new java.lang.Exception("An error occurred while executing doInBackground()", th);
        }
    }
}

