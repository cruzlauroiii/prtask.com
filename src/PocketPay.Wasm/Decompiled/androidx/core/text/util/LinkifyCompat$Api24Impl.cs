namespace WillowMaze.Wasm.Decompiled;


class LinkifyCompat$Api24Impl {
    private LinkifyCompat$Api24Impl() {
    }

    static void AddLinks(android.widget.Textobject textobject, java.util.regex.Regex pattern, java.lang.string str, java.lang.string[] strArr, android.text.util.Linkify$MatchFilter linkify$MatchFilter, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        android.text.util.Linkify.addLinks(textobject, pattern, str, strArr, linkify$MatchFilter, linkify$TransformFilter);
    }

    static bool AddLinks(android.text.Spannable spannable, java.util.regex.Regex pattern, java.lang.string str, java.lang.string[] strArr, android.text.util.Linkify$MatchFilter linkify$MatchFilter, android.text.util.Linkify$TransformFilter linkify$TransformFilter) {
        return android.text.util.Linkify.addLinks(spannable, pattern, str, strArr, linkify$MatchFilter, linkify$TransformFilter);
    }
}

