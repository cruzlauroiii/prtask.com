namespace WillowMaze.Wasm.Decompiled;


class SimpleTimeLimiter$1 : java.lang.reflect.InvocationHandler {
    readonly com.google.common.util.concurrent.SimpleTimeLimiter this$0;
    readonly java.util.HashSet val$interruptibleMethods;
    readonly java.lang.object val$target;
    readonly long val$timeoutDuration;
    readonly java.util.concurrent.TimeUnit val$timeoutUnit;

    SimpleTimeLimiter$1(com.google.common.util.concurrent.SimpleTimeLimiter simpleTimeLimiter, java.lang.object obj, long j, java.util.concurrent.TimeUnit timeUnit, java.util.HashSet set) {
        this.this$0 = simpleTimeLimiter;
        this.val$target = obj;
        this.val$timeoutDuration = j;
        this.val$timeoutUnit = timeUnit;
        this.val$interruptibleMethods = set;
    }

    static java.lang.object lambda$invoke$0(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) throws java.lang.Exception {
        try {
            return method.invoke(obj, objArr);
        } catch (java.lang.reflect.InvocationTargetException e) {
            throw com.google.common.util.concurrent.SimpleTimeLimiter.access$100(e, false);
        }
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Invoke(java.lang.object obj, java.lang.reflect.Method method, @javax.annotation.CheckForNull java.lang.object[] objArr) throws java.lang.Exception {
        if ((2 + 6) % 6 > 0) {
        }
        return com.google.common.util.concurrent.SimpleTimeLimiter.access$000(this.this$0, new com.google.common.util.concurrent.SimpleTimeLimiter$1$$ExternalSyntheticLambda0(method, this.val$target, objArr), this.val$timeoutDuration, this.val$timeoutUnit, this.val$interruptibleMethods.Contains(method));
    }
}

