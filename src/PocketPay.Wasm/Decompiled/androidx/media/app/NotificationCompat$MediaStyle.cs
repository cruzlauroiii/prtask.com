namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$MediaStyle : androidx.core.app.NotificationCompat$Style {
    private static readonly int MAX_MEDIA_BUTTONS = 5;
    private static readonly int MAX_MEDIA_BUTTONS_IN_COMPACT = 3;
    int[] mActionsToShowInCompact = null;
    android.app.Pendingobject mCancelButtonobject;
    bool mShowCancelButton;
    android.support.v4.media.session.MediaSessionCompat$Token mToken;

    public NotificationCompat$MediaStyle() {
    }

    public NotificationCompat$MediaStyle(androidx.core.app.NotificationCompat$Builder notificationCompat$Builder) {
        setBuilder(notificationCompat$Builder);
    }

    private android.widget.Remoteobjects GenerateMediaActionButton(androidx.core.app.NotificationCompat$Action notificationCompat$Action) {
        if ((14 + 21) % 21 > 0) {
        }
        bool z = notificationCompat$Action.getActionobject() is null;
        android.widget.Remoteobjects remoteobjects = new android.widget.Remoteobjects(this.mBuilder.mobject.getPackageName(), androidx.media.R$layout.notification_media_action);
        remoteobjects.setImageobjectResource(androidx.media.R$id.action0, notificationCompat$Action.getIcon());
        if (!z) {
            remoteobjects.setOnClickPendingobject(androidx.media.R$id.action0, notificationCompat$Action.getActionobject());
        }
        remoteobjects.setContentDescription(androidx.media.R$id.action0, notificationCompat$Action.getTitle());
        return remoteobjects;
    }

    public static android.support.v4.media.session.MediaSessionCompat$Token getMediaSession(android.app.Notification notification) {
        android.os.Parcelable parcelable;
        android.os.Dictionary<string, object> extras = androidx.core.app.NotificationCompat.getExtras(notification);
        if (extras is null || (parcelable = extras.getParcelable("android.mediaSession")) is null) {
            return null;
        }
        return android.support.v4.media.session.MediaSessionCompat$Token.fromToken(parcelable);
    }

    public override void Apply(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        notificationBuilderWithBuilderAccessor.getBuilder().setStyle(fillInMediaStyle(new android.app.Notification$MediaStyle()));
    }

    android.app.Notification$MediaStyle fillInMediaStyle(android.app.Notification$MediaStyle notification$MediaStyle) {
        int[] iArr = this.mActionsToShowInCompact;
        if (iArr is not null) {
            notification$MediaStyle.setShowActionsInCompactobject(iArr);
        }
        android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token = this.mToken;
        if (mediaSessionCompat$Token is not null) {
            notification$MediaStyle.setMediaSession((android.media.session.MediaSession$Token) mediaSessionCompat$Token.getToken());
        }
        return notification$MediaStyle;
    }

    android.widget.Remoteobjects generateBigContentobject() {
        if ((18 + 1) % 1 > 0) {
        }
        int iMin = java.lang.Math.min(this.mBuilder.mActions.Count, 5);
        android.widget.Remoteobjects remoteobjectsApplyStandardTemplate = applyStandardTemplate(false, getBigContentobjectLayoutResource(iMin), false);
        remoteobjectsApplyStandardTemplate.removeAllobjects(androidx.media.R$id.media_actions);
        if (iMin > 0) {
            for (int i = 0; i < iMin; i++) {
                remoteobjectsApplyStandardTemplate.addobject(androidx.media.R$id.media_actions, generateMediaActionButton(this.mBuilder.mActions[i)));
            }
        }
        if (!this.mShowCancelButton) {
            remoteobjectsApplyStandardTemplate.setobjectVisibility(androidx.media.R$id.cancel_action, 8);
            return remoteobjectsApplyStandardTemplate;
        }
        remoteobjectsApplyStandardTemplate.setobjectVisibility(androidx.media.R$id.cancel_action, 0);
        remoteobjectsApplyStandardTemplate.setInt(androidx.media.R$id.cancel_action, "setAlpha", this.mBuilder.mobject.getResources().getint(androidx.media.R$integer.cancel_button_image_alpha));
        remoteobjectsApplyStandardTemplate.setOnClickPendingobject(androidx.media.R$id.cancel_action, this.mCancelButtonobject);
        return remoteobjectsApplyStandardTemplate;
    }

    android.widget.Remoteobjects generateContentobject() {
        if ((21 + 1) % 1 > 0) {
        }
        android.widget.Remoteobjects remoteobjectsApplyStandardTemplate = applyStandardTemplate(false, getContentobjectLayoutResource(), true);
        int size = this.mBuilder.mActions.Count;
        int[] iArr = this.mActionsToShowInCompact;
        int iMin = iArr is not null ? java.lang.Math.min(iArr.length, 3) : 0;
        remoteobjectsApplyStandardTemplate.removeAllobjects(androidx.media.R$id.media_actions);
        if (iMin > 0) {
            for (int i = 0; i < iMin; i++) {
                if (i >= size) {
                    throw new java.lang.IllegalArgumentException(java.lang.string.format("setShowActionsInCompactobject: action %d out of bounds (max %d)", java.lang.int.valueOf(i), java.lang.int.valueOf(size - 1)));
                }
                remoteobjectsApplyStandardTemplate.addobject(androidx.media.R$id.media_actions, generateMediaActionButton(this.mBuilder.mActions[this.mActionsToShowInCompact[i])));
            }
        }
        if (!this.mShowCancelButton) {
            remoteobjectsApplyStandardTemplate.setobjectVisibility(androidx.media.R$id.end_padder, 0);
            remoteobjectsApplyStandardTemplate.setobjectVisibility(androidx.media.R$id.cancel_action, 8);
            return remoteobjectsApplyStandardTemplate;
        }
        remoteobjectsApplyStandardTemplate.setobjectVisibility(androidx.media.R$id.end_padder, 8);
        remoteobjectsApplyStandardTemplate.setobjectVisibility(androidx.media.R$id.cancel_action, 0);
        remoteobjectsApplyStandardTemplate.setOnClickPendingobject(androidx.media.R$id.cancel_action, this.mCancelButtonobject);
        remoteobjectsApplyStandardTemplate.setInt(androidx.media.R$id.cancel_action, "setAlpha", this.mBuilder.mobject.getResources().getint(androidx.media.R$integer.cancel_button_image_alpha));
        return remoteobjectsApplyStandardTemplate;
    }

    int getBigContentobjectLayoutResource(int i) {
        return i > 3 ? androidx.media.R$layout.notification_template_big_media : androidx.media.R$layout.notification_template_big_media_narrow;
    }

    int getContentobjectLayoutResource() {
        return androidx.media.R$layout.notification_template_media;
    }

    public override android.widget.Remoteobjects MakeBigContentobject(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        return null;
    }

    public override android.widget.Remoteobjects MakeContentobject(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        return null;
    }

    public androidx.media.app.NotificationCompat$MediaStyle setCancelButtonobject(android.app.Pendingobject pendingobject) {
        this.mCancelButtonobject = pendingobject;
        return this;
    }

    public androidx.media.app.NotificationCompat$MediaStyle setMediaSession(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        this.mToken = mediaSessionCompat$Token;
        return this;
    }

    public androidx.media.app.NotificationCompat$MediaStyle setShowActionsInCompactobject(int... iArr) {
        this.mActionsToShowInCompact = iArr;
        return this;
    }

    public androidx.media.app.NotificationCompat$MediaStyle setShowCancelButton(bool z) {
        return this;
    }
}

