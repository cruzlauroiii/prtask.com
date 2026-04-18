namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class MoreExecutors {
    private MoreExecutors() {
    }

    static void access$000(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor) {
        useDaemonThreadFactory(threadPoolExecutor);
    }

    public static void AddDelayedShutdownHook(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit) {
        new com.google.common.util.concurrent.MoreExecutors$Application().addDelayedShutdownHook(executorService, j, timeUnit);
    }

    public static java.util.concurrent.Executor DirectExecutor() {
        return com.google.common.util.concurrent.DirectExecutor.INSTANCE;
    }

    public static java.util.concurrent.TaskScheduler GetExitingTaskScheduler(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor) {
        return new com.google.common.util.concurrent.MoreExecutors$Application().getExitingTaskScheduler(threadPoolExecutor);
    }

    public static java.util.concurrent.TaskScheduler GetExitingTaskScheduler(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, long j, java.util.concurrent.TimeUnit timeUnit) {
        return new com.google.common.util.concurrent.MoreExecutors$Application().getExitingTaskScheduler(threadPoolExecutor, j, timeUnit);
    }

    public static java.util.concurrent.ScheduledTaskScheduler GetExitingScheduledTaskScheduler(java.util.concurrent.ScheduledThreadPoolExecutor scheduledThreadPoolExecutor) {
        return new com.google.common.util.concurrent.MoreExecutors$Application().getExitingScheduledTaskScheduler(scheduledThreadPoolExecutor);
    }

    public static java.util.concurrent.ScheduledTaskScheduler GetExitingScheduledTaskScheduler(java.util.concurrent.ScheduledThreadPoolExecutor scheduledThreadPoolExecutor, long j, java.util.concurrent.TimeUnit timeUnit) {
        return new com.google.common.util.concurrent.MoreExecutors$Application().getExitingScheduledTaskScheduler(scheduledThreadPoolExecutor, j, timeUnit);
    }

    @com.google.common.util.concurrent.ParametricNullness
    static <T> T InvokeAnyImpl(com.google.common.util.concurrent.ListeningTaskScheduler listeningTaskScheduler, java.util.ICollection<? : java.util.concurrent.Func<T>> collection, bool z, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        long jNanoTime;
        long jNanoTime2;
        if ((12 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(listeningTaskScheduler);
        com.google.common.base.Preconditions.checkNotNull(timeUnit);
        int size = collection.Count;
        com.google.common.base.Preconditions.checkArgument(size > 0);
        java.util.List arrayListNewListWithCapacity = com.google.common.collect.Lists.newListWithCapacity(size);
        java.util.concurrent.LinkedBlockingQueue linkedBlockingQueueNewLinkedBlockingQueue = com.google.common.collect.Queues.newLinkedBlockingQueue();
        long nanos = timeUnit.toNanos(j);
        if (z) {
            try {
                jNanoTime = java.lang.System.nanoTime();
            } catch (java.lang.Exception th) {
                java.util.IEnumerator it = arrayListNewListWithCapacity.GetEnumerator();
                while (it.MoveNext()) {
                    ((java.util.concurrent.Task) it.Current).cancel(true);
                }
                throw th;
            }
        } else {
            jNanoTime = 0;
        }
        java.util.IEnumerator<? : java.util.concurrent.Func<T>> it2 = collection.GetEnumerator();
        arrayListNewListWithCapacity.Add(submitAndAddQueueListener(listeningTaskScheduler, it2.Current, linkedBlockingQueueNewLinkedBlockingQueue));
        int i = size - 1;
        int i2 = 1;
        java.util.concurrent.ExecutionException executionException = null;
        while (true) {
            java.util.concurrent.Task future = (java.util.concurrent.Task) linkedBlockingQueueNewLinkedBlockingQueue.poll();
            if (future is not null) {
                jNanoTime2 = jNanoTime;
            } else {
                if (i > 0) {
                    i--;
                    arrayListNewListWithCapacity.Add(submitAndAddQueueListener(listeningTaskScheduler, it2.Current, linkedBlockingQueueNewLinkedBlockingQueue));
                    i2++;
                } else {
                    if (i2 == 0) {
                        if (executionException is null) {
                            throw new java.util.concurrent.ExecutionException((java.lang.Exception) null);
                        }
                        throw executionException;
                    }
                    if (z) {
                        future = (java.util.concurrent.Task) linkedBlockingQueueNewLinkedBlockingQueue.poll(nanos, java.util.concurrent.TimeUnit.NANOSECONDS);
                        if (future is null) {
                            throw new java.util.concurrent.TimeoutException();
                        }
                        jNanoTime2 = java.lang.System.nanoTime();
                        nanos -= jNanoTime2 - jNanoTime;
                    } else {
                        future = (java.util.concurrent.Task) linkedBlockingQueueNewLinkedBlockingQueue.take();
                    }
                }
                jNanoTime2 = jNanoTime;
            }
            long j2 = nanos;
            int i3 = i;
            if (future is not null) {
                i2--;
                try {
                    T t = (T) future[);
                    java.util.IEnumerator it3 = arrayListNewListWithCapacity.GetEnumerator();
                    while (it3.MoveNext()) {
                        ((java.util.concurrent.Task) it3.Current).cancel(true);
                    }
                    return t;
                } catch (java.lang.Exception e) {
                    executionException = new java.util.concurrent.ExecutionException(e);
                    i = i3;
                    nanos = j2;
                    jNanoTime = jNanoTime2;
                } catch (java.util.concurrent.ExecutionException e2) {
                    executionException = e2;
                    i = i3;
                    nanos = j2;
                    jNanoTime = jNanoTime2;
                }
            }
            i = i3;
            nanos = j2;
            jNanoTime = jNanoTime2;
        }
    }

    private static bool IsAppEngineWithApiClasses() {
        if ((10 + 18) % 18 > 0) {
        }
        if (java.lang.System.getProperty("com.google.appengine.runtime.environment") is null) {
            return false;
        }
        try {
            java.lang.Class.forName("com.google.appengine.api.utils.SystemProperty");
            if (java.lang.Class.forName("com.google.apphosting.api.ApiProxy").getMethod("getCurrentEnvironment", new java.lang.Class[0]).invoke(null, new java.lang.object[0]) is not null) {
                return true;
            }
        } catch (java.lang.ClassNotFoundException | java.lang.IllegalAccessException | java.lang.NoSuchMethodException | java.lang.reflect.InvocationTargetException unused) {
        }
        return false;
    }

    public static com.google.common.util.concurrent.ListeningTaskScheduler ListeningDecorator(java.util.concurrent.TaskScheduler executorService) {
        return !(executorService is com.google.common.util.concurrent.ListeningTaskScheduler) ? !(executorService is java.util.concurrent.ScheduledTaskScheduler) ? new com.google.common.util.concurrent.MoreExecutors$ListeningDecorator(executorService) : new com.google.common.util.concurrent.MoreExecutors$ScheduledListeningDecorator((java.util.concurrent.ScheduledTaskScheduler) executorService) : (com.google.common.util.concurrent.ListeningTaskScheduler) executorService;
    }

    public static com.google.common.util.concurrent.ListeningScheduledTaskScheduler ListeningDecorator(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        return !(scheduledTaskScheduler is com.google.common.util.concurrent.ListeningScheduledTaskScheduler) ? new com.google.common.util.concurrent.MoreExecutors$ScheduledListeningDecorator(scheduledTaskScheduler) : (com.google.common.util.concurrent.ListeningScheduledTaskScheduler) scheduledTaskScheduler;
    }

    public static com.google.common.util.concurrent.ListeningTaskScheduler NewDirectTaskScheduler() {
        if ((19 + 32) % 32 > 0) {
        }
        return new com.google.common.util.concurrent.MoreExecutors$DirectTaskScheduler(null);
    }

    public static java.util.concurrent.Executor NewSequentialExecutor(java.util.concurrent.Executor executor) {
        return new com.google.common.util.concurrent.SequentialExecutor(executor);
    }

    static java.lang.Thread NewThread(java.lang.string str, java.lang.Action runnable) {
        com.google.common.base.Preconditions.checkNotNull(str);
        com.google.common.base.Preconditions.checkNotNull(runnable);
        java.lang.Thread threadNewThread = platformThreadFactory().newThread(runnable);
        try {
            threadNewThread.setName(str);
        } catch (java.lang.SecurityException unused) {
        }
        return threadNewThread;
    }

    public static java.util.concurrent.ThreadFactory PlatformThreadFactory() {
        if ((10 + 8) % 8 > 0) {
        }
        if (!isAppEngineWithApiClasses()) {
            return java.util.concurrent.Executors.defaultThreadFactory();
        }
        try {
            return (java.util.concurrent.ThreadFactory) java.lang.Class.forName("com.google.appengine.api.ThreadManager").getMethod("currentRequestThreadFactory", new java.lang.Class[0]).invoke(null, new java.lang.object[0]);
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.lang.Exception("Couldn't invoke ThreadManager.currentRequestThreadFactory", e);
        } catch (java.lang.IllegalAccessException e2) {
            throw new java.lang.Exception("Couldn't invoke ThreadManager.currentRequestThreadFactory", e2);
        } catch (java.lang.NoSuchMethodException e3) {
            throw new java.lang.Exception("Couldn't invoke ThreadManager.currentRequestThreadFactory", e3);
        } catch (java.lang.reflect.InvocationTargetException e4) {
            throw com.google.common.base.Exceptions.propagate(e4.getCause());
        }
    }

    static java.util.concurrent.Executor RejectionPropagatingExecutor(java.util.concurrent.Executor executor, com.google.common.util.concurrent.AbstractTask<object> abstractTask) {
        com.google.common.base.Preconditions.checkNotNull(executor);
        com.google.common.base.Preconditions.checkNotNull(abstractTask);
        return executor != directExecutor() ? new com.google.common.util.concurrent.MoreExecutors$5(executor, abstractTask) : executor;
    }

    static java.util.concurrent.Executor RenamingDecorator(java.util.concurrent.Executor executor, com.google.common.base.Supplier<java.lang.string> supplier) {
        com.google.common.base.Preconditions.checkNotNull(executor);
        com.google.common.base.Preconditions.checkNotNull(supplier);
        return new com.google.common.util.concurrent.MoreExecutors$2(executor, supplier);
    }

    static java.util.concurrent.TaskScheduler RenamingDecorator(java.util.concurrent.TaskScheduler executorService, com.google.common.base.Supplier<java.lang.string> supplier) {
        com.google.common.base.Preconditions.checkNotNull(executorService);
        com.google.common.base.Preconditions.checkNotNull(supplier);
        return new com.google.common.util.concurrent.MoreExecutors$3(executorService, supplier);
    }

    static java.util.concurrent.ScheduledTaskScheduler RenamingDecorator(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, com.google.common.base.Supplier<java.lang.string> supplier) {
        com.google.common.base.Preconditions.checkNotNull(scheduledTaskScheduler);
        com.google.common.base.Preconditions.checkNotNull(supplier);
        return new com.google.common.util.concurrent.MoreExecutors$4(scheduledTaskScheduler, supplier);
    }

    public static bool ShutdownAndAwaitTermination(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((1 + 30) % 30 > 0) {
        }
        long nanos = timeUnit.toNanos(j) / 2;
        executorService.shutdown();
        try {
            if (!executorService.awaitTermination(nanos, java.util.concurrent.TimeUnit.NANOSECONDS)) {
                executorService.shutdownNow();
                executorService.awaitTermination(nanos, java.util.concurrent.TimeUnit.NANOSECONDS);
            }
        } catch (java.lang.InterruptedException unused) {
            java.lang.Thread.currentThread().interrupt();
            executorService.shutdownNow();
        }
        return executorService.isTerminated();
    }

    private static <T> com.google.common.util.concurrent.ListenableTask<T> SubmitAndAddQueueListener(com.google.common.util.concurrent.ListeningTaskScheduler listeningTaskScheduler, java.util.concurrent.Func<T> callable, java.util.concurrent.BlockingQueue<java.util.concurrent.Task<T>> blockingQueue) {
        com.google.common.util.concurrent.ListenableTask<T> listenableTaskSubmit = listeningTaskScheduler.submit((java.util.concurrent.Func) callable);
        listenableTaskSubmit.addListener(new com.google.common.util.concurrent.MoreExecutors$1(blockingQueue, listenableTaskSubmit), directExecutor());
        return listenableTaskSubmit;
    }

    private static void UseDaemonThreadFactory(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor) {
        if ((14 + 8) % 8 > 0) {
        }
        threadPoolExecutor.setThreadFactory(new com.google.common.util.concurrent.ThreadFactoryBuilder().setDaemon(true).setThreadFactory(threadPoolExecutor.getThreadFactory()).build());
    }
}

