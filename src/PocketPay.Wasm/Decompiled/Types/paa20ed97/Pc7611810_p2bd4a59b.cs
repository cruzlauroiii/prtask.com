namespace WillowMaze.Wasm.Decompiled;

public class Pc7611810_p2bd4a59b
{
    private static System.Text.RegularExpressions.Regex F033b1c05;
    private static string F171596b9;
    private static System.Text.RegularExpressions.Regex F4428b266;
    private static string F4b74b99f;
    private static System.Text.RegularExpressions.Regex F55453618;
    private static System.Text.RegularExpressions.Regex F62712baf;
    private static string F65ce1329;
    private static System.Text.RegularExpressions.Regex F66a5bd75;
    private static System.Text.RegularExpressions.Regex Faa845355;
    private static System.Text.RegularExpressions.Regex Ff441c813;
    private p883d7615 F03c23510;
    private bool F043ebf2c;
    private readonly Type[] F0bfe0bbd;
    private string F10e7dc60;
    private readonly Type[] F11427856;
    private bool F11f02432;
    private readonly Annotation[] F1565004b;
    private bool F16dd2c20;
    private bool F1efb4fe1;
    private bool F20b8c98f;
    private readonly Annotation[][] F22ee227a;
    private readonly pb9794896 F25c7ed2d;
    private HashSet<object> F2b16f5cf;
    private bool F3593e70c;
    private string F35d9ebd4;
    private bool F3864cd81;
    private bool F38f0d9bd;
    private bool F399cc996;
    private bool F3a66dc82;
    private bool F3dcb8180;
    private p883d7615 F4340fd73;
    private readonly Annotation[][] F44700b5c;
    private HashSet<object> F45257398;
    private pba07c23c F4adfea5e;
    private p883d7615 F4e09ada1;
    private readonly Annotation[] F576f4d21;
    private bool F5c993dab;
    private readonly Annotation[] F5f8e55d7;
    private bool F6984528a;
    private string F6ab23305;
    private readonly Method F6fa9761f;
    private bool F71f84f54;
    private HashSet<object> F725228b1;
    private readonly Annotation[][] F7637a37a;
    private bool F763cdb48;
    private bool F7a290740;
    private bool F7e968c4e;
    private pba07c23c F843a2dc7;
    private bool F8933ead1;
    private bool F941621be;
    private string F9479295b;
    private p3f1ca953[] F96194a07;
    private p3f1ca953[] F98be472f;
    private bool F9b745171;
    private bool F9eefbfe6;
    private bool Fa80a0b77;
    private bool Fb05d1aa5;
    private bool Fb0dffba2;
    private readonly pb9794896 Fbd279364;
    private string Fc33d9864;
    private bool Fc48b9b9d;
    private readonly Annotation[] Fc4f49e4d;
    private bool Fc83f361c;
    private bool Fc8a97751;
    private bool Fca451dc6;
    private bool Fcb23fab7;
    private bool Fcf905f89;
    private readonly Annotation[][] Fd015727d;
    private bool Fd4080aed;
    private p883d7615 Fd4a57cef;
    private bool Fd91da3e1;
    private pba07c23c Fd94ff1e6;
    private pba07c23c Fd975494f;
    private string Fdb9c30d5;
    private bool Fde40eb14;
    private bool Fde7a9b1c;
    private pba07c23c Fdf5feafa;
    private bool Fe3eb83bc;
    private HashSet<object> Fe5559715;
    private p3f1ca953[] Fe64c52a1;
    private readonly Method Fea9f6aca;
    private readonly Annotation[] Fedf067cc;
    private HashSet<object> Ff2b9e047;
    private bool Ff769aeb7;
    private bool Ffb018ef5;

    private static Type BoxIfPrimitive(Type P0)
    {
        // field: java.lang.Float.TYPE
        // field: java.lang.Boolean.TYPE
        // field: java.lang.Byte.TYPE
        // field: java.lang.Long.TYPE
        // field: java.lang.Integer.TYPE
        // field: java.lang.Short.TYPE
        // field: java.lang.Double.TYPE
        // field: java.lang.Character.TYPE
        // type: long
        // type: double
        // type: float
        // type: short
        // type: byte
        // type: char
        // type: int
        // type: bool
        return default!;
    }

    private p883d7615 ParseHeaders(string[] P0)
    {
        // str: "Malformed content type: %s"
        // str: "@Headers value must be in the form \"Name: Value\". Found: \"%s\""
        // str: "94ace9dc6df89edfc6404d5181c49ff21456b70dcd52254a856e7ed544c25c00b6fb2ea2062b235d"
        // call: string.equalsIgnoreCase
        // call: p883d7615$p2bd4a59b.build
        // call: string.substring
        // call: p883d7615$p2bd4a59b.<init>
        // call: pa470a233.methodError
        // call: pba07c23c.mb5eda0a7
        // call: string.length
        // call: string.trim
        // call: string.indexOf
        // call: DecryptString.decryptString
        // call: p883d7615$p2bd4a59b.add
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
        // field: paa20ed97.pc7611810$p2bd4a59b.fdf5feafa
        // type: p883d7615$p2bd4a59b
        return default!;
    }

