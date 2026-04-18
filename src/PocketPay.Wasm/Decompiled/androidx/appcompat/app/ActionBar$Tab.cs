namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class ActionBar$Tab {
    public static readonly int INVALID_POSITION = -1;

    public abstract java.lang.CharSequence GetContentDescription();

    public abstract android.view.object GetCustomobject();

    public abstract android.graphics.drawable.Drawable GetIcon();

    public abstract int GetPosition();

    public abstract java.lang.object GetTag();

    public abstract java.lang.CharSequence GetText();

    public abstract void Select();

    public abstract androidx.appcompat.app.ActionBar$Tab setContentDescription(int i);

    public abstract androidx.appcompat.app.ActionBar$Tab setContentDescription(java.lang.CharSequence charSequence);

    public abstract androidx.appcompat.app.ActionBar$Tab setCustomobject(int i);

    public abstract androidx.appcompat.app.ActionBar$Tab setCustomobject(android.view.object view);

    public abstract androidx.appcompat.app.ActionBar$Tab setIcon(int i);

    public abstract androidx.appcompat.app.ActionBar$Tab setIcon(android.graphics.drawable.Drawable drawable);

    public abstract androidx.appcompat.app.ActionBar$Tab setTabListener(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener);

    public abstract androidx.appcompat.app.ActionBar$Tab setTag(java.lang.object obj);

    public abstract androidx.appcompat.app.ActionBar$Tab setText(int i);

    public abstract androidx.appcompat.app.ActionBar$Tab setText(java.lang.CharSequence charSequence);
}

