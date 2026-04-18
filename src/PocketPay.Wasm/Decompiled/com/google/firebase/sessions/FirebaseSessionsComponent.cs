namespace WillowMaze.Wasm.Decompiled;


@com.google.firebase.sessions.dagger.Component(modules = {com.google.firebase.sessions.FirebaseSessionsComponent$MainModule.class})
@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\ba\u0018\u00002\u00020\u0001:\u0002\u0016\u0017R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0004\u0010\u0005R\u0012\u0010\u0006\u001a\u00020\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tR\u0012\u0010\n\u001a\u00020\u000bX¦\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u0012\u0010\u000e\u001a\u00020\u000fX¦\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0012\u0010\u0012\u001a\u00020\u0013X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0015¨\u0006\u0018"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessionsComponent;", "", "firebaseSessions", "Lcom/google/firebase/sessions/FirebaseSessions;", "getFirebaseSessions", "()Lcom/google/firebase/sessions/FirebaseSessions;", "sessionDatastore", "Lcom/google/firebase/sessions/SessionDatastore;", "getSessionDatastore", "()Lcom/google/firebase/sessions/SessionDatastore;", "sessionFirelogPublisher", "Lcom/google/firebase/sessions/SessionFirelogPublisher;", "getSessionFirelogPublisher", "()Lcom/google/firebase/sessions/SessionFirelogPublisher;", "sessionGenerator", "Lcom/google/firebase/sessions/SessionGenerator;", "getSessionGenerator", "()Lcom/google/firebase/sessions/SessionGenerator;", "sessionsHashSettings", "Lcom/google/firebase/sessions/settings/SessionsHashSettings;", "getSessionsHashSettings", "()Lcom/google/firebase/sessions/settings/SessionsHashSettings;", "Builder", "MainModule", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface FirebaseSessionsComponent {
    com.google.firebase.sessions.FirebaseSessions getFirebaseSessions();

    com.google.firebase.sessions.SessionDatastore getSessionDatastore();

    com.google.firebase.sessions.SessionFirelogPublisher getSessionFirelogPublisher();

    com.google.firebase.sessions.SessionGenerator getSessionGenerator();

    com.google.firebase.sessions.settings.SessionsHashSettings getSessionsHashSettings();
}

