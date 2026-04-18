"""Fix ALL brace corruption by properly parsing each file with string awareness."""
import os, re

test_dir = 'tests/PrTask.E2E'

def check_braces(content):
    """Check brace balance with string awareness. Returns (balanced, details)."""
    depth = 0
    in_string = False
    escape_next = False
    for i, ch in enumerate(content):
        if escape_next:
            escape_next = False
            continue
        if ch == '\\' and in_string:
            escape_next = True
            continue
        if ch == '"':
            in_string = not in_string
            continue
        if in_string:
            continue
        if ch == '{':
            depth += 1
        elif ch == '}':
            depth -= 1
    return depth == 0, depth

def extract_methods(content):
    """Extract test methods from a C# file, properly handling string literals."""
    methods = []
    # Find all [TestMethod positions
    test_positions = [m.start() for m in re.finditer(r'\[TestMethod', content)]

    for idx, pos in enumerate(test_positions):
        # End boundary is next [TestMethod or end of class
        if idx + 1 < len(test_positions):
            end_boundary = test_positions[idx + 1]
        else:
            end_boundary = len(content)

        block = content[pos:end_boundary]

        # Find method signature
        sig_match = re.search(r'public void (\w+)\(\)', block)
        if not sig_match:
            continue

        # Find opening brace after signature
        after_sig = block[sig_match.end():]
        brace_pos = after_sig.find('{')
        if brace_pos == -1:
            continue

        body_start = sig_match.end() + brace_pos

        # Parse to find matching closing brace (string-aware)
        depth = 0
        in_str = False
        esc = False
        body_end = -1

        for i in range(body_start, len(block)):
            ch = block[i]
            if esc:
                esc = False
                continue
            if ch == '\\' and in_str:
                esc = True
                continue
            if ch == '"':
                in_str = not in_str
                continue
            if in_str:
                continue
            if ch == '{':
                depth += 1
            elif ch == '}':
                depth -= 1
                if depth == 0:
                    body_end = i + 1
                    break

        if body_end == -1:
            # Braces unbalanced - try to fix by adding missing }
            # Count what we have
            depth2 = 0
            in_str2 = False
            esc2 = False
            for i in range(body_start, len(block)):
                ch = block[i]
                if esc2:
                    esc2 = False
                    continue
                if ch == '\\' and in_str2:
                    esc2 = True
                    continue
                if ch == '"':
                    in_str2 = not in_str2
                    continue
                if in_str2:
                    continue
                if ch == '{':
                    depth2 += 1
                elif ch == '}':
                    depth2 -= 1

            # Grab everything up to end and add missing braces
            method_text = block[:len(block)].rstrip()
            # Remove trailing incomplete content (next test's attributes)
            while depth2 > 0:
                method_text += '\n    }'
                depth2 -= 1

            # Just use the attributes + signature + body with added closing braces
            attrs = block[:sig_match.start()].strip()
            sig = f"public void {sig_match.group(1)}()"
            body_raw = block[body_start:].rstrip()

            # Add missing closing braces
            bd = 0
            in_s = False
            es = False
            for ch in body_raw:
                if es:
                    es = False
                    continue
                if ch == '\\' and in_s:
                    es = True
                    continue
                if ch == '"':
                    in_s = not in_s
                    continue
                if in_s:
                    continue
                if ch == '{':
                    bd += 1
                elif ch == '}':
                    bd -= 1

            while bd > 0:
                body_raw += '\n    }'
                bd -= 1

            methods.append(f"    {attrs}\n    {sig}\n    {body_raw}")
        else:
            attrs = block[:sig_match.start()].strip()
            sig = f"public void {sig_match.group(1)}()"
            body = block[body_start:body_end]
            methods.append(f"    {attrs}\n    {sig}\n    {body}")

    return methods

fixed_count = 0
error_files = []

for fname in sorted(os.listdir(test_dir)):
    if not fname.endswith('.cs'):
        continue

    path = os.path.join(test_dir, fname)
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    if '[TestMethod' not in content:
        # Check brace balance anyway
        balanced, depth = check_braces(content)
        if not balanced:
            error_files.append((fname, f"No tests but unbalanced by {depth}"))
        continue

    balanced, depth = check_braces(content)
    if balanced:
        continue  # File is fine

    print(f"Fixing {fname} (brace imbalance: {depth})")

    # Extract header
    first_test = content.find('[TestMethod')
    header = content[:first_test].rstrip()

    # Extract methods
    methods = extract_methods(content)

    if not methods:
        error_files.append((fname, "Could not extract methods"))
        continue

    # Rebuild
    new_content = header + '\n'
    for m in methods:
        new_content += m + '\n'
    new_content += '}\n'

    # Verify the new content is balanced
    new_balanced, new_depth = check_braces(new_content)
    if not new_balanced:
        error_files.append((fname, f"Still unbalanced after fix: {new_depth}"))
        # Write anyway, it's likely better

    with open(path, 'w', encoding='utf-8') as f:
        f.write(new_content)

    test_count = new_content.count('[TestMethod')
    print(f"  -> {test_count} tests, balanced: {new_balanced}")
    fixed_count += 1

print(f"\nFixed: {fixed_count} files")
if error_files:
    print("Remaining issues:")
    for fname, issue in error_files:
        print(f"  {fname}: {issue}")
