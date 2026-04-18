"""Split ArchitectureTests.ClaudeMd.cs into multiple files under 300 lines each."""
import re, os

INPUT = 'tests/PrTask.E2E/ArchitectureTests.ClaudeMd.cs'
MAX_LINES = 295  # Leave margin

with open(INPUT, 'r', encoding='utf-8') as f:
    content = f.read()

# Find all [TestMethod positions
test_positions = [m.start() for m in re.finditer(r'\[TestMethod', content)]
print(f"Found {len(test_positions)} test methods")

# Extract methods (attribute block + method body)
methods = []
for idx, pos in enumerate(test_positions):
    if idx + 1 < len(test_positions):
        end = test_positions[idx + 1]
    else:
        # Find the last closing brace of the class
        end = content.rfind('}')

    method_text = content[pos:end].rstrip()
    # Remove trailing } that belongs to class
    methods.append(method_text)

# Group into chunks that fit under MAX_LINES
chunks = []
current_chunk = []
current_lines = 5  # Header lines (using, namespace, class declaration, opening brace)

for method in methods:
    method_lines = method.count('\n') + 1
    if current_lines + method_lines > MAX_LINES and current_chunk:
        chunks.append(current_chunk)
        current_chunk = [method]
        current_lines = 5 + method_lines
    else:
        current_chunk.append(method)
        current_lines += method_lines

if current_chunk:
    chunks.append(current_chunk)

print(f"Split into {len(chunks)} files")

# Determine which usings each chunk needs
def needs_using(text, using_str, keyword):
    return keyword in text

# Write output files
for i, chunk in enumerate(chunks):
    suffix = chr(ord('A') + i)  # A, B, C, D, E...
    filename = f'tests/PrTask.E2E/ArchitectureTests.ClaudeMd{suffix}.cs'

    combined = '\n'.join(chunk)

    # Determine needed usings
    usings = []
    if 'BindingFlags' in combined or 'GetProperties' in combined or 'GetCustomAttribute' in combined:
        usings.append('using System.Reflection;')
    if 'Regex' in combined:
        usings.append('using System.Text.RegularExpressions;')
    if 'AppConstants' in combined or 'RouteConstants' in combined or 'MayaConstants' in combined or 'GitHubConstants' in combined or 'BadgeConstants' in combined or 'GoogleConstants' in combined or 'AzureConstants' in combined or 'OktaConstants' in combined:
        usings.append('using PrTask.Domain.Constants;')
    if 'TaskEntity' in combined or 'PullRequestEntity' in combined or 'UserEntity' in combined or 'PaymentEntity' in combined or 'LeaderboardEntry' in combined or 'AchievementEntity' in combined or 'PullRequestStatus' in combined or 'TaskComplexity' in combined or 'PaymentType' in combined or 'PaymentStatus' in combined or 'UserRole' in combined or 'OidcUserResponse' in combined or 'GitHubUserResponse' in combined:
        usings.append('using PrTask.Domain.Models;')

    # Sort usings: System first, then others
    sys_usings = sorted([u for u in usings if u.startswith('using System')])
    other_usings = sorted([u for u in usings if not u.startswith('using System')])
    all_usings = sys_usings + other_usings

    lines = []
    lines.extend(all_usings)
    lines.append('namespace PrTask.E2E;')
    lines.append('public partial class ArchitectureTests')
    lines.append('{')
    lines.append(combined)
    lines.append('}')

    file_content = '\n'.join(lines) + '\n'
    line_count = file_content.count('\n')

    with open(filename, 'w', encoding='utf-8') as f:
        f.write(file_content)

    # Count tests in this chunk
    test_count = combined.count('[TestMethod')
    print(f"  {filename}: {line_count} lines, {test_count} tests")

# Delete original file
os.remove(INPUT)
print(f"\nDeleted {INPUT}")
