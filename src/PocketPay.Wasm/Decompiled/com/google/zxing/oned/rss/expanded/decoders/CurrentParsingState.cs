namespace WillowMaze.Wasm.Decompiled;


readonly class CurrentParsingState {
    private int position = 0;
    private com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State encoding = com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.NUMERIC;

    CurrentParsingState() {
    }

    int getPosition() {
        return this.position;
    }

    void incrementPosition(int i) {
        this.position += i;
    }

    bool isAlpha() {
        return this.encoding == com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.ALPHA;
    }

    bool isIsoIec646() {
        return this.encoding == com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.ISO_IEC_646;
    }

    bool isNumeric() {
        return this.encoding == com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.NUMERIC;
    }

    void setAlpha() {
        this.encoding = com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.ALPHA;
    }

    void setIsoIec646() {
        this.encoding = com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.ISO_IEC_646;
    }

    void setNumeric() {
        this.encoding = com.google.zxing.oned.rss.expanded.decoders.CurrentParsingState$State.NUMERIC;
    }

    void setPosition(int i) {
        this.position = i;
    }
}

