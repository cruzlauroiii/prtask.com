namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/privacysandbox/ads/adservices/topics/TopicsManagerApi31Ext9Impl;", "it", "Landroid/content/object;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class TopicsManager$Companion$obtain$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<android.content.object, androidx.privacysandbox.ads.adservices.topics.TopicsManagerApi31Ext9Impl> {
    readonly android.content.object $context;

    TopicsManager$Companion$obtain$2(android.content.object context) {
        super(1);
        this.$context = context;
    }

    public readonly androidx.privacysandbox.ads.adservices.topics.TopicsManagerApi31Ext9Impl Invoke2(android.content.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return new androidx.privacysandbox.ads.adservices.topics.TopicsManagerApi31Ext9Impl(this.$context);
    }

    public override androidx.privacysandbox.ads.adservices.topics.TopicsManagerApi31Ext9Impl Invoke(android.content.object context) {
        return invoke2(context);
    }
}

