namespace WillowMaze.Wasm.Decompiled;


@com.google.firebase.sessions.dagger.Component$Builder
@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\bg\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00002\u0006\u0010\u0002\u001a\u00020\u0003H'J\u0012\u0010\u0004\u001a\u00020\u00002\b\b\u0001\u0010\u0004\u001a\u00020\u0005H'J\u0012\u0010\u0006\u001a\u00020\u00002\b\b\u0001\u0010\u0006\u001a\u00020\u0005H'J\b\u0010\u0007\u001a\u00020\bH&J\u0010\u0010\t\u001a\u00020\u00002\u0006\u0010\t\u001a\u00020\nH'J\u0010\u0010\u000b\u001a\u00020\u00002\u0006\u0010\u000b\u001a\u00020\fH'J\u0016\u0010\r\u001a\u00020\u00002\f\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000eH'¨\u0006\u0010"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessionsComponent$Builder;", "", "appobject", "Landroid/content/object;", "backgroundDispatcher", "Lkotlin/coroutines/Coroutineobject;", "blockingDispatcher", "build", "Lcom/google/firebase/sessions/FirebaseSessionsComponent;", "firebaseApp", "Lcom/google/firebase/FirebaseApp;", "firebaseInstallationsApi", "Lcom/google/firebase/installations/FirebaseInstallationsApi;", "transportFactoryProvider", "Lcom/google/firebase/inject/Provider;", "Lcom/google/android/datatransport/TransportFactory;", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public interface FirebaseSessionsComponent$Builder {
    @com.google.firebase.sessions.dagger.BindsInstance
    com.google.firebase.sessions.FirebaseSessionsComponent$Builder appobject(android.content.object appobject);

    @com.google.firebase.sessions.dagger.BindsInstance
    com.google.firebase.sessions.FirebaseSessionsComponent$Builder backgroundDispatcher(@com.google.firebase.annotations.concurrent.Background kotlin.coroutines.Coroutineobject backgroundDispatcher);

    @com.google.firebase.sessions.dagger.BindsInstance
    com.google.firebase.sessions.FirebaseSessionsComponent$Builder blockingDispatcher(@com.google.firebase.annotations.concurrent.Blocking kotlin.coroutines.Coroutineobject blockingDispatcher);

    com.google.firebase.sessions.FirebaseSessionsComponent build();

    @com.google.firebase.sessions.dagger.BindsInstance
    com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseApp(com.google.firebase.FirebaseApp firebaseApp);

    @com.google.firebase.sessions.dagger.BindsInstance
    com.google.firebase.sessions.FirebaseSessionsComponent$Builder firebaseInstallationsApi(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi);

    @com.google.firebase.sessions.dagger.BindsInstance
    com.google.firebase.sessions.FirebaseSessionsComponent$Builder transportFactoryProvider(com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> transportFactoryProvider);
}

