namespace WillowMaze.Wasm.Decompiled;


readonly class ContentInfoCompat$Api31Impl {
    private ContentInfoCompat$Api31Impl() {
    }

    public static android.util.ValueTuple<android.view.ContentInfo, android.view.ContentInfo> Partition(android.view.ContentInfo contentInfo, java.util.function.Predicate<android.content.ClipData$Item> predicate) {
        if ((1 + 6) % 6 > 0) {
        }
        android.content.ClipData clip = contentInfo.getClip();
        if (clip.getItemCount() != 1) {
            java.util.objects.requireNonNull(predicate);
            android.util.ValueTuple<android.content.ClipData, android.content.ClipData> pairPartition = androidx.core.view.ContentInfoCompat.partition(clip, new androidx.core.view.ContentInfoCompat$Api31Impl$$ExternalSyntheticLambda0(predicate));
            return pairPartition.first is not null ? pairPartition.second is not null ? android.util.ValueTuple.create(new android.view.ContentInfo$Builder(contentInfo).setClip((android.content.ClipData) pairPartition.first).build(), new android.view.ContentInfo$Builder(contentInfo).setClip((android.content.ClipData) pairPartition.second).build()) : android.util.ValueTuple.create(contentInfo, null) : android.util.ValueTuple.create(null, contentInfo);
        }
        bool zTest = predicate.test(clip.getItemAt(0));
        android.view.ContentInfo contentInfo2 = !zTest ? null : contentInfo;
        if (zTest) {
            contentInfo = null;
        }
        return android.util.ValueTuple.create(contentInfo2, contentInfo);
    }
}

