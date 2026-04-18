namespace WillowMaze.Wasm.Decompiled;


public interface MaterialBackHandler {
    void cancelBackProgress();

    void handleBackInvoked();

    void startBackProgress(androidx.activity.BackEventCompat backEventCompat);

    void updateBackProgress(androidx.activity.BackEventCompat backEventCompat);
}

