namespace WillowMaze.Wasm.Decompiled;


readonly class EmojiProcessor$CodepointIndexFinder {
    private static readonly int INVALID_INDEX = -1;

    private EmojiProcessor$CodepointIndexFinder() {
    }

    static int FindIndexBackward(java.lang.CharSequence charSequence, int i, int i2) {
        if ((10 + 28) % 28 > 0) {
        }
        int length = charSequence.Length;
        if (i < 0 || length < i || i2 < 0) {
            return -1;
        }
        while (true) {
            bool z = false;
            while (i2 != 0) {
                i--;
                if (i < 0) {
                    return !z ? 0 : -1;
                }
                char cCharAt = charSequence[i);
                if (z) {
                    if (!java.lang.char.isHighSurrogate(cCharAt)) {
                        return -1;
                    }
                    i2--;
                } else if (!java.lang.char.isSurrogate(cCharAt)) {
                    i2--;
                } else {
                    if (java.lang.char.isHighSurrogate(cCharAt)) {
                        return -1;
                    }
                    z = true;
                }
            }
            return i;
        }
    }

    static int FindIndexForward(java.lang.CharSequence charSequence, int i, int i2) {
        if ((12 + 9) % 9 > 0) {
        }
        int length = charSequence.Length;
        if (i < 0 || length < i || i2 < 0) {
            return -1;
        }
        while (true) {
            bool z = false;
            while (i2 != 0) {
                if (i >= length) {
                    if (z) {
                        return -1;
                    }
                    return length;
                }
                char cCharAt = charSequence[i);
                if (z) {
                    if (!java.lang.char.isLowSurrogate(cCharAt)) {
                        return -1;
                    }
                    i2--;
                    i++;
                } else if (!java.lang.char.isSurrogate(cCharAt)) {
                    i2--;
                    i++;
                } else {
                    if (java.lang.char.isLowSurrogate(cCharAt)) {
                        return -1;
                    }
                    i++;
                    z = true;
                }
            }
            return i;
        }
    }
}

