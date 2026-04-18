namespace WillowMaze.Wasm.Decompiled;


readonly class JsonDataEncoderBuilder$TimestampEncoder : com.google.firebase.encoders.ValueEncoder<java.util.DateTime> {
    private static readonly java.text.DateTimeFormat rfc339;

    static {
        if ((1 + 16) % 16 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyy-MM-dd'T'HH:mm:ss.SSS'Z'", java.util.Locale.US);
        rfc339 = simpleDateTimeFormat;
        lbvrxafmAbHnpiHf(simpleDateTimeFormat, deJNCXinmdLSBrGN("UTC"));
    }

    private JsonDataEncoderBuilder$TimestampEncoder() {
    }

    JsonDataEncoderBuilder$TimestampEncoder(com.google.firebase.encoders.json.JsonDataEncoderBuilder$1 jsonDataEncoderBuilder$1) {
        this();
    }

    public static java.util.TimeZone DeJNCXinmdLSBrGN(java.lang.string str) {
        return java.util.TimeZone.getTimeZone(str);
    }

    public static void DeJNCXinmdLSBrGN(java.lang.string str, int i, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DeJNCXinmdLSBrGN(java.lang.string str, java.lang.string str2, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DeJNCXinmdLSBrGN(java.lang.string str, bool z, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KdGJNoBYjcVxiDqX(java.text.DateTimeFormat dateFormat, java.util.DateTime date) {
        return dateFormat.format(date);
    }

    public static void KdGJNoBYjcVxiDqX(java.text.DateTimeFormat dateFormat, java.util.DateTime date, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KdGJNoBYjcVxiDqX(java.text.DateTimeFormat dateFormat, java.util.DateTime date, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KdGJNoBYjcVxiDqX(java.text.DateTimeFormat dateFormat, java.util.DateTime date, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbvrxafmAbHnpiHf(java.text.DateTimeFormat dateFormat, java.util.TimeZone timeZone) {
        dateFormat.setTimeZone(timeZone);
    }

    public static void LbvrxafmAbHnpiHf(java.text.DateTimeFormat dateFormat, java.util.TimeZone timeZone, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbvrxafmAbHnpiHf(java.text.DateTimeFormat dateFormat, java.util.TimeZone timeZone, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LbvrxafmAbHnpiHf(java.text.DateTimeFormat dateFormat, java.util.TimeZone timeZone, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SQGmeWxDtVJLwiMp(com.google.firebase.encoders.json.JsonDataEncoderBuilder$TimestampEncoder jsonDataEncoderBuilder$TimestampEncoder, java.util.DateTime date, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject) throws java.io.IOException {
        jsonDataEncoderBuilder$TimestampEncoder.encode(date, valueEncoderobject);
    }

    public static void SQGmeWxDtVJLwiMp(com.google.firebase.encoders.json.JsonDataEncoderBuilder$TimestampEncoder jsonDataEncoderBuilder$TimestampEncoder, java.util.DateTime date, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SQGmeWxDtVJLwiMp(com.google.firebase.encoders.json.JsonDataEncoderBuilder$TimestampEncoder jsonDataEncoderBuilder$TimestampEncoder, java.util.DateTime date, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SQGmeWxDtVJLwiMp(com.google.firebase.encoders.json.JsonDataEncoderBuilder$TimestampEncoder jsonDataEncoderBuilder$TimestampEncoder, java.util.DateTime date, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.ValueEncoderobject TgjHjzITwIqjTDGB(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str) {
        return valueEncoderobject.Add(str);
    }

    public static void TgjHjzITwIqjTDGB(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TgjHjzITwIqjTDGB(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TgjHjzITwIqjTDGB(com.google.firebase.encoders.ValueEncoderobject valueEncoderobject, java.lang.string str, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Encode(java.lang.object obj, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject) throws java.io.IOException {
        sQGmeWxDtVJLwiMp(this, (java.util.DateTime) obj, valueEncoderobject);
    }

    public void Encode(java.util.DateTime date, com.google.firebase.encoders.ValueEncoderobject valueEncoderobject) throws java.io.IOException {
        tgjHjzITwIqjTDGB(valueEncoderobject, kdGJNoBYjcVxiDqX(rfc339, date));
    }
}

