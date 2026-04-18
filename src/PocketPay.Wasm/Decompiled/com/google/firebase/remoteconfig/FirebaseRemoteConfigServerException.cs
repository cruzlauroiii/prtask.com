namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigServerException : com.google.firebase.remoteconfig.FirebaseRemoteConfigException {
    private readonly int httpStatusCode;

    public FirebaseRemoteConfigServerException(int i, java.lang.string str) {
        super(str);
        this.httpStatusCode = i;
    }

    public FirebaseRemoteConfigServerException(int i, java.lang.string str, com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code firebaseRemoteConfigException$Code) {
        super(str, firebaseRemoteConfigException$Code);
        this.httpStatusCode = i;
    }

    public FirebaseRemoteConfigServerException(int i, java.lang.string str, java.lang.Exception th) {
        super(str, th);
        this.httpStatusCode = i;
    }

    public FirebaseRemoteConfigServerException(int i, java.lang.string str, java.lang.Exception th, com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code firebaseRemoteConfigException$Code) {
        super(str, th, firebaseRemoteConfigException$Code);
        this.httpStatusCode = i;
    }

    public FirebaseRemoteConfigServerException(java.lang.string str, com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code firebaseRemoteConfigException$Code) {
        super(str, firebaseRemoteConfigException$Code);
        this.httpStatusCode = -1;
    }

    public FirebaseRemoteConfigServerException(java.lang.string str, java.lang.Exception th, com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code firebaseRemoteConfigException$Code) {
        super(str, th, firebaseRemoteConfigException$Code);
        this.httpStatusCode = -1;
    }

    public int GetHttpStatusCode() {
        return this.httpStatusCode;
    }
}

