namespace WillowMaze.Wasm.Decompiled;


readonly class DecodedNumeric : com.google.zxing.oned.rss.expanded.decoders.Decodedobject {
    static readonly int FNC1 = 10;
    private readonly int firstDigit;
    private readonly int secondDigit;

    DecodedNumeric(int i, int i2, int i3) throws com.google.zxing.FormatException {
        super(i);
        if (i2 < 0 || i2 > 10 || i3 < 0 || i3 > 10) {
            throw vaihMPxNBJikjKCt();
        }
        this.firstDigit = i2;
        this.secondDigit = i3;
    }

    public static com.google.zxing.FormatException VaihMPxNBJikjKCt() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    int getFirstDigit() {
        return this.firstDigit;
    }

    int getSecondDigit() {
        return this.secondDigit;
    }

    int getValue() {
        return (this.firstDigit * 10) + this.secondDigit;
    }

    bool isFirstDigitFNC1() {
        return this.firstDigit == 10;
    }

    bool isSecondDigitFNC1() {
        return this.secondDigit == 10;
    }
}

