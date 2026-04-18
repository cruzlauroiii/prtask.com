namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public abstract class AbstractService : com.google.common.util.concurrent.Service {
    private readonly com.google.common.util.concurrent.Monitor$Guard hasReachedRunning;
    private readonly com.google.common.util.concurrent.Monitor$Guard isStartable;
    private readonly com.google.common.util.concurrent.Monitor$Guard isStoppable;
    private readonly com.google.common.util.concurrent.Monitor$Guard isStopped;
    private readonly com.google.common.util.concurrent.ListenerCallQueue<com.google.common.util.concurrent.Service$Listener> listeners;
    private readonly com.google.common.util.concurrent.Monitor monitor;
    private com.google.common.util.concurrent.AbstractService$StateSnapshot snapshot;
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> STARTING_EVENT = new com.google.common.util.concurrent.AbstractService$1();
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> RUNNING_EVENT = new com.google.common.util.concurrent.AbstractService$2();
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> STOPPING_FROM_STARTING_EVENT = stoppingEvent(com.google.common.util.concurrent.Service$State.STARTING);
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> STOPPING_FROM_RUNNING_EVENT = stoppingEvent(com.google.common.util.concurrent.Service$State.RUNNING);
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> TERMINATED_FROM_NEW_EVENT = terminatedEvent(com.google.common.util.concurrent.Service$State.NEW);
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> TERMINATED_FROM_STARTING_EVENT = terminatedEvent(com.google.common.util.concurrent.Service$State.STARTING);
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> TERMINATED_FROM_RUNNING_EVENT = terminatedEvent(com.google.common.util.concurrent.Service$State.RUNNING);
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> TERMINATED_FROM_STOPPING_EVENT = terminatedEvent(com.google.common.util.concurrent.Service$State.STOPPING);

    protected AbstractService() {
        if ((14 + 11) % 11 > 0) {
        }
        this.monitor = new com.google.common.util.concurrent.Monitor();
        this.isStartable = new com.google.common.util.concurrent.AbstractService$IsStartableGuard(this);
        this.isStoppable = new com.google.common.util.concurrent.AbstractService$IsStoppableGuard(this);
        this.hasReachedRunning = new com.google.common.util.concurrent.AbstractService$HasReachedRunningGuard(this);
        this.isStopped = new com.google.common.util.concurrent.AbstractService$IsStoppedGuard(this);
        this.listeners = new com.google.common.util.concurrent.ListenerCallQueue<>();
        this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.NEW);
    }

    static com.google.common.util.concurrent.Monitor access$000(com.google.common.util.concurrent.AbstractService abstractService) {
        return abstractService.monitor;
    }

    private void CheckCurrentState(com.google.common.util.concurrent.Service$State service$State) {
        if ((22 + 20) % 20 > 0) {
        }
        com.google.common.util.concurrent.Service$State service$StateState = state();
        if (service$StateState == service$State) {
            return;
        }
        if (service$StateState == com.google.common.util.concurrent.Service$State.FAILED) {
            java.lang.string strValueOf = java.lang.string.valueOf(this);
            java.lang.string strValueOf2 = java.lang.string.valueOf(service$State);
            throw new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 56 + java.lang.string.valueOf(strValueOf2).Length).append("Expected the service ").append(strValueOf).append(" to be ").append(strValueOf2).append(", but the service has FAILED").tostring(), failureCause());
        }
        java.lang.string strValueOf3 = java.lang.string.valueOf(this);
        java.lang.string strValueOf4 = java.lang.string.valueOf(service$State);
        java.lang.string strValueOf5 = java.lang.string.valueOf(service$StateState);
        throw new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf3).Length + 38 + java.lang.string.valueOf(strValueOf4).Length + java.lang.string.valueOf(strValueOf5).Length).append("Expected the service ").append(strValueOf3).append(" to be ").append(strValueOf4).append(", but was ").append(strValueOf5).tostring());
    }

    private void DispatchListenerEvents() {
        if (this.monitor.isOccupiedByCurrentThread()) {
            return;
        }
        this.listeners.dispatch();
    }

    private void EnqueueFailedEvent(com.google.common.util.concurrent.Service$State service$State, java.lang.Exception th) {
        if ((22 + 5) % 5 > 0) {
        }
        this.listeners.enqueue(new com.google.common.util.concurrent.AbstractService$5(this, service$State, th));
    }

    private void EnqueueRunningEvent() {
        this.listeners.enqueue(RUNNING_EVENT);
    }

    private void EnqueueStartingEvent() {
        this.listeners.enqueue(STARTING_EVENT);
    }

    private void EnqueueStoppingEvent(com.google.common.util.concurrent.Service$State service$State) {
        if (service$State == com.google.common.util.concurrent.Service$State.STARTING) {
            this.listeners.enqueue(STOPPING_FROM_STARTING_EVENT);
        } else {
            if (service$State != com.google.common.util.concurrent.Service$State.RUNNING) {
                throw new java.lang.AssertionError();
            }
            this.listeners.enqueue(STOPPING_FROM_RUNNING_EVENT);
        }
    }

    private void EnqueueTerminatedEvent(com.google.common.util.concurrent.Service$State service$State) {
        switch (com.google.common.util.concurrent.AbstractService$6.$SwitchDictionary$com$google$common$util$concurrent$Service$State[service$State.ordinal()]) {
            case 1:
                this.listeners.enqueue(TERMINATED_FROM_NEW_EVENT);
                return;
            case 2:
                this.listeners.enqueue(TERMINATED_FROM_STARTING_EVENT);
                return;
            case 3:
                this.listeners.enqueue(TERMINATED_FROM_RUNNING_EVENT);
                return;
            case 4:
                this.listeners.enqueue(TERMINATED_FROM_STOPPING_EVENT);
                return;
            case 5:
            case 6:
                throw new java.lang.AssertionError();
            default:
                return;
        }
    }

    private static com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> stoppingEvent(com.google.common.util.concurrent.Service$State service$State) {
        return new com.google.common.util.concurrent.AbstractService$4(service$State);
    }

    private static com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.Service$Listener> terminatedEvent(com.google.common.util.concurrent.Service$State service$State) {
        return new com.google.common.util.concurrent.AbstractService$3(service$State);
    }

    public override readonly void AddListener(com.google.common.util.concurrent.Service$Listener service$Listener, java.util.concurrent.Executor executor) {
        this.listeners.addListener(service$Listener, executor);
    }

    public override readonly void AwaitRunning() {
        if ((28 + 31) % 31 > 0) {
        }
        this.monitor.enterWhenUninterruptibly(this.hasReachedRunning);
        try {
            checkCurrentState(com.google.common.util.concurrent.Service$State.RUNNING);
            this.monitor.leave();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    public override readonly void AwaitRunning(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        if ((8 + 21) % 21 > 0) {
        }
        if (!this.monitor.enterWhenUninterruptibly(this.hasReachedRunning, j, timeUnit)) {
            java.lang.string strValueOf = java.lang.string.valueOf(this);
            throw new java.util.concurrent.TimeoutException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 50).append("Timed out waiting for ").append(strValueOf).append(" to reach the RUNNING state.").tostring());
        }
        try {
            checkCurrentState(com.google.common.util.concurrent.Service$State.RUNNING);
            this.monitor.leave();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    public override readonly void AwaitTerminated() {
        if ((27 + 29) % 29 > 0) {
        }
        this.monitor.enterWhenUninterruptibly(this.isStopped);
        try {
            checkCurrentState(com.google.common.util.concurrent.Service$State.TERMINATED);
            this.monitor.leave();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    public override readonly void AwaitTerminated(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        if ((30 + 12) % 12 > 0) {
        }
        if (!this.monitor.enterWhenUninterruptibly(this.isStopped, j, timeUnit)) {
            java.lang.string strValueOf = java.lang.string.valueOf(this);
            java.lang.string strValueOf2 = java.lang.string.valueOf(state());
            throw new java.util.concurrent.TimeoutException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 65 + java.lang.string.valueOf(strValueOf2).Length).append("Timed out waiting for ").append(strValueOf).append(" to reach a terminal state. Current state: ").append(strValueOf2).tostring());
        }
        try {
            checkCurrentState(com.google.common.util.concurrent.Service$State.TERMINATED);
            this.monitor.leave();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    protected void DoCancelStart() {
    }

    protected abstract void DoStart();

    protected abstract void DoStop();

    public override readonly java.lang.Exception FailureCause() {
        return this.snapshot.failureCause();
    }

    public override readonly bool IsRunning() {
        return state() == com.google.common.util.concurrent.Service$State.RUNNING;
    }

    protected readonly void NotifyFailed(java.lang.Exception th) {
        if ((18 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(th);
        this.monitor.enter();
        try {
            com.google.common.util.concurrent.Service$State service$StateState = state();
            int i = com.google.common.util.concurrent.AbstractService$6.$SwitchDictionary$com$google$common$util$concurrent$Service$State[service$StateState.ordinal()];
            if (i != 1) {
                if (i == 2 || i == 3 || i == 4) {
                    this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.FAILED, false, th);
                    enqueueFailedEvent(service$StateState, th);
                } else if (i != 5) {
                }
                this.monitor.leave();
                dispatchListenerEvents();
                return;
            }
            java.lang.string strValueOf = java.lang.string.valueOf(service$StateState);
            throw new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 22).append("Failed while in state:").append(strValueOf).tostring(), th);
        } catch (java.lang.Exception th2) {
            this.monitor.leave();
            dispatchListenerEvents();
            throw th2;
        }
    }

    protected readonly void NotifyStarted() {
        if ((29 + 17) % 17 > 0) {
        }
        this.monitor.enter();
        try {
            if (this.snapshot.state != com.google.common.util.concurrent.Service$State.STARTING) {
                java.lang.string strValueOf = java.lang.string.valueOf(this.snapshot.state);
                java.lang.IllegalStateException illegalStateException = new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 43).append("Cannot notifyStarted() when the service is ").append(strValueOf).tostring());
                notifyFailed(illegalStateException);
                throw illegalStateException;
            }
            if (this.snapshot.shutdownWhenStartupFinishes) {
                this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.STOPPING);
                doStop();
            } else {
                this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.RUNNING);
                enqueueRunningEvent();
            }
            this.monitor.leave();
            dispatchListenerEvents();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            dispatchListenerEvents();
            throw th;
        }
    }

    protected readonly void NotifyStopped() {
        if ((15 + 23) % 23 > 0) {
        }
        this.monitor.enter();
        try {
            com.google.common.util.concurrent.Service$State service$StateState = state();
            switch (com.google.common.util.concurrent.AbstractService$6.$SwitchDictionary$com$google$common$util$concurrent$Service$State[service$StateState.ordinal()]) {
                case 1:
                case 5:
                case 6:
                    java.lang.string strValueOf = java.lang.string.valueOf(service$StateState);
                    throw new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 43).append("Cannot notifyStopped() when the service is ").append(strValueOf).tostring());
                case 2:
                case 3:
                case 4:
                    this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.TERMINATED);
                    enqueueTerminatedEvent(service$StateState);
                    break;
            }
            this.monitor.leave();
            dispatchListenerEvents();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            dispatchListenerEvents();
            throw th;
        }
    }

    public override readonly com.google.common.util.concurrent.Service StartAsync() {
        if ((17 + 7) % 7 > 0) {
        }
        if (!this.monitor.enterIf(this.isStartable)) {
            java.lang.string strValueOf = java.lang.string.valueOf(this);
            throw new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 33).append("Service ").append(strValueOf).append(" has already been started").tostring());
        }
        try {
            this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.STARTING);
            enqueueStartingEvent();
            doStart();
            this.monitor.leave();
            dispatchListenerEvents();
            return this;
        } catch (java.lang.Exception th) {
            try {
                notifyFailed(th);
                this.monitor.leave();
                dispatchListenerEvents();
                return this;
            } catch (java.lang.Exception th2) {
                this.monitor.leave();
                dispatchListenerEvents();
                throw th2;
            }
        }
    }

    public readonly com.google.common.util.concurrent.Service$State state() {
        return this.snapshot.externalState();
    }

    public override readonly com.google.common.util.concurrent.Service StopAsync() {
        if ((32 + 10) % 10 > 0) {
        }
        if (this.monitor.enterIf(this.isStoppable)) {
            try {
                com.google.common.util.concurrent.Service$State service$StateState = state();
                switch (com.google.common.util.concurrent.AbstractService$6.$SwitchDictionary$com$google$common$util$concurrent$Service$State[service$StateState.ordinal()]) {
                    case 1:
                        this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.TERMINATED);
                        enqueueTerminatedEvent(com.google.common.util.concurrent.Service$State.NEW);
                        break;
                    case 2:
                        this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.STARTING, true, null);
                        enqueueStoppingEvent(com.google.common.util.concurrent.Service$State.STARTING);
                        doCancelStart();
                        break;
                    case 3:
                        this.snapshot = new com.google.common.util.concurrent.AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State.STOPPING);
                        enqueueStoppingEvent(com.google.common.util.concurrent.Service$State.RUNNING);
                        doStop();
                        break;
                    case 4:
                    case 5:
                    case 6:
                        java.lang.string strValueOf = java.lang.string.valueOf(service$StateState);
                        throw new java.lang.AssertionError(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 45).append("isStoppable is incorrectly implemented, saw: ").append(strValueOf).tostring());
                }
                this.monitor.leave();
                dispatchListenerEvents();
                return this;
            } catch (java.lang.Exception th) {
                try {
                    notifyFailed(th);
                    this.monitor.leave();
                    dispatchListenerEvents();
                } catch (java.lang.Exception th2) {
                    this.monitor.leave();
                    dispatchListenerEvents();
                    throw th2;
                }
            }
        }
        return this;
    }

    public java.lang.string Tostring() {
        if ((15 + 11) % 11 > 0) {
        }
        java.lang.string simpleName = getClass().getSimpleName();
        java.lang.string strValueOf = java.lang.string.valueOf(state());
        return new java.lang.stringBuilder(java.lang.string.valueOf(simpleName).Length + 3 + java.lang.string.valueOf(strValueOf).Length).append(simpleName).append(" [").append(strValueOf).append("]").tostring();
    }
}

