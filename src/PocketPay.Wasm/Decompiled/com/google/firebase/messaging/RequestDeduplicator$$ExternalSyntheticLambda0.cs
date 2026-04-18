namespace WillowMaze.Wasm.Decompiled;


public readonly class RequestDeduplicator$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.messaging.RequestDeduplicator f$0;
    public readonly java.lang.string f$1;

    public RequestDeduplicator$$ExternalSyntheticLambda0(com.google.firebase.messaging.RequestDeduplicator requestDeduplicator, java.lang.string str) {
        this.f$0 = requestDeduplicator;
        this.f$1 = str;
    }

    public static com.google.android.gms.tasks.Task DuhJhsVNbxyUtIxd(com.google.firebase.messaging.RequestDeduplicator requestDeduplicator, java.lang.string str, com.google.android.gms.tasks.Task task) {
        return requestDeduplicator.m397x7161fc54(str, task);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return DuhJhsVNbxyUtIxd(this.f$0, this.f$1, task);
    }
}

