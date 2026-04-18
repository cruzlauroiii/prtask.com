namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "it", "Lcom/google/firebase/sessions/FirebaseSessionsData;", "emit", "(Lcom/google/firebase/sessions/FirebaseSessionsData;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class SessionDatastoreImpl$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly com.google.firebase.sessions.SessionDatastoreImpl this$0;

    SessionDatastoreImpl$1$1(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        this.this$0 = sessionDatastoreImpl;
    }

    public static java.util.concurrent.atomic.object BUNsIJvWQFyMjIDB(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        return com.google.firebase.sessions.SessionDatastoreImpl.access$getCurrentSessionFromDatastore$p(sessionDatastoreImpl);
    }

    public static void BxMpAMYqxQhCAbFp(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static java.lang.object SeSrTkAyKLszSVyi(com.google.firebase.sessions.SessionDatastoreImpl$1$1 sessionDatastoreImpl$1$1, com.google.firebase.sessions.FirebaseSessionsData firebaseSessionsData, kotlin.coroutines.Continuation continuation) {
        return sessionDatastoreImpl$1$1.emit(firebaseSessionsData, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly java.lang.object Emit(com.google.firebase.sessions.FirebaseSessionsData firebaseSessionsData, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        bxMpAMYqxQhCAbFp(bUNsIJvWQFyMjIDB(this.this$0), firebaseSessionsData);
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return seSrTkAyKLszSVyi(this, (com.google.firebase.sessions.FirebaseSessionsData) obj, continuation);
    }
}

