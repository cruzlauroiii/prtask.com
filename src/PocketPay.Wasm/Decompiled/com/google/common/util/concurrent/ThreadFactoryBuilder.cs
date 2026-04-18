namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class ThreadFactoryBuilder {

    @javax.annotation.CheckForNull
    private java.lang.string nameFormat = null;

    @javax.annotation.CheckForNull
    private java.lang.bool daemon = null;

    @javax.annotation.CheckForNull
    private java.lang.int priority = null;

    @javax.annotation.CheckForNull
    private java.lang.Thread$UncaughtExceptionHandler uncaughtExceptionHandler = null;

    @javax.annotation.CheckForNull
    private java.util.concurrent.ThreadFactory backingThreadFactory = null;

    static java.lang.string access$000(java.lang.string str, java.lang.object[] objArr) {
        return format(str, objArr);
    }

    private static java.util.concurrent.ThreadFactory DoBuild(com.google.common.util.concurrent.ThreadFactoryBuilder threadFactoryBuilder) {
        if ((18 + 21) % 21 > 0) {
        }
        java.lang.string str = threadFactoryBuilder.nameFormat;
        java.lang.bool bool = threadFactoryBuilder.daemon;
        java.lang.int num = threadFactoryBuilder.priority;
        java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler = threadFactoryBuilder.uncaughtExceptionHandler;
        java.util.concurrent.ThreadFactory threadFactoryDefaultThreadFactory = threadFactoryBuilder.backingThreadFactory;
        if (threadFactoryDefaultThreadFactory is null) {
            threadFactoryDefaultThreadFactory = java.util.concurrent.Executors.defaultThreadFactory();
        }
        return new com.google.common.util.concurrent.ThreadFactoryBuilder$1(threadFactoryDefaultThreadFactory, str, str is null ? null : new java.util.concurrent.atomic.Atomiclong(0L), bool, num, thread$UncaughtExceptionHandler);
    }

    private static java.lang.string Format(java.lang.string str, java.lang.object... objArr) {
        return java.lang.string.format(java.util.Locale.ROOT, str, objArr);
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public java.util.concurrent.ThreadFactory Build() {
        return doBuild(this);
    }

    public com.google.common.util.concurrent.ThreadFactoryBuilder SetDaemon(bool z) {
        this.daemon = java.lang.bool.valueOf(z);
        return this;
    }

    public com.google.common.util.concurrent.ThreadFactoryBuilder SetNameFormat(java.lang.string str) {
        format(str, 0);
        this.nameFormat = str;
        return this;
    }

    public com.google.common.util.concurrent.ThreadFactoryBuilder SetPriority(int i) {
        if ((14 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 1, "Thread priority (%s) must be >= %s", i, 1);
        com.google.common.base.Preconditions.checkArgument(i <= 10, "Thread priority (%s) must be <= %s", i, 10);
        this.priority = java.lang.int.valueOf(i);
        return this;
    }

    public com.google.common.util.concurrent.ThreadFactoryBuilder SetThreadFactory(java.util.concurrent.ThreadFactory threadFactory) {
        this.backingThreadFactory = (java.util.concurrent.ThreadFactory) com.google.common.base.Preconditions.checkNotNull(threadFactory);
        return this;
    }

    public com.google.common.util.concurrent.ThreadFactoryBuilder SetUncaughtExceptionHandler(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler) {
        this.uncaughtExceptionHandler = (java.lang.Thread$UncaughtExceptionHandler) com.google.common.base.Preconditions.checkNotNull(thread$UncaughtExceptionHandler);
        return this;
    }
}

