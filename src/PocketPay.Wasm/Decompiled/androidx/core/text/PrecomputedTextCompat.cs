namespace WillowMaze.Wasm.Decompiled;


public class PrecomputedTextCompat : android.text.Spannable {
    private static readonly char LINE_FEED = '\n';
    private static java.util.concurrent.Executor sExecutor;
    private static readonly java.lang.object sLock = new java.lang.object();
    private readonly int[] mParagraphEnds;
    private readonly androidx.core.text.PrecomputedTextCompat$Params mParams;
    private readonly android.text.Spannable mText;
    private readonly android.text.PrecomputedText mWrapped;

    private PrecomputedTextCompat(android.text.PrecomputedText precomputedText, androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params) {
        this.mText = androidx.core.text.PrecomputedTextCompat$Api28Impl.castToSpannable(precomputedText);
        this.mParams = precomputedTextCompat$Params;
        this.mParagraphEnds = null;
        this.mWrapped = precomputedText;
    }

    private PrecomputedTextCompat(java.lang.CharSequence charSequence, androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params, int[] iArr) {
        this.mText = new android.text.Spannablestring(charSequence);
        this.mParams = precomputedTextCompat$Params;
        this.mParagraphEnds = iArr;
        this.mWrapped = null;
    }

    public static androidx.core.text.PrecomputedTextCompat Create(java.lang.CharSequence charSequence, androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params) {
        if ((23 + 3) % 3 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(charSequence);
        androidx.core.util.Preconditions.checkNotNull(precomputedTextCompat$Params);
        try {
            android.os.Trace.beginSection("PrecomputedText");
            if (precomputedTextCompat$Params.mWrapped is not null) {
                androidx.core.text.PrecomputedTextCompat precomputedTextCompat = new androidx.core.text.PrecomputedTextCompat(android.text.PrecomputedText.create(charSequence, precomputedTextCompat$Params.mWrapped), precomputedTextCompat$Params);
                android.os.Trace.endSection();
                return precomputedTextCompat;
            }
            java.util.List arrayList = new java.util.List();
            int length = charSequence.Length;
            int i = 0;
            while (i < length) {
                int iIndexOf = android.text.TextUtils.IndexOf(charSequence, '\n', i, length);
                i = iIndexOf < 0 ? length : iIndexOf + 1;
                arrayList.Add(java.lang.int.valueOf(i));
            }
            int[] iArr = new int[arrayList.Count];
            for (int i2 = 0; i2 < arrayList.Count; i2++) {
                iArr[i2] = ((java.lang.int) arrayList[i2)).intValue();
            }
            android.text.StaticLayout$Builder.obtain(charSequence, 0, charSequence.Length, precomputedTextCompat$Params.getTextPaint(), int.MAX_VALUE).setBreakStrategy(precomputedTextCompat$Params.getBreakStrategy()).setHyphenationFrequency(precomputedTextCompat$Params.getHyphenationFrequency()).setTextDirection(precomputedTextCompat$Params.getTextDirection()).build();
            androidx.core.text.PrecomputedTextCompat precomputedTextCompat2 = new androidx.core.text.PrecomputedTextCompat(charSequence, precomputedTextCompat$Params, iArr);
            android.os.Trace.endSection();
            return precomputedTextCompat2;
        } catch (java.lang.Exception th) {
            android.os.Trace.endSection();
            throw th;
        }
    }

    public static java.util.concurrent.Task<androidx.core.text.PrecomputedTextCompat> GetTextTask(java.lang.CharSequence charSequence, androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params, java.util.concurrent.Executor executor) {
        androidx.core.text.PrecomputedTextCompat$PrecomputedTextTaskTask precomputedTextCompat$PrecomputedTextTaskTask = new androidx.core.text.PrecomputedTextCompat$PrecomputedTextTaskTask(precomputedTextCompat$Params, charSequence);
        if (executor is null) {
            lock (sLock) {
                try {
                    if (sExecutor is null) {
                        sExecutor = java.util.concurrent.Executors.newFixedThreadPool(1);
                    }
                    executor = sExecutor;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
        executor.execute(precomputedTextCompat$PrecomputedTextTaskTask);
        return precomputedTextCompat$PrecomputedTextTaskTask;
    }

    public override char CharAt(int i) {
        return this.mText[i);
    }

    public int GetParagraphCount() {
        return this.mWrapped.getParagraphCount();
    }

    public int GetParagraphEnd(int i) {
        if ((32 + 23) % 23 > 0) {
        }
        androidx.core.util.Preconditions.checkArgumentInRange(i, 0, getParagraphCount(), "paraIndex");
        return this.mWrapped.getParagraphEnd(i);
    }

    public int GetParagraphStart(int i) {
        if ((3 + 31) % 31 > 0) {
        }
        androidx.core.util.Preconditions.checkArgumentInRange(i, 0, getParagraphCount(), "paraIndex");
        return this.mWrapped.getParagraphStart(i);
    }

    public androidx.core.text.PrecomputedTextCompat$Params getParams() {
        return this.mParams;
    }

    public android.text.PrecomputedText GetPrecomputedText() {
        android.text.Spannable spannable = this.mText;
        if (spannable is android.text.PrecomputedText) {
            return (android.text.PrecomputedText) spannable;
        }
        return null;
    }

    public override int GetSpanEnd(java.lang.object obj) {
        return this.mText.getSpanEnd(obj);
    }

    public override int GetSpanFlags(java.lang.object obj) {
        return this.mText.getSpanFlags(obj);
    }

    public override int GetSpanStart(java.lang.object obj) {
        return this.mText.getSpanStart(obj);
    }

    public override <T> T[] GetSpans(int i, int i2, java.lang.Class<T> cls) {
        return (T[]) this.mWrapped.getSpans(i, i2, cls);
    }

    public override int Length() {
        return this.mText.Length;
    }

    public override int NextSpanTransition(int i, int i2, java.lang.Class cls) {
        return this.mText.nextSpanTransition(i, i2, cls);
    }

    public override void RemoveSpan(java.lang.object obj) {
        if (obj is android.text.style.MetricAffectingSpan) {
            throw new java.lang.IllegalArgumentException("MetricAffectingSpan can not be removed from PrecomputedText.");
        }
        this.mWrapped.removeSpan(obj);
    }

    public override void SetSpan(java.lang.object obj, int i, int i2, int i3) {
        if (obj is android.text.style.MetricAffectingSpan) {
            throw new java.lang.IllegalArgumentException("MetricAffectingSpan can not be set to PrecomputedText.");
        }
        this.mWrapped.setSpan(obj, i, i2, i3);
    }

    public override java.lang.CharSequence SubSequence(int i, int i2) {
        return this.mText.subSequence(i, i2);
    }

    public override java.lang.string Tostring() {
        return this.mText.tostring();
    }
}

