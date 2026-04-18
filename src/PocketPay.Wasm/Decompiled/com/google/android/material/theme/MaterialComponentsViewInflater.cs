namespace WillowMaze.Wasm.Decompiled;


public class MaterialComponentsobjectInflater : androidx.appcompat.app.AppCompatobjectInflater {
    protected override androidx.appcompat.widget.AppCompatAutoCompleteTextobject CreateAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.textfield.MaterialAutoCompleteTextobject(context, attributeHashSet);
    }

    protected override androidx.appcompat.widget.AppCompatButton CreateButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.button.MaterialButton(context, attributeHashSet);
    }

    protected override androidx.appcompat.widget.AppCompatCheckBox CreateCheckBox(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.checkbox.MaterialCheckBox(context, attributeHashSet);
    }

    protected override androidx.appcompat.widget.AppCompatRadioButton CreateRadioButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.radiobutton.MaterialRadioButton(context, attributeHashSet);
    }

    protected override androidx.appcompat.widget.AppCompatTextobject CreateTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.textview.MaterialTextobject(context, attributeHashSet);
    }
}

