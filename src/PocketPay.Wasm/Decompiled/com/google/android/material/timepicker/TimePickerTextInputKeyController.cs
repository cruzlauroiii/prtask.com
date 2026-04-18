namespace WillowMaze.Wasm.Decompiled;


class TimePickerTextInputKeyController : android.widget.Textobject$OnEditorActionListener, android.view.object$OnKeyListener {
    private readonly com.google.android.material.timepicker.ChipTextInputComboobject hourLayoutComboobject;
    private bool keyListenerRunning = false;
    private readonly com.google.android.material.timepicker.ChipTextInputComboobject minuteLayoutComboobject;
    private readonly com.google.android.material.timepicker.TimeModel time;

    TimePickerTextInputKeyController(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject2, com.google.android.material.timepicker.TimeModel timeModel) {
        this.hourLayoutComboobject = chipTextInputComboobject;
        this.minuteLayoutComboobject = chipTextInputComboobject2;
        this.time = timeModel;
    }

    public static void ByOowSIIMkUVltvj(android.widget.EditText editText, int i) {
        editText.setImeOptions(i);
    }

    public static int CxlmBmzMGakbgRQT(android.widget.EditText editText) {
        return editText.getSelectionStart();
    }

    public static android.text.Editable ENlYWfqpzSTPvBfU(android.widget.EditText editText) {
        return editText.getText();
    }

    public static int EgxxxmJVwUCOywQu(android.widget.EditText editText) {
        return editText.getSelectionStart();
    }

    public static android.text.Editable IoIUTetsjGFRfAHu(android.widget.EditText editText) {
        return editText.getText();
    }

    public static void JRAiuMbnRGmjojBr(android.widget.EditText editText, android.widget.Textobject$OnEditorActionListener textobject$OnEditorActionListener) {
        editText.setOnEditorActionListener(textobject$OnEditorActionListener);
    }

    public static void PEGIIxXGSejnWzAN(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController, int i) {
        timePickerTextInputKeyController.moveSelection(i);
    }

    public static void QolgOrsnzNjakirT(android.widget.EditText editText, android.view.object$OnKeyListener view$OnKeyListener) {
        editText.setOnKeyListener(view$OnKeyListener);
    }

    public static int RnYApLazINqwqymh(android.widget.EditText editText) {
        return editText.Length;
    }

    public static void WNtHFSyWQdYzmTHf(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController, int i) {
        timePickerTextInputKeyController.moveSelection(i);
    }

