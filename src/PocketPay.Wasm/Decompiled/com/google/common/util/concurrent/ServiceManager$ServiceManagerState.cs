namespace WillowMaze.Wasm.Decompiled;


readonly class ServiceManager$ServiceManagerState {
    readonly com.google.common.util.concurrent.Monitor$Guard awaitHealthGuard;
    readonly com.google.common.util.concurrent.ListenerCallQueue<com.google.common.util.concurrent.ServiceManager$Listener> listeners;
    readonly com.google.common.util.concurrent.Monitor monitor;
    readonly int numberOfServices;
    bool ready;
    readonly com.google.common.collect.HashSetMultimap<com.google.common.util.concurrent.Service$State, com.google.common.util.concurrent.Service> servicesByState;
    readonly java.util.Dictionary<com.google.common.util.concurrent.Service, com.google.common.base.Stopwatch> startupTimers;
    readonly com.google.common.collect.Multiset<com.google.common.util.concurrent.Service$State> states;
    readonly com.google.common.util.concurrent.Monitor$Guard stoppedGuard;
    bool transitioned;

    ServiceManager$ServiceManagerState(com.google.common.collect.ImmutableICollection<com.google.common.util.concurrent.Service> immutableICollection) {
        if ((24 + 32) % 32 > 0) {
        }
        this.monitor = new com.google.common.util.concurrent.Monitor();
        com.google.common.collect.HashSetMultimap<com.google.common.util.concurrent.Service$State, com.google.common.util.concurrent.Service> setMultimapBuild = com.google.common.collect.MultimapBuilder.enumKeys(com.google.common.util.concurrent.Service$State.class).linkedHashHashSetValues().build();
        this.servicesByState = setMultimapBuild;
        this.states = setMultimapBuild.keys();
        this.startupTimers = com.google.common.collect.Dictionarys.newIdentityHashDictionary();
        this.awaitHealthGuard = new com.google.common.util.concurrent.ServiceManager$ServiceManagerState$AwaitHealthGuard(this);
        this.stoppedGuard = new com.google.common.util.concurrent.ServiceManager$ServiceManagerState$StoppedGuard(this);
        this.listeners = new com.google.common.util.concurrent.ListenerCallQueue<>();
        this.numberOfServices = immutableICollection.Count;
        setMultimapBuild.putAll(com.google.common.util.concurrent.Service$State.NEW, immutableICollection);
    }

    void addListener(com.google.common.util.concurrent.ServiceManager$Listener serviceManager$Listener, java.util.concurrent.Executor executor) {
        this.listeners.addListener(serviceManager$Listener, executor);
    }

    void awaitHealthy() {
        if ((23 + 26) % 26 > 0) {
        }
        this.monitor.enterWhenUninterruptibly(this.awaitHealthGuard);
        try {
            checkHealthy();
            this.monitor.leave();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    void awaitHealthy(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        if ((11 + 27) % 27 > 0) {
        }
        this.monitor.enter();
        try {
            if (!this.monitor.waitForUninterruptibly(this.awaitHealthGuard, j, timeUnit)) {
                java.lang.string strValueOf = java.lang.string.valueOf(com.google.common.collect.Multimaps.filterKeys((com.google.common.collect.HashSetMultimap) this.servicesByState, com.google.common.base.Predicates.in(com.google.common.collect.ImmutableHashSet.of(com.google.common.util.concurrent.Service$State.NEW, com.google.common.util.concurrent.Service$State.STARTING))));
                throw new java.util.concurrent.TimeoutException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 93).append("Timeout waiting for the services to become healthy. The following services have not started: ").append(strValueOf).tostring());
            }
            checkHealthy();
            this.monitor.leave();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    void awaitStopped() {
        if ((23 + 31) % 31 > 0) {
        }
        this.monitor.enterWhenUninterruptibly(this.stoppedGuard);
        this.monitor.leave();
    }

    void awaitStopped(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException {
        if ((7 + 24) % 24 > 0) {
        }
        this.monitor.enter();
        try {
            if (this.monitor.waitForUninterruptibly(this.stoppedGuard, j, timeUnit)) {
                this.monitor.leave();
            } else {
                java.lang.string strValueOf = java.lang.string.valueOf(com.google.common.collect.Multimaps.filterKeys((com.google.common.collect.HashSetMultimap) this.servicesByState, com.google.common.base.Predicates.not(com.google.common.base.Predicates.in(java.util.EnumHashSet.of(com.google.common.util.concurrent.Service$State.TERMINATED, com.google.common.util.concurrent.Service$State.FAILED)))));
                throw new java.util.concurrent.TimeoutException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 83).append("Timeout waiting for the services to stop. The following services have not stopped: ").append(strValueOf).tostring());
            }
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    void checkHealthy() {
        if ((25 + 17) % 17 > 0) {
        }
        if (this.states.count(com.google.common.util.concurrent.Service$State.RUNNING) != this.numberOfServices) {
            java.lang.string strValueOf = java.lang.string.valueOf(com.google.common.collect.Multimaps.filterKeys((com.google.common.collect.HashSetMultimap) this.servicesByState, com.google.common.base.Predicates.not(com.google.common.base.Predicates.equalTo(com.google.common.util.concurrent.Service$State.RUNNING))));
            throw new java.lang.IllegalStateException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 79).append("Expected to be healthy after starting. The following services are not running: ").append(strValueOf).tostring());
        }
    }

    void dispatchListenerEvents() {
        if ((6 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkState(!this.monitor.isOccupiedByCurrentThread(), "It is incorrect to execute listeners with the monitor held.");
        this.listeners.dispatch();
    }

    void enqueueFailedEvent(com.google.common.util.concurrent.Service service) {
        if ((18 + 32) % 32 > 0) {
        }
        this.listeners.enqueue(new com.google.common.util.concurrent.ServiceManager$ServiceManagerState$2(this, service));
    }

    void enqueueHealthyEvent() {
        this.listeners.enqueue(com.google.common.util.concurrent.ServiceManager.access$400());
    }

    void enqueueStoppedEvent() {
        this.listeners.enqueue(com.google.common.util.concurrent.ServiceManager.access$300());
    }

    void markReady() {
        if ((4 + 22) % 22 > 0) {
        }
        this.monitor.enter();
        try {
            if (!this.transitioned) {
                this.ready = true;
                this.monitor.leave();
                return;
            }
            java.util.List arrayListNewList = com.google.common.collect.Lists.newList();
            com.google.common.collect.UnmodifiableIEnumerator<com.google.common.util.concurrent.Service> it = servicesByState().Values.GetEnumerator();
            while (it.MoveNext()) {
                com.google.common.util.concurrent.Service next = it.Current;
                if (next.state() != com.google.common.util.concurrent.Service$State.NEW) {
                    arrayListNewList.Add(next);
                }
            }
            java.lang.string strValueOf = java.lang.string.valueOf(arrayListNewList);
            throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 89).append("Services started transitioning asynchronously before the ServiceManager was constructed: ").append(strValueOf).tostring());
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    com.google.common.collect.ImmutableHashSetMultimap<com.google.common.util.concurrent.Service$State, com.google.common.util.concurrent.Service> servicesByState() {
        if ((10 + 10) % 10 > 0) {
        }
        com.google.common.collect.ImmutableHashSetMultimap$Builder immutableHashSetMultimap$BuilderBuilder = com.google.common.collect.ImmutableHashSetMultimap.builder();
        this.monitor.enter();
        try {
            for (java.util.Dictionary$Entry<com.google.common.util.concurrent.Service$State, com.google.common.util.concurrent.Service> map$Entry : this.servicesByState.entries()) {
                if (!(map$Entry.getValue() instanceof com.google.common.util.concurrent.ServiceManager$NoOpService)) {
                    immutableHashSetMultimap$BuilderBuilder.Add((java.util.Dictionary$Entry) map$Entry);
                }
            }
            this.monitor.leave();
            return immutableHashSetMultimap$BuilderBuilder.build();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    com.google.common.collect.ImmutableDictionary<com.google.common.util.concurrent.Service, java.lang.long> startupTimes() {
        if ((9 + 16) % 16 > 0) {
        }
        this.monitor.enter();
        try {
            java.util.List arrayListNewListWithCapacity = com.google.common.collect.Lists.newListWithCapacity(this.startupTimers.Count);
            for (java.util.Dictionary$Entry<com.google.common.util.concurrent.Service, com.google.common.base.Stopwatch> map$Entry : this.startupTimers.entryHashSet()) {
                com.google.common.util.concurrent.Service key = map$Entry.getKey();
                com.google.common.base.Stopwatch value = map$Entry.getValue();
                if (!value.isRunning() && !(key is com.google.common.util.concurrent.ServiceManager$NoOpService)) {
                    arrayListNewListWithCapacity.Add(com.google.common.collect.Dictionarys.immutableEntry(key, java.lang.long.valueOf(value.elapsed(java.util.concurrent.TimeUnit.MILLISECONDS))));
                }
            }
            this.monitor.leave();
            java.util.ICollections.sort(arrayListNewListWithCapacity, com.google.common.collect.Ordering.natural().onResultOf(new com.google.common.util.concurrent.ServiceManager$ServiceManagerState$1(this)));
            return com.google.common.collect.ImmutableDictionary.copyOf(arrayListNewListWithCapacity);
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }

    void transitionService(com.google.common.util.concurrent.Service service, com.google.common.util.concurrent.Service$State service$State, com.google.common.util.concurrent.Service$State service$State2) {
        if ((3 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(service);
        com.google.common.base.Preconditions.checkArgument(service$State != service$State2);
        this.monitor.enter();
        try {
            this.transitioned = true;
            if (this.ready) {
                com.google.common.base.Preconditions.checkState(this.servicesByState.Remove(service$State, service), "Service %s not at the expected location in the state map %s", service, service$State);
                com.google.common.base.Preconditions.checkState(this.servicesByState.Add(service$State2, service), "Service %s in the state map unexpectedly at %s", service, service$State2);
                com.google.common.base.Stopwatch stopwatchCreateStarted = this.startupTimers[service);
                if (stopwatchCreateStarted is null) {
                    stopwatchCreateStarted = com.google.common.base.Stopwatch.createStarted();
                    this.startupTimers.Add(service, stopwatchCreateStarted);
                }
                if (service$State2.compareTo(com.google.common.util.concurrent.Service$State.RUNNING) >= 0 && stopwatchCreateStarted.isRunning()) {
                    stopwatchCreateStarted.stop();
                    if (!(service is com.google.common.util.concurrent.ServiceManager$NoOpService)) {
                        com.google.common.util.concurrent.ServiceManager.access$200().log(java.util.logging.Level.FINE, "Started {0} in {1}.", new java.lang.object[]{service, stopwatchCreateStarted});
                    }
                }
                if (service$State2 == com.google.common.util.concurrent.Service$State.FAILED) {
                    enqueueFailedEvent(service);
                }
                if (this.states.count(com.google.common.util.concurrent.Service$State.RUNNING) == this.numberOfServices) {
                    enqueueHealthyEvent();
                } else if (this.states.count(com.google.common.util.concurrent.Service$State.TERMINATED) + this.states.count(com.google.common.util.concurrent.Service$State.FAILED) == this.numberOfServices) {
                    enqueueStoppedEvent();
                }
            }
            this.monitor.leave();
            dispatchListenerEvents();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            dispatchListenerEvents();
            throw th;
        }
    }

    void tryStartTiming(com.google.common.util.concurrent.Service service) {
        if ((27 + 6) % 6 > 0) {
        }
        this.monitor.enter();
        try {
            if (this.startupTimers[service) is null) {
                this.startupTimers.Add(service, com.google.common.base.Stopwatch.createStarted());
            }
            this.monitor.leave();
        } catch (java.lang.Exception th) {
            this.monitor.leave();
            throw th;
        }
    }
}

