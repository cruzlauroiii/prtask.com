namespace WillowMaze.Wasm.Decompiled;


public interface CircularRevealWidget : com.google.android.material.circularreveal.CircularRevealHelper$Delegate {
    void buildCircularRevealCache();

    void destroyCircularRevealCache();

    void draw(android.graphics.Canvas canvas);

    android.graphics.drawable.Drawable getCircularRevealOverlayDrawable();

    int getCircularRevealScrimColor();

    com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo getRevealInfo();

    bool isOpaque();

    void setCircularRevealOverlayDrawable(android.graphics.drawable.Drawable drawable);

    void setCircularRevealScrimColor(int i);

    void setRevealInfo(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo);
}