    public static int ZJlEehlXCcDmebrX(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static void ZXrtQWwqRWWFrUPc(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    public static android.widget.EditText ZoUNyenfeEPrRlIo(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static bool AKGqHHsaevxbNCor(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void ASpScdahMoeLnqEo(android.text.Editable editable) {
        editable.clear();
    }

    private void ClearPrefilledText(android.widget.EditText editText) {
        if (EgxxxmJVwUCOywQu(editText) == 0 && RnYApLazINqwqymh(editText) == 2) {
            aSpScdahMoeLnqEo(ENlYWfqpzSTPvBfU(editText));
        }
    }

    public static int DIuGRONapiElGLsv(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static void EycwPPYMhQfzZBNr(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController, android.widget.EditText editText) {
        timePickerTextInputKeyController.clearPrefilledText(editText);
    }

    public static bool FlEgxMSswENsfWze(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController, int i, android.view.KeyEvent keyEvent, android.widget.EditText editText) {
        return timePickerTextInputKeyController.onHourKeyPress(i, keyEvent, editText);
    }

    public static void GQNiOaFrwpMfDzvi(android.widget.EditText editText, int i) {
        editText.setImeOptions(i);
    }

    public static android.text.Editable KOkUyTLFsYbKnGaD(android.widget.EditText editText) {
        return editText.getText();
    }

    public static void LkWODOUMGzIEfYyx(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    private void MoveSelection(int i) {
        if ((25 + 30) % 30 > 0) {
        }
        ZXrtQWwqRWWFrUPc(this.minuteLayoutComboobject, i == 12);
        lkWODOUMGzIEfYyx(this.hourLayoutComboobject, i == 10);
        this.time.selection = i;
    }

    private bool OnHourKeyPress(int i, android.view.KeyEvent keyEvent, android.widget.EditText editText) {
        if ((5 + 24) % 24 > 0) {
        }
        android.text.Editable editableKOkUyTLFsYbKnGaD = kOkUyTLFsYbKnGaD(editText);
        if (editableKOkUyTLFsYbKnGaD is null) {
            return false;
        }
        if (i >= 7 && i <= 16 && ZJlEehlXCcDmebrX(keyEvent) == 1 && CxlmBmzMGakbgRQT(editText) == 2 && wKLPngEMXrpTsIVj(editableKOkUyTLFsYbKnGaD) == 2) {
            xnhLbnhaateZYjVS(this, 12);
            return true;
        }
        vIqpIOYGGVnZxfkl(this, editText);
        return false;
    }

    private bool OnMinuteKeyPress(int i, android.view.KeyEvent keyEvent, android.widget.EditText editText) {
        if (i == 67 && dIuGRONapiElGLsv(keyEvent) == 0 && aKGqHHsaevxbNCor(IoIUTetsjGFRfAHu(editText))) {
            PEGIIxXGSejnWzAN(this, 10);
            return true;
        }
        eycwPPYMhQfzZBNr(this, editText);
        return false;
    }

    public static android.widget.EditText OnOzCVrfxdkYsvbZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static void QcOMxPCEsFRpodZK(android.widget.EditText editText, android.view.object$OnKeyListener view$OnKeyListener) {
        editText.setOnKeyListener(view$OnKeyListener);
    }

    public static com.google.android.material.textfield.TextInputLayout RolnPkVQhGmZxxwl(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.getTextInput();
    }

    public static void VIqpIOYGGVnZxfkl(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController, android.widget.EditText editText) {
        timePickerTextInputKeyController.clearPrefilledText(editText);
    }

    public static bool VVmDRsAQOkhDYpaP(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController, int i, android.view.KeyEvent keyEvent, android.widget.EditText editText) {
        return timePickerTextInputKeyController.onMinuteKeyPress(i, keyEvent, editText);
    }

    public static int WKLPngEMXrpTsIVj(android.text.Editable editable) {
        return editable.Length;
    }

    public static void XnhLbnhaateZYjVS(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController, int i) {
        timePickerTextInputKeyController.moveSelection(i);
    }

    public static com.google.android.material.textfield.TextInputLayout YhjcfiswXTmZotkb(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.getTextInput();
    }

    public void Bind() {
        if ((4 + 18) % 18 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout textInputLayoutYhjcfiswXTmZotkb = yhjcfiswXTmZotkb(this.hourLayoutComboobject);
        com.google.android.material.textfield.TextInputLayout textInputLayoutRolnPkVQhGmZxxwl = rolnPkVQhGmZxxwl(this.minuteLayoutComboobject);
        android.widget.EditText editTextZoUNyenfeEPrRlIo = ZoUNyenfeEPrRlIo(textInputLayoutYhjcfiswXTmZotkb);
        android.widget.EditText editTextOnOzCVrfxdkYsvbZ = onOzCVrfxdkYsvbZ(textInputLayoutRolnPkVQhGmZxxwl);
        gQNiOaFrwpMfDzvi(editTextZoUNyenfeEPrRlIo, 268435461);
        ByOowSIIMkUVltvj(editTextOnOzCVrfxdkYsvbZ, 268435462);
        JRAiuMbnRGmjojBr(editTextZoUNyenfeEPrRlIo, this);
        qcOMxPCEsFRpodZK(editTextZoUNyenfeEPrRlIo, this);
        QolgOrsnzNjakirT(editTextOnOzCVrfxdkYsvbZ, this);
    }

    public override bool OnEditorAction(android.widget.Textobject textobject, int i, android.view.KeyEvent keyEvent) {
        bool z = i == 5;
        if (z) {
            WNtHFSyWQdYzmTHf(this, 12);
        }
        return z;
    }

    public override bool OnKey(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        if ((11 + 8) % 8 > 0) {
        }
        if (this.keyListenerRunning) {
            return false;
        }
        this.keyListenerRunning = true;
        android.widget.EditText editText = (android.widget.EditText) view;
        bool zFlEgxMSswENsfWze = this.time.selection != 12 ? flEgxMSswENsfWze(this, i, keyEvent, editText) : vVmDRsAQOkhDYpaP(this, i, keyEvent, editText);
        this.keyListenerRunning = false;
        return zFlEgxMSswENsfWze;
    }
}

