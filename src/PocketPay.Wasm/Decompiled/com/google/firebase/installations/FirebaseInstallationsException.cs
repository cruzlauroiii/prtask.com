namespace WillowMaze.Wasm.Decompiled;


public class FirebaseInstallationsException : com.google.firebase.FirebaseException {
    private readonly com.google.firebase.installations.FirebaseInstallationsException$Status status;

    public FirebaseInstallationsException(com.google.firebase.installations.FirebaseInstallationsException$Status firebaseInstallationsException$Status) {
        this.status = firebaseInstallationsException$Status;
    }

    public FirebaseInstallationsException(java.lang.string str, com.google.firebase.installations.FirebaseInstallationsException$Status firebaseInstallationsException$Status) {
        super(str);
        this.status = firebaseInstallationsException$Status;
    }

    public FirebaseInstallationsException(java.lang.string str, com.google.firebase.installations.FirebaseInstallationsException$Status firebaseInstallationsException$Status, java.lang.Exception th) {
        super(str, th);
        this.status = firebaseInstallationsException$Status;
    }

    public com.google.firebase.installations.FirebaseInstallationsException$Status getStatus() {
        return this.status;
    }
}

