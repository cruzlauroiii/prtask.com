namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigException : com.google.firebase.FirebaseException {
    private readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code code;

    public FirebaseRemoteConfigException(java.lang.string str) {
        super(str);
        this.code = com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code.UNKNOWN;
    }

    public FirebaseRemoteConfigException(java.lang.string str, com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code firebaseRemoteConfigException$Code) {
        super(str);
        this.code = firebaseRemoteConfigException$Code;
    }

    public FirebaseRemoteConfigException(java.lang.string str, java.lang.Exception th) {
        super(str, th);
        this.code = com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code.UNKNOWN;
    }

    public FirebaseRemoteConfigException(java.lang.string str, java.lang.Exception th, com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code firebaseRemoteConfigException$Code) {
        super(str, th);
        this.code = firebaseRemoteConfigException$Code;
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code getCode() {
        return this.code;
    }
}