    private void ParseHttpMethodAndPath(string P0, string P1, bool P2)
    {
        // str: "Only one HTTP method is allowed. Found: %s and %s."
        // str: "URL query string \"%s\" must not have replace block. For dynamic query parameters use @Query."
        // call: pa470a233.methodError
        // call: pc7611810$p2bd4a59b.parsePathParameters
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: string.isEmpty
        // call: string.indexOf
        // call: string.length
        // call: Matcher.find
        // call: string.substring
        // field: paa20ed97.pc7611810$p2bd4a59b.fb05d1aa5
        // field: paa20ed97.pc7611810$p2bd4a59b.f6ab23305
        // field: paa20ed97.pc7611810$p2bd4a59b.fdb9c30d5
        // field: paa20ed97.pc7611810$p2bd4a59b.ff2b9e047
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
        // field: paa20ed97.pc7611810$p2bd4a59b.f62712baf
    }

    private void ParseMethodAnnotation(Annotation P0)
    {
        // str: "DELETE"
        // str: "GET"
        // str: "OPTIONS"
        // str: "POST"
        // str: "PUT"
        // str: "PATCH"
        // str: "Only one encoding annotation is allowed."
        // str: "@Headers annotation is empty."
        // str: "HEAD"
        // call: p883d7615.value
        // call: p7528035a.value
        // call: pc7611810$p2bd4a59b.parseHttpMethodAndPath
        // call: p164dd62a.value
        // call: pe15e216f.value
        // call: pa02439ec.value
        // call: pa470a233.methodError
        // call: p32f68a60.value
        // call: p293c9ea2.method
        // call: p293c9ea2.hasBody
        // call: p3e75383a.value
        // call: p293c9ea2.path
        // call: pc7611810$p2bd4a59b.parseHeaders
        // call: p63bc9a39.value
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
        // field: paa20ed97.pc7611810$p2bd4a59b.f71f84f54
        // field: paa20ed97.pc7611810$p2bd4a59b.f3a66dc82
        // field: paa20ed97.pc7611810$p2bd4a59b.f4340fd73
    }

    private p3f1ca953 ParseParameter(int P0, Type P1, Annotation[] P2, bool P3)
    {
        // str: "No Retrofit annotation found."
        // str: "Multiple Retrofit annotations found, only one allowed."
        // call: pa470a233.parameterError
        // call: pa470a233.getRawType
        // call: pc7611810$p2bd4a59b.parseParameterAnnotation
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
        // field: paa20ed97.pc7611810$p2bd4a59b.fcb23fab7
        // type: object
        return default!;
    }

    private p3f1ca953 ParseParameterAnnotation(int P0, Type P1, Annotation[] P2, Annotation P3)
    {
        // str: "@Path parameters may not be used with @Url."
        // str: "@QueryMap parameter type must be Map."
        // str: "@Part parameters using the MultipartBody.Part must not include a part name in the annotation."
        // str: "@Url must be okhttp3.HttpUrl, String, java.net.URI, or android.net.Uri type."
        // str: "A @Url parameter must not come after a @QueryName."
        // str: "<String>)"
        // str: "@FieldMap parameters can only be used with form encoding."
        // str: " and would always overwrite its value."
        // str: "@QueryMap keys must be of type String: "
        // str: " must include generic type (e.g., "
        // str: "form-data; name=\""
        // str: "@PartMap parameters can only be used with multipart encoding."
        // str: "A @Path parameter must not come after a @QueryName."
        // str: "android.net.Uri"
        // str: "@Url cannot be used with @%s URL"
        // str: "A @Path parameter must not come after a @Query."
        // str: " is duplicate of parameter #"
        // str: "@Body parameters cannot be used with form or multi-part encoding."
        // str: "Unable to create @Body converter for %s"
        // str: "@FieldMap keys must be of type String: "
        // call: Type.getName
        // call: pa470a233.parameterError
        // call: Type.getSimpleName
        // call: pa470a233.getSupertype
        // call: p3f1ca953$p66c1b4c7.iterable
        // call: pa470a233.getParameterUpperBound
        // call: StringBuilder.append
        // call: pc7611810$p2bd4a59b.boxIfPrimitive
        // call: StringBuilder.<init>
        // call: pa470a233.getRawType
        // call: p3f1ca953$pbf50d5e6.iterable
        // call: p3f1ca953$p6f16a5f8.<init>
        // call: p3f1ca953$p8fc3270c.<init>
        // call: p752f2c10.encoded
        // call: p3f1ca953$p5bfce74a.<init>
        // call: Type.isArray
        // call: p3f1ca953$p6f16a5f8.iterable
        // call: Type.isAssignableFrom
        // call: pb9794896.stringConverter
        // call: pb9794896.requestBodyConverter
        // field: paa20ed97.pc7611810$p2bd4a59b.f5c993dab
        // field: paa20ed97.pc7611810$p2bd4a59b.fbd279364
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
        // field: paa20ed97.pc7611810$p2bd4a59b.f3864cd81
        // field: paa20ed97.pc7611810$p2bd4a59b.fc4f49e4d
        // field: paa20ed97.pc7611810$p2bd4a59b.f71f84f54
        // field: paa20ed97.pc7611810$p2bd4a59b.f3a66dc82
        // field: paa20ed97.p3f1ca953$pc101058e.f8a0496f6
        // field: paa20ed97.pc7611810$p2bd4a59b.f98be472f
        // field: paa20ed97.pc7611810$p2bd4a59b.f7e968c4e
        // field: paa20ed97.pc7611810$p2bd4a59b.fd91da3e1
        // field: paa20ed97.pc7611810$p2bd4a59b.f7a290740
        // field: paa20ed97.pc7611810$p2bd4a59b.f043ebf2c
        // field: paa20ed97.pc7611810$p2bd4a59b.f8933ead1
        // field: paa20ed97.pc7611810$p2bd4a59b.fdb9c30d5
        // type: IEnumerable<object>
        // type: p3f1ca953$p8fc3270c
        // type: Dictionary<string, object>
        // type: p3f1ca953$p05ad3768
        // type: pecf7e7e2$p5bfce74a
        // type: p883d7615
        // type: string
        // type: p3f1ca953$p883d7615
        // type: StringBuilder
        // type: p3f1ca953$p05794e2e
        return default!;
    }

