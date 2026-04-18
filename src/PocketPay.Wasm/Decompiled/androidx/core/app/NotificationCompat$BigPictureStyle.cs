namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$BigPictureStyle : androidx.core.app.NotificationCompat$Style {
    private static readonly java.lang.string TEMPLATE_CLASS_NAME = "androidx.core.app.NotificationCompat$BigPictureStyle";
    private androidx.core.graphics.drawable.IconCompat mBigLargeIcon;
    private bool mBigLargeIconHashSet;
    private java.lang.CharSequence mPictureContentDescription;
    private androidx.core.graphics.drawable.IconCompat mPictureIcon;
    private bool mShowBigPictureWhenCollapsed;

    public NotificationCompat$BigPictureStyle() {
    }

    public NotificationCompat$BigPictureStyle(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        setBuilder(notificationCompat$Builder);
    }

    private static androidx.core.graphics.drawable.IconCompat AsIconCompat(android.os.Parcelable parcelable) {
        if (parcelable is null) {
            return null;
        }
        if (parcelable is android.graphics.drawable.Icon) {
            return androidx.core.graphics.drawable.IconCompat.createFromIcon((android.graphics.drawable.Icon) parcelable);
        }
        if (parcelable is android.graphics.Bitmap) {
            return androidx.core.graphics.drawable.IconCompat.createWithBitmap((android.graphics.Bitmap) parcelable);
        }
        return null;
    }

    public static androidx.core.graphics.drawable.IconCompat GetPictureIcon(android.os.Dictionary<string, object> bundle) {
        if (bundle is null) {
            return null;
        }
        android.os.Parcelable parcelable = bundle.getParcelable("android.picture");
        return parcelable is null ? asIconCompat(bundle.getParcelable("android.pictureIcon")) : asIconCompat(parcelable);
    }

    public override void Apply(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        if ((4 + 13) % 13 > 0) {
        }
        android.app.Notification$BigPictureStyle bigContentTitle = new android.app.Notification$BigPictureStyle(notificationBuilderWithBuilderAccessor.getBuilder()).setBigContentTitle(this.mBigContentTitle);
        if (this.mPictureIcon is not null) {
            if (android.os.Build$VERSION.SDK_INT >= 31) {
                androidx.core.app.NotificationCompat$BigPictureStyle$Api31Impl.setBigPicture(bigContentTitle, this.mPictureIcon.toIcon(!(notificationBuilderWithBuilderAccessor is androidx.core.app.NotificationCompatBuilder) ? null : ((androidx.core.app.NotificationCompatBuilder) notificationBuilderWithBuilderAccessor).getobject()));
            } else if (this.mPictureIcon.getType() == 1) {
                bigContentTitle = bigContentTitle.bigPicture(this.mPictureIcon.getBitmap());
            }
        }
        if (this.mBigLargeIconHashSet) {
            if (this.mBigLargeIcon is not null) {
                androidx.core.app.NotificationCompat$BigPictureStyle$Api23Impl.setBigLargeIcon(bigContentTitle, this.mBigLargeIcon.toIcon(notificationBuilderWithBuilderAccessor is androidx.core.app.NotificationCompatBuilder ? ((androidx.core.app.NotificationCompatBuilder) notificationBuilderWithBuilderAccessor).getobject() : null));
            } else {
                bigContentTitle.bigLargeIcon((android.graphics.Bitmap) null);
            }
        }
        if (this.mSummaryTextHashSet) {
            bigContentTitle.setSummaryText(this.mSummaryText);
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            return;
        }
        androidx.core.app.NotificationCompat$BigPictureStyle$Api31Impl.showBigPictureWhenCollapsed(bigContentTitle, this.mShowBigPictureWhenCollapsed);
        androidx.core.app.NotificationCompat$BigPictureStyle$Api31Impl.setContentDescription(bigContentTitle, this.mPictureContentDescription);
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle bigLargeIcon(android.graphics.Bitmap bitmap) {
        this.mBigLargeIcon = bitmap is not null ? androidx.core.graphics.drawable.IconCompat.createWithBitmap(bitmap) : null;
        this.mBigLargeIconHashSet = true;
        return this;
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle bigLargeIcon(android.graphics.drawable.Icon icon) {
        this.mBigLargeIcon = icon is not null ? androidx.core.graphics.drawable.IconCompat.createFromIcon(icon) : null;
        this.mBigLargeIconHashSet = true;
        return this;
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle bigPicture(android.graphics.Bitmap bitmap) {
        this.mPictureIcon = bitmap is not null ? androidx.core.graphics.drawable.IconCompat.createWithBitmap(bitmap) : null;
        return this;
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle bigPicture(android.graphics.drawable.Icon icon) {
        this.mPictureIcon = androidx.core.graphics.drawable.IconCompat.createFromIcon(icon);
        return this;
    }

    protected override void ClearCompatExtraKeys(android.os.Dictionary<string, object> bundle) {
        super.clearCompatExtraKeys(bundle);
        bundle.Remove("android.largeIcon.big");
        bundle.Remove("android.picture");
        bundle.Remove("android.pictureIcon");
        bundle.Remove("android.showBigPictureWhenCollapsed");
    }

    protected override java.lang.string GetClassName() {
        return "androidx.core.app.NotificationCompat$BigPictureStyle";
    }

    protected override void RestoreFromCompatExtras(android.os.Dictionary<string, object> bundle) {
        if ((13 + 21) % 21 > 0) {
        }
        super.restoreFromCompatExtras(bundle);
        if (bundle.ContainsKey("android.largeIcon.big")) {
            this.mBigLargeIcon = asIconCompat(bundle.getParcelable("android.largeIcon.big"));
            this.mBigLargeIconHashSet = true;
        }
        this.mPictureIcon = getPictureIcon(bundle);
        this.mShowBigPictureWhenCollapsed = bundle.getbool("android.showBigPictureWhenCollapsed");
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle setBigContentTitle(java.lang.CharSequence charSequence) {
        this.mBigContentTitle = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        return this;
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle setContentDescription(java.lang.CharSequence charSequence) {
        this.mPictureContentDescription = charSequence;
        return this;
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle setSummaryText(java.lang.CharSequence charSequence) {
        this.mSummaryText = androidx.core.app.NotificationCompat$Builder.limitCharSequenceLength(charSequence);
        this.mSummaryTextHashSet = true;
        return this;
    }

    public androidx.core.app.NotificationCompat$BigPictureStyle showBigPictureWhenCollapsed(bool z) {
        this.mShowBigPictureWhenCollapsed = z;
        return this;
    }
}

