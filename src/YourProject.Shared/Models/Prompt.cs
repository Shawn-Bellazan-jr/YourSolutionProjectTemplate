using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourProject.Shared.Models
{
    public abstract class Prompt
    {
        public abstract string GetPrompt();
    }

    public sealed class ProgressCheckPrompt : Prompt
    {
        public override string GetPrompt() => "Where am I in the current project, and what’s next?";
    }

    public sealed class MotivationRequestPrompt : Prompt
    {
        public override string GetPrompt() => "Remind me why this project is important.";
    }

    public sealed class TemplateCodeReuseReminderPrompt : Prompt
    {
        public override string GetPrompt() => "Do I have anything in my repo that I can reuse here?";
    }

    public sealed class QuickStartPrompt : Prompt
    {
        public override string GetPrompt() => "Give me a quick step to get going on the next task.";
    }
}
