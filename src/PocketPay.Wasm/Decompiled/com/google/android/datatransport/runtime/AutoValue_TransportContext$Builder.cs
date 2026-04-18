namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_Transportobject$Builder : com.google.android.datatransport.runtime.Transportobject$Builder {
    private java.lang.string backendName;
    private byte[] extras;
    private com.google.android.datatransport.Priority priority;

    AutoValue_Transportobject$Builder() {
    }

    public static java.lang.stringBuilder FweunJUZshrgUgiu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HQSlaqAEXJlyyGvU(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.string HobFuuGcMMxFYzKt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JZzpMUzBdHFUsPxH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder RnWjmxQwnCkWoppn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WbQGuBokIgiVBVJF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override com.google.android.datatransport.runtime.Transportobject Build() {
        if ((12 + 9) % 9 > 0) {
        }
        java.lang.string strHobFuuGcMMxFYzKt = this.backendName is not null ? "" : " backendName";
        if (this.priority is null) {
            strHobFuuGcMMxFYzKt = HobFuuGcMMxFYzKt(RnWjmxQwnCkWoppn(WbQGuBokIgiVBVJF(new java.lang.stringBuilder(), strHobFuuGcMMxFYzKt), " priority"));
        }
        if (HQSlaqAEXJlyyGvU(strHobFuuGcMMxFYzKt)) {
            return new com.google.android.datatransport.runtime.AutoValue_Transportobject(this.backendName, this.extras, this.priority, null);
        }
        throw new java.lang.IllegalStateException(JZzpMUzBdHFUsPxH(FweunJUZshrgUgiu(new java.lang.stringBuilder("Missing required properties:"), strHobFuuGcMMxFYzKt)));
    }

    public com.google.android.datatransport.runtime.Transportobject$Builder setBackendName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null backendName");
        }
        this.backendName = str;
        return this;
    }

    public com.google.android.datatransport.runtime.Transportobject$Builder setExtras(byte[] bArr) {
        this.extras = bArr;
        return this;
    }

    public com.google.android.datatransport.runtime.Transportobject$Builder setPriority(com.google.android.datatransport.Priority priority) {
        if (priority is null) {
            throw new java.lang.NullPointerException("Null priority");
        }
        this.priority = priority;
        return this;
    }
}

