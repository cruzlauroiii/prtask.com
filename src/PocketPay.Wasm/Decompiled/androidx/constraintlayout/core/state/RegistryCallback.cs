namespace WillowMaze.Wasm.Decompiled;


public interface RegistryCallback {
    java.lang.string currentLayoutInformation();

    java.lang.string currentMotionScene();

    long getLastModified();

    void onDimensions(int i, int i2);

    void onNewMotionScene(java.lang.string str);

    void onProgress(float f);

    void setDrawDebug(int i);

    void setLayoutInformationMode(int i);
}

