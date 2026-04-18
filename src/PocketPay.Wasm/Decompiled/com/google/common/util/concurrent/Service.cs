namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Create an AbstractIdleService")
@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public interface Service {
    void addListener(com.google.common.util.concurrent.Service$Listener service$Listener, java.util.concurrent.Executor executor);

    void awaitRunning();

    void awaitRunning(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException;

    void awaitTerminated();

    void awaitTerminated(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.TimeoutException;

    java.lang.Exception failureCause();

    bool isRunning();

    com.google.common.util.concurrent.Service startAsync();

    com.google.common.util.concurrent.Service$State state();

    com.google.common.util.concurrent.Service stopAsync();
}

