using PrTask.Domain.Constants;

namespace PrTask.Prerender;
public static class HtmlTemplate
{
    private const string TemplateEnd = "</body>\n</html>";

    private const string HtmlExt = ".html";

    private static readonly string[] PageLinkHrefs =
    [
        HtmlConstants.PageTasks, HtmlConstants.PageLeaderboard,
        HtmlConstants.PageHowItWorks, HtmlConstants.PagePricing,
        HtmlConstants.PageAbout, HtmlConstants.PageDownload,
        HtmlConstants.PageDashboard, HtmlConstants.PageClientCreateTask,
        HtmlConstants.PageClientPayments, HtmlConstants.PageClientRepository,
        HtmlConstants.PageSprints, HtmlConstants.PageBoards,
        HtmlConstants.PageSettings, HtmlConstants.PageLogin,
        HtmlConstants.PageNotFound, HtmlConstants.PagePrs,
        HtmlConstants.PageProfile, HtmlConstants.PageDeployments,
        HtmlConstants.PageLegalTerms, HtmlConstants.PageLegalPrivacy,
        HtmlConstants.PageLegalCookiePolicy, HtmlConstants.PageLegalAcceptableUse,
        HtmlConstants.PageLegalRefund, HtmlConstants.PageLegalLicenses,
        HtmlConstants.PageLegalAccessibility, HtmlConstants.PageLegalDmca,
    ];

    public static string Wrap(string Route, string RenderedContent, string LanguageCode = I18NConstants.LanguageCodeEnglish)
    {
        var RootPrefix = ComputeRootPrefix(Route);
        var LocalePrefix = ComputeLocalePrefix(Route);
        var RelativeContent = RelativizeAbsoluteLinks(RenderedContent, LocalePrefix, RootPrefix);
        var LocalizedContent = LocalizeContent(RelativeContent, LanguageCode);
        return string.Concat(
            HtmlConstants.DoctypeHtmlLangOpen, LanguageCode, HtmlConstants.HtmlLangCloseHeadOpen,
            BuildHead(Route, LanguageCode, RootPrefix),
            BuildBodyStart(Route, LanguageCode, LocalePrefix, RootPrefix),
            LocalizedContent,
            BuildBodyEnd(Route, LanguageCode, LocalePrefix, RootPrefix),
            TemplateEnd);
    }

    private static string LocalizeContent(string Html, string LanguageCode)
    {
        if (LanguageCode == I18NConstants.LanguageCodeEnglish ||
            !I18NConstants.LocalizedHtmlStrings.TryGetValue(LanguageCode, out var Replacements))
        {
            return Html;
        }

        var Result = Html;
        foreach (var (From, To) in Replacements)
        {
            Result = Result.Replace(">" + From + "<", ">" + To + "<");
        }

        return Result;
    }

    private static string RelativizeAbsoluteLinks(string Html, string LocalePrefix, string RootPrefix)
    {
        var Mapped = ConvertRoutesToPages(Html);
        foreach (var (Code, _) in I18NConstants.AllLanguages)
        {
            Mapped = Mapped.Replace(
                string.Concat(HtmlConstants.HrefOpen, HtmlConstants.Slash, Code, HtmlConstants.Slash),
                string.Concat(HtmlConstants.HrefOpen, HtmlConstants.Slash));
        }
        return Mapped
            .Replace(
                string.Concat(HtmlConstants.HrefOpen, HtmlConstants.Slash),
                string.Concat(HtmlConstants.HrefOpen, LocalePrefix))
            .Replace(
                string.Concat(HtmlConstants.SrcOpen, HtmlConstants.Slash),
                string.Concat(HtmlConstants.SrcOpen, RootPrefix));
    }

