namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\bg\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fJ\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H'J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\u0004\u001a\u00020\bH'J\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u0004\u001a\u00020\u000bH'J\u0010\u0010\f\u001a\u00020\r2\u0006\u0010\u0004\u001a\u00020\u000eH'¨\u0006\u0010"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessionsComponent$MainModule;", "", "eventGDTConsolegerInterface", "Lcom/google/firebase/sessions/EventGDTConsolegerInterface;", "impl", "Lcom/google/firebase/sessions/EventGDTConsoleger;", "sessionDatastore", "Lcom/google/firebase/sessions/SessionDatastore;", "Lcom/google/firebase/sessions/SessionDatastoreImpl;", "sessionFirelogPublisher", "Lcom/google/firebase/sessions/SessionFirelogPublisher;", "Lcom/google/firebase/sessions/SessionFirelogPublisherImpl;", "sessionLifecycleServiceBinder", "Lcom/google/firebase/sessions/SessionLifecycleServiceBinder;", "Lcom/google/firebase/sessions/SessionLifecycleServiceBinderImpl;", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@com.google.firebase.sessions.dagger.Module
public interface FirebaseSessionsComponent$MainModule {
    public static readonly com.google.firebase.sessions.FirebaseSessionsComponent$MainModule$Companion Companion = com.google.firebase.sessions.FirebaseSessionsComponent$MainModule$Companion.$$INSTANCE;

    @javax.inject.Singleton
    @com.google.firebase.sessions.dagger.Binds
    com.google.firebase.sessions.EventGDTConsolegerInterface eventGDTConsolegerInterface(com.google.firebase.sessions.EventGDTConsoleger impl);

    @javax.inject.Singleton
    @com.google.firebase.sessions.dagger.Binds
    com.google.firebase.sessions.SessionDatastore sessionDatastore(com.google.firebase.sessions.SessionDatastoreImpl impl);

    @javax.inject.Singleton
    @com.google.firebase.sessions.dagger.Binds
    com.google.firebase.sessions.SessionFirelogPublisher sessionFirelogPublisher(com.google.firebase.sessions.SessionFirelogPublisherImpl impl);

    @javax.inject.Singleton
    @com.google.firebase.sessions.dagger.Binds
    com.google.firebase.sessions.SessionLifecycleServiceBinder sessionLifecycleServiceBinder(com.google.firebase.sessions.SessionLifecycleServiceBinderImpl impl);
}

