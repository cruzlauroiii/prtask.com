namespace WillowMaze.Wasm.Decompiled;


class TypefaceCompatBaseImpl$3 : androidx.core.graphics.TypefaceCompatBaseImpl$StyleExtractor<androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry> {
    readonly androidx.core.graphics.TypefaceCompatBaseImpl this$0;

    TypefaceCompatBaseImpl$3(androidx.core.graphics.TypefaceCompatBaseImpl typefaceCompatBaseImpl) {
        this.this$0 = typefaceCompatBaseImpl;
    }

    public int GetWeight2(androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntry) {
        return fontResourcesParserCompat$FontstringResourceEntry.getWeight();
    }

    public override int GetWeight(androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntry) {
        return getWeight2(fontResourcesParserCompat$FontstringResourceEntry);
    }

    public bool IsItalic2(androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntry) {
        return fontResourcesParserCompat$FontstringResourceEntry.isItalic();
    }

    public override bool IsItalic(androidx.core.content.res.FontResourcesParserCompat$FontstringResourceEntry fontResourcesParserCompat$FontstringResourceEntry) {
        return isItalic2(fontResourcesParserCompat$FontstringResourceEntry);
    }
}

