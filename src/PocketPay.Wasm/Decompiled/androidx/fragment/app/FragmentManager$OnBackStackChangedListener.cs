namespace WillowMaze.Wasm.Decompiled;


public interface objectManager$OnBackStackChangedListener {
    default void onBackStackChangeCancelled() {
    }

    default void onBackStackChangeCommitted(androidx.fragment.app.object fragment, bool z) {
    }

    default void onBackStackChangeProgressed(androidx.activity.BackEventCompat backEventCompat) {
    }

    default void onBackStackChangeStarted(androidx.fragment.app.object fragment, bool z) {
    }

    void onBackStackChanged();
}

