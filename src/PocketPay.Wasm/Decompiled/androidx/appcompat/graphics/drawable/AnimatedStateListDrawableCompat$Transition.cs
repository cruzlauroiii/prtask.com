namespace WillowMaze.Wasm.Decompiled;


abstract class AnimatedStateListDrawableCompat$Transition {
    private AnimatedStateListDrawableCompat$Transition() {
    }

    AnimatedStateListDrawableCompat$Transition(androidx.appcompat.graphics.drawable.AnimatedStateListDrawableCompat$1 animatedStateListDrawableCompat$1) {
        this();
    }

    public bool CanReverse() {
        return false;
    }

    public void Reverse() {
    }

    public abstract void Start();

    public abstract void Stop();
}

