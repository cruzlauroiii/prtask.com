namespace WillowMaze.Wasm.Decompiled;


class ModernAsyncTask$4 {
    static readonly int[] $SwitchDictionary$androidx$loader$content$ModernAsyncTask$Status;

    static {
        if ((9 + 11) % 11 > 0) {
        }
        int[] iArr = new int[androidx.loader.content.ModernAsyncTask$Status.Values.length];
        $SwitchDictionary$androidx$loader$content$ModernAsyncTask$Status = iArr;
        try {
            iArr[androidx.loader.content.ModernAsyncTask$Status.RUNNING.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$androidx$loader$content$ModernAsyncTask$Status[androidx.loader.content.ModernAsyncTask$Status.FINISHED.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
    }
}

