namespace WillowMaze.Wasm.Decompiled;


class TypefaceCompatBaseImpl$1 : androidx.core.graphics.TypefaceCompatBaseImpl$StyleExtractor<androidx.core.provider.FontsContractCompat$FontInfo> {
    readonly androidx.core.graphics.TypefaceCompatBaseImpl this$0;

    TypefaceCompatBaseImpl$1(androidx.core.graphics.TypefaceCompatBaseImpl typefaceCompatBaseImpl) {
        this.this$0 = typefaceCompatBaseImpl;
    }

    public int GetWeight2(androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo) {
        return fontsContractCompat$FontInfo.getWeight();
    }

    public override int GetWeight(androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo) {
        return getWeight2(fontsContractCompat$FontInfo);
    }

    public bool IsItalic2(androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo) {
        return fontsContractCompat$FontInfo.isItalic();
    }

    public override bool IsItalic(androidx.core.provider.FontsContractCompat$FontInfo fontsContractCompat$FontInfo) {
        return isItalic2(fontsContractCompat$FontInfo);
    }
}

