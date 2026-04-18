#:package DocumentFormat.OpenXml@3.2.0
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

var OutputPath = args.Length > 0 ? args[0] : @"C:\Users\user1\Downloads\Pre_interview_questionnaire.docx";
using (var Doc = WordprocessingDocument.Create(OutputPath, WordprocessingDocumentType.Document))
{
    var MainPart = Doc.AddMainDocumentPart();
    MainPart.Document = new Document();
    var Body = MainPart.Document.AppendChild(new Body());

    var StylePart = MainPart.AddNewPart<StyleDefinitionsPart>();
    var Styles = new Styles();
    foreach (var (Id, Name, Size, Clr, Before, After) in new[] {
        ("Heading1", "heading 1", "32", "1a1a2e", "240", "120"),
        ("Heading2", "heading 2", "26", "16213e", "200", "80"),
        ("Heading3", "heading 3", "22", "0f3460", "160", "60") })
    {
        var S = new Style { Type = StyleValues.Paragraph, StyleId = Id };
        S.Append(new StyleName { Val = Name });
        S.Append(new StyleRunProperties(new Bold(), new FontSize { Val = Size }, new Color { Val = Clr }));
        S.Append(new StyleParagraphProperties(new SpacingBetweenLines { After = After, Before = Before }));
        Styles.Append(S);
    }
    StylePart.Styles = Styles;

    void H(string Text, string Level) { var P = Body.AppendChild(new Paragraph()); P.ParagraphProperties = new ParagraphProperties(new ParagraphStyleId { Val = Level }); P.AppendChild(new Run(new Text(Text))); }
    void P(string Text, bool Bold = false) { var Par = Body.AppendChild(new Paragraph()); Par.ParagraphProperties = new ParagraphProperties(new SpacingBetweenLines { After = "80", Line = "276", LineRule = LineSpacingRuleValues.Auto }); var R = Par.AppendChild(new Run()); R.RunProperties = Bold ? new RunProperties(new Bold(), new RunFonts { Ascii = "Calibri", HighAnsi = "Calibri" }, new FontSize { Val = "21" }) : new RunProperties(new RunFonts { Ascii = "Calibri", HighAnsi = "Calibri" }, new FontSize { Val = "21" }); R.AppendChild(new Text(Text) { Space = SpaceProcessingModeValues.Preserve }); }
    void B(string Text) { var Par = Body.AppendChild(new Paragraph()); Par.ParagraphProperties = new ParagraphProperties(new SpacingBetweenLines { After = "40", Line = "276", LineRule = LineSpacingRuleValues.Auto }, new Indentation { Left = "360" }); var R = Par.AppendChild(new Run()); R.RunProperties = new RunProperties(new RunFonts { Ascii = "Calibri", HighAnsi = "Calibri" }, new FontSize { Val = "21" }); R.AppendChild(new Text("\u2022 " + Text) { Space = SpaceProcessingModeValues.Preserve }); }
    void Blank() { Body.AppendChild(new Paragraph(new ParagraphProperties(new SpacingBetweenLines { After = "40" }))); }

    H("Agentic AI Labor Platform \u2014 Pre-Interview Technical Questionnaire", "Heading1");
    P("From: Lauro Cruz III (noahblesse@gmail.com)", true);
    Blank();

    H("SECTION 1 \u2014 VISION & PRODUCT THINKING", "Heading2");

    H("Q1: Chatbot vs. Agentic AI System", "Heading3");
    P("A chatbot is reactive \u2014 it waits for input, responds, and stops. No goals, no memory of what to do next, no ability to act in external systems. On a hiring platform, a chatbot answers \"What warehouse jobs are open near me?\" and returns a list. Conversation over.");
    P("An agentic system has goals, plans, acts, observes results, and iterates \u2014 autonomously between user interactions. On the same platform, it monitors new postings hourly, compares against the worker's profile and salary floor, drafts personalized outreach to matching employers, schedules interviews, and follows up if no response within 48 hours \u2014 all without the worker opening the app.");
    P("The core difference is the loop. Chatbot: input \u2192 output. Agent: goal \u2192 plan \u2192 act \u2192 observe \u2192 revise \u2192 act again.");
    P("I built this pattern in PrTask (prtask.com). When a developer's profile matches a new task, the system scores complexity and surfaces it. When a PR is approved, payment fires automatically \u2014 no \"pay me\" button. The system acts on the event.");

    H("Q2: First 5 Minutes of the Personal Career Agent", "Heading3");
    P("0:00\u20130:30 \u2014 Warm start, not a form. The agent greets by name (from SSO) and asks one open question: \"What kind of work do you do?\"");
    P("0:30\u20131:30 \u2014 Conversational profiling. 3\u20134 targeted questions:");
    B("\"What's your most recent role?\" \u2192 extracts title, industry, recency");
    B("\"Do you drive? What license?\" \u2192 CDL, forklift cert, hazmat (logistics-specific)");
    B("\"What shift works for you?\" \u2192 schedule constraints");
    B("\"Minimum pay you'd accept?\" \u2192 salary floor for matching");
    P("Each answer processed by Claude with a structured extraction prompt \u2014 entities extracted into typed JSON.");
    P("1:30\u20133:00 \u2014 Background inference while chatting: experience level from title + years, geocode location for commute radius, cross-reference certs against active jobs, build embedding vector for semantic matching.");
    P("3:00\u20134:00 \u2014 First value delivery: \"I found 3 jobs within 15 miles. Top one: [Company], [Role], [$Pay/hr], [Shift]. Want me to apply?\" Deliver a relevant match in under 4 minutes or lose the worker.");
    P("4:00\u20135:00 \u2014 Autonomy setup: \"I can watch for new jobs and apply on your behalf \u2014 you'd just confirm. What level of autonomy do you want?\" Explicit consent for agentic behavior.");

    H("Q3: 6 Weeks to Fundable \u2014 Build vs. Skip", "Heading3");
    P("Build:", true);
    B("Weeks 1\u20132: Career agent conversation loop. Worker talks to agent, profile built via Claude, matches surfaced from seeded DB of 200+ logistics jobs.");
    B("Weeks 3\u20134: \"Apply for me\" action. Agent drafts outreach, worker confirms, application sent. The agentic moment investors need to see.");
    B("Week 5: Employer dashboard \u2014 ranked inbox with match reasoning.");
    B("Week 6: Polish, demo script, analytics dashboard.");
    P("Deliberately leave out:", true);
    B("Payment processing, mobile app, real ATS integrations, multi-language, production infra, background scheduling, compliance \u2014 document the plan, don't build it");

    H("SECTION 2 \u2014 TECHNICAL APPROACH", "Heading2");

    H("Q4: Architecture", "Heading3");
    P("Frontend: Next.js + Vercel AI SDK (built-in Claude streaming + tool calls). WebSocket for real-time. Production: Blazor WASM for offline-first (what I use for PrTask).");
    P("Agent Orchestrator: Conversation state machine. Calls Claude with context injection. Executes tool calls (search_jobs, apply_to_job, update_profile). Claude decides which tool, orchestrator executes, feeds result back.");
    P("Claude API: Tool use with typed params. Sonnet for 80% of calls (speed), Opus for complex reasoning.");
    P("State & Memory: Supabase (Postgres) for profiles/jobs/applications. Redis for session state. Conversation history summarized at session end (50 tokens vs 2,000 raw). pgvector for semantic matching.");
    P("In PrTask I built: Cloudflare Workers (D1+KV+R2), WebSocket gatekeeper with 232+ message types, USearch vector search (native C++ with .NET P/Invoke I wrote), Automerge CRDTs for offline sync.");

    H("Q5: Claude Code vs. Lovable", "Heading3");
    P("I use Claude Code daily \u2014 PrTask (30+ projects, 200+ files, clean architecture) was built almost entirely through it.");
    P("Claude Code:", true);
    B("Architecture, backend logic, API endpoints, service layers, complex multi-file refactoring, system prompt engineering, infra-as-code, tests");
    B("Needs oversight: can over-engineer (I constrain with CLAUDE.md + 4 Roslyn analyzers); still need runtime testing");
    P("Lovable:", true);
    B("Rapid UI prototyping, component scaffolding, design consistency (Tailwind/shadcn)");
    B("Limits: complex state (WebSocket, offline sync), backend logic, auth flows");
    P("Combined: Lovable for first-draft UI \u2192 Claude Code for logic/API/streaming \u2192 hand-written for security-critical code and edge cases.");

    H("Q6: Fast UX with Slow AI Calls", "Heading3");
    B("Streaming: Claude's streaming API, first token in ~200ms. User sees typing immediately. SSE or WebSocket.");
    B("Optimistic UI: Message renders instantly, typing indicator, \"Apply\" shows success before API returns.");
    B("Skeleton loaders + progressive rendering: Cards appear individually as matches arrive.");
    B("Background pre-fetch: While user reads response, fetch details of all mentioned jobs. Click \u2192 instant.");
    B("Cached common patterns: Onboarding greeting cached. Job details cached aggressively.");
    B("Parallel tool execution: Multiple tools run simultaneously. 6s \u2192 3s.");
    B("Edge compute: Cloudflare Workers for sub-100ms orchestration. Only latency = Claude call.");

    H("Q7: System Prompt Structure", "Heading3");
    P("Key sections:");
    B("Role: \"You are CareerAgent. You help workers find jobs and take action proactively.\"");
    B("Structured worker profile: Name, location, certs, experience, pay floor \u2014 typed fields, not conversation replay.");
    B("Previous session summary: Claude-generated 3-bullet summary (~50 tokens, not 2,000 raw).");
    B("Pending actions: Jobs applied to, responses waiting, reminders.");
    B("Tool definitions: search_jobs(criteria), apply_to_job(job_id, message), update_profile(fields).");
    P("Anti-hallucination (critical):", true);
    B("\"NEVER invent job details. Every job MUST come from search_jobs tool call.\"");
    B("\"NEVER fabricate salary/company/requirements. Only quote tool results.\"");
    B("\"Before any action, show plan and ask confirmation.\"");
    P("Tool-first = verifiable: Claude calls search_jobs, orchestrator runs real DB query, Claude narrates real results.");

    H("SECTION 3 \u2014 SPEED, SCALABILITY & FUNDRAISING", "Heading2");

    H("Q8: 3-Week VC Demo Plan", "Heading3");
    P("Week 1:", true); B("Supabase schema + 200 seeded jobs. Claude API + streaming. Chat UI. End-to-end: worker chats 2 min \u2192 complete profile.");
    P("Week 2:", true); B("Job matching (pgvector + hard filters). \"Apply for me\" flow. Employer dashboard with match scores. Tune system prompt.");
    P("Week 3:", true); B("Analytics page + landing page. Demo rehearsal 20+ times. Deploy to production URL \u2014 investor opens on phone during pitch.");
    P("Demo: Worker chats 3 min \u2192 matched \u2192 \"apply\" \u2192 agent handles \u2192 employer dashboard shows application. 5 min live.");
    P("Behind the scenes: 200 seeded jobs, demo employer account, embeddings+filters not ML, one Railway server, seeded analytics. All works \u2014 not production-scale yet.");

    H("Q9: Biggest Technical Risk", "Heading3");
    P("Cost-per-interaction at scale.", true);
    P("3\u20135 Claude calls per session \u2248 $0.15\u20130.30. At 10K daily workers = $45K\u201390K/month before revenue.");
    P("Mitigation:", true);
    B("Sonnet for 80% of calls (~5x cheaper). Opus only for complex reasoning.");
    B("Prompt caching \u2014 repeated system prompt costs drop 90%.");
    B("Summarize, don't replay \u2014 50-token session summaries keep input flat.");
    B("Token budget per session \u2014 graceful wrap at 4K output tokens.");
    B("Background matching via embeddings (pennies), not full Claude calls.");
    P("Second risk: Latency. Mitigate with streaming, async WebSocket, edge compute.");

    H("Q10: Something Live \u2014 prtask.com", "Heading3");
    P("Link: https://prtask.com", true);
    P("Developer marketplace \u2014 clients post tasks with payments, developers submit code, payment fires on approval. 16 languages. Full legal compliance. SSO (GitHub/Google/Azure/Okta). Maya Business payments.");
    P("Stack: .NET 10, Blazor WASM, MAUI Android, Cloudflare Workers (D1+KV+R2), Automerge CRDTs, USearch vector search, custom transpiler (Java/JS/TS/C/x86 \u2192 C#), HTML fingerprinting. Zero third-party runtime packages.");
    P("Also: NativeCdpBridge \u2014 CDP bridge for native Android app automation via Playwright. Multi-channel (Telegram/Viber/SMS/Teams), Claude+Gemini agents. Voice chat AI companion live at cruzlauroiii.github.io/voicechat.");
    Blank();
    P("Proud of: Offline-first with Automerge CRDTs.", true);
    P("Entire data layer uses CRDTs. Client stores locally (IndexedDB+OPFS), syncs diffs via WebSocket, merges automatically. Wrote .NET Automerge bindings from scratch (P/Invoke). App loads instantly, works offline, scales horizontally.");
    Blank();
    P("Would change: Full multi-target transpiler.", true);
    P("Built Java/JS/TS/C/x86 \u2192 C# transpiler with APK decompilation. Works, taught me compiler design, but over-engineered. 80% value from ILSpy + thin wrappers. Weeks spent that could've gone to user features.");

    Blank();
    P("Happy to dive deeper during the interview.");
    Blank();
    P("Lauro Cruz III | noahblesse@gmail.com | prtask.com | linkedin.com/in/lauro-iii-cruz-942a152a2");
}
Console.WriteLine("Written to " + OutputPath);