    private static string ConvertRoutesToPages(string Html)
    {
        var Result = Html;
        foreach (var (Route, Page) in HtmlConstants.RouteToPageMap)
        {
            Result = Result
                .Replace(
                    string.Concat(HtmlConstants.HrefOpen, Route, HtmlConstants.HrefClose),
                    string.Concat(HtmlConstants.HrefOpen, Page, HtmlConstants.HrefClose))
                .Replace(
                    string.Concat(HtmlConstants.HrefOpen, Route, HtmlConstants.HashPrefix),
                    string.Concat(HtmlConstants.HrefOpen, Page, HtmlConstants.HashPrefix));
        }
        return Result;
    }

    private static string ComputeRootPrefix(string Route)
    {
        var Depth = 1;
        var Trimmed = Route.TrimStart('/');
        if (Trimmed.Length > 0)
        {
            Depth += Trimmed.Count(C => C == '/');
        }
        return string.Concat(Enumerable.Repeat(HtmlConstants.ParentPrefix, Depth));
    }

    private static string ComputeLocalePrefix(string Route)
    {
        var Trimmed = Route.TrimStart('/');
        var SlashCount = Trimmed.Length > 0 ? Trimmed.Count(C => C == '/') : 0;
        return string.Concat(Enumerable.Repeat(HtmlConstants.ParentPrefix, SlashCount));
    }

    private static string BuildHead(string Route, string LanguageCode, string RootPrefix)
    {
        var CanonicalRoute = string.Concat(HtmlConstants.Slash, LanguageCode, Route);
        var Title = I18NConstants.PageTitles.TryGetValue(LanguageCode, out var LocalizedTitle)
            ? LocalizedTitle : SeoConstants.DefaultTitle;
        var Description = I18NConstants.PageDescriptions.TryGetValue(LanguageCode, out var LocalizedDescription)
            ? LocalizedDescription : SeoConstants.DefaultDescription;
        return string.Concat(
            string.Format(HtmlConstants.PreloadCssFormat, RootPrefix),
            LinkStylesheet(RootPrefix + HtmlConstants.CssPath),
            HtmlConstants.MetaCharsetTag,
            HtmlConstants.MetaViewportTag,
            HtmlConstants.MetaThemeColorTag,
            TitleTag(Title),
            MetaName(HtmlConstants.Description, Description),
            MetaProperty(HtmlConstants.OgTitle, Title),
            MetaProperty(HtmlConstants.OgDescription, Description),
            MetaProperty(HtmlConstants.OgType, SeoConstants.DefaultOgType),
            MetaProperty(HtmlConstants.OgUrl, PrerenderConstants.BaseUrl + CanonicalRoute),
            MetaProperty(HtmlConstants.OgSiteName, SeoConstants.DefaultOgSiteName),
            MetaName(HtmlConstants.TwitterCard, SeoConstants.DefaultTwitterCard),
            MetaName(HtmlConstants.TwitterTitle, Title),
            MetaName(HtmlConstants.TwitterDescription, Description),
            LinkTag(HtmlConstants.Canonical, PrerenderConstants.BaseUrl + CanonicalRoute),
            BuildHreflangTags(Route),
            LinkTag(HtmlConstants.AppleTouchIcon, RootPrefix + HtmlConstants.IconPath),
            LinkTag(HtmlConstants.FaviconRel, RootPrefix + HtmlConstants.FaviconPath),
            HtmlConstants.HeadClose);
    }

    private static string BuildHreflangTags(string Route)
    {
        var Sb = new System.Text.StringBuilder();
        foreach (var (Code, _) in I18NConstants.AllLanguages)
        {
            Sb.Append(HtmlConstants.HreflangOpen).Append(Code)
                .Append(HtmlConstants.HreflangHref).Append(PrerenderConstants.BaseUrl)
                .Append('/').Append(Code).Append(Route).Append(HtmlConstants.HreflangClose);
        }
        Sb.Append(HtmlConstants.HreflangOpen).Append(HtmlConstants.HreflangXDefault)
            .Append(HtmlConstants.HreflangHref).Append(PrerenderConstants.BaseUrl)
            .Append('/').Append(I18NConstants.LanguageCodeEnglish).Append(Route).Append(HtmlConstants.HreflangClose);
        return Sb.ToString();
    }

