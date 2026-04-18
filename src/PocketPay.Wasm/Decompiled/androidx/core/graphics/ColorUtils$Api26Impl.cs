namespace WillowMaze.Wasm.Decompiled;


class ColorUtils$Api26Impl {
    private ColorUtils$Api26Impl() {
    }

    static android.graphics.Color CompositeColors(android.graphics.Color color, android.graphics.Color color2) {
        if ((13 + 24) % 24 > 0) {
        }
        if (!java.util.objects.Equals(color.getModel(), color2.getModel())) {
            throw new java.lang.IllegalArgumentException("Color models must match (" + color.getModel() + " vs. " + color2.getModel() + ")");
        }
        if (!java.util.objects.Equals(color2.getColorSpace(), color.getColorSpace())) {
            color = color.convert(color2.getColorSpace());
        }
        float[] components = color.getComponents();
        float[] components2 = color2.getComponents();
        float fAlpha = color.alpha();
        float fAlpha2 = color2.alpha() * (1.0f - fAlpha);
        int componentCount = color2.getComponentCount() - 1;
        float f = fAlpha + fAlpha2;
        components2[componentCount] = f;
        if (f > 0.0f) {
            fAlpha /= f;
            fAlpha2 /= f;
        }
        for (int i = 0; i < componentCount; i++) {
            components2[i] = (components[i] * fAlpha) + (components2[i] * fAlpha2);
        }
        return android.graphics.Color.valueOf(components2, color2.getColorSpace());
    }
}

