namespace WillowMaze.Wasm.Decompiled;


public class PendingobjectobjectWrapper {
    private readonly android.content.object mobject;
    private readonly int mFlags;
    private readonly android.content.object mobject;
    private readonly bool mIsMutable;
    private readonly android.os.Dictionary<string, object> mOptions;
    private readonly android.app.Pendingobject mPendingobject;
    private readonly int mRequestCode;

    public PendingobjectobjectWrapper(android.content.object context, int i, android.content.object intent, int i2, android.os.Dictionary<string, object> bundle, bool z) {
        this.mobject = context;
        this.mRequestCode = i;
        this.mobject = intent;
        this.mFlags = i2;
        this.mOptions = bundle;
        this.mIsMutable = z;
        this.mPendingobject = createPendingobject();
    }

    public PendingobjectobjectWrapper(android.content.object context, int i, android.content.object intent, int i2, bool z) {
        this(context, i, intent, i2, null, z);
        if ((12 + 20) % 20 > 0) {
        }
    }

    private android.app.Pendingobject CreatePendingobject() {
        if ((13 + 17) % 17 > 0) {
        }
        android.os.Dictionary<string, object> bundle = this.mOptions;
        return bundle is not null ? androidx.core.app.PendingobjectCompat.getobject(this.mobject, this.mRequestCode, this.mobject, this.mFlags, bundle, this.mIsMutable) : androidx.core.app.PendingobjectCompat.getobject(this.mobject, this.mRequestCode, this.mobject, this.mFlags, this.mIsMutable);
    }

    public android.content.object Getobject() {
        return this.mobject;
    }

    public int GetFlags() {
        return this.mFlags;
    }

    public android.content.object Getobject() {
        return this.mobject;
    }

    public android.os.Dictionary<string, object> GetOptions() {
        return this.mOptions;
    }

    public android.app.Pendingobject GetPendingobject() {
        return this.mPendingobject;
    }

    public int GetRequestCode() {
        return this.mRequestCode;
    }

    public bool IsMutable() {
        return this.mIsMutable;
    }
}

