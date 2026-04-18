namespace WillowMaze.Wasm.Decompiled;


readonly class ServiceManager$NoOpService : com.google.common.util.concurrent.AbstractService {
    private ServiceManager$NoOpService() {
    }

    ServiceManager$NoOpService(com.google.common.util.concurrent.ServiceManager$1 serviceManager$1) {
        this();
    }

    protected override void DoStart() {
        notifyStarted();
    }

    protected override void DoStop() {
        notifyStopped();
    }
}

