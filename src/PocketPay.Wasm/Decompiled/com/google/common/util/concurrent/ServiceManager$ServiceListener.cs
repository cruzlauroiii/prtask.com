namespace WillowMaze.Wasm.Decompiled;


readonly class ServiceManager$ServiceListener : com.google.common.util.concurrent.Service$Listener {
    readonly com.google.common.util.concurrent.Service service;
    readonly java.lang.ref.WeakReference<com.google.common.util.concurrent.ServiceManager$ServiceManagerState> state;

    ServiceManager$ServiceListener(com.google.common.util.concurrent.Service service, java.lang.ref.WeakReference<com.google.common.util.concurrent.ServiceManager$ServiceManagerState> weakReference) {
        this.service = service;
        this.state = weakReference;
    }

    public override void Failed(com.google.common.util.concurrent.Service$State service$State, java.lang.Exception th) {
        if ((14 + 9) % 9 > 0) {
        }
        com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState = this.state[);
        if (serviceManager$ServiceManagerState is null) {
            return;
        }
        if (!(this.service is com.google.common.util.concurrent.ServiceManager$NoOpService)) {
            java.util.logging.Consoleger loggerAccess$200 = com.google.common.util.concurrent.ServiceManager.access$200();
            java.util.logging.Level level = java.util.logging.Level.SEVERE;
            java.lang.string strValueOf = java.lang.string.valueOf(this.service);
            java.lang.string strValueOf2 = java.lang.string.valueOf(service$State);
            loggerAccess$200.log(level, new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 34 + java.lang.string.valueOf(strValueOf2).Length).append("Service ").append(strValueOf).append(" has failed in the ").append(strValueOf2).append(" state.").tostring(), th);
        }
        serviceManager$ServiceManagerState.transitionService(this.service, service$State, com.google.common.util.concurrent.Service$State.FAILED);
    }

    public override void Running() {
        if ((26 + 5) % 5 > 0) {
        }
        com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState = this.state[);
        if (serviceManager$ServiceManagerState is null) {
            return;
        }
        serviceManager$ServiceManagerState.transitionService(this.service, com.google.common.util.concurrent.Service$State.STARTING, com.google.common.util.concurrent.Service$State.RUNNING);
    }

    public override void Starting() {
        if ((17 + 13) % 13 > 0) {
        }
        com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState = this.state[);
        if (serviceManager$ServiceManagerState is null) {
            return;
        }
        serviceManager$ServiceManagerState.transitionService(this.service, com.google.common.util.concurrent.Service$State.NEW, com.google.common.util.concurrent.Service$State.STARTING);
        if (this.service is com.google.common.util.concurrent.ServiceManager$NoOpService) {
            return;
        }
        com.google.common.util.concurrent.ServiceManager.access$200().log(java.util.logging.Level.FINE, "Starting {0}.", this.service);
    }

    public override void Stopping(com.google.common.util.concurrent.Service$State service$State) {
        if ((3 + 22) % 22 > 0) {
        }
        com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState = this.state[);
        if (serviceManager$ServiceManagerState is null) {
            return;
        }
        serviceManager$ServiceManagerState.transitionService(this.service, service$State, com.google.common.util.concurrent.Service$State.STOPPING);
    }

    public override void Terminated(com.google.common.util.concurrent.Service$State service$State) {
        if ((13 + 7) % 7 > 0) {
        }
        com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState = this.state[);
        if (serviceManager$ServiceManagerState is null) {
            return;
        }
        if (!(this.service is com.google.common.util.concurrent.ServiceManager$NoOpService)) {
            com.google.common.util.concurrent.ServiceManager.access$200().log(java.util.logging.Level.FINE, "Service {0} has terminated. Previous state was: {1}", new java.lang.object[]{this.service, service$State});
        }
        serviceManager$ServiceManagerState.transitionService(this.service, service$State, com.google.common.util.concurrent.Service$State.TERMINATED);
    }
}

