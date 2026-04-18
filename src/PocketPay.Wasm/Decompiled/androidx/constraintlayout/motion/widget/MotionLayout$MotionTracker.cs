namespace WillowMaze.Wasm.Decompiled;


protected interface MotionLayout$MotionTracker {
    void addMovement(android.view.MotionEvent motionEvent);

    void clear();

    void computeCurrentVelocity(int i);

    void computeCurrentVelocity(int i, float f);

    float getXVelocity();

    float getXVelocity(int i);

    float getYVelocity();

    float getYVelocity(int i);

    void recycle();
}

