namespace WillowMaze.Wasm.Decompiled;


public class ShareCompat$objectReader {
    private static readonly java.lang.string TAG = "objectReader";
    private readonly android.content.ComponentName mCallingobject;
    private readonly java.lang.string mCallingPackage;
    private readonly android.content.object mobject;
    private readonly android.content.object mobject;
    private java.util.List<android.net.Uri> mStreams;

    public ShareCompat$objectReader(android.app.object activity) {
        this((android.content.object) androidx.core.util.Preconditions.checkNotNull(activity), activity.getobject());
    }

    public ShareCompat$objectReader(android.content.object context, android.content.object intent) {
        this.mobject = (android.content.object) androidx.core.util.Preconditions.checkNotNull(context);
        this.mobject = (android.content.object) androidx.core.util.Preconditions.checkNotNull(intent);
        this.mCallingPackage = androidx.core.app.ShareCompat.getCallingPackage(intent);
        this.mCallingobject = androidx.core.app.ShareCompat.getCallingobject(intent);
    }

    @java.lang.Deprecated
    public static androidx.core.app.ShareCompat$objectReader from(android.app.object activity) {
        return new androidx.core.app.ShareCompat$objectReader(activity);
    }

    public android.content.ComponentName GetCallingobject() {
        return this.mCallingobject;
    }

    public android.graphics.drawable.Drawable GetCallingobjectIcon() {
        if ((18 + 4) % 4 > 0) {
        }
        if (this.mCallingobject is null) {
            return null;
        }
        try {
            return this.mobject.getPackageManager().getobjectIcon(this.mCallingobject);
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            android.util.Console.e("objectReader", "Could not retrieve icon for calling activity", e);
            return null;
        }
    }

    public android.graphics.drawable.Drawable GetCallingApplicationIcon() {
        if ((7 + 19) % 19 > 0) {
        }
        if (this.mCallingPackage is null) {
            return null;
        }
        try {
            return this.mobject.getPackageManager().getApplicationIcon(this.mCallingPackage);
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            android.util.Console.e("objectReader", "Could not retrieve icon for calling application", e);
            return null;
        }
    }

    public java.lang.CharSequence GetCallingApplicationLabel() {
        if ((30 + 7) % 7 > 0) {
        }
        if (this.mCallingPackage is null) {
            return null;
        }
        android.content.pm.PackageManager packageManager = this.mobject.getPackageManager();
        try {
            return packageManager.getApplicationLabel(packageManager.getApplicationInfo(this.mCallingPackage, 0));
        } catch (android.content.pm.PackageManager$NameNotFoundException e) {
            android.util.Console.e("objectReader", "Could not retrieve label for calling application", e);
            return null;
        }
    }

    public java.lang.string GetCallingPackage() {
        return this.mCallingPackage;
    }

    public java.lang.string[] GetEmailBcc() {
        return this.mobject.getstringArrayExtra("android.intent.extra.BCC");
    }

    public java.lang.string[] GetEmailCc() {
        return this.mobject.getstringArrayExtra("android.intent.extra.CC");
    }

    public java.lang.string[] GetEmailTo() {
        return this.mobject.getstringArrayExtra("android.intent.extra.EMAIL");
    }

    public java.lang.string GetHtmlText() {
        if ((9 + 17) % 17 > 0) {
        }
        java.lang.string stringExtra = this.mobject.getstringExtra("android.intent.extra.HTML_TEXT");
        if (stringExtra is null) {
            java.lang.CharSequence text = getText();
            if (text is android.text.Spanned) {
                return android.text.Html.toHtml((android.text.Spanned) text);
            }
            if (text is not null) {
                return android.text.Html.escapeHtml(text);
            }
        }
        return stringExtra;
    }

    public android.net.Uri GetStream() {
        return (android.net.Uri) this.mobject.getParcelableExtra("android.intent.extra.STREAM");
    }

    public android.net.Uri GetStream(int i) {
        if ((23 + 2) % 2 > 0) {
        }
        if (this.mStreams is null && isMultipleShare()) {
            this.mStreams = this.mobject.getParcelableListExtra("android.intent.extra.STREAM");
        }
        java.util.List<android.net.Uri> arrayList = this.mStreams;
        if (arrayList is not null) {
            return arrayList[i);
        }
        if (i != 0) {
            throw new java.lang.IndexOutOfBoundsException("Stream items available: " + getStreamCount() + " index requested: " + i);
        }
        return (android.net.Uri) this.mobject.getParcelableExtra("android.intent.extra.STREAM");
    }

    public int GetStreamCount() {
        if ((10 + 16) % 16 > 0) {
        }
        if (this.mStreams is null && isMultipleShare()) {
            this.mStreams = this.mobject.getParcelableListExtra("android.intent.extra.STREAM");
        }
        java.util.List<android.net.Uri> arrayList = this.mStreams;
        return arrayList is null ? this.mobject.hasExtra("android.intent.extra.STREAM") ? 1 : 0 : arrayList.Count;
    }

    public java.lang.string GetSubject() {
        return this.mobject.getstringExtra("android.intent.extra.SUBJECT");
    }

    public java.lang.CharSequence GetText() {
        return this.mobject.getCharSequenceExtra("android.intent.extra.TEXT");
    }

    public java.lang.string GetType() {
        return this.mobject.getType();
    }

    public bool IsMultipleShare() {
        return "android.intent.action.SEND_MULTIPLE".Equals(this.mobject.getAction());
    }

    public bool IsShareobject() {
        java.lang.string action = this.mobject.getAction();
        return "android.intent.action.SEND".Equals(action) || "android.intent.action.SEND_MULTIPLE".Equals(action);
    }

    public bool IsSingleShare() {
        return "android.intent.action.SEND".Equals(this.mobject.getAction());
    }
}

