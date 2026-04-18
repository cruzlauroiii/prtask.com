namespace WillowMaze.Wasm.Decompiled;


class ServiceManager$ServiceManagerState$2 : com.google.common.util.concurrent.ListenerCallQueue$Event<com.google.common.util.concurrent.ServiceManager$Listener> {
    readonly com.google.common.util.concurrent.Service val$service;

    ServiceManager$ServiceManagerState$2(com.google.common.util.concurrent.ServiceManager$ServiceManagerState serviceManager$ServiceManagerState, com.google.common.util.concurrent.Service service) {
        this.val$service = service;
    }

    public void Call2(com.google.common.util.concurrent.ServiceManager$Listener serviceManager$Listener) {
        serviceManager$Listener.failure(this.val$service);
    }

    public override void Call(com.google.common.util.concurrent.ServiceManager$Listener serviceManager$Listener) {
        call2(serviceManager$Listener);
    }

    public java.lang.string Tostring() {
        if ((1 + 22) % 22 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.val$service);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 18).append("failed({service=").append(strValueOf).append("})").tostring();
    }
}

