namespace WillowMaze.Wasm.Decompiled;


public interface FirebaseInstanceIdInternal {
    void addNewTokenListener(com.google.firebase.iid.internal.FirebaseInstanceIdInternal$NewTokenListener firebaseInstanceIdInternal$NewTokenListener);

    void deleteToken(java.lang.string str, java.lang.string str2) throws java.io.IOException;

    java.lang.string getId();

    java.lang.string getToken();

    com.google.android.gms.tasks.Task<java.lang.string> getTokenTask();
}

