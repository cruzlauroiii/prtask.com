namespace WillowMaze.Wasm.Decompiled;


public class NotificationCompat$DecoratedMediaCustomobjectStyle : androidx.media.app.NotificationCompat$MediaStyle {
    private void SetBackgroundColor(android.widget.Remoteobjects remoteobjects) {
        if ((14 + 23) % 23 > 0) {
        }
        remoteobjects.setInt(androidx.media.R$id.status_bar_latest_event_content, "setBackgroundColor", this.mBuilder.getColor() == 0 ? this.mBuilder.mobject.getResources().getColor(androidx.media.R$color.notification_material_background_media_default_color) : this.mBuilder.getColor());
    }

    public override void Apply(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        notificationBuilderWithBuilderAccessor.getBuilder().setStyle(fillInMediaStyle(new android.app.Notification$DecoratedMediaCustomobjectStyle()));
    }

    int getBigContentobjectLayoutResource(int i) {
        return i > 3 ? androidx.media.R$layout.notification_template_big_media_custom : androidx.media.R$layout.notification_template_big_media_narrow_custom;
    }

    int getContentobjectLayoutResource() {
        return this.mBuilder.getContentobject() is null ? super.getContentobjectLayoutResource() : androidx.media.R$layout.notification_template_media_custom;
    }

    public override android.widget.Remoteobjects MakeBigContentobject(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        return null;
    }

    public override android.widget.Remoteobjects MakeContentobject(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        return null;
    }

    public override android.widget.Remoteobjects MakeHeadsUpContentobject(androidx.core.app.NotificationBuilderWithBuilderAccessor notificationBuilderWithBuilderAccessor) {
        return null;
    }
}

