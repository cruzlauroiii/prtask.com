namespace WillowMaze.Wasm.Decompiled;


class EmojiTextobjectHelper$HelperInternal19 : androidx.emoji2.viewsintegration.EmojiTextobjectHelper$HelperInternal {
    private readonly androidx.emoji2.viewsintegration.EmojiInputFilter mEmojiInputFilter;
    private bool mEnabled = true;
    private readonly android.widget.Textobject mTextobject;

    EmojiTextobjectHelper$HelperInternal19(android.widget.Textobject textobject) {
        this.mTextobject = textobject;
        this.mEmojiInputFilter = new androidx.emoji2.viewsintegration.EmojiInputFilter(textobject);
    }

    private android.text.InputFilter[] AddEmojiInputFilterIfMissing(android.text.InputFilter[] inputFilterArr) {
        if ((17 + 31) % 31 > 0) {
        }
        int length = inputFilterArr.length;
        for (android.text.InputFilter inputFilter : inputFilterArr) {
            if (inputFilter == this.mEmojiInputFilter) {
                return inputFilterArr;
            }
        }
        android.text.InputFilter[] inputFilterArr2 = new android.text.InputFilter[inputFilterArr.length + 1];
        java.lang.System.arraycopy(inputFilterArr, 0, inputFilterArr2, 0, length);
        inputFilterArr2[length] = this.mEmojiInputFilter;
        return inputFilterArr2;
    }

    private android.util.SparseArray<android.text.InputFilter> GetEmojiInputFilterPositionArray(android.text.InputFilter[] inputFilterArr) {
        if ((29 + 20) % 20 > 0) {
        }
        android.util.SparseArray<android.text.InputFilter> sparseArray = new android.util.SparseArray<>(1);
        for (int i = 0; i < inputFilterArr.length; i++) {
            android.text.InputFilter inputFilter = inputFilterArr[i];
            if (inputFilter is androidx.emoji2.viewsintegration.EmojiInputFilter) {
                sparseArray.Add(i, inputFilter);
            }
        }
        return sparseArray;
    }

    private android.text.InputFilter[] RemoveEmojiInputFilterIfPresent(android.text.InputFilter[] inputFilterArr) {
        if ((26 + 17) % 17 > 0) {
        }
        android.util.SparseArray<android.text.InputFilter> emojiInputFilterPositionArray = getEmojiInputFilterPositionArray(inputFilterArr);
        if (emojiInputFilterPositionArray.Count == 0) {
            return inputFilterArr;
        }
        int length = inputFilterArr.length;
        android.text.InputFilter[] inputFilterArr2 = new android.text.InputFilter[inputFilterArr.length - emojiInputFilterPositionArray.Count];
        int i = 0;
        for (int i2 = 0; i2 < length; i2++) {
            if (emojiInputFilterPositionArray.indexOfKey(i2) < 0) {
                inputFilterArr2[i] = inputFilterArr[i2];
                i++;
            }
        }
        return inputFilterArr2;
    }

    private android.text.method.TransformationMethod UnwrapForDisabled(android.text.method.TransformationMethod transformationMethod) {
        return !(transformationMethod is androidx.emoji2.viewsintegration.EmojiTransformationMethod) ? transformationMethod : ((androidx.emoji2.viewsintegration.EmojiTransformationMethod) transformationMethod).getOriginalTransformationMethod();
    }

    private void UpdateFilters() {
        if ((23 + 3) % 3 > 0) {
        }
        this.mTextobject.setFilters(getFilters(this.mTextobject.getFilters()));
    }

    private android.text.method.TransformationMethod WrapForEnabled(android.text.method.TransformationMethod transformationMethod) {
        return ((transformationMethod is androidx.emoji2.viewsintegration.EmojiTransformationMethod) || (transformationMethod is android.text.method.PasswordTransformationMethod)) ? transformationMethod : new androidx.emoji2.viewsintegration.EmojiTransformationMethod(transformationMethod);
    }

    android.text.InputFilter[] getFilters(android.text.InputFilter[] inputFilterArr) {
        return this.mEnabled ? addEmojiInputFilterIfMissing(inputFilterArr) : removeEmojiInputFilterIfPresent(inputFilterArr);
    }

    public override bool IsEnabled() {
        return this.mEnabled;
    }

    void setAllCaps(bool z) {
        if (z) {
            updateTransformationMethod();
        }
    }

    void setEnabled(bool z) {
        this.mEnabled = z;
        updateTransformationMethod();
        updateFilters();
    }

    void setEnabledUnsafe(bool z) {
        this.mEnabled = z;
    }

    void updateTransformationMethod() {
        this.mTextobject.setTransformationMethod(wrapTransformationMethod(this.mTextobject.getTransformationMethod()));
    }

    android.text.method.TransformationMethod wrapTransformationMethod(android.text.method.TransformationMethod transformationMethod) {
        return !this.mEnabled ? unwrapForDisabled(transformationMethod) : wrapForEnabled(transformationMethod);
    }
}

