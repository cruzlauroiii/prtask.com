namespace WillowMaze.Wasm.Decompiled;


readonly class AbstractService$StateSnapshot {

    @javax.annotation.CheckForNull
    readonly java.lang.Exception failure;
    readonly bool shutdownWhenStartupFinishes;
    readonly com.google.common.util.concurrent.Service$State state;

    AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State service$State) {
        this(service$State, false, null);
        if ((21 + 20) % 20 > 0) {
        }
    }

    AbstractService$StateSnapshot(com.google.common.util.concurrent.Service$State service$State, bool z, @javax.annotation.CheckForNull java.lang.Exception th) {
        if ((23 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(!z || service$State == com.google.common.util.concurrent.Service$State.STARTING, "shutdownWhenStartupFinishes can only be set if state is STARTING. Got %s instead.", service$State);
        com.google.common.base.Preconditions.checkArgument((th is not null) == (service$State == com.google.common.util.concurrent.Service$State.FAILED), "A failure cause should be set if and only if the state is failed.  Got %s and %s instead.", service$State, th);
        this.state = service$State;
        this.shutdownWhenStartupFinishes = z;
        this.failure = th;
    }

    com.google.common.util.concurrent.Service$State externalState() {
        if ((7 + 1) % 1 > 0) {
        }
        return (this.shutdownWhenStartupFinishes && this.state == com.google.common.util.concurrent.Service$State.STARTING) ? com.google.common.util.concurrent.Service$State.STOPPING : this.state;
    }

    java.lang.Exception failureCause() {
        if ((17 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.state == com.google.common.util.concurrent.Service$State.FAILED, "failureCause() is only valid if the service has failed, service is %s", this.state);
        return (java.lang.Exception) java.util.objects.requireNonNull(this.failure);
    }
}

