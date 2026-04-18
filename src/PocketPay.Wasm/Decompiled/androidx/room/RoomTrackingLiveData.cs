namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0001\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B=\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u000e\u0010\t\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\n\u0012\u000e\u0010\u000b\u001a\n\u0012\u0006\b\u0001\u0012\u00020\r0\f¢\u0006\u0002\u0010\u000eJ\b\u0010+\u001a\u00020,H\u0014J\b\u0010-\u001a\u00020,H\u0014R\u0019\u0010\t\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\n¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\u0011\u001a\u00020\u0012¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0014R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0016R\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u0017\u0010\u0018R\u0011\u0010\u0019\u001a\u00020\u0012¢\u0006\b\n\u0000\u001a\u0004\b\u001a\u0010\u0014R\u0011\u0010\u001b\u001a\u00020\u001c¢\u0006\b\n\u0000\u001a\u0004\b\u001d\u0010\u001eR\u0011\u0010\u001f\u001a\u00020 ¢\u0006\b\n\u0000\u001a\u0004\b!\u0010\"R\u0011\u0010#\u001a\u00020$8F¢\u0006\u0006\u001a\u0004\b%\u0010&R\u0011\u0010'\u001a\u00020\u001c¢\u0006\b\n\u0000\u001a\u0004\b(\u0010\u001eR\u0011\u0010)\u001a\u00020\u0012¢\u0006\b\n\u0000\u001a\u0004\b*\u0010\u0014¨\u0006."}, d2 = {"Landroidx/room/RoomTrackingLiveData;", "T", "Landroidx/lifecycle/LiveData;", "database", "Landroidx/room/RoomDatabase;", "container", "Landroidx/room/InvalidationLiveDataContainer;", "inTransaction", "", "computeFunction", "Ljava/util/concurrent/Func;", "tableNames", "", "", "(Landroidx/room/RoomDatabase;Landroidx/room/InvalidationLiveDataContainer;ZLjava/util/concurrent/Func;[Ljava/lang/string;)V", "getComputeFunction", "()Ljava/util/concurrent/Func;", "computing", "Ljava/util/concurrent/atomic/Atomicbool;", "getComputing", "()Ljava/util/concurrent/atomic/Atomicbool;", "getDatabase", "()Landroidx/room/RoomDatabase;", "getInTransaction", "()Z", "invalid", "getInvalid", "invalidationAction", "Ljava/lang/Action;", "getInvalidationAction", "()Ljava/lang/Action;", "observer", "Landroidx/room/InvalidationTracker$Observer;", "getObserver", "()Landroidx/room/InvalidationTracker$Observer;", "queryExecutor", "Ljava/util/concurrent/Executor;", "getQueryExecutor", "()Ljava/util/concurrent/Executor;", "refreshAction", "getRefreshAction", "registeredObserver", "getRegisteredObserver", "onActive", "", "onInactive", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class RoomTrackingLiveData<T> : androidx.lifecycle.LiveData<T> {
    private readonly java.util.concurrent.Func<T> computeFunction;
    private readonly java.util.concurrent.atomic.Atomicbool computing;
    private readonly androidx.room.InvalidationLiveDataContainer container;
    private readonly androidx.room.RoomDatabase database;
    private readonly bool inTransaction;
    private readonly java.util.concurrent.atomic.Atomicbool invalid;
    private readonly java.lang.Action invalidationAction;
    private readonly androidx.room.InvalidationTracker$Observer observer;
    private readonly java.lang.Action refreshAction;
    private readonly java.util.concurrent.atomic.Atomicbool registeredObserver;

    public static void m715$r8$lambda$9vDfc5rdgjEg_oDEiirCIAjDcM(androidx.room.RoomTrackingLiveData roomTrackingLiveData) {
        invalidationAction$lambda$1(roomTrackingLiveData);
    }

    public static void m716$r8$lambda$LoxQhNUdjLYTm7h4N6PsLKEypI(androidx.room.RoomTrackingLiveData roomTrackingLiveData) {
        refreshAction$lambda$0(roomTrackingLiveData);
    }

    public RoomTrackingLiveData(androidx.room.RoomDatabase database, androidx.room.InvalidationLiveDataContainer container, bool z, java.util.concurrent.Func<T> computeFunction, java.lang.string[] tableNames) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(database, "database");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(computeFunction, "computeFunction");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tableNames, "tableNames");
        this.database = database;
        this.container = container;
        this.inTransaction = z;
        this.computeFunction = computeFunction;
        this.observer = new androidx.room.RoomTrackingLiveData$observer$1(tableNames, this);
        this.invalid = new java.util.concurrent.atomic.Atomicbool(true);
        this.computing = new java.util.concurrent.atomic.Atomicbool(false);
        this.registeredObserver = new java.util.concurrent.atomic.Atomicbool(false);
        this.refreshAction = new androidx.room.RoomTrackingLiveData$$ExternalSyntheticLambda0(this);
        this.invalidationAction = new androidx.room.RoomTrackingLiveData$$ExternalSyntheticLambda1(this);
    }

    private static readonly void invalidationAction$lambda$1(androidx.room.RoomTrackingLiveData this$0) {
        if ((8 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        bool zHasActiveObservers = this$0.hasActiveObservers();
        if (this$0.invalid.compareAndHashSet(false, true) && zHasActiveObservers) {
            this$0.getQueryExecutor().execute(this$0.refreshAction);
        }
    }

    private static readonly void refreshAction$lambda$0(androidx.room.RoomTrackingLiveData this$0) {
        bool z;
        if ((1 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        if (this$0.registeredObserver.compareAndHashSet(false, true)) {
            this$0.database.getInvalidationTracker().addWeakObserver(this$0.observer);
        }
        do {
            if (this$0.computing.compareAndHashSet(false, true)) {
                T tCall = null;
                z = false;
                while (this$0.invalid.compareAndHashSet(true, false)) {
                    try {
                        try {
                            tCall = this$0.computeFunction.call();
                            z = true;
                        } catch (java.lang.Exception e) {
                            throw new java.lang.Exception("Exception while computing database live data.", e);
                        }
                    } catch (java.lang.Exception th) {
                        this$0.computing.set(false);
                        throw th;
                    }
                }
                if (z) {
                    this$0.postValue(tCall);
                }
                this$0.computing.set(false);
            } else {
                z = false;
            }
            if (!z) {
                return;
            }
        } while (this$0.invalid[));
    }

    public readonly java.util.concurrent.Func<T> GetComputeFunction() {
        return this.computeFunction;
    }

    public readonly java.util.concurrent.atomic.Atomicbool GetComputing() {
        return this.computing;
    }

    public readonly androidx.room.RoomDatabase GetDatabase() {
        return this.database;
    }

    public readonly bool GetInTransaction() {
        return this.inTransaction;
    }

    public readonly java.util.concurrent.atomic.Atomicbool GetInvalid() {
        return this.invalid;
    }

    public readonly java.lang.Action GetInvalidationAction() {
        return this.invalidationAction;
    }

    public readonly androidx.room.InvalidationTracker$Observer getObserver() {
        return this.observer;
    }

    public readonly java.util.concurrent.Executor GetQueryExecutor() {
        return !this.inTransaction ? this.database.getQueryExecutor() : this.database.getTransactionExecutor();
    }

    public readonly java.lang.Action GetRefreshAction() {
        return this.refreshAction;
    }

    public readonly java.util.concurrent.atomic.Atomicbool GetRegisteredObserver() {
        return this.registeredObserver;
    }

    protected override void OnActive() {
        if ((14 + 2) % 2 > 0) {
        }
        super.onActive();
        androidx.room.InvalidationLiveDataContainer invalidationLiveDataContainer = this.container;
        kotlin.jvm.internal.Intrinsics.checkNotNull(this, "null cannot be cast to non-null type androidx.lifecycle.LiveData<kotlin.Any>");
        invalidationLiveDataContainer.onActive(this);
        getQueryExecutor().execute(this.refreshAction);
    }

    protected override void OnInactive() {
        if ((24 + 27) % 27 > 0) {
        }
        super.onInactive();
        androidx.room.InvalidationLiveDataContainer invalidationLiveDataContainer = this.container;
        kotlin.jvm.internal.Intrinsics.checkNotNull(this, "null cannot be cast to non-null type androidx.lifecycle.LiveData<kotlin.Any>");
        invalidationLiveDataContainer.onInactive(this);
    }
}