    private static string BuildBodyStart(string Route, string LanguageCode, string LocalePrefix, string RootPrefix)
    {
        var Nav = LocalizeHtml(HtmlConstants.StaticNavHtml, Route, LanguageCode, LocalePrefix, RootPrefix);
        var ActiveHref = Route.Length <= 1
            ? string.Concat(HtmlConstants.HrefOpen, LocalePrefix, HtmlConstants.DotSlash, HtmlConstants.HrefClose)
            : string.Concat(HtmlConstants.HrefOpen, LocalePrefix, Route.TrimStart('/'), HtmlConstants.HrefClose);
        Nav = Nav.Replace(ActiveHref, string.Concat(ActiveHref, HtmlConstants.ActiveAttr));
        return string.Concat(HtmlConstants.BodyOpen, HtmlConstants.AppDivOpen, Nav);
    }

    private static string BuildBodyEnd(string Route, string LanguageCode, string LocalePrefix, string RootPrefix)
    {
        var Footer = LocalizeHtml(HtmlConstants.StaticFooterHtml, Route, LanguageCode, LocalePrefix, RootPrefix);
        var ActiveHref = Route.Length <= 1
            ? string.Concat(HtmlConstants.HrefOpen, LocalePrefix, HtmlConstants.DotSlash, HtmlConstants.HrefClose)
            : string.Concat(HtmlConstants.HrefOpen, LocalePrefix, Route.TrimStart('/'), HtmlConstants.HrefClose);
        Footer = Footer.Replace(ActiveHref, string.Concat(ActiveHref, HtmlConstants.ActiveAttr));
        return string.Concat(Footer, HtmlConstants.AppDivClose, HtmlConstants.BodyClose);
    }

