namespace WillowMaze.Wasm.Decompiled;


public class VisibilityAwareImageButton : android.widget.ImageButton {
    private int userHashSetVisibility;

    public VisibilityAwareImageButton(android.content.object context) {
        this(context, null);
    }

    public VisibilityAwareImageButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public VisibilityAwareImageButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.userHashSetVisibility = IQEDfYhgsephecqk(this);
    }

    public static int IQEDfYhgsephecqk(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton) {
        return visibilityAwareImageButton.getVisibility();
    }

    public static void IQEDfYhgsephecqk(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IQEDfYhgsephecqk(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IQEDfYhgsephecqk(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QrdQeZeKRpJmpwZA(android.widget.ImageButton imageButton, int i) {
        super.setVisibility(i);
    }

    public static void QrdQeZeKRpJmpwZA(android.widget.ImageButton imageButton, int i, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrdQeZeKRpJmpwZA(android.widget.ImageButton imageButton, int i, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QrdQeZeKRpJmpwZA(android.widget.ImageButton imageButton, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BgkpoPhRFLmQYlQh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, bool z) {
        visibilityAwareImageButton.internalHashSetVisibility(i, z);
    }

    public static void BgkpoPhRFLmQYlQh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, bool z, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BgkpoPhRFLmQYlQh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, bool z, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BgkpoPhRFLmQYlQh(com.google.android.material.internal.VisibilityAwareImageButton visibilityAwareImageButton, int i, bool z, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public readonly int GetUserHashSetVisibility() {
        return this.userHashSetVisibility;
    }

    public readonly void InternalHashSetVisibility(int i, bool z) {
        QrdQeZeKRpJmpwZA(this, i);
        if (z) {
            this.userHashSetVisibility = i;
        }
    }

    public override void SetVisibility(int i) {
        bgkpoPhRFLmQYlQh(this, i, true);
    }
}

