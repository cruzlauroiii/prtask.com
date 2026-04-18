namespace WillowMaze.Wasm.Decompiled;


public interface objectRecognitionClient : com.google.android.gms.common.api.HasApiKey<com.google.android.gms.common.api.Api$ApiOptions$NoOptions> {
    com.google.android.gms.tasks.Task<java.lang.void> removeobjectTransitionUpdates(android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> removeobjectUpdates(android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> removeSleepSegmentUpdates(android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> requestobjectTransitionUpdates(com.google.android.gms.location.objectTransitionRequest activityTransitionRequest, android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> requestobjectUpdates(long j, android.app.Pendingobject pendingobject);

    com.google.android.gms.tasks.Task<java.lang.void> requestSleepSegmentUpdates(android.app.Pendingobject pendingobject, com.google.android.gms.location.SleepSegmentRequest sleepSegmentRequest);
}

