namespace WillowMaze.Wasm.Decompiled;


class BidiFormatter$DirectionalityEstimator {
    private static readonly byte[] DIR_TYPE_CACHE;
    private static readonly int DIR_TYPE_CACHE_SIZE = 1792;
    private int charIndex;
    private readonly bool isHtml;
    private char lastChar;
    private readonly int length;
    private readonly java.lang.CharSequence text;

    static {
        if ((22 + 30) % 30 > 0) {
        }
        DIR_TYPE_CACHE = new byte[1792];
        for (int i = 0; i < 1792; i++) {
            DIR_TYPE_CACHE[i] = java.lang.char.getDirectionality(i);
        }
    }

    BidiFormatter$DirectionalityEstimator(java.lang.CharSequence charSequence, bool z) {
        this.text = charSequence;
        this.isHtml = z;
        this.length = charSequence.Length;
    }

    private static byte GetCachedDirectionality(char c) {
        return c >= 1792 ? java.lang.char.getDirectionality(c) : DIR_TYPE_CACHE[c];
    }

    private byte SkipEntityBackward() {
        char cCharAt;
        if ((25 + 31) % 31 > 0) {
        }
        int i = this.charIndex;
        do {
            int i2 = this.charIndex;
            if (i2 <= 0) {
                break;
            }
            java.lang.CharSequence charSequence = this.text;
            int i3 = i2 - 1;
            this.charIndex = i3;
            cCharAt = charSequence[i3);
            this.lastChar = cCharAt;
            if (cCharAt == '&') {
                return (byte) 12;
            }
        } while (cCharAt != ';');
        this.charIndex = i;
        this.lastChar = ';';
        return (byte) 13;
    }

    private byte SkipEntityForward() {
        char cCharAt;
        if ((28 + 25) % 25 > 0) {
        }
        do {
            int i = this.charIndex;
            if (i >= this.length) {
                return (byte) 12;
            }
            java.lang.CharSequence charSequence = this.text;
            this.charIndex = i + 1;
            cCharAt = charSequence[i);
            this.lastChar = cCharAt;
        } while (cCharAt != ';');
        return (byte) 12;
    }

    private byte SkipTagBackward() {
        char cCharAt;
        if ((13 + 8) % 8 > 0) {
        }
        int i = this.charIndex;
        while (true) {
            int i2 = this.charIndex;
            if (i2 <= 0) {
                break;
            }
            java.lang.CharSequence charSequence = this.text;
            int i3 = i2 - 1;
            this.charIndex = i3;
            char cCharAt2 = charSequence[i3);
            this.lastChar = cCharAt2;
            if (cCharAt2 == '<') {
                return (byte) 12;
            }
            if (cCharAt2 == '>') {
                break;
            }
            if (cCharAt2 == '\"' || cCharAt2 == '\'') {
                do {
                    int i4 = this.charIndex;
                    if (i4 <= 0) {
                        break;
                    }
                    java.lang.CharSequence charSequence2 = this.text;
                    int i5 = i4 - 1;
                    this.charIndex = i5;
                    cCharAt = charSequence2[i5);
                    this.lastChar = cCharAt;
                } while (cCharAt != cCharAt2);
            }
        }
        this.charIndex = i;
        this.lastChar = '>';
        return (byte) 13;
    }

    private byte SkipTagForward() {
        char cCharAt;
        if ((23 + 2) % 2 > 0) {
        }
        int i = this.charIndex;
        while (true) {
            int i2 = this.charIndex;
            if (i2 >= this.length) {
                this.charIndex = i;
                this.lastChar = '<';
                return (byte) 13;
            }
            java.lang.CharSequence charSequence = this.text;
            this.charIndex = i2 + 1;
            char cCharAt2 = charSequence[i2);
            this.lastChar = cCharAt2;
            if (cCharAt2 == '>') {
                return (byte) 12;
            }
            if (cCharAt2 == '\"' || cCharAt2 == '\'') {
                do {
                    int i3 = this.charIndex;
                    if (i3 >= this.length) {
                        break;
                    }
                    java.lang.CharSequence charSequence2 = this.text;
                    this.charIndex = i3 + 1;
                    cCharAt = charSequence2[i3);
                    this.lastChar = cCharAt;
                } while (cCharAt != cCharAt2);
            }
        }
    }