    private static string LocalizeHtml(string Html, string Route, string LanguageCode, string LocalePrefix, string RootPrefix)
    {
        var Result = Html;
        if (LanguageCode != I18NConstants.LanguageCodeEnglish)
        {
            var CurrentLocaleSlash = string.Concat(HtmlConstants.Slash, LanguageCode, HtmlConstants.Slash);
            Result = Result.Replace(HtmlConstants.EnLocaleSlash, CurrentLocaleSlash);
        }
        Result = Result
            .Replace(
                string.Concat(HtmlConstants.HrefOpen, HtmlConstants.DotSlash, HtmlConstants.HrefClose),
                string.Concat(HtmlConstants.HrefOpen, LocalePrefix, HtmlConstants.DotSlash, HtmlConstants.HrefClose));
        foreach (var Href in PageLinkHrefs)
        {
            Result = Result
                .Replace(
                    string.Concat(HtmlConstants.HrefOpen, Href, HtmlConstants.HrefClose),
                    string.Concat(HtmlConstants.HrefOpen, LocalePrefix, Href, HtmlConstants.HrefClose))
                .Replace(
                    string.Concat(HtmlConstants.HrefOpen, Href, HtmlConstants.HashPrefix),
                    string.Concat(HtmlConstants.HrefOpen, LocalePrefix, Href, HtmlConstants.HashPrefix));
        }
        Result = Result.Replace(
            string.Concat(HtmlConstants.LangSummaryOpen, I18NConstants.LanguageCodeEnglishUpper, HtmlConstants.LangSummaryClose),
            string.Concat(HtmlConstants.LangSummaryOpen,
                LanguageCode.ToUpperInvariant(), HtmlConstants.LangSummaryClose));

        var RouteSegment = Route == PrerenderConstants.RouteHome ? string.Empty : Route.TrimStart('/');
        foreach (var (Code, _) in I18NConstants.AllLanguages)
        {
            var LangHref = RouteSegment.Length > 0
                ? string.Concat(RootPrefix, Code, HtmlConstants.Slash, RouteSegment, HtmlExt)
                : string.Concat(RootPrefix, Code, HtmlConstants.Slash);
            var LangActive = Code == LanguageCode ? HtmlConstants.ActiveAttr : string.Empty;
            Result = Result.Replace(
                string.Concat(HtmlConstants.HrefOpen, HtmlConstants.LangQueryPrefix, Code, HtmlConstants.HrefClose),
                string.Concat(HtmlConstants.HrefOpen, LangHref, HtmlConstants.HrefClose, LangActive));
        }

        if (LanguageCode != I18NConstants.LanguageCodeEnglish &&
            I18NConstants.NavLabels.TryGetValue(LanguageCode, out var LocalizedLabels))
        {
            var EnLabels = I18NConstants.NavLabels[I18NConstants.LanguageCodeEnglish];
            for (var I = 0; I < EnLabels.Length; I++)
            {
                Result = Result
                    .Replace(
                        $"\">{EnLabels[I]} &#9662;</label>",
                        $"\">{LocalizedLabels[I]} &#9662;</label>")
                    .Replace(
                        $"\">{EnLabels[I]}</label>",
                        $"\">{LocalizedLabels[I]}</label>")
                    .Replace(
                        $"\"> {EnLabels[I]}</label>",
                        $"\"> {LocalizedLabels[I]}</label>")
                    .Replace(
                        $"checked> {EnLabels[I]}</label>",
                        $"checked> {LocalizedLabels[I]}</label>");
            }
        }

        if (LanguageCode != I18NConstants.LanguageCodeEnglish &&
            I18NConstants.NavLinkLabels.TryGetValue(LanguageCode, out var LocalizedLinkLabels))
        {
            var EnLinkLabels = I18NConstants.NavLinkEnglish;
            for (var I = 0; I < EnLinkLabels.Length; I++)
            {
                if (EnLinkLabels[I] != LocalizedLinkLabels[I])
                {
                    Result = Result.Replace(
                        $">{EnLinkLabels[I]}</a>",
                        $">{LocalizedLinkLabels[I]}</a>");
                }
            }
        }

        if (LanguageCode != I18NConstants.LanguageCodeEnglish &&
            I18NConstants.FooterCopyrightTexts.TryGetValue(LanguageCode, out var LocalizedCopyright))
        {
            Result = Result.Replace(
                I18NConstants.FooterCopyrightEnglish,
                LocalizedCopyright);
        }

        if (LanguageCode != I18NConstants.LanguageCodeEnglish &&
            I18NConstants.LocalizedHtmlStrings.TryGetValue(LanguageCode, out var HtmlReplacements))
        {
            foreach (var (From, To) in HtmlReplacements)
            {
                Result = Result.Replace(">" + From + "<", ">" + To + "<");
            }
        }

        if (LanguageCode != I18NConstants.LanguageCodeEnglish &&
            I18NConstants.LocalizedBrandNames.TryGetValue(LanguageCode, out var LocalizedBrand))
        {
            Result = Result.Replace(
                string.Concat(HtmlConstants.NavBrandOpen, I18NConstants.BrandNameEnglish, HtmlConstants.NavBrandClose),
                string.Concat(HtmlConstants.NavBrandOpen, LocalizedBrand, HtmlConstants.NavBrandClose));
        }

        return Result;
    }

    private static string MetaName(string Name, string Content)
    {
        return string.Concat(HtmlConstants.MetaNameOpen, Name, HtmlConstants.ContentEquals, Content, HtmlConstants.TagClose);
    }

    private static string MetaProperty(string Property, string Content)
    {
        return string.Concat(HtmlConstants.MetaPropertyOpen, Property, HtmlConstants.ContentEquals, Content, HtmlConstants.TagClose);
    }

    private static string TitleTag(string Title)
    {
        return string.Concat(HtmlConstants.TitleOpen, Title, HtmlConstants.TitleClose);
    }

    private static string LinkTag(string Rel, string Href)
    {
        return string.Concat(HtmlConstants.LinkRelOpen, Rel, HtmlConstants.HrefEquals, Href, HtmlConstants.TagClose);
    }

    private static string LinkStylesheet(string Href)
    {
        return string.Concat(HtmlConstants.LinkStylesheetOpen, Href, HtmlConstants.TagClose);
    }
}
