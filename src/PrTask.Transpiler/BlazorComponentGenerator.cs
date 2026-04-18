using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using PrTask.Application.Services;
using PrTask.Domain.Constants;

namespace PrTask.Transpiler;

public sealed partial class BlazorComponentGenerator
{
    private readonly string Namespace;

    private static readonly Dictionary<string, string> InkToHtmlMap = new(StringComparer.Ordinal)
    {
        [JsTranspilerConstants.InkBox] = "div",
        [JsTranspilerConstants.InkText] = "span",
        [JsTranspilerConstants.InkStatic] = "div",
        [JsTranspilerConstants.InkSpinner] = "div",
        [JsTranspilerConstants.InkTextInput] = "input",
        [JsTranspilerConstants.InkSelectInput] = "select",
        [JsTranspilerConstants.InkNewline] = "br",
        [JsTranspilerConstants.InkSpacer] = "div",
    };

    private static readonly Dictionary<string, string> InkPropToCssMap = new(StringComparer.Ordinal)
    {
        ["flexDirection"] = "flex-direction",
        ["alignItems"] = "align-items",
        ["justifyContent"] = "justify-content",
        ["flexGrow"] = "flex-grow",
        ["flexShrink"] = "flex-shrink",
        ["flexWrap"] = "flex-wrap",
        ["width"] = "width",
        ["height"] = "height",
        ["minWidth"] = "min-width",
        ["minHeight"] = "min-height",
        ["maxWidth"] = "max-width",
        ["maxHeight"] = "max-height",
        ["padding"] = "padding",
        ["paddingX"] = "padding-left;padding-right",
        ["paddingY"] = "padding-top;padding-bottom",
        ["paddingTop"] = "padding-top",
        ["paddingBottom"] = "padding-bottom",
        ["paddingLeft"] = "padding-left",
        ["paddingRight"] = "padding-right",
        ["margin"] = "margin",
        ["marginX"] = "margin-left;margin-right",
        ["marginY"] = "margin-top;margin-bottom",
        ["marginTop"] = "margin-top",
        ["marginBottom"] = "margin-bottom",
        ["marginLeft"] = "margin-left",
        ["marginRight"] = "margin-right",
        ["borderStyle"] = "border-style",
        ["borderColor"] = "border-color",
        ["gap"] = "gap",
        ["overflow"] = "overflow",
        ["display"] = "display",
    };

    private static readonly Dictionary<string, string> InkColorToCssMap = new(StringComparer.Ordinal)
    {
        ["green"] = "color-green",
        ["red"] = "color-red",
        ["yellow"] = "color-yellow",
        ["blue"] = "color-blue",
        ["cyan"] = "color-cyan",
        ["magenta"] = "color-magenta",
        ["white"] = "color-white",
        ["gray"] = "color-gray",
        ["grey"] = "color-gray",
        ["dim"] = "text-dim",
        ["bold"] = "text-bold",
        ["italic"] = "text-italic",
        ["underline"] = "text-underline",
        ["strikethrough"] = "text-strikethrough",
        ["inverse"] = "text-inverse",
    };

    public BlazorComponentGenerator(string Namespace)
    {
        this.Namespace = Namespace;
    }

    public IReadOnlyList<BlazorComponentResult> ExtractAndGenerate(string JsSource, string OutputDir)
    {
        Directory.CreateDirectory(OutputDir);

        var Components = ExtractReactComponents(JsSource);
        var Results = new List<BlazorComponentResult>(Components.Count);

        foreach (var Component in Components)
        {
            var Result = ConvertToBlazor(Component);
            Results.Add(Result);

            var RazorPath = Path.Combine(OutputDir, Result.ComponentName + JsTranspilerConstants.RazorFileExtension);
            File.WriteAllText(RazorPath, Result.RazorContent);

            if (Result.CodeBehindContent.Length > 0)
            {
                var CodeBehindPath = Path.Combine(OutputDir, Result.ComponentName + JsTranspilerConstants.RazorFileExtension + JsTranspilerConstants.CsFileExtension);
                File.WriteAllText(CodeBehindPath, Result.CodeBehindContent);
            }
        }

        return Results;
    }

