namespace Chain_of_Responsibility
{
    public class ApplicationHelpHandler : HelpHandler
    {
        public ApplicationHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }

        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return true;
        }

        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return $"Неверное действие!";
        }

        protected override string BuildDefaultHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return $"Добро пожаловать в Калькулятор!";
        }
    }
}