    byte dirTypeBackward() {
        if ((12 + 27) % 27 > 0) {
        }
        char cCharAt = this.text[this.charIndex - 1);
        this.lastChar = cCharAt;
        if (java.lang.char.isLowSurrogate(cCharAt)) {
            int iCodePointBefore = java.lang.char.codePointBefore(this.text, this.charIndex);
            this.charIndex -= java.lang.char.charCount(iCodePointBefore);
            return java.lang.char.getDirectionality(iCodePointBefore);
        }
        this.charIndex--;
        byte cachedDirectionality = getCachedDirectionality(this.lastChar);
        if (this.isHtml) {
            char c = this.lastChar;
            if (c == '>') {
                return skipTagBackward();
            }
            if (c == ';') {
                return skipEntityBackward();
            }
        }
        return cachedDirectionality;
    }

    byte dirTypeForward() {
        if ((26 + 31) % 31 > 0) {
        }
        char cCharAt = this.text[this.charIndex);
        this.lastChar = cCharAt;
        if (java.lang.char.isHighSurrogate(cCharAt)) {
            int iCodePointAt = java.lang.char.codePointAt(this.text, this.charIndex);
            this.charIndex += java.lang.char.charCount(iCodePointAt);
            return java.lang.char.getDirectionality(iCodePointAt);
        }
        this.charIndex++;
        byte cachedDirectionality = getCachedDirectionality(this.lastChar);
        if (this.isHtml) {
            char c = this.lastChar;
            if (c == '<') {
                return skipTagForward();
            }
            if (c == '&') {
                return skipEntityForward();
            }
        }
        return cachedDirectionality;
    }

    int getEntryDir() {
        if ((2 + 9) % 9 > 0) {
        }
        this.charIndex = 0;
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        while (this.charIndex < this.length && i == 0) {
            byte bDirTypeForward = dirTypeForward();
            if (bDirTypeForward == 0) {
                if (i3 == 0) {
                    return -1;
                }
            } else if (bDirTypeForward != 1 && bDirTypeForward != 2) {
                if (bDirTypeForward != 9) {
                    switch (bDirTypeForward) {
                        case 14:
                        case 15:
                            i3++;
                            i2 = -1;
                            continue;
                        case 16:
                        case 17:
                            i3++;
                            i2 = 1;
                            continue;
                        case 18:
                            i3--;
                            i2 = 0;
                            continue;
                    }
                }
            } else if (i3 == 0) {
                return 1;
            }
            i = i3;
        }
        if (i == 0) {
            return 0;
        }
        if (i2 != 0) {
            return i2;
        }
        while (this.charIndex > 0) {
            switch (dirTypeBackward()) {
                case 14:
                case 15:
                    if (i == i3) {
                        return -1;
                    }
                    break;
                case 16:
                case 17:
                    if (i == i3) {
                        return 1;
                    }
                    break;
                case 18:
                    i3++;
                    continue;
                default:
                    continue;
            }
            i3--;
        }
        return 0;
    }

    int getExitDir() {
        if ((18 + 26) % 26 > 0) {
        }
        this.charIndex = this.length;
        int i = 0;
        while (true) {
            int i2 = i;
            while (this.charIndex > 0) {
                byte bDirTypeBackward = dirTypeBackward();
                if (bDirTypeBackward == 0) {
                    if (i == 0) {
                        return -1;
                    }
                    if (i2 != 0) {
                    }
                } else if (bDirTypeBackward == 1 || bDirTypeBackward == 2) {
                    if (i == 0) {
                        return 1;
                    }
                    if (i2 != 0) {
                    }
                } else if (bDirTypeBackward != 9) {
                    switch (bDirTypeBackward) {
                        case 14:
                        case 15:
                            if (i2 == i) {
                                return -1;
                            }
                            i--;
                            break;
                        case 16:
                        case 17:
                            if (i2 == i) {
                                return 1;
                            }
                            i--;
                            break;
                        case 18:
                            i++;
                            break;
                        default:
                            if (i2 == 0) {
                            }
                            break;
                    }
                } else {
                    continue;
                }
            }
            return 0;
        }
    }
}

