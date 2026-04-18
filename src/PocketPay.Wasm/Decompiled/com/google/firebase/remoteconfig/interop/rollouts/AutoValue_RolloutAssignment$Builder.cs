namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_RolloutAssignment$Builder : com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder {
    private java.lang.string parameterKey;
    private java.lang.string parameterValue;
    private java.lang.string rolloutId;
    private byte set$0;
    private long templateVersion;
    private java.lang.string variantId;

    AutoValue_RolloutAssignment$Builder() {
    }

    public static java.lang.stringBuilder BRjhPvoIQGiMSCzQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DgQTYwLvbgWRKLLS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GXOcgIoasOmUsUcp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JzKnHcBYBlDdrMAv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SNwtIjXKgCZiKhEj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KNSSfKffqnHctDUR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SPIBQgyKpyBYuJeZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public override com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment Build() {
        if ((12 + 26) % 26 > 0) {
        }
        if (this.set$0 == 1 && this.rolloutId is not null && this.variantId is not null && this.parameterKey is not null && this.parameterValue is not null) {
            return new com.google.firebase.remoteconfig.interop.rollouts.AutoValue_RolloutAssignment(this.rolloutId, this.variantId, this.parameterKey, this.parameterValue, this.templateVersion, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.rolloutId is null) {
            BRjhPvoIQGiMSCzQ(sb, " rolloutId");
        }
        if (this.variantId is null) {
            kNSSfKffqnHctDUR(sb, " variantId");
        }
        if (this.parameterKey is null) {
            GXOcgIoasOmUsUcp(sb, " parameterKey");
        }
        if (this.parameterValue is null) {
            SNwtIjXKgCZiKhEj(sb, " parameterValue");
        }
        if ((this.set$0 & 1) == 0) {
            DgQTYwLvbgWRKLLS(sb, " templateVersion");
        }
        throw new java.lang.IllegalStateException(JzKnHcBYBlDdrMAv(sPIBQgyKpyBYuJeZ(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder setParameterKey(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null parameterKey");
        }
        this.parameterKey = str;
        return this;
    }

    public com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder setParameterValue(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null parameterValue");
        }
        this.parameterValue = str;
        return this;
    }

    public com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder setRolloutId(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null rolloutId");
        }
        this.rolloutId = str;
        return this;
    }

    public com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder setTemplateVersion(long j) {
        this.templateVersion = j;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder setVariantId(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null variantId");
        }
        this.variantId = str;
        return this;
    }
}

