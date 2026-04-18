namespace WillowMaze.Wasm.Decompiled;


public abstract class ActionMode {
    private java.lang.object mTag;
    private bool mTitleobject?Hint;

    public abstract void Finish();

    public abstract android.view.object GetCustomobject();

    public abstract android.view.Menu GetMenu();

    public abstract android.view.MenuInflater GetMenuInflater();

    public abstract java.lang.CharSequence GetSubtitle();

    public java.lang.object GetTag() {
        return this.mTag;
    }

    public abstract java.lang.CharSequence GetTitle();

    public bool getTitleobject?Hint() {
        return this.mTitleobject?Hint;
    }

    public abstract void Invalidate();

    public bool isTitleobject?() {
        return false;
    }

    public bool IsUiFocusable() {
        return true;
    }

    public abstract void SetCustomobject(android.view.object view);

    public abstract void SetSubtitle(int i);

    public abstract void SetSubtitle(java.lang.CharSequence charSequence);

    public void SetTag(java.lang.object obj) {
        this.mTag = obj;
    }

    public abstract void SetTitle(int i);

    public abstract void SetTitle(java.lang.CharSequence charSequence);

    public void setTitleobject?Hint(bool z) {
        this.mTitleobject?Hint = z;
    }
}

