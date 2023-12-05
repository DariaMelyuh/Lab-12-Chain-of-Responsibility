namespace Chain_of_Responsibility
{
    public class ButtonHelpHandler : HelpHandler
    {
        public ButtonHelpHandler(HelpHandler helpHandler)
            : base(helpHandler) { }

        protected override bool IsSupportRequest(HelpRequest helpRequest)
        {
            if (helpRequest == null)
            {
                throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!");
            }
            return char.IsDigit(helpRequest.Symbol) || helpRequest.Symbol == '+' || helpRequest.Symbol == '-' || helpRequest.Symbol == '*' || helpRequest.Symbol == '/';
        }

        protected override string BuildHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null)
            {
                throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!");
            }
            return $"Это кнопка для символа '{helpRequest.Symbol}'";
        }
        protected override string BuildDefaultHelpString(HelpRequest helpRequest)
        {
            if (helpRequest == null)
            {
                throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!");
            }
            return $"Неверное действие!";
        }
    }
}
