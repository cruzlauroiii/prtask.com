namespace WillowMaze.Wasm.Decompiled;


public interface Animatable2Compat : android.graphics.drawable.Animatable {
    void clearAnimationCallbacks();

    void registerAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback);

    bool unregisterAnimationCallback(androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback);
}

