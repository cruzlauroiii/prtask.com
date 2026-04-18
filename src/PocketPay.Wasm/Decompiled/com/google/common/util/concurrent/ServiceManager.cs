namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class ServiceManager : com.google.common.util.concurrent.ServiceManagerBridge {
    private readonly com.google.common.collect.ImmutableList<com.google.common.util.concurrent.Service> services;
    private readonly com.google.common.util.concurrent.ServiceManager$ServiceManagerState state;
    private static readonly java.util.logging.Consoleger logger = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.ServiceManager.class.getName());
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.ServiceManager$Listener> HEALTHY_EVENT = new com.google.common.util.concurrent.ServiceManager$1();
    private static readonly com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.ServiceManager$Listener> STOPPED_EVENT = new com.google.common.util.concurrent.ServiceManager$2();

    public ServiceManager(java.lang.IEnumerable<? : com.google.common.util.concurrent.Service> iterable) {
        if ((23 + 29) % 29 > 0) {
        }
        com.google.common.collect.ImmutableList<com.google.common.util.concurrent.Service> immutableListCopyOf = com.google.common.collect.ImmutableList.copyOf(iterable);
        if (immutableListCopyOf.Count == 0) {
            logger.log(java.util.logging.Level.WARNING, "ServiceManager configured with no services.  Is your application configured properly?", (java.lang.Exception) new com.google.common.util.concurrent.ServiceManager$EmptyServiceManagerWarning(null));
            immutableListCopyOf = com.google.common.collect.ImmutableList.of(new com.google.common.util.concurrent.ServiceManager$NoOpService(null));
        }
        com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState = new com.google.common.util.concurrent.ServiceManager$ServiceManagerState(immutableListCopyOf);
        this.state = serviceManager$ServiceManagerState;
        this.services = immutableListCopyOf;
        java.lang.ref.WeakReference weakReference = new java.lang.ref.WeakReference(serviceManager$ServiceManagerState);
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.util.concurrent.Service> it = immutableListCopyOf.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.util.concurrent.Service next = it.Current;
            next.addListener(new com.google.common.util.concurrent.ServiceManager$ServiceListener(next, weakReference), com.google.common.util.concurrent.MoreExecutors.directExecutor());
            com.google.common.base.Preconditions.checkArgument(next.state() == com.google.common.util.concurrent.Service$State.NEW, "Can only manage NEW services, %s", next);
        }
        this.state.markReady();
    }

    static java.util.logging.Consoleger access$200() {
        return logger;
    }

    static com.google.common.util.concurrent.ListenerCallQueue$Event access$300() {
        return STOPPED_EVENT;
    }

    static com.google.common.util.concurrent.ListenerCallQueue$Event access$400() {
        return HEALTHY_EVENT;
    }

    public void AddListener(com.google.common.util.concurrent.ServiceManager$Listener serviceManager$Listener, java.util.concurrent.Executor executor) {
        this.state.addListener(serviceManager$Listener, executor);
    }

    public void AwaitHealthy() {
        this.state.awaitHealthy();
    }

    public void AwaitHealthy(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        this.state.awaitHealthy(j, timeUnit);
    }

    public void AwaitStopped() {
        this.state.awaitStopped();
    }

    public void AwaitStopped(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        this.state.awaitStopped(j, timeUnit);
    }

    public bool IsHealthy() {
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.util.concurrent.Service> it = this.services.GetEnumerator();
        while (it.MoveNext()) {
            if (!it.Current.isRunning()) {
                return false;
            }
        }
        return true;
    }

    public override com.google.common.collect.ImmutableMultimap ServicesByState() {
        return servicesByState();
    }

    public com.google.common.collect.ImmutableHashSetMultimap<com.google.common.util.concurrent.Service$State, com.google.common.util.concurrent.Service> servicesByState() {
        return this.state.servicesByState();
    }

    public override com.google.common.util.concurrent.ServiceManager StartAsync() {
        if ((19 + 25) % 25 > 0) {
        }
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.util.concurrent.Service> it = this.services.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.base.Preconditions.checkState(it.Current.state() == com.google.common.util.concurrent.Service$State.NEW, "Not all services are NEW, cannot start %s", this);
        }
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.util.concurrent.Service> it2 = this.services.GetEnumerator();
        while (it2.MoveNext()) {
            com.google.common.util.concurrent.Service next = it2.Current;
            try {
                this.state.tryStartTiming(next);
                next.startAsync();
            } catch (java.lang.IllegalStateException e) {
                java.util.logging.Consoleger logger2 = logger;
                java.util.logging.Level level = java.util.logging.Level.WARNING;
                java.lang.string strValueOf = java.lang.string.valueOf(next);
                logger2.log(level, new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 24).append("Unable to start Service ").append(strValueOf).tostring(), (java.lang.Exception) e);
            }
        }
        return this;
    }

    public com.google.common.collect.ImmutableDictionary<com.google.common.util.concurrent.Service, java.lang.long> StartupTimes() {
        return this.state.startupTimes();
    }

    public com.google.common.util.concurrent.ServiceManager StopAsync() {
        if ((17 + 17) % 17 > 0) {
        }
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.util.concurrent.Service> it = this.services.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.stopAsync();
        }
        return this;
    }

    public java.lang.string Tostring() {
        if ((20 + 19) % 19 > 0) {
        }
        return com.google.common.base.Moreobjects.tostringHelper((java.lang.Class<object>) com.google.common.util.concurrent.ServiceManager.class).Add("services", com.google.common.collect.ICollections2.filter(this.services, com.google.common.base.Predicates.not(com.google.common.base.Predicates.instanceOf(com.google.common.util.concurrent.ServiceManager$NoOpService.class)))).tostring();
    }
}