    private static HashSet<object> ParsePathParameters(string P0)
    {
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: Matcher.find
        // call: Matcher.group
        // call: HashSet<object>.add
        // call: HashSet<object>.<init>
        // field: paa20ed97.pc7611810$p2bd4a59b.f62712baf
        // type: HashSet<object>
        return default!;
    }

    private void ValidatePathName(int P0, string P1)
    {
        // str: "URL \"%s\" does not contain \"{%s}\"."
        // str: "@Path parameter name must match %s. Found: %s"
        // call: pa470a233.parameterError
        // call: System.Text.RegularExpressions.Regex.matcher
        // call: System.Text.RegularExpressions.Regex.pattern
        // call: Matcher.matches
        // call: HashSet<object>.contains
        // field: paa20ed97.pc7611810$p2bd4a59b.f6ab23305
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
        // field: paa20ed97.pc7611810$p2bd4a59b.ff2b9e047
        // field: paa20ed97.pc7611810$p2bd4a59b.f66a5bd75
        // field: paa20ed97.pc7611810$p2bd4a59b.f62712baf
    }

    private void ValidateResolvableType(int P0, Type P1)
    {
        // str: "Parameter type must not include a type variable or wildcard: %s"
        // call: pa470a233.hasUnresolvableType
        // call: pa470a233.parameterError
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
    }

    private pc7611810 Build()
    {
        // str: "Non-body HTTP method cannot contain @Body."
        // str: "FormUrlEncoded can only be specified on HTTP methods with request body (e.g., @POST)."
        // str: "Missing either @%s URL or @Url parameter."
        // str: "HTTP method annotation is required (e.g., @GET, @POST, etc.)."
        // str: "Form-encoded method must contain at least one @Field."
        // str: "Multipart can only be specified on HTTP methods with request body (e.g., @POST)."
        // str: "Multipart method must contain at least one @Part."
        // call: pc7611810$p2bd4a59b.parseParameter
        // call: pc7611810$p2bd4a59b.parseMethodAnnotation
        // call: pa470a233.methodError
        // call: pc7611810.<init>
        // field: paa20ed97.pc7611810$p2bd4a59b.fb05d1aa5
        // field: paa20ed97.pc7611810$p2bd4a59b.fdb9c30d5
        // field: paa20ed97.pc7611810$p2bd4a59b.fea9f6aca
        // field: paa20ed97.pc7611810$p2bd4a59b.f043ebf2c
        // field: paa20ed97.pc7611810$p2bd4a59b.f7637a37a
        // field: paa20ed97.pc7611810$p2bd4a59b.f3864cd81
        // field: paa20ed97.pc7611810$p2bd4a59b.f3a66dc82
        // field: paa20ed97.pc7611810$p2bd4a59b.f6ab23305
        // field: paa20ed97.pc7611810$p2bd4a59b.fd91da3e1
        // field: paa20ed97.pc7611810$p2bd4a59b.f71f84f54
        // field: paa20ed97.pc7611810$p2bd4a59b.f98be472f
        // field: paa20ed97.pc7611810$p2bd4a59b.ffb018ef5
        // field: paa20ed97.pc7611810$p2bd4a59b.fc4f49e4d
        // field: paa20ed97.pc7611810$p2bd4a59b.f11427856
        // type: pc7611810
        return default!;
    }

}
