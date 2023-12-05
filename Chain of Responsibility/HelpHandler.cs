namespace Chain_of_Responsibility
{
    public abstract class HelpHandler
    {
        protected HelpHandler? _helpHandler;

        public HelpHandler(HelpHandler helpHandler)
        {
            _helpHandler = helpHandler;
        }

        public virtual string HandleHelp(HelpRequest helpRequest)
        {
            if (helpRequest == null) { throw new ArgumentNullException(nameof(helpRequest), "Пустое значение!"); }

            if (IsSupportRequest(helpRequest))
            {
                return BuildHelpString(helpRequest);
            }

            if (_helpHandler != null)
            {
                return _helpHandler.HandleHelp(helpRequest);
            }

            return BuildDefaultHelpString(helpRequest);
        }

        protected abstract bool IsSupportRequest(HelpRequest helpRequest);
        protected abstract string BuildHelpString(HelpRequest helpRequest);
        protected abstract string BuildDefaultHelpString(HelpRequest helpRequest);
    }
}
