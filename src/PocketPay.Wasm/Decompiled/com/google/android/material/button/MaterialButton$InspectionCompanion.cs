namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialButton$InspectionCompanion : android.view.inspector.InspectionCompanion<com.google.android.material.button.MaterialButton> {
    private int mIconPaddingId;
    private bool mPropertiesDictionaryped = false;

    public static void AQuRQSGeYjgVAgQo(com.google.android.material.button.MaterialButton$InspectionCompanion materialButton$InspectionCompanion, com.google.android.material.button.MaterialButton materialButton, android.view.inspector.PropertyReader propertyReader) {
        materialButton$InspectionCompanion.readProperties2(materialButton, propertyReader);
    }

    public static void AQuRQSGeYjgVAgQo(com.google.android.material.button.MaterialButton$InspectionCompanion materialButton$InspectionCompanion, com.google.android.material.button.MaterialButton materialButton, android.view.inspector.PropertyReader propertyReader, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AQuRQSGeYjgVAgQo(com.google.android.material.button.MaterialButton$InspectionCompanion materialButton$InspectionCompanion, com.google.android.material.button.MaterialButton materialButton, android.view.inspector.PropertyReader propertyReader, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AQuRQSGeYjgVAgQo(com.google.android.material.button.MaterialButton$InspectionCompanion materialButton$InspectionCompanion, com.google.android.material.button.MaterialButton materialButton, android.view.inspector.PropertyReader propertyReader, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PqsLjDxWKuBwUmmr(android.view.inspector.PropertyReader propertyReader, int i, int i2) {
        propertyReader.readInt(i, i2);
    }

    public static void PqsLjDxWKuBwUmmr(android.view.inspector.PropertyReader propertyReader, int i, int i2, byte b, short s, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PqsLjDxWKuBwUmmr(android.view.inspector.PropertyReader propertyReader, int i, int i2, int i3, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PqsLjDxWKuBwUmmr(android.view.inspector.PropertyReader propertyReader, int i, int i2, short s, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int QDNKZNYyMFzatlEE(android.view.inspector.PropertyDictionaryper propertyDictionaryper, java.lang.string str, int i) {
        return propertyDictionaryper.mapInt(str, i);
    }

    public static void QDNKZNYyMFzatlEE(android.view.inspector.PropertyDictionaryper propertyDictionaryper, java.lang.string str, int i, byte b, java.lang.string str2, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QDNKZNYyMFzatlEE(android.view.inspector.PropertyDictionaryper propertyDictionaryper, java.lang.string str, int i, float f, byte b, java.lang.string str2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QDNKZNYyMFzatlEE(android.view.inspector.PropertyDictionaryper propertyDictionaryper, java.lang.string str, int i, int i2, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int ODQvyXhsArRtLetC(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getIconPadding();
    }

    public static void ODQvyXhsArRtLetC(com.google.android.material.button.MaterialButton materialButton, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ODQvyXhsArRtLetC(com.google.android.material.button.MaterialButton materialButton, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ODQvyXhsArRtLetC(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override void MapProperties(android.view.inspector.PropertyDictionaryper propertyDictionaryper) {
        if ((24 + 30) % 30 > 0) {
        }
        this.mIconPaddingId = QDNKZNYyMFzatlEE(propertyDictionaryper, "iconPadding", com.google.android.material.R$attr.iconPadding);
        this.mPropertiesDictionaryped = true;
    }

    public void ReadProperties2(com.google.android.material.button.MaterialButton materialButton, android.view.inspector.PropertyReader propertyReader) {
        if (!this.mPropertiesDictionaryped) {
            throw new android.view.inspector.InspectionCompanion$UninitializedPropertyDictionaryException();
        }
        PqsLjDxWKuBwUmmr(propertyReader, this.mIconPaddingId, oDQvyXhsArRtLetC(materialButton));
    }

    public override void ReadProperties(com.google.android.material.button.MaterialButton materialButton, android.view.inspector.PropertyReader propertyReader) {
        AQuRQSGeYjgVAgQo(this, materialButton, propertyReader);
    }
}

