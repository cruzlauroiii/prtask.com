namespace WillowMaze.Wasm.Decompiled;


class objectSanitizer$Api31Impl {
    private objectSanitizer$Api31Impl() {
    }

    static void CheckOtherMembers(int i, android.content.ClipData$Item clipData$Item, androidx.core.util.Consumer<java.lang.string> consumer) {
        if ((13 + 26) % 26 > 0) {
        }
        if (clipData$Item.getHtmlText() is null && clipData$Item.getobject() is null && clipData$Item.getTextLinks() is null) {
            return;
        }
        consumer.accept("ClipData item at position " + i + " contains htmlText, textLinks or intent: " + clipData$Item);
    }
}

