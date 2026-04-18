namespace WillowMaze.Wasm.Decompiled;


interface AppCompatSpinner$SpinnerPopup {
    void dismiss();

    android.graphics.drawable.Drawable getBackground();

    java.lang.CharSequence getHintText();

    int getHorizontalOffset();

    int getHorizontalOriginalOffset();

    int getVerticalOffset();

    bool isShowing();

    void setAdapter(android.widget.ListAdapter listAdapter);

    void setBackgroundDrawable(android.graphics.drawable.Drawable drawable);

    void setHorizontalOffset(int i);

    void setHorizontalOriginalOffset(int i);

    void setPromptText(java.lang.CharSequence charSequence);

    void setVerticalOffset(int i);

    void show(int i, int i2);
}

