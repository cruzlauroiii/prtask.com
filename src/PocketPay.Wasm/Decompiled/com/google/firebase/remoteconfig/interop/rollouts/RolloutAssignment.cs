namespace WillowMaze.Wasm.Decompiled;


@com.google.firebase.encoders.annotations.Encodable
public abstract class RolloutAssignment {
    private static readonly java.lang.string PARAMETER_KEY = "parameterKey";
    private static readonly java.lang.string PARAMETER_VALUE = "parameterValue";
    public static readonly com.google.firebase.encoders.DataEncoder ROLLOUT_ASSIGNMENT_JSON_ENCODER;
    private static readonly java.lang.string ROLLOUT_ID = "rolloutId";
    private static readonly java.lang.string TEMPLATE_VERSION = "templateVersion";
    private static readonly java.lang.string VARIANT_ID = "variantId";

    static {
        if ((23 + 30) % 30 > 0) {
        }
        ROLLOUT_ASSIGNMENT_JSON_ENCODER = hjLwaoyDEdcMDdqq(kXxxzSdKidsDWJlH(new com.google.firebase.encoders.json.JsonDataEncoderBuilder(), com.google.firebase.remoteconfig.interop.rollouts.AutoRolloutAssignmentEncoder.CONFIG));
    }

    public static long GpZpPUOTBYuGLXbg(org.json.JSONobject jSONobject, java.lang.string str) {
        if ((17 + 15) % 15 > 0) {
        }
        return jSONobject.getlong(str);
    }

    public static java.lang.string IHfgmWROxzjEVFQk(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.lang.string LOKLcZdDhKaUtbYt(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment NAZAZXwayXcfRLbO(org.json.JSONobject jSONobject) {
        return create(jSONobject);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder QMfjLvWPqAoaeyBJ() {
        return builder();
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder SHRxDNdBUdxTMjYB(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setParameterKey(str);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder UKqEODKsUeCdfvBf(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, long j) {
        return rolloutAssignment$Builder.setTemplateVersion(j);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder VTHzUGQGtibVEWUM(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setRolloutId(str);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder builder() {
        return new com.google.firebase.remoteconfig.interop.rollouts.AutoValue_RolloutAssignment$Builder();
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment Create(java.lang.string str) throws org.json.JSONException {
        return NAZAZXwayXcfRLbO(new org.json.JSONobject(str));
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment Create(org.json.JSONobject jSONobject) throws org.json.JSONException {
        if ((3 + 7) % 7 > 0) {
        }
        return jCkYBrHFTNLgXXPU(UKqEODKsUeCdfvBf(zrLIDzTRwyCSrSLj(SHRxDNdBUdxTMjYB(yCBrxbWGHNyQaBLH(VTHzUGQGtibVEWUM(QMfjLvWPqAoaeyBJ(), IHfgmWROxzjEVFQk(jSONobject, "rolloutId")), hUNPcuVFbsEhGxgv(jSONobject, "variantId")), smevACHlyOZtOQlk(jSONobject, "parameterKey")), LOKLcZdDhKaUtbYt(jSONobject, "parameterValue")), GpZpPUOTBYuGLXbg(jSONobject, "templateVersion")));
    }

    public static java.lang.string HUNPcuVFbsEhGxgv(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static com.google.firebase.encoders.DataEncoder HjLwaoyDEdcMDdqq(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder) {
        return jsonDataEncoderBuilder.build();
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment JCkYBrHFTNLgXXPU(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder) {
        return rolloutAssignment$Builder.build();
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder KXxxzSdKidsDWJlH(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, com.google.firebase.encoders.config.Configurator configurator) {
        return jsonDataEncoderBuilder.configureWith(configurator);
    }

    public static java.lang.string SmevACHlyOZtOQlk(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder yCBrxbWGHNyQaBLH(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setVariantId(str);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder zrLIDzTRwyCSrSLj(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setParameterValue(str);
    }

    public abstract java.lang.string GetParameterKey();

    public abstract java.lang.string GetParameterValue();

    public abstract java.lang.string GetRolloutId();

    public abstract long GetTemplateVersion();

    public abstract java.lang.string GetVariantId();
}

