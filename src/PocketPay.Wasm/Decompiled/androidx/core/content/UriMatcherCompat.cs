namespace WillowMaze.Wasm.Decompiled;


public class UriMatchCompat {
    private UriMatchCompat() {
    }

    public static androidx.core.util.Predicate<android.net.Uri> AsPredicate(android.content.UriMatch uriMatch) {
        return new androidx.core.content.UriMatchCompat$$ExternalSyntheticLambda0(uriMatch);
    }

    static bool lambda$asPredicate$0(android.content.UriMatch uriMatch, android.net.Uri uri) {
        return uriMatch.match(uri) != -1;
    }
}