    private List<ReactComponent> ExtractReactComponents(string Source)
    {
        var Components = new List<ReactComponent>();
        var Pos = 0;

        while (Pos < Source.Length)
        {
            var FuncMatch = ComponentFunctionRegex().Match(Source, Pos);
            if (!FuncMatch.Success)
            {
                break;
            }

            Pos = FuncMatch.Index + FuncMatch.Length;

            var ComponentName = FuncMatch.Groups[2].Value;
            if (ComponentName.Length == 0)
            {
                ComponentName = FuncMatch.Groups[3].Value;
            }

            if (ComponentName.Length == 0 || !char.IsUpper(ComponentName[0]))
            {
                continue;
            }

            var PropsParam = FuncMatch.Groups[4].Value;
            var BraceStart = Source.IndexOf(JsTranspilerConstants.JsBraceOpen, Pos);
            if (BraceStart < 0)
            {
                continue;
            }

            var BodyContent = ExtractBraceContent(Source, BraceStart);
            Pos = BraceStart + BodyContent.Length + 2;

            var HasJsx = ContainsJsx(BodyContent);
            var HasHooks = ContainsHooks(BodyContent);

            if (!HasJsx && !HasHooks)
            {
                continue;
            }

            var StateFields = ExtractStateFields(BodyContent);
            var Effects = ExtractEffects(BodyContent);
            var Callbacks = ExtractCallbacks(BodyContent);
            var Refs = ExtractRefs(BodyContent);
            var Props = ExtractProps(PropsParam, BodyContent);
            var JsxContent = ExtractJsxReturn(BodyContent);

            Components.Add(new ReactComponent
            {
                Name = ComponentName,
                Props = Props,
                StateFields = StateFields,
                Effects = Effects,
                Callbacks = Callbacks,
                Refs = Refs,
                JsxContent = JsxContent,
                RawBody = BodyContent,
            });
        }

        return Components;
    }

    private BlazorComponentResult ConvertToBlazor(ReactComponent Component)
    {
        var RazorSb = new StringBuilder(JsTranspilerConstants.ChunkSize);
        var CodeSb = new StringBuilder(JsTranspilerConstants.ChunkSize);

        var SafeName = SanitizeComponentName(Component.Name);

        EmitRazorFile(RazorSb, Component);
        EmitCodeBehind(CodeSb, Component);

        return new BlazorComponentResult
        {
            ComponentName = SafeName,
            RazorContent = RazorSb.ToString(),
            CodeBehindContent = CodeSb.ToString(),
            Parameters = Component.Props.Select(P => P.Name).ToList(),
            StateFields = Component.StateFields.Select(S => S.Name).ToList(),
            EventCallbacks = Component.Callbacks.Select(C => C.Name).ToList(),
        };
    }

    private void EmitRazorFile(StringBuilder Sb, ReactComponent Component)
    {
        Sb.Append(JsTranspilerConstants.BlazorUsingsDirective).Append(JsTranspilerConstants.JsSpace).AppendLine(Namespace);
        Sb.AppendLine();

        if (Component.JsxContent.Length > 0)
        {
            var ConvertedJsx = ConvertJsxToRazor(Component.JsxContent);
            Sb.AppendLine(ConvertedJsx);
        }
        else
        {
            Sb.AppendLine("<div>");
            Sb.Append("    <span>").Append(Component.Name).AppendLine("</span>");
            Sb.AppendLine("</div>");
        }

        Sb.AppendLine();
        Sb.AppendLine(JsTranspilerConstants.BlazorCodeDirective + " {");

        foreach (var Prop in Component.Props)
        {
            Sb.Append("    ").Append(JsTranspilerConstants.BlazorParameterAttribute).AppendLine();
            Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPublic).Append(JsTranspilerConstants.JsSpace)
              .Append(JsTranspilerConstants.CsTypeObject).Append(JsTranspilerConstants.JsSpace)
              .Append(JsToCSharpConverter.ToPascalCase(Prop.Name))
              .AppendLine(" { get; set; }");
            Sb.AppendLine();
        }

        foreach (var State in Component.StateFields)
        {
            Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPrivate).Append(JsTranspilerConstants.JsSpace)
              .Append(JsTranspilerConstants.CsTypeObject).Append(JsTranspilerConstants.JsSpace)
              .Append(JsToCSharpConverter.ToPascalCase(State.Name));

            if (State.InitialValue.Length > 0)
            {
                Sb.Append(" = ").Append(ConvertInitialValue(State.InitialValue));
            }

