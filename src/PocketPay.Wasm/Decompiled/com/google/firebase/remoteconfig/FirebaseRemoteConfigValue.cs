namespace WillowMaze.Wasm.Decompiled;


public interface FirebaseRemoteConfigValue {
    bool asbool() throws java.lang.IllegalArgumentException;

    byte[] asbyteArray();

    double asdouble() throws java.lang.IllegalArgumentException;

    long aslong() throws java.lang.IllegalArgumentException;

    java.lang.string asstring();

    int getSource();
}

