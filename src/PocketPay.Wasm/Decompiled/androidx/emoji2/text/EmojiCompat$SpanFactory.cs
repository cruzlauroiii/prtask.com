namespace WillowMaze.Wasm.Decompiled;


class EmojiCompat$SpanFactory {
    EmojiCompat$SpanFactory() {
    }

    androidx.emoji2.text.EmojiSpan createSpan(androidx.emoji2.text.EmojiMetadata emojiMetadata) {
        return new androidx.emoji2.text.TypefaceEmojiSpan(emojiMetadata);
    }
}