            Sb.AppendLine(";");
        }

        if (Component.StateFields.Count > 0)
        {
            Sb.AppendLine();
        }

        foreach (var Callback in Component.Callbacks)
        {
            Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPrivate).Append(JsTranspilerConstants.JsSpace)
              .Append(JsTranspilerConstants.CsTypeVoid).Append(JsTranspilerConstants.JsSpace)
              .Append(JsToCSharpConverter.ToPascalCase(Callback.Name))
              .AppendLine("()");
            Sb.AppendLine("    {");
            Sb.Append("        ").AppendLine(JsTranspilerConstants.BlazorStateHasChanged + "();");
            Sb.AppendLine("    }");
            Sb.AppendLine();
        }

        foreach (var Ref in Component.Refs)
        {
            Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordPrivate).Append(JsTranspilerConstants.JsSpace)
              .Append(JsTranspilerConstants.CsTypeObject).Append("? ")
              .Append(JsToCSharpConverter.ToPascalCase(Ref.Name)).AppendLine(";");
        }

        if (Component.Effects.Count > 0)
        {
            Sb.AppendLine();
            Sb.Append("    ").Append(JsTranspilerConstants.CsKeywordProtected).Append(JsTranspilerConstants.JsSpace)
              .Append(JsTranspilerConstants.CsKeywordOverride).Append(JsTranspilerConstants.JsSpace)
              .Append(JsTranspilerConstants.CsTypeVoid).Append(JsTranspilerConstants.JsSpace)
              .Append(JsTranspilerConstants.BlazorOnAfterRender).AppendLine("(bool FirstRender)");
            Sb.AppendLine("    {");
            Sb.AppendLine("        if (FirstRender)");
            Sb.AppendLine("        {");
            Sb.AppendLine("        }");
            Sb.AppendLine("    }");
        }

        Sb.AppendLine("}");
    }

    private void EmitCodeBehind(StringBuilder Sb, ReactComponent Component)
    {
        Sb.Append(JsTranspilerConstants.CsKeywordNamespace).Append(JsTranspilerConstants.JsSpace).Append(Namespace).AppendLine(";");
        Sb.AppendLine();
        Sb.Append(JsTranspilerConstants.CsKeywordPublic).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordSealed).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordPartial).Append(JsTranspilerConstants.JsSpace)
          .Append(JsTranspilerConstants.CsKeywordClass).Append(JsTranspilerConstants.JsSpace)
          .Append(Component.Name)
          .Append(" : ").AppendLine(JsTranspilerConstants.BlazorComponentBase);
        Sb.AppendLine("{");
        Sb.AppendLine("}");
    }

    private static string ConvertJsxToRazor(string JsxContent)
    {
        var Sb = new StringBuilder(JsxContent.Length);
        var Pos = 0;

        while (Pos < JsxContent.Length)
        {
            if (JsxContent[Pos] == JsTranspilerConstants.JsLessThan)
            {
                var TagEnd = JsxContent.IndexOf(JsTranspilerConstants.JsGreaterThan, Pos);
                if (TagEnd < 0)
                {
                    Sb.Append(JsxContent[Pos]);
                    Pos++;
                    continue;
                }

                var Tag = JsxContent[(Pos + 1)..TagEnd].Trim();
                var IsClosing = Tag.StartsWith("/", StringComparison.Ordinal);
                var IsSelfClosing = Tag.EndsWith("/", StringComparison.Ordinal);

                if (IsClosing)
                {
                    Tag = Tag[1..].Trim();
                    var HtmlTag = MapTagToHtml(Tag);
                    Sb.Append("</").Append(HtmlTag).Append(JsTranspilerConstants.JsGreaterThan);
                }
                else
                {
                    if (IsSelfClosing)
                    {
                        Tag = Tag[..^1].Trim();
                    }

                    var TagParts = Tag.Split(JsTranspilerConstants.JsSpace, 2);
                    var TagName = TagParts[0];
                    var Attributes = TagParts.Length > 1 ? TagParts[1] : string.Empty;
                    var HtmlTag = MapTagToHtml(TagName);
                    var ConvertedAttrs = ConvertJsxAttributes(Attributes, TagName);

                    Sb.Append(JsTranspilerConstants.JsLessThan).Append(HtmlTag);
                    if (ConvertedAttrs.Length > 0)
                    {
                        Sb.Append(JsTranspilerConstants.JsSpace).Append(ConvertedAttrs);
                    }

                    if (IsSelfClosing)
                    {
                        Sb.Append(" /");
                    }

                    Sb.Append(JsTranspilerConstants.JsGreaterThan);
                }

                Pos = TagEnd + 1;
            }
            else if (JsxContent[Pos] == JsTranspilerConstants.JsBraceOpen)
            {
                var ExprEnd = FindMatchingBrace(JsxContent, Pos);
                var Expr = JsxContent[(Pos + 1)..ExprEnd];
                ConvertJsxExpression(Sb, Expr);
                Pos = ExprEnd + 1;
            }
            else
            {
                Sb.Append(JsxContent[Pos]);
                Pos++;
            }
        }

        return Sb.ToString();
    }

    private static void ConvertJsxExpression(StringBuilder Sb, string Expr)
    {
        var Trimmed = Expr.Trim();

        var ConditionalMatch = JsxConditionalRegex().Match(Trimmed);
        if (ConditionalMatch.Success)
        {
            var Condition = ConditionalMatch.Groups[1].Value.Trim();
            var Content = ConditionalMatch.Groups[2].Value.Trim();
            Sb.AppendLine();
            Sb.Append("@if (").Append(JsToCSharpConverter.ToPascalCase(Condition)).Append(") { ").Append(Content).Append(" }");
            return;
        }

        var TernaryMatch = JsxTernaryRegex().Match(Trimmed);
        if (TernaryMatch.Success)
        {
            var Condition = TernaryMatch.Groups[1].Value.Trim();
            var TrueVal = TernaryMatch.Groups[2].Value.Trim();
            var FalseVal = TernaryMatch.Groups[3].Value.Trim();
            Sb.AppendLine();
            Sb.Append("@if (").Append(JsToCSharpConverter.ToPascalCase(Condition)).AppendLine(")");
            Sb.Append("{ ").Append(TrueVal).AppendLine(" }");
            Sb.Append("else { ").Append(FalseVal).AppendLine(" }");
            return;
        }

        var MapMatch = JsxMapRegex().Match(Trimmed);
        if (MapMatch.Success)
        {
            var Collection = MapMatch.Groups[1].Value.Trim();
            var ItemVar = MapMatch.Groups[2].Value.Trim();
            Sb.AppendLine();
            Sb.Append("@foreach (var ").Append(JsToCSharpConverter.ToPascalCase(ItemVar))
              .Append(" in ").Append(JsToCSharpConverter.ToPascalCase(Collection)).AppendLine(")");
            Sb.AppendLine("{");
            Sb.AppendLine("}");
            return;
        }

        Sb.Append("@(").Append(JsToCSharpConverter.ToPascalCase(Trimmed)).Append(")");
    }

    private static string ConvertJsxAttributes(string Attributes, string TagName)
    {
        if (Attributes.Length == 0)
        {
            return string.Empty;
        }

        var Sb = new StringBuilder();
        var IsInkComponent = InkToHtmlMap.ContainsKey(TagName);
        var StyleParts = new List<string>();

        var Matches = JsxAttributeRegex().Matches(Attributes);
        foreach (Match M in Matches)
        {
            var AttrName = M.Groups[1].Value;
            var AttrValue = M.Groups[2].Value;

            if (AttrName == "className")
            {
                Sb.Append("class=\"").Append(AttrValue).Append("\" ");
                continue;
            }

            if (AttrName == "onClick" || AttrName == "onPress")
            {
                Sb.Append("@onclick=\"").Append(JsToCSharpConverter.ToPascalCase(AttrValue.Trim('{', '}'))).Append("\" ");
                continue;
            }

            if (AttrName == "onChange" || AttrName == "onInput")
            {
                Sb.Append("@onchange=\"").Append(JsToCSharpConverter.ToPascalCase(AttrValue.Trim('{', '}'))).Append("\" ");
                continue;
            }

            if (AttrName == "value")
            {
                Sb.Append("@bind=\"").Append(JsToCSharpConverter.ToPascalCase(AttrValue.Trim('{', '}'))).Append("\" ");
                continue;
            }

            if (IsInkComponent && InkPropToCssMap.TryGetValue(AttrName, out var CssProp))
            {
                var CssValue = AttrValue.Trim('"', '\'', '{', '}');
                if (CssProp.Contains(';'))
                {
                    foreach (var SubProp in CssProp.Split(';'))
                    {
                        StyleParts.Add(string.Concat(SubProp, ":", CssValue));
                    }
                }
                else
                {
                    StyleParts.Add(string.Concat(CssProp, ":", CssValue));
                }

                continue;
            }

            if (IsInkComponent && AttrName == "color" && InkColorToCssMap.TryGetValue(AttrValue.Trim('"', '\''), out var CssClass))
            {
                Sb.Append("class=\"").Append(CssClass).Append("\" ");
                continue;
            }

            if (IsInkComponent && (AttrName is "bold" or "italic" or "underline" or "strikethrough" or "dimColor" or "inverse"))
            {
                if (InkColorToCssMap.TryGetValue(AttrName, out var TextClass))
                {
                    Sb.Append("class=\"").Append(TextClass).Append("\" ");
                }

                continue;
            }

            Sb.Append(AttrName).Append("=\"").Append(AttrValue.Trim('"', '\'')).Append("\" ");
        }

        if (StyleParts.Count > 0)
        {
            if (TagName == JsTranspilerConstants.InkBox)
            {
                StyleParts.Insert(0, "display:flex");
            }

            Sb.Append("style=\"").Append(string.Join(";", StyleParts)).Append("\" ");
        }
        else if (TagName == JsTranspilerConstants.InkBox)
        {
            Sb.Append("style=\"display:flex\" ");
        }

        return Sb.ToString().TrimEnd();
    }

    private static string MapTagToHtml(string TagName)
    {
        if (InkToHtmlMap.TryGetValue(TagName, out var HtmlTag))
        {
            return HtmlTag;
        }

        if (TagName.Length > 0 && char.IsUpper(TagName[0]))
        {
            return TagName;
        }

        return TagName;
    }

    private static List<StateField> ExtractStateFields(string Body)
    {
        var Fields = new List<StateField>();
        var Matches = UseStatePatternRegex().Matches(Body);
        foreach (Match M in Matches)
        {
            Fields.Add(new StateField
            {
                Name = M.Groups[1].Value,
                SetterName = M.Groups[2].Value,
                InitialValue = M.Groups[3].Value,
            });
        }

        return Fields;
    }

    private static List<EffectInfo> ExtractEffects(string Body)
    {
        var Effects = new List<EffectInfo>();
        var Matches = UseEffectPatternRegex().Matches(Body);
        foreach (Match M in Matches)
        {
            Effects.Add(new EffectInfo
            {
                DependencyArray = M.Groups[1].Value,
            });
        }

        return Effects;
    }

    private static List<CallbackInfo> ExtractCallbacks(string Body)
    {
        var Callbacks = new List<CallbackInfo>();
        var Matches = UseCallbackPatternRegex().Matches(Body);
        foreach (Match M in Matches)
        {
            Callbacks.Add(new CallbackInfo
            {
                Name = M.Groups[1].Value,
            });
        }

        return Callbacks;
    }

    private static List<RefInfo> ExtractRefs(string Body)
    {
        var Refs = new List<RefInfo>();
        var Matches = UseRefPatternRegex().Matches(Body);
        foreach (Match M in Matches)
        {
            Refs.Add(new RefInfo
            {
                Name = M.Groups[1].Value,
                InitialValue = M.Groups[2].Value,
            });
        }

        return Refs;
    }

    private static List<PropInfo> ExtractProps(string PropsParam, string Body)
    {
        var Props = new List<PropInfo>();

        if (PropsParam.Length == 0)
        {
            return Props;
        }

        var Cleaned = PropsParam.Trim().Trim('{', '}');
        var DestructuredMatch = DestructuredPropsRegex().Matches(Cleaned);
        foreach (Match M in DestructuredMatch)
        {
            Props.Add(new PropInfo { Name = M.Groups[1].Value });
        }

        if (Props.Count == 0 && Cleaned.Length > 0)
        {
            var PropAccessMatches = PropAccessRegex().Matches(Body);
            foreach (Match M in PropAccessMatches)
            {
                var PropName = M.Groups[1].Value;
                if (!Props.Exists(P => string.Equals(P.Name, PropName, StringComparison.Ordinal)))
                {
                    Props.Add(new PropInfo { Name = PropName });
                }
            }
        }

        return Props;
    }

    private static string ExtractJsxReturn(string Body)
    {
        var ReturnMatch = JsxReturnRegex().Match(Body);
        if (!ReturnMatch.Success)
        {
            return string.Empty;
        }

        var Start = ReturnMatch.Index + ReturnMatch.Length;

        if (Start < Body.Length && Body[Start] == JsTranspilerConstants.JsParenOpen)
        {
            var Depth = 1;
            var ContentStart = Start + 1;
            var Pos = ContentStart;
            while (Pos < Body.Length && Depth > 0)
            {
                if (Body[Pos] == JsTranspilerConstants.JsParenOpen)
                {
                    Depth++;
                }
                else if (Body[Pos] == JsTranspilerConstants.JsParenClose)
                {
                    Depth--;
                }

                Pos++;
            }

            return Body[ContentStart..(Pos - 1)].Trim();
        }

        var ExprEnd = Start;
        while (ExprEnd < Body.Length && Body[ExprEnd] != JsTranspilerConstants.JsSemicolon && Body[ExprEnd] != JsTranspilerConstants.JsNewline)
        {
            ExprEnd++;
        }

        return Body[Start..ExprEnd].Trim();
    }

    private static bool ContainsJsx(string Body)
    {
        return Body.Contains(JsTranspilerConstants.JsLessThan) && JsxReturnRegex().IsMatch(Body);
    }

    private static bool ContainsHooks(string Body)
    {
        return Body.Contains(JsTranspilerConstants.ReactUseState, StringComparison.Ordinal) ||
               Body.Contains(JsTranspilerConstants.ReactUseEffect, StringComparison.Ordinal) ||
               Body.Contains(JsTranspilerConstants.ReactUseCallback, StringComparison.Ordinal) ||
               Body.Contains(JsTranspilerConstants.ReactUseRef, StringComparison.Ordinal);
    }

    private static string ExtractBraceContent(string Source, int BraceStart)
    {
        var Depth = 0;
        var I = BraceStart;
        while (I < Source.Length)
        {
            var Ch = Source[I];
            if (Ch == JsTranspilerConstants.JsBraceOpen)
            {
                Depth++;
            }
            else if (Ch == JsTranspilerConstants.JsBraceClose)
            {
                Depth--;
                if (Depth == 0)
                {
                    return Source[(BraceStart + 1)..I];
                }
            }
            else if (Ch is '\'' or '"' or '`')
            {
                I = SkipString(Source, I);
                continue;
            }

            I++;
        }

        return Source[(BraceStart + 1)..];
    }

    private static int FindMatchingBrace(string Source, int Start)
    {
        var Depth = 0;
        var I = Start;
        while (I < Source.Length)
        {
            if (Source[I] == JsTranspilerConstants.JsBraceOpen)
            {
                Depth++;
            }
            else if (Source[I] == JsTranspilerConstants.JsBraceClose)
            {
                Depth--;
                if (Depth == 0)
                {
                    return I;
                }
            }

            I++;
        }

        return Source.Length - 1;
    }

    private static int SkipString(string Source, int Pos)
    {
        var Quote = Source[Pos];
        Pos++;
        while (Pos < Source.Length)
        {
            if (Source[Pos] == JsTranspilerConstants.JsBackslash)
            {
                Pos += 2;
                continue;
            }

            if (Source[Pos] == Quote)
            {
                return Pos + 1;
            }

            Pos++;
        }

        return Pos;
    }

    private static string ConvertInitialValue(string Value)
    {
        var Trimmed = Value.Trim();
        if (Trimmed is JsTranspilerConstants.JsKeywordTrue or JsTranspilerConstants.JsKeywordFalse)
        {
            return Trimmed;
        }

        if (Trimmed is JsTranspilerConstants.JsKeywordNull or JsTranspilerConstants.JsKeywordUndefined)
        {
            return JsTranspilerConstants.CsKeywordNull;
        }

        if (Trimmed.Length > 0 && Trimmed[0] == JsTranspilerConstants.JsSingleQuote && Trimmed[^1] == JsTranspilerConstants.JsSingleQuote)
        {
            return string.Concat("\"", Trimmed[1..^1], "\"");
        }

        if (Trimmed.Length > 0 && Trimmed[0] == JsTranspilerConstants.JsBracketOpen)
        {
            return string.Concat(JsTranspilerConstants.CsKeywordNew, " List<", JsTranspilerConstants.CsTypeObject, ">()");
        }

        if (Trimmed.Length > 0 && Trimmed[0] == JsTranspilerConstants.JsBraceOpen)
        {
            return string.Concat(JsTranspilerConstants.CsKeywordNew, " Dictionary<", JsTranspilerConstants.CsTypeString, ", ", JsTranspilerConstants.CsTypeObject, ">()");
        }

        return Trimmed;
    }

    [GeneratedRegex(@"(?:export\s+)?(?:default\s+)?(?:function|const|let|var)\s+(\w+)?\s*=?\s*(?:function\s+)?(\w+)?\s*\(([^)]*)\)\s*(?:=>)?\s*\{", RegexOptions.None)]
    private static partial Regex ComponentFunctionRegex();

    [GeneratedRegex(@"\[(\w+),\s*(\w+)\]\s*=\s*useState\(([^)]*)\)")]
    private static partial Regex UseStatePatternRegex();

    [GeneratedRegex(@"useEffect\s*\(\s*(?:(?:async\s+)?\(\)\s*=>\s*\{[^}]*\}|function[^}]*\})\s*,\s*\[([^\]]*)\]\s*\)")]
    private static partial Regex UseEffectPatternRegex();

    [GeneratedRegex(@"(\w+)\s*=\s*useCallback\(")]
    private static partial Regex UseCallbackPatternRegex();

    [GeneratedRegex(@"(\w+)\s*=\s*useRef\(([^)]*)\)")]
    private static partial Regex UseRefPatternRegex();

    [GeneratedRegex(@"return\s*[\(<]")]
    private static partial Regex JsxReturnRegex();

    [GeneratedRegex(@"(\w+)\s*&&\s*(.+)")]
    private static partial Regex JsxConditionalRegex();

    [GeneratedRegex(@"(\w+)\s*\?\s*(.+?)\s*:\s*(.+)")]
    private static partial Regex JsxTernaryRegex();

    [GeneratedRegex(@"(\w+)\.map\(\(?(\w+)")]
    private static partial Regex JsxMapRegex();

    [GeneratedRegex(@"(\w+)\s*=\s*""?([^""}\s]*)""?")]
    private static partial Regex JsxAttributeRegex();

    [GeneratedRegex(@"(\w+)")]
    private static partial Regex DestructuredPropsRegex();

    [GeneratedRegex(@"props\.(\w+)")]
    private static partial Regex PropAccessRegex();

    private static string SanitizeComponentName(string Name)
    {
        var Sb = new StringBuilder(Name.Length);
        foreach (var Ch in Name)
        {
            if (char.IsLetterOrDigit(Ch) || Ch == '_')
            {
                Sb.Append(Ch);
            }
        }

        if (Sb.Length == 0)
        {
            return "Component";
        }

        if (char.IsDigit(Sb[0]))
        {
            Sb.Insert(0, 'C');
        }

        return Sb.ToString();
    }

    private sealed class ReactComponent
    {
        internal required string Name { get; init; }
        internal List<PropInfo> Props { get; init; } = [];
        internal List<StateField> StateFields { get; init; } = [];
        internal List<EffectInfo> Effects { get; init; } = [];
        internal List<CallbackInfo> Callbacks { get; init; } = [];
        internal List<RefInfo> Refs { get; init; } = [];
        internal string JsxContent { get; init; } = string.Empty;
        internal string RawBody { get; init; } = string.Empty;
    }

    private sealed class PropInfo
    {
        internal required string Name { get; init; }
    }

    private sealed class StateField
    {
        internal required string Name { get; init; }
        internal string SetterName { get; init; } = string.Empty;
        internal string InitialValue { get; init; } = string.Empty;
    }

    private sealed class EffectInfo
    {
        internal string DependencyArray { get; init; } = string.Empty;
    }

    private sealed class CallbackInfo
    {
        internal required string Name { get; init; }
    }

    private sealed class RefInfo
    {
        internal required string Name { get; init; }
        internal string InitialValue { get; init; } = string.Empty;
    }
}
