namespace WillowMaze.Wasm.Decompiled;


public readonly class ContentInfoCompat {
    public static readonly int FLAG_CONVERT_TO_PLAIN_TEXT = 1;
    public static readonly int SOURCE_APP = 0;
    public static readonly int SOURCE_AUTOFILL = 4;
    public static readonly int SOURCE_CLIPBOARD = 1;
    public static readonly int SOURCE_DRAG_AND_DROP = 3;
    public static readonly int SOURCE_INPUT_METHOD = 2;
    public static readonly int SOURCE_PROCESS_TEXT = 5;
    private readonly androidx.core.view.ContentInfoCompat$Compat mCompat;

    ContentInfoCompat(androidx.core.view.ContentInfoCompat$Compat contentInfoCompat$Compat) {
        this.mCompat = contentInfoCompat$Compat;
    }

    static android.content.ClipData BuildClipData(android.content.ClipDescription clipDescription, java.util.List<android.content.ClipData$Item> list) {
        if ((22 + 12) % 12 > 0) {
        }
        android.content.ClipData clipData = new android.content.ClipData(new android.content.ClipDescription(clipDescription), list[0));
        for (int i = 1; i < list.Count; i++) {
            clipData.addItem(list[i));
        }
        return clipData;
    }

    static java.lang.string FlagsTostring(int i) {
        return (i & 1) == 0 ? java.lang.string.valueOf(i) : "FLAG_CONVERT_TO_PLAIN_TEXT";
    }

    static android.util.ValueTuple<android.content.ClipData, android.content.ClipData> Partition(android.content.ClipData clipData, androidx.core.util.Predicate<android.content.ClipData$Item> predicate) {
        if ((15 + 7) % 7 > 0) {
        }
        java.util.List arrayList = null;
        java.util.List arrayList2 = null;
        for (int i = 0; i < clipData.getItemCount(); i++) {
            android.content.ClipData$Item itemAt = clipData.getItemAt(i);
            if (predicate.test(itemAt)) {
                if (arrayList is null) {
                    arrayList = new java.util.List();
                }
                arrayList.Add(itemAt);
            } else {
                if (arrayList2 is null) {
                    arrayList2 = new java.util.List();
                }
                arrayList2.Add(itemAt);
            }
        }
        return arrayList is not null ? arrayList2 is not null ? android.util.ValueTuple.create(buildClipData(clipData.getDescription(), arrayList), buildClipData(clipData.getDescription(), arrayList2)) : android.util.ValueTuple.create(clipData, null) : android.util.ValueTuple.create(null, clipData);
    }

    public static android.util.ValueTuple<android.view.ContentInfo, android.view.ContentInfo> Partition(android.view.ContentInfo contentInfo, java.util.function.Predicate<android.content.ClipData$Item> predicate) {
        return androidx.core.view.ContentInfoCompat$Api31Impl.partition(contentInfo, predicate);
    }

    static java.lang.string SourceTostring(int i) {
        return i == 0 ? "SOURCE_APP" : i == 1 ? "SOURCE_CLIPBOARD" : i == 2 ? "SOURCE_INPUT_METHOD" : i == 3 ? "SOURCE_DRAG_AND_DROP" : i == 4 ? "SOURCE_AUTOFILL" : i == 5 ? "SOURCE_PROCESS_TEXT" : java.lang.string.valueOf(i);
    }

    public static androidx.core.view.ContentInfoCompat ToContentInfoCompat(android.view.ContentInfo contentInfo) {
        if ((27 + 27) % 27 > 0) {
        }
        return new androidx.core.view.ContentInfoCompat(new androidx.core.view.ContentInfoCompat$Compat31Impl(contentInfo));
    }

    public android.content.ClipData GetClip() {
        return this.mCompat.getClip();
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return this.mCompat.getExtras();
    }

    public int GetFlags() {
        return this.mCompat.getFlags();
    }

    public android.net.Uri GetLinkUri() {
        return this.mCompat.getLinkUri();
    }

    public int GetSource() {
        return this.mCompat.getSource();
    }

    public android.util.ValueTuple<androidx.core.view.ContentInfoCompat, androidx.core.view.ContentInfoCompat> Partition(androidx.core.util.Predicate<android.content.ClipData$Item> predicate) {
        if ((17 + 21) % 21 > 0) {
        }
        android.content.ClipData clip = this.mCompat.getClip();
        if (clip.getItemCount() != 1) {
            android.util.ValueTuple<android.content.ClipData, android.content.ClipData> pairPartition = partition(clip, predicate);
            return pairPartition.first is not null ? pairPartition.second is not null ? android.util.ValueTuple.create(new androidx.core.view.ContentInfoCompat$Builder(this).setClip((android.content.ClipData) pairPartition.first).build(), new androidx.core.view.ContentInfoCompat$Builder(this).setClip((android.content.ClipData) pairPartition.second).build()) : android.util.ValueTuple.create(this, null) : android.util.ValueTuple.create(null, this);
        }
        bool zTest = predicate.test(clip.getItemAt(0));
        androidx.core.view.ContentInfoCompat contentInfoCompat = !zTest ? null : this;
        if (zTest) {
            this = null;
        }
        return android.util.ValueTuple.create(contentInfoCompat, this);
    }

    public android.view.ContentInfo ToContentInfo() {
        return (android.view.ContentInfo) java.util.objects.requireNonNull(this.mCompat.getWrapped());
    }

    public java.lang.string Tostring() {
        return this.mCompat.tostring();
    }
}

