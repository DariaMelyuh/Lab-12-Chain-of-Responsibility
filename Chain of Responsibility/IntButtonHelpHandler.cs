namespace Chain_of_Responsibility
{
    public class IntButtonHelpHandler : ButtonHelpHandler
    {
        public IntButtonHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }

        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return char.IsDigit(helpRequest.Symbol);
        }

        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return $"Это кнопка для цифры '{helpRequest.Symbol}'";
        }

        protected override string BuildDefaultHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }
            return $"Вы нажимаете на числовую кнопку";
        }
    }
}
