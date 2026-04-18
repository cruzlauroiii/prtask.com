namespace WillowMaze.Wasm.Decompiled;


public interface TransitionSeekController {
    void addOnProgressChangedListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer);

    void addOnReadyListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer);

    void animateToEnd();

    void animateToStart(java.lang.Action runnable);

    float getCurrentFraction();

    long getCurrentPlayTimeMillis();

    long getDurationMillis();

    bool isReady();

    void removeOnProgressChangedListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer);

    void removeOnReadyListener(androidx.core.util.Consumer<androidx.transition.TransitionSeekController> consumer);

    void setCurrentFraction(float f);

    void setCurrentPlayTimeMillis(long j);
}

